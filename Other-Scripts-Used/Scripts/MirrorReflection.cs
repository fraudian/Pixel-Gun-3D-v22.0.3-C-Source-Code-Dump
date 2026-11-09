using UnityEngine;
public class MirrorReflection : MonoBehaviour
{
    // Fields
    public bool m_DisablePixelLights;
    public int m_TextureSize;
    public float m_ClipPlaneOffset;
    public UnityEngine.LayerMask m_ReflectLayers;
    private System.Collections.Hashtable m_ReflectionCameras;
    private UnityEngine.RenderTexture m_ReflectionTexture;
    private int m_OldReflectionTextureSize;
    private static bool s_InsideRendering;
    
    // Methods
    public void OnWillRenderObject()
    {
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_53;
        float val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        float val_59;
        float val_61;
        float val_62;
        float val_63;
        float val_64;
        float val_66;
        float val_67;
        float val_68;
        float val_69;
        UnityEngine.Object val_71;
        UnityEngine.Object val_72;
        var val_73;
        UnityEngine.RenderTexture val_75;
        var val_76;
        var val_77;
        UnityEngine.Camera val_9 = 0;
        if(this.enabled == false)
        {
                return;
        }
        
        val_71 = 1152921504848912384;
        val_72 = this.GetComponent<UnityEngine.Renderer>();
        if((UnityEngine.Object.op_Implicit(exists:  val_72)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_72.sharedMaterial)) == false)
        {
                return;
        }
        
        if(val_72.enabled == false)
        {
                return;
        }
        
        val_71 = UnityEngine.Camera.current;
        if((UnityEngine.Object.op_Implicit(exists:  val_71)) == false)
        {
                return;
        }
        
        val_73 = null;
        val_73 = null;
        if(MirrorReflection.s_InsideRendering == true)
        {
                return;
        }
        
        MirrorReflection.s_InsideRendering = true;
        this.CreateMirrorObjects(currentCamera:  val_71, reflectionCamera: out  val_9);
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = val_10.position;
        UnityEngine.Vector3 val_12 = val_10.up;
        if(this.m_DisablePixelLights != false)
        {
                UnityEngine.QualitySettings.pixelLightCount = 0;
        }
        
