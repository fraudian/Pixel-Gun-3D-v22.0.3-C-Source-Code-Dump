using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public interface IAeadBlockCipher
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher(); // 0
        public abstract void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract int GetBlockSize(); // 0
        public abstract void ProcessAadByte(byte input); // 0
        public abstract void ProcessAadBytes(byte[] inBytes, int inOff, int len); // 0
        public abstract int ProcessByte(byte input, byte[] outBytes, int outOff); // 0
        public abstract int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff); // 0
        public abstract int DoFinal(byte[] outBytes, int outOff); // 0
        public abstract byte[] GetMac(); // 0
        public abstract int GetUpdateOutputSize(int len); // 0
        public abstract int GetOutputSize(int len); // 0
        public abstract void Reset(); // 0
    
    }

}
