using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsDHKeyExchange : AbstractTlsKeyExchange
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner;
        protected Org.BouncyCastle.Crypto.Parameters.DHParameters mDHParameters;
        protected Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;
        protected Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials mAgreementCredentials;
        protected Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters mDHAgreePrivateKey;
        protected Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters mDHAgreePublicKey;
        
        // Properties
        public override bool RequiresServerKeyExchange { get; }
        protected virtual int MinimumPrimeBits { get; }
        
        // Methods
        public TlsDHKeyExchange(int keyExchange, System.Collections.IList supportedSignatureAlgorithms, Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters)
        {
            if((keyExchange - 3) <= 6)
            {
                    var val_4 = 106069424 + ((keyExchange - 3)) << 2;
                val_4 = val_4 + 106069424;
            }
            else
            {
                    System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "unsupported key exchange algorithm");
            }
        
        }
        public override void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            this.Init(context:  context);
            if(this.mTlsSigner == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            0 = 0;
            this.mTlsSigner.Init(context:  context);
        }
        public override void SkipServerCredentials()
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public override void ProcessServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
        {
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_10;
            var val_11;
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_12;
            var val_14;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_15;
            var val_16;
            var val_17;
            var val_18;
            bool val_20;
            var val_23;
            val_10 = this;
            if((serverCertificate & 1) != 0)
            {
                goto label_2;
            }
            
            val_12 = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo:  serverCertificate.SubjectPublicKeyInfo);
            this.mServerPublicKey = val_12;
            if(this.mTlsSigner == null)
            {
                goto label_4;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = 9;
            goto label_8;
            label_4:
            if(val_12 != null)
            {
                    val_12 = 0;
            }
            
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_5 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ValidateDHPublicKey(key:  val_12);
            this.mDHAgreePublicKey = val_12;
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_6 = val_12.Parameters;
            this.mDHParameters = val_10;
            val_14 = 8;
            goto label_17;
            label_8:
            if((this.mTlsSigner.IsValidPublicKey(publicKey:  val_12)) == false)
            {
                goto label_18;
            }
            
            val_14 = 128;
            label_17:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(c:  serverCertificate, keyUsageBits:  128);
            this.ProcessServerCertificate(serverCertificate:  serverCertificate);
            return;
            label_2:
            val_15 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_16 = 42;
            goto label_21;
            label_18:
            val_15 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_16 = 46;
            label_21:
            val_15 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  46);
            val_17 = 1152921547529597792;
            val_18 = val_15;
            val_23 = 8;
            mem[8] = null;
            val_20 = val_23;
        }
        public override bool get_RequiresServerKeyExchange()
        {
            if(W8 == 3)
            {
                    return true;
            }
            
            if(W8 != 5)
            {
                    return (bool)(W8 == 11) ? 1 : 0;
            }
            
            return true;
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
            Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials val_3;
            if(clientCredentials == null)
            {
                goto label_1;
            }
            
            if(clientCredentials == null)
            {
                goto label_2;
            }
            
            val_3 = clientCredentials;
            if(val_3 != null)
            {
                goto label_3;
            }
            
            label_2:
            val_3 = 0;
            label_3:
            this.mAgreementCredentials = val_3;
            return;
            label_1:
            if(clientCredentials != null)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public override void GenerateClientKeyExchange(System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_3;
            var val_4;
            if(this.mAgreementCredentials != null)
            {
                    return;
            }
            
            var val_6 = mem[137170944];
            if((mem[137170944] + 286) == 0)
            {
                goto label_6;
            }
            
            var val_3 = mem[137170944] + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_5:
            if(((mem[137170944] + 176 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[137170944] + 286))
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_6 = val_6 + val_5;
            val_4 = val_6 + 296;
            label_6:
            val_3 = this.mDHParameters;
            this.mDHAgreePrivateKey = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralClientKeyExchange(random:  SecureRandom, dhParams:  val_3, output:  output);
        }
        public override void ProcessClientCertificate(Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
        {
        
        }
        public override void ProcessClientKeyExchange(System.IO.Stream input)
        {
            Org.BouncyCastle.Math.BigInteger val_4;
            if(this.mDHAgreePublicKey != null)
            {
                    return;
            }
            
            val_4 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input:  input);
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_2 = new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  val_4, parameters:  this.mDHParameters);
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_3 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ValidateDHPublicKey(key:  val_2);
            this.mDHAgreePublicKey = val_2;
        }
        public override byte[] GeneratePremasterSecret()
        {
            if(this.mAgreementCredentials != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                return this.mAgreementCredentials.GenerateAgreement(peerPublicKey:  this.mDHAgreePublicKey);
            }
            
            if(this.mDHAgreePrivateKey != null)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CalculateDHBasicAgreement(publicKey:  this.mDHAgreePublicKey, privateKey:  this.mDHAgreePrivateKey);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        protected virtual int get_MinimumPrimeBits()
        {
            return 1024;
        }
        protected virtual Org.BouncyCastle.Crypto.Parameters.DHParameters ValidateDHParameters(Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
        {
            if(parameters.P.BitLength >= this)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ValidateDHParameters(parameters:  parameters);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  71);
        }
    
    }

}
