using UnityEngine;

namespace PGCompany
{
    internal class ModuleRemoveConfirmPanel : MonoBehaviour
    {
        // Fields
        internal const string 丁专丆丘东且丙世三 = "Modu_leRemoveCon_firmPanel_SkipK_ey";
        private UIToggle _toggle;
        private TweenAlpha _tweenAlpha;
        private UISprite _toggleSprite;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private System.Action 丕丂丁丛上东七丛丞;
        
        // Methods
        private void Awake()
        {
            this._toggle.value = 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Modu_leRemoveCon_firmPanel_SkipK_ey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        }
        private void OnEnable()
        {
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleRemoveConfirmPanel::丌丅丏丈业丛万且专()), 与且专丈不万东一万:  "ModuleRemoveConfirmPanel");
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        internal void 丈且东丑丂且万丒丅(System.Action 丂丘业丂不丁丁七丁)
        {
            this.丕丂丁丛上东七丛丞 = 丂丘业丂不丁丁七丁;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        private void 丌丅丏丈业丛万且专()
        {
        
        }
        public void U_Toggle(UIToggle 丒世丅业丝东下与丗)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Modu_leRemoveCon_firmPanel_SkipK_ey", 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this._toggle.value), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        public void U_ButtonOk()
        {
            if(this.丕丂丁丛上东七丛丞 != null)
            {
                    this.丕丂丁丛上东七丛丞.Invoke();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public void U_ButtonCancel()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public ModuleRemoveConfirmPanel()
        {
        
        }
    
    }

}
