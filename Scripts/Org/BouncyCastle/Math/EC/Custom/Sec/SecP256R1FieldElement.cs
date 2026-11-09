using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP256R1FieldElement : ECFieldElement
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
        public SecP256R1FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_5;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    val_5 = null;
                val_5 = null;
                if(((x.CompareTo(value:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q)) & 2147483648) != 0)
            {
                    this.x = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.FromBigInteger(x:  x);
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for SecP256R1FieldElement", paramName:  "x");
        }
        public SecP256R1FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat256.Create();
        }
        protected internal SecP256R1FieldElement(uint[] x)
        {
            this.x = x;
        }
        public override bool get_IsZero()
        {
            return Org.BouncyCastle.Math.Raw.Nat256.IsZero(x:  this.x);
        }
        public override bool get_IsOne()
        {
            return Org.BouncyCastle.Math.Raw.Nat256.IsOne(x:  this.x);
        }
        public override bool TestBitZero()
        {
            return (bool)((Org.BouncyCastle.Math.Raw.Nat256.GetBit(x:  this.x, bit:  0)) == 1) ? 1 : 0;
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            return Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(x:  this.x);
        }
        public override string get_FieldName()
        {
            return "SecP256R1Field";
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q != null)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Add(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Subtract(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_6;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15, x:  b, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_1, y:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Negate(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt15, x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            var val_7 = this;
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_7;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat256.IsOne(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_7;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Square(x:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_3, n:  2, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_4, y:  val_3, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_4, n:  4, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_3, y:  val_4, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_3, n:  8, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_4, y:  val_3, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_4, n:  16, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_3, y:  val_4, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_3, n:  32, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_3, n:  96, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(x:  val_3, n:  94, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(x:  val_3, y:  val_3, z:  val_4);
            val_7 = 0;
            if((Org.BouncyCastle.Math.Raw.Nat256.Eq(x:  this.x, y:  val_4)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_7;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement val_6 = null;
            val_7 = val_6;
            val_6 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement();
            .x = val_3;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_7;
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
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement other)
        {
            if(this == other)
            {
                    return true;
            }
            
            if(other == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat256.Eq(x:  this.x, y:  other.x);
        }
        public override int GetHashCode()
        {
            null = null;
            int val_1 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.x, off:  0, len:  8);
            val_1 = val_1 ^ Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q;
            return (int)val_1;
        }
        private static SecP256R1FieldElement()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q = Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve.SecP256R1_DEFAULT_COORDS;
        }
    
    }

}
