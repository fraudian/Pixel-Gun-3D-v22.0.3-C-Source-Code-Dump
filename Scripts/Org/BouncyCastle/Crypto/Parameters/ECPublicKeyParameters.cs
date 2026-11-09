using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ECPublicKeyParameters : ECKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.EC.ECPoint q;
        
        // Properties
        public Org.BouncyCastle.Math.EC.ECPoint Q { get; }
        
        // Methods
        public ECPublicKeyParameters(Org.BouncyCastle.Math.EC.ECPoint q, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters)
        {
        
        }
        public ECPublicKeyParameters(Org.BouncyCastle.Math.EC.ECPoint q, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            if(q != null)
            {
                    this.q = q;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "q");
        }
        public ECPublicKeyParameters(string algorithm, Org.BouncyCastle.Math.EC.ECPoint q, Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters)
        {
            if(q != null)
            {
                    this.q = q;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "q");
        }
        public ECPublicKeyParameters(string algorithm, Org.BouncyCastle.Math.EC.ECPoint q, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            if(q != null)
            {
                    this.q = q;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "q");
        }
        public Org.BouncyCastle.Math.EC.ECPoint get_Q()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.q;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters other)
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
