using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT233Field
    {
        // Fields
        private const ulong M41 = 2199023255551;
        private const ulong M59 = 576460752303423487;
        
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce23(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(x:  val_2, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(x:  val_2, n:  3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(x:  val_3, n:  7, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(x:  val_2, n:  14, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(x:  val_3, n:  29, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(x:  val_2, n:  58, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(x:  val_3, n:  116, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(x:  val_2, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_14;
            int val_15;
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
            
            ulong val_16 = xx[2];
            if(val_14 <= 3)
            {
                    val_14 = xx.Length;
            }
            
            if(val_14 <= 4)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_18 = xx[4];
            if(val_14 <= 5)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_19 = xx[5];
            if(val_14 <= 6)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_20 = xx[6];
            ulong val_21 = xx[7];
            ulong val_1 = val_20 >> 41;
            val_1 = val_1 ^ xx[3];
            val_1 = val_1 ^ ((xx[7]) << 23);
            val_21 = (val_21 >> 41) ^ val_18;
            val_18 = val_21 ^ (val_20 >> 31);
            ulong val_6 = val_18 << 23;
            val_16 = val_16 ^ ((xx[6]) << 23);
            val_15 = z.Length;
            ulong val_22 = xx[0];
            val_22 = (val_1 >> 41) ^ val_22;
            val_6 = val_22 ^ val_6;
            if(val_15 == 0)
            {
                    val_15 = z.Length;
            }
            
            ulong val_10 = val_16 ^ (val_19 >> 41);
            z[0] = val_6;
            if(val_15 <= 1)
            {
                    val_15 = z.Length;
            }
            
            val_10 = val_10 ^ (val_18 >> 31);
            z[1] = ((xx[1] ^ (((xx[5] ^ (xx[7]) >> 31)) << 23)) ^ ((((((xx[6] >> 41) ^ xx[3]) ^ (xx[7]) << 23) >> 41)) << 10)) ^ (val_21 >> 41);
            if(val_15 <= 2)
            {
                    val_15 = z.Length;
            }
            
            z[2] = val_10;
            ulong val_23 = val_1;
            val_23 = val_23 & 2199023255551;
            z[3] = val_23 ^ ((val_19 ^ (val_21 >> 31)) >> 31);
        }
        public static void Reduce23(ulong[] z, int zOff)
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
            val_5 = val_5 ^ (val_4 >> 41);
            val_7[(long)zOff] = val_5;
            ulong val_6 = val_7[(long)zOff + 1];
            val_6 = val_6 ^ (((z[(long)(int)((zOff + 3))][0] >> 41)) << 10);
            val_7[(long)zOff + 1] = val_6;
            val_7 = val_4 & 2199023255551;
            mem2[0] = val_7;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            ulong val_1 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[0]);
            ulong val_3 = val_1 >> 32;
            ulong val_4 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[2]);
            ulong val_5 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[3]);
            ulong val_8 = val_5 >> 27;
            ulong val_9 = val_5 ^ (val_4 >> 32);
            ulong val_10 = (Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[1])) ^ (((val_1 >> 32)) << 37);
            System.UInt64[] val_11 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            val_24 = 0;
            goto label_6;
            label_15:
            int val_27 = new int[3] {32, 117, 191}[0];
            val_25 = val_27;
            if(val_24 >= val_12.Length)
            {
                    val_25 = mem[val_12[0x0] + 32];
                val_25 = val_12[0x0] + 32;
            }
            
            int val_13 = val_27 >> 6;
            var val_14 = val_25 & 63;
            val_23 = (long)val_13;
            ulong val_28 = val_11[val_23];
            val_13 = val_23 + 1;
            val_28 = val_28 ^ (val_10 << val_14);
            val_11[val_23] = val_28;
            var val_30 = -val_25;
            val_25 = val_30 & 63;
            ulong val_16 = val_9 << val_14;
            val_30 = val_10 >> val_25;
            val_16 = val_16 | val_30;
            val_16 = val_11[val_13] ^ val_16;
            val_11[val_13] = val_16;
            ulong val_31 = val_11[val_23 + 2];
            ulong val_18 = val_8 << val_14;
            val_18 = val_18 | (val_9 >> val_25);
            val_31 = val_31 ^ val_18;
            val_11[val_23 + 2] = val_31;
            ulong val_32 = val_11[val_23 + 3];
            val_24 = 1;
            val_32 = val_32 ^ (val_8 >> val_25);
            val_11[val_23 + 3] = val_32;
            label_6:
            if(val_24 < val_12.Length)
            {
                goto label_15;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(xx:  val_11, z:  z);
            val_26 = mem[z + 24];
            val_26 = z + 24;
            ulong val_22 = val_4 & 4294967295;
            if(val_26 == 0)
            {
                    val_26 = mem[z + 24];
                val_26 = z + 24;
            }
            
            ulong val_33 = z + 32;
            val_33 = val_33 ^ val_1;
            val_22 = (val_5 << 32) | val_22;
            mem2[0] = val_33;
            ulong val_34 = z + 40;
            val_34 = val_34 ^ val_22;
            mem2[0] = val_34;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(xx:  val_1, z:  z);
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
            val_2 = x[0] ^ (val_2 >> 31);
            x = val_2 & 1;
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
            val_7 = val_7 ^ ((zz[1]) << 59);
            if(val_7 == 0)
            {
                    val_7 = zz.Length;
            }
            
            val_8 = (val_9 << 54) ^ (val_8 >> 5);
            zz[0] = val_7;
            if(val_7 <= 1)
            {
                    val_7 = zz.Length;
            }
            
            val_9 = (val_10 << 49) ^ (val_9 >> 10);
            zz[1] = val_8;
            if(val_7 <= 2)
            {
                    val_7 = zz.Length;
            }
            
            val_10 = (val_11 << 44) ^ (val_10 >> 15);
            zz[2] = val_9;
            if(val_7 <= 3)
            {
                    val_7 = zz.Length;
            }
            
            val_11 = (val_12 << 39) ^ (val_11 >> 20);
            zz[3] = val_10;
            if(val_7 <= 4)
            {
                    val_7 = zz.Length;
            }
            
            val_12 = (val_13 << 34) ^ (val_12 >> 25);
            zz[4] = val_11;
            if(val_7 <= 5)
            {
                    val_7 = zz.Length;
            }
            
            val_13 = (val_14 << 29) ^ (val_13 >> 30);
            zz[5] = val_12;
            if(val_7 <= 6)
            {
                    val_7 = zz.Length;
            }
            
            val_14 = val_14 >> 35;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplExpand(x:  x, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplExpand(x:  y, z:  val_2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_1[0], y:  val_2[0], z:  zz, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_1[1], y:  val_2[1], z:  zz, zOff:  1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_1[2], y:  val_2[2], z:  zz, zOff:  2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_1[3], y:  val_2[3], z:  zz, zOff:  3);
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
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_1[1] ^ val_1[0], y:  val_2[1] ^ val_2[0], z:  zz, zOff:  1);
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
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_1[3] ^ val_1[2], y:  val_2[3] ^ val_2[2], z:  zz, zOff:  3);
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_43 ^ val_40, y:  val_12 ^ val_10, z:  zz, zOff:  3);
            ulong[] val_14 = new ulong[3];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_40, y:  val_10, z:  val_14, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(x:  val_43, y:  val_12, z:  val_14, zOff:  1);
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplCompactExt(zz:  zz);
        }
        protected static void ImplMulwAcc(ulong x, ulong y, ulong[] z, int zOff)
        {
            int val_13;
            ulong val_14;
            ulong val_15;
            ulong val_16;
            ulong val_17;
            int val_18;
            ulong val_14 = y;
            ulong[] val_1 = new ulong[8];
            val_13 = val_1.Length;
            if(val_13 <= 1)
            {
                    val_13 = val_1.Length;
            }
            
            val_14 = val_14;
            val_1[1] = val_14;
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
            
            if(val_13 <= 3)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[3] = val_15 ^ val_14;
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
            
            if(val_13 <= 5)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[5] = val_16 ^ val_14;
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
            
            val_14 = val_17 ^ val_14;
            if(val_13 <= 7)
            {
                    val_13 = val_1.Length;
            }
            
            ulong val_4 = x & 7;
            val_1[7] = val_14;
            if(val_4 >= val_13)
            {
                    val_13 = val_1.Length;
            }
            
            ulong val_15 = val_1[val_4];
            ulong val_16 = val_1[(ulong)(x >> 3) & 7];
            var val_20 = 0;
            var val_19 = 60;
            val_15 = val_15 ^ ((val_1[(ulong)((x>>3) & 0x7)][0]) << 3);
            do
            {
                val_18 = val_1.Length;
                var val_5 = 54 & 62;
                ulong val_6 = x >> val_5;
                ulong val_7 = val_6 & 7;
                if(val_7 >= val_18)
            {
                    val_18 = val_1.Length;
            }
            
                ulong val_18 = val_1[(ulong)(val_6 >> 3) & 7];
                val_19 = val_19 - 6;
                ulong val_8 = val_1[val_7] ^ ((val_1[(ulong)(((x >> (54 & 62))>>3) & 0x7)][0]) << 3);
                val_1[val_7] = val_8 << val_5;
                val_8 = val_8 >> 10;
                val_15 = val_1[val_7] ^ val_15;
                val_20 = val_8 ^ val_20;
                var val_9 = 10 + 6;
            }
            while(val_19 > 6);
            
            ulong val_21 = z[(long)zOff];
            ulong val_10 = val_15 & 576460752303423487;
            val_21 = val_21 ^ val_10;
            z[(long)zOff] = val_21;
            ulong val_22 = z[(long)zOff + 1];
            val_22 = val_22 ^ val_10;
            z[(long)zOff + 1] = val_22;
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
        public SecT233Field()
        {
        
        }
    
    }

}
