using UnityEngine;

namespace Rilisoft
{
    public class BackgroundTextureHandler : MonoBehaviour
    {
        // Fields
        public bool SetupCleanTexture;
        
        // Methods
        private void OnEnable()
        {
            this.丟不丏世丝丕与世丘();
        }
        private void 丟不丏世丝丕与世丘()
        {
            UnityEngine.Texture2D val_9 = this.丑东丐下专丞丕丘世();
            if(val_9 == 0)
            {
                    val_9 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "coinsFon");
            }
            
            UITexture val_4 = this.GetComponent<UITexture>();
            if(val_4 == 0)
            {
                goto label_6;
            }
            
            if(val_4 == null)
            {
                goto label_7;
            }
            
            mem2[0] = 0;
            val_4.width = 254;
            val_4.height = 12;
            goto typeof(UITexture).__il2cppRuntimeField_2E8;
            label_6:
            UnityEngine.Renderer val_6 = this.GetComponent<UnityEngine.Renderer>();
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6.sharedMaterial.SetTexture(name:  "_MainTex", value:  val_9);
            return;
            label_7:
            mem[204] = 0;
            0.width = 254;
            0.height = 12;
            goto typeof(UITexture).__il2cppRuntimeField_2E8;
        }
        private UnityEngine.Texture2D 丑东丐下专丞丕丘世()
        {
            if(this.SetupCleanTexture == false)
            {
                    return Rilisoft.丛丅丘业丏丕下业丏.东丝专世丏丙丈三丕();
            }
            
            return Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂();
        }
        public BackgroundTextureHandler()
        {
        
        }
    
    }

}
