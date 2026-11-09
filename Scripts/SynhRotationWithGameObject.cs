using UnityEngine;
public class SynhRotationWithGameObject : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform gameObject;
    public bool transformPos;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.Vector3 addpos;
    
    // Methods
    private void Start()
    {
        this.万东万丆专丌丕丐丗 = this.transform;
    }
    private void Update()
    {
        UnityEngine.Quaternion val_1 = this.gameObject.rotation;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
        if(this.transformPos == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.gameObject.TransformPoint(position:  new UnityEngine.Vector3() {x = this.addpos, y = val_1.y, z = val_1.z});
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public SynhRotationWithGameObject()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.addpos = val_1;
        mem[1152921540464427860] = val_1.y;
        mem[1152921540464427864] = val_1.z;
    }

}
