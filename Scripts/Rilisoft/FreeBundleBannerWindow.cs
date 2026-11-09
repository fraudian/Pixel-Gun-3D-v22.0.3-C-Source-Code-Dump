using UnityEngine;

namespace Rilisoft
{
    public class FreeBundleBannerWindow : BannerWindow
    {
        // Fields
        private static Rilisoft.丅丟丒丟丑丈丒三丆 且下丘丈下世万丟下;
        
        // Properties
        internal static bool 丕世一与业丅万专丑 { get; }
        
        // Methods
        internal static bool 丌七丘七丗下丐七丞()
        {
            return false;
        }
        public override void Hide()
        {
            var val_6;
            MainMenuController val_7;
            var val_8;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "bundle_winter");
            if(val_2 != null)
            {
                    Rilisoft.FreeBundleBannerWindow.且下丘丈下世万丟下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  "bundle_winter");
                System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_4 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_2, 与且专丏丅世丐丐丑:  true, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
            }
            
            this.Hide();
            val_6 = null;
            val_6 = null;
            val_7 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_7 = MainMenuController.丄丞丁丈与业上丞丟;
            val_7.丄丒丂丈丁丂且丟丒(丁丛七丞丑一丌丞丆:  new System.Nullable<Rilisoft.LobbyItemGroupType>() {HasValue = false}, 世万丐专世丕业丟东:  "bundle_winter");
        }
        public FreeBundleBannerWindow()
        {
        
        }
    
    }

}
