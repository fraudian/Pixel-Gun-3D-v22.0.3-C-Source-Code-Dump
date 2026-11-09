using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class Pkcs7Padding : IBlockCipherPadding
    {
        // Properties
        public string PaddingName { get; }
        
        // Methods
        public void Init(Org.BouncyCastle.Security.SecureRandom random)
        {
        
        }
        public string get_PaddingName()
        {
            return "PKCS7";
        }
        public int AddPadding(byte[] input, int inOff)
        {
            int val_3 = inOff;
            int val_1 = input.Length - val_3;
            if()
            {
                    return (int)val_1 & 255;
            }
            
            do
            {
                input[(long)val_3] = val_1;
                val_3 = (long)val_3 + 1;
            }
            while(val_3 < input.Length);
            
            return (int)val_1 & 255;
        }
        public int PadCount(byte[] input)
        {
            int val_3;
            var val_4;
            var val_5;
            var val_3 = -4294967296;
            val_3 = val_3 + ((input.Length) << 32);
            byte val_4 = input[val_3 >> 32];
            if(val_4 == 0)
            {
                goto label_8;
            }
            
            val_3 = input.Length;
            if(val_4 > val_3)
            {
                goto label_8;
            }
            
            if(val_4 < 2)
            {
                    return (int)val_4;
            }
            
            val_4 = 2;
            val_5 = -2;
            goto label_6;
            label_9:
            val_3 = input.Length;
            val_4 = 3;
            val_5 = -3;
            label_6:
            val_3 = val_5 + val_3;
            if(input[(long)val_3] != val_4)
            {
                goto label_8;
            }
            
            if(val_4 < val_4)
            {
                goto label_9;
            }
            
            return (int)val_4;
            label_8:
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_2 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "pad block corrupted");
        }
        public Pkcs7Padding()
        {
        
        }
    
    }

}
