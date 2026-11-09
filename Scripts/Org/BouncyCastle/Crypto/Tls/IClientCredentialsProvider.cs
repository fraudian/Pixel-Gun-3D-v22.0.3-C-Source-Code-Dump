using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface IClientCredentialsProvider
    {
        // Methods
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCredentials GetClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest); // 0
    
    }

}
