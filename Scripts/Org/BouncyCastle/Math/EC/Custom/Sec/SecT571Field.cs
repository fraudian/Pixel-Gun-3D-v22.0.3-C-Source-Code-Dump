using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT571Field
    {
        // Fields
        private const ulong M59 = 576460752303423487;
        private const ulong RM = 17256631552825064414;
        private static readonly ulong[] ROOT_Z;
        
        // Methods
        public static void Add(ulong[] x, ulong[] y, ulong[] z)
        {
            var val_2 = 0;
            do
            {
                mem2[0] = 1152921505846136544 ^ 1152921505846136544;
                val_2 = val_2 + 1;
            }
            while(val_2 != 9);
        
        }
        private static void Add(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
        {
            var val_6 = 0;
            do
            {
                ulong val_4 = x[(long)xOff + val_6];
                val_4 = (y[(long)yOff + val_6]) ^ val_4;
                val_6 = val_6 + 1;
                z[(long)zOff + val_6] = val_4;
            }
            while(val_6 != 9);
        
        }
        private static void AddBothTo(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
        {
            var val_8 = 0;
            do
            {
                int val_6 = yOff;
                val_6 = val_6 + val_8;
                ulong val_7 = y[(long)val_6];
                val_8 = val_8 + 1;
                val_7 = ((x[(long)xOff + val_8]) ^ (z[(long)zOff + val_8])) ^ val_7;
                mem2[0] = val_7;
            }
            while(val_8 != 9);
        
        }
        public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
        {
            var val_2 = 0;
            do
            {
                mem2[0] = 1152921505846136544 ^ 1152921505846136544;
                val_2 = val_2 + 1;
            }
            while(val_2 != 18);
        
        }
        public static void AddOne(ulong[] x, ulong[] z)
        {
            var val_4 = 0;
            z[0] = x[0] ^ 1;
            do
            {
                var val_2 = val_4 + 1;
                mem2[0] = null;
                val_4 = val_4 + 1;
            }
            while(val_4 != 8);
        
        }
        public static ulong[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.FromBigInteger64(x:  x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce5(z:  val_1, zOff:  0);
            return val_1;
        }
        public static void Invert(ulong[] x, ulong[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat576.IsZero64(x:  x)) != true)
            {
                    System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat576.Create64();
                System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat576.Create64();
                System.UInt64[] val_4 = Org.BouncyCastle.Math.Raw.Nat576.Create64();
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(x:  x, z:  val_4);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(x:  val_4, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(x:  val_2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_2, n:  2, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_4, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_2, n:  5, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_3, n:  5, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_2, n:  15, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_4);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_4, n:  30, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_2, n:  30, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_2, n:  60, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_3, n:  60, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_2, n:  180, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(x:  val_3, n:  180, z:  val_3);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_3, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  val_4, z:  z);
                return;
            }
            
            System.InvalidOperationException val_5 = new System.InvalidOperationException();
        }
        public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void Reduce(ulong[] xx, ulong[] z)
        {
            int val_14;
            int val_15;
            val_14 = xx.Length;
            if(val_14 <= 9)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_17 = xx[9];
            if(val_14 <= 17)
            {
                    val_14 = xx.Length;
            }
            
            ulong val_18 = xx[17];
            ulong val_1 = val_17 ^ (val_18 >> 59);
            val_1 = val_1 ^ (val_18 >> 57);
            ulong val_2 = val_1 ^ (val_18 >> 54);
            ulong val_3 = val_18 << 7;
            val_3 = val_3 ^ ((xx[17]) << 5);
            val_3 = val_3 ^ ((xx[17]) << 10);
            val_3 = val_3 ^ ((xx[17]) << 15);
            var val_22 = 0;
            val_2 = val_2 ^ (val_18 >> 49);
            do
            {
                ulong val_20 = xx[val_22];
                xx[val_22] = val_3 ^ xx[8] ^ (val_20 >> 59);
                xx[val_22] = xx[val_22] ^ (val_20 >> 57);
                xx[val_22] = xx[val_22] ^ (val_20 >> 54);
                var val_6 = (val_22 + 16) - 8;
                mem2[0] = xx[val_22] ^ (val_20 >> 49);
                val_6 = val_6 - 1;
                ulong val_8 = val_20 << 7;
                val_8 = val_8 ^ ((xx[0x0][16]) << 5);
                val_8 = val_8 ^ ((xx[0x0][16]) << 10);
                val_8 = val_8 ^ ((xx[0x0][16]) << 15);
                val_22 = val_22 - 1;
            }
            while((val_6 + 9) > 10);
            
            ulong val_11 = val_17 >> 57;
            val_11 = val_11 ^ (val_17 >> 59);
            val_11 = val_11 ^ (val_17 >> 54);
            val_11 = val_11 ^ (val_17 >> 49);
            val_17 = val_11 ^ val_8 ^ xx[val_22];
            z[1] = val_17;
            val_15 = z.Length;
            ulong val_23 = xx[0];
            val_2 = val_2 << 15;
            if(val_15 <= 8)
            {
                    val_15 = z.Length;
            }
            
            ulong val_24 = z[8];
            ulong val_15 = (val_2 << 7) ^ (val_2 << 5);
            val_15 = val_15 ^ (val_2 << 10);
            val_15 = val_15 ^ val_2;
            val_15 = val_15 ^ val_23;
            ulong val_16 = val_24 >> 59;
            val_15 = val_15 ^ (val_24 >> 59);
            val_15 = val_15 ^ (((z[8] >> 59)) << 2);
            val_15 = val_15 ^ (((z[8] >> 59)) << 5);
            val_23 = val_15 ^ (((z[8] >> 59)) << 10);
            if(val_15 == 0)
            {
                    val_15 = z.Length;
            }
            
            val_24 = val_24 & 576460752303423487;
            z[0] = val_23;
            z[8] = val_24;
        }
        public static void Reduce5(ulong[] z, int zOff)
        {
            int val_3;
            System.UInt64[] val_6 = z;
            val_3 = z.Length;
            int val_1 = zOff + 8;
            if(val_1 >= val_3)
            {
                    val_3 = z.Length;
            }
            
            ulong val_3 = val_6[(long)val_1];
            ulong val_2 = val_3 >> 59;
            ulong val_4 = val_6[(long)zOff];
            var val_5 = 0;
            val_5 = val_5 ^ (((z[(long)(int)((zOff + 8))][0] >> 59)) << 5);
            val_5 = val_5 | (((z[(long)(int)((zOff + 8))][0] >> 59)) << 10);
            val_4 = val_4 ^ val_5;
            val_6[(long)zOff] = val_4;
            val_6 = val_3 & 576460752303423487;
            mem2[0] = val_6;
        }
        public static void Sqrt(ulong[] x, ulong[] z)
        {
            var val_7;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.Create64();
            System.UInt64[] val_2 = Org.BouncyCastle.Math.Raw.Nat576.Create64();
            var val_9 = 0;
            do
            {
                val_1[val_9] = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  null);
                val_9 = val_9 + 1;
                var val_6 = (0 + 1) + 1;
                val_2[val_9] = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  null);
            }
            while(val_9 != 4);
            
            ulong val_11 = Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x:  x[8]);
            val_1[4] = val_11 & 4294967295;
            val_11 = val_11 >> 32;
            val_2[4] = val_11;
            val_7 = null;
            val_7 = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(x:  val_2, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ROOT_Z, z:  z);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(x:  z, y:  val_1, z:  z);
        }
        public static void Square(ulong[] x, ulong[] z)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareAddToExt(ulong[] x, ulong[] zz)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddExt(xx:  zz, yy:  val_1, zz:  zz);
        }
        public static void SquareN(ulong[] x, int n, ulong[] z)
        {
            var val_2;
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static uint Trace(ulong[] x)
        {
            int val_2;
            ulong val_3;
            val_2 = x.Length;
            if(val_2 == 0)
            {
                    val_2 = x.Length;
            }
            
            if(val_2 <= 8)
            {
                    val_2 = x.Length;
            }
            
            ulong val_3 = x[8];
            val_3 = val_3;
            if(val_2 <= 8)
            {
                    val_3 = x[8];
            }
            
            ulong val_1 = val_3 >> 49;
            val_1 = val_1 ^ x[0];
            val_3 = val_3 >> 57;
            val_3 = val_1 ^ val_3;
            x = val_3 & 1;
            return (uint)x;
        }
        protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
        {
            ulong[] val_1 = new ulong[144];
            System.Array.Copy(sourceArray:  y, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  9, length:  9);
            var val_18 = 8;
            do
            {
                ulong val_2 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit64(len:  9, x:  val_1, xOff:  9, c:  0, z:  val_1, zOff:  18);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce5(z:  val_1, zOff:  18);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(x:  val_1, xOff:  9, y:  val_1, yOff:  18, z:  val_1, zOff:  18 + 9);
                val_18 = val_18 - 1;
                var val_4 = 18 + 18;
            }
            while(val_18 > 1);
            
            ulong[] val_5 = new ulong[0];
            ulong val_6 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits64(len:  val_1.Length, x:  val_1, xOff:  0, bits:  4, c:  0, z:  val_5, zOff:  0);
            do
            {
                do
            {
                ulong val_19 = x[1];
                val_19 = val_19 >> 56;
                ulong val_7 = val_19 & 15;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddBothTo(x:  val_1, xOff:  val_7 + (val_7 << 3), y:  val_5, yOff:  ((uint)(val_19 >> 4) & 15) + (((uint)(val_19 >> 4) & 15) << 3), z:  zz, zOff:  1 - 1);
                var val_11 = 5 + 2;
            }
            while(1 < 7);
            
                ulong val_12 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits64(len:  16, z:  zz, zOff:  0, bits:  8, c:  0);
            }
            while(56 > 7);
            
            var val_20 = 56;
            do
            {
                var val_21 = 0;
                do
            {
                System.UInt64[] val_14 = 1152921505846136544 >> (val_20 & 56);
                val_20 = val_14 & 15;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddBothTo(x:  val_1, xOff:  val_20 + (val_20 << 3), y:  val_5, yOff:  ((uint)(val_14 >> 4) & 15) + (((uint)(val_14 >> 4) & 15) << 3), z:  zz, zOff:  0);
                val_21 = val_21 + 2;
            }
            while(val_21 < 7);
            
                if(val_20 < 1)
            {
                    return;
            }
            
                ulong val_17 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits64(len:  18, z:  zz, zOff:  0, bits:  8, c:  0);
            }
            while(val_20 >= 1);
        
        }
        protected static void ImplMulwAcc(ulong[] xs, ulong y, ulong[] z, int zOff)
        {
            int val_9;
            ulong val_10;
            int val_11;
            ulong[] val_1 = new ulong[32];
            var val_15 = 0;
            val_1[1] = y;
            do
            {
                var val_2 = val_15 + 2;
                if((val_2 >> 1) < val_1.Length)
            {
                    val_9 = val_1.Length & 4294967295;
            }
            else
            {
                    val_9 = val_1.Length;
            }
            
                val_10 = (val_1[(long)(val_2 >> 1) & 2147483647]) << 1;
                val_1[val_15] = val_10;
                val_11 = val_1.Length;
                if(val_2 >= val_11)
            {
                    val_10 = val_1[val_15];
                val_11 = val_1.Length;
            }
            
                val_10 = val_10 ^ y;
                val_15 = val_15 + 2;
                val_1[val_15] = val_10;
            }
            while(((val_2 + 1) - 1) < 30);
            
            var val_23 = 0;
            do
            {
                ulong val_16 = xs[val_23];
                var val_20 = 4;
                ulong val_7 = (val_1[val_16 & 31]) ^ 0;
                var val_19 = 0;
                do
            {
                var val_8 = 65 - 5;
                ulong val_9 = val_16 >> val_8;
                ulong val_18 = val_1[val_9 & 31];
                val_9 = val_18 << val_8;
                val_18 = val_18 >> val_20;
                val_7 = val_9 ^ val_7;
                val_19 = val_18 ^ val_19;
                val_20 = val_20 + 5;
            }
            while(val_8 > 5);
            
                var val_21 = 0;
                do
            {
                val_16 = 8628315776412532207 & (val_16 >> 1);
                ulong val_11 = y << val_21;
                val_21 = val_21 + 1;
                val_11 = val_16 & (val_11 >> 63);
                val_19 = val_11 ^ val_19;
            }
            while(val_21 != 4);
            
                int val_22 = zOff;
                val_22 = val_23 + val_22;
                System.UInt64[] val_12 = z + (((long)(int)((0 + zOff))) << 3);
                ulong val_24 = (z + ((long)(int)((0 + zOff))) << 3) + 32;
                val_23 = val_23 + 1;
                val_24 = val_24 ^ val_7;
                mem2[0] = val_24;
            }
            while(val_23 != 9);
            
            int val_25 = zOff;
            val_25 = val_25 + 9;
            System.UInt64[] val_13 = z + (((long)(int)((zOff + 9))) << 3);
            ulong val_26 = (z + ((long)(int)((zOff + 9))) << 3) + 32;
            val_26 = val_26 ^ val_19;
            mem2[0] = val_26;
        }
        protected static void ImplSquare(ulong[] x, ulong[] zz)
        {
            var val_2 = 0;
            var val_1 = 0;
            do
            {
                Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x:  null, z:  zz, zOff:  0);
                val_1 = val_1 + 1;
                val_2 = val_2 + 2;
            }
            while(val_1 != 9);
        
        }
        public SecT571Field()
        {
        
        }
        private static SecT571Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.ROOT_Z = new ulong[9] {-7351059829448122069, 2557030308994936981, 1278515154489112778, 603229329973017701, -8885729398731880712, -3888753713477901444, 7315164714623111614, 3657581809711581279, 1864819152118973447};
        }
    
    }

}
