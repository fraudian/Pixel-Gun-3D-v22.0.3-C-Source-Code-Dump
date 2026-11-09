using UnityEngine;
public class GuiMaterialApplyer : GuiApplyer
{
    // Fields
    private UnityEngine.Renderer ressiver;
    private UnityEngine.Material 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    private string 一丅丗丄丐丄世万丏;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(GuiApplyersGroup 专与万丐七丌丐丁丂)
    {
        mem[1152921537857875072] = 专与万丐七丌丐丁丂;
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
        UnityEngine.Renderer val_3;
        UnityEngine.Material val_4;
        UnityEngine.Material val_5;
        var val_6;
        val_4 = this;
        if((val_4 & 1) == 0)
        {
            goto label_1;
        }
        
        if(this.专丞丅丅丐丞万专与 != true)
        {
                val_3 = this.ressiver;
            this.七丟下丏丈万丗丗丒 = val_3.sharedMaterial;
            this.专丞丅丅丐丞万专与 = true;
        }
        
        if(val_3 == 0)
        {
            goto label_7;
        }
        
        val_5 = val_3;
        goto label_9;
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        val_4 = this.七丟下丏丈万丗丗丒;
        val_5 = val_4;
        label_9:
        this.ressiver.sharedMaterial = val_5;
        val_6 = 1;
        return (bool)val_6;
    }
    internal UnityEngine.Material 专丄下丆丛丂丅七丗()
    {
        if(this.ressiver == 0)
        {
                return 0;
        }
        
        if(this.ressiver.sharedMaterial == 0)
        {
                return 0;
        }
        
        if(this.ressiver != null)
        {
                return this.ressiver.sharedMaterial;
        }
        
        return this.ressiver.sharedMaterial;
    }
    internal string 不丛丗丑丐丂丙丟丅()
    {
        if(this.ressiver == 0)
        {
                return 0;
        }
        
        this = this.ressiver.sharedMaterial;
        bool val_3 = UnityEngine.Object.op_Equality(x:  this, y:  0);
        return 0;
    }
    internal void 丆东七丂专业下与三(UnityEngine.Material 丘上专不丂万业不一)
    {
        if(this.ressiver == 0)
        {
                return;
        }
        
        this.ressiver.sharedMaterial = 丘上专不丂万业不一;
        this.一丅丗丄丐丄世万丏 = this.ressiver.sharedMaterial.name;
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
        
        if(this.ressiver.sharedMaterial == 0)
        {
                return;
        }
        
        bool val_8 = System.String.op_Inequality(a:  this.一丅丗丄丐丄世万丏, b:  this.ressiver.sharedMaterial.name.Replace(oldValue:  "(Instance)", newValue:  ""));
        this.一丅丗丄丐丄世万丏 = this.ressiver.sharedMaterial.name;
    }
    public GuiMaterialApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
