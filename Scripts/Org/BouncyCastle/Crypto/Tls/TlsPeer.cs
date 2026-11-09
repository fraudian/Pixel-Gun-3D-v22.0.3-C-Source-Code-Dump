using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsPeer
    {
        // Methods
        public abstract bool ShouldUseGmtUnixTime(); // 0
        public abstract void NotifySecureRenegotiation(bool secureRenegotiation); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher(); // 0
        public abstract void NotifyAlertRaised(byte alertLevel, byte alertDescription, string message, System.Exception cause); // 0
        public abstract void NotifyAlertReceived(byte alertLevel, byte alertDescription); // 0
        public abstract void NotifyHandshakeComplete(); // 0
    
    }

}
