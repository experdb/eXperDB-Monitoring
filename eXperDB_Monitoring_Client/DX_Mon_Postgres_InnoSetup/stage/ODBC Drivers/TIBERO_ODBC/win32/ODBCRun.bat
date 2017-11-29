@echo off
set mypath="%~dp0"

set mypath=%mypath:"=%\
set mypath="%mypath:\\=%"
tbodbc_driver_installer_5_32.exe -i %mypath%