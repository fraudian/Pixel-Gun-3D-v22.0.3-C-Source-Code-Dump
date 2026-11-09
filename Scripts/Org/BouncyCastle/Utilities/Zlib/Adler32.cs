using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    internal sealed class Adler32
    {
        // Fields
        private const int BASE = 65521;
        private const int NMAX = 5552;
        
        // Methods
        internal long adler32(long adler, byte[] buf, int index, int len)
        {
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            int val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            val_35 = len;
            if(buf == null)
            {
                goto label_0;
            }
            
            val_36 = adler & 65535;
            val_37 = (ulong)(adler >> 16) & 65535;
            if(val_35 < 1)
            {
                goto label_1;
            }
            
            label_24:
            var val_1 = (val_35 < 5552) ? (val_35) : 5552;
            if(val_1 >= 16)
            {
                goto label_2;
            }
            
            val_38 = index;
            goto label_3;
            label_2:
            var val_3 = ((~val_35) <= 5552) ? 5552 : (!val_35);
            val_3 = (-17) - val_3;
            val_3 = val_3 & 4294967280;
            val_3 = index + val_3;
            val_39 = val_3 + 16;
            do
            {
                val_40 = buf.Length;
                int val_4 = index + 1;
                var val_41 = (long)index;
                if(index >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                var val_5 = val_41 + 1;
                long val_7 = val_36 + buf[val_41];
                val_37 = val_7 + val_37;
                if(val_5 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_5 = val_5 + 1;
                val_4 = val_7 + buf[(long)val_4];
                val_37 = val_37 + val_4;
                if(val_5 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                var val_9 = val_5 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 2]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 3]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 4]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 5]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 6]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 7]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 8]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 9]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 10]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_9 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 11]);
                val_37 = val_37 + val_4;
                if(val_9 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_41 = val_9 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 12]);
                val_37 = val_37 + val_4;
                if(val_41 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_41 = val_41 + 1;
                val_4 = val_4 + (buf[(long)val_41 + 13]);
                val_37 = val_37 + val_4;
                if(val_41 >= val_40)
            {
                    val_40 = buf.Length;
            }
            
                val_42 = val_4 + (buf[(long)val_41 + 14]);
                val_37 = val_37 + val_42;
                val_1 = val_1 - 16;
                index = (val_41 + 1) + 1;
                val_43 = val_42 + (buf[(long)val_41 + 15]);
                val_44 = val_37;
            }
            while(val_1 > 15);
            
            val_35 = val_3 - val_3;
            if(val_35 == 0)
            {
                goto label_21;
            }
            
            label_3:
            var val_45 = val_35;
            do
            {
                val_42 = val_39 + 1;
                val_41 = (long)val_39;
                byte val_44 = buf[val_41];
                val_45 = val_45 - 1;
                val_45 = val_43;
                val_46 = val_45;
            }
            while(val_45 != 0);
            
            val_47 = val_35 + val_39;
            label_21:
            int val_23 = val_42;
            long val_24 = (-9221260491235007769) + val_46;
            val_23 = (val_23 >> 15) + (val_23 >> 63);
            val_24 = (val_24 >> 15) + (val_24 >> 63);
            val_48 = val_23;
            val_49 = val_46 - (val_24 * 65521);
            if((val_35 - val_1) > 0)
            {
                goto label_24;
            }
            
            label_1:
            val_50 = val_48 | (((((((((((((((((((((adler & 65535) + buf[(long)(int)(index)][0]) + buf[(long)(int)((index + 1))][0]) + buf[(long)(int)(((long)(int)(index) + 2))][0]) + buf[(long)(int)(((long)(int)(index) + 3))][0]) +  - ((((-9221260491235007769 + (((((((((((((((((((adler & 65535) + buf[(long)(int)(index)][0]) + buf[(long)(int)((index + 1))][0]) + buf[(long)(int)(((long)(int)(index) + 2))][0]) + buf[(long)(int)(((long) * 65521)) << 16);
            return (long)val_50;
            label_0:
            val_50 = 1;
            return (long)val_50;
        }
        public Adler32()
        {
        
        }
    
    }

}
