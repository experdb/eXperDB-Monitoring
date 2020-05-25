ALTER TABLE tb_access_info add column  agg_phy_read numeric(20,0);
ALTER TABLE tb_access_info add column  current_phy_read numeric(20,0);

CREATE TABLE TB_USER_INFO (
    reg_date character varying(8) COLLATE pg_catalog."default" NOT NULL,
    collect_dt timestamp without time zone,
    instance_id integer NOT NULL,
    user_name character varying(100) NOT NULL,
    user_id int8
);

ALTER TABLE ONLY TB_USER_INFO
    ADD CONSTRAINT pk_user_info PRIMARY KEY (reg_date, collect_dt, instance_id, user_id);

ALTER TABLE tb_user_info SET (autovacuum_analyze_scale_factor = 0.0);
ALTER TABLE tb_user_info SET (autovacuum_analyze_threshold = 1000);
ALTER TABLE tb_user_info SET (autovacuum_vacuum_scale_factor = 0.0);
ALTER TABLE tb_user_info SET (autovacuum_vacuum_threshold = 1000);
