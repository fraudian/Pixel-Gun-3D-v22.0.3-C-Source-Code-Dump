using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class RsaBlindingParameters : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey;
        private readonly Org.BouncyCastle.Math.BigInteger blindingFactor;
        
        // Properties
        public Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters PublicKey { get; }
        public Org.BouncyCastle.Math.BigInteger BlindingFactor { get; }
        
        // Methods
        public RsaBlindingParameters(Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey, Org.BouncyCastle.Math.BigInteger blindingFactor)
        {
            val_1 = new System.Object();
            if(publicKey.IsPrivate != true)
            {
                    this.publicKey = publicKey;
                this.blindingFactor = val_1;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "RSA parameters should be for a public key");
        }
        public Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters get_PublicKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)this.publicKey;
        }
        public Org.BouncyCastle.Math.BigInteger get_BlindingFactor()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.blindingFactor;
        }
    
    }

}
