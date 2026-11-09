using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsCipherFactory : TlsCipherFactory
    {
        // Methods
        public virtual Org.BouncyCastle.Crypto.Tls.TlsCipher CreateCipher(Org.BouncyCastle.Crypto.Tls.TlsContext context, int encryptionAlgorithm, int macAlgorithm)
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public AbstractTlsCipherFactory()
        {
        
        }
    
    }

}
