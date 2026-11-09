using UnityEngine;

namespace PGCompany.AuthorizationScene
{
    internal class AfterBanSceneController : PGBehaviour
    {
        // Fields
        private UITexture _background;
        private UnityEngine.Texture _defaultBackground;
        private const string 丕三业丘专丟丂上一 = "skip-account-blocked-window-and-unban-automatically";
        private const string 丛丐专东业下丕丁上 = "banned-id";
        private const string 丈七三丌丟东丛不丙 = "banned-hash";
        
        // Methods
        private void Awake()
        {
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
            {
                goto label_2;
            }
            
            if(Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂() == 0)
            {
                goto label_7;
            }
            
            UnityEngine.Texture2D val_5 = Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂();
            goto label_10;
            label_2:
            UnityEngine.Texture val_7 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Switcher.丌三丟丈东丑七丑上(丑丅世丐丒丏丐三丅:  3));
            label_10:
            if(this._background != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            ActivityIndicator.丞丂一丝三丄专丆一(丝丘专世丏三丝下丐:  0);
            this.丄丈一与丌丞丞丛万();
            return;
            label_7:
            if(this._background != null)
            {
                goto label_16;
            }
            
            goto label_17;
        }
        private void 丄丈一与丌丞丞丛万()
        {
            int val_8;
            int val_9;
            Progress.七七世万专丕丁上业.丌丄且与专一七丗丏();
            Rilisoft.KeychainCleaner.世业丒万丘丆专丘丐();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "AccountCreated", 下下丏一丙不丘丌丞:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丁世下丌丒且七不丈());
            业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌且上三丅万丗丐丄());
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "skip-account-blocked-window-and-unban-automatically", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_8 = 丏下三丗一不专丞丝.丒丁丐上丂丛丝三三();
            if(val_8 == null)
            {
                    val_8 = System.String.alignConst;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "banned-id", 下下丏一丙不丘丌丞:  val_8);
            val_9 = 丏下三丗一不专丞丝.丘专丙丑世下丌丕下();
            if(val_9 == null)
            {
                    val_9 = System.String.alignConst;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "banned-hash", 下下丏一丙不丘丌丞:  val_9);
        }
        internal static bool 丒一丅丄不丒专丅丅()
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "skip-account-blocked-window-and-unban-automatically", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            return (bool)((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "skip-account-blocked-window-and-unban-automatically", 丞丌丑丛上丕丙丕下:  0)) == 1) ? 1 : 0;
        }
        internal static string 不东丁不七丕丗丗业()
        {
            return 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "banned-id", 丞丌丑丛上丕丙丕下:  0);
        }
        internal static string 不丝丂丈丐东丛丗上()
        {
            return 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "banned-hash", 丞丌丑丛上丕丙丕下:  0);
        }
        public AfterBanSceneController()
        {
        
        }
    
    }

}
