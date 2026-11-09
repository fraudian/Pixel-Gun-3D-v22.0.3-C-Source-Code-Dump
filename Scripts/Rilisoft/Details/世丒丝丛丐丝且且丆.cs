using UnityEngine;

namespace Rilisoft.Details
{
    internal sealed class 世丒丝丛丐丝且且丆 : IEqualityComparer<byte[]>
    {
        // Methods
        public bool Equals(byte[] 三丟东丕丄丄下下丑, byte[] 丒丒丄丁且丄丆丂丌)
        {
            var val_3;
            var val_2 = ((三丟东丕丄丄下下丑 | 丒丒丄丁且丄丆丂丌) == null) ? 1 : 0;
            if(三丟东丕丄丄下下丑 == null)
            {
                    return (bool)val_3;
            }
            
            if(丒丒丄丁且丄丆丂丌 == null)
            {
                    return (bool)val_3;
            }
            
            if(三丟东丕丄丄下下丑.Length != 丒丒丄丁且丄丆丂丌.Length)
            {
                goto label_6;
            }
            
            if(三丟东丕丄丄下下丑.Length == 0)
            {
                goto label_3;
            }
            
            label_7:
            if(三丟东丕丄丄下下丑[0] != 丒丒丄丁且丄丆丂丌[0])
            {
                goto label_6;
            }
            
            if((0 + 1) != 三丟东丕丄丄下下丑.Length)
            {
                goto label_7;
            }
            
            label_3:
            val_3 = 1;
            return (bool)val_3;
            label_6:
            val_3 = 0;
            return (bool)val_3;
        }
        public int GetHashCode(byte[] 万且万且丑丗且丌丆)
        {
            int val_4;
            var val_5;
            if(万且万且丑丗且丌丆 != null)
            {
                    val_4 = 万且万且丑丗且丌丆.Length;
                if(val_4 != 0)
            {
                    do
            {
                var val_1 = (0 < 0) ? 3 : 0;
                val_1 = val_1 & 4294967292;
                if(0 >= val_4)
            {
                    val_4 = 万且万且丑丗且丌丆.Length;
            }
            
                byte val_5 = 万且万且丑丗且丌丆[0];
                val_5 = val_5 << ((0 - val_1) & 31);
                val_5 = val_5 ^ 0;
            }
            while((0 + 1) != val_4);
            
                return (int)val_5;
            }
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public 世丒丝丛丐丝且且丆()
        {
        
        }
    
    }

}
