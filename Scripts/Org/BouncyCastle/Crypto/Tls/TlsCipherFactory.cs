using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsCipherFactory
    {
        // Methods
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCipher CreateCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int encryptionAlgorithm, int macAlgorithm); // 0
    
    }

}
