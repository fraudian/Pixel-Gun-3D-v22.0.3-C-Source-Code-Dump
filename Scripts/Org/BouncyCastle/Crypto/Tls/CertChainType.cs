using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class CertChainType
    {
        // Fields
        public const byte individual_certs = 0;
        public const byte pkipath = 1;
        
        // Methods
        public static bool IsValid(byte certChainType)
        {
            return (bool)((certChainType & 255) < 2) ? 1 : 0;
        }
        protected CertChainType()
        {
        
        }
    
    }

}
