using UnityEngine;
public class JKeepCharOnPlatform : MonoBehaviour
{
    // Fields
    public float verticalOffset;
    private System.Collections.Hashtable 上丘丂丌丑东上且丗;
    private UnityEngine.Vector3 丙与下丄专丟丞丄丒;
    
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        var val_9;
        var val_10;
        float val_11;
        val_9 = 丘丛丏丘丝七世七丅;
        UnityEngine.Component val_2 = val_9.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_10 = 0;
        if( == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = val_9.transform;
        val_11 = height;
        UnityEngine.Vector3 val_7 = center;
        float val_10 = 0.5f;
        val_10 =  * val_10;
        val_7.y = val_10 - val_7.y;
         = this.verticalOffset + val_7.y;
        val_9 = val_9.transform;
        val_10 = ;
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Transform val_1 = 丘丛丏丘丝七世七丅.transform;
        if(this.上丘丂丌丑东上且丗 == null)
        {
            
        }
    
    }
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.丙与下丄专丟丞丄丒 = val_2;
        mem[1152921530768995452] = val_2.y;
        mem[1152921530768995456] = val_2.z;
    }
    private void Update()
    {
        float val_8;
        var val_15;
        var val_16;
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.丙与下丄专丟丞丄丒, y = V10.16B, z = V9.16B});
        this.丙与下丄专丟丞丄丒 = val_2;
        mem[1152921530769119788] = val_2.y;
        mem[1152921530769119792] = val_2.z;
        label_28:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(this.上丘丂丌丑东上且丗.MoveNext() == false)
        {
            goto label_10;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Vector3 val_9 = null.velocity;
        if(val_9.y > 0f)
        {
                if(val_9.y > val_3.y)
        {
            goto label_28;
        }
        
        }
        
        UnityEngine.Vector3 val_10 = null.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_2.y + val_8, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = 0f, z = val_3.z});
        null.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        goto label_28;
        label_10:
        val_15 = 0;
        val_16 = 0;
        if(this.上丘丂丌丑东上且丗 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            this.上丘丂丌丑东上且丗.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public JKeepCharOnPlatform()
    {
        this.verticalOffset = 0.5f;
        this.上丘丂丌丑东上且丗 = new System.Collections.Hashtable();
    }

}
