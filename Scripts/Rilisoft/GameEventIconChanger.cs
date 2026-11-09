using UnityEngine;

namespace Rilisoft
{
    internal class GameEventIconChanger : MonoBehaviour
    {
        // Fields
        private int _textureGrade;
        
        // Methods
        private void OnEnable()
        {
            int val_14 = this;
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业() == null)
            {
                    return;
            }
            
            if((this.GetComponent<UIBasicSprite>()) == 0)
            {
                    return;
            }
            
            val_14 = this._textureGrade;
            string val_7 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  val_14);
            if(val_7 == null)
            {
                    return;
            }
            
            UnityEngine.Texture val_8 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_7);
            val_14 = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        public GameEventIconChanger()
        {
            this._textureGrade = 1;
        }
    
    }

}
