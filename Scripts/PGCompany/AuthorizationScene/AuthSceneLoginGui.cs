using UnityEngine;

namespace PGCompany.AuthorizationScene
{
    public sealed class AuthSceneLoginGui : PGBehaviour
    {
        // Fields
        internal static string 专业下三业丕丑丙丙;
        private System.Action 丄东丄丅下三丐丆丒;
        private System.Action 且丕丐丒丗丙下丝上;
        private bool 丐丑丑一丝丛丟丙丗;
        private UITexture _gameCenterTexture;
        private UILabel _playerSocialName;
        
        // Methods
        private void OnApplicationPause(bool 世下丐丌一丗一丞丌)
        {
            if(世下丐丌一丗一丞丌 == true)
            {
                    return;
            }
            
            this.丐丑丑一丝丛丟丙丗 = false;
            if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == false)
            {
                    return;
            }
            
            this.丅丄丟丈丂三下不专();
        }
        internal void 下与丞三丅丛丄七丕(System.Action 丆丙丌东三且丝一丞, System.Action 七丒丏七丆专丙丂丄)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
            上丞丑上丙丈丄丗丐.且丕丅丕丝丛丂与丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthSceneLoginGui::丅世丂丂丂丁业丛丕()));
            上丞丑上丙丈丄丗丐.丐世丂丆丘一与丏世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthSceneLoginGui::丄丄丅上下丗且丗丏()));
            this.丄东丄丅下三丐丆丒 = 丆丙丌东三且丝一丞;
            this.且丕丐丒丗丙下丝上 = 七丒丏七丆专丙丂丄;
            this.丐丑丑一丝丛丟丙丗 = false;
        }
        public void U_Guest()
        {
            if(this.丐丑丑一丝丛丟丙丗 == true)
            {
                    return;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丙与不丞三丑丑业丏(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且丙七丂万丁丙丕一:  "guest", 世与丝丒业丗丈丅丟:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
            if(this.丄东丄丅下三丐丆丒 != null)
            {
                    this.丄东丄丅下三丐丆丒.Invoke();
            }
            
            this.丐丑丑一丝丛丟丙丗 = true;
        }
        public void U_Login()
        {
            if(this.丐丑丑一丝丛丟丙丗 == true)
            {
                    return;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丙与不丞三丑丑业丏(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且丙七丂万丁丙丕一:  "not guest", 世与丝丒业丗丈丅丟:  new System.Nullable<System.Int32>() {HasValue = false});
            this.丏七丗丄丝丁丕丄丆();
            this.丐丑丑一丝丛丟丙丗 = true;
        }
        private void 丏七丗丄丝丁丕丄丆()
        {
            var val_5;
            if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == false)
            {
                goto label_3;
            }
            
            label_11:
            this.丅丄丟丈丂三下不专();
            return;
            label_3:
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_4;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
            {
                goto label_7;
            }
            
            val_5 = null;
            goto label_10;
            label_4:
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                goto label_11;
            }
            
            val_5 = null;
            label_10:
            上丞丑上丙丈丄丗丐.丛丗上丝业下不丈丟();
            return;
            label_7:
            上丞丑上丙丈丄丗丐.丘丙丛东丁与丒七上();
        }
        private void 丅世丂丂丂丁业丛丕()
        {
            上丞丑上丙丈丄丗丐.不丄一丌丝丞丘不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthSceneLoginGui::丅世丂丂丂丁业丛丕()));
            this.丅丄丟丈丂三下不专();
        }
        private void 丄丄丅上下丗且丗丏()
        {
            this.丐丑丑一丝丛丟丙丗 = false;
        }
        private void 丅丄丟丈丂三下不专()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
            if(this.且丕丐丒丗丙下丝上 == null)
            {
                    return;
            }
            
            this.且丕丐丒丗丙下丝上.Invoke();
        }
        private void OnDisable()
        {
            上丞丑上丙丈丄丗丐.不丄一丌丝丞丘不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthSceneLoginGui::丅世丂丂丂丁业丛丕()));
            上丞丑上丙丈丄丗丐.三丘丘万世丂专丁丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthSceneLoginGui::丄丄丅上下丗且丗丏()));
        }
        public AuthSceneLoginGui()
        {
        
        }
        private static AuthSceneLoginGui()
        {
            PGCompany.AuthorizationScene.AuthSceneLoginGui.专业下三业丕丑丙丙 = "NguiWindows/LoginView/LogIn_View";
        }
    
    }

}
