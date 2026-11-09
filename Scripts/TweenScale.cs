using UnityEngine;
public class TweenScale : UITweener
{
    // Fields
    public UnityEngine.Vector3 from;
    public UnityEngine.Vector3 to;
    public bool updateTable;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UITable 丏七丏丆丘东丝且专;
    
    // Properties
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    public UnityEngine.Vector3 丙业与丙丗丝不丈东 { get; set; }
    public UnityEngine.Vector3 丝丕丁丏丏上丅丏且 { get; set; }
    
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
    public UnityEngine.Vector3 get_value()
    {
        UnityEngine.Transform val_1 = this.cachedTransform;
        if(val_1 != null)
        {
                return val_1.localScale;
        }
        
        return val_1.localScale;
    }
    public void set_value(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.cachedTransform.localScale = new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z};
    }
    public UnityEngine.Vector3 get_scale()
    {
        return this.value;
    }
    public void set_scale(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.value = new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z};
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_1 = 1f - 丞上与七且与七三丐;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.from, y = V9.16B, z = V10.16B}, d:  val_1);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.to, y = val_2.y, z = val_1}, d:  丞上与七且与七三丐);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.value = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        if(this.updateTable == false)
        {
                return;
        }
        
        if(this.丏七丏丆丘东丝且专 == 0)
        {
                UITable val_7 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UITable>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            this.丏七丏丆丘东丝且专 = val_7;
            if(val_7 == 0)
        {
                this.updateTable = false;
            return;
        }
        
        }
        
        this.丏七丏丆丘东丝且专.repositionNow = true;
    }
    public static TweenScale Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Vector3 丝丕丁丏丏上丅丏且)
    {
        TweenScale val_1 = UITweener.Begin<TweenScale>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
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
        
        val_1.to = 丝丕丁丏丏上丅丏且;
        mem2[0] = 丝丕丁丏丏上丅丏且.y;
        mem2[0] = 丝丕丁丏丏上丅丏且.z;
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
        mem[1152921535272395324] = val_1.y;
        mem[1152921535272395328] = val_1.z;
    }
    public override void SetEndToCurrentValue()
    {
        UnityEngine.Vector3 val_1 = this.value;
        this.to = val_1;
        mem[1152921535272507336] = val_1.y;
        mem[1152921535272507340] = val_1.z;
    }
    private void 丐一业丌东七丐丅丗()
    {
        this.value = new UnityEngine.Vector3() {x = this.from};
    }
    private void 一一丌丄三丐世丌不()
    {
        this.value = new UnityEngine.Vector3() {x = this.to};
    }
    public TweenScale()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.from = val_1;
        mem[1152921535272843324] = val_1.y;
        mem[1152921535272843328] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.to = val_2;
        mem[1152921535272843336] = val_2.y;
        mem[1152921535272843340] = val_2.z;
    }

}
