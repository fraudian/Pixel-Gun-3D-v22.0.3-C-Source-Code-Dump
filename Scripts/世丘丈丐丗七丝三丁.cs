using UnityEngine;
public sealed class 世丘丈丐丗七丝三丁 : 东丁世丕万丘丛丙上
{
    // Fields
    private UnityEngine.Vector2 丙丂上丝世丏丘丁丛;
    private UnityEngine.Vector2 三丅丒丆东专丞专丘;
    private bool 丘不丙东丐丑丌世丙;
    private bool 下丄七不丞丕万丘专;
    private bool 丞丒丛业专丐不丒不;
    private UnityEngine.Quaternion 丙丄与丒丐东万业丝;
    private UnityEngine.Quaternion 世东上丛丐丁东丘丅;
    private System.Nullable<UnityEngine.Vector2> 与丈丂丈丅丐丟业一;
    private UnityEngine.Vector2 且丏丈世丐业丘丕丅;
    private int 且丛一丞且万下下丝;
    private UnityEngine.Vector2 丗丏丞下三丌丕丗世;
    private int 业丆东丙丁丆且七三;
    private System.Collections.Generic.List<UnityEngine.Vector2> 三东丅不丁东丏丞东;
    private UnityEngine.Vector2 丁世丛丆上丒七丙丕;
    public bool 丕丟且三三丙丙丏东;
    public float 世业七东丟万且与一;
    public UnityEngine.Vector2 丂丐丗丌丏丛丏丐且;
    public int 丌丑丛专丞丝丘专下;
    public float 万丒丙世且专万丆丟;
    public float 丅丐不丘上丁丛业丟;
    
    // Properties
    private float 丙万丘不一三专丏下 { get; }
    
