CREATE UNLOGGED TABLE tb_access_info (
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
    buffer_hit_ratio numeric(5,2),
    collect_dt timestamp without time zone,
    delta_time numeric(10,3)
);


CREATE UNLOGGED TABLE tb_actv_collect_info (
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
);


CREATE UNLOGGED TABLE tb_backend_rsc (
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
    sql text,
    collect_dt timestamp without time zone
);

CREATE TABLE tb_config (
    daily_batch_start_time time without time zone,
    hchk_period_sec integer,
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

CREATE UNLOGGED TABLE tb_cpu_stat_detail (
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

CREATE UNLOGGED TABLE tb_cpu_stat_master (
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

CREATE UNLOGGED TABLE tb_current_lock (    
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

CREATE UNLOGGED TABLE tb_disk_io (
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
    delta_time numeric(10,3)
);

CREATE UNLOGGED TABLE tb_disk_usage (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    device_name character varying(100) NOT NULL,
    total_kb numeric(20,0),
    used_kb numeric(20,0),
    avail_kb numeric(20,0),
    mount_point_dir character varying(100),
    collect_dt timestamp without time zone
);

CREATE UNLOGGED TABLE tb_hchk_collect_info (
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
    pause_collect_dt timestamp without time zone
);

CREATE UNLOGGED TABLE tb_index_info (
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
    mon_group integer,
    ha_role character varying(1),
    ha_host character varying(100),
    ha_port character varying(10),
    last_mod_ip character varying(15),
    last_mod_dt timestamp without time zone
);

CREATE TABLE tb_group_info (
    group_id integer NOT NULL,
    group_name character varying(30),
    last_mod_ip character varying(15),
    last_mod_dt timestamp without time zone
);


CREATE UNLOGGED TABLE tb_memory_stat (
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

CREATE UNLOGGED TABLE tb_objt_collect_info (
    reg_date character varying(8) NOT NULL,
    objt_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
);

CREATE UNLOGGED TABLE tb_rsc_collect_info (
    reg_date character varying(8) NOT NULL,
    rsc_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
);

CREATE UNLOGGED TABLE tb_sys_log (
    reg_date character varying(8) NOT NULL,
    task_cd character varying(1) NOT NULL,
    start_dt timestamp without time zone,
    status character varying(1),
    end_dt timestamp without time zone,
    comments character varying(100)
);

CREATE UNLOGGED TABLE tb_table_info (
    reg_date character varying(8) NOT NULL,
    objt_reg_seq integer NOT NULL,
    db_name character varying(100) NOT NULL,
    schema_name character varying(100) NOT NULL,
    table_name character varying(100) NOT NULL,
    table_size_kb numeric(20,0),
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
    last_vacuum timestamp without time zone,
    last_analyze timestamp without time zone,
    collect_dt timestamp without time zone
);

CREATE UNLOGGED TABLE tb_tablespace_info (
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

CREATE UNLOGGED TABLE TB_CONTROL_PROCESS_HIST (
    reg_date character varying(8) NOT NULL,
    actv_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    process_id integer NOT NULL,
    control_type character varying(1),
    access_type character varying(1),
    control_time timestamp without time zone
);

CREATE UNLOGGED TABLE TB_HCHK_ALERT_INFO
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

ALTER TABLE ONLY tb_group_info
    ADD CONSTRAINT pk_group_info PRIMARY KEY (group_id);

ALTER TABLE ONLY tb_memory_stat
    ADD CONSTRAINT pk_memory_stat PRIMARY KEY (reg_date,rsc_reg_seq);


ALTER TABLE ONLY tb_objt_collect_info
    ADD CONSTRAINT pk_objt_collect_info PRIMARY KEY (reg_date,objt_reg_seq);


ALTER TABLE ONLY tb_rsc_collect_info
    ADD CONSTRAINT pk_rsc_collect_info PRIMARY KEY (reg_date,rsc_reg_seq);


ALTER TABLE ONLY tb_table_info
    ADD CONSTRAINT pk_table_info PRIMARY KEY (reg_date,objt_reg_seq,db_name,schema_name,table_name);


ALTER TABLE ONLY tb_tablespace_info
    ADD CONSTRAINT pk_tablespace_info PRIMARY KEY (reg_date,objt_reg_seq,tablespace_name);

ALTER TABLE ONLY tb_config
    ADD CONSTRAINT pk_tb_config PRIMARY KEY (admin_user_id);
    
ALTER TABLE ONLY TB_CONTROL_PROCESS_HIST
    ADD CONSTRAINT PK_CONTROL_PROCESS_HIST PRIMARY KEY (reg_date,actv_reg_seq, instance_id, process_id);

ALTER TABLE ONLY TB_HCHK_ALERT_INFO
    ADD CONSTRAINT pk_hchk_alert_info PRIMARY KEY (reg_date,hchk_reg_seq, instance_id, hchk_name);

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


CREATE INDEX idx01_tablespace_info ON tb_tablespace_info USING btree (collect_dt DESC);


CREATE INDEX idx02_current_lock ON tb_current_lock USING btree (collect_dt DESC);


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

ALTER TABLE tb_access_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_access_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_access_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_access_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_actv_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_actv_collect_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_actv_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_actv_collect_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_backend_rsc SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_backend_rsc SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_backend_rsc SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_backend_rsc SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_config SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_config SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_config SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_config SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_detail SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_cpu_stat_master SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_current_lock SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_current_lock SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_current_lock SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_current_lock SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_disk_io SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_disk_io SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_disk_io SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_disk_io SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_disk_usage SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_disk_usage SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_disk_usage SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_disk_usage SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_hchk_collect_info SET (autovacuum_vacuum_threshold = 5000);
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
ALTER TABLE tb_memory_stat SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_memory_stat SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_memory_stat SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_memory_stat SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_objt_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_objt_collect_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_objt_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_objt_collect_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_rsc_collect_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_sys_log SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_sys_log SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_sys_log SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_sys_log SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_table_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_table_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_table_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_table_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_tablespace_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_tablespace_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_tablespace_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_tablespace_info SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_control_process_hist SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_control_process_hist SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_control_process_hist SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_control_process_hist SET (autovacuum_vacuum_threshold = 5000);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_hchk_alert_info SET (autovacuum_vacuum_threshold = 5000);



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

--INSERT INTO tb_config VALUES ('23:30:00', 30, 7, 'ADMIN', 'webcash', '', '5964', '', '', '');

INSERT INTO tb_config(
DAILY_BATCH_START_TIME
,HCHK_PERIOD_SEC
,LOG_KEEP_DAYS
,ADMIN_USER_ID
,ADMIN_PASSWORD
,AGENT_IP
,AGENT_PORT
,LAST_MOD_DT
,LAST_MOD_IP
,SERIAL_KEY
,VERSION
) VALUES ('23:30:00', 30, 7, 'ADMIN', 'k4m', '127.0.0.1', '5960', now(), '127.0.0.1', 'LICENSEDAT', 'EXPERDB_VERSION');

INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (1, 'Group1', now(), '127.0.0.1');
INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (2, 'Group2', now(), '127.0.0.1');
INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (3, 'Group3', now(), '127.0.0.1');
INSERT INTO tb_group_info(group_id, group_name, LAST_MOD_DT, LAST_MOD_IP) VALUES (4, 'Group4', now(), '127.0.0.1');

/* repository agent_port is a port of agent_manager	 
   
*/
