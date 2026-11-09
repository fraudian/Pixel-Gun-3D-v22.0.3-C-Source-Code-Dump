using UnityEngine;
internal sealed class SimpleTweenColor : SimpleTween
{
    // Fields
    public UIWidget _target;
    public UnityEngine.Color fromColor;
    public UnityEngine.Color toColor;
    public UnityEngine.Color initial;
    
    // Properties
    public UIWidget 丘与丈丘丒丂丁丛丟 { get; }
    
    // Methods
    public UIWidget get_Target()
    {
        UIWidget val_3;
        if(this._target == 0)
        {
                this._target = this.GetComponent<UIWidget>();
            return val_3;
        }
        
        val_3 = this._target;
        return val_3;
    }
    internal void 丏丘万丒下丐丕丞丈(UnityEngine.Color 丈丗与丞一上且上上, UnityEngine.Color 专丂丕丗丗东世丞下)
    {
        this.fromColor = 丈丗与丞一上且上上;
        mem[1152921539475639956] = 丈丗与丞一上且上上.g;
        mem[1152921539475639960] = 丈丗与丞一上且上上.b;
        mem[1152921539475639964] = 丈丗与丞一上且上上.a;
        this.toColor = 专丂丕丗丗东世丞下;
        mem[1152921539475639972] = 专丂丕丗丗东世丞下.g;
        mem[1152921539475639976] = 专丂丕丗丗东世丞下.b;
        mem[1152921539475639980] = 专丂丕丗丗东世丞下.a;
        mem[1152921539475639920] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    internal void 丏丘万丒下丐丕丞丈(UnityEngine.Color 丈丗与丞一上且上上, UnityEngine.Color 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        this.fromColor = 丈丗与丞一上且上上;
        mem[1152921539475756052] = 丈丗与丞一上且上上.g;
        mem[1152921539475756056] = 丈丗与丞一上且上上.b;
        mem[1152921539475756060] = 丈丗与丞一上且上上.a;
        this.toColor = 专丂丕丗丗东世丞下;
        mem[1152921539475756068] = 专丂丕丗丗东世丞下.g;
        mem[1152921539475756012] = 与丈业丛丝丒丙一丏;
        mem[1152921539475756072] = 专丂丕丗丗东世丞下.b;
        mem[1152921539475756076] = 专丂丕丗丗东世丞下.a;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921539475756024] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921539475756016] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    public override void GetInitial()
    {
        UnityEngine.Color val_2 = this.Target.color;
        this.initial = val_2;
        mem[1152921539475876276] = val_2.g;
        mem[1152921539475876280] = val_2.b;
        mem[1152921539475876284] = val_2.a;
    }
    public override void SetInitial()
    {
        this.Target.color = new UnityEngine.Color() {r = this.initial, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Color val_2 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.fromColor}, b:  new UnityEngine.Color() {r = this.toColor}, t:  丙业与丙丗丝不丈东);
        this.Target.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    public SimpleTweenColor()
    {
    
    }

}
