using UnityEngine;
public class 丌丆丒七丑丞东三丛
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟> 丈与丁丗上丐世丐丞;
    private static string[] 万上丗丕专丟三丐丗;
    private static int 不丛三三专丛一万丝;
    
    // Methods
    internal static 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丐下下丅与上东丙丑(string 丛丄业丕且丗下一万, bool 不丌丞专丈丙丛东丏 = False)
    {
        var val_4;
        东丕与不丟丈与丄丟 val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_3;
        }
        
        label_12:
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_2 = null;
        val_5 = val_2;
        val_2 = new 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟(丛丄业丕且丗下一万:  丛丄业丕且丗下一万, 不丌丞专丈丙丛东丏:  不丌丞专丈丙丛东丏);
        val_6 = null;
        val_6 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
        {
                return (东丕与不丟丈与丄丟)val_5;
        }
        
        丌丆丒七丑丞东三丛.业丞世专丝丟丏丟丘(下上丐丆丝丟丝丒不:  丛丄业丕且丗下一万, 丙业与丙丗丝不丈东:  val_2);
        return (东丕与不丟丈与丄丟)val_5;
        label_3:
        val_5 = 丌丆丒七丑丞东三丛.丄业丈七上丝丈丙专(下上丐丆丝丟丝丒不:  丛丄业丕且丗下一万);
        if(val_5 == null)
        {
            goto label_12;
        }
        
        return (东丕与不丟丈与丄丟)val_5;
    }
    private static void 业丞世专丝丟丏丟丘(string 下上丐丆丝丟丝丒不, 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丙业与丙丗丝不丈东)
    {
        东丕与不丟丈与丄丟 val_9;
        var val_10;
        System.Collections.Generic.Dictionary<System.String, 东丕与不丟丈与丄丟> val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = 丙业与丙丗丝不丈东;
        val_10 = null;
        val_10 = null;
        val_11 = 丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞;
        if((val_11.ContainsKey(key:  下上丐丆丝丟丝丒不)) == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        System.String[] val_2 = 丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + ((丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3);
        if(((丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + (丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3) + 32) != 0)
        {
                val_13 = null;
            val_13 = null;
            System.String[] val_3 = 丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + ((丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3);
            东丕与不丟丈与丄丟 val_4 = 丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞.Item[(丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + (丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3) + 32];
            val_4.丅丏丑东丅丈业上世 = 0;
            System.String[] val_5 = 丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + ((丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3);
            bool val_6 = 丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞.Remove(key:  (丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + (丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3) + 32);
        }
        
        val_14 = null;
        val_14 = null;
        System.String[] val_7 = 丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + ((丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3);
        (丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 + (丌丆丒七丑丞东三丛.不丛三三专丛一万丝) << 3).__unknownFiledOffset_20 = 下上丐丆丝丟丝丒不;
        val_11 = 丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞;
        val_11.Add(key:  下上丐丆丝丟丝丒不, value:  val_9);
        int val_9 = 丌丆丒七丑丞东三丛.不丛三三专丛一万丝;
        val_9 = val_9 + 1;
        丌丆丒七丑丞东三丛.不丛三三专丛一万丝 = val_9;
        val_9 = 丌丆丒七丑丞东三丛.不丛三三专丛一万丝;
        if(val_9 < 丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗.Length)
        {
                return;
        }
        
        val_9 = 1152921505171808256;
        val_15 = null;
        val_15 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                UnityEngine.AsyncOperation val_8 = UnityEngine.Resources.UnloadUnusedAssets();
            UnityEngine.Debug.Log(message:  "<color=#FF5555>Resources.UnloadUnusedAssets</color>");
        }
        
        val_16 = null;
        val_16 = null;
        丌丆丒七丑丞东三丛.不丛三三专丛一万丝 = 0;
    }
    private static 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丄业丈七上丝丈丙专(string 下上丐丆丝丟丝丒不)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞.ContainsKey(key:  下上丐丆丝丟丝丒不)) != false)
        {
                val_4 = null;
            val_4 = null;
            东丕与不丟丈与丄丟 val_2 = 丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞.Item[下上丐丆丝丟丝丒不];
            return (东丕与不丟丈与丄丟)val_5;
        }
        
        val_5 = 0;
        return (东丕与不丟丈与丄丟)val_5;
    }
    public 丌丆丒七丑丞东三丛()
    {
    
    }
    private static 丌丆丒七丑丞东三丛()
    {
        丌丆丒七丑丞东三丛.丈与丁丗上丐世丐丞 = new System.Collections.Generic.Dictionary<System.String, 东丕与不丟丈与丄丟>();
        丌丆丒七丑丞东三丛.万上丗丕专丟三丐丗 = new string[70];
    }

}
