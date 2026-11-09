using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class Sha3Digest : KeccakDigest
    {
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        private static int CheckBitLength(int bitLength)
        {
            if(bitLength <= 256)
            {
                    if(bitLength == 224)
            {
                    return (int)bitLength;
            }
            
                if(bitLength == 256)
            {
                    return (int)bitLength;
            }
            
            }
            else
            {
                    if(bitLength == 512)
            {
                    return (int)bitLength;
            }
            
                if(bitLength == 384)
            {
                    return (int)bitLength;
            }
            
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  bitLength + " not supported for SHA-3"(" not supported for SHA-3"), paramName:  "bitLength");
        }
        public Sha3Digest()
        {
        
        }
        public Sha3Digest(int bitLength)
        {
            int val_1 = Org.BouncyCastle.Crypto.Digests.Sha3Digest.CheckBitLength(bitLength:  bitLength);
        }
        public Sha3Digest(Org.BouncyCastle.Crypto.Digests.Sha3Digest source)
        {
            Org.BouncyCastle.Crypto.Digests.Sha3Digest val_1 = source;
            val_1 = new Org.BouncyCastle.Crypto.Digests.KeccakDigest(source:  val_1);
        }
        public override string get_AlgorithmName()
        {
            return (string)"SHA3-"("SHA3-") + true;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            byte[] val_1 = new byte[1];
            val_1[0] = 2;
            this.Absorb(data:  val_1, off:  0, databitlen:  2);
            return this.DoFinal(output:  output, outOff:  outOff);
        }
        protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
        {
            int val_6;
            int val_7;
            if(partialBits < 8)
            {
                    int val_1 = partialBits & 31;
                var val_4 = 1;
                val_4 = val_4 << val_1;
                int val_2 = 2 << val_1;
                val_1 = val_4 + 255;
                val_1 = val_1 & partialByte;
                val_6 = partialBits + 2;
                val_1 = val_1 & 255;
                val_7 = val_1 | val_2;
                if(val_6 < 8)
            {
                    return this.DoFinal(output:  output, outOff:  outOff, partialByte:  val_7 = val_2 >> 8, partialBits:  val_6 = partialBits - 6);
            }
            
                mem2[0] = val_7;
                this.Absorb(data:  0, off:  0, databitlen:  8);
                return this.DoFinal(output:  output, outOff:  outOff, partialByte:  val_7, partialBits:  val_6);
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "must be in the range [0,7]", paramName:  "partialBits");
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.Sha3Digest(source:  this);
        }
    
    }

}
