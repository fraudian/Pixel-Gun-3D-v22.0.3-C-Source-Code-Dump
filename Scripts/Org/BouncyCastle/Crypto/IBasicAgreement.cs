using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public interface IBasicAgreement
    {
        // Methods
        public abstract void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters); // 0
        public abstract int GetFieldSize(); // 0
        public abstract Org.BouncyCastle.Math.BigInteger CalculateAgreement(Org.BouncyCastle.Crypto.ICipherParameters pubKey); // 0
    
    }

}
