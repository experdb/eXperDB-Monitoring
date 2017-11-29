#!/bin/sh
#-------------------------------------------------------------------------------
#
# Script used to install eXperDB monitoring Repository database for postgresql
#
#-------------------------------------------------------------------------------
DB_ENCODING="UTF8"
DB_SCHEMA="pgmon"
DB_NAME="pgmon"
DB_OWNER="pgmon"
CONN_DB_NAME=""
ORG_DB_HOST=""
AGENT_HOST=""
AGENT_PORT="5960"
DEBUG=0
AUTORUN=0
LICENSE_FILE=./license.dat
LICENSE_STR=

#install logo
		PRINT_LOGO() {
			echo "   "
			echo "   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
			echo "   ▒                                                                   ▒"
			echo "   ▒          X      X                             DDDDDD     BBBBBBB  ▒"  
			echo "   ▒           X    X                              D     D    B      B ▒"  
			echo "   ▒  eeee      X  X     ppppp    eeee     r   r   D      D   B      B ▒"  
			echo "   ▒ e    e      X       p    p  e    e    r r     D      D   BBBBBBB  ▒"  
			echo "   ▒ eeeeee     X  X     p ppp   eeeeee    rr      D      D   B      B ▒"  
			echo "   ▒ e         X    X    p       e         r       D     D    B      B ▒"  
			echo "   ▒  eeee    X      X   p        eeee    rrr      DDDDDD     BBBBBBB  ▒"  
			echo "   ▒                                                                   ▒"
			echo "   ▒       SSSSS                                                       ▒"
			echo "   ▒      S     S                                                      ▒"
			echo "   ▒      S         eeee   r   r  v       v   eeee    r   r            ▒"
			echo "   ▒       SSSSS   e    e  r r     v     v   e    e   r r              ▒"
			echo "   ▒            S  eeeeee  rr       v   v    eeeeee   rr               ▒"
			echo "   ▒      S     S  e       r         v v     e        r                ▒"
			echo "   ▒       SSSSS    eeee  rrr         v       eeee   rrr               ▒"
			echo "   ▒                                                                   ▒"
			echo "   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
			echo "   "
			echo "Install eXperDB-PGMON Repository"
		}
		
# Message functions
die() {
    echo "ERROR: $1" 1>&2
    exit 1
}

usage() {
    echo "usage: `basename $0` [options]"
    echo ""
    echo "Script used to install eXperDB monitoring Repository database for postgresql"
    echo ""
    echo "options:"
	echo "    -h hostname    hostname of the PostgreSQL server"
	echo "    -p port        listening port of the PostgreSQL server"
	echo "    -d dbname      database name of the PostgreSQL server to connect"
	echo "    -U username    username to connect to PostgreSQL"
    echo "    -D             enable debug mode, will only show what will be done"	
    echo "    -y             reply Yes to all questions for automatic import"	
    echo "    -?             print help"
    echo
    exit $1
}

# Function to emulate Perl prompt function
confirm () {

    msg=$1
    if [ "$AUTORUN" != "0" ]; then
        true
    else
            if [ -z "$msg" ]; then
                msg="Are you sure? [y/N/q]"
            fi
            # call with a prompt string or use a default
            read -r -p "${msg} [y/N/q] " response
            case $response in
                [yY][eE][sS]|[yY]) 
                    true
                    ;;
                [qQ][uU][iI][tT]|[qQ]) 
                    exit
                    ;;
                *)
                    false
                    ;;
            esac
    fi
}

PRINT_LOGO

# Command line options
options_found=0
if (($# == 0)); then
        usage $1;
fi

while getopts "d:h:U:p:L:Dy?"  opt; do
	options_found=1
    case "$opt" in
        h) DB_HOST=" -h $OPTARG"
		   ORG_DB_HOST="$OPTARG"
			;;
        U) DB_USER=" -U $OPTARG";;
        p) DB_PORT=" -p $OPTARG";;	
		d) CONN_DB_NAME=" -d $OPTARG";;	
		L) LICENSE_FILE=" -d $OPTARG";;	
        D) DEBUG=1;;	
        y) AUTORUN=1;;		
        "?") usage 1;;
        *) die "Unknown error while processing options";;
    esac
