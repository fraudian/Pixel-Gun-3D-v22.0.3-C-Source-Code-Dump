using UnityEngine;
internal sealed class SimpleTweenAlpha : SimpleTween
{
    // Fields
    public UIWidget _target;
    public float fromAlpha;
    public float toAlpha;
    public float initial;
    
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
    internal void 丏丘万丒下丐丕丞丈(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下)
    {
        this.fromAlpha = 丈丗与丞一上且上上;
        this.toAlpha = 专丂丕丗丗东世丞下;
        mem[1152921539474798576] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    internal void 丏丘万丒下丐丕丞丈(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        mem[1152921539474914668] = 与丈业丛丝丒丙一丏;
        this.fromAlpha = 丈丗与丞一上且上上;
        this.toAlpha = 专丂丕丗丗东世丞下;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921539474914680] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921539474914672] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    public override void GetInitial()
    {
        UIWidget val_1 = this.Target;
        this.initial = ;
    }
    public override void SetInitial()
    {
        if(this.Target == null)
        {
            
        }
    
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        float val_2 = UnityEngine.Mathf.Lerp(a:  this.fromAlpha, b:  this.toAlpha, t:  丙业与丙丗丝不丈东);
        if(this.Target == null)
        {
            
        }
    
    }
    public SimpleTweenAlpha()
    {
    
    }

}
