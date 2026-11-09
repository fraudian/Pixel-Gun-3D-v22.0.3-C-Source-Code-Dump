using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal sealed class ClanStorePromotionSave
    {
        // Fields
        private Rilisoft.丝丑丂丛万丐丈丘且 _id;
        private PGCompany.三东丏不丗世丅丌丄 _price;
        private Rilisoft.丝丑丂丛万丐丈丘且 _sale;
        private PGCompany.三东丏不丗世丅丌丄 _item;
        
        // Methods
        public ClanStorePromotionSave()
        {
        
        }
        internal ClanStorePromotionSave(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_6;
            var val_7;
            var val_8;
            if(且丘丏丁丑与丙与丁 != null)
            {
                    val_6 = 0;
                val_7 = 且丘丏丁丑与丙与丁.七丈丒丒下下且万与();
            }
            else
            {
                    val_6 = 0;
                val_7 = 0.七丈丒丒下下且万与();
            }
            
            val_8 = 0;
            this.丘上丐世丆丑且丞丒(一丗与一专丙丙丅丄:  null, 下丅丙一丂丗丅丝七:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  且丘丏丁丑与丙与丁), 丒世丘丘上丆丝东丞:  且丘丏丁丑与丙与丁, 与丝丙丝万丑丞丄一:  且丘丏丁丑与丙与丁.丆丞上丛丂一业丟丕());
        }
        internal ClanStorePromotionSave(PGCompany.世丏丘丛丗丑专丈下 一丗与一专丙丙丅丄, PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, int 与丝丙丝万丑丞丄一)
        {
            val_1 = new System.Object();
            this.丘上丐世丆丑且丞丒(一丗与一专丙丙丅丄:  一丗与一专丙丙丅丄, 下丅丙一丂丗丅丝七:  PGCompany.三东丏不丗世丅丌丄 val_1 = 下丅丙一丂丗丅丝七, 丒世丘丘上丆丝东丞:  丒世丘丘上丆丝东丞, 与丝丙丝万丑丞丄一:  与丝丙丝万丑丞丄一);
        }
        private void 丘上丐世丆丑且丞丒(PGCompany.世丏丘丛丗丑专丈下 一丗与一专丙丙丅丄, PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, int 与丝丙丝万丑丞丄一)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  一丗与一专丙丙丅丄.七万丅丆且丁世丏丈());
            this._id = val_2;
            mem[1152921554134430040] = val_2.上万三丆专丏丒丗业;
            this._item = 下丅丙一丂丗丅丝七;
            this._price = 丒世丘丘上丆丝东丞;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  与丝丙丝万丑丞丄一);
            this._sale = val_3;
            mem[1152921554134430064] = val_3.上万三丆专丏丒丗业;
        }
        internal PGCompany.东丑丆丗丏丐丟下丄 一丒丒七东丂丛丑东()
        {
            PGCompany.StorePromotionPurchaseSettings val_1 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = (this._price.业东丅东丌上丗丑不() == 10015) ? (1 + 1) : 1;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_4 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_4.Add(item:  this._price);
            val_1.Price = val_4;
            Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this._sale);
            .Sale = val_5;
            mem[1152921554134627440] = val_5.上万三丆专丏丒丗业;
            PGCompany.StorePromotionSettings val_6 = new PGCompany.StorePromotionSettings();
            if(val_6 != null)
            {
                    .PurchaseSettings = val_1;
                .MainPrefabName = "StorePromotion/SPOffersView";
            }
            else
            {
                    mem[96] = val_1;
                mem[56] = "StorePromotion/SPOffersView";
            }
            
            (PGCompany.StorePromotionSettings)[1152921554134643776].ItemsParams.Add(item:  this._item);
            return (PGCompany.东丑丆丗丏丐丟下丄)new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  2, 与不丕丆丈不丙丟丛:  val_6, 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  this._id)));
        }
    
    }

}
