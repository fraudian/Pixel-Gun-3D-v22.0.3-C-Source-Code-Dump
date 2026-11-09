using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public abstract class Gost3410KeyParameters : AsymmetricKeyParameter
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters;
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters Parameters { get; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet { get; }
        
        // Methods
        protected Gost3410KeyParameters(bool isPrivate, Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters)
        {
            bool val_1 = isPrivate;
            this.parameters = parameters;
        }
        protected Gost3410KeyParameters(bool isPrivate, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            bool val_1 = isPrivate;
            this.parameters = Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters.LookupParameters(publicKeyParamSet:  publicKeyParamSet);
            this.publicKeyParamSet = publicKeyParamSet;
        }
        public Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters get_Parameters()
        {
            return (Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters)this.parameters;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_PublicKeyParamSet()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.publicKeyParamSet;
        }
        private static Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters LookupParameters(Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
        {
            var val_8;
            if(publicKeyParamSet == null)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters val_1 = Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.GetByOid(oid:  publicKeyParamSet);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            return (Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters)new Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters(p:  val_1.P, q:  val_1.Q, a:  val_1.A, validation:  0);
            label_1:
            System.ArgumentNullException val_6 = null;
            val_8 = val_6;
            val_6 = new System.ArgumentNullException(paramName:  "publicKeyParamSet");
            goto label_5;
            label_4:
            System.ArgumentException val_7 = null;
            val_8 = val_7;
            val_7 = new System.ArgumentException(message:  "OID is not a valid CryptoPro public key parameter set", paramName:  "publicKeyParamSet");
            label_5:
        }
    
    }

}
