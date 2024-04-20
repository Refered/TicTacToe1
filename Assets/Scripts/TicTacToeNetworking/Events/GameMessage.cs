using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GameMessage
{
    public MessageType messageType { get; set; }
    public int playerId { get; set; }
    public int[] boardState { get; set; }
}