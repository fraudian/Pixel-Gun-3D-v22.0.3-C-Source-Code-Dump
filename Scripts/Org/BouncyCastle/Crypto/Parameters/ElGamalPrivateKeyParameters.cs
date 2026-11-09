using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger x;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger X { get; }
        
        // Methods
        public ElGamalPrivateKeyParameters(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters)
        {
            this = new Org.BouncyCastle.Crypto.AsymmetricKeyParameter(privateKey:  true);
            mem[1152921551357471208] = parameters;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters other)
        {
            if((other.x & 1) == 0)
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
