using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class NameType
    {
        // Fields
        public const byte host_name = 0;
        
        // Methods
        public static bool IsValid(byte nameType)
        {
            return (bool)((nameType & 255) != 0) ? 1 : 0;
        }
        protected NameType()
        {
        
        }
    
    }

}
