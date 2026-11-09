using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IStreamCalculator
    {
        // Properties
        public abstract System.IO.Stream Stream { get; }
        
        // Methods
        public abstract System.IO.Stream get_Stream(); // 0
        public abstract object GetResult(); // 0
    
    }

}
