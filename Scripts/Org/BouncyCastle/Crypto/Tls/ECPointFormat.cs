using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class ECPointFormat
    {
        // Fields
        public const byte uncompressed = 0;
        public const byte ansiX962_compressed_prime = 1;
        public const byte ansiX962_compressed_char2 = 2;
        
        // Methods
        protected ECPointFormat()
        {
        
        }
    
    }

}
