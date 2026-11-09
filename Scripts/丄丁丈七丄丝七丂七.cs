using UnityEngine;
private sealed class 丗丄丙丁丌业丅丒丕.丄丁丈七丄丝七丂七
{
    // Fields
    public int 丅万与丑万丆丆业丑;
    
    // Methods
    public 丗丄丙丁丌业丅丒丕.丄丁丈七丄丝七丂七()
    {
    
    }
    internal 丕丑丙丑丙东丌丘丕 下上丕三三下丝丌丞(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一)
    {
        object val_23;
        object val_24;
        ItemRarity val_25;
        var val_26;
        object val_1 = 0;
        object val_9 = 0;
        object val_5 = 0;
        if((0.TryGetValue(key:  "LEVEL", value: out  val_1)) == false)
        {
            goto label_4;
        }
        
        val_23 = val_1;
        if(val_23 != 0)
        {
                val_23 = System.Convert.ToInt32(value:  val_23, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        
        if(1 != 0)
        {
            goto label_10;
        }
        
        goto label_12;
        label_4:
        val_23 = 0;
        if(1 == 0)
        {
            goto label_12;
        }
        
        label_10:
        label_12:
        if((0.TryGetValue(key:  "TIER", value: out  val_5)) == false)
        {
            goto label_13;
        }
        
        val_24 = val_5;
        if(val_24 != 0)
        {
                val_24 = System.Convert.ToInt32(value:  val_24, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        
        if(1 != 0)
        {
            goto label_19;
        }
        
        goto label_21;
        label_13:
        val_24 = 0;
        if(1 == 0)
        {
            goto label_21;
        }
        
        label_19:
        label_21:
        val_25 = 0;
        if(val_9 != 0)
        {
                if(((0.TryGetValue(key:  "RARITY", value: out  val_9)) ^ 1) != true)
        {
                val_25 = System.Convert.ToInt32(value:  val_9, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        
        }
        
        new 下不丕丛业万丌丅丛() = new 下不丕丛业万丌丅丛(业万上丆丐丞且丒七:  0, 丈丘丝一丗下丈丐不:  0, 丈下丑丆上丏丗丈专:  val_25);
        val_26 = null;
        val_26 = null;
        return (丕丑丙丑丙东丌丘丕)BalanceController.丄丞丁丈与业上丞丟.丛业丐丅丌世七丑丈(丞世不丒下上上丝丑:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丈丏万丄丒业丅丒一.Value.丐丏七丌丕丗业且上()).业东丅东丌上丗丑不(), 丙丅东业丟丂七丈业:  new 下不丕丛业万丌丅丛(), 丂东丛丐且丈丘不丏:  this.丅万与丑万丆丆业丑).丛丂三丁世万世上七(下丛丐七七丐上丌丂:  ExperienceController.丞丞丘业东丙丏七丌());
    }

}
