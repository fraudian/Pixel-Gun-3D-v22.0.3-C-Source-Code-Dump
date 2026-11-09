using UnityEngine;

namespace Rilisoft
{
    internal class LobbyMiniGamesButton : MonoBehaviour
    {
        // Fields
        private UIButton button;
        private UnityEngine.GameObject lockedState;
        private UnityEngine.GameObject UnlockedState;
        private static string 丟丝丐专丏一丝丅七;
        private UISprite _newModesIndicatorSprite;
        
        // Methods
        internal static void 不丌丁丅丗丘丈丌专()
        {
            null = null;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  Rilisoft.LobbyMiniGamesButton.丟丝丐专丏一丝丅七, 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private void LateUpdate()
        {
            if(this.lockedState != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  (~this.button) & 1);
            }
            
            if(this.UnlockedState == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.UnlockedState, 丏业丟一东丂东丘丛:  this.button & 1);
        }
        private void OnEnable()
        {
            var val_4 = null;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newModesIndicatorSprite.gameObject, 丏业丟一东丂东丘丛:  ((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  Rilisoft.LobbyMiniGamesButton.丟丝丐专丏一丝丅七, 丞丌丑丛上丕丙丕下:  0)) == 0) ? 1 : 0);
        }
        public LobbyMiniGamesButton()
        {
        
        }
        private static LobbyMiniGamesButton()
        {
            Rilisoft.LobbyMiniGamesButton.丟丝丐专丏一丝丅七 = "LOBBY_MINI_GAME_NEW_CAMPAIGN";
        }
    
    }

}
