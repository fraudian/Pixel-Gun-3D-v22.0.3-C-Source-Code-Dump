using UnityEngine;
internal sealed class 丄丕七一上丛丛丕丄 : IComparer<丙且上东下丏丏丟下>
{
    // Methods
    public int Compare(丙且上东下丏丏丟下 三丟东丕丄丄下下丑, 丙且上东下丏丏丟下 丒丒丄丁且丄丆丂丌)
    {
        var val_33;
        string val_34;
        int val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        val_34 = 三丟东丕丄丄下下丑;
        if(val_34 == null)
        {
            goto label_1;
        }
        
        if(丒丒丄丁且丄丆丂丌 == null)
        {
            goto label_2;
        }
        
        string val_1 = val_34.业上丙丞丐丄丆丅七();
        val_35 = 七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  val_34.业上丙丞丐丄丆丅七());
        string val_4 = 丒丒丄丁且丄丆丂丌.业上丙丞丐丄丆丅七();
        int val_6 = 七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  丒丒丄丁且丄丆丂丌.业上丙丞丐丄丆丅七());
        var val_8 = ((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  val_1)) == 2) ? 1 : 0;
        val_33 = ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  val_4);
        val_37 = null;
        val_37 = null;
        bool val_11 = val_4.Contains(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒);
        if((val_1.Contains(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) == false)
        {
            goto label_11;
        }
        
        val_38 = null;
        val_38 = null;
        val_35 = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.Length;
        bool val_17 = System.Int32.TryParse(s:  val_1.Substring(startIndex:  val_35 + 4), style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0);
        val_36 = 1;
        val_39 = 1;
        if(val_11 == true)
        {
            goto label_18;
        }
        
        label_28:
        val_34 = BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  val_6);
        一一万丒与专丙丁丛 val_29 = BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_6);
        if(val_39 ^ val_34 == true)
        {
                return (int)(val_8 == 0) ? (-1) : 1;
        }
        
        var val_21 = (val_33 == 2) ? 1 : 0;
        if((val_39 & 1) != 0)
        {
            goto label_22;
        }
        
        goto label_23;
        label_1:
        var val_22 = (丒丒丄丁且丄丆丂丌 != 0) ? 1 : 0;
        return (int)(val_8 == 0) ? (-1) : 1;
        label_2:
        val_41 = 0;
        return (int)(val_8 == 0) ? (-1) : 1;
        label_11:
        val_39 = BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  val_35);
        一一万丒与专丙丁丛 val_24 = BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_35);
        if(val_11 == false)
        {
            goto label_28;
        }
        
        label_18:
        val_42 = null;
        val_42 = null;
        val_34 = val_4.Substring(startIndex:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.Length + 4);
        bool val_30 = System.Int32.TryParse(s:  val_34, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_29);
        if(val_39 == false)
        {
                return (int)(val_8 == 0) ? (-1) : 1;
        }
        
        val_40 = 1;
        label_22:
        if(val_40 != val_8)
        {
                return (int)(val_8 == 0) ? (-1) : 1;
        }
        
        if(val_24 != val_29)
        {
            goto label_37;
        }
        
        label_23:
        val_41 = 0;
        return (int)(val_8 == 0) ? (-1) : 1;
        label_37:
        var val_32 = (val_24 <= val_29) ? (-1) : 1;
        return (int)(val_8 == 0) ? (-1) : 1;
    }
    public 丄丕七一上丛丛丕丄()
    {
    
    }

}
