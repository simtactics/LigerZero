namespace LigerZero;

public class SceneManger(Engine engine, string ver)
{
    private readonly Engine game = engine;
    private readonly string version = ver;

    public Node CurrentScene => game.Tree.CurrentScene;

    public void ChangeScene(string scene)
    {
        var change = ResourceLoader.Load<PackedScene>($"res://{scene}").Instantiate();
        game.Tree.Root.AddChild(change);

    }

    public void Login()
    {
        if (CurrentScene.Name != "Login")
            return;

        var config = LZConfig.LoadConfig;

        var login = CurrentScene;
        var verLbl = login.GetNode<Label>("VerLbl");
        // var splash = scene.GetNode<TextureRect>("Splash");
        // var alertTxt = scene.GetNode<Label>("AlertWin/AlertBox/AlertTxt");
        var alertWin = login.GetNode<AcceptDialog>("AlertWin");

        // Init scene
        verLbl.Text = version;

        // Path resolver needs lots of work, but at least one things works xD
        if (!File.Exists(config.InstallDir)) alertWin.Show();
    }
}