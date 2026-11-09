using UnityEngine;

namespace PGCompany
{
    internal sealed class ModulesMigrationToV2Panel : BannerWindow
    {
        // Fields
        private CurrencyUI _craftCurrencyUI;
        private CurrencyUI _coinsUI;
        private PGCompany.ModuleSlotView _exampleItemView;
        private WidgetLayout _widgetLayout;
        private System.Collections.Generic.List<PGCompany.ModuleSlotView> 丞上丈丁丙丙丟东万;
        
        // Methods
        protected override void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            this.OnEnable();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_17;
            UnityEngine.Transform val_18;
            this._craftCurrencyUI.丈且东丑丂且万丒丅(丒世丘丘上丆丝东丞:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "CraftCurrency"), 七丈丟下世三万丙丄:  "CraftCurrency");
            val_17 = null;
            val_17 = null;
            this._coinsUI.丈且东丑丂且万丒丅(丒世丘丘上丆丝东丞:  PGCompany.丁丈且万丈丅丆丐丈.万丝丁下丅三丒丏丟(), 七丈丟下世三万丙丄:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
            System.Collections.Generic.List<T> val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂<PGCompany.丏丂一丗丙世丏丐三>(丁丅丈丌丟世丗丗丟:  126, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._exampleItemView, 丏业丟一东丂东丘丛:  false);
            UnityEngine.GameObject val_6 = this._exampleItemView.gameObject;
            val_18 = this._widgetLayout.transform;
            if(val_5 != null)
            {
                    丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ModuleSlotView>(专下丐丒丈万丗丟丝:  this.丞上丈丁丙丙丟东万, 专丑业丁丗丏丌不丛:  val_6, 丈东丘丏与丌东东下:  val_18, 与业丄丂丂丆下上丞:  val_5.Count, 丏东下下一丗专下丏:  0);
            }
            else
            {
                    丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ModuleSlotView>(专下丐丒丈万丗丟丝:  this.丞上丈丁丙丙丟东万, 专丑业丁丗丏丌不丛:  val_6, 丈东丘丏与丌东东下:  val_18, 与业丄丂丂丆下上丞:  0.Count, 丏东下下一丗专下丏:  0);
            }
            
            int val_12 = UnityEngine.Mathf.Min(a:  val_5.Count, b:  this.丞上丈丁丙丙丟东万.Count);
            if(val_12 >= 1)
            {
                    var val_17 = 0;
                do
            {
                this.丞上丈丁丙丙丟东万.Item[0].丈且东丑丂且万丒丅(丕上业丕丘上丘七一:  val_5.Item[0]);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丞上丈丁丙丙丟东万.Item[0], 丏业丟一东丂东丘丛:  true);
                val_18 = this._widgetLayout;
                val_18.AddElement(丅丆东丏丙丝丅丆丟:  this.丞上丈丁丙丙丟东万.Item[0]);
                val_17 = val_17 + 1;
            }
            while(val_12 != val_17);
            
            }
            
            this._widgetLayout.Reposition();
        }
        public void U_Hide()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  37);
            this.HideSelf();
        }
        public ModulesMigrationToV2Panel()
        {
            this.丞上丈丁丙丙丟东万 = new System.Collections.Generic.List<PGCompany.ModuleSlotView>();
        }
    
    }

}
