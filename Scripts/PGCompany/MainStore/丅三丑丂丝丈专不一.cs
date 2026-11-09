using UnityEngine;

namespace PGCompany.MainStore
{
    internal abstract class 丅三丑丂丝丈专不一 : 丙丝丛丘丂世丒丄丒
    {
        // Properties
        internal override bool 丑丆丕业世一世一专 { get; }
        protected abstract Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 三万丐专丆丆丕丝一 { get; }
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        
        // Methods
        internal override bool 丗且丒且万丄丕东丟()
        {
            return true;
        }
        protected abstract Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丑且一丐东三不丈丝(); // 0
        internal 丅三丑丂丝丈专不一()
        {
            Rilisoft.丗下丙丅且丐丞丙世.世丗东丈业上万且丒(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.MainStore.丅三丑丂丝丈专不一::丈丂丌丄万丟东上且(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
        }
        protected override bool 丆丑丟丙上丄丁一丕()
        {
            return true;
        }
        protected override bool 丗丘上丌下丌丗一万()
        {
            return true;
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            OfferModule val_10;
            OfferModule val_11;
            var val_12;
            val_10 = this;
            this.丟丕东丆上专七业丛();
            val_11 = val_10;
            val_12 = 0;
            Rilisoft.Offers.丑丝上世丄丂丛丛丕 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏(丗与丟上上丑专世丗:  this);
            if(val_2 == null)
            {
                    return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 7;
            val_11 = val_2.丙丈丈东丟丟丒丄三();
            if(val_11 == null)
            {
                    return;
            }
            
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<Rilisoft.业丙丘丆东丈丕丂丄>(丈丆丕与丒丌丘丕且:  val_11)) == true)
            {
                    return;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_6 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            int val_7 = val_11.Count;
            List.Enumerator<T> val_8 = val_11.GetEnumerator();
            label_17:
            if(((-676277640) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_9 = 0.丐丏七丌丕丗业且上();
            if(this == null)
            {
                goto label_17;
            }
            
            val_6.Add(item:  this);
            goto label_17;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.万丌丌丛万万丆一丗(七丄丆丘丒与丐丘丅:  val_6);
            val_10 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        }
        public override void Dispose()
        {
            Rilisoft.丗下丙丅且丐丞丙世.世丟丆丞不东丅丝三(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.MainStore.丅三丑丂丝丈专不一::丈丂丌丄万丟东上且(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
            this.Dispose();
        }
        private void 丈丂丌丄万丟东上且(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)
        {
            if(this != 丕上业丕丘上丘七一)
            {
                    return;
            }
            
            this.丗丄丐万丏业丏丑万();
        }
        protected virtual PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            var val_14;
            Rilisoft.丂上丐丄丛一一丒七 val_15;
            var val_52;
            PGCompany.MainStore.丅三丑丂丝丈专不一 val_53;
            var val_54;
            var val_55;
            int val_56;
            int val_57;
            System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_58;
            var val_59;
            val_53 = this;
            if(丙业丞丑七丗下丟丌 == null)
            {
                goto label_1;
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = 丙业丞丑七丗下丟丌.丏与丅专三丙与丘丒();
            val_54 = 0;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<Rilisoft.OfferItem>(丈丆丕与丒丌丘丕且:  val_1)) == true)
            {
                    return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_54;
            }
            
            PGCompany.StorePromotionSettings val_3 = PGCompany.MainStore.不丄且一丌与上不专.且一丕丒丌世丄丂七();
            if(val_3 == null)
            {
                goto label_3;
            }
            
            val_3.MainPrefabName = "StorePromotion/SPDefaultView";
            val_3.InfoPrefabName = "MainStorePromotion/MainStorePromo_InfoUI";
            val_3.InfoPrefabNameAlternative = "StorePromotion/SPOfferInfo";
            goto label_4;
            label_1:
            val_54 = 0;
            return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_54;
            label_3:
            mem[56] = "StorePromotion/SPDefaultView";
            mem[64] = "MainStorePromotion/MainStorePromo_InfoUI";
            mem[192] = "StorePromotion/SPOfferInfo";
            label_4:
            val_3.ObtainWeaponCause = 17;
            PGCompany.StorePromotionPurchaseSettings val_4 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = 15;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_5.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  丙业丞丑七丗下丟丌.丟丂丞不专丆万丒世().东与三丌丅三丒丏业()).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  丙业丞丑七丗下丟丌.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世()));
            val_4.Price = val_5;
            decimal val_12 = 丙业丞丑七丗下丟丌.丐丁丒世丟世丘丌丅();
            Rilisoft.丂上丐丄丛一一丒七 val_13 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid});
            mem[1152921559765767272] = val_14;
            .Profit = val_15;
            val_3.PurchaseSettings = val_4;
            Rilisoft.丝丑丂丛万丐丈丘且 val_17 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业丞丑七丗下丟丌.丘三丙丑一东世丛东());
            val_3.EndTime = val_17;
            mem2[0] = val_17.上万三丆专丏丒丗业;
            val_55 = null;
            val_55 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_3.PurchaseSettings.Profit, hi = val_3.PurchaseSettings.Profit}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
            {
                    decimal val_21 = System.Decimal.op_Implicit(value:  val_3.PurchaseSettings.与丂三丟业丘与丅三().丂丁丏一丙丛业且丌());
                val_56 = val_21.flags;
                val_57 = val_21.lo;
                decimal val_22 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_56, hi = val_21.hi, lo = val_57, mid = val_21.mid}, d2:  new System.Decimal() {flags = val_3.PurchaseSettings.Profit, hi = val_3.PurchaseSettings.Profit});
            }
            else
            {
                    val_57 = 1;
                val_56 = 丙业丞丑七丗下丟丌;
                decimal val_23 = val_56.万丞丗丕丕上七万丝(世丈三丐丞一丒丛不:  1);
            }
            
            val_3.ContentPrice = val_23;
            mem2[0] = val_23.lo;
            mem[4] = val_23.mid;
            string[] val_24 = new string[3];
            val_24[0] = "reward-bonus";
            val_24[1] = "promotion-sale-basic";
            val_24[2] = "show-old-price";
            val_3.Tag = new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_24);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            bool val_30 = val_3.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "offer-module."("offer-module.") + 丙业丞丑七丗下丟丌.丑且一丐东三不丈丝().ToString().ToLower());
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_35 = this.不世丈丏丈上与东且();
            .丄丑丘专丄七不专丆 = val_35.Section;
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_36 = this.不世丈丏丈上与东且();
            .丘丏丐丞丈专三且世 = val_36.Season;
            System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_37 = null;
            val_58 = val_37;
            val_37 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            .下丐丐丁与丂下世七 = val_58;
            val_52 = "reward-main";
            val_59 = 0;
            goto label_40;
            label_55:
            PGCompany.丄与丘丑业专丞七丅 val_40 = null;
            val_58 = val_40;
            val_40 = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_1.Item[0].ItemParams);
            bool val_41 = (PGCompany.丄与丘丑业专丞七丅)[1152921559765894160].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-main");
            val_53 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_43 = val_53.丞东丌丛下丙专丘丐(丈丄不七三万丄丁不:  (PGCompany.丄与丘丑业专丞七丅)[1152921559765894160].ItemParams);
            if(val_43.不业丙丒丂丞下丆丙() != 1200)
            {
                    if(val_43.不业丙丒丂丞下丆丙() != 1010)
            {
                    if(val_43.不业丙丒丂丞下丆丙() != 1000)
            {
                goto label_51;
            }
            
            }
            
            }
            
            bool val_47 = (PGCompany.丄与丘丑业专丞七丅)[1152921559765894160].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-currency");
            label_51:
            (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921559765861392].下丐丐丁与丂下世七.Add(item:  val_40);
            val_59 = 1;
            label_40:
            if(val_59 < val_1.Count)
            {
                goto label_55;
            }
            
            PGCompany.MainStore.丏不丂丛不不七且下 val_50 = null;
            val_54 = val_50;
            val_50 = new PGCompany.MainStore.丏不丂丛不不七且下(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  12, 与不丕丆丈不丙丟丛:  val_3, 一丗与一专丙丙丅丄:  new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  丙业丞丑七丗下丟丌.业上丙丞丐丄丆丅七())), 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一(), 丗与丟上上丑专世丗:  this.ToString(), 丙丌丛丗丙东丟专丟:  丙业丞丑七丗下丟丌);
            return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_54;
        }
    
    }

}
