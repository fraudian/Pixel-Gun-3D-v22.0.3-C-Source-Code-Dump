using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsHandshakeHash : IDigest
    {
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash NotifyPrfDetermined(); // 0
        public abstract void TrackHashAlgorithm(byte hashAlgorithm); // 0
        public abstract void SealHashAlgorithms(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash StopTracking(); // 0
        public abstract Org.BouncyCastle.Crypto.IDigest ForkPrfHash(); // 0
        public abstract byte[] GetFinalHash(byte hashAlgorithm); // 0
    
    }

}
