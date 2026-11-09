using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class Sha512tDigest : LongDigest
    {
        // Fields
        private const ulong A5 = 11936128518282651045;
        private readonly int digestLength;
        private ulong H1t;
        private ulong H2t;
        private ulong H3t;
        private ulong H4t;
        private ulong H5t;
        private ulong H6t;
        private ulong H7t;
        private ulong H8t;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public Sha512tDigest(int bitLength)
        {
            string val_8;
            if(bitLength >= 512)
            {
                goto label_3;
            }
            
            if((bitLength & 7) != 0)
            {
                goto label_4;
            }
            
            if(bitLength == 384)
            {
                goto label_5;
            }
            
            var val_3 = (bitLength < 0) ? (bitLength + 7) : bitLength;
            this.digestLength = val_3 >> 3;
            this.tIvGenerate(bitLength:  val_3 & 4294967288);
            goto typeof(Org.BouncyCastle.Crypto.Digests.Sha512tDigest).__il2cppRuntimeField_1F8;
            label_3:
            val_8 = "cannot be >= 512";
            goto label_9;
            label_4:
            val_8 = "needs to be a multiple of 8";
            goto label_9;
            label_5:
            val_8 = "cannot be 384 use SHA384 instead";
            label_9:
            null = new System.ArgumentException(message:  val_8, paramName:  "bitLength");
        }
        public Sha512tDigest(Org.BouncyCastle.Crypto.Digests.Sha512tDigest t)
        {
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest val_1 = t;
            val_1 = new Org.BouncyCastle.Crypto.Digests.LongDigest(t:  val_1);
            this.digestLength = t.digestLength;
            goto typeof(Org.BouncyCastle.Crypto.Digests.Sha512tDigest).__il2cppRuntimeField_248;
        }
        public override string get_AlgorithmName()
        {
            int val_2 = this.digestLength;
            val_2 = val_2 << 3;
            return (string)"SHA-512/"("SHA-512/") + val_2;
        }
        public override int GetDigestSize()
        {
            return (int)this.digestLength;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            this.Finish();
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff, max:  this.digestLength);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 8, max:  this.digestLength - 8);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 16, max:  this.digestLength - 16);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 24, max:  this.digestLength - 24);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 32, max:  this.digestLength - 32);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 40, max:  this.digestLength - 40);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 48, max:  this.digestLength - 48);
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 56, max:  this.digestLength - 56);
            return (int)this.digestLength;
        }
        public override void Reset()
        {
            this.Reset();
            mem[1152921553368058392] = this.H1t;
            mem[1152921553368058408] = this.H3t;
            mem[1152921553368058416] = this.H4t;
            mem[1152921553368058424] = this.H5t;
            mem[1152921553368058432] = this.H6t;
            mem[1152921553368058440] = this.H7t;
            mem[1152921553368058448] = this.H8t;
        }
        private void tIvGenerate(int bitLength)
        {
            var val_2;
            var val_3;
            var val_4;
            byte val_5;
            val_2 = bitLength;
            mem[1152921553368170392] = ;
            mem[1152921553368170408] = ;
            mem[1152921553368170424] = ;
            mem[1152921553368170440] = ;
            this.Update(input:  83);
            this.Update(input:  72);
            this.Update(input:  65);
            this.Update(input:  45);
            this.Update(input:  53);
            this.Update(input:  49);
            this.Update(input:  50);
            this.Update(input:  47);
            if(val_2 < 101)
            {
                goto label_0;
            }
            
            this.Update(input:  48);
            val_2 = 0;
            val_3 = 0;
            val_4 = 48;
            goto label_1;
            label_0:
            if(val_2 < 11)
            {
                goto label_2;
            }
            
            val_3 = 0;
            val_4 = 48;
            label_1:
            this.Update(input:  48);
            val_5 = (val_2 - (val_3 * 10)) | 48;
            goto label_3;
            label_2:
            val_5 = val_2 + 48;
            label_3:
            this.Update(input:  val_5);
            this.Finish();
            this.H1t = ;
            this.H2t = 2216346199247487646;
            this.H3t = -29977092;
            this.H4t = -29977092;
            this.H5t = -29977092;
            this.H6t = -29977092;
            this.H7t = ;
            this.H8t = ;
        }
        private static void UInt64_To_BE(ulong n, byte[] bs, int off, int max)
        {
            if(max < 1)
            {
                    return;
            }
            
            n = n >> 32;
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt32_To_BE(n:  n, bs:  bs, off:  off, max:  max);
            if(max < 5)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt32_To_BE(n:  n, bs:  bs, off:  off + 4, max:  max - 4);
        }
        private static void UInt32_To_BE(uint n, byte[] bs, int off, int max)
        {
            var val_5;
            int val_5 = max;
            int val_1 = System.Math.Min(val1:  4, val2:  val_5);
            val_5 = val_1 - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_5 = val_5 - 1;
                val_5 = (-(val_1 << 3)) + 8;
                bs[(long)off + val_5] = n >> ((-(val_1 << 3)) & 24);
            }
            while((val_5 & 2147483648) == 0);
        
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.Sha512tDigest(t:  this);
        }
        public override void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            if(other != null)
            {
                    this.CopyIn(t:  other);
                this.H1t = this.digestLength;
                this.H2t = this.digestLength;
                this.H3t = this.digestLength;
                this.H4t = this.digestLength;
                this.H5t = this.digestLength;
                this.H6t = this.digestLength;
                this.H7t = this.digestLength;
                this.H8t = this.digestLength;
                return;
            }
            
            Org.BouncyCastle.Utilities.MemoableResetException val_3 = new Org.BouncyCastle.Utilities.MemoableResetException(msg:  "digestLength inappropriate in other");
        }
    
    }

}
