# Source code refactoring

## GK6X/Program.cs

### static void Run(bool asGUI)

`Run(bool asGUI)` is very huge and it has 578 lines, must be split several function and shorten.

* Load check
* Device Connection
* GUI initialization
* Command read and switch
  * update_data
  * gui_to_txt
    * Keys / Macros
    * Lighting
  * gui_le
  * map/unmap
  * dumpkeys

## GK6X/GK6X-gui-host.c

* [FIXED] Swap argv and argc of main() to avoid confusion
* [FIXED] `PATH_MAX` is undefined unless include /usr/include/linux/limits.h on Ubuntu 20.04 (and on many other Linux distributions.)
* [FIXED] `strcat` and `strcpy` are unsafe, replace `snprintf` and `strncpy`, also check string length to avoid buffer overflow.
* [FIXED] Create GK6X/GK6X-gui.sh from GK6X/GK-GX-gui.bat.
* [FIXED] Create Makefile for make command.
* After all, the `main` function returns always `0`, is it right?
