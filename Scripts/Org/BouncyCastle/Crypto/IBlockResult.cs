using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IBlockResult
    {
        // Methods
        public abstract byte[] Collect(); // 0
        public abstract int Collect(byte[] destination, int offset); // 0
    
    }

}
