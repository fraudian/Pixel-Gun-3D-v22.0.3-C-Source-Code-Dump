using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class Poly1305KeyGenerator : CipherKeyGenerator
    {
        // Fields
        private const byte R_MASK_LOW_2 = 252;
        private const byte R_MASK_HIGH_4 = 15;
        
        // Methods
        protected override void engineInit(Org.BouncyCastle.Crypto.KeyGenerationParameters param)
        {
            mem[1152921551466755640] = 32;
            mem[1152921551466755632] = param.random;
        }
        protected override byte[] engineGenerateKey()
        {
            System.Byte[] val_1 = this.engineGenerateKey();
            Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.Clamp(key:  val_1);
            return val_1;
        }
        public static void Clamp(byte[] key)
        {
            if(key.Length == 32)
            {
                    byte val_3 = key[0];
                byte val_4 = key[0];
                byte val_5 = key[1];
                val_3 = val_3 & 15;
                key[0] = val_3;
                byte val_6 = key[1];
                val_4 = val_4 & 15;
                key[0] = val_4;
                byte val_7 = key[0];
                val_5 = val_5 & 15;
                val_6 = val_6 & 15;
                key[1] = val_5;
                key[1] = val_6;
                byte val_9 = key[1];
                val_7 = val_7 & 252;
                key[0] = val_7;
                val_9 = val_9 & 252;
                key[1] = key[1] & 252;
                key[1] = val_9;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Poly1305 key must be 256 bits.");
        }
        public static void CheckKey(byte[] key)
        {
            if(key.Length == 32)
            {
                    Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[0], mask:  15);
                Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[0], mask:  15);
                Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[1], mask:  15);
                Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[1], mask:  15);
                Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[0], mask:  252);
                Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[1], mask:  252);
                Org.BouncyCastle.Crypto.Generators.Poly1305KeyGenerator.CheckMask(b:  key[1], mask:  252);
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "Poly1305 key must be 256 bits.");
        }
        private static void CheckMask(byte b, byte mask)
        {
            byte val_1 = b & (~mask);
            val_1 = val_1 & 255;
            if(val_1 == 0)
            {
                    return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Invalid format for r portion of Poly1305 key.");
        }
        public Poly1305KeyGenerator()
        {
        
        }
    
    }

}
