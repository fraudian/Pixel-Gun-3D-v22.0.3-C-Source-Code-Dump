using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class PrfAlgorithm
    {
        // Fields
        public const int tls_prf_legacy = 0;
        public const int tls_prf_sha256 = 1;
        public const int tls_prf_sha384 = 2;
        
        // Methods
        protected PrfAlgorithm()
        {
        
        }
    
    }

}
