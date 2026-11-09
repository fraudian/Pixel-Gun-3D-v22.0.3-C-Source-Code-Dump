using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Endo
{
    public interface GlvEndomorphism : ECEndomorphism
    {
        // Methods
        public abstract Org.BouncyCastle.Math.BigInteger[] DecomposeScalar(Org.BouncyCastle.Math.BigInteger k); // 0
    
    }

}
