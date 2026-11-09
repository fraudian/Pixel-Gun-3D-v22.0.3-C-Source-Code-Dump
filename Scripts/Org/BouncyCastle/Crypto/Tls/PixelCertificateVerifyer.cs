using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class PixelCertificateVerifyer : ICertificateVerifyer
    {
        // Methods
        public bool IsValid(System.Uri targetUri, Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certs)
        {
            System.Byte[] val_2;
            var val_3;
            val_2 = certs;
            if(certs.Length == 0)
            {
                    return true;
            }
            
            val_2 = val_2[0].GetSignatureOctets();
            if(val_2 == null)
            {
                    return true;
            }
            
            if(val_1.Length == 0)
            {
                    return true;
            }
            
            val_3 = null;
            val_3 = null;
            业丂丏与世一丏业不.七专一万丑丆丐丑丗 = val_2;
            return true;
        }
        public PixelCertificateVerifyer()
        {
        
        }
    
    }

}
