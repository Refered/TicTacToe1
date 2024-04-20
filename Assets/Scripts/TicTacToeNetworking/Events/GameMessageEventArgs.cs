using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMessageEventArgs : EventArgs
{
    public GameMessage Message { get; }
    public GameMessageEventArgs(GameMessage message)
    {
        Message = message;
    }
}