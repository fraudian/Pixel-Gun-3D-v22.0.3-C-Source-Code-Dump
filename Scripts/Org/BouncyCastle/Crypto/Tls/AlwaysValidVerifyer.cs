using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class AlwaysValidVerifyer : ICertificateVerifyer
    {
        // Methods
        public bool IsValid(System.Uri targetUri, Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certs)
        {
            return true;
        }
        public AlwaysValidVerifyer()
        {
        
        }
    
    }

}
