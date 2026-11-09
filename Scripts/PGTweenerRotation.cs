using UnityEngine;
internal class PGTweenerRotation : PGTweener
{
    // Fields
    private UnityEngine.Vector3 fromRotation;
    private UnityEngine.Vector3 toRotation;
    
    // Methods
    internal void 丗万丞丒东万丂丛三(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        this.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 与丈业丛丝丒丙一丏:  null, 丁世一与丝丐丏丒丁:  false, 丛丆丁业东上丁丆丘:  0);
    }
    internal void 丗万丞丒东万丂丛三(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, bool 丁世一与丝丐丏丒丁, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        bool val_1 = 丁世一与丝丐丏丒丁;
        mem[1152921538186439520] = 与丈业丛丝丒丙一丏;
        this.fromRotation = 丈丗与丞一上且上上;
        mem[1152921538186439548] = 丈丗与丞一上且上上.y;
        mem[1152921538186439552] = 丈丗与丞一上且上上.z;
        this.toRotation = 专丂丕丗丗东世丞下;
        mem[1152921538186439512] = val_1;
        mem[1152921538186439560] = 专丂丕丗丗东世丞下.y;
        mem[1152921538186439564] = 专丂丕丗丗东世丞下.z;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921538186439528] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921538186439508] = 0;
        mem[1152921538186439504] = 1;
        mem[1152921538186439520] = val_1;
        this.专丞丆下丏丛世丁丁();
    }
    protected override void 丕丆丞丅上且丌丈丑()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(!=0)
        {
                UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.fromRotation, y = V9.16B, z = V8.16B});
            val_1.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            return;
        }
        
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.fromRotation, y = V9.16B, z = V8.16B});
        val_1.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Transform val_1 = this.transform;
        if(W21 != 0)
        {
                UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.fromRotation, y = V10.16B, z = V9.16B});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.toRotation, y = val_2.y, z = val_2.z});
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, b:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, t:  丙业与丙丗丝不丈东);
            val_1.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            return;
        }
        
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.fromRotation, y = V10.16B, z = V9.16B});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.toRotation, y = val_5.y, z = val_5.z});
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, b:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, t:  丙业与丙丗丝不丈东);
        val_1.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    public PGTweenerRotation()
    {
    
    }

}
