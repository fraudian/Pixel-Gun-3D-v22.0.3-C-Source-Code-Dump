using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IBufferedCipher
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract int GetBlockSize(); // 0
        public abstract int GetOutputSize(int inputLen); // 0
        public abstract int GetUpdateOutputSize(int inputLen); // 0
        public abstract byte[] ProcessByte(byte input); // 0
        public abstract int ProcessByte(byte input, byte[] output, int outOff); // 0
        public abstract byte[] ProcessBytes(byte[] input); // 0
        public abstract byte[] ProcessBytes(byte[] input, int inOff, int length); // 0
        public abstract int ProcessBytes(byte[] input, byte[] output, int outOff); // 0
        public abstract int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff); // 0
        public abstract byte[] DoFinal(); // 0
        public abstract byte[] DoFinal(byte[] input); // 0
        public abstract byte[] DoFinal(byte[] input, int inOff, int length); // 0
        public abstract int DoFinal(byte[] output, int outOff); // 0
        public abstract int DoFinal(byte[] input, byte[] output, int outOff); // 0
        public abstract int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff); // 0
        public abstract void Reset(); // 0
    
    }

}
