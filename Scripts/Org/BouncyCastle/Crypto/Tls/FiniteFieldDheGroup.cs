using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class FiniteFieldDheGroup
    {
        // Fields
        public const byte ffdhe2432 = 0;
        public const byte ffdhe3072 = 1;
        public const byte ffdhe4096 = 2;
        public const byte ffdhe6144 = 3;
        public const byte ffdhe8192 = 4;
        
        // Methods
        public static bool IsValid(byte group)
        {
            return (bool)((group & 255) < 5) ? 1 : 0;
        }
        protected FiniteFieldDheGroup()
        {
        
        }
    
    }

}
