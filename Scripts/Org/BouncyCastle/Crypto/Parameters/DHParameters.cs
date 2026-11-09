using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DHParameters : ICipherParameters
    {
        // Fields
        private const int DefaultMinimumLength = 160;
        private readonly Org.BouncyCastle.Math.BigInteger p;
        private readonly Org.BouncyCastle.Math.BigInteger g;
        private readonly Org.BouncyCastle.Math.BigInteger q;
        private readonly Org.BouncyCastle.Math.BigInteger j;
        private readonly int m;
        private readonly int l;
        private readonly Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger G { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        public Org.BouncyCastle.Math.BigInteger J { get; }
        public int M { get; }
        public int L { get; }
        public Org.BouncyCastle.Crypto.Parameters.DHValidationParameters ValidationParameters { get; }
        
        // Methods
        private static int GetDefaultMParam(int lParam)
        {
            if(lParam == 0)
            {
                    return 160;
            }
            
            return System.Math.Min(val1:  lParam, val2:  160);
        }
        public DHParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g)
        {
        
        }
        public DHParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger q)
        {
        
        }
        public DHParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger q, int l)
        {
            int val_1 = Org.BouncyCastle.Crypto.Parameters.DHParameters.GetDefaultMParam(lParam:  l);
        }
        public DHParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger q, int m, int l)
        {
        
        }
        public DHParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger j, Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation)
        {
        
        }
        public DHParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger q, int m, int l, Org.BouncyCastle.Math.BigInteger j, Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            string val_18;
            string val_19;
            string val_21;
            var val_22;
            val_1 = new System.Object();
            if(p == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if((p.TestBit(n:  0)) == false)
            {
                goto label_3;
            }
            
            val_14 = null;
            val_14 = null;
            if(((val_1.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.Two)) & 2147483648) != 0)
            {
                goto label_9;
            }
            
            val_15 = null;
            val_15 = null;
            if((val_1.CompareTo(value:  p.Subtract(n:  Org.BouncyCastle.Math.BigInteger.Two))) >= 1)
            {
                goto label_9;
            }
            
            if(q == null)
            {
                goto label_10;
            }
            
            val_13 = q.BitLength;
            if(val_13 >= p.BitLength)
            {
                goto label_11;
            }
            
            label_10:
            if(p.BitLength <= m)
            {
                goto label_12;
            }
            
            if(l == 0)
            {
                goto label_13;
            }
            
            if(p.BitLength <= l)
            {
                goto label_14;
            }
            
            if(l < m)
            {
                goto label_15;
            }
            
            label_13:
            if(j == null)
            {
                goto label_16;
            }
            
            val_16 = null;
            val_16 = null;
            if(((j.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.Two)) & 2147483648) != 0)
            {
                goto label_19;
            }
            
            label_16:
            this.p = p;
            this.g = val_1;
            this.m = m;
            this.l = l;
            this.q = q;
            this.j = j;
            this.validation = validation;
            return;
            label_9:
            val_18 = "generator must in the range [2, p - 2]";
            val_19 = "g";
            goto label_27;
            label_1:
            val_21 = "p";
            goto label_21;
            label_2:
            System.ArgumentNullException val_11 = null;
            val_21 = "g";
            label_21:
            val_22 = val_11;
            val_11 = new System.ArgumentNullException(paramName:  val_21);
            goto label_22;
            label_3:
            val_18 = "field must be an odd prime";
            val_19 = "p";
            goto label_27;
            label_12:
            val_18 = "m value must be < bitlength of p";
            val_19 = "m";
            goto label_27;
            label_11:
            val_18 = "q too big to be a factor of (p-1)";
            val_19 = "q";
            goto label_27;
            label_14:
            val_18 = "when l value specified, it must be less than bitlength(p)";
            goto label_26;
            label_15:
            val_18 = "when l value specified, it may not be less than m value";
            label_26:
            val_19 = "l";
            goto label_27;
            label_19:
            System.ArgumentException val_12 = null;
            val_18 = "subgroup factor must be >= 2";
            val_19 = "j";
            label_27:
            val_22 = val_12;
            val_12 = new System.ArgumentException(message:  val_18, paramName:  val_19);
            label_22:
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.p;
        }
        public Org.BouncyCastle.Math.BigInteger get_G()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.g;
        }
        public Org.BouncyCastle.Math.BigInteger get_Q()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.q;
        }
        public Org.BouncyCastle.Math.BigInteger get_J()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.j;
        }
        public int get_M()
        {
            return (int)this.m;
        }
        public int get_L()
        {
            return (int)this.l;
        }
        public Org.BouncyCastle.Crypto.Parameters.DHValidationParameters get_ValidationParameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DHValidationParameters)this.validation;
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
        protected virtual bool Equals(Org.BouncyCastle.Crypto.Parameters.DHParameters other)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = this.p;
            if((val_1 & 1) == 0)
            {
                    return false;
            }
            
            val_1 = this.g;
            if((val_1 & 1) == 0)
            {
                    return false;
            }
            
            return System.Object.Equals(objA:  this.q, objB:  other.q);
        }
        public override int GetHashCode()
        {
            var val_2 = this.g ^ this.p;
            if(this.q == null)
            {
                    return (int)val_2;
            }
            
            val_2 = this.q ^ val_2;
            return (int)val_2;
        }
    
    }

}
