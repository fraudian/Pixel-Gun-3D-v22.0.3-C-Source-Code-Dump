using UnityEngine;

namespace Rilisoft
{
    public abstract class InAppBonusLobbyButtonAbstractIconsGrid : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 七丁丗世业不丐丅业;
        
        // Methods
        public abstract void ShowCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowWeaponIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowRoyaleIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowPartsIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowEventCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowBattlePassCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowWearIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowLobbyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowPetIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowOfferPackIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowGadgetsIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowTryGunIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowMixIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowLeprechauntIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        public abstract void ShowVipIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄); // 0
        protected UnityEngine.Texture 丐丝丛与丆丂丐丆专(string 丛丄业丕且丗下一万)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            if((Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.ContainsKey(key:  丛丄业丕且丗下一万)) != false)
            {
                    val_6 = null;
                val_6 = null;
                if(Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.Item[丛丄业丕且丗下一万] != 0)
            {
                    val_7 = null;
                val_7 = null;
                if(Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业 != null)
            {
                    return Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.Item[丛丄业丕且丗下一万];
            }
            
                return Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.Item[丛丄业丕且丗下一万];
            }
            
            }
            
            val_8 = null;
            val_8 = null;
            UnityEngine.Texture val_4 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丛丄业丕且丗下一万);
            Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.set_Item(key:  丛丄业丕且丗下一万, value:  val_4);
            return val_4;
        }
        protected UnityEngine.Texture 丏东东上一东丈且丈(string 丕丁下丌不万丅丞丛)
        {
            var val_7;
            var val_8;
            var val_9;
            UnityEngine.Texture val_10;
            var val_11;
            val_7 = null;
            val_7 = null;
            if((Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.ContainsKey(key:  丕丁下丌不万丅丞丛)) != false)
            {
                    val_8 = null;
                val_8 = null;
                if(Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.Item[丕丁下丌不万丅丞丛] != 0)
            {
                    val_9 = null;
                val_9 = null;
                val_10 = Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.Item[丕丁下丌不万丅丞丛];
                return val_10;
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            val_10 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业.set_Item(key:  丕丁下丌不万丅丞丛, value:  val_10);
            return val_10;
        }
        protected InAppBonusLobbyButtonAbstractIconsGrid()
        {
        
        }
        private static InAppBonusLobbyButtonAbstractIconsGrid()
        {
            Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid.七丁丗世业不丐丅业 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        }
    
    }

}
