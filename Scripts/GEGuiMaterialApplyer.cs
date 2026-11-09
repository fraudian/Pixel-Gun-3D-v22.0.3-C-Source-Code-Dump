using UnityEngine;
public class GEGuiMaterialApplyer : GEGuiApplyer
{
    // Fields
    private UnityEngine.Renderer ressiver;
    private UnityEngine.Material 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    
    // Methods
    internal override void 丘上丐世丆丑且丞丒()
    {
        this.丘上丐世丆丑且丞丒();
        if(this.ressiver != 0)
        {
                return;
        }
        
        this.ressiver = this.GetComponent<UnityEngine.Renderer>();
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
        UnityEngine.Material val_6;
        UnityEngine.Material val_7;
        var val_8;
        val_6 = this;
        if((val_6 & 1) == 0)
        {
            goto label_1;
        }
        
        mem[1152921537427906192] = 1;
        mem[1152921537427906240] = this.Context;
        if(this.专丞丅丅丐丞万专与 != true)
        {
                this.七丟下丏丈万丗丗丒 = this.ressiver.sharedMaterial;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        UnityEngine.Material val_4 = GameEventsHalper.丄丑与一丁丝丌丁东(丅东专与不三丂丁丝:  this.Context, 丒丘丏上丙丟丑丕丈:  0);
        if(val_4 == 0)
        {
            goto label_6;
        }
        
        val_7 = val_4;
        goto label_8;
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_6:
        val_6 = this.七丟下丏丈万丗丗丒;
        val_7 = val_6;
        label_8:
        this.ressiver.sharedMaterial = val_7;
        val_8 = 1;
        return (bool)val_8;
    }
    internal string 不丛丗丑丐丂丙丟丅(string 丟丟丄专上丟丁丐丝)
    {
        UnityEngine.Material val_1 = GameEventsHalper.丄丑与一丁丝丌丁东(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丒丘丏上丙丟丑丕丈:  丟丟丄专上丟丁丐丝);
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
    public GEGuiMaterialApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
