using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IDsa
    {
        // Properties
        public abstract string AlgorithmName { get; }
        
        // Methods
        public abstract string get_AlgorithmName(); // 0
        public abstract void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message); // 0
        public abstract bool VerifySignature(byte[] message, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s); // 0
    
    }

}
