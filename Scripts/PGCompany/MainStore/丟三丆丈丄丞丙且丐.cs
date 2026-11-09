using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丟三丆丈丄丞丙且丐 : 丅三丑丂丝丈专不一
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 三万丐专丆丆丕丝一 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.offers.novice";
        }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丑且一丐东三不丈丝()
        {
            return 130;
        }
        protected override PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            string val_18;
            var val_19;
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_1 = this.丝与丘丘丅业一业丘(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌);
            PGCompany.StorePromotionConfig val_2 = val_1.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_3 = val_2.Settings;
            val_3.InfoPrefabName = "MainStorePromotion/MainStorePromo_NoviceInfoUI";
            val_18 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_7 = val_18.下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
            if(val_7 != null)
            {
                    if((val_7.丘丑下丆上业丛一丄(丗丟丁丐与下丙丕丛:  丙业丞丑七丗下丟丌.业上丙丞丐丄丆丅七().Replace(oldValue:  "nc_", newValue:  System.String.alignConst))) != null)
            {
                    PGCompany.StorePromotionSettings val_9 = val_2.Settings;
                val_9.TitleLocKey = val_8.LocKey;
                PGCompany.StorePromotionSettings val_10 = val_2.Settings;
                val_18 = val_8.DescriptionKey;
                val_10.DescriptionLocKey = val_18;
                PGCompany.StorePromotionSettings val_11 = val_2.Settings;
                val_11.MiniBannerPrefabName = "UniversalMiniBanner/Promotions/Promotion_MiniBanner_Novice";
            }
            
            }
            
            if(丙业丞丑七丗下丟丌.丏不丁丛丕丒丏丆丂() != 1)
            {
                goto label_18;
            }
            
            val_19 = "OfferIcons\\offer_starter_pack_1_new";
            if(val_2 != null)
            {
                goto label_22;
            }
            
            goto label_20;
            label_18:
            if(val_2 != null)
            {
                goto label_22;
            }
            
            label_20:
            label_22:
            PGCompany.StorePromotionSettings val_15 = val_2.Settings;
            val_15.TexturePath = (丙业丞丑七丗下丟丌.丏不丁丛丕丒丏丆丂() == 2) ? "OfferIcons\\offer_starter_pack_2" : 0;
            PGCompany.StorePromotionSettings val_16 = val_2.Settings;
            bool val_17 = val_16.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.disable-info-if-purchased");
            val_1.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_2);
            return val_1;
        }
        public 丟三丆丈丄丞丙且丐()
        {
        
        }
    
    }

}
