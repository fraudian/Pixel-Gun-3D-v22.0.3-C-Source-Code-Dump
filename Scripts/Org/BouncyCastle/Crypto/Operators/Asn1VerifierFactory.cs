using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    public class Asn1VerifierFactory : IVerifierFactory
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;
        private readonly Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey;
        
        // Properties
        public object AlgorithmDetails { get; }
        
        // Methods
        public Asn1VerifierFactory(string algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            val_1 = new System.Object();
            this.publicKey = val_1;
            this.algID = Org.BouncyCastle.Crypto.Operators.X509Utilities.GetSigAlgID(sigOid:  Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgorithmOid(algorithmName:  algorithm), algorithmName:  algorithm);
        }
        public Asn1VerifierFactory(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            val_1 = new System.Object();
            this.algID = algorithm;
            this.publicKey = val_1;
        }
        public object get_AlgorithmDetails()
        {
            return (object)this.algID;
        }
        public Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator()
        {
            Org.BouncyCastle.Crypto.ISigner val_2 = Org.BouncyCastle.Security.SignerUtilities.GetSigner(algorithm:  Org.BouncyCastle.Crypto.Operators.X509Utilities.GetSignatureName(sigAlgId:  this.algID));
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_2.Init(forSigning:  false, parameters:  this.publicKey);
            return (Org.BouncyCastle.Crypto.IStreamCalculator)new Org.BouncyCastle.Crypto.Operators.VerifierCalculator(sig:  val_2);
        }
    
    }

}
