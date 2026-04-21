namespace LigerZero;

public class SceneManager(Engine engine, string ver)
{
    private readonly string version = ver;

    private Node CurrentScene => engine.Tree.CurrentScene;

    public void ChangeScene(string file)
    {
        engine.Tree.ChangeSceneToFile(file);
    }

    public Node Login()
    {
        var gameVer = $"v{version}";
        var login = CurrentScene;
        var gameVerLbl = login.GetNode<Label>("VerLbl");
        var button = login.GetNode<Button>("LoginPanel/loginCtn/LoginBtn");
        // var scrollTxt = login.GetNode<Label>("ScrollCtn/ScrollTxt");
        var alertWin = login.GetNode<Window>("AlertWin");

        // Init scene
        gameVerLbl.Text = gameVer;

        if (FileManager.TSOExists)
        {
            var tsoVersion = FileManager.ReadTextFile($"{LZConsts.TSO_DIR}/version");
            gameVer = $"LZ v{version}{Env.NewLine}TSO v{tsoVersion}";
            gameVerLbl.Text = gameVer;
        }
        else
        {
            alertWin.Show();
        }

        GD.Print(gameVer);

        return login;
    }


    public Node Map()
    {
        var map = CurrentScene;
        var music = FileManager.LoadMP3($"{LZConsts.TSO_DIR}/music/modes/map/tsomap2_v2.mp3");
        var soundtrack = map.GetNode<AudioStreamPlayer>("Soundtrack");
        soundtrack.Stream = music;
        soundtrack.Play();

        return map;
    }
}
