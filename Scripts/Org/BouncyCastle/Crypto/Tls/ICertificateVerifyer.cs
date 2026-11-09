using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface ICertificateVerifyer
    {
        // Methods
        public abstract bool IsValid(System.Uri targetUri, Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certs); // 0
    
    }

}
