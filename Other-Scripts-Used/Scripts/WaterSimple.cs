using UnityEngine;
public class WaterSimple : MonoBehaviour
{
    // Fields
    private UnityEngine.Renderer _cachedRenderer;
    
    // Properties
    private UnityEngine.Renderer ThisRenderer { get; }
    
    // Methods
    private void Update()
    {
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        if((UnityEngine.Object.op_Implicit(exists:  this.ThisRenderer)) == false)
        {
                return;
        }
        
        this = this.ThisRenderer.sharedMaterial;
        if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
        {
                return;
        }
        
        UnityEngine.Vector4 val_6 = this.GetVector(name:  "WaveSpeed");
        float val_7 = this.GetFloat(name:  "_WaveScale");
        UnityEngine.Vector4 val_11 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, d:  val_7 * (UnityEngine.Time.time / 20f));
        float val_12 = UnityEngine.Mathf.Repeat(t:  val_11.x, length:  1f);
        float val_13 = UnityEngine.Mathf.Repeat(t:  val_11.y, length:  1f);
        float val_14 = UnityEngine.Mathf.Repeat(t:  val_11.z, length:  1f);
        float val_15 = UnityEngine.Mathf.Repeat(t:  val_11.w, length:  1f);
        this.SetVector(name:  "_WaveOffset", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_16 = 1f / val_7;
        UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
        UnityEngine.Matrix4x4 val_18 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
        this.SetMatrix(name:  "_WaveMatrix", value:  new UnityEngine.Matrix4x4() {m00 = val_21, m10 = val_21, m20 = val_21, m30 = val_21, m01 = val_22, m11 = val_22, m21 = val_22, m31 = val_22, m02 = val_19, m12 = val_19, m22 = val_19, m32 = val_19, m03 = val_20, m13 = val_20, m23 = val_20, m33 = val_20});
        UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.identity;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  0.45f);
        UnityEngine.Matrix4x4 val_25 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w}, s:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.z});
        this.SetMatrix(name:  "_WaveMatrix2", value:  new UnityEngine.Matrix4x4() {m00 = val_28, m10 = val_28, m20 = val_28, m30 = val_28, m01 = val_29, m11 = val_29, m21 = val_29, m31 = val_29, m02 = val_26, m12 = val_26, m22 = val_26, m32 = val_26, m03 = val_27, m13 = val_27, m23 = val_27, m33 = val_27});
    }
    private UnityEngine.Renderer get_ThisRenderer()
    {
        UnityEngine.Renderer val_3;
        if(this._cachedRenderer == 0)
        {
                this._cachedRenderer = this.GetComponent<UnityEngine.Renderer>();
            return val_3;
        }
        
        val_3 = this._cachedRenderer;
        return val_3;
    }
    public WaterSimple()
    {
    
    }

}
