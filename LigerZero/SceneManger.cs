namespace LigerZero;

public class SceneManger(Engine engine, string ver)
{
    private readonly string version = ver;

    private Node CurrentScene => engine.Tree.CurrentScene;

    private void ChangeScene(string scene)
    {
        var change = ResourceLoader.Load<PackedScene>(scene);
        var newScene = change.Instantiate();
        engine.Tree.Root.AddChild(newScene);
    }

    public void Login()
    {
        var login = CurrentScene;
        var lzVer = login.GetNode<Label>("VerLbl");
        var button = login.GetNode<Button>("LoginPanel/loginCtn/LoginBtn");
        // var scrollTxt = login.GetNode<Label>("ScrollCtn/ScrollTxt");
        var alertWin = login.GetNode<Window>("AlertWin");

        // Init scene
        lzVer.Text = $"v{version}";

        button.Pressed += OnLoginBtnPresssed;

        var dir = DirAccess.Open(LZConsts.TSO_DIR);
        if (dir != null)
        {
            var tsoVersion = FileManager.ReadTextFile($"{LZConsts.TSO_DIR}/version");
            lzVer.Text = $"LZ v{version}{Env.NewLine}TSO v{tsoVersion}";
        }
        else
        {
            alertWin.Show();
        }
    }

    private void OnLoginBtnPresssed()
    {
        ChangeScene("res://map.tscn");
    }
}
