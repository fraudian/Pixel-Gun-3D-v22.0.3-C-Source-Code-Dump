using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    public interface IExtensionField : IFiniteField
    {
        // Properties
        public abstract Org.BouncyCastle.Math.Field.IFiniteField Subfield { get; }
        public abstract int Degree { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Math.Field.IFiniteField get_Subfield(); // 0
        public abstract int get_Degree(); // 0
    
    }

}
