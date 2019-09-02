create table tb_access_info (
    reg_date character varying(8) not null,
    actv_reg_seq integer not null,
    db_name character varying(100) not null,
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
) partition by list (reg_date);

create table tb_actv_collect_info (
    reg_date character varying(8) not null,
    actv_reg_seq integer not null,
    instance_id integer not null,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
)partition by list (reg_date);

create table tb_backend_rsc (
    reg_date character varying(8) not null,
    actv_reg_seq integer not null,
    process_id integer not null,
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
    wait_event int2 null,
    queryid character varying(41),
    sql text,
    collect_dt timestamp without time zone
) partition by list (reg_date);

create table tb_config (
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

create table tb_cpu_stat_detail (
    reg_date character varying(8) not null,
    rsc_reg_seq integer not null,
    cpu_logical_id integer not null,
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
) partition by list (reg_date);

create table tb_cpu_stat_master (
    reg_date character varying(8) not null,
    rsc_reg_seq integer not null,
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
) partition by list (reg_date);

create table tb_current_lock (    
    reg_date character varying(8) not null,
    actv_reg_seq integer not null,
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
    collect_dt timestamp without time zone
) partition by list (reg_date);

create table tb_disk_io (
    reg_date character varying(8) not null,
    rsc_reg_seq integer not null,
    disk_name character varying(100) not null,
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
) partition by list (reg_date);

create table tb_disk_usage (
    reg_date character varying(8) not null,
    rsc_reg_seq integer not null,
    device_name character varying(100) not null,
    total_kb numeric(20,0),
    used_kb numeric(20,0),
    avail_kb numeric(20,0),
    mount_point_dir character varying(100),
    collect_dt timestamp without time zone
) partition by list (reg_date);

create table tb_hchk_collect_info (
    reg_date character varying(8) not null,
    hchk_reg_seq integer not null,
    instance_id integer not null,
    hchk_name character varying(100) not null,
    value numeric(15,2),
    collect_group character varying(1),
    collect_reg_date character varying(8),
    collect_reg_seq character varying(30),
    reg_time time without time zone
)partition by list (reg_date);

create table tb_hchk_thrd_list (
    instance_id integer not null,
    hchk_name character varying(100) not null,
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

create table tb_index_info (
    reg_date character varying(8) not null,
    objt_reg_seq integer not null,
    db_name character varying(100) not null,
    schema_name character varying(100) not null,
    index_name character varying(100) not null,
    table_name character varying(100),
    index_size_kb numeric(20,0),
    columns_cnt integer,
    agg_index_scan_cnt numeric(20,0),
    agg_index_scan_tuples numeric(20,0),
    agg_index_scan_fetch_tuples numeric(20,0),
    collect_dt timestamp without time zone
);

create table tb_instance_info (
    instance_id integer not null,
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
    rtstmt_period_sec integer default 0,
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

create table tb_replication_info (
    reg_date character varying(8) not null,
    repl_reg_seq integer not null,
    instance_id integer not null,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    ha_role character varying(1),
    ha_host character varying(100),
    ha_port character varying(10),
    ha_group integer,
    replay_lag integer,
    replay_lag_size numeric(20,0),
    collect_dt timestamp without time zone
)partition by list (reg_date);

create table tb_checkpoint_info (
    reg_date character varying(8) not null,
    repl_reg_seq integer not null,
    instance_id integer not null,
    checkpoints_timed integer,
    checkpoints_req integer,
    checkpoint_time numeric(20,0),
    checkpoints_timed_delta integer,
    checkpoints_req_delta integer,
    checkpoints_timed_time_delta numeric(20,0),
    checkpoints_req_time_delta numeric(20,0),
    collect_dt timestamp without time zone
)partition by list (reg_date);

create table tb_group_info (
    group_id integer not null,
    group_name character varying(30),
    last_mod_ip character varying(15),
    last_mod_dt timestamp without time zone
);

create table tb_group_instance_info
(
  group_id integer not null,
  instance_id integer not null,
  last_mod_ip character varying(15),
  last_mod_dt timestamp without time zone
);

create table tb_memory_stat (
    reg_date character varying(8) not null,
    rsc_reg_seq integer not null,
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
) partition by list (reg_date);

create table tb_objt_collect_info (
    reg_date character varying(8) not null,
    objt_reg_seq integer not null,
    instance_id integer not null,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
)partition by list (reg_date);

create table tb_rsc_collect_info (
    reg_date character varying(8) not null,
    rsc_reg_seq integer not null,
    instance_id integer not null,
    is_collect_ok character varying(1),
    failed_collect_type character varying(1),
    reg_time time without time zone
) partition by list (reg_date);

create table tb_sys_log (
    reg_date character varying(8) not null,
    task_cd character varying(1) not null,
    start_dt timestamp without time zone,
    status character varying(1),
    end_dt timestamp without time zone,
    comments character varying(100),
    driver_status character varying(3)
);

create table tb_table_info (
    reg_date character varying(8) not null,
    objt_reg_seq integer not null,
    db_name character varying(100) not null,
    schema_name character varying(100) not null,
    table_name character varying(100) not null,
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

create table tb_table_ext_info (
    reg_date character varying(8) not null,
    collect_dt timestamp without time zone,
    objt_reg_seq integer not null,
    instance_id integer not null,
    relid oid,
    autovacuum_count int8,
    autoanalyze_count int8,
    maxage int4
)partition by list (reg_date);

create table tb_tablespace_info (
    reg_date character varying(8) not null,
    objt_reg_seq integer not null,
    tablespace_name character varying(100) not null,
    location character varying(100),
    size_kb numeric,
    total_disk_kb numeric,
    aval_disk_kb numeric,
    fs_name character varying(100),
    device_name character varying(100),
    collect_dt date
);

create table tb_control_process_hist (
    reg_date character varying(8) not null,
    actv_reg_seq integer not null,
    instance_id integer not null,
    process_id integer not null,
    control_type character varying(1),
    access_type character varying(1),
    control_time timestamp without time zone
);

create table tb_hchk_alert_info
(
  reg_date character varying(8) not null,
  hchk_reg_seq integer not null,
  instance_id integer not null,
  hchk_name character varying(100) not null,
  state integer,
  check_user_id character varying(32),
  check_comment character varying(100),
  check_ip character varying(15),
  check_dt timestamp without time zone null
) partition by list (reg_date);

create table tb_query_info (
		instance_id integer not null,
    queryid character varying(41) not null,
    stmt_queryid int8,
    query text,
    collect_dt timestamp without time zone
);

create table tb_pg_stat_statements (
    reg_date character varying(8) collate pg_catalog."default" not null,
    collect_dt timestamp without time zone,
    instance_id integer not null,
    pgss jsonb not null
)partition by list (reg_date);

create table tb_user_info (
    reg_date character varying(8) collate pg_catalog."default" not null,
    collect_dt timestamp without time zone,
    instance_id integer not null,
    user_name character varying(100) not null,
    user_id int8
);

create table tb_database_info (
    reg_date character varying(8) collate pg_catalog."default" not null,
    collect_dt timestamp without time zone,
    instance_id integer not null,
    database_name character varying(100) not null,
    datid int8
);

create table tb_sys_code (
		code int2 not null,
		code_name character varying(50) not null,
);
        
create table tb_realtime_statements (
    reg_time character varying(14) not null,
    instance_id integer not null,
    dbid int4,
    userid int4,
    queryid int8,
    calls int8,
    total_time float8,
    cqueryid character varying(41),
    collect_dt timestamp without time zone
) partition by list (reg_time);

------------------------------------------------------------------------------------------
-----------------------<create partition tables>------------------------------------------
------------------------------------------------------------------------------------------
create table tb_access_info_${TODAY} partition of tb_access_info for values in ('${TODAY}');
create table tb_actv_collect_info_${TODAY} partition of tb_actv_collect_info for values in ('${TODAY}');
create table tb_backend_rsc_${TODAY} partition of tb_backend_rsc for values in ('${TODAY}');
create table tb_cpu_stat_detail_${TODAY} partition of tb_cpu_stat_detail for values in ('${TODAY}');
create table tb_cpu_stat_master_${TODAY} partition of tb_cpu_stat_master for values in ('${TODAY}');
create table tb_current_lock_${TODAY} partition of tb_current_lock for values in ('${TODAY}');
create table tb_disk_io_${TODAY} partition of tb_disk_io for values in ('${TODAY}');
create table tb_disk_usage_${TODAY} partition of tb_disk_usage for values in ('${TODAY}');
create table tb_hchk_collect_info_${TODAY} partition of tb_hchk_collect_info for values in ('${TODAY}');
create table tb_replication_info_${TODAY} partition of tb_replication_info for values in ('${TODAY}');
create table tb_checkpoint_info_${TODAY} partition of tb_checkpoint_info for values in ('${TODAY}');
create table tb_memory_stat_${TODAY} partition of tb_memory_stat for values in ('${TODAY}');
create table tb_objt_collect_info_${TODAY} partition of tb_objt_collect_info  for values in ('${TODAY}');
create table tb_rsc_collect_info_${TODAY} partition of tb_rsc_collect_info for values in ('${TODAY}');
create table tb_table_ext_info_${TODAY} partition of tb_table_ext_info for values in ('${TODAY}');
create table tb_hchk_alert_info_${TODAY} partition of tb_hchk_alert_info for values in ('${TODAY}');
create table tb_pg_stat_statements_${TODAY} partition of tb_pg_stat_statements for values in ('${TODAY}');
create table tb_realtime_statements_${CURRHOUR} partition of tb_realtime_statements for values in ('${CURRHOUR}');
create table tb_realtime_statements_${NEXTHOUR} partition of tb_realtime_statements for values in ('${NEXTHOUR}');
------------------------------------------------------------------------------------------
-----------------------<create create constraint>-----------------------------------------
------------------------------------------------------------------------------------------
alter table only tb_access_info_${TODAY} add constraint pk_tb_access_info_${TODAY} primary key (reg_date,actv_reg_seq,db_name);
alter table only tb_actv_collect_info_${TODAY} add constraint pk_actv_collect_info_${TODAY} primary key (reg_date,actv_reg_seq);
alter table only tb_backend_rsc_${TODAY} add constraint pk_tb_backend_rsc_${TODAY} primary key (reg_date,actv_reg_seq,process_id);
alter table only tb_cpu_stat_detail_${TODAY} add constraint pk_tb_cpu_stat_detail_${TODAY} primary key (reg_date,rsc_reg_seq,cpu_logical_id);
alter table only tb_cpu_stat_master_${TODAY} add constraint pk_tb_cpu_stat_master_${TODAY} primary key (reg_date,rsc_reg_seq);
alter table only tb_disk_io_${TODAY} add constraint pk_tb_disk_io_${TODAY} primary key (reg_date,rsc_reg_seq,disk_name);
alter table only tb_disk_usage_${TODAY} add constraint pk_tb_disk_usage_${TODAY} primary key (reg_date,rsc_reg_seq,mount_point_dir);
alter table only tb_hchk_collect_info_${TODAY} add constraint pk_tb_hchk_collect_info_${TODAY} primary key (reg_date,hchk_reg_seq,instance_id,hchk_name);
alter table only tb_replication_info_${TODAY} add constraint pk_ha_info_${TODAY} primary key (reg_date, repl_reg_seq, instance_id);
alter table only tb_checkpoint_info_${TODAY} add constraint pk_checkpoint_info_${TODAY} primary key (reg_date,repl_reg_seq,instance_id);
alter table only tb_memory_stat_${TODAY} add constraint pk_tb_memory_stat_${TODAY} primary key (reg_date,rsc_reg_seq);
alter table only tb_objt_collect_info_${TODAY} add constraint pk_objt_collect_info_${TODAY} primary key (reg_date,objt_reg_seq);
alter table only tb_rsc_collect_info_${TODAY} add constraint pk_tb_rsc_collect_info_${TODAY} primary key (reg_date,rsc_reg_seq);
alter table only tb_table_ext_info_${TODAY} add constraint pk_table_ext_info_${TODAY} primary key (reg_date,objt_reg_seq,instance_id,relid);
alter table only tb_hchk_alert_info_${TODAY} add constraint pk_tb_hchk_alert_info_${TODAY} primary key (reg_date,hchk_reg_seq, instance_id, hchk_name);
alter table only tb_pg_stat_statements_${TODAY} add constraint pk_pg_stat_statements_${TODAY} primary key (reg_date, collect_dt, instance_id);
alter table only tb_query_info add constraint pk_query_info primary key (instance_id, queryid);
alter table only tb_sys_log	add constraint pk_batch_log primary key (reg_date,task_cd, start_dt);
alter table only tb_hchk_thrd_list add constraint pk_hchk_thrd_list primary key (instance_id,hchk_name);
alter table only tb_index_info add constraint pk_index_info primary key (reg_date,objt_reg_seq,db_name,schema_name,index_name);
alter table only tb_instance_info add constraint pk_instance_info primary key (instance_id);
alter table only tb_group_info add constraint pk_group_info primary key (group_id);
alter table only tb_group_info add constraint uk_group_info unique (group_name);
alter table only tb_group_instance_info add constraint pk_group_instance_info primary key (group_id, instance_id);
alter table only tb_table_info add constraint pk_table_info primary key (reg_date,objt_reg_seq,db_name,schema_name,table_name);
alter table only tb_tablespace_info add constraint pk_tablespace_info primary key (reg_date,objt_reg_seq,tablespace_name);
alter table only tb_config add constraint pk_tb_config primary key (admin_user_id);
alter table only tb_control_process_hist add constraint pk_control_process_hist primary key (reg_date,actv_reg_seq, instance_id, process_id);
alter table only tb_user_info add constraint pk_user_info primary key (reg_date, collect_dt, instance_id, user_id);
--alter table only tb_access_info add constraint pk_access_info primary key (reg_date,actv_reg_seq,db_name);
--alter table only tb_actv_collect_info add constraint pk_actv_collect_info primary key (reg_date,actv_reg_seq);
--alter table only tb_backend_rsc add constraint pk_backend_rsc primary key (reg_date,actv_reg_seq,process_id);
--alter table only tb_cpu_stat_detail add constraint pk_cpu_stat_detail primary key (reg_date,rsc_reg_seq,cpu_logical_id);
--alter table only tb_cpu_stat_master add constraint pk_cpu_stat_master primary key (reg_date,rsc_reg_seq);
--alter table only tb_disk_io add constraint pk_disk_io primary key (reg_date,rsc_reg_seq,disk_name);
--alter table only tb_disk_usage add constraint pk_disk_usage primary key (reg_date,rsc_reg_seq,mount_point_dir);
--alter table only tb_hchk_collect_info add constraint pk_hchk_collect_info primary key (reg_date,hchk_reg_seq,instance_id,hchk_name);
--alter table only tb_replication_info add constraint pk_ha_info primary key (reg_date, repl_reg_seq, instance_id);
--alter table only tb_checkpoint_info add constraint pk_checkpoint_info primary key (reg_date, repl_reg_seq, instance_id);
--alter table only tb_memory_stat add constraint pk_memory_stat primary key (reg_date,rsc_reg_seq);
--alter table only tb_objt_collect_info add constraint pk_objt_collect_info primary key (reg_date,objt_reg_seq);
--alter table only tb_rsc_collect_info add constraint pk_rsc_collect_info primary key (reg_date,rsc_reg_seq);
--alter table only tb_table_ext_info add constraint pk_table_ext_info primary key (reg_date,objt_reg_seq,instance_id,relid);
--alter table only tb_hchk_alert_info add constraint pk_hchk_alert_info primary key (reg_date,hchk_reg_seq, instance_id, hchk_name);
--alter table only tb_pg_stat_statements add constraint pk_pg_stat_statements primary key (reg_date, collect_dt, instance_id);
------------------------------------------------------------------------------------------
-----------------------<create function>--------------------------------------------------
------------------------------------------------------------------------------------------
create or replace function to_date_imm(text, text) 
		returns date
		as 'to_date'
		language internal immutable strict
		cost 1;
------------------------------------------------------------------------------------------
-----------------------<create index>----------------------------------------------
------------------------------------------------------------------------------------------
create index if not exists idx01_tb_access_info_${TODAY} on tb_access_info_${TODAY} using btree (collect_dt desc);
create index if not exists idx01_tb_actv_collect_info_${TODAY} on tb_actv_collect_info_${TODAY} using btree((to_date_imm(reg_date, 'yyyymmdd') + reg_time), instance_id);
create index if not exists idx01_tb_backend_rsc_${TODAY} on tb_backend_rsc_${TODAY} using btree (collect_dt desc);
create index if not exists idx01_tb_cpu_stat_master_${TODAY} on tb_cpu_stat_master_${TODAY} using btree (collect_dt desc);
create index if not exists idx01_tb_current_lock_${TODAY} on tb_current_lock_${TODAY} using btree (reg_date,actv_reg_seq);
create index if not exists idx01_tb_disk_io_${TODAY} on tb_disk_io_${TODAY} using btree (collect_dt desc);
create index if not exists idx01_tb_disk_usage_${TODAY} on tb_disk_usage_${TODAY} using btree (collect_dt desc);
create index if not exists idx01_tb_rsc_collect_info_${TODAY} on tb_rsc_collect_info_${TODAY} using btree((to_date_imm(reg_date, 'yyyymmdd') + reg_time), instance_id);
create index if not exists idx01_tb_table_ext_info_${TODAY} on tb_table_ext_info_${TODAY} using btree (collect_dt desc);
create index if not exists idx01_tb_realtime_statements_${CURRHOUR} on tb_realtime_statements_${CURRHOUR} using btree (collect_dt desc);
create index if not exists idx01_tb_realtime_statements_${NEXTHOUR} on tb_realtime_statements_${NEXTHOUR} using btree (collect_dt desc);
create index if not exists idx01_tb_index_info on tb_index_info using btree (collect_dt desc);
create index if not exists idx01_tb_sys_log on tb_sys_log using btree (reg_date desc);
create index if not exists idx01_tb_table_info on tb_table_info using btree (collect_dt desc);
create index if not exists idx01_tb_tablespace_info on tb_tablespace_info using btree (collect_dt desc);
--create index idx01_access_info on tb_access_info using btree (collect_dt desc);
--create index idx01_backend_rsc on tb_backend_rsc using btree (collect_dt desc);
--create index idx01_cpu_stat_master on tb_cpu_stat_master using btree (collect_dt desc);
--create index idx01_current_lock on tb_current_lock using btree (reg_date,actv_reg_seq);
--create index idx01_disk_io on tb_disk_io using btree (collect_dt desc);
--create index idx01_disk_usage on tb_disk_usage using btree (collect_dt desc);
--create index idx01_memory_stat on tb_memory_stat using btree (collect_dt desc);
--create index idx01_table_ext_info on tb_table_ext_info using btree (collect_dt desc);
--create index idx02_current_lock on tb_current_lock using btree (collect_dt desc);
--create index idx01_tb_actv_collect_info on tb_actv_collect_info using btree((to_date_imm(reg_date, 'yyyymmdd') + reg_time), instance_id);
--create index idx01_tb_rsc_collect_info on tb_rsc_collect_info using btree((to_date_imm(reg_date, 'yyyymmdd') + reg_time), instance_id);
--create index idx01_realtime_statements on tb_realtime_statements using btree (collect_dt desc);

------------------------------------------------------------------------------------------
-----------------------<create sequence>--------------------------------------------------
------------------------------------------------------------------------------------------
create sequence hchk_reg_seq
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;
create sequence instance_id
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;
create sequence actv_reg_seq
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;
create sequence objt_reg_seq
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;
create sequence rsc_reg_seq
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;
create sequence repl_reg_seq
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;
-----------------------------------------------------------------------------------------------
-----------------------<autovacuum condition>--------------------------------------------------
-----------------------------------------------------------------------------------------------
alter table tb_config set (autovacuum_analyze_scale_factor = 0.1);
alter table tb_config set (autovacuum_vacuum_scale_factor = 0.2);
alter table tb_current_lock set (autovacuum_analyze_threshold = 5000);
alter table tb_current_lock set (autovacuum_vacuum_threshold = 5000);
alter table tb_hchk_thrd_list set (autovacuum_analyze_scale_factor = 0.1);
alter table tb_hchk_thrd_list set (autovacuum_vacuum_scale_factor = 0.2);
alter table tb_instance_info set (autovacuum_analyze_scale_factor = 0.0);
alter table tb_instance_info set (autovacuum_analyze_threshold = 5000);
alter table tb_instance_info set (autovacuum_vacuum_scale_factor = 0.0);
alter table tb_instance_info set (autovacuum_vacuum_threshold = 5000);
alter table tb_sys_log set (autovacuum_analyze_scale_factor = 0.1);
alter table tb_sys_log set (autovacuum_vacuum_scale_factor = 0.2);
alter table tb_table_info set (autovacuum_analyze_threshold = 5000);
alter table tb_table_info set (autovacuum_vacuum_threshold = 5000);
alter table tb_index_info set (autovacuum_analyze_threshold = 5000);
alter table tb_index_info set (autovacuum_vacuum_threshold = 5000);
alter table tb_tablespace_info set (autovacuum_analyze_threshold = 5000);
alter table tb_tablespace_info set (autovacuum_vacuum_threshold = 5000);
alter table tb_control_process_hist set (autovacuum_analyze_scale_factor = 0.1);
alter table tb_control_process_hist set (autovacuum_vacuum_scale_factor = 0.2);
alter table tb_user_info set (autovacuum_analyze_scale_factor = 0.1);
alter table tb_user_info set (autovacuum_vacuum_scale_factor = 0.2);
alter table tb_database_info set (autovacuum_analyze_scale_factor = 0.1);
alter table tb_database_info set (autovacuum_vacuum_scale_factor = 0.2);

-----------------------------------------------------------------------------------------------
-----------------------<create extension>------------------------------------------------------
-----------------------------------------------------------------------------------------------
create extension pg_hint_plan ;
create extension postgres_fdw ;
-----------------------------------------------------------------------------------------------
-----------------------<insert initial data>---------------------------------------------------
-----------------------------------------------------------------------------------------------
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'diskusage', '%', '0', 80.00, 90.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'bufferhitratio', '%', '1', 95.00, 90.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'commitratio', '%', '1', 80.00, 70.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'connectionfail', 'cnt', '0', 0.00, 1.00, '2', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'cpuwait', '%', '0', 50.00, 90.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'swapusage', '%', '0', 80.00, 90.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'lockcnt', 'cnt', '0', 50.00, 0.00, '1', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'traxidlecnt', 'cnt', '0', 10.00, 0.00, '1', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'longrunsql', 'sec', '0', 3.00, 0.00, '1', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'unusedindex', 'cnt', '0', 1.00, 0.00, '1', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'lastvacuum', 'day', '0', 7.00, 0.00, '1', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'lastanalyze', 'day', '0', 7.00, 0.00, '1', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'activeconnection', '%', '0', 80.00, 90.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'hastatus', 'lvl', '0', 1.00, 2.00, '0', null, null);
insert into tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) values (-1, 'replication_delay', 'mb', '0', 100, 1000, '0', null, null);

insert into tb_config(
						daily_batch_start_time
						,hchk_period_sec
						,objt_period_sec
						,stmt_period_sec
						,rtstmt_period_sec
						,log_keep_days
						,admin_user_id
						,admin_password
						,agent_ip
						,agent_port
						,last_mod_dt
						,last_mod_ip
						,serial_key
						,version
) values ('23:30:00', 30, 300, 1200, 10, 7, 'admin', 'k4m', '127.0.0.1', '5960', now(), '127.0.0.1', 'licensedat', ${EXPERDB_VERSION});

insert into tb_group_info(group_id, group_name, last_mod_dt, last_mod_ip) values (1, 'group1', now(), '127.0.0.1');
insert into tb_group_info(group_id, group_name, last_mod_dt, last_mod_ip) values (2, 'group2', now(), '127.0.0.1');
insert into tb_group_info(group_id, group_name, last_mod_dt, last_mod_ip) values (3, 'group3', now(), '127.0.0.1');
insert into tb_group_info(group_id, group_name, last_mod_dt, last_mod_ip) values (4, 'group4', now(), '127.0.0.1');

insert into tb_sys_code select 1 	 ,'shmemindexlock';
insert into tb_sys_code select 2 	 ,'oidgenlock';
insert into tb_sys_code select 3 	 ,'xidgenlock';
insert into tb_sys_code select 4 	 ,'procarraylock';
insert into tb_sys_code select 5 	 ,'sinvalreadlock';
insert into tb_sys_code select 6 	 ,'sinvalwritelock';
insert into tb_sys_code select 7 	 ,'walbufmappinglock';
insert into tb_sys_code select 8 	 ,'walwritelock';
insert into tb_sys_code select 9 	 ,'controlfilelock';
insert into tb_sys_code select 10  ,'checkpointlock';
insert into tb_sys_code select 11  ,'clogcontrollock';
insert into tb_sys_code select 12  ,'subtranscontrollock';
insert into tb_sys_code select 13  ,'multixactgenlock';
insert into tb_sys_code select 14  ,'multixactoffsetcontrollock';
insert into tb_sys_code select 15  ,'multixactmembercontrollock';
insert into tb_sys_code select 16  ,'relcacheinitlock';
insert into tb_sys_code select 17  ,'checkpointercommlock';
insert into tb_sys_code select 18  ,'twophasestatelock';
insert into tb_sys_code select 19  ,'tablespacecreatelock';
insert into tb_sys_code select 20  ,'btreevacuumlock';
insert into tb_sys_code select 21  ,'addinshmeminitlock';
insert into tb_sys_code select 22  ,'autovacuumlock';
insert into tb_sys_code select 23  ,'autovacuumschedulelock';
insert into tb_sys_code select 24  ,'syncscanlock';
insert into tb_sys_code select 25  ,'relationmappinglock';
insert into tb_sys_code select 26  ,'asyncctllock';
insert into tb_sys_code select 27  ,'asyncqueuelock';
insert into tb_sys_code select 28  ,'serializablexacthashlock';
insert into tb_sys_code select 29  ,'serializablefinishedlistlock';
insert into tb_sys_code select 30  ,'serializablepredicatelocklistlock';
insert into tb_sys_code select 31  ,'oldserxidlock';
insert into tb_sys_code select 32  ,'syncreplock';
insert into tb_sys_code select 33  ,'backgroundworkerlock';
insert into tb_sys_code select 34  ,'dynamicsharedmemorycontrollock';
insert into tb_sys_code select 35  ,'autofilelock';
insert into tb_sys_code select 36  ,'replicationslotallocationlock';
insert into tb_sys_code select 37  ,'replicationslotcontrollock';
insert into tb_sys_code select 38  ,'committscontrollock';
insert into tb_sys_code select 39  ,'committslock';
insert into tb_sys_code select 40  ,'replicationoriginlock';
insert into tb_sys_code select 41  ,'multixacttruncationlock';
insert into tb_sys_code select 42  ,'oldsnapshottimemaplock';
insert into tb_sys_code select 43  ,'backendrandomlock';
insert into tb_sys_code select 44  ,'logicalrepworkerlock';
insert into tb_sys_code select 45  ,'clogtruncationlock';
insert into tb_sys_code select 46  ,'clog';
insert into tb_sys_code select 47  ,'commit_timestamp';
insert into tb_sys_code select 48  ,'subtrans';
insert into tb_sys_code select 49  ,'multixact_offset';
insert into tb_sys_code select 50  ,'multixact_member';
insert into tb_sys_code select 51  ,'async';
insert into tb_sys_code select 52  ,'oldserxid';
insert into tb_sys_code select 53  ,'wal_insert';
insert into tb_sys_code select 54  ,'buffer_content';
insert into tb_sys_code select 55  ,'buffer_io';
insert into tb_sys_code select 56  ,'replication_origin';
insert into tb_sys_code select 57  ,'replication_slot_io';
insert into tb_sys_code select 58  ,'proc';
insert into tb_sys_code select 59  ,'buffer_mapping';
insert into tb_sys_code select 60  ,'lock_manager';
insert into tb_sys_code select 61  ,'predicate_lock_manager';
insert into tb_sys_code select 62  ,'parallel_query_dsa';
insert into tb_sys_code select 63  ,'tbm';
insert into tb_sys_code select 64  ,'relation';
insert into tb_sys_code select 65  ,'extend';
insert into tb_sys_code select 66  ,'page';
insert into tb_sys_code select 67  ,'tuple';
insert into tb_sys_code select 68  ,'transactionid';
insert into tb_sys_code select 69  ,'virtualxid';
insert into tb_sys_code select 70  ,'speculative token';
insert into tb_sys_code select 71  ,'object';
insert into tb_sys_code select 72  ,'userlock';
insert into tb_sys_code select 73  ,'advisory';
insert into tb_sys_code select 74  ,'bufferpin';
insert into tb_sys_code select 75  ,'archivermain';
insert into tb_sys_code select 76  ,'autovacuummain';
insert into tb_sys_code select 77  ,'bgwriterhibernate';
insert into tb_sys_code select 78  ,'bgwritermain';
insert into tb_sys_code select 79  ,'checkpointermain';
insert into tb_sys_code select 80  ,'logicalapplymain';
insert into tb_sys_code select 81  ,'logicallaunchermain';
insert into tb_sys_code select 82  ,'pgstatmain';
insert into tb_sys_code select 83  ,'recoverywalall';
insert into tb_sys_code select 84  ,'recoverywalstream';
insert into tb_sys_code select 85  ,'sysloggermain';
insert into tb_sys_code select 86  ,'walreceivermain';
insert into tb_sys_code select 87  ,'walsendermain';
insert into tb_sys_code select 88  ,'walwritermain';
insert into tb_sys_code select 89  ,'clientread';
insert into tb_sys_code select 90  ,'clientwrite';
insert into tb_sys_code select 91  ,'libpqwalreceiverconnect';
insert into tb_sys_code select 92  ,'libpqwalreceiverreceive';
insert into tb_sys_code select 93  ,'sslopenserver';
insert into tb_sys_code select 94  ,'walreceiverwaitstart';
insert into tb_sys_code select 95  ,'walsenderwaitforwal';
insert into tb_sys_code select 96  ,'walsenderwritedata';
insert into tb_sys_code select 97  ,'extension';
insert into tb_sys_code select 98  ,'bgworkershutdown';
insert into tb_sys_code select 99  ,'bgworkerstartup';
insert into tb_sys_code select 100 ,'btreepage';
insert into tb_sys_code select 101 ,'executegather';
insert into tb_sys_code select 102 ,'logicalsyncdata';
insert into tb_sys_code select 103 ,'logicalsyncstatechange';
insert into tb_sys_code select 104 ,'messagequeueinternal';
insert into tb_sys_code select 105 ,'messagequeueputmessage';
insert into tb_sys_code select 106 ,'messagequeuereceive';
insert into tb_sys_code select 107 ,'messagequeuesend';
insert into tb_sys_code select 108 ,'parallelbitmapscan';
insert into tb_sys_code select 109 ,'parallelfinish';
insert into tb_sys_code select 110 ,'procarraygroupupdate';
insert into tb_sys_code select 111 ,'replicationorigindrop';
insert into tb_sys_code select 112 ,'replicationslotdrop';
insert into tb_sys_code select 113 ,'safesnapshot';
insert into tb_sys_code select 114 ,'syncrep';
insert into tb_sys_code select 115 ,'basebackupthrottle';
insert into tb_sys_code select 116 ,'pgsleep';
insert into tb_sys_code select 117 ,'recoveryapplydelay';
insert into tb_sys_code select 118 ,'buffileread';
insert into tb_sys_code select 119 ,'buffilewrite';
insert into tb_sys_code select 120 ,'controlfileread';
insert into tb_sys_code select 121 ,'controlfilesync';
insert into tb_sys_code select 122 ,'controlfilesyncupdate';
insert into tb_sys_code select 123 ,'controlfilewrite';
insert into tb_sys_code select 124 ,'controlfilewriteupdate';
insert into tb_sys_code select 125 ,'copyfileread';
insert into tb_sys_code select 126 ,'copyfilewrite';
insert into tb_sys_code select 127 ,'datafileextend';
insert into tb_sys_code select 128 ,'datafileflush';
insert into tb_sys_code select 129 ,'datafileimmediatesync';
insert into tb_sys_code select 130 ,'datafileprefetch';
insert into tb_sys_code select 131 ,'datafileread';
insert into tb_sys_code select 132 ,'datafilesync';
insert into tb_sys_code select 133 ,'datafiletruncate';
insert into tb_sys_code select 134 ,'datafilewrite';
insert into tb_sys_code select 135 ,'dsmfillzerowrite';
insert into tb_sys_code select 136 ,'lockfileaddtodatadirread';
insert into tb_sys_code select 137 ,'lockfileaddtodatadirsync';
insert into tb_sys_code select 138 ,'lockfileaddtodatadirwrite';
insert into tb_sys_code select 139 ,'lockfilecreateread';
insert into tb_sys_code select 140 ,'lockfilecreatesync';
insert into tb_sys_code select 141 ,'lockfilecreatewrite';
insert into tb_sys_code select 142 ,'lockfilerecheckdatadirread';
insert into tb_sys_code select 143 ,'logicalrewritecheckpointsync';
insert into tb_sys_code select 144 ,'logicalrewritemappingsync';
insert into tb_sys_code select 145 ,'logicalrewritemappingwrite';
insert into tb_sys_code select 146 ,'logicalrewritesync';
insert into tb_sys_code select 147 ,'logicalrewritewrite';
insert into tb_sys_code select 148 ,'relationmapread';
insert into tb_sys_code select 149 ,'relationmapsync';
insert into tb_sys_code select 150 ,'relationmapwrite';
insert into tb_sys_code select 151 ,'reorderbufferread';
insert into tb_sys_code select 152 ,'reorderbufferwrite';
insert into tb_sys_code select 153 ,'reorderlogicalmappingread';
insert into tb_sys_code select 154 ,'replicationslotread';
insert into tb_sys_code select 155 ,'replicationslotrestoresync';
insert into tb_sys_code select 156 ,'replicationslotsync';
insert into tb_sys_code select 157 ,'replicationslotwrite';
insert into tb_sys_code select 158 ,'slruflushsync';
insert into tb_sys_code select 159 ,'slruread';
insert into tb_sys_code select 160 ,'slrusync';
insert into tb_sys_code select 161 ,'slruwrite';
insert into tb_sys_code select 162 ,'snapbuildread';
insert into tb_sys_code select 163 ,'snapbuildsync';
insert into tb_sys_code select 164 ,'snapbuildwrite';
insert into tb_sys_code select 165 ,'timelinehistoryfilesync';
insert into tb_sys_code select 166 ,'timelinehistoryfilewrite';
insert into tb_sys_code select 167 ,'timelinehistoryread';
insert into tb_sys_code select 168 ,'timelinehistorysync';
insert into tb_sys_code select 169 ,'timelinehistorywrite';
insert into tb_sys_code select 170 ,'twophasefileread';
insert into tb_sys_code select 171 ,'twophasefilesync';
insert into tb_sys_code select 172 ,'twophasefilewrite';
insert into tb_sys_code select 173 ,'walbootstrapsync';
insert into tb_sys_code select 174 ,'walbootstrapwrite';
insert into tb_sys_code select 175 ,'walcopyread';
insert into tb_sys_code select 176 ,'walcopysync';
insert into tb_sys_code select 177 ,'walcopywrite';
insert into tb_sys_code select 178 ,'walinitsync';
insert into tb_sys_code select 179 ,'walinitwrite';
insert into tb_sys_code select 180 ,'walread';
insert into tb_sys_code select 181 ,'walsendertimelinehistoryread';
insert into tb_sys_code select 182 ,'walsyncmethodassign';
insert into tb_sys_code select 183 ,'walwrite';
/* repository agent_port is a port of agent_manager	 
   
*/
