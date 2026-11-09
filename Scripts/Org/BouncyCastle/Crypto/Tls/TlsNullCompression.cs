using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsNullCompression : TlsCompression
    {
        // Methods
        public virtual System.IO.Stream Compress(System.IO.Stream output)
        {
            return (System.IO.Stream)output;
        }
        public virtual System.IO.Stream Decompress(System.IO.Stream output)
        {
            return (System.IO.Stream)output;
        }
        public TlsNullCompression()
        {
        
        }
    
    }

}
