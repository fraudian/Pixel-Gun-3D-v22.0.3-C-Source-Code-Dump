using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class DerStringBase : Asn1Object, IAsn1String
    {
        // Methods
        protected DerStringBase()
        {
        
        }
        public abstract string GetString(); // 0
        public override string ToString()
        {
            goto typeof(Org.BouncyCastle.Asn1.DerStringBase).__il2cppRuntimeField_1C8;
        }
        protected override int Asn1GetHashCode()
        {
            if(this != null)
            {
                    return this.GetHashCode();
            }
            
            return this.GetHashCode();
        }
    
    }

}
