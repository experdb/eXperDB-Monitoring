#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <dirent.h>
#include <libgen.h>
#include <sys/vfs.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <sys/time.h>
#include <unistd.h>
#include "postgres.h"
#include "funcapi.h"
#include "fmgr.h"

#define PGDATA_ENV_NM "PGDATA"
#define PROC_FULL_NAME_SIZE     1024
#define PROC_FULL_NAME  "/proc/"
#define MAX_PG_PROC_CNT 4096
#define TEMP_BUFFER_LEN 1024
#define DISK_READ_TITLE "read_bytes"
#define DISK_WRITE_TITLE "write_bytes"
#define pagetok(x)      ((x) * sysconf(_SC_PAGESIZE) >> 10)

#define CPUSTAT     "/proc/stat"
#define MAX_CPUNM_LEN 128
#define MAX_CPU_CNT 512

#define DISKSTAT    "/proc/diskstats"
#define PARTITIONS  "/proc/partitions"
#define MOUNTINFO  "/proc/self/mountinfo"
#define MAX_DISKNM_LEN 128
#define MAX_DISK_CNT 512

#define MMOUNT      "/etc/mtab"
#define MAX_DEVNM_LEN 128
#define MAX_MNTDIR_LEN 128
#define MAX_FSTYPE_LEN 128

#define MEMINFO     "/proc/meminfo"
#define BUFF_LEN 1024

#define LOC_MAX_LEN 1024

#ifdef PG_MODULE_MAGIC
PG_MODULE_MAGIC;
#endif

typedef struct _backend_rsc{
        int si_proc_id;
        unsigned long long sui_cpu_utime;
        unsigned long long sui_cpu_stime;
        unsigned long long sui_disk_read;
        unsigned long long sui_disk_write;
        unsigned long long sui_start_msec;
        unsigned long long sui_mem_rss;
        unsigned long long sui_end_msec;
        struct timeval  tv;
} PROC_INFO;

typedef struct _cpuinfo
{
        char cpuname[MAX_CPUNM_LEN];
        unsigned long long cpu_user;
        unsigned long long cpu_nice;
        unsigned long long cpu_system;
        unsigned long long cpu_idle;
        unsigned long long cpu_wait;
} CPU_P;

typedef struct _diskioinfo {
        char diskname[MAX_DISKNM_LEN];
        unsigned long long red_compl;
        unsigned long long red_merge;
        unsigned long long red_sectr;
        unsigned long long red_milsc;
        unsigned long long wrt_comp;
        unsigned long long wrt_merg;
        unsigned long long wrt_sect;
        unsigned long long wrt_mils;
        unsigned long long io_c_prc;
        unsigned long long io_comp;
        unsigned long long io_mils;
        char mountpoint[MAX_MNTDIR_LEN];
        struct timeval  tv;
} DSKST_P;

typedef struct _mountinfo
{
        char devname[MAX_DEVNM_LEN];
        char mountdir[MAX_MNTDIR_LEN];
        char fstype[MAX_FSTYPE_LEN];
        unsigned long blocks;
        unsigned long avail;
        unsigned long used;
} DSK_P;

typedef struct _meminfo
{
        unsigned long ul_MemTotal;
        unsigned long ul_MemUsed;
        unsigned long ul_MemFree;
        unsigned long ul_Buffers;
        unsigned long ul_Cached;
        unsigned long ul_SwapCached;
        unsigned long ul_SwapTotal;
        unsigned long ul_SwapFree;
        unsigned long ul_SwapUsed;
        unsigned long ul_Shmem;
} MEM_P;

PROC_INFO ST_PROC_NODES[MAX_PG_PROC_CNT];
CPU_P CP[MAX_CPU_CNT];
DSKST_P DSKSTP[MAX_DISK_CNT];
DSK_P DSKP[MAX_DISK_CNT];

int gi_counter_idx = 0;
static int gi_cpuinfo_counter_idx=0;
int gi_disk_io_counter_idx = 0;
int gi_disk_usage_counter_idx=0;

Datum v1c_get_backend_rsc(PG_FUNCTION_ARGS);
Datum v1c_get_stat_cpu_cores(PG_FUNCTION_ARGS);
Datum v1c_get_cpu_clocks(PG_FUNCTION_ARGS);
Datum v1c_get_hostname(PG_FUNCTION_ARGS);
Datum v1c_get_stat_disk_io(PG_FUNCTION_ARGS);
Datum v1c_get_stat_disk_usge(PG_FUNCTION_ARGS);
Datum v1c_get_stat_mem(PG_FUNCTION_ARGS);
Datum v1c_get_tbsdisk_avail(PG_FUNCTION_ARGS);
Datum v1c_get_tbsdisk_total(PG_FUNCTION_ARGS);

int fill_backend_node(void);
int fill_cpu_cores_node(void);
int fill_diskio_node(void);
int fill_diskusage_node(void);

PG_FUNCTION_INFO_V1(v1c_get_stat_cpu_cores);
PG_FUNCTION_INFO_V1(v1c_get_backend_rsc);
PG_FUNCTION_INFO_V1(v1c_get_cpu_clocks);
PG_FUNCTION_INFO_V1(v1c_get_hostname);
PG_FUNCTION_INFO_V1(v1c_get_stat_disk_io);
PG_FUNCTION_INFO_V1(v1c_get_stat_disk_usge);
PG_FUNCTION_INFO_V1(v1c_get_stat_mem);
PG_FUNCTION_INFO_V1(v1c_get_tbsdisk_avail);
PG_FUNCTION_INFO_V1(v1c_get_tbsdisk_total);

