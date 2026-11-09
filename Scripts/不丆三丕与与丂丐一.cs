using UnityEngine;
public class 不丆三丕与与丂丐一 : CustomYieldInstruction
{
    // Fields
    private float 丝世丘与丁上专三万;
    private float 丑丝丗万且丌一世丌;
    private float 丈丑且丂丘丕丆丌丙;
    
    // Properties
    public override bool 丂丟下且且三且上丒 { get; }
    
    // Methods
    public 不丆三丕与与丂丐一(float 丆丐七丅丆丗丛上与)
    {
        this.丑丝丗万且丌一世丌 = UnityEngine.Time.unscaledTime;
        this.丈丑且丂丘丕丆丌丙 = System.Math.Abs(丆丐七丅丆丗丛上与);
    }
    public override bool get_keepWaiting()
    {
        float val_1 = UnityEngine.Time.unscaledTime;
        val_1 = val_1 - this.丑丝丗万且丌一世丌;
        val_1 = this.丝世丘与丁上专三万 + val_1;
        this.丝世丘与丁上专三万 = val_1;
        this.丑丝丗万且丌一世丌 = UnityEngine.Time.unscaledTime;
        return (bool)(this.丝世丘与丁上专三万 < 0) ? 1 : 0;
    }

}
