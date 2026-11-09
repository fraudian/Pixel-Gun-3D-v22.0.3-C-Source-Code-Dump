using UnityEngine;

namespace PGCompany
{
    internal class MainStorePromotionInfoUI : StorePromotionInfoUIAbstract
    {
        // Fields
        private bool collectViewComponentsAutomatic;
        private System.Collections.Generic.List<SPViewComponentBase> 丞丒丄一丞七丒且丛;
        public GuiApplyersGroup guiApplyersGroup;
        private MainStorePromotionView promotionView;
        private System.Collections.Generic.List<UIBasicSprite> pixelManTextures;
        private UnityEngine.GameObject contentNoneView;
        private UnityEngine.GameObject contentLobbyView;
        private UnityEngine.GameObject contentWeaponView;
        private UnityEngine.GameObject contentGadgetView;
        private UnityEngine.GameObject contentCurrencyView;
        private UnityEngine.GameObject sectionDefaultView;
        private UnityEngine.GameObject sectionAdaptiveView;
        private UnityEngine.GameObject sectionDailyTierView;
        private UnityEngine.GameObject sectionBonusesView;
        private UnityEngine.GameObject sectionOffersLobbyView;
        private System.IDisposable 与丅世与丄丑丌丞东;
        
        // Methods
        protected virtual void OnEnable()
        {
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.MainStorePromotionInfoUI).__il2cppRuntimeField_1C0);
            this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "MainStorePromotionInfoUI_" + this.gameObject.name);
        }
        protected virtual void OnDisable()
        {
            if(this.与丅世与丄丑丌丞东 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.与丅世与丄丑丌丞东.Dispose();
        }
        internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, object 一丐丗丁丞丆丅丟丄, PGCompany.丞丙上世丑丕与丁丁 且丒丛与丞世丙丕丌 = 0)
        {
            if(this.collectViewComponentsAutomatic != false)
            {
                    this.丘丁东丟丒丙且丄七();
            }
            
            this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 且丒丛与丞世丙丕丌:  2);
            this.丒丛丐丐丑丈世专丑();
        }
        protected override void 丝一丅丆三东丂丞七()
        {
            List.Enumerator<T> val_1 = this.丞丒丄一丞七丒且丛.GetEnumerator();
            label_5:
            if(((-217068872) & 1) == 0)
            {
                goto label_3;
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_3 = this.与丞丆丑东东丟丆丌();
            if(0.丐丏七丌丕丗业且上() != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.东丑丆丗丏丐丟下丄 val_4 = this.与丞丆丑东东丟丆丌();
            if((val_4 != null) && (this.guiApplyersGroup != null))
            {
                    string val_6 = "MainStoreSection_" + val_4.丝丒丙一丙丄不三丞();
                string val_7 = val_4.丅上万丛一丐上上丕();
            }
            
            this.丛丙专东丒丁下丟万();
            this.丏丝丕专丗与业丝不();
        }
        private void 丘丁东丟丒丙且丄七()
        {
            if(this.丞丒丄一丞七丒且丛 != null)
            {
                    if(this.丞丒丄一丞七丒且丛.Count != 0)
            {
                    return;
            }
            
            }
            
            this.丞丒丄一丞七丒且丛 = System.Linq.Enumerable.ToList<SPViewComponentBase>(source:  this.GetComponentsInChildren<SPViewComponentBase>(includeInactive:  true));
        }
        private void 丒丛丐丐丑丈世专丑()
        {
            var val_12;
            PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.与丞丆丑东东丟丆丌();
            if(this.与丞丆丑东东丟丆丌().上丟丄与丁三丌丘专() >= 1)
            {
                    var val_7 = (PixelTime.丙丅丅业丟丁世丁丗() < (this.与丞丆丑东东丟丆丌().上丟丄与丁三丌丘专() << )) ? 1 : 0;
            }
            else
            {
                    val_12 = 0;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丗下一不丘丑丅业且:  this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌(), 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  "Offer", 一丑丑丝丏且丂丏丘:  "ByUser");
        }
        public void U_Show_PreviewLobbyPack()
        {
            MainStoreView.丑七不且上丗丁一世().丏丈丁丌丈丅丙且丒(丐丆丝业丙丈下世丁:  this.与丞丆丑东东丟丆丌());
        }
        private void 丛丙专东丒丁下丟万()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.contentNoneView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.contentLobbyView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.contentWeaponView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.contentGadgetView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.contentCurrencyView, 丏业丟一东丂东丘丛:  false);
            if(this.丂丆丁下丈丙丌东上() > 4)
            {
                    return;
            }
            
            var val_14 = 106048980 + (val_1) << 2;
            val_14 = val_14 + 106048980;
            goto (106048980 + (val_1) << 2 + 106048980);
        }
        private PGCompany.MainStorePromotionInfoUI.丁下丄丂丘下不业业 丂丆丁下丈丙丌东上()
        {
            var val_14;
            var val_15;
            System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_17;
            var val_18;
            var val_19;
            var val_21;
            var val_23;
            System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_25;
            val_14 = this;
            PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.与丞丆丑东东丟丆丌();
            val_15 = null;
            val_15 = null;
            val_17 = MainStorePromotionInfoUI.<>c.<>9__24_0;
            if(val_17 == null)
            {
                goto label_4;
            }
            
            label_24:
            if((val_1.Exists(match:  val_17)) != false)
            {
                    val_18 = 1;
                return (丁下丄丂丘下不业业)(((val_14.Exists(match:  System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_10 = null)) & true) != 0) ? (3 + 1) : 3;
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_3 = this.与丞丆丑东东丟丆丌();
            val_19 = null;
            val_19 = null;
            val_17 = MainStorePromotionInfoUI.<>c.<>9__24_1;
            if(val_17 == null)
            {
                goto label_11;
            }
            
            label_28:
            if((val_3.Exists(match:  val_17)) == true)
            {
                goto label_13;
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_5 = this.与丞丆丑东东丟丆丌();
            val_21 = null;
            val_21 = null;
            val_17 = MainStorePromotionInfoUI.<>c.<>9__24_2;
            if(val_17 == null)
            {
                goto label_17;
            }
            
            label_39:
            if((val_5.Exists(match:  val_17)) == false)
            {
                goto label_19;
            }
            
            label_13:
            val_18 = 2;
            return (丁下丄丂丘下不业业)(((val_14.Exists(match:  val_10)) & true) != 0) ? (3 + 1) : 3;
            label_4:
            MainStorePromotionInfoUI.<>c.<>9__24_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  MainStorePromotionInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionInfoUI.<>c::且丕且丅丕丝丘丕丛(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            if(val_1 != null)
            {
                goto label_24;
            }
            
            goto label_24;
            label_11:
            MainStorePromotionInfoUI.<>c.<>9__24_1 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  MainStorePromotionInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionInfoUI.<>c::一丘丌且丐丝丄不丈(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            if(val_3 != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_19:
            val_23 = null;
            val_14 = this.与丞丆丑东东丟丆丌();
            val_23 = null;
            val_25 = MainStorePromotionInfoUI.<>c.<>9__24_3;
            if(val_25 != null)
            {
                    return (丁下丄丂丘下不业业)(((val_14.Exists(match:  val_10)) & true) != 0) ? (3 + 1) : 3;
            }
            
            val_25 = val_10;
            val_10 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  MainStorePromotionInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionInfoUI.<>c::七丅丒丘丙丒七下丙(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            MainStorePromotionInfoUI.<>c.<>9__24_3 = val_25;
            return (丁下丄丂丘下不业业)(((val_14.Exists(match:  val_10)) & true) != 0) ? (3 + 1) : 3;
            label_17:
            MainStorePromotionInfoUI.<>c.<>9__24_2 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  MainStorePromotionInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionInfoUI.<>c::丙丆东三万丘且丘不(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            if(val_5 != null)
            {
                goto label_39;
            }
            
            goto label_39;
        }
        private void 丏丝丕专丗与业丝不()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sectionDefaultView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sectionAdaptiveView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sectionDailyTierView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sectionBonusesView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sectionOffersLobbyView, 丏业丟一东丂东丘丛:  false);
            if(this.与与丕世下丄下七丈() > 4)
            {
                    return;
            }
            
            var val_7 = 106049000 + (val_1) << 2;
            val_7 = val_7 + 106049000;
            goto (106049000 + (val_1) << 2 + 106049000);
        }
        private PGCompany.MainStorePromotionInfoUI.三丄丅丞丗丗丐丙东 与与丕世下丄下七丈()
        {
            var val_17;
            if(this.与丞丆丑东东丟丆丌() == null)
            {
                    return (三丄丅丞丗丗丐丙东)val_17;
            }
            
            if(this.与丞丆丑东东丟丆丌() == null)
            {
                    return (三丄丅丞丗丗丐丙东)val_17;
            }
            
            val_17 = 0;
            return (三丄丅丞丗丗丐丙东)val_17;
        }
        public MainStorePromotionInfoUI()
        {
            this.collectViewComponentsAutomatic = true;
            this.丞丒丄一丞七丒且丛 = new System.Collections.Generic.List<SPViewComponentBase>();
        }
    
    }

}
