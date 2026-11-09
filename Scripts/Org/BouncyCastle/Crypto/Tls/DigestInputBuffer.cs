using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class DigestInputBuffer : MemoryStream
    {
        // Methods
        internal void UpdateDigest(Org.BouncyCastle.Crypto.IDigest d)
        {
            .d = d;
            this.WriteTo(stream:  new DigestInputBuffer.DigStream());
        }
        public DigestInputBuffer()
        {
        
        }
    
    }

}
