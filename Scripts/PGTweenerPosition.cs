using UnityEngine;
internal class PGTweenerPosition : PGTweener
{
    // Fields
    private UnityEngine.Vector3 fromPosition;
    private UnityEngine.Vector3 toPosition;
    
    // Methods
    internal void 丗万丞丒东万丂丛三(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        this.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 与丈业丛丝丒丙一丏:  null, 丁世一与丝丐丏丒丁:  false, 丛丆丁业东上丁丆丘:  0);
    }
    internal void 丗万丞丒东万丂丛三(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, bool 丁世一与丝丐丏丒丁, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        bool val_1 = 丁世一与丝丐丏丒丁;
        mem[1152921538185854944] = 与丈业丛丝丒丙一丏;
        this.fromPosition = 丈丗与丞一上且上上;
        mem[1152921538185854972] = 丈丗与丞一上且上上.y;
        mem[1152921538185854976] = 丈丗与丞一上且上上.z;
        this.toPosition = 专丂丕丗丗东世丞下;
        mem[1152921538185854936] = val_1;
        mem[1152921538185854984] = 专丂丕丗丗东世丞下.y;
        mem[1152921538185854988] = 专丂丕丗丗东世丞下.z;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921538185854952] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921538185854932] = 0;
        mem[1152921538185854928] = 1;
        mem[1152921538185854944] = val_1;
        this.专丞丆下丏丛世丁丁();
    }
    protected override void 丕丆丞丅上且丌丈丑()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 == null)
        {
            goto label_0;
        }
        
        if(W20 == 0)
        {
            goto label_1;
        }
        
        label_2:
        val_1.localPosition = new UnityEngine.Vector3() {x = this.fromPosition, y = V9.16B, z = V8.16B};
        return;
        label_0:
        if(W20 != 0)
        {
            goto label_2;
        }
        
        label_1:
        val_1.position = new UnityEngine.Vector3() {x = this.fromPosition, y = V9.16B, z = V8.16B};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Transform val_1 = this.transform;
        if(!=0)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.fromPosition, y = V10.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this.toPosition, y = V12.16B, z = V9.16B}, t:  丙业与丙丗丝不丈东);
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.fromPosition, y = V10.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this.toPosition, y = V12.16B, z = V9.16B}, t:  丙业与丙丗丝不丈东);
        val_1.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public PGTweenerPosition()
    {
    
    }

}
