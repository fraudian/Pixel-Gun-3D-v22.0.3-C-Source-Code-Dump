using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class X923Padding : IBlockCipherPadding
    {
        // Fields
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public string PaddingName { get; }
        
        // Methods
        public void Init(Org.BouncyCastle.Security.SecureRandom random)
        {
            this.random = random;
        }
        public string get_PaddingName()
        {
            return "X9.23";
        }
        public int AddPadding(byte[] input, int inOff)
        {
            var val_5;
            int val_6;
            byte val_7;
            var val_8;
            val_5 = inOff;
            val_6 = input.Length;
            int val_1 = val_6 - val_5;
            if((val_6 - 1) <= val_5)
            {
                goto label_1;
            }
            
            label_6:
            if(this.random == null)
            {
                goto label_2;
            }
            
            val_7 = this.random;
            val_8 = (long)val_5;
            if(val_5 < input.Length)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            val_8 = (long)val_5;
            val_7 = 0;
            label_4:
            input[val_8] = val_7;
            val_6 = input.Length;
            val_5 = val_5 + 1;
            if(val_5 < (val_6 - 1))
            {
                goto label_6;
            }
            
            label_1:
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
        public X923Padding()
        {
        
        }
    
    }

}
