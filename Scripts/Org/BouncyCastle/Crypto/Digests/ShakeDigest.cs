using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class ShakeDigest : KeccakDigest, IXof, IDigest
    {
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        private static int CheckBitLength(int bitLength)
        {
            if(bitLength == 256)
            {
                    return (int)bitLength;
            }
            
            if(bitLength == 128)
            {
                    return (int)bitLength;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  bitLength + " not supported for SHAKE", paramName:  "bitLength");
        }
        public ShakeDigest()
        {
        
        }
        public ShakeDigest(int bitLength)
        {
            int val_1 = Org.BouncyCastle.Crypto.Digests.ShakeDigest.CheckBitLength(bitLength:  bitLength);
        }
        public ShakeDigest(Org.BouncyCastle.Crypto.Digests.ShakeDigest source)
        {
            Org.BouncyCastle.Crypto.Digests.ShakeDigest val_1 = source;
            val_1 = new Org.BouncyCastle.Crypto.Digests.KeccakDigest(source:  val_1);
        }
        public override string get_AlgorithmName()
        {
            return (string)"SHAKE" + true;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            int val_1 = this.GetDigestSize();
            goto typeof(Org.BouncyCastle.Crypto.Digests.ShakeDigest).__il2cppRuntimeField_2D8;
        }
        public virtual int DoFinal(byte[] output, int outOff, int outLen)
        {
            this.Reset();
            return (int)outLen;
        }
        public virtual int DoOutput(byte[] output, int outOff, int outLen)
        {
            if(true == 0)
            {
                    byte[] val_1 = new byte[1];
                val_1[0] = 15;
                this.Absorb(data:  val_1, off:  0, databitlen:  4);
            }
            
            this.Squeeze(output:  output, offset:  outOff, outputLength:  4);
            return (int)outLen;
        }
        protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
        {
            int val_1 = this.GetDigestSize();
            goto typeof(Org.BouncyCastle.Crypto.Digests.ShakeDigest).__il2cppRuntimeField_2F8;
        }
        protected virtual int DoFinal(byte[] output, int outOff, int outLen, byte partialByte, int partialBits)
        {
            var val_7;
            var val_8;
            int val_9;
            val_7 = partialBits;
            if(val_7 >= 8)
            {
                goto label_1;
            }
            
            int val_1 = val_7 & 31;
            var val_4 = 1;
            val_4 = val_4 << val_1;
            int val_2 = 15 << val_1;
            val_1 = val_4 + 255;
            val_1 = val_1 & partialByte;
            val_8 = val_7 + 4;
            val_1 = val_1 & 255;
            val_9 = val_1 | val_2;
            if(val_8 < 8)
            {
                goto label_2;
            }
            
            mem2[0] = val_9;
            this.Absorb(data:  0, off:  0, databitlen:  8);
            val_8 = val_7 - 4;
            if(val_8 <= 0)
            {
                goto label_5;
            }
            
            val_9 = val_2 >> 8;
            label_2:
            mem2[0] = val_9;
            this.Absorb(data:  0, off:  0, databitlen:  (long)val_8);
            label_5:
            this.Squeeze(output:  output, offset:  outOff, outputLength:  (long)val_8);
            this.Reset();
            return (int)outLen;
            label_1:
            System.ArgumentException val_3 = new System.ArgumentException(message:  "must be in the range [0,7]", paramName:  "partialBits");
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.ShakeDigest(source:  this);
        }
    
    }

}
