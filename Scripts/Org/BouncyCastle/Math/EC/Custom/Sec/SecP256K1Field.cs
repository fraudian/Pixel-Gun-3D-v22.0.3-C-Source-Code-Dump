using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP256K1Field
    {
        // Fields
        internal static readonly uint[] P;
        internal static readonly uint[] PExt;
        private static readonly uint[] PExtInv;
        private const uint P7 = 4294967295;
        private const uint PExt15 = 4294967295;
        private const uint PInv33 = 977;
        
        // Methods
        public static void Add(uint[] x, uint[] y, uint[] z)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat256.Add(x:  x, y:  y, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.Add33To(len:  8, x:  209, z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33)) == true)
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
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  16, x:  val_5, y:  yy, z:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  16, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[7] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  16, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExt)) == true)
            {
                goto label_14;
            }
        
        }
        public static void AddOne(uint[] x, uint[] z)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat.Inc(len:  8, x:  x, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.Add33To(len:  8, x:  209, z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33)) == true)
            {
                goto label_7;
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
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  val_1, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33)) == false)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat256.SubFrom(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33, z:  val_1);
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
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  8, z:  z, c:  Org.BouncyCastle.Math.Raw.Nat256.Add(x:  x, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33, z:  z));
        }
        public static void Multiply(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  x, y:  y, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
        {
            System.UInt32[] val_5;
            var val_6;
            System.UInt32[] val_7;
            var val_8;
            var val_9;
            val_5 = x;
            if((Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x:  val_5, y:  y, zz:  zz)) == 0)
            {
                goto label_1;
            }
            
            label_14:
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv;
            val_7 = val_5;
            if(val_5 == null)
            {
                    val_7 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length, x:  val_7, z:  zz)) == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  16, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length);
            return;
            label_1:
            if(zz[7] != 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  16, x:  zz, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExt)) == true)
            {
                goto label_14;
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
            int val_2 = Org.BouncyCastle.Math.Raw.Nat256.Sub(x:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33, y:  x, z:  z);
        }
        public static void Reduce(uint[] xx, uint[] z)
        {
            var val_5;
            if((Org.BouncyCastle.Math.Raw.Nat256.Mul33DWordAdd(x:  209, y:  Org.BouncyCastle.Math.Raw.Nat256.Mul33Add(w:  209, x:  xx, xOff:  8, y:  xx, yOff:  0, z:  z, zOff:  0), z:  z, zOff:  0)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.Add33To(len:  8, x:  209, z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33)) == true)
            {
                goto label_7;
            }
        
        }
        public static void Reduce32(uint x, uint[] z)
        {
            var val_4;
            if(x != 0)
            {
                    if((Org.BouncyCastle.Math.Raw.Nat256.Mul33WordAdd(x:  209, y:  x, z:  z, zOff:  0)) != 0)
            {
                goto label_2;
            }
            
            }
            
            if(z[3] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33)) == false)
            {
                    return;
            }
            
            label_2:
            uint val_3 = Org.BouncyCastle.Math.Raw.Nat.Add33To(len:  8, x:  209, z:  z);
        }
        public static void Square(uint[] x, uint[] z)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(xx:  val_1, z:  z);
        }
        public static void SquareN(uint[] x, int n, uint[] z)
        {
            var val_2;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(xx:  val_1, z:  z);
            val_2 = n - 1;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                Org.BouncyCastle.Math.Raw.Nat256.Square(x:  z, zz:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(xx:  val_1, z:  z);
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
            
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.Sub33From(len:  8, x:  209, z:  z);
        }
        public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
        {
            System.UInt32[] val_4;
            var val_5;
            System.UInt32[] val_6;
            var val_7;
            val_4 = xx;
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  16, x:  val_4, y:  yy, z:  zz)) == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv;
            val_6 = val_4;
            if(val_4 == null)
            {
                    val_6 = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length, x:  val_6, z:  zz)) == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            int val_3 = Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  16, z:  zz, zPos:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length);
        }
        public static void Twice(uint[] x, uint[] z)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  8, x:  x, c:  0, z:  z)) == 0)
            {
                goto label_1;
            }
            
            label_7:
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.Add33To(len:  8, x:  209, z:  z);
            return;
            label_1:
            if(z[3] != 1)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  z, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33)) == true)
            {
                goto label_7;
            }
        
        }
        public SecP256K1Field()
        {
        
        }
        private static SecP256K1Field()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PInv33 = new uint[8] {-977, -2, -1, -1, -1, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExt = new uint[16] {954529, 1954, 1, 0, 0, 0, 0, 0, -1954, -3, -1, -1, -1, -1, -1, -1};
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv = new uint[10] {-954529, -1955, -2, -1, -1, -1, -1, -1, 1953, 2};
        }
    
    }

}