Datum
v1c_get_backend_rsc(PG_FUNCTION_ARGS) {
        FuncCallContext     *funcctx;
        int                  call_cntr;
        int                  max_calls;
        TupleDesc            tupdesc;
        AttInMetadata       *attinmeta;
        /* stuff done only on the first call of the function */
        if ( SRF_IS_FIRSTCALL() )
        {
                MemoryContext   oldcontext;

                /* create a function context for cross-call persistence */
                funcctx = SRF_FIRSTCALL_INIT();

                /* switch to memory context appropriate for multiple function calls */
                oldcontext = MemoryContextSwitchTo(funcctx->multi_call_memory_ctx);

                /* total number of tuples to be returned */
                funcctx->max_calls = fill_backend_node();

                /* Build a tuple descriptor for our result type */
                if (get_call_result_type(fcinfo, NULL, &tupdesc) != TYPEFUNC_COMPOSITE)
                        ereport(ERROR,
                                        (errcode(ERRCODE_FEATURE_NOT_SUPPORTED),
                                         errmsg("function returning record called in context "
                                                 "that cannot accept type record")));

                attinmeta = TupleDescGetAttInMetadata(tupdesc);
                funcctx->attinmeta = attinmeta;

                MemoryContextSwitchTo(oldcontext);
        }

        /* stuff done on every call of the function */
        funcctx = SRF_PERCALL_SETUP();
        call_cntr = funcctx->call_cntr;
        max_calls = funcctx->max_calls;
        attinmeta = funcctx->attinmeta;

        if (call_cntr < max_calls)    /* do when there is more left to send */
        {
                char       **values;
                HeapTuple    tuple;
                Datum        result;

                values = (char **) palloc(6 * sizeof(char *));
                values[0] = (char *) palloc(32 * sizeof(char));
                values[1] = (char *) palloc(32 * sizeof(char));
                values[2] = (char *) palloc(32 * sizeof(char));
                values[3] = (char *) palloc(32 * sizeof(char));
                values[4] = (char *) palloc(32 * sizeof(char));
                values[5] = (char *) palloc(32 * sizeof(char));

                snprintf( values[0], 32, "%d",   ST_PROC_NODES[gi_counter_idx].si_proc_id   );
                snprintf( values[1], 32, "%llu",  ST_PROC_NODES[gi_counter_idx].sui_cpu_utime );
                snprintf( values[2], 32, "%llu",  ST_PROC_NODES[gi_counter_idx].sui_cpu_stime );
                snprintf( values[3], 32, "%llu",  ST_PROC_NODES[gi_counter_idx].sui_disk_read / 1024 );
                snprintf( values[4], 32, "%llu",  ST_PROC_NODES[gi_counter_idx].sui_disk_write / 1024 );
                snprintf( values[5], 32, "%ld.%03ld", ST_PROC_NODES[gi_counter_idx].tv.tv_sec,ST_PROC_NODES[gi_counter_idx].tv.tv_usec);

                /* build a tuple */
                tuple = BuildTupleFromCStrings(attinmeta, values);

                /* make the tuple into a datum */
                result = HeapTupleGetDatum(tuple);

                /* clean up (this is not really necessary) */
                pfree(values[0]);
                pfree(values[1]);
                pfree(values[2]);
                pfree(values[3]);
                pfree(values[4]);
                pfree(values[5]);
                pfree(values);

                gi_counter_idx++;
                SRF_RETURN_NEXT(funcctx, result);
        }
        else {   /* do when there is no more left */
                gi_counter_idx = 0;
                SRF_RETURN_DONE(funcctx);
        }
}

