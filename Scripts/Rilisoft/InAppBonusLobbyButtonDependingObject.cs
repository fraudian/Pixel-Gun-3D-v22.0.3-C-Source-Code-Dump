using UnityEngine;

namespace Rilisoft
{
    internal class InAppBonusLobbyButtonDependingObject : MonoBehaviour
    {
        // Fields
        public Rilisoft.丛且世丐丆上七业丁 gameEvent;
        private UISprite _backgroundSprite;
        private UIBasicSprite _texture;
        private UITweener 丞上丈业丂与丛下丂;
        
        // Properties
        public UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        public UISprite 丈丌丛万丑七丘丛丈 { get; }
        public UITweener 丕与丘丒上不丙丞专 { get; }
        
        // Methods
        public UIBasicSprite get_Texture()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        public UISprite get_BackgroundSprite()
        {
            return (UISprite)this._backgroundSprite;
        }
        public UITweener get_TweenRotationScript()
        {
            UITweener val_4;
            if(this.丞上丈业丂与丛下丂 == 0)
            {
                    this.丞上丈业丂与丛下丂 = this.Texture.GetComponent<TweenRotation>();
                return val_4;
            }
            
            val_4 = this.丞上丈业丂与丛下丂;
            return val_4;
        }
        public InAppBonusLobbyButtonDependingObject()
        {
        
        }
    
    }

}
