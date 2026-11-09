using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class X931Signer : ISigner
    {
        // Fields
        public const int TRAILER_IMPLICIT = 188;
        public const int TRAILER_RIPEMD160 = 12748;
        public const int TRAILER_RIPEMD128 = 13004;
        public const int TRAILER_SHA1 = 13260;
        public const int TRAILER_SHA256 = 13516;
        public const int TRAILER_SHA512 = 13772;
        public const int TRAILER_SHA384 = 14028;
        public const int TRAILER_WHIRLPOOL = 14284;
        public const int TRAILER_SHA224 = 14540;
        private Org.BouncyCastle.Crypto.IDigest digest;
        private Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;
        private Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam;
        private int trailer;
        private int keyBits;
        private byte[] block;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public X931Signer(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest, bool isImplicit)
        {
            var val_4;
            Org.BouncyCastle.Crypto.IDigest val_5;
            val_4 = isImplicit;
            this.digest = digest;
            this.cipher = cipher;
            if(val_4 == false)
            {
                goto label_1;
            }
            
            val_5 = 188;
            goto label_2;
            label_1:
            val_4 = 1152921505530593280;
            if((Org.BouncyCastle.Crypto.Signers.IsoTrailers.NoTrailerAvailable(digest:  digest)) == true)
            {
                goto label_5;
            }
            
            val_5 = digest;
            label_2:
            this.trailer = Org.BouncyCastle.Crypto.Signers.IsoTrailers.GetTrailer(digest:  val_5);
            return;
            label_5:
            System.ArgumentException val_3 = new System.ArgumentException(message:  "no valid trailer", paramName:  "digest");
        }
        public virtual string get_AlgorithmName()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            return this.digest.AlgorithmName + "with" + this.cipher.AlgorithmName + "/X9.31"("/X9.31");
        }
        public X931Signer(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest)
        {
        
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_11 = parameters;
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            this.kParam = val_11;
            var val_11 = 0;
            val_11 = val_11 + 1;
            this.cipher.Init(forEncryption:  forSigning, parameters:  val_11);
            int val_5 = this.kParam.modulus.BitLength;
            this.keyBits = val_5;
            int val_6 = val_5 + 7;
            var val_9 = ((val_6 < 0) ? (val_5 + 14) : (val_6)) >> 3;
            this.block = new byte[0];
        }
        private void ClearBlock(byte[] block)
        {
            System.Array.Clear(array:  block, index:  0, length:  block.Length);
        }
        public virtual void Update(byte b)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Update(input:  b);
        }
        public virtual void BlockUpdate(byte[] input, int off, int len)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.BlockUpdate(input:  input, inOff:  off, length:  len);
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Reset();
        }
        public virtual byte[] GenerateSignature()
        {
            this.CreateSignatureBlock();
            if(this.block == null)
            {
                goto label_1;
            }
            
            if(this.cipher != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_6;
            label_1:
            if(this.cipher != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  this.cipher.ProcessBlock(inBuf:  this.block, inOff:  0, inLen:  this.block.Length));
            val_3.ClearBlock(block:  this.block);
            int val_6 = this.kParam.modulus.BitLength;
            int val_7 = val_6 + 7;
            val_6 = ((val_7 < 0) ? (val_6 + 14) : (val_7)) >> 3;
            return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  val_6, n:  val_3.Min(value:  this.kParam.modulus.Subtract(n:  val_3)));
        }
        private void CreateSignatureBlock()
        {
            int val_11;
            int val_15;
            int val_16;
            var val_17;
            var val_12 = 0;
            val_12 = val_12 + 1;
            int val_13 = this.block.Length;
            val_13 = val_13 - this.digest.GetDigestSize();
            if(this.trailer != 188)
            {
                goto label_7;
            }
            
            val_11 = val_13 - 1;
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_12;
            label_7:
            val_11 = val_13 - 2;
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_17;
            label_12:
            int val_4 = this.digest.DoFinal(output:  this.block, outOff:  val_11);
            var val_16 = -4294967296;
            val_16 = val_16 + ((this.block.Length) << 32);
            val_15 = 188;
            goto label_20;
            label_17:
            int val_7 = this.digest.DoFinal(output:  this.block, outOff:  val_11);
            if(this.block != null)
            {
                    val_16 = this.trailer;
            }
            else
            {
                    val_16 = this.trailer;
            }
            
            var val_17 = -8589934592;
            val_17 = val_17 + ((this.block.Length) << 32);
            this.block[val_17 >> 32] = val_16 >> 8;
            if(this.block != null)
            {
                    val_15 = this.trailer;
            }
            else
            {
                    val_15 = this.trailer;
            }
            
            var val_18 = -4294967296;
            val_18 = val_18 + ((this.block.Length) << 32);
            label_20:
            mem2[0] = val_15;
            val_17 = val_11 - 2;
            this.block[0] = 107;
            goto label_29;
            label_32:
            val_17 = val_17 - 1;
            this.block[(long)val_17] = 187;
            label_29:
            if(val_17 != 0)
            {
                goto label_32;
            }
            
            this.block[(long)val_11 - 1] = 186;
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            bool val_10;
            Org.BouncyCastle.Math.BigInteger val_12;
            Org.BouncyCastle.Math.BigInteger val_13;
            bool val_14;
            val_10 = this;
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Byte[] val_2 = this.cipher.ProcessBlock(inBuf:  signature, inOff:  0, inLen:  signature.Length);
            this.block = val_2;
            Org.BouncyCastle.Math.BigInteger val_3 = null;
            val_12 = val_3;
            val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_2);
            if((val_3.IntValue & 15) == 12)
            {
                goto label_8;
            }
            
            val_13 = this.kParam.modulus;
            val_12 = val_13.Subtract(n:  val_3);
            if((val_12.IntValue & 15) != 12)
            {
                goto label_12;
            }
            
            label_8:
            this.CreateSignatureBlock();
            val_13 = this.block;
            System.Byte[] val_9 = Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  this.block.Length, n:  val_12);
            bool val_10 = Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  this.block, b:  val_9);
            val_10 = val_10;
            val_10.ClearBlock(block:  this.block);
            val_10.ClearBlock(block:  val_9);
            val_14 = val_10;
            return (bool)val_14;
            label_12:
            val_14 = 0;
            return (bool)val_14;
        }
    
    }

}