int fill_backend_node(void) {
        FILE *lfp_pg_pid_file;
        char temp[1024];
        char ls_pgdata_dir[1024];
        int  li_backend_count;
        int  li_parent_pid;
        int  li_temp_pid;
        int  li_temp_ppid;
        unsigned long long lui_temp_cpu_utime, lui_temp_cpu_stime, lui_temp_mem_rss;

        DIR     *dir_info;
        struct  dirent  *dir_entry;
        FILE *lfp_stat_file = NULL;
        FILE *lfp_io_file = NULL;
        char ls_stat_file_nm[PROC_FULL_NAME_SIZE];
        char ls_io_file_nm[PROC_FULL_NAME_SIZE];
        char ls_temp_string[TEMP_BUFFER_LEN];
        char *lcp_string_cursor = NULL;
        char ls_proc_pid[10240][16];
        int li_proc_cnt=0;
        int li_proc_idx=0;
        li_temp_pid = 0;
        li_temp_ppid = 0;
        lui_temp_cpu_utime=0;
        lui_temp_cpu_stime=0;
        lui_temp_mem_rss=0;
        li_parent_pid = 0;
        li_backend_count = 0;
        memset(ls_pgdata_dir, 0x00, sizeof(ls_pgdata_dir));
        memset(temp, 0x00, sizeof(temp));
        memset(ls_temp_string, 0x00, sizeof(ls_temp_string));
        memset(ls_proc_pid, 0x00, sizeof(ls_proc_pid));

        if( !getenv(PGDATA_ENV_NM) ) {
                return 0;
        }

        // read postgresql data_directory

        //strncpy(ls_pgdata_dir, getenv(PGDATA_ENV_NM), strlen(getenv(PGDATA_ENV_NM)));
        sprintf(ls_pgdata_dir, "%s", getenv(PGDATA_ENV_NM));
        strcat(ls_pgdata_dir, "/postmaster.pid");

        // get postgresql group pid from postmaster.pid
        lfp_pg_pid_file = fopen(ls_pgdata_dir, "r");

        if( !lfp_pg_pid_file ) {
                return 0;
        }

        fgets( temp, 1023, lfp_pg_pid_file );
        //fscanf(lfp_pg_pid_file, "%d", &li_parent_pid);
        sscanf( temp, "%d", &li_parent_pid );
        if( 0 != fclose(lfp_pg_pid_file) ) return 0;

        // read child process list from /proc/[1-9]*/status files which stores parent PID
        dir_info = opendir(PROC_FULL_NAME);
        if(NULL != dir_info) {
                while((dir_entry = readdir(dir_info))) {
                        if (dir_entry->d_type == DT_DIR && *dir_entry->d_name > '0' && *dir_entry->d_name <= '9') {
                                sprintf( ls_proc_pid[li_proc_cnt++], "%s", dir_entry->d_name );
                        }
                }
                closedir(dir_info);
                for(li_proc_idx=0;li_proc_idx<li_proc_cnt; li_proc_idx++) {
                        //char ls_stat_file_nm[PROC_FULL_NAME_SIZE];
                        memset( ls_stat_file_nm, 0x00, PROC_FULL_NAME_SIZE );
                        //sprintf( ls_stat_file_nm, "%s%s/stat", PROC_FULL_NAME, ls_proc_pid[li_proc_idx] ); //LEAK
                        sprintf( ls_stat_file_nm, "%s%s/stat", PROC_FULL_NAME, ls_proc_pid[li_proc_idx] ); //LEAK
                        if ( 0 == access( ls_stat_file_nm, R_OK)) {
                                lfp_stat_file = fopen(ls_stat_file_nm, "r");
                                if( !lfp_stat_file ) {
                                        return 0;
                                }
                                //fscanf(lfp_stat_file, "%d %*s %*s %d %*s %*s %*s %*s %*s %*s %*s %*s %*s %llu %llu %*s %*s %*s %*s %*s %*s %*s %*s %*s ", &li_temp_pid, &li_temp_ppid, &lui_temp_cpu_utime, &lui_temp_cpu_stime, &lui_temp_mem_rss);
                                fscanf(lfp_stat_file, "%d %*s %*s %d %*s %*s %*s %*s %*s %*s %*s %*s %*s %llu %llu %*s %*s %*s %*s %*s %*s %*s %*s %llu", &li_temp_pid, &li_temp_ppid, &lui_temp_cpu_utime, &lui_temp_cpu_stime, &lui_temp_mem_rss);
                                if( 0 != (fclose(lfp_stat_file)) ) return 0;
                                if( li_temp_ppid == li_parent_pid ) {
                                        gettimeofday(&ST_PROC_NODES[li_backend_count].tv, NULL);
                                        ST_PROC_NODES[li_backend_count].si_proc_id    = li_temp_pid ;
                                        ST_PROC_NODES[li_backend_count].sui_cpu_utime = lui_temp_cpu_utime;
                                        ST_PROC_NODES[li_backend_count].sui_cpu_stime = lui_temp_cpu_stime;
                                        ST_PROC_NODES[li_backend_count].sui_mem_rss = lui_temp_mem_rss;
                                        memset(ls_io_file_nm, 0x00, PROC_FULL_NAME_SIZE);
                                        sprintf( ls_io_file_nm, "%s%d/io", PROC_FULL_NAME, li_temp_pid );
                                        if ( 0 == access( ls_io_file_nm, R_OK)) {
                                                lfp_io_file = fopen(ls_io_file_nm, "r");
                                                if( !lfp_io_file ) {
                                                        return 0;
                                                }
                                                while( (fgets(ls_temp_string, TEMP_BUFFER_LEN-1, lfp_io_file)) ) {
                                                        if( (lcp_string_cursor = strstr(ls_temp_string, DISK_READ_TITLE)) ) {
                                                                sscanf(ls_temp_string, "%*s %llu", &ST_PROC_NODES[li_backend_count].sui_disk_read);
                                                        }
                                                        // not cancelled_write_bytes
                                                        else if( *ls_temp_string != 'c' && (lcp_string_cursor = strstr(ls_temp_string, DISK_WRITE_TITLE)) ) {
                                                                sscanf(ls_temp_string, "%*s %llu", &ST_PROC_NODES[li_backend_count].sui_disk_write);
                                                        }
                                                        else continue;
                                                }
                                                if( 0 != (fclose(lfp_io_file)) ) return 0;
                                                li_backend_count++;
                                        } else continue;
                                }
                        } else continue;
                }
        } else return 0;
        return li_backend_count;
}

