# Project Liger Zero

Liger Zero (or TSO LZ) is a prototype aimed at reimplementing The Sims Online's client using Godot. In order to make this all work I'm using [2dog](https://github.com/outfox/2dog),  a library that uses `libgodot` in order to reverse the workflow, letting .NET take control of the engine. You can still make use of GDScript or C# for scripting but this brings with it more advanced capabilities of .NET to Godot. Which is useful for both complex games like this or simple ones.

## LAN First

Godot has a basic multiplayer framework that allows for Mesh networks and P2P play. Right now the core focus on this prototype is just to understand the networking APIs and get it set up by starting with a simple map view. Since 2dog runs as a console application, a headless LAN server is certainly possible.

## Quick Start

### Prerequisites

- .NET 8 or later
- [Godot (.NET)](https://godotengine.org/) 

Supported platforms: `win-x64`, `linux-x64`, and `osx-arm64`.

### Where to Put TSO

Whether you are playing or contributing to Liger Zero, in order for the game to safely access The Sims Online's contents, you must place the `TSOClient` folder or a symlink to it in the game's data directory.

- Windows: `%APPDATA%\SimTactics\LigerZero`
- macOS: `~/Library/Application Support/SimTactics/LigerZero`
- Linux: `~/.local/share/SimTactics/LigerZero`

## To-Do

See [changelog](./ChangeLog.md).

- [ ] Prototype (Tokaido)
    - [x] Login
    - [ ] Lobby
    - [ ] Chat

## Declaimer

The Sims trademarks are the property of Electronic Arts Inc. and its licensors. Game content and materials copyright Electronic Arts Inc. and its licensors. All rights reserved.

## License

I license this project under the GPL-3.0 license - see [LICENSE](LICENSE) for details.
