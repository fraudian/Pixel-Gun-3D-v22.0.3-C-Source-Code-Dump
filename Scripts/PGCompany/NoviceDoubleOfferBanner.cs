using UnityEngine;

namespace PGCompany
{
    internal sealed class NoviceDoubleOfferBanner : BannerWindowLobbyPurchase
    {
        // Fields
        private static System.Action 丛丄业丘不丆丄三丞;
        private static System.Action 丛一丘专专丅丆丛与;
        private static bool <不丟东上丂丘一不万>k__BackingField;
        private NoviceDoublePromotionView promotionView;
        
        // Properties
        internal static bool 丅业东万丌丕上丌丄 { get; set; }
        
        // Methods
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.NoviceDoubleOfferBanner.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.NoviceDoubleOfferBanner.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丌丘东丙丆万三丞专(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.NoviceDoubleOfferBanner.丛一丘专专丅丆丛与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.NoviceDoubleOfferBanner.丛一丘专专丅丆丛与 != 1152921505628839944);
        
        }
        internal static void 丏丅丄丘丐丏丝丏一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.NoviceDoubleOfferBanner.丛一丘专专丅丆丛与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.NoviceDoubleOfferBanner.丛一丘专专丅丆丛与 != 1152921505628839944);
        
        }
        internal static bool 丈丐丞丐上丑且丕万()
        {
            return (bool)PGCompany.NoviceDoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField;
        }
        private static void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
        {
            PGCompany.NoviceDoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丆下丝丟丛不三丟丟()
        {
            var val_4;
            System.Func<PGCompany.上业七丕丒丂七丐丄, System.Boolean> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = NoviceDoubleOfferBanner.<>c.<>9__11_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.Any<PGCompany.上业七丕丒丂七丐丄>(source:  PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丝丘丛丅下丅世世丑(), predicate:  System.Func<PGCompany.上业七丕丒丂七丐丄, System.Boolean> val_3 = null);
            }
            
            val_6 = val_3;
            val_3 = new System.Func<PGCompany.上业七丕丒丂七丐丄, System.Boolean>(object:  NoviceDoubleOfferBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NoviceDoubleOfferBanner.<>c::且丑丘丛丁世丝丙不(PGCompany.上业七丕丒丂七丐丄 丄丘七三上丕世丞业));
            NoviceDoubleOfferBanner.<>c.<>9__11_0 = val_6;
            return System.Linq.Enumerable.Any<PGCompany.上业七丕丒丂七丐丄>(source:  PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丝丘丛丅下丅世世丑(), predicate:  val_3);
        }
        private static bool 丆下丝丟丛不三丟丟(PGCompany.上业七丕丒丂七丐丄 丄丘七三上丕世丞业)
        {
            if(丄丘七三上丕世丞业 != null)
            {
                    if(丄丘七三上丕世丞业.世一丒专丛丏世丁丙() == false)
            {
                goto label_2;
            }
            
            }
            
            return false;
            label_2:
            if(丄丘七三上丕世丞业.丆业上丑丏七丂世丘() == 0)
            {
                    return false;
            }
            
            if(丄丘七三上丕世丞业.丆业上丑丏七丂世丘() < 1)
            {
                    return false;
            }
            
            if(丄丘七三上丕世丞业.丁业丕上丂丈且丞与() < 1)
            {
                    return false;
            }
            
            if(丄丘七三上丕世丞业.丌业东丐丟不与丅丘() == false)
            {
                    return false;
            }
            
            var val_10 = (PixelTime.丝丗专上三不丄丑丑() >= ((丄丘七三上丕世丞业.丁业丕上丂丈且丞与() + 丄丘七三上丕世丞业.丆业上丑丏七丂世丘()) << )) ? 1 : 0;
            return false;
        }
        public override void Show()
        {
            var val_3;
            var val_30;
            var val_31;
            int val_32;
            var val_33;
            System.Func<PGCompany.上业七丕丒丂七丐丄, System.Boolean> val_35;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_36;
            var val_37;
            var val_38;
            val_30 = this;
            this.Show();
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                goto label_5;
            }
            
            PGCompany.丆下丐丁丏世丈上丟 val_2 = this.丑丐丙丄丅世世丑丒();
            if(val_3 == 0)
            {
                goto label_4;
            }
            
            PGCompany.丆下丐丁丏世丈上丟 val_4 = this.丑丐丙丄丅世世丑丒();
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            label_17:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  87);
            if(val_3.上丟丄与丁三丌丘专() == 0)
            {
                goto label_9;
            }
            
            val_31 = 0;
            goto label_10;
            label_4:
            val_32 = 1152921505628889088;
            val_33 = null;
            val_33 = null;
            val_35 = NoviceDoubleOfferBanner.<>c.<>9__13_0;
            if(val_35 == null)
            {
                    System.Func<PGCompany.上业七丕丒丂七丐丄, System.Boolean> val_9 = null;
                val_35 = val_9;
                val_9 = new System.Func<PGCompany.上业七丕丒丂七丐丄, System.Boolean>(object:  NoviceDoubleOfferBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NoviceDoubleOfferBanner.<>c::丌世丗丅丌与东不丌(PGCompany.上业七丕丒丂七丐丄 丌丛万丛世丗丙丟与));
                NoviceDoubleOfferBanner.<>c.<>9__13_0 = val_35;
            }
            
            if((System.Linq.Enumerable.FirstOrDefault<PGCompany.上业七丕丒丂七丐丄>(source:  PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丝丘丛丅下丅世世丑(), predicate:  val_9)) != null)
            {
                goto label_17;
            }
            
            label_5:
            this.HideSelf();
            return;
            label_9:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丕丙业丒丌上不丝专(丗丟丁丐与下丙丕丛:  val_3.业上丙丞丐丄丆丅七(), 与丕丌丒丗丄丘丙东:  PixelTime.丝丗专上三不丄丑丑());
            if(PGCompany.NoviceDoubleOfferBanner.丛一丘专专丅丆丛与 != null)
            {
                    PGCompany.NoviceDoubleOfferBanner.丛一丘专专丅丆丛与.Invoke();
            }
            
            val_31 = 1;
            label_10:
            val_32 = PixelTime.丝丗专上三不丄丑丑();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏上不丒丝丒丐下业(丗丟丁丐与下丙丕丛:  val_3.业上丙丞丐丄丆丅七(), 丘东丏丆丑丐与丆丝:  val_32);
            if(this.promotionView != null)
            {
                    PGCompany.东丑丆丗丏丐丟下丄 val_18 = new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  val_3.东丐丌下万丑世丙丒());
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_36 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            System.Collections.Generic.List<PGCompany.StorePromotionConfig> val_21 = val_3.专专丈丘且专丛丏与();
            if(val_21 == null)
            {
                goto label_39;
            }
            
            PGCompany.StorePromotionSettings val_24 = System.Linq.Enumerable.FirstOrDefault<PGCompany.StorePromotionConfig>(source:  val_21).Settings;
            if((val_24 == null) || (val_24.PurchaseSettings == null))
            {
                goto label_39;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_26 = val_24.PurchaseSettings.与丂三丟业丘与丅三();
            if(val_26 == null)
            {
                goto label_47;
            }
            
            int val_27 = val_26.丂丁丏一丙丛业且丌();
            val_37 = 0;
            val_36 = (val_24 == 0) ? 0 : ((val_21 == 0) ? 0 : (val_36));
            goto label_47;
            label_39:
            val_37 = 0;
            label_47:
            if(((-279994728) & 1) != 0)
            {
                    val_38 = val_37.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_38 = 0;
            }
            
            val_35 = "nodouble";
            PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  val_36, 丗下一不丘丑丅业且:  0, 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  val_35, 一丑丑丝丏且丂丏丘:  (val_31 != 0) ? "FirstTime" : "Timer");
            PGCompany.NoviceDoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField = true;
        }
        public override void Hide()
        {
            this.Hide();
            PGCompany.NoviceDoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField = false;
            if(PGCompany.NoviceDoubleOfferBanner.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.NoviceDoubleOfferBanner.丛丄业丘不丆丄三丞.Invoke();
        }
        public override void Back()
        {
            this.Back();
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            PGCompany.丌与丛丕业丈不丐世.丅丂且三丂丟丒业丕(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.NoviceDoubleOfferBanner::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
            this.OnEnable();
        }
        protected override void OnDisable()
        {
            PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.NoviceDoubleOfferBanner::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
            this.OnDisable();
        }
        private void 丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)
        {
            goto typeof(PGCompany.NoviceDoubleOfferBanner).__il2cppRuntimeField_218;
        }
        public NoviceDoubleOfferBanner()
        {
        
        }
    
    }

}
