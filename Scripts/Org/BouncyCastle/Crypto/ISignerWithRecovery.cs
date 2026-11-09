using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface ISignerWithRecovery : ISigner
    {
        // Methods
        public abstract bool HasFullMessage(); // 0
        public abstract byte[] GetRecoveredMessage(); // 0
        public abstract void UpdateWithRecoveredMessage(byte[] signature); // 0
    
    }

}
