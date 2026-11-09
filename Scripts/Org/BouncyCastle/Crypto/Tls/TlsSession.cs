using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsSession
    {
        // Properties
        public abstract byte[] SessionID { get; }
        public abstract bool IsResumable { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Crypto.Tls.SessionParameters ExportSessionParameters(); // 0
        public abstract byte[] get_SessionID(); // 0
        public abstract void Invalidate(); // 0
        public abstract bool get_IsResumable(); // 0
    
    }

}
