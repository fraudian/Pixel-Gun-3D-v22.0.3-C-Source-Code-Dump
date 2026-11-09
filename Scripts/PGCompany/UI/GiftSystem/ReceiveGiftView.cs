using UnityEngine;

namespace PGCompany.UI.GiftSystem
{
    internal sealed class ReceiveGiftView : BannerWindow
    {
        // Fields
        internal GiftUI giftUI;
        private PGCompany.UI.GiftSystem.与丕丒三万丞丝丄丑 万万丕丁不业东不丌;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Methods
        protected override void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  0);
            this.万万丕丁不业东不丌 = new PGCompany.UI.GiftSystem.与丕丒三万丞丝丄丑(丘世丟七不丏丙丞丏:  this);
        }
        protected override void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.giftUI.animations.与丛上丞丈丏东万万 = 0;
        }
        public ReceiveGiftView()
        {
        
        }
    
    }

}