Datum
v1c_get_stat_cpu_cores(PG_FUNCTION_ARGS) {
        FuncCallContext     *funcctx;
        int                  call_cntr;
        int                  max_calls;
        TupleDesc            tupdesc;
        AttInMetadata       *attinmeta;
        /* stuff done only on the first call of the function */
        if ( SRF_IS_FIRSTCALL() )
        {
                MemoryContext   oldcontext;

                /* create a function context for cross-call persistence */
                funcctx = SRF_FIRSTCALL_INIT();

                /* switch to memory context appropriate for multiple function calls */
                oldcontext = MemoryContextSwitchTo(funcctx->multi_call_memory_ctx);

                /* total number of tuples to be returned */
                funcctx->max_calls = fill_cpu_cores_node();

                /* Build a tuple descriptor for our result type */
                if (get_call_result_type(fcinfo, NULL, &tupdesc) != TYPEFUNC_COMPOSITE)
                        ereport(ERROR,
                                        (errcode(ERRCODE_FEATURE_NOT_SUPPORTED),
                                         errmsg("function returning record called in context "
                                                 "that cannot accept type record")));

                /*
                 * ** generate attribute metadata needed later to produce tuples from raw C strings
                 *  */
                attinmeta = TupleDescGetAttInMetadata(tupdesc);
                funcctx->attinmeta = attinmeta;

                MemoryContextSwitchTo(oldcontext);
        }

        /* stuff done on every call of the function */
        funcctx = SRF_PERCALL_SETUP();
        call_cntr = funcctx->call_cntr;
        max_calls = funcctx->max_calls;
        attinmeta = funcctx->attinmeta;

        if (call_cntr < max_calls)    /* do when there is more left to send */
        {
                char       **values;
                HeapTuple    tuple;
                Datum        result;

                /*
                 *  *          * Prepare a values array for building the returned tuple.
                 *   *                   * This should be an array of C strings which will
                 *    *                            * be processed later by the type input functions.
                 *     *                                     */
                values = (char **) palloc(7 * sizeof(char *));
                values[0] = (char *) palloc(32 * sizeof(char));
                values[1] = (char *) palloc(32 * sizeof(char));
                values[2] = (char *) palloc(32 * sizeof(char));
                values[3] = (char *) palloc(32 * sizeof(char));
                values[4] = (char *) palloc(32 * sizeof(char));
                values[5] = (char *) palloc(32 * sizeof(char));
                values[6] = (char *) palloc(32 * sizeof(char));

                snprintf( values[0], 32, "%s",    CP[gi_cpuinfo_counter_idx].cpuname  );
                snprintf( values[1], 32, "%llu",  CP[gi_cpuinfo_counter_idx].cpu_user );
                snprintf( values[2], 32, "%llu",  CP[gi_cpuinfo_counter_idx].cpu_nice );
                snprintf( values[3], 32, "%llu",  CP[gi_cpuinfo_counter_idx].cpu_system );
                snprintf( values[4], 32, "%llu",  CP[gi_cpuinfo_counter_idx].cpu_idle );
                snprintf( values[5], 32, "%llu",  CP[gi_cpuinfo_counter_idx].cpu_wait  );
                snprintf( values[6], 32, "%d", gi_cpuinfo_counter_idx+1);

                /* build a tuple */
                tuple = BuildTupleFromCStrings(attinmeta, values);

                /* make the tuple into a datum */
                result = HeapTupleGetDatum(tuple);

                /* clean up (this is not really necessary) */
                pfree(values[0]);
                pfree(values[1]);
                pfree(values[2]);
                pfree(values[3]);
                pfree(values[4]);
                pfree(values[5]);
                pfree(values[6]);
                pfree(values);
                gi_cpuinfo_counter_idx++;
                SRF_RETURN_NEXT(funcctx, result);
        }
        else    /* do when there is no more left */
        {
                gi_cpuinfo_counter_idx = 0;
                SRF_RETURN_DONE(funcctx);
        }
}

int fill_cpu_cores_node(void) {
        FILE *cpu_fp;
        char ls_cpu_name[10];
        unsigned long long li_cpu_user=0;
        unsigned long long li_cpu_nice=0;
        unsigned long long li_cpu_system=0;
        unsigned long long li_cpu_idle=0;
        unsigned long long li_cpu_wait=0;
        int li_counter=0;
        char buf[1024];
        memset(ls_cpu_name, 0x00, sizeof(ls_cpu_name));

        cpu_fp=fopen(CPUSTAT, "r");
        if( ! cpu_fp ) return 0;

        while(fgets(buf, sizeof(buf), cpu_fp))
        {
                sscanf(buf, "%s %llu %llu %llu %llu %llu ",ls_cpu_name, &li_cpu_user,&li_cpu_nice,&li_cpu_system,&li_cpu_idle,&li_cpu_wait);
                if (strncmp(ls_cpu_name,"cpu",3) == 0)
                {
                        strcpy(CP[li_counter].cpuname, ls_cpu_name);
                        CP[li_counter].cpu_user    = li_cpu_user   ;
                        CP[li_counter].cpu_nice    = li_cpu_nice   ;
                        CP[li_counter].cpu_system  = li_cpu_system ;
                        CP[li_counter].cpu_idle    = li_cpu_idle   ;
                        CP[li_counter].cpu_wait    = li_cpu_wait   ;
                        li_counter++;
                }
        }
        if( 0 != fclose(cpu_fp) ) return 0;
        return li_counter;
}

Datum
v1c_get_cpu_clocks(PG_FUNCTION_ARGS) {
        PG_RETURN_INT32(sysconf(_SC_CLK_TCK));
}

Datum
v1c_get_hostname(PG_FUNCTION_ARGS) {
        char hostname[80] = {0x00};
        text *hostname_res = (text *)palloc(sizeof(hostname)+VARHDRSZ);
        if( 0 !=  gethostname(hostname, sizeof(hostname)) ) {
                memcpy(hostname, "Unknown", sizeof("Unknown"));
        }
        SET_VARSIZE(hostname_res, VARHDRSZ + sizeof(hostname));
        memcpy(VARDATA(hostname_res), hostname, sizeof(hostname));
        PG_RETURN_TEXT_P(hostname_res);
}

