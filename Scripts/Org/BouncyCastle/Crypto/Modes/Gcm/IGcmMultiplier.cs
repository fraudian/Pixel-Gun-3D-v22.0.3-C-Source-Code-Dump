using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
    public interface IGcmMultiplier
    {
        // Methods
        public abstract void Init(byte[] H); // 0
        public abstract void MultiplyH(byte[] x); // 0
    
    }

}
