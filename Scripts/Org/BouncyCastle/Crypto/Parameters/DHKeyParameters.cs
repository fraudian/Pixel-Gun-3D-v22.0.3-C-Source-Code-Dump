using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DHKeyParameters : AsymmetricKeyParameter
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.DHParameters parameters;
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters { get; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier AlgorithmOid { get; }
        
        // Methods
        protected DHKeyParameters(bool isPrivate, Org.BouncyCastle.Crypto.Parameters.DHParameters parameters)
        {
            null = null;
            isPrivate = isPrivate;
            this.parameters = parameters;
            this.algorithmOid = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DhKeyAgreement;
        }
        protected DHKeyParameters(bool isPrivate, Org.BouncyCastle.Crypto.Parameters.DHParameters parameters, Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid)
        {
            bool val_1 = isPrivate;
            this.parameters = parameters;
            this.algorithmOid = algorithmOid;
        }
        public Org.BouncyCastle.Crypto.Parameters.DHParameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DHParameters)this.parameters;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_AlgorithmOid()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.algorithmOid;
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
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.DHKeyParameters other)
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
