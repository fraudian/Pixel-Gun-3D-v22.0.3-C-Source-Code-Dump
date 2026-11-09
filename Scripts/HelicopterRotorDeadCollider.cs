using UnityEngine;
internal class HelicopterRotorDeadCollider : DeadCollider
{
    // Fields
    public HelicopterEngine engine;
    
    // Properties
    internal bool 丕不丆丐七上丂不丐 { get; }
    
    // Methods
    internal bool 丑丑一丟丁丒下丒丏()
    {
        HelicopterEngine val_2;
        var val_3;
        val_2 = this;
        if((this.engine.丆丟与丝丘东丝丒且 & 1) != 0)
        {
                val_3 = 0;
            return (bool)(this.engine.且专三丞丞丂且不丝 > 0f) ? 1 : 0;
        }
        
        val_2 = this.engine;
        return (bool)(this.engine.且专三丞丞丂且不丝 > 0f) ? 1 : 0;
    }
    protected override void Awake()
    {
        this.Awake();
        this.engine = this.GetComponentInParent<HelicopterEngine>();
    }
    public HelicopterRotorDeadCollider()
    {
    
    }

}
