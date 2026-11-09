using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsCompression
    {
        // Methods
        public abstract System.IO.Stream Compress(System.IO.Stream output); // 0
        public abstract System.IO.Stream Decompress(System.IO.Stream output); // 0
    
    }

}
