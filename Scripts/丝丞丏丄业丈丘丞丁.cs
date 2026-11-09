using UnityEngine;
public sealed class 丝丞丏丄业丈丘丞丁 : 东丁世丕万丘丛丙上
{
    // Fields
    public float 丑与丟专上丟丞三丑;
    public float 七一上丏三不丕丌世;
    public float 丌丕丌丁丑丕且一三;
    private System.Nullable<UnityEngine.Vector2> 与东丗万东且且世丄;
    private System.Nullable<UnityEngine.Vector2> 丑丒世丛丗丗丙七丘;
    private bool 丟丌上丈丂丅万丆丞;
    private bool 丐丑丛丑丞东不丕不;
    private System.Nullable<UnityEngine.Vector2> 丅丛上一且丛专世丕;
    
    // Methods
    public override void OnPress(bool 丆且上丘世下丅且丞)
    {
        System.Collections.IEnumerator val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = this;
        if(丆且上丘世下丅且丞 != false)
        {
                UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.与东丗万东且且世丄 = 0;
            mem[1152921539927398396] = 0;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.丑丒世丛丗丗丙七丘 = 0;
            mem[1152921539927398408] = 0;
        }
        else
        {
                mem[1152921539927398404] = 0;
            mem[1152921539927398396] = 0;
            this.与东丗万东且且世丄 = 0;
        }
        
        bool val_3 = 丆且上丘世下丅且丞;
        this.丐丑丛丑丞东不丕不 = val_3;
        this.丟丌上丈丂丅万丆丞 = val_3;
        val_10 = null;
        if(丆且上丘世下丅且丞 != false)
        {
                val_11 = null;
            if((UnityEngine.Object.op_Implicit(exists:  JoystickController.丘万丏三丏丑世丐丏)) == false)
        {
                return;
        }
        
            val_12 = null;
            val_12 = null;
            val_9 = this.CancelLimitDrag();
            UnityEngine.Coroutine val_6 = JoystickController.丘万丏三丏丑世丐丏.StartCoroutine(routine:  val_9);
            return;
        }
        
        val_13 = null;
        if((UnityEngine.Object.op_Implicit(exists:  JoystickController.丘万丏三丏丑世丐丏)) == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_9 = this.CancelLimitDrag();
        JoystickController.丘万丏三丏丑世丐丏.StopCoroutine(routine:  val_9);
    }
    private System.Collections.IEnumerator CancelLimitDrag()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 丝丞丏丄业丈丘丞丁.丛且丁丝丅一丘世丒();
    }
    public override void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_6;
        var val_7;
        var val_8;
        float val_9;
        System.Nullable<UnityEngine.Vector2> val_12;
        var val_13;
        val_6 = 丞且丅三三东不丄且.x;
        if(this.丐丑丛丑丞东不丕不 != true)
        {
                mem[1152921539927648992] = val_6;
            mem[1152921539927648996] = 丞且丅三三东不丄且.y;
        }
        
        this.丐丑丛丑丞东不丕不 = false;
        if(this.丟丌上丈丂丅万丆丞 != false)
        {
                this.丟丌上丈丂丅万丆丞 = false;
            val_7 = null;
            val_7 = null;
            if((UnityEngine.Object.op_Implicit(exists:  JoystickController.丘万丏三丏丑世丐丏)) != false)
        {
                val_8 = null;
            val_8 = null;
            JoystickController.丘万丏三丏丑世丐丏.StopCoroutine(routine:  this.CancelLimitDrag());
        }
        
            val_9 = this.七一上丏三不丕丌世;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = val_6, y = 丞且丅三三东不丄且.y}, maxLength:  val_9);
            mem[1152921539927648992] = val_3.x;
            mem[1152921539927648996] = val_3.y;
        }
        
        val_12 = 1152921539927622928;
        if((this.与东丗万东且且世丄 & 1) != 0)
        {
                val_12 = this.丑丒世丛丗丗丙七丘;
            if((val_12 & 1) != 0)
        {
                val_9 = val_3.x;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9, y = val_3.y}, b:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.y, y = val_6});
            val_6 = val_4.y;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_6}, t:  this.丌丕丌丁丑丕且一三);
            this.与东丗万东且且世丄 = 0;
            mem[1152921539927649020] = 0;
            this.丑丒世丛丗丗丙七丘 = 0;
            mem[1152921539927649032] = 0;
        }
        
        }
        
        val_13 = null;
        val_13 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_4.x, y = val_6}, 万业丒丞丅一丂丈业:  false);
    }
    public override void 且七丙丄丘一丄上不()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        mem[1152921539927765088] = val_1.x;
        mem[1152921539927765092] = val_1.y;
        mem[1152921539927765124] = 0;
        mem[1152921539927765116] = 0;
        this.与东丗万东且且世丄 = 0;
    }
    public override void 丑丗丘丗下丙丆丅七(UnityEngine.Vector2 一丟丂三丌丆与丟一, UnityEngine.Transform 丒一丘三丞与丟七三, UnityEngine.Transform 丙三万丙与丟丏丆丐, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一)
    {
        float val_9;
        if((this.与东丗万东且且世丄 & 1) == 0)
        {
            goto label_1;
        }
        
        if((this.丅丛上一且丛专世丕 & 1) == 0)
        {
            goto label_2;
        }
        
        float val_9 = 30f;
        float val_1 = 世专专丙世丒上丁丌 / val_9;
        val_9 = val_1 * 一丟丂三丌丆与丟一.x;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_9 + val_9, z:  0f);
        float val_11 = val_3.y;
        丒一丘三丞与丟七三.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_11, z = val_3.z, w = val_3.w};
        float val_10 = -360f;
        val_10 = val_11 + val_10;
        val_11 = (val_11 > 180f) ? (val_10) : (val_11);
        float val_4 = (丝业丈不丙丄丝一一 != true) ? 1f : -1f;
        val_4 = val_4 * 一丟丂三丌丆与丟一.y;
        val_4 = val_1 * val_4;
        val_4 = val_4 + val_11;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  一丟丂三丌丆与丟一.y, y:  0f, z:  0f);
        val_9 = val_5.x;
        丙三万丙与丟丏丆丐.localRotation = new UnityEngine.Quaternion() {x = val_9, y = val_5.y, z = val_5.z, w = val_5.w};
        return;
        label_1:
        mem2[0] = 0;
        mem2[0] = 0;
        return;
        label_2:
        UnityEngine.Quaternion val_6 = 丒一丘三丞与丟七三.rotation;
        val_9 = val_6.y;
        UnityEngine.Vector3 val_7 = 丙三万丙与丟丏丆丐.localEulerAngles;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_9, y:  val_7.x);
        this.丅丛上一且丛专世丕 = 0;
        mem[1152921539927885336] = 0;
    }
    public 丝丞丏丄业丈丘丞丁()
    {
        this.丑与丟专上丟丞三丑 = 1.5f;
        this.七一上丏三不丕丌世 = 1f;
        this.丌丕丌丁丑丕且一三 = 0.25f;
    }

}
