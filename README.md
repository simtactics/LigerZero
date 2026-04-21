# Project Liger Zero

Liger Zero (or TSO LZ) is an implementation of The Sims Online's client using on Godot
and [2dog](https://github.com/outfox/2dog), a library that reverses the workflow, letting .NET take control of the
engine. You can still make use of GDScript or C# for scripting but this brings with it more advanced capabilities .NET
to Godot. Which is useful for complex games like this or simple ones.

## Where to Put TSO

Whether you are playing or contributing to Liger Zero, in order for the game to safely access The Sims Online's
contents, you must place the `TSOClient` folder or a symlink to it in the game's data directory.

- Windows: `%APPDATA%\SimTactics\LigerZero`
- macOS: `~/Library/Application Support/SimTactics/LigerZero`
- Linux: `~/.local/share/SimTactics/LigerZero`

## To-do

See [changelog](./docs/ChangeLog.md).

- [ ] Prototype (Tokaido)
    - [x] Login window
    - [ ] Basic networking
    - [ ] Chat

## License

I license this project under the GPL-3.0 license - see [LICENSE](LICENSE) for details.
