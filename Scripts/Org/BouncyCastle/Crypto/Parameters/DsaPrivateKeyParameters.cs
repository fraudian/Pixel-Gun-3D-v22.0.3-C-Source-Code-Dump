using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DsaPrivateKeyParameters : DsaKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger x;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger X { get; }
        
        // Methods
        public DsaPrivateKeyParameters(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  true);
            mem[1152921551346709384] = parameters;
            if(x != null)
            {
                    this.x = x;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "x");
        }
        public Org.BouncyCastle.Math.BigInteger get_X()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.x;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters other)
        {
            if((this.x & 1) == 0)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_1 = this.GetHashCode();
            val_1 = val_1 ^ this.x;
            return (int)val_1;
        }
    
    }

}
