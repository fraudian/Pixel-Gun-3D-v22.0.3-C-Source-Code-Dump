using UnityEngine;
public class 丑丁且丏万丒丅三丝 : 东丁世丕万丘丛丙上
{
    // Fields
    public float 丐一丁上丑丅与且七;
    private float 丝一丐一丅不丑上丆;
    public float 丆万丅世三丅丕且丁;
    private int 且丐丆下丝丄丄丏丆;
    public float 丌三丛世业丝业丗丘;
    private UnityEngine.Vector2[] 不世丕丈丐丂与且东;
    private int 不丄丌世东丈丄丕丞;
    private bool 丄三丆万丁丕丛丛丈;
    public float 丏七丞丞丈世世三丁;
    public float 专业一丟丙世不丗丅;
    private UnityEngine.Vector2 丆丌丙业丄世丁上丌;
    public float 七东丙下丛不业丄三;
    
    // Properties
    private bool 丆丟专丑丁丒丁上丙 { get; }
    
    // Methods
    private bool 丏丟丁丁丑丟丞丄丌()
    {
        null = null;
        if(JoystickController.丘万丏三丏丑世丐丏 != null)
        {
                return JoystickController.丘万丏三丏丑世丐丏.HasTouchFinger;
        }
        
        return JoystickController.丘万丏三丏丑世丐丏.HasTouchFinger;
    }
    private void 丞上丞丕下下不不上(UnityEngine.Vector2 丒丙丐一丈一三一丆)
    {
        int val_2;
        int val_1 = this.且丐丆下丝丄丄丏丆 + 1;
        this.且丐丆下丝丄丄丏丆 = val_1;
        if(val_1 < this.不世丕丈丐丂与且东.Length)
        {
                val_2 = this.且丐丆下丝丄丄丏丆;
        }
        else
        {
                val_2 = 0;
            this.且丐丆下丝丄丄丏丆 = 0;
        }
        
        this.不世丕丈丐丂与且东[0] = 丒丙丐一丈一三一丆;
        this.不世丕丈丐丂与且东[0] = 丒丙丐一丈一三一丆.y;
        if(this.不丄丌世东丈丄丕丞 >= this.不世丕丈丐丂与且东.Length)
        {
                return;
        }
        
        int val_2 = this.不丄丌世东丈丄丕丞;
        val_2 = val_2 + 1;
        this.不丄丌世东丈丄丕丞 = val_2;
    }
    private UnityEngine.Vector2 丝业丈七丒丞且万下()
    {
        float val_5;
        int val_8;
        float val_9;
        float val_10;
        float val_13;
        float val_14;
        float val_17;
        float val_18;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_5 = val_1.z;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_5});
        val_8 = this.不丄丌世东丈丄丕丞;
        val_9 = val_2.x;
        val_10 = val_2.y;
        if(val_8 == 0)
        {
                return new UnityEngine.Vector2() {x = val_17, y = val_18};
        }
        
        if(val_8 >= 1)
        {
                var val_6 = 0;
            do
        {
            val_5 = this.不世丕丈丐丂与且东[0];
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, b:  new UnityEngine.Vector2() {x = this.不世丕丈丐丂与且东[0], y = val_5});
            val_8 = this.不丄丌世东丈丄丕丞;
            val_6 = val_6 + 1;
            val_13 = val_3.x;
            val_14 = val_3.y;
        }
        while(val_6 < val_8);
        
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_13, y = val_14}, d:  (float)val_8);
        val_17 = val_4.x;
        val_18 = val_4.y;
        return new UnityEngine.Vector2() {x = val_17, y = val_18};
    }
    private void 丌丒丅丟丈丗丗丘丅()
    {
        this.且丐丆下丝丄丄丏丆 = 0;
        this.不丄丌世东丈丄丕丞 = 0;
    }
    public override void OnPress(bool 丆且上丘世下丅且丞)
    {
    
    }
    public override void 丑丈丆万丅上丞丗丐()
    {
        var val_15;
        bool val_1 = this.丏丟丁丁丑丟丞丄丌();
        if(val_1 != false)
        {
                if(this.丄三丆万丁丕丛丛丈 != true)
        {
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.丆丌丙业丄世丁上丌 = val_2;
            mem[1152921539925248924] = val_2.y;
        }
        
            this.丝一丐一丅不丑上丆 = 0f;
        }
        else
        {
                if(this.丄三丆万丁丕丛丛丈 != false)
        {
                UnityEngine.Vector2 val_3 = this.丝业丈七丒丞且万下();
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  this.七东丙下丛不业丄三);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.丆丌丙业丄世丁上丌, y = V9.16B}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.丆丌丙业丄世丁上丌 = val_5;
            mem[1152921539925248924] = val_5.y;
            this.且丐丆下丝丄丄丏丆 = 0;
            this.不丄丌世东丈丄丕丞 = 0;
        }
        
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = this.丝一丐一丅不丑上丆 + val_6;
            this.丝一丐一丅不丑上丆 = UnityEngine.Mathf.Clamp(value:  val_6, min:  0f, max:  1f);
        }
        
        this.丄三丆万丁丕丛丛丈 = val_1;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = this.丆丌丙业丄世丁上丌, y = val_3.x}, t:  (val_1 != true) ? this.丆万丅世三丅丕且丁 : this.丐一丁上丑丅与且七);
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.丆丌丙业丄世丁上丌, y = this.丆丌丙业丄世丁上丌}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        this.丆丌丙业丄世丁上丌 = val_12;
        mem[1152921539925248924] = val_12.y;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, rhs:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y})) == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, 万业丒丞丅一丂丈业:  false);
    }
    public override void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, d:  this.专业一丟丙世不丗丅);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  UnityEngine.Mathf.Lerp(a:  1f, b:  UnityEngine.Mathf.Min(a:  this.丌三丛世业丝业丗丘, b:  val_1.x), t:  this.丏七丞丞丈世世三丁));
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.丆丌丙业丄世丁上丌, y = 丞且丅三三东不丄且.x}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.丆丌丙业丄世丁上丌 = val_5;
        mem[1152921539925360924] = val_5.y;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  UnityEngine.Time.deltaTime);
        this.丞上丞丕下下不不上(丒丙丐一丈一三一丆:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
    }
    public override void 且七丙丄丘一丄上不()
    {
    
    }
    public override void 丑丗丘丗下丙丆丅七(UnityEngine.Vector2 一丟丂三丌丆与丟一, UnityEngine.Transform 丒一丘三丞与丟七三, UnityEngine.Transform 丙三万丙与丟丏丆丐, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一)
    {
    
    }
    public 丑丁且丏万丒丅三丝()
    {
        this.丐一丁上丑丅与且七 = 1f;
        this.丝一丐一丅不丑上丆 = 1f;
        this.丆万丅世三丅丕且丁 = 0.9f;
        this.丌三丛世业丝业丗丘 = 11.5f;
        this.不世丕丈丐丂与且东 = new UnityEngine.Vector2[3];
        this.丏七丞丞丈世世三丁 = 0.4f;
        this.专业一丟丙世不丗丅 = 2.204102E-41f;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丆丌丙业丄世丁上丌 = val_2;
        mem[1152921539925717436] = val_2.y;
        this.七东丙下丛不业丄三 = 0.05f;
    }

}
