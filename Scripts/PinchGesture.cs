using UnityEngine;
internal sealed class PinchGesture : BaseGesture
{
    // Fields
    private float 不丕丅丆丕丙丑丑丅;
    private float 七东丙丘丑丛丒丄丑;
    private float 丕世丒丞世丂丌丐丏;
    
    // Properties
    public float 丙万丘不一三专丏下 { get; }
    public float 丌且丙丏且上七丕不 { get; }
    public float 丌世一丏丟丈下七丙 { get; }
    
    // Methods
    public float get_Delta()
    {
        return (float)this.七东丙丘丑丛丒丄丑;
    }
    public float get_PinchFactor()
    {
        if(W8 == 0)
        {
                return 1f;
        }
        
        float val_1 = this.PinchDistance;
        val_1 = this.不丕丅丆丕丙丑丑丅 / val_1;
        return (float)val_1;
    }
    public float get_PinchDistance()
    {
        if(true == 0)
        {
                return 0f;
        }
        
        UnityEngine.Touch val_4 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Item[X21.Item[0]];
        TouchManager val_5 = Rilisoft.Singleton<TouchManager>.Instance;
        this = val_5.CurrentTouches;
        UnityEngine.Touch val_8 = this.Item[val_5.Item[1]];
        float val_9 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        return 0f;
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
        int val_3 = X21.Item[0];
        UnityEngine.Touch val_4 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Item[val_3];
        UnityEngine.Touch val_8 = Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Item[val_3.Item[1]];
        this.不丕丅丆丕丙丑丑丅 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        this.七东丙丘丑丛丒丄丑 = 0f;
        this.丕世丒丞世丂丌丐丏 = 0f;
        this.丙丌下上三万一丁上();
    }
    protected override void 不与与丌丗丞丒专业()
    {
        this.不丕丅丆丕丙丑丑丅 = -1f;
        this.七东丙丘丑丛丒丄丑 = 0f;
        this.丕世丒丞世丂丌丐丏 = 0f;
        this.不与与丌丗丞丒专业();
    }
    protected override void 丄与丅下丙丟专丅东()
    {
        float val_3;
        float val_4;
        if(W8 == 0)
        {
                return;
        }
        
        val_3 = this.丕世丒丞世丂丌丐丏;
        if(val_3 == 0f)
        {
            goto label_1;
        }
        
        float val_1 = this.PinchDistance;
        val_1 = this.不丕丅丆丕丙丑丑丅 / val_1;
        val_3 = val_1 - this.丕世丒丞世丂丌丐丏;
        this.七东丙丘丑丛丒丄丑 = val_3;
        if(W8 == 0)
        {
            goto label_2;
        }
        
        label_1:
        val_4 = this.不丕丅丆丕丙丑丑丅 / this.PinchDistance;
        goto label_3;
        label_2:
        val_4 = 1f;
        label_3:
        this.丕世丒丞世丂丌丐丏 = val_4;
    }
    public PinchGesture()
    {
        this.不丕丅丆丕丙丑丑丅 = -1f;
    }

}
