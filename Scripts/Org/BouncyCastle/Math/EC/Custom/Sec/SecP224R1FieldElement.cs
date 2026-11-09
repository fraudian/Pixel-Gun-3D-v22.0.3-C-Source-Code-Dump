using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP224R1FieldElement : ECFieldElement
    {
        // Fields
        public static readonly Org.BouncyCastle.Math.BigInteger Q;
        protected internal readonly uint[] x;
        
        // Properties
        public override bool IsZero { get; }
        public override bool IsOne { get; }
        public override string FieldName { get; }
        public override int FieldSize { get; }
        
        // Methods
        public SecP224R1FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_5;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    val_5 = null;
                val_5 = null;
                if(((x.CompareTo(value:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q)) & 2147483648) != 0)
            {
                    this.x = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.FromBigInteger(x:  x);
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for SecP224R1FieldElement", paramName:  "x");
        }
        public SecP224R1FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat224.Create();
        }
        protected internal SecP224R1FieldElement(uint[] x)
        {
            this.x = x;
        }
        public override bool get_IsZero()
        {
            return Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  this.x);
        }
        public override bool get_IsOne()
        {
            return Org.BouncyCastle.Math.Raw.Nat224.IsOne(x:  this.x);
        }
        public override bool TestBitZero()
        {
            return (bool)((Org.BouncyCastle.Math.Raw.Nat224.GetBit(x:  this.x, bit:  0)) == 1) ? 1 : 0;
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            return Org.BouncyCastle.Math.Raw.Nat224.ToBigInteger(x:  this.x);
        }
        public override string get_FieldName()
        {
            return "SecP224R1Field";
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q != null)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_6;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13, x:  b, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_1, y:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Negate(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13, x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            System.UInt32[] val_10 = this;
            if((Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat224.IsOne(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Negate(x:  this.x, z:  Org.BouncyCastle.Math.Raw.Nat224.Create());
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Mod.Random(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13);
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            if((Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.IsSquare(x:  this.x)) == true)
            {
                goto label_9;
            }
            
            val_10 = 0;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            label_15:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddOne(x:  val_4, z:  val_4);
            label_9:
            if((Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.TrySqrt(nc:  val_10, r:  val_4, t:  val_5)) == false)
            {
                goto label_15;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_5, z:  val_4);
            val_10 = 0;
            if((Org.BouncyCastle.Math.Raw.Nat224.Eq(x:  this.x, y:  val_4)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_9 = null;
            val_10 = val_9;
            val_9 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_5;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
        }
        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                
            }
        
        }
        public override bool Equals(Org.BouncyCastle.Math.EC.ECFieldElement other)
        {
            if(other != null)
            {
                
            }
        
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement other)
        {
            if(this == other)
            {
                    return true;
            }
            
            if(other == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat224.Eq(x:  this.x, y:  other.x);
        }
        public override int GetHashCode()
        {
            null = null;
            int val_1 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.x, off:  0, len:  7);
            val_1 = val_1 ^ Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q;
            return (int)val_1;
        }
        private static bool IsSquare(uint[] x)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            System.UInt32[] val_2 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  x, z:  val_1);
            var val_3 = 0;
            do
            {
                Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  val_1, z:  val_2);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.SquareN(x:  val_1, n:  1, z:  val_1);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_1, y:  val_2, z:  val_1);
                val_3 = val_3 + 1;
            }
            while(val_3 != 7);
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.SquareN(x:  val_1, n:  95, z:  val_1);
            return Org.BouncyCastle.Math.Raw.Nat224.IsOne(x:  val_1);
        }
        private static void RM(uint[] nc, uint[] d0, uint[] e0, uint[] d1, uint[] e1, uint[] f1, uint[] t)
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  e1, y:  e0, z:  t);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  t, y:  nc, z:  t);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  d1, y:  d0, z:  f1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(x:  f1, y:  t, z:  f1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  d1, y:  e0, z:  t);
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  f1, z:  d1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  e1, y:  d0, z:  e1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(x:  e1, y:  t, z:  e1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  e1, z:  f1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  f1, y:  nc, z:  f1);
        }
        private static void RP(uint[] nc, uint[] d1, uint[] e1, uint[] f1, uint[] t)
        {
            var val_4;
            var val_5;
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  nc, z:  f1);
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            System.UInt32[] val_2 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            var val_4 = 0;
            label_7:
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  d1, z:  val_1);
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  e1, z:  val_2);
            val_4 = null;
            val_5 = 0;
            goto label_1;
            label_4:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RS(d:  d1, e:  e1, f:  f1, t:  t);
            val_4 = null;
            val_5 = -1;
            label_1:
            var val_3 = ((Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if((val_5 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RM(nc:  nc, d0:  val_1, e0:  val_2, d1:  d1, e1:  e1, f1:  f1, t:  t);
            val_4 = val_4 + 1;
            if(val_4 != 7)
            {
                goto label_7;
            }
        
        }
        private static void RS(uint[] d, uint[] e, uint[] f, uint[] t)
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  e, y:  d, z:  e);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Twice(x:  e, z:  e);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  d, z:  t);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(x:  f, y:  t, z:  d);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  f, y:  t, z:  f);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(len:  7, z:  f, bits:  2, c:  0), z:  f);
        }
        private static bool TrySqrt(uint[] nc, uint[] r, uint[] t)
        {
            var val_7;
            var val_8;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  r, z:  val_1);
            System.UInt32[] val_2 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_2[0] = 1;
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RP(nc:  nc, d1:  val_1, e1:  val_2, f1:  val_3, t:  t);
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            var val_7 = 0;
            label_8:
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  val_1, z:  val_4);
            Org.BouncyCastle.Math.Raw.Nat224.Copy(x:  val_2, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RS(d:  val_1, e:  val_2, f:  val_3, t:  t);
            if((Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  val_1)) == true)
            {
                goto label_7;
            }
            
            val_7 = val_7 + 1;
            if(val_7 < 95)
            {
                goto label_8;
            }
            
            val_7 = 0;
            return (bool)val_7;
            label_7:
            val_8 = null;
            val_8 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt13, x:  val_5, z:  t);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  t, y:  val_4, z:  t);
            val_7 = 1;
            return (bool)val_7;
        }
        private static SecP224R1FieldElement()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1_DEFAULT_COORDS;
        }
    
    }

}