Datum
v1c_get_stat_disk_io(PG_FUNCTION_ARGS) {
        FuncCallContext     *funcctx;
        int                  call_cntr;
        int                  max_calls;
        TupleDesc            tupdesc;
        AttInMetadata       *attinmeta;


        /* stuff done only on the first call of the function */
        if (SRF_IS_FIRSTCALL())
        {
                MemoryContext   oldcontext;

                /* create a function context for cross-call persistence */
                funcctx = SRF_FIRSTCALL_INIT();

                /* switch to memory context appropriate for multiple function calls */
                oldcontext = MemoryContextSwitchTo(funcctx->multi_call_memory_ctx);

                /* total number of tuples to be returned */
                /* ------디스크 파티션 갯수 카운팅 및 리턴튜플 갯수 할당 */
                funcctx->max_calls = fill_diskio_node();

                /* Build a tuple descriptor for our result type */
                if (get_call_result_type(fcinfo, NULL, &tupdesc) != TYPEFUNC_COMPOSITE)
                        ereport(ERROR,
                                        (errcode(ERRCODE_FEATURE_NOT_SUPPORTED),
                                         errmsg("function returning record called in context "
                                                 "that cannot accept type record")));

                /*
                 *          * generate attribute metadata needed later to produce tuples from raw
                 *                   * C strings
                 *                            */
                attinmeta = TupleDescGetAttInMetadata(tupdesc);
                funcctx->attinmeta = attinmeta;

                MemoryContextSwitchTo(oldcontext);
        }

        /* stuff done on every call of the function */
        funcctx = SRF_PERCALL_SETUP();
        call_cntr = funcctx->call_cntr;
        max_calls = funcctx->max_calls;
        attinmeta = funcctx->attinmeta;

        if (call_cntr < max_calls)    /* do when there is more left to send */
        {
                char       **values;
                HeapTuple    tuple;
                Datum        result;

                /*
                 *          * Prepare a values array for building the returned tuple.
                 *                   * This should be an array of C strings which will
                 *                            * be processed later by the type input functions.
                 *                                     */
                values = (char **) palloc(12 * sizeof(char *));
                values[0] = (char *) palloc(32 * sizeof(char));
                values[1] = (char *) palloc(32 * sizeof(char));
                values[2] = (char *) palloc(32 * sizeof(char));
                values[3] = (char *) palloc(32 * sizeof(char));
                values[4] = (char *) palloc(32 * sizeof(char));
                values[5] = (char *) palloc(32 * sizeof(char));
                values[6] = (char *) palloc(32 * sizeof(char));
                values[7] = (char *) palloc(32 * sizeof(char));
                values[8] = (char *) palloc(32 * sizeof(char));
                values[9] = (char *) palloc(32 * sizeof(char));
                values[10]= (char *) palloc(32 * sizeof(char));
                values[11]= (char *) palloc(32 * sizeof(char));

                snprintf( values[0], 32, "%s",   DSKSTP[gi_disk_io_counter_idx].diskname  );
                snprintf( values[1], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].red_compl );
                snprintf( values[2], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].red_merge );
                snprintf( values[3], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].red_sectr );
                snprintf( values[4], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].red_milsc );
                snprintf( values[5], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].wrt_comp  );
                snprintf( values[6], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].wrt_merg  );
                snprintf( values[7], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].wrt_sect  );
                //snprintf( values[8], 32, "%lu",  DSKSTP[gi_disk_io_counter_idx].wrt_mils  );
                snprintf( values[8], 32, "%llu",  DSKSTP[gi_disk_io_counter_idx].io_comp  );
                snprintf( values[9], 32, "%ld.%03ld", DSKSTP[gi_disk_io_counter_idx].tv.tv_sec,DSKSTP[gi_counter_idx].tv.tv_usec);
                snprintf( values[10],32, "%d", gi_disk_io_counter_idx+1);
                snprintf( values[11],32, "%s",   DSKSTP[gi_disk_io_counter_idx].mountpoint );

                /* build a tuple */
                tuple = BuildTupleFromCStrings(attinmeta, values);

                /* make the tuple into a datum */
                result = HeapTupleGetDatum(tuple);

                /* clean up (this is not really necessary) */
                pfree(values[0]);
                pfree(values[1]);
                pfree(values[2]);
                pfree(values[3]);
                pfree(values[4]);
                pfree(values[5]);
                pfree(values[6]);
                pfree(values[7]);
                pfree(values[8]);
                pfree(values[9]);
                pfree(values[10]);
                pfree(values[11]);
                pfree(values);
                gi_disk_io_counter_idx++;
                SRF_RETURN_NEXT(funcctx, result);
        }
        else    /* do when there is no more left */
        {
                gi_disk_io_counter_idx=0;
                SRF_RETURN_DONE(funcctx);
        }
}

