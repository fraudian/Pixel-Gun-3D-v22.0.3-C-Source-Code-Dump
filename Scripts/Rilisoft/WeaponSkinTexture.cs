using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class WeaponSkinTexture
    {
        // Fields
        private UnityEngine.Texture2D _texture;
        public string Raw;
        public int W;
        public int H;
        public UnityEngine.FilterMode FilterMode;
        public string[] ToObjects;
        public string ShaderPropertyName;
        
        // Properties
        public UnityEngine.Texture2D Texture { get; }
        
        // Methods
        public WeaponSkinTexture(string 丞丕丒专一下丙业上, int 与丘东下丈东丛丂万, int 一丗世三专三万丞丞, string[] 丄专不丂丄且三丛丆)
        {
            this.ToObjects = new string[0];
            this.ShaderPropertyName = "_MainTex";
            this.Raw = 丞丕丒专一下丙业上;
            this.W = 与丘东下丈东丛丂万;
            this.H = 一丗世三专三万丞丞;
            this.ToObjects = 丄专不丂丄且三丛丆;
        }
        public UnityEngine.Texture2D get_Texture()
        {
            if(this._texture != 0)
            {
                    return (UnityEngine.Texture2D)this._texture;
            }
            
            UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  this.W, height:  this.H, textureFormat:  4, mipChain:  false);
            this._texture = val_3;
            bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  val_3, data:  System.Convert.FromBase64String(s:  this.Raw), markNonReadable:  true);
            this._texture.filterMode = this.FilterMode;
            return (UnityEngine.Texture2D)this._texture;
        }
    
    }

}
