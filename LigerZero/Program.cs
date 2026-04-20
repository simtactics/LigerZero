using Engine = twodog.Engine;

// Create and start the Godot engine with your project
const string version =
    $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}";
const string project = "LigerZero";
using var engine = new Engine(project, Engine.ResolveProjectDir());
using var godot = engine.Start();

// Load main scene
var game = GD.Load<PackedScene>("res://main.tscn");
engine.Tree.Root.AddChild(game.Instantiate());

var scene = engine.Tree.CurrentScene;
var verLbl = scene.GetNode<Label>("VerLbl");
var alertWin = scene.GetNode<Window>("AlertWin");
var win = scene.GetWindow();
var cfg = new LZConfig();

// Init scene
verLbl.Text = version;
win.Size = new Vector2I(cfg.Height, cfg.Width); // I might have mixed up the X Y coordinates on this one.


// Path resolver need fixing, but at least one things works xD
if (!File.Exists(cfg.InstallDir)) alertWin.Show();

// Main game loop - runs until window closes or 'Q' is pressed
while (!godot.Iteration())
    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
        break;


Console.WriteLine("Shutting down...");
