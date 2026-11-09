using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class DHKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
    {
        // Fields
        private Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters param;
        
        // Methods
        public virtual void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            Org.BouncyCastle.Crypto.KeyGenerationParameters val_3 = parameters;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.param = val_3;
        }
        public virtual Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
        {
            var val_7;
            Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters val_8;
            Org.BouncyCastle.Math.BigInteger val_9;
            val_7 = null;
            val_7 = null;
            val_8 = this.param;
            if(this.param != null)
            {
                goto label_3;
            }
            
            val_8 = this.param;
            if(val_8 == null)
            {
                goto label_4;
            }
            
            label_3:
            if(Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance != null)
            {
                    val_9 = 0.CalculatePrivate(dhParams:  this.param.parameters, random:  this.param);
            }
            else
            {
                    val_9 = 0.CalculatePrivate(dhParams:  this.param.parameters, random:  this.param);
            }
            
            .x = val_9;
            return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  0.CalculatePublic(dhParams:  this.param.parameters, x:  val_9), parameters:  this.param.parameters), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters(isPrivate:  true, parameters:  this.param.parameters));
            label_4:
        }
        public DHKeyPairGenerator()
        {
        
        }
    
    }

}
