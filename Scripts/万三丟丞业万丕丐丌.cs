using UnityEngine;
internal static class 万三丟丞业万丕丐丌
{
    // Methods
    internal static bool 丅丗丑一丁一丌丏丕(char 丕上丙丝丅丛丐丏丑)
    {
        var val_3;
        if((System.Char.IsHighSurrogate(c:  丕上丙丝丅丛丐丏丑)) != false)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        val_3 = (~(System.Char.IsLowSurrogate(c:  丕上丙丝丅丛丐丏丑))) & 1;
        return (bool)val_3;
    }
    internal static string 丏丙专丞丗丐下专东(string 下业七不丑丂丏丟东)
    {
        var val_6;
        string val_7;
        val_6 = 0;
        val_7 = "";
        goto label_1;
        label_6:
        if((万三丟丞业万丕丐丌.丅丗丑一丁一丌丏丕(丕上丙丝丅丛丐丏丑:  下业七不丑丂丏丟东.Chars[0])) != false)
        {
                val_7 = val_7 + 下业七不丑丂丏丟东.Chars[0];
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < 下业七不丑丂丏丟东.Length)
        {
            goto label_6;
        }
        
        return (string)val_7;
    }

}
