using UnityEngine;
internal class PositionConsider : MonoBehaviour
{
    // Fields
    private bool 丑丟专丏丏丄丐丁丟;
    public UnityEngine.Transform transformToConsider;
    public UnityEngine.Vector3 offset;
    private UnityEngine.Vector3 丌丐专丅且丝三丛丈;
    
    // Properties
    set; }
    
    // Methods
    internal void 丛一万丐世丈不丕丝(bool 丙业与丙丗丝不丈东)
    {
        if((this.丑丟专丏丏丄丐丁丟 != false) && (丙业与丙丗丝不丈东 != true))
        {
                this.transform.localPosition = new UnityEngine.Vector3() {x = this.丌丐专丅且丝三丛丈, y = V9.16B, z = V10.16B};
        }
        
        this.丑丟专丏丏丄丐丁丟 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.丌丐专丅且丝三丛丈 = val_2;
        mem[1152921537065519912] = val_2.y;
        mem[1152921537065519916] = val_2.z;
    }
    private void Update()
    {
        if(this.丑丟专丏丏丄丐丁丟 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transformToConsider.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public PositionConsider()
    {
    
    }

}
