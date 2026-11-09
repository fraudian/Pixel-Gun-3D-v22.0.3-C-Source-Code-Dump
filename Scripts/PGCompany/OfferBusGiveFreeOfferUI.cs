using UnityEngine;

namespace PGCompany
{
    internal sealed class OfferBusGiveFreeOfferUI : BannerWindowWithBack
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        
        // Methods
        public override void Show()
        {
            System.Collections.Generic.IEnumerable<TSource> val_2;
            this.Show();
            PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
            if(val_2 != 0)
            {
                    PGCompany.丆下丐丁丏世丈上丟 val_3 = this.丑丐丙丄丅世世丑丒();
                if(val_2.Count != 0)
            {
                    PGCompany.丆下丐丁丏世丈上丟 val_5 = this.丑丐丙丄丅世世丑丒();
                this = System.Linq.Enumerable.First<PGCompany.三东丏不丗世丅丌丄>(source:  val_2);
                this._itemView.Setup(丈丄不七三万丄丁不:  this);
                return;
            }
            
            }
            
            this.HideSelf();
        }
        public override void Back()
        {
            this.Back();
            this.HideSelf();
        }
        public OfferBusGiveFreeOfferUI()
        {
        
        }
    
    }

}
