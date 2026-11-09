using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IWrapper
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forWrapping, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract byte[] Wrap(byte[] input, int inOff, int length); // 0
        public abstract byte[] Unwrap(byte[] input, int inOff, int length); // 0
    
    }

}
