using UnityEngine;

namespace I2.Loc
{
    public class LocalizationLanguageStore : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<I2.Loc.LanguageEntry> LanguageDictionary;
        
        // Methods
        public void 丕丌丐丘七丘丐丌下(string 下上丐丆丝丟丝丒不, int 丞世不丒下上上丝丑, string 丙业与丙丗丝不丈东, string 专丏不丏东丏丈丆上)
        {
            I2.Loc.LanguageEntry val_1 = new I2.Loc.LanguageEntry();
            .key = 下上丐丆丝丟丝丒不;
            .index = 丞世不丒下上上丝丑;
            .path = 丙业与丙丗丝不丈东;
            .code = 专丏不丏东丏丈丆上;
            if((this.LanguageDictionary.Contains(item:  val_1)) != false)
            {
                    return;
            }
            
            this.LanguageDictionary.Add(item:  val_1);
        }
        public LocalizationLanguageStore()
        {
            this.LanguageDictionary = new System.Collections.Generic.List<I2.Loc.LanguageEntry>();
        }
    
    }

}
