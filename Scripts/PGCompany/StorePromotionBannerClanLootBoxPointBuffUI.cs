using UnityEngine;

namespace PGCompany
{
    internal sealed class StorePromotionBannerClanLootBoxPointBuffUI : StorePromotionBannerDefaultUI
    {
        // Fields
        private static System.Action 丄丏丅丛丕丛丈专丂;
        
        // Methods
        internal static void 丌不三丈三丙不丟与(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.StorePromotionBannerClanLootBoxPointBuffUI.丄丏丅丛丕丛丈专丂, b:  丙业与丙丗丝不丈东);
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
        internal static void 丁丌丅且丈丏丙世丕(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.StorePromotionBannerClanLootBoxPointBuffUI.丄丏丅丛丕丛丈专丂, value:  丙业与丙丗丝不丈东);
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
        protected override void 丘专上丈世丟上专丒()
        {
            this.丁丅丗丙且丛下东专();
        }
        protected override void 丞丁丅七丏丐东丝东()
        {
            this.丁丅丗丙且丛下东专();
            if(PGCompany.StorePromotionBannerClanLootBoxPointBuffUI.丄丏丅丛丕丛丈专丂 == null)
            {
                    return;
            }
            
            PGCompany.StorePromotionBannerClanLootBoxPointBuffUI.丄丏丅丛丕丛丈专丂.Invoke();
        }
        private void 丁丅丗丙且丛下东专()
        {
            var val_2 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丘丁丝七丅专丏与(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.不丗丄丗七世丞世丕, 丐丅一丘丟丄丑三丏:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public StorePromotionBannerClanLootBoxPointBuffUI()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
