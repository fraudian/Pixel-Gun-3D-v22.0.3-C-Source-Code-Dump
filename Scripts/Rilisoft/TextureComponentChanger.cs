using UnityEngine;

namespace Rilisoft
{
    internal class TextureComponentChanger : MonoBehaviour
    {
        // Methods
        private void Start()
        {
            UITexture val_1 = this.GetComponent<UITexture>();
            if(val_1 == 0)
            {
                    return;
            }
            
            this.enabled = false;
            UITextureMasked val_4 = this.gameObject.AddComponent<UITextureMasked>();
            val_4.width = val_1.width;
            val_4.height = val_1.height;
            val_4.depth = val_1.depth;
            UnityEngine.Object.Destroy(obj:  val_1);
            UnityEngine.Object.Destroy(obj:  this);
        }
        public TextureComponentChanger()
        {
        
        }
    
    }

}
