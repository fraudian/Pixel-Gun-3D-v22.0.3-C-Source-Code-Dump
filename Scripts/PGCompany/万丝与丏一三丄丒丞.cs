using UnityEngine;

namespace PGCompany
{
    internal class 万丝与丏一三丄丒丞 : IComparer<丏不一丏丗丗丗丈丞>
    {
        // Methods
        public int Compare(丏不一丏丗丗丗丈丞 万丏丄丅下丄上业丑, 丏不一丏丗丗丗丈丞 丐专丕丟丌且丌丏丁)
        {
            var val_16;
            var val_17;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if((万丏丄丅下丄上业丑.七下业丈业丙丆上丌() == false) || (万丏丄丅下丄上业丑.三丐丑丛业丅东丕东() == false))
            {
                goto label_3;
            }
            
            val_16 = (~万丏丄丅下丄上业丑.东业东丆丂丝万丑下()) & 1;
            if(丐专丕丟丌且丌丏丁 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_3:
            val_16 = 0;
            if(丐专丕丟丌且丌丏丁 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            if((丐专丕丟丌且丌丏丁.七下业丈业丙丆上丌() != false) && (丐专丕丟丌且丌丏丁.三丐丑丛业丅东丕东() != false))
            {
                    val_17 = (~丐专丕丟丌且丌丏丁.东业东丆丂丝万丑下()) & 1;
            }
            else
            {
                    val_17 = 0;
            }
            
            val_16 = (val_16 > val_17) ? 0 : ((val_16 < val_17) ? 1000000 : 0);
            var val_8 = (val_16 > val_17) ? 1000000 : 0;
            if(万丏丄丅下丄上业丑.七下业丈业丙丆上丌() == false)
            {
                goto label_14;
            }
            
            bool val_14 = 万丏丄丅下丄上业丑.isReaded;
            val_14 = val_14 ^ 1;
            val_20 = val_14 & 255;
            if(丐专丕丟丌且丌丏丁 != null)
            {
                goto label_18;
            }
            
            goto label_17;
            label_14:
            val_20 = 0;
            if(丐专丕丟丌且丌丏丁 != null)
            {
                goto label_18;
            }
            
            label_17:
            label_18:
            if(丐专丕丟丌且丌丏丁.七下业丈业丙丆上丌() != false)
            {
                    bool val_15 = 丐专丕丟丌且丌丏丁.isReaded;
                val_15 = val_15 ^ 1;
                val_21 = val_15 & 255;
            }
            else
            {
                    val_21 = 0;
            }
            
            if(val_20 <= val_21)
            {
                goto label_22;
            }
            
            val_19 = val_8 + 100000;
            if(万丏丄丅下丄上业丑 != null)
            {
                goto label_25;
            }
            
            goto label_24;
            label_22:
            val_16 = (val_20 < val_21) ? (val_16 + 100000) : (val_16);
            if(万丏丄丅下丄上业丑 != null)
            {
                goto label_25;
            }
            
            label_24:
            label_25:
            if(万丏丄丅下丄上业丑.Date > 丐专丕丟丌且丌丏丁.Date)
            {
                    val_19 = val_8 + 10000;
            }
            else
            {
                    val_16 = (万丏丄丅下丄上业丑.Date < 丐专丕丟丌且丌丏丁.Date) ? (val_16 + 10000) : (val_16);
            }
            
            if(val_8 <= val_16)
            {
                    return (int)(val_8 < val_16) ? 1 : 0;
            }
            
            val_22 = 0;
            return (int)(val_8 < val_16) ? 1 : 0;
        }
        public 万丝与丏一三丄丒丞()
        {
        
        }
    
    }

}
