using UnityEngine;

namespace PGCompany
{
    internal class StorePromotionInfoUI : StorePromotionInfoUIAbstract
    {
        // Fields
        private UILabel _titleLabel;
        private PGCompany.InventoryItemView _priceUI;
        private PGCompany.InventoryItemView _itemView;
        private System.IDisposable 东三世丝丒三一丈丛;
        
        // Methods
        protected override void OnEnable()
        {
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.StorePromotionInfoUI).__il2cppRuntimeField_1C0);
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "StorePromotionInfoUI_" + this.gameObject.name);
        }
        protected override void OnDisable()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        protected override void 丝一丅丆三东丂丞七()
        {
            string val_2;
            if(71690 == 0)
            {
                    return;
            }
            
            val_2 = 71690;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  val_2);
            if(this._priceUI != null)
            {
                    val_2 = 71690;
                this._priceUI.Setup(丈丄不七三万丄丁不:  val_2);
            }
            
            if(this._itemView == null)
            {
                    return;
            }
            
            this._itemView.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this));
        }
        public StorePromotionInfoUI()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
