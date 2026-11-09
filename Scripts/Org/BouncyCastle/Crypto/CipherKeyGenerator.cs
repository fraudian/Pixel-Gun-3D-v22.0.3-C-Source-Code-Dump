using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class CipherKeyGenerator
    {
        // Fields
        protected internal Org.BouncyCastle.Security.SecureRandom random;
        protected internal int strength;
        private bool uninitialised;
        private int defaultStrength;
        
        // Properties
        public int DefaultStrength { get; }
        
        // Methods
        public CipherKeyGenerator()
        {
            this.uninitialised = true;
        }
        internal CipherKeyGenerator(int defaultStrength)
        {
            this.uninitialised = true;
            if(defaultStrength > 0)
            {
                    this.defaultStrength = defaultStrength;
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "strength must be a positive value", paramName:  "defaultStrength");
        }
        public int get_DefaultStrength()
        {
            return (int)this.defaultStrength;
        }
        public void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            if(parameters != null)
            {
                    this.uninitialised = false;
            }
            else
            {
                    System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "parameters");
            }
        
        }
        protected virtual void engineInit(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            if(parameters != null)
            {
                    this.random = parameters.Random;
            }
            else
            {
                    this.random = 0.Random;
            }
            
            int val_3 = parameters.Strength;
            int val_4 = val_3 + 7;
            int val_6 = (val_4 < 0) ? (val_3 + 14) : (val_4);
            val_6 = val_6 >> 3;
            this.strength = val_6;
        }
        public byte[] GenerateKey()
        {
            if(this.uninitialised != false)
            {
                    if(this.defaultStrength > 0)
            {
                    this.uninitialised = false;
                Org.BouncyCastle.Crypto.KeyGenerationParameters val_2 = new Org.BouncyCastle.Crypto.KeyGenerationParameters(random:  new Org.BouncyCastle.Security.SecureRandom(), strength:  this.defaultStrength);
            }
            else
            {
                    System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "Generator has not been initialised");
            }
            
            }
        
        }
        protected virtual byte[] engineGenerateKey()
        {
            return Org.BouncyCastle.Security.SecureRandom.GetNextBytes(secureRandom:  this.random, length:  this.strength);
        }
    
    }

}
