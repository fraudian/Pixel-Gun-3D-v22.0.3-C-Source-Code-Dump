using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IXof : IDigest
    {
        // Methods
        public abstract int DoFinal(byte[] output, int outOff, int outLen); // 0
        public abstract int DoOutput(byte[] output, int outOff, int outLen); // 0
    
    }

}
