using UnityEngine;
public class GuiShaderApplyer : GuiApplyer
{
    // Fields
    private UIBasicSprite ressiver;
    private string 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    private string 一丅丗丄丐丄世万丏;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(GuiApplyersGroup 专与万丐七丌丐丁丂)
    {
        mem[1152921537863663072] = 专与万丐七丌丐丁丂;
        if(this.ressiver != 0)
        {
                return;
        }
        
        this.ressiver = this.GetComponent<UIBasicSprite>();
    }
    internal override bool 七丆业丗不业丙丏三()
    {
        if(this.七丆业丗不业丙丏三() == false)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.ressiver, y:  0);
    }
    internal override bool 三业丒丑丂三丕上丛()
    {
        UnityEngine.Object val_4;
        var val_5;
        var val_7;
        val_5 = this;
        if((val_5 & 1) == 0)
        {
            goto label_1;
        }
        
        if(this.专丞丅丅丐丞万专与 != true)
        {
                val_4 = this.ressiver;
            this.七丟下丏丈万丗丗丒 = val_4.name;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        if(val_4 == 0)
        {
            goto label_8;
        }
        
        if(this.ressiver != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_1:
        val_7 = 0;
        return (bool)val_7;
        label_8:
        val_5 = UnityEngine.Shader.Find(name:  this.七丟下丏丈万丗丗丒);
        label_10:
        val_7 = 1;
        return (bool)val_7;
    }
    internal string 不丛丗丑丐丂丙丟丅()
    {
        if(this.ressiver == 0)
        {
                return 0;
        }
        
        this = this.ressiver;
        bool val_2 = UnityEngine.Object.op_Equality(x:  this, y:  0);
        return 0;
    }
    internal UnityEngine.Shader 专丄下丆丛丂丅七丗()
    {
        if(this.ressiver == 0)
        {
                return 0;
        }
        
        if(this.ressiver == 0)
        {
                return 0;
        }
        
        if(this.ressiver == null)
        {
            
        }
    
    }
    internal void 丆东七丂专业下与三(UnityEngine.Shader 丕丄与专丛丝丄丐下)
    {
        if(this.ressiver == 0)
        {
                return;
        }
        
        this.一丅丗丄丐丄世万丏 = this.ressiver.name;
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
        
        if(this.ressiver == 0)
        {
                return;
        }
        
        bool val_5 = System.String.op_Inequality(a:  this.一丅丗丄丐丄世万丏, b:  this.ressiver.name);
        this.一丅丗丄丐丄世万丏 = this.ressiver.name;
    }
    public GuiShaderApplyer()
    {
        this.一丅丗丄丐丄世万丏 = "";
        this = new UnityEngine.MonoBehaviour();
    }

}
