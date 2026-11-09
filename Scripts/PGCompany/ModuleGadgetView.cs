using UnityEngine;

namespace PGCompany
{
    internal class ModuleGadgetView : MonoBehaviour
    {
        // Fields
        private UITexture icon;
        private UILabel gadgetName;
        private UILabel description;
        private PropertiesLayout _propertiesLayout;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专, string 丑世丁七丆万丙三丁, System.Nullable<UnityEngine.Color> 丑丞丈丗丄丙丟万丄)
        {
            var val_11;
            var val_12;
            var val_26;
            PropertiesLayout val_27;
            val_26 = 丑丞丈丗丄丙丟万丄.HasValue;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  this.icon);
            if((UnityEngine.Object.op_Implicit(exists:  this.gadgetName)) != false)
            {
                    this.gadgetName.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  三丐三丞丘丕不丒专.nameLocalizationKey);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.description)) != false)
            {
                    this.description.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  三丐三丞丘丕不丒专.descriptionLocalizationKey);
            }
            
            if(val_26.HasValue != false)
            {
                    this.gadgetName.color = new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B};
            }
            
            val_27 = this._propertiesLayout;
            if(val_27 == 0)
            {
                    return;
            }
            
            this._propertiesLayout.世业丒万丘丆专丘丐();
            val_27 = this._propertiesLayout;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_27, 丏业丟一东丂东丘丛:  (三丐三丞丘丕不丒专.properties.Count > 0) ? 1 : 0);
            List.Enumerator<T> val_10 = 三丐三丞丘丕不丒专.properties.GetEnumerator();
            label_41:
            if(((-355639504) & 1) == 0)
            {
                goto label_27;
            }
            
            int val_13 = val_12.丙东专丂世丈丏丁丂();
            val_11 = 0;
            val_12 = 0;
            PropertyUI val_20 = this._propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  ModulesSetGadgetsStorage.Instance.上丘丞丏丗且丑丟丛(丄丒丗丟世丘万丙丟:  val_13), 丟丒丏丛三丟丑丗丝:  ModulesSetGadgetsStorage.Instance.丝七丕丂丅丈丁三丑(丄丒丗丟世丘万丙丟:  val_13), 丌丒丝东丌下丕丁丅:  ModulesSetGadgetsStorage.Instance.下世三万专丈丂下丝(丗丄万丄丌丕丈丈三:  丑世丁七丆万丙三丁, 丄丒丗丟世丘万丙丟:  val_13), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            if(val_26.HasValue == false)
            {
                goto label_41;
            }
            
            val_20.丆丘与丌一不万不丐().color = new UnityEngine.Color() {r = 0f, g = 0f, b = V2.16B, a = V3.16B};
            val_20.下丌丘七世丟丂业丟().color = new UnityEngine.Color() {r = 0f, g = 0f, b = V2.16B, a = V3.16B};
            val_20.丑一丆丑且丟上业丛().color = new UnityEngine.Color() {r = 0f, g = 0f, b = V2.16B, a = V3.16B};
            goto label_41;
            label_27:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public ModuleGadgetView()
        {
        
        }
    
    }

}
