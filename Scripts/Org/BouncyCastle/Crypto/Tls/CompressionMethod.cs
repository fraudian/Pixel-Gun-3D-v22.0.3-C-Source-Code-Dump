using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class CompressionMethod
    {
        // Fields
        public const byte cls_null = 0;
        public const byte DEFLATE = 1;
        
        // Methods
        protected CompressionMethod()
        {
        
        }
    
    }

}