int fill_diskio_node(void) {
        char ls_partname[20];
        int li_counter_outer=0;
        char ls_buf[512];
        char buf[512];
        char m_buf[512];
        int li_temp=0;
        char ls_diskname[10];
        unsigned long li_red_compl=0;
        unsigned long li_red_merge=0;
        unsigned long li_red_sectr=0;
        unsigned long li_red_milsc=0;
        unsigned long li_wrt_comp=0;
        unsigned long li_wrt_merg=0;
        unsigned long li_wrt_sect=0;
        unsigned long li_wrt_mils=0;
        unsigned long li_io_c_prc=0;
        unsigned long li_io_comp=0;
        unsigned long li_io_mils=0;
        /* 20181109 Add mountpoint for disk io*/
        int major_number=0;
        int minor_number=0;
        int major_number_disk=0;
        int minor_number_disk=0;
        char ls_sdevno[16];
        char sdevno[10];
        char ls_stemp[MAX_MNTDIR_LEN];
        char ls_mountpoint[MAX_MNTDIR_LEN];

        FILE *dskst_fp=NULL;
        FILE *prt_fp=NULL;
        FILE *mi_fp=NULL;

        dskst_fp=fopen(DISKSTAT, "r");
        prt_fp=fopen(PARTITIONS, "r");
        mi_fp=fopen(MOUNTINFO, "r");
        if( !dskst_fp || !prt_fp ) return 0;
        memset(ls_buf, 0x00, sizeof(ls_buf));
        memset(buf, 0x00, sizeof(buf));
        memset(m_buf, 0x00, sizeof(m_buf));
        while(fgets(ls_buf, sizeof(ls_buf), prt_fp)) {
                sscanf(ls_buf, "%d %d %d %s", &major_number, &minor_number, &li_temp, ls_partname );
                while(fgets(buf, sizeof(buf), dskst_fp)) {
                        sscanf(buf, "%d %d %s", &li_temp, &li_temp, ls_diskname);
                        //if(strcmp(ls_diskname,ls_partname)==0)
                        if(strcmp(ls_diskname,ls_partname)==0) {
                                sscanf(buf, "%d %d %s %lu %lu %lu %lu %lu %lu %lu %lu %lu %lu %lu"
                                                , &major_number_disk, &minor_number_disk, ls_diskname, &li_red_compl, &li_red_merge
                                                , &li_red_sectr, &li_red_milsc, &li_wrt_comp, &li_wrt_merg, &li_wrt_sect, &li_wrt_mils, &li_io_c_prc, &li_io_comp, &li_io_mils);

                                strcpy(DSKSTP[li_counter_outer].diskname, ls_diskname);
                                DSKSTP[li_counter_outer].red_compl       = li_red_compl ;
                                DSKSTP[li_counter_outer].red_merge       = li_red_merge ;
                                DSKSTP[li_counter_outer].red_sectr       = li_red_sectr*512/1024 ;
                                DSKSTP[li_counter_outer].red_milsc       = li_red_milsc ;
                                DSKSTP[li_counter_outer].wrt_comp        = li_wrt_comp  ;
                                DSKSTP[li_counter_outer].wrt_merg        = li_wrt_merg  ;
                                DSKSTP[li_counter_outer].wrt_sect        = li_wrt_sect *512/1024 ;
                                DSKSTP[li_counter_outer].wrt_mils        = li_wrt_mils  ;
                                DSKSTP[li_counter_outer].io_c_prc        = li_io_c_prc  ;
                                DSKSTP[li_counter_outer].io_comp         = li_io_comp   ;
                                DSKSTP[li_counter_outer].io_mils         = li_io_mils   ;
                                gettimeofday(&DSKSTP[li_counter_outer].tv, NULL);

                                if(mi_fp){
                                        sprintf(sdevno, "%d:%d", major_number_disk, minor_number_disk);
                                        fgets(m_buf, sizeof(m_buf), mi_fp);
                                        while(fgets(m_buf, sizeof(m_buf), mi_fp)) {
                                                sscanf(m_buf, "%s %s %s %s %s %s %s %s %s %s %s",
                                                                ls_stemp, ls_stemp, ls_sdevno, ls_stemp, ls_mountpoint,
                                                                ls_stemp, ls_stemp, ls_stemp, ls_stemp, ls_stemp, ls_stemp);
                                                if(strcmp(sdevno,ls_sdevno)==0) {
                                                        strncpy(DSKSTP[li_counter_outer].mountpoint, ls_mountpoint, MAX_MNTDIR_LEN);
                                                }
                                        }
                                        rewind(mi_fp);
                                }
                                li_counter_outer++;

                        }
                }
                rewind(dskst_fp);
        }

        if(mi_fp)
                fclose(mi_fp);
        if(dskst_fp)
                fclose(dskst_fp);
        if(prt_fp)
                fclose(prt_fp);
        return li_counter_outer;
}

Datum
v1c_get_stat_disk_usge(PG_FUNCTION_ARGS) {
        FuncCallContext     *funcctx;
        int                  call_cntr;
        int                  max_calls;
        TupleDesc            tupdesc;
        AttInMetadata       *attinmeta;

        /* stuff done only on the first call of the function */
        if (SRF_IS_FIRSTCALL())
        {
                MemoryContext   oldcontext;

                /* create a function context for cross-call persistence */
                funcctx = SRF_FIRSTCALL_INIT();

                /* switch to memory context appropriate for multiple function calls */
                oldcontext = MemoryContextSwitchTo(funcctx->multi_call_memory_ctx);

                /* total number of tuples to be returned */
                /* ------디스크 파티션 갯수 카운팅 및 리턴튜플 갯수 할당 */
                funcctx->max_calls = fill_diskusage_node();

                /* Build a tuple descriptor for our result type */
                if (get_call_result_type(fcinfo, NULL, &tupdesc) != TYPEFUNC_COMPOSITE)
                        ereport(ERROR,
                                        (errcode(ERRCODE_FEATURE_NOT_SUPPORTED),
                                         errmsg("function returning record called in context "
                                                 "that cannot accept type record")));

                /*
                 *          * generate attribute metadata needed later to produce tuples from raw
                 *                   * C strings
                 *                            */
                attinmeta = TupleDescGetAttInMetadata(tupdesc);
                funcctx->attinmeta = attinmeta;

                MemoryContextSwitchTo(oldcontext);
        }

        /* stuff done on every call of the function */
        funcctx = SRF_PERCALL_SETUP();
        call_cntr = funcctx->call_cntr;
        max_calls = funcctx->max_calls;
        attinmeta = funcctx->attinmeta;

        if (call_cntr < max_calls)    /* do when there is more left to send */
        {
                char       **values;
                HeapTuple    tuple;
                Datum        result;

                /*
                 *          * Prepare a values array for building the returned tuple.
                 *                   * This should be an array of C strings which will
                 *                            * be processed later by the type input functions.
                 *                                     */
                values = (char **) palloc(6 * sizeof(char *));
                values[0] = (char *) palloc(32 * sizeof(char));
                values[1] = (char *) palloc(32 * sizeof(char));
                values[2] = (char *) palloc(32 * sizeof(char));
                values[3] = (char *) palloc(32 * sizeof(char));
                values[4] = (char *) palloc(32 * sizeof(char));
                values[5] = (char *) palloc(32 * sizeof(char));

                snprintf(values[0], 32, "%s", DSKP[gi_disk_usage_counter_idx].devname);
                snprintf(values[1], 32, "%s", DSKP[gi_disk_usage_counter_idx].mountdir);
                snprintf(values[2], 32, "%lu", DSKP[gi_disk_usage_counter_idx].blocks);
                snprintf(values[3], 32, "%lu", DSKP[gi_disk_usage_counter_idx].avail);
                snprintf(values[4], 32, "%lu", DSKP[gi_disk_usage_counter_idx].used);
                snprintf(values[5], 32, "%d", gi_disk_usage_counter_idx+1);


                //fprintf(fp, "%s", DSKP[li_counter].devname);
                //fprintf(fp, "%s", DSKP[li_counter].mountdir);
                //fprintf(fp, "%lu", DSKP[li_counter].blocks);
                //fprintf(fp, "%lu", DSKP[li_counter].avail);
                //fprintf(fp, "%lu", DSKP[li_counter].used);
                /* build a tuple */
                tuple = BuildTupleFromCStrings(attinmeta, values);

                /* make the tuple into a datum */
                result = HeapTupleGetDatum(tuple);

                /* clean up (this is not really necessary) */
                pfree(values[0]);
                pfree(values[1]);
                pfree(values[2]);
                pfree(values[3]);
                pfree(values[4]);
                pfree(values[5]);
                pfree(values);
                gi_disk_usage_counter_idx++;
                SRF_RETURN_NEXT(funcctx, result);
        }
        else    /* do when there is no more left */
        {
                gi_disk_usage_counter_idx=0;
                SRF_RETURN_DONE(funcctx);
        }
}

