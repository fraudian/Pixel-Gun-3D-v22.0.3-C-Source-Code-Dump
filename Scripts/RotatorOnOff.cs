using UnityEngine;
internal sealed class RotatorOnOff : MonoBehaviour
{
    // Fields
    private bool isRotate;
    private bool isRotateOnStart;
    public UnityEngine.Vector3 eulersPerSecond;
    private UnityEngine.Transform rotateTransform;
    
    // Methods
    private void Start()
    {
        this.isRotate = this.isRotateOnStart;
    }
    private void Update()
    {
        UnityEngine.Transform val_4;
        if(this.isRotate == false)
        {
                return;
        }
        
        val_4 = this.rotateTransform;
        if(val_4 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.eulersPerSecond, y = V9.16B, z = V10.16B}, d:  RealTime.deltaTime);
        this.rotateTransform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    internal void 丒丕丝丄与不三丅丘()
    {
        this.isRotate = true;
    }
    internal void 且丐丐丞丘丐丐丗丏()
    {
        this.isRotate = false;
    }
    public RotatorOnOff()
    {
        this.eulersPerSecond = 0;
        mem[1152921540138876244] = 0;
    }

}
