using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;

public class NetworkClientEventArgs : EventArgs
{
    // Correctly typed and named property
    public NetworkClient NetworkClient { get; }

    // Constructor that correctly assigns the passed parameter to the property
    public NetworkClientEventArgs(NetworkClient networkClient)
    {
        NetworkClient = networkClient;
    }
}