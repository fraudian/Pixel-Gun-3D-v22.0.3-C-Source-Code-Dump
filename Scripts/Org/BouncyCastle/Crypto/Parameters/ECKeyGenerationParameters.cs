using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ECKeyGenerationParameters : KeyGenerationParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.ECDomainParameters domainParams;
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.ECDomainParameters DomainParameters { get; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet { get; }
        
        // Methods
        public ECKeyGenerationParameters(Org.BouncyCastle.Crypto.Parameters.ECDomainParameters domainParameters, Org.BouncyCastle.Security.SecureRandom random)
        {
            int val_1 = domainParameters.n.BitLength;
            this.domainParams = domainParameters;
        }
        public ECKeyGenerationParameters(Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, Org.BouncyCastle.Security.SecureRandom random)
        {
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_1 = Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.LookupParameters(publicKeyParamSet:  publicKeyParamSet);
            this.publicKeyParamSet = publicKeyParamSet;
        }
        public Org.BouncyCastle.Crypto.Parameters.ECDomainParameters get_DomainParameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)this.domainParams;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_PublicKeyParamSet()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.publicKeyParamSet;
        }
    
    }

}
