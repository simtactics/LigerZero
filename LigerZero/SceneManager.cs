namespace LigerZero;

public class SceneManager(Engine engine, string ver)
{
    private readonly string version = ver;

    private Node CurrentScene => engine.Tree.CurrentScene;

    public void ChangeScene(string file)
    {
        engine.Tree.ChangeSceneToFile(file);
    }

    public void Login()
    {
        var gameVer = $"v{version}";
        var current = CurrentScene;
        var gameVerLbl = current.GetNode<Label>("VerLbl");
        var alertWin = current.GetNode<Window>("AlertWin");
        var login = current.GetNode<Button>("LoginPanel/loginCtn/ButtonCtn/LoginBtn");
        var cancel = current.GetNode<Button>("LoginPanel/loginCtn/ButtonCtn/CancelBtn");

        login.Pressed += () => ChangeScene("res://scenes/map/map_menu.tscn");
        cancel.Pressed += () => Env.Exit(Env.ExitCode);

        // Init scene
        gameVerLbl.Text = gameVer;

        if (FileManager.TSOExists)
        {
            var tsoVersion = FileManager.ReadText($"{LZConsts.TSO_DIR}/version");
            gameVer = $"LZ v{version}{Env.NewLine}TSO v{tsoVersion}";
            gameVerLbl.Text = gameVer;
        }
        else
        {
            alertWin.Show();
        }

        GD.Print(gameVer);
    }
}
