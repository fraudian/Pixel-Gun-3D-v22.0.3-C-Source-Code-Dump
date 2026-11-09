using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class TbcPadding : IBlockCipherPadding
    {
        // Properties
        public string PaddingName { get; }
        
        // Methods
        public string get_PaddingName()
        {
            return "TBC";
        }
        public virtual void Init(Org.BouncyCastle.Security.SecureRandom random)
        {
        
        }
        public virtual int AddPadding(byte[] input, int inOff)
        {
            var val_4;
            var val_5;
            int val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = inOff;
            if(input == null)
            {
                goto label_0;
            }
            
            val_5 = input;
            val_6 = input.Length;
            val_7 = val_6 - val_4;
            if(val_4 >= 1)
            {
                goto label_1;
            }
            
            goto label_2;
            label_0:
            val_7 = 28563616 - val_4;
            if(val_4 < 1)
            {
                goto label_3;
            }
            
            val_5 = 24;
            val_8 = 28563616;
            label_1:
            int val_1 = val_4 - 1;
            byte val_4 = (long)val_1;
            if(val_1 < 28563616)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            if(val_5 <= val_4)
            {
                    return (int)val_7;
            }
            
            byte val_3 = input[val_4];
            val_3 = val_3 & 1;
            val_4 = val_3 - 1;
            do
            {
                input[(long)val_4] = val_4;
                val_4 = (long)val_4 + 1;
            }
            while(val_4 < 28563616);
            
            return (int)val_7;
            label_3:
            val_9 = 28563616;
            label_2:
            var val_5 = -4294967296;
            val_5 = val_5 + 122679796575502336;
            var val_2 = val_5 >> 32;
            if(val_9 != 0)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        public virtual int PadCount(byte[] input)
        {
            int val_4 = input.Length;
            var val_4 = -4294967296;
            val_4 = val_4 + ((input.Length) << 32);
            if(val_4 == 0)
            {
                    val_4 = input.Length;
            }
            
            int val_2 = val_4 - 1;
            do
            {
                val_2 = val_2 - 1;
                if()
            {
                    return (int)input.Length - val_2;
            }
            
            }
            while(input[(long)val_2] == (input[val_4 >> 32]));
            
            return (int)input.Length - val_2;
        }
        public TbcPadding()
        {
        
        }
    
    }

}
