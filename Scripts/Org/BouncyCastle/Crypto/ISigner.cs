using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface ISigner
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract void Update(byte input); // 0
        public abstract void BlockUpdate(byte[] input, int inOff, int length); // 0
        public abstract byte[] GenerateSignature(); // 0
        public abstract bool VerifySignature(byte[] signature); // 0
        public abstract void Reset(); // 0
    
    }

}
