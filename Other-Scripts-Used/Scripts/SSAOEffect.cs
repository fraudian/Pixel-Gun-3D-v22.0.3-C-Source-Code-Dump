using UnityEngine;
public class SSAOEffect : MonoBehaviour
{
    // Fields
    public float m_Radius;
    public SSAOEffect.SSAOSamples m_SampleCount;
    public float m_OcclusionIntensity;
    public int m_Blur;
    public int m_Downsampling;
    public float m_OcclusionAttenuation;
    public float m_MinZ;
    public UnityEngine.Shader m_SSAOShader;
    private UnityEngine.Material m_SSAOMaterial;
    public UnityEngine.Texture2D m_RandomTexture;
    private bool m_Supported;
    
    // Methods
    private static UnityEngine.Material CreateMaterial(UnityEngine.Shader shader)
    {
        if((UnityEngine.Object.op_Implicit(exists:  shader)) == false)
        {
                return (UnityEngine.Material)0;
        }
        
        UnityEngine.Material val_2 = null;
        0 = val_2;
        val_2 = new UnityEngine.Material(shader:  shader);
        val_2.hideFlags = 61;
        return (UnityEngine.Material)0;
    }
    private static void DestroyMaterial(UnityEngine.Material mat)
    {
        if((UnityEngine.Object.op_Implicit(exists:  mat)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  mat);
    }
    private void OnDisable()
    {
        SSAOEffect.DestroyMaterial(mat:  this.m_SSAOMaterial);
    }
    private void Start()
    {
        if((UnityEngine.SystemInfo.supportsImageEffects != false) && ((UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  1)) != false))
        {
                this.CreateMaterials();
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SSAOMaterial)) != false)
        {
                if(this.m_SSAOMaterial.passCount == 5)
        {
                this.m_Supported = true;
            return;
        }
        
        }
        
        }
        
        this.m_Supported = false;
        this.enabled = false;
    }
    private void OnEnable()
    {
        var val_5;
        UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
        if(val_1 != null)
        {
                val_5 = val_1.depthTextureMode;
        }
        else
        {
                val_5 = val_1.depthTextureMode;
        }
        
        val_1.depthTextureMode = val_5 | 2;
    }
    private void CreateMaterials()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.m_SSAOMaterial)) == true)
        {
                return;
        }
        
        if(this.m_SSAOShader.isSupported == false)
        {
                return;
        }
        
        UnityEngine.Material val_3 = SSAOEffect.CreateMaterial(shader:  this.m_SSAOShader);
        this.m_SSAOMaterial = val_3;
        val_3.SetTexture(name:  "_RandomTexture", value:  this.m_RandomTexture);
    }
    private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        float val_24;
        UnityEngine.RenderTexture val_25;
        float val_26;
        var val_27;
        float val_28;
        float val_29;
        var val_30;
        if((this.m_Supported == false) || (this.m_SSAOShader.isSupported == false))
        {
            goto label_3;
        }
        
        this.CreateMaterials();
        val_24 = 1f;
        this.m_Downsampling = UnityEngine.Mathf.Clamp(value:  this.m_Downsampling, min:  1, max:  6);
        float val_25 = 0.5f;
        this.m_Radius = UnityEngine.Mathf.Clamp(value:  this.m_Radius, min:  0.05f, max:  val_24);
        this.m_MinZ = UnityEngine.Mathf.Clamp(value:  this.m_MinZ, min:  1E-05f, max:  val_25);
        this.m_OcclusionIntensity = UnityEngine.Mathf.Clamp(value:  this.m_OcclusionIntensity, min:  val_25, max:  4f);
        this.m_OcclusionAttenuation = UnityEngine.Mathf.Clamp(value:  this.m_OcclusionAttenuation, min:  0.2f, max:  2f);
        this.m_Blur = UnityEngine.Mathf.Clamp(value:  this.m_Blur, min:  0, max:  4);
        val_25 = UnityEngine.RenderTexture.GetTemporary(width:  source / this.m_Downsampling, height:  source / this.m_Downsampling, depthBuffer:  0);
        UnityEngine.Camera val_11 = this.GetComponent<UnityEngine.Camera>();
        if(val_11 == null)
        {
            goto label_8;
        }
        
        val_26 = val_11.fieldOfView;
        goto label_9;
        label_3:
        this.enabled = false;
        return;
        label_8:
        val_26 = val_11.fieldOfView;
        label_9:
        float val_24 = 0.01745329f;
        val_24 = val_26 * val_24;
        val_24 = val_24 * val_25;
        val_25 = val_11.farClipPlane * val_24;
        float val_15 = val_11.aspect;
        val_15 = val_25 * val_15;
        UnityEngine.Vector4 val_16 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.m_SSAOMaterial.SetVector(name:  "_FarCorner", value:  new UnityEngine.Vector4() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w});
        val_27 = 0;
        val_28 = val_24;
        if((UnityEngine.Object.op_Implicit(exists:  this.m_RandomTexture)) != false)
        {
                val_27 = public System.Int32 UnityEngine.Texture::get_height();
            val_28 = (float)this.m_RandomTexture.width;
            val_24 = (float)this.m_RandomTexture.height;
        }
        
        float val_26 = (float)val_25;
        float val_27 = (float)val_25;
        val_26 = val_26 / val_28;
        val_27 = val_27 / val_24;
        UnityEngine.Vector4 val_20 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_29 = val_20.x;
        this.m_SSAOMaterial.SetVector(name:  "_NoiseScale", value:  new UnityEngine.Vector4() {x = val_29, y = val_20.y, z = val_20.z, w = val_20.w});
        float val_28 = this.m_OcclusionAttenuation;
        val_28 = 1f / val_28;
        this.m_SSAOMaterial.SetVector(name:  "_Params", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Graphics.Blit(source:  (this.m_Blur > 0) ? 0 : source, dest:  val_25, mat:  this.m_SSAOMaterial, pass:  this.m_SampleCount);
        if(this.m_Blur >= 1)
        {
                UnityEngine.RenderTexture val_22 = UnityEngine.RenderTexture.GetTemporary(width:  source, height:  source, depthBuffer:  0);
            float val_29 = (float)this.m_Blur;
            val_29 = val_29 / (float)source;
            val_30 = "_TexelOffsetScale";
            this.m_SSAOMaterial.SetVector(name:  "_TexelOffsetScale", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.m_SSAOMaterial.SetTexture(name:  "_SSAO", value:  val_25);
            UnityEngine.Graphics.Blit(source:  0, dest:  val_22, mat:  this.m_SSAOMaterial, pass:  3);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_25);
            val_29 = this.m_Blur;
            val_25 = UnityEngine.RenderTexture.GetTemporary(width:  source, height:  source, depthBuffer:  0);
            float val_30 = (float)source;
            val_30 = (float)val_29 / val_30;
            this.m_SSAOMaterial.SetVector(name:  "_TexelOffsetScale", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.m_SSAOMaterial.SetTexture(name:  "_SSAO", value:  val_22);
            UnityEngine.Graphics.Blit(source:  source, dest:  val_25, mat:  this.m_SSAOMaterial, pass:  3);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_22);
        }
        
        this.m_SSAOMaterial.SetTexture(name:  "_SSAO", value:  val_25);
        UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.m_SSAOMaterial, pass:  4);
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_25);
    }
    public SSAOEffect()
    {
        this.m_Radius = 0.4f;
        this.m_SampleCount = 1;
        this.m_OcclusionIntensity = 1.5f;
        this.m_Blur = 2;
        this.m_Downsampling = 2;
        this.m_OcclusionAttenuation = 1f;
        this.m_MinZ = 0.01f;
    }

}
