using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IBlockCipher
    {
        // Properties
        public abstract string AlgorithmName { get; }
        public abstract bool IsPartialBlockOkay { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract int GetBlockSize(); // 0
        public abstract bool get_IsPartialBlockOkay(); // 0
        public abstract int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff); // 0
        public abstract void Reset(); // 0
    
    }

}
