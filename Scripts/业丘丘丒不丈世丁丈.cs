using UnityEngine;
public class 丁一业专丈三丄丘专.业丘丘丒不丈世丁丈
{
    // Fields
    public 丑丄一丐丁丕世下丕 丁丛丅丌一丌丝丌东;
    public System.Collections.Generic.Dictionary<int, 丑丄一丐丁丕世下丕> 东丌七丑丌业东丑丌;
    
    // Methods
    public 丁一业专丈三丄丘专.业丘丘丒不丈世丁丈()
    {
        this.东丌七丑丌业东丑丌 = new System.Collections.Generic.Dictionary<System.Int32, 丑丄一丐丁丕世下丕>();
    }
    public 丑丄一丐丁丕世下丕 丏且三且丈世丂丏上(int 与丐上丈与丑一丌丏, bool 东下丂三丙不下丗下 = True)
    {
        System.Collections.Generic.Dictionary<System.Int32, 丑丄一丐丁丕世下丕> val_5;
        丑丄一丐丁丕世下丕 val_6;
        var val_7;
        val_5 = 东下丂三丙不下丗下;
        if((this.东丌七丑丌业东丑丌.ContainsKey(key:  与丐上丈与丑一丌丏)) == true)
        {
            goto label_2;
        }
        
        if(val_5 == false)
        {
            goto label_3;
        }
        
        val_5 = this.东丌七丑丌业东丑丌;
        val_6 = this.丁丛丅丌一丌丝丌东;
        if(this.丁丛丅丌一丌丝丌东 != null)
        {
            goto label_4;
        }
        
        val_6 = this.丁丛丅丌一丌丝丌东;
        if(val_6 == null)
        {
            goto label_5;
        }
        
        label_4:
        val_5.Add(key:  与丐上丈与丑一丌丏, value:  new 丑丄一丐丁丕世下丕(丂丛丑东不丅丈一东:  this.丁丛丅丌一丌丝丌东.丂丛丑东不丅丈一东, 与丐上丈与丑一丌丏:  与丐上丈与丑一丌丏, 丆丐万丑上丄上丂三:  new System.Collections.Generic.List<System.Int32>(collection:  this.丁丛丅丌一丌丝丌东.丆丐万丑上丄上丂三)));
        label_2:
        丑丄一丐丁丕世下丕 val_4 = this.东丌七丑丌业东丑丌.Item[与丐上丈与丑一丌丏];
        return (丑丄一丐丁丕世下丕)val_7;
        label_3:
        val_7 = 0;
        return (丑丄一丐丁丕世下丕)val_7;
        label_5:
    }

}
