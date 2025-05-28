/* contrib/get_backend_rsc/get_backend_rsc--1.0--1.1.sql */

-- complain if script is sourced in psql, rather than via ALTER EXTENSION
\echo Use "ALTER EXTENSION experdb_pgmon UPDATE TO '1.1'" to load this file. \quit

DROP VIEW get_stat_disk_io;
DROP FUNCTION get_stat_disk_io();
DROP TYPE utype_get_stat_disk_io;

CREATE TYPE utype_get_stat_disk_io AS (
    disk_name         varchar(100),
    rd_agg_comp_cnt   numeric,
    rd_agg_merge_cnt  numeric,
    rd_agg_sectors    numeric,
    rd_agg_millisec   numeric,
    wr_agg_comp_cnt   numeric,
    wr_agg_merge_cnt  numeric,
    wr_agg_sectors    numeric,
    io_agg_millisec   numeric,
    sec_from_epoch    numeric,
    seq               int,
    mountpoint        varchar(100)
);

CREATE OR REPLACE FUNCTION get_stat_disk_io()
    RETURNS SETOF utype_get_stat_disk_io
    AS 'MODULE_PATHNAME', 'v1c_get_stat_disk_io'
    LANGUAGE C IMMUTABLE STRICT;

CREATE VIEW get_stat_disk_io AS
    SELECT * FROM get_stat_disk_io();

GRANT SELECT ON get_stat_disk_io TO PUBLIC;


