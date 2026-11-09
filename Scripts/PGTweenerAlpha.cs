using UnityEngine;
internal sealed class PGTweenerAlpha : PGTweener
{
    // Fields
    private float fromAlpha;
    private float toAlpha;
    private UIWidget _widget;
    
    // Methods
    internal void 丁世丁丈丒丗丙丌不(UIWidget 世丌丌丙丞丟下东丞)
    {
        this._widget = 世丌丌丙丞丟下东丞;
    }
    internal void 丗万丞丒东万丂丛三(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下)
    {
        this.fromAlpha = 丈丗与丞一上且上上;
        this.toAlpha = 专丂丕丗丗东世丞下;
        mem[1152921538185137876] = 0;
        mem[1152921538185137872] = 1;
        mem[1152921538185137888] = ???;
        this.专丞丆下丏丛世丁丁();
    }
    internal void 丗万丞丒东万丂丛三(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        mem[1152921538185253984] = 与丈业丛丝丒丙一丏;
        this.fromAlpha = 丈丗与丞一上且上上;
        this.toAlpha = 专丂丕丗丗东世丞下;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921538185253992] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921538185253972] = 0;
        mem[1152921538185253968] = 1;
        mem[1152921538185253984] = ???;
        this.专丞丆下丏丛世丁丁();
    }
    protected override void 丕丆丞丅上且丌丈丑()
    {
        if(this._widget == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(UIWidget).__il2cppRuntimeField_1A8;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        float val_10;
        var val_11;
        val_10 = 丙业与丙丗丝不丈东;
        val_11 = this;
        if(this._widget == 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Mathf.Lerp(a:  this.fromAlpha, b:  this.toAlpha, t:  val_10);
        val_11 = ???;
        val_10 = ???;
        goto typeof(UIWidget).__il2cppRuntimeField_1A8;
    }
    public PGTweenerAlpha()
    {
    
    }

}
