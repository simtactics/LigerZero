namespace LigerZero;

public class Soundtrack
{
    private readonly GameMode _gameMode = GameMode.Load;
    private readonly IEnumerable<string> _mapMode = ["tsomap2_v2", "tsomap3", "tsomap4_v1"];
    private readonly string _tsoLoc = $"{LZConsts.TSO_DIR}/music";

    public Soundtrack(GameMode modes)
    {
        var rng = new Random();

        switch (modes)
        {
            case GameMode.Create:
                _gameMode = GameMode.Create;
                _tsoLoc = $"{_tsoLoc}/create";
                break;
            default:
            case GameMode.Load:
                _gameMode = GameMode.Load;
                _tsoLoc = $"{_tsoLoc}/load";
                break;
            case GameMode.Map:
                _gameMode = GameMode.Map;
                _tsoLoc = $"{_tsoLoc}/map";
                break;
            case GameMode.Select:
                _gameMode = GameMode.Select;
                _tsoLoc = $"{_tsoLoc}/select";
                break;
        }
    }

    public IEnumerable<string> Load()
    {
        var loadMusc = new List<string>();
        switch (_gameMode)
        {
            case GameMode.Create:
                break;
            default:
            case GameMode.Map:
                loadMusc.AddRange(_mapMode.Select(map => Path.Combine(_tsoLoc, map)));
                break;
            case GameMode.Load:
                break;
            case GameMode.Select:
                break;
        }

        return loadMusc;
    }
}
