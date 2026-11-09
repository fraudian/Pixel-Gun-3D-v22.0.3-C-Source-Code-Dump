using UnityEngine;
public class TweenColor : UITweener
{
    // Fields
    public UnityEngine.Color from;
    public UnityEngine.Color to;
    private bool 丛世专万业丈东不丁;
    private UIWidget 丆不下丄丄且丞一丈;
    private UnityEngine.Material 丅丕下丗丂下世丒丞;
    private UnityEngine.Light 七丘三丄上丈上万业;
    private UnityEngine.SpriteRenderer 丐丛丌七且丄丙且丗;
    
    // Properties
    public UnityEngine.Color 丑丞丈丗丄丙丟万丄 { get; set; }
    public UnityEngine.Color 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    private void 丏万丟丙上丏丟万丑()
    {
        this.丛世专万业丈东不丁 = true;
        UIWidget val_1 = this.GetComponent<UIWidget>();
        this.丆不下丄丄且丞一丈 = val_1;
        if(val_1 != 0)
        {
                return;
        }
        
        UnityEngine.SpriteRenderer val_3 = this.GetComponent<UnityEngine.SpriteRenderer>();
        this.丐丛丌七且丄丙且丗 = val_3;
        if(val_3 != 0)
        {
                return;
        }
        
        UnityEngine.Renderer val_5 = this.GetComponent<UnityEngine.Renderer>();
        if(val_5 != 0)
        {
                this.丅丕下丗丂下世丒丞 = val_5.material;
            return;
        }
        
        UnityEngine.Light val_8 = this.GetComponent<UnityEngine.Light>();
        this.七丘三丄上丈上万业 = val_8;
        if(val_8 != 0)
        {
                return;
        }
        
        this.丆不下丄丄且丞一丈 = this.GetComponentInChildren<UIWidget>();
    }
    public UnityEngine.Color get_color()
    {
        return this.value;
    }
    public void set_color(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.value = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
    }
    public UnityEngine.Color get_value()
    {
        if(this.丛世专万业丈东不丁 != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if(this.丆不下丄丄且丞一丈 != 0)
        {
                if(this.丆不下丄丄且丞一丈 != null)
        {
                return this.丆不下丄丄且丞一丈.color;
        }
        
            return this.丆不下丄丄且丞一丈.color;
        }
        
        if(this.丅丕下丗丂下世丒丞 != 0)
        {
                if(this.丅丕下丗丂下世丒丞 != null)
        {
                return this.丅丕下丗丂下世丒丞.color;
        }
        
            return this.丅丕下丗丂下世丒丞.color;
        }
        
        if(this.丐丛丌七且丄丙且丗 != 0)
        {
                if(this.丐丛丌七且丄丙且丗 != null)
        {
                return this.丐丛丌七且丄丙且丗.color;
        }
        
            return this.丐丛丌七且丄丙且丗.color;
        }
        
        if(this.七丘三丄上丈上万业 == 0)
        {
                return UnityEngine.Color.black;
        }
        
        if(this.七丘三丄上丈上万业 != null)
        {
                return this.七丘三丄上丈上万业.color;
        }
        
        return this.七丘三丄上丈上万业.color;
    }
    public void set_value(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        if(this.丛世专万业丈东不丁 != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if(this.丆不下丄丄且丞一丈 != 0)
        {
                this.丆不下丄丄且丞一丈.color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
            return;
        }
        
        if(this.丅丕下丗丂下世丒丞 != 0)
        {
                this.丅丕下丗丂下世丒丞.color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
            return;
        }
        
        if(this.丐丛丌七且丄丙且丗 != 0)
        {
                this.丐丛丌七且丄丙且丗.color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
            return;
        }
        
        if(this.七丘三丄上丈上万业 == 0)
        {
                return;
        }
        
        this.七丘三丄上丈上万业.color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        float val_5 = 丙业与丙丗丝不丈东.r + 丙业与丙丗丝不丈东.g;
        val_5 = 丙业与丙丗丝不丈东.b + val_5;
        this.七丘三丄上丈上万业.enabled = (val_5 > 0.01f) ? 1 : 0;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.from}, b:  new UnityEngine.Color() {r = this.to}, t:  丞上与七且与七三丐);
        this.value = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    public static TweenColor Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        TweenColor val_1 = UITweener.Begin<TweenColor>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        UnityEngine.Color val_2 = val_1.value;
        if(val_1 != null)
        {
                val_1.from = val_2;
            mem2[0] = val_2.g;
            mem2[0] = val_2.b;
            mem2[0] = val_2.a;
        }
        else
        {
                mem[120] = val_2.r;
            mem2[0] = val_2.g;
            mem[128] = val_2.b;
            mem2[0] = val_2.a;
        }
        
        val_1.to = 丑丞丈丗丄丙丟万丄;
        mem2[0] = 丑丞丈丗丄丙丟万丄.g;
        mem2[0] = 丑丞丈丗丄丙丟万丄.b;
        mem2[0] = 丑丞丈丗丄丙丟万丄.a;
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
        UnityEngine.Color val_1 = this.value;
        this.from = val_1;
        mem[1152921535262884412] = val_1.g;
        mem[1152921535262884416] = val_1.b;
        mem[1152921535262884420] = val_1.a;
    }
    public override void SetEndToCurrentValue()
    {
        UnityEngine.Color val_1 = this.value;
        this.to = val_1;
        mem[1152921535262996428] = val_1.g;
        mem[1152921535262996432] = val_1.b;
        mem[1152921535262996436] = val_1.a;
    }
    private void 丐一业丌东七丐丅丗()
    {
        this.value = new UnityEngine.Color() {r = this.from};
    }
    private void 一一丌丄三丐世丌不()
    {
        this.value = new UnityEngine.Color() {r = this.to};
    }
    public TweenColor()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.from = val_1;
        mem[1152921535263332412] = val_1.g;
        mem[1152921535263332416] = val_1.b;
        mem[1152921535263332420] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.to = val_2;
        mem[1152921535263332428] = val_2.g;
        mem[1152921535263332432] = val_2.b;
        mem[1152921535263332436] = val_2.a;
    }

}
