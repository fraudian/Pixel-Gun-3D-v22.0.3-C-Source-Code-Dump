using UnityEngine;
public class TweenRotation : UITweener
{
    // Fields
    public UnityEngine.Vector3 from;
    public UnityEngine.Vector3 to;
    public bool quaternionLerp;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    
    // Properties
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    public UnityEngine.Quaternion 七丅丗丆丒丌丑丝不 { get; set; }
    public UnityEngine.Quaternion 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    public UnityEngine.Transform get_cachedTransform()
    {
        UnityEngine.Transform val_3;
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                this.丐一丗丛丕世丘东丁 = this.transform;
            return val_3;
        }
        
        val_3 = this.丐一丗丛丕世丘东丁;
        return val_3;
    }
    public UnityEngine.Quaternion get_rotation()
    {
        return this.value;
    }
    public void set_rotation(UnityEngine.Quaternion 丙业与丙丗丝不丈东)
    {
        this.value = new UnityEngine.Quaternion() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z, w = 丙业与丙丗丝不丈东.w};
    }
    public UnityEngine.Quaternion get_value()
    {
        UnityEngine.Transform val_1 = this.cachedTransform;
        if(val_1 != null)
        {
                return val_1.localRotation;
        }
        
        return val_1.localRotation;
    }
    public void set_value(UnityEngine.Quaternion 丙业与丙丗丝不丈东)
    {
        this.cachedTransform.localRotation = new UnityEngine.Quaternion() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z, w = 丙业与丙丗丝不丈东.w};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_8;
        if(this.quaternionLerp != false)
        {
                UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.from, y = V11.16B, z = V10.16B});
            val_8 = val_1.y;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.to, y = val_1.y, z = val_1.z});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_1.x, y = val_8, z = val_1.z, w = val_1.w}, b:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, t:  丞上与七且与七三丐);
        }
        else
        {
                float val_4 = UnityEngine.Mathf.Lerp(a:  this.from, b:  this.to, t:  丞上与七且与七三丐);
            val_8 = UnityEngine.Mathf.Lerp(a:  丞上与七且与七三丐, b:  this.to, t:  丞上与七且与七三丐);
            float val_6 = UnityEngine.Mathf.Lerp(a:  丞上与七且与七三丐, b:  this.to, t:  丞上与七且与七三丐);
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        
        this.value = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    public static TweenRotation Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        TweenRotation val_1 = UITweener.Begin<TweenRotation>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        UnityEngine.Quaternion val_2 = val_1.value;
        val_1.from = val_2.x;
        mem2[0] = val_2.y;
        mem2[0] = val_2.z;
        val_1.to = val_2.x;
        mem2[0] = val_2.y;
        mem2[0] = val_2.z;
        if(与丈业丛丝丒丙一丏 > 0f)
        {
                return val_1;
        }
        
        val_1.Sample(丞上与七且与七三丐:  1f, 丄上且东丙丘丙丈丕:  true);
        val_1.enabled = false;
        return val_1;
    }
    public override void SetStartToCurrentValue()
    {
        UnityEngine.Quaternion val_1 = this.value;
        this.from = val_1.x;
        mem[1152921535270960188] = val_1.y;
        mem[1152921535270960192] = val_1.z;
    }
    public override void SetEndToCurrentValue()
    {
        UnityEngine.Quaternion val_1 = this.value;
        this.to = val_1.x;
        mem[1152921535271072200] = val_1.y;
        mem[1152921535271072204] = val_1.z;
    }
    private void 丐一业丌东七丐丅丗()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.from, y = V8.16B, z = V9.16B});
        this.value = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
    }
    private void 一一丌丄三丐世丌不()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.to, y = V8.16B, z = V9.16B});
        this.value = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
    }
    public TweenRotation()
    {
    
    }

}
