using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ElGamalPublicKeyParameters : ElGamalKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger y;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger Y { get; }
        
        // Methods
        public ElGamalPublicKeyParameters(Org.BouncyCastle.Math.BigInteger y, Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  false);
            mem[1152921551358105960] = parameters;
            if(y != null)
            {
                    this.y = y;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "y");
        }
        public Org.BouncyCastle.Math.BigInteger get_Y()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.y;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters other)
        {
            if((this.y & 1) == 0)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_1 = this.GetHashCode();
            val_1 = val_1 ^ this.y;
            return (int)val_1;
        }
    
    }

}
