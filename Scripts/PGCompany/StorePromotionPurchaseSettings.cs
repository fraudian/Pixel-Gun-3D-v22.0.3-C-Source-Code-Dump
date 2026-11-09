using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class StorePromotionPurchaseSettings
    {
        // Fields
        internal PGCompany.丆一丁丏三万丑东不 Type;
        private PGCompany.三东丏不丗世丅丌丄 _p;
        private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> _price;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Sale;
        internal Rilisoft.丂上丐丄丛一一丒七 Profit;
        internal string InAppId;
        internal Rilisoft.丝丑丂丛万丐丈丘且 FriendGift;
        
        // Properties
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> Price { get; set; }
        
        // Methods
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> get_Price()
        {
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this._price;
        }
        internal void set_Price(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            this._price = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.三东丏不丗世丅丌丄 与丂三丟业丘与丅三()
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3;
            PGCompany.三东丏不丗世丅丌丄 val_4;
            val_3 = this;
            if((PGCompany.丞丒专七世下丅万丂.一不丂专一下丑业不<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  this._price)) != false)
            {
                    val_3 = this._price;
                PGCompany.三东丏不丗世丅丌丄 val_2 = val_3.Item[0];
                return val_4;
            }
            
            val_4 = this._p;
            return val_4;
        }
        public StorePromotionPurchaseSettings()
        {
        
        }
    
    }

}
