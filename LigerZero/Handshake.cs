namespace LigerZero;

public class Handshake(Engine engine, string IPAddr, int Port)
{

    public Node Scene => engine.Tree.CurrentScene;

    public void Client()
    {
        var client = new ENetMultiplayerPeer();
        client.CreateClient(IPAddr, Port);
        Scene.Multiplayer.MultiplayerPeer = client;
    }

    public void server()
    {
        var server = new ENetMultiplayerPeer();
        server.CreateClient(IPAddr, Port);
        Scene.Multiplayer.MultiplayerPeer = server;

    }
}