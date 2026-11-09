using UnityEngine;

namespace PGCompany
{
    internal class StoreItemEndlessScrollCell : EndlessScrollCell
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        private UnityEngine.GameObject _selectableGO;
        private PGCompany.InventoryItemView _price;
        private UnityEngine.GameObject _craftContainer;
        private UILabel _craftCount;
        private UnityEngine.GameObject _canCraftContainer;
        private UnityEngine.GameObject _purchasedContainer;
        private UnityEngine.GameObject _equippedContainer;
        private UnityEngine.GameObject _craftedContainer;
        private UnityEngine.GameObject _lockContainer;
        private UISprite _divisionSprite;
        private UITexture _lockTexture;
        private UITextureMasked _mainTexture;
        private UILabel clanLabel;
        private System.Collections.Generic.List<UnityEngine.GameObject> enableOnMaxDivision;
        private System.Collections.Generic.List<UnityEngine.GameObject> enableIfEmptyCell;
        private bool _lookAtItemState;
        private PGCompany.丟丁且丝丁三丏丙且 <丝业三丑三上丆专不>k__BackingField;
        
        // Properties
        internal bool 丗丐丙丗与丙三且丅 { get; set; }
        internal PGCompany.丟丁且丝丁三丏丙且 不下下丞三一丘丗丐 { get; set; }
        private PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七 { get; }
        
