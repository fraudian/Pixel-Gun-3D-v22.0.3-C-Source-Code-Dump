using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP224K1FieldElement : ECFieldElement
    {
        // Fields
        public static readonly Org.BouncyCastle.Math.BigInteger Q;
        private static readonly uint[] PRECOMP_POW2;
        protected internal readonly uint[] x;
        
        // Properties
        public override bool IsZero { get; }
        public override bool IsOne { get; }
        public override string FieldName { get; }
        public override int FieldSize { get; }
        
        // Methods
        public SecP224K1FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_5;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    val_5 = null;
                val_5 = null;
                if(((x.CompareTo(value:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q)) & 2147483648) != 0)
            {
                    this.x = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.FromBigInteger(x:  x);
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for SecP224K1FieldElement", paramName:  "x");
        }
        public SecP224K1FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat224.Create();
        }
        protected internal SecP224K1FieldElement(uint[] x)
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
            return "SecP224K1Field";
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q != null)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Add(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_6;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PInv33, x:  b, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_1, y:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Negate(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PInv33, x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            var val_11;
            var val_12;
            var val_13;
            val_11 = this;
            if((Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_11;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat224.IsOne(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_11;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  val_3, z:  val_3);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_3, y:  this.x, z:  val_3);
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  val_3, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_4, y:  this.x, z:  val_4);
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_4, n:  4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_5, n:  3, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_6, y:  val_3, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_6, n:  8, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_6, y:  val_5, z:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_6, n:  4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_5, n:  19, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_4, y:  val_6, z:  val_4);
            System.UInt32[] val_7 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_4, n:  42, z:  val_7);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_7, y:  val_4, z:  val_7);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_7, n:  23, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_4, y:  val_5, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_4, n:  84, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  val_7, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_5, n:  20, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  val_6, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_5, n:  3, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  this.x, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_5, n:  2, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  this.x, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x:  val_5, n:  4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  val_3, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  val_5, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  val_5, z:  val_7);
            val_12 = null;
            if((Org.BouncyCastle.Math.Raw.Nat224.Eq(x:  this.x, y:  val_7)) != false)
            {
                    val_13 = val_12;
            }
            else
            {
                    val_12 = null;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x:  val_5, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.PRECOMP_POW2, z:  val_5);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x:  val_5, z:  val_7);
                val_11 = 0;
                if((Org.BouncyCastle.Math.Raw.Nat224.Eq(x:  this.x, y:  val_7)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_11;
            }
            
                val_13 = null;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement val_10 = null;
            val_11 = val_10;
            val_10 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement();
            .x = val_5;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_11;
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
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement other)
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
            val_1 = val_1 ^ Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q;
            return (int)val_1;
        }
        private static SecP224K1FieldElement()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q = Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_DEFAULT_COORDS;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.PRECOMP_POW2 = new uint[7] {868209154, -587542221, 579297866, -1014948952, -1470801668, 514782679, -1897982644};
        }
    
    }

}
