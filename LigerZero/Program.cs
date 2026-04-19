using Godot;
using LigerZero;
using Engine = twodog.Engine;

// Create and start the Godot engine with your project
const string version = $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}";
const string project = "LigerZero";
using var engine = new Engine(project, Engine.ResolveProjectDir());
using var godot = engine.Start();

// Load your main scene
var scene = GD.Load<PackedScene>("res://main.tscn");
var tree = engine.Tree.Root;
tree.AddChild(scene.Instantiate());

#if DEBUG
var window = tree.GetWindow();
window.Title = $"{project} {version}";
#endif

GD.Print("2dog is running! Close window or press 'Q' to quit.");
Console.WriteLine("Press 'Q' to quit.");

// Main game loop - runs until window closes or 'Q' is pressed
while (!godot.Iteration())
{
    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
        break;

    var findTSO = new FindTSO();
}

Console.WriteLine("Shutting down...");
