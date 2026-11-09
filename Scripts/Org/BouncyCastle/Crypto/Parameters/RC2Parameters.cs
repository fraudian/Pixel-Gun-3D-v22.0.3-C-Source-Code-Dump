using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class RC2Parameters : KeyParameter
    {
        // Fields
        private readonly int bits;
        
        // Properties
        public int EffectiveKeyBits { get; }
        
        // Methods
        public RC2Parameters(byte[] key)
        {
            this.bits = (key.Length > 128) ? 1024 : (key.Length << 3);
        }
        public RC2Parameters(byte[] key, int keyOff, int keyLen)
        {
            this.bits = (keyLen > 128) ? 1024 : (keyLen << 3);
        }
        public RC2Parameters(byte[] key, int bits)
        {
            this.bits = bits;
        }
        public RC2Parameters(byte[] key, int keyOff, int keyLen, int bits)
        {
            this.bits = bits;
        }
        public int get_EffectiveKeyBits()
        {
            return (int)this.bits;
        }
    
    }

}