        this.UpdateCameraModes(src:  val_71, dest:  val_9);
        float val_71 = val_11.x;
        val_71 = (-(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, rhs:  new UnityEngine.Vector3() {x = val_71, y = val_11.y, z = val_11.z}))) - this.m_ClipPlaneOffset;
        UnityEngine.Matrix4x4 val_15 = UnityEngine.Matrix4x4.zero;
        MirrorReflection.CalculateReflectionMatrix(reflectionMat: ref  new UnityEngine.Matrix4x4() {m00 = val_16, m10 = val_16, m20 = val_16, m30 = val_16, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17}, plane:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_75 = val_71.transform;
        UnityEngine.Vector3 val_21 = val_75.position;
        UnityEngine.Matrix4x4 val_22 = val_71.worldToCameraMatrix;
        UnityEngine.Matrix4x4 val_27 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_26, m10 = val_26, m20 = val_26, m30 = val_26, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_24, m12 = val_24, m22 = val_24, m32 = val_24, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_16, m10 = val_16, m20 = val_16, m30 = val_16, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17});
        val_9.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = val_31, m10 = val_31, m20 = val_31, m30 = val_31, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_29, m12 = val_29, m22 = val_29, m32 = val_29, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28};
        UnityEngine.Vector4 val_32 = this.CameraSpacePlane(cam:  val_9, pos:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, normal:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, sideSign:  1f);
        UnityEngine.Matrix4x4 val_33 = val_71.projectionMatrix;
        MirrorReflection.CalculateObliqueMatrix(projection: ref  new UnityEngine.Matrix4x4() {m00 = val_37, m10 = val_37, m20 = val_37, m30 = val_37, m01 = val_36, m11 = val_36, m21 = val_36, m31 = val_36, m02 = val_35, m12 = val_35, m22 = val_35, m32 = val_35, m03 = val_34, m13 = val_34, m23 = val_34, m33 = val_34}, clipPlane:  new UnityEngine.Vector4() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w});
        val_9.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = val_37, m10 = val_37, m20 = val_37, m30 = val_37, m01 = val_36, m11 = val_36, m21 = val_36, m31 = val_36, m02 = val_35, m12 = val_35, m22 = val_35, m32 = val_35, m03 = val_34, m13 = val_34, m23 = val_34, m33 = val_34};
        val_9.cullingMask = this.m_ReflectLayers.value & 4294967279;
        if(val_9 != 0)
        {
                val_9.targetTexture = this.m_ReflectionTexture;
            UnityEngine.GL.SetRevertBackfacing(revertBackFaces:  true);
        }
        else
        {
                val_9.targetTexture = this.m_ReflectionTexture;
            UnityEngine.GL.SetRevertBackfacing(revertBackFaces:  true);
        }
        
        UnityEngine.Transform val_40 = val_9.transform;
        val_40.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        UnityEngine.Vector3 val_41 = val_75.eulerAngles;
        val_40.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_9.Render();
        val_40.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        UnityEngine.GL.SetRevertBackfacing(revertBackFaces:  false);
        val_72 = val_72.sharedMaterials;
        val_76 = 0;
        goto label_43;
        label_49:
        UnityEngine.Material val_72 = val_72[0];
        if((val_72.HasProperty(name:  "_ReflectionTex")) != false)
        {
                val_75 = this.m_ReflectionTexture;
            val_72.SetTexture(name:  "_ReflectionTex", value:  val_75);
        }
        
        val_76 = 1;
        label_43:
        if(val_76 < val_42.Length)
        {
            goto label_49;
        }
        
        UnityEngine.Quaternion val_44 = UnityEngine.Quaternion.identity;
        UnityEngine.Matrix4x4 val_45 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_44.x, y = val_44.y, z = val_44.z, w = val_44.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
        UnityEngine.Vector3 val_46 = val_10.lossyScale;
        UnityEngine.Matrix4x4 val_47 = val_10.localToWorldMatrix;
        val_46.x = 1f / val_46.x;
        val_46.y = 1f / val_46.y;
        val_46.z = 1f / val_46.z;
        UnityEngine.Matrix4x4 val_48 = UnityEngine.Matrix4x4.Scale(vector:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Matrix4x4 val_49 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_26, m10 = val_26, m20 = val_26, m30 = val_26, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_24, m12 = val_24, m22 = val_24, m32 = val_24, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_31, m10 = val_31, m20 = val_31, m30 = val_31, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_29, m12 = val_29, m22 = val_29, m32 = val_29, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28});
        UnityEngine.Matrix4x4 val_50 = val_71.projectionMatrix;
        UnityEngine.Matrix4x4 val_51 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_16, m10 = val_16, m20 = val_16, m30 = val_16, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_37, m10 = val_37, m20 = val_37, m30 = val_37, m01 = val_36, m11 = val_36, m21 = val_36, m31 = val_36, m02 = val_35, m12 = val_35, m22 = val_35, m32 = val_35, m03 = val_34, m13 = val_34, m23 = val_34, m33 = val_34});
        UnityEngine.Matrix4x4 val_52 = val_71.worldToCameraMatrix;
        UnityEngine.Matrix4x4 val_60 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = val_55, m11 = val_55, m21 = val_55, m31 = val_55, m02 = val_53, m12 = val_53, m22 = val_53, m32 = val_53, m03 = val_54, m13 = val_54, m23 = val_54, m33 = val_54}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_58, m10 = val_58, m20 = val_58, m30 = val_58, m01 = val_59, m11 = val_59, m21 = val_59, m31 = val_59, m02 = val_56, m12 = val_56, m22 = val_56, m32 = val_56, m03 = val_57, m13 = val_57, m23 = val_57, m33 = val_57});
        UnityEngine.Matrix4x4 val_65 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_63, m10 = val_63, m20 = val_63, m30 = val_63, m01 = val_64, m11 = val_64, m21 = val_64, m31 = val_64, m02 = val_61, m12 = val_61, m22 = val_61, m32 = val_61, m03 = val_62, m13 = val_62, m23 = val_62, m33 = val_62}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_37, m10 = val_37, m20 = val_37, m30 = val_37, m01 = val_36, m11 = val_36, m21 = val_36, m31 = val_36, m02 = val_35, m12 = val_35, m22 = val_35, m32 = val_35, m03 = val_34, m13 = val_34, m23 = val_34, m33 = val_34});
        if(val_42.Length >= 1)
        {
                do
        {
            val_71 = val_72[0];
            val_17 = val_67;
            val_18 = val_66;
            val_19 = val_69;
            val_16 = val_68;
            val_71.SetMatrix(name:  "_ProjMatrix", value:  new UnityEngine.Matrix4x4() {m00 = val_16, m10 = val_16, m20 = val_16, m30 = val_16, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17});
        }
        while((0 + 1) < val_42.Length);
        
        }
        
        if(this.m_DisablePixelLights != false)
        {
                UnityEngine.QualitySettings.pixelLightCount = UnityEngine.QualitySettings.pixelLightCount;
        }
        
        val_77 = null;
        val_77 = null;
        MirrorReflection.s_InsideRendering = false;
    }
    private void OnDisable()
    {
        var val_10;
        var val_11;
        var val_12;
        if((UnityEngine.Object.op_Implicit(exists:  this.m_ReflectionTexture)) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.m_ReflectionTexture);
            this.m_ReflectionTexture = 0;
        }
        
        label_24:
        var val_10 = 0;
        val_10 = val_10 + 1;
        if(this.m_ReflectionCameras.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_11 = 0;
        val_11 = val_11 + 1;
        object val_5 = this.m_ReflectionCameras.Current;
        val_10 = ;
        if(null != 0)
        {
                if(null == null)
        {
            goto label_19;
        }
        
        }
        
        if(null != 0)
        {
                label_19:
            if(null != null)
        {
                val_10 = 0;
        }
        
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  val_10.gameObject);
        goto label_24;
        label_12:
        val_11 = 0;
        val_12 = 0;
        if(this.m_ReflectionCameras != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            this.m_ReflectionCameras.Dispose();
        }
        
        if(this.m_ReflectionCameras != null)
        {
                return;
        }
    
    }
    private void UpdateCameraModes(UnityEngine.Camera src, UnityEngine.Camera dest)
    {
        UnityEngine.Object val_20;
        var val_21;
        if(dest == 0)
        {
                return;
        }
        
        dest.clearFlags = src.clearFlags;
        UnityEngine.Color val_3 = src.backgroundColor;
        dest.backgroundColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        if(src.clearFlags != 1)
        {
            goto label_9;
        }
        
        System.Type val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Component val_6 = src.GetComponent(type:  val_20);
        if(val_6 != null)
        {
                val_20 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        System.Type val_21 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Component val_8 = dest.GetComponent(type:  val_21);
        if(val_8 != null)
        {
                val_21 = (null == null) ? (val_8) : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        if(((UnityEngine.Object.op_Implicit(exists:  val_20)) == false) || ((UnityEngine.Object.op_Implicit(exists:  val_20.material)) == false))
        {
            goto label_24;
        }
        
        val_21.enabled = true;
        val_21.material = val_20.material;
        if(src != null)
        {
            goto label_31;
        }
        
        goto label_29;
        label_24:
        val_21.enabled = false;
        label_9:
        if(src != null)
        {
            goto label_31;
        }
        
        label_29:
        label_31:
        dest.farClipPlane = src.farClipPlane;
        dest.nearClipPlane = src.nearClipPlane;
        dest.orthographic = src.orthographic;
        dest.fieldOfView = src.fieldOfView;
        dest.aspect = src.aspect;
        dest.orthographicSize = src.orthographicSize;
    }
    private void CreateMirrorObjects(UnityEngine.Camera currentCamera, out UnityEngine.Camera reflectionCamera)
    {
        System.Collections.Hashtable val_21;
        string val_22;
        UnityEngine.Camera val_23;
        val_21 = this;
        reflectionCamera = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.m_ReflectionTexture)) != false)
        {
                if(this.m_OldReflectionTextureSize == this.m_TextureSize)
        {
            goto label_4;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.m_ReflectionTexture)) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.m_ReflectionTexture);
        }
        
        UnityEngine.RenderTexture val_3 = new UnityEngine.RenderTexture(width:  this.m_TextureSize, height:  this.m_TextureSize, depth:  16);
        this.m_ReflectionTexture = val_3;
        val_22 = "__MirrorReflection" + this.GetInstanceID();
        val_3.name = val_22;
        this.m_ReflectionTexture.isPowerOfTwo = true;
        this.m_ReflectionTexture.hideFlags = 52;
        this.m_OldReflectionTextureSize = this.m_TextureSize;
        label_4:
        System.Collections.Hashtable val_21 = this.m_ReflectionCameras;
        if(val_21 != null)
        {
                val_21 = (null == null) ? (val_21) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        reflectionCamera = val_23;
        if((UnityEngine.Object.op_Implicit(exists:  val_23)) == true)
        {
                return;
        }
        
        System.Type[] val_10 = new System.Type[2];
        val_10[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_10[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.GameObject val_13 = new UnityEngine.GameObject(name:  System.String.Format(format:  "Mirror Refl Camera id{0} for {1}", arg0:  this.GetInstanceID(), arg1:  currentCamera.GetInstanceID()), components:  val_10);
        UnityEngine.Camera val_14 = val_13.GetComponent<UnityEngine.Camera>();
        reflectionCamera = val_14;
        val_14.enabled = false;
        UnityEngine.Transform val_15 = reflectionCamera.transform;
        UnityEngine.Transform val_16 = this.transform;
        UnityEngine.Vector3 val_17 = val_16.position;
        val_15.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Quaternion val_18 = val_16.rotation;
        val_15.rotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
        val_22 = reflectionCamera.gameObject;
        UnityEngine.FlareLayer val_20 = val_22.AddComponent<UnityEngine.FlareLayer>();
        val_13.hideFlags = 61;
        val_21 = this.m_ReflectionCameras;
    }
    private static float sgn(float a)
    {
        if(a <= 0f)
        {
                return (float)(a < 0) ? -1f : 0f;
        }
        
        return 1f;
    }
    private UnityEngine.Vector4 CameraSpacePlane(UnityEngine.Camera cam, UnityEngine.Vector3 pos, UnityEngine.Vector3 normal, float sideSign)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, d:  this.m_ClipPlaneOffset);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Matrix4x4 val_3 = cam.worldToCameraMatrix;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, d:  sideSign);
        float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    private static void CalculateObliqueMatrix(ref UnityEngine.Matrix4x4 projection, UnityEngine.Vector4 clipPlane)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        var val_2 = (clipPlane.x > 0f) ? 1f : ((clipPlane.x < 0) ? -1f : 0f);
        var val_4 = (clipPlane.y > 0f) ? 1f : ((clipPlane.y < 0) ? -1f : 0f);
        UnityEngine.Vector4 val_9 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_7, m12 = val_7, m22 = val_7, m32 = val_7, m03 = val_8, m13 = val_8, m23 = val_8, m33 = val_8}, vector:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_12 = val_9.x;
        val_12 = 2f / (UnityEngine.Vector4.Dot(a:  new UnityEngine.Vector4() {x = clipPlane.x, y = clipPlane.y, z = clipPlane.z, w = clipPlane.w}, b:  new UnityEngine.Vector4() {x = val_12, y = val_9.y, z = val_9.z, w = val_9.w}));
        UnityEngine.Vector4 val_11 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = clipPlane.x, y = clipPlane.y, z = clipPlane.z, w = clipPlane.w}, d:  val_12);
        val_11.x = val_11.x - val_11.x;
        val_11.x = val_11.y - val_11.x;
        val_11.x = val_11.z - val_11.x;
        val_11.x = val_11.w - val_11.x;
    }
    private static void CalculateReflectionMatrix(ref UnityEngine.Matrix4x4 reflectionMat, UnityEngine.Vector4 plane)
    {
        float val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        plane.x = plane.x + 1f;
        reflectionMat.m00 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m01 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m02 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m03 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m10 = plane.x;
        val_1 = plane.x + plane.x;
        plane.x = val_1 * plane.x;
        plane.x = 1f - plane.x;
        reflectionMat.m11 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m12 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m13 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m20 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m21 = plane.x;
        val_1 = plane.x + plane.x;
        plane.x = val_1 * plane.x;
        plane.x = 1f - plane.x;
        reflectionMat.m22 = plane.x;
        val_1 = plane.x * (-2f);
        plane.x = val_1 * plane.x;
        reflectionMat.m30 = 0f;
        reflectionMat.m31 = 0f;
        reflectionMat.m32 = 0f;
        reflectionMat.m23 = plane.x;
        reflectionMat.m33 = 1f;
    }
    public MirrorReflection()
    {
        this.m_DisablePixelLights = true;
        this.m_TextureSize = 256;
        this.m_ClipPlaneOffset = 3.306083E-41f;
        UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.m_ReflectLayers = val_1;
        this.m_ReflectionCameras = new System.Collections.Hashtable();
    }
    private static MirrorReflection()
    {
    
    }

}
