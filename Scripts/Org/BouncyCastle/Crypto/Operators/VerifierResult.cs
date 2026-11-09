using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    internal class VerifierResult : IVerifier
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.ISigner sig;
        
        // Methods
        internal VerifierResult(Org.BouncyCastle.Crypto.ISigner sig)
        {
            this.sig = sig;
        }
        public bool IsVerified(byte[] signature)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.sig.VerifySignature(signature:  signature);
        }
        public bool IsVerified(byte[] signature, int off, int length)
        {
            System.Array val_3;
            byte[] val_1 = new byte[0];
            val_3 = val_1;
            System.Array.Copy(sourceArray:  signature, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  off, length:  val_1.Length);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 5;
            return this.sig.VerifySignature(signature:  signature);
        }
    
    }

}
