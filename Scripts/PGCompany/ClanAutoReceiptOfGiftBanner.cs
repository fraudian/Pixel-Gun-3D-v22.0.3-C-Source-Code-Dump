using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanAutoReceiptOfGiftBanner : BannerWindow
    {
        // Fields
        private GiftUI giftUI;
        private WidgetLayout _widgetLayout;
        private PGCompany.ClanGiftItemUI _clanGiftItemUI;
        private System.Collections.Generic.List<PGCompany.ClanGiftItemUI> 东丐万丝三下丐丅丒;
        private System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> 七丅丈丁丌丘丑且丙;
        private System.IDisposable 与丅世与丄丑丌丞东;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.东丐万丝三下丐丅丒 = System.Linq.Enumerable.ToList<PGCompany.ClanGiftItemUI>(source:  this.GetComponentsInChildren<PGCompany.ClanGiftItemUI>(includeInactive:  true));
        }
        internal static bool 丕世一与业丅万专丑()
        {
            var val_5;
            if(Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐() == false)
            {
                    return false;
            }
            
            System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> val_3 = Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘();
            val_5 = null;
            val_5 = null;
            if((ClanAutoReceiptOfGiftBanner.<>c.<>9__5_0) != null)
            {
                    if(val_3 == null)
            {
                    return val_3.Exists(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__5_0);
            }
            
                return val_3.Exists(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__5_0);
            }
            
            ClanAutoReceiptOfGiftBanner.<>c.<>9__5_0 = new System.Predicate<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(object:  ClanAutoReceiptOfGiftBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanAutoReceiptOfGiftBanner.<>c::丟丆一丙下丟丘丈丅(PGCompany.GiftSystem.丏下丙丂万且一丑丛 业七丐世专丝丂丟丈));
            if(val_3 != null)
            {
                    return val_3.Exists(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__5_0);
            }
            
            return val_3.Exists(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__5_0);
        }
        public override void Show()
        {
            var val_12;
            System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> val_2 = Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘();
            val_12 = null;
            val_12 = null;
            if((ClanAutoReceiptOfGiftBanner.<>c.<>9__8_0) == null)
            {
                goto label_6;
            }
            
            label_22:
            System.Collections.Generic.List<T> val_3 = val_2.FindAll(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__8_0);
            this.七丅丈丁丌丘丑且丙 = val_3;
            if(val_3.Count <= 0)
            {
                goto typeof(PGCompany.ClanAutoReceiptOfGiftBanner).__il2cppRuntimeField_1D8;
            }
            
            this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "ClanAutoReceiptOfGiftBanner");
            this.giftUI.上丈丏丈丄丛丕丛丏 = new System.Action(object:  this, method:  System.Void PGCompany.ClanAutoReceiptOfGiftBanner::丈丙丝东丒一且丘丂());
            this.giftUI.三万万万丁三丒丘丗 = new System.Action(object:  this, method:  System.Void PGCompany.ClanAutoReceiptOfGiftBanner::丟丒丗丞三丒丄丕丁());
            this.giftUI.丗丒上丙丁七七业上 = new System.Action(object:  this, method:  System.Void PGCompany.ClanAutoReceiptOfGiftBanner::丆世东不下东丗丞不());
            this.giftUI.丈且东丑丂且万丒丅(丄丒丞专丐丌东丒业:  this.七丅丈丁丌丘丑且丙.Item[0]);
            this.Show();
            return;
            label_6:
            ClanAutoReceiptOfGiftBanner.<>c.<>9__8_0 = new System.Predicate<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(object:  ClanAutoReceiptOfGiftBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanAutoReceiptOfGiftBanner.<>c::且丑专三三丂与且丕(PGCompany.GiftSystem.丏下丙丂万且一丑丛 业七丐世专丝丂丟丈));
            if(val_2 != null)
            {
                goto label_22;
            }
            
            goto label_22;
        }
        public void U_GiveGifts()
        {
        
        }
        private void 丈丙丝东丒一且丘丂()
        {
            var val_7;
            System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> val_2 = Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘();
            val_7 = null;
            val_7 = null;
            if((ClanAutoReceiptOfGiftBanner.<>c.<>9__10_0) == null)
            {
                goto label_6;
            }
            
            label_16:
            System.Collections.Generic.List<T> val_3 = val_2.FindAll(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__10_0);
            this.七丅丈丁丌丘丑且丙 = val_3;
            if(val_3.Count < 1)
            {
                goto typeof(PGCompany.ClanAutoReceiptOfGiftBanner).__il2cppRuntimeField_208;
            }
            
            this.giftUI.丈且东丑丂且万丒丅(丄丒丞专丐丌东丒业:  this.七丅丈丁丌丘丑且丙.Item[0]);
            return;
            label_6:
            ClanAutoReceiptOfGiftBanner.<>c.<>9__10_0 = new System.Predicate<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(object:  ClanAutoReceiptOfGiftBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanAutoReceiptOfGiftBanner.<>c::丌万业世丂丑丅丏丁(PGCompany.GiftSystem.丏下丙丂万且一丑丛 业七丐世专丝丂丟丈));
            if(val_2 != null)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        private void 丟丒丗丞三丒丄丕丁()
        {
            var val_9;
            System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> val_2 = Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘();
            val_9 = null;
            val_9 = null;
            if((ClanAutoReceiptOfGiftBanner.<>c.<>9__11_0) == null)
            {
                goto label_6;
            }
            
            label_16:
            System.Collections.Generic.List<T> val_3 = val_2.FindAll(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__11_0);
            this.七丅丈丁丌丘丑且丙 = val_3;
            if(val_3.Count < 1)
            {
                goto typeof(PGCompany.ClanAutoReceiptOfGiftBanner).__il2cppRuntimeField_208;
            }
            
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7 = PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世().上丆丂丆上世三与丘(且丌丒丝不丛上三丆:  this.七丅丈丁丌丘丑且丙.Item[0]);
            return;
            label_6:
            ClanAutoReceiptOfGiftBanner.<>c.<>9__11_0 = new System.Predicate<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(object:  ClanAutoReceiptOfGiftBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanAutoReceiptOfGiftBanner.<>c::丏丒丏丐业丟丛业丗(PGCompany.GiftSystem.丏下丙丂万且一丑丛 业七丐世专丝丂丟丈));
            if(val_2 != null)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        private void 丆世东不下东丗丞不()
        {
            var val_6;
            System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> val_2 = Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘();
            val_6 = null;
            if((ClanAutoReceiptOfGiftBanner.<>c.<>9__12_0) == null)
            {
                goto label_6;
            }
            
            label_14:
            System.Collections.Generic.List<T> val_3 = val_2.FindAll(match:  ClanAutoReceiptOfGiftBanner.<>c.<>9__12_0);
            this.七丅丈丁丌丘丑且丙 = val_3;
            if(val_3.Count <= 0)
            {
                goto typeof(PGCompany.ClanAutoReceiptOfGiftBanner).__il2cppRuntimeField_208;
            }
            
            return;
            label_6:
            ClanAutoReceiptOfGiftBanner.<>c.<>9__12_0 = new System.Predicate<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(object:  ClanAutoReceiptOfGiftBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanAutoReceiptOfGiftBanner.<>c::东一一丝丏一丐七丞(PGCompany.GiftSystem.丏下丙丂万且一丑丛 业七丐世专丝丂丟丈));
            if(val_2 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        public override void HideSelf()
        {
            PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世().业丆丕下丛丕丈丐丗();
            this.HideSelf();
        }
        public override void Hide()
        {
            if(this.与丅世与丄丑丌丞东 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.与丅世与丄丑丌丞东.Dispose();
            }
            
            this.Hide();
        }
        public ClanAutoReceiptOfGiftBanner()
        {
            this.东丐万丝三下丐丅丒 = new System.Collections.Generic.List<PGCompany.ClanGiftItemUI>();
        }
    
    }

}
