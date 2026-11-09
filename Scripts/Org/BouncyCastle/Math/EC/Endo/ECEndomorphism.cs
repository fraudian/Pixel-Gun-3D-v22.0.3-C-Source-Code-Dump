using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Endo
{
    public interface ECEndomorphism
    {
        // Properties
        public abstract Org.BouncyCastle.Math.EC.ECPointMap PointMap { get; }
        public abstract bool HasEfficientPointMap { get; }
        
        // Methods
        public abstract Org.BouncyCastle.Math.EC.ECPointMap get_PointMap(); // 0
        public abstract bool get_HasEfficientPointMap(); // 0
    
    }

}
