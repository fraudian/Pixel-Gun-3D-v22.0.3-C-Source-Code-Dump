using UnityEngine;
internal sealed class 业丟丘一丑丗世丏丁
{
    // Fields
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<int, string>> 丛丈且丁丄不丙丈丂;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 万不丗丛丘业丟丝丐;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 下三丕丝丕上丙东下;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 丝丘丗一丐东世丁世;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> 丛丈丘丂丏丙七丝丝;
    private System.Nullable<bool> 丂与专丈东一业丈丙;
    private System.Nullable<bool> 丒下上丙专三丘东丁;
    private static 业丟丘一丑丗世丏丁 丝业丆丁业三丈丟东;
    
    // Properties
    internal static 业丟丘一丑丗世丏丁 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static 业丟丘一丑丗世丏丁 丑七不且上丗丁一世()
    {
        业丟丘一丑丗世丏丁 val_2;
        业丟丘一丑丗世丏丁 val_3 = 业丟丘一丑丗世丏丁.丝业丆丁业三丈丟东;
        if(val_3 != null)
        {
                return val_3;
        }
        
        业丟丘一丑丗世丏丁 val_1 = null;
        val_2 = val_1;
        val_1 = new 业丟丘一丑丗世丏丁();
        业丟丘一丑丗世丏丁.丝业丆丁业三丈丟东 = val_2;
        val_3 = 业丟丘一丑丗世丏丁.丝业丆丁业三丈丟东;
        return val_3;
    }
    internal void 丄七丐丛业丈丐丌万()
    {
        this.丒下上丙专三丘东丁 = 0;
        bool val_2 = 丆丟七丌丞东丆丕丌.丗丏业丁丞专丌丅丘();
        this.丂与专丈东一业丈丙 = 0;
        if(((-1779434728) & 1) == 0)
        {
                return;
        }
        
        this.万不丗丛丘业丟丝丐.Clear();
        this.下三丕丝丕上丙东下.Clear();
        this = this.丝丘丗一丐东世丁世.Item["r"];
        this.set_Item(key:  "e", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  WeaponManager.上丙上万七丆丐丆业())));
        this.set_Item(key:  "ec", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  WeaponManager.丗丈丁世且世丂丈丝)));
        this.set_Item(key:  "c", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  WeaponManager.丆丘下丛不丒丛丌丄)));
    }
    internal void 七一丕丆丐万丏下丌(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业, bool 丐专丙丝丕丅丄丌丅)
    {
        System.Nullable<System.Boolean> val_48;
        var val_49;
        var val_50;
        if(丆丐七世世且丏丐业 == null)
        {
                return;
        }
        
        val_48 = this.丂与专丈东一业丈丙;
        if((val_48 & 1) == 0)
        {
                return;
        }
        
        if((val_48 & 1) == 0)
        {
                return;
        }
        
        if((业丟丘一丑丗世丏丁.世丛世丁丏业三业丞(丟丈一下东业一丝丆:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false)
        {
                return;
        }
        
        val_49 = null;
        val_49 = null;
        bool val_18 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛());
        if(val_18 != false)
        {
                val_50 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丝丈专丝丂丄万丟与(下丅丙一丂丗丅丝七:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), 丙上丟丕丒丆丝丟一:  0, 丘丄一丘丁丞丘丆且:  false);
        }
        else
        {
                val_50 = 0;
        }
        
        string val_33 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_35 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        null.Add(key:  "c", value:  WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "e", value:  WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "s", value:  WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "t", value:  WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "d", value:  WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "h", value:  ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  丆丐七世世且丏丐业.业东丅东丌上丗丑不())) != 0) ? 1 : 0);
        null.Add(key:  "g", value:  val_18);
        null.Add(key:  "r", value:  WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌()));
        null.Add(key:  "ca", value:  WeaponManager.丐上业丐丏丐万世丑().Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "es", value:  与丑丛万不东专丅丙.丕三丌万丞世丟七丑(丞一丁业丄一一业且:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), 世七七丟丑丁丂与丞:  40));
        null.Add(key:  "cc", value:  WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "al", value:  0);
        val_48 = "a";
        null.Add(key:  val_48, value:  丐专丙丝丕丅丄丌丅);
        this.万不丗丛丘业丟丝丐.set_Item(key:  System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8), value:  null);
    }
    internal void 万东丙丘丂丐上与上()
    {
        bool val_2 = 丆丟七丌丞东丆丕丌.丗丏业丁丞专丌丅丘();
        this.丒下上丙专三丘东丁 = 0;
        if(((-1778930854) & 1) == 0)
        {
                return;
        }
        
        this = this.丝丘丗一丐东世丁世.Item["g"];
        this.set_Item(key:  "e", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  WeaponManager.上丙上万七丆丐丆业())));
        this.set_Item(key:  "ec", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  WeaponManager.丗丈丁世且世丂丈丝)));
        this.set_Item(key:  "c", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  WeaponManager.丆丘下丛不丒丛丌丄)));
    }
    internal void 丝专丂丆东丏丗专世(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丐专丙丝丕丅丄丌丅)
    {
        丙且上东下丏丏丟下 val_7 = 下丅丙一丂丗丅丝七;
        if(val_7 == null)
        {
                return;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_7.丒万丕七专不丏丞丌())) == false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7.业上丙丞丐丄丆丅七())) == true)
        {
                return;
        }
        
        val_7 = val_7.业上丙丞丐丄丆丅七();
        三丅丁丗丗丝丂万且 val_6 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_7);
        if(val_6 == null)
        {
                return;
        }
        
        丐专丙丝丕丅丄丌丅 = 丐专丙丝丕丅丄丌丅;
        this.丝专丂丆东丏丗专世(丆丐七世世且丏丐业:  val_6, 丐专丙丝丕丅丄丌丅:  丐专丙丝丕丅丄丌丅);
    }
    internal void 丝专丂丆东丏丗专世(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业, bool 丐专丙丝丕丅丄丌丅)
    {
        System.Nullable<System.Boolean> val_48;
        var val_49;
        var val_50;
        if(丆丐七世世且丏丐业 == null)
        {
                return;
        }
        
        val_48 = this.丒下上丙专三丘东丁;
        if((val_48 & 1) == 0)
        {
                return;
        }
        
        if((val_48 & 1) == 0)
        {
                return;
        }
        
        if((业丟丘一丑丗世丏丁.世丛世丁丏业三业丞(丟丈一下东业一丝丆:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false)
        {
                return;
        }
        
        val_49 = null;
        val_49 = null;
        bool val_18 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛());
        if(val_18 != false)
        {
                val_50 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丝丈专丝丂丄万丟与(下丅丙一丂丗丅丝七:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), 丙上丟丕丒丆丝丟一:  0, 丘丄一丘丁丞丘丆且:  false);
        }
        else
        {
                val_50 = 0;
        }
        
        string val_33 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_35 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        null.Add(key:  "c", value:  WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "e", value:  WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "s", value:  WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "t", value:  WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "d", value:  WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "h", value:  ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  丆丐七世世且丏丐业.业东丅东丌上丗丑不())) != 0) ? 1 : 0);
        null.Add(key:  "g", value:  val_18);
        null.Add(key:  "r", value:  WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌()));
        null.Add(key:  "ca", value:  WeaponManager.丐上业丐丏丐万世丑().Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "es", value:  与丑丛万不东专丅丙.丕三丌万丞世丟七丑(丞一丁业丄一一业且:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), 世七七丟丑丁丂与丞:  40));
        null.Add(key:  "cc", value:  WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛()));
        null.Add(key:  "al", value:  0);
        val_48 = "a";
        null.Add(key:  val_48, value:  丐专丙丝丕丅丄丌丅);
        this.下三丕丝丕上丙东下.set_Item(key:  System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8), value:  null);
    }
    internal void 丈丛万丘丏丏丞不丈(CategoryNames 七丆丒与丗丌丄且丂, 丅丞丄且丑丗丈丘丒 丛丌丙世专世东丕下)
    {
        System.Collections.Generic.List<System.Int32> val_1 = 0;
        if((this.丒下上丙专三丘东丁 & 1) == 0)
        {
                return;
        }
        
        if((this.丒下上丙专三丘东丁 & 1) == 0)
        {
                return;
        }
        
        this = this.丛丈丘丂丏丙七丝丝;
        bool val_2 = this.TryGetValue(key:  七丆丒与丗丌丄且丂, value: out  val_1);
        if(val_1 == 0)
        {
                return;
        }
        
        if((val_1.Contains(item:  丛丌丙世专世东丕下)) == true)
        {
                return;
        }
        
        val_1.Add(item:  丛丌丙世专世东丕下);
    }
    internal void 下万丐东东与丄三三(CategoryNames 七丆丒与丗丌丄且丂)
    {
        System.Collections.Generic.List<System.Int32> val_1 = 0;
        bool val_2 = this.丛丈丘丂丏丙七丝丝.TryGetValue(key:  七丆丒与丗丌丄且丂, value: out  val_1);
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.Clear();
    }
    internal void 与丟七丁丂一万与且(object 上世丏丁世丟世丆业, PGCompany.GameplayLoop.GameplayLoopType 东且丒丌且丈丞丗与, BalanceController.丙丁万丟三丒下丂丛 丑东与丅丐丅丂丞业)
    {
        object val_7;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.String>> val_8;
        val_7 = 上世丏丁世丟世丆业;
        val_8 = this;
        System.Collections.Generic.Dictionary<System.Int32, System.String> val_4 = 0;
        if(丆丟七丌丞东丆丕丌.丗丏业丁丞专丌丅丘() == false)
        {
                return;
        }
        
        if(val_7 == null)
        {
                System.Collections.Generic.List<System.Object> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Collections.Generic.List<System.Object>();
            val_2.Add(item:  "conf_null");
        }
        
        bool val_5 = this.丛丈且丁丄不丙丈丂.TryGetValue(key:  东且丒丌且丈丞丗与, value: out  val_4);
        if(val_4 == 0)
        {
                System.Collections.Generic.Dictionary<System.Int32, System.String> val_6 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            val_8 = this.丛丈且丁丄不丙丈丂;
            val_8.set_Item(key:  东且丒丌且丈丞丗与, value:  null);
        }
        
        0.set_Item(key:  丑东与丅丐丅丂丞业, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_2));
    }
    internal static bool 世丛世丁丏业三业丞(string 丟丈一下东业一丝丆)
    {
        string val_9;
        var val_10;
        val_9 = 丟丈一下东业一丝丆;
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != true) && (val_9.Length > 6))
        {
                val_9 = val_9.Substring(startIndex:  6);
            if((System.Int32.TryParse(s:  val_9, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) != false)
        {
                return (bool)val_10;
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    public 业丟丘一丑丗世丏丁()
    {
        this.丛丈且丁丄不丙丈丂 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.String>>();
        this.万不丗丛丘业丟丝丐 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
        this.下三丕丝丕上丙东下 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
        val_4.Add(key:  "r", value:  new System.Collections.Generic.Dictionary<System.String, System.String>());
        val_4.Add(key:  "g", value:  new System.Collections.Generic.Dictionary<System.String, System.String>());
        this.丝丘丗一丐东世丁世 = val_4;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Int32>> val_7 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Int32>>();
        val_7.Add(key:  0, value:  new System.Collections.Generic.List<System.Int32>());
        val_7.Add(key:  1, value:  new System.Collections.Generic.List<System.Int32>());
        val_7.Add(key:  2, value:  new System.Collections.Generic.List<System.Int32>());
        val_7.Add(key:  3, value:  new System.Collections.Generic.List<System.Int32>());
        val_7.Add(key:  4, value:  new System.Collections.Generic.List<System.Int32>());
        System.Collections.Generic.List<System.Int32> val_13 = new System.Collections.Generic.List<System.Int32>();
        val_7.Add(key:  5, value:  val_13);
        this.丛丈丘丂丏丙七丝丝 = val_7;
        val_13 = new System.Object();
    }

}
