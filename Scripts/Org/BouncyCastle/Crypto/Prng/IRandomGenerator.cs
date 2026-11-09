using UnityEngine;

namespace Org.BouncyCastle.Crypto.Prng
{
    public interface IRandomGenerator
    {
        // Methods
        public abstract void AddSeedMaterial(byte[] seed); // 0
        public abstract void AddSeedMaterial(long seed); // 0
        public abstract void NextBytes(byte[] bytes); // 0
        public abstract void NextBytes(byte[] bytes, int start, int len); // 0
    
    }

}
