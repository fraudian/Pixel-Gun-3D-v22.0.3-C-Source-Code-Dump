using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IAsymmetricCipherKeyPairGenerator
    {
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters); // 0
        public abstract Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair(); // 0
    
    }

}
