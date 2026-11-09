using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class KeyGenerationParameters
    {
        // Fields
        private Org.BouncyCastle.Security.SecureRandom random;
        private int strength;
        
        // Properties
        public Org.BouncyCastle.Security.SecureRandom Random { get; }
        public int Strength { get; }
        
        // Methods
        public KeyGenerationParameters(Org.BouncyCastle.Security.SecureRandom random, int strength)
        {
            var val_3;
            if(random == null)
            {
                goto label_1;
            }
            
            if(strength <= 0)
            {
                goto label_2;
            }
            
            this.random = random;
            this.strength = strength;
            return;
            label_1:
            System.ArgumentNullException val_1 = null;
            val_3 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  "random");
            goto label_3;
            label_2:
            System.ArgumentException val_2 = null;
            val_3 = val_2;
            val_2 = new System.ArgumentException(message:  "strength must be a positive value", paramName:  "strength");
            label_3:
        }
        public Org.BouncyCastle.Security.SecureRandom get_Random()
        {
            return (Org.BouncyCastle.Security.SecureRandom)this.random;
        }
        public int get_Strength()
        {
            return (int)this.strength;
        }
    
    }

}
