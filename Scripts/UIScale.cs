using UnityEngine;
public class UIScale : MonoBehaviour
{
    // Fields
    public UIWidget target;
    private UnityEngine.Vector2 丟丕世万七且万丌丈;
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
        
        if(this.丟丕世万七且万丌丈 == (float)this.target.width)
        {
                if(this.丟丕世万七且万丌丈 == (float)this.target.height)
        {
                return;
        }
        
        }
        
        this.丟丕世万七且万丌丈 = (float)this.target.width;
        mem[1152921535439361988] = (float)this.target.height;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.丟丕世万七且万丌丈, y = (float)this.target.height});
        this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public UIScale()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        this.丟丕世万七且万丌丈 = val_2;
        mem[1152921535439498564] = val_2.y;
    }

}
