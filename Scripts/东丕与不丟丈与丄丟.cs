using UnityEngine;
public class 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟
{
    // Fields
    private UnityEngine.ResourceRequest 东丞丒丙世丏三下丟;
    private bool 丅丑东上丐丑世东七;
    private string 丗下上业丈不丑丕丙;
    private UnityEngine.Object 丅丏丑东丅丈业上世;
    
    // Properties
    public UnityEngine.Object 丄专丄丟七丅万不丅 { get; set; }
    public bool 丈丂上丁丄丛上下且 { get; }
    
    // Methods
    public 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟(string 丛丄业丕且丗下一万, bool 不丌丞专丈丙丛东丏)
    {
        this.丗下上业丈不丑丕丙 = 丛丄业丕且丗下一万;
        if(不丌丞专丈丙丛东丏 != false)
        {
                if(this.东丞丒丙世丏三下丟 != null)
        {
                this.东丞丒丙世丏三下丟 = 0;
        }
        
            this.丅丏丑东丅丈业上世 = UnityEngine.Resources.Load(path:  丛丄业丕且丗下一万);
            this.丅丑东上丐丑世东七 = true;
            return;
        }
        
        this.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  丛丄业丕且丗下一万);
    }
    public UnityEngine.Object 丂丑且与丐七丟丝下()
    {
        if(this.丅丏丑东丅丈业上世 != 0)
        {
                return (UnityEngine.Object)this.丅丏丑东丅丈业上世;
        }
        
        if(this.下丑万三且丟丒丌丕() == true)
        {
                return (UnityEngine.Object)this.丅丏丑东丅丈业上世;
        }
        
        if(this.东丞丒丙世丏三下丟 != null)
        {
                this.东丞丒丙世丏三下丟 = 0;
        }
        
        this.丅丏丑东丅丈业上世 = UnityEngine.Resources.Load(path:  this.丗下上业丈不丑丕丙);
        this.丅丑东上丐丑世东七 = true;
        return (UnityEngine.Object)this.丅丏丑东丅丈业上世;
    }
    public void 丟丌丝专丅下丑丒与(UnityEngine.Object 丙业与丙丗丝不丈东)
    {
        this.丅丏丑东丅丈业上世 = 丙业与丙丗丝不丈东;
    }
    public void 不丒丒丕丙丞丟丟与()
    {
        if(this.东丞丒丙世丏三下丟 != null)
        {
                this.东丞丒丙世丏三下丟 = 0;
        }
        
        this.丅丏丑东丅丈业上世 = UnityEngine.Resources.Load(path:  this.丗下上业丈不丑丕丙);
        this.丅丑东上丐丑世东七 = true;
    }
    public bool 下丑万三且丟丒丌丕()
    {
        bool val_3;
        if(this.丅丑东上丐丑世东七 != false)
        {
                val_3 = 1;
            return (bool)val_3;
        }
        
        if(this.东丞丒丙世丏三下丟.isDone != false)
        {
                this.丅丏丑东丅丈业上世 = this.东丞丒丙世丏三下丟.asset;
            val_3 = true;
            this.东丞丒丙世丏三下丟 = 0;
            this.丅丑东上丐丑世东七 = val_3;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }

}
