using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class PssSigner : ISigner
    {
        // Fields
        public const byte TrailerImplicit = 188;
        private readonly Org.BouncyCastle.Crypto.IDigest contentDigest1;
        private readonly Org.BouncyCastle.Crypto.IDigest contentDigest2;
        private readonly Org.BouncyCastle.Crypto.IDigest mgfDigest;
        private readonly Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;
        private Org.BouncyCastle.Security.SecureRandom random;
        private int hLen;
        private int mgfhLen;
        private int sLen;
        private bool sSet;
        private int emBits;
        private byte[] salt;
        private byte[] mDash;
        private byte[] block;
        private byte trailer;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public static Org.BouncyCastle.Crypto.Signers.PssSigner CreateRawSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            return (Org.BouncyCastle.Crypto.Signers.PssSigner)new Org.BouncyCastle.Crypto.Signers.PssSigner(cipher:  cipher, contentDigest1:  new Org.BouncyCastle.Crypto.Digests.NullDigest(), contentDigest2:  digest, mgfDigest:  digest, saltLen:  digest.GetDigestSize(), salt:  0, trailer:  188);
        }
        public static Org.BouncyCastle.Crypto.Signers.PssSigner CreateRawSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest contentDigest, Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen, byte trailer)
        {
            return (Org.BouncyCastle.Crypto.Signers.PssSigner)new Org.BouncyCastle.Crypto.Signers.PssSigner(cipher:  cipher, contentDigest1:  new Org.BouncyCastle.Crypto.Digests.NullDigest(), contentDigest2:  contentDigest, mgfDigest:  mgfDigest, saltLen:  saltLen, salt:  0, trailer:  trailer);
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            int val_2 = digest.GetDigestSize();
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest, int saltLen)
        {
        
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest, byte[] salt)
        {
            if(salt != null)
            {
                    return;
            }
        
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest contentDigest, Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen)
        {
        
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest contentDigest, Org.BouncyCastle.Crypto.IDigest mgfDigest, byte[] salt)
        {
            if(salt != null)
            {
                    return;
            }
        
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest, int saltLen, byte trailer)
        {
        
        }
        public PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest contentDigest, Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen, byte trailer)
        {
        
        }
        private PssSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest contentDigest1, Org.BouncyCastle.Crypto.IDigest contentDigest2, Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen, byte[] salt, byte trailer)
        {
            System.Byte[] val_7 = salt;
            this.mgfDigest = mgfDigest;
            this.cipher = cipher;
            this.contentDigest1 = contentDigest1;
            this.contentDigest2 = contentDigest2;
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.hLen = contentDigest2.GetDigestSize();
            var val_10 = 0;
            val_10 = val_10 + 1;
            this.mgfhLen = mgfDigest.GetDigestSize();
            this.sLen = saltLen;
            this.sSet = (val_7 != null) ? 1 : 0;
            if(val_7 == null)
            {
                    val_7 = new byte[0];
            }
            
            this.salt = val_7;
            int val_11 = this.hLen;
            val_11 = saltLen + val_11;
            int val_7 = val_11 + 8;
            this.mDash = new byte[0];
            this.trailer = trailer;
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.mgfDigest.AlgorithmName + "withRSAandMGF1";
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_14;
            var val_15;
            val_14 = parameters;
            if(forSigning != false)
            {
                    Org.BouncyCastle.Security.SecureRandom val_1 = null;
                val_15 = val_1;
                val_1 = new Org.BouncyCastle.Security.SecureRandom();
                this.random = null;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            this.cipher.Init(forEncryption:  forSigning, parameters:  null);
            if(null != 0)
            {
                    val_14 = 0;
            }
            
            int val_6 = 28563616.BitLength;
            int val_15 = this.hLen;
            int val_7 = val_6 - 1;
            this.emBits = val_7;
            val_15 = this.sLen + val_15;
            val_15 = val_15 << 3;
            val_15 = val_15 + 9;
            if(val_7 >= val_15)
            {
                    int val_8 = val_6 + 6;
                var val_11 = ((val_8 < 0) ? (val_6 + 13) : (val_8)) >> 3;
                this.block = new byte[0];
                return;
            }
            
            System.ArgumentException val_13 = new System.ArgumentException(message:  "key too small for specified hash and salt lengths");
        }
        private void ClearBlock(byte[] block)
        {
            System.Array.Clear(array:  block, index:  0, length:  block.Length);
        }
        public virtual void Update(byte input)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.contentDigest1.Update(input:  input);
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.contentDigest1.BlockUpdate(input:  input, inOff:  inOff, length:  length);
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.contentDigest1.Reset();
        }
        public virtual byte[] GenerateSignature()
        {
            System.Byte[] val_13;
            int val_17;
            int val_18;
            var val_19;
            byte val_20;
            val_13 = this.mDash;
            int val_16 = this.hLen;
            val_16 = this.mDash.Length - (this.sLen + val_16);
            var val_17 = 0;
            val_17 = val_17 + 1;
            int val_3 = this.contentDigest1.DoFinal(output:  val_13, outOff:  val_16);
            if(this.sLen != 0)
            {
                    if(this.sSet != true)
            {
                    val_13 = this.random;
            }
            
                this.salt.CopyTo(array:  this.mDash, index:  this.mDash.Length - this.sLen);
            }
            
            byte[] val_5 = new byte[0];
            if(this.mDash == null)
            {
                goto label_12;
            }
            
            if(this.contentDigest2 != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_17;
            label_12:
            if(this.contentDigest2 != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_17:
            this.contentDigest2.BlockUpdate(input:  this.mDash, inOff:  0, length:  this.mDash.Length);
            var val_19 = 0;
            val_19 = val_19 + 1;
            int val_8 = this.contentDigest2.DoFinal(output:  val_5, outOff:  0);
            if(this.block != null)
            {
                    val_17 = this.sLen;
                val_18 = this.hLen;
            }
            else
            {
                    val_17 = this.sLen;
                val_18 = this.hLen;
            }
            
            int val_21 = this.block.Length;
            var val_20 = -2;
            val_20 = val_20 - val_18;
            val_20 = val_20 - val_17;
            val_21 = val_20 + val_21;
            this.block[(long)val_21] = 1;
            int val_23 = this.sLen;
            var val_22 = ~val_23;
            val_22 = val_22 - this.hLen;
            this.salt.CopyTo(array:  this.block, index:  val_22 + this.block.Length);
            val_19 = 0;
            goto label_32;
            label_37:
            val_23 = val_23 + 0;
            byte val_24 = this.MaskGeneratorFunction1(Z:  val_5, zOff:  0, zLen:  val_5.Length, length:  (~this.hLen) + this.block.Length)[0];
            val_19 = 1;
            val_24 = val_24 ^ ((this.sLen + 0) + 32);
            mem2[0] = val_24;
            label_32:
            if(val_19 != val_11.Length)
            {
                goto label_37;
            }
            
            int val_26 = this.block.Length;
            val_26 = val_26 << 3;
            val_26 = val_26 - this.emBits;
            val_26 = val_26 & 31;
            val_26 = 255 >> val_26;
            val_26 = val_26 & this.block[0];
            this.block[0] = val_26;
            val_5.CopyTo(array:  this.block, index:  (~this.hLen) + this.block.Length);
            if(this.block != null)
            {
                    val_20 = this.trailer;
            }
            else
            {
                    val_20 = this.trailer;
            }
            
            var val_27 = -4294967296;
            val_27 = val_27 + ((this.block.Length) << 32);
            this.block[val_27 >> 32] = val_20;
            if(this.block == null)
            {
                goto label_45;
            }
            
            if(this.cipher != null)
            {
                goto label_51;
            }
            
            label_52:
            label_51:
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_50;
            label_45:
            if(this.cipher != null)
            {
                goto label_51;
            }
            
            goto label_52;
            label_50:
            System.Byte[] val_15 = this.cipher.ProcessBlock(inBuf:  this.block, inOff:  0, inLen:  this.block.Length);
            val_15.ClearBlock(block:  this.block);
            return val_15;
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            int val_17;
            int val_18;
            var val_21;
            System.Byte[] val_22;
            var val_23;
            System.Byte[] val_24;
            System.Byte[] val_25;
            int val_26;
            System.Array val_27;
            int val_28;
            System.Array val_29;
            int val_30;
            int val_33;
            var val_34;
            val_17 = this.sLen;
            val_18 = this.mDash.Length - (val_17 + this.hLen);
            var val_15 = 0;
            val_15 = val_15 + 1;
            int val_3 = this.contentDigest1.DoFinal(output:  this.mDash, outOff:  val_18);
            if(signature == null)
            {
                goto label_7;
            }
            
            label_14:
            int val_19 = signature.Length;
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto label_12;
            label_7:
            if(this.cipher != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_12:
            System.Byte[] val_5 = this.cipher.ProcessBlock(inBuf:  signature, inOff:  0, inLen:  val_19);
            if(this.block == null)
            {
                goto label_15;
            }
            
            label_38:
            val_5.CopyTo(array:  this.block, index:  this.block.Length - val_5.Length);
            var val_17 = -4294967296;
            val_17 = val_17 + ((this.block.Length) << 32);
            val_21 = val_17 >> 32;
            if(this.block[val_21] != this.trailer)
            {
                goto label_19;
            }
            
            val_22 = this.block;
            if(this.block != null)
            {
                goto label_20;
            }
            
            val_22 = this.block;
            if(val_22 == null)
            {
                goto label_21;
            }
            
            label_20:
            val_23 = 0;
            goto label_22;
            label_27:
            val_19 = val_19 + 0;
            byte val_20 = this.MaskGeneratorFunction1(Z:  this.block, zOff:  (~this.hLen) + this.block.Length, zLen:  this.hLen, length:  (~this.hLen) + this.block.Length)[0];
            val_23 = 1;
            val_20 = val_20 ^ ((signature.Length + 0) + 32);
            mem2[0] = val_20;
            label_22:
            if(val_23 != val_9.Length)
            {
                goto label_27;
            }
            
            int val_22 = this.block.Length;
            val_22 = val_22 << 3;
            val_22 = val_22 - this.emBits;
            val_22 = val_22 & 31;
            val_22 = 255 >> val_22;
            val_22 = val_22 & this.block[0];
            this.block[0] = val_22;
            label_34:
            val_24 = this.block;
            if(this.block == null)
            {
                    val_24 = this.block;
            }
            
            val_17 = this.sLen;
            int val_23 = this.block.Length;
            int val_10 = (-2) - this.hLen;
            val_10 = val_10 - val_17;
            val_23 = val_10 + val_23;
            if(0 == val_23)
            {
                goto label_31;
            }
            
            val_18 = 0;
            val_21 = 0 + 1;
            if(val_24[val_18] == 0)
            {
                goto label_34;
            }
            
            goto label_41;
            label_19:
            val_25 = this.block;
            goto label_36;
            label_15:
            if(val_5 != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_31:
            if(val_24 == null)
            {
                    val_18 = this.hLen;
                val_17 = this.sLen;
            }
            
            int val_26 = this.block.Length;
            var val_25 = -2;
            val_25 = val_25 - val_17;
            val_25 = val_25 - val_18;
            val_26 = val_25 + val_26;
            val_21 = (long)val_26;
            if(val_24[val_21] != 1)
            {
                goto label_41;
            }
            
            if(this.sSet != false)
            {
                    val_26 = this.sLen;
                val_27 = this.salt;
                val_28 = 0;
                val_29 = this.mDash;
                val_30 = this.mDash.Length - val_26;
            }
            else
            {
                    val_18 = this.hLen;
                val_26 = this.sLen;
                if(this.mDash == null)
            {
                    val_26 = this.sLen;
            }
            
                var val_28 = ~this.sLen;
                val_28 = val_28 - val_18;
                val_28 = val_28 + this.block.Length;
                val_30 = this.mDash.Length - val_26;
                val_27 = this.block;
                val_29 = this.mDash;
            }
            
            System.Array.Copy(sourceArray:  val_27, sourceIndex:  val_28, destinationArray:  val_29, destinationIndex:  val_30, length:  val_26);
            var val_29 = 0;
            val_29 = val_29 + 1;
            this.contentDigest2.BlockUpdate(input:  this.mDash, inOff:  0, length:  this.mDash.Length);
            int val_30 = this.hLen;
            val_30 = this.mDash.Length - val_30;
            var val_31 = 0;
            val_31 = val_31 + 1;
            int val_13 = this.contentDigest2.DoFinal(output:  this.mDash, outOff:  val_30);
            val_33 = this.hLen;
            int val_14 = (~val_33) + this.block.Length;
            if(this.mDash == null)
            {
                    val_33 = this.hLen;
            }
            
            val_21 = this.mDash.Length - val_33;
            goto label_61;
            label_68:
            val_18 = this.mDash;
            if(this.block[(long)val_14] != val_18[(long)val_21])
            {
                goto label_66;
            }
            
            val_14 = val_14 + 1;
            val_21 = val_21 + 1;
            label_61:
            if(val_21 != this.mDash.Length)
            {
                goto label_68;
            }
            
            this.ClearBlock(block:  this.mDash);
            this.ClearBlock(block:  this.block);
            val_34 = 1;
            return (bool)val_34;
            label_66:
            this.ClearBlock(block:  this.mDash);
            label_41:
            val_25 = this.block;
            label_36:
            this.ClearBlock(block:  val_25);
            val_34 = 0;
            return (bool)val_34;
            label_21:
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
        private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
        {
            Org.BouncyCastle.Crypto.IDigest val_16;
            System.Array val_17;
            System.Byte[] val_18;
            int val_20;
            System.Array val_21;
            var val_25;
            int val_29;
            val_16 = length;
            byte[] val_1 = new byte[0];
            val_17 = val_1;
            byte[] val_2 = new byte[0];
            byte[] val_3 = new byte[4];
            val_18 = val_3;
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.mgfDigest.Reset();
            val_20 = this.mgfhLen;
            if((val_16 / val_20) < 1)
            {
                goto label_6;
            }
            
            label_26:
            val_21 = val_17;
            this.mgfDigest.ItoOSP(i:  0, sp:  val_3);
            var val_19 = 0;
            val_19 = val_19 + 1;
            this.mgfDigest.BlockUpdate(input:  Z, inOff:  zOff, length:  zLen);
            if(val_18 == null)
            {
                goto label_12;
            }
            
            label_19:
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_17;
            label_12:
            if(this.mgfDigest != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_17:
            this.mgfDigest.BlockUpdate(input:  val_3, inOff:  0, length:  val_3.Length);
            var val_21 = 0;
            val_21 = val_21 + 1;
            int val_9 = this.mgfDigest.DoFinal(output:  val_2, outOff:  0);
            val_17 = val_21;
            val_2.CopyTo(array:  val_1, index:  this.mgfhLen * 0);
            val_20 = this.mgfhLen;
            val_25 = 0 + 1;
            if(val_25 < (val_16 / val_20))
            {
                goto label_26;
            }
            
            goto label_27;
            label_6:
            val_25 = 0;
            label_27:
            val_20 = val_20 * val_25;
            if(val_20 >= val_16)
            {
                    return (System.Byte[])val_17;
            }
            
            this.mgfDigest.ItoOSP(i:  0, sp:  val_3);
            val_16 = this.mgfDigest;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_16.BlockUpdate(input:  Z, inOff:  zOff, length:  zLen);
            if(val_18 == null)
            {
                goto label_34;
            }
            
            if(this.mgfDigest != null)
            {
                goto label_40;
            }
            
            label_41:
            label_40:
            val_21 = val_3.Length;
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_39;
            label_34:
            if(this.mgfDigest != null)
            {
                goto label_40;
            }
            
            goto label_41;
            label_39:
            this.mgfDigest.BlockUpdate(input:  val_3, inOff:  0, length:  val_21);
            val_18 = this.mgfDigest;
            var val_24 = 0;
            val_24 = val_24 + 1;
            int val_15 = val_18.DoFinal(output:  val_2, outOff:  0);
            val_29 = this.mgfhLen;
            if(val_17 == null)
            {
                    val_29 = this.mgfhLen;
            }
            
            System.Array.Copy(sourceArray:  val_2, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  this.mgfhLen * val_25, length:  val_1.Length - (val_29 * val_25));
            return (System.Byte[])val_17;
        }
    
    }

}
