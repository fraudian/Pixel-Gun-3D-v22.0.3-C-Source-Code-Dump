using UnityEngine;

namespace Rilisoft
{
    public class WeaponSkinsData : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.WeaponSkin> Data;
        
        // Methods
        public string 丒下丂丒丛且丆丐专()
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.WeaponSkin> val_1 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.WeaponSkin>();
            List.Enumerator<T> val_2 = this.Data.GetEnumerator();
            label_12:
            if((395083680 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((val_1.ContainsKey(key:  val_5.Id)) == true)
            {
                goto label_5;
            }
            
            val_1.Add(key:  val_5.Id, value:  val_5);
            goto label_12;
            label_5:
            UnityEngine.Debug.LogError(message:  "Weapon skin list already contains element with id: "("Weapon skin list already contains element with id: ") + val_5.Id);
            goto label_12;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return "";
        }
        public WeaponSkinsData()
        {
            this.Data = new System.Collections.Generic.List<Rilisoft.WeaponSkin>();
        }
    
    }

}
