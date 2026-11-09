using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP256R1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        internal const uint P7 = 4294967295;
        internal const uint PExt15 = 4294967294;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat256.Add(x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15)) == true)
            {
                goto label_9;
            }
        
        }
        public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
        {
            var val_4;
            var val_5;
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  16, x:  xx, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            val_4 = null;
            val_4 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  16, x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt, z:  zz);
            return;
            label_1:
            if(zz[7] < 2)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  16, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt)) == true)
            {
                goto label_9;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  8, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15)) == true)
            {
                goto label_9;
            }
        
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.FromBigInteger(x:  x);
            if(val_1[3] != 1)
            {
                    return val_1;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat256.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15, z:  val_1);
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
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  8, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat256.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            var val_4;
            var val_5;
            if((Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x:  x, y:  y, zz:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            val_4 = null;
            val_4 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  16, x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt, z:  zz);
            return;
            label_1:
            if(zz[7] < 2)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  16, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt)) == true)
            {
                goto label_9;
            }
        
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
            int val_2 = Org.BouncyCastle.Math.Raw.Nat256.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            int val_11;
            System.UInt32[] val_31 = xx;
            val_11 = xx.Length;
            if(val_11 <= 8)
            {
                    val_11 = xx.Length;
            }
            
            uint val_11 = val_31[4];
            if(val_11 <= 9)
            {
                    val_11 = xx.Length;
            }
            
            uint val_12 = val_31[4];
            if(val_11 <= 10)
            {
                    val_11 = xx.Length;
            }
            
            uint val_13 = val_31[5];
            if(val_11 <= 11)
            {
                    val_11 = xx.Length;
            }
            
            uint val_14 = val_31[5];
            if(val_11 <= 12)
            {
                    val_11 = xx.Length;
            }
            
            uint val_15 = val_31[6];
            if(val_11 <= 13)
            {
                    val_11 = xx.Length;
            }
            
            uint val_16 = val_31[6];
            if(val_11 <= 14)
            {
                    val_11 = xx.Length;
            }
            
            uint val_17 = val_31[7];
            if(val_11 <= 15)
            {
                    val_11 = xx.Length;
            }
            
            uint val_18 = val_31[7];
            uint val_1 = val_17 + val_16;
            var val_19 = 6;
            val_19 = val_19 - val_11;
            val_19 = val_19 - val_12;
            val_11 = val_19 + val_1;
            uint val_20 = val_31[0];
            val_20 = val_20 - (val_15 + val_14);
            val_11 = val_20 - val_11;
            z[0] = val_11;
            val_12 = val_13 + val_12;
            val_16 = val_16 + val_15;
            uint val_3 = val_18 + val_17;
            val_11 = val_11 >> 32;
            uint val_4 = val_12 - val_16;
            val_4 = val_4 - val_3;
            val_4 = val_4 + val_11;
            val_14 = val_14 + val_13;
            val_16 = val_4 + val_31[0];
            z[0] = val_16;
            uint val_5 = val_14 - val_18;
            uint val_6 = val_16 >> 32;
            uint val_23 = val_1;
            val_23 = val_5 - val_23;
            val_23 = val_23 + val_6;
            val_6 = val_23 + val_31[1];
            z[1] = val_6;
            val_6 = val_6 >> 32;
            uint val_7 = val_11 + (((xx[6] + xx[5])) << 1);
            val_7 = val_7 - val_3;
            val_7 = val_7 + val_6;
            val_6 = val_7 + val_31[1];
            z[1] = val_6;
            val_6 = val_6 >> 32;
            uint val_8 = val_16 << 1;
            val_8 = val_8 - val_12;
            val_8 = val_8 + val_17;
            val_8 = val_8 + val_6;
            val_6 = val_8 + val_31[2];
            z[2] = val_6;
            val_6 = val_6 >> 32;
            uint val_27 = val_1;
            val_27 = val_27 << 1;
            val_27 = val_27 - val_5;
            val_27 = val_27 + val_6;
            val_6 = val_27 + val_31[2];
            z[2] = val_6;
            val_6 = val_6 >> 32;
            uint val_9 = val_11 + (((xx[7] + xx[7])) << 1);
            val_9 = val_9 + val_6;
            val_6 = val_9 + val_31[3];
            z[3] = val_6;
            uint val_30 = val_11;
            val_6 = val_6 >> 32;
            val_30 = (val_30 - 6) - val_16;
            val_30 = val_30 + ((xx[7]) << 1);
            val_30 = val_30 - val_5;
            val_30 = val_30 + val_6;
            val_31 = val_30 + val_31[3];
            z[3] = val_31;
            val_30 = val_31 >> 32;
            val_31 = val_30 + 6;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce32(x:  val_31, z:  z);
        }
        public static void Reduce32(uint x, uint[] z)
        {
            var val_6;
            int val_7;
            uint val_8;
            int val_9;
            int val_10;
            uint val_11;
            int val_12;
            int val_13;
            var val_14;
            if(x == 0)
            {
                goto label_1;
            }
            
            uint val_13 = x;
            val_7 = z.Length;
            if(val_7 == 0)
            {
                    val_7 = z.Length;
            }
            
            uint val_1 = z[0] + val_13;
            val_8 = val_1 >> 32;
            z[0] = val_1;
            if(val_8 != 0)
            {
                    val_9 = z.Length;
                if(val_9 <= 1)
            {
                    val_9 = z.Length;
            }
            
                val_8 = val_8 + z[0];
                if(val_9 <= 1)
            {
                    val_9 = z.Length;
            }
            
                z[0] = val_8;
                val_8 = val_8 >> 32;
                if(val_9 <= 2)
            {
                    val_9 = z.Length;
            }
            
                val_8 = val_8 + z[1];
                z[1] = val_8;
                val_8 = val_8 >> 32;
            }
            
            val_10 = z.Length;
            if(val_10 <= 3)
            {
                    val_10 = z.Length;
            }
            
            uint val_8 = z[1];
            val_8 = val_8 - val_13;
            val_1 = val_8 + val_8;
            val_11 = val_1 >> 32;
            z[1] = val_1;
            if(val_11 != 0)
            {
                    val_12 = z.Length;
                if(val_12 <= 4)
            {
                    val_12 = z.Length;
            }
            
                val_11 = val_11 + z[2];
                if(val_12 <= 4)
            {
                    val_12 = z.Length;
            }
            
                z[2] = val_11;
                val_11 = val_11 >> 32;
                if(val_12 <= 5)
            {
                    val_12 = z.Length;
            }
            
                val_11 = val_11 + z[2];
                z[2] = val_11;
                val_11 = val_11 >> 32;
            }
            
            val_13 = z.Length;
            if(val_13 <= 6)
            {
                    val_13 = z.Length;
            }
            
            uint val_11 = z[3];
            val_11 = val_11 - val_13;
            val_11 = val_11 + val_11;
            if(val_13 <= 6)
            {
                    val_13 = z.Length;
            }
            
            z[3] = val_11;
            val_6 = val_11 >> 32;
            if(val_13 <= 7)
            {
                    val_13 = z.Length;
            }
            
            val_13 = (val_6 + val_13) + z[3];
            z[3] = val_13;
            if((val_13 >> 32) == 0)
            {
                goto label_23;
            }
            
            goto label_22;
            label_1:
            label_23:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15)) == false)
            {
                    return;
            }
            
            label_22:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat256.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(xx:  val_1, z:  z);
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
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SubPInvFrom(z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  16, x:  xx, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  16, x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt, z:  zz);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  8, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15)) == true)
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
            int val_10;
            uint val_11;
            int val_12;
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
            
            uint val_4 = val_8 + z[1];
            val_8 = val_4 >> 32;
            z[1] = val_4;
            if(val_8 != 0)
            {
                    val_10 = z.Length;
                if(val_10 <= 4)
            {
                    val_10 = z.Length;
            }
            
                val_8 = val_8 + z[2];
                if(val_10 <= 4)
            {
                    val_10 = z.Length;
            }
            
                z[2] = val_8;
                val_8 = val_8 >> 32;
                if(val_10 <= 5)
            {
                    val_10 = z.Length;
            }
            
                val_8 = val_8 + z[2];
                z[2] = val_8;
                val_11 = (val_8 >> 32) - 1;
            }
            else
            {
                    val_11 = 0;
            }
            
            val_12 = z.Length;
            if(val_12 <= 6)
            {
                    val_12 = z.Length;
            }
            
            val_11 = val_11 + z[3];
            if(val_12 <= 6)
            {
                    val_12 = z.Length;
            }
            
            z[3] = val_11;
            val_11 = val_11 >> 32;
            if(val_12 <= 7)
            {
                    val_12 = z.Length;
            }
            
            uint val_13 = z[3];
            val_13 = val_11 + val_13;
            val_11 = val_13 + 1;
            z[3] = val_11;
        }
        private static void SubPInvFrom(uint[] z)
        {
            int val_6;
            int val_7;
            uint val_8;
            int val_9;
            int val_10;
            uint val_11;
            int val_12;
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
            
            uint val_4 = val_8 + z[1];
            val_8 = val_4 >> 32;
            z[1] = val_4;
            if(val_8 != 0)
            {
                    val_10 = z.Length;
                if(val_10 <= 4)
            {
                    val_10 = z.Length;
            }
            
                val_8 = val_8 + z[2];
                if(val_10 <= 4)
            {
                    val_10 = z.Length;
            }
            
                z[2] = val_8;
                val_8 = val_8 >> 32;
                if(val_10 <= 5)
            {
                    val_10 = z.Length;
            }
            
                val_8 = val_8 + z[2];
                z[2] = val_8;
                val_11 = (val_8 >> 32) + 1;
            }
            else
            {
                    val_11 = 1;
            }
            
            val_12 = z.Length;
            if(val_12 <= 6)
            {
                    val_12 = z.Length;
            }
            
            val_11 = val_11 + z[3];
            if(val_12 <= 6)
            {
                    val_12 = z.Length;
            }
            
            z[3] = val_11;
            val_11 = val_11 >> 32;
            if(val_12 <= 7)
            {
                    val_12 = z.Length;
            }
            
            uint val_13 = z[3];
            val_13 = val_11 + val_13;
            val_11 = val_13 - 1;
            z[3] = val_11;
        }
        public SecP256R1Field()
        {
        
        }
        private static SecP256R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15 = new uint[8] {-1, -1, -1, 0, 0, 0, 1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt = new uint[16] {1, 0, 0, -2, -1, -1, -2, 1, -2, 1, -2, 1, 1, -2, 2, -2};
        }
    
    }

}
