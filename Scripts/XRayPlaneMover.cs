using UnityEngine;
internal sealed class XRayPlaneMover : PGBehaviour
{
    // Fields
    public float delta;
    
    // Methods
    private void OnEnable()
    {
        var val_20;
        var val_21;
        var val_24;
        var val_25;
        var val_26;
        val_20 = this;
        val_21 = null;
        val_21 = null;
        this.丌丟丄业且三丛丕丄().parent = 丝丙与东丈不丙三丟().丌丟丄业且三丛丕丄();
        this.gameObject.layer = 0;
        System.Collections.IEnumerator val_6 = this.transform.GetEnumerator();
        label_27:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_24 = val_6.Current;
        if(val_24 != null)
        {
                val_24 = 0;
        }
        
        val_24.gameObject.layer = 0;
        goto label_27;
        label_14:
        val_25 = 0;
        val_26 = 0;
        if(val_6 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_6.Dispose();
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        val_20 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.MeshRenderer>().sharedMaterial;
        val_20.SetFloat(name:  "_AndroidFix", value:  1f);
    }
    private void LateUpdate()
    {
        var val_14 = null;
        UnityEngine.Vector3 val_4 = 丝丙与东丈不丙三丟().丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_7 = 丝丙与东丈不丙三丟().丌丟丄业且三丛丕丄().forward;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.delta);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_13 = 丝丙与东丈不丙三丟().丌丟丄业且三丛丕丄().rotation;
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
    }
    public XRayPlaneMover()
    {
        this.delta = 1f;
    }

}