        // Methods
        internal bool 丞一下丟丐丑三业下()
        {
            return (bool)this._lookAtItemState;
        }
        internal void 丆丅业丆专七丏业专(bool 丙业与丙丗丝不丈东)
        {
            this._lookAtItemState = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 != false)
            {
                    if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
                PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
                PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
                return;
            }
            
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        }
        private void 世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            var val_10;
            PGCompany.三东丏不丗世丅丌丄 val_11;
            PGCompany.三东丏不丗世丅丌丄 val_12;
            if((this.<丝业三丑三上丆专不>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丝业三丑三上丆专不>k__BackingField.丏丘下丞丘不丑万丏()) == null)
            {
                    return;
            }
            
            if(val_1.ItemParams == null)
            {
                    return;
            }
            
            if((this.<丝业三丑三上丆专不>k__BackingField) == null)
            {
                    return;
            }
            
            val_10 = 丅一丘丙上东丏丅不.一且丟丁上丑业丕且.业东丅东丌上丗丑不();
            if(((this.<丝业三丑三上丆专不>k__BackingField) == null) || ((this.<丝业三丑三上丆专不>k__BackingField.丏丘下丞丘不丑万丏()) == null))
            {
                goto label_6;
            }
            
            val_11 = val_3.ItemParams;
            if(val_11 != null)
            {
                goto label_7;
            }
            
            label_6:
            val_11 = 0;
            label_7:
            if(val_10 == val_11.业东丅东丌上丗丑不())
            {
                goto label_8;
            }
            
            val_10 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            if(((this.<丝业三丑三上丆专不>k__BackingField) == null) || ((this.<丝业三丑三上丆专不>k__BackingField.丏丘下丞丘不丑万丏()) == null))
            {
                goto label_10;
            }
            
            val_12 = val_6.ItemParams;
            if(val_12 != null)
            {
                goto label_11;
            }
            
            label_10:
            val_12 = 0;
            label_11:
            if((val_10.丕丈丑丝丌专与上下(丟丅丕万万丛丗丞丆:  val_12.业东丅东丌上丗丑不(), 丐丒丗与丝丑丛七丝:  丅一丘丙上东丏丅不.一且丟丁上丑业丕且.业东丅东丌上丗丑不())) == false)
            {
                    return;
            }
            
            label_8:
            this.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  this.<丝业三丑三上丆专不>k__BackingField);
        }
        internal PGCompany.丟丁且丝丁三丏丙且 丂丑丞丝且万丐万丟()
        {
            return (PGCompany.丟丁且丝丁三丏丙且)this.<丝业三丑三上丆专不>k__BackingField;
        }
        private void 丘丕丈下东一丑上丗(PGCompany.丟丁且丝丁三丏丙且 丙业与丙丗丝不丈东)
        {
            this.<丝业三丑三上丆专不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private PGCompany.三东丏不丗世丅丌丄 丈与且丄与丝丆专不()
        {
            PGCompany.丟丁且丝丁三丏丙且 val_2 = this.<丝业三丑三上丆专不>k__BackingField;
            if(val_2 == null)
            {
                    return val_2;
            }
            
            if(val_2.丏丘下丞丘不丑万丏() == null)
            {
                    return val_2;
            }
            
            val_2 = val_1.ItemParams;
            return val_2;
        }
        public override void OnSelectStateUpdate()
        {
            this.OnSelectStateUpdate();
            this.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  this.<丝业三丑三上丆专不>k__BackingField);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄)
        {
            UnityEngine.GameObject val_35;
            this.<丝业三丑三上丆专不>k__BackingField = 丅丘丌且丈丘丄丗丄;
            if(丅丘丌且丈丘丄丗丄 == null)
            {
                goto label_1;
            }
            
            if(this._itemView != null)
            {
                goto label_31;
            }
            
            label_32:
            label_31:
            this._itemView.Setup(与且专丈不万东一万:  丅丘丌且丈丘丄丗丄.丒丅丙丄丞丟下丏业());
            val_35 = this._selectableGO;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  this.Selected);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._price, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._craftContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchasedContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._equippedContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._craftedContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfEmptyCell, 丏业丟一东丂东丘丛:  (丅丘丌且丈丘丄丗丄 == 0) ? 1 : 0);
            if(丅丘丌且丈丘丄丗丄 == null)
            {
                    return;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_5 = 丅丘丌且丈丘丄丗丄.丞三万丒丛丂丞不丄();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._price, 丏业丟一东丂东丘丛:  (val_5 != 0) ? 1 : 0);
            if(val_5 != null)
            {
                    this._price.Setup(丈丄不七三万丄丁不:  val_5);
            }
            
            bool val_7 = 丅丘丌且丈丘丄丗丄.丁丐丅丈丑业丒三上();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._craftContainer, 丏业丟一东丂东丘丛:  val_7);
            if(val_7 != false)
            {
                    PGCompany.StoreItemSettings val_10 = 丅丘丌且丈丘丄丗丄.丏丘下丞丘不丑万丏();
                int val_12 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_10.ItemParams.业东丅东丌上丗丑不());
                PGCompany.StoreItemSettings val_14 = 丅丘丌且丈丘丄丗丄.丏丘下丞丘不丑万丏();
                int val_15 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().七丏万丞且丛丌专丞(丒丞丁丞下丝丆不且:  val_14.ItemParams);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._craftCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_12, arg1:  val_15));
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._canCraftContainer, 丏业丟一东丂东丘丛:  (val_12 >= val_15) ? 1 : 0);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchasedContainer, 丏业丟一东丂东丘丛:  丅丘丌且丈丘丄丗丄.不丌丝丗丒丛丏丙丌());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._equippedContainer, 丏业丟一东丂东丘丛:  丅丘丌且丈丘丄丗丄.与丏丘丏丆丗丌专丅());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._craftedContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnMaxDivision, 丏业丟一东丂东丘丛:  ((this.<丝业三丑三上丆专不>k__BackingField.世丝丌一且丝专丑丛()) == 7) ? 1 : 0);
            val_35 = 丅丘丌且丈丘丄丗丄.一专丁且与丅且丝且();
            bool val_25 = 丅丘丌且丈丘丄丗丄.不丌丝丗丒丛丏丙丌();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._mainTexture, 丏业丟一东丂东丘丛:  val_35 | val_25);
            if(val_25 == true)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  (~val_35) & 1);
            if(val_35 == true)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._divisionSprite, 万丑丞一丝丌丐丒丘:  System.String.Format(format:  "cup{0}_small", arg0:  (this.<丝业三丑三上丆专不>k__BackingField.世丝丌一且丝专丑丛()) + 1.ToString()));
            val_35 = this.<丝业三丑三上丆专不>k__BackingField;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanLabel, 丕丗丘丑丛与丑业丒:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_35.世丝丌一且丝专丑丛()));
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._lockTexture, 与万丆丛丒万丝丙丑:  0);
            return;
            label_1:
            if(this._itemView != null)
            {
                goto label_31;
            }
            
            goto label_32;
        }
        protected void OnEnable()
        {
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        }
        protected void OnDisable()
        {
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        }
        protected void OnDestroy()
        {
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.StoreItemEndlessScrollCell::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        }
        public StoreItemEndlessScrollCell()
        {
        
        }
    
    }

}
