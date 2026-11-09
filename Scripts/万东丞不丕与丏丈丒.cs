using UnityEngine;
internal sealed class 万东丞不丕与丏丈丒 : 三且丛下丛丝丐专世
{
    // Properties
    internal override string 丂丛丗世丈上丑丟丄 { get; }
    
    // Methods
    internal override string 丂丗丐丗丝七丙丐丛()
    {
        return "IDFA";
    }
    protected override void 下世丙丐上专业下丒(object 丛一丂上丒丛且万上)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        bool val_12;
        val_7 = 丛一丂上丒丛且万上;
        if(val_7 != null)
        {
                val_8 = 0;
            val_7 = 0;
        }
        else
        {
                val_8 = 0;
        }
        
        val_9 = null;
        val_9 = null;
        PGCompany.丅丗且下丈业丌与丞.丝丘丏丄上丝与丅丆 = "Key_10505";
        if(val_8 == 0)
        {
            goto label_7;
        }
        
        if(val_7 != null)
        {
                val_10 = 0;
        }
        else
        {
                val_10 = 1;
        }
        
        if((val_7.ContainsKey(key:  "SystemBannerOnly")) == false)
        {
            goto label_15;
        }
        
        val_7 = System.Convert.ToBoolean(value:  val_7.Item["SystemBannerOnly"]);
        val_12 = val_7;
        goto label_21;
        label_15:
        val_9 = null;
        label_7:
        val_12 = true;
        label_21:
        PGCompany.丅丗且下丈业丌与丞.丝东三丂丗一专与丗 = val_12;
    }
    protected override void 丂与丗专上业丏丗万()
    {
        null = null;
        PGCompany.丅丗且下丈业丌与丞.丝东三丂丗一专与丗 = true;
        PGCompany.丅丗且下丈业丌与丞.丝丘丏丄上丝与丅丆 = "Key_10505";
    }
    public 万东丞不丕与丏丈丒()
    {
    
    }

}
