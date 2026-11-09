using UnityEngine;
public class PSRotationCD1Curves : MonoBehaviour
{
    // Fields
    public bool local;
    public bool initial_orientation_local;
    public UnityEngine.Vector3 startRotation;
    public UnityEngine.Vector3 worldOffset;
    private System.Collections.Generic.List<UnityEngine.Vector4> 丅丌丟丟七专业丗一;
    private UnityEngine.ParticleSystem 丘丕丝上下丄丈丏丒;
    
    // Methods
    private void Start()
    {
        this.丘丕丝上下丄丈丏丒 = this.GetComponent<UnityEngine.ParticleSystem>();
        UnityEngine.Transform val_2 = this.transform;
        if(this.initial_orientation_local != false)
        {
                val_2.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
        }
        
        val_2.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        UnityEngine.Vector3 val_29;
        System.Collections.Generic.List<UnityEngine.Vector4> val_33;
        System.Collections.Generic.List<UnityEngine.Vector4> val_34;
        float val_35;
        var val_36;
        UnityEngine.Quaternion val_2 = this.transform.rotation;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        UnityEngine.Vector3 val_12 = this.transform.parent.transform.localPosition;
        UnityEngine.Vector3 val_13 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_29 = this.worldOffset;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_29, y = val_4.w, z = val_12.z});
        UnityEngine.Vector3 val_15 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        if(this.丘丕丝上下丄丈丏丒 != 0)
        {
                val_33 = this;
            int val_17 = this.丘丕丝上下丄丈丏丒.GetCustomParticleData(customData:  this.丅丌丟丟七专业丗一, streamIndex:  0);
        }
        else
        {
                val_33 = this.丅丌丟丟七专业丗一;
        }
        
        val_34 = this.丅丌丟丟七专业丗一.SyncRoot.Count;
        UnityEngine.Transform val_19 = this.transform;
        if(val_34 == 0)
        {
            goto label_19;
        }
        
        UnityEngine.Vector4 val_20 = this.丅丌丟丟七专业丗一.SyncRoot.Item[0];
        if(this.local == false)
        {
            goto label_21;
        }
        
        UnityEngine.Vector4 val_21 = this.丅丌丟丟七专业丗一.Item[0];
        val_34 = this.丅丌丟丟七专业丗一;
        val_35 = val_21.y;
        UnityEngine.Vector4 val_22 = val_34.Item[0];
        float val_23 = this.startRotation + val_20.x;
        float val_24 = val_4.w + val_35;
        val_22.z = val_29 + val_22.z;
        val_19.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_19:
        if(this.local == false)
        {
            goto label_26;
        }
        
        val_19.Rotate(eulers:  new UnityEngine.Vector3() {x = this.startRotation, y = val_15.z, z = val_15.y}, relativeTo:  1);
        return;
        label_21:
        UnityEngine.Vector4 val_25 = this.丅丌丟丟七专业丗一.Item[0];
        val_34 = this.丅丌丟丟七专业丗一;
        val_35 = val_25.y;
        UnityEngine.Vector4 val_26 = val_34.Item[0];
        float val_27 = this.startRotation + val_20.x;
        val_36 = val_4.w + val_35;
        val_26.z = val_29 + val_26.z;
        goto label_31;
        label_26:
        val_36 = val_15.z;
        label_31:
        val_19.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public PSRotationCD1Curves()
    {
        this.local = true;
        this.initial_orientation_local = true;
        this.startRotation = 0;
        mem[1152921540538304772] = 0;
        this.worldOffset = 0;
        mem[1152921540538304784] = 0;
        this.丅丌丟丟七专业丗一 = new System.Collections.Generic.List<UnityEngine.Vector4>();
    }

}