int fill_diskusage_node(void) {
        char ls_devname[80];
        char ls_mountdir[20];
        char ls_fstype[12];
        unsigned long lul_blocks=0;
        unsigned long lul_avail=0;
        unsigned long lul_used=0;

        //if(!mnt_fp)     exit;
        struct statfs lstatfs;
        struct stat lstat;

        int li_counter=0;
        int is_root;
        char ls_buf[1024];

        FILE *mnt_fp=fopen(MMOUNT, "r");
        if( !mnt_fp ) return 0;

        while(fgets(ls_buf, sizeof(ls_buf), mnt_fp)) {
                is_root = 0;
                sscanf( ls_buf, "%s %s %s %lu %lu %lu ",ls_devname, ls_mountdir, ls_fstype, &lul_blocks, &lul_avail, &lul_used );
                if (strcmp(ls_mountdir,"/") == 0 || strcmp(ls_devname ,"tmpfs") == 0 ) is_root=1;
                if (stat(ls_devname, &lstat) == 0 || is_root ) {
                        if ((strstr(ls_buf, ls_mountdir) && S_ISBLK(lstat.st_mode)) || is_root) {
                                statfs(ls_mountdir, &lstatfs);
                                //lul_blocks = lstatfs.f_blocks * (lstatfs.f_bsize / 1024 ) / 1024 ;
                                //lul_avail  = lstatfs.f_bavail * (lstatfs.f_bsize / 1024 ) / 1024 ;
                                lul_blocks = lstatfs.f_blocks * (lstatfs.f_bsize / 1024 ) ;
                                lul_avail  = lstatfs.f_bavail * (lstatfs.f_bsize / 1024 ) ;
                                lul_used   = lul_blocks - lul_avail;

                                strcpy(DSKP[li_counter].devname ,ls_devname);
                                strcpy(DSKP[li_counter].mountdir,ls_mountdir);
                                strcpy(DSKP[li_counter].fstype,  ls_fstype);
                                DSKP[li_counter].blocks = lul_blocks;
                                DSKP[li_counter].avail  = lul_avail;
                                DSKP[li_counter].used   = lul_used;
                                //printf("%-10s %-30s %10lu MB %10lu MB\n" , DSKP[li_counter].mountdir, DSKP[li_counter].devname, DSKP[li_counter].blocks, DSKP[li_counter].avail);
                                li_counter++;
                        }
                }
        }
        if( 0 != fclose(mnt_fp) ) return 0;
        return li_counter;
}

