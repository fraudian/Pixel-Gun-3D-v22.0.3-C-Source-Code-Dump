using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ElGamalParameters : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger p;
        private readonly Org.BouncyCastle.Math.BigInteger g;
        private readonly int l;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger G { get; }
        public int L { get; }
        
        // Methods
        public ElGamalParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g)
        {
        
        }
        public ElGamalParameters(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, int l)
        {
            string val_4;
            val_1 = new System.Object();
            if(p == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            this.p = p;
            this.g = val_1;
            this.l = l;
            return;
            label_1:
            val_4 = "p";
            goto label_3;
            label_2:
            val_4 = "g";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.p;
        }
        public Org.BouncyCastle.Math.BigInteger get_G()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.g;
        }
        public int get_L()
        {
            return (int)this.l;
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.ElGamalParameters other)
        {
            Org.BouncyCastle.Math.BigInteger val_2;
            var val_3;
            val_2 = this.p;
            if((val_2 & 1) != 0)
            {
                    val_2 = this.g;
                if((val_2 & 1) != 0)
            {
                    var val_1 = (this.l == other.l) ? 1 : 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public override int GetHashCode()
        {
            Org.BouncyCastle.Math.BigInteger val_2 = this.g;
            val_2 = val_2 ^ this.p ^ this.l;
            return (int)val_2;
        }
    
    }

}
