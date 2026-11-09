using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP160R1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        private static readonly uint[] PExtInv;
        private const uint P4 = 4294967295;
        private const uint PExt9 = 4294967295;
        private const uint PInv = 2147483649;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat160.Add(x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  5, x:  -2147483647, z:  z);
            return;
            label_1:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat160.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv)) == true)
            {
                goto label_7;
            }
        
        }
        public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
        {
            System.UInt32[] val_5;
            var val_6;
            System.UInt32[] val_7;
            var val_8;
            var val_9;
            val_5 = xx;
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  10, x:  val_5, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  10, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[4] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  10, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  5, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  5, x:  -2147483647, z:  z);
            return;
            label_1:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat160.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv)) == true)
            {
                goto label_7;
            }
        
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.FromBigInteger(x:  x);
            if(val_1[2] != 1)
            {
                    return val_1;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat160.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat160.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv, z:  val_1);
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            var val_4;
            if((x[0] & 1) == 0)
            {
                    uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  5, x:  x, c:  0, z:  z);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  5, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat160.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat160.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            System.UInt32[] val_5;
            var val_6;
            System.UInt32[] val_7;
            var val_8;
            var val_9;
            val_5 = x;
            if((Org.BouncyCastle.Math.Raw.Nat160.MulAddTo(x:  val_5, y:  y, zz:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  10, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[4] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  10, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat160.IsZero(x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat160.Zero(z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat160.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            int val_5;
            System.UInt32[] val_15 = xx;
            val_5 = xx.Length;
            if(val_5 <= 5)
            {
                    val_5 = xx.Length;
            }
            
            if(val_5 <= 6)
            {
                    val_5 = xx.Length;
            }
            
            uint val_6 = val_15[3];
            if(val_5 <= 7)
            {
                    val_5 = xx.Length;
            }
            
            uint val_7 = val_15[3];
            if(val_5 <= 8)
            {
                    val_5 = xx.Length;
            }
            
            uint val_8 = val_15[4];
            if(val_5 <= 9)
            {
                    val_5 = xx.Length;
            }
            
            uint val_2 = (val_15[2] + ((xx[2]) << 31)) + val_15[0];
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_3 = val_2 + (val_6 * (-2147483647));
            val_6 = val_3 + val_15[0];
            z[0] = val_6;
            val_6 = val_6 >> 32;
            val_3 = val_6 + (val_7 * (-2147483647));
            val_7 = val_3 + val_15[1];
            z[1] = val_7;
            val_7 = val_7 >> 32;
            val_3 = val_7 + (val_8 * (-2147483647));
            val_8 = val_3 + val_15[1];
            z[1] = val_8;
            val_8 = val_8 >> 32;
            val_3 = val_8 + (val_15[4] * (-2147483647));
            val_15 = val_3 + val_15[2];
            z[2] = val_15;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce32(x:  val_15 >> 32, z:  z);
        }
        public static void Reduce32(uint x, uint[] z)
        {
            var val_4;
            if(x != 0)
            {
                    if((Org.BouncyCastle.Math.Raw.Nat160.MulWordsAdd(x:  -2147483647, y:  x, z:  z, zOff:  0)) != 0)
            {
                goto label_2;
            }
            
            }
            
            if(z[2] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat160.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv)) == false)
            {
                    return;
            }
            
            label_2:
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  5, x:  -2147483647, z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat160.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat160.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat160.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat160.Sub(x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.SubWordFrom(len:  5, x:  -2147483647, z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            System.UInt32[] val_4;
            var val_5;
            System.UInt32[] val_6;
            var val_7;
            val_4 = xx;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  10, x:  val_4, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv;
            val_6 = val_4;
            if(val_4 == null)
            {
                    val_6 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length, x:  val_6, z:  zz)) == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  10, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  5, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddWordTo(len:  5, x:  -2147483647, z:  z);
            return;
            label_1:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat160.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv)) == true)
            {
                goto label_7;
            }
        
        }
        public SecP160R1Field()
        {
        
        }
        private static SecP160R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PInv = new uint[5] {2147483647, -1, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExt = new uint[10] {1, 1073741825, 0, 0, 0, -2, -2, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv = new uint[7] {-1, -1073741826, -1, -1, -1, 1, 1};
        }
    
    }

}
