@echo off
setlocal enabledelayedexpansion

set "protogen_path=.\protogen\protogen.exe"
set "proto_folder=.\protos"
set "output_folder=.\exportFolder"

for %%F in ("%proto_folder%\*.proto") do (
    set "file_name=%%~nF"
    %protogen_path% %proto_folder%\!file_name!.proto --csharp_out=%output_folder%
)

echo Done generating proto files.

rem 复制.\exportFolder\protos 文件夹到当前上级目录下的.\Assets\Scripts
xcopy /s /e /y "%output_folder%" "..\Assets\Scripts"

echo Copied generated files to the target location.

pause