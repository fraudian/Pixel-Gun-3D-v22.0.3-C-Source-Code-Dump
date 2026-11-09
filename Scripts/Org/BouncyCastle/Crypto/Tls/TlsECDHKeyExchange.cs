using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsECDHKeyExchange : AbstractTlsKeyExchange
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner;
        protected int[] mNamedCurves;
        protected byte[] mClientECPointFormats;
        protected byte[] mServerECPointFormats;
        protected Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;
        protected Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials mAgreementCredentials;
        protected Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mECAgreePrivateKey;
        protected Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mECAgreePublicKey;
        
        // Properties
        public override bool RequiresServerKeyExchange { get; }
        
        // Methods
        public TlsECDHKeyExchange(int keyExchange, System.Collections.IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats)
        {
            if((keyExchange - 16) <= 4)
            {
                    var val_4 = 106069472 + ((keyExchange - 16)) << 2;
                val_4 = val_4 + 106069472;
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
            if(true == 20)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public override void ProcessServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
        {
            var val_8;
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_9;
            var val_11;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_12;
            var val_13;
            var val_14;
            bool val_15;
            bool val_16;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_17;
            var val_18;
            var val_19;
            if(true == 20)
            {
                goto label_1;
            }
            
            if((serverCertificate & 1) != 0)
            {
                goto label_3;
            }
            
            val_9 = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo:  serverCertificate.SubjectPublicKeyInfo);
            this.mServerPublicKey = val_9;
            if(this.mTlsSigner == null)
            {
                goto label_5;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = 9;
            goto label_9;
            label_5:
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            this.mECAgreePublicKey = val_9;
            val_11 = 8;
            goto label_17;
            label_9:
            if((this.mTlsSigner.IsValidPublicKey(publicKey:  val_9)) == false)
            {
                goto label_18;
            }
            
            val_11 = 128;
            label_17:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(c:  serverCertificate, keyUsageBits:  128);
            this.ProcessServerCertificate(serverCertificate:  serverCertificate);
            return;
            label_1:
            val_12 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_13 = 10;
            goto label_22;
            label_3:
            val_12 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_13 = 42;
            goto label_22;
            label_18:
            val_12 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_13 = 46;
            label_22:
            val_12 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  46);
            label_23:
            val_14 = 0;
            val_15 = val_12;
            if( != 1)
            {
                goto label_30;
            }
            
            val_16 = mem[X0];
            val_16 = ;
            if((null & 1) == 0)
            {
                goto label_26;
            }
            
            val_17 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_18 = 46;
            goto label_27;
            label_26:
            val_19 = 8;
            mem[8] = ;
            goto label_28;
            label_27:
             = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  43, alertCause:  null);
            goto label_23;
            label_28:
            val_15 = ;
            label_30:
        }
        public override bool get_RequiresServerKeyExchange()
        {
            if(W8 != 17)
            {
                    return (bool)((W8 - 19) < 2) ? 1 : 0;
            }
            
            return true;
        }
        public override byte[] GenerateServerKeyExchange()
        {
            var val_4;
            if((this & 1) == 0)
            {
                    return 0;
            }
            
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            var val_7 = X21;
            if((X21 + 286) == 0)
            {
                goto label_6;
            }
            
            var val_4 = X21 + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_5:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < (X21 + 286))
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            var val_6 = val_4;
            val_6 = val_6 + 1;
            val_7 = val_7 + val_6;
            val_4 = val_7 + 296;
            label_6:
            this.mECAgreePrivateKey = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralServerKeyExchange(random:  X21.SecureRandom, namedCurves:  this.mNamedCurves, ecPointFormats:  this.mClientECPointFormats, output:  val_1);
            if(val_1 == null)
            {
                
            }
        
        }
        public override void ProcessServerKeyExchange(System.IO.Stream input)
        {
            if((this & 1) != 0)
            {
                    this.mECAgreePublicKey = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(ecPointFormats:  this.mClientECPointFormats, curve_params:  Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameters(namedCurves:  this.mNamedCurves, ecPointFormats:  this.mClientECPointFormats, input:  input), encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  input));
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public override void ValidateCertificateRequest(Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
        {
            goto label_2;
            label_7:
            0 = 1;
            label_2:
            if(0 < certificateRequest.mSupportedSignatureAlgorithms)
            {
                goto label_7;
            }
        
        }
        public override void ProcessClientCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
        {
            Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials val_3;
            if(true == 20)
            {
                goto label_6;
            }
            
            if(clientCredentials == null)
            {
                goto label_2;
            }
            
            if(clientCredentials == null)
            {
                goto label_3;
            }
            
            val_3 = clientCredentials;
            if(val_3 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_3 = 0;
            label_4:
            this.mAgreementCredentials = val_3;
            return;
            label_2:
            if(clientCredentials != null)
            {
                    return;
            }
            
            label_6:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public override void GenerateClientKeyExchange(System.IO.Stream output)
        {
            System.Byte[] val_4;
            var val_5;
            if(this.mAgreementCredentials != null)
            {
                    return;
            }
            
            var val_7 = mem[137170944];
            if((mem[137170944] + 286) == 0)
            {
                goto label_6;
            }
            
            var val_4 = mem[137170944] + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_5:
            if(((mem[137170944] + 176 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < (mem[137170944] + 286))
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            var val_6 = val_4;
            val_6 = val_6 + 1;
            val_7 = val_7 + val_6;
            val_5 = val_7 + 296;
            label_6:
            val_4 = this.mServerECPointFormats;
            this.mECAgreePrivateKey = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralClientKeyExchange(random:  SecureRandom, ecPointFormats:  val_4, ecParams:  this.mECAgreePublicKey.Parameters, output:  output);
        }
        public override void ProcessClientCertificate(Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
        {
            if(true != 20)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public override void ProcessClientKeyExchange(System.IO.Stream input)
        {
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_4;
            if(this.mECAgreePublicKey != null)
            {
                    return;
            }
            
            val_4 = this.mECAgreePrivateKey.Parameters;
            this.mECAgreePublicKey = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(ecPointFormats:  this.mServerECPointFormats, curve_params:  val_4, encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  input));
        }
        public override byte[] GeneratePremasterSecret()
        {
            if(this.mAgreementCredentials != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                return this.mAgreementCredentials.GenerateAgreement(peerPublicKey:  this.mECAgreePublicKey);
            }
            
            if(this.mECAgreePrivateKey != null)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CalculateECDHBasicAgreement(publicKey:  this.mECAgreePublicKey, privateKey:  this.mECAgreePrivateKey);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
    
    }

}
