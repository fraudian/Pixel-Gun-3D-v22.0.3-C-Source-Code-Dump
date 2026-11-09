using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    public class Asn1SignatureFactory : ISignatureFactory
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;
        private readonly string algorithm;
        private readonly Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
        private readonly Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public object AlgorithmDetails { get; }
        public static System.Collections.IEnumerable SignatureAlgNames { get; }
        
        // Methods
        public Asn1SignatureFactory(string algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
        {
        
        }
        public Asn1SignatureFactory(string algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, Org.BouncyCastle.Security.SecureRandom random)
        {
            val_1 = new System.Object();
            this.algorithm = algorithm;
            this.privateKey = val_1;
            this.random = random;
            this.algID = Org.BouncyCastle.Crypto.Operators.X509Utilities.GetSigAlgID(sigOid:  Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgorithmOid(algorithmName:  algorithm), algorithmName:  algorithm);
        }
        public object get_AlgorithmDetails()
        {
            return (object)this.algID;
        }
        public Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator()
        {
            Org.BouncyCastle.Crypto.ISigner val_1 = Org.BouncyCastle.Security.SignerUtilities.GetSigner(algorithm:  this.algorithm);
            if(this.random != null)
            {
                    Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom val_2 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters:  this.privateKey, random:  this.random);
                var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
            }
            
            val_1.Init(forSigning:  true, parameters:  this.privateKey);
            return (Org.BouncyCastle.Crypto.IStreamCalculator)new Org.BouncyCastle.Crypto.Operators.SigCalculator(sig:  val_1);
        }
        public static System.Collections.IEnumerable get_SignatureAlgNames()
        {
            return Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgNames();
        }
    
    }

}
