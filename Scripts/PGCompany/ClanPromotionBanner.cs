using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanPromotionBanner : BannerWindow
    {
        // Fields
        private UnityEngine.GameObject _container;
        private PGCompany.东丑丆丗丏丐丟下丄 丂丅七与丘丞丟万丕;
        private UnityEngine.GameObject 丛丅上丑与东丐丏丂;
        
        // Methods
        internal static bool 丕世一与业丅万专丑()
        {
            if(Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐() == false)
            {
                    return false;
            }
            
            return PGCompany.上三世丝丕专丂丟丌.丒丏丕七世丞丞且丞();
        }
        public override void Show()
        {
            object val_23;
            int val_24;
            PGCompany.东丑丆丗丏丐丟下丄 val_25;
            UnityEngine.Object val_26;
            val_23 = this;
            val_24 = 0;
            this.Show();
            this.丂丅七与丘丞丟万丕 = 0;
            if(PGCompany.上三世丝丕专丂丟丌.丒丏丕七世丞丞且丞() == false)
            {
                goto label_3;
            }
            
            val_25 = PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世();
            val_24 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_lootbox_point_buff").业东丅东丌上丗丑不();
            PGCompany.东丑丆丗丏丐丟下丄 val_5 = val_25.丒世丒一不丝丑且业(丞世不丒下上上丝丑:  val_24);
            this.丂丅七与丘丞丟万丕 = val_5;
            if(val_5 == null)
            {
                goto label_21;
            }
            
            PGCompany.StorePromotionConfig val_6 = val_5.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_7 = val_6.Settings;
            val_7.BannerPrefabName = "StorePromotion/SPClanLootBoxPointBuffBanner";
            val_25 = this.丂丅七与丘丞丟万丕;
            val_24 = val_6;
            val_25.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_24);
            label_3:
            if(this.丂丅七与丘丞丟万丕 == null)
            {
                goto label_21;
            }
            
            UnityEngine.GameObject val_9 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丂丅七与丘丞丟万丕.丙丈丂三丁一丙丄丝());
            val_24 = 0;
            if(val_9 == val_24)
            {
                goto label_21;
            }
            
            val_25 = this._container.transform;
            UnityEngine.GameObject val_12 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_9, 丈东丘丏与丌东东下:  val_25, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_24 = 0;
            if(val_12 == val_24)
            {
                goto label_21;
            }
            
            val_26 = val_12.GetComponent<PGCompany.StorePromotionBannerUIAbstract>();
            val_24 = 0;
            if(val_26 != val_24)
            {
                goto label_25;
            }
            
            label_21:
            val_26 = ???;
            val_23 = ???;
            goto typeof(PGCompany.ClanPromotionBanner).__il2cppRuntimeField_1D8;
            label_25:
            val_26.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  val_23 + 304);
            val_26.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionBannerUIAbstract>(object:  val_23, method:  System.Void PGCompany.ClanPromotionBanner::丛丄业丘不丆丄三丞(PGCompany.StorePromotionBannerUIAbstract 丘上丐一七东丟丁丁)));
        }
        private void 丛丄业丘不丆丄三丞(PGCompany.StorePromotionBannerUIAbstract 丘上丐一七东丟丁丁)
        {
            丘上丐一七东丟丁丁.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionBannerUIAbstract>(object:  this, method:  System.Void PGCompany.ClanPromotionBanner::丛丄业丘不丆丄三丞(PGCompany.StorePromotionBannerUIAbstract 丘上丐一七东丟丁丁)));
            goto typeof(PGCompany.ClanPromotionBanner).__il2cppRuntimeField_1D8;
        }
        public override void Hide()
        {
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丛丅上丑与东丐丏丂);
            this.Hide();
        }
        public ClanPromotionBanner()
        {
        
        }
    
    }

}
