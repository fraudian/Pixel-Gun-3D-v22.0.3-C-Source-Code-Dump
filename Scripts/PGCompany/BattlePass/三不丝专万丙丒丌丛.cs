using UnityEngine;

namespace PGCompany.BattlePass
{
    public class 三不丝专万丙丒丌丛 : 丗且世丝丏丕丑丈业
    {
        // Methods
        public void 丗三丗丒丏丐且丞丗(ref string 丞丟丂丄下万丈万东, PGCompany.BattlePass.三丛上丁丗丌丆丌东 七丂丙上与丅丘丟丏, bool 丙专丂世七丂专丆丆)
        {
            string val_6;
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            string val_19;
            var val_20;
            val_14 = 丙专丂世七丂专丆丆;
            if(七丂丙上与丅丘丟丏 == null)
            {
                    return;
            }
            
            if(七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒 == null)
            {
                    return;
            }
            
            if(七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.专丞丑丒丘丆丛丈且() == 67)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            if((WeaponSounds.三丘丒万丛丞与一不.ContainsKey(key:  七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.专丞丑丒丘丆丛丈且())) == false)
            {
                goto label_8;
            }
            
            val_16 = null;
            if(val_14 == false)
            {
                goto label_9;
            }
            
            val_17 = null;
            System.ValueTuple<System.String, System.String, System.String> val_5 = WeaponSounds.三丘丒万丛丞与一不.Item[七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.专丞丑丒丘丆丛丈且()];
            string val_7 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_6);
            goto label_16;
            label_8:
            val_19 = 七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.专丞丑丒丘丆丛丈且().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_20;
            label_9:
            val_20 = null;
            System.ValueTuple<System.String, System.String, System.String> val_11 = WeaponSounds.三丘丒万丛丞与一不.Item[七丂丙上与丅丘丟丏.丌丏万丅丁丘丅三丒.专丞丑丒丘丆丛丈且()];
            label_16:
            val_19 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
            label_20:
            val_14 = 丞丟丂丄下万丈万东;
            丞丟丂丄下万丈万东 = val_14.Replace(oldValue:  "{9}", newValue:  val_19);
        }
        public 三不丝专万丙丒丌丛()
        {
        
        }
    
    }

}
