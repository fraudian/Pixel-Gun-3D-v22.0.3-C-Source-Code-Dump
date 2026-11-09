using UnityEngine;
public class TweenTransform : UITweener
{
    // Fields
    public UnityEngine.Transform from;
    public UnityEngine.Transform to;
    public bool parentWhenFinished;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UnityEngine.Vector3 丞丌上丂与业丆丅丅;
    private UnityEngine.Quaternion 丙东丒丁丐万三丟三;
    private UnityEngine.Vector3 丟丕世万七且万丌丈;
    
    // Methods
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        UnityEngine.Transform val_32;
        UnityEngine.Quaternion val_33;
        var val_34;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        val_32 = this.to;
        if(val_32 == 0)
        {
                return;
        }
        
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                UnityEngine.Transform val_3 = this.transform;
            this.丐一丗丛丕世丘东丁 = val_3;
            UnityEngine.Vector3 val_4 = val_3.position;
            this.丞丌上丂与业丆丅丅 = val_4;
            mem[1152921535273045468] = val_4.y;
            mem[1152921535273045472] = val_4.z;
            UnityEngine.Quaternion val_5 = this.丐一丗丛丕世丘东丁.rotation;
            this.丙东丒丁丐万三丟三 = val_5;
            mem[1152921535273045480] = val_5.y;
            mem[1152921535273045484] = val_5.z;
            mem[1152921535273045488] = val_5.w;
            UnityEngine.Vector3 val_6 = this.丐一丗丛丕世丘东丁.localScale;
            this.丟丕世万七且万丌丈 = val_6;
            mem[1152921535273045496] = val_6.y;
            mem[1152921535273045500] = val_6.z;
        }
        
        if(this.from != 0)
        {
                UnityEngine.Vector3 val_8 = this.from.position;
            float val_9 = 1f - 丞上与七且与七三丐;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  val_9);
            UnityEngine.Vector3 val_11 = this.to.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  丞上与七且与七三丐);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Vector3 val_14 = this.from.localScale;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_9);
            UnityEngine.Vector3 val_16 = this.to.localScale;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  丞上与七且与七三丐);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            val_32 = this.丐一丗丛丕世丘东丁;
            UnityEngine.Quaternion val_19 = this.from.rotation;
            val_33 = val_19.x;
            val_34 = val_19.w;
            UnityEngine.Quaternion val_20 = this.to.rotation;
            val_39 = val_20.x;
            val_40 = val_20.y;
            val_41 = val_20.z;
            val_42 = val_20.w;
            val_43 = 丞上与七且与七三丐;
            val_44 = val_19.y;
            val_45 = val_19.z;
            val_46 = val_34;
        }
        else
        {
                float val_21 = 1f - 丞上与七且与七三丐;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = V8.16B, z = V10.16B}, d:  val_21);
            UnityEngine.Vector3 val_23 = this.to.position;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  丞上与七且与七三丐);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丟丕世万七且万丌丈, y = val_25.y, z = val_25.z}, d:  val_21);
            UnityEngine.Vector3 val_27 = this.to.localScale;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  丞上与七且与七三丐);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            val_32 = this.丐一丗丛丕世丘东丁;
            val_33 = this.丙东丒丁丐万三丟三;
            UnityEngine.Quaternion val_30 = this.to.rotation;
            val_39 = val_30.x;
            val_40 = val_30.y;
            val_41 = val_30.z;
            val_42 = val_30.w;
            val_43 = 丞上与七且与七三丐;
            val_44 = val_29.z;
            val_45 = val_22.z;
            val_46 = val_26.z;
        }
        
        UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_33, y = val_44, z = val_45, w = val_46}, b:  new UnityEngine.Quaternion() {x = val_39, y = val_40, z = val_41, w = val_42}, t:  val_43);
        val_32.rotation = new UnityEngine.Quaternion() {x = val_31.x, y = val_31.y, z = val_31.z, w = val_31.w};
        if(this.parentWhenFinished == false)
        {
                return;
        }
        
        if(丄上且东丙丘丙丈丕 == false)
        {
                return;
        }
        
        this.丐一丗丛丕世丘东丁.parent = this.to;
    }
    public static TweenTransform Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Transform 专丂丕丗丗东世丞下)
    {
        return TweenTransform.Begin(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏, 丈丗与丞一上且上上:  0, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下);
    }
    public static TweenTransform Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Transform 丈丗与丞一上且上上, UnityEngine.Transform 专丂丕丗丗东世丞下)
    {
        TweenTransform val_1 = UITweener.Begin<TweenTransform>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        if(val_1 != null)
        {
                val_1.from = 丈丗与丞一上且上上;
        }
        else
        {
                mem[120] = 丈丗与丞一上且上上;
        }
        
        val_1.to = 专丂丕丗丗东世丞下;
        if(与丈业丛丝丒丙一丏 > 0f)
        {
                return val_1;
        }
        
        val_1.Sample(丞上与七且与七三丐:  1f, 丄上且东丙丘丙丈丕:  true);
        val_1.enabled = false;
        return val_1;
    }
    public TweenTransform()
    {
    
    }

}
