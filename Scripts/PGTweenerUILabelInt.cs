using UnityEngine;
internal sealed class PGTweenerUILabelInt : PGTweener
{
    // Fields
    private UILabel uiLabel;
    private int fromInt;
    private int toInt;
    private float oneTickDuration;
    private float maxAnimationTime;
    
    // Methods
    internal void 丗万丞丒东万丂丛三(int 丈丗与丞一上且上上, int 专丂丕丗丗东世丞下)
    {
        float val_4 = this.oneTickDuration;
        val_4 = val_4 * ((float)UnityEngine.Mathf.Abs(value:  专丂丕丗丗东世丞下 - 丈丗与丞一上且上上));
        mem[1152921538187492576] = val_4;
        float val_3 = UnityEngine.Mathf.Min(a:  val_4, b:  this.maxAnimationTime);
        this.fromInt = 丈丗与丞一上且上上;
        this.toInt = 专丂丕丗丗东世丞下;
        mem[1152921538187492564] = 0;
        mem[1152921538187492560] = 1;
        mem[1152921538187492576] = UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished;
        this.专丞丆下丏丛世丁丁();
    }
    internal void 丗万丞丒东万丂丛三(int 丈丗与丞一上且上上, int 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UILabel 七丐丞丑丑丕世丙七, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        mem[1152921538187612768] = 与丈业丛丝丒丙一丏;
        this.fromInt = 丈丗与丞一上且上上;
        this.toInt = 专丂丕丗丗东世丞下;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921538187612776] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921538187612756] = 0;
        mem[1152921538187612752] = 1;
        mem[1152921538187612768] = ???;
        this.专丞丆下丏丛世丁丁();
    }
    protected override void 丕丆丞丅上且丌丈丑()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.uiLabel, 丕丗丘丑丛与丑业丒:  this.fromInt);
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.uiLabel, 丕丗丘丑丛与丑业丒:  UnityEngine.Mathf.FloorToInt(f:  UnityEngine.Mathf.Lerp(a:  (float)this.fromInt, b:  (float)this.toInt, t:  丙业与丙丗丝不丈东)));
    }
    public PGTweenerUILabelInt()
    {
        this.oneTickDuration = 0.01f;
        this.maxAnimationTime = 2f;
    }

}
