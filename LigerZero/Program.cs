// Ignore VSCode if it complains about "ThisAssembly" not being found.
const string version =
    $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}";

// Create and start the Godot engine with your project
using var engine = new Engine("Liger Zero", Engine.ResolveProjectDir());
using var godot = engine.Start();
var scene = new SceneManager(engine, version);

var login = scene.Login();
var button = login.GetNode<Button>("LoginPanel/loginCtn/LoginBtn");

button.Pressed += () =>
{
    scene.ChangeScene("res://scenes/map/map_menu.tscn");
};

// Main game loop - runs until window closes or 'Q' is pressed
while (!godot.Iteration())
    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
        break;

Console.WriteLine("Shutting down...");
