using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class SignerInputBuffer : MemoryStream
    {
        // Methods
        internal void UpdateSigner(Org.BouncyCastle.Crypto.ISigner s)
        {
            .s = s;
            this.WriteTo(stream:  new SignerInputBuffer.SigStream());
        }
        public SignerInputBuffer()
        {
        
        }
    
    }

}
