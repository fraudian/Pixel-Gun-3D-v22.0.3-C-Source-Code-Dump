using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT409Field
    {
        // Fields
        private const ulong M25 = 33554431;
        private const ulong M59 = 576460752303423487;
        
        // Methods
        public static void Add(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_15 = y;
            ulong val_1 = x[0];
            val_1 = val_15[0] ^ val_1;
            z[0] = val_1;
            ulong val_3 = x[1];
            val_3 = val_15[1] ^ val_3;
            z[1] = val_3;
            ulong val_5 = x[2];
            val_5 = val_15[2] ^ val_5;
            z[2] = val_5;
            ulong val_7 = x[3];
            val_7 = val_15[3] ^ val_7;
            z[3] = val_7;
            ulong val_9 = x[4];
            val_9 = val_15[4] ^ val_9;
            z[4] = val_9;
            ulong val_11 = x[5];
            val_11 = val_15[5] ^ val_11;
            z[5] = val_11;
            val_15 = val_15[6] ^ x[6];
            z[6] = val_15;
        }
        public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
        {
            var val_2 = 0;
            do
            {
                mem2[0] = 1152921505846136544 ^ 1152921505846136544;
                val_2 = val_2 + 1;
            }
            while(val_2 != 13);
        
        }
        public static void AddOne(ulong[] x, ulong[] z)
        {
            ulong val_1 = x[0];
            val_1 = val_1 ^ 1;
            z[0] = val_1;
            z[1] = x[1];
            z[2] = x[2];
            z[3] = x[3];
            z[4] = x[4];
            z[5] = x[5];
            z[6] = x[6];
        }
        public static ulong[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat448.FromBigInteger64(x:  x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce39(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat448.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat448.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat448.Create64();
                System.UInt64[] val_4 = Org.BouncyCastle.Math.Raw.Nat448.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  1, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_3, n:  1, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  6, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  12, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_4);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_4, n:  24, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  24, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  48, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  96, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(x:  val_2, n:  192, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(x:  val_2, y:  val_4, z:  z);
                return;
            }
            
            System.InvalidOperationException val_5 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat448.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat448.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_20;
            ulong val_21;
            int val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            System.UInt64[] val_28 = xx;
            val_20 = xx.Length;
            if(val_20 == 0)
            {
                    val_20 = xx.Length;
            }
            
            ulong val_16 = val_28[0];
            if(val_20 <= 1)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 2)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 3)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 4)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 5)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 6)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 7)
            {
                    val_20 = xx.Length;
            }
            
            if(val_20 <= 12)
            {
                    val_20 = xx.Length;
            }
            
            ulong val_24 = val_28[12];
            if(val_20 <= 11)
            {
                    val_20 = xx.Length;
            }
            
            ulong val_25 = val_28[11];
            if(val_20 <= 10)
            {
                    val_20 = xx.Length;
            }
            
            ulong val_26 = val_28[10];
            ulong val_2 = (val_24 >> 25) ^ val_28[6];
            if(val_20 <= 9)
            {
                    val_20 = xx.Length;
            }
            
            ulong val_27 = val_28[9];
            val_2 = val_2 ^ (val_25 >> 2);
            val_21 = val_28[8];
            ulong val_3 = val_28[7] ^ (val_24 >> 2);
            val_16 = val_16 ^ (((xx[7] ^ (xx[12]) >> 2)) << 39);
            val_24 = val_3 >> 25;
            val_25 = val_2 >> 25;
            if(z == null)
            {
                    val_21 = val_21;
            }
            
            val_22 = z.Length;
            val_23 = val_27 << 39;
            val_28 = val_21 >> 25;
            val_24 = val_21 << 39;
            if(val_22 == 0)
            {
                    val_21 = val_21;
                val_22 = z.Length;
                val_24 = val_24;
                val_23 = val_23;
            }
            
            ulong val_30 = val_26;
            z[0] = val_16 ^ val_25;
            val_25 = val_28[3] ^ ((xx[10]) << 39);
            ulong val_29 = val_28[1];
            val_27 = (val_28[2] ^ (val_3 >> 2)) ^ val_23;
            val_29 = val_24 ^ val_29;
            val_29 = val_29 ^ ((((((xx[12] >> 25) ^ xx[6]) ^ (xx[11]) >> 2) >> 25)) << 23);
            if(val_22 <= 1)
            {
                    val_21 = val_21;
                val_22 = z.Length;
                val_25 = val_25;
            }
            
            val_26 = val_28[4] ^ ((xx[11]) << 39);
            val_27 = val_27 ^ val_28;
            z[1] = val_29 ^ val_24;
            if(val_22 <= 2)
            {
                    val_21 = val_21;
                val_22 = z.Length;
                val_26 = val_26;
            }
            
            val_30 = val_26 ^ (val_30 >> 25);
            z[2] = val_27;
            if(val_22 <= 3)
            {
                    val_22 = z.Length;
            }
            
            z[3] = (val_25 ^ (val_27 >> 25)) ^ (val_21 >> 2);
            ulong val_31 = val_26;
            if(val_22 <= 4)
            {
                    val_22 = z.Length;
            }
            
            val_31 = ((val_28[5] ^ ((xx[12]) << 39)) ^ (val_25 >> 25)) ^ (val_31 >> 2);
            z[4] = val_30 ^ (val_27 >> 2);
            if(val_22 <= 5)
            {
                    val_22 = z.Length;
            }
            
            z[5] = val_31;
            z[6] = val_2 & 33554431;
        }
        public static void Reduce39(ulong[] z, int zOff)
        {
            int val_4;
            System.UInt64[] val_7 = z;
            val_4 = z.Length;
            int val_1 = zOff + 6;
            if(val_1 >= val_4)
            {
                    val_4 = z.Length;
            }
            
            ulong val_4 = val_7[(long)val_1];
            ulong val_5 = val_7[(long)zOff];
            val_5 = val_5 ^ (val_4 >> 25);
            val_7[(long)zOff] = val_5;
            ulong val_6 = val_7[(long)zOff + 1];
            val_6 = val_6 ^ (((z[(long)(int)((zOff + 6))][0] >> 25)) << 23);
            val_7[(long)zOff + 1] = val_6;
            val_7 = val_4 & 33554431;
            mem2[0] = val_7;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            int val_18;
            ulong val_19;
            System.UInt64[] val_25 = x;
            ulong val_1 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[0]);
            ulong val_3 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[2]);
            ulong val_4 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[3]);
            ulong val_5 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[4]);
            ulong val_7 = val_1 >> 32;
            ulong val_8 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[6]);
            val_18 = z.Length;
            ulong val_9 = val_3 >> 32;
            if(val_18 == 0)
            {
                    val_18 = z.Length;
            }
            
            val_19 = val_5;
            z[0] = val_1 ^ (((val_1 >> 32)) << 44);
            val_25 = val_19 >> 32;
            if(val_18 <= 1)
            {
                    val_19 = val_5;
                val_18 = z.Length;
            }
            
            z[1] = X9 ^ val_3;
            ulong val_13 = val_8 >> 32;
            if(val_18 <= 2)
            {
                    val_18 = z.Length;
            }
            
            ulong val_15 = (Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[5])) >> 20;
            z[2] = val_8 ^ val_19;
            val_15 = val_15 ^ ((val_2) << 13);
            if(val_18 <= 3)
            {
                    val_18 = z.Length;
            }
            
            z[3] = val_15 ^ (val_8 & 4294967295);
            ulong val_26 = val_8;
            val_26 = val_26 >> 52;
            ulong val_17 = val_26 ^ ((Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_25[1])) >> 51);
            if(val_18 <= 4)
            {
                    val_18 = z.Length;
            }
            
            z[4] = val_17;
            if(val_18 <= 5)
            {
                    val_18 = z.Length;
            }
            
            z[5] = val_17;
            z[6] = val_17;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  13);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  13);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  13);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static uint Trace(ulong[] x)
        {
            x = x[0] & 1;
            return (uint)x;
        }
        protected static void ImplCompactExt(ulong[] zz)
        {
            int val_23 = zz.Length;
            if(val_23 == 0)
            {
                    val_23 = zz.Length;
            }
            
            if(val_23 <= 1)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_24 = zz[1];
            if(val_23 <= 2)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_25 = zz[2];
            if(val_23 <= 3)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_26 = zz[3];
            if(val_23 <= 4)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_27 = zz[4];
            if(val_23 <= 5)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_28 = zz[5];
            if(val_23 <= 6)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_29 = zz[6];
            if(val_23 <= 7)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_30 = zz[7];
            if(val_23 <= 8)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_31 = zz[8];
            if(val_23 <= 9)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_32 = zz[9];
            if(val_23 <= 10)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_33 = zz[10];
            if(val_23 <= 11)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_34 = zz[11];
            if(val_23 <= 12)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_35 = zz[12];
            if(val_23 <= 13)
            {
                    val_23 = zz.Length;
            }
            
            if(val_23 == 0)
            {
                    val_23 = zz.Length;
            }
            
            val_24 = (val_25 << 54) ^ (val_24 >> 5);
            zz[0] = zz[0] ^ ((zz[1]) << 59);
            if(val_23 <= 1)
            {
                    val_23 = zz.Length;
            }
            
            val_25 = (val_26 << 49) ^ (val_25 >> 10);
            zz[1] = val_24;
            if(val_23 <= 2)
            {
                    val_23 = zz.Length;
            }
            
            zz[2] = val_25;
            val_26 = (val_27 << 44) ^ (val_26 >> 15);
            if(val_23 <= 3)
            {
                    val_23 = zz.Length;
            }
            
            zz[3] = val_26;
            if(val_23 <= 4)
            {
                    val_23 = zz.Length;
            }
            
            zz[4] = (val_28 << 39) ^ (val_27 >> 20);
            if(val_23 <= 5)
            {
                    val_23 = zz.Length;
            }
            
            zz[5] = (val_29 << 34) ^ (val_28 >> 25);
            if(val_23 <= 6)
            {
                    val_23 = zz.Length;
            }
            
            zz[6] = (val_30 << 29) ^ (val_29 >> 30);
            if(val_23 <= 7)
            {
                    val_23 = zz.Length;
            }
            
            zz[7] = (val_31 << 24) ^ (val_30 >> 35);
            if(val_23 <= 8)
            {
                    val_23 = zz.Length;
            }
            
            zz[8] = (val_32 << 19) ^ (val_31 >> 40);
            if(val_23 <= 9)
            {
                    val_23 = zz.Length;
            }
            
            zz[9] = (val_33 << 14) ^ (val_32 >> 45);
            if(val_23 <= 10)
            {
                    val_23 = zz.Length;
            }
            
            zz[10] = (val_34 << 9) ^ (val_33 >> 50);
            ulong val_19 = val_35 << 4;
            val_19 = val_19 ^ (val_34 >> 55);
            if(val_23 <= 11)
            {
                    val_23 = zz.Length;
            }
            
            zz[11] = val_19 ^ ((zz[13]) << 63);
            if(val_23 <= 12)
            {
                    val_23 = zz.Length;
            }
            
            zz[12] = (zz[13] >> 1) ^ (val_35 >> 60);
            zz[13] = 0;
        }
        protected static void ImplExpand(ulong[] x, ulong[] z)
        {
            int val_2;
            int val_3;
            val_2 = x.Length;
            if(val_2 == 0)
            {
                    val_2 = x.Length;
            }
            
            ulong val_2 = x[0];
            if(val_2 <= 1)
            {
                    val_2 = x.Length;
            }
            
            ulong val_3 = x[1];
            if(val_2 <= 2)
            {
                    val_2 = x.Length;
            }
            
            ulong val_4 = x[2];
            if(val_2 <= 3)
            {
                    val_2 = x.Length;
            }
            
            ulong val_5 = x[3];
            if(val_2 <= 4)
            {
                    val_2 = x.Length;
            }
            
            ulong val_6 = x[4];
            if(val_2 <= 5)
            {
                    val_2 = x.Length;
            }
            
            ulong val_7 = x[5];
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            val_2 = val_2 >> 59;
            z[0] = val_2 & 576460752303423487;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            val_3 = val_3 >> 54;
            z[1] = val_2;
            if(val_3 <= 2)
            {
                    val_3 = z.Length;
            }
            
            val_4 = val_4 >> 49;
            z[2] = val_3;
            if(val_3 <= 3)
            {
                    val_3 = z.Length;
            }
            
            val_5 = val_5 >> 44;
            z[3] = val_4;
            if(val_3 <= 4)
            {
                    val_3 = z.Length;
            }
            
            val_6 = val_6 >> 39;
            z[4] = val_5;
            if(val_3 <= 5)
            {
                    val_3 = z.Length;
            }
            
            z[5] = val_6;
            z[6] = x[6];
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            ulong[] val_1 = new ulong[7];
            ulong[] val_2 = new ulong[7];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplExpand(x:  x, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplExpand(x:  y, z:  val_2);
            var val_3 = 0;
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(xs:  val_1, y:  null, z:  zz, zOff:  0);
                val_3 = val_3 + 1;
            }
            while(val_3 != 7);
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplCompactExt(zz:  zz);
        }
        protected static void ImplMulwAcc(ulong[] xs, ulong y, ulong[] z, int zOff)
        {
            int val_13;
            ulong val_14;
            ulong val_15;
            ulong val_16;
            ulong val_17;
            int val_18;
            int val_19;
            System.UInt64[] val_17 = xs;
            ulong[] val_1 = new ulong[8];
            val_13 = val_1.Length;
            if(val_13 <= 1)
            {
                    val_13 = val_1.Length;
            }
            
            val_14 = y;
            val_1[1] = y;
            if(val_13 <= 1)
            {
                    val_14 = val_1[1];
                val_13 = val_1.Length;
            }
            
            val_15 = val_14 << 1;
            if(val_13 <= 2)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[2] = val_15;
            if(val_13 <= 2)
            {
                    val_15 = val_1[2];
                val_13 = val_1.Length;
            }
            
            val_15 = val_15 ^ y;
            if(val_13 <= 3)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[3] = val_15;
            if(val_13 <= 2)
            {
                    val_13 = val_1.Length;
            }
            
            val_16 = val_1[2] << 1;
            if(val_13 <= 4)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[4] = val_16;
            if(val_13 <= 4)
            {
                    val_16 = val_1[4];
                val_13 = val_1.Length;
            }
            
            val_16 = val_16 ^ y;
            if(val_13 <= 5)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[5] = val_16;
            if(val_13 <= 3)
            {
                    val_13 = val_1.Length;
            }
            
            val_17 = val_1[3] << 1;
            if(val_13 <= 6)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[6] = val_17;
            if(val_13 <= 6)
            {
                    val_17 = val_1[6];
                val_13 = val_1.Length;
            }
            
            val_17 = val_17 ^ y;
            var val_24 = 0;
            val_1[7] = val_17;
            do
            {
                ulong val_14 = val_17[val_24];
                val_18 = val_1.Length;
                ulong val_2 = val_14 & 7;
                if(val_2 >= val_18)
            {
                    val_18 = val_1.Length;
            }
            
                ulong val_16 = val_1[(ulong)(val_14 >> 3) & 7];
                var val_21 = 0;
                var val_20 = 60;
                ulong val_3 = val_1[val_2] ^ ((val_1[(ulong)((xs[0x0][0]>>3) & 0x7)][0]) << 3);
                do
            {
                val_19 = val_1.Length;
                var val_4 = 54 & 62;
                ulong val_5 = val_14 >> val_4;
                val_17 = val_5 & 7;
                if(val_17 >= val_19)
            {
                    val_19 = val_1.Length;
            }
            
                ulong val_19 = val_1[(ulong)(val_5 >> 3) & 7];
                val_20 = val_20 - 6;
                ulong val_6 = val_1[val_17] ^ ((val_1[(ulong)(((xs[0x0][0] >> (54 & 62))>>3) & 0x7)][0]) << 3);
                val_1[val_17] = val_6 << val_4;
                val_6 = val_6 >> 10;
                val_3 = val_1[val_17] ^ val_3;
                val_21 = val_6 ^ val_21;
                var val_7 = 10 + 6;
            }
            while(val_20 > 6);
            
                int val_22 = zOff;
                val_22 = val_24 + val_22;
                System.UInt64[] val_8 = z + (((long)(int)((0 + zOff))) << 3);
                ulong val_23 = (z + ((long)(int)((0 + zOff))) << 3) + 32;
                ulong val_9 = val_3 & 576460752303423487;
                val_23 = val_23 ^ val_9;
                mem2[0] = val_23;
                var val_10 = (long)val_22 + 1;
                System.UInt64[] val_11 = z + (((long)(int)(((long)(int)((0 + zOff)) + 1))) << 3);
                ulong val_25 = (z + ((long)(int)(((long)(int)((0 + zOff)) + 1))) << 3) + 32;
                val_24 = val_24 + 1;
                val_25 = val_25 ^ val_9;
                mem2[0] = val_25;
            }
            while(val_24 != 7);
        
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            val_3 = 0;
            goto label_0;
            label_3:
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[0], z:  zz, zOff:  0);
            val_3 = 1;
            val_2 = 2;
            label_0:
            if(val_3 < 6)
            {
                goto label_3;
            }
            
            zz[12] = Org.BouncyCastle.Math.Raw.Interleave.Expand32to64(x:  x[6]);
        }
        public SecT409Field()
        {
        
        }
    
    }

}
