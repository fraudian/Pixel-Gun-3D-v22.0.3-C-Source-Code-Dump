using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    internal class SigResult : IBlockResult
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.ISigner sig;
        
        // Methods
        internal SigResult(Org.BouncyCastle.Crypto.ISigner sig)
        {
            this.sig = sig;
        }
        public byte[] Collect()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.sig.GenerateSignature();
        }
        public int Collect(byte[] destination, int offset)
        {
            System.Byte[] val_1 = this.Collect();
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  destination, destinationIndex:  offset, length:  val_1.Length);
            if(val_1 != null)
            {
                    return (int)val_1.Length;
            }
            
            return (int)val_1.Length;
        }
    
    }

}
