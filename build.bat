@echo off
setlocal
if not exist build mkdir build
cmake -S . -B build -G "NMake Makefiles"
if errorlevel 1 goto :e
cmake --build build --config Release
if errorlevel 1 goto :e
echo.
echo Built: build\AutoShutdown.exe
exit /b 0
:e
echo Build failed. Ensure you launched the "Native Tools" prompt and have CMake installed.
exit /b 1
