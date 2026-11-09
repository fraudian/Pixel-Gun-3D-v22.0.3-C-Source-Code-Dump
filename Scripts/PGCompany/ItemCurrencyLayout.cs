using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemCurrencyLayout : PGBehaviour
    {
        // Fields
        private WidgetLayout _widgetLayout;
        private System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> _currencyIds;
        private System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丄七丐与丒三世丝专;
        private System.Collections.Generic.List<PGCompany.ItemCurrencyUI> 丟与丛万下丆丏丘丏;
        
        // Methods
        private void Awake()
        {
            this._currencyIds.ForEach(action:  new System.Action<PGCompany.三丌上丁一丟丐丟丈>(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丟丙不丝丗七万丑专(PGCompany.三丌上丁一丟丐丟丈 丐一业丏上七丆下丌)));
            this.丟与丛万下丆丏丘丏.AddRange(collection:  this.GetComponentsInChildren<PGCompany.ItemCurrencyUI>());
            PGCompany.ItemCurrencyUI val_3 = System.Linq.Enumerable.FirstOrDefault<PGCompany.ItemCurrencyUI>(source:  this.丟与丛万下丆丏丘丏);
            if(val_3 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ItemCurrencyUI>(专下丐丒丈万丗丟丝:  this.丟与丛万下丆丏丘丏, 专丑业丁丗丏丌不丛:  val_3.gameObject, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 与业丄丂丂丆下上丞:  this.丄七丐与丒三世丝专.Count, 丏东下下一丗专下丏:  0);
            this.丟与丛万下丆丏丘丏.ForEach(action:  new System.Action<PGCompany.ItemCurrencyUI>(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丆丅丝丙七与丁丁丅(PGCompany.ItemCurrencyUI 三丟东丕丄丄下下丑)));
            this._widgetLayout.Reposition();
            bool val_9 = 业丞下丞丆下丑万上.丂丆东丐七东不丏上(丏专丌万与上丆丈三:  this);
        }
        private void OnDestroy()
        {
            bool val_1 = 业丞下丞丆下丑万上.业丝丑丗且丘丙且丗(丏专丌万与上丆丈三:  this);
        }
        internal void 下丌业业丐丘丐丘三()
        {
            if(业丞下丞丆下丑万上.丈丗丂丟不七东丄丌() == false)
            {
                    return;
            }
            
            this.不与丞下业丑丒丙万();
            Progress.丑丅专一业丙丝丄丁.丆丄世东东丝丝一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丝丏上丄丅丙丕丕专(string 万且万且丑丗且丌丆)));
            PGCompany.丂丞万丒下万丒业丌.丒丛东丙丝万丕与丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丕一丂东丁丝丏三丐()));
            PGCompany.丂丞万丒下万丒业丌.业与丁万丟丄丟丙丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丕一丂东丁丝丏三丐()));
        }
        internal void 不与丞下业丑丒丙万()
        {
            Progress.丑丅专一业丙丝丄丁.丒一世与三东世不丒(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丝丏上丄丅丙丕丕专(string 万且万且丑丗且丌丆)));
            PGCompany.丂丞万丒下万丒业丌.丕万东丛与丟丐东下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丕一丂东丁丝丏三丐()));
            PGCompany.丂丞万丒下万丒业丌.专丕下丂丗一丕丁丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemCurrencyLayout::丕一丂东丁丝丏三丐()));
        }
        private void OnEnable()
        {
            this.丝一丅丆三东丂丞七(丗丂丞丛丒丒丟万丗:  false);
            this.下丌业业丐丘丐丘三();
        }
        private void OnDisable()
        {
            this.不与丞下业丑丒丙万();
        }
        internal void 丝一丅丆三东丂丞七(bool 丗丂丞丛丒丒丟万丗 = False)
        {
            int val_16;
            var val_17;
            PGCompany.丌丑丕丙丅丈丈丘丄 val_18;
            PGCompany.丌丑丕丙丅丈丈丘丄 val_19;
            var val_20;
            var val_21;
            val_16 = this.丟与丛万下丆丏丘丏.Count;
            int val_3 = UnityEngine.Mathf.Min(a:  this.丄七丐与丒三世丝专.Count, b:  val_16);
            if(val_3 >= 1)
            {
                    do
            {
                val_17 = 0;
                Rilisoft.丝丑丂丛万丐丈丘且 val_6 = this.丄七丐与丒三世丝专.Item[0];
                val_18 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丌丑丕丙丅丈丈丘丄>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  -599987104), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
                if(val_18 != null)
            {
                    PGCompany.ItemCurrencyUI val_9 = this.丟与丛万下丆丏丘丏.Item[0];
                val_17 = val_18.丂丁丏一丙丛业且丌();
                val_19 = val_18;
                val_20 = val_17;
                val_21 = 丗丂丞丛丒丒丟万丗;
            }
            else
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_12 = this.丄七丐与丒三世丝专.Item[0];
                val_18 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丑丕丙丅丈丈丘丄>(丞世不丒下上上丝丑:  -599987104);
                val_19 = val_18;
                val_20 = 0;
                val_21 = 0;
            }
            
                this.丟与丛万下丆丏丘丏.Item[0].丈且东丑丂且万丒丅(三七业丂不丄业下七:  val_19, 丌丒丝东丌下丕丁丅:  0, 丗丂丞丛丒丒丟万丗:  false);
                val_16 = 0 + 1;
            }
            while(val_3 != val_16);
            
            }
            
            this._widgetLayout.Reposition();
        }
        private void 丕一丂东丁丝丏三丐()
        {
            this.丝一丅丆三东丂丞七(丗丂丞丛丒丒丟万丗:  true);
        }
        private void 丝丏上丄丅丙丕丕专(string 万且万且丑丗且丌丆)
        {
            this.丝一丅丆三东丂丞七(丗丂丞丛丒丒丟万丗:  true);
        }
        internal PGCompany.ItemCurrencyUI 丝丗丟丛丕丐丂世与(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_5;
            var val_6;
            var val_7;
            val_6 = 丈丄不七三万丄丁不;
            List.Enumerator<T> val_1 = this.丟与丛万下丆丏丘丏.GetEnumerator();
            label_6:
            if(((-599573208) & 1) == 0)
            {
                goto label_2;
            }
            
            val_7 = 0.丐丏七丌丕丗业且上();
            val_5 = 业东丅东丌上丗丑不();
            if(val_5 != val_6.业东丅东丌上丗丑不())
            {
                goto label_6;
            }
            
            goto label_7;
            label_2:
            val_7 = 0;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (PGCompany.ItemCurrencyUI)val_7;
        }
        public ItemCurrencyLayout()
        {
            this._currencyIds = new System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈>();
            this.丄七丐与丒三世丝专 = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
            this.丟与丛万下丆丏丘丏 = new System.Collections.Generic.List<PGCompany.ItemCurrencyUI>();
        }
        private void 丟丙不丝丗七万丑专(PGCompany.三丌上丁一丟丐丟丈 丐一业丏上七丆下丌)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丐一业丏上七丆下丌);
            this.丄七丐与丒三世丝专.Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_1.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_1.上万三丆专丏丒丗业});
        }
        private void 丆丅丝丙七与丁丁丅(PGCompany.ItemCurrencyUI 三丟东丕丄丄下下丑)
        {
            this._widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  三丟东丕丄丄下下丑);
        }
    
    }

}
