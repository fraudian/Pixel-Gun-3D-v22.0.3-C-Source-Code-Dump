using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class UnityARVideo : MonoBehaviour
    {
        // Fields
        public UnityEngine.Material m_ClearMaterial;
        private UnityEngine.Texture2D 丈丟丛丁丕下丄与丆;
        private UnityEngine.Texture2D 丌万丐丗不丙丘上专;
        private float 丆东丈上丁丝业丂丐;
        private UnityEngine.ScreenOrientation 丕丙业丕与丗丛丏且;
        
        // Methods
        public void Start()
        {
            this.丆东丈上丁丝业丂丐 = 1f;
            this.丕丙业丕与丗丛丏且 = 3;
            mem[1152921540754723728] = this;
            mem[1152921540754723736] = System.Void UnityEngine.XR.iOS.UnityARVideo::丝一与世且下丟丄丟(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 业丆丆东丂与万丅不);
            mem[1152921540754723712] = System.Void UnityEngine.XR.iOS.UnityARVideo::丝一与世且下丟丄丟(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 业丆丆东丂与万丅不);
            UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.世上一丆丗丛东丗七(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.三丐丘丟丅丌丏三专());
        }
        private void 丝一与世且下丟丄丟(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 业丆丆东丂与万丅不)
        {
            this.丆东丈上丁丝业丂丐 = 业丆丆东丂与万丅不.丄丄七上上丟丑丝丟.yHeight;
            this.丕丙业丕与丗丛丏且 = 业丆丆东丂与万丅不.丄丄七上上丟丑丝丟.yWidth;
        }
        private void OnDestroy()
        {
            mem[1152921540755054736] = this;
            mem[1152921540755054744] = System.Void UnityEngine.XR.iOS.UnityARVideo::丝一与世且下丟丄丟(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 业丆丆东丂与万丅不);
            mem[1152921540755054720] = System.Void UnityEngine.XR.iOS.UnityARVideo::丝一与世且下丟丄丟(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 业丆丆东丂与万丅不);
            UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丒专丆丂丏丐丞丟世(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.三丐丘丟丅丌丏三专());
        }
        public void OnPreRender()
        {
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            UnityEngine.Material val_21;
            IntPtr val_22;
            float val_23;
            var val_24;
            val_21 = this;
            UnityEngine.XR.iOS.丘东三丐丘丄丈且与 val_3 = ARController.Instance.NativeSession.且丄七一丑丟丑东丅();
            val_22 = val_3.世丏丐丕丗丄丘专丈;
            if((System.IntPtr.op_Equality(value1:  val_3.世丏丐丕丗丄丘专丈, value2:  0)) == true)
            {
                    return;
            }
            
            if((System.IntPtr.op_Equality(value1:  val_3.丟丙丁一世业一丕丏, value2:  0)) == true)
            {
                    return;
            }
            
            UnityEngine.Resolution val_6 = UnityEngine.Screen.currentResolution;
            UnityEngine.Texture2D val_8 = UnityEngine.Texture2D.CreateExternalTexture(width:  val_6.m_Width.GetHashCode(), height:  1788611488, format:  63, mipChain:  false, linear:  false, nativeTex:  val_22);
            this.丈丟丛丁丕下丄与丆 = val_8;
            val_8.filterMode = 1;
            this.丈丟丛丁丕下丄与丆.wrapMode = 0;
            this.丈丟丛丁丕下丄与丆.UpdateExternalTexture(nativeTex:  val_22);
            UnityEngine.Texture2D val_10 = UnityEngine.Texture2D.CreateExternalTexture(width:  val_6.m_Width.GetHashCode(), height:  1788611488, format:  62, mipChain:  false, linear:  false, nativeTex:  val_3.丟丙丁一世业一丕丏);
            this.丌万丐丗不丙丘上专 = val_10;
            val_10.filterMode = 1;
            this.丌万丐丗不丙丘上专.wrapMode = 0;
            this.丌万丐丗不丙丘上专.UpdateExternalTexture(nativeTex:  val_3.丟丙丁一世业一丕丏);
            this.m_ClearMaterial.SetTexture(name:  "_textureY", value:  this.丈丟丛丁丕下丄与丆);
            this.m_ClearMaterial.SetTexture(name:  "_textureCbCr", value:  this.丌万丐丗不丙丘上专);
            if(this.丕丙业丕与丗丛丏且 == 1)
            {
                goto label_13;
            }
            
            if(this.丕丙业丕与丗丛丏且 != 2)
            {
                goto label_14;
            }
            
            val_23 = 90f;
            goto label_15;
            label_13:
            val_23 = -90f;
            label_15:
            val_24 = 1;
            goto label_16;
            label_14:
            val_24 = 0;
            label_16:
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (this.丕丙业丕与丗丛丏且 == 4) ? -180f : 0f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_15 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, q:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, s:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.z});
            this.m_ClearMaterial.SetMatrix(name:  "_TextureRotation", value:  new UnityEngine.Matrix4x4() {m00 = val_18, m10 = val_18, m20 = val_18, m30 = val_18, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_16, m12 = val_16, m22 = val_16, m32 = val_16, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17});
            val_22 = this.m_ClearMaterial;
            val_22.SetFloat(name:  "_texCoordScale", value:  this.丆东丈上丁丝业丂丐);
            val_21 = this.m_ClearMaterial;
            val_21.SetInt(name:  "_isPortrait", value:  0);
        }
        public UnityARVideo()
        {
        
        }
    
    }

}
