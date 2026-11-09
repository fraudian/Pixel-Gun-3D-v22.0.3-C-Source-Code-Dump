using UnityEngine;

namespace PGCompany.MainStore
{
    internal sealed class 丂东万丁丆丒丞上丏 : 丙丝丛丘丂世丒丄丒
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        internal override bool 丑丆丕业世一世一专 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.offers.manual";
        }
        protected override bool 丆丑丟丙上丄丁一丕()
        {
            return true;
        }
        protected override bool 丗丘上丌下丌丗一万()
        {
            return true;
        }
        internal override bool 丗且丒且万丄丕东丟()
        {
            return true;
        }
        public 丂东万丁丆丒丞上丏()
        {
            PGCompany.ManualOffers.与丈三上丗不丝丐丛.万丞下世东且专丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.MainStore.丂东万丁丆丒丞上丏::专丈丝与丛下丏丂万(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)));
        }
        private void 专丈丝与丛下丏丂万(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
        {
            PGCompany.东丑丆丗丏丐丟下丄 val_14 = 丐丆丝业丙丈下世丁;
            if((this.丈丒丞东专丒下丈专(一丗与一专丙丙丅丄:  val_14.七丈丒丒下下且万与())) == null)
            {
                    return;
            }
            
            val_14 = val_14.丘丑下丆上业丛一丄();
            if(val_14 == null)
            {
                    return;
            }
            
            PGCompany.StorePromotionSettings val_4 = val_14.Settings;
            if(val_4.Tag == null)
            {
                    PGCompany.StorePromotionSettings val_5 = val_14.Settings;
                val_5.Tag = new TagSystem.三与下丘七丘丌丏丄();
            }
            
            PGCompany.StorePromotionSettings val_7 = val_14.Settings;
            PGCompany.StorePromotionSettings val_9 = val_14.Settings;
            if(PixelTime.丙丅丅业丟丁世丁丗() > (long)val_7.StartTime)
            {
                    val_9.Tag.Remove(丆万一不丌且东丐丐:  "hide_sale");
                PGCompany.StorePromotionSettings val_10 = val_14.Settings;
                bool val_11 = val_10.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "show-old-price");
                return;
            }
            
            bool val_12 = val_9.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "hide_sale");
            PGCompany.StorePromotionSettings val_13 = val_14.Settings;
            val_13.Tag.Remove(丆万一不丌且东丐丐:  "show-old-price");
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            var val_9;
            System.Collections.Generic.List<PGCompany.StorePromotionConfig> val_10;
            val_9 = this;
            this.丟丕东丆上专七业丛();
            PGCompany.ManualOffers.与丈三上丗不丝丐丛 val_1 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世();
            val_10 = val_1.三世丌丈丒丌七东万;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.StorePromotionConfig>(丈丆丕与丒丌丘丕且:  val_10)) == true)
            {
                    return;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            int val_4 = val_10.Count;
            List.Enumerator<T> val_5 = val_10.GetEnumerator();
            label_11:
            if(((-650201864) & 1) == 0)
            {
                goto label_8;
            }
            
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_7 = this.丝与丘丘丅业一业丘(上世丏丁世丟世丆业:  0.丐丏七丌丕丗业且上());
            if(val_7 == null)
            {
                goto label_11;
            }
            
            val_3.Add(item:  val_7);
            goto label_11;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.万丌丌丛万万丆一丗(七丄丆丘丒与丐丘丅:  val_3);
            val_9 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        }
        public override void Dispose()
        {
            PGCompany.ManualOffers.与丈三上丗不丝丐丛.三丗丆丕丟上丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.MainStore.丂东万丁丆丒丞上丏::专丈丝与丛下丏丂万(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)));
            this.Dispose();
        }
        private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(PGCompany.StorePromotionConfig 上世丏丁世丟世丆业)
        {
            var val_10;
            PGCompany.StorePromotionSettings val_1 = 上世丏丁世丟世丆业.Settings;
            val_1.InfoPrefabName = "MainStorePromotion/MainStorePromo_InfoUIWithCharacter";
            PGCompany.StorePromotionSettings val_2 = 上世丏丁世丟世丆业.Settings;
            val_2.MiniBannerPrefabName = "UniversalMiniBanner/Promotions/Promotion_MiniBanner_Manual";
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_4 = this.不世丈丏丈上与东且();
            .丄丑丘专丄七不专丆 = val_4.Section;
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_5 = this.不世丈丏丈上与东且();
            .丘丏丐丞丈专三且世 = val_5.Season;
            .下丐丐丁与丂下世七 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            PGCompany.StorePromotionSettings val_7 = 上世丏丁世丟世丆业.Settings;
            List.Enumerator<T> val_8 = val_7.ItemsParams.GetEnumerator();
            label_17:
            if(((-649780912) & 1) == 0)
            {
                goto label_11;
            }
            
            string val_11 = val_10.丐丏七丌丕丗业且上();
            if(val_11 == null)
            {
                goto label_17;
            }
            
            new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_11);
            bool val_13 = (PGCompany.丄与丘丑业专丞七丅)[1152921559791734192].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-main");
            (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921559791697328].下丐丐丁与丂下世七.Add(item:  new PGCompany.丄与丘丑业专丞七丅());
            goto label_17;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.StorePromotionSettings val_14 = 上世丏丁世丟世丆业.Settings;
            if(val_14.Tag == null)
            {
                goto label_30;
            }
            
            label_71:
            PGCompany.StorePromotionSettings val_15 = 上世丏丁世丟世丆业.Settings;
            PGCompany.StorePromotionSettings val_17 = 上世丏丁世丟世丆业.Settings;
            if(PixelTime.丙丅丅业丟丁世丁丗() <= (long)val_15.StartTime)
            {
                goto label_38;
            }
            
            val_17.Tag.Remove(丆万一不丌且东丐丐:  "hide_sale");
            PGCompany.StorePromotionSettings val_18 = 上世丏丁世丟世丆业.Settings;
            bool val_19 = val_18.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "show-old-price");
            if(上世丏丁世丟世丆业 != null)
            {
                goto label_47;
            }
            
            goto label_43;
            label_38:
            bool val_20 = val_17.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "hide_sale");
            PGCompany.StorePromotionSettings val_21 = 上世丏丁世丟世丆业.Settings;
            val_21.Tag.Remove(丆万一不丌且东丐丐:  "show-old-price");
            if(上世丏丁世丟世丆业 != null)
            {
                goto label_47;
            }
            
            label_43:
            label_47:
            PGCompany.StorePromotionSettings val_22 = 上世丏丁世丟世丆业.Settings;
            if((val_22.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "notifications.enabled")) != true)
            {
                    PGCompany.StorePromotionSettings val_24 = 上世丏丁世丟世丆业.Settings;
                bool val_25 = val_24.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "notifications.enabled");
            }
            
            PGCompany.StorePromotionSettings val_26 = 上世丏丁世丟世丆业.Settings;
            if((val_26.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.disable-info-if-purchased")) != true)
            {
                    PGCompany.StorePromotionSettings val_28 = 上世丏丁世丟世丆业.Settings;
                bool val_29 = val_28.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.disable-info-if-purchased");
            }
            
            PGCompany.StorePromotionSettings val_30 = 上世丏丁世丟世丆业.Settings;
            if((val_30.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "NoBlockContainer")) == true)
            {
                    return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  上世丏丁世丟世丆业, 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
            }
            
            PGCompany.StorePromotionSettings val_32 = 上世丏丁世丟世丆业.Settings;
            bool val_33 = val_32.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "NoBlockContainer");
            return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  上世丏丁世丟世丆业, 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
            label_30:
            PGCompany.StorePromotionSettings val_35 = 上世丏丁世丟世丆业.Settings;
            TagSystem.三与下丘七丘丌丏丄 val_36 = 1152921505345343488;
            val_36 = new TagSystem.三与下丘七丘丌丏丄();
            val_35.Tag = val_36;
            if(上世丏丁世丟世丆业 != null)
            {
                goto label_71;
            }
            
            goto label_71;
        }
        protected override void 丌丑丁上丞万丅丒丌(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 且丘丏丁丑与丙与丁)
        {
            this.丗丄丐万丏业丏丑万();
        }
    
    }

}
