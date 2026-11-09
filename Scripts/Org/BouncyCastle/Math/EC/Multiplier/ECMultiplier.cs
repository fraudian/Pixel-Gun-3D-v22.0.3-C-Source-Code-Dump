using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public interface ECMultiplier
    {
        // Methods
        public abstract Org.BouncyCastle.Math.EC.ECPoint Multiply(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k); // 0
    
    }

}
