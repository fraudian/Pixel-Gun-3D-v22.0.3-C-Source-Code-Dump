using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP384R1FieldElement : ECFieldElement
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
        public SecP384R1FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_5;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    val_5 = null;
                val_5 = null;
                if(((x.CompareTo(value:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q)) & 2147483648) != 0)
            {
                    this.x = Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.FromBigInteger(x:  x);
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for SecP384R1FieldElement", paramName:  "x");
        }
        public SecP384R1FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
        }
        protected internal SecP384R1FieldElement(uint[] x)
        {
            this.x = x;
        }
        public override bool get_IsZero()
        {
            return Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  12, x:  this.x);
        }
        public override bool get_IsOne()
        {
            return Org.BouncyCastle.Math.Raw.Nat.IsOne(len:  12, x:  this.x);
        }
        public override bool TestBitZero()
        {
            return (bool)((Org.BouncyCastle.Math.Raw.Nat.GetBit(x:  this.x, bit:  0)) == 1) ? 1 : 0;
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            return Org.BouncyCastle.Math.Raw.Nat.ToBigInteger(len:  12, x:  this.x);
        }
        public override string get_FieldName()
        {
            return "SecP384R1Field";
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q != null)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Add(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_6;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23, x:  b, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_1, y:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Negate(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt23, x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            var val_9 = this;
            if((Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  12, x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_9;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IsOne(len:  12, x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_9;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_3, n:  2, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  val_3, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_4, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  this.x, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  5, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_5, n:  5, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_6, y:  val_4, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_6, n:  15, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  val_6, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  2, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_3, y:  val_5, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_5, n:  28, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  val_5, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  60, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_5, n:  120, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  val_5, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  15, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  val_6, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  33, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  val_3, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  64, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_4, y:  this.x, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(x:  val_4, n:  30, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_3, z:  val_4);
            val_9 = 0;
            if((Org.BouncyCastle.Math.Raw.Nat.Eq(len:  12, x:  this.x, y:  val_4)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_9;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_8 = null;
            val_9 = val_8;
            val_8 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_3;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_9;
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
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement other)
        {
            if(this == other)
            {
                    return true;
            }
            
            if(other == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.Eq(len:  12, x:  this.x, y:  other.x);
        }
        public override int GetHashCode()
        {
            null = null;
            int val_1 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.x, off:  0, len:  12);
            val_1 = val_1 ^ Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q;
            return (int)val_1;
        }
        private static SecP384R1FieldElement()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q = Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve.SecP384R1_DEFAULT_COORDS;
        }
    
    }

}
