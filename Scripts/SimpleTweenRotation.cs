using UnityEngine;
public class SimpleTweenRotation : SimpleTween
{
    // Fields
    public UnityEngine.Transform _target;
    public UnityEngine.Vector3 fromRotation;
    public UnityEngine.Vector3 toRotation;
    public UnityEngine.Quaternion initial;
    
    // Properties
    public UnityEngine.Transform 丘与丈丘丒丂丁丛丟 { get; }
    
    // Methods
    public UnityEngine.Transform get_Target()
    {
        UnityEngine.Transform val_3;
        if(this._target == 0)
        {
                this._target = this.transform;
            return val_3;
        }
        
        val_3 = this._target;
        return val_3;
    }
    public void PlayCustom(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        this.fromRotation = 丈丗与丞一上且上上;
        mem[1152921539478997780] = 丈丗与丞一上且上上.y;
        mem[1152921539478997784] = 丈丗与丞一上且上上.z;
        this.toRotation = 专丂丕丗丗东世丞下;
        mem[1152921539478997792] = 专丂丕丗丗东世丞下.y;
        mem[1152921539478997796] = 专丂丕丗丗东世丞下.z;
        mem[1152921539478997744] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    public void PlayCustom(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        mem[1152921539479113836] = 与丈业丛丝丒丙一丏;
        this.fromRotation = 丈丗与丞一上且上上;
        mem[1152921539479113876] = 丈丗与丞一上且上上.y;
        mem[1152921539479113880] = 丈丗与丞一上且上上.z;
        this.toRotation = 专丂丕丗丗东世丞下;
        mem[1152921539479113888] = 专丂丕丗丗东世丞下.y;
        mem[1152921539479113892] = 专丂丕丗丗东世丞下.z;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921539479113848] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921539479113840] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    public override void GetInitial()
    {
        UnityEngine.Quaternion val_2 = this.Target.localRotation;
        this.initial = val_2;
        mem[1152921539479234092] = val_2.y;
        mem[1152921539479234096] = val_2.z;
        mem[1152921539479234100] = val_2.w;
    }
    public override void SetInitial()
    {
        this.Target.localRotation = new UnityEngine.Quaternion() {x = this.initial, y = V9.16B, z = V10.16B, w = V11.16B};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.fromRotation, y = V10.16B, z = V9.16B});
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.toRotation, y = val_2.y, z = val_2.z});
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, b:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, t:  丙业与丙丗丝不丈东);
        this.Target.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    public SimpleTweenRotation()
    {
    
    }

}
