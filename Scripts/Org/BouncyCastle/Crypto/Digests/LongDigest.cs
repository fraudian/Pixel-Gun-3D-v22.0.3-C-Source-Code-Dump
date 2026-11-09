using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public abstract class LongDigest : IDigest, IMemoable
    {
        // Fields
        private int MyByteLength;
        private byte[] xBuf;
        private int xBufOff;
        private long byteCount1;
        private long byteCount2;
        internal ulong H1;
        internal ulong H2;
        internal ulong H3;
        internal ulong H4;
        internal ulong H5;
        internal ulong H6;
        internal ulong H7;
        internal ulong H8;
        private ulong[] W;
        private int wOff;
        internal static readonly ulong[] K;
        
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        internal LongDigest()
        {
            this.MyByteLength = 128;
            this.W = new ulong[80];
            this.xBuf = new byte[8];
            goto typeof(Org.BouncyCastle.Crypto.Digests.LongDigest).__il2cppRuntimeField_1F8;
        }
        internal LongDigest(Org.BouncyCastle.Crypto.Digests.LongDigest t)
        {
            this.MyByteLength = 128;
            this.W = new ulong[80];
            this.xBuf = new byte[0];
            this.CopyIn(t:  t);
        }
        protected void CopyIn(Org.BouncyCastle.Crypto.Digests.LongDigest t)
        {
            if(t == null)
            {
                goto label_0;
            }
            
            if(t.xBuf != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            System.Array.Copy(sourceArray:  t.xBuf, sourceIndex:  0, destinationArray:  this.xBuf, destinationIndex:  0, length:  t.xBuf.Length);
            if(t == null)
            {
                goto label_2;
            }
            
            this.xBufOff = t.xBufOff;
            this.byteCount1 = t.byteCount1;
            this.byteCount2 = t.byteCount2;
            this.H1 = t.H1;
            this.H2 = t.H2;
            this.H3 = t.H3;
            this.H4 = t.H4;
            this.H5 = t.H5;
            this.H6 = t.H6;
            this.H7 = t.H7;
            this.H8 = t.H8;
            if(t.W != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            System.Array.Copy(sourceArray:  t.W, sourceIndex:  0, destinationArray:  this.W, destinationIndex:  0, length:  t.W.Length);
            this.wOff = t.wOff;
            return;
            label_0:
            if(28563616 != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_2:
            this.xBufOff = 64;
            this.byteCount1 = 135970152;
            this.byteCount2 = 15762873573703680;
            this.H1 = 7599944634466311;
            this.H2 = 21474836481;
            this.H3 = 0;
            this.H4 = 0;
            this.H5 = 0;
            this.H6 = 123372880;
            this.H7 = 123372880;
            this.H8 = 65536;
            if(1 != 0)
            {
                goto label_7;
            }
            
            goto label_8;
        }
        public void Update(byte input)
        {
            this.xBufOff = this.xBufOff + 1;
            this.xBuf[this.xBufOff] = input;
            if(this.xBufOff == this.xBuf.Length)
            {
                    this.ProcessWord(input:  this.xBuf, inOff:  0);
                this.xBufOff = 0;
            }
            
            long val_2 = this.byteCount1;
            val_2 = val_2 + 1;
            this.byteCount1 = val_2;
        }
        public void BlockUpdate(byte[] input, int inOff, int length)
        {
            int val_4;
            var val_5;
            System.Byte[] val_6;
            System.Byte[] val_7;
            val_4 = inOff;
            if((length < 1) || (this.xBufOff == 0))
            {
                goto label_1;
            }
            
            label_5:
            this.Update(input:  input[(long)val_4]);
            val_4 = val_4 + 1;
            val_5 = length - 1;
            if(length < 2)
            {
                goto label_7;
            }
            
            if(this.xBufOff != 0)
            {
                goto label_5;
            }
            
            goto label_7;
            label_1:
            val_5 = length;
            goto label_7;
            label_14:
            this.ProcessWord(input:  input, inOff:  val_4);
            val_6 = this.xBuf;
            if(val_6 == null)
            {
                goto label_8;
            }
            
            val_7 = val_6;
            val_4 = val_4 + this.xBuf.Length;
            goto label_11;
            label_8:
            val_7 = this.xBuf;
            val_4 = val_4 + this.xBuf.Length;
            if(val_7 == null)
            {
                goto label_10;
            }
            
            val_6 = val_7;
            goto label_11;
            label_10:
            val_6 = this.xBuf;
            if(val_6 == null)
            {
                goto label_12;
            }
            
            label_11:
            val_5 = val_5 - this.xBuf.Length;
            this.byteCount1 = this.xBuf.Length + this.byteCount1;
            label_7:
            if(val_5 > this.xBuf.Length)
            {
                goto label_14;
            }
            
            if(val_5 < 1)
            {
                    return;
            }
            
            int val_2 = val_5 + 1;
            do
            {
                val_5 = (long)val_4;
                this.Update(input:  input[val_5]);
                val_2 = val_2 - 1;
                val_4 = val_4 + 1;
            }
            while(val_2 > 1);
            
            return;
            label_12:
        }
        public void Finish()
        {
            long val_2;
            long val_3;
            var val_4;
            val_2 = this.byteCount1;
            val_3 = this.byteCount2;
            if(val_2 >= 2305843009213693952)
            {
                    val_3 = val_3 + (val_2 >> 61);
                val_2 = val_2 & 2305843009213693951;
                this.byteCount1 = val_2;
                this.byteCount2 = val_3;
            }
            
            val_4 = 128;
            goto label_1;
            label_2:
            val_4 = 0;
            label_1:
            this.Update(input:  0);
            if(this.xBufOff != 0)
            {
                goto label_2;
            }
            
            this.ProcessLength(lowW:  val_2 << 3, hiW:  val_3);
            this.ProcessBlock();
        }
        public virtual void Reset()
        {
            this.xBufOff = 0;
            this.byteCount1 = 0;
            this.byteCount2 = 0;
            goto label_0;
            label_4:
            0 = 1;
            this.xBuf[0] = 0;
            label_0:
            if(0 < this.xBuf.Length)
            {
                goto label_4;
            }
            
            this.wOff = 0;
            System.Array.Clear(array:  this.W, index:  0, length:  this.W.Length);
        }
        internal void ProcessWord(byte[] input, int inOff)
        {
            this.W[this.wOff] = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(bs:  input, off:  inOff);
            int val_2 = this.wOff;
            val_2 = val_2 + 1;
            this.wOff = val_2;
            if(val_2 != 16)
            {
                    return;
            }
            
            this.ProcessBlock();
        }
        private void AdjustByteCounts()
        {
            long val_2 = this.byteCount1;
            if(val_2 < 2305843009213693952)
            {
                    return;
            }
            
            val_2 = this.byteCount2 + (val_2 >> 61);
            this.byteCount1 = val_2 & 2305843009213693951;
            this.byteCount2 = val_2;
        }
        internal void ProcessLength(long lowW, long hiW)
        {
            if(this.wOff >= 15)
            {
                    this.ProcessBlock();
            }
            
            this.W[14] = hiW;
            this.W[15] = lowW;
        }
        internal void ProcessBlock()
        {
            var val_127;
            ulong val_128;
            var val_129;
            ulong val_130;
            ulong val_131;
            var val_132;
            var val_133;
            var val_134;
            long val_136 = this.byteCount1;
            if(val_136 >= 2305843009213693952)
            {
                    val_136 = this.byteCount2 + (val_136 >> 61);
                this.byteCount1 = val_136 & 2305843009213693951;
                this.byteCount2 = val_136;
            }
            
            var val_141 = 0;
            do
            {
                var val_2 = val_141 + 14;
                ulong val_137 = this.W[val_141];
                var val_3 = val_141 + 9;
                ulong val_138 = this.W[val_141];
                var val_4 = val_141 + 1;
                ulong val_139 = this.W[val_141];
                this.W[val_141] = val_139 >> 8;
                var val_8 = val_141 + 16;
                val_137 = ((val_137 >> 61) ^ (val_137 >> 6)) ^ (((this.W[0x0][14]) << (64-19)) | ((this.W[0x0][14]) << 19));
                val_139 = (this.W[val_141] ^ (val_139 >> 7)) ^ (((this.W[0x0][1]) << (64-1)) | ((this.W[0x0][1]) << 1));
                ulong val_9 = val_138 + val_137;
                val_9 = val_9 + val_139;
                val_138 = val_9 + this.W[val_141];
                val_141 = val_141 + 1;
                this.W[val_141] = val_138;
            }
            while(val_141 != 64);
            
            ulong val_142 = this.H5;
            do
            {
                val_127 = null;
                val_127 = null;
                System.UInt64[] val_145 = this.W;
                ulong val_13 = this.H7 & (~val_142);
                val_142 = ((val_142 >> 14) ^ (((this.H5) << (64-18)) | ((this.H5) << 18))) ^ (((this.H5) << (64-41)) | ((this.H5) << 41));
                val_13 = val_13 ^ (val_142 & this.H6);
                ulong val_144 = this.H8;
                val_144 = val_13 + val_144;
                val_144 = val_144 + val_142;
                val_144 = val_144 + (Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 32);
                val_145 = val_144 + val_145[0];
                ulong val_146 = this.H1;
                ulong val_14 = val_145 + this.H4;
                val_146 = ((val_146 >> 28) ^ (((this.H1) << (64-34)) | ((this.H1) << 34))) ^ (((this.H1) << (64-39)) | ((this.H1) << 39));
                var val_20 = 0 + 1;
                val_128 = val_14;
                if(val_20 >= Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length)
            {
                    val_128 = val_128;
            }
            
                ulong val_23 = (val_14 >> 14) ^ ((((((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org.BouncyCastle.Crypt) << (64-18)) | (((((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org.BouncyCastle.Crypt) << 18));
                val_146 = val_146 + ((this.H2 ^ this.H3 & val_146) ^ (this.H2 & this.H3));
                System.UInt64[] val_149 = this.W;
                if(val_149 == null)
            {
                    val_128 = val_128;
            }
            
                ulong val_26 = val_146 + val_145;
                val_145 = val_23 ^ ((((((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org.BouncyCastle.Crypt) << (64-41)) | (((((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org.BouncyCastle.Crypt) << 41));
                ulong val_148 = this.H7;
                val_148 = ((this.H6 & (~val_128)) ^ (val_128 & val_142)) + val_148;
                val_148 = val_148 + val_145;
                val_148 = val_148 + (Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 40);
                val_145 = val_148 + val_149[0];
                val_23 = val_145 + this.H3;
                ulong val_32 = this.H1 & this.H2;
                val_20 = val_20 + 1;
                val_32 = (val_26 & this.H1 ^ this.H2) ^ val_32;
                val_32 = (((val_26 >> 28) ^ ((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this.H5))) << (64-34)) | (((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this.H5))) << 34))) ^ ((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this.H5))) << (64-39)) | (((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this.H5))) << 39))) + val_32;
                val_129 = mem[Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 48];
                val_129 = Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 48;
                ulong val_36 = val_23 & val_128;
                val_149 = val_142 & (~val_23);
                if(this.W == null)
            {
                    val_129 = val_129;
            }
            
                ulong val_37 = val_32 + val_145;
                val_145 = ((val_23 >> 14) ^ ((((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org) << (64-18)) | (((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org) << 18))) ^ ((((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org) << (64-41)) | (((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) + Org) << 41));
                val_36 = val_149 ^ val_36;
                if(val_20 >= this.W.Length)
            {
                    val_129 = val_129;
            }
            
                ulong val_151 = this.H6;
                val_151 = val_36 + val_151;
                val_151 = val_151 + val_145;
                val_151 = val_151 + val_129;
                val_145 = val_151 + this.W[0];
                val_149 = val_145 + this.H2;
                ulong val_42 = val_26 & this.H1;
                ulong val_152 = val_23;
                val_20 = val_20 + 1;
                val_42 = (val_37 & val_26 ^ this.H1) ^ val_42;
                ulong val_44 = val_149 >> 14;
                val_44 = val_44 ^ ((((((((((this.H5 & (~(((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this) << (64-18)) | (((((((((this.H5 & (~(((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this) << 18));
                val_152 = val_149 & val_152;
                val_130 = mem[Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 56];
                val_130 = Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 56;
                if(this.W == null)
            {
                    val_130 = val_130;
            }
            
                ulong val_47 = ((val_37 >> 28) ^ (((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this) << (64-34)) | ((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this) << 34))) ^ (((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this) << (64-39)) | ((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & (~this) << 39));
                val_44 = val_44 ^ ((((((((((this.H5 & (~(((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this) << (64-41)) | (((((((((this.H5 & (~(((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this) << 41));
                if(val_20 >= this.W.Length)
            {
                    ulong val_155 = val_130;
                val_130 = val_155;
            }
            
                ulong val_154 = val_142;
                ulong val_153 = this.W[0];
                val_154 = ((val_128 & (~val_149)) ^ val_152) + val_154;
                val_154 = val_154 + val_44;
                val_154 = val_154 + val_130;
                val_155 = val_154;
                val_145 = val_155;
                ulong val_53 = val_37 & val_26;
                val_20 = val_20 + 1;
                ulong val_55 = val_47 & val_37 ^ val_26;
                ulong val_59 = val_145;
                ulong val_61 = ((val_47 >> 28) ^ ((((((((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & () << (64-34)) | (((((((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & () << 34))) ^ ((((((((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & () << (64-39)) | (((((((((((((((((this.H1 >> 28) ^ ((this.H1) << (64-34)) | ((this.H1) << 34)) ^ ((this.H1) << (64-39)) | ((this.H1) << 39)) + (((this.H2 ^ this.H3) & this.H1) ^ (this.H2 & this.H3))) + ((((((this.H7 & () << 39));
                val_155 = val_145 >> 14;
                ulong val_157 = val_128;
                val_157 = val_23 + val_157;
                ulong val_63 = val_157;
                val_63 = val_63 + 1;
                ulong val_64 = val_63 + this.W[0];
                ulong val_65 = val_64 + val_26;
                ulong val_68 = val_47 ^ val_37;
                ulong val_70 = val_47 & val_37;
                val_20 = val_20 + 1;
                ulong val_72 = val_61;
                ulong val_76 = val_65;
                val_131 = 0;
                if(this.W == null)
            {
                    val_131 = val_131;
            }
            
                ulong val_78 = val_61 >> 28;
                val_64 = ((val_65 >> 14) ^ (((((((((((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) << (64-18)) | ((((((((((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) << 18))) ^ (((((((((((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) << (64-41)) | ((((((((((((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) | ((this.H5) << 41))) << 41));
                if(val_20 >= this.W.Length)
            {
                    ulong val_160 = val_131;
                val_131 = val_160;
            }
            
                ulong val_159 = val_23;
                val_159 = val_149 + val_159;
                ulong val_80 = val_159;
                val_80 = val_80 + val_131;
                ulong val_81 = val_80 + this.W[0];
                val_160 = val_81;
                ulong val_84 = val_61;
                ulong val_86 = val_61;
                ulong val_89 = val_78;
                ulong val_93 = val_160;
                ulong val_95 = val_78 >> 28;
                val_81 = (val_160 >> 14) ^ (((((((((((((((((this.H5 & (~(((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) |) << (64-18)) | ((((((((((((((((this.H5 & (~(((((((this.H6 & (~(((((((this.H7 & (~this.H5)) ^ (this.H5 & this.H6)) + this.H8) + (((this.H5 >> 14) ^ ((this.H5) << (64-18)) | ((this.H5) << 18)) ^ ((this.H5) << (64-41)) |) << 18));
                ulong val_161 = this.W[0];
                ulong val_101 = val_145;
                ulong val_104 = val_78;
                ulong val_106 = val_78;
                var val_108 = (val_20 + 1) + 1;
                ulong val_109 = val_95;
                val_132 = val_101 >> 14;
                val_133 = mem[Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 88];
                val_133 = Org.BouncyCastle.Crypto.Digests.LongDigest.K.Length + 88;
                val_134 = 0 + 8;
                ulong val_112 = val_101;
                if(this.W == null)
            {
                    val_133 = val_133;
                val_134 = val_134;
            }
            
                ulong val_114 = val_95 >> 28;
                ulong val_115 = val_132;
                if(val_108 >= this.W.Length)
            {
                    var val_163 = val_133;
                val_132 = val_134;
                val_134 = val_132;
                val_133 = val_163;
            }
            
                ulong val_162 = this.W[0];
                ulong val_118 = val_65;
                val_118 = val_118 + val_133;
                ulong val_120 = val_95;
                ulong val_122 = val_95;
                ulong val_126 = val_114;
                val_163 = val_118;
                ulong val_128 = val_114 >> 28;
                var val_129 = val_108 + 1;
            }
            while(val_134 != 80);
            
            ulong val_164 = this.H7;
            ulong val_165 = this.H8;
            val_164 = val_164 + val_160;
            this.H1 = this.H1;
            this.H2 = this.H2;
            val_165 = val_165 + val_65;
            this.H3 = this.H3;
            this.H4 = this.H4;
            this.H5 = val_142;
            this.H6 = this.H6;
            this.H7 = val_164;
            this.H8 = val_165;
            mem[1152921553278757936] = 0;
            System.Array.Clear(array:  this.W, index:  0, length:  16);
        }
        private static ulong Ch(ulong x, ulong y, ulong z)
        {
            x = (z & (~x)) ^ (y & x);
            return (ulong)x;
        }
        private static ulong Maj(ulong x, ulong y, ulong z)
        {
            ulong val_1 = z ^ y;
            val_1 = val_1 & x;
            x = val_1 ^ (z & y);
            return (ulong)x;
        }
        private static ulong Sum0(ulong x)
        {
            ulong val_1 = x >> 28;
            val_1 = val_1 ^ (((x) << (64-34)) | ((x) << 34));
            x = val_1 ^ (((x) << (64-39)) | ((x) << 39));
            return (ulong)x;
        }
        private static ulong Sum1(ulong x)
        {
            ulong val_1 = x >> 14;
            val_1 = val_1 ^ (((x) << (64-18)) | ((x) << 18));
            x = val_1 ^ (((x) << (64-41)) | ((x) << 41));
            return (ulong)x;
        }
        private static ulong Sigma0(ulong x)
        {
            ulong val_1 = x >> 8;
            val_1 = val_1 ^ (x >> 7);
            x = val_1 ^ (((x) << (64-1)) | ((x) << 1));
            return (ulong)x;
        }
        private static ulong Sigma1(ulong x)
        {
            ulong val_1 = x >> 61;
            val_1 = val_1 ^ (x >> 6);
            x = val_1 ^ (((x) << (64-19)) | ((x) << 19));
            return (ulong)x;
        }
        public int GetByteLength()
        {
            return (int)this.MyByteLength;
        }
        public abstract string get_AlgorithmName(); // 0
        public abstract int GetDigestSize(); // 0
        public abstract int DoFinal(byte[] output, int outOff); // 0
        public abstract Org.BouncyCastle.Utilities.IMemoable Copy(); // 0
        public abstract void Reset(Org.BouncyCastle.Utilities.IMemoable t); // 0
        private static LongDigest()
        {
            Org.BouncyCastle.Crypto.Digests.LongDigest.K = new ulong[80] {2498979749673536066, -3646245387246487695, 3403399622905544885, -4838122184753039895, 4086252446962308665, 1859992929390686553, -7255552232500609134, 1765813315555957931, 4756368157632497624, -4724434042410532078, -8308327335690161884, -2110781031757050795, 8037091291283963506, -5650304235557757312, 3824337998120934555, -7771407767240074303, -3293554513316045852, -2079168548772004113, -5344210850844655345, 7321916724731776036, 8431349115508287789, -8942839965813541814, -3099811634807721892, -5380937871772812938, -6062013399648092520, 1167193360650613160, 4549193732232512432, -2013408380718196289, -4427134924657794874, 2713148928191211477, 8034988947155438086, 8101428217529313556, -274769851924695257, 2794807221280643886, -1357056442637669299, -2327352080558376877, -2421899161643054491, -6290834626763396490, -1824259909055036799, 4266459246648652434, 7206869140159119266, 85641769406306984, -7955616642601628734, 3512337146882124999, 1752726907837256401, 1200602192021985750, 3035550769558654708, -5129112675285964272, -3976446782870543335, 6028984342455007006, -7355628476667836377, -6320630683295502284, 7159256408608480313, -3780136492758017970, 8350627498165967963, -6649368213535642008, -237864643584684172, 6930783929945531768, 8262962515965167748, -1424997744119724148, 2890857017004506768, -1603981998329933660, 1547486418939673022, 3121965290049008070, -7178413541127477302, 559220555064575697, 2228121615336332010, 8705861525301067253, -5012762078987423738, -6442178665529908470, -5904788941896663279, 1965570631190409499, -8899952736125592792, -7843925571205871054, -4846215056792314308, 5480054587075796291, -5313615565542865588, 3061996932284645209, -1370547589108216993, 1682172846326498412};
        }
    
    }

}
