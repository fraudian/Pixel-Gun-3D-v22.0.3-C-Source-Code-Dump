using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    public interface IPolynomial
    {
        // Properties
        public abstract int Degree { get; }
        
        // Methods
        public abstract int get_Degree(); // 0
        public abstract int[] GetExponentsPresent(); // 0
    
    }

}
