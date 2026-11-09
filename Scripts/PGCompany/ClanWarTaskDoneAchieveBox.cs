using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarTaskDoneAchieveBox : AchieveBox
    {
        // Fields
        private UILabel titleLabel;
        private UILabel idLabel;
        private UITexture statusTexture;
        private UILabel statusLabel;
        private UnityEngine.Texture statusTextureSuccess;
        private UnityEngine.Texture statusTextureFailed;
        
        // Methods
        internal void 三丆丐与丛一丈不丕(string 丞丅上丏丂且下丅与)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.idLabel, 丕丗丘丑丛与丑业丒:  丞丅上丏丂且下丅与);
        }
        internal void 丒一丝与丏丝万丘且(string 丕丗丘丑丛与丑业丒)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        }
        internal void 一不与丂丞丛丁丝丐(bool 丐万丗丒下七丟丁三)
        {
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.statusTexture, 与万丆丛丒万丝丙丑:  (丐万丗丒下七丟丁三 != true) ? this.statusTextureSuccess : this.statusTextureFailed);
            if(丐万丗丒下七丟丁三 != false)
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.green;
            }
            else
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.white;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.statusTexture, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            if(丐万丗丒下七丟丁三 != false)
            {
                    UnityEngine.Color val_4 = UnityEngine.Color.green;
            }
            else
            {
                    UnityEngine.Color val_5 = UnityEngine.Color.red;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.statusLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        }
        public ClanWarTaskDoneAchieveBox()
        {
        
        }
    
    }

}
