using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
    internal class Curve25519FieldElement : ECFieldElement
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
        public Curve25519FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_5;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    val_5 = null;
                val_5 = null;
                if(((x.CompareTo(value:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q)) & 2147483648) != 0)
            {
                    this.x = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.FromBigInteger(x:  x);
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for Curve25519FieldElement", paramName:  "x");
        }
        public Curve25519FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat256.Create();
        }
        protected internal Curve25519FieldElement(uint[] x)
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
            return "Curve25519Field";
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q != null)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Add(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  this.x, y:  b, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_6;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv, x:  b, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_1, y:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Negate(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            var val_3;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv, x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            System.UInt32[] val_9;
            var val_10;
            var val_11;
            var val_12;
            val_10 = this;
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat256.IsOne(x:  this.x)) == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
            val_9 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  this.x, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_9, y:  this.x, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_9, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_9, y:  this.x, z:  val_9);
            System.UInt32[] val_4 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_9, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_4, y:  this.x, z:  val_4);
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_4, n:  3, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_5, y:  val_9, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_5, n:  4, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_9, y:  val_4, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_9, n:  4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_5, n:  15, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_4, y:  val_5, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_4, n:  30, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_5, y:  val_4, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_5, n:  60, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_4, y:  val_5, z:  val_4);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_4, n:  11, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_5, y:  val_9, z:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x:  val_5, n:  120, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_9, y:  val_4, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_9, z:  val_9);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_9, z:  val_4);
            val_11 = null;
            if((Org.BouncyCastle.Math.Raw.Nat256.Eq(x:  this.x, y:  val_4)) != false)
            {
                    val_12 = val_11;
            }
            else
            {
                    val_11 = null;
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_9, y:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.PRECOMP_POW2, z:  val_9);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_9, z:  val_4);
                val_10 = 0;
                if((Org.BouncyCastle.Math.Raw.Nat256.Eq(x:  this.x, y:  val_4)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_10;
            }
            
                val_12 = null;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_8 = null;
            val_10 = val_8;
            val_8 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_9;
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
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement other)
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
            val_1 = val_1 ^ Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q;
            return (int)val_1;
        }
        private static Curve25519FieldElement()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q = Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519_DEFAULT_COORDS;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.PRECOMP_POW2 = new uint[8] {1242472624, -991028441, -1389370248, 792926214, 1039914919, 726466713, 1338105611, 730014848};
        }
    
    }

}
