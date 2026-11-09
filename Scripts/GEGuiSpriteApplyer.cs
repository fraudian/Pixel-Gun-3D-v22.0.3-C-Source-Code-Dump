using UnityEngine;
public class GEGuiSpriteApplyer : GEGuiApplyer
{
    // Fields
    private UISprite ressiver;
    private string 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    
    // Methods
    internal override void 丘上丐世丆丑且丞丒()
    {
        this.丘上丐世丆丑且丞丒();
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
        string val_12;
        UISprite val_13;
        var val_14;
        val_12 = this;
        if((val_12 & 1) == 0)
        {
            goto label_1;
        }
        
        mem[1152921537429870096] = 1;
        mem[1152921537429870144] = this.Context;
        if(this.专丞丅丅丐丞万专与 != true)
        {
                this.七丟下丏丈万丗丗丒 = this.ressiver.spriteName;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        .且上与一七丟丐丂丛 = GameEventsHalper.专与丆与丅下丅且丆(丅东专与不三丂丁丝:  this.Context, 丒丘丏上丙丟丑丕丈:  0);
        val_13 = this.ressiver;
        if((System.String.op_Inequality(a:  val_13.spriteName, b:  (GEGuiSpriteApplyer.丞丂万丅不丒丘丟丗)[1152921537429902064].且上与一七丟丐丂丛)) == false)
        {
            goto label_6;
        }
        
        val_13 = this.ressiver;
        if((this.ressiver.atlas.spriteList.Exists(match:  new System.Predicate<UISpriteData>(object:  new GEGuiSpriteApplyer.丞丂万丅不丒丘丟丗(), method:  System.Boolean GEGuiSpriteApplyer.丞丂万丅不丒丘丟丗::丘丐且丂业丛丞丟丄(UISpriteData 三丟东丕丄丄下下丑)))) == false)
        {
            goto label_10;
        }
        
        val_12 = (GEGuiSpriteApplyer.丞丂万丅不丒丘丟丗)[1152921537429902064].且上与一七丟丐丂丛;
        if(val_13 != null)
        {
            goto label_14;
        }
        
        goto label_12;
        label_1:
        val_14 = 0;
        return (bool)val_14;
        label_10:
        val_12 = this.七丟下丏丈万丗丗丒;
        if(val_13 != null)
        {
            goto label_14;
        }
        
        label_12:
        label_14:
        val_13.spriteName = val_12;
        label_6:
        val_14 = 1;
        return (bool)val_14;
    }
    internal string 不丛丗丑丐丂丙丟丅(string 丟丟丄专上丟丁丐丝)
    {
        return GameEventsHalper.专与丆与丅下丅且丆(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丒丘丏上丙丟丑丕丈:  X8);
    }
    public GEGuiSpriteApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
