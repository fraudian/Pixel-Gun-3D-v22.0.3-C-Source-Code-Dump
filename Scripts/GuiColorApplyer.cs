using UnityEngine;
public class GuiColorApplyer : GuiApplyer
{
    // Fields
    private UIWidget ressiver;
    private UnityEngine.Color 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    private System.Nullable<UnityEngine.Color> 上三丙丘且万丌一丂;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(GuiApplyersGroup 专与万丐七丌丐丁丂)
    {
        mem[1152921537856313984] = 专与万丐七丌丐丁丂;
        this.ressiver = this.GetComponent<UIWidget>();
    }
    internal override bool 三业丒丑丂三丕上丛()
    {
        var val_5;
        UnityEngine.Color val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = this;
        if(this.七丆业丗不业丙丏三() == false)
        {
            goto label_0;
        }
        
        if(this.专丞丅丅丐丞万专与 != true)
        {
                UnityEngine.Color val_2 = this.ressiver.color;
            this.七丟下丏丈万丗丗丒 = val_2;
            mem[1152921537856442388] = val_2.g;
            mem[1152921537856442392] = val_2.b;
            mem[1152921537856442396] = val_2.a;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.clear;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, rhs:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a})) == false)
        {
            goto label_4;
        }
        
        val_6 = val_2.r;
        val_7 = val_2.g;
        val_8 = val_2.b;
        val_9 = val_2.a;
        if(this.ressiver != null)
        {
            goto label_9;
        }
        
        goto label_7;
        label_0:
        val_10 = 0;
        return (bool)val_10;
        label_4:
        val_6 = this.七丟下丏丈万丗丗丒;
        if(this.ressiver != null)
        {
            goto label_9;
        }
        
        label_7:
        label_9:
        this.ressiver.color = new UnityEngine.Color() {r = val_6, g = val_2.g, b = val_2.b, a = val_2.a};
        val_10 = 1;
        return (bool)val_10;
    }
    internal UnityEngine.Color 专丄下丆丛丂丅七丗()
    {
        if(this.ressiver == 0)
        {
                return UnityEngine.Color.clear;
        }
        
        if(this.ressiver != null)
        {
                return this.ressiver.color;
        }
        
        return this.ressiver.color;
    }
    internal void 丆东七丂专业下与三(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(this.ressiver == 0)
        {
                return;
        }
        
        this.ressiver.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        UnityEngine.Color val_2 = this.ressiver.color;
        mem[1152921537856703284] = 0;
        this.上三丙丘且万丌一丂 = 0;
    }
    protected override void 不丏丌丟丑丄丟上丝()
    {
        if(this.ressiver == 0)
        {
                return;
        }
        
        if(this.ressiver == 0)
        {
                return;
        }
        
        if(this.上三丙丘且万丌一丂.HasValue != false)
        {
                UnityEngine.Color val_4 = this.ressiver.color;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B}, rhs:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a})) == false)
        {
                return;
        }
        
            UnityEngine.Color val_6 = this.ressiver.color;
            mem2[0] = 0;
            mem2[0] = 0;
            if(this.上三丙丘且万丌一丂 != 0)
        {
                return;
        }
        
            return;
        }
        
        this = this.ressiver;
        UnityEngine.Color val_7 = this.color;
        mem2[0] = 0;
        mem2[0] = 0;
    }
    public GuiColorApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
