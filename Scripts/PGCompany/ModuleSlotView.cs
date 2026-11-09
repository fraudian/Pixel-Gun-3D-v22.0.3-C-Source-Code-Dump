using UnityEngine;

namespace PGCompany
{
    internal class ModuleSlotView : MonoBehaviour
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        private UnityEngine.GameObject _weightContainer;
        private UILabel _upLabel;
        private UITexture _moduleTexture;
        private UISprite _moduleSprite;
        private UISprite _bg;
        private System.Collections.Generic.List<UnityEngine.GameObject> _selectedObjects;
        private System.Collections.Generic.List<UIBasicSprite> _coloredObjetcs;
        private PGCompany.丏丂一丗丙世丏丐三 <丆世七丘丈丞丅世上>k__BackingField;
        
        // Properties
        internal PGCompany.丏丂一丗丙世丏丐三 丏丂一丗丙世丏丐三 { get; set; }
        
        // Methods
        internal PGCompany.丏丂一丗丙世丏丐三 丁世下丘丝丆不不丁()
        {
            return (PGCompany.丏丂一丗丙世丏丐三)this.<丆世七丘丈丞丅世上>k__BackingField;
        }
        private void 不上丘与丛丞丈丄不(PGCompany.丏丂一丗丙世丏丐三 丙业与丙丗丝不丈东)
        {
            this.<丆世七丘丈丞丅世上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            PGCompany.丏丂一丗丙世丏丐三 val_16;
            var val_17;
            val_16 = 丕上业丕丘上丘七一;
            this.<丆世七丘丈丞丅世上>k__BackingField = val_16;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weightContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._upLabel, 丏业丟一东丂东丘丛:  (val_16 != 0) ? 1 : 0);
            UnityEngine.Color val_2 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "ActiveModule");
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._bg, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            if(this._itemView != 0)
            {
                    this._itemView.Setup(与且专丈不万东一万:  val_16);
            }
            
            if(val_16 == null)
            {
                goto label_26;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._upLabel, 丕丗丘丑丛与丑业丒:  PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  val_16.丑业世丞上丂丄丟丞()));
            val_17 = 0;
            goto label_12;
            label_17:
            UnityEngine.Color val_7 = val_16.丝一丙丝上丛三丄丈();
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._coloredObjetcs.Item[0], 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            val_17 = 1;
            label_12:
            if(val_17 < this._coloredObjetcs.Count)
            {
                goto label_17;
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._moduleTexture, 与万丆丛丒万丝丙丑:  val_16);
            if(this._moduleSprite == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._moduleSprite, 万丑丞一丝丌丐丒丘:  PGCompany.七丆丆丕丂丙丕丐丂.丙丟丁丒七下丝七一(丕上业丕丘上丘七一:  val_16, 不丗丐丘业专丂丝上:  this._moduleSprite.atlas));
            return;
            label_30:
            UnityEngine.Color val_13 = UnityEngine.Color.white;
            this._coloredObjetcs.Item[val_16].color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
            val_16 = val_16 + 1;
            label_26:
            if(val_16 < this._coloredObjetcs.Count)
            {
                goto label_30;
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._moduleTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Mods/Module_Empty"));
        }
        internal void 一东上下丆丌丁丐丙()
        {
            UnityEngine.Color val_1 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "InvalidModule");
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._bg, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        }
        internal void 丄丑万丑不丑丟下丄(bool 丂丛丑东不丅丈一东)
        {
            .丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
            this._selectedObjects.ForEach(action:  new System.Action<UnityEngine.GameObject>(object:  new ModuleSlotView.丌丟丘丏丕丅七万丕(), method:  System.Void ModuleSlotView.丌丟丘丏丕丅七万丕::丄业丞丂不下丆丄丕(UnityEngine.GameObject 三丟东丕丄丄下下丑)));
        }
        public ModuleSlotView()
        {
            this._selectedObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._coloredObjetcs = new System.Collections.Generic.List<UIBasicSprite>();
        }
    
    }

}
