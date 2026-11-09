using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class HeartbeatMode
    {
        // Fields
        public const byte peer_allowed_to_send = 1;
        public const byte peer_not_allowed_to_send = 2;
        
        // Methods
        public static bool IsValid(byte heartbeatMode)
        {
            byte val_1 = heartbeatMode - 1;
            val_1 = val_1 & 255;
            return (bool)(val_1 < 2) ? 1 : 0;
        }
        protected HeartbeatMode()
        {
        
        }
    
    }

}
