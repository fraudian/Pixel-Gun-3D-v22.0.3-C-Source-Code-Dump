using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class IesWithCipherParameters : IesParameters
    {
        // Fields
        private int cipherKeySize;
        
        // Properties
        public int CipherKeySize { get; }
        
        // Methods
        public IesWithCipherParameters(byte[] derivation, byte[] encoding, int macKeySize, int cipherKeySize)
        {
            val_1 = new System.Object();
            mem[1152921551363235504] = derivation;
            mem[1152921551363235512] = encoding;
            mem[1152921551363235520] = macKeySize;
            this.cipherKeySize = cipherKeySize;
        }
        public int get_CipherKeySize()
        {
            return (int)this.cipherKeySize;
        }
    
    }

}
