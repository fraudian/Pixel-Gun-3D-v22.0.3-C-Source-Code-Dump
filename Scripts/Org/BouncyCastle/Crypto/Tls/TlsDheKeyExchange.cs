using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsDheKeyExchange : TlsDHKeyExchange
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials;
        
        // Methods
        public TlsDheKeyExchange(int keyExchange, System.Collections.IList supportedSignatureAlgorithms, Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters)
        {
        
        }
        public override void ProcessServerCredentials(Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
        {
            Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials val_5;
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
        public override byte[] GenerateServerKeyExchange()
        {
            var val_13;
            var val_14;
            var val_17;
            if(true == 0)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Crypto.Tls.DigestInputBuffer val_1 = new Org.BouncyCastle.Crypto.Tls.DigestInputBuffer();
            var val_17 = X21;
            if((X21 + 286) == 0)
            {
                goto label_6;
            }
            
            var val_14 = X21 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_5:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (X21 + 286))
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            var val_16 = val_14;
            val_16 = val_16 + 1;
            val_17 = val_17 + val_16;
            val_13 = val_17 + 296;
            label_6:
            mem[1152921547528422216] = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralServerKeyExchange(random:  X21.SecureRandom, dhParams:  X21, output:  val_1);
            Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm val_4 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(context:  X21, signerCredentials:  this.mServerCredentials);
            Org.BouncyCastle.Crypto.IDigest val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(signatureAndHashAlgorithm:  val_4);
            var val_21 = X23;
            if((X23 + 286) == 0)
            {
                goto label_15;
            }
            
            var val_18 = X23 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_14:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X23 + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            var val_20 = val_18;
            val_20 = val_20 + 2;
            val_21 = val_21 + val_20;
            val_14 = val_21 + 296;
            label_15:
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_6 = X23.SecurityParameters;
            if(val_6 == null)
            {
                goto label_16;
            }
            
            if(val_6.clientRandom != null)
            {
                goto label_23;
            }
            
            label_24:
            label_23:
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_22;
            label_16:
            if(0 != 0)
            {
                goto label_23;
            }
            
            goto label_24;
            label_22:
            val_5.BlockUpdate(input:  val_6.clientRandom, inOff:  0, length:  val_6.clientRandom.Length);
            if(val_6 == null)
            {
                goto label_25;
            }
            
            if(val_6.serverRandom != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_31;
            label_25:
            if(4194311 != 0)
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            val_17 = 0;
            val_5.BlockUpdate(input:  val_6.serverRandom, inOff:  0, length:  val_6.serverRandom.Length);
            val_1.UpdateDigest(d:  val_5);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_17 = 0;
            Org.BouncyCastle.Crypto.Tls.DigitallySigned val_12 = new Org.BouncyCastle.Crypto.Tls.DigitallySigned(algorithm:  val_4, signature:  this.mServerCredentials.GenerateCertificateSignature(hash:  Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_5)));
            if(val_1 != null)
            {
                    return val_1.ToArray();
            }
            
            return val_1.ToArray();
            label_1:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_13 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public override void ProcessServerKeyExchange(System.IO.Stream input)
        {
            var val_10;
            var val_11;
            var val_14 = mem[137170944];
            if((mem[137170944] + 286) == 0)
            {
                goto label_5;
            }
            
            var val_11 = mem[137170944] + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_4:
            if(((mem[137170944] + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (mem[137170944] + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            var val_13 = val_11;
            val_13 = val_13 + 2;
            val_14 = val_14 + val_13;
            val_10 = val_14 + 296;
            label_5:
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_1 = SecurityParameters;
            Org.BouncyCastle.Crypto.Tls.SignerInputBuffer val_2 = new Org.BouncyCastle.Crypto.Tls.SignerInputBuffer();
            Org.BouncyCastle.Crypto.Tls.ServerDHParams val_4 = Org.BouncyCastle.Crypto.Tls.ServerDHParams.Parse(input:  new Org.BouncyCastle.Utilities.IO.TeeInputStream(input:  input, tee:  val_2));
            Org.BouncyCastle.Crypto.Tls.DigitallySigned val_5 = this.ParseSignature(input:  input);
            val_11 = val_5;
            val_2.UpdateSigner(s:  this);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_11 = 5;
            if((this.VerifySignature(signature:  val_5)) != false)
            {
                    Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_8 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ValidateDHPublicKey(key:  val_4);
                mem[1152921547528756544] = val_4;
                Org.BouncyCastle.Crypto.Parameters.DHParameters val_9 = val_4.Parameters;
                mem[1152921547528756512] = this;
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_10 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  51);
        }
        protected virtual Org.BouncyCastle.Crypto.ISigner InitVerifyer(Org.BouncyCastle.Crypto.Tls.TlsSigner tlsSigner, Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Crypto.ISigner val_2 = tlsSigner.CreateVerifyer(algorithm:  algorithm, publicKey:  this);
            if(securityParameters == null)
            {
                goto label_6;
            }
            
            if(securityParameters.clientRandom != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_12;
            label_6:
            if(0 != 0)
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            val_2.BlockUpdate(input:  securityParameters.clientRandom, inOff:  0, length:  securityParameters.clientRandom.Length);
            if(securityParameters == null)
            {
                goto label_15;
            }
            
            if(securityParameters.serverRandom != null)
            {
                goto label_22;
            }
            
            label_23:
            label_22:
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_21;
            label_15:
            if(4194311 != 0)
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            val_2.BlockUpdate(input:  securityParameters.serverRandom, inOff:  0, length:  securityParameters.serverRandom.Length);
            return val_2;
        }
    
    }

}
