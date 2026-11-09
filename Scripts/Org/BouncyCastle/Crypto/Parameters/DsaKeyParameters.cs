using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public abstract class DsaKeyParameters : AsymmetricKeyParameter
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters { get; }
        
        // Methods
        protected DsaKeyParameters(bool isPrivate, Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters)
        {
            bool val_1 = isPrivate;
            this.parameters = parameters;
        }
        public Org.BouncyCastle.Crypto.Parameters.DsaParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DsaParameters)this.parameters;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters other)
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
