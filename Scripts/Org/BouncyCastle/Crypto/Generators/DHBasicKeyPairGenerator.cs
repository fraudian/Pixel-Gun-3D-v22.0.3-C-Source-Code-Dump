using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class DHBasicKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
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
            var val_9;
            Org.BouncyCastle.Math.BigInteger val_10;
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_1 = this.param.Parameters;
            Org.BouncyCastle.Security.SecureRandom val_2 = this.param.Random;
            if(Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance != null)
            {
                    val_10 = Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance.CalculatePrivate(dhParams:  val_1, random:  val_2);
                return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance.CalculatePublic(dhParams:  val_1, x:  val_10 = 0.CalculatePrivate(dhParams:  val_1, random:  val_2)), parameters:  val_1), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters(x:  val_10, parameters:  val_1));
            }
            
            return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance.CalculatePublic(dhParams:  val_1, x:  val_10), parameters:  val_1), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters(x:  val_10, parameters:  val_1));
        }
        public DHBasicKeyPairGenerator()
        {
        
        }
    
    }

}
