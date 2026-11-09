using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class ISO10126d2Padding : IBlockCipherPadding
    {
        // Fields
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public string PaddingName { get; }
        
        // Methods
        public void Init(Org.BouncyCastle.Security.SecureRandom random)
        {
            if(random == null)
            {
                goto label_1;
            }
            
            label_5:
            this.random = random;
            return;
            label_1:
            Org.BouncyCastle.Security.SecureRandom val_1 = new Org.BouncyCastle.Security.SecureRandom();
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        public string get_PaddingName()
        {
            return "ISO10126-2";
        }
        public int AddPadding(byte[] input, int inOff)
        {
            var val_5;
            int val_6;
            val_5 = inOff;
            val_6 = input.Length;
            int val_1 = val_6 - val_5;
            if((val_6 - 1) > val_5)
            {
                    do
            {
                input[(long)val_5] = this.random;
                val_6 = input.Length;
                val_5 = val_5 + 1;
            }
            while(val_5 < (val_6 - 1));
            
            }
            
            input[(long)val_5] = val_1;
            return (int)val_1 & 255;
        }
        public int PadCount(byte[] input)
        {
            int val_3 = input.Length;
            var val_3 = -4294967296;
            val_3 = val_3 + ((input.Length) << 32);
            if(val_3 == 0)
            {
                    val_3 = input.Length;
            }
            
            byte val_4 = input[val_3 >> 32];
            if(val_4 <= val_3)
            {
                    return (int)val_4;
            }
            
            Org.BouncyCastle.Crypto.InvalidCipherTextException val_2 = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  "pad block corrupted");
        }
        public ISO10126d2Padding()
        {
        
        }
    
    }

}
