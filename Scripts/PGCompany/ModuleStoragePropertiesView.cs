using UnityEngine;

namespace PGCompany
{
    internal class ModuleStoragePropertiesView : MonoBehaviour
    {
        // Fields
        private PropertiesLayout _propertiesLayout;
        private UISprite _propertySprite;
        private PGCompany.丗丟丅七东丄丙丟上 丂丐丗专丞与丄丕万;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丅七东丄丙丟上 丑专丆丟丟丐丆一丕)
        {
            this.丂丐丗专丞与丄丕万 = 丑专丆丟丟丐丆一丕;
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_19;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            var val_28;
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_1 = this.丂丐丗专丞与丄丕万.丆丟且丗丒不丄七丌();
            this._propertiesLayout.世业丒万丘丆专丘丐();
            val_19 = 0;
            goto label_3;
            label_23:
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            val_24 = val_2.r;
            val_25 = val_2.g;
            val_26 = val_2.b;
            val_27 = val_2.a;
            if(val_19 >= val_1.Count)
            {
                goto label_5;
            }
            
            val_28 = this._propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  PGCompany.七丆丆丕丂丙丕丐丂.世丗丘丙丘丛丛一丟(丕上业丕丘上丘七一:  val_1.Item[0], 不丗丐丘业专丂丝上:  this._propertySprite.atlas), 丟丒丏丛三丟丑丗丝:  val_1.Item[0].业丙与世东丑丈丐万(), 丌丒丝东丌下丕丁丅:  val_1.Item[0].丅业专丏不丒丄丐一(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            if(val_28 != null)
            {
                goto label_16;
            }
            
            goto label_14;
            label_5:
            val_28 = this._propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "shop_stats_Empty", 丟丒丏丛三丟丑丗丝:  "Module_Property_Empty", 丌丒丝东丌下丕丁丅:  0, 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = false}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            UnityEngine.Color val_13 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "ModulePropertyEmpty");
            val_24 = val_13.r;
            val_25 = val_13.g;
            val_26 = val_13.b;
            val_27 = val_13.a;
            if(val_28 != null)
            {
                goto label_16;
            }
            
            label_14:
            label_16:
            val_28.丆丘与丌一不万不丐().color = new UnityEngine.Color() {r = val_24, g = val_25, b = val_26, a = val_27};
            val_28.下丌丘七世丟丂业丟().color = new UnityEngine.Color() {r = val_24, g = val_25, b = val_26, a = val_27};
            val_28.丑一丆丑且丟上业丛().color = new UnityEngine.Color() {r = val_24, g = val_25, b = val_26, a = val_27};
            val_19 = 1;
            label_3:
            Rilisoft.丝丑丂丛万丐丈丘且 val_17 = this.丂丐丗专丞与丄丕万.丏丝丄丄丗丟丙不丆();
            if(val_19 < (-316435568))
            {
                goto label_23;
            }
        
        }
        public ModuleStoragePropertiesView()
        {
        
        }
    
    }

}
