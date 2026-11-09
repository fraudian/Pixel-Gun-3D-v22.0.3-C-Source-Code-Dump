using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class ECFieldElement
    {
        // Properties
        public abstract string FieldName { get; }
        public abstract int FieldSize { get; }
        public virtual int BitLength { get; }
        public virtual bool IsOne { get; }
        public virtual bool IsZero { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Math.BigInteger ToBigInteger(); // 0
        public abstract string get_FieldName(); // 0
        public abstract int get_FieldSize(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement AddOne(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Negate(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Square(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Invert(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement Sqrt(); // 0
        public virtual int get_BitLength()
        {
            if(this != null)
            {
                    return this.BitLength;
            }
            
            return this.BitLength;
        }
        public virtual bool get_IsOne()
        {
            return (bool)(this == 1) ? 1 : 0;
        }
        public virtual bool get_IsZero()
        {
            return (bool)(this.SignValue == 0) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
        {
            var val_1;
            var val_2;
            val_1 = pow;
            val_2 = this;
            if(val_1 < 1)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_2;
            }
            
            do
            {
                val_1 = val_1 - 1;
                val_2 = val_2;
            }
            while(val_1 != 0);
            
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_2;
        }
        public virtual bool TestBitZero()
        {
            if(this != null)
            {
                    return this.TestBit(n:  0);
            }
            
            return this.TestBit(n:  0);
        }
        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                
            }
        
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.ECFieldElement other)
        {
            var val_1;
            var val_2;
            val_1 = other;
            if(this == val_1)
            {
                goto label_0;
            }
            
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_1 = ???;
            goto Org.BouncyCastle.Math.EC.ECFieldElement.__il2cppRuntimeField_vtable;
            label_0:
            val_2 = 1;
            return (bool)val_2;
            label_1:
            val_2 = 0;
            return (bool)val_2;
        }
        public override int GetHashCode()
        {
            if(this == null)
            {
                
            }
        
        }
        public override string ToString()
        {
            if(this != null)
            {
                    return this.ToString(radix:  16);
            }
            
            return this.ToString(radix:  16);
        }
        public virtual byte[] GetEncoded()
        {
            int val_1 = (1152921544069072711 < 0) ? 1152921544069072718 : 1152921544069072711;
            val_1 = val_1 >> 3;
            return Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(length:  val_1, n:  this);
        }
        protected ECFieldElement()
        {
        
        }
    
    }

}
