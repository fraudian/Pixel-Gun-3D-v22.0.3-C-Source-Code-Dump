using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsCredentials
    {
        // Properties
        public abstract Org.BouncyCastle.Crypto.Tls.Certificate Certificate { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Crypto.Tls.Certificate get_Certificate(); // 0
    
    }

}
