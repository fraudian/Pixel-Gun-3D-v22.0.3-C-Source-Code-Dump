using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public abstract class AsymmetricKeyParameter : ICipherParameters
    {
        // Fields
        private readonly bool privateKey;
        
        // Properties
        public bool IsPrivate { get; }
        
        // Methods
        protected AsymmetricKeyParameter(bool privateKey)
        {
            this.privateKey = privateKey;
        }
        public bool get_IsPrivate()
        {
            return (bool)this.privateKey;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                    return false;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.AsymmetricKeyParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            return false;
        }
        protected bool Equals(Org.BouncyCastle.Crypto.AsymmetricKeyParameter other)
        {
            var val_2 = (other.privateKey == true) ? 1 : 0;
            val_2 = ((this.privateKey == true) ? 1 : 0) ^ val_2;
            return (bool)val_2 ^ 1;
        }
        public override int GetHashCode()
        {
            return (int)this.privateKey.GetHashCode();
        }
    
    }

}
