using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class ECBasisType
    {
        // Fields
        public const byte ec_basis_trinomial = 1;
        public const byte ec_basis_pentanomial = 2;
        
        // Methods
        public static bool IsValid(byte ecBasisType)
        {
            byte val_1 = ecBasisType - 1;
            val_1 = val_1 & 255;
            return (bool)(val_1 < 2) ? 1 : 0;
        }
        protected ECBasisType()
        {
        
        }
    
    }

}
