using UnityEngine;

namespace Rilisoft
{
    public class PetHighlightComponent : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color 且丌东丞万业与丏丒;
        private UnityEngine.Texture 万丕丆不丘丕丛三丌;
        private UnityEngine.Coroutine 不七不丙三丕丒丑七;
        private bool 丂丂业上丂丟业丝丗;
        private UnityEngine.Texture2D _damageTexture;
        private UnityEngine.Coroutine 上丙东丑丂业三三七;
        private bool 丙丅世万丂专世不丌;
        private UnityEngine.Color _immortalColor;
        private UnityEngine.Renderer _rend;
        private string _shaderColorProp;
        private float _splashTime;
        
        // Methods
        private void Awake()
        {
            this.万丕丆不丘丕丛三丌 = this._rend.material.mainTexture;
            if((this._rend.material.HasProperty(name:  this._shaderColorProp)) != false)
            {
                    UnityEngine.Color val_6 = this._rend.material.GetColor(name:  this._shaderColorProp);
                this.且丌东丞万业与丏丒 = val_6;
                mem[1152921543369130364] = val_6.g;
                mem[1152921543369130368] = val_6.b;
                mem[1152921543369130372] = val_6.a;
                return;
            }
            
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "shader property \'{0}\' not found", arg0:  this._shaderColorProp));
        }
        private void OnDisable()
        {
            this.丂丅万世丟上一三下();
            this.且专万丐丗三世丅丂();
        }
        internal void 丏丝丄不丝丆三丏丟()
        {
            if(this.不七不丙三丕丒丑七 != null)
            {
                    this.StopCoroutine(routine:  this.且丗业七丐丞上丕丗());
                this.不七不丙三丕丒丑七 = 0;
            }
            
            this.不七不丙三丕丒丑七 = this.StartCoroutine(routine:  this.且丗业七丐丞上丕丗());
        }
        private void 丂丅万世丟上一三下()
        {
            this.丂丂业上丂丟业丝丗 = false;
            this._rend.material.mainTexture = this.万丕丆不丘丕丛三丌;
        }
        private System.Collections.IEnumerator 且丗业七丐丞上丕丗()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PetHighlightComponent.三丝丗丌丑世丆业丁();
        }
        internal void 三万专丕丟专丗丝丁(float 丂三丟丂丈丐丆丗丟)
        {
            if(this.丙丅世万丂专世不丌 == true)
            {
                    return;
            }
            
            this.上丙东丑丂业三三七 = this.StartCoroutine(routine:  this.丙七丑丙丟丐且丐专());
            this.丙丅世万丂专世不丌 = true;
        }
        internal void 且专万丐丗三世丅丂()
        {
            if(this.上丙东丑丂业三三七 != null)
            {
                    this.StopCoroutine(routine:  this.上丙东丑丂业三三七);
                this.上丙东丑丂业三三七 = 0;
            }
            
            this.丙丅世万丂专世不丌 = false;
            this.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.且丌东丞万业与丏丒});
        }
        private System.Collections.IEnumerator 丙七丑丙丟丐且丐专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PetHighlightComponent.不丆丙丗丈丁不世上();
        }
        private void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
        {
            if((this._rend.material.HasProperty(name:  this._shaderColorProp)) != false)
            {
                    this._rend.material.SetColor(name:  this._shaderColorProp, value:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
                return;
            }
            
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "shader property \'{0}\' not found", arg0:  this._shaderColorProp));
        }
        public PetHighlightComponent()
        {
            this._splashTime = 0.3f;
            this._shaderColorProp = "_ColorRili";
        }
    
    }

}
