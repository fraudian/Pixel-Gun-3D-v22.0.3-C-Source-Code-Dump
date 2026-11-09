using UnityEngine;

namespace BestHTTP
{
    [Serializable]
    internal enum RetryCauses
    {
        // Fields
        None = 0
        ,Reconnect = 1
        ,Authenticate = 2
        ,ProxyAuthenticate = 3
        
    
    }

}
