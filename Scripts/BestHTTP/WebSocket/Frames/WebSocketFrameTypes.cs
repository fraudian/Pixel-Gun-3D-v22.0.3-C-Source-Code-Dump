using UnityEngine;

namespace BestHTTP.WebSocket.Frames
{
    [Serializable]
    public enum WebSocketFrameTypes
    {
        // Fields
        Continuation = 0
        ,Text = 1
        ,Binary = 2
        ,ConnectionClose = 8
        ,Ping = 9
        ,Pong = 10
        
    
    }

}
