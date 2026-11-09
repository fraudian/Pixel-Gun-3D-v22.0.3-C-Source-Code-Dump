using UnityEngine;
public class SimpleTweenPosition : SimpleTween
{
    // Fields
    public UnityEngine.Transform _target;
    public UnityEngine.Vector3 fromPosition;
    public UnityEngine.Vector3 toPosition;
    public UnityEngine.Vector3 initial;
    
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
        this.fromPosition = 丈丗与丞一上且上上;
        mem[1152921539478156436] = 丈丗与丞一上且上上.y;
        mem[1152921539478156440] = 丈丗与丞一上且上上.z;
        this.toPosition = 专丂丕丗丗东世丞下;
        mem[1152921539478156448] = 专丂丕丗丗东世丞下.y;
        mem[1152921539478156452] = 专丂丕丗丗东世丞下.z;
        mem[1152921539478156400] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    public void PlayCustom(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘)
    {
        mem[1152921539478272492] = 与丈业丛丝丒丙一丏;
        this.fromPosition = 丈丗与丞一上且上上;
        mem[1152921539478272532] = 丈丗与丞一上且上上.y;
        mem[1152921539478272536] = 丈丗与丞一上且上上.z;
        this.toPosition = 专丂丕丗丗东世丞下;
        mem[1152921539478272544] = 专丂丕丗丗东世丞下.y;
        mem[1152921539478272548] = 专丂丕丗丗东世丞下.z;
        if(丛丆丁业东上丁丆丘 != null)
        {
                mem[1152921539478272504] = 丛丆丁业东上丁丆丘;
        }
        
        mem[1152921539478272496] = 0;
        this.专丞丆下丏丛世丁丁();
    }
    public override void GetInitial()
    {
        UnityEngine.Vector3 val_2 = this.Target.localPosition;
        this.initial = val_2;
        mem[1152921539478392748] = val_2.y;
        mem[1152921539478392752] = val_2.z;
    }
    public override void SetInitial()
    {
        this.Target.localPosition = new UnityEngine.Vector3() {x = this.initial, y = V9.16B, z = V10.16B};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        float val_2 = 1f - 丙业与丙丗丝不丈东;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.fromPosition, y = V10.16B, z = V9.16B}, d:  val_2);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.toPosition, y = val_3.y, z = val_2}, d:  丙业与丙丗丝不丈东);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.Target.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public SimpleTweenPosition()
    {
    
    }

}
