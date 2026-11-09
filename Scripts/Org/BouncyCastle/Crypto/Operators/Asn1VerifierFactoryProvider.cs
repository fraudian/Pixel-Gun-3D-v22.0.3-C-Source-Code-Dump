using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    public class Asn1VerifierFactoryProvider : IVerifierFactoryProvider
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey;
        
        // Properties
        public System.Collections.IEnumerable SignatureAlgNames { get; }
        
        // Methods
        public Asn1VerifierFactoryProvider(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            this.publicKey = publicKey;
        }
        public Org.BouncyCastle.Crypto.IVerifierFactory CreateVerifierFactory(object algorithmDetails)
        {
            object val_4 = algorithmDetails;
            if(val_4 != null)
            {
                    val_4 = 0;
            }
            
            new Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactory() = new System.Object();
            .algID = val_4;
            .publicKey = this.publicKey;
            return (Org.BouncyCastle.Crypto.IVerifierFactory)new Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactory();
        }
        public System.Collections.IEnumerable get_SignatureAlgNames()
        {
            return Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgNames();
        }
    
    }

}
