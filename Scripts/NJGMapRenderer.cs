using UnityEngine;
public class NJGMapRenderer : MonoBehaviour
{
    // Fields
    private static NJGMapRenderer 丄丈丂丅上专万丞丏;
    private UnityEngine.Vector2 丝丈丏丘丟业丘丏丌;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private bool 且丟丝丁与丈与专丐;
    private bool 七丟丑丛丗世丞与丄;
    private bool 世丗下丞丟丗丙丅丁;
    private bool 丄丛丑丛不三一丄丛;
    private bool 丌丌丞丒丑七七万丈;
    private float 丈丈丏且丂丅东上丗;
    private NJG.NJGMapBase 丞丁丑丏丄丏七丂不;
    
    // Properties
    public static NJGMapRenderer 丄丘七三上丕世丞业 { get; }
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    
    // Methods
    public static NJGMapRenderer get_instance()
    {
        NJGMapRenderer val_12;
        var val_13;
        val_12 = NJGMapRenderer.丄丈丂丅上专万丞丏;
        if(val_12 != 0)
        {
                return (NJGMapRenderer)NJGMapRenderer.丄丈丂丅上专万丞丏;
        }
        
        val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  val_12);
        val_13 = 0;
        NJGMapRenderer.丄丈丂丅上专万丞丏 = ;
        if(NJGMapRenderer.丄丈丂丅上专万丞丏 != 0)
        {
                return (NJGMapRenderer)NJGMapRenderer.丄丈丂丅上专万丞丏;
        }
        
        UnityEngine.GameObject val_6 = null;
        val_12 = val_6;
        val_6 = new UnityEngine.GameObject(name:  "_NJGMapRenderer");
        val_6.transform.parent = NJG.NJGMapBase.instance.transform;
        int val_10 = UnityEngine.LayerMask.NameToLayer(layerName:  "TransparentFX");
        if(val_12 != null)
        {
                val_6.layer = val_10;
        }
        else
        {
                val_6.layer = val_10;
        }
        
