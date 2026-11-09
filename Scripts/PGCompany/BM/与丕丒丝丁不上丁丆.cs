using UnityEngine;

namespace PGCompany.BM
{
    internal class 与丕丒丝丁不上丁丆 : 丏丙丙丏不专丁丁丏
    {
        // Methods
        internal override bool 七丆丟丗丕丆丐丕丅(PGCompany.BM.丒万丗丏一丝丅丌世 专丌万丘且三不下丙, ref System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 专丂丕丗丗东世丞下)
        {
            var val_5;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            丝丆丁丒丌丂上丑丏 val_27;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = 丟下七丘下下丙丗丅.一三专丞丒丅上业上().Values.GetEnumerator();
            val_23 = 0;
            val_24 = 0;
            var val_22 = 0;
            label_40:
            if((108178752 & 1) == 0)
            {
                goto label_5;
            }
            
            if((W24 != 专丌万丘且三不下丙._rarity) || ((Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  X24)) == true))
            {
                goto label_40;
            }
            
            PGCompany.BM.丒万丗丏一丝丅丌世 val_9 = PGCompany.BM.丟丌丅丞下丏丕不丞.丑七不且上丗丁一世().三丟丌丂丐丙丅丗七();
            if(val_9 != null)
            {
                    val_9._rarity = 专丌万丘且三不下丙._rarity;
            }
            else
            {
                    mem[32] = 专丌万丘且三不下丙._rarity;
            }
            
            val_9._overrideType = 0;
            Rilisoft.丝丑丂丛万丐丈丘且 val_10 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  专丌万丘且三不下丙.weight);
            val_9.weight = val_10;
            mem2[0] = val_10.上万三丆专丏丒丗业;
            val_9._forSlotType = 专丌万丘且三不下丙._forSlotType;
            val_9._currencies = System.Linq.Enumerable.ToList<PGCompany.三丌上丁一丟丐丟丈>(source:  专丌万丘且三不下丙._currencies);
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_5.丐丏七丌丕丗业且上().Index);
            val_9.丘丕丈下东一丑上丗(丙业与丙丗丝不丈东:  new PGCompany.三东丏不丗世丅丌丄());
            System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏> val_14 = new System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏>();
            val_9._reals = null;
            Dictionary.Enumerator<TKey, TValue> val_15 = 专丌万丘且三不下丙._reals.GetEnumerator();
            label_25:
            val_25 = 108178608;
            val_26 = 1152921560549648816;
            if((108178704 & 1) == 0)
            {
                goto label_19;
            }
            
            ConfiguredValueTaskAwaiter val_17 = val_5.GetAwaiter();
            val_27 = val_17._value._obj.Clone();
            if(val_27 != null)
            {
                    val_27 = 0;
            }
            
            val_9._reals.Add(key:  val_17._value._obj.丙东专丂世丈丏丁丂(), value:  val_27);
            goto label_25;
            label_19:
            val_22 = val_22 + 1;
            mem2[0] = 261;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_22 != 1) && ((val_30 + ((0 + 1)) << 2) == 261))
            {
                    var val_23 = 0;
                val_23 = val_23 ^ (val_22 >> 31);
                val_22 = val_22 + val_23;
            }
            else
            {
                    if( != false)
            {
                
            }
            
            }
            
            Add(item:  val_9);
            goto label_40;
            label_5:
            val_22 = val_22 + 1;
            mem2[0] = 297;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_22 != 1)
            {
                    if( == 0)
            {
                    return true;
            }
            
                if((1152921560549600432 + ((0 + 1)) << 2) == 297)
            {
                    return true;
            }
            
                return true;
            }
            
            if( != 0)
            {
                    return true;
            }
            
            return true;
        }
        public 与丕丒丝丁不上丁丆()
        {
            val_1 = new System.Object();
        }
    
    }

}
