using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class CipherType
    {
        // Fields
        public const int stream = 0;
        public const int block = 1;
        public const int aead = 2;
        
        // Methods
        protected CipherType()
        {
        
        }
    
    }

}
