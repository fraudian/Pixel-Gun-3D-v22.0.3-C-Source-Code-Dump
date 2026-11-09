using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
    public interface IGcmExponentiator
    {
        // Methods
        public abstract void Init(byte[] x); // 0
        public abstract void ExponentiateX(long pow, byte[] output); // 0
    
    }

}
