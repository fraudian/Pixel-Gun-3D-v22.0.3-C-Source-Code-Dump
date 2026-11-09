using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsRsaUtilities
    {
        // Methods
        public static byte[] GenerateEncryptedPreMasterSecret(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaServerPublicKey, System.IO.Stream output)
        {
            byte[] val_1 = new byte[48];
            var val_13 = 0;
            val_13 = val_13 + 1;
            Org.BouncyCastle.Security.SecureRandom val_3 = context.SecureRandom;
            var val_14 = 0;
            val_14 = val_14 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(version:  context.ClientVersion, buf:  val_1, offset:  0);
            Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding val_7 = new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_7.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters:  rsaServerPublicKey, random:  context.SecureRandom));
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  context)) != false)
            {
                    if(output != null)
            {
                    return (System.Byte[])val_1;
            }
            
                return (System.Byte[])val_1;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  val_7.ProcessBlock(input:  val_1, inOff:  0, length:  val_1.Length), output:  output);
            return (System.Byte[])val_1;
        }
        public static byte[] SafeDecryptPreMasterSecret(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
        {
            var val_13;
            int val_17;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_13 = 4;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_2 = context.ClientVersion;
            byte[] val_3 = new byte[48];
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_13 = 1;
            Org.BouncyCastle.Security.SecureRandom val_5 = context.SecureRandom;
            System.Byte[] val_6 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_3);
            new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine() = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding() = new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), fallback:  val_3);
            var val_18 = 0;
            val_18 = val_18 + 1;
            new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom() = new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters:  rsaServerPrivateKey, random:  context.SecureRandom);
            new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding().Init(forEncryption:  false, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom());
            System.Byte[] val_12 = new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding().ProcessBlock(input:  encryptedPreMasterSecret, inOff:  0, length:  encryptedPreMasterSecret.Length);
            int val_20 = val_2.version;
            val_17 = val_12.Length;
            if(val_17 == 0)
            {
                    val_17 = val_12.Length;
            }
            
            byte val_19 = val_12[0];
            val_20 = val_20 >> 8;
            byte val_21 = val_12[0];
            var val_23 = 0;
            val_21 = val_2.version ^ val_21;
            val_21 = val_21 | val_20 ^ val_19;
            val_21 = val_21 | (val_21 >> 1);
            val_21 = val_21 | (val_21 >> 2);
            val_21 = val_21 | (val_21 >> 4);
            val_21 = val_21 & 1;
            val_20 = val_21 - 1;
            val_19 = val_20 ^ 255;
            do
            {
                byte val_22 = val_12[val_23];
                val_22 = (val_19 & 1152921505721910208) | (val_20 & val_22);
                val_23 = val_23 + 1;
                val_12[val_23] = val_22;
            }
            while(val_23 != 48);
            
            return val_12;
        }
        protected TlsRsaUtilities()
        {
        
        }
    
    }

}
