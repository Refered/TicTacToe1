using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
public class PayloadEventArgs<T>
{
    public T Payload { get; }
    public PayloadEventArgs(T payload)
    {
        Payload = payload;
    }
}