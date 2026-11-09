using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class MqvPublicParameters : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey;
        private readonly Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey;
        
        // Properties
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters StaticPublicKey { get; }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey { get; }
        
        // Methods
        public MqvPublicParameters(Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey, Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey)
        {
            string val_4;
            var val_5;
            if(staticPublicKey == null)
            {
                goto label_1;
            }
            
            if(ephemeralPublicKey == null)
            {
                goto label_2;
            }
            
            if((137150464 & 1) == 0)
            {
                goto label_4;
            }
            
            this.staticPublicKey = staticPublicKey;
            this.ephemeralPublicKey = ephemeralPublicKey;
            return;
            label_1:
            val_4 = "staticPublicKey";
            goto label_5;
            label_2:
            System.ArgumentNullException val_1 = null;
            val_4 = "ephemeralPublicKey";
            label_5:
            val_5 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  val_4);
            goto label_6;
            label_4:
            System.ArgumentException val_2 = null;
            val_5 = val_2;
            val_2 = new System.ArgumentException(message:  "Static and ephemeral public keys have different domain parameters");
            label_6:
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters get_StaticPublicKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.staticPublicKey;
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters get_EphemeralPublicKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.ephemeralPublicKey;
        }
    
    }

}
