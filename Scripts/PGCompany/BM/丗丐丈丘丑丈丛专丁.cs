using UnityEngine;

namespace PGCompany.BM
{
    internal class 丗丐丈丘丑丈丛专丁 : 丄不丙万与丙东世丕
    {
        // Methods
        internal override bool 丈丗丒不下丙东东三(PGCompany.BM.丘丆丆丁丝且不丄东 丙丑丆上不丒上丕丛, System.Collections.Generic.List<int> 万专东业世且丏七三)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.List<System.Int32> val_33;
            PGCompany.BM.丘丆丆丁丝且不丄东 val_34;
            var val_35;
            var val_36;
            var val_38;
            val_33 = 万专东业世且丏七三;
            val_34 = 丙丑丆上不丒上丕丛;
            if((((95942.丈丗丒不下丙东东三(丙丑丆上不丒上丕丛:  val_34, 万专东业世且丏七三:  val_33)) == false) || ((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).不业丙丒丂丞下丆丙()) != 1150)) || ((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).业东丅东丌上丗丑不()) < 1))
            {
                goto label_53;
            }
            
            PGCompany.丏丂一丗丙世丏丐三 val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丏丂一丗丙世丏丐三>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex));
            if(val_8 == null)
            {
                    return (bool)val_35;
            }
            
            val_36 = val_8.丆丒丕下丝丂三丘丑() - val_8.且丆丟业丞丕丑上且();
            if(val_36 < 1)
            {
                goto label_53;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_11 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            Dictionary.Enumerator<TKey, TValue> val_12 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.GetEnumerator();
            val_38 = 1152921560543769024;
            label_26:
            label_25:
            if((105219984 & 1) == 0)
            {
                goto label_17;
            }
            
            ConfiguredValueTaskAwaiter val_16 = val_15.GetAwaiter();
            if((val_33.Contains(item:  val_16._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_19;
            }
            
            var val_19 = (val_14 < val_36) ? 1 : 0;
            val_19 = val_19 | 1;
            if((val_19 & 1) != 0)
            {
                goto label_21;
            }
            
            val_11.Add(item:  val_16._value._obj.丙东专丂世丈丏丁丂());
            goto label_25;
            label_19:
            val_11.Add(item:  val_16._value._obj.丙东专丂世丈丏丁丂());
            goto label_25;
            label_21:
            var val_31 = 0;
            val_31 = val_31 | ((val_14 >= val_36) ? 1 : 0);
            goto label_26;
            label_17:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.Linq.Enumerable.Any<System.Int32>(source:  val_11)) == false)
            {
                goto label_47;
            }
            
            List.Enumerator<T> val_24 = val_11.GetEnumerator();
            val_38 = 1152921525710254080;
            val_36 = 1152921560543771072;
            label_42:
            if((105219936 & 1) == 0)
            {
                goto label_39;
            }
            
            bool val_26 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Remove(key:  val_15.丙东专丂世丈丏丁丂());
            goto label_42;
            label_39:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_47:
            val_33 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Count) >= 1)
            {
                    val_34 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField;
                var val_30 = (val_34.Count > 0) ? 1 : 0;
                return (bool)val_35;
            }
            
            label_53:
            val_35 = 0;
            return (bool)val_35;
        }
        public 丗丐丈丘丑丈丛专丁()
        {
            val_1 = new System.Object();
        }
    
    }

}
