using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IVerifier
    {
        // Methods
        public abstract bool IsVerified(byte[] data); // 0
        public abstract bool IsVerified(byte[] source, int off, int length); // 0
    
    }

}
