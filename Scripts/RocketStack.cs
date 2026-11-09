using UnityEngine;
internal sealed class RocketStack : MonoBehaviour
{
    // Fields
    internal static RocketStack 丄丞丁丈与业上丞丟;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丑一七七丕世丒一丄;
    private float 丙与丐丒上七世与丐;
    public UnityEngine.Transform mytranform;
    
    // Methods
    private void Awake()
    {
        RocketStack.丄丞丁丈与业上丞丟 = this;
        this.mytranform = this.transform;
    }
    internal UnityEngine.GameObject 丄丌丛丗世业丛丆丂()
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_17;
        var val_18;
        var val_19;
        float val_21;
        float val_22;
        float val_23;
        UnityEngine.GameObject val_25;
        goto label_1;
        label_8:
        if(this.丑一七七丕世丒一丄.Item[0] != 0)
        {
            goto label_5;
        }
        
        this.丑一七七丕世丒一丄.RemoveAt(index:  0);
        label_1:
        if(this.丑一七七丕世丒一丄.Count >= 1)
        {
            goto label_8;
        }
        
        label_5:
        if(this.丑一七七丕世丒一丄.Count >= 1)
        {
                val_17 = this.丑一七七丕世丒一丄;
            val_18 = this.丑一七七丕世丒一丄.Item[0];
            val_17.RemoveAt(index:  0);
            val_18.SetActive(value:  true);
            return (UnityEngine.GameObject)val_18;
        }
        
        val_19 = null;
        val_19 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_17;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_20;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  10000f);
        val_21 = val_7.x;
        val_22 = val_7.z;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_23 = val_8.y;
        UnityEngine.GameObject val_9 = 丅丒丗丑丒丙丛不丆.业丕丝丝万丕丛下三(丟丈一下东业一丝丆:  "Rocket", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_21, y = val_7.y, z = val_22}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_8.x, y = val_23, z = val_8.z, w = val_8.w}, 不丝丄丒丌丐一一与:  0);
        goto label_27;
        label_17:
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  "Rocket");
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  10000f);
        val_21 = val_12.x;
        val_22 = val_12.z;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        val_23 = val_13.y;
        if(val_10 != null)
        {
                var val_14 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_25 = 0;
        }
        
        label_27:
        val_18 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_25, position:  new UnityEngine.Vector3() {x = val_21, y = val_12.y, z = val_22}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_23, z = val_13.z, w = val_13.w});
        if(val_18 != null)
        {
            goto label_36;
        }
        
        label_20:
        val_18 = 0;
        label_36:
        val_17 = this.mytranform;
        val_18.transform.parent = val_17;
        return (UnityEngine.GameObject)val_18;
    }
    internal void 丕下丙丈丘丛且七丆(UnityEngine.GameObject 丆且丑丗丛丄丕丂丄)
    {
        float val_8;
        float val_9;
        float val_10;
        UnityEngine.Rigidbody val_1 = 丆且丑丗丛丄丕丂丄.GetComponent<UnityEngine.Rigidbody>();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if(val_1 != null)
        {
                val_8 = val_2.x;
            val_9 = val_2.y;
            val_10 = val_2.z;
            val_1.velocity = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
            val_1.isKinematic = false;
        }
        else
        {
                val_8 = val_2.x;
            val_9 = val_2.y;
            val_10 = val_2.z;
            val_1.velocity = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
            val_1.isKinematic = false;
        }
        
        val_1.useGravity = false;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_1.angularVelocity = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  10000f);
        丆且丑丗丛丄丕丂丄.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        丆且丑丗丛丄丕丂丄.SetActive(value:  false);
        this.丙与丐丒上七世与丐 = UnityEngine.Time.realtimeSinceStartup;
        this.丑一七七丕世丒一丄.Add(item:  丆且丑丗丛丄丕丂丄);
    }
    private void OnDestroy()
    {
        RocketStack.丄丞丁丈与业上丞丟 = 0;
    }
    public RocketStack()
    {
        this.丑一七七丕世丒一丄 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
