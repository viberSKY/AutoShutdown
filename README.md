# AutoShutdown (Portable Windows Freeware)

A tiny, portable Windows tool to schedule a **shutdown at a specific time** or **after a countdown**. Uses the built-in `shutdown` command under the hood, so it doesn't require admin rights in normal cases.

## Features
- Pick a **date & time** to shut down the PC.
- Start a **countdown** (seconds) to shut down.
- Shows remaining time (if a shutdown is scheduled).
- **Cancel** a scheduled shutdown at any time.
- **Portable**: publish as a single EXE (no installer).

## Screenshot
_(UI is a compact WinForms window with time picker, countdown box, and Schedule/Start/Cancel buttons.)_

## Getting Started

### 1) Prerequisites

For (v2.0.1 and later)
- Lightweight (around 120 Kb) portable exe that does not need .NET or other prequisites like VCRedist.

For (v2.0.0) 
- Lightweight. If you get VCRuntime errors, download and install~ [Visual C++ Redistributable (2015–2022)] https://aka.ms/vs/17/release/vc_redist.x64.exe


For (v.1.0.0) .NET Dependent build
- Windows 10 or later.
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download) (for building from source).

### 2) Build (Debug, non-portable)
```bash
cd src/AutoShutdown
dotnet build
```

### 3) Publish Portable (single EXE)
This creates a standalone exe you can copy anywhere.
```bash
cd src/AutoShutdown
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true -o ../../publish
```
- Output will be in `publish/AutoShutdown.exe`.
- The executable will have the included **power switch** icon.

### 4) Usage
- **Schedule at time**: choose a date/time and click **Schedule Shutdown**.
- **Countdown**: enter seconds and click **Start Countdown**.
- **Cancel**: click **Cancel Scheduled Shutdown** (or run `shutdown /a` manually).
- When a schedule is active, Windows displays a toast and the tool shows the remaining time.

> Under the hood we call: `shutdown /s /t <seconds>`. Cancel uses `shutdown /a`.

### 5) Notes
- If you close the app, a schedule created via `shutdown /s /t` **continues** (it's system-level). Use **Cancel** or `shutdown /a` to abort.
- Hibernation/Hybrid shutdown settings can influence behavior on some PCs.
- No data is collected; the app makes no network calls.

## Repository Layout
```
AutoShutdown/
├── .gitignore
├── LICENSE
├── README.md
└── src/
    └── AutoShutdown/
        ├── AutoShutdown.csproj
        ├── Program.cs
        ├── MainForm.cs
        ├── MainForm.Designer.cs
        └── Resources/
            └── powerswitch.ico
```

## License
[MIT](./LICENSE)
