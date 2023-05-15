using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class DataHandle : SocketBase
{
    protected override void DispenseMessage(EndPoint endPoint, byte[] buf, int Length)
    {
        throw new System.NotImplementedException();
    }
}
