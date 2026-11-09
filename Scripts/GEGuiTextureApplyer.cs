using UnityEngine;
public class GEGuiTextureApplyer : GEGuiApplyer
{
    // Fields
    private UIBasicSprite ressiver;
    private UnityEngine.Texture 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    
    // Methods
    internal override void 丘上丐世丆丑且丞丒()
    {
        this.丘上丐世丆丑且丞丒();
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
        UnityEngine.Texture val_5;
        var val_7;
        val_5 = this;
        if((val_5 & 1) == 0)
        {
            goto label_1;
        }
        
        mem[1152921537430801552] = 1;
        mem[1152921537430801600] = this.Context;
        if(this.专丞丅丅丐丞万专与 != true)
        {
                this.七丟下丏丈万丗丗丒 = this.ressiver;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        if((GameEventsHalper.下丁丞上上且世丂丅(丅东专与不三丂丁丝:  this.Context, 丒丘丏上丙丟丑丕丈:  typeof(UIBasicSprite).__il2cppRuntimeField_2E0)) == 0)
        {
            goto label_6;
        }
        
        if(this.ressiver != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_1:
        val_7 = 0;
        return (bool)val_7;
        label_6:
        val_5 = this.七丟下丏丈万丗丗丒;
        label_8:
        val_7 = 1;
        return (bool)val_7;
    }
    internal string 不丛丗丑丐丂丙丟丅(string 丟丟丄专上丟丁丐丝)
    {
        UnityEngine.Texture val_1 = GameEventsHalper.下丁丞上上且世丂丅(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丒丘丏上丙丟丑丕丈:  丟丟丄专上丟丁丐丝);
        if(val_1 == 0)
        {
                return "";
        }
        
        if(val_1 != null)
        {
                return val_1.name;
        }
        
        return val_1.name;
    }
    public GEGuiTextureApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
