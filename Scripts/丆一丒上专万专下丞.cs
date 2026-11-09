using UnityEngine;
public class FriendsController.丆一丒上专万专下丞
{
    // Fields
    public string 丛且丞与丕业下丏丞;
    public bool 丑业不丅丄七丞万丅;
    public bool 世丏且丂丗丕三丞上;
    public FriendsController.一且与专丏丄丆丁下 丘丑丛下丘丗丙丞七;
    public string 丟上丅丛一丅丄不丙;
    private string 一丌丞丗世专丑世与;
    private string 下丁上丟业一三丒东;
    
    // Properties
    public string 上且丗一丏丏万丅丌 { get; set; }
    internal Rilisoft.七丕丟丏三丈一丄世 下丌丑丘世与丙丈与 { get; }
    public bool 一专七且丅丒丂丟丁 { get; }
    
    // Methods
    public string 丑丌丛丈丅丅与不业()
    {
        return (string)this.下丁上丟业一三丒东;
    }
    public void 丏丑丘丐丁世丝丕丌(string 丙业与丙丗丝不丈东)
    {
        this.下丁上丟业一三丒东 = 丙业与丙丗丝不丈东;
        this.一丌丞丗世专丑世与 = 丙业与丙丗丝不丈东.Substring(startIndex:  丙业与丙丗丝不丈东.Length - ((this.下丁上丟业一三丒东.Length > 1) ? (1 + 1) : 1));
    }
    internal Rilisoft.七丕丟丏三丈一丄世 丝丅丛不丂专一丞与()
    {
        return System.Convert.ToInt32(value:  this.一丌丞丗世专丑世与);
    }
    public Rilisoft.七下上丝三丛三上一 丘丑不万专且丈丌丌()
    {
        string val_3;
        var val_4;
        val_3 = this;
        if(this.世丏且丂丗丕三丞上 == false)
        {
            goto label_1;
        }
        
        val_3 = this.一丌丞丗世专丑世与;
        int val_1 = System.Convert.ToInt32(value:  val_3);
        if(val_1 > 14)
        {
            goto label_4;
        }
        
        if(val_1 == 6)
        {
            goto label_5;
        }
        
        if(val_1 != 7)
        {
                return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
        }
        
        val_4 = 3;
        return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
        label_1:
        val_4 = 4;
        return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
        label_4:
        if(val_1 == 15)
        {
            goto label_9;
        }
        
        if(val_1 != 18)
        {
                return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
        }
        
        val_4 = 7;
        return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
        label_5:
        val_4 = 2;
        return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
        label_9:
        val_4 = 6;
        return (Rilisoft.七下上丝三丛三上一)(val_1 != 17) ? 0 : 4;
    }
    public string 丈世丆不丑丟丛丒丕()
    {
        var val_7;
        System.Collections.Generic.IDictionary<System.Int32, System.String> val_1 = GameConnect.丛丛丏专丏下三与七();
        if(this.世丏且丂丗丕三丞上 == false)
        {
                return (string)System.String.alignConst;
        }
        
        int val_2 = System.Int32.Parse(s:  this.一丌丞丗世专丑世与);
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_7 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
        if((val_1.ContainsKey(key:  ???)) == false)
        {
                return (string)System.String.alignConst;
        }
        
        int val_5 = System.Int32.Parse(s:  this.一丌丞丗世专丑世与);
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_7 = 0;
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1.Item[???]);
    }
    public string 丆丆业丂专与丙丐不()
    {
        UnityEngine.Object val_4;
        var val_5;
        val_4 = this;
        if(this.世丏且丂丗丕三丞上 == false)
        {
                return (string)System.String.alignConst;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  this.丛且丞与丕业下丏丞));
        if(val_4 == 0)
        {
                return (string)System.String.alignConst;
        }
        
        if(val_4 != null)
        {
                return val_4.上丘丙丒一丈丕丈世();
        }
        
        return val_4.上丘丙丒一丈丕丈世();
    }
    public bool 丐丟丑丐丁丁丅丕丘()
    {
        return (bool)(this.丘丑丛下丘丗丙丞七 == 5) ? 1 : 0;
    }
    public string 专不丟丗丝丌丘三丙()
    {
        if(this.丘丑丛下丘丗丙丞七 > 6)
        {
                return (string)System.String.alignConst;
        }
        
        var val_5 = 106017360 + (this.丘丑丛下丘丗丙丞七) << 2;
        val_5 = val_5 + 106017360;
        goto (106017360 + (this.丘丑丛下丘丗丙丞七) << 2 + 106017360);
    }
    public string 丝且丏七丐万丅丗东()
    {
        if(this.丘丑丛下丘丗丙丞七 > 6)
        {
                return (string)System.String.alignConst;
        }
        
        var val_5 = 106017388 + (this.丘丑丛下丘丗丙丞七) << 2;
        val_5 = val_5 + 106017388;
        goto (106017388 + (this.丘丑丛下丘丗丙丞七) << 2 + 106017388);
    }
    public FriendsController.丆一丒上专万专下丞()
    {
    
    }

}
