CREATE TABLE tb_access_info (
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    db_name character varying(100) NOT NULL,
    db_size_kb numeric(20,0),
    table_cnt integer,
    index_cnt integer,
    agg_heap_blks_read_kb numeric(20,0),
    agg_heap_blks_hit_kb numeric(20,0),
    agg_seq_read_tuples numeric(20,0),
    agg_idx_fetch_tuples numeric(20,0),
    agg_insert_tuples numeric(20,0),
    agg_update_tuples numeric(20,0),
    agg_delete_tuples numeric(20,0),
    agg_seq_scan_cnt numeric(20,0),
    agg_idx_scan_cnt numeric(20,0),
    agg_commit numeric(20,0),
    agg_rollback numeric(20,0),
    agg_phy_read numeric(20,0),
    current_heap_blks_read_kb numeric(20,0),
    current_heap_blks_hit_kb numeric(20,0),
    current_seq_read_tuples numeric(20,0),
    current_idx_fetch_tuples numeric(20,0),
    current_insert_tuples numeric(20,0),
    current_update_tuples numeric(20,0),
    current_delete_tuples numeric(20,0),
    current_seq_scan_cnt numeric(20,0),
    current_idx_scan_cnt numeric(20,0),
    current_commit numeric(20,0),
    current_rollback numeric(20,0),
    current_phy_read numeric(20,0),
    buffer_hit_ratio numeric(5,2),
    collect_dt timestamp without time zone,
    delta_time numeric(10,3)
);


CREATE TABLE tb_actv_collect_info (
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
);


CREATE TABLE tb_backend_rsc (
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    process_id integer NOT NULL,
    db_name character varying(100),
    client_addr character varying(15),
    user_name character varying(100),
    client_app character varying(100),
    agg_proc_utime numeric(20,0),
    agg_proc_stime numeric(20,0),
    current_proc_utime numeric(20,0),
    current_proc_stime numeric(20,0),
    proc_cpu_util numeric(5,2),
    agg_proc_read_kb numeric(20,0),
    agg_proc_write_kb numeric(20,0),
    current_proc_read_kb numeric(20,0),
    current_proc_write_kb numeric(20,0),
    query_start timestamp without time zone,
    elapsed_time numeric(20,5),
    state character varying(30),
    queryid character varying(41),
    sql text,
    collect_dt timestamp without time zone
);

CREATE TABLE tb_config (
    daily_batch_start_time time without time zone,
    hchk_period_sec integer,
    objt_period_sec integer,
    stmt_period_sec integer,
    log_keep_days integer,
    admin_user_id character varying(100),
    admin_password character varying(100),
    agent_ip character varying(15),
    agent_port character varying(10),
    serial_key character varying(1000),
    version character varying(10),
    last_mod_dt timestamp without time zone,
    last_mod_ip character varying(15)
);

CREATE TABLE tb_cpu_stat_detail (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    cpu_logical_id integer NOT NULL,
    agg_user_util numeric(20,0),
    agg_nice_util numeric(20,0),
    agg_sys_util numeric(20,0),
    agg_idle_util numeric(20,0),
    agg_wait_util numeric(20,0),
    current_user_util numeric(20,0),
    current_nice_util numeric(20,0),
    current_sys_util numeric(20,0),
    current_idle_util numeric(20,0),
    current_wait_util numeric(20,0),
    user_util_rate numeric(5,2),
    nice_util_rate numeric(5,2),
    sys_util_rate numeric(5,2),
    idle_util_rate numeric(5,2),
    wait_util_rate numeric(5,2)
);

CREATE TABLE tb_cpu_stat_master (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    agg_user_util numeric(20,0),
    agg_nice_util numeric(20,0),
    agg_sys_util numeric(20,0),
    agg_idle_util numeric(20,0),
    agg_wait_util numeric(20,0),
    current_user_util numeric(20,0),
    current_nice_util numeric(20,0),
    current_sys_util numeric(20,0),
    current_idle_util numeric(20,0),
    current_wait_util numeric(20,0),
    user_util_rate numeric(5,2),
    nice_util_rate numeric(5,2),
    sys_util_rate numeric(5,2),
    idle_util_rate numeric(5,2),
    wait_util_rate numeric(5,2),
    collect_dt timestamp without time zone
);

CREATE TABLE tb_current_lock (    
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    db_name character varying(100),
    blocking_user character varying(100),
    blocking_pid integer,
    blocking_query text,
    blocked_user character varying(100),
    blocked_pid integer,
    blocked_query text,
    blocked_duration interval,
    lock_mode character varying(100),
    query_start timestamp without time zone,
    xact_start timestamp without time zone,
    order_no integer,
    collect_dt timestamp without time zone);

CREATE TABLE tb_disk_io (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    disk_name character varying(100) NOT NULL,
    agg_read_kb numeric(20,0),
    current_read_kb numeric(20,0),
    read_busy_rate numeric(5,2),
    agg_write_kb numeric(20,0),
    current_write_kb numeric(20,0),
    write_busy_rate numeric(5,2),
    agg_io_msec numeric(20,0),
    current_io_msec numeric(20,0),
    collect_dt timestamp without time zone,
    delta_time numeric(10,3),
    mountpoint character varying(100)    
);

