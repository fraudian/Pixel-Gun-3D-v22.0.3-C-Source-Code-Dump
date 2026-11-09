using UnityEngine;

namespace BestHTTP.SocketIO
{
    [Serializable]
    public enum SocketIOErrors
    {
        // Fields
        UnknownTransport = 0
        ,UnknownSid = 1
        ,BadHandshakeMethod = 2
        ,BadRequest = 3
        ,Internal = 4
        ,User = 5
        ,Custom = 6
        
    
    }

}
