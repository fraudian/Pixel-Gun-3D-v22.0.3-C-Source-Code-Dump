using UnityEngine;
internal class PGTweenerScale : PGTweener
{
    // Fields
    private UnityEngine.Vector3 fromScale;
    private UnityEngine.Vector3 toScale;
    
    // Methods
    internal void 丗万丞丒东万丂丛三(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        this.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 与丈业丛丝丒丙一丏:  null, 丛丆丁业东上丁丆丘:  0);
    }
    internal void 丗万丞丒东万丂丛三(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        mem[1152921538187024096] = 与丈业丛丝丒丙一丏;
        this.fromScale = 丈丗与丞一上且上上;
        mem[1152921538187024124] = 丈丗与丞一上且上上.y;
        mem[1152921538187024128] = 丈丗与丞一上且上上.z;
        this.toScale = 专丂丕丗丗东世丞下;
        mem[1152921538187024136] = 专丂丕丗丗东世丞下.y;
        mem[1152921538187024140] = 专丂丕丗丗东世丞下.z;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921538187024104] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921538187024084] = 0;
        mem[1152921538187024080] = 1;
        mem[1152921538187024096] = ???;
        this.专丞丆下丏丛世丁丁();
    }
    protected override void 丕丆丞丅上且丌丈丑()
    {
        this.transform.localScale = new UnityEngine.Vector3() {x = this.fromScale, y = V9.16B, z = V10.16B};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.fromScale, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.toScale, y = V11.16B, z = V9.16B}, t:  丙业与丙丗丝不丈东);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public PGTweenerScale()
    {
    
    }

}
