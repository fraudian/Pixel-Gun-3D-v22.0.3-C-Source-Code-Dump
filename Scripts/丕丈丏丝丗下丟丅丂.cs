using UnityEngine;
internal class 丕丈丏丝丗下丟丅丂
{
    // Fields
    private System.Collections.Generic.List<FilterMaps> 丈丂业丕丘丄世且东;
    private System.Collections.Generic.List<FilterMaps> 丞丆丘丄丅丈丌丒业;
    private string 丏丟丛世丄七丌业三;
    private float 丄且丈丗七七下一丏;
    private float 与丁丐丈万丏丘丂下;
    private bool 且丘丈丁丗万万不丙;
    private int 丑专丐丛丛丌丞东专;
    private Rilisoft.丝丑丂丛万丐丈丘且 丑丁丄丟丟丁且东七;
    private float 不丄丕且丄丕丝丛丆;
    internal int 丄丑丏与丌丌丕丄丛;
    internal int 且丗丟丟专一丈丙丝;
    internal int 上丙丘丝丅丁丗丐万;
    private System.Collections.Generic.List<一丁丒与丁丂丈七丆> <七丗丟丄丅且丐丟东>k__BackingField;
    private System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> <一专丒七丏业丁丌丝>k__BackingField;
    private GadgetCategory <丄上丞不三与一丅丒>k__BackingField;
    private string <上七东下丏不丕丐丑>k__BackingField;
    private string <丝七丝且东丏丙丌丗>k__BackingField;
    private string <丆三丒世丐万丛万丟>k__BackingField;
    private 丅世一丈七丆业丝丘 <丕丌专一且丐丄东丙>k__BackingField;
    private bool <业丟万业丁丘丁万专>k__BackingField;
    
    // Properties
    internal ItemRarity 且丐丟专丛丗丏上丙 { get; }
    internal System.Collections.Generic.List<FilterMaps> 丄与不丆一丒下丞七 { get; }
    internal System.Collections.Generic.List<一丁丒与丁丂丈七丆> 丄丗丒专丆与丈上丁 { get; set; }
    internal System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 丈不三丛七丑丈丑丆 { get; set; }
    internal GadgetCategory 七丌丌丏丗东丕且丅 { get; set; }
    internal string 下丄丈不与世丐业专 { get; set; }
    internal string 丑丗丁丞丒丂与丙丈 { get; set; }
    internal string 不且七丞丂丌丒丙专 { get; set; }
    internal string 一丌丐业丂不丗不丁 { get; set; }
    internal 丅世一丈七丆业丝丘 丄丙一与丐一丈丛丙 { get; set; }
    internal bool 万与丟业丑三丅三丟 { get; set; }
    internal int 丐丒且丝丛丁丕丟丅 { get; }
    internal float 不丕万丟丘专丟丄上 { get; }
    internal float 丕丟三丂三丁丄且专 { get; }
    internal float 丐丟一丙丁业世丒一 { get; }
    internal float 三一业丟丅丅丙丒三 { get; }
    internal float 专万丞丗丒丞丟上上 { get; }
    internal float 与丝万丒丐专丅丗专 { get; }
    internal float 丑业丏丙丒与丘七下 { get; }
    internal float 丏丌丏丅丄丁丛丅丕 { get; }
    internal float 七丙丕丁丌丘丌丛丐 { get; }
    internal float 与丁丘丁丄丆丒上丆 { get; }
    internal float 下丕丏丕丅专东丌丛 { get; }
    internal float 丄丂丌丞丁丄丒与三 { get; }
    internal float 七丄且丞三丂上东上 { get; }
    internal float 不丁丝丂不丐丄三专 { get; }
    internal float 丛七世丙丙与不丄丗 { get; }
    internal float 且丑世专丐丑不下丏 { get; }
    private float 丅丈且上三专丗上丆 { get; }
    internal int 一上业丏且丐丝不三 { get; }
    internal int 丄不丟万丛丒东丝三 { get; }
    internal string 业专丝丗丈与丂世丅 { get; }
    internal float 丝丐丐三丒一专世不 { get; }
    internal float 且专专专万不丒一丆 { get; }
    internal float 丛丟丂万丐东丆七丗 { get; }
    internal bool 且丞丅丒丏丌丐丐丝 { get; }
    internal int 不丐不世且丏丁东丒 { get; }
    internal float 丗业七丌专丙丗丗丆 { get; }
    
