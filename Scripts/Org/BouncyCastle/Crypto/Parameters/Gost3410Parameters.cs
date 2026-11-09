using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class Gost3410Parameters : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger p;
        private readonly Org.BouncyCastle.Math.BigInteger q;
        private readonly Org.BouncyCastle.Math.BigInteger a;
        private readonly Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters validation;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        public Org.BouncyCastle.Math.BigInteger A { get; }
        public Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters ValidationParameters { get; }
        
        // Methods
        public Gost3410Parameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger a)
        {
        
        }
        public Gost3410Parameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters validation)
        {
            string val_4;
            val_1 = new System.Object();
            if(p == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(a == null)
            {
                goto label_3;
            }
            
            this.p = p;
            this.q = val_1;
            this.a = a;
            this.validation = validation;
            return;
            label_1:
            val_4 = "p";
            goto label_5;
            label_2:
            val_4 = "q";
            goto label_5;
            label_3:
            val_4 = "a";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.p;
        }
        public Org.BouncyCastle.Math.BigInteger get_Q()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.q;
        }
        public Org.BouncyCastle.Math.BigInteger get_A()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.a;
        }
        public Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters get_ValidationParameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters)this.validation;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters other)
        {
            Org.BouncyCastle.Math.BigInteger val_7;
            var val_8;
            val_7 = this.p;
            val_8 = other;
            if((val_7 & 1) == 0)
            {
                    return false;
            }
            
            val_7 = this.q;
            if((val_7 & 1) == 0)
            {
                    return false;
            }
            
            val_8 = ???;
            val_7 = ???;
            goto Org.BouncyCastle.Math.BigInteger.__il2cppRuntimeField_vtable;
        }
        public override int GetHashCode()
        {
            Org.BouncyCastle.Math.BigInteger val_2 = this.a;
            val_2 = this.q ^ this.p ^ val_2;
            return (int)val_2;
        }
    
    }

}
