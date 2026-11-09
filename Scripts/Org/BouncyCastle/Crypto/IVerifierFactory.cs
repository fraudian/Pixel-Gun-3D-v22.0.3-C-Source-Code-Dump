using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IVerifierFactory
    {
        // Properties
        public abstract object AlgorithmDetails { get; }
        
        // Methods
        public abstract object get_AlgorithmDetails(); // 0
        public abstract Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator(); // 0
    
    }

}
