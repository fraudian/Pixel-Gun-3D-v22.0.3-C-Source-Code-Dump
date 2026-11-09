using UnityEngine;
public class 丕世专丒丁不丁丅丁 : CustomYieldInstruction
{
    // Fields
    private float 丝世丘与丁上专三万;
    private float 丑丝丗万且丌一世丌;
    private float 丈丑且丂丘丕丆丌丙;
    
    // Properties
    public override bool 丂丟下且且三且上丒 { get; }
    
    // Methods
    public 丕世专丒丁不丁丅丁(float 丆丐七丅丆丗丛上与)
    {
        this.丑丝丗万且丌一世丌 = UnityEngine.Time.realtimeSinceStartup;
        this.丈丑且丂丘丕丆丌丙 = System.Math.Abs(丆丐七丅丆丗丛上与);
    }
    public override bool get_keepWaiting()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丑丝丗万且丌一世丌;
        val_1 = this.丝世丘与丁上专三万 + val_1;
        this.丝世丘与丁上专三万 = val_1;
        this.丑丝丗万且丌一世丌 = UnityEngine.Time.realtimeSinceStartup;
        return (bool)(this.丝世丘与丁上专三万 < 0) ? 1 : 0;
    }

}
