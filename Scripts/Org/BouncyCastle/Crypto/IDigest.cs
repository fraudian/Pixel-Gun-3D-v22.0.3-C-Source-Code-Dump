using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IDigest
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract int GetDigestSize(); // 0
        public abstract int GetByteLength(); // 0
        public abstract void Update(byte input); // 0
        public abstract void BlockUpdate(byte[] input, int inOff, int length); // 0
        public abstract int DoFinal(byte[] output, int outOff); // 0
        public abstract void Reset(); // 0
    
    }

}
