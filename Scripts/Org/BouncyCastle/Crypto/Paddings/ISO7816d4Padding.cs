using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class ISO7816d4Padding : IBlockCipherPadding
    {
        // Properties
        public string PaddingName { get; }
        
        // Methods
        public void Init(Org.BouncyCastle.Security.SecureRandom random)
        {
        
        }
        public string get_PaddingName()
        {
            return "ISO7816-4";
        }
        public int AddPadding(byte[] input, int inOff)
        {
            var val_1;
            var val_2;
            int val_3;
            var val_4;
            val_1 = inOff;
            if(input != null)
            {
                    val_2 = input;
                val_3 = input.Length;
                val_4 = val_3;
            }
            else
            {
                    val_2 = 24;
                val_4 = 28563616;
                val_3 = 28563616;
            }
            
            val_4 = val_4 - val_1;
            input[(long)val_1] = 128;
            goto label_3;
            label_5:
            val_1 = 128;
            input[val_1] = 0;
            label_3:
            if((val_1 + 1) < val_2)
            {
                goto label_5;
            }
            
            return (int)val_4;
        }
        public int PadCount(byte[] input)
        {
            int val_4 = input.Length;
            val_4 = val_4 - 1;
            label_4:
            if(val_4 < 1)
            {
                goto label_2;
            }
            
            var val_1 = (long)val_4 - 1;
            if(input[(long)val_4] == 0)
            {
                goto label_4;
            }
            
            label_2:
            if(input[(long)val_4] == 128)
            {
                    return (int)input.Length - (long)val_4;
            }
            
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_3 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "pad block corrupted");
        }
        public ISO7816d4Padding()
        {
        
        }
    
    }

}
