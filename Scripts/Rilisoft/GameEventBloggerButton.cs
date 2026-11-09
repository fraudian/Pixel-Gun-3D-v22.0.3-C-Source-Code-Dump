using UnityEngine;

namespace Rilisoft
{
    internal class GameEventBloggerButton : MonoBehaviour
    {
        // Fields
        private string bName;
        private string bUrl;
        
        // Methods
        private void OnClick()
        {
            string val_10 = 1152921505451360256;
            if(Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上() != 0)
            {
                    Rilisoft.丛且世丐丆上七业丁 val_4 = Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context;
                if((val_4 != null) && (val_4.丟丗一丟丒丄丄丆丂() != true))
            {
                    val_10 = val_4.丁专丗万三上丟三丆();
                if(val_6.BloggerReward != null)
            {
                    if(val_6.BloggerReward.丟丂丞不专丆万丒世() >= 1)
            {
                    val_10 = val_6.BloggerReward.东与三丌丅三丒丏业();
                BankController.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_10, 丌丒丝东丌下丕丁丅:  val_6.BloggerReward.丟丂丞不专丆万丒世(), 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  30, 丟世且丕丂丁万丒万:  0);
                val_4.丘丌不与丌丌不专丒(丙业与丙丗丝不丈东:  true);
            }
            
            }
            
            }
            
            }
            
            Rilisoft.一丟专且三万丞丁丂.丐丈丂丟专与与七丝(且东东世丏丒丑丆丑:  this.bName);
            UnityEngine.Application.OpenURL(url:  this.bUrl);
        }
        public GameEventBloggerButton()
        {
            this.bName = "Bigbst4tz2";
            this.bUrl = "https://www.youtube.com/user/Bigbst4tz2?sub_confirmation=1";
        }
    
    }

}
