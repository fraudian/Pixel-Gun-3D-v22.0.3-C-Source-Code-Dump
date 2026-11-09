using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class RandomDsaKCalculator : IDsaKCalculator
    {
        // Fields
        private Org.BouncyCastle.Math.BigInteger q;
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual bool IsDeterministic { get; }
        
        // Methods
        public virtual bool get_IsDeterministic()
        {
            return false;
        }
        public virtual void Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Security.SecureRandom random)
        {
            this.q = n;
            this.random = random;
        }
        public virtual void Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger d, byte[] message)
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Operation not supported");
        }
        public virtual Org.BouncyCastle.Math.BigInteger NextK()
        {
            do
            {
                Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  this.q.BitLength, random:  this.random);
            }
            while(val_2.SignValue < 1);
            
            if(((val_2.CompareTo(value:  this.q)) & 2147483648) != 0)
            {
                    return val_2;
            }
        
        }
        public RandomDsaKCalculator()
        {
        
        }
    
    }

}
