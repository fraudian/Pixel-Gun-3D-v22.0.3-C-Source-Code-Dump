using UnityEngine;

namespace PGCompany
{
    internal abstract class ItemButtonAbstract : PGBehaviour
    {
        // Fields
        private System.Action 丙且丆东七与上丌下;
        protected PGCompany.InventoryItemView _price;
        private PGCompany.丟丁且丝丁三丏丙且 <丄丈丆丁一丕丛下万>k__BackingField;
        
        // Properties
        internal PGCompany.丟丁且丝丁三丏丙且 丟丁且丝丁三丏丙且 { get; set; }
        
        // Methods
        internal void 不丌丕丝丐丆上丕丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丙且丆东七与上丌下, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙且丆东七与上丌下 != 1152921555724161288);
        
        }
        internal void 丐专世丛丘丝丈丘丅(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丙且丆东七与上丌下, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙且丆东七与上丌下 != 1152921555724297864);
        
        }
        internal PGCompany.丟丁且丝丁三丏丙且 且丟东专丏丗丙三丘()
        {
            return (PGCompany.丟丁且丝丁三丏丙且)this.<丄丈丆丁一丕丛下万>k__BackingField;
        }
        private void 丟丙丟上丅七丗丝丑(PGCompany.丟丁且丝丁三丏丙且 丙业与丙丗丝不丈东)
        {
            this.<丄丈丆丁一丕丛下万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄)
        {
            PGCompany.InventoryItemView val_6;
            this.<丄丈丆丁一丕丛下万>k__BackingField = 丅丘丌且丈丘丄丗丄;
            val_6 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            PGCompany.StoreItemSettings val_2 = 丅丘丌且丈丘丄丗丄.丏丘下丞丘不丑万丏();
            if((val_6.丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_2.ItemParams)) == true)
            {
                    return;
            }
            
            val_6 = this._price;
            if(val_6 == 0)
            {
                    return;
            }
            
            this._price.Setup(丈丄不七三万丄丁不:  丅丘丌且丈丘丄丗丄.丞三万丒丛丂丞不丄());
        }
        private void OnClick()
        {
            if(this.丙且丆东七与上丌下 == null)
            {
                    return;
            }
            
            this.丙且丆东七与上丌下.Invoke();
        }
        protected void 万丞丌七丈丄丙东万(PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  false, 丆丟七丝丏业丅上丄:  丒世丘丘上丆丝东丞.业上丙丞丐丄丆丅七(), 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛, 丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗, 丁丕丈丏且丕丒丞丏:  true, 上不丗业一丛丈丞且:  0);
        }
        protected abstract void 丞丙东丌一三专丏不(); // 0
        protected ItemButtonAbstract()
        {
        
        }
    
    }

}
