using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IDerivationFunction
    {
        // Properties
        public abstract Org.BouncyCastle.Crypto.IDigest Digest { get; }
        
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.IDerivationParameters parameters); // 0
        public abstract Org.BouncyCastle.Crypto.IDigest get_Digest(); // 0
        public abstract int GenerateBytes(byte[] output, int outOff, int length); // 0
    
    }

}
