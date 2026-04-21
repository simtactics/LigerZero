# Project Liger Zero

Liger Zero (or TSO LZ) is an implementation of The Sims Online's client using on Godot and [2dog](https://github.com/outfox/2dog), a library that takes advantage of `libgodot` to reverse the workflow, letting .NET take control of the engine. You can still make use of GDScript or C# for scripting but this brings with it more advanced capabilities of .NET to Godot. Which is useful for both complex games like this or simple ones.


## Quick Start

### Prerequisites

- .NET 8 or later
- [Godot Mono](https://godotengine.org/)

### Where to Put TSO

Whether you are playing or contributing to Liger Zero, in order for the game to safely access The Sims Online's contents, you must place the `TSOClient` folder or a symlink to it in the game's data directory.

- Windows: `%APPDATA%\SimTactics\LigerZero`
- macOS: `~/Library/Application Support/SimTactics/LigerZero`
- Linux: `~/.local/share/SimTactics/LigerZero`

## Platform Support

|         | Version                   | x64 | arm64 |
| ------- | ------------------------- | --- | ----- |
| macOS   | 26, 15, 14                | ❌   | ✅     |
| Ubuntu  | 25.10, 24.04, 22.04       | ✅   | ❌     |
| Fedora  | 43, 42                    | ✅   | ❌     |
| Windows | 10 21H2, 11 26H1, 11 25H2 | ✅   | ❌     |
| Debian  | 13, 12                    | ✅   | ❌     |

## To-Do

See [changelog](./ChangeLog.md).

- [ ] Prototype (Tokaido)
    - [x] Login
    - [ ] Lobby
    - [ ] Chat


## License

I license this project under the GPL-3.0 license - see [LICENSE](LICENSE) for details.
