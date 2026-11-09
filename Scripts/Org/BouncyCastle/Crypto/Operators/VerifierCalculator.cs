using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    internal class VerifierCalculator : IStreamCalculator
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.ISigner sig;
        private readonly System.IO.Stream stream;
        
        // Properties
        public System.IO.Stream Stream { get; }
        
        // Methods
        internal VerifierCalculator(Org.BouncyCastle.Crypto.ISigner sig)
        {
            this.sig = sig;
            this.stream = new Org.BouncyCastle.Crypto.Operators.SignerBucket(signer:  sig);
        }
        public System.IO.Stream get_Stream()
        {
            return (System.IO.Stream)this.stream;
        }
        public object GetResult()
        {
            .sig = this.sig;
            return (object)new Org.BouncyCastle.Crypto.Operators.VerifierResult();
        }
    
    }

}
