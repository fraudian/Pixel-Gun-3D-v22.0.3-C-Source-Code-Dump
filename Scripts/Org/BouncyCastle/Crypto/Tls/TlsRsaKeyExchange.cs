using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsRsaKeyExchange : AbstractTlsKeyExchange
    {
        // Fields
        protected Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;
        protected Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters mRsaServerPublicKey;
        protected Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials mServerCredentials;
        protected byte[] mPremasterSecret;
        
        // Methods
        public TlsRsaKeyExchange(System.Collections.IList supportedSignatureAlgorithms)
        {
        
        }
        public override void SkipServerCredentials()
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public override void ProcessServerCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
        {
            Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials val_5;
            if(serverCredentials == null)
            {
                goto label_1;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Crypto.Tls.Certificate val_2 = serverCredentials.Certificate;
            if(serverCredentials == null)
            {
                goto label_7;
            }
            
            val_5 = serverCredentials;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_5 = 0;
            label_8:
            this.mServerCredentials = val_5;
            return;
            label_1:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public override void ProcessServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8;
            var val_9;
            System.Exception val_10;
            if((serverCertificate & 1) != 0)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_2 = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo:  serverCertificate.SubjectPublicKeyInfo);
            this.mServerPublicKey = val_2;
            if(val_2.IsPrivate == true)
            {
                goto label_5;
            }
            
            this.mRsaServerPublicKey = this;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(c:  serverCertificate, keyUsageBits:  32);
            this.ProcessServerCertificate(serverCertificate:  serverCertificate);
            return;
            label_2:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_9 = 42;
            goto label_11;
            label_5:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_9 = 80;
            label_11:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            val_10 = val_8;
        }
        public override void ValidateCertificateRequest(Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
        {
            var val_2 = 0;
            if(val_2 >= certificateRequest.mSupportedSignatureAlgorithms)
            {
                    return;
            }
            
            val_2 = val_2 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = null;
            certificateRequest = val_1;
            val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public override void ProcessClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
        {
            if(clientCredentials != null)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public override void GenerateClientKeyExchange(System.IO.Stream output)
        {
            this.mPremasterSecret = Org.BouncyCastle.Crypto.Tls.TlsRsaUtilities.GenerateEncryptedPreMasterSecret(context:  this, rsaServerPublicKey:  this.mRsaServerPublicKey, output:  output);
        }
        public override void ProcessClientKeyExchange(System.IO.Stream input)
        {
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  137170944)) != false)
            {
                    System.Byte[] val_2 = Org.BouncyCastle.Utilities.IO.Streams.ReadAll(inStr:  input);
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.mPremasterSecret = this.mServerCredentials.DecryptPreMasterSecret(encryptedPreMasterSecret:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input));
        }
        public override byte[] GeneratePremasterSecret()
        {
            if(this.mPremasterSecret != null)
            {
                    this.mPremasterSecret = 0;
                return (System.Byte[])this.mPremasterSecret;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        protected virtual Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters ValidateRsaPublicKey(Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key)
        {
            if((key.Exponent.IsProbablePrime(certainty:  2)) != false)
            {
                    return (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)key;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
    
    }

}