CREATE TABLE tb_disk_usage (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    device_name character varying(100) NOT NULL,
    total_kb numeric(20,0),
    used_kb numeric(20,0),
    avail_kb numeric(20,0),
    mount_point_dir character varying(100),
    collect_dt timestamp without time zone
);

CREATE TABLE tb_hchk_collect_info (
    reg_date character varying(8) NOT NULL,
    hchk_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    hchk_name character varying(100) NOT NULL,
    value numeric(15,2),
    collect_group character varying(1),
    collect_reg_date character varying(8),
    collect_reg_seq character varying(30),
    reg_time time without time zone
);

CREATE TABLE tb_hchk_thrd_list (
    instance_id integer NOT NULL,
    hchk_name character varying(100) NOT NULL,
    unit character varying(10),
    is_higher character varying(1),
    warning_threshold numeric(15,2),
    critical_threshold numeric(15,2),
    fixed_threshold character varying(1),
    last_mod_ip character varying(15),
    last_mod_dt timestamp without time zone,
    pause_collect_dt timestamp without time zone,
    retention_time integer,
    critical_start_time timestamp without time zone
);

CREATE TABLE tb_index_info (
    reg_date character varying(8) NOT NULL,
    objt_reg_seq integer NOT NULL,
    db_name character varying(100) NOT NULL,
    schema_name character varying(100) NOT NULL,
    index_name character varying(100) NOT NULL,
    table_name character varying(100),
    index_size_kb numeric(20,0),
    columns_cnt integer,
    agg_index_scan_cnt numeric(20,0),
    agg_index_scan_tuples numeric(20,0),
    agg_index_scan_fetch_tuples numeric(20,0),
    collect_dt timestamp without time zone
);

CREATE TABLE tb_instance_info (
    instance_id integer NOT NULL,
    server_ip character varying(15),
    service_port character varying(10),
    instance_uptime timestamp without time zone,
    max_conn_cnt numeric(20,0),
    cpu_clocks integer,
    host_name character varying(100),
    dbms_type character varying(30),
    conn_user_id character varying(100),
    conn_user_pwd character varying(300),
    collect_yn character varying(1),
    delete_yn character varying(1),
    collect_period_sec integer,
    hchk_period_sec integer,
    conn_db_name character varying(100),
    conn_schema_name character varying(100),
    conn_name character varying(100),
    log_keep_days integer,
    home_dir character varying(100),
    pg_version character varying(1000),
    extensions integer,
    mon_group integer,
    ha_role character varying(1),
    ha_host character varying(100),
    ha_port character varying(10),
    ha_repl_host character varying(100),
    ha_group integer,
    last_mod_ip character varying(15),
    last_mod_dt timestamp without time zone
);

CREATE TABLE tb_replication_info (
    reg_date character varying(8) NOT NULL,
    repl_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    ha_role character varying(1),
    ha_host character varying(100),
    ha_port character varying(10),
    ha_group integer,
    replay_lag integer,
    replay_lag_size numeric(20,0),
    collect_dt timestamp without time zone
);

CREATE TABLE tb_checkpoint_info (
    reg_date character varying(8) NOT NULL,
    repl_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    checkpoints_timed integer,
    checkpoints_req integer,
    checkpoint_time numeric(20,0),
    checkpoints_timed_delta integer,
    checkpoints_req_delta integer,
    checkpoints_timed_time_delta numeric(20,0),
    checkpoints_req_time_delta numeric(20,0),
    collect_dt timestamp without time zone
);

CREATE TABLE tb_group_info (
    group_id integer NOT NULL,
    group_name character varying(30),
    last_mod_ip character varying(15),
    last_mod_dt timestamp without time zone
);

CREATE TABLE tb_group_instance_info
(
  group_id integer NOT NULL,
  instance_id integer NOT NULL,
  last_mod_ip character varying(15),
  last_mod_dt timestamp without time zone
);

CREATE TABLE tb_memory_stat (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    mem_total_kb numeric(20,0),
    mem_used_kb numeric(20,0),
    mem_free_kb numeric(20,0),
    mem_buffered_kb numeric(20,0),
    mem_cached_kb numeric(20,0),
    swp_total_kb numeric(20,0),
    swp_used_kb numeric(20,0),
    swp_cached_kb numeric(20,0),
    swp_free_kb numeric(20,0),
    shm_kb numeric(20,0),
    pgsql_usage_kb numeric(20,0),
    collect_dt timestamp without time zone
);

CREATE TABLE tb_objt_collect_info (
    reg_date character varying(8) NOT NULL,
    objt_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
);

CREATE TABLE tb_rsc_collect_info (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
);

CREATE TABLE tb_sys_log (
    reg_date character varying(8) NOT NULL,
    task_cd character varying(1) NOT NULL,
    start_dt timestamp without time zone,
    status character varying(1),
    end_dt timestamp without time zone,
    comments character varying(100),
    driver_status character varying(3)
);

