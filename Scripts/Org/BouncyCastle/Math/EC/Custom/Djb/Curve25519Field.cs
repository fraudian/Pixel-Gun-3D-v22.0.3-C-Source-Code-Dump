using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
    internal class Curve25519Field
    {
        // Fields
        internal static readonly uint[] P;
        private const uint P7 = 2147483647;
        private static readonly uint[] PExt;
        private const uint PInv = 19;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_4;
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat256.Add(x:  x, y:  y, z:  z);
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv)) == false)
            {
                    return;
            }
            
            int val_3 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z:  z);
        }
        public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
        {
            var val_4;
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat.Add(len:  16, x:  xx, y:  yy, z:  zz);
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  16, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt)) == false)
            {
                    return;
            }
            
            int val_3 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPExtFrom(zz:  zz);
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_4;
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat.Inc(len:  8, x:  x, z:  z);
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv)) == false)
            {
                    return;
            }
            
            int val_3 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z:  z);
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.FromBigInteger(x:  x);
            goto label_1;
            label_6:
            val_4 = null;
            val_4 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat256.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv, z:  val_1);
            label_1:
            val_5 = null;
            val_5 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv)) == true)
            {
                goto label_6;
            }
            
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            var val_4;
            if((x[0] & 1) == 0)
            {
                    uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  8, x:  x, c:  0, z:  z);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat256.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv, z:  z);
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  8, z:  z, c:  0);
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            var val_4;
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x:  x, y:  y, zz:  zz);
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  16, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt)) == false)
            {
                    return;
            }
            
            int val_3 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPExtFrom(zz:  zz);
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero(x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat256.Zero(z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat256.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            var val_9;
            uint val_9 = xx[3];
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  8, x:  xx, xOff:  8, c:  val_9, z:  z, zOff:  0);
            uint val_10 = Org.BouncyCastle.Math.Raw.Nat256.MulByWordAddTo(x:  19, y:  xx, z:  z);
            val_10 = val_10 << 1;
            uint val_11 = z[3];
            uint val_3 = val_10 + (val_9 >> 31);
            val_3 = val_3 + (val_11 >> 31);
            uint val_4 = val_11 & 2147483647;
            val_4 = (Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  7, x:  val_3 * 19, z:  z)) + val_4;
            z[3] = val_4;
            if(val_4 < 2147483647)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv)) == false)
            {
                    return;
            }
            
            int val_8 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z:  z);
        }
        public static void Reduce27(uint x, uint[] z)
        {
            var val_6;
            uint val_1 = z[3] & 2147483647;
            val_1 = (Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  7, x:  W9 * 19, z:  z)) + val_1;
            z[3] = val_1;
            if(val_1 < 2147483647)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv)) == false)
            {
                    return;
            }
            
            int val_5 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat256.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat256.Sub(x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            uint val_2 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.AddPTo(z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  16, x:  xx, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            uint val_2 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.AddPExtTo(zz:  zz);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_4;
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  8, x:  x, c:  0, z:  z);
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv)) == false)
            {
                    return;
            }
            
            int val_3 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z:  z);
        }
        private static uint AddPTo(uint[] z)
        {
            int val_5;
            uint val_6;
            int val_7;
            val_5 = z.Length;
            if(val_5 == 0)
            {
                    val_5 = z.Length;
            }
            
            uint val_1 = z[0] - 19;
            z[0] = val_1;
            if((val_1 >> 32) == 0)
            {
                    val_6 = -2147483648;
            }
            else
            {
                    int val_3 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  7, z:  z, zPos:  1);
                val_6 = (-2147483648) + (val_3 << );
            }
            
            val_7 = z.Length;
            if(val_7 <= 7)
            {
                    val_7 = z.Length;
            }
            
            val_6 = val_6 + z[3];
            z[3] = val_6;
            val_3 = val_6 >> 32;
            return (uint)val_3;
        }
        private static uint AddPExtTo(uint[] zz)
        {
            var val_8;
            uint val_9;
            int val_10;
            var val_11;
            var val_12;
            uint val_7 = zz[0];
            val_8 = null;
            val_8 = null;
            val_7 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt + 32) + val_7;
            zz[0] = val_7;
            if((val_7 & 4294967296) == 0)
            {
                    val_9 = 18;
            }
            else
            {
                    val_9 = (Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  8, z:  zz, zPos:  1)) - 19;
            }
            
            val_10 = zz.Length;
            if(val_10 <= 8)
            {
                    val_10 = zz.Length;
            }
            
            val_9 = val_9 + zz[4];
            zz[4] = val_9;
            if((val_9 >> 32) == 0)
            {
                    val_11 = 0;
            }
            else
            {
                    val_11 = (long)Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  15, z:  zz, zPos:  9);
            }
            
            val_12 = null;
            val_12 = null;
            var val_10 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt + 92;
            val_10 = val_10 + 1;
            uint val_5 = (val_11 + zz[7]) + val_10;
            zz[7] = val_5;
            return (uint)val_5 >> 32;
        }
        private static int SubPFrom(uint[] z)
        {
            int val_3;
            uint val_4;
            int val_5;
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            uint val_1 = z[0] + 19;
            val_4 = -2147483648;
            z[0] = val_1;
            if((val_1 & 4294967296) != 0)
            {
                    uint val_2 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zPos:  1);
                val_4 = val_4 + val_2;
            }
            
            val_5 = z.Length;
            if(val_5 <= 7)
            {
                    val_5 = z.Length;
            }
            
            val_4 = val_4 + z[3];
            z[3] = val_4;
            val_2 = val_4 >> 32;
            return (int)val_2;
        }
        private static int SubPExtFrom(uint[] zz)
        {
            var val_7;
            uint val_8;
            int val_9;
            var val_10;
            var val_11;
            uint val_6 = zz[0];
            val_7 = null;
            val_7 = null;
            var val_7 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt + 32;
            val_6 = val_6 - val_7;
            val_7 = val_6 >> 32;
            zz[0] = val_6;
            if(val_7 == 0)
            {
                    val_8 = 19;
            }
            else
            {
                    val_8 = ((long)Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  8, z:  zz, zPos:  1)) + 19;
            }
            
            val_9 = zz.Length;
            if(val_9 <= 8)
            {
                    val_9 = zz.Length;
            }
            
            val_8 = val_8 + zz[4];
            zz[4] = val_8;
            if((val_8 >> 32) == 0)
            {
                    val_10 = 0;
            }
            else
            {
                    val_10 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  15, z:  zz, zPos:  9);
            }
            
            val_11 = null;
            val_11 = null;
            var val_10 = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt + 92;
            val_10 = val_10 + 1;
            val_10 = zz[7] - val_10;
            uint val_4 = val_10 + val_10;
            zz[7] = val_4;
            return (int)val_4 >> 32;
        }
        public Curve25519Field()
        {
        
        }
        private static Curve25519Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv = new uint[8] {-19, -1, -1, -1, -1, -1, -1, 2147483647};
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt = new uint[16] {361, 0, 0, 0, 0, 0, 0, 0, -19, -1, -1, -1, -1, -1, -1, 1073741823};
        }
    
    }

}
