using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class ECCurveType
    {
        // Fields
        public const byte explicit_prime = 1;
        public const byte explicit_char2 = 2;
        public const byte named_curve = 3;
        
        // Methods
        protected ECCurveType()
        {
        
        }
    
    }

}
