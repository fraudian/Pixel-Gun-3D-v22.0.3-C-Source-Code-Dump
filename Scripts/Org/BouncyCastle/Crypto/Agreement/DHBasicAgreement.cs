using UnityEngine;

namespace Org.BouncyCastle.Crypto.Agreement
{
    public class DHBasicAgreement : IBasicAgreement
    {
        // Fields
        private Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters key;
        private Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams;
        
        // Methods
        public virtual void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_5 = parameters;
            if(val_5 != null)
            {
                    val_5 = val_5.Parameters;
                if(val_5 != null)
            {
                    this.key = val_5;
                this.dhParams = val_5.Parameters;
                return;
            }
            
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "DHEngine expects DHPrivateKeyParameters");
        }
        public virtual int GetFieldSize()
        {
            int val_3 = this.key.Parameters.P.BitLength;
            int val_4 = val_3 + 7;
            val_3 = ((val_4 < 0) ? (val_3 + 14) : (val_4)) >> 3;
            return (int)val_3;
        }
        public virtual Org.BouncyCastle.Math.BigInteger CalculateAgreement(Org.BouncyCastle.Crypto.ICipherParameters pubKey)
        {
            var val_11;
            var val_12;
            val_11 = pubKey;
            if(this.key == null)
            {
                goto label_1;
            }
            
            val_11 = 0;
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_3 = val_11.Parameters;
            if((val_3 & 1) == 0)
            {
                goto label_6;
            }
            
            return (Org.BouncyCastle.Math.BigInteger)(val_3 != 1) ? (val_11) : 0.Y.ModPow(e:  this.key.X, m:  this.dhParams.P);
            label_1:
            System.InvalidOperationException val_9 = null;
            val_12 = val_9;
            val_9 = new System.InvalidOperationException(message:  "Agreement algorithm not initialised");
            goto label_12;
            label_6:
            System.ArgumentException val_10 = null;
            val_12 = val_10;
            val_10 = new System.ArgumentException(message:  "Diffie-Hellman public key has wrong parameters.");
            label_12:
        }
        public DHBasicAgreement()
        {
        
        }
    
    }

}
