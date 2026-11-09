using UnityEngine;
public sealed class 丅丂丘丐丐东丟丙丞 : 东丁世丕万丘丛丙上
{
    // Fields
    private bool 丆丄丛丕丟且丘丞丞;
    public float 且丄七丄不专丏且下;
    
    // Methods
    public override void OnPress(bool 丆且上丘世下丅且丞)
    {
        this.丆丄丛丕丟且丘丞丞 = 丆且上丘世下丅且丞;
    }
    public override void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_2;
        float val_3;
        var val_4;
        val_2 = 丞且丅三三东不丄且.y;
        val_3 = 丞且丅三三东不丄且.x;
        if(this.丆丄丛丕丟且丘丞丞 != false)
        {
                this.丆丄丛丕丟且丘丞丞 = false;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = val_3, y = val_2}, maxLength:  this.且丄七丄不专丏且下);
            val_3 = val_1.x;
            val_2 = val_1.y;
        }
        
        mem[1152921539923929568] = val_3;
        mem[1152921539923929572] = val_2;
        val_4 = null;
        val_4 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_2, y = val_3}, 万业丒丞丅一丂丈业:  false);
        goto typeof(丅丂丘丐丐东丟丙丞).__il2cppRuntimeField_198;
    }
    public override void 且七丙丄丘一丄上不()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        mem[1152921539924041568] = val_1.x;
        mem[1152921539924041572] = val_1.y;
        this.丆丄丛丕丟且丘丞丞 = false;
    }
    public override void 丑丗丘丗下丙丆丅七(UnityEngine.Vector2 一丟丂三丌丆与丟一, UnityEngine.Transform 丒一丘三丞与丟七三, UnityEngine.Transform 丙三万丙与丟丏丆丐, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 一丟丂三丌丆与丟一.x, y = 一丟丂三丌丆与丟一.y}, d:  世专专丙世丒上丁丌);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  30f);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  (float)UnityEngine.Screen.width);
        丒一丘三丞与丟七三.Rotate(xAngle:  0f, yAngle:  val_4.x, zAngle:  0f, relativeTo:  0);
        float val_6 = -1f;
        val_6 = ((丝业丈不丙丄丝一一 != true) ? 1f : (val_6)) * val_4.y;
        丙三万丙与丟丏丆丐.Rotate(xAngle:  val_6, yAngle:  0f, zAngle:  0f);
    }
    public 丅丂丘丐丐东丟丙丞()
    {
        this.且丄七丄不专丏且下 = 5f;
    }

}
