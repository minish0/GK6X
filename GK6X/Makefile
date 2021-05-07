#
# makefile for GK6X-gui-host
#

#
# DEFINITIONS
#

#
# Local Definition
#

####

#
# Generic Definition (replace when you need)
#

# destination directory
DEST	      = .

# extend headers (are always system header)
EXTHDRS	      = /usr/include/stdio.h \
		/usr/include/stdint.h \
		/usr/include/stdlib.h \
		/usr/include/string.h \
		/usr/include/limits.h

# include headers (are always local header)
HDRS	      = 

# flags when you compile
CFLAGS	      = -O
#CFLAGS	      = -g


# flags when you load(or called link)
LDFLAGS	      = -ldl

# libraries
LIBS	      = 

# compiler you use
CC            = clang
#CC            = cc
#CC            = gcc

# linker you use
LINKER	      = $(CC)

# makefile
MAKEFILE      = Makefile

####

#
# You must edit following section
#

# object files
OBJS          = GK6X-gui-host

# make finally build
PROGRAM       = obj/Debug/GK6X-gui.exe

# source files
SRCS          = GK6X-gui-host.c

####

#
# GENERIC PRODUCTION RULES (you don't have to edit)
#

all:		$(PROGRAM)

# accomplish target
$(PROGRAM):	$(OBJS)
	xbuild GK6X.csproj /p:Configuration=Debug /p:AssemblyName=GK6X-gui /p:DefineConstants=AS_GUI

# clean up object files (%make clean)
clean: 
	@echo -n "cleaning objects ... "
	@rm -f $(OBJS)
	@echo "done"

program:        $(PROGRAM)

#
# LOCAL PRODUCTION RULES (You must edit)
#
$(OBJS):
	$(CC) ${CFLAGS} $(LDFLAGS) $(LIBS)-o $(OBJS) $(SRCS)
