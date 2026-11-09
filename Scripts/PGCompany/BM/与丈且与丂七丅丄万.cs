using UnityEngine;

namespace PGCompany.BM
{
    internal class 与丈且与丂七丅丄万 : 丄不丙万与丙东世丕
    {
        // Methods
        internal override bool 丈丗丒不下丙东东三(PGCompany.BM.丘丆丆丁丝且不丄东 丙丑丆上不丒上丕丛, System.Collections.Generic.List<int> 万专东业世且丏七三)
        {
            var val_13;
            var val_14;
            System.Collections.Generic.List<System.Int32> val_31;
            PGCompany.BM.丘丆丆丁丝且不丄东 val_32;
            System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏> val_34;
            var val_35;
            var val_36;
            val_31 = 万专东业世且丏七三;
            val_32 = 丙丑丆上不丒上丕丛;
            if((((90629.丈丗丒不下丙东东三(丙丑丆上不丒上丕丛:  val_32, 万专东业世且丏七三:  val_31)) == false) || ((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).不业丙丒丂丞下丆丙()) != 80)) || ((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).业东丅东丌上丗丑不()) < 1))
            {
                goto label_52;
            }
            
            int val_9 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丝丑专不丝丌下丘丄(世丐丗专丅三丝丑丆:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).业上丙丞丐丄丆丅七());
            PGCompany.东丑丒丗一丞下丙丙<T> val_10 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            val_34 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField;
            Dictionary.Enumerator<TKey, TValue> val_11 = val_34.GetEnumerator();
            val_35 = 1152921525750875424;
            label_25:
            label_24:
            if((105921936 & 1) == 0)
            {
                goto label_16;
            }
            
            ConfiguredValueTaskAwaiter val_15 = val_14.GetAwaiter();
            if((val_31.Contains(item:  val_15._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_18;
            }
            
            var val_18 = (val_13 < val_9) ? 1 : 0;
            val_18 = val_18 | 1;
            if((val_18 & 1) != 0)
            {
                goto label_20;
            }
            
            val_10.Add(item:  val_15._value._obj.丙东专丂世丈丏丁丂());
            goto label_24;
            label_18:
            val_10.Add(item:  val_15._value._obj.丙东专丂世丈丏丁丂());
            goto label_24;
            label_20:
            var val_30 = 0;
            val_30 = val_30 | ((val_13 >= val_9) ? 1 : 0);
            goto label_25;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.Linq.Enumerable.Any<System.Int32>(source:  val_10)) == false)
            {
                goto label_46;
            }
            
            List.Enumerator<T> val_23 = val_10.GetEnumerator();
            val_34 = 1152921525710254080;
            val_35 = 1152921560543771072;
            label_41:
            if((105921888 & 1) == 0)
            {
                goto label_38;
            }
            
            bool val_25 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Remove(key:  val_14.丙东专丂世丈丏丁丂());
            goto label_41;
            label_38:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_46:
            val_31 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Count) >= 1)
            {
                    val_32 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField;
                var val_29 = (val_32.Count > 0) ? 1 : 0;
                return (bool)val_36;
            }
            
            label_52:
            val_36 = 0;
            return (bool)val_36;
        }
        public 与丈且与丂七丅丄万()
        {
            val_1 = new System.Object();
        }
    
    }

}
