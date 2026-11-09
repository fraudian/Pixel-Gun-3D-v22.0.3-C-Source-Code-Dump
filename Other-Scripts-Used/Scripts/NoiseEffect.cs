using UnityEngine;
public class NoiseEffect : MonoBehaviour
{
    // Fields
    public bool monochrome;
    private bool rgbFallback;
    public float grainIntensityMin;
    public float grainIntensityMax;
    public float grainSize;
    public float scratchIntensityMin;
    public float scratchIntensityMax;
    public float scratchFPS;
    public float scratchJitter;
    public UnityEngine.Texture grainTexture;
    public UnityEngine.Texture scratchTexture;
    public UnityEngine.Shader shaderRGB;
    public UnityEngine.Shader shaderYUV;
    private UnityEngine.Material m_MaterialRGB;
    private UnityEngine.Material m_MaterialYUV;
    private float scratchTimeLeft;
    private float scratchX;
    private float scratchY;
    
    // Properties
    protected UnityEngine.Material material { get; }
    
    // Methods
    protected void Start()
    {
        if(UnityEngine.SystemInfo.supportsImageEffects != false)
        {
                if(this.shaderRGB != 0)
        {
                if(this.shaderYUV != 0)
        {
            goto label_7;
        }
        
        }
        
            UnityEngine.Debug.Log(message:  "Noise shaders are not set up! Disabling noise effect.");
        }
        
        label_11:
        this.enabled = false;
        return;
        label_7:
        if(this.shaderRGB.isSupported == false)
        {
            goto label_11;
        }
        
        if(this.shaderYUV.isSupported == true)
        {
                return;
        }
        
        this.rgbFallback = true;
    }
    protected UnityEngine.Material get_material()
    {
        var val_5;
        UnityEngine.Shader val_6;
        val_5 = this;
        if(this.m_MaterialRGB == 0)
        {
                val_6 = this.shaderRGB;
            UnityEngine.Material val_2 = new UnityEngine.Material(shader:  val_6);
            this.m_MaterialRGB = val_2;
            val_2.hideFlags = 61;
        }
        
        if(this.m_MaterialYUV == 0)
        {
                if(this.rgbFallback == true)
        {
                return (UnityEngine.Material)val_5;
        }
        
            val_6 = this.shaderYUV;
            UnityEngine.Material val_4 = new UnityEngine.Material(shader:  val_6);
            this.m_MaterialYUV = val_4;
            val_4.hideFlags = 61;
        }
        
        if(this.rgbFallback == true)
        {
                return (UnityEngine.Material)val_5;
        }
        
        if(this.monochrome == true)
        {
                return (UnityEngine.Material)val_5;
        }
        
        val_5 = 1152921524102693504;
        return (UnityEngine.Material)val_5;
    }
    protected void OnDisable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.m_MaterialRGB)) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.m_MaterialRGB);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_MaterialYUV)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this.m_MaterialYUV);
    }
    private void SanitizeParameters()
    {
        this.grainIntensityMin = UnityEngine.Mathf.Clamp(value:  this.grainIntensityMin, min:  0f, max:  5f);
        this.grainIntensityMax = UnityEngine.Mathf.Clamp(value:  this.grainIntensityMax, min:  0f, max:  5f);
        this.scratchIntensityMin = UnityEngine.Mathf.Clamp(value:  this.scratchIntensityMin, min:  0f, max:  5f);
        this.scratchIntensityMax = UnityEngine.Mathf.Clamp(value:  this.scratchIntensityMax, min:  0f, max:  5f);
        this.scratchFPS = UnityEngine.Mathf.Clamp(value:  this.scratchFPS, min:  1f, max:  30f);
        this.scratchJitter = UnityEngine.Mathf.Clamp(value:  this.scratchJitter, min:  0f, max:  1f);
        this.grainSize = UnityEngine.Mathf.Clamp(value:  this.grainSize, min:  0.1f, max:  50f);
    }
    private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        float val_21;
        this.SanitizeParameters();
        val_21 = this.scratchTimeLeft;
        if(val_21 <= 0f)
        {
                float val_1 = UnityEngine.Random.value;
            val_1 = val_1 + val_1;
            val_1 = val_1 / this.scratchFPS;
            this.scratchTimeLeft = val_1;
            this.scratchX = UnityEngine.Random.value;
            val_21 = this.scratchTimeLeft;
            this.scratchY = UnityEngine.Random.value;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = val_21 - val_4;
        this.scratchTimeLeft = val_4;
        UnityEngine.Material val_5 = this.material;
        val_5.SetTexture(name:  "_GrainTex", value:  this.grainTexture);
        val_5.SetTexture(name:  "_ScratchTex", value:  this.scratchTexture);
        float val_21 = this.grainSize;
        float val_6 = UnityEngine.Random.value;
        float val_7 = UnityEngine.Random.value;
        val_21 = 1f / val_21;
        float val_22 = (float)UnityEngine.Screen.width;
        float val_23 = (float)this.grainTexture;
        val_22 = val_22 / (float)this.grainTexture;
        float val_11 = val_21 * val_22;
        val_23 = val_21 * ((float)UnityEngine.Screen.height / val_23);
        val_5.SetVector(name:  "_GrainOffsetScale", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_16 = UnityEngine.Random.value * this.scratchJitter;
        float val_17 = UnityEngine.Random.value * this.scratchJitter;
        float val_24 = (float)UnityEngine.Screen.width;
        val_16 = this.scratchX + val_16;
        val_17 = this.scratchY + val_17;
        val_24 = val_24 / (float)this.scratchTexture;
        float val_18 = (float)UnityEngine.Screen.height / (float)this.scratchTexture;
        val_5.SetVector(name:  "_ScratchOffsetScale", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_19 = UnityEngine.Random.Range(min:  this.grainIntensityMin, max:  this.grainIntensityMax);
        float val_20 = UnityEngine.Random.Range(min:  this.scratchIntensityMin, max:  this.scratchIntensityMax);
        val_5.SetVector(name:  "_Intensity", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  val_5);
    }
    public NoiseEffect()
    {
        this.monochrome = true;
        this.scratchIntensityMax = 0.25f;
        this.scratchFPS = 10f;
        this.grainIntensityMin = ;
        this.grainIntensityMax = ;
        this.grainSize = 2f;
        this.scratchIntensityMin = 0.05f;
        this.scratchJitter = 0.01f;
    }

}