done

# A connect database user is mandatory
if [ -z "$DB_USER" ]; then
        die "you must give a username to be used as connect to PostgreSQL database (see option)."
fi

# A database hostname is mandatory
if [ -z "$DB_HOST" ]; then
        die "you must give a hostname of the PostgreSQL server to be used as connect to PostgreSQL database (see option)."
fi

# A database port is mandatory
if [ -z "$DB_PORT" ]; then
        die "you must give a port of the PostgreSQL server to be used as connect to PostgreSQL database (see option)."
fi

# A database name is mandatory
if [ -z "$CONN_DB_NAME" ]; then
        die "you must give the name of the PostgreSQL server to be used as connect to PostgreSQL database (see option)."
fi

# Create owner user
user_exists=`psql$DB_HOST$DB_PORT$DB_USER$CONN_DB_NAME -Atc "select usename from pg_user where usename='$DB_OWNER';"`
if [ "a$user_exists" = "a" ]; then
        if confirm "Would you like to create the owner of the database $DB_OWNER?" ; then
                echo "Running: createuser$DB_HOST$DB_PORT$DB_USER --no-superuser --no-createrole --no-createdb -P $DB_OWNER"
                if [ $DEBUG -eq 0 ]; then
                        createuser$DB_HOST$DB_PORT$DB_USER -W --no-superuser --no-createrole --no-createdb -P $DB_OWNER
                        if [ $? -ne 0 ]; then
                                die "can not create user $DB_OWNER."
                        fi
                fi
		else
			die "you must create user $DB_OWNER."
        fi
else
        echo "Database owner $DB_OWNER already exists, skipping creation."
fi

DB_ENCODING=`psql$DB_HOST$DB_PORT$DB_USER$CONN_DB_NAME -Atc "select ' -E ' || pg_encoding_to_char(encoding) || ' --lc-collate=' || datcollate || ' --lc-ctype=' || datctype from pg_database where datname like 'template%' and datallowconn='t';;"`
db_exists=`psql$DB_HOST$DB_PORT$DB_USER$CONN_DB_NAME -Atc "select datname from pg_database where datname='$DB_NAME';"`
if [ "a$db_exists" = "a" ]; then
        if confirm "Would you like to create the database $DB_NAME?" ; then
                echo "Running: createdb$DB_HOST$DB_PORT$DB_USER$DB_ENCODING --owner $DB_OWNER $DB_NAME"
                if [ $DEBUG -eq 0 ]; then
                        createdb$DB_HOST$DB_PORT$DB_USER$DB_ENCODING --owner $DB_OWNER $DB_NAME
                        if [ $? -ne 0 ]; then
                                die "can not create database $DB_NAME."
                        fi
                fi
		else
			die "you must create database $DB_NAME."				
        fi
else
        if confirm "Would you like to drop the database $DB_NAME before recreate it?" ; then
                echo "Running: dropdb$DB_HOST$DB_PORT$DB_USER $DB_NAME"
                if [ $DEBUG -eq 0 ]; then
                        dropdb$DB_HOST$DB_PORT$DB_USER $DB_NAME
                        if [ $? -ne 0 ]; then
                                die "can not drop database $DB_NAME."
                        fi
                fi
                echo "Running: createdb$DB_HOST$DB_PORT$DB_USER$DB_ENCODING --owner $DB_OWNER $DB_NAME"
                if [ $DEBUG -eq 0 ]; then
                        createdb$DB_HOST$DB_PORT$DB_USER$DB_ENCODING --owner $DB_OWNER $DB_NAME
                        if [ $? -ne 0 ]; then
                                die "can not create database $DB_NAME."
                        fi
                fi
        fi
