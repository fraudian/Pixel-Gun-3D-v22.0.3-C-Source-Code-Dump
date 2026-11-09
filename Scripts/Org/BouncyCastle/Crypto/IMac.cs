using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IMac
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract string get_AlgorithmName(); // 0
        public abstract int GetMacSize(); // 0
        public abstract void Update(byte input); // 0
        public abstract void BlockUpdate(byte[] input, int inOff, int len); // 0
        public abstract int DoFinal(byte[] output, int outOff); // 0
        public abstract void Reset(); // 0
    
    }

}
