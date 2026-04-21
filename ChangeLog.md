# Changelog

## 0.1.117

- Setting menu in map view that allows toggling of music.

## 0.1.116

- Redesigned the main/login scene to match The Sims Online's layout.
- Naturally, the cancel button now works as well and just quits the game.

## 0.1.115

- Pressing the login button now takes you to a dummy map view. If it finds TSO, then music from that mode will play.

## 0.1.112

- New `LigerZero.Common` library with a `FileManager` class for streamlined file I/O using Godot's `FileAccess` class.
- FileManager current supports reading text files and buffer.

## 0.1.109

- Changed mouse cursor to something a bit more interesting.
- New font that closely matched what I'm assuming TSO and The Sims used.

## 0.1.106

- Liger Zero now checks for `TSOClient` in the user directory. If the directory is found, TSO's version number appears on the top right corner, directly below Liger Zero's.
- Removed a tone of OS detection and path resolving complexity I'm glad I didn't have to deal with.

## 0.1.102

- Basic login window. Splash screen is just some placeholder I made from the fansite kit.
- A lot of TSO path detection code that does and doesn't work. Technically, it does. Just not in the way you'd expect.
  xD

## 0.1 Tokaido

This is just a basic prototype. I had already done some internal testing with 2dog a few months back and while it's still rough around edges, it is solid enough to give me something to work with.
