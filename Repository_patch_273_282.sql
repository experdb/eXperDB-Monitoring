ALTER TABLE tb_replication_info add column replay_lag_size numeric(20,0);
ALTER TABLE tb_table_info add column relid oid;
CREATE TABLE tb_table_ext_info (
    collect_dt timestamp without time ZONE,
    objt_reg_seq integer NOT NULL,
    instance_id integer NOT NULL,
    relid oid,
    autovacuum_count int8,
    autoanalyze_count int8,
    maxage int4
);    

ALTER TABLE ONLY tb_table_ext_info ADD CONSTRAINT pk_table_ext_info PRIMARY KEY (collect_dt,objt_reg_seq,instance_id,relid);
ALTER TABLE tb_table_ext_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_table_ext_info SET (autovacuum_analyze_threshold = 5000);
ALTER TABLE tb_table_ext_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_table_ext_info SET (autovacuum_vacuum_threshold = 5000);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (-1, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (1, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (2, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (3, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (4, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (5, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);
INSERT INTO tb_hchk_thrd_list (instance_id, hchk_name, unit, is_higher, warning_threshold, critical_threshold, fixed_threshold, last_mod_ip, last_mod_dt) VALUES (6, 'REPLICATION_DELAY', 'MB', '0', 100, 1000, '0', NULL, NULL);

