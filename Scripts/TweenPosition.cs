using UnityEngine;
public class TweenPosition : UITweener
{
    // Fields
    public UnityEngine.Vector3 from;
    public UnityEngine.Vector3 to;
    public bool worldSpace;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UIRect 不丝下丆丐丙丘东丛;
    
    // Properties
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    public UnityEngine.Vector3 业丒丝丗与丐丛丟丏 { get; set; }
    public UnityEngine.Vector3 丙业与丙丗丝不丈东 { get; set; }
    
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
    public UnityEngine.Vector3 get_position()
    {
        return this.value;
    }
    public void set_position(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.value = new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z};
    }
    public UnityEngine.Vector3 get_value()
    {
        UnityEngine.Transform val_1 = this.cachedTransform;
        if(val_1 != null)
        {
                if(this.worldSpace == false)
        {
                return val_1.localPosition;
        }
        
            return val_1.position;
        }
        
        if(this.worldSpace == true)
        {
                return val_1.position;
        }
        
        return val_1.localPosition;
    }
    public void set_value(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        if(this.不丝下丆丐丙丘东丛 != 0)
        {
                if(this.不丝下丆丐丙丘东丛.isAnchored != false)
        {
                if(this.worldSpace == false)
        {
            goto label_6;
        }
        
        }
        
        }
        
        UnityEngine.Transform val_3 = this.cachedTransform;
        if(val_3 == null)
        {
            goto label_7;
        }
        
        if(this.worldSpace == false)
        {
            goto label_8;
        }
        
        label_9:
        val_3.position = new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z};
        return;
        label_7:
        if(this.worldSpace == true)
        {
            goto label_9;
        }
        
        label_8:
        val_3.localPosition = new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z};
        return;
        label_6:
        UnityEngine.Vector3 val_5 = this.cachedTransform.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        万丗丅且丄丑世专与.丕万丅与上不丂七七(丝丆丏丕丕丕丗丛业:  this.不丝下丆丐丙丘东丛, 三丟东丕丄丄下下丑:  val_6.x, 丒丒丄丁且丄丆丂丌:  val_6.y);
    }
    private void Awake()
    {
        this.不丝下丆丐丙丘东丛 = this.GetComponent<UIRect>();
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_1 = 1f - 丞上与七且与七三丐;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.from, y = V9.16B, z = V10.16B}, d:  val_1);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.to, y = val_2.y, z = val_1}, d:  丞上与七且与七三丐);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.value = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static TweenPosition Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        TweenPosition val_1 = UITweener.Begin<TweenPosition>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        UnityEngine.Vector3 val_2 = val_1.value;
        if(val_1 != null)
        {
                val_1.from = val_2;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
        }
        else
        {
                mem[120] = val_2.x;
            mem2[0] = val_2.y;
            mem[128] = val_2.z;
        }
        
        val_1.to = 下业丕七东丌丝下且;
        mem2[0] = 下业丕七东丌丝下且.y;
        mem2[0] = 下业丕七东丌丝下且.z;
        if(与丈业丛丝丒丙一丏 > 0f)
        {
                return val_1;
        }
        
        val_1.Sample(丞上与七且与七三丐:  1f, 丄上且东丙丘丙丈丕:  true);
        val_1.enabled = false;
        return val_1;
    }
    public static TweenPosition Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Vector3 下业丕七东丌丝下且, bool 丙丐三一丏丐丏丆丒)
    {
        TweenPosition val_1 = UITweener.Begin<TweenPosition>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        if(val_1 != null)
        {
                val_1.worldSpace = 丙丐三一丏丐丏丆丒;
        }
        else
        {
                mem[144] = 丙丐三一丏丐丏丆丒;
        }
        
        UnityEngine.Vector3 val_4 = val_1.value;
        if(val_1 != null)
        {
                val_1.from = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
        }
        else
        {
                mem[120] = val_4.x;
            mem2[0] = val_4.y;
            mem[128] = val_4.z;
        }
        
        val_1.to = 下业丕七东丌丝下且;
        mem2[0] = 下业丕七东丌丝下且.y;
        mem2[0] = 下业丕七东丌丝下且.z;
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
        UnityEngine.Vector3 val_1 = this.value;
        this.from = val_1;
        mem[1152921535269557820] = val_1.y;
        mem[1152921535269557824] = val_1.z;
    }
    public override void SetEndToCurrentValue()
    {
        UnityEngine.Vector3 val_1 = this.value;
        this.to = val_1;
        mem[1152921535269669832] = val_1.y;
        mem[1152921535269669836] = val_1.z;
    }
    private void 丐一业丌东七丐丅丗()
    {
        this.value = new UnityEngine.Vector3() {x = this.from};
    }
    private void 一一丌丄三丐世丌不()
    {
        this.value = new UnityEngine.Vector3() {x = this.to};
    }
    public TweenPosition()
    {
    
    }

}
