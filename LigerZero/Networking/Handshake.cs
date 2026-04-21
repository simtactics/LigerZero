using System.Net;
using System.Net.Sockets;

namespace LigerZero.Networking;

public class Handshake(Engine engine, int Port)
{

    public Node Scene => engine.Tree.CurrentScene;

    // Source - https://stackoverflow.com/a/6803109
    // Posted by Mrchief, modified by community. See post 'Timeline' for change history
    // Retrieved 2026-04-20, License - CC BY-SA 3.0

    static string LocalIPAddress
    {
        get
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }

    public void Client()
    {
        var host = Dns.GetHostName();
        var ip = Dns.GetHostEntry(host);
        var client = new ENetMultiplayerPeer();
        client.CreateClient(LocalIPAddress, Port);
        Scene.Multiplayer.MultiplayerPeer = client;
    }

    public void server()
    {
        var server = new ENetMultiplayerPeer();
        server.CreateServer(Port);
        Scene.Multiplayer.MultiplayerPeer = server;

    }
}
