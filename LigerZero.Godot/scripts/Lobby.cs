// Based on https://docs.godotengine.org/en/stable/tutorials/networking/high_level_multiplayer.html
internal partial class Lobby : Node // I.e. map view
{
    [Signal]
    public delegate void PlayerConnectedEventHandler(int peerId, Dictionary<string, string> playerInfo);

    [Signal]
    public delegate void PlayerDisconnectedEventHandler(int peerId);

    [Signal]
    public delegate void ServerDisconnectedEventHandler();

    private const int Port = 7000;
    private const string DefaultServerIP = "127.0.0.1"; // IPv4 localhost
    private const int MaxConnections = 20;

    private Dictionary<string, string> _playerInfo = new()
    {
        { "Name", "PlayerName" }
    };

    private Dictionary<long, Dictionary<string, string>> _players = new();

    private int _playersLoaded = 0;

    public static Lobby Instance { get; private set; }

    public override void _Ready()
    {
        Instance = this;
        Multiplayer.PeerConnected += OnPlayerConnected;
    }

    private Error JoinGame(string ip = "")
    {
        if (string.IsNullOrEmpty(ip)) ip = DefaultServerIP;

        var peer = new ENetMultiplayerPeer();
        var error = peer.CreateClient(ip, Port);
        if (error != Error.Ok) return error;

        Multiplayer.MultiplayerPeer = peer;
        return Error.Ok;
    }

    private Error CreateGame()
    {
        var peer = new ENetMultiplayerPeer();
        var error = peer.CreateServer(Port, MaxConnections);

        if (error != Error.Ok) return error;

        Multiplayer.MultiplayerPeer = peer;
        _players[1] = _playerInfo;
        EmitSignal(SignalName.PlayerConnected, 1, _playerInfo);

        return Error.Ok;
    }

    private void RemoveMultiplayerPeer()
    {
        Multiplayer.MultiplayerPeer = null;
        _players.Clear();
    }

    // When the server decides to start the game from a scene
    // do RPC(Lobby.MethodName.LoadGame, filepath);
    [Rpc(CallLocal = true, TransferMode = MultiplayerPeer.TransferModeEnum.Reliable)]
    private void LoadGame(string scene)
    {
        GetTree().ChangeSceneToFile(scene);
    }

    // Every peer will callthis when they have loaded the game scene.
    private void PlayerLoaded()
    {
        if (!Multiplayer.IsServer()) return;
        _playersLoaded += 1;
        if (_playersLoaded != _players.Count) return;
        // Should be something like this: GetNode<Game>("/root/Game").StartGame();
        GetNode("/root/Game");
        _playersLoaded = 0;
    }

    private void OnPlayerConnected(long id)
    {
        // RpcId(id, MethodName.RegisterPlayer, _playerInfo);
    }
}