Datum
v1c_get_stat_mem(PG_FUNCTION_ARGS) {
        MEM_P memory = {0x00};
        char ls_buf[BUFF_LEN];
        char ls_buf_item[BUFF_LEN];
        unsigned long lul_temp=0;

        FuncCallContext     *funcctx;
        int                  call_cntr;
        int                  max_calls;
        TupleDesc            tupdesc;
        AttInMetadata       *attinmeta;


        FILE *mem_fp = fopen(MEMINFO, "r");
        if( !mem_fp ) return 0;
        while(fgets(ls_buf, sizeof(ls_buf), mem_fp)) {
                sscanf(ls_buf, "%s %lu", ls_buf_item, &lul_temp);
                if     (strcmp(ls_buf_item, "MemTotal:")   == 0)        memory.ul_MemTotal   = lul_temp;
                else if(strcmp(ls_buf_item, "MemFree:")    == 0)        memory.ul_MemFree    = lul_temp;
                else if(strcmp(ls_buf_item, "Buffers:")    == 0)        memory.ul_Buffers    = lul_temp;
                else if(strcmp(ls_buf_item, "Cached:")     == 0)        memory.ul_Cached     = lul_temp;
                else if(strcmp(ls_buf_item, "SwapCached:") == 0)        memory.ul_SwapCached = lul_temp;
                else if(strcmp(ls_buf_item, "SwapTotal:")  == 0)        memory.ul_SwapTotal  = lul_temp;
                else if(strcmp(ls_buf_item, "SwapFree:")   == 0)        memory.ul_SwapFree   = lul_temp;
                else if(strcmp(ls_buf_item, "Shmem:")      == 0)        memory.ul_Shmem      = lul_temp;
                else continue;
        }
        if( 0 != fclose(mem_fp) ) return 0;
        memory.ul_MemUsed  = memory.ul_MemTotal  - memory.ul_MemFree;
        memory.ul_SwapUsed = memory.ul_SwapTotal - memory.ul_SwapFree;
        /* stuff done only on the first call of the function */
        if (SRF_IS_FIRSTCALL())
        {
                MemoryContext   oldcontext;

                /* create a function context for cross-call persistence */
                funcctx = SRF_FIRSTCALL_INIT();

                /* switch to memory context appropriate for multiple function calls */
                oldcontext = MemoryContextSwitchTo(funcctx->multi_call_memory_ctx);

                /* total number of tuples to be returned */
                funcctx->max_calls = 1;

                /* Build a tuple descriptor for our result type */
                if (get_call_result_type(fcinfo, NULL, &tupdesc) != TYPEFUNC_COMPOSITE)
                        ereport(ERROR,
                                        (errcode(ERRCODE_FEATURE_NOT_SUPPORTED),
                                         errmsg("function returning record called in context "
                                                 "that cannot accept type record")));

                /*
                 *          * generate attribute metadata needed later to produce tuples from raw
                 *                   * C strings
                 *                            */
                attinmeta = TupleDescGetAttInMetadata(tupdesc);
                funcctx->attinmeta = attinmeta;

                MemoryContextSwitchTo(oldcontext);
        }

        /* stuff done on every call of the function */
        funcctx = SRF_PERCALL_SETUP();

        call_cntr = funcctx->call_cntr;
        max_calls = funcctx->max_calls;
        attinmeta = funcctx->attinmeta;

        if (call_cntr < max_calls)    /* do when there is more left to send */
        {
                char       **values;
                HeapTuple    tuple;
                Datum        result;

                /*
                 *          * Prepare a values array for building the returned tuple.
                 *                   * This should be an array of C strings which will
                 *                            * be processed later by the type input functions.
                 *                                     */
                values = (char **) palloc(10 * sizeof(char *));
                /*int cnt;
                  for(cnt=0;cnt<10;cnt++){
                  values[cnt]  = (char *) palloc(32 * sizeof(char));
                  } */

                values[0] = (char *) palloc(32 * sizeof(char));
                values[1] = (char *) palloc(32 * sizeof(char));
                values[2] = (char *) palloc(32 * sizeof(char));
                values[3] = (char *) palloc(32 * sizeof(char));
                values[4] = (char *) palloc(32 * sizeof(char));
                values[5] = (char *) palloc(32 * sizeof(char));
                values[6] = (char *) palloc(32 * sizeof(char));
                values[7] = (char *) palloc(32 * sizeof(char));
                values[8] = (char *) palloc(32 * sizeof(char));
                values[9] = (char *) palloc(32 * sizeof(char));

                snprintf(values[0],  32, "%lu", memory.ul_MemTotal  );
                snprintf(values[1],  32, "%lu", memory.ul_MemUsed   );
                snprintf(values[2],  32, "%lu", memory.ul_MemFree   );
                snprintf(values[3],  32, "%lu", memory.ul_Buffers   );
                snprintf(values[4],  32, "%lu", memory.ul_Cached    );
                snprintf(values[5],  32, "%lu", memory.ul_SwapTotal );
                snprintf(values[6],  32, "%lu", memory.ul_SwapUsed  );
                snprintf(values[7],  32, "%lu", memory.ul_SwapCached);
                snprintf(values[8],  32, "%lu", memory.ul_SwapFree  );
                snprintf(values[9],  32, "%lu", memory.ul_Shmem     );

                /* build a tuple */
                tuple = BuildTupleFromCStrings(attinmeta, values);

                /* make the tuple into a datum */
                result = HeapTupleGetDatum(tuple);

                /* clean up (this is not really necessary) */
                /*for(cnt=0;cnt<10;cnt++){
                  pfree(values[cnt]);
                  }*/
                pfree(values[0]);
                pfree(values[1]);
                pfree(values[2]);
                pfree(values[3]);
                pfree(values[4]);
                pfree(values[5]);
                pfree(values[6]);
                pfree(values[7]);
                pfree(values[8]);
                pfree(values[9]);
                pfree(values);

                SRF_RETURN_NEXT(funcctx, result);
        }
        else    /* do when there is no more left */
        {
                SRF_RETURN_DONE(funcctx);
        }
}

Datum
v1c_get_tbsdisk_avail(PG_FUNCTION_ARGS) {
        char ls_tbs_loc[LOC_MAX_LEN] = { 0x00 };
        struct statfs ls_tbs_fs;
        unsigned long lul_aval_kb = 0;

        text *tbs_path = PG_GETARG_TEXT_P(0);

        memcpy((void*)ls_tbs_loc, (void*)VARDATA(tbs_path), VARSIZE(tbs_path)-VARHDRSZ);

        if(statfs(ls_tbs_loc, &ls_tbs_fs) == 0) {
                lul_aval_kb = ls_tbs_fs.f_bavail * ls_tbs_fs.f_bsize/1024;
        }

        PG_RETURN_FLOAT8(lul_aval_kb);
}

Datum
v1c_get_tbsdisk_total(PG_FUNCTION_ARGS) {
        char ls_tbs_loc[LOC_MAX_LEN] = { 0x00 };
        struct statfs ls_tbs_fs;
        unsigned long lul_tot_kb = 0;

        text *tbs_path = PG_GETARG_TEXT_P(0);

        memcpy((void*)ls_tbs_loc, (void*)VARDATA(tbs_path), VARSIZE(tbs_path)-VARHDRSZ);

        if(statfs(ls_tbs_loc, &ls_tbs_fs) == 0) {
                lul_tot_kb = ls_tbs_fs.f_blocks*ls_tbs_fs.f_bsize/1024;
        }

        PG_RETURN_FLOAT8(lul_tot_kb);
}