namespace LigerZero;

public class SceneManger
{
    private readonly LZConfig config = new();
    private readonly Engine game;
    private readonly string version;

    public SceneManger(Engine engine, string ver)
    {
        game = engine;
        version = ver;
    }

    private Node Instantiate(string path)
    {
        var scene = GD.Load<PackedScene>($"res://{path}");
        game.Tree.Root.AddChild(scene.Instantiate());
        var current = game.Tree.CurrentScene;
        var win = current.GetWindow();

        win.Size = new Vector2I(config.Height, config.Width); // I might have mixed up the X Y coordinates on this one.

        return current;
    }

    public void Login()
    {
        var scene = Instantiate("main.tscn");
        var verLbl = scene.GetNode<Label>("VerLbl");
        // var splash = scene.GetNode<TextureRect>("Splash");
        // var alertTxt = scene.GetNode<Label>("AlertWin/AlertBox/AlertTxt");
        var alertWin = scene.GetNode<Window>("AlertWin");

        // Init scene
        verLbl.Text = version;

        // Path resolver need fixing, but at least one things works xD
        if (!File.Exists(config.InstallDir)) alertWin.Show();
    }
}
