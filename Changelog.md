# Changelog

All notable changes to **AutoShutdown** will be documented in this file.  
This project follows [Semantic Versioning](https://semver.org/).

---

## [2.0.1] - 2025-08-25
### Fixed
- Credits line refined to a **single inline entry**:  
  `Developed and maintained by @viberSKY @TheGeekPage.com`  
- Both credits remain **clickable hyperlinks**, but the duplicate text on the right-hand side of the dialog was removed.
- Build a static build without the dependency on VCRedist library files.

---

## [2.0.0] - 2025-08-24
### Added
- **Lightweight native Win32 build** (no .NET, smaller size, faster startup).  
- **Revamped UI** with blue accent header, modern fonts, Light/Dark/System theme toggle.  
- **Custom app + tray icons** for a professional look.  
- **Smart scheduling**: shutdown at a specific date & time.  
- **Run on startup** checkbox (adds/removes key in Windows startup).  
- **Portable settings** via `AutoShutdown.ini` (remembers theme, schedule, timer, etc.).  
- Branding updated to:  
  `Developed and maintained by @viberSKY @TheGeekPage.com`

### Features
- Actions: Sleep, Hibernate, Shutdown, Restart, Log off, Lock.  
- Options: Force close apps, Start minimized to tray, Cancel & Abort OS shutdown.  
- Tray integration with countdown tooltip and right-click context menu.  

---

## [1.x] - Initial Proof of Concept
- Early builds using .NET dependency. Considerably large in size for a freeware. 
- Basic countdown shutdown functionality.
- No tray integration or theming.
