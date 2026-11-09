using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarStartEndAchieveBox : AchieveBox
    {
        // Fields
        private UILabel titleLabel;
        private UITexture statusTexture;
        private const string 上丟七丌丐丅丏丞专 = "Key_8197";
        private const string 丟丕丘上丆丆业一下 = "Key_8198";
        private const string 世七与丘下丛丆东丆 = "OfferMiniIcons/CwStart";
        private const string 世业专上丏世丆丁三 = "OfferMiniIcons/CwFinish";
        
        // Methods
        internal void 丑七丂丌世与七丏与(bool 不且东三三丐世下丝)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (不且东三三丐世下丝 != true) ? "Key_8197" : "Key_8198"));
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.statusTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  (不且东三三丐世下丝 != true) ? "OfferMiniIcons/CwStart" : "OfferMiniIcons/CwFinish"));
        }
        public void GoToClanLobby()
        {
            null = null;
            MainMenuController.丄丞丁丈与业上丞丟.HandleClansClickedCore(三丂东专丕专业丏万:  false);
        }
        public ClanWarStartEndAchieveBox()
        {
        
        }
    
    }

}
