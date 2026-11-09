using UnityEngine;
internal class FirstPersonCamera : BaseCamera
{
    // Methods
    protected override void Awake()
    {
        this.Awake();
        mem[1152921539917110720] = this.camera.fieldOfView;
        this.丞与三丞丗且丟下七(不丌丕不七丗丞万万:  this.transform, 丗丈丑丅丑丕丘丂丐:  0);
    }
    internal override void 丗丂东丌丙一丕业丙(UnityEngine.Vector2 丞且丅三三东不丄且, bool 万业丒丞丅一丂丈业 = False)
    {
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, d:  this.与丈丏东一丘丆丁三());
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  30f);
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, d:  (万业丒丞丅一丂丈业 != true) ? 1280f : ((float)UnityEngine.Screen.width));
        val_6.y = val_6.y * ((106016768 != 0) ? 1f : -1f);
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.y);
        float val_9 = this.与丈丏东一丘丆丁三();
        var val_10 = (万业丒丞丅一丂丈业 == true) ? 1 : 0;
    }
    internal override void 一上丘丞丕丅丝丑丄(UnityEngine.Vector2 丞且丅三三东不丄且, float 丗丝业万与丆七东丁, bool 丝业丈不丙丄丝一一, bool 与丒下丅丛丏丘世丘 = False, bool 丅与万万丌一丑丟丒 = False)
    {
        var val_5;
        float val_7 = 丞且丅三三东不丄且.y;
        val_5 = this;
        if(137109504 == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_2 = localRotation;
        float val_5 = -360f;
        float val_6 = -65f;
        val_5 = val_2.x + val_5;
        val_2.x = (val_2.x > 180f) ? (val_5) : val_2.x;
        val_5 = val_7 + val_2.x;
        float val_4 = (val_5 < 0) ? (val_6 - val_2.x) : (val_7);
        val_6 = val_2.x + val_4;
        val_2.x = 80f - val_2.x;
        val_7 = (val_6 > 80f) ? (val_2.x) : (val_4);
        this.Rotate(xAngle:  val_7, yAngle:  0f, zAngle:  0f);
    }
    internal override void 丁丆且丑丙丛上丛万()
    {
        float val_1 = Player_move_c.且丒丗丑万丐丗丅三();
        this.丁丆且丑丙丛上丛万();
    }
    internal override void 丏丄丕三丆一丛丞丗(float 丁丌业三东不东东丙, float 丟丞一专丕三东丗一 = 0)
    {
        this.丏丄丕三丆一丛丞丗(丁丌业三东不东东丙:  丁丌业三东不东东丙, 丟丞一专丕三东丗一:  丟丞一专丕三东丗一);
        if(丟丞一专丕三东丗一 != 0f)
        {
                return;
        }
        
        this.camera.fieldOfView = 丁丌业三东不东东丙;
    }
    internal override void 丒一丅下丐丆丛丆丁()
    {
        mem[1152921539917687112] = 1036831949;
        this.丒一丅下丐丆丛丆丁();
    }
    internal override void 丝丏一丆丐丄丙七一(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
        this.丝丏一丆丐丄丙七一(七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Quaternion val_3 = this.camera.transform.rotation;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_3.y, z:  val_3.z);
        this.camera.transform.rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    public FirstPersonCamera()
    {
    
    }

}
