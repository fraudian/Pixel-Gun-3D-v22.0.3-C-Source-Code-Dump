using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class KdfParameters : IDerivationParameters
    {
        // Fields
        private byte[] iv;
        private byte[] shared;
        
        // Methods
        public KdfParameters(byte[] shared, byte[] iv)
        {
            this.iv = iv;
            this.shared = shared;
        }
        public byte[] GetSharedSecret()
        {
            return (System.Byte[])this.shared;
        }
        public byte[] GetIV()
        {
            return (System.Byte[])this.iv;
        }
    
    }

}
