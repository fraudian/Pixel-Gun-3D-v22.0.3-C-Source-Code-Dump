using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class ZeroBytePadding : IBlockCipherPadding
    {
        // Properties
        public string PaddingName { get; }
        
        // Methods
        public string get_PaddingName()
        {
            return "ZeroBytePadding";
        }
        public void Init(Org.BouncyCastle.Security.SecureRandom random)
        {
        
        }
        public int AddPadding(byte[] input, int inOff)
        {
            if()
            {
                    return (int)input.Length - inOff;
            }
            
            do
            {
                var val_2 = (long)inOff;
                input[val_2] = 0;
                val_2 = val_2 + 1;
            }
            while(val_2 < input.Length);
            
            return (int)input.Length - inOff;
        }
        public int PadCount(byte[] input)
        {
            int val_4 = input.Length;
            do
            {
                if(val_4 <= 0)
            {
                    return (int)input.Length - val_4;
            }
            
                val_4 = val_4 - 1;
            }
            while((input[(long)val_4 - 1]) == 0);
            
            return (int)input.Length - val_4;
        }
        public ZeroBytePadding()
        {
        
        }
    
    }

}
