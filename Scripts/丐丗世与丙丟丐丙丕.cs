using UnityEngine;
private sealed class ShopNGUIController.丐丗世与丙丟丐丙丕
{
    // Fields
    public ShopNGUIController 丝且与丝丒丟万丁专;
    public int 丞丟丛丛丐丅丛丞丂;
    public int 丟专丏不东专世丄丄;
    public 丙且上东下丏丏丟下 与丝丕与丙不与丗丆;
    
    // Methods
    public ShopNGUIController.丐丗世与丙丟丐丙丕()
    {
    
    }
    internal bool 不东丆丐丞丑丞丗万(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        var val_9;
        var val_10;
        val_9 = this;
        if((System.String.op_Equality(a:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), b:  this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七())) != false)
        {
                val_9 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
            var val_8 = (val_9 == this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌()) ? 1 : 0;
            return (bool)val_10;
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    internal int 丘一丑丅一丐丙业丁(System.Collections.Generic.List<丙且上东下丏丏丟下> 丈丏东丐不丕丐东丟)
    {
        var val_16;
        var val_17;
        if((丈丏东丐不丕丐东丟.Count >= this.丞丟丛丛丐丅丛丞丂) || (丈丏东丐不丕丐东丟.Count < 1))
        {
            goto label_4;
        }
        
        val_16 = this.丞丟丛丛丐丅丛丞丂 - 丈丏东丐不丕丐东丟.Count;
        if(丈丏东丐不丕丐东丟 != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_4:
        int val_4 = 丈丏东丐不丕丐东丟.Count;
        int val_5 = val_4 / this.丞丟丛丛丐丅丛丞丂;
        val_5 = val_4 - (val_5 * this.丞丟丛丛丐丅丛丞丂);
        if((val_5 < 1) || (丈丏东丐不丕丐东丟.Count < 1))
        {
            goto label_11;
        }
        
        int val_7 = 丈丏东丐不丕丐东丟.Count;
        int val_8 = val_7 / this.丞丟丛丛丐丅丛丞丂;
        val_8 = val_7 - (val_8 * this.丞丟丛丛丐丅丛丞丂);
        val_16 = this.丞丟丛丛丐丅丛丞丂 - val_8;
        if(丈丏东丐不丕丐东丟 != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_11:
        val_16 = 0;
        if(丈丏东丐不丕丐东丟 != null)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        int val_10 = 丈丏东丐不丕丐东丟.Count;
        if(val_10 >= 1)
        {
                int val_14 = this.丟专丏不东专世丄丄;
            int val_11 = 丈丏东丐不丕丐东丟.Count + val_16;
            val_11 = val_11 / this.丞丟丛丛丐丅丛丞丂;
            val_14 = val_14 - val_11;
            var val_12 = (val_10 > 1) ? (val_14) : 0;
            return (int)val_16 + (val_17 * this.丞丟丛丛丐丅丛丞丂);
        }
        
        val_17 = 0;
        return (int)val_16 + (val_17 * this.丞丟丛丛丐丅丛丞丂);
    }
    internal bool 丄丝三丏丕东不丏东(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        return System.String.op_Equality(a:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), b:  this.与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七());
    }
    internal bool 丒丐丏丙丁不三不丅(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        return System.String.op_Equality(a:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), b:  this.与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七());
    }

}
