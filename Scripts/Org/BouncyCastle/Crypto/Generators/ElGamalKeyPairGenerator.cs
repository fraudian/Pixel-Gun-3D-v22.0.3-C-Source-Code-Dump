using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class ElGamalKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
    {
        // Fields
        private Org.BouncyCastle.Crypto.Parameters.ElGamalKeyGenerationParameters param;
        
        // Methods
        public void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            Org.BouncyCastle.Crypto.KeyGenerationParameters val_3 = parameters;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.param = val_3;
        }
        public Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
        {
            var val_14;
            Org.BouncyCastle.Math.BigInteger val_15;
            Org.BouncyCastle.Math.BigInteger val_16;
            Org.BouncyCastle.Math.BigInteger val_17;
            val_14 = null;
            val_14 = null;
            Org.BouncyCastle.Crypto.Parameters.ElGamalParameters val_1 = this.param.Parameters;
            if(val_1 != null)
            {
                    val_15 = val_1.P;
                val_16 = val_1.G;
            }
            else
            {
                    val_15 = 0.P;
                val_16 = 0.G;
            }
            
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_7 = new Org.BouncyCastle.Crypto.Parameters.DHParameters(p:  val_15, g:  val_16, q:  0, m:  0, l:  val_1.L, j:  0, validation:  0);
            if(Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance != null)
            {
                    val_17 = 0.CalculatePrivate(dhParams:  val_7, random:  this.param);
                return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters(y:  0.CalculatePublic(dhParams:  val_7, x:  val_17 = 0.CalculatePrivate(dhParams:  val_7, random:  this.param)), parameters:  val_1), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters(x:  val_17, parameters:  val_1));
            }
            
            return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters(y:  0.CalculatePublic(dhParams:  val_7, x:  val_17), parameters:  val_1), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters(x:  val_17, parameters:  val_1));
        }
        public ElGamalKeyPairGenerator()
        {
        
        }
    
    }

}
