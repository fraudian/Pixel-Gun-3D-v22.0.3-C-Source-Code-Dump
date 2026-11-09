using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    internal class GF2Polynomial : IPolynomial
    {
        // Fields
        protected readonly int[] exponents;
        
        // Properties
        public virtual int Degree { get; }
        
        // Methods
        internal GF2Polynomial(int[] exponents)
        {
            this.exponents = Org.BouncyCastle.Utilities.Arrays.Clone(data:  exponents);
        }
        public virtual int get_Degree()
        {
            var val_2 = -4294967296;
            val_2 = val_2 + ((this.exponents.Length) << 32);
            return (int)this.exponents[val_2 >> 32];
        }
        public virtual int[] GetExponentsPresent()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.exponents);
        }
        public override bool Equals(object obj)
        {
            var val_2;
            if(this != obj)
            {
                    if(obj != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.Field.GF2Polynomial.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            }
            
                val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        public override int GetHashCode()
        {
            return Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.exponents);
        }
    
    }

}
