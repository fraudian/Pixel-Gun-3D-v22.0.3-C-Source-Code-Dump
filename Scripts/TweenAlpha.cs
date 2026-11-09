using UnityEngine;
public class TweenAlpha : UITweener
{
    // Fields
    public float from;
    public float to;
    private bool 丛世专万业丈东不丁;
    private UIRect 不丝下丆丐丙丘东丛;
    private UnityEngine.Material 丅丕下丗丂下世丒丞;
    private UnityEngine.SpriteRenderer 丐丛丌七且丄丙且丗;
    
    // Properties
    public float 与专丌丅丙上丌一丄 { get; set; }
    public float 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    public float get_alpha()
    {
        return this.value;
    }
    public void set_alpha(float 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    private void 丏万丟丙上丏丟万丑()
    {
        UnityEngine.Material val_10;
        this.丛世专万业丈东不丁 = true;
        this.不丝下丆丐丙丘东丛 = this.GetComponent<UIRect>();
        this.丐丛丌七且丄丙且丗 = this.GetComponent<UnityEngine.SpriteRenderer>();
        if(this.不丝下丆丐丙丘东丛 != 0)
        {
                return;
        }
        
        if(this.丐丛丌七且丄丙且丗 != 0)
        {
                return;
        }
        
        UnityEngine.Renderer val_5 = this.GetComponent<UnityEngine.Renderer>();
        if(val_5 != 0)
        {
                val_10 = val_5.material;
            this.丅丕下丗丂下世丒丞 = val_10;
        }
        else
        {
                val_10 = this.丅丕下丗丂下世丒丞;
        }
        
        if(val_10 != 0)
        {
                return;
        }
        
        this.不丝下丆丐丙丘东丛 = this.GetComponentInChildren<UIRect>();
    }
    public float get_value()
    {
        var val_11;
        var val_12;
        val_11 = this;
        if(this.丛世专万业丈东不丁 != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        val_12 = 1152921504848912384;
        if(this.不丝下丆丐丙丘东丛 != 0)
        {
                val_11 = ???;
            val_12 = ???;
        }
        else
        {
                if((val_11 + 152) != 0)
        {
                val_11 = mem[val_11 + 152];
            val_11 = val_11 + 152;
            UnityEngine.Color val_3 = val_11.color;
            return 1f;
        }
        
            if((val_11 + 144) != 0)
        {
                val_11 = mem[val_11 + 144];
            val_11 = val_11 + 144;
            UnityEngine.Color val_5 = val_11.color;
            return 1f;
        }
        
            return 1f;
        }
    
    }
    public void set_value(float 丙业与丙丗丝不丈东)
    {
        double val_15;
        var val_16;
        var val_17;
        val_15 = 丙业与丙丗丝不丈东;
        val_16 = this;
        if(this.丛世专万业丈东不丁 != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        val_17 = 1152921504848912384;
        if(this.不丝下丆丐丙丘东丛 != 0)
        {
                val_16 = ???;
            val_17 = ???;
            val_15 = ???;
        }
        else
        {
                if((val_16 + 152) != 0)
        {
                UnityEngine.Color val_3 = val_16 + 152.color;
            val_16 + 152.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_15};
            return;
        }
        
            if((val_16 + 144) == 0)
        {
                return;
        }
        
            UnityEngine.Color val_14 = val_16 + 144.color;
            val_16 + 144.color = new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_15};
        }
    
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        this.value = UnityEngine.Mathf.Lerp(a:  this.from, b:  this.to, t:  丞上与七且与七三丐);
    }
    public static TweenAlpha Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, float 与专丌丅丙上丌一丄)
    {
        TweenAlpha val_1 = UITweener.Begin<TweenAlpha>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        if(val_1 != null)
        {
                val_1.from = val_1.value;
        }
        else
        {
                mem[120] = val_1.value;
        }
        
        val_1.to = 与专丌丅丙上丌一丄;
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
        this.from = this.value;
    }
    public override void SetEndToCurrentValue()
    {
        this.to = this.value;
    }
    public TweenAlpha()
    {
        this.from = 1f;
        this.to = 1f;
    }

}
