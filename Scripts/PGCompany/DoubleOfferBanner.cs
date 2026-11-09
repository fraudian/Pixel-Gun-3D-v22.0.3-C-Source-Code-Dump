using UnityEngine;

namespace PGCompany
{
    internal sealed class DoubleOfferBanner : BannerWindowLobbyPurchase
    {
        // Fields
        private static System.Action 丛丄业丘不丆丄三丞;
        private static System.Action 丛一丘专专丅丆丛与;
        private static bool <不丟东上丂丘一不万>k__BackingField;
        private DoublePromotionView promotionView;
        
        // Properties
        internal static bool 丅业东万丌丕上丌丄 { get; set; }
        
        // Methods
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.DoubleOfferBanner.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
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
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.DoubleOfferBanner.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
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
                val_3 = System.Delegate.Combine(a:  PGCompany.DoubleOfferBanner.丛一丘专专丅丆丛与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.DoubleOfferBanner.丛一丘专专丅丆丛与 != 1152921505589170184);
        
        }
        internal static void 丏丅丄丘丐丏丝丏一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.DoubleOfferBanner.丛一丘专专丅丆丛与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.DoubleOfferBanner.丛一丘专专丅丆丛与 != 1152921505589170184);
        
        }
        internal static bool 丈丐丞丐上丑且丕万()
        {
            return (bool)PGCompany.DoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField;
        }
        private static void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
        {
            PGCompany.DoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丆下丝丟丛不三丟丟()
        {
            var val_17;
            PGCompany.不万丑丗丕与丐丒丏 val_2 = PGCompany.专三不不三三一丗丅.丑七不且上丗丁一世().丙与丞上丅上且且业();
            if(val_2 == null)
            {
                    return (bool)val_17;
            }
            
            if((val_2.业一与丏丄与丁丅七(东业丝丞丕东丞且丟:  PixelTime.丝丗专上三不丄丑丑())) != false)
            {
                    if(val_2.世一丒专丛丏世丁丙() == false)
            {
                goto label_6;
            }
            
            }
            
            label_11:
            val_17 = 0;
            return (bool)val_17;
            label_6:
            if(val_2.丆业上丑丏七丂世丘() == 0)
            {
                    return (bool)val_17;
            }
            
            if(((val_2.丆业上丑丏七丂世丘() < 1) || (val_2.世丈丁业丛上丘丗丐().丁业丕上丂丈且丞与() < 1)) || (val_2.丌业东丐丟不与丅丘() == false))
            {
                goto label_11;
            }
            
            var val_16 = (PixelTime.丝丗专上三不丄丑丑() >= ((val_2.世丈丁业丛上丘丗丐().丁业丕上丂丈且丞与() + val_2.丆业上丑丏七丂世丘()) << )) ? 1 : 0;
            return (bool)val_17;
        }
        public override void Show()
        {
            var val_21;
            var val_22;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_23;
            var val_24;
            var val_25;
            this.Show();
            val_21 = PGCompany.专三不不三三一丗丅.丑七不且上丗丁一世().丙与丞上丅上且且业();
            if((val_21 == null) || (PixelTime.丝业丁丌丘东丏世与() == false))
            {
                goto label_5;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  70);
            if(val_21.上丟丄与丁三丌丘专() == 0)
            {
                goto label_9;
            }
            
            val_22 = 0;
            goto label_10;
            label_5:
            this.HideSelf();
            return;
            label_9:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().一丄丒丟丘丗丙丅业(与丕丌丒丗丄丘丙东:  PixelTime.丝丗专上三不丄丑丑());
            if(PGCompany.DoubleOfferBanner.丛一丘专专丅丆丛与 != null)
            {
                    PGCompany.DoubleOfferBanner.丛一丘专专丅丆丛与.Invoke();
            }
            
            val_22 = 1;
            label_10:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三且不丕世丘不三丒(丘东丏丆丑丐与丆丝:  PixelTime.丝丗专上三不丄丑丑());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_23 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            System.Collections.Generic.List<PGCompany.StorePromotionConfig> val_12 = val_21.专专丈丘且专丛丏与();
            if(val_12 == null)
            {
                goto label_32;
            }
            
            PGCompany.StorePromotionSettings val_15 = System.Linq.Enumerable.FirstOrDefault<PGCompany.StorePromotionConfig>(source:  val_12).Settings;
            if((val_15 == null) || (val_15.PurchaseSettings == null))
            {
                goto label_32;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_17 = val_15.PurchaseSettings.与丂三丟业丘与丅三();
            if(val_17 == null)
            {
                goto label_40;
            }
            
            int val_18 = val_17.丂丁丏一丙丛业且丌();
            val_24 = 0;
            val_23 = (val_15 == 0) ? 0 : ((val_12 == 0) ? 0 : (val_23));
            goto label_40;
            label_32:
            val_24 = 0;
            label_40:
            if(((-860188232) & 1) != 0)
            {
                    val_25 = val_24.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_25 = 0;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  val_23, 丗下一不丘丑丅业且:  0, 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  "double", 一丑丑丝丏且丂丏丘:  (val_22 != 0) ? "FirstTime" : "Timer");
            PGCompany.DoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField = true;
        }
        public override void Hide()
        {
            this.Hide();
            PGCompany.DoubleOfferBanner.<不丟东上丂丘一不万>k__BackingField = false;
            if(PGCompany.DoubleOfferBanner.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.DoubleOfferBanner.丛丄业丘不丆丄三丞.Invoke();
        }
        public override void Back()
        {
            this.Back();
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            PGCompany.丌与丛丕业丈不丐世.丅丂且三丂丟丒业丕(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.DoubleOfferBanner::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
            this.OnEnable();
        }
        protected override void OnDisable()
        {
            PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.DoubleOfferBanner::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
            this.OnDisable();
        }
        private void 丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)
        {
            goto typeof(PGCompany.DoubleOfferBanner).__il2cppRuntimeField_218;
        }
        public DoubleOfferBanner()
        {
        
        }
    
    }

}
