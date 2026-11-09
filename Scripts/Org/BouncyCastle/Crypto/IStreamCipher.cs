using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IStreamCipher
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract byte ReturnByte(byte input); // 0
        public abstract void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff); // 0
        public abstract void Reset(); // 0
    
    }

}
