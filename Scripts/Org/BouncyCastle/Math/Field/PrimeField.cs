using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    internal class PrimeField : IFiniteField
    {
        // Fields
        protected readonly Org.BouncyCastle.Math.BigInteger characteristic;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Characteristic { get; }
        public virtual int Dimension { get; }
        
        // Methods
        internal PrimeField(Org.BouncyCastle.Math.BigInteger characteristic)
        {
            this.characteristic = characteristic;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Characteristic()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.characteristic;
        }
        public virtual int get_Dimension()
        {
            return 1;
        }
        public override bool Equals(object obj)
        {
            var val_2;
            if(this != obj)
            {
                    if(obj != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.Field.PrimeField.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            }
            
                val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        public override int GetHashCode()
        {
            if(this.characteristic == null)
            {
                
            }
        
        }
    
    }

}
