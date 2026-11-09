using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT239Field
    {
        // Fields
        private const ulong M47 = 140737488355327;
        private const ulong M60 = 1152921504606846975;
        
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
            System.UInt64[] val_17 = yy;
            ulong val_1 = xx[0];
            val_1 = val_17[0] ^ val_1;
            zz[0] = val_1;
            ulong val_3 = xx[1];
            val_3 = val_17[1] ^ val_3;
            zz[1] = val_3;
            ulong val_5 = xx[2];
            val_5 = val_17[2] ^ val_5;
            zz[2] = val_5;
            ulong val_7 = xx[3];
            val_7 = val_17[3] ^ val_7;
            zz[3] = val_7;
            ulong val_9 = xx[4];
            val_9 = val_17[4] ^ val_9;
            zz[4] = val_9;
            ulong val_11 = xx[5];
            val_11 = val_17[5] ^ val_11;
            zz[5] = val_11;
            ulong val_13 = xx[6];
            val_13 = val_17[6] ^ val_13;
            zz[6] = val_13;
            val_17 = val_17[7] ^ xx[7];
            zz[7] = val_17;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce17(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  val_2, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  val_2, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  val_3, n:  7, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  val_2, n:  14, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  val_3, n:  29, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  val_2, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  val_2, n:  59, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  val_3, n:  119, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  val_2, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_14;
            int val_15;
            System.UInt64[] val_22 = xx;
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
            
            if(val_14 <= 3)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 4)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 5)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_19 = val_22[5];
            if(val_14 <= 6)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_20 = val_22[6];
            ulong val_21 = val_22[7];
            val_22 = val_22[3] ^ ((xx[7]) << 17);
            val_19 = val_19 ^ ((xx[7]) << 47);
            val_21 = val_20 ^ (val_21 >> 17);
            ulong val_2 = (val_22[4] ^ (val_21 >> 47)) ^ (((xx[6] ^ (xx[7]) >> 17)) << 47);
            ulong val_7 = val_22[0] ^ (((((xx[4] ^ (xx[7]) >> 47) ^ ((xx[6] ^ (xx[7]) >> 17)) << 47) ^ (((xx[5] ^ (xx[7]) << 47) ^ ((xx[6] ^ (xx[7]) >> 17)) >> 17)) >> 17)) << 17);
            val_15 = z.Length;
            val_19 = (val_22[2] ^ (((xx[6] ^ (xx[7]) >> 17)) << 17)) ^ (val_19 >> 47);
            val_7 = val_7 ^ ((val_22 ^ ((((xx[5] ^ (xx[7]) << 47) ^ ((xx[6] ^ (xx[7]) >> 17)) >> 17)) << 47)) >> 47);
            ulong val_9 = val_22[1] ^ ((((xx[5] ^ (xx[7]) << 47) ^ ((xx[6] ^ (xx[7]) >> 17)) >> 17)) << 17);
            if(val_15 == 0)
            {
                    val_15 = z.Length;
            }
            
            val_9 = val_9 ^ (val_2 >> 47);
            z[0] = val_7;
            if(val_15 <= 1)
            {
                    val_15 = z.Length;
            }
            
            val_20 = val_20 >> 47;
            z[1] = val_9;
            if(val_15 <= 2)
            {
                    val_15 = z.Length;
            }
            
            ulong val_13 = val_22 & 140737488355327;
            val_13 = val_13 ^ val_20;
            val_22 = val_13 ^ ((val_2 ^ ((val_19 ^ (val_21 >> 17)) >> 17)) >> 17);
            z[2] = (val_19 ^ (((((xx[4] ^ (xx[7]) >> 47) ^ ((xx[6] ^ (xx[7]) >> 17)) << 47) ^ (((xx[5] ^ (xx[7]) << 47) ^ ((xx[6] ^ (xx[7]) >> 17)) >> 17)) >> 17)) << 47)) ^ (((((xx[3] ^ (xx[7]) << 17) ^ (((xx[5] ^ (xx[7]) << 47) ^ ((xx[6] ^ (xx[7]) >> 17)) >> 17)) << 47) >> 47)) << 30);
            z[3] = val_22;
        }
        public static void Reduce17(ulong[] z, int zOff)
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
            ulong val_5 = val_7[(long)zOff];
            val_5 = val_5 ^ (val_4 >> 47);
            val_7[(long)zOff] = val_5;
            ulong val_6 = val_7[(long)zOff + 2];
            val_6 = val_6 ^ (((z[(long)(int)((zOff + 3))][0] >> 47)) << 30);
            val_7[(long)zOff + 2] = val_6;
            val_7 = val_4 & 140737488355327;
            mem2[0] = val_7;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            var val_20;
            ulong val_21;
            int val_22;
            var val_23;
            var val_24;
            val_20 = x;
            ulong val_2 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_20[1]);
            val_21 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_20[2]);
            ulong val_4 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_20[3]);
            System.UInt64[] val_5 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            int[] val_6 = new int[2];
            val_22 = val_6.Length;
            if(val_22 == 0)
            {
                    val_22 = val_6.Length;
            }
            
            val_6[0] = 39;
            if(val_22 <= 1)
            {
                    val_22 = val_6.Length;
            }
            
            val_6[0] = 120;
            if(val_22 >= 1)
            {
                    ulong val_7 = val_4 >> 49;
                ulong val_8 = val_4 ^ ((val_2) << 15);
                do
            {
                val_20 = 0;
                if(0 >= val_22)
            {
                    val_22 = val_6.Length;
            }
            
                int val_24 = val_6[0];
                val_23 = val_24;
                if(val_20 >= val_22)
            {
                    val_23 = mem[val_6[0x0] + 32];
                val_23 = val_6[0x0] + 32;
            }
            
                var val_10 = val_23 & 63;
                ulong val_25 = val_5[(long)val_24 >> 6];
                val_25 = val_25 ^ (val_2 << val_10);
                val_5[(long)val_24 >> 6] = val_25;
                var val_27 = -val_23;
                val_23 = val_27 & 63;
                ulong val_13 = val_8 << val_10;
                val_27 = val_2 >> val_23;
                val_13 = val_13 | val_27;
                val_13 = (val_5[((long)val_24 >> 6) + 1]) ^ val_13;
                val_5[((long)val_24 >> 6) + 1] = val_13;
                ulong val_29 = val_21;
                ulong val_28 = val_5[((long)val_24 >> 6) + 2];
                val_29 = val_29 << val_10;
                val_29 = val_29 | (val_8 >> val_23);
                val_28 = val_28 ^ val_29;
                val_5[((long)val_24 >> 6) + 2] = val_28;
                ulong val_31 = val_21;
                ulong val_30 = val_5[((long)val_24 >> 6) + 3];
                ulong val_17 = val_7 << val_10;
                val_31 = val_31 >> val_23;
                val_17 = val_17 | val_31;
                val_30 = val_30 ^ val_17;
                val_5[((long)val_24 >> 6) + 3] = val_30;
                val_21 = ((long)val_24 >> 6) + 4;
                ulong val_32 = val_5[val_21];
                val_32 = val_32 ^ (val_7 >> val_23);
                val_5[val_21] = val_32;
            }
            while((val_20 + 1) < val_6.Length);
            
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_5, z:  z);
            val_24 = mem[z + 24];
            val_24 = z + 24;
            if(val_24 == 0)
            {
                    val_24 = mem[z + 24];
                val_24 = z + 24;
            }
            
            ulong val_33 = z + 32;
            val_33 = val_33 ^ (Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  val_20[0]));
            mem2[0] = val_33;
            ulong val_34 = z + 40;
            val_34 = val_34 ^ val_21;
            mem2[0] = val_34;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_1, z:  z);
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
            val_4 = val_4 >> 34;
            val_4 = (x[0] ^ (x[1] >> 17)) ^ val_4;
            x = val_4 & 1;
            return (uint)x;
        }
        protected static void ImplCompactExt(ulong[] zz)
        {
            int val_7 = zz.Length;
            if(val_7 == 0)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_7 = zz[0];
            if(val_7 <= 1)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_8 = zz[1];
            if(val_7 <= 2)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_9 = zz[2];
            if(val_7 <= 3)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_10 = zz[3];
            if(val_7 <= 4)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_11 = zz[4];
            if(val_7 <= 5)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_12 = zz[5];
            if(val_7 <= 6)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_13 = zz[6];
            if(val_7 <= 7)
            {
                    val_7 = zz.Length;
            }
            
            ulong val_14 = zz[7];
            val_7 = val_7 ^ ((zz[1]) << 60);
            if(val_7 == 0)
            {
                    val_7 = zz.Length;
            }
            
            val_8 = (val_9 << 56) ^ (val_8 >> 4);
            zz[0] = val_7;
            if(val_7 <= 1)
            {
                    val_7 = zz.Length;
            }
            
            val_9 = (val_10 << 52) ^ (val_9 >> 8);
            zz[1] = val_8;
            if(val_7 <= 2)
            {
                    val_7 = zz.Length;
            }
            
            val_10 = (val_11 << 48) ^ (val_10 >> 12);
            zz[2] = val_9;
            if(val_7 <= 3)
            {
                    val_7 = zz.Length;
            }
            
            val_11 = (val_12 << 44) ^ (val_11 >> 16);
            zz[3] = val_10;
            if(val_7 <= 4)
            {
                    val_7 = zz.Length;
            }
            
            val_12 = (val_13 << 40) ^ (val_12 >> 20);
            zz[4] = val_11;
            if(val_7 <= 5)
            {
                    val_7 = zz.Length;
            }
            
            val_13 = (val_14 << 36) ^ (val_13 >> 24);
            zz[5] = val_12;
            if(val_7 <= 6)
            {
                    val_7 = zz.Length;
            }
            
            val_14 = val_14 >> 28;
            zz[6] = val_13;
            zz[7] = val_14;
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
            
            val_2 = val_2 >> 60;
            z[0] = val_2 & 1152921504606846975;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            val_3 = val_3 >> 56;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplExpand(x:  x, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplExpand(x:  y, z:  val_2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_1[0], y:  val_2[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_1[1], y:  val_2[1], z:  zz, zOff:  1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_1[2], y:  val_2[2], z:  zz, zOff:  2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_1[3], y:  val_2[3], z:  zz, zOff:  3);
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
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_1[1] ^ val_1[0], y:  val_2[1] ^ val_2[0], z:  zz, zOff:  1);
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
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_1[3] ^ val_1[2], y:  val_2[3] ^ val_2[2], z:  zz, zOff:  3);
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_43 ^ val_40, y:  val_12 ^ val_10, z:  zz, zOff:  3);
            ulong[] val_14 = new ulong[3];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_40, y:  val_10, z:  val_14, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(x:  val_43, y:  val_12, z:  val_14, zOff:  1);
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplCompactExt(zz:  zz);
        }
        protected static void ImplMulwAcc(ulong x, ulong y, ulong[] z, int zOff)
        {
            int val_21;
            ulong val_22;
            ulong val_23;
            ulong val_24;
            ulong val_25;
            int val_26;
            ulong[] val_1 = new ulong[8];
            val_21 = val_1.Length;
            if(val_21 <= 1)
            {
                    val_21 = val_1.Length;
            }
            
            val_22 = y;
            val_1[1] = y;
            if(val_21 <= 1)
            {
                    val_22 = val_1[1];
                val_21 = val_1.Length;
            }
            
            val_23 = val_22 << 1;
            if(val_21 <= 2)
            {
                    val_21 = val_1.Length;
            }
            
            val_1[2] = val_23;
            if(val_21 <= 2)
            {
                    val_23 = val_1[2];
                val_21 = val_1.Length;
            }
            
            if(val_21 <= 3)
            {
                    val_21 = val_1.Length;
            }
            
            val_1[3] = val_23 ^ y;
            if(val_21 <= 2)
            {
                    val_21 = val_1.Length;
            }
            
            val_24 = val_1[2] << 1;
            if(val_21 <= 4)
            {
                    val_21 = val_1.Length;
            }
            
            val_1[4] = val_24;
            if(val_21 <= 4)
            {
                    val_24 = val_1[4];
                val_21 = val_1.Length;
            }
            
            if(val_21 <= 5)
            {
                    val_21 = val_1.Length;
            }
            
            val_1[5] = val_24 ^ y;
            if(val_21 <= 3)
            {
                    val_21 = val_1.Length;
            }
            
            val_25 = val_1[3] << 1;
            if(val_21 <= 6)
            {
                    val_21 = val_1.Length;
            }
            
            val_1[6] = val_25;
            if(val_21 <= 6)
            {
                    val_25 = val_1[6];
                val_21 = val_1.Length;
            }
            
            if(val_21 <= 7)
            {
                    val_21 = val_1.Length;
            }
            
            ulong val_5 = x & 7;
            val_1[7] = val_25 ^ y;
            if(val_5 >= val_21)
            {
                    val_21 = val_1.Length;
            }
            
            ulong val_23 = val_1[(ulong)(x >> 3) & 7];
            var val_27 = 0;
            var val_26 = 60;
            ulong val_6 = val_1[val_5] ^ ((val_1[(ulong)((x>>3) & 0x7)][0]) << 3);
            do
            {
                val_26 = val_1.Length;
                var val_7 = 54 & 62;
                ulong val_8 = x >> val_7;
                ulong val_9 = val_8 & 7;
                if(val_9 >= val_26)
            {
                    val_26 = val_1.Length;
            }
            
                ulong val_25 = val_1[(ulong)(val_8 >> 3) & 7];
                val_26 = val_26 - 6;
                ulong val_10 = val_1[val_9] ^ ((val_1[(ulong)(((x >> (54 & 62))>>3) & 0x7)][0]) << 3);
                val_1[val_9] = val_10 << val_7;
                val_10 = val_10 >> 10;
                val_6 = val_1[val_9] ^ val_6;
                val_27 = val_10 ^ val_27;
                var val_11 = 10 + 6;
            }
            while(val_26 > 6);
            
            System.UInt64[] val_15 = z + (((long)(int)(zOff)) << 3);
            ulong val_28 = (z + ((long)(int)(zOff)) << 3) + 32;
            ulong val_16 = val_6 & 1152921504606846975;
            ulong val_17 = val_27 ^ (((x & ((y << 4) >> 63)) & 585610922974906400) >> 5);
            val_28 = val_28 ^ val_16;
            mem2[0] = val_28;
            int val_18 = zOff + 1;
            System.UInt64[] val_19 = z + (((long)(int)((zOff + 1))) << 3);
            ulong val_29 = (z + ((long)(int)((zOff + 1))) << 3) + 32;
            val_29 = val_29 ^ val_16;
            mem2[0] = val_29;
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[1], z:  zz, zOff:  2);
            Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  x[2], z:  zz, zOff:  4);
            ulong val_7 = x[3];
            zz[6] = Org.BouncyCastle.Math.Raw.Interleave.Expand32to64(x:  val_7);
            zz[7] = Org.BouncyCastle.Math.Raw.Interleave.Expand16to32(x:  val_7 >> 32);
        }
        public SecT239Field()
        {
        
        }
    
    }

}
