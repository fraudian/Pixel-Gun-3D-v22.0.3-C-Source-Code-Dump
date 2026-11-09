using UnityEngine;

namespace Rilisoft
{
    internal class UITextureUpdater : MonoBehaviour
    {
        // Fields
        private UIBasicSprite 丒与七丟丒丒丒不丕;
        private bool 丑丄丌不丛丝丞三丌;
        private string _texturePath;
        
        // Properties
        private UIBasicSprite 丅七且东丕万不丒下 { get; }
        
        // Methods
        private UIBasicSprite 专丝一丕丘丄丂丗丛()
        {
            UIBasicSprite val_3;
            if(this.丒与七丟丒丒丒不丕 == 0)
            {
                    this.丒与七丟丒丒丒不丕 = this.GetComponent<UIBasicSprite>();
                return val_3;
            }
            
            val_3 = this.丒与七丟丒丒丒不丕;
            return val_3;
        }
        private void OnEnable()
        {
            this.丑丄丌不丛丝丞三丌 = true;
        }
        private void Update()
        {
            if(this.专丝一丕丘丄丂丗丛() == 0)
            {
                    return;
            }
            
            if(this.专丝一丕丘丄丂丗丛().isVisible != false)
            {
                    if(this.丑丄丌不丛丝丞三丌 == false)
            {
                    return;
            }
            
                if(this.专丝一丕丘丄丂丗丛().isVisible == false)
            {
                    return;
            }
            
                this.丑丄丌不丛丝丞三丌 = false;
                UnityEngine.Texture val_7 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this._texturePath);
                UIBasicSprite val_8 = this.专丝一丕丘丄丂丗丛();
                this = ???;
            }
            else
            {
                    mem2[0] = 1;
            }
        
        }
        public UITextureUpdater()
        {
            this.丑丄丌不丛丝丞三丌 = true;
            this._texturePath = "OfferIcons/decor_big_presidential_1_icon1_big";
        }
    
    }

}
