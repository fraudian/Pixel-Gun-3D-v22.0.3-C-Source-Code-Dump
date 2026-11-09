using UnityEngine;

namespace PGCompany.BattlePass
{
    public class 三东七丆丛丘丑上丒 : 丗且世丝丏丕丑丈业
    {
        // Methods
        public void 丗三丗丒丏丐且丞丗(ref string 丞丟丂丄下万丈万东, PGCompany.BattlePass.三丛上丁丗丌丆丌东 七丂丙上与丅丘丟丏, bool 丙专丂世七丂专丆丆)
        {
            string val_12;
            var val_14;
            var val_15;
            System.NotSupportedException val_17;
            var val_18;
            val_12 = 丙专丂世七丂专丆丆;
            if(七丂丙上与丅丘丟丏 == null)
            {
                    return;
            }
            
            if(七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒 == null)
            {
                    return;
            }
            
            if(七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.丘丛丆丕且丂业世丌() == 100)
            {
                    return;
            }
            
            Rilisoft.七丕丟丏三丈一丄世 val_2 = 七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.丘丛丆丕且丂业世丌();
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            if((GameConnect.丛丛丏专丏下三与七().ContainsKey(key:  ???)) == false)
            {
                goto label_12;
            }
            
            if(val_12 == false)
            {
                goto label_13;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = 0;
            goto label_20;
            label_12:
            val_17 = null;
            goto label_21;
            label_13:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = 0;
            goto label_28;
            label_20:
            string val_10 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]);
            goto label_31;
            label_28:
            label_31:
            val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]);
            label_21:
            val_12 = 丞丟丂丄下万丈万东;
            丞丟丂丄下万丈万东 = val_12.Replace(oldValue:  "{1}", newValue:  val_17);
        }
        public 三东七丆丛丘丑上丒()
        {
        
        }
    
    }

}
