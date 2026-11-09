using UnityEngine;

namespace Org.BouncyCastle.Crypto.Agreement
{
    public class ECDHBasicAgreement : IBasicAgreement
    {
        // Fields
        protected internal Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey;
        
        // Methods
        public virtual void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_4 = parameters;
            if(val_4 != null)
            {
                    val_4 = val_4.Parameters;
                if(val_4 != null)
            {
                    val_4 = 0;
            }
            
            }
            
            this.privKey = val_4;
        }
        public virtual int GetFieldSize()
        {
            var val_6 = this.privKey.Parameters.Curve;
            Org.BouncyCastle.Math.EC.ECCurve val_3 = val_6 + 7;
            val_6 = ((val_3 < 0) ? (val_6 + 14) : (val_3)) >> 3;
            return (int)val_6;
        }
        public virtual Org.BouncyCastle.Math.BigInteger CalculateAgreement(Org.BouncyCastle.Crypto.ICipherParameters pubKey)
        {
            var val_11;
            string val_13;
            val_11 = pubKey;
            val_11 = 0;
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_3 = val_11.Parameters;
            Org.BouncyCastle.Crypto.Parameters.ECDomainParameters val_4 = this.privKey.Parameters;
            if((val_3 & 1) == 0)
            {
                goto label_6;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_6 = (val_3 != 1) ? (val_11) : 0.Q;
            Org.BouncyCastle.Math.BigInteger val_7 = this.privKey.D;
            bool val_8 = val_6.IsInfinity;
            var val_9 = (val_8 != true) ? 0 : (val_6);
            if(val_8 == true)
            {
                goto label_12;
            }
            
            if(val_9 != 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_9;
            }
            
            return (Org.BouncyCastle.Math.BigInteger)val_9;
            label_6:
            val_13 = "ECDH public key has wrong domain parameters";
            goto label_15;
            label_12:
            val_13 = "Infinity is not a valid agreement value for ECDH";
            label_15:
            null = new System.InvalidOperationException(message:  val_13);
        }
        public ECDHBasicAgreement()
        {
        
        }
    
    }

}
