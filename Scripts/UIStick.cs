using UnityEngine;
public class UIStick : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform target;
    private UnityEngine.Vector3 丆丆丄丘上业丂丂与;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    
    // Methods
    private void Awake()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
    }
    private void Update()
    {
        if(this.target == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.target.localPosition;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.丆丆丄丘上业丂丂与, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.target.localPosition;
        this.丆丆丄丘上业丂丂与 = val_4;
        mem[1152921535392498132] = val_4.y;
        mem[1152921535392498136] = val_4.z;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public UIStick()
    {
    
    }

}
