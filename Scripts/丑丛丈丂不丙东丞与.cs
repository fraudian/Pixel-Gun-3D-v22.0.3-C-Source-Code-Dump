using UnityEngine;
public sealed class 丑丛丈丂不丙东丞与 : 东丁世丕万丘丛丙上
{
    // Fields
    private UnityEngine.Vector2 丙丂上丝世丏丘丁丛;
    private UnityEngine.Vector2 三丅丒丆东专丞专丘;
    private System.Nullable<UnityEngine.Vector2> 且七丌丟丁丌一且专;
    private UnityEngine.Vector2 丆且业世上东与丗三;
    private bool 丘不丙东丐丑丌世丙;
    private bool 下丄七不丞丕万丘专;
    private bool 丞丒丛业专丐不丒不;
    private UnityEngine.Quaternion 丙丄与丒丐东万业丝;
    private UnityEngine.Quaternion 世东上丛丐丁东丘丅;
    private UnityEngine.Vector2 且丏丈世丐业丘丕丅;
    private System.Nullable<UnityEngine.Vector2> 下下丁丄丁万丐不丞;
    private int 且丛一丞且万下下丝;
    public float 东丙万丆三丒丁丝世;
    private UnityEngine.Vector2 一丟丂三丌丆与丟一;
    private UnityEngine.Vector2 三上丒上丄丄丆丞三;
    public float 丞丂丝三丝业下专下;
    public UnityEngine.Vector2 业丈世与一世丑丝丁;
    public float 丅丐不丘上丁丛业丟;
    
    // Properties
    private bool 上七丈东丙丅丗丁一 { get; }
    
    // Methods
    private bool 七丏万一与业丘三世()
    {
        null = null;
        if(JoystickController.丘万丏三丏丑世丐丏 != null)
        {
                return JoystickController.丘万丏三丏丑世丐丏.HasTouchFinger;
        }
        
        return JoystickController.丘万丏三丏丑世丐丏.HasTouchFinger;
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
        mem[1152921539928943476] = UICamera.currentTouch + 20 + 4;
        this.且丏丈世丐业丘丕丅 = UICamera.currentTouch.下业丕七东丌丝下且;
        mem[1152921539928943540] = UICamera.currentTouch + 20 + 4;
        this.丙丂上丝世丏丘丁丛 = UICamera.currentTouch.下业丕七东丌丝下且;
        mem[1152921539928943468] = UICamera.currentTouch + 20 + 4;
    }
    public override void 丑丈丆万丅上丞丗丐()
    {
        System.Nullable<UnityEngine.Vector2> val_19;
        System.Nullable<UnityEngine.Vector2> val_20;
        float val_22;
        float val_23;
        var val_25;
        var val_26;
        if(this.七丏万一与业丘三世() == false)
        {
            goto label_1;
        }
        
        val_19 = this.且七丌丟丁丌一且专;
        if((val_19 & 1) == 0)
        {
            goto label_2;
        }
        
        val_20 = this.下下丁丄丁万丐不丞;
        goto label_3;
        label_1:
        val_20 = this;
        this.且七丌丟丁丌一且专 = this.下下丁丄丁万丐不丞;
        val_19 = 1152921539929055480;
        mem[1152921539929055488] = ???;
        if((val_19 & 1) == 0)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.三上丒上丄丄丆丞三 = val_2;
        mem[1152921539929055576] = val_2.y;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.且七丌丟丁丌一且专 = 0;
        mem[1152921539929055488] = 0;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        val_20 = this.下下丁丄丁万丐不丞;
        this.下下丁丄丁万丐不丞 = 0;
        mem[1152921539929055552] = 0;
        label_3:
        val_22 = val_4.y;
        UnityEngine.Vector2 val_18 = this.一丟丂三丌丆与丟一;
        val_18 = val_18 * this.丞丂丝三丝业下专下;
        val_23 = val_4.x + val_18;
        float val_8 = UnityEngine.Mathf.SmoothDamp(current:  val_4.x, target:  val_23, currentVelocity: ref  this.丆且业世上东与丗三, smoothTime:  this.东丙万丆三丒丁丝世);
        float val_10 = UnityEngine.Mathf.SmoothDamp(current:  val_22, target:  val_4.y + (this.丞丂丝三丝业下专下 * S4), currentVelocity: ref  1152921539929055496, smoothTime:  this.东丙万丆三丒丁丝世);
        this.且七丌丟丁丌一且专 = 0;
        mem[1152921539929055488] = 0;
        mem2[0] = 0;
        mem[1152921539929055552] = 0;
        goto label_10;
        label_4:
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        label_5:
        this.三上丒上丄丄丆丞三 = val_11;
        mem[1152921539929055576] = val_11.y;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        this.丆且业世上东与丗三 = val_12;
        mem[1152921539929055496] = val_12.y;
        mem[1152921539929055552] = 0;
        this.下下丁丄丁万丐不丞 = 0;
        label_10:
        val_25 = val_19;
        if((val_25 & 1) != 0)
        {
                val_20 = 1152921539927623952;
            val_22 = this.三上丒上丄丄丆丞三;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_22, y = V9.16B});
            val_23 = val_13.x;
            this.三上丒上丄丄丆丞三 = val_13;
            mem[1152921539929055576] = val_13.y;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
            val_25 = 0;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_23, y = val_13.y}, rhs:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y})) != false)
        {
                val_26 = null;
            val_26 = null;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_23, y:  val_13.y);
            val_25 = typeof(Player_move_c).__il2cppRuntimeField_628;
            val_25.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, 万业丒丞丅一丂丈业:  false);
        }
        
        }
        
        if(val_25.七丏万一与业丘三世() == true)
        {
                return;
        }
        
        mem[1152921539929055488] = 0;
        this.且七丌丟丁丌一且专 = 0;
    }
    public override void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        this.一丟丂三丌丆与丟一 = 丞且丅三三东不丄且;
        mem[1152921539929167568] = 丞且丅三三东不丄且.y;
    }
    public override void 且七丙丄丘一丄上不()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.一丟丂三丌丆与丟一 = val_1;
        mem[1152921539929279568] = val_1.y;
    }
    public override void 丑丗丘丗下丙丆丅七(UnityEngine.Vector2 一丟丂三丌丆与丟一, UnityEngine.Transform 丒一丘三丞与丟七三, UnityEngine.Transform 丙三万丙与丟丏丆丐, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一)
    {
    
    }
    public 丑丛丈丂不丙东丞与()
    {
        this.东丙万丆三丒丁丝世 = 0.05f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丞丂丝三丝业下专下 = 1f;
        this.三上丒上丄丄丆丞三 = val_1;
        mem[1152921539929519960] = val_1.y;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  0.8f);
        this.业丈世与一世丑丝丁 = val_2.x;
        mem[1152921539929519972] = val_2.y;
        this.丅丐不丘上丁丛业丟 = 4f;
    }

}
