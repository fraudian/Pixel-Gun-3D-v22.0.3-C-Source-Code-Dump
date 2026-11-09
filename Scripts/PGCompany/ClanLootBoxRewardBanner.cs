using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanLootBoxRewardBanner : BannerWindow
    {
        // Fields
        private PGCompany.ClanLootBoxRewardUI _clanLootBoxRewardUI;
        
        // Methods
        public override void Show()
        {
            PGCompany.七东万三万丒丏一丁 val_2;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5;
            this.Show();
            PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
            if(val_2 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanLootBoxRewardUI, 丏业丟一东丂东丘丛:  true);
                PGCompany.丆下丐丁丏世丈上丟 val_3 = this.丑丐丙丄丅世世丑丒();
                PGCompany.丆下丐丁丏世丈上丟 val_4 = this.丑丐丙丄丅世世丑丒();
                this._clanLootBoxRewardUI.丈且东丑丂且万丒丅(丒丁且东世一丝业丆:  val_2, 上业丟世三与七七三:  val_5);
                this._clanLootBoxRewardUI.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionRewardUIAbstract>(object:  this, method:  System.Void PGCompany.ClanLootBoxRewardBanner::丌丒七丒丞丁丌丞下(PGCompany.StorePromotionRewardUIAbstract 万且万且丑丗且丌丆)));
                return;
            }
            
            this.HideSelf();
        }
        private void 丌丒七丒丞丁丌丞下(PGCompany.StorePromotionRewardUIAbstract 万且万且丑丗且丌丆)
        {
            this._clanLootBoxRewardUI.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionRewardUIAbstract>(object:  this, method:  System.Void PGCompany.ClanLootBoxRewardBanner::丌丒七丒丞丁丌丞下(PGCompany.StorePromotionRewardUIAbstract 万且万且丑丗且丌丆)));
            this.HideSelf();
        }
        public void U_Hide()
        {
            this.HideSelf();
        }
        public ClanLootBoxRewardBanner()
        {
        
        }
    
    }

}
