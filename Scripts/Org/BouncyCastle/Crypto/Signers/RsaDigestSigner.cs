using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class RsaDigestSigner : ISigner
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IAsymmetricBlockCipher rsaEngine;
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId;
        private readonly Org.BouncyCastle.Crypto.IDigest digest;
        private bool forSigning;
        private static readonly System.Collections.IDictionary oidMap;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        private static RsaDigestSigner()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_13 = null;
            val_13 = null;
            var val_5 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_9;
            }
            
            var val_2 = mem[val_1] + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_8:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (mem[val_1] + 286))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            var val_4 = val_2;
            val_4 = val_4 + 1;
            val_5 = val_5 + val_4;
            val_14 = val_5 + 296;
            label_9:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "RIPEMD128", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128);
            var val_9 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_14;
            }
            
            var val_6 = mem[val_1] + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_13:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (mem[val_1] + 286))
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            var val_8 = val_6;
            val_8 = val_8 + 1;
            val_9 = val_9 + val_8;
            val_15 = val_9 + 296;
            label_14:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "RIPEMD160", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160);
            var val_13 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_19;
            }
            
            var val_10 = mem[val_1] + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_18:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_17;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (mem[val_1] + 286))
            {
                goto label_18;
            }
            
            goto label_19;
            label_17:
            var val_12 = val_10;
            val_12 = val_12 + 1;
            val_13 = val_13 + val_12;
            val_16 = val_13 + 296;
            label_19:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "RIPEMD256", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256);
            val_17 = null;
            val_17 = null;
            var val_17 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_26;
            }
            
            var val_14 = mem[val_1] + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_25:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_24;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[val_1] + 286))
            {
                goto label_25;
            }
            
            goto label_26;
            label_24:
            var val_16 = val_14;
            val_16 = val_16 + 1;
            val_17 = val_17 + val_16;
            val_18 = val_17 + 296;
            label_26:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "SHA-1", value:  Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdSha1);
            val_19 = null;
            val_19 = null;
            var val_21 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_33;
            }
            
            var val_18 = mem[val_1] + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_32:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_31;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (mem[val_1] + 286))
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            var val_20 = val_18;
            val_20 = val_20 + 1;
            val_21 = val_21 + val_20;
            val_20 = val_21 + 296;
            label_33:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "SHA-224", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
            var val_25 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_38;
            }
            
            var val_22 = mem[val_1] + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_37:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_36;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (mem[val_1] + 286))
            {
                goto label_37;
            }
            
            goto label_38;
            label_36:
            var val_24 = val_22;
            val_24 = val_24 + 1;
            val_25 = val_25 + val_24;
            val_21 = val_25 + 296;
            label_38:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "SHA-256", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
            var val_29 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_43;
            }
            
            var val_26 = mem[val_1] + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_42:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_41;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (mem[val_1] + 286))
            {
                goto label_42;
            }
            
            goto label_43;
            label_41:
            var val_28 = val_26;
            val_28 = val_28 + 1;
            val_29 = val_29 + val_28;
            val_22 = val_29 + 296;
            label_43:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "SHA-384", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
            var val_33 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_48;
            }
            
            var val_30 = mem[val_1] + 176;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_47:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_46;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (mem[val_1] + 286))
            {
                goto label_47;
            }
            
            goto label_48;
            label_46:
            var val_32 = val_30;
            val_32 = val_32 + 1;
            val_33 = val_33 + val_32;
            val_23 = val_33 + 296;
            label_48:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "SHA-512", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
            val_24 = null;
            val_24 = null;
            var val_37 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_55;
            }
            
            var val_34 = mem[val_1] + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_54:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_53;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (mem[val_1] + 286))
            {
                goto label_54;
            }
            
            goto label_55;
            label_53:
            var val_36 = val_34;
            val_36 = val_36 + 1;
            val_37 = val_37 + val_36;
            val_25 = val_37 + 296;
            label_55:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "MD2", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2);
            var val_41 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_60;
            }
            
            var val_38 = mem[val_1] + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_59:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_58;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (mem[val_1] + 286))
            {
                goto label_59;
            }
            
            goto label_60;
            label_58:
            var val_40 = val_38;
            val_40 = val_40 + 1;
            val_41 = val_41 + val_40;
            val_26 = val_41 + 296;
            label_60:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "MD4", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4);
            var val_45 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_65;
            }
            
            var val_42 = mem[val_1] + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_64:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_63;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < (mem[val_1] + 286))
            {
                goto label_64;
            }
            
            goto label_65;
            label_63:
            var val_44 = val_42;
            val_44 = val_44 + 1;
            val_45 = val_45 + val_44;
            val_27 = val_45 + 296;
            label_65:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.set_Item(key:  "MD5", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5);
        }
        public RsaDigestSigner(Org.BouncyCastle.Crypto.IDigest digest)
        {
            var val_5;
            var val_6;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_9;
            val_5 = null;
            val_5 = null;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_6 = 0;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_6 = 0;
            val_9 = Org.BouncyCastle.Crypto.Signers.RsaDigestSigner.oidMap.Item[digest.AlgorithmName];
            if(val_9 == null)
            {
                    return;
            }
            
            val_9 = 0;
        }
        public RsaDigestSigner(Org.BouncyCastle.Crypto.IDigest digest, Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid)
        {
            null = null;
            Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_1 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  digestOid, parameters:  Org.BouncyCastle.Asn1.DerNull.Instance);
        }
        public RsaDigestSigner(Org.BouncyCastle.Crypto.IDigest digest, Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId)
        {
            this.rsaEngine = new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
            this.algId = algId;
            this.digest = digest;
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.digest.AlgorithmName + "withRSA";
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_11;
            string val_13;
            this.forSigning = forSigning;
            if(parameters != null)
            {
                    val_11 = parameters;
            }
            
            val_11 = 0;
            if(forSigning == false)
            {
                goto label_8;
            }
            
            if(val_11.IsPrivate == true)
            {
                goto label_10;
            }
            
            val_13 = "Signing requires private key.";
            goto label_11;
            label_8:
            if(val_11.IsPrivate == true)
            {
                goto label_13;
            }
            
            label_10:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.rsaEngine.Init(forEncryption:  forSigning, parameters:  parameters);
            return;
            label_13:
            val_13 = "Verification requires public key.";
            label_11:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_13);
        }
        public virtual void Update(byte input)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Update(input:  input);
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.BlockUpdate(input:  input, inOff:  inOff, length:  length);
        }
        public virtual byte[] GenerateSignature()
        {
            if(this.forSigning == false)
            {
                goto label_1;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            int val_2 = this.digest.GetDigestSize();
            byte[] val_3 = new byte[0];
            var val_10 = 0;
            val_10 = val_10 + 1;
            int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
            System.Byte[] val_6 = this.DerEncode(hash:  val_3);
            if(val_6 == null)
            {
                goto label_12;
            }
            
            label_19:
            var val_11 = 0;
            val_11 = val_11 + 1;
            return this.rsaEngine.ProcessBlock(inBuf:  val_6, inOff:  0, inLen:  val_6.Length);
            label_12:
            if(this.rsaEngine != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_1:
            System.InvalidOperationException val_8 = new System.InvalidOperationException(message:  "RsaDigestSigner not initialised for signature generation.");
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            System.Byte[] val_15;
            System.Byte[] val_17;
            int val_19;
            int val_21;
            var val_22;
            int val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_15 = signature;
            if(this.forSigning == true)
            {
                goto label_1;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            int val_2 = this.digest.GetDigestSize();
            byte[] val_3 = new byte[0];
            val_17 = val_3;
            var val_16 = 0;
            val_16 = val_16 + 1;
            int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
            val_19 = signature.Length;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_15 = this.rsaEngine.ProcessBlock(inBuf:  val_15, inOff:  0, inLen:  val_19);
            System.Byte[] val_8 = this.DerEncode(hash:  val_3);
            if(val_15 == null)
            {
                goto label_18;
            }
            
            label_25:
            int val_18 = val_8.Length;
            if(val_7.Length == val_18)
            {
                    return Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  val_15, b:  val_8);
            }
            
            val_18 = val_18 - 2;
            if(val_18 != val_7.Length)
            {
                goto label_21;
            }
            
            if(val_17 == null)
            {
                goto label_22;
            }
            
            val_21 = val_3.Length;
            val_22 = val_7.Length - val_21;
            goto label_23;
            label_18:
            if(val_8 != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_22:
            val_22 = val_7.Length - val_3.Length;
            val_21 = val_21;
            label_23:
            val_23 = val_8.Length;
            if(val_8.Length <= 1)
            {
                    val_23 = val_8.Length;
            }
            
            byte val_19 = val_8[0];
            val_19 = val_19 + 254;
            val_8[0] = val_19;
            byte val_20 = val_8[0];
            val_19 = val_22 - 2;
            val_24 = 0;
            val_20 = val_20 + 254;
            val_8[0] = val_20;
            if(val_21 >= 1)
            {
                    val_21 = (val_8.Length - 2) - val_21;
                do
            {
                byte val_22 = val_8[(long)val_21 + 0];
                val_25 = 0 + 1;
                val_22 = val_22 ^ (val_15[(long)val_19 + 0]);
                val_22 = val_22 & 255;
                val_24 = val_24 | val_22;
            }
            while(val_25 < val_21);
            
            }
            
            if(val_19 >= 1)
            {
                    val_19 = val_19;
                do
            {
                val_17 = 0 + 1;
                System.Byte[] val_12 = 1152921505721910208 ^ 1152921505721910208;
                val_12 = val_12 & 255;
                val_24 = val_24 | val_12;
            }
            while(val_19 != val_17);
            
            }
            
            var val_13 = (val_24 == 0) ? 1 : 0;
            return (bool)val_26;
            label_1:
            val_27 = new System.InvalidOperationException(message:  "RsaDigestSigner not initialised for verification");
            if(0 != 1)
            {
                goto label_38;
            }
            
            if((null & 1) == 0)
            {
                goto label_39;
            }
            
            UnityEngine.Debug.LogException(exception:  1152921504622235648);
            label_21:
            val_26 = 0;
            return (bool)val_26;
            label_39:
            mem[8] = null;
            val_27 = 8;
            label_38:
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Reset();
        }
        private byte[] DerEncode(byte[] hash)
        {
            if(this.algId == null)
            {
                    return (System.Byte[])hash;
            }
            
            Org.BouncyCastle.Asn1.X509.DigestInfo val_1 = new Org.BouncyCastle.Asn1.X509.DigestInfo(algID:  this.algId, digest:  hash);
            if(val_1 != null)
            {
                    return val_1.GetDerEncoded();
            }
            
            return val_1.GetDerEncoded();
        }
    
    }

}
