using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    public interface IFiniteField
    {
        // Properties
        public abstract Org.BouncyCastle.Math.BigInteger Characteristic { get; }
        public abstract int Dimension { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Math.BigInteger get_Characteristic(); // 0
        public abstract int get_Dimension(); // 0
    
    }

}
