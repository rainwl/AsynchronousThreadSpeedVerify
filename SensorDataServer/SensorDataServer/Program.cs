using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SensorDataServer;

internal class SensorData
{
    private readonly Socket server;
    private EndPoint _clientpoint;

    private SensorData()
    {
        server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        server.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9600));
        _clientpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9700);

        var msg = "1,1,1";
        server.SendTo(Encoding.UTF8.GetBytes(msg), _clientpoint);
    }
}