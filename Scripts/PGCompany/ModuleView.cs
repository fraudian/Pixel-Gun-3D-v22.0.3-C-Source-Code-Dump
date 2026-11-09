using UnityEngine;

namespace PGCompany
{
    internal class ModuleView : MonoBehaviour
    {
        // Fields
        private UIWidget _widget;
        private UISprite _propertySprite;
        private PGCompany.InventoryItemView _itemView;
        private PropertyUI _propertyUI;
        private PGCompany.丏丂一丗丙世丏丐三 丙丄七万三丁丆丅丅;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            this.丙丄七万三丁丆丅丅 = 丕上业丕丘上丘七一;
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            string val_7;
            PGCompany.InventoryItemView val_8;
            val_7 = this;
            val_8 = this._itemView;
            val_8.Setup(与且专丈不万东一万:  this.丙丄七万三丁丆丅丅);
            if(this.丙丄七万三丁丆丅丅 == null)
            {
                    return;
            }
            
            val_8 = this._propertyUI;
            val_7 = this.丙丄七万三丁丆丅丅.业丙与世东丑丈丐万();
            val_8.世与东丗世三丞丞不(丟丕丞丁丝丂上丄上:  this._widget.depth, 丛丐丌丙丈七丛丛东:  PGCompany.七丆丆丕丂丙丕丐丂.世丗丘丙丘丛丛一丟(丕上业丕丘上丘七一:  this.丙丄七万三丁丆丅丅, 不丗丐丘业专丂丝上:  this._propertySprite.atlas), 丟丒丏丛三丟丑丗丝:  val_7, 丌丒丝东丌下丕丁丅:  this.丙丄七万三丁丆丅丅.丅业专丏不丒丄丐一(), 丙丝与丆三丝不且丑:  0f, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        }
        public ModuleView()
        {
        
        }
    
    }

}
