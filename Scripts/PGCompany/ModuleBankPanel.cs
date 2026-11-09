using UnityEngine;

namespace PGCompany
{
    internal class ModuleBankPanel : MonoBehaviour
    {
        // Fields
        private UIButton _button;
        private UnityEngine.BoxCollider _boxCollider;
        private Rilisoft.ButtonHandler 丗丅丂三且不七丒东;
        
        // Methods
        private void Awake()
        {
            this.丗丅丂三且不七丒东 = this.GetComponent<Rilisoft.ButtonHandler>();
        }
        private void OnEnable()
        {
            object val_9;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            val_9 = this;
            if(this.丗丅丂三且不七丒东 != 0)
            {
                    this.丗丅丂三且不七丒东.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ModuleBankPanel::万丑业丐丗丑丄丙丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            }
            
            this._boxCollider.enabled = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
            this._button.enabled = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_9;
            }
            
            val_9 = this._button;
            if(this._button != null)
            {
                goto label_13;
            }
            
            goto label_12;
            label_9:
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            val_10 = val_8.r;
            val_11 = val_8.g;
            val_12 = val_8.b;
            val_13 = val_8.a;
            if(this._button != null)
            {
                goto label_13;
            }
            
            label_12:
            label_13:
            this._button.defaultColor = new UnityEngine.Color() {r = val_10, g = val_11, b = val_12, a = val_13};
        }
        private void OnDisable()
        {
            if(this.丗丅丂三且不七丒东 == 0)
            {
                    return;
            }
            
            this.丗丅丂三且不七丒东.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ModuleBankPanel::万丑业丐丗丑丄丙丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 万丑业丐丗丑丄丙丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丄业丁丞万丛丏丘(丆丟七丝丏业丅上丄:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        }
        public ModuleBankPanel()
        {
        
        }
    
    }

}
