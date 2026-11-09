using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class IesParameters : ICipherParameters
    {
        // Fields
        private byte[] derivation;
        private byte[] encoding;
        private int macKeySize;
        
        // Properties
        public int MacKeySize { get; }
        
        // Methods
        public IesParameters(byte[] derivation, byte[] encoding, int macKeySize)
        {
            this.derivation = derivation;
            this.encoding = encoding;
            this.macKeySize = macKeySize;
        }
        public byte[] GetDerivationV()
        {
            return (System.Byte[])this.derivation;
        }
        public byte[] GetEncodingV()
        {
            return (System.Byte[])this.encoding;
        }
        public int get_MacKeySize()
        {
            return (int)this.macKeySize;
        }
    
    }

}
