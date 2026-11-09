using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ElGamalKeyParameters : AsymmetricKeyParameter
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters { get; }
        
        // Methods
        protected ElGamalKeyParameters(bool isPrivate, Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters)
        {
            bool val_1 = isPrivate;
            this.parameters = parameters;
        }
        public Org.BouncyCastle.Crypto.Parameters.ElGamalParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ElGamalParameters)this.parameters;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters other)
        {
            if((System.Object.Equals(objA:  this.parameters, objB:  other.parameters)) == false)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_2 = this.GetHashCode();
            if(this.parameters == null)
            {
                    return (int)val_2;
            }
            
            val_2 = this.parameters ^ val_2;
            return (int)val_2;
        }
    
    }

}
