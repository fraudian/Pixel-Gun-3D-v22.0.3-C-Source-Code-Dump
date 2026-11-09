using UnityEngine;

namespace PGCompany.BM
{
    internal class 丅丁不一丙丐丘且上 : 丄不丙万与丙东世丕
    {
        // Methods
        internal override bool 丈丗丒不下丙东东三(PGCompany.BM.丘丆丆丁丝且不丄东 丙丑丆上不丒上丕丛, System.Collections.Generic.List<int> 万专东业世且丏七三)
        {
            var val_11;
            var val_12;
            System.Collections.Generic.List<System.Int32> val_29;
            PGCompany.BM.丘丆丆丁丝且不丄东 val_30;
            System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏> val_32;
            var val_33;
            var val_34;
            val_29 = 万专东业世且丏七三;
            val_30 = 丙丑丆上不丒上丕丛;
            if(((83291.丈丗丒不下丙东东三(丙丑丆上不丒上丕丛:  val_30, 万专东业世且丏七三:  val_29)) == false) || ((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).不业丙丒丂丞下丆丙()) != 1070))
            {
                goto label_50;
            }
            
            int val_5 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).业东丅东丌上丗丑不();
            if(val_5 < 1)
            {
                goto label_50;
            }
            
            int val_7 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下丞丝丂万丙三丏上(世且丐丐丑丛东专丟:  val_5);
            PGCompany.东丑丒丗一丞下丙丙<T> val_8 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            val_32 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField;
            Dictionary.Enumerator<TKey, TValue> val_9 = val_32.GetEnumerator();
            val_33 = 1152921525750875424;
            label_23:
            label_22:
            if((105570960 & 1) == 0)
            {
                goto label_14;
            }
            
            ConfiguredValueTaskAwaiter val_13 = val_12.GetAwaiter();
            if((val_29.Contains(item:  val_13._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_16;
            }
            
            var val_16 = (val_11 < val_7) ? 1 : 0;
            val_16 = val_16 | 1;
            if((val_16 & 1) != 0)
            {
                goto label_18;
            }
            
            val_8.Add(item:  val_13._value._obj.丙东专丂世丈丏丁丂());
            goto label_22;
            label_16:
            val_8.Add(item:  val_13._value._obj.丙东专丂世丈丏丁丂());
            goto label_22;
            label_18:
            var val_28 = 0;
            val_28 = val_28 | ((val_11 >= val_7) ? 1 : 0);
            goto label_23;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.Linq.Enumerable.Any<System.Int32>(source:  val_8)) == false)
            {
                goto label_44;
            }
            
            List.Enumerator<T> val_21 = val_8.GetEnumerator();
            val_32 = 1152921525710254080;
            val_33 = 1152921560543771072;
            label_39:
            if((105570912 & 1) == 0)
            {
                goto label_36;
            }
            
            bool val_23 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Remove(key:  val_12.丙东专丂世丈丏丁丂());
            goto label_39;
            label_36:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_44:
            val_29 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Count) >= 1)
            {
                    val_30 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField;
                var val_27 = (val_30.Count > 0) ? 1 : 0;
                return (bool)val_34;
            }
            
            label_50:
            val_34 = 0;
            return (bool)val_34;
        }
        public 丅丁不一丙丐丘且上()
        {
            val_1 = new System.Object();
        }
    
    }

}
