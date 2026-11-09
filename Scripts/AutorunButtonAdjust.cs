using UnityEngine;
internal sealed class AutorunButtonAdjust : ButtonJoystickAdjust
{
    // Fields
    internal static readonly int 专丛三且丛上丛业丈;
    private MoveJoystickAdjust joystick;
    
    // Properties
    internal override bool 万丒丗且丘丈丕丈世 { get; }
    
    // Methods
    internal override bool 丈丏丆世丟三丙丌丑()
    {
        return false;
    }
    private void OnEnable()
    {
        if(this.joystick == null)
        {
                return;
        }
        
        this.joystick.且丅七丗丙万一三专(丟丒丞丐丐丘丒丄东:  this);
    }
    protected override System.Nullable<UnityEngine.Vector3> 丒丑丆下下丛丄丛下(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_12;
        var val_13;
        float val_14;
        var val_15;
        float val_16;
        var val_17;
        int val_18;
        var val_19;
        val_12 = 丞且丅三三东不丄且.y;
        val_13 = this;
        val_14 = val_12;
        System.Nullable<UnityEngine.Vector3> val_1 = this.丒丑丆下下丛丄丛下(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = val_14});
        val_15 = public System.Boolean System.Nullable<UnityEngine.Vector3>::get_HasValue();
        if((923008000 & 1) == 0)
        {
                return 0;
        }
        
        UnityEngine.Vector3 val_3 = this.joystick.transform.localPosition;
        val_12 = val_3.x;
        float val_9 = val_3.y;
        UISprite val_4 = this.joystick.GetComponent<UISprite>();
        if(val_4 != 0)
        {
                val_14 = 0.5f;
            val_16 = (float)val_4.width * val_14;
        }
        else
        {
                val_16 = 75f;
        }
        
        val_17 = null;
        val_17 = null;
        val_9 = val_9 + val_16;
        val_18 = AutorunButtonAdjust.专丛三且丛上丛业丈;
        float val_10 = (float)val_18;
        val_10 = val_9 + val_10;
        if(val_3.y < 0)
        {
                val_18 = AutorunButtonAdjust.专丛三且丛上丛业丈;
            val_13 = this.transform;
            UnityEngine.Vector3 val_8 = val_13.localPosition;
            val_19 = val_9 + (float)val_18;
        }
        else
        {
                val_19 = val_3.y;
        }
        
        val_15 = public System.Void System.Nullable<UnityEngine.Vector3>::.ctor(UnityEngine.Vector3 value);
        return 0;
    }
    internal void 丒丆丙丆七且丟万且(UnityEngine.Vector3 丞且丅三三东不丄且)
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y, z = 丞且丅三三东不丄且.z});
        goto typeof(AutorunButtonAdjust).__il2cppRuntimeField_1A8;
    }
    internal void 世丏万丄丄七不专丆(float 与专丌丅丙上丌一丄)
    {
        this.丝丆且下丁三不丘世(与专丌丅丙上丌一丄:  与专丌丅丙上丌一丄);
    }
    internal override void 丝丆且下丁三不丘世(float 与专丌丅丙上丌一丄)
    {
    
    }
    public AutorunButtonAdjust()
    {
    
    }
    private static AutorunButtonAdjust()
    {
        AutorunButtonAdjust.专丛三且丛上丛业丈 = 40;
    }

}
