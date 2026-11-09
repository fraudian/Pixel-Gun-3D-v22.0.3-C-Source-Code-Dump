using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP192R1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        private static readonly uint[] PExtInv;
        private const uint P5 = 4294967295;
        private const uint PExt11 = 4294967295;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat192.Add(x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11)) == true)
            {
                goto label_9;
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
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  12, x:  val_5, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  12, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[5] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  6, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11)) == true)
            {
                goto label_9;
            }
        
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.FromBigInteger(x:  x);
            if(val_1[2] != 1)
            {
                    return val_1;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat192.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11, z:  val_1);
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            var val_4;
            if((x[0] & 1) == 0)
            {
                    uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  6, x:  x, c:  0, z:  z);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  6, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat192.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat192.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            System.UInt32[] val_5;
            var val_6;
            System.UInt32[] val_7;
            var val_8;
            var val_9;
            val_5 = x;
            if((Org.BouncyCastle.Math.Raw.Nat192.MulAddTo(x:  val_5, y:  y, zz:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  12, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[5] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat192.IsZero(x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat192.Zero(z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat192.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            int val_10;
            int val_11;
            int val_12;
            uint val_13;
            uint val_14;
            int val_15;
            var val_16;
            System.UInt32[] val_21 = xx;
            val_10 = xx.Length;
            if(val_10 <= 6)
            {
                    val_10 = xx.Length;
            }
            
            uint val_9 = val_21[3];
            if(val_10 <= 7)
            {
                    val_10 = xx.Length;
            }
            
            if(val_10 <= 8)
            {
                    val_10 = xx.Length;
            }
            
            uint val_11 = val_21[4];
            if(val_10 <= 9)
            {
                    val_10 = xx.Length;
            }
            
            uint val_12 = val_21[4];
            if(val_10 <= 10)
            {
                    val_10 = xx.Length;
            }
            
            uint val_13 = val_21[5];
            if(val_10 <= 11)
            {
                    val_10 = xx.Length;
            }
            
            uint val_14 = val_21[5];
            val_9 = val_13 + val_9;
            if(val_10 == 0)
            {
                    val_10 = xx.Length;
            }
            
            uint val_15 = val_21[0];
            uint val_1 = val_14 + val_21[3];
            uint val_2 = val_9 + val_15;
            uint val_3 = val_2 >> 32;
            val_15 = val_3 + val_1;
            val_3 = val_15 + val_21[0];
            z[0] = val_3;
            val_11 = xx.Length;
            val_3 = val_3 >> 32;
            val_9 = val_9 + val_11;
            if(val_11 <= 2)
            {
                    val_11 = xx.Length;
            }
            
            uint val_4 = val_3 + val_9;
            val_1 = val_1 + val_12;
            val_9 = val_4 + val_21[1];
            val_3 = val_9 >> 32;
            val_4 = val_3 + val_1;
            val_1 = val_4 + val_21[1];
            z[1] = val_1;
            val_1 = val_1 >> 32;
            val_11 = val_13 + val_11;
            val_4 = val_11 + val_1;
            val_11 = val_4 + val_21[2];
            z[2] = val_11;
            val_12 = val_14 + val_12;
            val_11 = val_11 >> 32;
            val_12 = z.Length;
            uint val_20 = val_21[2];
            val_4 = val_12 + val_11;
            val_21 = val_4 + val_20;
            if(val_12 <= 5)
            {
                    val_12 = z.Length;
            }
            
            val_20 = val_21 >> 32;
            val_11 = val_20 + val_2;
            z[2] = val_21;
            val_13 = (val_9 & 4294967295) + (val_21 >> 32);
            val_14 = val_11 >> 32;
            z[0] = val_11;
            if(val_14 != 0)
            {
                    val_15 = z.Length;
                if(val_15 <= 1)
            {
                    val_15 = z.Length;
            }
            
                val_14 = val_14 + z[0];
                val_13 = val_13 + (val_14 >> 32);
                z[0] = val_14;
            }
            
            z[1] = val_13;
            if((val_13 >> 32) != 0)
            {
                    if((Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  6, z:  z, zPos:  3)) != 0)
            {
                goto label_25;
            }
            
            }
            
            if(z[2] != 1)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11)) == false)
            {
                    return;
            }
            
            label_25:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z:  z);
        }
        public static void Reduce32(uint x, uint[] z)
        {
            uint val_7;
            int val_8;
            int val_9;
            int val_10;
            var val_11;
            if(x == 0)
            {
                goto label_1;
            }
            
            val_8 = z.Length;
            if(val_8 == 0)
            {
                    val_8 = z.Length;
            }
            
            uint val_1 = z[0] + x;
            uint val_9 = x;
            val_7 = val_1 >> 32;
            z[0] = val_1;
            if(val_7 != 0)
            {
                    val_9 = z.Length;
                if(val_9 <= 1)
            {
                    val_9 = z.Length;
            }
            
                val_7 = val_7 + z[0];
                z[0] = val_7;
                val_7 = val_7 >> 32;
            }
            
            val_10 = z.Length;
            if(val_10 <= 2)
            {
                    val_10 = z.Length;
            }
            
            val_9 = (val_7 + val_9) + z[1];
            z[1] = val_9;
            if((val_9 >> 32) == 0)
            {
                goto label_13;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  6, z:  z, zPos:  3)) != 0)
            {
                goto label_11;
            }
            
            goto label_13;
            label_1:
            label_13:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11)) == false)
            {
                    return;
            }
            
            label_11:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat192.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat192.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat192.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat192.Sub(x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SubPInvFrom(z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            System.UInt32[] val_4;
            var val_5;
            System.UInt32[] val_6;
            var val_7;
            val_4 = xx;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  12, x:  val_4, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv;
            val_6 = val_4;
            if(val_4 == null)
            {
                    val_6 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length, x:  val_6, z:  zz)) == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  12, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  6, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[2] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11)) == true)
            {
                goto label_9;
            }
        
        }
        private static void AddPInvTo(uint[] z)
        {
            int val_6;
            int val_7;
            uint val_8;
            int val_9;
            val_6 = z.Length;
            if(val_6 == 0)
            {
                    val_6 = z.Length;
            }
            
            uint val_1 = z[0] + 1;
            uint val_2 = val_1 >> 32;
            z[0] = val_1;
            if(val_2 != 0)
            {
                    val_7 = z.Length;
                if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
                val_2 = val_2 + z[0];
                z[0] = val_2;
                val_8 = (val_2 >> 32) + 1;
            }
            else
            {
                    val_8 = 1;
            }
            
            val_9 = z.Length;
            if(val_9 <= 2)
            {
                    val_9 = z.Length;
            }
            
            val_8 = val_8 + z[1];
            z[1] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return;
            }
            
            uint val_5 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  6, z:  z, zPos:  3);
        }
        private static void SubPInvFrom(uint[] z)
        {
            int val_6;
            int val_7;
            uint val_8;
            int val_9;
            val_6 = z.Length;
            if(val_6 == 0)
            {
                    val_6 = z.Length;
            }
            
            uint val_1 = z[0] - 1;
            uint val_2 = val_1 >> 32;
            z[0] = val_1;
            if(val_2 != 0)
            {
                    val_7 = z.Length;
                if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
                val_2 = val_2 + z[0];
                z[0] = val_2;
                val_8 = (val_2 >> 32) - 1;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_9 = z.Length;
            if(val_9 <= 2)
            {
                    val_9 = z.Length;
            }
            
            val_8 = val_8 + z[1];
            z[1] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return;
            }
            
            int val_5 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  6, z:  z, zPos:  3);
        }
        public SecP192R1Field()
        {
        
        }
        private static SecP192R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt11 = new uint[6] {-1, -1, -2, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt = new uint[12] {1, 0, 2, 0, 1, 0, -2, -1, -3, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv = new uint[9] {-1, -1, -3, -1, -2, -1, 1, 0, 2};
        }
    
    }

}
