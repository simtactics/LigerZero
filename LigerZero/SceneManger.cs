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
        var login = CurrentScene;
        var lzVer = login.GetNode<Label>("VerLbl");
        // var splash = scene.GetNode<TextureRect>("Splash");
        // var scrollTxt = login.GetNode<Label>("ScrollCtn/ScrollTxt");
        var alertWin = login.GetNode<Window>("AlertWin");

        // Init scene
        lzVer.Text = $"v{version}";

        var dir = DirAccess.Open(LZConsts.TSO_DIR);
        if (dir != null)
        {
            using var verFile = FileAccess.Open($"{LZConsts.TSO_DIR}/version", FileAccess.ModeFlags.Read);
            var tsoVersion = verFile.GetAsText();
            lzVer.Text = $"LZ v{version}{Env.NewLine}TSO v{tsoVersion}";
        }
        else { alertWin.Show(); }
    }
}