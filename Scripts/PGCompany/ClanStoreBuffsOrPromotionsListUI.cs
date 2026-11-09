using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanStoreBuffsOrPromotionsListUI : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _noActiveBuffs;
        private WidgetLayout _widgetLayout;
        private PGCompany.ClanStoreBuffsOrPromotionsUI _example;
        private System.Collections.Generic.List<PGCompany.ClanStoreBuffsOrPromotionsUI> 丗丒世丅三丛丒一下;
        
        // Methods
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._example, 丏业丟一东丂东丘丛:  false);
            this.丗丒世丅三丛丒一下 = System.Linq.Enumerable.ToList<PGCompany.ClanStoreBuffsOrPromotionsUI>(source:  this._widgetLayout.GetComponentsInChildren<PGCompany.ClanStoreBuffsOrPromotionsUI>(includeInactive:  true));
        }
        private void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            PGCompany.StorePromotionBannerClanLootBoxPointBuffUI.丌不三丈三丙不丟与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsOrPromotionsListUI::丝一丅丆三东丂丞七()));
            PGCompany.BuffController.丅丕万丝世丒专下专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsOrPromotionsListUI::丝一丅丆三东丂丞七()));
        }
        private void OnDisable()
        {
            PGCompany.StorePromotionBannerClanLootBoxPointBuffUI.丁丌丅且丈丏丙世丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsOrPromotionsListUI::丝一丅丆三东丂丞七()));
            PGCompany.BuffController.一不丐丘业丘丐上丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsOrPromotionsListUI::丝一丅丆三东丂丞七()));
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_33;
            var val_35;
            UnityEngine.GameObject val_37;
            var val_38;
            UnityEngine.GameObject val_39;
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_1 = null;
            val_33 = val_1;
            val_1 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  40, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(PGCompany.上三世丝丕专丂丟丌.丏丞丕不且七丌万丙() != false)
            {
                    if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_lootbox_point_buff"), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true)
            {
                    PGCompany.东丑丆丗丏丐丟下丄 val_11 = PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().丒世丒一不丝丑且业(丞世不丒下上上丝丑:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_lootbox_point_buff").业东丅东丌上丗丑不());
                if(val_11 != null)
            {
                    val_1.Add(item:  val_11);
            }
            
            }
            
            }
            
            val_35 = null;
            val_35 = null;
            if((ClanStoreBuffsOrPromotionsListUI.<>c.<>9__7_0) == null)
            {
                goto label_15;
            }
            
            label_41:
            this.丗丒世丅三丛丒一下.ForEach(action:  ClanStoreBuffsOrPromotionsListUI.<>c.<>9__7_0);
            val_37 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._widgetLayout, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noActiveBuffs, 丏业丟一东丂东丘丛:  false);
            val_38 = 1152921554011105904;
            if(val_1.Count <= 0)
            {
                    if(val_3.Count < 1)
            {
                goto label_22;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._widgetLayout, 丏业丟一东丂东丘丛:  true);
            val_37 = this._example.gameObject;
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ClanStoreBuffsOrPromotionsUI>(专下丐丒丈万丗丟丝:  this.丗丒世丅三丛丒一下, 专丑业丁丗丏丌不丛:  val_37, 丈东丘丏与丌东东下:  this._widgetLayout.transform, 与业丄丂丂丆下上丞:  val_3.Count + val_1.Count, 丏东下下一丗专下丏:  0);
            this._widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
            List.Enumerator<T> val_19 = val_1.GetEnumerator();
            val_33 = 0;
            goto label_31;
            label_36:
            this.丗丒世丅三丛丒一下.Item[0].下与丞三丅丛丄七丕(且丘丏丁丑与丙与丁:  0.丐丏七丌丕丗业且上());
            val_37 = this.丗丒世丅三丛丒一下.Item[0];
            this._widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_37);
            val_33 = 1;
            label_31:
            if(((-2135234352) & 1) != 0)
            {
                goto label_36;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_50;
            label_15:
            ClanStoreBuffsOrPromotionsListUI.<>c.<>9__7_0 = new System.Action<PGCompany.ClanStoreBuffsOrPromotionsUI>(object:  ClanStoreBuffsOrPromotionsListUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStoreBuffsOrPromotionsListUI.<>c::且万东丈丞三丁业丑(PGCompany.ClanStoreBuffsOrPromotionsUI 三丟东丕丄丄下下丑));
            if(this.丗丒世丅三丛丒一下 != null)
            {
                goto label_41;
            }
            
            goto label_41;
            label_22:
            val_39 = this._noActiveBuffs;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_39, 丏业丟一东丂东丘丛:  true);
            return;
            label_50:
            List.Enumerator<T> val_26 = val_3.GetEnumerator();
            val_38 = 1152921536474029712;
            goto label_58;
            label_63:
            new ClanStoreBuffsOrPromotionsListUI.丒丑万一丁丕东一丗() = new System.Object();
            .专丅丒丈且丐东丐丈 = 0.丐丏七丌丕丗业且上();
            val_37 = null;
            val_37 = new System.Predicate<PGCompany.东丑丆丗丏丐丟下丄>(object:  new ClanStoreBuffsOrPromotionsListUI.丒丑万一丁丕东一丗(), method:  System.Boolean ClanStoreBuffsOrPromotionsListUI.丒丑万一丁丕东一丗::丑专业与不上不七专(PGCompany.东丑丆丗丏丐丟下丄 三且丑上丕上丅丁万));
            if((PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().丙三丟丕丕专与丟丑().Exists(match:  null)) != false)
            {
                    PGCompany.ClanStoreBuffsOrPromotionsUI val_31 = null.Item[-2135190224];
                val_31.下与丞三丅丛丄七丕(丟丑丂丆丅三丈上世:  (ClanStoreBuffsOrPromotionsListUI.丒丑万一丁丕东一丗)[1152921554011378992].专丅丒丈且丐东丐丈);
                val_37 = val_31.Item[-2135190224];
                (ClanStoreBuffsOrPromotionsListUI.丒丑万一丁丕东一丗)[1152921554011378992].专丅丒丈且丐东丐丈.AddElement(丅丆东丏丙丝丅丆丟:  val_37);
                val_33 = 1152921554011264305;
            }
            
            label_58:
            if(((-2135234384) & 1) != 0)
            {
                goto label_63;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_39.Reposition();
        }
        public void U_GoToStore()
        {
            this.丆丐丌业丗丌上丙丒();
        }
        private void 丆丐丌业丗丌上丙丒()
        {
            PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丐丅丒专丛丏上与业:  2, 且丘丏丁丑与丙与丁:  0, 丅丘丌且丈丘丄丗丄:  0, 丞丘丞丏业且丛丏丘:  0);
        }
        public ClanStoreBuffsOrPromotionsListUI()
        {
            this.丗丒世丅三丛丒一下 = new System.Collections.Generic.List<PGCompany.ClanStoreBuffsOrPromotionsUI>();
        }
    
    }

}