        NJGMapRenderer.丄丈丂丅上专万丞丏 = val_6.AddComponent<NJGMapRenderer>();
        return (NJGMapRenderer)NJGMapRenderer.丄丈丂丅上专万丞丏;
    }
    public UnityEngine.Transform get_cachedTransform()
    {
        UnityEngine.Transform val_3;
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                this.丐一丗丛丕世丘东丁 = this.transform;
            return val_3;
        }
        
        val_3 = this.丐一丗丛丕世丘东丁;
        return val_3;
    }
    private void Awake()
    {
        NJG.NJGMapBase val_1 = NJG.NJGMapBase.instance;
        this.丞丁丑丏丄丏七丂不 = val_1;
        if(val_1 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Can\'t render map photo. NJGMiniMap instance not found.");
            丁丒丐丂万三丌万业.Destroy(万且万且丑丗且丌丆:  this.gameObject);
            return;
        }
        
        if((this.gameObject.GetComponent<UnityEngine.Camera>()) == 0)
        {
                UnityEngine.Camera val_8 = this.gameObject.AddComponent<UnityEngine.Camera>();
        }
        
        this.GetComponent<UnityEngine.Camera>().useOcclusionCulling = false;
        this.GetComponent<UnityEngine.Camera>().enabled = false;
        UnityEngine.Vector2 val_12 = this.丞丁丑丏丄丏七丂不.mapSize;
        UnityEngine.Vector2 val_13 = this.丞丁丑丏丄丏七丂不.mapSize;
        this.GetComponent<UnityEngine.Camera>().targetTexture = new UnityEngine.RenderTexture(width:  (int)val_12.x, height:  (int)val_13.y, depth:  24, format:  0);
    }
    private void 丁丄丞丏丑上丑一丙()
    {
        float val_8;
        float val_9;
        float val_10;
        var val_11;
        float val_12;
        var val_13;
        this.丞丁丑丏丄丏七丂不.UpdateBounds();
        UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
        val_1.depth = -100f;
        val_9 = this.丞丁丑丏丄丏七丂不.cameraBackgroundColor;
        val_1.backgroundColor = new UnityEngine.Color() {r = val_9, g = V9.16B, b = V10.16B, a = V11.16B};
        val_1.cullingMask = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.丞丁丑丏丄丏七丂不.renderLayers});
        if(val_1 != null)
        {
                val_1.clearFlags = this.丞丁丑丏丄丏七丂不.cameraClearFlags;
        }
        else
        {
                val_1.clearFlags = this.丞丁丑丏丄丏七丂不.cameraClearFlags;
        }
        
        val_1.orthographic = true;
        if(this.丞丁丑丏丄丏七丂不.orientation != 1)
        {
            goto label_12;
        }
        
        float val_8 = 1.1f;
        val_8 = V10.16B * val_8;
        val_1.farClipPlane = val_8;
        val_10 = V9.16B;
        val_8 = V9.16B;
        if(val_1 != null)
        {
            goto label_30;
        }
        
        label_31:
        label_30:
        val_9 = val_8 / val_8;
        val_1.aspect = val_9;
        goto label_15;
        label_12:
        val_10 = 0f;
        if(this.丞丁丑丏丄丏七丂不.orientation == 0)
        {
            goto label_17;
        }
        
        label_15:
        float val_4 = this.GetComponent<UnityEngine.Camera>().farClipPlane;
        if(val_1 != null)
        {
                float val_9 = 5f;
            val_9 = val_4 * val_9;
            val_1.farClipPlane = val_9;
        }
        else
        {
                float val_10 = 5f;
            val_10 = val_4 * val_10;
            val_1.farClipPlane = val_10;
        }
        
        val_1.orthographicSize = val_10;
        UnityEngine.Transform val_5 = this.cachedTransform;
        if(this.丞丁丑丏丄丏七丂不.orientation != 0)
        {
                float val_13 = 0f;
            val_5.eulerAngles = new UnityEngine.Vector3() {x = val_13, y = 0f, z = 0f};
            val_11 = this.cachedTransform;
            val_12 = val_13;
            val_8 = val_13;
            float val_12 = System.Math.Abs(0f);
            val_12 = System.Math.Abs(0f) + val_12;
            val_12 = val_12 + 10f;
            val_13 = val_12 - val_8;
            val_13 = 0f;
        }
        else
        {
                val_5.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_11 = this.cachedTransform;
            val_12 = 0f;
            val_13 = 0f + 0f;
        }
        
        val_11.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_17:
        float val_14 = 1.1f;
        val_14 = V9.16B * val_14;
        val_1.farClipPlane = val_14;
        if(val_1 != null)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    private System.Collections.IEnumerator OnPostRender()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NJGMapRenderer.东专丄丕下丆三丌丞();
    }
    public void Render()
    {
        float val_14 = this.丈丈丏且丂丅东上丗;
        if(UnityEngine.Time.time < val_14)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                float val_3 = UnityEngine.Time.time;
            val_14 = 1f;
            val_3 = val_3 + val_14;
            this.丈丈丏且丂丅东上丗 = val_3;
        }
        
        this.七丟丑丛丗世丞与丄 = false;
        this.世丗下丞丟丗丙丅丁 = false;
        this.丄丛丑丛不三一丄丛 = false;
        this.丌丌丞丒丑七七万丈 = false;
        if(this.丞丁丑丏丄丏七丂不.optimize != true)
        {
                this.且丟丝丁与丈与专丐 = true;
        }
        
        UnityEngine.Vector2 val_4 = this.丞丁丑丏丄丏七丂不.mapSize;
        if(val_4.x == 0f)
        {
            goto label_6;
        }
        
        UnityEngine.Vector2 val_5 = this.丞丁丑丏丄丏七丂不.mapSize;
        if(val_5.y != 0f)
        {
            goto label_8;
        }
        
        label_6:
        this.丞丁丑丏丄丏七丂不.UpdateRenderSize();
        label_8:
        if(this.丞丁丑丏丄丏七丂不.runtimeGeneration == false)
        {
            goto label_11;
        }
        
        if(this.丞丁丑丏丄丏七丂不.userMapTexture != 0)
        {
                丁丒丐丂万三丌万业.Destroy(万且万且丑丗且丌丆:  this.丞丁丑丏丄丏七丂不.userMapTexture);
            this.丞丁丑丏丄丏七丂不.userMapTexture = 0;
        }
        
        if(this.丞丁丑丏丄丏七丂不.mapTexture != 0)
        {
            goto label_25;
        }
        
        this.丞丁丑丏丄丏七丂不.mapTexture = this.丐丅丞丘丌三丁丁丙();
        UnityEngine.Vector2 val_9 = this.丞丁丑丏丄丏七丂不.mapSize;
        this.丝丈丏丘丟业丘丏丌 = val_9;
        mem[1152921535386546364] = val_9.y;
        goto label_25;
        label_11:
        if(UnityEngine.Application.isPlaying != true)
        {
                if(this.丞丁丑丏丄丏七丂不.mapTexture != 0)
        {
                丁丒丐丂万三丌万业.Destroy(万且万且丑丗且丌丆:  this.丞丁丑丏丄丏七丂不.mapTexture);
            this.丞丁丑丏丄丏七丂不.mapTexture = 0;
        }
        
            this.丞丁丑丏丄丏七丂不.userMapTexture = this.丐丅丞丘丌三丁丁丙();
        }
        
        label_25:
        this.丁丄丞丏丑上丑一丙();
        this.GetComponent<UnityEngine.Camera>().Render();
    }
    private UnityEngine.Texture2D 丐丅丞丘丌三丁丁丙()
    {
        NJG.NJGMapBase val_3;
        UnityEngine.Vector2 val_1 = this.丞丁丑丏丄丏七丂不.mapSize;
        val_3 = this.丞丁丑丏丄丏七丂不;
        if(this.丞丁丑丏丄丏七丂不 != null)
        {
            goto label_2;
        }
        
        val_3 = this.丞丁丑丏丄丏七丂不;
        if(val_3 == null)
        {
            goto label_3;
        }
        
        label_2:
        UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  (int)val_1.x, height:  (int)val_1.y, textureFormat:  this.丞丁丑丏丄丏七丂不.textureFormat, mipChain:  this.丞丁丑丏丄丏七丂不.generateMipmaps);
        val_2.name = "_NJGMapTexture";
        val_2.filterMode = this.丞丁丑丏丄丏七丂不.mapFilterMode;
        val_2.wrapMode = this.丞丁丑丏丄丏七丂不.mapWrapMode;
        return val_2;
        label_3:
    }
    public NJGMapRenderer()
    {
        this.且丟丝丁与丈与专丐 = true;
    }

}
