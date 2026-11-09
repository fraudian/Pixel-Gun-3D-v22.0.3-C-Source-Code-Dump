using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP384R1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        private static readonly uint[] PExtInv;
        private const uint P11 = 4294967295;
        private const uint PExt23 = 4294967295;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  12, x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[5] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23)) == true)
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
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  24, x:  val_5, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  24, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[11] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  24, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  12, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[5] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23)) == true)
            {
                goto label_9;
            }
        
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            var val_5;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bits:  384, x:  x);
            if(val_1[5] != 1)
            {
                    return val_1;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  12, x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23, z:  val_1);
            return val_1;
        }
        public static void Half(uint[] x, uint[] z)
        {
            var val_4;
            if((x[0] & 1) == 0)
            {
                    uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  12, x:  x, c:  0, z:  z);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  12, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat.Add(len:  12, x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  24);
            Org.BouncyCastle.Math.Raw.Nat384.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void Negate(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  12, x:  x)) != false)
            {
                    Org.BouncyCastle.Math.Raw.Nat.Zero(len:  12, z:  z);
                return;
            }
            
            val_3 = null;
            val_3 = null;
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.Sub(len:  12, x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            int val_19;
            System.UInt32[] val_48 = xx;
            val_19 = xx.Length;
            if(val_19 <= 16)
            {
                    val_19 = xx.Length;
            }
            
            uint val_19 = val_48[8];
            if(val_19 <= 17)
            {
                    val_19 = xx.Length;
            }
            
            uint val_20 = val_48[8];
            if(val_19 <= 18)
            {
                    val_19 = xx.Length;
            }
            
            uint val_21 = val_48[9];
            if(val_19 <= 19)
            {
                    val_19 = xx.Length;
            }
            
            uint val_22 = val_48[9];
            if(val_19 <= 20)
            {
                    val_19 = xx.Length;
            }
            
            uint val_23 = val_48[10];
            if(val_19 <= 21)
            {
                    val_19 = xx.Length;
            }
            
            uint val_24 = val_48[10];
            if(val_19 <= 22)
            {
                    val_19 = xx.Length;
            }
            
            uint val_25 = val_48[11];
            if(val_19 <= 23)
            {
                    val_19 = xx.Length;
            }
            
            uint val_26 = val_48[11];
            if(val_19 <= 12)
            {
                    val_19 = xx.Length;
            }
            
            uint val_27 = val_48[6];
            if(val_19 <= 13)
            {
                    val_19 = xx.Length;
            }
            
            uint val_28 = val_48[6];
            val_27 = val_23 + val_27;
            if(val_19 <= 14)
            {
                    val_19 = xx.Length;
            }
            
            uint val_29 = val_48[7];
            uint val_1 = val_27 - 1;
            if(val_19 <= 15)
            {
                    val_19 = xx.Length;
            }
            
            uint val_31 = val_26;
            val_31 = val_24 - val_31;
            uint val_2 = val_1 + val_31;
            val_23 = val_2 + val_48[0];
            z[0] = val_23;
            val_28 = val_28 + val_25;
            uint val_34 = val_26;
            val_34 = val_34 - val_1;
            val_34 = val_34 + val_28;
            val_34 = val_34 + (val_23 >> 32);
            val_1 = val_34 + val_48[0];
            z[0] = val_1;
            val_29 = (val_34 + val_25) + val_29;
            val_1 = val_1 >> 32;
            uint val_36 = val_24;
            val_36 = val_28 + val_36;
            val_36 = val_29 - val_36;
            val_36 = val_36 + val_1;
            val_1 = val_36 + val_48[1];
            z[1] = val_1;
            val_1 = val_1 >> 32;
            uint val_5 = val_48[7] + val_26;
            uint val_6 = val_2 - val_29;
            val_6 = val_6 + val_5;
            val_6 = val_6 + val_1;
            val_1 = val_6 + val_48[1];
            z[1] = val_1;
            val_1 = val_1 >> 32;
            uint val_39 = val_24;
            val_39 = val_39 + val_19;
            val_39 = val_39 + val_2;
            val_39 = val_39 + val_28;
            val_39 = val_39 - val_5;
            val_39 = val_39 + val_1;
            val_1 = val_39 + val_48[2];
            z[2] = val_1;
            uint val_41 = val_24;
            val_1 = val_1 >> 32;
            uint val_7 = val_41 + val_20;
            val_41 = val_7 - val_19;
            val_41 = val_41 + val_28;
            val_41 = val_41 + val_29;
            val_41 = val_41 + val_1;
            val_1 = val_41 + val_48[2];
            z[2] = val_1;
            val_1 = val_1 >> 32;
            uint val_8 = val_21 - val_20;
            val_8 = val_8 + val_29;
            val_8 = val_8 + val_5;
            val_8 = val_8 + val_1;
            val_29 = val_8 + val_48[3];
            z[3] = val_29;
            val_29 = val_29 >> 32;
            uint val_9 = val_19 - val_21;
            val_9 = val_9 + val_22;
            val_9 = val_9 + val_5;
            val_9 = val_9 + val_29;
            val_5 = val_9 + val_48[3];
            z[3] = val_5;
            val_5 = val_5 >> 32;
            uint val_10 = val_20 + val_19;
            val_10 = val_10 - val_22;
            val_10 = val_10 + val_23;
            uint val_12 = val_10 + val_48[4];
            z[4] = val_12;
            val_12 = val_12 >> 32;
            uint val_13 = val_21 - val_23;
            val_13 = val_13 + val_7;
            val_13 = val_13 + val_12;
            uint val_14 = val_13 + val_48[4];
            z[4] = val_14;
            val_14 = val_14 >> 32;
            uint val_15 = val_25 - val_26;
            uint val_16 = val_22 + val_21;
            val_16 = val_16 - val_31;
            val_16 = val_16 + val_15;
            val_16 = val_16 + val_14;
            val_14 = val_16 + val_48[5];
            z[5] = val_14;
            val_14 = val_14 >> 32;
            uint val_17 = val_23 + val_22;
            val_17 = val_17 - val_15;
            val_17 = val_17 + val_14;
            val_48 = val_17 + val_48[5];
            z[5] = val_48;
            val_48 = (val_48 >> 32) + 1;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(x:  val_48, z:  z);
        }
        public static void Reduce32(uint x, uint[] z)
        {
            var val_7;
            int val_8;
            uint val_9;
            int val_10;
            int val_11;
            var val_12;
            if(x == 0)
            {
                goto label_1;
            }
            
            uint val_12 = x;
            val_8 = z.Length;
            if(val_8 == 0)
            {
                    val_8 = z.Length;
            }
            
            uint val_1 = z[0] + val_12;
            if(val_8 == 0)
            {
                    val_8 = z.Length;
            }
            
            z[0] = val_1;
            val_1 = val_1 >> 32;
            if(val_8 <= 1)
            {
                    val_8 = z.Length;
            }
            
            uint val_8 = z[0];
            val_8 = val_8 - val_12;
            uint val_2 = val_8 + val_1;
            val_9 = val_2 >> 32;
            z[0] = val_2;
            if(val_9 != 0)
            {
                    val_10 = z.Length;
                if(val_10 <= 2)
            {
                    val_10 = z.Length;
            }
            
                val_9 = val_9 + z[1];
                z[1] = val_9;
                val_9 = val_9 >> 32;
            }
            
            val_11 = z.Length;
            if(val_11 <= 3)
            {
                    val_11 = z.Length;
            }
            
            uint val_3 = val_9 + val_12;
            val_9 = val_3 + z[1];
            if(val_11 <= 3)
            {
                    val_11 = z.Length;
            }
            
            z[1] = val_9;
            val_7 = val_9 >> 32;
            if(val_11 <= 4)
            {
                    val_11 = z.Length;
            }
            
            val_3 = val_7 + val_12;
            val_12 = val_3 + z[2];
            z[2] = val_12;
            if((val_12 >> 32) == 0)
            {
                goto label_17;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  12, z:  z, zPos:  5)) != 0)
            {
                goto label_15;
            }
            
            goto label_17;
            label_1:
            label_17:
            if(z[5] != 1)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23)) == false)
            {
                    return;
            }
            
            label_15:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  24);
            Org.BouncyCastle.Math.Raw.Nat384.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  24);
            Org.BouncyCastle.Math.Raw.Nat384.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat384.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(xx:  val_1, z:  z);
                val_2 = val_2 - 1;
            }
            while(val_2 > 0);
        
        }
        public static void Subtract(uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  12, x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SubPInvFrom(z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            System.UInt32[] val_4;
            var val_5;
            System.UInt32[] val_6;
            var val_7;
            val_4 = xx;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  24, x:  val_4, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv;
            val_6 = val_4;
            if(val_4 == null)
            {
                    val_6 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length, x:  val_6, z:  zz)) == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  24, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_3;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  12, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_9:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z:  z);
            return;
            label_1:
            if(z[5] != 1)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  12, x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23)) == true)
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
            if(val_6 == 0)
            {
                    val_6 = z.Length;
            }
            
            z[0] = val_1;
            val_1 = val_1 >> 32;
            if(val_6 <= 1)
            {
                    val_6 = z.Length;
            }
            
            uint val_7 = z[0];
            val_7 = val_1 + val_7;
            uint val_2 = val_7 - 1;
            val_1 = val_2 >> 32;
            z[0] = val_2;
            if(val_1 != 0)
            {
                    val_7 = z.Length;
                if(val_7 <= 2)
            {
                    val_7 = z.Length;
            }
            
                val_1 = val_1 + z[1];
                z[1] = val_1;
                val_8 = (val_1 >> 32) + 1;
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
            if(val_9 <= 3)
            {
                    val_9 = z.Length;
            }
            
            z[1] = val_8;
            val_8 = val_8 >> 32;
            if(val_9 <= 4)
            {
                    val_9 = z.Length;
            }
            
            uint val_10 = z[2];
            val_10 = val_8 + val_10;
            val_8 = val_10 + 1;
            z[2] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return;
            }
            
            uint val_5 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  12, z:  z, zPos:  5);
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
            if(val_6 == 0)
            {
                    val_6 = z.Length;
            }
            
            z[0] = val_1;
            val_1 = val_1 >> 32;
            if(val_6 <= 1)
            {
                    val_6 = z.Length;
            }
            
            uint val_7 = z[0];
            val_7 = val_1 + val_7;
            uint val_2 = val_7 + 1;
            val_1 = val_2 >> 32;
            z[0] = val_2;
            if(val_1 != 0)
            {
                    val_7 = z.Length;
                if(val_7 <= 2)
            {
                    val_7 = z.Length;
            }
            
                val_1 = val_1 + z[1];
                z[1] = val_1;
                val_8 = (val_1 >> 32) - 1;
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
            if(val_9 <= 3)
            {
                    val_9 = z.Length;
            }
            
            z[1] = val_8;
            val_8 = val_8 >> 32;
            if(val_9 <= 4)
            {
                    val_9 = z.Length;
            }
            
            uint val_10 = z[2];
            val_10 = val_8 + val_10;
            val_8 = val_10 - 1;
            z[2] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return;
            }
            
            int val_5 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  12, z:  z, zPos:  5);
        }
        public SecP384R1Field()
        {
        
        }
        private static SecP384R1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23 = new uint[12] {-1, 0, 0, -1, -2, -1, -1, -1, -1, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt = new uint[24] {1, -2, 0, 2, 0, -2, 0, 2, 1, 0, 0, 0, -2, 1, 0, -2, -3, -1, -1, -1, -1, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv = new uint[17] {-1, 1, -1, -3, -1, 1, -1, -3, -2, -1, -1, -1, 1, -2, -1, 1, 2};
        }
    
    }

}
