using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal struct ClanStoreBuffSetting
    {
        // Fields
        private Rilisoft.丝丑丂丛万丐丈丘且 _indexContainer;
        internal PGCompany.三东丏不丗世丅丌丄 PriceBuy;
        internal PGCompany.三东丏不丗世丅丌丄 PriceGift;
        internal Rilisoft.丝丑丂丛万丐丈丘且 SecondsBuy;
        internal Rilisoft.丝丑丂丛万丐丈丘且 SecondsGift;
        internal Rilisoft.丝丑丂丛万丐丈丘且 SecondsFree;
        private Rilisoft.丝丑丂丛万丐丈丘且 _availabilityDependent;
        private Rilisoft.丝丑丂丛万丐丈丘且 _notifyOnEnd;
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> NotifyTimesToEnd;
        
        // Properties
        internal int Index { get; set; }
        internal bool AvailabilityDependent { get; }
        internal bool NotifyOnEnd { get; }
        
        // Methods
        internal int get_Index()
        {
        
        }
        internal void set_Index(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.PriceBuy = val_1.七丄不丐丗三丝丑一;
            this.PriceGift = val_1.上万三丆专丏丒丗业;
        }
        internal bool get_AvailabilityDependent()
        {
        
        }
        internal bool get_NotifyOnEnd()
        {
        
        }
    
    }

}