CREATE TABLE tb_table_info (
    reg_date character varying(8) NOT NULL,
    objt_reg_seq integer NOT NULL,
    db_name character varying(100) NOT NULL,
    schema_name character varying(100) NOT NULL,
    table_name character varying(100) NOT NULL,
    table_size_kb numeric(20,0),
		bloat_size_kb numeric(20,0),
    tot_index_size_kb numeric(20,0),
    index_cnt integer,
    toast_yn character varying(1),
    agg_seq_scan_cnt numeric(20,0),
    agg_seq_tuples numeric(20,0),
    agg_index_scan_cnt numeric(20,0),
    agg_index_tuples numeric(20,0),
    current_seq_scan_cnt numeric(20,0),
    current_seq_tuples numeric(20,0),
    current_index_scan_cnt numeric(20,0),
    current_index_tuples numeric(20,0),
    live_tuple_cnt numeric(20,0),
    dead_tuple_cnt numeric(20,0),
    last_vacuum timestamp without time zone,
    last_analyze timestamp without time zone,
    collect_dt timestamp without time zone,
    relid oid
);

CREATE TABLE tb_table_ext_info (
    reg_date character varying(8) NOT NULL,
    collect_dt timestamp without time ZONE,
    objt_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    relid oid,
    autovacuum_count int8,
    autoanalyze_count int8,
    maxage int4
);

CREATE TABLE tb_tablespace_info (
    reg_date character varying(8) NOT NULL,
    objt_reg_seq integer NOT NULL,
    tablespace_name character varying(100) NOT NULL,
    location character varying(100),
    size_kb numeric,
    total_disk_kb numeric,
    aval_disk_kb numeric,
    fs_name character varying(100),
    device_name character varying(100),
    collect_dt date
);

CREATE TABLE TB_CONTROL_PROCESS_HIST (
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    process_id integer NOT NULL,
    control_type character varying(1),
    access_type character varying(1),
    control_time timestamp without time zone
);

CREATE TABLE TB_HCHK_ALERT_INFO
(
  reg_date character varying(8) NOT NULL,
  hchk_reg_seq integer NOT NULL,
  instance_id integer NOT NULL,
  hchk_name character varying(100) NOT NULL,
  state INTEGER,
  check_user_id character varying(32),
  check_comment character varying(100),
  check_ip character varying(15),
  check_dt timestamp without time zone NULL
);

CREATE TABLE TB_QUERY_INFO (
		instance_id integer NOT NULL,
    queryid character varying(41) NOT NULL,
    stmt_queryid int8,
    query text,
    collect_dt timestamp without time zone
);

CREATE TABLE TB_PG_STAT_STATEMENTS (
    reg_date character varying(8) COLLATE pg_catalog."default" NOT NULL,
    collect_dt timestamp without time zone,
    instance_id integer NOT NULL,
    pgss jsonb NOT NULL
);

CREATE TABLE TB_USER_INFO (
    reg_date character varying(8) COLLATE pg_catalog."default" NOT NULL,
    collect_dt timestamp without time zone,
    instance_id integer NOT NULL,
    user_name character varying(100) NOT NULL,
    user_id int8
);

CREATE TABLE TB_SYS_CODE (
		code int2 NOT NULL,
		code_name character varying(50) NOT NULL,
);

ALTER TABLE ONLY tb_access_info
    ADD CONSTRAINT pk_access_info PRIMARY KEY (reg_date,actv_reg_seq,db_name);


ALTER TABLE ONLY tb_actv_collect_info
    ADD CONSTRAINT pk_actv_collect_info PRIMARY KEY (reg_date,actv_reg_seq);


ALTER TABLE ONLY tb_backend_rsc
    ADD CONSTRAINT pk_backend_rsc PRIMARY KEY (reg_date,actv_reg_seq,process_id);


ALTER TABLE ONLY tb_sys_log
	ADD CONSTRAINT pk_batch_log PRIMARY KEY (reg_date,task_cd, start_dt);
    -- ADD CONSTRAINT pk_batch_log PRIMARY KEY (reg_date,task_cd);


ALTER TABLE ONLY tb_cpu_stat_detail
    ADD CONSTRAINT pk_cpu_stat_detail PRIMARY KEY (reg_date,rsc_reg_seq,cpu_logical_id);


ALTER TABLE ONLY tb_cpu_stat_master
    ADD CONSTRAINT pk_cpu_stat_master PRIMARY KEY (reg_date,rsc_reg_seq);


ALTER TABLE ONLY tb_disk_io
    ADD CONSTRAINT pk_disk_io PRIMARY KEY (reg_date,rsc_reg_seq,disk_name);


ALTER TABLE ONLY tb_disk_usage
	ADD CONSTRAINT pk_disk_usage PRIMARY KEY (reg_date,rsc_reg_seq,mount_point_dir);
    --ADD CONSTRAINT pk_disk_usage PRIMARY KEY (reg_date,rsc_reg_seq,device_name);


ALTER TABLE ONLY tb_hchk_collect_info
    ADD CONSTRAINT pk_hchk_collect_info PRIMARY KEY (reg_date,hchk_reg_seq,instance_id,hchk_name);


