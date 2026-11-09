using UnityEngine;

namespace ShaderControl
{
    public class Effect : MonoBehaviour
    {
        // Fields
        private UnityEngine.Material 世丑丘丘丂专丅丆与;
        private string[] 丙丈丂丕世下三七丂;
        
        // Methods
        private void Start()
        {
            this.世丑丘丘丂专丅丆与 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "ChromaScreen");
        }
        private void OnRenderImage(UnityEngine.RenderTexture 丑东与丅丐丅丂丞业, UnityEngine.RenderTexture 丁丆丈丂上丙丈丙万)
        {
            this.世丑丘丘丂专丅丆与.shaderKeywords = this.丙丈丂丕世下三七丂;
            UnityEngine.Graphics.Blit(source:  丑东与丅丐丅丂丞业, dest:  丁丆丈丂上丙丈丙万, mat:  this.世丑丘丘丂专丅丆与);
        }
        public Effect()
        {
            string[] val_1 = new string[3];
            val_1[0] = "ENABLE_RED_CHANNEL";
            val_1[1] = "ENABLE_GREEN_CHANNEL";
            val_1[2] = "ENABLE_BLUE_CHANNEL";
            this.丙丈丂丕世下三七丂 = val_1;
        }
    
    }

}
