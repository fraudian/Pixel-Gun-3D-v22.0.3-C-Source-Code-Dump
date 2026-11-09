using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 与且丛丈与且丑东七 : 丅三丑丂丝丈专不一
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 三万丐专丆丆丕丝一 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.offers.tier-bundles";
        }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丑且一丐东三不丈丝()
        {
            return 140;
        }
        protected override PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_1 = this.丝与丘丘丅业一业丘(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌);
            PGCompany.StorePromotionConfig val_2 = val_1.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_3 = val_2.Settings;
            val_3.InfoPrefabName = "MainStorePromotion/MainStorePromo_TierBundleInfoUI";
            PGCompany.StorePromotionSettings val_4 = val_2.Settings;
            val_4.MiniBannerPrefabName = "UniversalMiniBanner/Promotions/Promotion_MiniBanner_TierBundle";
            PGCompany.StorePromotionSettings val_5 = val_2.Settings;
            val_5.TitleLocKey = "Key_9348";
            PGCompany.StorePromotionSettings val_6 = val_2.Settings;
            val_6.DescriptionLocKey = "Key_9349";
            PGCompany.StorePromotionSettings val_7 = val_2.Settings;
            bool val_8 = val_7.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.disable-info-if-purchased");
            val_1.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_2);
            return val_1;
        }
        public 与且丛丈与且丑东七()
        {
        
        }
    
    }

}
