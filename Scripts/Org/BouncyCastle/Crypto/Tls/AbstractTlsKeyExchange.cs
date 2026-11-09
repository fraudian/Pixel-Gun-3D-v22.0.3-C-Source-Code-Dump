using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class AbstractTlsKeyExchange : TlsKeyExchange
    {
        // Fields
        protected readonly int mKeyExchange;
        protected System.Collections.IList mSupportedSignatureAlgorithms;
        protected Org.BouncyCastle.Crypto.Tls.TlsContext mContext;
        
        // Properties
        public virtual bool RequiresServerKeyExchange { get; }
        
        // Methods
        protected AbstractTlsKeyExchange(int keyExchange, System.Collections.IList supportedSignatureAlgorithms)
        {
            this.mKeyExchange = keyExchange;
            this.mSupportedSignatureAlgorithms = supportedSignatureAlgorithms;
        }
        protected virtual Org.BouncyCastle.Crypto.Tls.DigitallySigned ParseSignature(System.IO.Stream input)
        {
            Org.BouncyCastle.Crypto.Tls.DigitallySigned val_1 = Org.BouncyCastle.Crypto.Tls.DigitallySigned.Parse(context:  this.mContext, input:  input);
            if(val_1 == null)
            {
                    return val_1;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(supportedSignatureAlgorithms:  this.mSupportedSignatureAlgorithms, signatureAlgorithm:  val_1);
            return val_1;
        }
        public virtual void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            var val_11;
            var val_12;
            this.mContext = context;
            var val_10 = 0;
            val_10 = val_10 + 1;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_2 = context.ClientVersion;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(clientVersion:  val_2)) == false)
            {
                goto label_8;
            }
            
            if(this.mSupportedSignatureAlgorithms != null)
            {
                    return;
            }
            
            int val_11 = this.mKeyExchange;
            val_11 = val_11 - 1;
            if(val_11 > 23)
            {
                goto label_10;
            }
            
            var val_12 = 106048508 + ((this.mKeyExchange - 1)) << 2;
            val_12 = val_12 + 106048508;
            goto (106048508 + ((this.mKeyExchange - 1)) << 2 + 106048508);
            label_8:
            if(this.mSupportedSignatureAlgorithms == null)
            {
                    return;
            }
            
            val_11 = 1152921547465202528;
            val_12 = new System.InvalidOperationException(message:  "supported_signature_algorithms not allowed for " + val_2);
            goto label_15;
            label_10:
            val_11 = 1152921547465202528;
            val_12 = new System.InvalidOperationException(message:  "unsupported key exchange algorithm");
            label_15:
        }
        public abstract void SkipServerCredentials(); // 0
        public virtual void ProcessServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
        {
        
        }
        public virtual void ProcessServerCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Org.BouncyCastle.Crypto.Tls.Certificate val_2 = serverCredentials.Certificate;
            goto typeof(Org.BouncyCastle.Crypto.Tls.AbstractTlsKeyExchange).__il2cppRuntimeField_288;
        }
        public virtual bool get_RequiresServerKeyExchange()
        {
            return false;
        }
        public virtual byte[] GenerateServerKeyExchange()
        {
            if((this & 1) == 0)
            {
                    return 0;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public virtual void SkipServerKeyExchange()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public virtual void ProcessServerKeyExchange(System.IO.Stream input)
        {
            if((this & 1) != 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public abstract void ValidateCertificateRequest(Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest); // 0
        public virtual void SkipClientCredentials()
        {
        
        }
        public abstract void ProcessClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials); // 0
        public virtual void ProcessClientCertificate(Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
        {
        
        }
        public abstract void GenerateClientKeyExchange(System.IO.Stream output); // 0
        public virtual void ProcessClientKeyExchange(System.IO.Stream input)
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public abstract byte[] GeneratePremasterSecret(); // 0
    
    }

}
