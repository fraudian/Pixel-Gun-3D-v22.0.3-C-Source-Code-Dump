using UnityEngine;

namespace BestHTTP.SocketIO.Transports
{
    [Serializable]
    public enum TransportStates
    {
        // Fields
        Connecting = 0
        ,Opening = 1
        ,Open = 2
        ,Closed = 3
        ,Paused = 4
        
    
    }

}
