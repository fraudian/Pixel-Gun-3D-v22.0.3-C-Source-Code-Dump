using UnityEngine;

namespace PGCompany
{
    internal class 丄丈专上丛专丂一与 : IComparer<丗不专世丑七万丞与>
    {
        // Methods
        public int Compare(丗不专世丑七万丞与 三丟东丕丄丄下下丑, 丗不专世丑七万丞与 丒丒丄丁且丄丆丂丌)
        {
            var val_18;
            var val_19;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            丏不一丏丗丗丗丈丞 val_1 = 三丟东丕丄丄下下丑.丐东专丁三丙丟丆丅();
            丏不一丏丗丗丗丈丞 val_2 = 丒丒丄丁且丄丆丂丌.丐东专丁三丙丟丆丅();
            if((val_1.七下业丈业丙丆上丌() == false) || (val_1.三丐丑丛业丅东丕东() == false))
            {
                goto label_5;
            }
            
            val_18 = (~val_1.东业东丆丂丝万丑下()) & 1;
            if(val_2 != null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_5:
            val_18 = 0;
            if(val_2 != null)
            {
                goto label_9;
            }
            
            label_8:
            label_9:
            if((val_2.七下业丈业丙丆上丌() != false) && (val_2.三丐丑丛业丅东丕东() != false))
            {
                    val_19 = (~val_2.东业东丆丂丝万丑下()) & 1;
            }
            else
            {
                    val_19 = 0;
            }
            
            val_18 = (val_18 > val_19) ? 0 : ((val_18 < val_19) ? 1000000 : 0);
            var val_10 = (val_18 > val_19) ? 1000000 : 0;
            if(val_1.七下业丈业丙丆上丌() == false)
            {
                goto label_16;
            }
            
            bool val_16 = val_1.isReaded;
            val_16 = val_16 ^ 1;
            val_22 = val_16 & 255;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_19;
            label_16:
            val_22 = 0;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            label_19:
            label_20:
            if(val_2.七下业丈业丙丆上丌() != false)
            {
                    bool val_17 = val_2.isReaded;
                val_17 = val_17 ^ 1;
                val_23 = val_17 & 255;
            }
            else
            {
                    val_23 = 0;
            }
            
            if(val_22 <= val_23)
            {
                goto label_24;
            }
            
            val_21 = val_10 + 100000;
            if(val_1 != null)
            {
                goto label_27;
            }
            
            goto label_26;
            label_24:
            val_18 = (val_22 < val_23) ? (val_18 + 100000) : (val_18);
            if(val_1 != null)
            {
                goto label_27;
            }
            
            label_26:
            label_27:
            if(val_1.Date > val_2.Date)
            {
                    val_21 = val_10 + 10000;
            }
            else
            {
                    val_18 = (val_1.Date < val_2.Date) ? (val_18 + 10000) : (val_18);
            }
            
            if(val_10 <= val_18)
            {
                    return (int)(val_10 < val_18) ? 1 : 0;
            }
            
            val_24 = 0;
            return (int)(val_10 < val_18) ? 1 : 0;
        }
        public 丄丈专上丛专丂一与()
        {
        
        }
    
    }

}
