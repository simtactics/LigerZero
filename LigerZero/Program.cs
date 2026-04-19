using Engine = twodog.Engine;

// Create and start the Godot engine with your project
const string version = $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}";
const string project = "LigerZero";
using var engine = new Engine(project, Engine.ResolveProjectDir());
using var godot = engine.Start();

// Load main scene
var scene = GD.Load<PackedScene>("res://main.tscn");
var tree = engine.Tree.Root;
var window = tree.GetWindow();
var config = new LZConfig();

// Init scene
tree.AddChild(scene.Instantiate());
window.Size = new Vector2I(config.Height, config.Width);


#if DEBUG
window.Title = $"{project} {version}";
#endif

var tso = config.GameLocation;


if (!File.Exists(tso))
    GD.Print("Could not find The Sims Online!");

// Main game loop - runs until window closes or 'Q' is pressed
while (!godot.Iteration())
{
    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
        break;
}

Console.WriteLine("Shutting down...");
