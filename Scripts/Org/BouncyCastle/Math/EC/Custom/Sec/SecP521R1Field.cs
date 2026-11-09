using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP521R1Field
    {
        // Fields
        internal static readonly uint[] P;
        private const int P16 = 511;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_6;
            uint val_7;
            var val_8;
            val_6 = Org.BouncyCastle.Math.Raw.Nat.Add(len:  16, x:  x, y:  y, z:  z);
            val_7 = (x[8] + val_6) + y[8];
            if(val_7 > 511)
            {
                goto label_5;
            }
            
            if(val_7 != 511)
            {
                goto label_6;
            }
            
            val_6 = 1152921505518239744;
            val_8 = null;
            val_8 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Eq(len:  16, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16)) == false)
            {
                goto label_9;
            }
            
            label_5:
            val_7 = ((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  16, z:  z)) + val_7) & 511;
            label_6:
            if(z != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            z[8] = val_7;
            return;
            label_9:
            if(z != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            uint val_5;
            var val_6;
            val_5 = x[8] + (Org.BouncyCastle.Math.Raw.Nat.Inc(len:  16, x:  x, z:  z));
            if(val_5 > 511)
            {
                goto label_3;
            }
            
            if(val_5 != 511)
            {
                goto label_4;
            }
            
            val_6 = null;
            val_6 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Eq(len:  16, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16)) == false)
            {
                goto label_7;
            }
            
            label_3:
            val_5 = ((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  16, z:  z)) + val_5) & 511;
            label_4:
            if(z != null)
            {
                goto label_10;
            }
            
            label_11:
            label_10:
            z[8] = val_5;
            return;
            label_7:
            if(z != null)
            {
                goto label_10;
            }
            
            goto label_11;
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bits:  9, x:  x);
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Eq(len:  17, x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16)) == false)
            {
                    return val_1;
            }
            
            Org.BouncyCastle.Math.Raw.Nat.Zero(len:  17, z:  val_1);
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            uint val_3 = x[8];
            uint val_4 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  16, x:  x, c:  val_3, z:  z);
            val_4 = (val_4 >> 23) | (val_3 >> 1);
            z[8] = val_4;
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  33);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplMultiply(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  17, x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat.Zero(len:  17, z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.Sub(len:  17, x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            uint val_7;
            var val_8;
            uint val_7 = xx[16];
            val_7 = ((Org.BouncyCastle.Math.Raw.Nat.ShiftDownBits(len:  16, x:  xx, xOff:  16, bits:  9, c:  val_7, z:  z, zOff:  0)) >> 23) + (val_7 >> 9);
            val_7 = val_7 + (Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  16, x:  xx, z:  z));
            if(val_7 > 511)
            {
                goto label_3;
            }
            
            if(val_7 != 511)
            {
                goto label_4;
            }
            
            val_8 = null;
            val_8 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Eq(len:  16, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16)) == false)
            {
                goto label_7;
            }
            
            label_3:
            val_7 = ((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  16, z:  z)) + val_7) & 511;
            label_4:
            if(z != null)
            {
                goto label_10;
            }
            
            label_11:
            label_10:
            z[8] = val_7;
            return;
            label_7:
            if(z != null)
            {
                goto label_10;
            }
            
            goto label_11;
        }
        public static void Reduce23(uint[] z)
        {
            uint val_7;
            var val_8;
            uint val_7 = z[8];
            val_7 = (val_7 & 511) + (Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  16, x:  val_7 >> 9, z:  z));
            if(val_7 > 511)
            {
                goto label_3;
            }
            
            if(val_7 != 511)
            {
                goto label_9;
            }
            
            val_8 = null;
            val_8 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Eq(len:  16, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16)) == false)
            {
                goto label_9;
            }
            
            label_3:
            val_7 = ((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  16, z:  z)) + val_7) & 511;
            label_9:
            z[8] = val_7;
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  33);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  33);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplSquare(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplSquare(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_5 = y;
            uint val_4 = val_5[8];
            val_4 = x[8] - val_4;
            val_5 = val_4 + (Org.BouncyCastle.Math.Raw.Nat.Sub(len:  16, x:  x, y:  val_5, z:  z));
            if((val_5 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            label_8:
            z[8] = val_5;
            return;
            label_4:
            val_4 = (Org.BouncyCastle.Math.Raw.Nat.Dec(len:  16, z:  z)) + val_5;
            val_5 = val_4 & 511;
            if(z != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        public static void Twice(uint[] x, uint[] z)
        {
            System.UInt32[] val_4 = x;
            uint val_3 = val_4[8];
            val_4 = (Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  16, x:  val_4, c:  val_3 << 23, z:  z)) | (val_3 << 1);
            val_4 = val_4 & 511;
            z[8] = val_4;
        }
        protected static void ImplMultiply(uint[] x, uint[] y, uint[] zz)
        {
            Org.BouncyCastle.Math.Raw.Nat512.Mul(x:  x, y:  y, zz:  zz);
            uint val_2 = x[8];
            uint val_3 = y[8];
            uint val_4 = Org.BouncyCastle.Math.Raw.Nat.Mul31BothAdd(len:  16, a:  val_2, x:  y, b:  val_3, y:  x, z:  zz, zOff:  16);
            val_4 = val_4 + (val_3 * val_2);
            zz[16] = val_4;
        }
        protected static void ImplSquare(uint[] x, uint[] zz)
        {
            Org.BouncyCastle.Math.Raw.Nat512.Square(x:  x, zz:  zz);
            uint val_3 = x[8];
            uint val_4 = Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len:  16, x:  val_3 << 1, y:  x, yOff:  0, z:  zz, zOff:  16);
            val_4 = val_4 + (val_3 * val_3);
            zz[16] = val_4;
        }
        public SecP521R1Field()
        {
        
        }
        private static SecP521R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P16 = new uint[17] {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 511};
        }
    
    }

}
