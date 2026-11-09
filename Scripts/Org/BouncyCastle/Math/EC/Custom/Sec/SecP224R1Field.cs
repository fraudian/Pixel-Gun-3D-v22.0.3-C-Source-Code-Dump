using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP224R1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        private static readonly uint[] PExtInv;
        private const uint P6 = 4294967295;
        private const uint PExt13 = 4294967295;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat224.Add(x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13)) == true)
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
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  14, x:  val_5, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  14, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[6] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  14, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  7, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13)) == true)
            {
                goto label_9;
            }
        
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.FromBigInteger(x:  x);
            if(val_1[3] != 1)
            {
                    return val_1;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat224.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13, z:  val_1);
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            var val_4;
            if((x[0] & 1) == 0)
            {
                    uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  7, x:  x, c:  0, z:  z);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  7, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat224.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat224.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            System.UInt32[] val_5;
            var val_6;
            System.UInt32[] val_7;
            var val_8;
            var val_9;
            val_5 = x;
            if((Org.BouncyCastle.Math.Raw.Nat224.MulAddTo(x:  val_5, y:  y, zz:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  14, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[6] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  14, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat224.Zero(z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat224.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13, y:  x, z:  z);
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
            System.UInt32[] val_26 = xx;
            val_10 = xx.Length;
            if(val_10 <= 10)
            {
                    val_10 = xx.Length;
            }
            
            uint val_10 = val_26[5];
            if(val_10 <= 11)
            {
                    val_10 = xx.Length;
            }
            
            uint val_11 = val_26[5];
            if(val_10 <= 12)
            {
                    val_10 = xx.Length;
            }
            
            uint val_12 = val_26[6];
            if(val_10 <= 13)
            {
                    val_10 = xx.Length;
            }
            
            uint val_13 = val_26[6];
            if(val_10 <= 7)
            {
                    val_10 = xx.Length;
            }
            
            uint val_14 = val_26[3];
            if(val_10 <= 8)
            {
                    val_10 = xx.Length;
            }
            
            val_14 = val_11 + val_14;
            if(val_10 <= 9)
            {
                    val_10 = xx.Length;
            }
            
            uint val_16 = val_26[4];
            uint val_1 = val_14 - 1;
            if(val_10 == 0)
            {
                    val_10 = xx.Length;
            }
            
            uint val_2 = val_26[4] + val_12;
            uint val_3 = val_26[0] - val_1;
            val_14 = val_3 >> 32;
            uint val_18 = val_26[0];
            val_18 = val_18 - val_2;
            val_14 = val_18 + val_14;
            z[0] = val_14;
            val_16 = val_16 + val_13;
            val_14 = val_14 >> 32;
            uint val_19 = val_26[1];
            val_19 = val_19 - val_16;
            val_14 = val_19 + val_14;
            z[1] = val_14;
            val_11 = xx.Length;
            val_14 = val_14 >> 32;
            if(val_11 <= 3)
            {
                    val_11 = xx.Length;
            }
            
            uint val_21 = val_10;
            val_21 = val_1 - val_21;
            val_21 = val_21 + val_14;
            val_1 = val_21 + val_26[1];
            val_14 = val_1 >> 32;
            uint val_4 = val_2 - val_11;
            val_4 = val_4 + val_14;
            val_14 = val_4 + val_26[2];
            z[2] = val_14;
            val_14 = val_14 >> 32;
            uint val_5 = val_16 - val_12;
            val_5 = val_5 + val_14;
            val_14 = val_5 + val_26[2];
            z[2] = val_14;
            val_12 = val_14 >> 32;
            uint val_25 = val_10;
            val_12 = z.Length;
            uint val_24 = val_26[3];
            val_25 = val_25 - val_13;
            val_25 = val_25 + val_12;
            val_26 = val_25 + val_24;
            if(val_12 <= 6)
            {
                    val_12 = z.Length;
            }
            
            val_24 = val_26 >> 32;
            z[3] = val_26;
            val_26 = val_24 + 1;
            val_13 = val_1 & 4294967295;
            val_12 = (val_3 & 4294967295) - val_26;
            val_13 = val_26 + val_13;
            val_14 = val_12 >> 32;
            z[0] = val_12;
            if(val_14 != 0)
            {
                    val_15 = z.Length;
                if(val_15 <= 1)
            {
                    val_15 = z.Length;
            }
            
                val_14 = val_14 + z[0];
                if(val_15 <= 1)
            {
                    val_15 = z.Length;
            }
            
                z[0] = val_14;
                val_14 = val_14 >> 32;
                if(val_15 <= 2)
            {
                    val_15 = z.Length;
            }
            
                val_14 = val_14 + z[1];
                val_13 = val_13 + (val_14 >> 32);
                z[1] = val_14;
            }
            
            z[1] = val_13;
            if((val_13 >> 32) != 0)
            {
                    if((Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zPos:  4)) != 0)
            {
                goto label_30;
            }
            
            }
            
            if(z[3] != 1)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13)) == false)
            {
                    return;
            }
            
            label_30:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z:  z);
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
            
            uint val_10 = x;
            val_8 = z.Length;
            if(val_8 == 0)
            {
                    val_8 = z.Length;
            }
            
            uint val_1 = z[0] - val_10;
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
                if(val_9 <= 1)
            {
                    val_9 = z.Length;
            }
            
                z[0] = val_7;
                val_7 = val_7 >> 32;
                if(val_9 <= 2)
            {
                    val_9 = z.Length;
            }
            
                val_7 = val_7 + z[1];
                z[1] = val_7;
                val_7 = val_7 >> 32;
            }
            
            val_10 = z.Length;
            if(val_10 <= 3)
            {
                    val_10 = z.Length;
            }
            
            val_10 = (val_7 + val_10) + z[1];
            z[1] = val_10;
            if((val_10 >> 32) == 0)
            {
                goto label_15;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zPos:  4)) != 0)
            {
                goto label_13;
            }
            
            goto label_15;
            label_1:
            label_15:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13)) == false)
            {
                    return;
            }
            
            label_13:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat224.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat224.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat224.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat224.Sub(x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.SubPInvFrom(z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            System.UInt32[] val_4;
            var val_5;
            System.UInt32[] val_6;
            var val_7;
            val_4 = xx;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  14, x:  val_4, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv;
            val_6 = val_4;
            if(val_4 == null)
            {
                    val_6 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length, x:  val_6, z:  zz)) == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  14, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  7, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13)) == true)
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
                if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
                z[0] = val_2;
                val_2 = val_2 >> 32;
                if(val_7 <= 2)
            {
                    val_7 = z.Length;
            }
            
                val_2 = val_2 + z[1];
                z[1] = val_2;
                val_8 = (val_2 >> 32) + 1;
            }
            else
            {
                    val_8 = 1;
            }
            
            val_9 = z.Length;
            if(val_9 <= 3)
            {
                    val_9 = z.Length;
            }
            
            val_8 = val_8 + z[1];
            z[1] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return;
            }
            
            uint val_5 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zPos:  4);
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
                if(val_7 <= 1)
            {
                    val_7 = z.Length;
            }
            
                z[0] = val_2;
                val_2 = val_2 >> 32;
                if(val_7 <= 2)
            {
                    val_7 = z.Length;
            }
            
                val_2 = val_2 + z[1];
                z[1] = val_2;
                val_8 = (val_2 >> 32) - 1;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_9 = z.Length;
            if(val_9 <= 3)
            {
                    val_9 = z.Length;
            }
            
            val_8 = val_8 + z[1];
            z[1] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return;
            }
            
            int val_5 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  7, z:  z, zPos:  4);
        }
        public SecP224R1Field()
        {
        
        }
        private static SecP224R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13 = new uint[7] {1, 0, 0, -1, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt = new uint[14] {1, 0, 0, -2, -1, -1, 0, 2, 0, 0, -2, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv = new uint[11] {-1, -1, -1, 1, 0, 0, -1, -3, -1, -1, 1};
        }
    
    }

}
