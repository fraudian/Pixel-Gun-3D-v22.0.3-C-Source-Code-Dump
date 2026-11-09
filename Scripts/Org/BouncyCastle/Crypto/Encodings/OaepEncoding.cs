using UnityEngine;

namespace Org.BouncyCastle.Crypto.Encodings
{
    public class OaepEncoding : IAsymmetricBlockCipher
    {
        // Fields
        private byte[] defHash;
        private Org.BouncyCastle.Crypto.IDigest hash;
        private Org.BouncyCastle.Crypto.IDigest mgf1Hash;
        private Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;
        private Org.BouncyCastle.Security.SecureRandom random;
        private bool forEncryption;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public OaepEncoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
        {
            Org.BouncyCastle.Crypto.Digests.Sha1Digest val_1 = new Org.BouncyCastle.Crypto.Digests.Sha1Digest();
        }
        public OaepEncoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest hash)
        {
        
        }
        public OaepEncoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest hash, byte[] encodingParams)
        {
        
        }
        public OaepEncoding(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest hash, Org.BouncyCastle.Crypto.IDigest mgf1Hash, byte[] encodingParams)
        {
            System.Byte[] val_6;
            this.mgf1Hash = mgf1Hash;
            this.engine = cipher;
            this.hash = hash;
            var val_7 = 0;
            val_7 = val_7 + 1;
            int val_2 = hash.GetDigestSize();
            val_6 = new byte[0];
            this.defHash = val_6;
            if(encodingParams != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                hash.BlockUpdate(input:  encodingParams, inOff:  0, length:  encodingParams.Length);
                val_6 = this.defHash;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            int val_6 = hash.DoFinal(output:  val_6, outOff:  0);
        }
        public Org.BouncyCastle.Crypto.IAsymmetricBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IAsymmetricBlockCipher)this.engine;
        }
        public string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.engine.AlgorithmName + "/OAEPPadding"("/OAEPPadding");
        }
        public void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters param)
        {
            this.random = new Org.BouncyCastle.Security.SecureRandom();
            var val_5 = 0;
            val_5 = val_5 + 1;
            bool val_3 = forEncryption;
            this.engine.Init(forEncryption:  val_3, parameters:  param);
            this.forEncryption = val_3;
        }
        public int GetInputBlockSize()
        {
            System.Byte[] val_3;
            var val_5;
            val_3 = this;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = this.engine.GetInputBlockSize();
            if(this.forEncryption == false)
            {
                    return (int)val_5;
            }
            
            val_3 = this.defHash;
            val_5 = (val_5 - 1) - (this.defHash.Length << 1);
            return (int)val_5;
        }
        public int GetOutputBlockSize()
        {
            System.Byte[] val_3;
            var val_5;
            val_3 = this;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = this.engine.GetOutputBlockSize();
            if(this.forEncryption == true)
            {
                    return (int)val_5;
            }
            
            val_3 = this.defHash;
            val_5 = (val_5 - 1) - (this.defHash.Length << 1);
            return (int)val_5;
        }
        public byte[] ProcessBlock(byte[] inBytes, int inOff, int inLen)
        {
            if(this.forEncryption == false)
            {
                    return this.DecodeBlock(inBytes:  inBytes, inOff:  inOff, inLen:  inLen);
            }
            
            return this.EncodeBlock(inBytes:  inBytes, inOff:  inOff, inLen:  inLen);
        }
        private byte[] EncodeBlock(byte[] inBytes, int inOff, int inLen)
        {
            System.Byte[] val_12;
            int val_13;
            int val_14;
            byte val_15;
            System.Byte[] val_16;
            var val_17;
            int val_11 = this.defHash.Length;
            val_11 = this.GetInputBlockSize() + (val_11 << 1);
            int val_2 = val_11 + 1;
            byte[] val_3 = new byte[0];
            inLen = val_3.Length - inLen;
            System.Array.Copy(sourceArray:  inBytes, sourceIndex:  inOff, destinationArray:  val_3, destinationIndex:  inLen, length:  inLen);
            int val_4 = val_3.Length - inLen;
            val_4 = val_4 - 1;
            val_3[(long)val_4] = 1;
            val_12 = this.defHash;
            if(this.defHash != null)
            {
                goto label_5;
            }
            
            val_12 = this.defHash;
            if(val_12 == null)
            {
                goto label_6;
            }
            
            label_5:
            System.Array.Copy(sourceArray:  this.defHash, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  this.defHash.Length, length:  this.defHash.Length);
            System.Byte[] val_5 = Org.BouncyCastle.Security.SecureRandom.GetNextBytes(secureRandom:  this.random, length:  this.defHash.Length);
            System.Byte[] val_7 = this.maskGeneratorFunction1(Z:  val_5, zOff:  0, zLen:  val_5.Length, length:  val_3.Length - this.defHash.Length);
            val_13 = this.defHash.Length;
            val_14 = val_3.Length;
            goto label_18;
            label_21:
            val_15 = val_3[(long)val_13];
            if(this.defHash == null)
            {
                goto label_15;
            }
            
            label_20:
            int val_12 = this.defHash.Length;
            val_12 = (long)val_13 - val_12;
            byte val_13 = val_7[(long)val_12];
            val_13 = val_13 ^ val_15;
            mem2[0] = val_13;
            val_14 = val_3.Length;
            val_13 = (long)val_13 + 1;
            goto label_18;
            label_15:
            if(val_7 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_18:
            if(val_13 != val_14)
            {
                goto label_21;
            }
            
            System.Array.Copy(sourceArray:  val_5, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  0, length:  this.defHash.Length);
            val_16 = this.defHash;
            if(this.defHash != null)
            {
                goto label_23;
            }
            
            val_16 = this.defHash;
            if(val_16 == null)
            {
                goto label_24;
            }
            
            label_23:
            val_17 = 0;
            goto label_25;
            label_30:
            val_15 = val_3[0];
            byte val_14 = this.maskGeneratorFunction1(Z:  val_3, zOff:  this.defHash.Length, zLen:  val_3.Length - this.defHash.Length, length:  this.defHash.Length)[0];
            val_17 = 1;
            val_14 = val_14 ^ val_15;
            mem2[0] = val_14;
            label_25:
            if(val_17 != this.defHash.Length)
            {
                goto label_30;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            return this.engine.ProcessBlock(inBuf:  val_3, inOff:  0, inLen:  val_3.Length);
            label_24:
            label_6:
        }
        private byte[] DecodeBlock(byte[] inBytes, int inOff, int inLen)
        {
            System.Array val_19;
            System.Byte[] val_22;
            var val_23;
            System.Byte[] val_24;
            int val_25;
            int val_26;
            var val_27;
            var val_28;
            int val_29;
            int val_30;
            var val_31;
            var val_32;
            string val_34;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_19 = this.engine.ProcessBlock(inBuf:  inBytes, inOff:  inOff, inLen:  inLen);
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(this.engine.GetOutputBlockSize() <= val_2.Length)
            {
                goto label_12;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            int val_6 = this.engine.GetOutputBlockSize();
            byte[] val_7 = new byte[0];
            if(val_7 == null)
            {
                goto label_18;
            }
            
            label_61:
            System.Array.Copy(sourceArray:  val_19, sourceIndex:  0, destinationArray:  val_7, destinationIndex:  val_7.Length - val_2.Length, length:  val_2.Length);
            val_19 = val_7;
            label_12:
            if(1 > val_7.Length)
            {
                goto label_21;
            }
            
            val_22 = this.defHash;
            if(this.defHash != null)
            {
                goto label_22;
            }
            
            val_22 = this.defHash;
            if(val_22 == null)
            {
                goto label_23;
            }
            
            label_22:
            val_23 = 0;
            goto label_24;
            label_29:
            byte val_23 = this.maskGeneratorFunction1(Z:  val_7, zOff:  this.defHash.Length, zLen:  val_7.Length - this.defHash.Length, length:  this.defHash.Length)[0];
            val_23 = 1;
            val_23 = val_23 ^ val_19[0];
            mem2[0] = val_23;
            label_24:
            if(val_23 != this.defHash.Length)
            {
                goto label_29;
            }
            
            val_24 = this.defHash;
            if(this.defHash != null)
            {
                goto label_30;
            }
            
            val_24 = this.defHash;
            if(val_24 == null)
            {
                goto label_31;
            }
            
            label_30:
            System.Byte[] val_12 = this.maskGeneratorFunction1(Z:  val_7, zOff:  0, zLen:  this.defHash.Length, length:  val_7.Length - this.defHash.Length);
            val_25 = this.defHash.Length;
            val_26 = val_7.Length;
            goto label_38;
            label_41:
            if(this.defHash == null)
            {
                goto label_35;
            }
            
            label_40:
            int val_25 = this.defHash.Length;
            val_25 = (long)val_25 - val_25;
            byte val_26 = val_12[(long)val_25];
            val_26 = val_26 ^ val_19[(long)val_25];
            mem2[0] = val_26;
            val_26 = val_7.Length;
            val_25 = (long)val_25 + 1;
            goto label_38;
            label_35:
            if(val_12 != null)
            {
                goto label_40;
            }
            
            goto label_40;
            label_38:
            if(val_25 != val_26)
            {
                goto label_41;
            }
            
            val_27 = 0;
            val_28 = 0;
            goto label_42;
            label_48:
            int val_28 = this.defHash.Length;
            val_28 = val_27 + val_28;
            byte val_29 = val_19[(long)val_28];
            val_27 = 1;
            val_29 = val_29 ^ this.defHash[0];
            val_29 = val_29 & 255;
            val_28 = val_28 | val_29;
            label_42:
            if(val_27 < this.defHash.Length)
            {
                goto label_48;
            }
            
            if(val_28 != 0)
            {
                goto label_49;
            }
            
            val_29 = val_7.Length;
            val_30 = this.defHash.Length << 1;
            goto label_51;
            label_54:
            if(val_19[(long)val_30] != 0)
            {
                goto label_53;
            }
            
            val_29 = val_7.Length;
            val_30 = val_30 + 1;
            label_51:
            if(val_30 != val_29)
            {
                goto label_54;
            }
            
            goto label_55;
            label_53:
            val_29 = val_7.Length;
            label_55:
            if(val_30 > (val_29 - 1))
            {
                goto label_58;
            }
            
            if(val_19[(long)val_30] != 1)
            {
                goto label_58;
            }
            
            val_30 = val_30 + 1;
            int val_14 = val_7.Length - val_30;
            byte[] val_15 = new byte[0];
            System.Array.Copy(sourceArray:  val_7, sourceIndex:  val_30, destinationArray:  val_15, destinationIndex:  0, length:  val_15.Length);
            return (System.Byte[])val_15;
            label_18:
            if(val_19 != null)
            {
                goto label_61;
            }
            
            goto label_61;
            label_58:
            val_31 = 1152921553230149632;
            val_32 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "data start wrong " + val_30);
            goto label_62;
            label_21:
            val_34 = "data too short";
            goto label_63;
            label_49:
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_18 = null;
            val_34 = "data hash wrong";
            label_63:
            val_18 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_34);
            val_31 = 1152921553230149632;
            val_32 = val_18;
            label_62:
            label_23:
            label_31:
        }
        private void ItoOSP(int i, byte[] sp)
        {
            int val_4 = sp.Length;
            if(val_4 == 0)
            {
                    val_4 = sp.Length;
            }
            
            sp[0] = i >> 24;
            if(val_4 <= 1)
            {
                    val_4 = sp.Length;
            }
            
            sp[0] = i >> 16;
            if(val_4 <= 2)
            {
                    val_4 = sp.Length;
            }
            
            sp[0] = i >> 8;
            sp[0] = i;
        }
        private byte[] maskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
        {
            Org.BouncyCastle.Crypto.IDigest val_16;
            int val_17;
            Org.BouncyCastle.Crypto.IDigest val_18;
            int val_22;
            val_16 = length;
            val_17 = zOff;
            val_18 = this;
            byte[] val_1 = new byte[0];
            var val_19 = 0;
            val_19 = val_19 + 1;
            int val_3 = this.mgf1Hash.GetDigestSize();
            byte[] val_4 = new byte[0];
            byte[] val_5 = new byte[4];
            var val_20 = 0;
            val_20 = val_20 + 1;
            this.hash.Reset();
            int val_24 = 0;
            label_31:
            this.hash.ItoOSP(i:  0, sp:  val_5);
            var val_21 = 0;
            val_21 = val_21 + 1;
            this.mgf1Hash.BlockUpdate(input:  Z, inOff:  val_17, length:  zLen);
            if(val_5 == null)
            {
                goto label_16;
            }
            
            label_23:
            val_22 = val_5.Length;
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_21;
            label_16:
            if(this.mgf1Hash != null)
            {
                goto label_23;
            }
            
            goto label_23;
            label_21:
            this.mgf1Hash.BlockUpdate(input:  val_5, inOff:  0, length:  val_22);
            var val_23 = 0;
            val_23 = val_23 + 1;
            int val_10 = this.mgf1Hash.DoFinal(output:  val_4, outOff:  0);
            System.Array.Copy(sourceArray:  val_4, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  val_24 * val_4.Length, length:  val_4.Length);
            val_24 = val_24 + 1;
            int val_25 = val_4.Length;
            if(val_24 < (val_16 / val_25))
            {
                goto label_31;
            }
            
            val_25 = val_24 * val_25;
            if(val_25 >= val_16)
            {
                    return (System.Byte[])val_1;
            }
            
            this.ItoOSP(i:  val_24, sp:  val_5);
            val_16 = this.mgf1Hash;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_16.BlockUpdate(input:  Z, inOff:  val_17, length:  zLen);
            val_22 = this.mgf1Hash;
            if(val_5 == null)
            {
                goto label_38;
            }
            
            if(val_22 != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            val_17 = val_5.Length;
            var val_27 = 0;
            val_27 = val_27 + 1;
            goto label_43;
            label_38:
            if(val_22 != null)
            {
                goto label_44;
            }
            
            goto label_45;
            label_43:
            val_22.BlockUpdate(input:  val_5, inOff:  0, length:  val_17);
            val_18 = this.mgf1Hash;
            var val_28 = 0;
            val_28 = val_28 + 1;
            int val_16 = val_18.DoFinal(output:  val_4, outOff:  0);
            if(val_1 == 0)
            {
                goto label_52;
            }
            
            if(val_4 != null)
            {
                goto label_54;
            }
            
            label_55:
            label_54:
            int val_17 = val_24 * val_4.Length;
            System.Array.Copy(sourceArray:  val_4, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  val_17, length:  mem[1152921553231262488] - val_17);
            return (System.Byte[])val_1;
            label_52:
            if(val_4 != null)
            {
                goto label_54;
            }
            
            goto label_55;
        }
    
    }

}
