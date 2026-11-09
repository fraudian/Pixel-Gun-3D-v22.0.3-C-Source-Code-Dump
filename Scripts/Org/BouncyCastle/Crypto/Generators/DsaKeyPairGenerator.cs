using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class DsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
    {
        // Fields
        private static readonly Org.BouncyCastle.Math.BigInteger One;
        private Org.BouncyCastle.Crypto.Parameters.DsaKeyGenerationParameters param;
        
        // Methods
        public void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            Org.BouncyCastle.Crypto.KeyGenerationParameters val_4 = parameters;
            if(val_4 != null)
            {
                    val_4 = 0;
                this.param = val_4;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "parameters");
        }
        public Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
        {
            Org.BouncyCastle.Math.BigInteger val_10;
            Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.GeneratePrivateKey(q:  this.param.parameters.Q, random:  this.param);
            if(this.param.parameters != null)
            {
                    val_10 = this.param.parameters.P;
                return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(y:  this.param.parameters.G.ModPow(e:  val_2, m:  val_10 = 0.P), parameters:  this.param.parameters), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(x:  val_2, parameters:  this.param.parameters));
            }
            
            return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(y:  this.param.parameters.G.ModPow(e:  val_2, m:  val_10), parameters:  this.param.parameters), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(x:  val_2, parameters:  this.param.parameters));
        }
        private static Org.BouncyCastle.Math.BigInteger GeneratePrivateKey(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Security.SecureRandom random)
        {
            var val_6;
            do
            {
                val_6 = null;
                val_6 = null;
                Org.BouncyCastle.Math.BigInteger val_4 = Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(min:  Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.One, max:  q.Subtract(n:  Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.One), random:  random);
            }
            while((Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(k:  val_4)) < (q.BitLength >> 2));
            
            return val_4;
        }
        private static Org.BouncyCastle.Math.BigInteger CalculatePublicKey(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger x)
        {
            if(g != null)
            {
                    return g.ModPow(e:  x, m:  p);
            }
            
            return g.ModPow(e:  x, m:  p);
        }
        public DsaKeyPairGenerator()
        {
        
        }
        private static DsaKeyPairGenerator()
        {
            null = null;
            Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.One = Org.BouncyCastle.Math.BigInteger.One;
        }
    
    }

}
