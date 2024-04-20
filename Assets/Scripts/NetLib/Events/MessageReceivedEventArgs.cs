using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MessageReceivedEventArgs : EventArgs
{
    public byte[] Data { get; }
    public MessageReceivedEventArgs(byte[] data, int length)
    {
        Data = new byte[length];
        Array.Copy(data, Data, length);
    }
}