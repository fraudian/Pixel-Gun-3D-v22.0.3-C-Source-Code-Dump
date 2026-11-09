using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsSignerCredentials : TlsCredentials
    {
        // Properties
        public abstract Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm SignatureAndHashAlgorithm { get; }
        
        // Methods
        public abstract byte[] GenerateCertificateSignature(byte[] hash); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm get_SignatureAndHashAlgorithm(); // 0
    
    }

}
