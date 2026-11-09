using UnityEngine;

namespace PGCompany.AuthorizationScene
{
    internal class AccountBlockedWindow : PGBehaviour
    {
        // Fields
        private System.Action 丌东一丅丌丕丕丞丟;
        private System.Action 丗下丕丕丂世丙与不;
        private int 丄与丕丌业丝丌丅三;
        private float 丆丕且丙专东万丄丅;
        private UIButton _startNewGameButton;
        private UILabel _startNewGameButtonLabel;
        
        // Methods
        internal void 丅专下万丕丑丆丅丝(int 丘丐且丅与丑丛丒丄, System.Action 丈丁丁专丙丕不三专, System.Action 七丙丛丅丞下七丂一)
        {
            this.丄与丕丌业丝丌丅三 = 丘丐且丅与丑丛丒丄;
            this.丌东一丅丌丕丕丞丟 = 丈丁丁专丙丕不三专;
            this.丗下丕丕丂世丙与不 = 七丙丛丅丞下七丂一;
        }
        public void U_StartNewGameClicked()
        {
            if(this.丗下丕丕丂世丙与不 == null)
            {
                    return;
            }
            
            this.丗下丕丕丂世丙与不.Invoke();
        }
        public void U_ContactUsClicked()
        {
            if(this.丌东一丅丌丕丕丞丟 == null)
            {
                    return;
            }
            
            this.丌东一丅丌丕丕丞丟.Invoke();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_8;
            UILabel val_9;
            if(PixelTime.丒丙专丟世丟丌丁上() != false)
            {
                    val_8 = PixelTime.丙丅丅业丟丁世丁丗();
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "No server time when see account blocked window");
                val_8 = 0;
            }
            
            if(val_8 < this.丄与丕丌业丝丌丅三)
            {
                    val_9 = this._startNewGameButtonLabel;
                string val_6 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10978"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丄与丕丌业丝丌丅三 - val_8, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            }
            else
            {
                    val_9 = this._startNewGameButtonLabel;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_9, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11684"));
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 - this.丆丕且丙专东万丄丅;
            if((double)val_1 <= 0.8)
            {
                    return;
            }
            
            this.丆丕且丙专东万丄丅 = UnityEngine.Time.realtimeSinceStartup;
            this.丝一丅丆三东丂丞七();
        }
        public AccountBlockedWindow()
        {
        
        }
    
    }

}
