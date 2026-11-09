using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class RsaKeyGenerationParameters : KeyGenerationParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger publicExponent;
        private readonly int certainty;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger PublicExponent { get; }
        public int Certainty { get; }
        
        // Methods
        public RsaKeyGenerationParameters(Org.BouncyCastle.Math.BigInteger publicExponent, Org.BouncyCastle.Security.SecureRandom random, int strength, int certainty)
        {
            this.publicExponent = publicExponent;
            this.certainty = certainty;
        }
        public Org.BouncyCastle.Math.BigInteger get_PublicExponent()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.publicExponent;
        }
        public int get_Certainty()
        {
            return (int)this.certainty;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                    return false;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            this = ???;
            goto Org.BouncyCastle.Math.BigInteger.__il2cppRuntimeField_vtable;
        }
        public override int GetHashCode()
        {
            Org.BouncyCastle.Math.BigInteger val_2 = this.publicExponent;
            val_2 = val_2 ^ this.certainty.GetHashCode();
            return (int)val_2;
        }
    
    }

}
