using UnityEngine;

namespace PGCompany.BM
{
    internal class 专丁世上丒一且丘丈 : 丏丙丙丏不专丁丁丏
    {
        // Methods
        internal override bool 七丆丟丗丕丆丐丕丅(PGCompany.BM.丒万丗丏一丝丅丌世 专丌万丘且三不下丙, ref System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 专丂丕丗丗东世丞下)
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            丝丆丁丒丌丂上丑丏 val_23;
            List.Enumerator<T> val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上专丂不七业丂丈丑<PGCompany.丏丂一丗丙世丏丐三>(丁丅丈丌丟世丗丗丟:  126, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}).GetEnumerator();
            val_19 = 0;
            val_20 = 0;
            var val_18 = 0;
            label_35:
            if((107811568 & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(((val_4 & 1) == 0) || (val_4 != 专丌万丘且三不下丙._rarity))
            {
                goto label_35;
            }
            
            PGCompany.BM.丒万丗丏一丝丅丌世 val_6 = PGCompany.BM.丟丌丅丞下丏丕不丞.丑七不且上丗丁一世().三丟丌丂丐丙丅丗七();
            if(val_6 != null)
            {
                    val_6._rarity = 专丌万丘且三不下丙._rarity;
            }
            else
            {
                    mem[32] = 专丌万丘且三不下丙._rarity;
            }
            
            val_6._overrideType = 0;
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  专丌万丘且三不下丙.weight);
            val_6.weight = val_7;
            mem2[0] = val_7.上万三丆专丏丒丗业;
            val_6._forSlotType = 专丌万丘且三不下丙._forSlotType;
            val_6._currencies = System.Linq.Enumerable.ToList<PGCompany.三丌上丁一丟丐丟丈>(source:  专丌万丘且三不下丙._currencies);
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_4.业东丅东丌上丗丑不());
            val_6.丘丕丈下东一丑上丗(丙业与丙丗丝不丈东:  new PGCompany.三东丏不丗世丅丌丄());
            System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏> val_11 = new System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏>();
            val_6._reals = null;
            Dictionary.Enumerator<TKey, TValue> val_12 = 专丌万丘且三不下丙._reals.GetEnumerator();
            label_20:
            val_21 = 107811392;
            val_22 = 1152921560549281616;
            if((107811520 & 1) == 0)
            {
                goto label_14;
            }
            
            ConfiguredValueTaskAwaiter val_14 = 0.GetAwaiter();
            val_23 = val_14._value._obj.Clone();
            if(val_23 != null)
            {
                    val_23 = 0;
            }
            
            val_6._reals.Add(key:  val_14._value._obj.丙东专丂世丈丏丁丂(), value:  val_23);
            goto label_20;
            label_14:
            val_18 = val_18 + 1;
            mem2[0] = 254;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_18 != 1) && ((val_27 + ((0 + 1)) << 2) == 254))
            {
                    var val_19 = 0;
                val_19 = val_19 ^ (val_18 >> 31);
                val_18 = val_18 + val_19;
            }
            else
            {
                    if( != false)
            {
                
            }
            
            }
            
            Add(item:  val_6);
            goto label_35;
            label_3:
            val_18 = val_18 + 1;
            mem2[0] = 290;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_18 != 1)
            {
                    if( == 0)
            {
                    return true;
            }
            
                if((1152921560549233216 + ((0 + 1)) << 2) == 290)
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
        public 专丁世上丒一且丘丈()
        {
            val_1 = new System.Object();
        }
    
    }

}
