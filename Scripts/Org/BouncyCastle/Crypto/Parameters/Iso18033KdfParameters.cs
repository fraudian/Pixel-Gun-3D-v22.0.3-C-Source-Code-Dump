using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class Iso18033KdfParameters : IDerivationParameters
    {
        // Fields
        private byte[] seed;
        
        // Methods
        public Iso18033KdfParameters(byte[] seed)
        {
            this.seed = seed;
        }
        public byte[] GetSeed()
        {
            return (System.Byte[])this.seed;
        }
    
    }

}
