# AutoShutdown (Native, no .NET)

Free, lightweight Win32 app with:
- Sleep / Hibernate / Shutdown / Restart / Log off / Lock
- Force-close apps option (use with care)
- Countdown with tray support (minimize to tray)
- Cancel timer + Abort OS shutdown
- Start minimized
- **Schedule at date & time**
- **Run on Windows startup**
- **Theme toggle:** Light / Dark / System (uses Windows "AppsUseLightTheme")
- Unicode-safe; DPI-aware manifest; single EXE build (no .NET)

Links in UI:
- **@viberSKY** → GitHub
- **@TheGeekPage.com** → website

## Build (MSVC)
Open **x64 Native Tools Command Prompt for VS**, then:
```
cd AutoShutdownNativeFinal
build.bat
```
Output: `build\AutoShutdown.exe`

## Notes
- Hibernate requires `powercfg /hibernate on`.
- Some actions may require elevation depending on policy.
- We embed the application manifest; the linker manifest is disabled to avoid duplicates.
