using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IVerifierFactoryProvider
    {
        // Methods
        public abstract Org.BouncyCastle.Crypto.IVerifierFactory CreateVerifierFactory(object algorithmDetails); // 0
    
    }

}
