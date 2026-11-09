using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class FpFieldElement : ECFieldElement
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger q;
        private readonly Org.BouncyCastle.Math.BigInteger r;
        private readonly Org.BouncyCastle.Math.BigInteger x;
        
        // Properties
        public override string FieldName { get; }
        public override int FieldSize { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        
        // Methods
        internal static Org.BouncyCastle.Math.BigInteger CalculateResidue(Org.BouncyCastle.Math.BigInteger p)
        {
            var val_10;
            var val_11;
            int val_1 = p.BitLength;
            if(val_1 < 96)
            {
                    return 0;
            }
            
            if((p.ShiftRight(n:  val_1 - 64).LongValue) == 1)
            {
                goto label_5;
            }
            
            if((val_1 & 7) == 0)
            {
                goto label_6;
            }
            
            return 0;
            label_5:
            val_10 = null;
            val_10 = null;
            Org.BouncyCastle.Math.BigInteger val_6 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  val_1);
            if(val_6 != null)
            {
                    return val_6.Subtract(n:  p);
            }
            
            return val_6.Subtract(n:  p);
            label_6:
            val_11 = null;
            val_11 = null;
            Org.BouncyCastle.Math.BigInteger val_9 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  val_1 << 1).Divide(val:  p);
            if(val_9 != null)
            {
                    return val_9.Negate();
            }
            
            return val_9.Negate();
        }
        public FpFieldElement(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = Org.BouncyCastle.Math.EC.FpFieldElement.CalculateResidue(p:  q);
        }
        internal FpFieldElement(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger x)
        {
            val_1 = new System.Object();
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    if(((x.CompareTo(value:  q)) & 2147483648) != 0)
            {
                    this.q = q;
                this.r = val_1;
                this.x = x;
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "value invalid in Fp field element", paramName:  "x");
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.x;
        }
        public override string get_FieldName()
        {
            return "Fp";
        }
        public override int get_FieldSize()
        {
            if(this.q != null)
            {
                    return this.q.BitLength;
            }
            
            return this.q.BitLength;
        }
        public Org.BouncyCastle.Math.BigInteger get_Q()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.q;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            var val_4;
            Org.BouncyCastle.Math.BigInteger val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            val_5 = this.x.Add(value:  Org.BouncyCastle.Math.BigInteger.One);
            if((val_5.CompareTo(value:  this.q)) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  val_5 = Org.BouncyCastle.Math.BigInteger.Zero);
            }
            
            val_6 = null;
            val_6 = null;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  val_5);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            Org.BouncyCastle.Math.BigInteger val_3 = this.x.Multiply(val:  b).Subtract(n:  x.Multiply(val:  y));
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            Org.BouncyCastle.Math.BigInteger val_12;
            var val_13;
            val_12 = b;
            val_13 = this.x.Multiply(val:  val_12).Add(value:  x.Multiply(val:  y));
            if(this.r == null)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            }
            
            if((this.r.SignValue & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            }
            
            val_12 = this.q;
            if(val_13.BitLength <= (val_12.BitLength << 1))
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            }
            
            if(this.q != null)
            {
                    val_12 = this.q.BitLength;
            }
            else
            {
                    val_12 = 0.BitLength;
            }
            
            val_13 = val_13.Subtract(n:  this.q.ShiftLeft(n:  val_12));
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            if(this.x.SignValue == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            Org.BouncyCastle.Math.EC.FpFieldElement val_3 = null;
            this = val_3;
            val_3 = new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this.q.Subtract(n:  this.x));
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            Org.BouncyCastle.Math.BigInteger val_3 = this.x.Multiply(val:  this.x).Subtract(n:  x.Multiply(val:  y));
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            Org.BouncyCastle.Math.BigInteger val_12;
            var val_13;
            val_12 = y;
            val_13 = this.x.Multiply(val:  this.x).Add(value:  x.Multiply(val:  val_12));
            if(this.r == null)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            }
            
            if((this.r.SignValue & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            }
            
            val_12 = this.q;
            if(val_13.BitLength <= (val_12.BitLength << 1))
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            }
            
            if(this.q != null)
            {
                    val_12 = this.q.BitLength;
            }
            else
            {
                    val_12 = 0.BitLength;
            }
            
            val_13 = val_13.Subtract(n:  this.q.ShiftLeft(n:  val_12));
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            int val_31;
            var val_32;
            var val_33;
            if(this.IsZero == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            if(this.IsOne != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            if((this.q.TestBit(n:  0)) == false)
            {
                goto label_4;
            }
            
            bool val_4 = this.q.TestBit(n:  1);
            if(this.q == null)
            {
                goto label_6;
            }
            
            if(val_4 == false)
            {
                goto label_7;
            }
            
            label_12:
            val_27 = null;
            val_27 = null;
            Org.BouncyCastle.Math.EC.FpFieldElement val_8 = null;
            label_56:
            label_20:
            val_8 = new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this.x.ModPow(e:  this.q.ShiftRight(n:  2).Add(value:  Org.BouncyCastle.Math.BigInteger.One), m:  this.q));
            return this.CheckSqrt(z:  val_8);
            label_6:
            if(val_4 == true)
            {
                goto label_12;
            }
            
            label_7:
            if((this.q.TestBit(n:  2)) == false)
            {
                goto label_13;
            }
            
            Org.BouncyCastle.Math.BigInteger val_11 = this.x.ModPow(e:  this.q.ShiftRight(n:  3), m:  this.q);
            val_28 = null;
            val_28 = null;
            if((this & 1) == 0)
            {
                goto label_19;
            }
            
            goto label_20;
            label_13:
            Org.BouncyCastle.Math.BigInteger val_12 = this.q.ShiftRight(n:  1);
            val_29 = null;
            val_29 = null;
            if(((this.x.ModPow(e:  val_12, m:  this.q)) & 1) == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            val_30 = null;
            val_30 = null;
            Org.BouncyCastle.Math.BigInteger val_15 = this.q.Subtract(n:  Org.BouncyCastle.Math.BigInteger.One);
            do
            {
                label_50:
                Org.BouncyCastle.Math.BigInteger val_17 = Org.BouncyCastle.Math.BigInteger.Arbitrary(sizeInBits:  this.q.BitLength);
            }
            while(((val_17.CompareTo(value:  this.q)) & 2147483648) == 0);
            
            Org.BouncyCastle.Math.BigInteger val_20 = val_17.Multiply(val:  val_17).Subtract(n:  this);
            if(((val_12.ModPow(e:  val_12, m:  this.q)) & 1) == 0)
            {
                goto label_50;
            }
            
            Org.BouncyCastle.Math.BigInteger[] val_22 = this.LucasSequence(P:  val_17, Q:  this.x, k:  val_12.Add(value:  Org.BouncyCastle.Math.BigInteger.One));
            val_31 = val_22.Length;
            if(val_31 == 0)
            {
                    val_31 = val_22.Length;
            }
            
            Org.BouncyCastle.Math.BigInteger val_27 = val_22[0];
            Org.BouncyCastle.Math.BigInteger val_28 = val_22[1];
            if((this & 1) != 0)
            {
                goto label_45;
            }
            
            val_32 = null;
            val_32 = null;
            if(((val_27 & 1) != 0) || ((val_27 & 1) != 0))
            {
                goto label_50;
            }
            
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            label_19:
            val_33 = null;
            val_33 = null;
            Org.BouncyCastle.Math.BigInteger val_24 = Org.BouncyCastle.Math.BigInteger.Two.ModPow(e:  this.q.ShiftRight(n:  2), m:  this.q);
            goto label_56;
            label_45:
            Org.BouncyCastle.Math.EC.FpFieldElement val_25 = new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.q, r:  this.r, x:  this);
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            label_4:
            System.Exception val_26 = Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException(message:  "even value of q");
        }
        private Org.BouncyCastle.Math.EC.ECFieldElement CheckSqrt(Org.BouncyCastle.Math.EC.ECFieldElement z)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)(z != 1) ? z : 0;
        }
        private Org.BouncyCastle.Math.BigInteger[] LucasSequence(Org.BouncyCastle.Math.BigInteger P, Org.BouncyCastle.Math.BigInteger Q, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_30;
            var val_31;
            Org.BouncyCastle.Math.BigInteger val_32;
            Org.BouncyCastle.Math.BigInteger val_33;
            Org.BouncyCastle.Math.BigInteger val_34;
            Org.BouncyCastle.Math.BigInteger val_35;
            var val_36;
            Org.BouncyCastle.Math.BigInteger val_37;
            Org.BouncyCastle.Math.BigInteger val_38;
            if(k != null)
            {
                    val_30 = k.BitLength;
            }
            else
            {
                    val_30 = 0.BitLength;
            }
            
            int val_3 = k.GetLowestSetBit();
            val_31 = null;
            val_31 = null;
            int val_4 = val_30 - 1;
            val_32 = Org.BouncyCastle.Math.BigInteger.One;
            val_33 = Org.BouncyCastle.Math.BigInteger.Two;
            int val_5 = val_3 + 1;
            val_34 = this;
            val_35 = P;
            if(val_4 >= val_5)
            {
                    do
            {
                if((k.TestBit(n:  val_4)) != false)
            {
                    val_36 = this;
                val_32 = this;
                Org.BouncyCastle.Math.BigInteger val_9 = val_35.Multiply(val:  val_33).Subtract(n:  P.Multiply(val:  this));
                val_33 = this;
                Org.BouncyCastle.Math.BigInteger val_12 = val_35.Multiply(val:  val_35).Subtract(n:  this.ShiftLeft(n:  1));
                val_35 = this;
            }
            else
            {
                    Org.BouncyCastle.Math.BigInteger val_14 = val_32.Multiply(val:  val_33).Subtract(n:  this);
                val_32 = this;
                Org.BouncyCastle.Math.BigInteger val_17 = val_35.Multiply(val:  val_33).Subtract(n:  P.Multiply(val:  this));
                val_35 = this;
                Org.BouncyCastle.Math.BigInteger val_20 = val_33.Multiply(val:  val_33).Subtract(n:  this.ShiftLeft(n:  1));
                val_33 = this;
                val_36 = val_34;
            }
            
                val_4 = val_4 - 1;
                val_34 = this;
            }
            while(val_4 >= val_5);
            
            }
            
            Org.BouncyCastle.Math.BigInteger val_22 = this.Multiply(val:  this).Subtract(n:  this);
            val_37 = this;
            Org.BouncyCastle.Math.BigInteger val_25 = this.Multiply(val:  this).Subtract(n:  P.Multiply(val:  this));
            val_38 = this;
            if(val_3 >= 1)
            {
                    var val_30 = 1;
                do
            {
                val_37 = this;
                Org.BouncyCastle.Math.BigInteger val_28 = this.Multiply(val:  this).Subtract(n:  this.ShiftLeft(n:  1));
                val_38 = this;
                val_30 = val_30 + 1;
            }
            while(val_30 <= val_3);
            
            }
            
            Org.BouncyCastle.Math.BigInteger[] val_29 = new Org.BouncyCastle.Math.BigInteger[2];
            if(val_29 == null)
            {
                goto label_34;
            }
            
            if(this != null)
            {
                goto label_35;
            }
            
            goto label_38;
            label_34:
            if(this == null)
            {
                goto label_38;
            }
            
            label_35:
            label_38:
            val_29[0] = val_37;
            val_29[1] = val_38;
            return val_29;
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModAdd(Org.BouncyCastle.Math.BigInteger x1, Org.BouncyCastle.Math.BigInteger x2)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = x1.Add(value:  x2);
            if(((val_1.CompareTo(value:  this.q)) & 2147483648) != 0)
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    return val_1.Subtract(n:  this.q);
            }
            
            return val_1.Subtract(n:  this.q);
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModDouble(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = x.ShiftLeft(n:  1);
            if(((val_1.CompareTo(value:  this.q)) & 2147483648) != 0)
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    return val_1.Subtract(n:  this.q);
            }
            
            return val_1.Subtract(n:  this.q);
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModHalf(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_3 = x;
            if((val_3.TestBit(n:  0)) != false)
            {
                    val_3 = this.q.Add(value:  val_3 = x);
            }
            
            if(val_3 != null)
            {
                    return val_3.ShiftRight(n:  1);
            }
            
            return val_3.ShiftRight(n:  1);
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModHalfAbs(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_3 = x;
            if((val_3.TestBit(n:  0)) != false)
            {
                    val_3 = this.q.Subtract(n:  val_3 = x);
            }
            
            if(val_3 != null)
            {
                    return val_3.ShiftRight(n:  1);
            }
            
            return val_3.ShiftRight(n:  1);
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModInverse(Org.BouncyCastle.Math.BigInteger x)
        {
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  25388502);
            Org.BouncyCastle.Math.Raw.Mod.Invert(p:  Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bits:  812432048, x:  this.q), x:  Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bits:  812432048, x:  x), z:  val_3);
            return Org.BouncyCastle.Math.Raw.Nat.ToBigInteger(len:  25388502, x:  val_3);
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModMult(Org.BouncyCastle.Math.BigInteger x1, Org.BouncyCastle.Math.BigInteger x2)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = x1.Multiply(val:  x2);
            goto typeof(Org.BouncyCastle.Math.EC.FpFieldElement).__il2cppRuntimeField_338;
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModReduce(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_31;
            var val_32;
            Org.BouncyCastle.Math.BigInteger val_33;
            Org.BouncyCastle.Math.BigInteger val_34;
            var val_35;
            val_31 = x;
            if(this.r == null)
            {
                goto label_1;
            }
            
            int val_1 = val_31.SignValue;
            if((val_1 & 2147483648) != 0)
            {
                    val_31 = val_31.Abs();
            }
            
            int val_30 = this.q.BitLength;
            if(this.r.SignValue < 1)
            {
                goto label_7;
            }
            
            val_32 = null;
            val_32 = null;
            val_33 = this.r;
            val_34 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  val_30);
            goto label_12;
            label_19:
            if(val_31 != null)
            {
                    val_33 = val_31.ShiftRight(n:  val_30);
            }
            else
            {
                    val_33 = 0.ShiftRight(n:  val_30);
            }
            
            if((val_33 & 1) == 0)
            {
                    val_33 = val_33.Multiply(val:  this.r);
            }
            
            val_31 = val_33.Add(value:  val_31.Remainder(n:  val_34));
            label_12:
            if(val_31.BitLength > (val_30 + 1))
            {
                goto label_19;
            }
            
            goto label_34;
            label_1:
            if(val_31 != null)
            {
                    return val_31.Mod(m:  this.q);
            }
            
            return val_31.Mod(m:  this.q);
            label_7:
            val_33 = ((val_30 + 31) & 31) + 1;
            val_30 = val_33 + val_30;
            val_35 = null;
            val_35 = null;
            Org.BouncyCastle.Math.BigInteger val_21 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  val_30);
            val_34 = this.r.Negate().Multiply(val:  val_31.ShiftRight(n:  val_30 - val_33)).ShiftRight(n:  val_30).Multiply(val:  this.q).Remainder(n:  val_21);
            val_31 = val_31.Remainder(n:  val_21).Subtract(n:  val_34);
            if((val_31.SignValue & 2147483648) == 0)
            {
                goto label_34;
            }
            
            Org.BouncyCastle.Math.BigInteger val_26 = val_31.Add(value:  val_21);
            goto label_36;
            label_39:
            label_36:
            val_31 = val_31.Subtract(n:  this.q);
            label_34:
            if(((val_31.CompareTo(value:  this.q)) & 2147483648) == 0)
            {
                goto label_39;
            }
            
            if((val_1 & 2147483648) == 0)
            {
                    return val_31;
            }
            
            if(val_31.SignValue == 0)
            {
                    return val_31;
            }
            
            if(this.q != null)
            {
                    return this.q.Subtract(n:  val_31);
            }
            
            return this.q.Subtract(n:  val_31);
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ModSubtract(Org.BouncyCastle.Math.BigInteger x1, Org.BouncyCastle.Math.BigInteger x2)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = x1.Subtract(n:  x2);
            if((val_1.SignValue & 2147483648) == 0)
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    return val_1.Add(value:  this.q);
            }
            
            return val_1.Add(value:  this.q);
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.FpFieldElement other)
        {
            if((this.q & 1) == 0)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_1 = this.GetHashCode();
            val_1 = val_1 ^ this.q;
            return (int)val_1;
        }
    
    }

}
