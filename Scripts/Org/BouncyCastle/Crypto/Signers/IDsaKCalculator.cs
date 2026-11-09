using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public interface IDsaKCalculator
    {
        // Properties
        public abstract bool IsDeterministic { get; }
        
        // Methods
        public abstract bool get_IsDeterministic(); // 0
        public abstract void Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Security.SecureRandom random); // 0
        public abstract void Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger d, byte[] message); // 0
        public abstract Org.BouncyCastle.Math.BigInteger NextK(); // 0
    
    }

}
