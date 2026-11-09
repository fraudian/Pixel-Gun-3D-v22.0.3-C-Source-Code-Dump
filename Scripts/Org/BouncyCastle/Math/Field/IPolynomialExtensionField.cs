using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    public interface IPolynomialExtensionField : IExtensionField, IFiniteField
    {
        // Properties
        public abstract Org.BouncyCastle.Math.Field.IPolynomial MinimalPolynomial { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Math.Field.IPolynomial get_MinimalPolynomial(); // 0
    
    }

}