ALTER TABLE ONLY tb_hchk_thrd_list
    ADD CONSTRAINT pk_hchk_thrd_list PRIMARY KEY (instance_id,hchk_name);


ALTER TABLE ONLY tb_index_info
    ADD CONSTRAINT pk_index_info PRIMARY KEY (reg_date,objt_reg_seq,db_name,schema_name,index_name);


ALTER TABLE ONLY tb_instance_info
    ADD CONSTRAINT pk_instance_info PRIMARY KEY (instance_id);

ALTER TABLE ONLY tb_replication_info
    ADD CONSTRAINT pk_ha_info PRIMARY KEY (reg_date, repl_reg_seq, instance_id);

ALTER TABLE ONLY tb_checkpoint_info
    ADD CONSTRAINT pk_checkpoint_info PRIMARY KEY (reg_date, repl_reg_seq, instance_id);

ALTER TABLE ONLY tb_group_info
    ADD CONSTRAINT pk_group_info PRIMARY KEY (group_id);

ALTER TABLE ONLY tb_group_info
    ADD CONSTRAINT uk_group_info UNIQUE (group_name);
    
ALTER TABLE ONLY tb_group_instance_info
    ADD CONSTRAINT pk_group_instance_info PRIMARY KEY (group_id, instance_id);

ALTER TABLE ONLY tb_memory_stat
    ADD CONSTRAINT pk_memory_stat PRIMARY KEY (reg_date,rsc_reg_seq);


ALTER TABLE ONLY tb_objt_collect_info
    ADD CONSTRAINT pk_objt_collect_info PRIMARY KEY (reg_date,objt_reg_seq);


ALTER TABLE ONLY tb_rsc_collect_info
    ADD CONSTRAINT pk_rsc_collect_info PRIMARY KEY (reg_date,rsc_reg_seq);


ALTER TABLE ONLY tb_table_info
    ADD CONSTRAINT pk_table_info PRIMARY KEY (reg_date,objt_reg_seq,db_name,schema_name,table_name);

ALTER TABLE ONLY tb_table_ext_info
    ADD CONSTRAINT pk_table_ext_info PRIMARY KEY (reg_date,objt_reg_seq,instance_id,relid);

ALTER TABLE ONLY tb_tablespace_info
    ADD CONSTRAINT pk_tablespace_info PRIMARY KEY (reg_date,objt_reg_seq,tablespace_name);

ALTER TABLE ONLY tb_config
    ADD CONSTRAINT pk_tb_config PRIMARY KEY (admin_user_id);
    
ALTER TABLE ONLY TB_CONTROL_PROCESS_HIST
    ADD CONSTRAINT PK_CONTROL_PROCESS_HIST PRIMARY KEY (reg_date,actv_reg_seq, instance_id, process_id);

ALTER TABLE ONLY TB_HCHK_ALERT_INFO
    ADD CONSTRAINT pk_hchk_alert_info PRIMARY KEY (reg_date,hchk_reg_seq, instance_id, hchk_name);
    
ALTER TABLE ONLY TB_QUERY_INFO
    ADD CONSTRAINT pk_query_info PRIMARY KEY (instance_id, queryid);

ALTER TABLE ONLY TB_PG_STAT_STATEMENTS
    ADD CONSTRAINT pk_pg_stat_statements PRIMARY KEY (reg_date, collect_dt, instance_id);
    
ALTER TABLE ONLY TB_USER_INFO
    ADD CONSTRAINT pk_user_info PRIMARY KEY (reg_date, collect_dt, instance_id, user_id);
    
    
CREATE FUNCTION to_date_immutable(VARCHAR) RETURNS date
    AS $$ SELECT CAST($1 AS date)
    $$ LANGUAGE SQL immutable;
    
CREATE INDEX idx01_access_info ON tb_access_info USING btree (collect_dt DESC);


CREATE INDEX idx01_backend_rsc ON tb_backend_rsc USING btree (collect_dt DESC);


CREATE INDEX idx01_cpu_stat_master ON tb_cpu_stat_master USING btree (collect_dt DESC);


CREATE INDEX idx01_current_lock ON tb_current_lock USING btree (reg_date,actv_reg_seq);


CREATE INDEX idx01_disk_io ON tb_disk_io USING btree (collect_dt DESC);


CREATE INDEX idx01_disk_usage ON tb_disk_usage USING btree (collect_dt DESC);


CREATE INDEX idx01_index_info ON tb_index_info USING btree (collect_dt DESC);


CREATE INDEX idx01_memory_stat ON tb_memory_stat USING btree (collect_dt DESC);


CREATE INDEX idx01_sys_log ON tb_sys_log USING btree (reg_date DESC);


CREATE INDEX idx01_table_info ON tb_table_info USING btree (collect_dt DESC);


CREATE INDEX idx01_table_info ON tb_table_ext_info USING btree (collect_dt DESC);


CREATE INDEX idx01_tablespace_info ON tb_tablespace_info USING btree (collect_dt DESC);


CREATE INDEX idx02_current_lock ON tb_current_lock USING btree (collect_dt DESC);


