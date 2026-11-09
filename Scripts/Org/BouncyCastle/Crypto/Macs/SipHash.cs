using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class SipHash : IMac
    {
        // Fields
        protected readonly int c;
        protected readonly int d;
        protected long k0;
        protected long k1;
        protected long v0;
        protected long v1;
        protected long v2;
        protected long v3;
        protected long m;
        protected int wordPos;
        protected int wordCount;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public SipHash()
        {
            this.c = 6;
            this.d = 4;
        }
        public SipHash(int c, int d)
        {
            this.c = c;
            this.d = d;
        }
        public virtual string get_AlgorithmName()
        {
            object[] val_1 = new object[4];
            val_1[0] = "SipHash-";
            val_1[1] = this.c;
            val_1[2] = "-";
            val_1[3] = this.d;
            return (string)+val_1;
        }
        public virtual int GetMacSize()
        {
            return 8;
        }
        public virtual void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            string val_6;
            if(parameters == null)
            {
                goto label_3;
            }
            
            System.Byte[] val_1 = parameters.GetKey();
            if(val_1.Length != 16)
            {
                goto label_5;
            }
            
            this.k0 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(bs:  val_1, off:  0);
            this.k1 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(bs:  val_1, off:  8);
            goto typeof(Org.BouncyCastle.Crypto.Macs.SipHash).__il2cppRuntimeField_248;
            label_3:
            val_6 = "must be an instance of KeyParameter";
            goto label_6;
            label_5:
            val_6 = "must be a 128-bit key";
            label_6:
            null = new System.ArgumentException(message:  val_6, paramName:  "parameters");
        }
        public virtual void Update(byte input)
        {
            int val_1 = this.wordPos;
            val_1 = val_1 + 1;
            this.m = this.m;
            this.wordPos = val_1;
            if(val_1 != 8)
            {
                    return;
            }
            
            this.wordPos = 0;
        }
        public virtual void BlockUpdate(byte[] input, int offset, int length)
        {
            var val_12;
            long val_13;
            var val_14;
            int val_12 = this.wordPos;
            val_12 = length;
            int val_1 = val_12 & 4294967288;
            int val_16 = offset;
            if(val_12 == 0)
            {
                goto label_0;
            }
            
            if(val_1 < 1)
            {
                goto label_1;
            }
            
            val_12 = val_12 << 3;
            do
            {
                long val_13 = this.m;
                val_13 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(bs:  input, off:  val_16 + 0);
                val_13 = val_13 >> ((-val_12) & 56);
                val_13 = val_13 | (val_13 << (val_12 & 56));
                this.m = val_13;
                val_14 = 0 + 8;
                this.m = val_13;
            }
            while(val_14 < val_1);
            
            goto label_3;
            label_0:
            if(val_1 < 1)
            {
                goto label_4;
            }
            
            do
            {
                this.m = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(bs:  input, off:  val_16 + 0);
                val_14 = 0 + 8;
            }
            while(val_14 < val_1);
            
            goto label_6;
            label_1:
            val_14 = 0;
            label_3:
            if(val_14 >= val_12)
            {
                    return;
            }
            
            int val_9 = val_14 + val_16;
            var val_10 = (long)val_12 - (val_14 << );
            do
            {
                val_13 = this.m;
                int val_15 = this.wordPos;
                val_15 = val_15 + 1;
                this.m = input[(long)val_9];
                this.wordPos = val_15;
                if(val_15 == 8)
            {
                    this.wordPos = 0;
            }
            
                val_10 = val_10 - 1;
                val_12 = val_9 + 1;
            }
            while(val_10 != 0);
            
            return;
            label_4:
            val_14 = 0;
            label_6:
            if(val_14 < val_12)
            {
                    val_16 = val_14 + val_16;
                val_14 = (long)val_12 - (val_14 << );
                do
            {
                byte val_17 = input[(long)val_16];
                val_14 = val_14 - 1;
                val_16 = val_16 + 1;
                this.m = this.m;
            }
            while(val_14 != 0);
            
            }
            
            this.wordPos = val_12 - val_1;
        }
        public virtual long DoFinal()
        {
            int val_4 = this.wordPos;
            long val_5 = this.m;
            var val_3 = 7;
            val_3 = val_3 - val_4;
            val_4 = val_4 + (this.wordCount << 3);
            val_5 = val_5 >> this.wordCount;
            this.m = val_5;
            long val_6 = this.v2;
            val_6 = val_6 ^ 255;
            this.v2 = val_6;
            long val_1 = this.v1 ^ this.v0;
            val_1 = val_1 ^ this.v2;
            return (long)val_1 ^ this.v3;
        }
        public virtual int DoFinal(byte[] output, int outOff)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(n:  this, bs:  output, off:  outOff);
            return 8;
        }
        public virtual void Reset()
        {
            long val_3 = this.k0;
            long val_4 = this.k1;
            val_3 = val_3 ^ 7816392313619706465;
            val_4 = val_4 ^ 8387220255154660723;
            this.v0 = val_3 ^ 8317987319222330741;
            this.v1 = val_4 ^ 7237128888997146477;
            this.v2 = val_3;
            this.v3 = val_4;
            this.m = 0;
            this.wordPos = 0;
            this.wordCount = 0;
        }
        protected virtual void ProcessMessageWord()
        {
            int val_1 = this.wordCount;
            long val_2 = this.v3;
            val_1 = val_1 + 1;
            val_2 = this.m ^ val_2;
            this.wordCount = val_1;
            this.v3 = val_2;
            long val_3 = this.v0;
            val_3 = this.m ^ val_3;
            this.v0 = val_3;
        }
        protected virtual void ApplySipRounds(int n)
        {
            long val_1;
            long val_2;
            long val_3;
            long val_4;
            val_1 = this.v0;
            val_2 = this.v1;
            val_3 = this.v2;
            val_4 = this.v3;
            if(n >= 1)
            {
                    do
            {
                val_1 = val_1 + val_2;
                val_3 = val_3 + val_4;
                val_2 = val_1 ^ (((this.v1) << (64-51)) | ((this.v1) << 51));
                val_4 = val_3 ^ (((this.v3) << (64-48)) | ((this.v3) << 48));
                val_1 = val_1 >> 32;
                val_3 = val_2 + val_3;
                val_1 = val_1 + val_4;
                n = n - 1;
                val_2 = val_3 ^ (((((this.v0 + this.v1) ^ ((this.v1) << (64-51)) | ((this.v1) << 51))) << (64-47)) | ((((this.v0 + this.v1) ^ ((this.v1) << (64-51)) | ((this.v1) << 51))) << 47));
                val_4 = val_1 ^ (((((this.v2 + this.v3) ^ ((this.v3) << (64-48)) | ((this.v3) << 48))) << (64-43)) | ((((this.v2 + this.v3) ^ ((this.v3) << (64-48)) | ((this.v3) << 48))) << 43));
                val_3 = val_3 >> 32;
            }
            while(n != 0);
            
            }
            
            this.v0 = val_1;
            this.v1 = val_2;
            this.v2 = val_3;
            this.v3 = val_4;
        }
        protected static long RotateLeft(long x, int n)
        {
            var val_1 = -n;
            val_1 = val_1 & 63;
            x = x >> val_1;
            return (long)x;
        }
    
    }

}