    // Methods
    internal ItemRarity 七东与丄丕丁丛世三()
    {
        return BalanceController.丘丛丄业丒一丝丆东(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
    }
    internal System.Collections.Generic.List<FilterMaps> 一丝丈丂世丒丟东丕()
    {
        if(this.丞丆丘丄丅丈丌丒业 == null)
        {
                return (System.Collections.Generic.List<FilterMaps>)this.丈丂业丕丘丄世且东;
        }
        
        return (System.Collections.Generic.List<FilterMaps>)this.丞丆丘丄丅丈丌丒业;
    }
    internal bool 上东丌丂丟不下丒业(FilterMaps 专丆丌丛东一不丑丙)
    {
        if(专丆丌丛东一不丑丙 < 100)
        {
                return true;
        }
        
        if(this.丞丆丘丄丅丈丌丒业 != null)
        {
                return this.丈丂业丕丘丄世且东.Contains(item:  专丆丌丛东一不丑丙);
        }
        
        if(this.丈丂业丕丘丄世且东 == null)
        {
                return true;
        }
        
        return this.丈丂业丕丘丄世且东.Contains(item:  专丆丌丛东一不丑丙);
    }
    internal void 且丄丂丝丈丆丄丏上(System.Collections.Generic.List<FilterMaps> 丑七丟丒丌丌万与丐)
    {
        this.丞丆丘丄丅丈丌丒业 = 丑七丟丒丌丌万与丐;
    }
    internal 丕丈丏丝丗下丟丅丂(GadgetCategory 丙丑丕丂下丏一丁专, string 丞丅上丏丂且下丅与, string 业东丘与与业丏丛丈, int 丗丈一丟丈万丅丞东, string 丙丆与丁七三丛丂世, string 丘专三丛丅与丆不万, string 丆丕下丄万丞丁世丛, int 丞世不丒下上上丝丑, int 丞丌东丟且丒丐丑丂, float 不丄丕且丄丕丝丛丆, System.Collections.Generic.List<一丁丒与丁丂丈七丆> 丗丟上上丒丐丗丞丙, System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 丌丞丌丌丈丁丏丅丟, 丅世一丈七丆业丝丘 业万丅丆上丈一世丄, string 丏丟丛世丄七丌业三, float 与丁丐丈万丏丘丂下, int 丑专丐丛丛丌丞东专, bool 且丘丈丁丗万万不丙, float 丄且丈丗七七下一丏, bool 丆丑上丁丄业丞不丗 = False, int 丄丑丏与丌丌丕丄丛 = 5, int 且丗丟丟专一丈丙丝 = 5, int 上丙丘丝丅丁丗丐万 = 65)
    {
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_1 = 丗丟上上丒丐丗丞丙;
        val_1 = new System.Object();
        this.丑专丐丛丛丌丞东专 = 丑专丐丛丛丌丞东专;
        this.丄且丈丗七七下一丏 = 丄且丈丗七七下一丏;
        this.与丁丐丈万丏丘丂下 = 与丁丐丈万丏丘丂下;
        this.且丘丈丁丗万万不丙 = 且丘丈丁丗万万不丙;
        this.丏丟丛世丄七丌业三 = 丏丟丛世丄七丌业三;
        Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
        this.丑丁丄丟丟丁且东七 = val_3;
        mem[1152921537403187424] = val_3.上万三丆专丏丒丗业;
        this.不丄丕且丄丕丝丛丆 = 不丄丕且丄丕丝丛丆;
        this.丄丑丏与丌丌丕丄丛 = 丄丑丏与丌丌丕丄丛;
        this.且丗丟丟专一丈丙丝 = 且丗丟丟专一丈丙丝;
        this.上丙丘丝丅丁丗丐万 = 上丙丘丝丅丁丗丐万;
        this.<丄上丞不三与一丅丒>k__BackingField = 丙丑丕丂下丏一丁专;
        this.<上七东下丏不丕丐丑>k__BackingField = 丞丅上丏丂且下丅与;
        this.<丝七丝且东丏丙丌丗>k__BackingField = 业东丘与与业丏丛丈;
        this.<丆三丒世丐万丛万丟>k__BackingField = 丆丕下丄万丞丁世丛;
        this.<七丗丟丄丅且丐丟东>k__BackingField = val_1;
        this.<业丟万业丁丘丁万专>k__BackingField = 丆丑上丁丄业丞不丗;
        this.<一专丒七丏业丁丌丝>k__BackingField = 丌丞丌丌丈丁丏丅丟;
        this.<丕丌专一且丐丄东丙>k__BackingField = 业万丅丆上丈一世丄;
    }
    internal System.Collections.Generic.List<一丁丒与丁丂丈七丆> 丘一一丆业丂丘丒世()
    {
        return (System.Collections.Generic.List<一丁丒与丁丂丈七丆>)this.<七丗丟丄丅且丐丟东>k__BackingField;
    }
    internal void 万专三专业丌丈丌且(System.Collections.Generic.List<一丁丒与丁丂丈七丆> 丙业与丙丗丝不丈东)
    {
        this.<七丗丟丄丅且丐丟东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 丑丐丗世业丙丗丘不()
    {
        return (System.Collections.Generic.List<丈不三丛七丑丈丑丆>)this.<一专丒七丏业丁丌丝>k__BackingField;
    }
    internal void 丄丕丕业万丄丏业丛(System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 丙业与丙丗丝不丈东)
    {
        this.<一专丒七丏业丁丌丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal GadgetCategory 丒万丕七专不丏丞丌()
    {
        return (GadgetCategory)this.<丄上丞不三与一丅丒>k__BackingField;
    }
    internal void 与丘丑丒丅丕丞七丈(GadgetCategory 丙业与丙丗丝不丈东)
    {
        this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 业上丙丞丐丄丆丅七()
    {
        return (string)this.<上七东下丏不丕丐丑>k__BackingField;
    }
    internal void 丒丞东丈丁丄丑丅且(string 丙业与丙丗丝不丈东)
    {
        this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丛丈丅丞丏丅丛丛丐()
    {
        return (string)this.<丝七丝且东丏丙丌丗>k__BackingField;
    }
    internal void 上专七丅业丘丑一丗(string 丙业与丙丗丝不丈东)
    {
        this.<丝七丝且东丏丙丌丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丒万丁丌一丙专丐丞()
    {
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.<丝七丝且东丏丙丌丗>k__BackingField);
    }
    internal void 丏七丌万丆万丈与丝(string 丙业与丙丗丝不丈东)
    {
    
    }
    internal string 丄东且丘丄丑下丑东()
    {
        return (string)this.<丆三丒世丐万丛万丟>k__BackingField;
    }
    internal void 丙丘丐下七丟业专东(string 丙业与丙丗丝不丈东)
    {
        this.<丆三丒世丐万丛万丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丅世一丈七丆业丝丘 丁上三丒丄丞丑丙与()
    {
        return (丅世一丈七丆业丝丘)this.<丕丌专一且丐丄东丙>k__BackingField;
    }
    internal void 世世丌丅丑与七丘上(丅世一丈七丆业丝丘 丙业与丙丗丝不丈东)
    {
        this.<丕丌专一且丐丄东丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丙丅专丒丈丐丂与丝()
    {
        return (bool)this.<业丟万业丁丘丁万专>k__BackingField;
    }
    private void 万丄丟丌丞上丐万不(bool 丙业与丙丗丝不丈东)
    {
        this.<业丟万业丁丘丁万专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 业东丅东丌上丗丑不()
    {
    
    }
    internal float 丅上丟丙丏丗丕丟专()
    {
        return BalanceController.万一丈丞丟上丅丙世(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丗且东七世丌丑丏不()
    {
        return BalanceController.丄专万上三世丘不不(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丐丐万丆不丆丏丑三()
    {
        return BalanceController.世丘东丛业丙丝丑丆(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 与丄丛丂一三丆丄且()
    {
        return (float)this.不丄丕且丄丕丝丛丆;
    }
    internal float 丗丁丅丙东丗七业丐()
    {
        return BalanceController.七丂丌丈上丅丙世丞(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丂丂七万丒丈丈不三()
    {
        return BalanceController.且丆三丐丛丙七七丂(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丛丞丒丒丆丛且丗不()
    {
        return BalanceController.丛丞世丝丞专下丌丂(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丑丈东丄丏三上丕丟()
    {
        return BalanceController.丙丕丝三下丒且丅万(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丐下三下丆丛万丑丟()
    {
        return BalanceController.专丕一与业丏专不专(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丒丞丌丒业丐丏丑丟()
    {
        return BalanceController.丕世丛专万丄丘下丞(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丂丂丝下丞丐丝专世()
    {
        return BalanceController.丆丆丈丕丐丂丂且丑(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丂丆丈丘上七丁世与()
    {
        return BalanceController.丆万一丅专丁丂丑丁(万专上丞业下丙丗丁:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 丁丒丝丈丈丒丞丘下(PhotonView 丅丏三七丁丑丞丄丏)
    {
        return this.丈丆丝丑丙丈丒丑丏();
    }
    internal float 丈丆丝丑丙丈丒丑丏()
    {
        int val_8;
        int val_9;
        if((this.<丄上丞不三与一丅丒>k__BackingField) == 13500)
        {
                return this.丑丈东丄丏三上丕丟();
        }
        
        val_8 = BalanceController.丈丅三丙东丕东下丐(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
        val_9 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
        if(val_9 <= 0)
        {
                val_9 = BalanceController.世丅丄丗丄丌三世且(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_9 = this.上丙丘丝丅丁丗丐万;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return BalanceController.丄丌不业上丌上丅业(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField, 丂丄丆丁丘丝丞丐不:  val_9, 丙丂丏丛丌丏下丝不:  val_8 = ExperienceController.丞丞丘业东丙丏七丌());
        }
        
        return BalanceController.丄丌不业上丌上丅业(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField, 丂丄丆丁丘丝丞丐不:  val_9, 丙丂丏丛丌丏下丝不:  val_8);
    }
    internal float 且丕丑丗上下万丑七()
    {
        return 1f;
    }
    internal float 丌丛丟丙丘丝丂一不()
    {
        int val_5;
        if((this.<丄上丞不三与一丅丒>k__BackingField) == 13500)
        {
                return this.丗丁丅丙东丗七业丐();
        }
        
        val_5 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
        if(val_5 <= 0)
        {
                val_5 = this.专丂丏世且丗丏丌丝();
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return BalanceController.业不一丒下丑丄万丏(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField, 丂丄丆丁丘丝丞丐不:  val_5 = this.上丙丘丝丅丁丗丐万);
        }
        
        return BalanceController.业不一丒下丑丄万丏(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField, 丂丄丆丁丘丝丞丐不:  val_5);
    }
    internal float 丙丈丗丌丘三丄业且()
    {
        var val_8;
        var val_9;
        int val_10;
        if((this.<丄上丞不三与一丅丒>k__BackingField) == 13500)
        {
                return this.丂丂七万丒丈丈不三();
        }
        
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_9 = null;
            val_9 = null;
            if(丄丝丝下丟丘丄丒丈() != false)
        {
                return this.丞不丙丗丙七丅万丟();
        }
        
        }
        
        val_10 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
        if(val_10 <= 0)
        {
                val_10 = this.专丂丏世且丗丏丌丝();
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
                return BalanceController.丕与丝丗与三下丟丌(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField, 丂丄丆丁丘丝丞丐不:  val_10 = this.上丙丘丝丅丁丗丐万);
        }
        
        }
        
        return BalanceController.丕与丝丗与三下丟丌(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField, 丂丄丆丁丘丝丞丐不:  val_10);
    }
    private float 丞不丙丗丙七丅万丟()
    {
        return BalanceController.丝丑丌不业七且业丞(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal int 专丂丏世且丗丏丌丝()
    {
        var val_7;
        PGCompany.丟丁且丝丁三丏丙且 val_3 = 0;
        bool val_4 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().TryGetValue(下上丐丆丝丟丝丒不:  this.丑丁丄丟丟丁且东七, 丙业与丙丗丝不丈东: out  val_3);
        if(val_3 != 0)
        {
                val_7 = 0;
            int val_5 = ExperienceController.丞丞丘业东丙丏七丌();
            return (int)this.丈丒丟下丂丒东与丑();
        }
        
        val_7 = this;
        return (int)this.丈丒丟下丂丒东与丑();
    }
    internal int 丈丒丟下丂丒东与丑()
    {
        return BalanceController.世丅丄丗丄丌三世且(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
    }
    internal string 丆丑专丑上万丟丗东()
    {
        return (string)this.丏丟丛世丄七丌业三;
    }
    internal float 丏丕丄东世丕三丆丘()
    {
        return BalanceController.丄专业丑且丘丑丑丛(丗丑丐丕丟丝且下丕:  this.<上七东下丏不丕丐丑>k__BackingField);
    }
    internal float 东丏丒丘丐丅丐万专()
    {
        return 0f;
    }
    internal float 丙丝丑丏丁丂上业丞()
    {
        return (float)this.与丁丐丈万丏丘丂下;
    }
    internal bool 丆东丘丆东东与丌丕()
    {
        return (bool)this.且丘丈丁丗万万不丙;
    }
    internal int 丝丙专丐三丕丌且与()
    {
        return (int)this.丑专丐丛丛丌丞东专;
    }
    internal float 丞与三丌专东丅丑专()
    {
        return (float)this.丄且丈丗七七下一丏;
    }

}
