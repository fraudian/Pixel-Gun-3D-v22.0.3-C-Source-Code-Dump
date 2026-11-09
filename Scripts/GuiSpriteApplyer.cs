using UnityEngine;
public class GuiSpriteApplyer : GuiApplyer
{
    // Fields
    private UISprite ressiver;
    private string 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    private string 一丅丗丄丐丄世万丏;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(GuiApplyersGroup 专与万丐七丌丐丁丂)
    {
        mem[1152921537864772064] = 专与万丐七丌丐丁丂;
        if(this.ressiver != 0)
        {
                return;
        }
        
        this.ressiver = this.GetComponent<UISprite>();
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
        string val_10;
        UISprite val_11;
        var val_12;
        val_10 = this;
        if((val_10 & 1) == 0)
        {
            goto label_1;
        }
        
        if(this.专丞丅丅丐丞万专与 != true)
        {
                this.七丟下丏丈万丗丗丒 = this.ressiver.spriteName;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        float val_3 = this.ressiver.CalculateFinalAlpha(与专丙丝丝且丂且丒:  X22);
        .且上与一七丟丐丂丛 = this.ressiver;
        val_11 = this.ressiver;
        if((System.String.op_Inequality(a:  val_11.spriteName, b:  (GuiSpriteApplyer.丞丂万丅不丒丘丟丗)[1152921537865102784].且上与一七丟丐丂丛)) == false)
        {
            goto label_7;
        }
        
        val_11 = this.ressiver;
        if((this.ressiver.atlas.spriteList.Exists(match:  new System.Predicate<UISpriteData>(object:  new GuiSpriteApplyer.丞丂万丅不丒丘丟丗(), method:  System.Boolean GuiSpriteApplyer.丞丂万丅不丒丘丟丗::丘丐且丂业丛丞丟丄(UISpriteData 三丟东丕丄丄下下丑)))) == false)
        {
            goto label_11;
        }
        
        val_10 = (GuiSpriteApplyer.丞丂万丅不丒丘丟丗)[1152921537865102784].且上与一七丟丐丂丛;
        if(val_11 != null)
        {
            goto label_15;
        }
        
        goto label_13;
        label_1:
        val_12 = 0;
        return (bool)val_12;
        label_11:
        val_10 = this.七丟下丏丈万丗丗丒;
        if(val_11 != null)
        {
            goto label_15;
        }
        
        label_13:
        label_15:
        val_11.spriteName = val_10;
        label_7:
        val_12 = 1;
        return (bool)val_12;
    }
    internal string 专丄下丆丛丂丅七丗()
    {
        if(this.ressiver == 0)
        {
                return "";
        }
        
        if((System.String.IsNullOrEmpty(value:  this.ressiver.spriteName)) != false)
        {
                return "";
        }
        
        if(this.ressiver != null)
        {
                return this.ressiver.spriteName;
        }
        
        return this.ressiver.spriteName;
    }
    internal void 丆东七丂专业下与三(string 万丑丞一丝丌丐丒丘)
    {
        if(this.ressiver == 0)
        {
                return;
        }
        
        this.ressiver.spriteName = 万丑丞一丝丌丐丒丘;
        this.一丅丗丄丐丄世万丏 = this.ressiver.spriteName;
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
        
        if((System.String.IsNullOrEmpty(value:  this.ressiver.spriteName)) == true)
        {
                return;
        }
        
        bool val_6 = System.String.op_Inequality(a:  this.一丅丗丄丐丄世万丏, b:  this.ressiver.spriteName);
        this.一丅丗丄丐丄世万丏 = this.ressiver.spriteName;
    }
    public GuiSpriteApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