CREATE INDEX idx01_tb_actv_collect_info ON tb_actv_collect_info USING btree((TO_DATE_IMMUTABLE(reg_date) + reg_time), instance_id);


CREATE INDEX idx01_tb_rsc_collect_info ON tb_rsc_collect_info USING btree((TO_DATE_IMMUTABLE(reg_date) + reg_time), instance_id);


CREATE SEQUENCE hchk_reg_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


CREATE SEQUENCE instance_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE actv_reg_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE objt_reg_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE rsc_reg_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE repl_reg_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

ALTER TABLE tb_access_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_access_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_access_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_access_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_actv_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_actv_collect_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_actv_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_actv_collect_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_backend_rsc SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_backend_rsc SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_backend_rsc SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_backend_rsc SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_config SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_config SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_config SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_config SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_current_lock SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_current_lock SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_current_lock SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_current_lock SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_disk_io SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_disk_io SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_disk_io SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_disk_io SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_disk_usage SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_disk_usage SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_disk_usage SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_disk_usage SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_hchk_thrd_list SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_hchk_thrd_list SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_hchk_thrd_list SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_hchk_thrd_list SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_index_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_index_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_index_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_index_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_instance_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_instance_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_instance_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_instance_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_replication_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_replication_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_replication_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_replication_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_checkpoint_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_checkpoint_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_checkpoint_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_checkpoint_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_memory_stat SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_memory_stat SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_memory_stat SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_memory_stat SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_objt_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_objt_collect_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_objt_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_objt_collect_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_sys_log SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_sys_log SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_sys_log SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_sys_log SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_table_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_table_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_table_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_table_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_table_ext_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_table_ext_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_table_ext_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_table_ext_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_tablespace_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_tablespace_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_tablespace_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_tablespace_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_control_process_hist SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_control_process_hist SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_control_process_hist SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_control_process_hist SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_query_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_query_info SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_query_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_query_info SET (autovacuum_vacuum_threshold = 10000);
ALTER TABLE tb_pg_stat_statements SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_pg_stat_statements SET (autovacuum_analyze_threshold = 10000);
ALTER TABLE tb_pg_stat_statements SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_pg_stat_statements SET (autovacuum_vacuum_threshold = 10000);

ALTER TABLE tb_user_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_user_info SET (autovacuum_analyze_threshold = 1000);
ALTER TABLE tb_user_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_user_info SET (autovacuum_vacuum_threshold = 1000);


INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'DISKUSAGE', '%', '0', 80.00, 90.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'BUFFERHITRATIO', '%', '1', 95.00, 90.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'COMMITRATIO', '%', '1', 80.00, 70.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'CONNECTIONFAIL', 'CNT', '0', 0.00, 1.00, '2', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'CPUWAIT', '%', '0', 50.00, 90.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'SWAPUSAGE', '%', '0', 80.00, 90.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'LOCKCNT', 'CNT', '0', 50.00, 0.00, '1', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'TRAXIDLECNT', 'CNT', '0', 10.00, 0.00, '1', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'LONGRUNSQL', 'SEC', '0', 3.00, 0.00, '1', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'UNUSEDINDEX', 'CNT', '0', 1.00, 0.00, '1', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'LASTVACUUM', 'DAY', '0', 7.00, 0.00, '1', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'LASTANALYZE', 'DAY', '0', 7.00, 0.00, '1', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'ACTIVECONNECTION', '%', '0', 80.00, 90.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'HASTATUS', 'LVL', '0', 1.00, 2.00, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);

--INSERT INTO tb_config VALUES ('23:30:00', 30, 7, 'ADMIN', 'webcash', '', '5964', '', '', '');

INSERT INTO tb_config(
DAILY_BATCH_START_TIME
,HCHK_PERIOD_SEC
,OBJT_PERIOD_SEC
,STMT_PERIOD_SEC
,LOG_KEEP_DAYS
,ADMIN_USER_ID
,ADMIN_PASSWORD
,AGENT_IP
,AGENT_PORT
,LAST_MOD_DT
,LAST_MOD_IP
,SERIAL_KEY
,VERSION
) VALUES ('23:30:00', 30, 300, 1200, 7, 'ADMIN', 'k4m', '127.0.0.1', '5960', now(), '127.0.0.1', 'LICENSEDAT', '10.4.2.265');

INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (1, 'Group1', now(), '127.0.0.1');
INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (2, 'Group2', now(), '127.0.0.1');
INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (3, 'Group3', now(), '127.0.0.1');
INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (4, 'Group4', now(), '127.0.0.1');


