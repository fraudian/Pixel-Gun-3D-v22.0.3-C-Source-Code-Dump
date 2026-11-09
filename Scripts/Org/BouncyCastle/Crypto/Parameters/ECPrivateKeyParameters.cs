using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ECPrivateKeyParameters : ECKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger d;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger D { get; }
        
        // Methods
        public ECPrivateKeyParameters(Org.BouncyCastle.Math.BigInteger d, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters)
        {
        
        }
        public ECPrivateKeyParameters(Org.BouncyCastle.Math.BigInteger d, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            if(d != null)
            {
                    this.d = d;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "d");
        }
        public ECPrivateKeyParameters(string algorithm, Org.BouncyCastle.Math.BigInteger d, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters)
        {
            if(d != null)
            {
                    this.d = d;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "d");
        }
        public ECPrivateKeyParameters(string algorithm, Org.BouncyCastle.Math.BigInteger d, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            if(d != null)
            {
                    this.d = d;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "d");
        }
        public Org.BouncyCastle.Math.BigInteger get_D()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.d;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters other)
        {
            if((this.d & 1) == 0)
            {
                    return false;
            }
            
            return other.Equals(other:  other);
        }
        public override int GetHashCode()
        {
            int val_1 = this.GetHashCode();
            val_1 = val_1 ^ this.d;
            return (int)val_1;
        }
    
    }

}
