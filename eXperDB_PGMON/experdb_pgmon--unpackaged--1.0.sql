/* contrib/get_backend_rsc/get_backend_rsc--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_backend_rsc();
/* contrib/get_stat_cpu_cores/get_stat_cpu_cores--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_stat_cpu_cores();
/* contrib/get_stat_disk_io/get_stat_disk_io--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_stat_disk_io();
/* contrib/get_stat_mem/get_stat_mem--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_stat_mem();
/* contrib/get_backend_rsc/get_backend_rsc--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_tbsdisk_avail(TEXT);
/* contrib/get_backend_rsc/get_backend_rsc--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_tbsdisk_total(TEXT);
/* contrib/get_stat_disk_usge/get_stat_disk_usge--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_stat_disk_usge();
/* contrib/get_cpu_clocks/get_cpu_clocks--unpackaged--1.0.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION eXperdb_pgmon" to load this file. \quit

ALTER EXTENSION eXperdb_pgmon ADD function get_cpu_clocks();
ALTER EXTENSION eXperdb_pgmon ADD function get_hostname();
