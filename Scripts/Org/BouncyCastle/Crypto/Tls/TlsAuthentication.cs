using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsAuthentication
    {
        // Methods
        public abstract void NotifyServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsCredentials GetClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest); // 0
    
    }

}
