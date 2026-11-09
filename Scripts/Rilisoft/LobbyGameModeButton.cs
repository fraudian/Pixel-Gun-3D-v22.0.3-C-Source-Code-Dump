using UnityEngine;

namespace Rilisoft
{
    public sealed class LobbyGameModeButton : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _buttonLockedObjects;
        private System.Collections.Generic.List<UIButton> _buttons;
        private System.Collections.Generic.List<UILabel> _levelRequiredLabel;
        public Rilisoft.七丕丟丏三丈一丄世 Mode;
        private UnityEngine.Coroutine 丙丗东丅丂丂丏丗丞;
        
        // Methods
        private void OnEnable()
        {
            if(this.丙丗东丅丂丂丏丗丞 != null)
            {
                    this.StopCoroutine(routine:  this.丙丗东丅丂丂丏丗丞);
                this.丙丗东丅丂丂丏丗丞 = 0;
            }
            
            this.丙丗东丅丂丂丏丗丞 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private void OnDisable()
        {
            if(this.丙丗东丅丂丂丏丗丞 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丙丗东丅丂丂丏丗丞);
            this.丙丗东丅丂丂丏丗丞 = 0;
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyGameModeButton.丕丗东下万丘丘且丌();
        }
        public LobbyGameModeButton()
        {
        
        }
    
    }

}
