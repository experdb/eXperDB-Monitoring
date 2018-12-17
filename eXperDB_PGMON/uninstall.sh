#!/bin/sh
#-------------------------------------------------------------------------------
#
# Script used to Uninstall eXperDB monitoring for postgresql extension in target db 
#
#-------------------------------------------------------------------------------

#EXPORT_TYPE="TYPE TABLE PACKAGE VIEW GRANT SEQUENCE TRIGGER FUNCTION PROCEDURE TABLESPACE PARTITION MVIEW DBLINK SYNONYM DIRECTORY"
INCLUDE_LIB_INSTALL_FILES="experdb_pgmon.so"
INCLUDE_EXT_INSTALL_FILES="experdb_pgmon--1.1.sql experdb_pgmon--unpackaged--1.1.sql experdb_pgmon.control"
INSTALL_DIRECTORIES="lib share/postgresql/extension"
PG_HOME=""
INSTALL_LIB_ONLY=0
CREATE_EXT_ONLY=0

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
			echo "Uninstall Target eXperDB-PGMON EXTENSION "
		}
		
# Message functions
die() {
    echo "ERROR: $1" 1>&2
    exit 1
}

usage() {
    echo "usage: `basename $0` [options]"
    echo ""
    echo "Script used to load exported sql files into PostgreSQL in practical manner"
    echo "allowing you to chain and automatically import schema and data."
    echo ""
    echo "options:"
    echo "    -d Directory      PostgreSQL Home Directory for Install"
	#echo "    -l             install library only"
	#echo "    -e             create extension eXperdb_pgmon only"
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

while getopts "d:le?"  opt; do
	options_found=1
    case "$opt" in
        d) PG_HOME=$OPTARG;;
		#l) INSTALL_LIB_ONLY=1;;
		#e) CREATE_EXT_ONLY=1;;
        "?") usage 1;;
        *) die "Unknown error while processing options";;
    esac
done

if ((options_found == 0)); then
        usage 1;
fi

# Check if exists PostgreSQL Home Directory
if [ ! -d "$PG_HOME" ]; then
        die "PostgreSQL Home directory '$PG_HOME' is not valid or is not readable."
fi

if [ ! -d "$PG_HOME/lib/postgresql" ]; then
        die "PostgreSQL library directory '$PG_HOME/lib/postgresql' is not valid or is not readable."
fi

if [ ! -d "$PG_HOME/share/postgresql/extension" ]; then
        die "PostgreSQL extension directory '$PG_HOME/share/postgresql/extension' is not valid or is not readable."
fi

# Check if exists eXperdb_pgmon.so and etc sql..
for file in $(echo $INCLUDE_LIB_INSTALL_FILES | tr "," "\n")
do
	if [ ! -w "$PG_HOME/lib/postgresql/$file" ]; then
        die "eXperDB install file '$PG_HOME/lib/postgresql/$file' is not valid or is not deletable."
	fi
done

for file in $(echo $INCLUDE_EXT_INSTALL_FILES | tr "," "\n")
do
	if [ ! -w "$PG_HOME/share/postgresql/extension/$file" ]; then
        die "eXperDB install file '$PG_HOME/share/postgresql/extension/$file' is not valid or is not deletable."
	fi
done

# Copy so file and SQL and control file
#if [ "$CREATE_EXT_ONLY" == 0 ]; then
	for file in $(echo $INCLUDE_LIB_INSTALL_FILES | tr "," "\n")
	do
		echo "Running: rm ./$file $PG_HOME/lib/postgresql/$file"
		rm $PG_HOME/lib/postgresql/$file
	done
	
	for file in $(echo $INCLUDE_EXT_INSTALL_FILES | tr "," "\n")
	do
		echo "Running: rm ./$file $PG_HOME/share/postgresql/extension/$file"
		rm $PG_HOME/share/postgresql/extension/$file
	done
#fi 

exit 0
