using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP160R2FieldElement : ECFieldElement
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
        public SecP160R2FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_5;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    val_5 = null;
                val_5 = null;
                if(((x.CompareTo(value:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q)) & 2147483648) != 0)
            {
                    this.x = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.FromBigInteger(x:  x);
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for SecP160R2FieldElement", paramName:  "x");
        }
        public SecP160R2FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat160.Create();
        }
        protected internal SecP160R2FieldElement(uint[] x)
        {
            this.x = x;
        }
        public override bool get_IsZero()
        {
            return Org.BouncyCastle.Math.Raw.Nat160.IsZero(x:  this.x);
        }
        public override bool get_IsOne()
        {
            return Org.BouncyCastle.Math.Raw.Nat160.IsOne(x:  this.x);
        }
        public override bool TestBitZero()
        {
            return (bool)((Org.BouncyCastle.Math.Raw.Nat160.GetBit(x:  this.x, bit:  0)) == 1) ? 1 : 0;
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            return Org.BouncyCastle.Math.Raw.Nat160.ToBigInteger(x:  this.x);
        }
        public override string get_FieldName()
        {
            return "SecP160R2Field";
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q != null)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Add(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Subtract(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_6;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PInv33, x:  b, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_1, y:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Negate(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PInv33, x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            var val_10 = this;
            if((Org.BouncyCastle.Math.Raw.Nat160.IsZero(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat160.IsOne(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x:  val_3, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_4, y:  this.x, z:  val_4);
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  this.x, z:  val_5);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  3, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_6, y:  val_4, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_6, n:  7, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  val_6, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  3, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_6, y:  val_4, z:  val_6);
            System.UInt32[] val_7 = Org.BouncyCastle.Math.Raw.Nat160.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_6, n:  14, z:  val_7);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_7, y:  val_5, z:  val_7);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_7, n:  31, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  val_7, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  62, z:  val_7);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_7, y:  val_5, z:  val_7);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_7, n:  3, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  18, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  val_6, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  2, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  this.x, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  3, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  val_3, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  6, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x:  val_5, n:  2, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x:  val_5, y:  this.x, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x:  val_5, z:  val_3);
            val_10 = 0;
            if((Org.BouncyCastle.Math.Raw.Nat160.Eq(x:  this.x, y:  val_3)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement val_9 = null;
            val_10 = val_9;
            val_9 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement();
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
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement other)
        {
            if(this == other)
            {
                    return true;
            }
            
            if(other == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat160.Eq(x:  this.x, y:  other.x);
        }
        public override int GetHashCode()
        {
            null = null;
            int val_1 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.x, off:  0, len:  5);
            val_1 = val_1 ^ Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q;
            return (int)val_1;
        }
        private static SecP160R2FieldElement()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.SecP160R2_DEFAULT_COORDS;
        }
    
    }

}
