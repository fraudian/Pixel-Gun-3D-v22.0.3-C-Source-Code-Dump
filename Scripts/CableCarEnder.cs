using UnityEngine;
public class CableCarEnder : PGBehaviour
{
    // Fields
    private UnityEngine.Vector3 丛上丙丄丄七丈且丅;
    private CableCar 丟丏丝丆七丈世丛丙;
    
    // Properties
    internal UnityEngine.Vector3 丂七丅一一丒且万丕 { get; }
    
    // Methods
    private void Awake()
    {
        this.丟丏丝丆七丈世丛丙 = this.GetComponentInParent<CableCar>();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    internal UnityEngine.Vector3 下丏丟丁丌丒丝丘丝()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.丛上丙丄丄七丈且丅, y = V11.16B, z = V10.16B});
    }
    public CableCarEnder()
    {
        this.丛上丙丄丄七丈且丅 = 0;
        mem[1152921525571455088] = 0;
    }

}
