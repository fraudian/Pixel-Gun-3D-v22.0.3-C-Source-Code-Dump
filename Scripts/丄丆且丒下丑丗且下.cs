using UnityEngine;
private sealed class 上丑三丁丄丛丁万丑.丄丆且丒下丑丗且下
{
    // Fields
    public CategoryNames 丁且上与丈丂专专业;
    
    // Methods
    public 上丑三丁丄丛丁万丑.丄丆且丒下丑丗且下()
    {
    
    }
    internal int 丛丂三丌不世万丘丛(string 丅丒三七丄丛上丑东, string 丝丆丌丈且丂丂上丑)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_2 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().Item[this.丁且上与丈丂专专业];
        val_20 = 0;
        goto label_4;
        label_9:
        val_21 = val_2.Item[0].IndexOf(item:  丅丒三七丄丛上丑东);
        if(val_21 != 1)
        {
            goto label_7;
        }
        
        val_20 = 1;
        label_4:
        if(val_20 < val_2.Count)
        {
            goto label_9;
        }
        
        val_21 = 0;
        val_22 = 0;
        goto label_10;
        label_7:
        System.Collections.Generic.List<System.String> val_6 = val_2.Item[0];
        label_10:
        val_23 = 0;
        goto label_12;
        label_17:
        int val_8 = val_2.Item[0].IndexOf(item:  丝丆丌丈且丂丂上丑);
        if(val_8 != 1)
        {
            goto label_15;
        }
        
        val_23 = 1;
        label_12:
        if(val_23 < val_2.Count)
        {
            goto label_17;
        }
        
        val_24 = 0;
        return (int)val_24;
        label_15:
        System.Collections.Generic.List<System.String> val_10 = val_2.Item[0];
        val_24 = 0;
        if(val_6 == null)
        {
                return (int)val_24;
        }
        
        if(val_10 == null)
        {
                return (int)val_24;
        }
        
        if(val_6 != val_10)
        {
                val_21 = 1152921516223708000;
            val_22 = 七丌丞万七万丁丐丙.丕与东丞丕丒丘不丂(丝丒丞丙丐一一丅三:  val_10.Item[0]);
            val_24 = (((七丌丞万七万丁丐丙.丕与东丞丕丒丘不丂(丝丒丞丙丐一一丅三:  val_6.Item[0]).专七三丘丗七丆丟丗()) != true) ? -1000 : (val_20)) - ((val_22.专七三丘丗七丆丟丗() != true) ? -1000 : (val_23));
            return (int)val_24;
        }
        
        val_24 = val_21 - val_8;
        return (int)val_24;
    }

}
