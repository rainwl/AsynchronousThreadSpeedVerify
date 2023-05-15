using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using UnityEngine;

public abstract class SocketBase :ISocket
{
    Socket socket;
    private EndPoint clientEnd;
    Thread connectThread;
    bool isRuning = false;
    byte[] recvData = new byte[1024];
    int recvLen;

    public void Connect()
    {
        socket = new Socket(AddressFamily.InterNetwork , SocketType.Dgram , ProtocolType.Udp);
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1") , 9700);
        socket.Bind(ipEndPoint);
        
        isRuning = true;
        connectThread = new Thread(new ThreadStart(ReceiveMessage));
        connectThread.Start();
    }

    public void ReceiveMessage()
    {
        while (isRuning)
        {
            if (!isRuning)
                return;

            recvData = new byte[1024];
            recvLen = socket.ReceiveFrom(recvData , ref clientEnd);
            DispenseMessage(clientEnd , recvData , recvLen);
        }
    }

    protected abstract void DispenseMessage(EndPoint endPoint , byte[] buf , int Length);

}
