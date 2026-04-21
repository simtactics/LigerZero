using System;
using Godot;
using Godot.Collections;

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

    public static Lobby Instance { get; private set; }

    public override void _Ready()
    {
        Instance = this;
        Multiplayer.PeerConnected += OnPlayerConnected;
    }

    private void OnPlayerConnected(long id)
    {
        throw new NotImplementedException();
    }
}
