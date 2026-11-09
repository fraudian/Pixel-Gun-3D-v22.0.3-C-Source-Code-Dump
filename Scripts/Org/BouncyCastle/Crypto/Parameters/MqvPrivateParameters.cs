using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class MqvPrivateParameters : ICipherParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey;
        private readonly Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey;
        private readonly Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey;
        
        // Properties
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters StaticPrivateKey { get; }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters EphemeralPrivateKey { get; }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey { get; }
        
        // Methods
        public MqvPrivateParameters(Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey, Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey)
        {
        
        }
        public MqvPrivateParameters(Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey, Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey, Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey)
        {
            Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_4;
            string val_6;
            string val_8;
            var val_9;
            val_4 = ephemeralPublicKey;
            if(staticPrivateKey == null)
            {
                goto label_1;
            }
            
            if(ephemeralPrivateKey == null)
            {
                goto label_2;
            }
            
            if((137150464 & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_4 == null)
            {
                goto label_5;
            }
            
            if((137150464 & 1) != 0)
            {
                goto label_6;
            }
            
            val_6 = "Ephemeral public key has different domain parameters";
            goto label_7;
            label_5:
            Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters val_1 = null;
            val_4 = val_1;
            val_1 = new Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(q:  mem[137150496], parameters:  137150464);
            label_6:
            this.staticPrivateKey = staticPrivateKey;
            this.ephemeralPrivateKey = ephemeralPrivateKey;
            this.ephemeralPublicKey = val_4;
            return;
            label_1:
            val_8 = "staticPrivateKey";
            goto label_9;
            label_2:
            System.ArgumentNullException val_2 = null;
            val_8 = "ephemeralPrivateKey";
            label_9:
            val_9 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  val_8);
            goto label_10;
            label_4:
            System.ArgumentException val_3 = null;
            val_6 = "Static and ephemeral private keys have different domain parameters";
            label_7:
            val_9 = val_3;
            val_3 = new System.ArgumentException(message:  val_6);
            label_10:
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters get_StaticPrivateKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.staticPrivateKey;
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters get_EphemeralPrivateKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.ephemeralPrivateKey;
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters get_EphemeralPublicKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.ephemeralPublicKey;
        }
    
    }

}