INSERT INTO tb_sys_code SELECT 1 	 ,'ShmemIndexLock';
INSERT INTO tb_sys_code SELECT 2 	 ,'OidGenLock';
INSERT INTO tb_sys_code SELECT 3 	 ,'XidGenLock';
INSERT INTO tb_sys_code SELECT 4 	 ,'ProcArrayLock';
INSERT INTO tb_sys_code SELECT 5 	 ,'SInvalReadLock';
INSERT INTO tb_sys_code SELECT 6 	 ,'SInvalWriteLock';
INSERT INTO tb_sys_code SELECT 7 	 ,'WALBufMappingLock';
INSERT INTO tb_sys_code SELECT 8 	 ,'WALWriteLock';
INSERT INTO tb_sys_code SELECT 9 	 ,'ControlFileLock';
INSERT INTO tb_sys_code SELECT 10  ,'CheckpointLock';
INSERT INTO tb_sys_code SELECT 11  ,'CLogControlLock';
INSERT INTO tb_sys_code SELECT 12  ,'SubtransControlLock';
INSERT INTO tb_sys_code SELECT 13  ,'MultiXactGenLock';
INSERT INTO tb_sys_code SELECT 14  ,'MultiXactOffsetControlLock';
INSERT INTO tb_sys_code SELECT 15  ,'MultiXactMemberControlLock';
INSERT INTO tb_sys_code SELECT 16  ,'RelCacheInitLock';
INSERT INTO tb_sys_code SELECT 17  ,'CheckpointerCommLock';
INSERT INTO tb_sys_code SELECT 18  ,'TwoPhaseStateLock';
INSERT INTO tb_sys_code SELECT 19  ,'TablespaceCreateLock';
INSERT INTO tb_sys_code SELECT 20  ,'BtreeVacuumLock';
INSERT INTO tb_sys_code SELECT 21  ,'AddinShmemInitLock';
INSERT INTO tb_sys_code SELECT 22  ,'AutovacuumLock';
INSERT INTO tb_sys_code SELECT 23  ,'AutovacuumScheduleLock';
INSERT INTO tb_sys_code SELECT 24  ,'SyncScanLock';
INSERT INTO tb_sys_code SELECT 25  ,'RelationMappingLock';
INSERT INTO tb_sys_code SELECT 26  ,'AsyncCtlLock';
INSERT INTO tb_sys_code SELECT 27  ,'AsyncQueueLock';
INSERT INTO tb_sys_code SELECT 28  ,'SerializableXactHashLock';
INSERT INTO tb_sys_code SELECT 29  ,'SerializableFinishedListLock';
INSERT INTO tb_sys_code SELECT 30  ,'SerializablePredicateLockListLock';
INSERT INTO tb_sys_code SELECT 31  ,'OldSerXidLock';
INSERT INTO tb_sys_code SELECT 32  ,'SyncRepLock';
INSERT INTO tb_sys_code SELECT 33  ,'BackgroundWorkerLock';
INSERT INTO tb_sys_code SELECT 34  ,'DynamicSharedMemoryControlLock';
INSERT INTO tb_sys_code SELECT 35  ,'AutoFileLock';
INSERT INTO tb_sys_code SELECT 36  ,'ReplicationSlotAllocationLock';
INSERT INTO tb_sys_code SELECT 37  ,'ReplicationSlotControlLock';
INSERT INTO tb_sys_code SELECT 38  ,'CommitTsControlLock';
INSERT INTO tb_sys_code SELECT 39  ,'CommitTsLock';
INSERT INTO tb_sys_code SELECT 40  ,'ReplicationOriginLock';
INSERT INTO tb_sys_code SELECT 41  ,'MultiXactTruncationLock';
INSERT INTO tb_sys_code SELECT 42  ,'OldSnapshotTimeMapLock';
INSERT INTO tb_sys_code SELECT 43  ,'BackendRandomLock';
INSERT INTO tb_sys_code SELECT 44  ,'LogicalRepWorkerLock';
INSERT INTO tb_sys_code SELECT 45  ,'CLogTruncationLock';
INSERT INTO tb_sys_code SELECT 46  ,'clog';
INSERT INTO tb_sys_code SELECT 47  ,'commit_timestamp';
INSERT INTO tb_sys_code SELECT 48  ,'subtrans';
INSERT INTO tb_sys_code SELECT 49  ,'multixact_offset';
INSERT INTO tb_sys_code SELECT 50  ,'multixact_member';
INSERT INTO tb_sys_code SELECT 51  ,'async';
INSERT INTO tb_sys_code SELECT 52  ,'oldserxid';
INSERT INTO tb_sys_code SELECT 53  ,'wal_insert';
INSERT INTO tb_sys_code SELECT 54  ,'buffer_content';
INSERT INTO tb_sys_code SELECT 55  ,'buffer_io';
INSERT INTO tb_sys_code SELECT 56  ,'replication_origin';
INSERT INTO tb_sys_code SELECT 57  ,'replication_slot_io';
INSERT INTO tb_sys_code SELECT 58  ,'proc';
INSERT INTO tb_sys_code SELECT 59  ,'buffer_mapping';
INSERT INTO tb_sys_code SELECT 60  ,'lock_manager';
INSERT INTO tb_sys_code SELECT 61  ,'predicate_lock_manager';
INSERT INTO tb_sys_code SELECT 62  ,'parallel_query_dsa';
INSERT INTO tb_sys_code SELECT 63  ,'tbm';
INSERT INTO tb_sys_code SELECT 64  ,'relation';
INSERT INTO tb_sys_code SELECT 65  ,'extend';
INSERT INTO tb_sys_code SELECT 66  ,'page';
INSERT INTO tb_sys_code SELECT 67  ,'tuple';
INSERT INTO tb_sys_code SELECT 68  ,'transactionid';
INSERT INTO tb_sys_code SELECT 69  ,'virtualxid';
INSERT INTO tb_sys_code SELECT 70  ,'speculative token';
INSERT INTO tb_sys_code SELECT 71  ,'object';
INSERT INTO tb_sys_code SELECT 72  ,'userlock';
INSERT INTO tb_sys_code SELECT 73  ,'advisory';
INSERT INTO tb_sys_code SELECT 74  ,'BufferPin';
INSERT INTO tb_sys_code SELECT 75  ,'ArchiverMain';
INSERT INTO tb_sys_code SELECT 76  ,'AutoVacuumMain';
INSERT INTO tb_sys_code SELECT 77  ,'BgWriterHibernate';
INSERT INTO tb_sys_code SELECT 78  ,'BgWriterMain';
INSERT INTO tb_sys_code SELECT 79  ,'CheckpointerMain';
INSERT INTO tb_sys_code SELECT 80  ,'LogicalApplyMain';
INSERT INTO tb_sys_code SELECT 81  ,'LogicalLauncherMain';
INSERT INTO tb_sys_code SELECT 82  ,'PgStatMain';
INSERT INTO tb_sys_code SELECT 83  ,'RecoveryWalAll';
INSERT INTO tb_sys_code SELECT 84  ,'RecoveryWalStream';
INSERT INTO tb_sys_code SELECT 85  ,'SysLoggerMain';
INSERT INTO tb_sys_code SELECT 86  ,'WalReceiverMain';
INSERT INTO tb_sys_code SELECT 87  ,'WalSenderMain';
INSERT INTO tb_sys_code SELECT 88  ,'WalWriterMain';
INSERT INTO tb_sys_code SELECT 89  ,'ClientRead';
INSERT INTO tb_sys_code SELECT 90  ,'ClientWrite';
INSERT INTO tb_sys_code SELECT 91  ,'LibPQWalReceiverConnect';
INSERT INTO tb_sys_code SELECT 92  ,'LibPQWalReceiverReceive';
INSERT INTO tb_sys_code SELECT 93  ,'SSLOpenServer';
INSERT INTO tb_sys_code SELECT 94  ,'WalReceiverWaitStart';
INSERT INTO tb_sys_code SELECT 95  ,'WalSenderWaitForWAL';
INSERT INTO tb_sys_code SELECT 96  ,'WalSenderWriteData';
INSERT INTO tb_sys_code SELECT 97  ,'Extension';
INSERT INTO tb_sys_code SELECT 98  ,'BgWorkerShutdown';
INSERT INTO tb_sys_code SELECT 99  ,'BgWorkerStartup';
INSERT INTO tb_sys_code SELECT 100 ,'BtreePage';
INSERT INTO tb_sys_code SELECT 101 ,'ExecuteGather';
INSERT INTO tb_sys_code SELECT 102 ,'LogicalSyncData';
INSERT INTO tb_sys_code SELECT 103 ,'LogicalSyncStateChange';
INSERT INTO tb_sys_code SELECT 104 ,'MessageQueueInternal';
INSERT INTO tb_sys_code SELECT 105 ,'MessageQueuePutMessage';
INSERT INTO tb_sys_code SELECT 106 ,'MessageQueueReceive';
INSERT INTO tb_sys_code SELECT 107 ,'MessageQueueSend';
INSERT INTO tb_sys_code SELECT 108 ,'ParallelBitmapScan';
INSERT INTO tb_sys_code SELECT 109 ,'ParallelFinish';
INSERT INTO tb_sys_code SELECT 110 ,'ProcArrayGroupUpdate';
INSERT INTO tb_sys_code SELECT 111 ,'ReplicationOriginDrop';
INSERT INTO tb_sys_code SELECT 112 ,'ReplicationSlotDrop';
INSERT INTO tb_sys_code SELECT 113 ,'SafeSnapshot';
INSERT INTO tb_sys_code SELECT 114 ,'SyncRep';
INSERT INTO tb_sys_code SELECT 115 ,'BaseBackupThrottle';
INSERT INTO tb_sys_code SELECT 116 ,'PgSleep';
INSERT INTO tb_sys_code SELECT 117 ,'RecoveryApplyDelay';
INSERT INTO tb_sys_code SELECT 118 ,'BufFileRead';
INSERT INTO tb_sys_code SELECT 119 ,'BufFileWrite';
INSERT INTO tb_sys_code SELECT 120 ,'ControlFileRead';
INSERT INTO tb_sys_code SELECT 121 ,'ControlFileSync';
INSERT INTO tb_sys_code SELECT 122 ,'ControlFileSyncUpdate';
INSERT INTO tb_sys_code SELECT 123 ,'ControlFileWrite';
INSERT INTO tb_sys_code SELECT 124 ,'ControlFileWriteUpdate';
INSERT INTO tb_sys_code SELECT 125 ,'CopyFileRead';
INSERT INTO tb_sys_code SELECT 126 ,'CopyFileWrite';
INSERT INTO tb_sys_code SELECT 127 ,'DataFileExtend';
INSERT INTO tb_sys_code SELECT 128 ,'DataFileFlush';
INSERT INTO tb_sys_code SELECT 129 ,'DataFileImmediateSync';
INSERT INTO tb_sys_code SELECT 130 ,'DataFilePrefetch';
INSERT INTO tb_sys_code SELECT 131 ,'DataFileRead';
INSERT INTO tb_sys_code SELECT 132 ,'DataFileSync';
INSERT INTO tb_sys_code SELECT 133 ,'DataFileTruncate';
INSERT INTO tb_sys_code SELECT 134 ,'DataFileWrite';
INSERT INTO tb_sys_code SELECT 135 ,'DSMFillZeroWrite';
INSERT INTO tb_sys_code SELECT 136 ,'LockFileAddToDataDirRead';
INSERT INTO tb_sys_code SELECT 137 ,'LockFileAddToDataDirSync';
INSERT INTO tb_sys_code SELECT 138 ,'LockFileAddToDataDirWrite';
INSERT INTO tb_sys_code SELECT 139 ,'LockFileCreateRead';
INSERT INTO tb_sys_code SELECT 140 ,'LockFileCreateSync';
INSERT INTO tb_sys_code SELECT 141 ,'LockFileCreateWrite';
INSERT INTO tb_sys_code SELECT 142 ,'LockFileReCheckDataDirRead';
INSERT INTO tb_sys_code SELECT 143 ,'LogicalRewriteCheckpointSync';
INSERT INTO tb_sys_code SELECT 144 ,'LogicalRewriteMappingSync';
INSERT INTO tb_sys_code SELECT 145 ,'LogicalRewriteMappingWrite';
INSERT INTO tb_sys_code SELECT 146 ,'LogicalRewriteSync';
INSERT INTO tb_sys_code SELECT 147 ,'LogicalRewriteWrite';
INSERT INTO tb_sys_code SELECT 148 ,'RelationMapRead';
INSERT INTO tb_sys_code SELECT 149 ,'RelationMapSync';
INSERT INTO tb_sys_code SELECT 150 ,'RelationMapWrite';
INSERT INTO tb_sys_code SELECT 151 ,'ReorderBufferRead';
INSERT INTO tb_sys_code SELECT 152 ,'ReorderBufferWrite';
INSERT INTO tb_sys_code SELECT 153 ,'ReorderLogicalMappingRead';
INSERT INTO tb_sys_code SELECT 154 ,'ReplicationSlotRead';
INSERT INTO tb_sys_code SELECT 155 ,'ReplicationSlotRestoreSync';
INSERT INTO tb_sys_code SELECT 156 ,'ReplicationSlotSync';
INSERT INTO tb_sys_code SELECT 157 ,'ReplicationSlotWrite';
INSERT INTO tb_sys_code SELECT 158 ,'SLRUFlushSync';
INSERT INTO tb_sys_code SELECT 159 ,'SLRURead';
INSERT INTO tb_sys_code SELECT 160 ,'SLRUSync';
INSERT INTO tb_sys_code SELECT 161 ,'SLRUWrite';
INSERT INTO tb_sys_code SELECT 162 ,'SnapbuildRead';
INSERT INTO tb_sys_code SELECT 163 ,'SnapbuildSync';
INSERT INTO tb_sys_code SELECT 164 ,'SnapbuildWrite';
INSERT INTO tb_sys_code SELECT 165 ,'TimelineHistoryFileSync';
INSERT INTO tb_sys_code SELECT 166 ,'TimelineHistoryFileWrite';
INSERT INTO tb_sys_code SELECT 167 ,'TimelineHistoryRead';
INSERT INTO tb_sys_code SELECT 168 ,'TimelineHistorySync';
INSERT INTO tb_sys_code SELECT 169 ,'TimelineHistoryWrite';
INSERT INTO tb_sys_code SELECT 170 ,'TwophaseFileRead';
INSERT INTO tb_sys_code SELECT 171 ,'TwophaseFileSync';
INSERT INTO tb_sys_code SELECT 172 ,'TwophaseFileWrite';
INSERT INTO tb_sys_code SELECT 173 ,'WALBootstrapSync';
INSERT INTO tb_sys_code SELECT 174 ,'WALBootstrapWrite';
INSERT INTO tb_sys_code SELECT 175 ,'WALCopyRead';
INSERT INTO tb_sys_code SELECT 176 ,'WALCopySync';
INSERT INTO tb_sys_code SELECT 177 ,'WALCopyWrite';
INSERT INTO tb_sys_code SELECT 178 ,'WALInitSync';
INSERT INTO tb_sys_code SELECT 179 ,'WALInitWrite';
INSERT INTO tb_sys_code SELECT 180 ,'WALRead';
INSERT INTO tb_sys_code SELECT 181 ,'WALSenderTimelineHistoryRead';
INSERT INTO tb_sys_code SELECT 182 ,'WALSyncMethodAssign';
INSERT INTO tb_sys_code SELECT 183 ,'WALWrite';
/* repository agent_port is a port of agent_manager	 
   
*/
