using UnityEngine;

namespace Rilisoft
{
    public class 丘上丕丗丘专万丆丁
    {
        // Methods
        public static UnityEngine.Texture2D 丕丑丈丒丄丅丅丝一(UnityEngine.Camera 业丆丆东丂与万丅不, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一, UnityEngine.TextureFormat 世业丄业下丛丞丟下 = 3)
        {
            int val_8;
            var val_9;
            var val_10;
            val_8 = 业与三万七丝不万东;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
            {
                    val_9 = null;
                val_9 = null;
                float val_8 = (float)val_8;
                val_8 = val_8 / IphoneXCameraScaler.不丅七丘丈不丌丝丏;
                val_8 = UnityEngine.Mathf.RoundToInt(f:  val_8);
                float val_9 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
                val_9 = 1f - val_9;
                val_9 = val_9 * (float)丟丌丐丘丆丙丑丑一;
                val_9 = val_9 + 2f;
                val_10 = UnityEngine.Mathf.RoundToInt(f:  val_9);
            }
            else
            {
                    val_10 = 0;
            }
            
            UnityEngine.RenderTexture val_4 = null;
            丟丌丐丘丆丙丑丑一 = 丟丌丐丘丆丙丑丑一 + 0;
            val_4 = new UnityEngine.RenderTexture(width:  val_8, height:  丟丌丐丘丆丙丑丑一, depth:  24);
            业丆丆东丂与万丅不.targetTexture = val_4;
            UnityEngine.Texture2D val_5 = new UnityEngine.Texture2D(width:  val_8, height:  丟丌丐丘丆丙丑丑一, textureFormat:  世业丄业下丛丞丟下, mipChain:  false);
            业丆丆东丂与万丅不.Render();
            UnityEngine.RenderTexture.active = val_4;
            val_5.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
            业丆丆东丂与万丅不.targetTexture = 0;
            UnityEngine.RenderTexture.active = 0;
            if(UnityEngine.Application.isPlaying != true)
            {
                    if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  val_4);
                return val_5;
            }
            
            }
            
            UnityEngine.Object.Destroy(obj:  val_4);
            return val_5;
        }
        public 丘上丕丗丘专万丆丁()
        {
        
        }
    
    }

}
