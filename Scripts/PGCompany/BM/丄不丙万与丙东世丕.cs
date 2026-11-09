using UnityEngine;

namespace PGCompany.BM
{
    internal abstract class 丄不丙万与丙东世丕
    {
        // Methods
        internal virtual bool 丈丗丒不下丙东东三(PGCompany.BM.丘丆丆丁丝且不丄东 丙丑丆上不丒上丕丛, System.Collections.Generic.List<int> 万专东业世且丏七三)
        {
            var val_9;
            var val_23;
            System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> val_24;
            var val_25;
            var val_27;
            var val_28;
            val_23 = 万专东业世且丏七三;
            val_24 = 丙丑丆上不丒上丕丛;
            if((丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField) == null)
            {
                goto label_45;
            }
            
            if((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex)) == null)
            {
                    return (bool)val_25;
            }
            
            PGCompany.BM.丟三东丒与万上且东 val_2 = PGCompany.BM.丟三东丒与万上且东.丑七不且上丗丁一世();
            if((丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField) == null)
            {
                goto label_6;
            }
            
            if(val_2 != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            if((val_2.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex))) == false)
            {
                goto label_45;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_5 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            Dictionary.Enumerator<TKey, TValue> val_6 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.GetEnumerator();
            val_27 = 1152921560543766976;
            val_28 = 1152921516995548064;
            label_17:
            if((102379536 & 1) == 0)
            {
                goto label_13;
            }
            
            ConfiguredValueTaskAwaiter val_10 = val_9.GetAwaiter();
            if((val_23.Contains(item:  val_10._value._obj.丙东专丂世丈丏丁丂())) == true)
            {
                goto label_17;
            }
            
            val_5.Add(item:  val_10._value._obj.丙东专丂世丈丏丁丂());
            goto label_17;
            label_6:
            if(val_2 != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_5.Count < 1)
            {
                goto label_39;
            }
            
            List.Enumerator<T> val_15 = val_5.GetEnumerator();
            val_28 = 1152921525710254080;
            val_27 = 1152921525710255104;
            label_34:
            if((102379488 & 1) == 0)
            {
                goto label_31;
            }
            
            bool val_17 = 丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Remove(key:  val_9.丙东专丂世丈丏丁丂());
            goto label_34;
            label_31:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_39:
            val_23 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if((丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Count) >= 1)
            {
                    val_24 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField;
                var val_21 = (val_24.Count > 0) ? 1 : 0;
                return (bool)val_25;
            }
            
            label_45:
            val_25 = 0;
            return (bool)val_25;
        }
        protected 丄不丙万与丙东世丕()
        {
        
        }
    
    }

}
