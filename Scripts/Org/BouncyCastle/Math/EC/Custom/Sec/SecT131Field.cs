using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT131Field
    {
        // Fields
        private const ulong M03 = 7;
        private const ulong M44 = 17592186044415;
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
            System.UInt64[] val_11 = yy;
            ulong val_1 = xx[0];
            val_1 = val_11[0] ^ val_1;
            zz[0] = val_1;
            ulong val_3 = xx[1];
            val_3 = val_11[1] ^ val_3;
            zz[1] = val_3;
            ulong val_5 = xx[2];
            val_5 = val_11[2] ^ val_5;
            zz[2] = val_5;
            ulong val_7 = xx[3];
            val_7 = val_11[3] ^ val_7;
            zz[3] = val_7;
            val_11 = val_11[4] ^ xx[4];
            zz[4] = val_11;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce61(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat192.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat192.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat192.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(x:  val_2, n:  2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(x:  val_3, n:  4, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(x:  val_2, n:  8, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(x:  val_3, n:  16, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(x:  val_2, n:  32, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(x:  val_3, n:  65, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(x:  val_2, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            var val_13;
            int val_14;
            var val_15;
            int val_16;
            var val_17;
            val_13 = z;
            System.UInt64[] val_16 = xx;
            val_14 = xx.Length;
            if(val_14 == 0)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 1)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 2)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_13 = val_16[2];
            if(val_14 <= 3)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_14 = val_16[3];
            ulong val_15 = val_16[4];
            ulong val_1 = val_15 ^ val_13;
            val_1 = val_1 ^ (val_15 >> 1);
            val_1 = val_1 ^ (val_15 >> 3);
            val_13 = val_1 ^ ((xx[4]) << 5);
            ulong val_2 = val_14 ^ (val_15 >> 59);
            val_16 = val_13 ^ (val_14 >> 59);
            ulong val_5 = val_16 >> 3;
            ulong val_17 = val_16[0];
            ulong val_6 = val_16 & (-8);
            val_15 = val_15 << 61;
            ulong val_7 = val_15 << 63;
            val_17 = (val_2 << 63) ^ val_17;
            ulong val_8 = val_17 ^ (val_2 << 61);
            val_16 = z.Length;
            val_8 = val_8 ^ val_5;
            val_6 = val_8 ^ val_6;
            val_6 = val_6 ^ ((((((((xx[4] ^ xx[2]) ^ (xx[4]) >> 1) ^ (xx[4]) >> 3) ^ (xx[4]) << 5) ^ (xx[3]) >> 59) >> 3)) << 2);
            val_17 = val_2 >> 3;
            val_15 = val_2 << 5;
            val_5 = val_6 ^ ((((((((xx[4] ^ xx[2]) ^ (xx[4]) >> 1) ^ (xx[4]) >> 3) ^ (xx[4]) << 5) ^ (xx[3]) >> 59) >> 3)) << 8);
            if(val_16 == 0)
            {
                    val_13 = val_15;
                val_16 = z.Length;
                val_15 = val_13;
                val_17 = val_17;
            }
            
            val_13[0] = val_5;
            ulong val_18 = val_16[1];
            val_18 = val_7 ^ val_18;
            val_18 = val_18 ^ val_15;
            val_18 = val_18 ^ val_2;
            val_18 = val_18 ^ (val_2 >> 1);
            val_18 = val_18 ^ val_17;
            val_18 = val_18 ^ val_15;
            val_7 = val_18 ^ (val_13 >> 59);
            if(val_16 <= 1)
            {
                    val_16 = z.Length;
            }
            
            val_13[1] = val_7;
            val_13[2] = val_16 & 7;
        }
        public static void Reduce61(ulong[] z, int zOff)
        {
            int val_5;
            System.UInt64[] val_8 = z;
            val_5 = z.Length;
            int val_1 = zOff + 2;
            if(val_1 >= val_5)
            {
                    val_5 = z.Length;
            }
            
            ulong val_5 = val_8[(long)val_1];
            ulong val_6 = val_8[(long)zOff];
            ulong val_3 = val_5 & (-8);
            val_3 = val_3 ^ (val_5 >> 3);
            val_3 = val_3 ^ (((z[(long)(int)((zOff + 2))][0] >> 3)) << 2);
            val_3 = val_3 ^ (((z[(long)(int)((zOff + 2))][0] >> 3)) << 8);
            val_6 = val_3 ^ val_6;
            val_8[(long)zOff] = val_6;
            ulong val_7 = val_8[(long)zOff + 1];
            val_7 = val_7 ^ (val_5 >> 59);
            val_8[(long)zOff + 1] = val_7;
            val_8 = val_5 & 7;
            mem2[0] = val_8;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ROOT_Z, z:  z);
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
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static uint Trace(ulong[] x)
        {
            int val_2 = x.Length;
            if(val_2 == 0)
            {
                    val_2 = x.Length;
            }
            
            if(val_2 <= 1)
            {
                    val_2 = x.Length;
            }
            
            ulong val_4 = x[2];
            ulong val_1 = x[1] >> 59;
            val_1 = val_1 ^ x[0];
            val_4 = val_1 ^ (val_4 >> 1);
            x = val_4 & 1;
            return (uint)x;
        }
        protected static void ImplCompactExt(ulong[] zz)
        {
            int val_6 = zz.Length;
            if(val_6 == 0)
            {
                    val_6 = zz.Length;
            }
            
            ulong val_6 = zz[0];
            if(val_6 <= 1)
            {
                    val_6 = zz.Length;
            }
            
            ulong val_7 = zz[1];
            if(val_6 <= 2)
            {
                    val_6 = zz.Length;
            }
            
            ulong val_8 = zz[2];
            if(val_6 <= 3)
            {
                    val_6 = zz.Length;
            }
            
            ulong val_9 = zz[3];
            if(val_6 <= 4)
            {
                    val_6 = zz.Length;
            }
            
            if(val_6 <= 5)
            {
                    val_6 = zz.Length;
            }
            
            val_6 = val_6 ^ ((zz[1]) << 44);
            if(val_6 == 0)
            {
                    val_6 = zz.Length;
            }
            
            val_7 = (val_8 << 24) ^ (val_7 >> 20);
            zz[0] = val_6;
            if(val_6 <= 1)
            {
                    val_6 = zz.Length;
            }
            
            ulong val_2 = val_9 << 4;
            val_2 = val_2 ^ (val_8 >> 40);
            zz[1] = val_7;
            if(val_6 <= 2)
            {
                    val_6 = zz.Length;
            }
            
            val_9 = (val_9 >> 60) ^ (zz[4] >> 16);
            zz[2] = val_2 ^ ((zz[4]) << 48);
            if(val_6 <= 3)
            {
                    val_6 = zz.Length;
            }
            
            zz[3] = val_9;
            if(val_6 <= 4)
            {
                    val_6 = zz.Length;
            }
            
            zz[4] = zz[5] >> 36;
            zz[5] = 0;
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            int val_21;
            int val_22;
            int val_23;
            ulong val_24;
            ulong val_25;
            int val_26;
            System.UInt64[] val_27 = x;
            val_21 = x.Length;
            if(val_21 == 0)
            {
                    val_21 = x.Length;
            }
            
            ulong val_23 = val_27[0];
            if(val_21 <= 1)
            {
                    val_21 = x.Length;
            }
            
            ulong val_25 = val_27[2];
            val_22 = y.Length;
            if(val_22 == 0)
            {
                    val_22 = y.Length;
            }
            
            ulong val_26 = y[0];
            val_27 = val_27[1] >> 24;
            if(val_22 <= 1)
            {
                    val_22 = y.Length;
            }
            
            ulong val_28 = y[1];
            val_23 = val_23 & 17592186044415;
            ulong val_29 = y[2];
            ulong val_2 = val_28 >> 24;
            val_26 = val_26 & 17592186044415;
            ulong[] val_4 = new ulong[10];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(x:  val_23, y:  val_26, z:  val_4, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(x:  val_27, y:  val_2, z:  val_4, zOff:  2);
            val_28 = ((val_26 >> 44) ^ val_26) ^ val_2;
            ulong val_7 = ((val_23 >> 44) ^ val_23) ^ val_27;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(x:  val_7, y:  val_28, z:  val_4, zOff:  4);
            val_27 = (val_27 << 2) ^ (((x[0] >> 44)) << 1);
            val_2 = (val_2 << 2) ^ (((y[0] >> 44)) << 1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(x:  val_27 ^ val_23, y:  val_2 ^ val_26, z:  val_4, zOff:  6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(x:  val_27 ^ val_7, y:  val_2 ^ val_28, z:  val_4, zOff:  8);
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
            
            ulong val_33 = val_4[9];
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
            
            ulong val_36 = val_4[0];
            if(val_23 <= 1)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 == 0)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_38 = val_4[0];
            if(val_23 <= 4)
            {
                    val_23 = val_4.Length;
            }
            
            if(val_23 <= 1)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_40 = val_4[1];
            if(val_23 <= 5)
            {
                    val_23 = val_4.Length;
            }
            
            ulong val_14 = val_4[8] ^ val_4[6];
            if(val_23 <= 2)
            {
                    val_23 = val_4.Length;
            }
            
            val_33 = val_33 ^ val_4[7];
            val_24 = val_4[2];
            if(val_23 <= 2)
            {
                    val_24 = val_4[2];
                val_23 = val_4.Length;
            }
            
            val_14 = val_14 ^ (((val_4[9] ^ val_4[7])) << 1);
            val_38 = val_38 ^ val_4[1];
            ulong val_43 = val_36;
            val_43 = (val_4[6] ^ (((val_4[8] ^ val_4[6])) << 1)) ^ val_43;
            ulong val_16 = val_43 ^ ((val_4[2]) << 4);
            if(val_23 <= 3)
            {
                    val_23 = val_4.Length;
            }
            
            val_40 = val_4[5] ^ val_40;
            val_14 = val_14 ^ val_4[7];
            ulong val_45 = val_4[4];
            val_16 = val_16 ^ ((val_4[2]) << 1);
            val_25 = val_4[3];
            val_38 = val_38 ^ val_45;
            if(val_23 <= 3)
            {
                    val_25 = val_4[3];
            }
            
            val_45 = val_14 ^ val_38;
            val_45 = val_45 ^ ((val_4[3]) << 4);
            ulong val_18 = val_45 ^ ((val_4[3]) << 1);
            val_45 = val_40 ^ val_33 ^ (val_18 >> 44);
            val_18 = val_18 & 17592186044415;
            val_18 = val_18 ^ (val_16 >> 44);
            val_18 = val_18 >> 1;
            val_18 = val_18 ^ 0;
            ulong val_46 = 0;
            val_46 = val_46 ^ (val_45 >> 1);
            zz[0] = val_36;
            val_38 = 0 ^ val_38 ^ val_4[2];
            zz[1] = val_38;
            var val_20 = 0 & 17592186044415;
            val_26 = zz.Length;
            ulong val_21 = 0 ^ val_40;
            val_21 = val_21 ^ val_20;
            ulong val_50 = 0;
            val_40 = val_21 ^ val_4[3];
            if(val_26 <= 2)
            {
                    val_26 = zz.Length;
            }
            
            zz[2] = val_40;
            zz[3] = val_50 ^ val_20;
            val_50 = val_4[2] ^ val_50;
            zz[4] = val_50;
            zz[5] = val_4[3];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplCompactExt(zz:  zz);
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
            
            if(val_18 <= 7)
            {
                    val_18 = val_1.Length;
            }
            
            ulong val_5 = x & 7;
            val_1[7] = val_22 ^ y;
            if(val_5 >= val_18)
            {
                    val_18 = val_1.Length;
            }
            
            ulong val_18 = val_1[val_5];
            if(((ulong)(x >> 3) & 7) >= val_18)
            {
                    val_18 = val_1.Length;
            }
            
            ulong val_19 = val_1[(ulong)(x >> 3) & 7];
            ulong val_20 = val_1[(ulong)(x >> 6) & 7];
            var val_25 = 0;
            val_18 = (val_18 ^ ((val_1[(ulong)((x>>3) & 0x7)][0]) << 3)) ^ ((val_1[(ulong)((x>>6) & 0x7)][0]) << 6);
            var val_26 = 31;
            do
            {
                val_23 = val_1.Length;
                var val_7 = 45 - 12;
                ulong val_8 = x >> val_7;
                ulong val_9 = val_8 & 7;
                if(val_9 >= val_23)
            {
                    val_23 = val_1.Length;
            }
            
                if(((ulong)(val_8 >> 3) & 7) >= val_23)
            {
                    val_23 = val_1.Length;
            }
            
                ulong val_22 = val_1[(ulong)(val_8 >> 3) & 7];
                if(((ulong)(val_8 >> 6) & 7) >= val_23)
            {
                    val_23 = val_1.Length;
            }
            
                ulong val_23 = val_1[(ulong)(val_8 >> 6) & 7];
                ulong val_24 = val_1[(ulong)(val_8 >> 9) & 7];
                ulong val_10 = val_1[val_9] ^ ((val_1[(ulong)(((x >> (45 - 12))>>3) & 0x7)][0]) << 3);
                val_10 = val_10 ^ ((val_1[(ulong)(((x >> (45 - 12))>>6) & 0x7)][0]) << 6);
                ulong val_11 = val_10 ^ ((val_1[(ulong)(((x >> (45 - 12))>>9) & 0x7)][0]) << 9);
                val_10 = val_11 << val_7;
                val_11 = val_11 >> val_26;
                val_18 = val_10 ^ val_18;
                val_25 = val_11 ^ val_25;
                val_26 = val_26 + 12;
            }
            while(val_7 > 12);
            
            System.UInt64[] val_13 = z + (((long)(int)(zOff)) << 3);
            mem2[0] = val_18 & 17592186044415;
            int val_14 = zOff + 1;
            System.UInt64[] val_15 = z + (((long)(int)((zOff + 1))) << 3);
            mem2[0] = (long)zOff;
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[1], z:  zz, zOff:  2);
            zz[4] = Org.BouncyCastle.Math.Raw.Interleave.Expand8to16(x:  x[2]);
        }
        public SecT131Field()
        {
        
        }
        private static SecT131Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ROOT_Z = new ulong[3] {2537199610838760486, -2146544001626555354, 432345564227567616};
        }
    
    }

}
