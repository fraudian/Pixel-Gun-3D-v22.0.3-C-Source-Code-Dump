using UnityEngine;
public class DragTrigerer : MonoBehaviour
{
    // Fields
    public bool isDraging;
    public UnityEngine.Vector2 TotalDelta;
    public UnityEngine.Vector2 Delta;
    public DragTrigerer[] coTriggers;
    
    // Methods
    private void OnEnable()
    {
        this.Reset();
    }
    private void OnApplicationFocus(bool hasFocus)
    {
        this.Reset();
    }
    private void OnDragStart()
    {
        this.Reset();
    }
    public void OnDrag(UnityEngine.Vector2 delta)
    {
        this.isDraging = true;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.TotalDelta, y = V10.16B}, b:  new UnityEngine.Vector2() {x = delta.x, y = delta.y});
        this.TotalDelta = val_1;
        mem[1152921525910114880] = val_1.y;
        this.Delta = delta;
        mem[1152921525910114888] = delta.y;
        this.丑世丟丗且上东丟与();
    }
    private void OnDragEnd()
    {
        this.Reset();
    }
    public void Reset()
    {
        this.isDraging = false;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.TotalDelta = val_1;
        mem[1152921525910338880] = val_1.y;
        this.丑世丟丗且上东丟与();
    }
    private void 丑世丟丗且上东丟与()
    {
        UnityEngine.Vector2 val_2;
        if(this.coTriggers == null)
        {
                return;
        }
        
        if(this.coTriggers.Length == 0)
        {
                return;
        }
        
        if(this.coTriggers.Length < 1)
        {
                return;
        }
        
        do
        {
            DragTrigerer val_3 = this.coTriggers[0];
            if(val_3 != 0)
        {
                if(val_3 != null)
        {
                this.coTriggers[0x0][0].isDraging = this.isDraging;
            this.coTriggers[0x0][0].TotalDelta = this.TotalDelta;
            mem2[0] = UnityEngine.Object.__il2cppRuntimeField_127;
            val_2 = this.Delta;
        }
        else
        {
                this.coTriggers[0x0][0].isDraging = this.isDraging;
            this.coTriggers[0x0][0].TotalDelta = this.TotalDelta;
            mem2[0] = ???;
            val_2 = this.Delta;
        }
        
            this.coTriggers[0x0][0].Delta = val_2;
            mem2[0] = ???;
        }
        
        }
        while((0 + 1) < this.coTriggers.Length);
    
    }
    public DragTrigerer()
    {
    
    }

}
