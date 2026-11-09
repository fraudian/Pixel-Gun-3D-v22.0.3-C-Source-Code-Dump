using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT239FieldElement : ECFieldElement
    {
        // Fields
        protected ulong[] x;
        
        // Properties
        public override bool IsOne { get; }
        public override bool IsZero { get; }
        public override string FieldName { get; }
        public override int FieldSize { get; }
        public virtual int Representation { get; }
        public virtual int M { get; }
        public virtual int K1 { get; }
        public virtual int K2 { get; }
        public virtual int K3 { get; }
        
        // Methods
        public SecT239FieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    if(x.BitLength < 240)
            {
                    System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.FromBigInteger64(x:  x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce17(z:  val_3, zOff:  0);
                this.x = val_3;
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid for SecT239FieldElement", paramName:  "x");
        }
        public SecT239FieldElement()
        {
            this.x = Org.BouncyCastle.Math.Raw.Nat256.Create64();
        }
        protected internal SecT239FieldElement(ulong[] x)
        {
            this.x = x;
        }
        public override bool get_IsOne()
        {
            return Org.BouncyCastle.Math.Raw.Nat256.IsOne64(x:  this.x);
        }
        public override bool get_IsZero()
        {
            return Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x:  this.x);
        }
        public override bool TestBitZero()
        {
            return (bool)this.x[0] & 1;
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            return Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger64(x:  this.x);
        }
        public override string get_FieldName()
        {
            return "SecT239Field";
        }
        public override int get_FieldSize()
        {
            return 239;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Add(x:  this.x, y:  null, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddOne(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement).__il2cppRuntimeField_198;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(x:  this.x, y:  null, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement).__il2cppRuntimeField_268;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            System.UInt64[] val_6 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.MultiplyAddToExt(x:  this.x, y:  b, zz:  val_6);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.MultiplyAddToExt(x:  x, y:  y, zz:  val_6);
            System.UInt64[] val_7 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_6, z:  val_7);
            .x = val_7;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            if(b == null)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement).__il2cppRuntimeField_288;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            System.UInt64[] val_5 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareAddToExt(x:  this.x, zz:  val_5);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.MultiplyAddToExt(x:  x, y:  y, zz:  val_5);
            System.UInt64[] val_6 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(xx:  val_5, z:  val_6);
            .x = val_6;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
        {
            if(pow <= 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(x:  this.x, n:  pow, z:  val_1);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement val_2 = null;
            this = val_2;
            val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Invert(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            System.UInt64[] val_1 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Sqrt(x:  this.x, z:  val_1);
            .x = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement();
        }
        public virtual int get_Representation()
        {
            return 2;
        }
        public virtual int get_M()
        {
            return 239;
        }
        public virtual int get_K1()
        {
            return 158;
        }
        public virtual int get_K2()
        {
            return 0;
        }
        public virtual int get_K3()
        {
            return 0;
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
        public virtual bool Equals(Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement other)
        {
            if(this == other)
            {
                    return true;
            }
            
            if(other == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat256.Eq64(x:  this.x, y:  other.x);
        }
        public override int GetHashCode()
        {
            int val_1 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.x, off:  0, len:  4);
            val_1 = val_1 ^ 23900158;
            return (int)val_1;
        }
    
    }

}
