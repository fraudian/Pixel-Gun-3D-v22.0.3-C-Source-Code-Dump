using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT113Field
    {
        // Fields
        private const ulong M49 = 562949953421311;
        private const ulong M57 = 144115188075855871;
        
        // Methods
        public static void Add(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_5 = y;
            ulong val_1 = x[0];
            val_1 = val_5[0] ^ val_1;
            z[0] = val_1;
            val_5 = val_5[1] ^ x[1];
            z[1] = val_5;
        }
        public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
        {
            System.UInt64[] val_9 = yy;
            ulong val_1 = xx[0];
            val_1 = val_9[0] ^ val_1;
            zz[0] = val_1;
            ulong val_3 = xx[1];
            val_3 = val_9[1] ^ val_3;
            zz[1] = val_3;
            ulong val_5 = xx[2];
            val_5 = val_9[2] ^ val_5;
            zz[2] = val_5;
            val_9 = val_9[3] ^ xx[3];
            zz[3] = val_9;
        }
        public static void AddOne(ulong[] x, ulong[] z)
        {
            ulong val_1 = x[0];
            val_1 = val_1 ^ 1;
            z[0] = val_1;
            z[1] = x[1];
        }
        public static ulong[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.FromBigInteger64(x:  x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce15(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat128.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat128.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat128.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(x:  val_2, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(x:  val_2, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(x:  val_3, n:  7, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(x:  val_2, n:  14, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(x:  val_3, n:  28, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(x:  val_2, n:  56, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(x:  val_3, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_10;
            int val_11;
            System.UInt64[] val_14 = xx;
            val_10 = xx.Length;
            if(val_10 == 0)
            {
                    val_10 = xx.Length;
            }
            
            ulong val_10 = val_14[0];
            if(val_10 <= 1)
            {
                    val_10 = xx.Length;
            }
            
            if(val_10 <= 2)
            {
                    val_10 = xx.Length;
            }
            
            ulong val_12 = val_14[2];
            ulong val_13 = val_14[3];
            val_14 = (val_14[1] ^ ((xx[3]) << 24)) ^ ((xx[3]) << 15);
            val_13 = (val_12 ^ (val_13 >> 40)) ^ (val_13 >> 49);
            val_11 = z.Length;
            ulong val_7 = (val_13 << 24) ^ val_10;
            val_7 = val_7 ^ (val_13 << 15);
            val_7 = val_7 ^ (val_14 >> 49);
            val_10 = val_7 ^ (((((xx[1] ^ (xx[3]) << 24) ^ (xx[3]) << 15) >> 49)) << 9);
            if(val_11 == 0)
            {
                    val_11 = z.Length;
            }
            
            val_14 = ((val_12 >> 49) ^ (val_12 >> 40)) ^ (val_14 & 562949953421311);
            z[0] = val_10;
            z[1] = val_14;
        }
        public static void Reduce15(ulong[] z, int zOff)
        {
            int val_3;
            System.UInt64[] val_5 = z;
            val_3 = z.Length;
            int val_1 = zOff + 1;
            if(val_1 >= val_3)
            {
                    val_3 = z.Length;
            }
            
            ulong val_3 = val_5[(long)val_1];
            ulong val_2 = val_3 >> 49;
            ulong val_4 = val_5[(long)zOff];
            val_4 = 0 ^ val_4;
            val_5[(long)zOff] = val_4;
            val_5 = val_3 & 562949953421311;
            mem2[0] = val_5;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            int val_6;
            ulong val_8 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[0]);
            ulong val_9 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[1]);
            ulong val_3 = val_8 >> 32;
            val_6 = z.Length;
            val_8 = (val_8 ^ (((val_1 >> 32)) << 57)) ^ ((val_2) << 5);
            if(val_6 == 0)
            {
                    val_6 = z.Length;
            }
            
            val_9 = (val_9 >> 7) ^ (val_9 >> 59);
            z[0] = val_8;
            z[1] = val_9;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static uint Trace(ulong[] x)
        {
            x = x[0] & 1;
            return (uint)x;
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            int val_10;
            int val_11;
            int val_12;
            int val_13;
            System.UInt64[] val_12 = x;
            val_10 = x.Length;
            if(val_10 == 0)
            {
                    val_10 = x.Length;
            }
            
            ulong val_10 = val_12[0];
            ulong val_11 = val_12[1];
            val_12 = val_10 >> 57;
            val_11 = y.Length;
            if(val_11 == 0)
            {
                    val_11 = y.Length;
            }
            
            ulong val_13 = y[0];
            ulong val_14 = y[1];
            ulong val_1 = val_13 >> 57;
            val_13 = val_13 & 144115188075855871;
            ulong[] val_2 = new ulong[6];
            val_10 = val_10 & 144115188075855871;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMulw(x:  val_10, y:  val_13, z:  val_2, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMulw(x:  val_12, y:  val_1, z:  val_2, zOff:  2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMulw(x:  val_12 ^ val_10, y:  val_1 ^ val_13, z:  val_2, zOff:  4);
            val_12 = val_2.Length;
            if(val_12 <= 1)
            {
                    val_12 = val_2.Length;
            }
            
            ulong val_15 = val_2[1];
            if(val_12 <= 2)
            {
                    val_12 = val_2.Length;
            }
            
            if(val_12 == 0)
            {
                    val_12 = val_2.Length;
            }
            
            ulong val_17 = val_2[0];
            if(val_12 <= 3)
            {
                    val_12 = val_2.Length;
            }
            
            ulong val_18 = val_2[3];
            val_15 = val_2[2] ^ val_15;
            if(val_12 <= 4)
            {
                    val_12 = val_2.Length;
            }
            
            ulong val_19 = val_2[4];
            ulong val_20 = val_2[5];
            val_19 = val_17 ^ val_15 ^ val_19;
            val_15 = val_18 ^ val_15;
            val_13 = zz.Length;
            val_20 = val_15 ^ val_20;
            val_17 = val_17 ^ ((((val_2[0] ^ (val_2[2] ^ val_2[1])) ^ val_2[4])) << 57);
            if(val_13 == 0)
            {
                    val_13 = zz.Length;
            }
            
            zz[0] = val_17;
            if(val_13 <= 1)
            {
                    val_13 = zz.Length;
            }
            
            val_20 = (val_20 >> 14) ^ ((val_2[3]) << 43);
            zz[1] = (val_20 << 50) ^ (val_19 >> 7);
            if(val_13 <= 2)
            {
                    val_13 = zz.Length;
            }
            
            zz[2] = val_20;
            zz[3] = val_18 >> 21;
        }
        protected static void ImplMulw(ulong x, ulong y, ulong[] z, int zOff)
        {
            int val_18;
            ulong val_19;
            ulong val_20;
            ulong val_21;
            ulong val_22;
            int val_23;
            ulong[] val_1 = new ulong[8];
            val_18 = val_1.Length;
            if(val_18 <= 1)
            {
                    val_18 = val_1.Length;
            }
            
            val_19 = y;
            val_1[1] = y;
            if(val_18 <= 1)
            {
                    val_19 = val_1[1];
                val_18 = val_1.Length;
            }
            
            val_20 = val_19 << 1;
            if(val_18 <= 2)
            {
                    val_18 = val_1.Length;
            }
            
            val_1[2] = val_20;
            if(val_18 <= 2)
            {
                    val_20 = val_1[2];
                val_18 = val_1.Length;
            }
            
            if(val_18 <= 3)
            {
                    val_18 = val_1.Length;
            }
            
            val_1[3] = val_20 ^ y;
            if(val_18 <= 2)
            {
                    val_18 = val_1.Length;
            }
            
            val_21 = val_1[2] << 1;
            if(val_18 <= 4)
            {
                    val_18 = val_1.Length;
            }
            
            val_1[4] = val_21;
            if(val_18 <= 4)
            {
                    val_21 = val_1[4];
                val_18 = val_1.Length;
            }
            
            if(val_18 <= 5)
            {
                    val_18 = val_1.Length;
            }
            
            val_1[5] = val_21 ^ y;
            if(val_18 <= 3)
            {
                    val_18 = val_1.Length;
            }
            
            val_22 = val_1[3] << 1;
            if(val_18 <= 6)
            {
                    val_18 = val_1.Length;
            }
            
            val_1[6] = val_22;
            if(val_18 <= 6)
            {
                    val_22 = val_1[6];
                val_18 = val_1.Length;
            }
            
            val_22 = val_22 ^ y;
            if(val_18 <= 7)
            {
                    val_18 = val_1.Length;
            }
            
            val_1[7] = val_22;
            ulong val_18 = val_1[x & 7];
            var val_22 = 0;
            var val_23 = 16;
            do
            {
                val_23 = val_1.Length;
                var val_5 = 57 - 9;
                ulong val_6 = x >> val_5;
                ulong val_7 = val_6 & 7;
                if(val_7 >= val_23)
            {
                    val_23 = val_1.Length;
            }
            
                ulong val_19 = val_1[val_7];
                if(((ulong)(val_6 >> 3) & 7) >= val_23)
            {
                    val_23 = val_1.Length;
            }
            
                ulong val_20 = val_1[(ulong)(val_6 >> 3) & 7];
                ulong val_21 = val_1[(ulong)(val_6 >> 6) & 7];
                ulong val_8 = val_19 ^ ((val_1[(ulong)(((x >> (57 - 9))>>3) & 0x7)][0]) << 3);
                ulong val_9 = val_8 ^ ((val_1[(ulong)(((x >> (57 - 9))>>6) & 0x7)][0]) << 6);
                val_8 = val_9 << val_5;
                val_9 = val_9 >> val_23;
                val_18 = val_8 ^ val_18;
                val_22 = val_9 ^ val_22;
                val_23 = val_23 + 9;
            }
            while(val_5 > 9);
            
            ulong val_10 = y << 7;
            val_10 = x & (val_10 >> 63);
            val_19 = val_22 ^ ((val_10 & 72198606942111744) >> 8);
            System.UInt64[] val_13 = z + (((long)(int)(zOff)) << 3);
            mem2[0] = val_18 & 144115188075855871;
            int val_14 = zOff + 1;
            System.UInt64[] val_15 = z + (((long)(int)((zOff + 1))) << 3);
            mem2[0] = val_19;
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[1], z:  zz, zOff:  2);
        }
        public SecT113Field()
        {
        
        }
    
    }

}
