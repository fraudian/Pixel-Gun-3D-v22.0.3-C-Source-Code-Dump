using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT283Field
    {
        // Fields
        private const ulong M27 = 134217727;
        private const ulong M57 = 144115188075855871;
        private static readonly ulong[] ROOT_Z;
        
        // Methods
        public static void Add(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_11 = y;
            ulong val_1 = x[0];
            val_1 = val_11[0] ^ val_1;
            z[0] = val_1;
            ulong val_3 = x[1];
            val_3 = val_11[1] ^ val_3;
            z[1] = val_3;
            ulong val_5 = x[2];
            val_5 = val_11[2] ^ val_5;
            z[2] = val_5;
            ulong val_7 = x[3];
            val_7 = val_11[3] ^ val_7;
            z[3] = val_7;
            val_11 = val_11[4] ^ x[4];
            z[4] = val_11;
        }
        public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
        {
            System.UInt64[] val_19 = yy;
            ulong val_1 = xx[0];
            val_1 = val_19[0] ^ val_1;
            zz[0] = val_1;
            ulong val_3 = xx[1];
            val_3 = val_19[1] ^ val_3;
            zz[1] = val_3;
            ulong val_5 = xx[2];
            val_5 = val_19[2] ^ val_5;
            zz[2] = val_5;
            ulong val_7 = xx[3];
            val_7 = val_19[3] ^ val_7;
            zz[3] = val_7;
            ulong val_9 = xx[4];
            val_9 = val_19[4] ^ val_9;
            zz[4] = val_9;
            ulong val_11 = xx[5];
            val_11 = val_19[5] ^ val_11;
            zz[5] = val_11;
            ulong val_13 = xx[6];
            val_13 = val_19[6] ^ val_13;
            zz[6] = val_13;
            ulong val_15 = xx[7];
            val_15 = val_19[7] ^ val_15;
            zz[7] = val_15;
            val_19 = val_19[8] ^ xx[8];
            zz[8] = val_19;
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
        }
        public static ulong[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat320.FromBigInteger64(x:  x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce37(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat320.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat320.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat320.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(x:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_2, n:  2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_3, n:  4, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_2, n:  8, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(x:  val_3, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_3, y:  x, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_3, n:  17, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(x:  val_2, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_2, n:  35, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_3, n:  70, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(x:  val_2, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_2, y:  x, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(x:  val_2, n:  141, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_3, y:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(x:  val_3, z:  z);
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat320.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat320.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_25;
            ulong val_26;
            ulong val_27;
            var val_28;
            var val_29;
            val_25 = xx.Length;
            if(val_25 == 0)
            {
                    val_25 = xx.Length;
            }
            
            if(val_25 <= 1)
            {
                    val_25 = xx.Length;
            }
            
            if(val_25 <= 2)
            {
                    val_25 = xx.Length;
            }
            
            if(val_25 <= 3)
            {
                    val_25 = xx.Length;
            }
            
            if(val_25 <= 4)
            {
                    val_25 = xx.Length;
            }
            
            if(val_25 <= 5)
            {
                    val_25 = xx.Length;
            }
            
            ulong val_27 = xx[5];
            if(val_25 <= 6)
            {
                    val_25 = xx.Length;
            }
            
            ulong val_28 = xx[6];
            if(val_25 <= 7)
            {
                    val_25 = xx.Length;
            }
            
            ulong val_29 = xx[7];
            ulong val_31 = xx[1];
            ulong val_30 = xx[8];
            ulong val_1 = xx[3] ^ (val_29 >> 22);
            ulong val_2 = xx[2] ^ (val_28 >> 22);
            val_31 = val_31 ^ (val_27 >> 22);
            val_1 = val_1 ^ (val_29 >> 27);
            val_2 = val_2 ^ (val_28 >> 27);
            val_31 = val_31 ^ (val_27 >> 27);
            val_1 = val_1 ^ (val_29 >> 20);
            val_2 = val_2 ^ (val_28 >> 20);
            val_31 = val_31 ^ (val_27 >> 20);
            ulong val_7 = (val_2 ^ (val_28 >> 15)) ^ ((xx[7]) << 42);
            ulong val_9 = (xx[4] ^ (val_30 >> 22)) ^ (val_30 >> 27);
            val_9 = val_9 ^ (val_30 >> 20);
            val_9 = val_9 ^ (val_30 >> 15);
            val_26 = val_27 << 37;
            val_27 = val_27 << 49;
            if(z == 0)
            {
                    val_27 = val_27;
                val_26 = val_26;
            }
            
            ulong val_32 = xx[0];
            val_28 = (val_1 ^ (val_29 >> 15)) ^ ((xx[8]) << 42);
            val_7 = val_7 ^ ((xx[7]) << 37);
            val_32 = (val_27 << 42) ^ val_32;
            val_32 = val_32 ^ val_26;
            val_32 = val_32 ^ (val_27 << 44);
            ulong val_15 = val_32 ^ val_27;
            val_29 = mem[z + 24];
            val_29 = z + 24;
            val_15 = val_15 ^ (val_9 >> 27);
            val_15 = val_15 ^ (((((((xx[4] ^ (xx[8]) >> 22) ^ (xx[8]) >> 27) ^ (xx[8]) >> 20) ^ (xx[8]) >> 15) >> 27)) << 5);
            val_15 = val_15 ^ (((((((xx[4] ^ (xx[8]) >> 22) ^ (xx[8]) >> 27) ^ (xx[8]) >> 20) ^ (xx[8]) >> 15) >> 27)) << 7);
            if(val_29 == 0)
            {
                    val_29 = mem[z + 24];
                val_29 = z + 24;
                val_28 = val_28;
            }
            
            val_7 = val_7 ^ ((xx[7]) << 44);
            mem2[0] = val_15 ^ (((((((xx[4] ^ (xx[8]) >> 22) ^ (xx[8]) >> 27) ^ (xx[8]) >> 20) ^ (xx[8]) >> 15) >> 27)) << 12);
            if(val_29 <= 1)
            {
                    val_29 = mem[z + 24];
                val_29 = z + 24;
            }
            
            val_7 = val_7 ^ ((xx[7]) << 49);
            mem2[0] = ((((val_31 ^ (val_27 >> 15)) ^ ((xx[6]) << 42)) ^ ((xx[6]) << 37)) ^ ((xx[6]) << 44)) ^ ((xx[6]) << 49);
            if(val_29 <= 2)
            {
                    val_29 = mem[z + 24];
                val_29 = z + 24;
            }
            
            mem2[0] = val_7;
            if(val_29 <= 3)
            {
                    val_29 = mem[z + 24];
                val_29 = z + 24;
            }
            
            mem2[0] = ((val_28 ^ ((xx[8]) << 37)) ^ ((xx[8]) << 44)) ^ ((xx[8]) << 49);
            mem2[0] = val_9 & 134217727;
        }
        public static void Reduce37(ulong[] z, int zOff)
        {
            int val_3;
            System.UInt64[] val_6 = z;
            val_3 = z.Length;
            int val_1 = zOff + 4;
            if(val_1 >= val_3)
            {
                    val_3 = z.Length;
            }
            
            ulong val_3 = val_6[(long)val_1];
            ulong val_2 = val_3 >> 27;
            ulong val_4 = val_6[(long)zOff];
            var val_5 = 0;
            val_5 = val_5 ^ (((z[(long)(int)((zOff + 4))][0] >> 27)) << 7);
            val_5 = val_5 ^ (((z[(long)(int)((zOff + 4))][0] >> 27)) << 12);
            val_4 = val_5 ^ val_4;
            val_6[(long)zOff] = val_4;
            val_6 = val_3 & 134217727;
            mem2[0] = val_6;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            var val_9;
            int val_10;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat320.Create64();
            val_1[0] = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[1]);
            val_1[1] = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[3]);
            ulong val_6 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[4]);
            val_1[2] = val_6 >> 32;
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ROOT_Z, z:  z);
            val_10 = z.Length;
            if(val_10 == 0)
            {
                    val_10 = z.Length;
            }
            
            ulong val_14 = z[0];
            val_14 = val_14 ^ (Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[0]));
            z[0] = val_14;
            if(val_10 <= 1)
            {
                    val_10 = z.Length;
            }
            
            ulong val_15 = z[1];
            val_15 = val_15 ^ (Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[2]));
            z[1] = val_15;
            ulong val_16 = z[2];
            val_16 = val_16 ^ (val_6 & 4294967295);
            z[2] = val_16;
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  9);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  9);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create64(len:  9);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(xx:  val_1, z:  z);
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
            
            ulong val_2 = x[4];
            val_2 = x[0] ^ (val_2 >> 15);
            x = val_2 & 1;
            return (uint)x;
        }
        protected static void ImplCompactExt(ulong[] zz)
        {
            int val_18 = zz.Length;
            if(val_18 == 0)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_18 = zz[0];
            if(val_18 <= 1)
            {
                    val_18 = zz.Length;
            }
            
            if(val_18 <= 2)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_20 = zz[2];
            if(val_18 <= 3)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_21 = zz[3];
            if(val_18 <= 4)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_22 = zz[4];
            if(val_18 <= 5)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_23 = zz[5];
            if(val_18 <= 6)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_24 = zz[6];
            if(val_18 <= 7)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_25 = zz[7];
            if(val_18 <= 8)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_26 = zz[8];
            if(val_18 <= 9)
            {
                    val_18 = zz.Length;
            }
            
            ulong val_27 = zz[9];
            val_18 = val_18 ^ ((zz[1]) << 57);
            if(val_18 == 0)
            {
                    val_18 = zz.Length;
            }
            
            zz[0] = val_18;
            if(val_18 <= 1)
            {
                    val_18 = zz.Length;
            }
            
            zz[1] = (val_20 << 50) ^ (zz[1] >> 7);
            if(val_18 <= 2)
            {
                    val_18 = zz.Length;
            }
            
            zz[2] = (val_21 << 43) ^ (val_20 >> 14);
            if(val_18 <= 3)
            {
                    val_18 = zz.Length;
            }
            
            zz[3] = (val_22 << 36) ^ (val_21 >> 21);
            if(val_18 <= 4)
            {
                    val_18 = zz.Length;
            }
            
            zz[4] = (val_23 << 29) ^ (val_22 >> 28);
            if(val_18 <= 5)
            {
                    val_18 = zz.Length;
            }
            
            zz[5] = (val_24 << 22) ^ (val_23 >> 35);
            if(val_18 <= 6)
            {
                    val_18 = zz.Length;
            }
            
            zz[6] = (val_25 << 15) ^ (val_24 >> 42);
            if(val_18 <= 7)
            {
                    val_18 = zz.Length;
            }
            
            zz[7] = (val_26 << 8) ^ (val_25 >> 49);
            if(val_18 <= 8)
            {
                    val_18 = zz.Length;
            }
            
            zz[8] = (val_27 << 1) ^ (val_26 >> 56);
            zz[9] = val_27 >> 63;
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
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            val_2 = val_2 >> 57;
            z[0] = val_2 & 144115188075855871;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            val_3 = val_3 >> 50;
            z[1] = val_2;
            if(val_3 <= 2)
            {
                    val_3 = z.Length;
            }
            
            val_4 = val_4 >> 43;
            z[2] = val_3;
            if(val_3 <= 3)
            {
                    val_3 = z.Length;
            }
            
            z[3] = val_4;
            z[4] = x[4];
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            int val_25;
            int val_26;
            int val_27;
            int val_28;
            int val_29;
            int val_30;
            int val_31;
            int val_32;
            int val_33;
            int val_34;
            int val_35;
            int val_36;
            int val_37;
            int val_38;
            int val_39;
            ulong[] val_1 = new ulong[5];
            System.UInt64[] val_57 = val_1;
            ulong[] val_2 = new ulong[5];
            System.UInt64[] val_59 = val_2;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplExpand(x:  x, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplExpand(x:  y, z:  val_2);
            ulong[] val_3 = new ulong[26];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[0], y:  val_59[0], z:  val_3, zOff:  0);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[1], y:  val_59[1], z:  val_3, zOff:  2);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[2], y:  val_59[2], z:  val_3, zOff:  4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[3], y:  val_59[3], z:  val_3, zOff:  6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[4], y:  val_59[4], z:  val_3, zOff:  8);
            val_25 = val_2.Length;
            if(val_25 == 0)
            {
                    val_25 = val_2.Length;
            }
            
            val_26 = val_1.Length;
            if(val_26 == 0)
            {
                    val_26 = val_1.Length;
            }
            
            val_27 = val_2.Length;
            if(val_27 == 0)
            {
                    val_27 = val_2.Length;
            }
            
            val_28 = val_1.Length;
            ulong val_42 = val_59[2];
            if(val_28 <= 2)
            {
                    val_28 = val_1.Length;
            }
            
            val_29 = val_2.Length;
            if(val_29 <= 2)
            {
                    val_29 = val_2.Length;
            }
            
            val_30 = val_1.Length;
            ulong val_46 = val_59[4];
            if(val_30 <= 3)
            {
                    val_30 = val_1.Length;
            }
            
            val_31 = val_2.Length;
            if(val_31 <= 3)
            {
                    val_31 = val_2.Length;
            }
            
            ulong val_50 = val_59[4];
            ulong val_52 = val_57[0];
            val_52 = val_57[2] ^ val_52;
            val_42 = val_42 ^ val_59[0];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[3] ^ val_52, y:  val_59[3] ^ val_42, z:  val_3, zOff:  18);
            val_50 = val_50 ^ val_59[3];
            ulong val_6 = val_57[1] ^ val_57[0];
            ulong val_7 = val_59[1] ^ val_59[0];
            ulong val_8 = val_57[4] ^ val_57[3];
            val_46 = val_46 ^ val_59[2];
            ulong val_9 = val_57[4] ^ val_57[2];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57[1] ^ val_9, y:  val_59[1] ^ val_46, z:  val_3, zOff:  20);
            ulong val_12 = val_50 ^ val_7;
            ulong val_13 = val_8 ^ val_6;
            val_57 = val_57[2] ^ val_13;
            val_59 = val_59[2] ^ val_12;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_13, y:  val_12, z:  val_3, zOff:  22);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_57, y:  val_59, z:  val_3, zOff:  24);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_6, y:  val_7, z:  val_3, zOff:  10);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_52, y:  val_42, z:  val_3, zOff:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_9, y:  val_46, z:  val_3, zOff:  14);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(x:  val_8, y:  val_50, z:  val_3, zOff:  16);
            mem2[0] = val_3[0];
            mem2[0] = val_3[9];
            val_32 = val_3.Length;
            if(val_32 == 0)
            {
                    val_32 = val_3.Length;
            }
            
            ulong val_62 = val_3[0];
            if(val_32 <= 1)
            {
                    val_32 = val_3.Length;
            }
            
            ulong val_14 = val_3[1] ^ val_62;
            if(val_32 <= 2)
            {
                    val_32 = val_3.Length;
            }
            
            ulong val_15 = val_3[2] ^ val_14;
            val_62 = val_3[10] ^ val_15;
            mem2[0] = val_62;
            val_33 = val_3.Length;
            if(val_33 <= 3)
            {
                    val_33 = val_3.Length;
            }
            
            ulong val_66 = val_3[3];
            if(val_33 <= 4)
            {
                    val_33 = val_3.Length;
            }
            
            if(val_33 <= 11)
            {
                    val_33 = val_3.Length;
            }
            
            val_66 = val_3[4] ^ val_66;
            ulong val_16 = val_66 ^ val_15;
            val_16 = val_16 ^ val_3[11];
            val_15 = val_16 ^ val_3[12];
            mem2[0] = val_15;
            val_34 = val_3.Length;
            if(val_34 <= 5)
            {
                    val_34 = val_3.Length;
            }
            
            ulong val_70 = val_3[5];
            if(val_34 <= 6)
            {
                    val_34 = val_3.Length;
            }
            
            if(val_34 <= 8)
            {
                    val_34 = val_3.Length;
            }
            
            if(val_34 <= 13)
            {
                    val_34 = val_3.Length;
            }
            
            if(val_34 <= 14)
            {
                    val_34 = val_3.Length;
            }
            
            val_70 = val_3[6] ^ val_70;
            ulong val_17 = val_66 ^ val_14;
            if(val_34 <= 18)
            {
                    val_34 = val_3.Length;
            }
            
            val_17 = val_17 ^ val_70;
            if(val_34 <= 22)
            {
                    val_34 = val_3.Length;
            }
            
            ulong val_18 = val_3[14] ^ val_3[13];
            val_17 = val_17 ^ val_3[8];
            val_18 = val_18 ^ val_17;
            ulong val_19 = val_18 ^ val_3[18];
            val_19 = val_19 ^ val_3[22];
            val_17 = val_19 ^ val_3[24];
            mem2[0] = val_17;
            val_35 = val_3.Length;
            if(val_35 <= 7)
            {
                    val_35 = val_3.Length;
            }
            
            ulong val_78 = val_3[7];
            if(val_35 <= 8)
            {
                    val_35 = val_3.Length;
            }
            
            if(val_35 <= 9)
            {
                    val_35 = val_3.Length;
            }
            
            ulong val_20 = val_3[8] ^ val_78;
            ulong val_21 = val_20 ^ val_3[9];
            val_78 = val_3[17] ^ val_21;
            mem2[0] = val_78;
            val_36 = val_3.Length;
            if(val_36 <= 15)
            {
                    val_36 = val_3.Length;
            }
            
            val_20 = val_21 ^ val_70;
            val_20 = val_20 ^ val_3[15];
            val_70 = val_20 ^ val_3[16];
            mem2[0] = val_70;
            val_37 = val_3.Length;
            if(val_37 <= 19)
            {
                    val_37 = val_3.Length;
            }
            
            if(val_37 <= 20)
            {
                    val_37 = val_3.Length;
            }
            
            if(val_37 <= 25)
            {
                    val_37 = val_3.Length;
            }
            
            if(val_37 <= 24)
            {
                    val_37 = val_3.Length;
            }
            
            if(val_37 <= 18)
            {
                    val_37 = val_3.Length;
            }
            
            ulong val_88 = val_3[18];
            ulong val_22 = val_3[20] ^ val_3[19];
            val_22 = val_22 ^ val_3[25];
            val_20 = val_70 ^ val_62;
            ulong val_23 = val_22 ^ val_3[24];
            val_22 = val_20 ^ val_23;
            val_22 = val_22 ^ val_88;
            val_88 = val_22 ^ val_3[23];
            mem2[0] = val_88;
            val_38 = val_3.Length;
            if(val_38 <= 21)
            {
                    val_38 = val_3.Length;
            }
            
            ulong val_92 = val_15;
            val_92 = val_78 ^ val_92;
            val_92 = val_92 ^ val_23;
            val_92 = val_92 ^ val_3[21];
            val_23 = val_92 ^ val_3[22];
            mem2[0] = val_23;
            val_39 = val_3.Length;
            if(val_39 == 0)
            {
                    val_39 = val_3.Length;
            }
            
            ulong val_93 = val_3[0];
            if(val_39 <= 9)
            {
                    val_39 = val_3.Length;
            }
            
            if(val_39 <= 21)
            {
                    val_39 = val_3.Length;
            }
            
            if(val_39 <= 23)
            {
                    val_39 = val_3.Length;
            }
            
            ulong val_24 = val_18 ^ val_93;
            val_24 = val_24 ^ val_3[9];
            val_24 = val_24 ^ val_3[21];
            val_24 = val_24 ^ val_3[23];
            val_93 = val_24 ^ val_3[25];
            mem2[0] = val_93;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplCompactExt(zz:  zz);
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
            if(val_3 < 4)
            {
                goto label_3;
            }
            
            zz[8] = Org.BouncyCastle.Math.Raw.Interleave.Expand32to64(x:  x[4]);
        }
        public SecT283Field()
        {
        
        }
        private static SecT283Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ROOT_Z = new ulong[5] {578927163257073676, -4381988404967193808, 901599571319195778, 2308237883120689160, -9070240844841222144};
        }
    
    }

}
