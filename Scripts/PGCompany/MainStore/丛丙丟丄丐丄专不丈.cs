using UnityEngine;

namespace PGCompany.MainStore
{
    internal abstract class 丛丙丟丄丐丄专不丈 : 丙丝丛丘丂世丒丄丒
    {
        // Fields
        private UnityEngine.Coroutine 三丅不专丟丘丒丑丄;
        
        // Properties
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        internal override bool 丑丆丕业世一世一专 { get; }
        internal abstract int 上丝丏丞一下丏丄与 { get; }
        internal abstract 丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 一丅丌丁丙丈丙上丙 { get; }
        internal override bool 丑东丛丄丈专不丒丑 { get; }
        
        // Methods
        protected override bool 丆丑丟丙上丄丁一丕()
        {
            return false;
        }
        protected override bool 丗丘上丌下丌丗一万()
        {
            return true;
        }
        internal override bool 丗且丒且万丄丕东丟()
        {
            return false;
        }
        internal abstract int 世万上丈与万丑丆丛(); // 0
        internal abstract 丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 丟丄丐丙万丛丂丆三(); // 0
        internal override bool 下丐七不不丅丕七丑()
        {
            return true;
        }
        protected abstract System.Collections.Generic.List<int> 丙丞不丝东丗不且不(); // 0
        internal 丛丙丟丄丐丄专不丈()
        {
            丅且东丙业丏丛东丛.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丛丙丟丄丐丄专不丈::丄丆丄七七且丂上丕()));
            丅且东丙业丏丛东丛.东东世丄三丒丄丄上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丛丙丟丄丐丄专不丈::丄丆丄七七且丂上丕()));
            BalanceController.上丝七丈一丈不一丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丛丙丟丄丐丄专不丈::丄丆丄七七且丂上丕()));
        }
        private void 丄丆丄七七且丂上丕()
        {
            this.一丞上一丌世丑一丞();
        }
        private void 一丞上一丌世丑一丞()
        {
            if(this.三丅不专丟丘丒丑丄 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.三丅不专丟丘丒丑丄);
            }
            
            this.三丅不专丟丘丒丑丄 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.三一丝丑七丑丄与丟());
        }
        private System.Collections.IEnumerator 三一丝丑七丑丄与丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丛丙丟丄丐丄专不丈.丈丘业三丙丐东三丘();
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            var val_6;
            PGCompany.StorePromotionConfig val_8 = 0;
            PGCompany.DataObjects.专丅一丄上丗且丑一 val_9 = 0;
            this.丟丕东丆上专七业丛();
            PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            PGCompany.MainStore.不丄且一丌与上不专.丝丟七丕万丝丆业丙(丟丛一东丘上丄丁业:  this, 丟丘不丒上丐丗与丅:  this.Count, 专丂丕丗丗东世丞下: ref  val_3);
            List.Enumerator<T> val_4 = val_3.GetEnumerator();
            label_9:
            if(((-661303728) & 1) == 0)
            {
                goto label_7;
            }
            
            if((this.丟丟专丞世与与丄丘(世丈三丐丞一丒丛不:  val_6.丙东专丂世丈丏丁丂(), 丒丆丂丂丌丕丒丝下: out  val_8, 且万丄丏专丄丛丌丗: out  val_9)) == false)
            {
                goto label_9;
            }
            
            new PGCompany.MainStore.下丐丒丙丂丁丗丘丘() = new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  val_8, 且万丄丏专丄丛丌丗:  val_9);
            this.与丟专世丙丒且下丅(且丘丏丁丑与丙与丁:  new PGCompany.MainStore.下丐丒丙丂丁丗丘丘());
            goto label_9;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不()) != null)
            {
                    return;
            }
        
        }
        private bool 丟丟专丞世与与丄丘(int 世丈三丐丞一丒丛不, out PGCompany.StorePromotionConfig 丒丆丂丂丌丕丒丝下, out PGCompany.DataObjects.专丅一丄上丗且丑一 且万丄丏专丄丛丌丗)
        {
            var val_21;
            Rilisoft.丂上丐丄丛一一丒七 val_22;
            TagSystem.三与下丘七丘丌丏丄 val_49;
            PGCompany.DataObjects.专丅一丄上丗且丑一 val_50;
            一丅丌丁丙丈丙上丙 val_51;
            var val_52;
            int val_53;
            var val_54;
            val_49 = 1152921559780421840;
            val_50 = 1152921559780417808;
            丒丆丂丂丌丕丒丝下 = 0;
            且万丄丏专丄丛丌丗 = 0;
            val_51 = this;
            string val_1 = AbstractBankView.丕东与丐丆丛丛与丅(万丐丝一万专上且丝:  this, 世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
            {
                    val_52 = 0;
                return (bool)val_52;
            }
            
            int val_3 = AbstractBankView.丆丟万丆专丂丝丌丕(万丐丝一万专上且丝:  this, 世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不);
            int val_7 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  -661036016, 世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不);
            if(val_7 != 0)
            {
                    val_53 = val_7 * val_3;
                val_54 = (丅且东丙业丏丛东丛.丑七不且上丗丁一世().丛丏丆东丙丁丅丛丐(三且丗丏丝丂业丛丛:  val_7)) + PixelTime.丙丅丅业丟丁世丁丗();
            }
            else
            {
                    val_54 = 0;
                val_53 = val_3;
            }
            
            PGCompany.StorePromotionPurchaseSettings val_16 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = 2;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_17 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_17.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  (this == 2015) ? 20015 : ((this == 1015) ? 19015 : 10015)).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  世丈三丐丞一丒丛不));
            val_16.Price = val_17;
            val_15.PurchaseSettings = val_16;
            if(0 == 0)
            {
                    int val_18 = AbstractBankView.丕东专下上丆丝丆专(世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不, 万丐丝一万专上且丝:  this);
                if(val_18 >= 1)
            {
                    decimal val_19 = System.Decimal.op_Implicit(value:  val_18);
                Rilisoft.丂上丐丄丛一一丒七 val_20 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_19.flags, hi = val_19.hi, lo = val_19.lo, mid = val_19.mid});
                mem2[0] = val_21;
                val_15.PurchaseSettings.Profit = val_22;
            }
            
            }
            
            val_15.MainPrefabName = (世丈三丐丞一丒丛不 == 100) ? "MainStorePromotion/MainStorePromo_Currency" : "MainStorePromotion/MainStorePromo_Grid_Currency";
            val_15.InfoPrefabName = "";
            val_15.InfoPrefabNameAlternative = "StorePromotion/SPOfferInfo";
            val_15.TitleLocKey = "key_empty";
            val_15.DescriptionLocKey = "key_empty";
            val_15.TexturePath = Rilisoft.Offers.丁且丕专万丈丒丏丗.丄丐丐业下丛丘丛丁(丘专丈与三专丈丈专:  val_1);
            Rilisoft.丝丑丂丛万丐丈丘且 val_25 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            val_15.EndTime = val_25;
            mem2[0] = val_25.上万三丆专丏丒丗业;
            val_15.PurchaseSettings.Type = 2;
            string[] val_27 = new string[3];
            val_27[0] = "view.header.count";
            val_27[1] = "show_purchase_confirmation";
            val_27[2] = PGCompany.MainStore.不丄且一丌与上不专.业丙丙丐丏丟丞丞丆(丒与世世丂且丗业丁:  0, 世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不);
            TagSystem.三与下丘七丘丌丏丄 val_28 = new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_27);
            val_15.Tag = val_28;
            if(0 != 0)
            {
                    string[] val_29 = new string[2];
                val_29[0] = 0;
                val_29[1] = "reward-bonus";
                bool val_30 = val_28.业丏丗丐丂业东丂丗(丏上业丞上丈丄丈不:  val_29);
            }
            
            丒丆丂丂丌丕丒丝下 = new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  12, 与不丕丆丈不丙丟丛:  PGCompany.MainStore.不丄且一丌与上不专.且一丕丒丌世丄丂七(), 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  PGCompany.三丛丗丆七丁丆上丌.丌丏专且丁丂丟世东() + 10000));
            PGCompany.DataObjects.专丅一丄上丗且丑一 val_35 = null;
            val_50 = val_35;
            val_35 = new PGCompany.DataObjects.专丅一丄上丗且丑一();
            .丄丑丘专丄七不专丆 = (PGCompany.StorePromotionConfig)[1152921559780503696].<Type>k__BackingField;
            .丘丏丐丞丈专三且世 = 1152921505710571520;
            System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_36 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            string[] val_37 = new string[2];
            val_37[0] = "reward-main";
            val_37[1] = "reward-currency";
            TagSystem.三与下丘七丘丌丏丄 val_38 = null;
            val_49 = val_38;
            val_38 = new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_37);
            val_36.Add(item:  new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  -661036016).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_53), 丆万一不丌且东丐丐:  val_38));
            .下丐丐丁与丂下世七 = val_36;
            Rilisoft.丝丑丂丛万丐丈丘且 val_40 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_7);
            .且丁丝世丑万丏业丞 = val_40;
            mem[1152921559780507848] = val_40.上万三丆专丏丒丗业;
            val_51 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
            .丑丂丕上丏上业丐且 = val_51.三丌上丐丐丟东专丄(三且丗丏丝丂业丛丛:  val_7);
            且万丄丏专丄丛丌丗 = val_50;
            if(0 != 0)
            {
                    bool val_44 = val_15.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "view.show.currency-count-base");
                val_50 = 且万丄丏专丄丛丌丗;
                val_51 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  -661036016).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_3);
                mem[1152921559780507832] = val_51;
            }
            
            val_52 = 1;
            return (bool)val_52;
        }
        protected override void 丌丑丁上丞万丅丒丌(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 且丘丏丁丑与丙与丁)
        {
            PGCompany.StorePromotionConfig val_3 = 0;
            PGCompany.DataObjects.专丅一丄上丗且丑一 val_4 = 0;
            if((this.丟丟专丞世与与丄丘(世丈三丐丞一丒丛不:  且丘丏丁丑与丙与丁.丒丒与丑丏世且丂业().丂丁丏一丙丛业且丌(), 丒丆丂丂丌丕丒丝下: out  val_3, 且万丄丏专丄丛丌丗: out  val_4)) == false)
            {
                    return;
            }
            
            且丘丏丁丑与丙与丁.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_3);
            且丘丏丁丑与丙与丁.丙丛东七丛一世一丕(且万丄丏专丄丛丌丗:  val_4);
            if(null != null)
            {
                    return;
            }
            
            mem[1152921559780636992] = 1;
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return;
            }
            
            且丘丏丁丑与丙与丁.Invoke();
        }
        public override void Dispose()
        {
            if(this.三丅不专丟丘丒丑丄 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.三丅不专丟丘丒丑丄);
            }
            
            丅且东丙业丏丛东丛.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丛丙丟丄丐丄专不丈::丄丆丄七七且丂上丕()));
            丅且东丙业丏丛东丛.丆世丑三丁丞三三三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丛丙丟丄丐丄专不丈::丄丆丄七七且丂上丕()));
            BalanceController.东丝丙丅丁七丁丛丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丛丙丟丄丐丄专不丈::丄丆丄七七且丂上丕()));
            this.Dispose();
        }
    
    }

}
