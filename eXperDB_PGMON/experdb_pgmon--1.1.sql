/* contrib/get_backend_rsc/get_backend_rsc--1.1.sql */

-- complain if script is sourced in psql, rather than via CREATE EXTENSION
\echo Use "CREATE EXTENSION experdb_pgmon" to load this file. \quit

-- Register functions.
CREATE TYPE utype_get_backend_rsc AS
(
        proc_id         int,
        cpu_utime       numeric,
        cpu_stime       numeric,
        disk_read       numeric,
        disk_write      numeric,
	sec_from_epoch   numeric
);

CREATE OR REPLACE FUNCTION get_backend_rsc()
    RETURNS SETOF utype_get_backend_rsc
    AS 'MODULE_PATHNAME' , 'v1c_get_backend_rsc'
    LANGUAGE C IMMUTABLE STRICT;

-- Register a view on the function for ease of use.
CREATE VIEW get_backend_rsc AS
  SELECT * FROM get_backend_rsc();

GRANT SELECT ON get_backend_rsc TO PUBLIC;

-- Register functions.

CREATE TYPE utype_get_stat_cpu_cores AS 
(
        cpu_name          varchar(100),
        cpu_agg_user      numeric,
        cpu_agg_nice      numeric,
        cpu_agg_sys       numeric,
        cpu_agg_idle      numeric,
        cpu_agg_wait      numeric,
        seq               int
);

--DROP FUNCTION get_stat_cpu_cores();

CREATE OR REPLACE FUNCTION get_stat_cpu_cores()
    RETURNS SETOF utype_get_stat_cpu_cores
    AS 'MODULE_PATHNAME', 'v1c_get_stat_cpu_cores'
    LANGUAGE C IMMUTABLE STRICT;

-- Register a view on the function for ease of use.
CREATE VIEW get_stat_cpu_cores AS
  SELECT * FROM get_stat_cpu_cores();

GRANT SELECT ON get_stat_cpu_cores TO PUBLIC;

-- Register functions.
CREATE TYPE utype_get_stat_disk_io AS
(
        disk_name varchar(100),
        rd_agg_comp_cnt    numeric,
        rd_agg_merge_cnt   numeric,
        rd_agg_sectors     numeric,
        rd_agg_millisec    numeric,
        wr_agg_comp_cnt   numeric,
        wr_agg_merge_cnt  numeric,
        wr_agg_sectors    numeric, -- write sector not I/O
        --wr_agg_millisec   numeric, 
        io_agg_millisec   numeric, 
        sec_from_epoch   numeric, 
        seq int,
        mountpoint varchar(100)
);

CREATE OR REPLACE FUNCTION get_stat_disk_io()
    RETURNS SETOF utype_get_stat_disk_io
    AS 'MODULE_PATHNAME', 'v1c_get_stat_disk_io'
    LANGUAGE C IMMUTABLE STRICT;

-- Register a view on the function for ease of use.
CREATE VIEW get_stat_disk_io AS
  SELECT * FROM get_stat_disk_io();

GRANT SELECT ON get_stat_disk_io TO PUBLIC;

CREATE TYPE utype_get_stat_mem AS
(
        mem_total_kb  numeric,
        mem_used_kb   numeric,
        mem_free_kb   numeric,
        mem_buffer_kb numeric,
        mem_cached_kb numeric,
        swp_total_kb  numeric,
        swp_used_kb   numeric,
        swp_cached_kb numeric,
        swp_free_kb   numeric,
        shm_kb        numeric
);

CREATE OR REPLACE FUNCTION get_stat_mem()
    RETURNS SETOF utype_get_stat_mem
    AS 'MODULE_PATHNAME', 'v1c_get_stat_mem'
    LANGUAGE C IMMUTABLE STRICT;

-- Register a view on the function for ease of use.
CREATE VIEW get_stat_mem AS
  SELECT * FROM get_stat_mem();

GRANT SELECT ON get_stat_mem TO PUBLIC;

-- Register functions.
CREATE OR REPLACE FUNCTION get_tbsdisk_avail(TEXT)
    RETURNS double precision 
    AS 'MODULE_PATHNAME' , 'v1c_get_tbsdisk_avail'
    LANGUAGE C IMMUTABLE STRICT;

-- Register functions.
CREATE OR REPLACE FUNCTION get_tbsdisk_total(TEXT)
    RETURNS double precision 
    AS 'MODULE_PATHNAME' , 'v1c_get_tbsdisk_total'
    LANGUAGE C IMMUTABLE STRICT;

-- Register functions.

CREATE TYPE utype_get_stat_disk_usge AS 
(
	 dev_name varchar(100)
	,mt_dir varchar(100)
	,tot_kb numeric
	,avail_kb numeric
	,used_kb numeric
	,seq int);

CREATE OR REPLACE FUNCTION get_stat_disk_usge()
    RETURNS SETOF utype_get_stat_disk_usge
    AS 'MODULE_PATHNAME', 'v1c_get_stat_disk_usge'
    LANGUAGE C IMMUTABLE STRICT;

-- Register a view on the function for ease of use.
CREATE VIEW get_stat_disk_usge AS
  SELECT * FROM get_stat_disk_usge();

GRANT SELECT ON get_stat_disk_usge TO PUBLIC;

CREATE OR REPLACE FUNCTION get_cpu_clocks()
    RETURNS INTEGER
    AS 'MODULE_PATHNAME', 'v1c_get_cpu_clocks'
    LANGUAGE C IMMUTABLE STRICT;

-- Register a view on the function for ease of use.
CREATE VIEW get_cpu_clocks AS
  SELECT * FROM get_cpu_clocks();

GRANT SELECT ON get_cpu_clocks TO PUBLIC;


CREATE OR REPLACE FUNCTION get_hostname()
    RETURNS TEXT
    AS 'MODULE_PATHNAME', 'v1c_get_hostname'
    LANGUAGE C IMMUTABLE STRICT;

CREATE VIEW get_hostname AS
  SELECT * FROM get_hostname();

