using UnityEngine;
internal sealed class SetColorLerped : PGBehaviour
{
    // Fields
    public SetColorLerped.三丒丐丛不丗丌不丌 lerpType;
    public float speed;
    public System.Collections.Generic.List<UIWidget> recivers;
    public System.Collections.Generic.List<UIWidget> recivers_1;
    public System.Collections.Generic.List<UIWidget> recivers_2;
    private System.Nullable<UnityEngine.Color> 丛丌丕丐世丑丂七丂;
    private System.Nullable<UnityEngine.Color> 且与丛丘与七丆丐且;
    private System.Nullable<UnityEngine.Color> 丁业与丟三丐丑万丑;
    private UnityEngine.Color 丁与万丐丐东业三丄;
    private UnityEngine.Color 丘东下丅下且丌三丆;
    private UnityEngine.Color 丕丘丁世丐丆丛一丈;
    
    // Methods
    private void OnEnable()
    {
        var val_5;
        System.Func<UIWidget, System.Boolean> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = SetColorLerped.<>c.<>9__12_0;
        if(val_7 == null)
        {
                System.Func<UIWidget, System.Boolean> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<UIWidget, System.Boolean>(object:  SetColorLerped.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SetColorLerped.<>c::丝丁与丌丛丝丆七丞(UIWidget 三丟东丕丄丄下下丑));
            SetColorLerped.<>c.<>9__12_0 = val_7;
        }
        
        UIWidget val_2 = System.Linq.Enumerable.FirstOrDefault<UIWidget>(source:  this.recivers, predicate:  val_1);
        if(val_2 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_4 = val_2.color;
        this.丁与万丐丐东业三丄 = val_4;
        mem[1152921537740328536] = val_4.g;
        mem[1152921537740328540] = val_4.b;
        mem[1152921537740328544] = val_4.a;
    }
    internal void 丅专下万丕丑丆丅丝(string 丗丕丕丄不三丐万且, bool 丌丝丌丁下丐丞丆一)
    {
        string val_6 = 丗丕丕丄不三丐万且;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_6 = 丗丕丕丄不三丐万且);
        mem[1152921537740465224] = 0;
        this.丛丌丕丐世丑丂七丂 = 0;
        UnityEngine.Color val_3 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_6 + "_1");
        mem[1152921537740465244] = 0;
        this.且与丛丘与七丆丐且 = 0;
        UnityEngine.Color val_5 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_6 + "_2");
        mem[1152921537740465264] = 0;
        this.丁业与丟三丐丑万丑 = 0;
        if(丌丝丌丁下丐丞丆一 == false)
        {
                return;
        }
        
        val_6 = this.丁业与丟三丐丑万丑;
        this.丁与万丐丐东业三丄 = 0;
        mem[1152921537740465272] = val_5.g;
        mem[1152921537740465276] = val_5.b;
        mem[1152921537740465280] = val_5.a;
        this.丘东下丅下且丌三丆 = 0;
        mem[1152921537740465288] = val_5.g;
        mem[1152921537740465292] = val_5.b;
        mem[1152921537740465296] = val_5.a;
        this.丕丘丁世丐丆丛一丈 = 0;
        mem[1152921537740465304] = val_5.g;
        mem[1152921537740465308] = val_5.b;
        mem[1152921537740465312] = val_5.a;
    }
    internal void 丅专下万丕丑丆丅丝(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘, bool 丌丝丌丁下丐丞丆一)
    {
    
    }
    private void Update()
    {
        UnityEngine.Color val_3 = this.丝一丙丝上丛三丄丈(上丞丕专丈业丁世专:  new UnityEngine.Color() {r = this.丁与万丐丐东业三丄, g = V9.16B, b = V10.16B, a = V11.16B}, 丞下万上三丘上与专:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 丂三丟丂丈丐丆丗丟:  UnityEngine.Time.deltaTime * this.speed);
        this.丁与万丐丐东业三丄 = val_3;
        mem[1152921537740722040] = val_3.g;
        mem[1152921537740722044] = val_3.b;
        mem[1152921537740722048] = val_3.a;
        UnityEngine.Color val_6 = this.丝一丙丝上丛三丄丈(上丞丕专丈业丁世专:  new UnityEngine.Color() {r = this.丘东下丅下且丌三丆, g = V9.16B, b = V10.16B, a = V11.16B}, 丞下万上三丘上与专:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 丂三丟丂丈丐丆丗丟:  UnityEngine.Time.deltaTime * this.speed);
        this.丘东下丅下且丌三丆 = val_6;
        mem[1152921537740722056] = val_6.g;
        mem[1152921537740722060] = val_6.b;
        mem[1152921537740722064] = val_6.a;
        UnityEngine.Color val_9 = this.丝一丙丝上丛三丄丈(上丞丕专丈业丁世专:  new UnityEngine.Color() {r = this.丕丘丁世丐丆丛一丈, g = V9.16B, b = V10.16B, a = V11.16B}, 丞下万上三丘上与专:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 丂三丟丂丈丐丆丗丟:  UnityEngine.Time.deltaTime * this.speed);
        this.丕丘丁世丐丆丛一丈 = val_9;
        mem[1152921537740722072] = val_9.g;
        mem[1152921537740722076] = val_9.b;
        mem[1152921537740722080] = val_9.a;
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.recivers, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丁与万丐丐东业三丄, g = V9.16B, b = V10.16B, a = this.丕丘丁世丐丆丛一丈});
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.recivers_1, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丘东下丅下且丌三丆, g = V9.16B, b = V10.16B, a = this.丕丘丁世丐丆丛一丈});
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.recivers_2, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丕丘丁世丐丆丛一丈, g = V9.16B, b = V10.16B, a = this.丕丘丁世丐丆丛一丈});
    }
    private UnityEngine.Color 丝一丙丝上丛三丄丈(UnityEngine.Color 上丞丕专丈业丁世专, System.Nullable<UnityEngine.Color> 丞下万上三丘上与专, float 丂三丟丂丈丐丆丗丟)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        val_4 = 上丞丕专丈业丁世专.a;
        val_5 = 上丞丕专丈业丁世专.b;
        val_6 = 上丞丕专丈业丁世专.g;
        val_7 = 上丞丕专丈业丁世专.r;
        if(丞下万上三丘上与专.HasValue.HasValue == false)
        {
                return new UnityEngine.Color() {r = val_7, g = val_6, b = val_5, a = val_4};
        }
        
        if(this.lerpType != 2)
        {
                if(this.lerpType != 1)
        {
                return new UnityEngine.Color() {r = val_7, g = val_6, b = val_5, a = val_4};
        }
        
            UnityEngine.Color val_2 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_7, g = val_6, b = val_5, a = val_4}, b:  new UnityEngine.Color() {r = 上丞丕专丈业丁世专.r, g = 上丞丕专丈业丁世专.g, b = 上丞丕专丈业丁世专.b, a = 上丞丕专丈业丁世专.a}, t:  丂三丟丂丈丐丆丗丟);
            val_7 = val_2.r;
            val_6 = val_2.g;
            val_5 = val_2.b;
            val_4 = val_2.a;
            return new UnityEngine.Color() {r = val_7, g = val_6, b = val_5, a = val_4};
        }
        
        UnityEngine.Vector4 val_3 = UnityEngine.Vector4.MoveTowards(current:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, target:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, maxDistanceDelta:  丂三丟丂丈丐丆丗丟);
        return new UnityEngine.Color() {r = val_7, g = val_6, b = val_5, a = val_4};
    }
    public SetColorLerped()
    {
        this.lerpType = 1;
    }

}
