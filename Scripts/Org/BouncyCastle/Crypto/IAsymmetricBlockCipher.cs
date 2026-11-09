using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IAsymmetricBlockCipher
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract int GetInputBlockSize(); // 0
        public abstract int GetOutputBlockSize(); // 0
        public abstract byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen); // 0
    
    }

}
