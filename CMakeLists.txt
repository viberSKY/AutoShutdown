cmake_minimum_required(VERSION 3.16)
project(AutoShutdown LANGUAGES CXX RC)

add_executable(AutoShutdown WIN32
    src/main.cpp
    src/AutoShutdown.rc
)

target_compile_definitions(AutoShutdown PRIVATE UNICODE _UNICODE)
target_compile_features(AutoShutdown PRIVATE cxx_std_17)

target_link_libraries(AutoShutdown PRIVATE
    user32.lib
    advapi32.lib
    shell32.lib
    comctl32.lib
    gdi32.lib
    powrprof.lib
)

# Avoid duplicate manifest (we embed one in the RC)
target_link_options(AutoShutdown PRIVATE "/MANIFEST:NO")

set_property(TARGET AutoShutdown PROPERTY OUTPUT_NAME "AutoShutdown")
