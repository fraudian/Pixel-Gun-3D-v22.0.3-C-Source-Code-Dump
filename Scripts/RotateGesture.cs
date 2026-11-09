using UnityEngine;
internal sealed class RotateGesture : BaseGesture
{
    // Fields
    private UnityEngine.Vector2 丑丘丅丘不丛不与丕;
    private float 万与丐丅与丑一丂东;
    public float _angleDelta;
    
    // Properties
    public UnityEngine.Vector2 丏丘不丆且上丏业丕 { get; }
    public float 下丟下丅专丑丟丌丅 { get; }
    public float 业丁丕七丑业专万丏 { get; }
    private UnityEngine.Vector2 丑七业丗丘丅丐七丙 { get; }
    
    // Methods
    public UnityEngine.Vector2 get_RotateAround()
    {
        var val_18;
        int val_19;
        var val_20;
        int val_21;
        val_18 = this;
        UnityEngine.Touch val_4 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Item[X21.Item[0]];
        val_19 = 专三三与三且一且一();
        if(val_19 != 2)
        {
            goto label_6;
        }
        
        val_18 = X22.Item[0];
        val_20 = public UnityEngine.Touch System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Touch>::get_Item(System.Int32 key);
        val_21 = val_18;
        goto label_8;
        label_6:
        val_19 = X22.Item[1];
        UnityEngine.Touch val_10 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Item[val_19];
        if(专三三与三且一且一() != 2)
        {
            goto label_10;
        }
        
        TouchManager val_12 = Rilisoft.Singleton<TouchManager>.Instance;
        val_18 = val_12.CurrentTouches;
        val_20 = public UnityEngine.Touch System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Touch>::get_Item(System.Int32 key);
        val_21 = val_12.Item[1];
        label_8:
        UnityEngine.Touch val_15 = val_18.Item[val_21];
        return new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
        label_10:
        UnityEngine.Vector3 val_16 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        return new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
    }
    public float get_Angle()
    {
        UnityEngine.Vector2 val_1 = this.丄业业不丞万下丕业();
        return UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = this.丑丘丅丘不丛不与丕, y = V9.16B}, to:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
    }
    public float get_AngleDelta()
    {
        return (float)this._angleDelta;
    }
    private UnityEngine.Vector2 丄业业不丞万下丕业()
    {
        UnityEngine.Touch val_4 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Item[X21.Item[0]];
        TouchManager val_5 = Rilisoft.Singleton<TouchManager>.Instance;
        UnityEngine.Touch val_8 = val_5.CurrentTouches.Item[val_5.Item[1]];
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        return new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
    }
    protected override void 上丏丝下丅业丑且世(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.上丏丝下丅业丑且世(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        if(丟下丙丆不东一与丅.m_FingerId.Count < 2)
        {
                return;
        }
    
    }
    protected override void 丝丞丙三三丗万丛丁(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.丝丞丙三三丗万丛丁(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        if(丟下丙丆不东一与丅.m_FingerId.Count > 1)
        {
                return;
        }
        
        if((public System.Int32 System.Collections.Generic.List<System.Int32>::get_Count()) == 0)
        {
                return;
        }
    
    }
    protected override void 丙丌下上三万一丁上()
    {
        UnityEngine.Vector2 val_1 = this.丄业业不丞万下丕业();
        this.丑丘丅丘不丛不与丕 = val_1;
        mem[1152921536919245760] = val_1.y;
        this.万与丐丅与丑一丂东 = 0f;
        this._angleDelta = 0f;
        this.丙丌下上三万一丁上();
    }
    protected override void 不与与丌丗丞丒专业()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丑丘丅丘不丛不与丕 = val_1;
        mem[1152921536919357760] = val_1.y;
        this.万与丐丅与丑一丂东 = 0f;
        this._angleDelta = 0f;
        this.不与与丌丗丞丒专业();
    }
    protected override void 丄与丅下丙丟专丅东()
    {
        float val_3;
        if(W8 == 0)
        {
                return;
        }
        
        val_3 = this.万与丐丅与丑一丂东;
        if(val_3 != 0f)
        {
                val_3 = this.Angle - this.万与丐丅与丑一丂东;
            this._angleDelta = val_3;
        }
        
        this.万与丐丅与丑一丂东 = this.Angle;
    }
    public RotateGesture()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丑丘丅丘不丛不与丕 = val_1;
        mem[1152921536919581760] = val_1.y;
    }

}
