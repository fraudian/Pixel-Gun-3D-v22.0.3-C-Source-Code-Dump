using UnityEngine;

namespace Org.BouncyCastle.Crypto.Prng
{
    public class CryptoApiRandomGenerator : IRandomGenerator
    {
        // Fields
        private readonly System.Security.Cryptography.RandomNumberGenerator rndProv;
        
        // Methods
        public CryptoApiRandomGenerator()
        {
            this.rndProv = new System.Security.Cryptography.RNGCryptoServiceProvider();
        }
        public CryptoApiRandomGenerator(System.Security.Cryptography.RandomNumberGenerator rng)
        {
            this.rndProv = rng;
        }
        public virtual void AddSeedMaterial(byte[] seed)
        {
        
        }
        public virtual void AddSeedMaterial(long seed)
        {
        
        }
        public virtual void NextBytes(byte[] bytes)
        {
            if(this.rndProv == null)
            {
                
            }
        
        }
        public virtual void NextBytes(byte[] bytes, int start, int len)
        {
            int val_12;
            int val_13;
            System.Array val_14;
            var val_15;
            var val_16;
            val_12 = len;
            val_13 = start;
            val_14 = bytes;
            val_15 = this;
            if((val_13 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if((val_12 + val_13) > bytes.Length)
            {
                goto label_3;
            }
            
            if((val_13 != 0) || (bytes.Length != val_12))
            {
                goto label_5;
            }
            
            val_12 = ???;
            val_14 = ???;
            val_15 = ???;
            val_13 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Prng.CryptoApiRandomGenerator).__il2cppRuntimeField_1C8;
            label_5:
            System.Array.Copy(sourceArray:  new byte[0], sourceIndex:  0, destinationArray:  val_14, destinationIndex:  val_13, length:  val_12);
            return;
            label_1:
            System.ArgumentException val_10 = null;
            val_16 = val_10;
            val_10 = new System.ArgumentException(message:  "Start offset cannot be negative", paramName:  "start");
            goto label_6;
            label_3:
            System.ArgumentException val_11 = null;
            val_16 = val_11;
            val_11 = new System.ArgumentException(message:  "Byte array too small for requested offset and length");
            label_6:
        }
    
    }

}
