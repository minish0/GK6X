#!/bin/sh
#call %WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe GK6X.csproj /p:Configuration=Debug /p:OutputType=Winexe /p:AssemblyName=GK6X-gui /p:DefineConstants=AS_GUI
# You may use gcc instead of clang.
CC='clang'
#CC='cc'
#CC='gcc'
LDFLAGS='-ldl'
# build GK6X-gui-host
$(CC) $(LDFLAGS) -o GK6X-gui-host GK6X-gui-host.c
# build Debug Project
xbuild GK6X.csproj /p:Configuration=Debug /p:AssemblyName=GK6X-gui /p:DefineConstants=AS_GUI
