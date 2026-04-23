// Create and start the Godot engine with your project

using var engine = new Engine("Liger Zero", Engine.ResolveProjectDir());
using var godot = engine.Start();
var scene = new SceneManager(engine);
// scene.InstantiateScene("res://scenes/main.tscn");
var splashImgs = new[]
{
    "res://assets/splash/restoredsplash1.png",
    "res://assets/splash/restoredsplash2.png",
    "res://assets/splash/restoredsplash3.png"
};
Random.Shared.Shuffle(splashImgs);
var splashTexture = ResourceLoader.Load<CompressedTexture2D>(splashImgs.First());

// Init scene
var gameVer = $"v{LZConsts.VERSION}";
var current = scene.CurrentScene;
var unameInput = current.GetNode<LineEdit>("LoginPanel/loginCtn/UnameInput");
var splash = current.GetNode<TextureRect>("Splash");
var servInput = current.GetNode<LineEdit>("LoginPanel/loginCtn/ServInput");
var gameVerLbl = current.GetNode<Label>("VerLbl");
var alertWin = current.GetNode<Window>("AlertWin");
var login = current.GetNode<Button>("LoginPanel/loginCtn/ButtonCtn/LoginBtn");
var cancel = current.GetNode<Button>("LoginPanel/loginCtn/ButtonCtn/CancelBtn");

var loginFile = FileManager.ReadText("user://login.toml");
var loginCfg = TomlSerializer.Deserialize<LoginConfig>(loginFile)!;

if (!string.IsNullOrEmpty(loginFile))
{
    unameInput.Text = loginCfg.Username;
    servInput.Text = loginCfg.Server;
}

ProjectSettings.SetSetting("application/config/version", LZConsts.VERSION);

gameVerLbl.Text = gameVer;
splash.Texture = splashTexture;

login.Pressed += () => scene.ChangeScene("res://scenes/map/map_menu.tscn");
cancel.Pressed += () => Env.Exit(Env.ExitCode);

if (FileManager.TSOExists)
{
    var tsoVersion = FileManager.ReadText($"{LZConsts.TSO_DIR}/version");
    gameVer = $"LZ v{LZConsts.VERSION}{Env.NewLine}TSO v{tsoVersion}";
    gameVerLbl.Text = gameVer;
}
else
{
    alertWin.Show();
}

GD.Print(gameVer);

// Main game loop - runs until window closes or 'Q' is pressed
while (!godot.Iteration())
    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
        break;

Console.WriteLine("Shutting down...");
