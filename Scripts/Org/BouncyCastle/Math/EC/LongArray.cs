using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    internal class LongArray
    {
        // Fields
        private static readonly ushort[] INTERLEAVE2_TABLE;
        private static readonly int[] INTERLEAVE3_TABLE;
        private static readonly int[] INTERLEAVE4_TABLE;
        private static readonly int[] INTERLEAVE5_TABLE;
        private static readonly long[] INTERLEAVE7_TABLE;
        private const string ZEROES = "0000000000000000000000000000000000000000000000000000000000000000";
        internal static readonly byte[] BitLengths;
        private long[] m_ints;
        
        // Properties
        public int Length { get; }
        
        // Methods
        public LongArray(int intLen)
        {
            this.m_ints = new long[0];
        }
        public LongArray(long[] ints)
        {
            this.m_ints = ints;
        }
        public LongArray(long[] ints, int off, int len)
        {
            if((off == 0) && (ints.Length == len))
            {
                    this.m_ints = ints;
                return;
            }
            
            long[] val_1 = new long[0];
            this.m_ints = val_1;
            System.Array.Copy(sourceArray:  ints, sourceIndex:  off, destinationArray:  val_1, destinationIndex:  0, length:  len);
        }
        public LongArray(Org.BouncyCastle.Math.BigInteger bigInt)
        {
            var val_15;
            var val_17;
            var val_18;
            long val_19;
            var val_20;
            if((bigInt == null) || ((bigInt.SignValue & 2147483648) != 0))
            {
                goto label_2;
            }
            
            if(bigInt.SignValue == 0)
            {
                goto label_3;
            }
            
            System.Byte[] val_3 = bigInt.ToByteArray();
            if(val_3 == null)
            {
                goto label_4;
            }
            
            int val_16 = val_3.Length;
            if(val_3.Length != 0)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            byte val_15 = val_3[0];
            var val_4 = (val_15 == 0) ? 1 : 0;
            int val_5 = val_16 - val_4;
            int val_6 = val_5 + 7;
            var val_8 = (val_6 < 0) ? (val_5 + 14) : (val_6);
            val_16 = val_8 >> 3;
            var val_10 = (val_5 < 0) ? (val_6) : (val_5);
            val_10 = val_10 & 4294967288;
            val_10 = val_5 - val_10;
            val_17 = ((long)(val_8 >> 3) & 536870911) - 1;
            this.m_ints = new long[0];
            if(val_10 >= 1)
            {
                    val_10 = val_10 + val_4;
                var val_11 = (val_15 == 0) ? 1 : 0;
                do
            {
                val_18 = val_11 + 1;
                val_19 = 0 | val_3[val_11];
            }
            while(val_18 < (long)val_10);
            
                val_15 = val_16 - 2;
                val_17 = val_15;
                this.m_ints[val_17] = val_19;
            }
            
            if((val_17 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                var val_19 = 0;
                do
            {
                long val_20 = 0;
                val_19 = val_19 + 1;
                val_20 = val_20 | (val_3[(long)val_18 + val_19]);
            }
            while(val_19 != 8);
            
                val_19 = this.m_ints;
                val_20 = val_18 + 8;
                val_15 = (long)val_17 - 1;
                val_19[(long)val_17] = val_20;
            }
            while((long)val_17 >= this.m_ints.Length);
            
            return;
            label_3:
            this.m_ints = new long[1];
            return;
            label_4:
            if(28563616 != 0)
            {
                goto label_18;
            }
            
            goto label_19;
            label_2:
            System.ArgumentException val_14 = new System.ArgumentException(message:  "invalid F2m field value", paramName:  "bigInt");
        }
        public bool IsOne()
        {
            var val_1;
            if(this.m_ints[0] != 1)
            {
                goto label_5;
            }
            
            if(this.m_ints.Length < 2)
            {
                goto label_3;
            }
            
            label_6:
            if(this.m_ints[1] != 0)
            {
                goto label_5;
            }
            
            if((1 + 1) < this.m_ints.Length)
            {
                goto label_6;
            }
            
            label_3:
            val_1 = 1;
            return (bool)val_1;
            label_5:
            val_1 = 0;
            return (bool)val_1;
        }
        public bool IsZero()
        {
            var val_1;
            var val_2 = 0;
            label_3:
            if(val_2 >= this.m_ints.Length)
            {
                goto label_1;
            }
            
            val_2 = val_2 + 1;
            if(this.m_ints[0] == 0)
            {
                goto label_3;
            }
            
            val_1 = 0;
            return (bool)val_1;
            label_1:
            val_1 = 1;
            return (bool)val_1;
        }
        public int GetUsedLength()
        {
            if(this.m_ints != null)
            {
                    return this.GetUsedLengthFrom(from:  this.m_ints.Length);
            }
            
            return this.GetUsedLengthFrom(from:  this.m_ints.Length);
        }
        public int GetUsedLengthFrom(int from)
        {
            var val_5;
            var val_6;
            val_5 = System.Math.Min(val1:  from, val2:  this.m_ints.Length);
            val_6 = val_5 - 1;
            if()
            {
                    if(this.m_ints[0] != 0)
            {
                    val_5 = val_5 + 1;
                do
            {
                val_6 = (long)val_5 - 2;
                val_5 = val_5 - 1;
            }
            while(this.m_ints[val_6] == 0);
            
                return (int)val_5;
            }
            
                do
            {
                if(null != null)
            {
                    return (int)val_5;
            }
            
                val_6 = this.m_ints[val_6][32] - 8;
            }
            while((val_5 - 1) > 0);
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public int Degree()
        {
            var val_3;
            var val_4;
            val_3 = -(this.m_ints.Length << 6);
            int val_1 = this.m_ints.Length - 1;
            label_5:
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            long val_3 = this.m_ints[(long)val_1];
            val_3 = val_3 + 64;
            val_1 = val_1 - 1;
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            val_4 = (Org.BouncyCastle.Math.EC.LongArray.BitLength(w:  val_3)) - val_3;
            return (int)val_4;
            label_2:
            val_4 = 0;
            return (int)val_4;
        }
        private int DegreeFrom(int limit)
        {
            var val_4;
            var val_5;
            int val_1 = limit + 62;
            val_1 = val_1 >> 6;
            val_4 = -(val_1 << 6);
            int val_2 = val_1 - 1;
            label_4:
            if(val_2 == 1)
            {
                goto label_1;
            }
            
            long val_4 = this.m_ints[(long)val_2];
            val_4 = val_4 + 64;
            val_2 = val_2 - 1;
            if(val_4 == 0)
            {
                goto label_4;
            }
            
            val_5 = (Org.BouncyCastle.Math.EC.LongArray.BitLength(w:  val_4)) - val_4;
            return (int)val_5;
            label_1:
            val_5 = 0;
            return (int)val_5;
        }
        private static int BitLength(long w)
        {
            var val_10;
            var val_11;
            var val_12;
            System.Byte[] val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            long val_1 = w >> 32;
            var val_2 = (val_1 == 0) ? w : (val_1);
            var val_3 = val_2 >> 16;
            if(val_3 == 0)
            {
                goto label_1;
            }
            
            val_10 = val_2 >> 24;
            val_11 = null;
            if(val_10 == 0)
            {
                goto label_2;
            }
            
            val_12 = null;
            val_13 = Org.BouncyCastle.Math.EC.LongArray.BitLengths;
            val_14 = 24;
            goto label_6;
            label_1:
            var val_5 = val_2 >> 8;
            val_15 = null;
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            val_16 = null;
            val_13 = val_5;
            System.Byte[] val_6 = Org.BouncyCastle.Math.EC.LongArray.BitLengths + val_13;
            val_17 = ((Org.BouncyCastle.Math.EC.LongArray.BitLengths + (val_1 == 0 ? w : (w >> 32) >> 8)) + 32) + 8;
            return (int)val_17 + ((val_1 == 0) ? 0 : 32);
            label_2:
            val_18 = null;
            val_13 = Org.BouncyCastle.Math.EC.LongArray.BitLengths;
            val_14 = 16;
            val_10 = val_3;
            label_6:
            System.Byte[] val_7 = val_13 + val_10;
            val_17 = val_14 + ((Org.BouncyCastle.Math.EC.LongArray.BitLengths + (val_1 == 0 ? w : (w >> 32) >> 16)) + 32);
            return (int)val_17 + ((val_1 == 0) ? 0 : 32);
            label_7:
            val_19 = null;
            System.Byte[] val_9 = Org.BouncyCastle.Math.EC.LongArray.BitLengths + (long)val_2;
            return (int)val_17 + ((val_1 == 0) ? 0 : 32);
        }
        private long[] ResizedInts(int newLen)
        {
            long[] val_1 = new long[0];
            System.Array.Copy(sourceArray:  this.m_ints, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  System.Math.Min(val1:  this.m_ints.Length, val2:  newLen));
            return (System.Int64[])val_1;
        }
        public Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            long val_10;
            var val_11;
            var val_12;
            Org.BouncyCastle.Math.BigInteger val_13;
            var val_14;
            int val_1 = this.GetUsedLength();
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            val_10 = this.m_ints[(long)val_1 - 1];
            var val_14 = 8;
            byte[] val_3 = new byte[8];
            val_11 = 0;
            label_8:
            var val_13 = 56;
            long val_4 = val_10 >> val_13;
            val_13 = val_4 & 255;
            if(val_13 == 0)
            {
                    if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            }
            
            val_3[0] = val_4;
            val_11 = val_11 + 1;
            label_5:
            val_14 = val_14 - 1;
            val_12 = 56 - 8;
            if(val_14 > 0)
            {
                goto label_8;
            }
            
            var val_6 = val_11 + (((long)val_1 - 1) << 3);
            byte[] val_7 = new byte[0];
            if(val_11 >= 1)
            {
                    var val_15 = 0;
                val_10 = val_11;
                do
            {
                mem2[0] = null;
                val_15 = val_15 + 1;
            }
            while(val_10 != val_15);
            
            }
            
            int val_8 = val_1 - 2;
            if((val_8 & 2147483648) == 0)
            {
                    var val_18 = (long)val_8;
                do
            {
                var val_17 = 8;
                do
            {
                val_17 = val_17 - 1;
                val_7[(long)val_11] = this.m_ints[val_18] >> (56 & 56);
                val_10 = 56 - 8;
                val_12 = val_11 + 1;
            }
            while(val_17 > 0);
            
                val_18 = val_18 - 1;
                val_11 = val_11 + 8;
            }
            while((val_18 & 2147483648) == 0);
            
            }
            
            Org.BouncyCastle.Math.BigInteger val_12 = null;
            val_13 = val_12;
            val_12 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_7);
            return val_13;
            label_1:
            val_14 = null;
            val_14 = null;
            val_13 = Org.BouncyCastle.Math.BigInteger.Zero;
            return val_13;
        }
        private static long ShiftUp(long[] x, int xOff, int count, int shift)
        {
            var val_5;
            long val_6;
            int val_7;
            val_5 = xOff;
            val_6 = 0;
            if(count < 1)
            {
                    return (long)val_6;
            }
            
            int val_5 = count;
            do
            {
                val_7 = x.Length;
                if(val_5 >= val_7)
            {
                    val_7 = x.Length;
            }
            
                long val_4 = x[(long)val_5];
                val_6 = (val_4 << (shift & 63)) | val_6;
                mem2[0] = val_6;
                val_6 = val_4 >> ((-shift) & 63);
                val_5 = val_5 - 1;
                val_5 = val_5 + 1;
            }
            while(val_5 != 0);
            
            return (long)val_6;
        }
        private static long ShiftUp(long[] x, int xOff, long[] z, int zOff, int count, int shift)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = zOff;
            val_6 = xOff;
            val_7 = 0;
            if(count < 1)
            {
                    return (long)val_7;
            }
            
            int val_6 = count;
            do
            {
                long val_4 = x[(long)val_6];
                int val_5 = shift & 63;
                val_5 = val_4 << val_5;
                val_7 = val_4 >> ((-shift) & 63);
                val_5 = val_5 + 1;
                val_6 = val_6 - 1;
                val_6 = val_6 + 1;
                z[(long)val_5] = val_5 | val_7;
            }
            while(val_6 != 0);
            
            return (long)val_7;
        }
        public Org.BouncyCastle.Math.EC.LongArray AddOne()
        {
            System.Int64[] val_6;
            long val_7;
            if(this.m_ints.Length != 0)
            {
                    val_6 = this.ResizedInts(newLen:  System.Math.Max(val1:  1, val2:  this.GetUsedLength()));
                val_7 = val_6[0] ^ 1;
            }
            else
            {
                    val_6 = new long[1];
                val_7 = 1;
            }
            
            val_6[0] = val_7;
            .m_ints = val_6;
            return (Org.BouncyCastle.Math.EC.LongArray)new Org.BouncyCastle.Math.EC.LongArray();
        }
        private void AddShiftedByBitsSafe(Org.BouncyCastle.Math.EC.LongArray other, int otherDegree, int bits)
        {
            System.Int64[] val_4;
            int val_5;
            int val_4 = bits;
            val_4 = this;
            val_5 = (otherDegree + 63) >> 6;
            int val_2 = val_4 >> 6;
            val_4 = val_4 & 63;
            if(val_4 != 0)
            {
                    long val_3 = Org.BouncyCastle.Math.EC.LongArray.AddShiftedUp(x:  this.m_ints, xOff:  val_2, y:  other.m_ints, yOff:  0, count:  val_5, shift:  val_4);
                if(val_3 == 0)
            {
                    return;
            }
            
                val_4 = this.m_ints;
                val_5 = val_2 + val_5;
                long val_5 = val_4[val_5];
                val_5 = val_5 ^ val_3;
                val_4[val_5] = val_5;
                return;
            }
            
            Org.BouncyCastle.Math.EC.LongArray.Add(x:  this.m_ints, xOff:  val_2, y:  other.m_ints, yOff:  0, count:  val_5);
        }
        private static long AddShiftedUp(long[] x, int xOff, long[] y, int yOff, int count, int shift)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = yOff;
            val_6 = xOff;
            val_7 = 0;
            if(count < 1)
            {
                    return (long)val_7;
            }
            
            int val_6 = count;
            do
            {
                long val_4 = y[(long)val_5];
                long val_3 = val_4 << (shift & 63);
                val_3 = val_3 | val_7;
                val_6 = val_6 + 1;
                val_6 = val_6 - 1;
                val_7 = val_4 >> ((-shift) & 63);
                val_3 = x[(long)val_6] ^ val_3;
                val_5 = val_5 + 1;
                x[(long)val_6] = val_3;
            }
            while(val_6 != 0);
            
            return (long)val_7;
        }
        private static long AddShiftedDown(long[] x, int xOff, long[] y, int yOff, int count, int shift)
        {
            var val_8;
            int val_1 = count - 1;
            val_8 = 0;
            if((val_1 & 2147483648) != 0)
            {
                    return (long)val_8;
            }
            
            do
            {
                long val_7 = y[(long)yOff + val_1];
                long val_8 = x[(long)xOff + val_1];
                long val_6 = val_7 >> (shift & 63);
                val_6 = val_6 | val_8;
                val_1 = val_1 - 1;
                val_8 = val_8 ^ val_6;
                val_8 = val_7 << ((-shift) & 63);
                x[(long)xOff + val_1] = val_8;
            }
            while((val_1 & 2147483648) == 0);
            
            return (long)val_8;
        }
        public void AddShiftedByWords(Org.BouncyCastle.Math.EC.LongArray other, int words)
        {
            System.Int64[] val_4;
            int val_1 = other.GetUsedLength();
            if(val_1 == 0)
            {
                    return;
            }
            
            int val_2 = val_1 + words;
            if(val_2 <= this.m_ints.Length)
            {
                goto label_4;
            }
            
            val_4 = this.ResizedInts(newLen:  val_2);
            this.m_ints = val_4;
            if(other != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_4 = this.m_ints;
            if(other != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            Org.BouncyCastle.Math.EC.LongArray.Add(x:  val_4, xOff:  words, y:  other.m_ints, yOff:  0, count:  val_1);
        }
        private static void Add(long[] x, int xOff, long[] y, int yOff, int count)
        {
            var val_1;
            var val_2;
            val_1 = yOff;
            val_2 = xOff;
            if(count < 1)
            {
                    return;
            }
            
            int val_3 = count;
            do
            {
                long val_2 = y[(long)val_1];
                val_1 = val_1 + 1;
                val_3 = val_3 - 1;
                val_2 = val_2 + 1;
                val_2 = val_2 ^ x[(long)val_2];
                mem2[0] = val_2;
            }
            while(val_3 != 0);
        
        }
        private static void Add(long[] x, int xOff, long[] y, int yOff, long[] z, int zOff, int count)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = zOff;
            val_2 = yOff;
            val_3 = xOff;
            if(count < 1)
            {
                    return;
            }
            
            int val_3 = count;
            do
            {
                long val_1 = x[(long)val_3];
                val_1 = y[(long)val_2] ^ val_1;
                val_1 = val_1 + 1;
                val_2 = val_2 + 1;
                val_3 = val_3 - 1;
                val_3 = val_3 + 1;
                z[(long)val_1] = val_1;
            }
            while(val_3 != 0);
        
        }
        private static void AddBoth(long[] x, int xOff, long[] y1, int y1Off, long[] y2, int y2Off, int count)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = y2Off;
            val_3 = y1Off;
            val_4 = xOff;
            if(count < 1)
            {
                    return;
            }
            
            int val_5 = count;
            do
            {
                long val_4 = y2[(long)val_2];
                val_2 = val_2 + 1;
                val_4 = y1[(long)val_3] ^ x[(long)val_4] ^ val_4;
                mem2[0] = val_4;
                val_3 = val_3 + 1;
                val_5 = val_5 - 1;
                val_4 = val_4 + 1;
            }
            while(val_5 != 0);
        
        }
        private static void Distribute(long[] x, int src, int dst1, int dst2, int count)
        {
            var val_1;
            var val_2;
            int val_3;
            val_1 = dst2;
            int val_4 = dst1;
            val_2 = src;
            if(count < 1)
            {
                    return;
            }
            
            int val_5 = count;
            do
            {
                val_3 = x.Length;
                if(val_2 >= val_3)
            {
                    val_3 = x.Length;
            }
            
                long val_1 = x[(long)val_2];
                long val_2 = x[(long)val_4];
                val_2 = val_2 ^ val_1;
                x[(long)val_4] = val_2;
                long val_3 = x[(long)val_1];
                val_1 = val_1 + 1;
                val_4 = val_4 + 1;
                val_5 = val_5 - 1;
                val_3 = val_3 ^ val_1;
                val_2 = val_2 + 1;
                x[(long)val_1] = val_3;
            }
            while(val_5 != 0);
        
        }
        public int get_Length()
        {
            if(this.m_ints != null)
            {
                    return (int)this.m_ints.Length;
            }
            
            return (int)this.m_ints.Length;
        }
        private static void FlipWord(long[] buf, int off, int bit, long word)
        {
            var val_6;
            var val_7;
            long val_9;
            val_6 = bit;
            val_7 = word;
            int val_1 = off + (val_6 >> 6);
            int val_2 = val_6 & 63;
            val_9 = buf[(long)val_1];
            if(val_2 != 0)
            {
                    val_9 = val_9 ^ (val_7 << val_2);
                val_7 = val_7 >> ((-val_6) & 63);
                mem2[0] = val_9;
                if(val_7 == 0)
            {
                    return;
            }
            
                val_6 = (long)val_1 + 1;
                val_9 = buf[val_6];
            }
            
            val_9 = val_9 ^ val_7;
            mem2[0] = val_9;
        }
        public bool TestBitZero()
        {
            System.Int64[] val_2;
            var val_3;
            val_2 = this;
            if(this.m_ints.Length != 0)
            {
                    val_2 = this.m_ints;
                val_3 = val_2[0] & 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        private static bool TestBit(long[] buf, int off, int n)
        {
            int val_2 = n & 63;
            val_2 = 1 << val_2;
            return (bool)((buf[(long)(n >> 6) + off]) != val_2) ? 1 : 0;
        }
        private static void FlipBit(long[] buf, int off, int n)
        {
            int val_2 = n & 63;
            val_2 = 1 << val_2;
            long val_4 = buf[(long)(n >> 6) + off];
            val_4 = val_4 ^ val_2;
            buf[(long)(n >> 6) + off] = val_4;
        }
        private static void MultiplyWord(long a, long[] b, int bLen, long[] c, int cOff)
        {
            var val_5;
            var val_6;
            val_5 = a;
            if((val_5 & 1) != 0)
            {
                    Org.BouncyCastle.Math.EC.LongArray.Add(x:  c, xOff:  cOff, y:  b, yOff:  0, count:  bLen);
            }
            
            val_6 = val_5 >> 1;
            if(val_6 == 0)
            {
                    return;
            }
            
            do
            {
                if((val_6 & 1) != 0)
            {
                    long val_2 = Org.BouncyCastle.Math.EC.LongArray.AddShiftedUp(x:  c, xOff:  cOff, y:  b, yOff:  0, count:  bLen, shift:  1);
                if(val_2 != 0)
            {
                    mem2[0] = 1152921505756883616 ^ val_2;
            }
            
            }
            
                val_6 = val_6 >> 1;
                val_5 = 1 + 1;
            }
            while(val_6 != 0);
        
        }
        public Org.BouncyCastle.Math.EC.LongArray ModMultiplyLD(Org.BouncyCastle.Math.EC.LongArray other, int m, int[] ks)
        {
            var val_29;
            int val_30;
            var val_31;
            System.Int64[] val_32;
            int val_33;
            System.Int64[] val_34;
            var val_35;
            int val_36;
            int val_37;
            int val_38;
            System.Int64[] val_39;
            int val_40;
            int val_41;
            System.Int32[] val_42;
            System.Int64[] val_43;
            var val_44;
            val_29 = this;
            int val_1 = this.Degree();
            if(val_1 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_31;
            }
            
            int val_2 = other.Degree();
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            var val_3 = (val_1 > val_2) ? (val_1) : (val_2);
            int val_4 = (val_1 > val_2) ? (val_2) : (val_1);
            var val_5 = val_4 + 63;
            val_4 = val_4 + val_3;
            val_5 = val_5 >> 6;
            val_4 = val_4 + 62;
            var val_8 = (val_1 > val_2) ? other : (val_29);
            val_30 = (val_3 + 63) >> 6;
            val_4 = val_4 >> 6;
            if(val_5 != 1)
            {
                goto label_4;
            }
            
            if((val_1 > val_2 ? other : this + 16 + 32) != 1)
            {
                goto label_8;
            }
            
            val_31 = (val_1 > val_2) ? (val_29) : other;
            return (Org.BouncyCastle.Math.EC.LongArray)val_31;
            label_3:
            val_31 = other;
            return (Org.BouncyCastle.Math.EC.LongArray)val_31;
            label_4:
            val_3 = val_3 + 70;
            int val_9 = val_3 >> 6;
            val_32 = new int[16];
            var val_11 = val_9 << 4;
            long[] val_12 = new long[0];
            val_32[0] = val_9;
            System.Array.Copy(sourceArray:  val_1 > val_2 ? this : other + 16, sourceIndex:  0, destinationArray:  val_12, destinationIndex:  val_9, length:  val_30);
            var val_31 = 0;
            var val_30 = 0;
            val_33 = val_9 << 1;
            do
            {
                int val_14 = val_33 + val_31;
                mem2[0] = val_14;
                if(((val_30 + 2) & 1) == 0)
            {
                    long val_16 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_12, xOff:  val_14 >> 1, z:  val_12, zOff:  val_14, count:  val_9, shift:  1);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.LongArray.Add(x:  val_12, xOff:  val_9, y:  val_12, yOff:  val_9 + val_31, z:  val_12, zOff:  val_14, count:  val_9);
            }
            
                val_30 = val_30 + 1;
                val_31 = val_31 + val_9;
            }
            while(val_30 != 14);
            
            long[] val_18 = new long[0];
            val_34 = val_18;
            long val_19 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_12, xOff:  0, z:  val_18, zOff:  0, count:  mem[1152921544102850408], shift:  4);
            val_35 = mem[val_1 > val_2 ? other : this + 16];
            val_35 = val_1 > val_2 ? other : this + 16;
            long[] val_20 = new long[0];
            val_30 = val_9;
            do
            {
                if(val_5 >= 128)
            {
                    do
            {
                if(1 >= (val_1 > val_2 ? other : this + 16 + 24))
            {
                    val_34 = 0;
            }
            
                var val_32 = val_1 > val_2 ? other : this + 16 + 40;
                val_32 = val_32 >> 56;
                val_36 = val_10.Length;
                if((val_32 & 15) >= val_36)
            {
                    val_34 = 0;
                val_36 = val_10.Length;
            }
            
                val_33 = val_32[(((val_1 > val_2 ? other : this + 16 + 40 >> 56) & 15)) << 2];
                if(((ulong)(val_32 >> 4) & 15) >= val_36)
            {
                    val_34 = 0;
            }
            
                Org.BouncyCastle.Math.EC.LongArray.AddBoth(x:  val_20, xOff:  1 - 1, y1:  val_12, y1Off:  val_33, y2:  val_18, y2Off:  val_32[((ulong)(((val_1 > val_2 ? other : this + 16 + 40 >> 56)>>4) & 0xF)) << 2], count:  val_30);
                var val_23 = 1 + 2;
                var val_24 = 5 + 2;
            }
            while(val_23 < val_5);
            
            }
            
                val_37 = val_4;
                long val_25 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_20, xOff:  0, count:  val_37, shift:  8);
            }
            while(val_23 >= val_5);
            
            var val_26 = val_35 + 32;
            label_50:
            if(val_5 != 0)
            {
                    do
            {
                if(0 >= (val_1 > val_2 ? other : this + 16 + 24))
            {
                    val_37 = 0;
            }
            
                var val_34 = (val_1 > val_2 ? other : this + 16 + 32) + 0;
                val_34 = val_34 >> 56;
                val_38 = val_10.Length;
                if((val_34 & 15) >= val_38)
            {
                    val_37 = 0;
                val_38 = val_10.Length;
            }
            
                if(((ulong)(val_34 >> 4) & 15) >= val_38)
            {
                    val_37 = 0;
            }
            
                Org.BouncyCastle.Math.EC.LongArray.AddBoth(x:  val_20, xOff:  0, y1:  val_12, y1Off:  val_32[((((val_1 > val_2 ? other : this + 16 + 32) + 0 >> 56) & 15)) << 2], y2:  val_18, y2Off:  val_32[((ulong)((((val_1 > val_2 ? other : this + 16 + 32) + 0 >> 56)>>4) & 0xF)) << 2], count:  val_30);
                val_33 = 0 + 2;
            }
            while(val_33 < val_5);
            
            }
            
            val_39 = 56;
            if(val_39 < 1)
            {
                goto label_47;
            }
            
            long val_28 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_20, xOff:  0, count:  val_4, shift:  8);
            val_39 = val_39 - 8;
            if(val_39 >= 1)
            {
                goto label_50;
            }
            
            label_47:
            val_40 = val_4;
            val_41 = m;
            val_42 = ks;
            val_43 = val_20;
            val_44 = 0;
            return Org.BouncyCastle.Math.EC.LongArray.ReduceResult(buf:  long[] val_29 = new long[0], off:  0, len:  val_40 = val_4, m:  val_41 = m, ks:  val_42 = ks);
            label_8:
            val_32 = val_29;
            val_39 = mem[val_1 > val_2 ? this : other + 16];
            val_39 = val_1 > val_2 ? this : other + 16;
            Org.BouncyCastle.Math.EC.LongArray.MultiplyWord(a:  val_1 > val_2 ? other : this + 16 + 32, b:  val_39, bLen:  val_30, c:  val_29, cOff:  0);
            val_43 = val_32;
            val_44 = 0;
            return Org.BouncyCastle.Math.EC.LongArray.ReduceResult(buf:  val_29, off:  0, len:  val_40, m:  val_41, ks:  val_42);
        }
        public Org.BouncyCastle.Math.EC.LongArray ModMultiply(Org.BouncyCastle.Math.EC.LongArray other, int m, int[] ks)
        {
            var val_34;
            int val_35;
            int val_36;
            var val_37;
            int val_38;
            int val_39;
            System.Int32[] val_40;
            var val_41;
            System.Int64[] val_42;
            System.Int64[] val_44;
            var val_45;
            int val_46;
            int val_47;
            System.Int32[] val_48;
            Org.BouncyCastle.Math.EC.LongArray val_29 = other;
            val_34 = this;
            int val_1 = this.Degree();
            if(val_1 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_34;
            }
            
            int val_2 = val_29.Degree();
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            var val_3 = (val_1 > val_2) ? (val_1) : (val_2);
            var val_4 = (val_1 > val_2) ? (val_2) : (val_1);
            var val_5 = val_4 + 63;
            val_4 = val_4 + val_3;
            val_5 = val_5 >> 6;
            val_4 = val_4 + 62;
            var val_8 = (val_1 > val_2) ? (val_29) : (val_34);
            val_35 = (val_3 + 63) >> 6;
            val_36 = val_4 >> 6;
            if(val_5 != 1)
            {
                goto label_4;
            }
            
            if((val_1 > val_2 ? other : this + 16 + 32) != 1)
            {
                goto label_8;
            }
            
            val_34 = (val_1 > val_2) ? (val_34) : (val_29);
            return (Org.BouncyCastle.Math.EC.LongArray)val_34;
            label_3:
            val_34 = val_29;
            return (Org.BouncyCastle.Math.EC.LongArray)val_34;
            label_4:
            val_3 = val_3 + 70;
            val_29 = val_3 >> 6;
            int[] val_9 = new int[16];
            var val_10 = val_29 << 4;
            long[] val_11 = new long[0];
            val_9[0] = val_29;
            System.Array.Copy(sourceArray:  val_1 > val_2 ? this : other + 16, sourceIndex:  0, destinationArray:  val_11, destinationIndex:  val_29, length:  val_35);
            var val_31 = 0;
            var val_30 = 0;
            val_37 = val_29 << 1;
            do
            {
                int val_13 = val_37 + val_31;
                mem2[0] = val_13;
                if(((val_30 + 2) & 1) == 0)
            {
                    long val_15 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_11, xOff:  val_13 >> 1, z:  val_11, zOff:  val_13, count:  val_29, shift:  1);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.LongArray.Add(x:  val_11, xOff:  val_29, y:  val_11, yOff:  val_29 + val_31, z:  val_11, zOff:  val_13, count:  val_29);
            }
            
                val_30 = val_30 + 1;
                val_31 = val_31 + val_29;
            }
            while(val_30 != 14);
            
            val_38 = val_36;
            long[] val_17 = new long[0];
            long val_18 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_11, xOff:  0, z:  val_17, zOff:  0, count:  val_11.Length, shift:  4);
            var val_19 = val_38 << 3;
            long[] val_20 = new long[0];
            val_35 = val_20;
            if(val_5 != 0)
            {
                    var val_34 = 0;
                do
            {
                var val_21 = (val_1 > val_2 ? other : this + 16) + 0;
                do
            {
                val_39 = val_9.Length;
                if((((val_1 > val_2 ? other : this + 16 + 0) + 32) & 15) >= val_39)
            {
                    val_39 = val_9.Length;
            }
            
                Org.BouncyCastle.Math.EC.LongArray.AddBoth(x:  val_20, xOff:  0, y1:  val_11, y1Off:  val_9[(((val_1 > val_2 ? other : this + 16 + 0) + 32 & 15)) << 2], y2:  val_17, y2Off:  val_9[((ulong)(((val_1 > val_2 ? other : this + 16 + 0) + 32>>4) & 0xF)) << 2], count:  val_29);
                val_38 = val_36;
                val_36 = ((val_1 > val_2 ? other : this + 16 + 0) + 32) >> 8;
                val_37 = val_34 + val_38;
            }
            while(val_36 != 0);
            
                val_34 = val_34 + 1;
            }
            while(val_34 != val_5);
            
            }
            
            int val_36 = val_20.Length;
            val_40 = ks;
            val_41 = null;
            val_42 = val_36 - val_38;
            var val_23 = ((Org.BouncyCastle.Math.EC.LongArray.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if(val_42 != 0)
            {
                    var val_35 = 0;
                val_36 = val_36 - (val_38 << 1);
                do
            {
                long val_26 = Org.BouncyCastle.Math.EC.LongArray.AddShiftedUp(x:  val_20, xOff:  val_36 + val_35, y:  val_20, yOff:  val_42 + val_35, count:  val_38, shift:  8);
                val_35 = val_35 - val_38;
                val_36 = val_42 + val_35;
                val_41 = null;
                var val_27 = ((Org.BouncyCastle.Math.EC.LongArray.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            }
            while(val_36 != 0);
            
            }
            
            val_44 = val_35;
            val_45 = 0;
            val_46 = val_38;
            val_47 = m;
            val_48 = val_40;
            return Org.BouncyCastle.Math.EC.LongArray.ReduceResult(buf:  long[] val_28 = new long[0], off:  0, len:  val_46 = val_36, m:  val_47 = m, ks:  val_48 = ks);
            label_8:
            val_40 = val_28;
            val_42 = mem[val_1 > val_2 ? this : other + 16];
            val_42 = val_1 > val_2 ? this : other + 16;
            Org.BouncyCastle.Math.EC.LongArray.MultiplyWord(a:  val_1 > val_2 ? other : this + 16 + 32, b:  val_42, bLen:  val_35, c:  val_28, cOff:  0);
            val_44 = val_40;
            val_45 = 0;
            return Org.BouncyCastle.Math.EC.LongArray.ReduceResult(buf:  val_28, off:  0, len:  val_46, m:  val_47, ks:  val_48);
        }
        public Org.BouncyCastle.Math.EC.LongArray ModMultiplyAlt(Org.BouncyCastle.Math.EC.LongArray other, int m, int[] ks)
        {
            var val_28;
            int val_29;
            int val_30;
            int val_31;
            var val_32;
            int val_33;
            int val_34;
            int val_35;
            System.Int64[] val_36;
            var val_37;
            var val_38;
            var val_39;
            int val_40;
            int val_41;
            System.Int64[] val_42;
            var val_43;
            val_28 = this;
            int val_1 = this.Degree();
            if(val_1 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_28;
            }
            
            int val_2 = other.Degree();
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            var val_3 = (val_1 > val_2) ? (val_1) : (val_2);
            var val_4 = (val_1 > val_2) ? (val_2) : (val_1);
            val_4 = val_4 + val_3;
            var val_7 = (val_1 > val_2) ? other : (val_28);
            val_29 = (val_4 + 63) >> 6;
            val_4 = val_4 + 62;
            val_30 = (val_3 + 63) >> 6;
            val_31 = val_4 >> 6;
            if(val_29 != 1)
            {
                goto label_4;
            }
            
            val_32 = mem[val_1 > val_2 ? other : this + 16];
            val_32 = val_1 > val_2 ? other : this + 16;
            if((val_1 > val_2 ? other : this + 16 + 32) != 1)
            {
                goto label_8;
            }
            
            val_28 = (val_1 > val_2) ? (val_28) : other;
            return (Org.BouncyCastle.Math.EC.LongArray)val_28;
            label_3:
            val_28 = other;
            return (Org.BouncyCastle.Math.EC.LongArray)val_28;
            label_4:
            val_3 = val_3 + 78;
            val_33 = val_3 >> 6;
            int[] val_9 = new int[16];
            val_34 = val_9.Length;
            int val_10 = val_33 << 3;
            if(val_34 == 0)
            {
                    val_34 = val_9.Length;
            }
            
            val_9[0] = val_29;
            val_10 = val_10 + val_29;
            if(val_34 <= 1)
            {
                    val_34 = val_9.Length;
            }
            
            val_9[0] = val_10;
            val_35 = val_10 + val_31;
            if(val_34 >= 3)
            {
                    do
            {
                val_9[8] = val_35;
                val_35 = val_35 + val_31;
            }
            while((2 + 1) < val_9.Length);
            
            }
            
            var val_12 = val_35 + 1;
            long[] val_13 = new long[0];
            val_36 = val_13;
            val_37 = 1152921505514991616;
            Org.BouncyCastle.Math.EC.LongArray.Interleave(x:  val_1 > val_2 ? other : this + 16, xOff:  0, z:  val_13, zOff:  0, count:  val_29, width:  4);
            System.Array.Copy(sourceArray:  val_1 > val_2 ? this : other + 16, sourceIndex:  0, destinationArray:  val_13, destinationIndex:  val_29, length:  val_30);
            int val_14 = val_33 + val_29;
            var val_24 = 1;
            do
            {
                long val_15 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_13, xOff:  val_29, z:  val_13, zOff:  val_14, count:  val_33, shift:  1);
                val_24 = val_24 + 1;
                val_14 = val_14 + val_33;
            }
            while(val_24 != 8);
            
            goto label_23;
            label_36:
            long val_16 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_13, xOff:  val_29, count:  val_10, shift:  8);
            label_23:
            var val_27 = 0;
            label_35:
            val_30 = val_29;
            val_38 = 7;
            val_39 = val_36[val_27] >> (0 & 32);
            goto label_28;
            label_34:
            val_30 = val_30 + val_33;
            val_39 = val_39 >> 4;
            val_38 = 6;
            label_28:
            if((val_39 & 15) != 0)
            {
                    Org.BouncyCastle.Math.EC.LongArray.Add(x:  val_13, xOff:  (val_9[((((val_13[0x0][0] >> (0 & 32)) >> 4) & 15)) << 2]) + val_27, y:  val_13, yOff:  val_30, count:  val_33);
            }
            
            if(val_38 != 0)
            {
                goto label_34;
            }
            
            val_27 = val_27 + 1;
            if(val_27 < val_29)
            {
                goto label_35;
            }
            
            if(32 <= 63)
            {
                goto label_36;
            }
            
            val_31 = val_31;
            val_29 = val_9.Length;
            int val_20 = val_29 - 1;
            if(val_20 < 2)
            {
                goto label_38;
            }
            
            var val_31 = (long)val_20;
            label_51:
            if((val_31 & 1) != 0)
            {
                goto label_39;
            }
            
            val_29 = val_31 >> 1;
            if(val_29 >= val_9.Length)
            {
                goto label_40;
            }
            
            val_40 = val_9.Length & 4294967295;
            goto label_41;
            label_39:
            val_41 = val_9.Length;
            if(val_31 >= val_41)
            {
                    val_41 = val_9.Length;
            }
            
            if((val_29 - 2) >= val_41)
            {
                    val_41 = val_9.Length;
            }
            
            val_33 = val_9[((long)(int)((val_9.Length - 2))) << 2];
            val_31 = val_31;
            Org.BouncyCastle.Math.EC.LongArray.Distribute(x:  val_13, src:  val_9[((long)(int)((val_9.Length - 1))) << 2], dst1:  val_33, dst2:  val_9[0], count:  val_31);
            goto label_47;
            label_40:
            val_40 = val_9.Length;
            label_41:
            val_33 = val_9[((long)(int)((val_9.Length - 1))) << 2];
            long val_22 = Org.BouncyCastle.Math.EC.LongArray.AddShiftedUp(x:  val_13, xOff:  val_9[(((long)(int)((val_9.Length - 1)) >> 1)) << 2], y:  val_13, yOff:  val_33, count:  val_31, shift:  16);
            label_47:
            val_31 = val_31 - 1;
            if(val_31 > 1)
            {
                goto label_51;
            }
            
            val_29 = val_9.Length;
            label_38:
            val_42 = val_36;
            val_43 = val_9[0];
            return Org.BouncyCastle.Math.EC.LongArray.ReduceResult(buf:  long[] val_23 = new long[0], off:  0, len:  val_31, m:  m, ks:  ks);
            label_8:
            val_36 = val_23;
            Org.BouncyCastle.Math.EC.LongArray.MultiplyWord(a:  val_1 > val_2 ? other : this + 16 + 32, b:  val_1 > val_2 ? this : other + 16, bLen:  val_30, c:  val_23, cOff:  0);
            val_42 = val_36;
            val_43 = 0;
            return Org.BouncyCastle.Math.EC.LongArray.ReduceResult(buf:  val_23, off:  0, len:  val_31, m:  m, ks:  ks);
        }
        public Org.BouncyCastle.Math.EC.LongArray ModReduce(int m, int[] ks)
        {
            System.Int64[] val_1 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.m_ints);
            return (Org.BouncyCastle.Math.EC.LongArray)new Org.BouncyCastle.Math.EC.LongArray(ints:  val_1, off:  0, len:  Org.BouncyCastle.Math.EC.LongArray.ReduceInPlace(buf:  val_1, off:  0, len:  val_1.Length, m:  m, ks:  ks));
        }
        public Org.BouncyCastle.Math.EC.LongArray Multiply(Org.BouncyCastle.Math.EC.LongArray other, int m, int[] ks)
        {
            var val_34;
            var val_35;
            System.Int64[] val_36;
            int val_37;
            int val_38;
            int val_39;
            int val_40;
            int val_41;
            var val_42;
            System.Int64[] val_43;
            var val_44;
            int val_45;
            val_34 = other;
            val_35 = this;
            val_36 = this.Degree();
            if(val_36 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_35;
            }
            
            int val_2 = val_34.Degree();
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            var val_3 = (val_36 > val_2) ? (val_36) : (val_2);
            var val_4 = (val_36 > val_2) ? (val_2) : (val_36);
            var val_5 = val_4 + 63;
            val_4 = val_4 + val_3;
            val_5 = val_5 >> 6;
            val_4 = val_4 + 62;
            var val_8 = (val_36 > val_2) ? (val_34) : (val_35);
            val_37 = (val_3 + 63) >> 6;
            val_38 = val_4 >> 6;
            if(val_5 != 1)
            {
                goto label_4;
            }
            
            val_34 = mem[val_36 > val_2 ? other : this + 16];
            val_34 = val_36 > val_2 ? other : this + 16;
            if((val_36 > val_2 ? other : this + 16 + 32) != 1)
            {
                goto label_8;
            }
            
            val_35 = (val_36 > val_2) ? (val_35) : (val_34);
            return (Org.BouncyCastle.Math.EC.LongArray)val_35;
            label_3:
            val_35 = val_34;
            return (Org.BouncyCastle.Math.EC.LongArray)val_35;
            label_4:
            val_3 = val_3 + 70;
            int val_9 = val_3 >> 6;
            val_36 = new int[16];
            var val_11 = val_9 << 4;
            long[] val_12 = new long[0];
            val_36[0] = val_9;
            System.Array.Copy(sourceArray:  val_36 > val_2 ? this : other + 16, sourceIndex:  0, destinationArray:  val_12, destinationIndex:  val_9, length:  val_37);
            var val_31 = 0;
            val_38 = val_9 << 1;
            do
            {
                int val_14 = val_38 + val_31;
                mem2[0] = val_14;
                if(((0 + 2) & 1) == 0)
            {
                    long val_16 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_12, xOff:  val_14 >> 1, z:  val_12, zOff:  val_14, count:  val_9, shift:  1);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.LongArray.Add(x:  val_12, xOff:  val_9, y:  val_12, yOff:  val_9 + val_31, z:  val_12, zOff:  val_14, count:  val_9);
            }
            
                val_39 = 0 + 1;
                val_31 = val_31 + val_9;
            }
            while(val_39 != 14);
            
            val_40 = val_38;
            long[] val_18 = new long[0];
            long val_19 = Org.BouncyCastle.Math.EC.LongArray.ShiftUp(x:  val_12, xOff:  0, z:  val_18, zOff:  0, count:  val_12.Length, shift:  4);
            var val_20 = val_40 << 3;
            long[] val_21 = new long[0];
            val_37 = val_21;
            if(val_5 != 0)
            {
                    var val_34 = 0;
                do
            {
                var val_22 = (val_36 > val_2 ? other : this + 16) + 0;
                var val_33 = (val_36 > val_2 ? other : this + 16 + 0) + 32;
                do
            {
                val_41 = val_10.Length;
                if((val_33 & 15) >= val_41)
            {
                    val_41 = val_10.Length;
            }
            
                val_39 = val_36[((ulong)(((val_36 > val_2 ? other : this + 16 + 0) + 32>>4) & 0xF)) << 2];
                Org.BouncyCastle.Math.EC.LongArray.AddBoth(x:  val_21, xOff:  0, y1:  val_12, y1Off:  val_36[(((val_36 > val_2 ? other : this + 16 + 0) + 32 & 15)) << 2], y2:  val_18, y2Off:  val_39, count:  val_9);
                val_40 = val_38;
                val_33 = val_33 >> 8;
                val_38 = val_34 + val_40;
            }
            while(val_33 != 0);
            
                val_34 = val_34 + 1;
            }
            while(val_34 != val_5);
            
            }
            
            val_34 = val_21.Length - val_40;
            val_42 = null;
            if(val_34 != 0)
            {
                    do
            {
                long val_27 = Org.BouncyCastle.Math.EC.LongArray.AddShiftedUp(x:  val_21, xOff:  (val_21.Length - (val_40 << 1)) + 0, y:  val_21, yOff:  val_34 + 0, count:  val_40, shift:  8);
                val_36 = 0 - val_40;
                val_42 = null;
            }
            while((val_34 + val_36) != 0);
            
            }
            
            val_35 = new Org.BouncyCastle.Math.EC.LongArray();
            val_43 = val_37;
            val_44 = 0;
            val_45 = val_40;
            goto label_41;
            label_8:
            long[] val_29 = new long[0];
            val_36 = val_29;
            val_34 = 1152921505514991616;
            Org.BouncyCastle.Math.EC.LongArray.MultiplyWord(a:  val_36 > val_2 ? other : this + 16 + 32, b:  val_36 > val_2 ? this : other + 16, bLen:  val_37, c:  val_29, cOff:  0);
            Org.BouncyCastle.Math.EC.LongArray val_30 = null;
            val_35 = val_30;
            val_43 = val_36;
            val_44 = 0;
            val_45 = val_38;
            label_41:
            val_30 = new Org.BouncyCastle.Math.EC.LongArray(ints:  val_29, off:  0, len:  val_45);
            return (Org.BouncyCastle.Math.EC.LongArray)val_35;
        }
        public void Reduce(int m, int[] ks)
        {
            int val_1 = Org.BouncyCastle.Math.EC.LongArray.ReduceInPlace(buf:  this.m_ints, off:  0, len:  this.m_ints.Length, m:  m, ks:  ks);
            if(val_1 >= this.m_ints.Length)
            {
                    return;
            }
            
            long[] val_2 = new long[0];
            this.m_ints = val_2;
            System.Array.Copy(sourceArray:  this.m_ints, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  val_1);
        }
        private static Org.BouncyCastle.Math.EC.LongArray ReduceResult(long[] buf, int off, int len, int m, int[] ks)
        {
            return (Org.BouncyCastle.Math.EC.LongArray)new Org.BouncyCastle.Math.EC.LongArray(ints:  buf, off:  off, len:  Org.BouncyCastle.Math.EC.LongArray.ReduceInPlace(buf:  buf, off:  off, len:  len, m:  m, ks:  ks));
        }
        private static int ReduceInPlace(long[] buf, int off, int len, int m, int[] ks)
        {
            System.Int32[] val_19;
            int val_20;
            int val_21;
            var val_22;
            int val_23;
            var val_24;
            var val_25;
            int val_26;
            var val_27;
            var val_28;
            int val_29;
            val_20 = len;
            val_21 = off;
            val_22 = (m + 63) >> 6;
            if(val_22 > val_20)
            {
                    val_22 = val_20;
                return (int)val_22;
            }
            
            int val_2 = val_20 << 6;
            val_23 = System.Math.Min(val1:  val_2, val2:  (m << 1) - 1);
            val_24 = val_2 - val_23;
            if(val_24 >= 64)
            {
                    int val_6 = val_2 - 64;
                val_6 = val_6 - val_23;
                val_20 = (val_20 - 1) - (val_6 >> 6);
                val_24 = val_6 & 63;
            }
            
            if(ks != null)
            {
                    val_25 = ks;
                val_26 = ks.Length;
                val_27 = val_26;
            }
            else
            {
                    val_25 = 24;
                val_27 = 28563616;
                val_26 = 28563616;
            }
            
            var val_8 = val_27 - 2;
            if(28563615 >= val_26)
            {
                    System.Int32[] val_18 = ks;
                val_18 = val_18 + (((long)(int)((val_27 - 2))) << 2);
                val_28 = mem[(ks + ((long)(int)((val_27 - 2))) << 2) + 32];
                val_28 = (ks + ((long)(int)((val_27 - 2))) << 2) + 32;
            }
            else
            {
                    val_28 = 0;
            }
            
            int val_10 = System.Math.Max(val1:  m, val2:  ks[114254460] + 64);
            val_10 = val_23 - val_10;
            val_21 = ((System.Math.Min(val1:  val_10, val2:  m - val_28)) + val_24) >> 6;
            if(val_21 < 2)
            {
                    val_19 = ks;
                val_29 = val_21;
            }
            else
            {
                    val_23 = val_20 - val_21;
                val_29 = val_21;
                val_19 = ks;
                Org.BouncyCastle.Math.EC.LongArray.ReduceVectorWise(buf:  buf, off:  val_29, len:  val_20, words:  val_23, m:  m, ks:  val_19);
                if(val_20 > val_23)
            {
                    var val_19 = val_29;
                val_19 = val_20 + val_19;
                var val_20 = (long)val_20;
                int val_15 = val_19 - 1;
                do
            {
                val_20 = val_20 - 1;
                val_21 = val_15 - 1;
                buf[(long)val_15] = 0;
            }
            while(val_20 > (long)val_23);
            
                val_29 = val_21;
                val_19 = ks;
                val_20 = (val_20 - 1) - (val_21 - 1);
            }
            
                val_23 = val_23 << 6;
            }
            
            if(val_23 > val_10)
            {
                    val_23 = val_10;
                Org.BouncyCastle.Math.EC.LongArray.ReduceWordWise(buf:  buf, off:  val_29, len:  val_20, toBit:  val_23, m:  m, ks:  val_19);
            }
            
            if(val_23 <= m)
            {
                    return (int)val_22;
            }
            
            Org.BouncyCastle.Math.EC.LongArray.ReduceBitWise(buf:  buf, off:  val_29, BitLength:  val_23, m:  m, ks:  val_19);
            return (int)val_22;
        }
        private static void ReduceBitWise(long[] buf, int off, int BitLength, int m, int[] ks)
        {
            int val_2 = BitLength - 1;
            if(val_2 < m)
            {
                    return;
            }
            
            do
            {
                if((Org.BouncyCastle.Math.EC.LongArray.TestBit(buf:  buf, off:  off, n:  val_2 = BitLength - 1)) != false)
            {
                    Org.BouncyCastle.Math.EC.LongArray.ReduceBit(buf:  buf, off:  off, bit:  val_2, m:  m, ks:  ks);
            }
            
                val_2 = val_2 - 1;
            }
            while(val_2 >= m);
        
        }
        private static void ReduceBit(long[] buf, int off, int bit, int m, int[] ks)
        {
            int val_5;
            int val_6;
            var val_7;
            int val_3 = m;
            val_5 = bit;
            Org.BouncyCastle.Math.EC.LongArray.FlipBit(buf:  buf, off:  off, n:  val_5);
            val_3 = val_5 - val_3;
            int val_1 = ks.Length - 1;
            if((val_1 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_6 = ks.Length & 4294967295;
            val_5 = (long)val_1;
            val_7 = ks.Length - 2;
            goto label_5;
            label_9:
            val_6 = ks.Length;
            val_5 = val_5 - 1;
            val_7 = val_7 - 1;
            label_5:
            Org.BouncyCastle.Math.EC.LongArray.FlipBit(buf:  buf, off:  off, n:  (ks[(((long)(int)((ks.Length - 1)) - 1)) << 2]) + val_3);
            if((val_7 & 2147483648) == 0)
            {
                goto label_9;
            }
            
            label_4:
            Org.BouncyCastle.Math.EC.LongArray.FlipBit(buf:  buf, off:  off, n:  val_3);
        }
        private static void ReduceWordWise(long[] buf, int off, int len, int toBit, int m, int[] ks)
        {
            int val_11;
            var val_12;
            long val_13;
            val_11 = toBit;
            int val_8 = len;
            int val_1 = val_8 - 1;
            int val_2 = val_11 >> 6;
            if(val_1 > (val_11 >> 6))
            {
                    val_8 = (val_8 << 6) - 64;
                do
            {
                long val_9 = buf[(long)off + val_1];
                if(val_9 != 0)
            {
                    mem2[0] = 0;
                Org.BouncyCastle.Math.EC.LongArray.ReduceWord(buf:  buf, off:  off, bit:  val_8, word:  val_9, m:  m, ks:  ks);
            }
            
                val_1 = val_1 - 1;
                val_8 = val_8 - 64;
            }
            while(val_1 > val_2);
            
                val_11 = val_11;
                val_12 = val_11 & 63;
            }
            else
            {
                    val_12 = val_11 & 63;
            }
            
            val_13 = buf[(long)val_2 + off];
            long val_6 = val_13 >> val_12;
            if(val_6 == 0)
            {
                    return;
            }
            
            if(((long)val_2 + off) >= buf.Length)
            {
                    val_13 = mem[buf[(long)(int)(((toBit >> 6) + off))] + 32];
                val_13 = buf[(long)(int)(((toBit >> 6) + off))] + 32;
            }
            
            val_13 = val_13 ^ (val_6 << val_12);
            mem2[0] = val_13;
            Org.BouncyCastle.Math.EC.LongArray.ReduceWord(buf:  buf, off:  off, bit:  val_11, word:  val_6, m:  m, ks:  ks);
        }
        private static void ReduceWord(long[] buf, int off, int bit, long word, int m, int[] ks)
        {
            var val_5;
            int val_6;
            var val_7;
            int val_3 = m;
            val_3 = bit - val_3;
            int val_1 = ks.Length - 1;
            if((val_1 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_6 = ks.Length & 4294967295;
            val_7 = (long)val_1;
            val_5 = ks.Length - 2;
            goto label_3;
            label_7:
            val_6 = ks.Length;
            val_7 = val_7 - 1;
            val_5 = val_5 - 1;
            label_3:
            Org.BouncyCastle.Math.EC.LongArray.FlipWord(buf:  buf, off:  off, bit:  (ks[(((long)(int)((ks.Length - 1)) - 1)) << 2]) + val_3, word:  word);
            if((val_5 & 2147483648) == 0)
            {
                goto label_7;
            }
            
            label_2:
            Org.BouncyCastle.Math.EC.LongArray.FlipWord(buf:  buf, off:  off, bit:  val_3, word:  word);
        }
        private static void ReduceVectorWise(long[] buf, int off, int len, int words, int m, int[] ks)
        {
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            int val_6 = m;
            val_8 = words << 6;
            val_6 = val_8 - val_6;
            int val_1 = ks.Length - 1;
            if((val_1 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_8 = 1152921505514991616;
            val_9 = ks.Length & 4294967295;
            val_10 = (long)val_1;
            val_11 = ks.Length - 2;
            goto label_3;
            label_7:
            val_9 = ks.Length;
            val_10 = val_10 - 1;
            val_11 = val_11 - 1;
            label_3:
            ks = (ks[(((long)(int)((ks.Length - 1)) - 1)) << 2]) + val_6;
            Org.BouncyCastle.Math.EC.LongArray.FlipVector(x:  buf, xOff:  off, y:  buf, yOff:  words + off, yLen:  len - words, bits:  ks);
            if((val_11 & 2147483648) == 0)
            {
                goto label_7;
            }
            
            label_2:
            Org.BouncyCastle.Math.EC.LongArray.FlipVector(x:  buf, xOff:  off, y:  buf, yOff:  words + off, yLen:  len - words, bits:  val_6);
        }
        private static void FlipVector(long[] x, int xOff, long[] y, int yOff, int yLen, int bits)
        {
            int val_3 = bits;
            int val_1 = val_3 & 63;
            val_3 = xOff + (val_3 >> 6);
            if(val_1 != 0)
            {
                    xOff = val_3 + 1;
                bits = 64 - val_1;
                long val_4 = x[(long)val_3];
                val_4 = val_4 ^ (Org.BouncyCastle.Math.EC.LongArray.AddShiftedDown(x:  x, xOff:  xOff, y:  y, yOff:  yOff, count:  yLen, shift:  bits));
                x[(long)val_3] = val_4;
                return;
            }
            
            Org.BouncyCastle.Math.EC.LongArray.Add(x:  x, xOff:  val_3, y:  y, yOff:  yOff, count:  yLen);
        }
        public Org.BouncyCastle.Math.EC.LongArray ModSquare(int m, int[] ks)
        {
            int val_9;
            System.Int32[] val_10;
            var val_11;
            long val_12;
            val_10 = ks;
            val_11 = this;
            int val_1 = this.GetUsedLength();
            if(val_1 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_11;
            }
            
            val_12 = val_1 << 1;
            long[] val_2 = new long[0];
            val_10 = val_2;
            if(val_12 >= 1)
            {
                    var val_11 = 0;
                var val_10 = 0;
                do
            {
                long val_9 = this.m_ints[val_11];
                val_10[val_10] = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_9);
                val_12 = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_9 >> 32);
                val_10 = (val_10 + 1) + 1;
                val_11 = val_11 + 1;
                val_10[val_10] = val_12;
            }
            while(val_10 < (long)val_12);
            
            }
            
            val_9 = Org.BouncyCastle.Math.EC.LongArray.ReduceInPlace(buf:  val_2, off:  0, len:  val_2.Length, m:  m, ks:  val_10);
            Org.BouncyCastle.Math.EC.LongArray val_8 = null;
            val_11 = val_8;
            val_8 = new Org.BouncyCastle.Math.EC.LongArray(ints:  val_2, off:  0, len:  val_9);
            return (Org.BouncyCastle.Math.EC.LongArray)val_11;
        }
        public Org.BouncyCastle.Math.EC.LongArray ModSquareN(int n, int m, int[] ks)
        {
            System.Array val_7;
            var val_8;
            var val_9;
            int val_10;
            var val_11;
            val_8 = n;
            val_9 = this;
            val_10 = this.GetUsedLength();
            if(val_10 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_9;
            }
            
            int val_2 = m + 63;
            val_2 = val_2 >> 6;
            int val_3 = val_2 << 1;
            long[] val_4 = new long[0];
            val_7 = val_4;
            System.Array.Copy(sourceArray:  this.m_ints, sourceIndex:  0, destinationArray:  val_4, destinationIndex:  0, length:  val_10);
            val_8 = val_8 - 1;
            val_11 = null;
            if((val_8 & 2147483648) == 0)
            {
                    do
            {
                Org.BouncyCastle.Math.EC.LongArray.SquareInPlace(x:  val_4, xLen:  val_10, m:  845219024, ks:  0);
                val_11 = null;
                val_8 = val_8 - 1;
                val_10 = Org.BouncyCastle.Math.EC.LongArray.ReduceInPlace(buf:  val_4, off:  0, len:  val_4.Length, m:  m, ks:  ks);
            }
            while((val_8 & 2147483648) == 0);
            
            }
            
            Org.BouncyCastle.Math.EC.LongArray val_6 = null;
            val_9 = val_6;
            val_6 = new Org.BouncyCastle.Math.EC.LongArray(ints:  val_4, off:  0, len:  val_10);
            return (Org.BouncyCastle.Math.EC.LongArray)val_9;
        }
        public Org.BouncyCastle.Math.EC.LongArray Square(int m, int[] ks)
        {
            var val_8;
            long val_9;
            val_8 = this;
            int val_1 = this.GetUsedLength();
            if(val_1 == 0)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_8;
            }
            
            val_9 = val_1 << 1;
            long[] val_2 = new long[0];
            if(val_9 >= 1)
            {
                    var val_10 = 0;
                var val_9 = 0;
                do
            {
                long val_8 = this.m_ints[val_10];
                val_2[val_9] = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_8);
                val_9 = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_8 >> 32);
                val_9 = (val_9 + 1) + 1;
                val_10 = val_10 + 1;
                val_2[val_9] = val_9;
            }
            while(val_9 < (long)val_9);
            
            }
            
            Org.BouncyCastle.Math.EC.LongArray val_7 = null;
            val_8 = val_7;
            val_7 = new Org.BouncyCastle.Math.EC.LongArray(ints:  val_2, off:  0, len:  val_2.Length);
            return (Org.BouncyCastle.Math.EC.LongArray)val_8;
        }
        private static void SquareInPlace(long[] x, int xLen, int m, int[] ks)
        {
            var val_8;
            int val_1 = xLen - 1;
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            var val_9 = (long)val_1;
            int val_3 = (xLen << 1) - 1;
            do
            {
                long val_8 = x[val_9];
                x[(long)val_3] = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_8 >> 32);
                val_8 = (long)val_3 - 1;
                val_9 = val_9 - 1;
                val_3 = val_3 - 2;
                x[val_8] = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_8);
            }
            while((val_9 & 2147483648) == 0);
        
        }
        private static void Interleave(long[] x, int xOff, long[] z, int zOff, int count, int width)
        {
            var val_3;
            if(width == 7)
            {
                goto label_1;
            }
            
            if(width == 5)
            {
                goto label_2;
            }
            
            if(width != 3)
            {
                goto label_3;
            }
            
            Org.BouncyCastle.Math.EC.LongArray.Interleave3(x:  x, xOff:  xOff, z:  z, zOff:  zOff, count:  count);
            return;
            label_1:
            Org.BouncyCastle.Math.EC.LongArray.Interleave7(x:  x, xOff:  xOff, z:  z, zOff:  zOff, count:  count);
            return;
            label_2:
            Org.BouncyCastle.Math.EC.LongArray.Interleave5(x:  x, xOff:  xOff, z:  z, zOff:  zOff, count:  count);
            return;
            label_3:
            val_3 = null;
            val_3 = null;
            System.Byte[] val_1 = Org.BouncyCastle.Math.EC.LongArray.BitLengths + (long)width;
            Org.BouncyCastle.Math.EC.LongArray.Interleave2_n(x:  x, xOff:  xOff, z:  z, zOff:  zOff, count:  count, rounds:  ((Org.BouncyCastle.Math.EC.LongArray.BitLengths + (long)(int)(width)) + 32) - 1);
        }
        private static void Interleave3(long[] x, int xOff, long[] z, int zOff, int count)
        {
            long val_2;
            var val_3;
            var val_4;
            val_2 = count;
            val_3 = zOff;
            val_4 = xOff;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_3 = val_2;
            do
            {
                val_2 = Org.BouncyCastle.Math.EC.LongArray.Interleave3(x:  x[(long)val_4]);
                val_3 = val_3 + 1;
                val_3 = val_3 - 1;
                val_4 = val_4 + 1;
                z[(long)val_3] = val_2;
            }
            while(val_3 != 0);
        
        }
        private static long Interleave3(long x)
        {
            long val_3 = Org.BouncyCastle.Math.EC.LongArray.Interleave3_21to63(x:  (ulong)(x >> 21) & 2097151);
            long val_4 = Org.BouncyCastle.Math.EC.LongArray.Interleave3_21to63(x:  (ulong)(x >> 42) & 2097151);
            long val_5 = x & (-9223372036854775808);
            val_5 = (Org.BouncyCastle.Math.EC.LongArray.Interleave3_21to63(x:  x & 2097151)) | val_5;
            val_5 = val_5 | ((val_3) << 1);
            return (long)val_5 | ((val_4) << 2);
        }
        private static long Interleave3_21to63(int x)
        {
            var val_7;
            int val_7 = x;
            val_7 = null;
            val_7 = null;
            int val_1 = val_7 & 127;
            System.Int32[] val_2 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE + (((x & 127)) << 2);
            System.Int32[] val_3 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE + (((uint)((x>>7) & 0x7F)) << 2);
            val_7 = val_7 >> 14;
            System.Int32[] val_4 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE + (((x >> 14)) << 2);
            return (long)(((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE + ((x & 127)) << 2) + 32) | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE + ((uint)((x>>7) & 0x7F)) << 2) + 32) << 21)) | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE + ((x >> 14)) << 2) + 32) << 42);
        }
        private static void Interleave5(long[] x, int xOff, long[] z, int zOff, int count)
        {
            long val_2;
            var val_3;
            var val_4;
            val_2 = count;
            val_3 = zOff;
            val_4 = xOff;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_3 = val_2;
            do
            {
                val_2 = Org.BouncyCastle.Math.EC.LongArray.Interleave5(x:  x[(long)val_4]);
                val_3 = val_3 + 1;
                val_3 = val_3 - 1;
                val_4 = val_4 + 1;
                z[(long)val_3] = val_2;
            }
            while(val_3 != 0);
        
        }
        private static long Interleave5(long x)
        {
            long val_3 = Org.BouncyCastle.Math.EC.LongArray.Interleave3_13to65(x:  (uint)(x >> 13) & 8191);
            long val_4 = Org.BouncyCastle.Math.EC.LongArray.Interleave3_13to65(x:  (ulong)(x >> 26) & 8191);
            long val_5 = Org.BouncyCastle.Math.EC.LongArray.Interleave3_13to65(x:  (ulong)(x >> 39) & 8191);
            long val_7 = Org.BouncyCastle.Math.EC.LongArray.Interleave3_13to65(x:  x >> 52);
            long val_8 = (Org.BouncyCastle.Math.EC.LongArray.Interleave3_13to65(x:  x & 8191)) | ((val_3) << 1);
            val_8 = val_8 | ((val_4) << 2);
            val_8 = val_8 | ((val_5) << 3);
            return (long)val_8 | ((val_7) << 4);
        }
        private static long Interleave3_13to65(int x)
        {
            var val_4;
            int val_4 = x;
            val_4 = null;
            val_4 = null;
            int val_1 = val_4 & 127;
            System.Int32[] val_2 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE5_TABLE + (((x & 127)) << 2);
            val_4 = val_4 >> 7;
            System.Int32[] val_3 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE5_TABLE + (((x >> 7)) << 2);
            return (long)(Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE5_TABLE + ((x & 127)) << 2) + 32;
        }
        private static void Interleave7(long[] x, int xOff, long[] z, int zOff, int count)
        {
            long val_2;
            var val_3;
            var val_4;
            val_2 = count;
            val_3 = zOff;
            val_4 = xOff;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_3 = val_2;
            do
            {
                val_2 = Org.BouncyCastle.Math.EC.LongArray.Interleave7(x:  x[(long)val_4]);
                val_3 = val_3 + 1;
                val_3 = val_3 - 1;
                val_4 = val_4 + 1;
                z[(long)val_3] = val_2;
            }
            while(val_3 != 0);
        
        }
        private static long Interleave7(long x)
        {
            null = null;
            long val_1 = x & 511;
            System.Int64[] val_2 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((x & 511)) << 3);
            System.Int64[] val_3 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((ulong)((x>>9) & 0x1FF)) << 3);
            System.Int64[] val_4 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((ulong)((x>>18) & 0x1FF)) << 3);
            System.Int64[] val_5 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((ulong)((x>>27) & 0x1FF)) << 3);
            System.Int64[] val_6 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((ulong)((x>>36) & 0x1FF)) << 3);
            System.Int64[] val_7 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((ulong)((x>>45) & 0x1FF)) << 3);
            long val_8 = x & (-9223372036854775808);
            val_8 = ((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((x & 511)) << 3) + 32) | val_8;
            val_8 = val_8 | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((ulong)((x>>9) & 0x1FF)) << 3) + 32) << 1);
            val_8 = val_8 | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((ulong)((x>>18) & 0x1FF)) << 3) + 32) << 2);
            System.Int64[] val_9 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + (((ulong)((x>>54) & 0x1FF)) << 3);
            val_8 = val_8 | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((ulong)((x>>27) & 0x1FF)) << 3) + 32) << 3);
            val_8 = val_8 | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((ulong)((x>>36) & 0x1FF)) << 3) + 32) << 4);
            val_8 = val_8 | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((ulong)((x>>45) & 0x1FF)) << 3) + 32) << 5);
            return (long)val_8 | (((Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE + ((ulong)((x>>54) & 0x1FF)) << 3) + 32) << 6);
        }
        private static void Interleave2_n(long[] x, int xOff, long[] z, int zOff, int count, int rounds)
        {
            var val_2;
            int val_3 = zOff;
            int val_4 = xOff;
            if(count < 1)
            {
                    return;
            }
            
            do
            {
                val_3 = val_3 + 1;
                val_2 = count - 1;
                val_4 = val_4 + 1;
                z[(long)val_3] = Org.BouncyCastle.Math.EC.LongArray.Interleave2_n(x:  x[(long)val_4], rounds:  rounds);
            }
            while(val_2 != 0);
        
        }
        private static long Interleave2_n(long x, int rounds)
        {
            var val_12;
            var val_13;
            int val_14;
            val_13 = rounds;
            val_14 = x;
            if(val_13 >= 2)
            {
                    int val_1 = val_13 + 2;
                do
            {
                val_12 = Org.BouncyCastle.Math.EC.LongArray.Interleave4_16to64(x:  val_14 & 65535);
                long val_4 = Org.BouncyCastle.Math.EC.LongArray.Interleave4_16to64(x:  (ulong)(val_14 >> 16) & 65535);
                long val_5 = Org.BouncyCastle.Math.EC.LongArray.Interleave4_16to64(x:  (ulong)(val_14 >> 32) & 65535);
                long val_7 = Org.BouncyCastle.Math.EC.LongArray.Interleave4_16to64(x:  val_14 >> 48);
                long val_8 = val_12 | ((val_4) << 1);
                val_1 = val_1 - 2;
                val_8 = val_8 | ((val_5) << 2);
                val_14 = val_8 | ((val_7) << 3);
            }
            while(val_1 > 3);
            
                val_13 = val_13 & 1;
            }
            
            if(val_13 != 1)
            {
                    return (long)val_14;
            }
            
            long val_11 = Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_14 >> 32);
            val_14 = (Org.BouncyCastle.Math.EC.LongArray.Interleave2_32to64(x:  val_14)) | ((val_11) << 1);
            return (long)val_14;
        }
        private static long Interleave4_16to64(int x)
        {
            var val_4;
            int val_4 = x;
            val_4 = null;
            val_4 = null;
            int val_1 = val_4 & 255;
            System.Int32[] val_2 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE4_TABLE + (((x & 255)) << 2);
            val_4 = val_4 >> 8;
            System.Int32[] val_3 = Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE4_TABLE + (((x >> 8)) << 2);
            return (long)(Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE4_TABLE + ((x & 255)) << 2) + 32;
        }
        private static long Interleave2_32to64(int x)
        {
            var val_6;
            int val_6 = x;
            val_6 = null;
            val_6 = null;
            int val_1 = val_6 & 255;
            string val_2 = Org.BouncyCastle.Math.EC.LongArray.ZEROES + (((x & 255)) << 1);
            string val_3 = Org.BouncyCastle.Math.EC.LongArray.ZEROES + (((uint)((x>>8) & 0xFF)) << 1);
            string val_4 = Org.BouncyCastle.Math.EC.LongArray.ZEROES + (((uint)((x>>16) & 0xFF)) << 1);
            val_6 = val_6 >> 24;
            string val_5 = Org.BouncyCastle.Math.EC.LongArray.ZEROES + (((x >> 24)) << 1);
            return (long)(Org.BouncyCastle.Math.EC.LongArray.ZEROES + ((x & 255)) << 1) + 32;
        }
        public Org.BouncyCastle.Math.EC.LongArray ModInverse(int m, int[] ks)
        {
            int val_12;
            var val_20;
            System.Int32[] val_21;
            var val_22;
            int val_23;
            var val_24;
            int val_25;
            var val_26;
            var val_27;
            int val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_21 = ks;
            int val_22 = m;
            val_22 = this;
            val_23 = this.Degree();
            if(val_23 == 1)
            {
                    return (Org.BouncyCastle.Math.EC.LongArray)val_22;
            }
            
            if(val_23 == 0)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Math.EC.LongArray val_2 = this.Copy();
            int val_4 = (val_22 + 63) >> 6;
            Org.BouncyCastle.Math.EC.LongArray.ReduceBit(buf:  (Org.BouncyCastle.Math.EC.LongArray)[1152921544109854992].m_ints, off:  0, bit:  val_22, m:  val_22, ks:  val_21);
            (Org.BouncyCastle.Math.EC.LongArray)[1152921544109895952].m_ints[0] = 1;
            Org.BouncyCastle.Math.EC.LongArray val_7 = new Org.BouncyCastle.Math.EC.LongArray(intLen:  val_4);
            val_24 = new int[2];
            val_25 = val_8.Length;
            if(val_25 == 0)
            {
                    val_25 = val_8.Length;
            }
            
            val_22 = val_22 + 1;
            val_24[0] = val_23;
            val_24[0] = val_22;
            val_26 = new Org.BouncyCastle.Math.EC.LongArray[2];
            val_26[0] = val_2;
            val_26[1] = new Org.BouncyCastle.Math.EC.LongArray(intLen:  val_4);
            int[] val_10 = new int[2];
            val_10[0] = 1;
            Org.BouncyCastle.Math.EC.LongArray[] val_11 = new Org.BouncyCastle.Math.EC.LongArray[2];
            val_11[0] = new Org.BouncyCastle.Math.EC.LongArray(intLen:  val_4);
            mem[1152921544109953384] = val_7;
            int val_23 = val_24[0];
            val_27 = mem[1152921544109949268];
            val_28 = val_23 - val_24[0];
            goto label_29;
            label_50:
            val_29 = val_8.Length;
            Org.BouncyCastle.Math.EC.LongArray val_25 = val_26[(mem[1152921544109949268]) << 2];
            if(1 >= val_29)
            {
                    val_29 = val_8.Length;
            }
            
            Org.BouncyCastle.Math.EC.LongArray[] val_27 = val_11;
            val_27 = val_27 + ((mem[1152921544109949268]) << 3);
            val_24[val_2].AddShiftedByBitsSafe(other:  (val_11 + (mem[1152921544109949268]) << 3) + 32, otherDegree:  val_25, bits:  val_28);
            val_30 = val_25 + val_28;
            val_24 = val_7;
            val_26 = val_23;
            if(val_30 <= val_12)
            {
                    if(val_30 == val_12)
            {
                    val_30 = val_8[val_2] + 32;
                int val_13 = val_30.DegreeFrom(limit:  val_12);
            }
            else
            {
                    val_30 = val_12;
            }
            
            }
            
            int val_28 = val_23;
            val_31 = val_30;
            val_28 = val_28 - val_28;
            val_32 = val_28 + 1152921505514991616;
            label_29:
            if((val_32 & 2147483648) != 0)
            {
                    Org.BouncyCastle.Math.EC.LongArray val_14 = val_24 + 4;
                mem2[0] = 1152921505514991616;
                System.Int32[] val_29 = val_10;
                val_20 = 1 - 1;
                val_29 = val_29 + 4;
                mem2[0] = val_31;
                val_21 = -val_32;
                System.Int32[] val_30 = val_10;
                val_30 = val_30 + (((long)(int)((1 - 1))) << 2);
                val_33 = mem[(val_10 + ((long)(int)((1 - 1))) << 2) + 32];
                val_33 = (val_10 + ((long)(int)((1 - 1))) << 2) + 32;
            }
            
            val_12 = val_33;
            val_34 = mem[val_1 + 24];
            val_34 = val_1 + 24;
            if(val_20 >= val_34)
            {
                    val_34 = mem[val_1 + 24];
                val_34 = val_1 + 24;
            }
            
            int val_16 = val_26 + (((long)(int)((1 - 1))) << 3);
            var val_31 = 1;
            val_31 = val_31 - val_20;
            int val_17 = val_26 + (((long)(int)((1 - (1 - 1)))) << 3);
            val_23 = val_26;
            Org.BouncyCastle.Math.EC.LongArray val_18 = val_24 + (((long)(int)((1 - (1 - 1)))) << 2);
            (val_1 + ((long)(int)((1 - 1))) << 3) + 32.AddShiftedByBitsSafe(other:  (val_1 + ((long)(int)((1 - (1 - 1)))) << 3) + 32, otherDegree:  848384272, bits:  val_21);
            if(((val_1 + ((long)(int)((1 - 1))) << 3) + 32.DegreeFrom(limit:  val_24 + (((long)(int)((1 - 1))) << 2))) != 0)
            {
                goto label_50;
            }
            
            Org.BouncyCastle.Math.EC.LongArray[] val_20 = val_11 + (((long)(int)((1 - (1 - 1)))) << 3);
            val_22 = mem[(val_11 + ((long)(int)((1 - (1 - 1)))) << 3) + 32];
            val_22 = (val_11 + ((long)(int)((1 - (1 - 1)))) << 3) + 32;
            return (Org.BouncyCastle.Math.EC.LongArray)val_22;
            label_2:
            System.InvalidOperationException val_21 = new System.InvalidOperationException();
        }
        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                
            }
        
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.LongArray other)
        {
            var val_3;
            var val_4;
            if(this == other)
            {
                goto label_3;
            }
            
            if(other == null)
            {
                goto label_8;
            }
            
            val_3 = this.GetUsedLength();
            if(other.GetUsedLength() != val_3)
            {
                goto label_8;
            }
            
            if(val_3 < 1)
            {
                goto label_3;
            }
            
            val_3 = (long)val_3;
            var val_7 = 4;
            label_9:
            var val_3 = val_7 - 4;
            if(this.m_ints[0] != other.m_ints[0])
            {
                goto label_8;
            }
            
            val_7 = val_7 + 1;
            if((val_7 - 3) < val_3)
            {
                goto label_9;
            }
            
            label_3:
            val_4 = 1;
            return (bool)val_4;
            label_8:
            val_4 = 0;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            var val_3;
            int val_1 = this.GetUsedLength();
            if(val_1 >= 1)
            {
                    var val_5 = 0;
                do
            {
                long val_2 = this.m_ints[val_5];
                var val_4 = 0;
                val_4 = val_4 - 1;
                val_5 = val_5 + 1;
                val_4 = val_4 ^ val_2;
                val_2 = val_4 << 5;
                val_4 = val_2 - val_4;
                val_3 = val_4 ^ this.m_ints[val_5];
            }
            while(val_1 != val_5);
            
                return (int)val_3;
            }
            
            val_3 = 1;
            return (int)val_3;
        }
        public Org.BouncyCastle.Math.EC.LongArray Copy()
        {
            .m_ints = Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.m_ints);
            return (Org.BouncyCastle.Math.EC.LongArray)new Org.BouncyCastle.Math.EC.LongArray();
        }
        public override string ToString()
        {
            var val_20;
            var val_21;
            string val_22;
            string val_23;
            var val_24;
            val_20 = this;
            val_21 = this.GetUsedLength();
            if(val_21 == 0)
            {
                    return "0";
            }
            
            System.Text.StringBuilder val_4 = null;
            val_22 = System.Convert.ToString(value:  this.m_ints[(long)val_21 - 1], toBase:  2);
            val_4 = new System.Text.StringBuilder(value:  val_22);
            int val_5 = val_21 - 2;
            if((val_5 & 2147483648) == 0)
            {
                    var val_22 = (long)val_5;
                do
            {
                val_23 = System.Convert.ToString(value:  this.m_ints[val_22], toBase:  2);
                int val_7 = val_23.Length;
                if(val_7 <= 63)
            {
                    System.Text.StringBuilder val_9 = val_4.Append(value:  Substring(startIndex:  val_7));
            }
            
                val_22 = val_23;
                System.Text.StringBuilder val_10 = val_4.Append(value:  val_22);
                val_22 = val_22 - 1;
            }
            while((val_22 & 2147483648) == 0);
            
            }
            
            val_20 = ???;
            val_24 = ???;
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        private static LongArray()
        {
            Org.BouncyCastle.Math.EC.LongArray.ZEROES = new ushort[256] {0, 1, 4, 5, 16, 17, 20, 21, 64, 65, 68, 69, 80, 81, 84, 85, 256, 257, 260, 261, 272, 273, 276, 277, 320, 321, 324, 325, 336, 337, 340, 341, 1024, 1025, 1028, 1029, 1040, 1041, 1044, 1045, 1088, 1089, 1092, 1093, 1104, 1105, 1108, 1109, 1280, 1281, 1284, 1285, 1296, 1297, 1300, 1301, 1344, 1345, 1348, 1349, 1360, 1361, 1364, 1365, 4096, 4097, 4100, 4101, 4112, 4113, 4116, 4117, 4160, 4161, 4164, 4165, 4176, 4177, 4180, 4181, 4352, 4353, 4356, 4357, 4368, 4369, 4372, 4373, 4416, 4417, 4420, 4421, 4432, 4433, 4436, 4437, 5120, 5121, 5124, 5125, 5136, 5137, 5140, 5141, 5184, 5185, 5188, 5189, 5200, 5201, 5204, 5205, 5376, 5377, 5380, 5381, 5392, 5393, 5396, 5397, 5440, 5441, 5444, 5445, 5456, 5457, 5460, 5461, 16384, 16385, 16388, 16389, 16400, 16401, 16404, 16405, 16448, 16449, 16452, 16453, 16464, 16465, 16468, 16469, 16640, 16641, 16644, 16645, 16656, 16657, 16660, 16661, 16704, 16705, 16708, 16709, 16720, 16721, 16724, 16725, 17408, 17409, 17412, 17413, 17424, 17425, 17428, 17429, 17472, 17473, 17476, 17477, 17488, 17489, 17492, 17493, 17664, 17665, 17668, 17669, 17680, 17681, 17684, 17685, 17728, 17729, 17732, 17733, 17744, 17745, 17748, 17749, 20480, 20481, 20484, 20485, 20496, 20497, 20500, 20501, 20544, 20545, 20548, 20549, 20560, 20561, 20564, 20565, 20736, 20737, 20740, 20741, 20752, 20753, 20756, 20757, 20800, 20801, 20804, 20805, 20816, 20817, 20820, 20821, 21504, 21505, 21508, 21509, 21520, 21521, 21524, 21525, 21568, 21569, 21572, 21573, 21584, 21585, 21588, 21589, 21760, 21761, 21764, 21765, 21776, 21777, 21780, 21781, 21824, 21825, 21828, 21829, 21840, 21841, 21844, 21845};
            Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE3_TABLE = new int[128] {0, 1, 8, 9, 64, 65, 72, 73, 512, 513, 520, 521, 576, 577, 584, 585, 4096, 4097, 4104, 4105, 4160, 4161, 4168, 4169, 4608, 4609, 4616, 4617, 4672, 4673, 4680, 4681, 32768, 32769, 32776, 32777, 32832, 32833, 32840, 32841, 33280, 33281, 33288, 33289, 33344, 33345, 33352, 33353, 36864, 36865, 36872, 36873, 36928, 36929, 36936, 36937, 37376, 37377, 37384, 37385, 37440, 37441, 37448, 37449, 262144, 262145, 262152, 262153, 262208, 262209, 262216, 262217, 262656, 262657, 262664, 262665, 262720, 262721, 262728, 262729, 266240, 266241, 266248, 266249, 266304, 266305, 266312, 266313, 266752, 266753, 266760, 266761, 266816, 266817, 266824, 266825, 294912, 294913, 294920, 294921, 294976, 294977, 294984, 294985, 295424, 295425, 295432, 295433, 295488, 295489, 295496, 295497, 299008, 299009, 299016, 299017, 299072, 299073, 299080, 299081, 299520, 299521, 299528, 299529, 299584, 299585, 299592, 299593};
            Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE4_TABLE = new int[256] {0, 1, 16, 17, 256, 257, 272, 273, 4096, 4097, 4112, 4113, 4352, 4353, 4368, 4369, 65536, 65537, 65552, 65553, 65792, 65793, 65808, 65809, 69632, 69633, 69648, 69649, 69888, 69889, 69904, 69905, 1048576, 1048577, 1048592, 1048593, 1048832, 1048833, 1048848, 1048849, 1052672, 1052673, 1052688, 1052689, 1052928, 1052929, 1052944, 1052945, 1114112, 1114113, 1114128, 1114129, 1114368, 1114369, 1114384, 1114385, 1118208, 1118209, 1118224, 1118225, 1118464, 1118465, 1118480, 1118481, 16777216, 16777217, 16777232, 16777233, 16777472, 16777473, 16777488, 16777489, 16781312, 16781313, 16781328, 16781329, 16781568, 16781569, 16781584, 16781585, 16842752, 16842753, 16842768, 16842769, 16843008, 16843009, 16843024, 16843025, 16846848, 16846849, 16846864, 16846865, 16847104, 16847105, 16847120, 16847121, 17825792, 17825793, 17825808, 17825809, 17826048, 17826049, 17826064, 17826065, 17829888, 17829889, 17829904, 17829905, 17830144, 17830145, 17830160, 17830161, 17891328, 17891329, 17891344, 17891345, 17891584, 17891585, 17891600, 17891601, 17895424, 17895425, 17895440, 17895441, 17895680, 17895681, 17895696, 17895697, 268435456, 268435457, 268435472, 268435473, 268435712, 268435713, 268435728, 268435729, 268439552, 268439553, 268439568, 268439569, 268439808, 268439809, 268439824, 268439825, 268500992, 268500993, 268501008, 268501009, 268501248, 268501249, 268501264, 268501265, 268505088, 268505089, 268505104, 268505105, 268505344, 268505345, 268505360, 268505361, 269484032, 269484033, 269484048, 269484049, 269484288, 269484289, 269484304, 269484305, 269488128, 269488129, 269488144, 269488145, 269488384, 269488385, 269488400, 269488401, 269549568, 269549569, 269549584, 269549585, 269549824, 269549825, 269549840, 269549841, 269553664, 269553665, 269553680, 269553681, 269553920, 269553921, 269553936, 269553937, 285212672, 285212673, 285212688, 285212689, 285212928, 285212929, 285212944, 285212945, 285216768, 285216769, 285216784, 285216785, 285217024, 285217025, 285217040, 285217041, 285278208, 285278209, 285278224, 285278225, 285278464, 285278465, 285278480, 285278481, 285282304, 285282305, 285282320, 285282321, 285282560, 285282561, 285282576, 285282577, 286261248, 286261249, 286261264, 286261265, 286261504, 286261505, 286261520, 286261521, 286265344, 286265345, 286265360, 286265361, 286265600, 286265601, 286265616, 286265617, 286326784, 286326785, 286326800, 286326801, 286327040, 286327041, 286327056, 286327057, 286330880, 286330881, 286330896, 286330897, 286331136, 286331137, 286331152, 286331153};
            Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE5_TABLE = new int[128] {0, 1, 32, 33, 1024, 1025, 1056, 1057, 32768, 32769, 32800, 32801, 33792, 33793, 33824, 33825, 1048576, 1048577, 1048608, 1048609, 1049600, 1049601, 1049632, 1049633, 1081344, 1081345, 1081376, 1081377, 1082368, 1082369, 1082400, 1082401, 33554432, 33554433, 33554464, 33554465, 33555456, 33555457, 33555488, 33555489, 33587200, 33587201, 33587232, 33587233, 33588224, 33588225, 33588256, 33588257, 34603008, 34603009, 34603040, 34603041, 34604032, 34604033, 34604064, 34604065, 34635776, 34635777, 34635808, 34635809, 34636800, 34636801, 34636832, 34636833, 1073741824, 1073741825, 1073741856, 1073741857, 1073742848, 1073742849, 1073742880, 1073742881, 1073774592, 1073774593, 1073774624, 1073774625, 1073775616, 1073775617, 1073775648, 1073775649, 1074790400, 1074790401, 1074790432, 1074790433, 1074791424, 1074791425, 1074791456, 1074791457, 1074823168, 1074823169, 1074823200, 1074823201, 1074824192, 1074824193, 1074824224, 1074824225, 1107296256, 1107296257, 1107296288, 1107296289, 1107297280, 1107297281, 1107297312, 1107297313, 1107329024, 1107329025, 1107329056, 1107329057, 1107330048, 1107330049, 1107330080, 1107330081, 1108344832, 1108344833, 1108344864, 1108344865, 1108345856, 1108345857, 1108345888, 1108345889, 1108377600, 1108377601, 1108377632, 1108377633, 1108378624, 1108378625, 1108378656, 1108378657};
            Org.BouncyCastle.Math.EC.LongArray.INTERLEAVE7_TABLE = new long[512] {0, 72057594037927936, -9223372036854775808, -9151314442816847872, 18014398509481984, 90071992547409920, -9205357638345293824, -9133300044307365888, 35184372088832, 72092778410016768, -9223336852482686976, -9151279258444759040, 18049582881570816, 90107176919498752, -9205322453973204992, -9133264859935277056, 68719476736, 72057662757404672, -9223371968135299072, -9151314374097371136, 18014467228958720, 90072061266886656, -9205357569625817088, -9133299975587889152, 35253091565568, 72092847129493504, -9223336783763210240, -9151279189725282304, 18049651601047552, 90107245638975488, -9205322385253728256, -9133264791215800320, 134217728, 72057594172145664, -9223372036720558080, -9151314442682630144, 18014398643699712, 90071992681627648, -9205357638211076096, -9133300044173148160, 35184506306560, 72092778544234496, -9223336852348469248, -9151279258310541312, 18049583015788544, 90107177053716480, -9205322453838987264, -9133264859801059328, 68853694464, 72057662891622400, -9223371968001081344, -9151314373963153408, 18014467363176448, 90072061401104384, -9205357569491599360, -9133299975453671424, 35253225783296, 72092847263711232, -9223336783628992512, -9151279189591064576, 18049651735265280, 90107245773193216, -9205322385119510528, -9133264791081582592, 262144, 72057594038190080, -9223372036854513664, -9151314442816585728, 18014398509744128, 90071992547672064, -9205357638345031680, -9133300044307103744, 35184372350976, 72092778410278912, -9223336852482424832, -9151279258444496896, 18049582881832960, 90107176919760896, -9205322453972942848, -9133264859935014912, 68719738880, 72057662757666816, -9223371968135036928, -9151314374097108992, 18014467229220864, 90072061267148800, -9205357569625554944, -9133299975587627008, 35253091827712, 72092847129755648, -9223336783762948096, -9151279189725020160, 18049651601309696, 90107245639237632, -9205322385253466112, -9133264791215538176, 134479872, 72057594172407808, -9223372036720295936, -9151314442682368000, 18014398643961856, 90071992681889792, -9205357638210813952, -9133300044172886016, 35184506568704, 72092778544496640, -9223336852348207104, -9151279258310279168, 18049583016050688, 90107177053978624, -9205322453838725120, -9133264859800797184, 68853956608, 72057662891884544, -9223371968000819200, -9151314373962891264, 18014467363438592, 90072061401366528, -9205357569491337216, -9133299975453409280, 35253226045440, 72092847263973376, -9223336783628730368, -9151279189590802432, 18049651735527424, 90107245773455360, -9205322385119248384, -9133264791081320448, 512, 72057594037928448, -9223372036854775296, -9151314442816847360, 18014398509482496, 90071992547410432, -9205357638345293312, -9133300044307365376, 35184372089344, 72092778410017280, -9223336852482686464, -9151279258444758528, 18049582881571328, 90107176919499264, -9205322453973204480, -9133264859935276544, 68719477248, 72057662757405184, -9223371968135298560, -9151314374097370624, 18014467228959232, 90072061266887168, -9205357569625816576, -9133299975587888640, 35253091566080, 72092847129494016, -9223336783763209728, -9151279189725281792, 18049651601048064, 90107245638976000, -9205322385253727744, -9133264791215799808, 134218240, 72057594172146176, -9223372036720557568, -9151314442682629632, 18014398643700224, 90071992681628160, -9205357638211075584, -9133300044173147648, 35184506307072, 72092778544235008, -9223336852348468736, -9151279258310540800, 18049583015789056, 90107177053716992, -9205322453838986752, -9133264859801058816, 68853694976, 72057662891622912, -9223371968001080832, -9151314373963152896, 18014467363176960, 90072061401104896, -9205357569491598848, -9133299975453670912, 35253225783808, 72092847263711744, -9223336783628992000, -9151279189591064064, 18049651735265792, 90107245773193728, -9205322385119510016, -9133264791081582080, 262656, 72057594038190592, -9223372036854513152, -9151314442816585216, 18014398509744640, 90071992547672576, -9205357638345031168, -9133300044307103232, 35184372351488, 72092778410279424, -9223336852482424320, -9151279258444496384, 18049582881833472, 90107176919761408, -9205322453972942336, -9133264859935014400, 68719739392, 72057662757667328, -9223371968135036416, -9151314374097108480, 18014467229221376, 90072061267149312, -9205357569625554432, -9133299975587626496, 35253091828224, 72092847129756160, -9223336783762947584, -9151279189725019648, 18049651601310208, 90107245639238144, -9205322385253465600, -9133264791215537664, 134480384, 72057594172408320, -9223372036720295424, -9151314442682367488, 18014398643962368, 90071992681890304, -9205357638210813440, -9133300044172885504, 35184506569216, 72092778544497152, -9223336852348206592, -9151279258310278656, 18049583016051200, 90107177053979136, -9205322453838724608, -9133264859800796672, 68853957120, 72057662891885056, -9223371968000818688, -9151314373962890752, 18014467363439104, 90072061401367040, -9205357569491336704, -9133299975453408768, 35253226045952, 72092847263973888, -9223336783628729856, -9151279189590801920, 18049651735527936, 90107245773455872, -9205322385119247872, -9133264791081319936, 1, 72057594037927937, -9223372036854775807, -9151314442816847871, 18014398509481985, 90071992547409921, -9205357638345293823, -9133300044307365887, 35184372088833, 72092778410016769, -9223336852482686975, -9151279258444759039, 18049582881570817, 90107176919498753, -9205322453973204991, -9133264859935277055, 68719476737, 72057662757404673, -9223371968135299071, -9151314374097371135, 18014467228958721, 90072061266886657, -9205357569625817087, -9133299975587889151, 35253091565569, 72092847129493505, -9223336783763210239, -9151279189725282303, 18049651601047553, 90107245638975489, -9205322385253728255, -9133264791215800319, 134217729, 72057594172145665, -9223372036720558079, -9151314442682630143, 18014398643699713, 90071992681627649, -9205357638211076095, -9133300044173148159, 35184506306561, 72092778544234497, -9223336852348469247, -9151279258310541311, 18049583015788545, 90107177053716481, -9205322453838987263, -9133264859801059327, 68853694465, 72057662891622401, -9223371968001081343, -9151314373963153407, 18014467363176449, 90072061401104385, -9205357569491599359, -9133299975453671423, 35253225783297, 72092847263711233, -9223336783628992511, -9151279189591064575, 18049651735265281, 90107245773193217, -9205322385119510527, -9133264791081582591, 262145, 72057594038190081, -9223372036854513663, -9151314442816585727, 18014398509744129, 90071992547672065, -9205357638345031679, -9133300044307103743, 35184372350977, 72092778410278913, -9223336852482424831, -9151279258444496895, 18049582881832961, 90107176919760897, -9205322453972942847, -9133264859935014911, 68719738881, 72057662757666817, -9223371968135036927, -9151314374097108991, 18014467229220865, 90072061267148801, -9205357569625554943, -9133299975587627007, 35253091827713, 72092847129755649, -9223336783762948095, -9151279189725020159, 18049651601309697, 90107245639237633, -9205322385253466111, -9133264791215538175, 134479873, 72057594172407809, -9223372036720295935, -9151314442682367999, 18014398643961857, 90071992681889793, -9205357638210813951, -9133300044172886015, 35184506568705, 72092778544496641, -9223336852348207103, -9151279258310279167, 18049583016050689, 90107177053978625, -9205322453838725119, -9133264859800797183, 68853956609, 72057662891884545, -9223371968000819199, -9151314373962891263, 18014467363438593, 90072061401366529, -9205357569491337215, -9133299975453409279, 35253226045441, 72092847263973377, -9223336783628730367, -9151279189590802431, 18049651735527425, 90107245773455361, -9205322385119248383, -9133264791081320447, 513, 72057594037928449, -9223372036854775295, -9151314442816847359, 18014398509482497, 90071992547410433, -9205357638345293311, -9133300044307365375, 35184372089345, 72092778410017281, -9223336852482686463, -9151279258444758527, 18049582881571329, 90107176919499265, -9205322453973204479, -9133264859935276543, 68719477249, 72057662757405185, -9223371968135298559, -9151314374097370623, 18014467228959233, 90072061266887169, -9205357569625816575, -9133299975587888639, 35253091566081, 72092847129494017, -9223336783763209727, -9151279189725281791, 18049651601048065, 90107245638976001, -9205322385253727743, -9133264791215799807, 134218241, 72057594172146177, -9223372036720557567, -9151314442682629631, 18014398643700225, 90071992681628161, -9205357638211075583, -9133300044173147647, 35184506307073, 72092778544235009, -9223336852348468735, -9151279258310540799, 18049583015789057, 90107177053716993, -9205322453838986751, -9133264859801058815, 68853694977, 72057662891622913, -9223371968001080831, -9151314373963152895, 18014467363176961, 90072061401104897, -9205357569491598847, -9133299975453670911, 35253225783809, 72092847263711745, -9223336783628991999, -9151279189591064063, 18049651735265793, 90107245773193729, -9205322385119510015, -9133264791081582079, 262657, 72057594038190593, -9223372036854513151, -9151314442816585215, 18014398509744641, 90071992547672577, -9205357638345031167, -9133300044307103231, 35184372351489, 72092778410279425, -9223336852482424319, -9151279258444496383, 18049582881833473, 90107176919761409, -9205322453972942335, -9133264859935014399, 68719739393, 72057662757667329, -9223371968135036415, -9151314374097108479, 18014467229221377, 90072061267149313, -9205357569625554431, -9133299975587626495, 35253091828225, 72092847129756161, -9223336783762947583, -9151279189725019647, 18049651601310209, 90107245639238145, -9205322385253465599, -9133264791215537663, 134480385, 72057594172408321, -9223372036720295423, -9151314442682367487, 18014398643962369, 90071992681890305, -9205357638210813439, -9133300044172885503, 35184506569217, 72092778544497153, -9223336852348206591, -9151279258310278655, 18049583016051201, 90107177053979137, -9205322453838724607, -9133264859800796671, 68853957121, 72057662891885057, -9223371968000818687, -9151314373962890751, 18014467363439105, 90072061401367041, -9205357569491336703, -9133299975453408767, 35253226045953, 72092847263973889, -9223336783628729855, -9151279189590801919, 18049651735527937, 90107245773455873, -9205322385119247871, -9133264791081319935};
            Org.BouncyCastle.Math.EC.LongArray.BitLengths = new byte[256] {0, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8};
        }
    
    }

}
