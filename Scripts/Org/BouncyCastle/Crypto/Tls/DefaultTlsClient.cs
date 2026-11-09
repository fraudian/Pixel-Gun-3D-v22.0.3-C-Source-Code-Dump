using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class DefaultTlsClient : AbstractTlsClient
    {
        // Methods
        public DefaultTlsClient()
        {
        
        }
        public DefaultTlsClient(Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory)
        {
            val_1 = new System.Object();
            mem[1152921547488598640] = cipherFactory;
        }
        public override int[] GetCipherSuites()
        {
            return (System.Int32[])new int[15] {49195, 49187, 49161, 49199, 49191, 49171, 162, 64, 50, 158, 103, 51, 156, 60, 47};
        }
        public override Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
        {
            if(((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(ciphersuite:  137150464)) - 1) <= 19)
            {
                    var val_8 = 106048900 + ((val_1 - 1)) << 2;
                val_8 = val_8 + 106048900;
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_7 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateDHKeyExchange(int keyExchange)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsKeyExchange)new Org.BouncyCastle.Crypto.Tls.TlsDHKeyExchange(keyExchange:  keyExchange, supportedSignatureAlgorithms:  this, dhParameters:  0);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateDheKeyExchange(int keyExchange)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsKeyExchange)new Org.BouncyCastle.Crypto.Tls.TlsDheKeyExchange(keyExchange:  keyExchange, supportedSignatureAlgorithms:  this, dhParameters:  0);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsKeyExchange)new Org.BouncyCastle.Crypto.Tls.TlsECDHKeyExchange(keyExchange:  keyExchange, supportedSignatureAlgorithms:  137150464, namedCurves:  X22, clientECPointFormats:  X23, serverECPointFormats:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateECDheKeyExchange(int keyExchange)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsKeyExchange)new Org.BouncyCastle.Crypto.Tls.TlsECDheKeyExchange(keyExchange:  keyExchange, supportedSignatureAlgorithms:  137150464, namedCurves:  X22, clientECPointFormats:  X23, serverECPointFormats:  this);
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateRsaKeyExchange()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsKeyExchange)new Org.BouncyCastle.Crypto.Tls.TlsRsaKeyExchange(supportedSignatureAlgorithms:  this);
        }
    
    }

}
