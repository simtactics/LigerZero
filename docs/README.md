# Project Liger Zero

Liger Zero (or TSO LZ) is an implementation of The Sims Online's client using on Godot and [2dog](https://github.com/outfox/2dog), a library that reverses the workflow, letting .NET take control of the engine. You can still make use of GDScript or C# for scripting but this brings with it more advanced capabilities .NET to Godot. Which is useful for complex games like this or simple ones.

## LAN First

Godot has a basic multiplayer framework that allows for P2P play. The core focus on this prototype is just to understand that basic framework and get it set up. Since it's technically just a console application, a headless LAN server is certainly possible. I have no plans on getting rid of this feature because FreeSO alpha proved you can play The Sims Online at a smaller scale.

## Map View

Similar to past smaller scale projects, map view generally functions as a "hello world." In my personal experience, it was basically the lobby. The map view will also serve as testing out networking and chat without having jump head first into figuring out how the hell you render the lot.

## FAQ

### What's with the Name?

It's been a while since I've used a code name for a Sims project and I wanted to try something different. Mostly just been reusing the classics cause I couldn't think of anything better.

Then I remembered [Zoids: New Century](https://en.wikipedia.org/wiki/Zoids%3A_New_Century). It is one of the many animes I grew up and I wanted to be in the mecha the main character had soo bad. After a quick search, I named this project after it. Liger Zero.

That brief backstory aside, it's just a cool name to give a game client.


- [1]: If you are tight on space, symlinks using `ln -s` are supported. I'm not sure about Windows.