    // Methods
    private float 丄丄丘上丁上且东丘()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * 30f;
        return (float)val_1;
    }
    public override void OnPress(bool 丆且上丘世下丅且丞)
    {
        var val_1;
        int val_2;
        var val_3;
        if(丆且上丘世下丅且丞 != false)
        {
                if(this.且丛一丞且万下下丝 != 1)
        {
                return;
        }
        
            this.丘不丙东丐丑丌世丙 = true;
            val_1 = null;
            val_1 = null;
            val_2 = UICamera.currentTouchID;
        }
        else
        {
                if(this.且丛一丞且万下下丝 == 1)
        {
                return;
        }
        
            val_2 = 0;
            this.丘不丙东丐丑丌世丙 = false;
        }
        
        this.且丛一丞且万下下丝 = val_2;
        val_3 = null;
        val_3 = null;
        this.丞丒丛业专丐不丒不 = false;
        this.三丅丒丆东专丞专丘 = UICamera.currentTouch.下业丕七东丌丝下且;
        mem[1152921539929743860] = UICamera.currentTouch + 20 + 4;
        this.且丏丈世丐业丘丕丅 = UICamera.currentTouch.下业丕七东丌丝下且;
        mem[1152921539929743916] = UICamera.currentTouch + 20 + 4;
        this.丙丂上丝世丏丘丁丛 = UICamera.currentTouch.下业丕七东丌丝下且;
        mem[1152921539929743852] = UICamera.currentTouch + 20 + 4;
    }
    public override void 丑丈丆万丅上丞丗丐()
    {
        this.下丄七不丞丕万丘专 = false;
        if(this.丘不丙东丐丑丌世丙 == false)
        {
            goto label_7;
        }
        
        int val_1 = UnityEngine.Input.touchCount;
        if(val_1 < 1)
        {
            goto label_7;
        }
        
        var val_10 = 0;
        do
        {
            UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
            if(GetHashCode() == this.且丛一丞且万下下丝)
        {
                if((专三三与三且一且一() == 1) || (专三三与三且一且一() == 2))
        {
            goto label_5;
        }
        
        }
        
            val_10 = val_10 + 1;
        }
        while(val_10 < val_1);
        
        goto label_7;
        label_5:
        this.下丄七不丞丕万丘专 = true;
        this.且丏丈世丐业丘丕丅 = this.丙丂上丝世丏丘丁丛;
        mem[1152921539929868252] = ???;
        this.丙丂上丝世丏丘丁丛 = new UnityEngine.Vector2();
        mem[1152921539929868188] = ???;
        label_7:
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
        mem[1152921539929868176] = val_6.x;
        mem[1152921539929868180] = val_6.y;
        if(this.下丄七不丞丕万丘专 == false)
        {
                return;
        }
        
        if(this.丞丒丛业专丐不丒不 == false)
        {
            goto label_11;
        }
        
        label_18:
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.丙丂上丝世丏丘丁丛, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.且丏丈世丐业丘丕丅, y = V8.16B});
        mem[1152921539929868176] = val_7.x;
        mem[1152921539929868180] = val_7.y;
        return;
        label_11:
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.丙丂上丝世丏丘丁丛, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.三丅丒丆东专丞专丘, y = V8.16B});
        if(val_8.x.sqrMagnitude < 0)
        {
                return;
        }
        
        if(this.丞丒丛业专丐不丒不 == true)
        {
            goto label_18;
        }
        
        this.丞丒丛业专丐不丒不 = true;
    }
    public override void 且七丙丄丘一丄上不()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        mem[1152921539929992512] = val_1.x;
        mem[1152921539929992516] = val_1.y;
        this.丘不丙东丐丑丌世丙 = false;
        this.且丛一丞且万下下丝 = 0;
        this.下丄七不丞丕万丘专 = false;
        this.丞丒丛业专丐不丒不 = false;
    }
    public override void 丑丗丘丗下丙丆丅七(UnityEngine.Vector2 一丟丂三丌丆与丟一, UnityEngine.Transform 丒一丘三丞与丟七三, UnityEngine.Transform 丙三万丙与丟丏丆丐, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一)
    {
        float val_20;
        float val_23;
        val_20 = 一丟丂三丌丆与丟一.x;
        世专专丙世丒上丁丌 = 世专专丙世丒上丁丌 * 0.01f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_20, y = 一丟丂三丌丆与丟一.y}, d:  世专专丙世丒上丁丌);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
        UnityEngine.Vector2 val_3 = this.下业世专丗丐丞丛丟(丟上丙丅丗上东丕专:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_23 = val_3.x;
        if(this.下丄七不丞丕万丘专 != false)
        {
                if((this.与丈丂丈丅丐丟业一 & 1) == 0)
        {
                UnityEngine.Quaternion val_4 = 丙三万丙与丟丏丆丐.localRotation;
            this.丙丄与丒丐东万业丝 = val_4;
            mem[1152921539930112736] = val_4.y;
            mem[1152921539930112740] = val_4.z;
            mem[1152921539930112744] = val_4.w;
            UnityEngine.Quaternion val_5 = 丒一丘三丞与丟七三.rotation;
            this.世东上丛丐丁东丘丅 = val_5;
            mem[1152921539930112752] = val_5.y;
            mem[1152921539930112756] = val_5.z;
            mem[1152921539930112760] = val_5.w;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            this.与丈丂丈丅丐丟业一 = 0;
            mem[1152921539930112772] = 0;
        }
        
            val_6.y = val_23 + val_6.y;
            val_6.x = val_3.y + val_6.x;
            val_6.x = (val_6.x > 180f) ? (val_6.x + (-360f)) : (val_6.x);
            val_6.y = (val_6.y > 180f) ? (val_6.y + (-360f)) : (val_6.y);
            float val_12 = (val_6.y < 0) ? (val_6.y + 360f) : (val_6.y);
            float val_13 = UnityEngine.Mathf.Clamp(value:  (val_6.x < 0) ? (val_6.x + 360f) : (val_6.x), min:  -89.5f, max:  89.5f);
            float val_14 = UnityEngine.Mathf.Clamp(value:  val_12, min:  -360f, max:  360f);
            this.与丈丂丈丅丐丟业一 = 0;
            mem[1152921539930112772] = 0;
            丒一丘三丞与丟七三.rotation = new UnityEngine.Quaternion() {x = this.世东上丛丐丁东丘丅, y = 360f, z = val_12, w = val_13};
            丙三万丙与丟丏丆丐.localRotation = new UnityEngine.Quaternion() {x = this.丙丄与丒丐东万业丝, y = 360f, z = val_12, w = val_13};
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Euler(x:  0f, y:  360f, z:  0f);
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.世东上丛丐丁东丘丅, y = 360f, z = val_12, w = val_13}, rhs:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w});
            丒一丘三丞与丟七三.rotation = new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w};
            float val_20 = -1f;
            val_20 = ((丝业丈不丙丄丝一一 != true) ? 1f : (val_20)) * val_16.x;
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.Euler(x:  val_20, y:  0f, z:  0f);
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.丙丄与丒丐东万业丝, y = val_16.y, z = val_16.z, w = val_16.w}, rhs:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w});
            val_23 = val_19.x;
            val_20 = val_19.z;
            丙三万丙与丟丏丆丐.localRotation = new UnityEngine.Quaternion() {x = val_23, y = val_19.y, z = val_20, w = val_19.w};
            return;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
    }
    public UnityEngine.Vector2 下业世专丗丐丞丛丟(UnityEngine.Vector2 丟上丙丅丗上东丕专)
    {
        float val_19;
        System.Collections.Generic.List<UnityEngine.Vector2> val_20;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        val_19 = 丟上丙丅丗上东丕专.y;
        if(this.业丆东丙丁丆且七三 == UnityEngine.Time.frameCount)
        {
                return new UnityEngine.Vector2() {x = val_20, y = val_26};
        }
        
        this.业丆东丙丁丆且七三 = UnityEngine.Time.frameCount;
        float val_3 = UnityEngine.Time.timeScale;
        val_3 = 丟上丙丅丗上东丕专.x * val_3;
        this.丁世丛丆上丒七丙丕 = val_3;
        float val_4 = UnityEngine.Time.timeScale;
        val_4 = val_19 * val_4;
        mem[1152921539930250412] = val_4;
        this.丌丑丛专丞丝丘专下 = UnityEngine.Mathf.Clamp(value:  this.丌丑丛专丞丝丘专下, min:  1, max:  20);
        this.万丒丙世且专万丆丟 = UnityEngine.Mathf.Clamp01(value:  this.万丒丙世且专万丆丟);
        val_20 = 1152921516216383616;
        goto label_5;
        label_8:
        this.丌丑丛专丞丝丘专下.RemoveAt(index:  0);
        label_5:
        if(this.三东丅不丁东丏丞东.Count > this.丌丑丛专丞丝丘专下)
        {
            goto label_8;
        }
        
        this.三东丅不丁东丏丞东.Add(item:  new UnityEngine.Vector2() {x = this.丁世丛丆上丒七丙丕, y = 丟上丙丅丗上东丕专.x});
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        System.Collections.Generic.List<UnityEngine.Vector2> val_18 = this.三东丅不丁东丏丞东;
        val_23 = val_8.x;
        val_24 = val_8.y;
        val_18 = val_18.Count - 1;
        val_25 = 0f;
        if(val_18 >= 1)
        {
                float val_19 = 1f;
            do
        {
            val_20 = this.三东丅不丁东丏丞东;
            UnityEngine.Vector2 val_10 = val_20.Item[val_18];
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, d:  val_19);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_23, y = val_24}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_23 = val_12.x;
            val_24 = val_12.y;
            val_25 = val_25 + val_19;
            float val_13 = UnityEngine.Time.deltaTime;
            val_13 = val_13 * 30f;
            val_18 = val_18 - 1;
            val_13 = this.万丒丙世且专万丆丟 / val_13;
            val_19 = val_19 * val_13;
        }
        while(val_18 > 0);
        
        }
        
        val_26 = val_24;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_23, y = val_26}, d:  UnityEngine.Mathf.Max(a:  1f, b:  val_25));
        val_27 = 0f;
        UnityEngine.Vector2 val_16 = 世丘丈丐丗七丝三丁.且丘丑丌丘丈万丅丅(丒丙丐一丈一三一丆:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, 丌世丅丕一丙丅丅三:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        val_19 = val_16.x;
        this.丗丏丞下三丌丕丗世 = val_16;
        mem[1152921539930250392] = val_16.y;
        if(this.丕丟且三三丙丙丏东 != false)
        {
                val_16.x = val_19 * val_19;
            val_16.y = val_16.y * val_16.y;
            val_16.x = val_16.x + val_16.y;
            if(val_19 >= _TYPE_MAX_)
        {
                val_19 = val_16.x;
        }
        
            float val_17 = UnityEngine.Time.deltaTime;
            val_26 = this.世业七东丟万且与一;
            val_17 = val_17 * 30f;
            val_27 = val_19 / val_17;
            if(val_27 <= val_26)
        {
                val_27 = 0f;
        }
        
        }
        
        UnityEngine.Vector2 val_20 = this.丂丐丗丌丏丛丏丐且;
        val_20 = val_27 + val_20;
        val_26 = val_27 + val_26;
        val_20 = this.丗丏丞下三丌丕丗世 * val_20;
        val_26 = 0f * val_26;
        this.丗丏丞下三丌丕丗世 = val_20;
        mem[1152921539930250392] = val_26;
        return new UnityEngine.Vector2() {x = val_20, y = val_26};
    }
    private static UnityEngine.Vector2 且丘丑丌丘丈万丅丅(UnityEngine.Vector2 丒丙丐一丈一三一丆, UnityEngine.Vector2 丌世丅丕一丙丅丅三)
    {
        丒丙丐一丈一三一丆.y = ((System.Double.IsNaN(d:  (double)丒丙丐一丈一三一丆.y)) != true) ? 丌世丅丕一丙丅丅三.y : 丒丙丐一丈一三一丆.y;
        return new UnityEngine.Vector2() {x = ((System.Double.IsNaN(d:  (double)丒丙丐一丈一三一丆.x)) != true) ? 丌世丅丕一丙丅丅三.x : 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y};
    }
    public 世丘丈丐丗七丝三丁()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丗丏丞下三丌丕丗世 = val_1;
        mem[1152921539930494872] = val_1.y;
        this.业丆东丙丁丆且七三 = 0;
        this.三东丅不丁东丏丞东 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.世业七东丟万且与一 = 0.4f;
        this.丁世丛丆上丒七丙丕 = val_3;
        mem[1152921539930494892] = val_3.y;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  2.8f, y:  1.876f);
        mem[1152921539930494908] = val_4.y;
        this.丌丑丛专丞丝丘专下 = 10;
        this.丂丐丗丌丏丛丏丐且 = val_4.x;
        this.万丒丙世且专万丆丟 = 0.15f;
        this.丅丐不丘上丁丛业丟 = 4f;
    }

}
