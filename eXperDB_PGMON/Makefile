# contrib/get_cpu_clocks/Makefile

MODULE_big = experdb_pgmon
#OBJS = get_backend_rsc.o get_stat_cpu_cores.o get_stat_disk_usge.o get_tbsdisk_avail.o get_cpu_clocks.o get_stat_disk_io.o get_stat_mem.o get_tbsdisk_total.o
OBJS = experdb_pgmon.o 

#EXTENSION = experdb_pgmon
EXTENSION = $(MODULE_big)
DATA = experdb_pgmon--1.1.sql experdb_pgmon--unpackaged--1.1.sql

ifdef NO_PGXS
subdir = contrib/experdb_pgmon
top_builddir = ../..
include $(top_builddir)/src/Makefile.global
include $(top_srcdir)/contrib/contrib-global.mk
else
PG_CONFIG = pg_config
PGXS := $(shell $(PG_CONFIG) --pgxs)
include $(PGXS)
endif
