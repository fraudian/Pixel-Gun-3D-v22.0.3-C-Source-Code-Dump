using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DsaParameters : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger p;
        private readonly Org.BouncyCastle.Math.BigInteger q;
        private readonly Org.BouncyCastle.Math.BigInteger g;
        private readonly Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters validation;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        public Org.BouncyCastle.Math.BigInteger G { get; }
        public Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters ValidationParameters { get; }
        
        // Methods
        public DsaParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger g)
        {
        
        }
        public DsaParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters parameters)
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
            
            if(g == null)
            {
                goto label_3;
            }
            
            this.p = p;
            this.q = val_1;
            this.g = g;
            this.validation = parameters;
            return;
            label_1:
            val_4 = "p";
            goto label_5;
            label_2:
            val_4 = "q";
            goto label_5;
            label_3:
            val_4 = "g";
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
        public Org.BouncyCastle.Math.BigInteger get_G()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.g;
        }
        public Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters get_ValidationParameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters)this.validation;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.DsaParameters other)
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
            Org.BouncyCastle.Math.BigInteger val_2 = this.g;
            val_2 = this.q ^ this.p ^ val_2;
            return (int)val_2;
        }
    
    }

}
