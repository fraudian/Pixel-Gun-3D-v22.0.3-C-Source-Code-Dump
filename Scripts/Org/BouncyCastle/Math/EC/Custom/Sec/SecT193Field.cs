using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT193Field
    {
        // Fields
        private const ulong M01 = 1;
        private const ulong M49 = 562949953421311;
        
        // Methods
        public static void Add(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_9 = y;
            ulong val_1 = x[0];
            val_1 = val_9[0] ^ val_1;
            z[0] = val_1;
            ulong val_3 = x[1];
            val_3 = val_9[1] ^ val_3;
            z[1] = val_3;
            ulong val_5 = x[2];
            val_5 = val_9[2] ^ val_5;
            z[2] = val_5;
            val_9 = val_9[3] ^ x[3];
            z[3] = val_9;
        }
        public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
        {
            System.UInt64[] val_15 = yy;
            ulong val_1 = xx[0];
            val_1 = val_15[0] ^ val_1;
            zz[0] = val_1;
            ulong val_3 = xx[1];
            val_3 = val_15[1] ^ val_3;
            zz[1] = val_3;
            ulong val_5 = xx[2];
            val_5 = val_15[2] ^ val_5;
            zz[2] = val_5;
            ulong val_7 = xx[3];
            val_7 = val_15[3] ^ val_7;
            zz[3] = val_7;
            ulong val_9 = xx[4];
            val_9 = val_15[4] ^ val_9;
            zz[4] = val_9;
            ulong val_11 = xx[5];
            val_11 = val_15[5] ^ val_11;
            zz[5] = val_11;
            val_15 = val_15[6] ^ xx[6];
            zz[6] = val_15;
        }
        public static void AddOne(ulong[] x, ulong[] z)
        {
            ulong val_1 = x[0];
            val_1 = val_1 ^ 1;
            z[0] = val_1;
            z[1] = x[1];
            z[2] = x[2];
            z[3] = x[3];
        }
        public static ulong[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.FromBigInteger64(x:  x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce63(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  1, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_3, n:  1, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  6, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  12, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  24, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  48, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(x:  val_2, n:  96, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(x:  val_2, y:  val_3, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_11;
            int val_12;
            var val_13;
            System.UInt64[] val_17 = xx;
            val_11 = xx.Length;
            if(val_11 == 0)
            {
                    val_11 = xx.Length;
            }
            
            if(val_11 <= 1)
            {
                    val_11 = xx.Length;
            }
            
            if(val_11 <= 2)
            {
                    val_11 = xx.Length;
            }
            
            ulong val_12 = val_17[2];
            if(val_11 <= 3)
            {
                    val_11 = xx.Length;
            }
            
            ulong val_13 = val_17[3];
            if(val_11 <= 4)
            {
                    val_11 = xx.Length;
            }
            
            ulong val_14 = val_17[4];
            if(val_11 <= 5)
            {
                    val_11 = xx.Length;
            }
            
            ulong val_15 = val_17[5];
            ulong val_16 = val_17[6];
            ulong val_1 = val_13 ^ ((xx[6]) << 14);
            val_13 = val_1 ^ (val_16 >> 1);
            ulong val_2 = val_14 ^ (val_16 >> 50);
            val_1 = val_13 ^ (val_15 >> 50);
            val_17 = val_17[0] ^ (((xx[4] ^ (xx[6]) >> 50)) << 63);
            val_12 = z.Length;
            val_12 = (val_12 ^ (val_14 >> 50)) ^ ((xx[5]) << 14);
            val_13 = val_15 << 63;
            val_14 = val_2 >> 1;
            ulong val_6 = val_2 << 14;
            if(val_12 == 0)
            {
                    val_12 = z.Length;
                val_13 = val_13;
            }
            
            z[0] = (val_17 ^ (val_1 >> 1)) ^ ((((((xx[3] ^ (xx[6]) << 14) ^ (xx[6]) >> 1) ^ (xx[5]) >> 50) >> 1)) << 15);
            ulong val_18 = val_17[1];
            val_12 = val_12 ^ (val_15 >> 1);
            val_18 = val_13 ^ val_18;
            val_18 = val_18 ^ val_6;
            val_18 = val_18 ^ val_14;
            val_6 = val_18 ^ (val_13 >> 50);
            if(val_12 <= 1)
            {
                    val_12 = z.Length;
            }
            
            z[1] = val_6;
            if(val_12 <= 2)
            {
                    val_12 = z.Length;
            }
            
            z[2] = val_12 ^ ((xx[6]) << 63);
            z[3] = val_1 & 1;
        }
        public static void Reduce63(ulong[] z, int zOff)
        {
            int val_4;
            System.UInt64[] val_7 = z;
            val_4 = z.Length;
            int val_1 = zOff + 3;
            if(val_1 >= val_4)
            {
                    val_4 = z.Length;
            }
            
            ulong val_4 = val_7[(long)val_1];
            ulong val_2 = val_4 >> 1;
            ulong val_5 = val_7[(long)zOff];
            val_5 = 0 ^ val_5;
            val_7[(long)zOff] = val_5;
            ulong val_6 = val_7[(long)zOff + 1];
            val_6 = val_6 ^ (val_4 >> 50);
            val_7[(long)zOff + 1] = val_6;
            val_7 = val_4 & 1;
            mem2[0] = val_7;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            int val_7;
            ulong val_1 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[0]);
            ulong val_12 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[1]);
            ulong val_13 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[2]);
            ulong val_10 = x[3];
            ulong val_11 = val_1;
            val_7 = z.Length;
            ulong val_4 = val_1 >> 32;
            ulong val_5 = val_13 >> 32;
            val_11 = val_11 ^ ((val_2) << 8);
            if(val_7 == 0)
            {
                    val_7 = z.Length;
            }
            
            ulong val_6 = val_12 >> 56;
            val_6 = val_6 ^ (((val_3 >> 32)) << 8);
            val_12 = val_6 ^ val_13;
            z[0] = val_11;
            if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
            z[1] = val_12;
            if(val_7 <= 2)
            {
                    val_7 = z.Length;
            }
            
            val_13 = val_13 >> 63;
            z[2] = val_12;
            z[3] = val_13;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(xx:  val_1, z:  z);
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
            int val_9 = zz.Length;
            if(val_9 == 0)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_9 = zz[0];
            if(val_9 <= 1)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_10 = zz[1];
            if(val_9 <= 2)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_11 = zz[2];
            if(val_9 <= 3)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_12 = zz[3];
            if(val_9 <= 4)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_13 = zz[4];
            if(val_9 <= 5)
            {
                    val_9 = zz.Length;
            }
            
            if(val_9 <= 6)
            {
                    val_9 = zz.Length;
            }
            
            if(val_9 <= 7)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_16 = zz[7];
            val_9 = val_9 ^ ((zz[1]) << 49);
            if(val_9 == 0)
            {
                    val_9 = zz.Length;
            }
            
            val_10 = (val_11 << 34) ^ (val_10 >> 15);
            zz[0] = val_9;
            if(val_9 <= 1)
            {
                    val_9 = zz.Length;
            }
            
            val_11 = (val_12 << 19) ^ (val_11 >> 30);
            zz[1] = val_10;
            if(val_9 <= 2)
            {
                    val_9 = zz.Length;
            }
            
            ulong val_3 = val_13 << 4;
            val_3 = val_3 ^ (val_12 >> 45);
            zz[2] = val_11;
            if(val_9 <= 3)
            {
                    val_9 = zz.Length;
            }
            
            val_13 = (val_13 >> 60) ^ (zz[5] >> 11);
            zz[3] = val_3 ^ ((zz[5]) << 53);
            if(val_9 <= 4)
            {
                    val_9 = zz.Length;
            }
            
            zz[4] = val_13;
            if(val_9 <= 5)
            {
                    val_9 = zz.Length;
            }
            
            zz[5] = (val_16 << 23) ^ (zz[6] >> 26);
            if(val_9 <= 6)
            {
                    val_9 = zz.Length;
            }
            
            zz[6] = val_16 >> 41;
            zz[7] = 0;
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
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            val_2 = val_2 >> 49;
            z[0] = val_2 & 562949953421311;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            val_3 = val_3 >> 34;
            z[1] = val_2;
            if(val_3 <= 2)
            {
                    val_3 = z.Length;
            }
            
            z[2] = val_3;
            z[3] = x[3];
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            ulong[] val_1 = new ulong[4];
            ulong[] val_2 = new ulong[4];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplExpand(x:  x, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplExpand(x:  y, z:  val_2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_1[0], y:  val_2[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_1[1], y:  val_2[1], z:  zz, zOff:  1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_1[2], y:  val_2[2], z:  zz, zOff:  2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_1[3], y:  val_2[3], z:  zz, zOff:  3);
            var val_28 = 0;
            do
            {
                var val_26 = 5;
                val_14 = zz.Length;
                if(val_26 >= val_14)
            {
                    val_14 = zz.Length;
            }
            
                val_26 = val_26 - 1;
                ulong val_27 = zz[val_28];
                val_28 = val_28 - 1;
                val_27 = val_27 ^ zz[val_28];
                zz[val_28] = val_27;
            }
            while((val_26 + 1) > 1);
            
            val_15 = val_1.Length;
            if(val_15 == 0)
            {
                    val_15 = val_1.Length;
            }
            
            val_16 = val_2.Length;
            if(val_16 == 0)
            {
                    val_16 = val_2.Length;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_1[1] ^ val_1[0], y:  val_2[1] ^ val_2[0], z:  zz, zOff:  1);
            val_17 = val_1.Length;
            if(val_17 <= 2)
            {
                    val_17 = val_1.Length;
            }
            
            val_18 = val_2.Length;
            if(val_18 <= 2)
            {
                    val_18 = val_2.Length;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_1[3] ^ val_1[2], y:  val_2[3] ^ val_2[2], z:  zz, zOff:  3);
            var val_39 = 0;
            do
            {
                val_19 = zz.Length;
                var val_8 = val_39 + 7;
                if(val_8 >= val_19)
            {
                    val_19 = zz.Length;
            }
            
                val_8 = val_8 - 2;
                ulong val_38 = zz[val_39];
                val_39 = val_39 - 1;
                val_38 = val_38 ^ zz[val_39];
                zz[val_39] = val_38;
            }
            while((val_8 + 2) > 2);
            
            val_20 = val_1.Length;
            if(val_20 == 0)
            {
                    val_20 = val_1.Length;
            }
            
            ulong val_40 = val_1[0];
            if(val_20 <= 2)
            {
                    val_20 = val_1.Length;
            }
            
            if(val_20 <= 1)
            {
                    val_20 = val_1.Length;
            }
            
            ulong val_43 = val_1[3];
            val_21 = val_2.Length;
            if(val_21 == 0)
            {
                    val_21 = val_2.Length;
            }
            
            if(val_21 <= 2)
            {
                    val_21 = val_2.Length;
            }
            
            val_43 = val_43 ^ val_1[1];
            ulong val_10 = val_2[2] ^ val_2[0];
            if(val_21 <= 1)
            {
                    val_21 = val_2.Length;
            }
            
            val_40 = val_1[2] ^ val_40;
            ulong val_12 = val_2[3] ^ val_2[1];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_43 ^ val_40, y:  val_12 ^ val_10, z:  zz, zOff:  3);
            ulong[] val_14 = new ulong[3];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_40, y:  val_10, z:  val_14, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(x:  val_43, y:  val_12, z:  val_14, zOff:  1);
            val_22 = val_14.Length;
            if(val_22 == 0)
            {
                    val_22 = val_14.Length;
            }
            
            ulong val_48 = val_14[0];
            if(val_22 <= 1)
            {
                    val_22 = val_14.Length;
            }
            
            ulong val_49 = val_14[1];
            val_23 = zz.Length;
            ulong val_50 = val_14[2];
            if(val_23 <= 2)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_51 = zz[2];
            val_51 = val_51 ^ val_48;
            zz[2] = val_51;
            if(val_23 <= 3)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_52 = zz[3];
            val_52 = val_49 ^ val_48 ^ val_52;
            zz[3] = val_52;
            if(val_23 <= 4)
            {
                    val_23 = zz.Length;
            }
            
            ulong val_53 = zz[4];
            val_53 = val_50 ^ val_49 ^ val_53;
            zz[4] = val_53;
            ulong val_54 = zz[5];
            val_54 = val_54 ^ val_50;
            zz[5] = val_54;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplCompactExt(zz:  zz);
        }
        protected static void ImplMulwAcc(ulong x, ulong y, ulong[] z, int zOff)
        {
            System.UInt64[] val_22;
            var val_23;
            ulong val_24;
            ulong val_25;
            ulong val_26;
            ulong val_27;
            var val_28;
            ulong[] val_1 = new ulong[8];
            if(val_1 == null)
            {
                    val_22 = val_1;
            }
            
            val_23 = mem[1152921544378725448];
            if(val_23 <= 1)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            val_24 = y;
            mem[1152921544378725464] = y;
            if(val_23 <= 1)
            {
                    val_22 = val_1;
                val_24 = mem[1152921544378725464];
                val_23 = mem[1152921544378725448];
            }
            
            val_25 = val_24 << 1;
            if(val_23 <= 2)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            mem[1152921544378725472] = val_25;
            if(val_23 <= 2)
            {
                    val_22 = val_1;
                val_25 = mem[1152921544378725472];
                val_23 = mem[1152921544378725448];
            }
            
            val_25 = val_25 ^ y;
            if(val_23 <= 3)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            mem[1152921544378725480] = val_25;
            if(val_23 <= 2)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            val_26 = mem[1152921544378725472] << 1;
            if(val_23 <= 4)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            mem[1152921544378725488] = val_26;
            if(val_23 <= 4)
            {
                    val_22 = val_1;
                val_26 = mem[1152921544378725488];
                val_23 = mem[1152921544378725448];
            }
            
            val_26 = val_26 ^ y;
            if(val_23 <= 5)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            mem[1152921544378725496] = val_26;
            if(val_23 <= 3)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            val_27 = mem[1152921544378725480] << 1;
            if(val_23 <= 6)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            mem[1152921544378725504] = val_27;
            if(val_23 <= 6)
            {
                    val_22 = val_1;
                val_27 = mem[1152921544378725504];
                val_23 = mem[1152921544378725448];
            }
            
            val_27 = val_27 ^ y;
            if(val_23 <= 7)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            mem[1152921544378725512] = val_27;
            if((x & 7) >= val_23)
            {
                    val_22 = val_1;
                val_23 = mem[1152921544378725448];
            }
            
            System.UInt64[] val_3 = val_22 + (((x & 7)) << 3);
            if(((ulong)(x >> 3) & 7) >= val_23)
            {
                    val_22 = val_1;
            }
            
            System.UInt64[] val_4 = val_22 + (((ulong)((x>>3) & 0x7)) << 3);
            var val_20 = 0;
            var val_21 = 28;
            var val_5 = ((val_1 + ((x & 7)) << 3) + 32) ^ (((val_1 + ((ulong)((x>>3) & 0x7)) << 3) + 32) << 3);
            do
            {
                val_28 = mem[1152921544378725448];
                var val_6 = 51 - 15;
                ulong val_7 = x >> val_6;
                if((val_7 & 7) >= val_28)
            {
                    val_22 = val_1;
                val_28 = mem[1152921544378725448];
            }
            
                System.UInt64[] val_9 = val_22 + ((((x >> (51 - 15)) & 7)) << 3);
                if(((ulong)(val_7 >> 3) & 7) >= val_28)
            {
                    val_22 = val_1;
                val_28 = mem[1152921544378725448];
            }
            
                System.UInt64[] val_10 = val_22 + (((ulong)(((x >> (51 - 15))>>3) & 0x7)) << 3);
                if(((ulong)(val_7 >> 6) & 7) >= val_28)
            {
                    val_22 = val_1;
                val_28 = mem[1152921544378725448];
            }
            
                System.UInt64[] val_11 = val_22 + (((ulong)(((x >> (51 - 15))>>6) & 0x7)) << 3);
                if(((ulong)(val_7 >> 9) & 7) >= val_28)
            {
                    val_22 = val_1;
                val_28 = mem[1152921544378725448];
            }
            
                System.UInt64[] val_12 = val_22 + (((ulong)(((x >> (51 - 15))>>9) & 0x7)) << 3);
                if(((ulong)(val_7 >> 12) & 7) >= val_28)
            {
                    val_22 = val_1;
            }
            
                System.UInt64[] val_13 = val_22 + (((ulong)(((x >> (51 - 15))>>12) & 0x7)) << 3);
                var val_14 = ((val_1 + (((x >> (51 - 15)) & 7)) << 3) + 32) ^ (((val_1 + ((ulong)(((x >> (51 - 15))>>3) & 0x7)) << 3) + 32) << 3);
                val_14 = val_14 ^ (((val_1 + ((ulong)(((x >> (51 - 15))>>6) & 0x7)) << 3) + 32) << 6);
                val_14 = val_14 ^ (((val_1 + ((ulong)(((x >> (51 - 15))>>9) & 0x7)) << 3) + 32) << 9);
                var val_15 = val_14 ^ (((val_1 + ((ulong)(((x >> (51 - 15))>>12) & 0x7)) << 3) + 32) << 12);
                val_14 = val_15 << val_6;
                val_15 = val_15 >> val_21;
                val_5 = val_14 ^ val_5;
                val_20 = val_15 ^ val_20;
                val_21 = val_21 + 15;
            }
            while(val_6 > 15);
            
            System.UInt64[] val_16 = z + (((long)(int)(zOff)) << 3);
            var val_22 = (z + ((long)(int)(zOff)) << 3) + 32;
            var val_17 = val_5 & 562949953421311;
            val_22 = val_22 ^ val_17;
            mem2[0] = val_22;
            int val_18 = zOff + 1;
            System.UInt64[] val_19 = z + (((long)(int)((zOff + 1))) << 3);
            var val_23 = (z + ((long)(int)((zOff + 1))) << 3) + 32;
            val_23 = val_23 ^ val_17;
            mem2[0] = val_23;
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[1], z:  zz, zOff:  2);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[2], z:  zz, zOff:  4);
            ulong val_4 = x[3];
            val_4 = val_4 & 1;
            zz[6] = val_4;
        }
        public SecT193Field()
        {
        
        }
    
    }

}
