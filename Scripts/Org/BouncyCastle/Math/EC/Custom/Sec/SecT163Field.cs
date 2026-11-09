using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT163Field
    {
        // Fields
        private const ulong M35 = 34359738367;
        private const ulong M55 = 36028797018963967;
        private static readonly ulong[] ROOT_Z;
        
        // Methods
        public static void Add(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_7 = y;
            ulong val_1 = x[0];
            val_1 = val_7[0] ^ val_1;
            z[0] = val_1;
            ulong val_3 = x[1];
            val_3 = val_7[1] ^ val_3;
            z[1] = val_3;
            val_7 = val_7[2] ^ x[2];
            z[2] = val_7;
        }
        public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
        {
            System.UInt64[] val_13 = yy;
            ulong val_1 = xx[0];
            val_1 = val_13[0] ^ val_1;
            zz[0] = val_1;
            ulong val_3 = xx[1];
            val_3 = val_13[1] ^ val_3;
            zz[1] = val_3;
            ulong val_5 = xx[2];
            val_5 = val_13[2] ^ val_5;
            zz[2] = val_5;
            ulong val_7 = xx[3];
            val_7 = val_13[3] ^ val_7;
            zz[3] = val_7;
            ulong val_9 = xx[4];
            val_9 = val_13[4] ^ val_9;
            zz[4] = val_9;
            val_13 = val_13[5] ^ xx[5];
            zz[5] = val_13;
        }
        public static void AddOne(ulong[] x, ulong[] z)
        {
            ulong val_1 = x[0];
            val_1 = val_1 ^ 1;
            z[0] = val_1;
            z[1] = x[1];
            z[2] = x[2];
        }
        public static ulong[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.FromBigInteger64(x:  x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce29(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat192.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat192.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat192.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_2, n:  1, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_3, n:  1, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_2, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_3, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_2, n:  9, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_3, n:  9, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_2, n:  27, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_3, n:  27, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(x:  val_2, n:  81, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_2, y:  val_3, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_14;
            int val_15;
            System.UInt64[] val_20 = xx;
            val_14 = xx.Length;
            if(val_14 == 0)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_14 = val_20[0];
            if(val_14 <= 1)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 2)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 3)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_17 = val_20[3];
            if(val_14 <= 4)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_18 = val_20[4];
            ulong val_19 = val_20[5];
            ulong val_1 = val_20[2] ^ (val_18 >> 32);
            val_1 = val_1 ^ (val_18 >> 35);
            val_1 = val_1 ^ (val_18 >> 29);
            ulong val_2 = val_20[1] ^ ((xx[4]) << 32);
            val_1 = val_1 ^ (val_18 >> 28);
            ulong val_3 = val_17 ^ (val_19 >> 32);
            val_2 = val_2 ^ ((xx[4]) << 29);
            val_1 = val_1 ^ ((xx[5]) << 32);
            val_3 = val_3 ^ (val_19 >> 35);
            val_2 = val_2 ^ ((xx[4]) << 35);
            val_20 = val_1 ^ ((xx[5]) << 29);
            ulong val_4 = val_3 ^ (val_19 >> 29);
            val_2 = val_2 ^ ((xx[4]) << 36);
            ulong val_6 = val_4 ^ (val_19 >> 28);
            ulong val_7 = (val_20 ^ ((xx[5]) << 35)) ^ ((xx[5]) << 36);
            val_4 = val_2 ^ (val_6 >> 32);
            val_17 = val_6 << 29;
            ulong val_11 = val_4 ^ (val_6 >> 35);
            val_7 = (val_7 >> 35) ^ val_14;
            val_7 = val_7 ^ (((((((((((xx[2] ^ (xx[4]) >> 32) ^ (xx[4]) >> 35) ^ (xx[4]) >> 29) ^ (xx[4]) >> 28) ^ (xx[5]) << 32) ^ (xx[5]) << 29) ^ (xx[5]) << 35) ^ (xx[5]) << 36) >> 35)) << 3);
            val_7 = val_7 ^ (((((((((((xx[2] ^ (xx[4]) >> 32) ^ (xx[4]) >> 35) ^ (xx[4]) >> 29) ^ (xx[4]) >> 28) ^ (xx[5]) << 32) ^ (xx[5]) << 29) ^ (xx[5]) << 35) ^ (xx[5]) << 36) >> 35)) << 6);
            ulong val_13 = val_7 ^ (((((((((((xx[2] ^ (xx[4]) >> 32) ^ (xx[4]) >> 35) ^ (xx[4]) >> 29) ^ (xx[4]) >> 28) ^ (xx[5]) << 32) ^ (xx[5]) << 29) ^ (xx[5]) << 35) ^ (xx[5]) << 36) >> 35)) << 7);
            val_15 = z.Length;
            val_13 = val_13 ^ (val_6 << 32);
            val_13 = val_13 ^ val_17;
            val_13 = val_13 ^ (val_6 << 35);
            val_11 = val_11 ^ (val_6 >> 29);
            val_14 = val_13 ^ (val_6 << 36);
            if(val_15 == 0)
            {
                    val_15 = z.Length;
            }
            
            val_6 = val_11 ^ (val_6 >> 28);
            z[0] = val_14;
            if(val_15 <= 1)
            {
                    val_15 = z.Length;
            }
            
            val_20 = val_20 & 34359738367;
            z[1] = val_6;
            z[2] = val_20;
        }
        public static void Reduce29(ulong[] z, int zOff)
        {
            int val_3;
            System.UInt64[] val_6 = z;
            val_3 = z.Length;
            int val_1 = zOff + 2;
            if(val_1 >= val_3)
            {
                    val_3 = z.Length;
            }
            
            ulong val_3 = val_6[(long)val_1];
            ulong val_2 = val_3 >> 35;
            ulong val_4 = val_6[(long)zOff];
            var val_5 = 0;
            val_5 = val_5 ^ (((z[(long)(int)((zOff + 2))][0] >> 35)) << 6);
            val_5 = val_5 ^ (((z[(long)(int)((zOff + 2))][0] >> 35)) << 7);
            val_4 = val_5 ^ val_4;
            val_6[(long)zOff] = val_4;
            val_6 = val_3 & 34359738367;
            mem2[0] = val_6;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            var val_7;
            int val_8;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.Create64();
            val_1[0] = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[1]);
            ulong val_4 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[2]);
            val_1[1] = val_4 >> 32;
            val_7 = null;
            val_7 = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ROOT_Z, z:  z);
            val_8 = z.Length;
            if(val_8 == 0)
            {
                    val_8 = z.Length;
            }
            
            ulong val_10 = z[0];
            val_10 = val_10 ^ (Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[0]));
            z[0] = val_10;
            ulong val_11 = z[1];
            val_11 = val_11 ^ (val_4 & 4294967295);
            z[1] = val_11;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static uint Trace(ulong[] x)
        {
            int val_1 = x.Length;
            if(val_1 == 0)
            {
                    val_1 = x.Length;
            }
            
            ulong val_2 = x[2];
            val_2 = x[0] ^ (val_2 >> 29);
            x = val_2 & 1;
            return (uint)x;
        }
        protected static void ImplCompactExt(ulong[] zz)
        {
            int val_5 = zz.Length;
            if(val_5 == 0)
            {
                    val_5 = zz.Length;
            }
            
            ulong val_5 = zz[0];
            if(val_5 <= 1)
            {
                    val_5 = zz.Length;
            }
            
            ulong val_6 = zz[1];
            if(val_5 <= 2)
            {
                    val_5 = zz.Length;
            }
            
            ulong val_7 = zz[2];
            if(val_5 <= 3)
            {
                    val_5 = zz.Length;
            }
            
            ulong val_8 = zz[3];
            if(val_5 <= 4)
            {
                    val_5 = zz.Length;
            }
            
            ulong val_9 = zz[4];
            if(val_5 <= 5)
            {
                    val_5 = zz.Length;
            }
            
            ulong val_10 = zz[5];
            val_5 = val_5 ^ ((zz[1]) << 55);
            if(val_5 == 0)
            {
                    val_5 = zz.Length;
            }
            
            val_6 = (val_7 << 46) ^ (val_6 >> 9);
            zz[0] = val_5;
            if(val_5 <= 1)
            {
                    val_5 = zz.Length;
            }
            
            val_7 = (val_8 << 37) ^ (val_7 >> 18);
            zz[1] = val_6;
            if(val_5 <= 2)
            {
                    val_5 = zz.Length;
            }
            
            val_8 = (val_9 << 28) ^ (val_8 >> 27);
            zz[2] = val_7;
            if(val_5 <= 3)
            {
                    val_5 = zz.Length;
            }
            
            val_9 = (val_10 << 19) ^ (val_9 >> 36);
            zz[3] = val_8;
            if(val_5 <= 4)
            {
                    val_5 = zz.Length;
            }
            
            val_10 = val_10 >> 45;
            zz[4] = val_9;
            zz[5] = val_10;
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            int val_21;
            int val_22;
            int val_23;
            ulong val_24;
            ulong val_25;
            int val_26;
            val_21 = x.Length;
            if(val_21 == 0)
            {
                    val_21 = x.Length;
            }
            
            ulong val_23 = x[0];
            if(val_21 <= 1)
            {
                    val_21 = x.Length;
            }
            
            ulong val_24 = x[1];
            ulong val_25 = x[2];
            val_22 = y.Length;
            if(val_22 == 0)
            {
                    val_22 = y.Length;
            }
            
            ulong val_26 = y[0];
            if(val_22 <= 1)
            {
                    val_22 = y.Length;
            }
            
            ulong val_27 = y[1];
            val_23 = val_23 & 36028797018963967;
            ulong val_28 = y[2];
            ulong val_3 = val_26 & 36028797018963967;
            ulong[] val_4 = new ulong[10];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(x:  val_23, y:  val_3, z:  val_4, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(x:  val_25, y:  val_27, z:  val_4, zOff:  2);
            val_26 = ((val_26 >> 55) ^ val_3) ^ val_27;
            ulong val_7 = ((val_23 >> 55) ^ val_23) ^ val_25;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(x:  val_7, y:  val_26, z:  val_4, zOff:  4);
            val_25 = (val_25 << 2) ^ (((x[0] >> 55)) << 1);
            val_27 = (val_27 << 2) ^ (((y[0] >> 55)) << 1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(x:  val_25 ^ val_23, y:  val_27 ^ val_3, z:  val_4, zOff:  6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(x:  val_25 ^ val_7, y:  val_27 ^ val_26, z:  val_4, zOff:  8);
            val_23 = val_4.Length;
            if(val_23 <= 6)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 <= 8)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 <= 7)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 <= 9)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_32 = val_4[9];
            if(val_23 <= 6)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 <= 7)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 == 0)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_35 = val_4[0];
            if(val_23 <= 1)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 == 0)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_37 = val_4[0];
            if(val_23 <= 4)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 <= 1)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_39 = val_4[1];
            if(val_23 <= 5)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_14 = val_4[8] ^ val_4[6];
            if(val_23 <= 2)
            {
                    val_23 = val_4.Length;
            }
            
            val_32 = val_32 ^ val_4[7];
            val_24 = val_4[2];
            if(val_23 <= 2)
            {
                    val_24 = val_4[2];
                val_23 = val_4.Length;
            }
            
            val_14 = val_14 ^ (((val_4[9] ^ val_4[7])) << 1);
            val_37 = val_37 ^ val_4[1];
            ulong val_42 = val_35;
            val_42 = (val_4[6] ^ (((val_4[8] ^ val_4[6])) << 1)) ^ val_42;
            ulong val_16 = val_42 ^ ((val_4[2]) << 4);
            if(val_23 <= 3)
            {
                    val_23 = val_4.Length;
            }
            
            val_39 = val_4[5] ^ val_39;
            val_14 = val_14 ^ val_4[7];
            ulong val_44 = val_4[4];
            val_16 = val_16 ^ ((val_4[2]) << 1);
            val_25 = val_4[3];
            val_37 = val_37 ^ val_44;
            if(val_23 <= 3)
            {
                    val_25 = val_4[3];
            }
            
            val_44 = val_14 ^ val_37;
            val_44 = val_44 ^ ((val_4[3]) << 4);
            ulong val_18 = val_44 ^ ((val_4[3]) << 1);
            val_44 = val_39 ^ val_32 ^ (val_18 >> 55);
            val_18 = val_18 & 36028797018963967;
            val_18 = val_18 ^ (val_16 >> 55);
            val_18 = val_18 >> 1;
            val_18 = val_18 ^ 0;
            ulong val_45 = 0;
            val_45 = val_45 ^ (val_44 >> 1);
            zz[0] = val_35;
            val_37 = 0 ^ val_37 ^ val_4[2];
            zz[1] = val_37;
            var val_20 = 0 & 36028797018963967;
            val_26 = zz.Length;
            ulong val_21 = 0 ^ val_39;
            val_21 = val_21 ^ val_20;
            ulong val_49 = 0;
            val_39 = val_21 ^ val_4[3];
            if(val_26 <= 2)
            {
                    val_26 = zz.Length;
            }
            
            zz[2] = val_39;
            zz[3] = val_49 ^ val_20;
            val_49 = val_4[2] ^ val_49;
            zz[4] = val_49;
            zz[5] = val_4[3];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplCompactExt(zz:  zz);
        }
        protected static void ImplMulw(ulong x, ulong y, ulong[] z, int zOff)
        {
            int val_14;
            ulong val_15;
            ulong val_16;
            ulong val_17;
            ulong val_18;
            int val_19;
            ulong val_14 = y;
            ulong[] val_1 = new ulong[8];
            val_14 = val_1.Length;
            if(val_14 <= 1)
            {
                    val_14 = val_1.Length;
            }
            
            val_15 = val_14;
            val_1[1] = val_14;
            if(val_14 <= 1)
            {
                    val_15 = val_1[1];
                val_14 = val_1.Length;
            }
            
            val_16 = val_15 << 1;
            if(val_14 <= 2)
            {
                    val_14 = val_1.Length;
            }
            
            val_1[2] = val_16;
            if(val_14 <= 2)
            {
                    val_16 = val_1[2];
                val_14 = val_1.Length;
            }
            
            if(val_14 <= 3)
            {
                    val_14 = val_1.Length;
            }
            
            val_1[3] = val_16 ^ val_14;
            if(val_14 <= 2)
            {
                    val_14 = val_1.Length;
            }
            
            val_17 = val_1[2] << 1;
            if(val_14 <= 4)
            {
                    val_14 = val_1.Length;
            }
            
            val_1[4] = val_17;
            if(val_14 <= 4)
            {
                    val_17 = val_1[4];
                val_14 = val_1.Length;
            }
            
            if(val_14 <= 5)
            {
                    val_14 = val_1.Length;
            }
            
            val_1[5] = val_17 ^ val_14;
            if(val_14 <= 3)
            {
                    val_14 = val_1.Length;
            }
            
            val_18 = val_1[3] << 1;
            if(val_14 <= 6)
            {
                    val_14 = val_1.Length;
            }
            
            val_1[6] = val_18;
            if(val_14 <= 6)
            {
                    val_18 = val_1[6];
                val_14 = val_1.Length;
            }
            
            val_14 = val_18 ^ val_14;
            if(val_14 <= 7)
            {
                    val_14 = val_1.Length;
            }
            
            val_1[7] = val_14;
            ulong val_15 = val_1[x & 3];
            var val_20 = 0;
            var val_16 = 56;
            do
            {
                val_19 = val_1.Length;
                val_16 = val_16 - 9;
                ulong val_5 = x >> val_16;
                ulong val_6 = val_5 & 7;
                if(val_6 >= val_19)
            {
                    val_19 = val_1.Length;
            }
            
                if(((ulong)(val_5 >> 3) & 7) >= val_19)
            {
                    val_19 = val_1.Length;
            }
            
                ulong val_18 = val_1[(ulong)(val_5 >> 3) & 7];
                ulong val_19 = val_1[(ulong)(val_5 >> 6) & 7];
                ulong val_7 = val_1[val_6] ^ ((val_1[(ulong)(((x >> (56 - 9))>>3) & 0x7)][0]) << 3);
                ulong val_8 = val_7 ^ ((val_1[(ulong)(((x >> (56 - 9))>>6) & 0x7)][0]) << 6);
                val_7 = val_8 << val_16;
                val_8 = val_8 >> 17;
                val_15 = val_7 ^ val_15;
                val_20 = val_8 ^ val_20;
                var val_9 = 17 + 9;
            }
            while(val_16 > 9);
            
            z[(long)zOff] = val_15 & 36028797018963967;
            z[(long)zOff + 1] = (long)zOff;
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[1], z:  zz, zOff:  2);
            ulong val_6 = x[2];
            zz[4] = Org.BouncyCastle.Math.Raw.Interleave.Expand32to64(x:  val_6);
            zz[5] = Org.BouncyCastle.Math.Raw.Interleave.Expand8to16(x:  val_6 >> 32);
        }
        public SecT163Field()
        {
        
        }
        private static SecT163Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ROOT_Z = new ulong[3] {-5713258286846977098, 7916081454584570953, -7916121353529327616};
        }
    
    }

}
