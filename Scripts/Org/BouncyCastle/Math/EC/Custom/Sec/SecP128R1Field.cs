using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP128R1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        private static readonly uint[] PExtInv;
        private const uint P3 = 4294967293;
        private const uint PExt7 = 4294967292;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat128.Add(x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[1] != 3)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat128.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7)) == true)
            {
                goto label_9;
            }
        
        }
        public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
        {
            var val_4;
            System.UInt32[] val_5;
            var val_6;
            if((Org.BouncyCastle.Math.Raw.Nat256.Add(x:  xx, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_10:
            val_4 = null;
            val_4 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv == null)
            {
                    val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv;
            }
            
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv.Length, x:  val_5, z:  zz);
            return;
            label_1:
            if(zz[3] != 4)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt)) == true)
            {
                goto label_10;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  4, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[1] != 3)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat128.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7)) == true)
            {
                goto label_9;
            }
        
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.FromBigInteger(x:  x);
            if(val_1[1] != 3)
            {
                    return val_1;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat128.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat128.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7, z:  val_1);
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            var val_4;
            if((x[0] & 1) == 0)
            {
                    uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  4, x:  x, c:  0, z:  z);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  4, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat128.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat128.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            var val_4;
            System.UInt32[] val_5;
            var val_6;
            if((Org.BouncyCastle.Math.Raw.Nat128.MulAddTo(x:  x, y:  y, zz:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_10:
            val_4 = null;
            val_4 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv == null)
            {
                    val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv;
            }
            
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv.Length, x:  val_5, z:  zz);
            return;
            label_1:
            if(zz[3] != 4)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt)) == true)
            {
                goto label_10;
            }
        
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat128.IsZero(x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat128.Zero(z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat128.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            int val_3;
            int val_4;
            System.UInt32[] val_11 = xx;
            val_3 = xx.Length;
            if(val_3 == 0)
            {
                    val_3 = xx.Length;
            }
            
            uint val_3 = val_11[0];
            if(val_3 <= 1)
            {
                    val_3 = xx.Length;
            }
            
            uint val_4 = val_11[0];
            if(val_3 <= 2)
            {
                    val_3 = xx.Length;
            }
            
            uint val_5 = val_11[1];
            if(val_3 <= 3)
            {
                    val_3 = xx.Length;
            }
            
            uint val_6 = val_11[1];
            if(val_3 <= 4)
            {
                    val_3 = xx.Length;
            }
            
            if(val_3 <= 5)
            {
                    val_3 = xx.Length;
            }
            
            uint val_8 = val_11[2];
            if(val_3 <= 6)
            {
                    val_3 = xx.Length;
            }
            
            uint val_9 = val_11[3];
            val_9 = val_9 + ((xx[3]) << 1);
            val_8 = val_8 + (((xx[3] + (xx[3]) << 1)) << 1);
            val_11 = val_11[2] + (((xx[2] + ((xx[3] + (xx[3]) << 1)) << 1)) << 1);
            val_3 = val_11 + val_3;
            val_4 = z.Length;
            val_4 = val_8 + val_4;
            if(val_4 == 0)
            {
                    val_4 = z.Length;
            }
            
            val_6 = val_11[3] + val_6;
            val_5 = val_9 + val_5;
            z[0] = val_3;
            val_3 = val_4 + (val_3 >> 32);
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            uint val_1 = val_6 + (((xx[2] + ((xx[2] + ((xx[3] + (xx[3]) << 1)) << 1)) << 1)) << 1);
            z[0] = val_3;
            val_3 = val_5 + (val_3 >> 32);
            if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
            val_1 = val_1 + (val_3 >> 32);
            z[1] = val_3;
            z[1] = val_1;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce32(x:  val_1 >> 32, z:  z);
        }
        public static void Reduce32(uint x, uint[] z)
        {
            int val_5;
            uint val_6;
            int val_7;
            int val_8;
            if(x == 0)
            {
                    return;
            }
            
            do
            {
                uint val_8 = x;
                val_5 = z.Length;
                if(val_5 == 0)
            {
                    val_5 = z.Length;
            }
            
                uint val_1 = z[0] + val_8;
                val_6 = val_1 >> 32;
                z[0] = val_1;
                if(val_6 != 0)
            {
                    val_7 = z.Length;
                if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
                val_6 = val_6 + z[0];
                if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
                z[0] = val_6;
                val_6 = val_6 >> 32;
                if(val_7 <= 2)
            {
                    val_7 = z.Length;
            }
            
                val_6 = val_6 + z[1];
                z[1] = val_6;
                val_6 = val_6 >> 32;
            }
            
                val_8 = z.Length;
                if(val_8 <= 3)
            {
                    val_8 = z.Length;
            }
            
                val_8 = (val_6 + ((x) << 1)) + z[1];
                z[1] = val_8;
            }
            while((val_8 >> 32) != 0);
        
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat128.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat128.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat128.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat128.Sub(x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SubPInvFrom(z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            var val_3;
            System.UInt32[] val_4;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  10, x:  xx, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv == null)
            {
                    val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv;
            }
            
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv.Length, x:  val_4, z:  zz);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  4, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[1] != 3)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat128.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7)) == true)
            {
                goto label_9;
            }
        
        }
        private static void AddPInvTo(uint[] z)
        {
            int val_4;
            int val_5;
            uint val_6;
            int val_7;
            val_4 = z.Length;
            if(val_4 == 0)
            {
                    val_4 = z.Length;
            }
            
            uint val_1 = z[0] + 1;
            uint val_2 = val_1 >> 32;
            z[0] = val_1;
            if(val_2 != 0)
            {
                    val_5 = z.Length;
                if(val_5 <= 1)
            {
                    val_5 = z.Length;
            }
            
                val_2 = val_2 + z[0];
                if(val_5 <= 1)
            {
                    val_5 = z.Length;
            }
            
                z[0] = val_2;
                val_2 = val_2 >> 32;
                if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
                val_2 = val_2 + z[1];
                z[1] = val_2;
                val_6 = (val_2 >> 32) | 2;
            }
            else
            {
                    val_6 = 2;
            }
            
            val_7 = z.Length;
            if(val_7 <= 3)
            {
                    val_7 = z.Length;
            }
            
            val_6 = val_6 + z[1];
            z[1] = val_6;
        }
        private static void SubPInvFrom(uint[] z)
        {
            int val_3;
            int val_4;
            uint val_5;
            int val_6;
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            uint val_1 = z[0] - 1;
            uint val_2 = val_1 >> 32;
            z[0] = val_1;
            if(val_2 != 0)
            {
                    val_4 = z.Length;
                if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
                val_2 = val_2 + z[0];
                if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
                z[0] = val_2;
                val_2 = val_2 >> 32;
                if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
                val_2 = val_2 + z[1];
                z[1] = val_2;
                val_5 = (-2) + (val_2 >> 32);
            }
            else
            {
                    val_5 = -2;
            }
            
            val_6 = z.Length;
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            val_5 = val_5 + z[1];
            z[1] = val_5;
        }
        public SecP128R1Field()
        {
        
        }
        private static SecP128R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt7 = new uint[4] {-1, -1, -1, -3};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt = new uint[8] {1, 0, 0, 4, -2, -1, 3, -4};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv = new uint[8] {-1, -1, -1, -5, 1, 0, -4, 3};
        }
    
    }

}
