using UnityEngine;
internal class TapGesture : BaseGesture
{
    // Fields
    private float maxTapTime;
    private float maxDistance;
    private float 丌与且上且万七丐丈;
    
    // Methods
    protected override void 上丏丝下丅业丑且世(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.上丏丝下丅业丑且世(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2(), m_AltitudeAngle = ???, m_AzimuthAngle = ???});
        this.丌与且上且万七丐丈 = UnityEngine.Time.time;
    }
    protected override void 丝丞丙三三丗万丛丁(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        this.丝丞丙三三丗万丛丁(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_Position = new UnityEngine.Vector2(), m_RawPosition = new UnityEngine.Vector2(), m_PositionDelta = new UnityEngine.Vector2()});
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 - this.丌与且上且万七丐丈;
        if(val_1 >= 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = 丟下丙丆不东一与丅.position;
        if(this.maxDistance >= 0)
        {
                return;
        }
    
    }
    protected virtual void 世七七业业丘与丂丕(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        UnityEngine.Debug.Log(message:  "tap");
    }
    public TapGesture()
    {
        this.maxTapTime = 0.1f;
        this.maxDistance = 10f;
    }

}
