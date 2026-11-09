using UnityEngine;
internal sealed class DragGesture : BaseGesture
{
    // Fields
    private UnityEngine.Vector3 七东丙丘丑丛丒丄丑;
    private UnityEngine.Vector2 丗与与丌丈与一丁丆;
    private UnityEngine.Vector2 丐丅丑丂丞专丙东丁;
    
    // Properties
    public UnityEngine.Vector2 丙万丘不一三专丏下 { get; }
    public UnityEngine.Vector2 丘丂不不下丕丁下丟 { get; }
    public UnityEngine.Vector2 万丟下丘不世与丗丐 { get; }
    
    // Methods
    public UnityEngine.Vector2 get_Delta()
    {
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.七东丙丘丑丛丒丄丑, y = V8.16B, z = V9.16B});
    }
    public UnityEngine.Vector2 get_Position()
    {
        return new UnityEngine.Vector2() {x = this.丗与与丌丈与一丁丆};
    }
    public UnityEngine.Vector2 get_LastPosition()
    {
        return new UnityEngine.Vector2() {x = this.丐丅丑丂丞专丙东丁};
    }
    protected override void 上丏丝下丅业丑且世(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.上丏丝下丅业丑且世(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.七东丙丘丑丛丒丄丑 = val_2;
        mem[1152921536905888464] = val_2.y;
        mem[1152921536905888468] = val_2.z;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.丗与与丌丈与一丁丆 = val_3;
        mem[1152921536905888476] = val_3.y;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丐丅丑丂丞专丙东丁 = val_4;
        mem[1152921536905888484] = val_4.y;
        if(丟下丙丆不东一与丅.m_FingerId.Count < 1)
        {
                return;
        }
        
        this.丙丌下上三万一丁上();
    }
    protected override void 丝丞丙三三丗万丛丁(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.丝丞丙三三丗万丛丁(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.七东丙丘丑丛丒丄丑 = val_2;
        mem[1152921536906025136] = val_2.y;
        mem[1152921536906025140] = val_2.z;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.丗与与丌丈与一丁丆 = val_3;
        mem[1152921536906025148] = val_3.y;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丐丅丑丂丞专丙东丁 = val_4;
        mem[1152921536906025156] = val_4.y;
        if(丟下丙丆不东一与丅.m_FingerId.Count > 0)
        {
            
        }
        else
        {
                if((public System.Int32 System.Collections.Generic.List<System.Int32>::get_Count()) == 0)
        {
                return;
        }
        
        }
        
        this.不与与丌丗丞丒专业();
    }
    protected override void 丄与丅下丙丟专丅东()
    {
        float val_7;
        UnityEngine.Vector2 val_8;
        if(true == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        val_7 = val_1.z;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_7});
        val_8 = this.丐丅丑丂丞专丙东丁;
        this.丗与与丌丈与一丁丆 = val_2;
        mem[1152921536906149484] = val_2.y;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_8, y = val_1.y}, rhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})) != false)
        {
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.丗与与丌丈与一丁丆, y = val_7}, b:  new UnityEngine.Vector2() {x = this.丐丅丑丂丞专丙东丁, y = val_8});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            this.七东丙丘丑丛丒丄丑 = val_6;
            mem[1152921536906149472] = val_6.y;
            mem[1152921536906149476] = val_6.z;
        }
        
        this.丐丅丑丂丞专丙东丁 = this.丗与与丌丈与一丁丆;
        mem[1152921536906149492] = ???;
    }
    public DragGesture()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丗与与丌丈与一丁丆 = val_1;
        mem[1152921536906261484] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丐丅丑丂丞专丙东丁 = val_2;
        mem[1152921536906261492] = val_2.y;
    }

}
