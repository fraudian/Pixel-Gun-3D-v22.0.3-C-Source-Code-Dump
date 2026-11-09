using UnityEngine;
public class UIScaleChildOnCenter : MonoBehaviour
{
    // Fields
    public UIPanel panel;
    public UnityEngine.Vector3 center;
    public float deltaToScale;
    public float scale;
    
    // Methods
    private void Start()
    {
        var val_3;
        if(null <= 1)
        {
                val_3 = 0;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  2f);
        this.center = val_2;
        mem[1152921540648336276] = val_2.y;
        mem[1152921540648336280] = val_2.z;
    }
    private void LateUpdate()
    {
        var val_17;
        float val_18;
        float val_19;
        var val_20;
        float val_21;
        float val_22;
        if(null <= 1)
        {
                val_17 = 0;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  2f);
        this.center = val_2;
        mem[1152921540648476948] = val_2.y;
        mem[1152921540648476952] = val_2.z;
        val_20 = 0;
        goto label_9;
        label_22:
        UnityEngine.Transform val_4 = this.transform.GetChild(index:  0);
        UnityEngine.Vector3 val_5 = val_4.position;
        val_21 = this.deltaToScale;
        val_22 = this.center - val_5.x;
        float val_16 = System.Math.Abs(val_22);
        if(val_16 < 0)
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.scale);
            val_21 = val_7.x;
            val_22 = val_7.y;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, t:  1f - (val_16 / (val_21 / 384f)));
        }
        else
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        }
        
        val_18 = val_13.x;
        val_19 = val_13.z;
        val_4.localScale = new UnityEngine.Vector3() {x = val_18, y = val_13.y, z = val_19};
        val_20 = 1;
        label_9:
        if(val_20 < this.transform.childCount)
        {
            goto label_22;
        }
    
    }
    public UIScaleChildOnCenter()
    {
    
    }

}
