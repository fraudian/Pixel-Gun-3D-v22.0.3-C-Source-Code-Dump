using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class MaxFragmentLength
    {
        // Fields
        public const byte pow2_9 = 1;
        public const byte pow2_10 = 2;
        public const byte pow2_11 = 3;
        public const byte pow2_12 = 4;
        
        // Methods
        public static bool IsValid(byte maxFragmentLength)
        {
            byte val_1 = maxFragmentLength - 1;
            val_1 = val_1 & 255;
            return (bool)(val_1 < 4) ? 1 : 0;
        }
        protected MaxFragmentLength()
        {
        
        }
    
    }

}
