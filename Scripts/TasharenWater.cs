using UnityEngine;
public class TasharenWater : MonoBehaviour
{
    // Fields
    public TasharenWater.不丘一丙下且一世七 quality;
    public UnityEngine.LayerMask highReflectionMask;
    public UnityEngine.LayerMask mediumReflectionMask;
    public bool keepUnderCamera;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private System.Collections.Hashtable 业东丆且丝丅丁丂丝;
    private UnityEngine.RenderTexture 丅三专世业三丁七丆;
    private int 万丛丌东七丛丆不丗;
    private UnityEngine.Renderer 丂丟业丗上一万丘丒;
    private static bool 三业丄丝世丅丝丝业;
    
    // Properties
    public int 丄丕丝丂丞与丌丈丙 { get; }
    public UnityEngine.LayerMask 丝丑丛一三世三丄丐 { get; }
    public bool 丛三一丅丕丑丕丝且 { get; }
    
    // Methods
    public int get_reflectionTextureSize()
    {
        if((this.quality & 4294967294) != 2)
        {
                return (int)(this.quality != 4) ? 0 : 1024;
        }
        
        return 512;
    }
    public UnityEngine.LayerMask get_reflectionMask()
    {
        UnityEngine.LayerMask val_2;
        不丘一丙下且一世七 val_2 = this.quality;
        if(val_2 == 2)
        {
                val_2 = this.mediumReflectionMask;
        }
        else
        {
                val_2 = val_2 - 3;
            if(val_2 <= 1)
        {
                val_2 = this.highReflectionMask;
        }
        else
        {
                val_2 = 0;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        }
        
        }
        
        val_1.m_Mask = val_1.m_Mask & 4294967295;
        return (UnityEngine.LayerMask)val_1.m_Mask;
    }
    public bool get_useRefraction()
    {
        return (bool)(this.quality > 0) ? 1 : 0;
    }
    private static float 丘东丒丕丁丝与丆丟(float 丆丛丑世下一丐且丕)
    {
        if(丆丛丑世下一丐且丕 <= 0f)
        {
                return (float)(丆丛丑世下一丐且丕 < 0) ? -1f : 0f;
        }
        
        return 1f;
    }
    private static void 一专东丂七上万丕丒(ref UnityEngine.Matrix4x4 七丘丛上业丁且业丆, UnityEngine.Vector4 丞万丐丈丛丝一丈上)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        var val_2 = (丞万丐丈丛丝一丈上.x > 0f) ? 1f : ((丞万丐丈丛丝一丈上.x < 0) ? -1f : 0f);
        var val_4 = (丞万丐丈丛丝一丈上.y > 0f) ? 1f : ((丞万丐丈丛丝一丈上.y < 0) ? -1f : 0f);
        UnityEngine.Vector4 val_9 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_7, m12 = val_7, m22 = val_7, m32 = val_7, m03 = val_8, m13 = val_8, m23 = val_8, m33 = val_8}, vector:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_12 = val_9.x;
        val_12 = 2f / (UnityEngine.Vector4.Dot(a:  new UnityEngine.Vector4() {x = 丞万丐丈丛丝一丈上.x, y = 丞万丐丈丛丝一丈上.y, z = 丞万丐丈丛丝一丈上.z, w = 丞万丐丈丛丝一丈上.w}, b:  new UnityEngine.Vector4() {x = val_12, y = val_9.y, z = val_9.z, w = val_9.w}));
        UnityEngine.Vector4 val_11 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = 丞万丐丈丛丝一丈上.x, y = 丞万丐丈丛丝一丈上.y, z = 丞万丐丈丛丝一丈上.z, w = 丞万丐丈丛丝一丈上.w}, d:  val_12);
        val_11.x = val_11.x - val_11.x;
        val_11.x = val_11.y - val_11.x;
        val_11.x = val_11.z - val_11.x;
        val_11.x = val_11.w - val_11.x;
    }
    private static void 上不丞丄丑丌丈丗丐(ref UnityEngine.Matrix4x4 丌七丒丌下上丂丛丞, UnityEngine.Vector4 专下丒丁不丌丕三上)
    {
        float val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        专下丒丁不丌丕三上.x = 专下丒丁不丌丕三上.x + 1f;
        丌七丒丌下上丂丛丞.m00 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m01 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m02 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m03 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m10 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x + 专下丒丁不丌丕三上.x;
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        专下丒丁不丌丕三上.x = 1f - 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m11 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m12 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m13 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m20 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m21 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x + 专下丒丁不丌丕三上.x;
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        专下丒丁不丌丕三上.x = 1f - 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m22 = 专下丒丁不丌丕三上.x;
        val_1 = 专下丒丁不丌丕三上.x * (-2f);
        专下丒丁不丌丕三上.x = val_1 * 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m30 = 0f;
        丌七丒丌下上丂丛丞.m31 = 0f;
        丌七丒丌下上丂丛丞.m32 = 0f;
        丌七丒丌下上丂丛丞.m23 = 专下丒丁不丌丕三上.x;
        丌七丒丌下上丂丛丞.m33 = 1f;
    }
    public static TasharenWater.不丘一丙下且一世七 GetQuality()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  "Water", defaultValue:  3);
    }
    public static void SetQuality(TasharenWater.不丘一丙下且一世七 丒世且丒丅丆一万丝)
    {
        if(val_2.Length != 0)
        {
                if(val_2.Length < 1)
        {
                return;
        }
        
            do
        {
            UnityEngine.Object val_4 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))[0];
            mem2[0] = 丒世且丒丅丆一万丝;
        }
        while((0 + 1) < val_2.Length);
        
            return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "Water", value:  丒世且丒丅丆一万丝);
    }
    private void Awake()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.丂丟业丗上一万丘丒 = this.GetComponent<UnityEngine.Renderer>();
        this.quality = TasharenWater.GetQuality();
    }
    private void OnDisable()
    {
        var val_9;
        var val_10;
        var val_11;
        this.世业丒万丘丆专丘丐();
        label_19:
        var val_9 = 0;
        val_9 = val_9 + 1;
        if(this.业东丆且丝丅丁丂丝.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        object val_4 = this.业东丆且丝丅丁丂丝.Current;
        val_9 = ;
        if(null != 0)
        {
                if(null == null)
        {
            goto label_14;
        }
        
        }
        
        if(null != 0)
        {
                label_14:
            if(null != null)
        {
                val_9 = 0;
        }
        
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  val_9.gameObject);
        goto label_19;
        label_7:
        val_10 = 0;
        val_11 = 0;
        if(this.业东丆且丝丅丁丂丝 != null)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            this.业东丆且丝丅丁丂丝.Dispose();
        }
        
        if(this.业东丆且丝丅丁丂丝 != null)
        {
                return;
        }
    
    }
    private void 世业丒万丘丆专丘丐()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丅三专世业三丁七丆)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this.丅三专世业三丁七丆);
        this.丅三专世业三丁七丆 = 0;
    }
    private void 不丝七丏业丄丗丕七(UnityEngine.Camera 丟丄丛丗丞丐东专一, UnityEngine.Camera 丙七丟丏丅丘丈丁丄)
    {
        if(丟丄丛丗丞丐东专一.clearFlags != 1)
        {
            goto label_2;
        }
        
        UnityEngine.Skybox val_2 = 丟丄丛丗丞丐东专一.GetComponent<UnityEngine.Skybox>();
        UnityEngine.Skybox val_3 = 丙七丟丏丅丘丈丁丄.GetComponent<UnityEngine.Skybox>();
        if(((UnityEngine.Object.op_Implicit(exists:  val_2)) == false) || ((UnityEngine.Object.op_Implicit(exists:  val_2.material)) == false))
        {
            goto label_11;
        }
        
        val_3.enabled = true;
        val_3.material = val_2.material;
        if(丟丄丛丗丞丐东专一 != null)
        {
            goto label_18;
        }
        
        goto label_16;
        label_11:
        val_3.enabled = false;
        label_2:
        if(丟丄丛丗丞丐东专一 != null)
        {
            goto label_18;
        }
        
        label_16:
        label_18:
        丙七丟丏丅丘丈丁丄.clearFlags = 丟丄丛丗丞丐东专一.clearFlags;
        UnityEngine.Color val_9 = 丟丄丛丗丞丐东专一.backgroundColor;
        丙七丟丏丅丘丈丁丄.backgroundColor = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
        丙七丟丏丅丘丈丁丄.farClipPlane = 丟丄丛丗丞丐东专一.farClipPlane;
        丙七丟丏丅丘丈丁丄.nearClipPlane = 丟丄丛丗丞丐东专一.nearClipPlane;
        丙七丟丏丅丘丈丁丄.orthographic = 丟丄丛丗丞丐东专一.orthographic;
        丙七丟丏丅丘丈丁丄.fieldOfView = 丟丄丛丗丞丐东专一.fieldOfView;
        丙七丟丏丅丘丈丁丄.aspect = 丟丄丛丗丞丐东专一.aspect;
        float val_16 = 丟丄丛丗丞丐东专一.orthographicSize;
        if(丙七丟丏丅丘丈丁丄 != null)
        {
                丙七丟丏丅丘丈丁丄.orthographicSize = val_16;
            丙七丟丏丅丘丈丁丄.depthTextureMode = 0;
        }
        else
        {
                0.orthographicSize = val_16;
            0.depthTextureMode = 0;
        }
        
        丙七丟丏丅丘丈丁丄.renderingPath = 1;
    }
    private UnityEngine.Camera 不丛三下丂丅丌丑丏(UnityEngine.Camera 上丞丕专丈业丁世专, UnityEngine.Material 世丑丘丘丂专丅丆与, int 东丄东丂专不丗丏丄)
    {
        UnityEngine.RenderTexture val_21;
        UnityEngine.Object val_22;
        val_21 = this.丅三专世业三丁七丆;
        if((UnityEngine.Object.op_Implicit(exists:  val_21)) != false)
        {
                if(this.万丛丌东七丛丆不丗 == 东丄东丂专不丗丏丄)
        {
            goto label_4;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丅三专世业三丁七丆)) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.丅三专世业三丁七丆);
        }
        
        UnityEngine.RenderTexture val_3 = new UnityEngine.RenderTexture(width:  东丄东丂专不丗丏丄, height:  东丄东丂专不丗丏丄, depth:  16);
        this.丅三专世业三丁七丆 = val_3;
        val_3.name = "__MirrorReflection" + this.GetInstanceID();
        this.丅三专世业三丁七丆.isPowerOfTwo = true;
        val_21 = this.丅三专世业三丁七丆;
        val_21.hideFlags = 52;
        this.万丛丌东七丛丆不丗 = 东丄东丂专不丗丏丄;
        label_4:
        System.Collections.Hashtable val_21 = this.业东丆且丝丅丁丂丝;
        if(val_21 != null)
        {
                val_21 = (null == null) ? (val_21) : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_22)) != true)
        {
                System.Type[] val_10 = new System.Type[2];
            val_10[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_10[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.GameObject val_13 = new UnityEngine.GameObject(name:  System.String.Format(format:  "Mirror Refl Camera id{0} for {1}", arg0:  this.GetInstanceID(), arg1:  上丞丕专丈业丁世专.GetInstanceID()), components:  val_10);
            if(val_13 != null)
        {
                val_13.hideFlags = 61;
        }
        else
        {
                0.hideFlags = 61;
        }
        
            val_22 = val_13.GetComponent<UnityEngine.Camera>();
            if(val_22 != null)
        {
                val_22.enabled = false;
        }
        else
        {
                0.enabled = false;
        }
        
            UnityEngine.Transform val_15 = val_22.transform;
            UnityEngine.Vector3 val_16 = this.丐一丗丛丕世丘东丁.position;
            val_15.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Quaternion val_17 = this.丐一丗丛丕世丘东丁.rotation;
            val_15.rotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
            UnityEngine.FlareLayer val_19 = val_22.gameObject.AddComponent<UnityEngine.FlareLayer>();
            val_21 = this.业东丆且丝丅丁丂丝;
        }
        
        if((世丑丘丘丂专丅丆与.HasProperty(name:  "_ReflectionTex")) == false)
        {
                return (UnityEngine.Camera)val_22;
        }
        
        世丑丘丘丂专丅丆与.SetTexture(name:  "_ReflectionTex", value:  this.丅三专世业三丁七丆);
        return (UnityEngine.Camera)val_22;
    }
    private UnityEngine.Vector4 与且丞且丞丟丂丂丟(UnityEngine.Camera 业丆丆东丂与万丅不, UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Vector3 丏与三业丈丕专且丑, float 丐丑丒世与丁丒丛丗)
    {
        UnityEngine.Matrix4x4 val_1 = 业丆丆东丂与万丅不.worldToCameraMatrix;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = 丏与三业丈丕专且丑.y, z = 丏与三业丈丕专且丑.z}, d:  丐丑丒世与丁丒丛丗);
        float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    private void LateUpdate()
    {
        if(this.keepUnderCamera == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Camera.main.transform.position;
        UnityEngine.Vector3 val_4 = this.丐一丗丛丕世丘东丁.position;
        UnityEngine.Vector3 val_5 = this.丐一丗丛丕世丘东丁.position;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_4.y, z = val_3.z})) == false)
        {
                return;
        }
        
        this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_3.x, y = val_4.y, z = val_3.z};
    }
    private void OnWillRenderObject()
    {
        null = null;
        if(TasharenWater.三业丄丝世丅丝丝业 != false)
        {
                return;
        }
        
        if((this.enabled != false) && ((UnityEngine.Object.op_Implicit(exists:  this.丂丟业丗上一万丘丒)) != false))
        {
                if(this.丂丟业丗上一万丘丒.enabled != false)
        {
                UnityEngine.Material val_4 = this.丂丟业丗上一万丘丒.sharedMaterial;
            if((UnityEngine.Object.op_Implicit(exists:  val_4)) == false)
        {
                return;
        }
        
            this.quality = 0;
            val_4.shader.maximumLOD = 100;
            return;
        }
        
        }
        
        this.世业丒万丘丆专丘丐();
    }
    public TasharenWater()
    {
        this.quality = 3;
        UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.highReflectionMask = val_1;
        UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.mediumReflectionMask = val_2;
        this.keepUnderCamera = true;
        this.业东丆且丝丅丁丂丝 = new System.Collections.Hashtable();
    }
    private static TasharenWater()
    {
    
    }

}