fi

schema_exists=`psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -Atc "select nspname from pg_namespace where nspname='$DB_SCHEMA';"`
echo "Running: psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -c \"CREATE SCHEMA $DB_SCHEMA;\""
if [ "a$schema_exists" = "a" ]; then
		if confirm "Would you like to create schema $DB_SCHEMA in database $DB_NAME?" ; then
				if [ $DEBUG -eq 0 ]; then
						psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -c "CREATE SCHEMA $DB_SCHEMA;"
						if [ $? -ne 0 ]; then
								die "can not create schema $DB_SCHEMA."
						fi
				fi
		else
			die "you must create schema $DB_SCHEMA."					
		fi
#else
#		if confirm "Would you like to drop schema $DB_SCHEMA in database $DB_NAME before recreate it?" ; then
#				if [ $DEBUG -eq 0 ]; then
#						psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -c "DROP SCHEMA $DB_SCHEMA;"
#						if [ $? -ne 0 ]; then
#								die "can not drop schema $DB_SCHEMA."
#						fi
#						
#						psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -c "CREATE SCHEMA $DB_SCHEMA;"
#						if [ $? -ne 0 ]; then
#								die "can not create schema $DB_SCHEMA."
#						fi
#				fi
#		fi
fi

if [ -r "./pgmon_repository.sql" ]; then
	    echo "Running: psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -f ./pgmon_repository.sql"
		
		if [ ! -f $LICENSE_FILE ]; then
			echo "License is not found!!"
			exit 1
		fi
		LICENSE_STR=`head -n 1 $LICENSE_FILE`
		cp ./pgmon_repository.sql ./pgmon_repository.tmp.sql
		sed -i "s|LICENSEDAT|$LICENSE_STR|g" ./pgmon_repository.tmp.sql

        if [ $DEBUG -eq 0 ]; then
                psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -f ./pgmon_repository.tmp.sql
                if [ $? -ne 0 ]; then
                        die "can not import repository data."
                fi
        fi
		rm -f ./pgmon_repository.tmp.sql
fi

#AGENT HOST and PORT
read -r -p "Input Agent Host(Default : $ORG_DB_HOST) : " response

if [ -z "$response" ]; then
	# Default AGENT_HOST  is equaled with DB_HOST
	AGENT_HOST="$ORG_DB_HOST"
else	
	AGENT_HOST="$response"
fi

read -r -p "Input Agent Port(Default : 5960) : " response

if [ -z "$response" ]; then
	# Default AGENT_HOST  is equaled with DB_HOST
	AGENT_PORT="5960"
else
	AGENT_PORT="$response"
fi

valid_tb_config=`psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -Atc "select 't' as result from tb_config where (select count(*) as cnt from tb_config) > 1;"`
if [ "a$valid_tb_config" = "a" ]; then
	update_tb_config=`psql$DB_HOST$DB_PORT -U $DB_OWNER -d $DB_NAME -Atc "update tb_config set agent_ip = trim('$AGENT_HOST'), agent_port = trim('$AGENT_PORT') \
	                  where (select sum(case when regexp_split_to_table = '' then 0 else 1 end) from regexp_split_to_table('$AGENT_HOST', '^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$')) = 0 \
					  and (select sum(case when regexp_split_to_table = '' then 0 else 1 end) from regexp_split_to_table('$AGENT_PORT','^([0-9]{1,4}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$')) = 0;"`
	if [ "$update_tb_config" = "UPDATE 1" ]; then
		echo "Complete to install eXperDB-PGMON Repository."
	else
		if [ "$update_tb_config" = "UPDATE 0" ]; then
			die "Invalid agent host or agent port"
		else
			echo "Failure to update the agent ip and port of tb_config"
			die "$update_tb_config"
		fi		
	fi
else
	die "table(tb_config) can not have more than one row."
fi

exit 0
