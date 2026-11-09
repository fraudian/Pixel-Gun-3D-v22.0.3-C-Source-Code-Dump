using UnityEngine;

namespace PGCompany.MainStore
{
    internal sealed class 丑丝丞丆丛不东丏东 : 丙丝丛丘丂世丒丄丒
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        internal override bool 丑丆丕业世一世一专 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.vip20";
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
        public 丑丝丞丆丛不东丏东()
        {
            PGCompany.VIP20.丗一丄且与一丕丙丝.万丞下世东且专丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            var val_13;
            System.Collections.Generic.List<PGCompany.StorePromotionConfig> val_14;
            val_13 = this;
            this.丟丕东丆上专七业丛();
            val_14 = 1152921505649868800;
            if(PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丝丞丙丂与上且丙丛() == false)
            {
                    return;
            }
            
            if(PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().与丟且上丘与丈丟专() == false)
            {
                    return;
            }
            
            PGCompany.VIP20.丗一丄且与一丕丙丝 val_5 = PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世();
            val_14 = val_5.三世丌丈丒丌七东万;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.StorePromotionConfig>(丈丆丕与丒丌丘丕且:  val_14)) == true)
            {
                    return;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_7 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            int val_8 = val_14.Count;
            List.Enumerator<T> val_9 = val_14.GetEnumerator();
            label_21:
            if(((-628473000) & 1) == 0)
            {
                goto label_18;
            }
            
            PGCompany.MainStore.丙丘丞丒丆丘丑丅丌 val_11 = this.丝与丘丘丅业一业丘(上世丏丁世丟世丆业:  0.丐丏七丌丕丗业且上());
            if(val_11 == null)
            {
                goto label_21;
            }
            
            val_7.Add(item:  val_11);
            goto label_21;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.万丌丌丛万万丆一丗(七丄丆丘丒与丐丘丅:  val_7);
            val_13 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        }
        public override void Dispose()
        {
            PGCompany.VIP20.丗一丄且与一丕丙丝.三丗丆丕丟上丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            this.Dispose();
        }
        private PGCompany.MainStore.丙丘丞丒丆丘丑丅丌 丝与丘丘丅业一业丘(PGCompany.StorePromotionConfig 上世丏丁世丟世丆业)
        {
            var val_6;
            PGCompany.丄与丘丑业专丞七丅 val_49;
            var val_52;
            var val_54;
            var val_55;
            .丄丑丘专丄七不专丆 = X22 + 16;
            .丘丏丐丞丈专三且世 = 1152921505710571520;
            .下丐丐丁与丂下世七 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            PGCompany.StorePromotionSettings val_3 = 上世丏丁世丟世丆业.Settings;
            List.Enumerator<T> val_4 = val_3.ItemRewards.GetEnumerator();
            label_12:
            if(((-628002240) & 1) == 0)
            {
                goto label_7;
            }
            
            val_49 = val_6.丐丏七丌丕丗业且上().Clone();
            if((val_49 != null) && (null != null))
            {
                    val_49 = 0;
            }
            
            (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921559813467808].下丐丐丁与丂下世七.Add(item:  val_49);
            goto label_12;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.StorePromotionSettings val_10 = 上世丏丁世丟世丆业.Settings;
            if(val_10.Tag == null)
            {
                goto label_23;
            }
            
            label_83:
            PGCompany.StorePromotionSettings val_11 = 上世丏丁世丟世丆业.Settings;
            if((val_11.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "source.vip20")) != true)
            {
                    PGCompany.StorePromotionSettings val_13 = 上世丏丁世丟世丆业.Settings;
                bool val_14 = val_13.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "source.vip20");
            }
            
            PGCompany.StorePromotionSettings val_15 = 上世丏丁世丟世丆业.Settings;
            val_52 = null;
            val_52 = null;
            PGCompany.StorePromotionSettings val_17 = 上世丏丁世丟世丆业.Settings;
            bool val_18 = val_17.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "hide_sale");
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_15.PurchaseSettings.Profit, hi = val_15.PurchaseSettings.Profit}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
            {
                goto label_39;
            }
            
            if(val_18 != false)
            {
                    PGCompany.StorePromotionSettings val_19 = 上世丏丁世丟世丆业.Settings;
                val_19.Tag.Remove(丆万一不丌且东丐丐:  "hide_sale");
            }
            
            PGCompany.StorePromotionSettings val_20 = 上世丏丁世丟世丆业.Settings;
            if((val_20.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "show-old-price")) == true)
            {
                goto label_60;
            }
            
            PGCompany.StorePromotionSettings val_22 = 上世丏丁世丟世丆业.Settings;
            bool val_23 = val_22.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "show-old-price");
            if(上世丏丁世丟世丆业 != null)
            {
                goto label_64;
            }
            
            goto label_52;
            label_39:
            if(val_18 != true)
            {
                    PGCompany.StorePromotionSettings val_24 = 上世丏丁世丟世丆业.Settings;
                bool val_25 = val_24.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "hide_sale");
            }
            
            PGCompany.StorePromotionSettings val_26 = 上世丏丁世丟世丆业.Settings;
            if((val_26.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "show-old-price")) != false)
            {
                    PGCompany.StorePromotionSettings val_28 = 上世丏丁世丟世丆业.Settings;
                val_28.Tag.Remove(丆万一不丌且东丐丐:  "show-old-price");
            }
            
            label_60:
            if(上世丏丁世丟世丆业 != null)
            {
                goto label_64;
            }
            
            label_52:
            label_64:
            PGCompany.StorePromotionSettings val_29 = 上世丏丁世丟世丆业.Settings;
            if((val_29.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.disable-info-if-purchased")) != true)
            {
                    PGCompany.StorePromotionSettings val_31 = 上世丏丁世丟世丆业.Settings;
                bool val_32 = val_31.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.disable-info-if-purchased");
            }
            
            PGCompany.MainStore.丙丘丞丒丆丘丑丅丌 val_33 = new PGCompany.MainStore.丙丘丞丒丆丘丑丅丌(上世丏丁世丟世丆业:  上世丏丁世丟世丆业, 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
            val_33.七万三丟丞丆丞东业().Clear();
            PGCompany.StorePromotionSettings val_35 = 上世丏丁世丟世丆业.Settings;
            List.Enumerator<T> val_36 = val_35.ItemsParams.GetEnumerator();
            label_79:
            if(((-628002272) & 1) == 0)
            {
                goto label_76;
            }
            
            val_33.七万三丟丞丆丞东业().Add(item:  val_6.丐丏七丌丕丗业且上().与下不与丐丈丁丈万());
            goto label_79;
            label_23:
            PGCompany.StorePromotionSettings val_40 = 上世丏丁世丟世丆业.Settings;
            val_40.Tag = new TagSystem.三与下丘七丘丌丏丄();
            if(上世丏丁世丟世丆业 != null)
            {
                goto label_83;
            }
            
            goto label_83;
            label_76:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_54 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.七下丐丂丙丑东专丂 val_44 = val_54.一丌世丑丄东丞丘三<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207));
            if(val_44 == null)
            {
                    return val_33;
            }
            
            List.Enumerator<T> val_46 = val_44.且业上丞丄丁专不丙().GetEnumerator();
            label_96:
            if(((-628002272) & 1) == 0)
            {
                goto label_93;
            }
            
            (PGCompany.MainStore.丙丘丞丒丆丘丑丅丌)[1152921559813602976].专七东丌下丏丕万上.Add(item:  val_6.丐丏七丌丕丗业且上().与下不与丐丈丁丈万());
            goto label_96;
            label_93:
            val_55 = 0;
            val_54 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return val_33;
            }
            
                if(641 == 641)
            {
                    return val_33;
            }
            
                return val_33;
            }
            
            if( != 0)
            {
                    return val_33;
            }
            
            return val_33;
        }
        protected override void 丌丑丁上丞万丅丒丌(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 且丘丏丁丑与丙与丁)
        {
            if(W8 != 0)
            {
                    return;
            }
            
            mem[1152921559813752640] = 1;
            if(X8 == 0)
            {
                    return;
            }
            
            X8.Invoke();
        }
    
    }

}
