using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public abstract class GeneralDigest : IDigest, IMemoable
    {
        // Fields
        private const int BYTE_LENGTH = 64;
        private byte[] xBuf;
        private int xBufOff;
        private long byteCount;
        
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        internal GeneralDigest()
        {
            this.xBuf = new byte[4];
        }
        internal GeneralDigest(Org.BouncyCastle.Crypto.Digests.GeneralDigest t)
        {
            this.xBuf = new byte[0];
            this.CopyIn(t:  t);
        }
        protected void CopyIn(Org.BouncyCastle.Crypto.Digests.GeneralDigest t)
        {
            if(t == null)
            {
                goto label_0;
            }
            
            if(t.xBuf != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            System.Array.Copy(sourceArray:  t.xBuf, sourceIndex:  0, destinationArray:  this.xBuf, destinationIndex:  0, length:  t.xBuf.Length);
            if(t == null)
            {
                goto label_2;
            }
            
            this.xBufOff = t.xBufOff;
            goto label_3;
            label_0:
            if(11993091 != 0)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            this.xBufOff = 28563616;
            label_3:
            this.byteCount = t.byteCount;
        }
        public void Update(byte input)
        {
            this.xBufOff = this.xBufOff + 1;
            this.xBuf[this.xBufOff] = input;
            if(this.xBufOff == this.xBuf.Length)
            {
                    this.xBufOff = 0;
            }
            
            long val_2 = this.byteCount;
            val_2 = val_2 + 1;
            this.byteCount = val_2;
        }
        public void BlockUpdate(byte[] input, int inOff, int length)
        {
            var val_8;
            var val_9;
            System.Byte[] val_10;
            var val_11;
            val_8 = inOff;
            int val_1 = System.Math.Max(val1:  0, val2:  length);
            if(this.xBufOff == 0)
            {
                goto label_3;
            }
            
            val_9 = 0;
            val_10 = val_8;
            label_9:
            if(val_9 >= (long)val_1)
            {
                goto label_10;
            }
            
            this.xBufOff = this.xBufOff + 1;
            val_9 = val_9 + 1;
            this.xBuf[(long)this.xBufOff] = input[(long)val_10 + val_9];
            if(this.xBufOff != 4)
            {
                goto label_9;
            }
            
            this.xBufOff = 0;
            goto label_10;
            label_3:
            val_9 = 0;
            label_10:
            int val_4 = val_1 - val_9;
            val_4 = val_4 & 4294967292;
            goto label_11;
            label_12:
            int val_6 = val_8 + val_9;
            val_9 = 4;
            label_11:
            if(val_9 < (val_4 + val_9))
            {
                goto label_12;
            }
            
            if(val_9 < val_1)
            {
                    val_11 = (long)val_1;
                val_8 = val_9 + val_8;
                val_9 = val_11 - (val_9 << );
                do
            {
                val_10 = this.xBuf;
                this.xBufOff = this.xBufOff + 1;
                val_9 = val_9 - 1;
                val_8 = val_8 + 1;
                val_10[this.xBufOff] = input[(long)val_8];
            }
            while(val_9 != 0);
            
            }
            else
            {
                    val_11 = (long)val_1;
            }
            
            long val_10 = this.byteCount;
            val_10 = val_10 + val_11;
            this.byteCount = val_10;
        }
        public void Finish()
        {
            long val_1 = this.byteCount << 3;
            goto label_0;
            label_1:
            128 = 0;
            label_0:
            this.Update(input:  0);
            if(this.xBufOff != 0)
            {
                goto label_1;
            }
            
            goto typeof(Org.BouncyCastle.Crypto.Digests.GeneralDigest).__il2cppRuntimeField_228;
        }
        public virtual void Reset()
        {
            this.byteCount = 0;
            this.xBufOff = 0;
            System.Array.Clear(array:  this.xBuf, index:  0, length:  this.xBuf.Length);
        }
        public int GetByteLength()
        {
            return 64;
        }
        internal abstract void ProcessWord(byte[] input, int inOff); // 0
        internal abstract void ProcessLength(long bitLength); // 0
        internal abstract void ProcessBlock(); // 0
        public abstract string get_AlgorithmName(); // 0
        public abstract int GetDigestSize(); // 0
        public abstract int DoFinal(byte[] output, int outOff); // 0
        public abstract Org.BouncyCastle.Utilities.IMemoable Copy(); // 0
        public abstract void Reset(Org.BouncyCastle.Utilities.IMemoable t); // 0
    
    }

}
