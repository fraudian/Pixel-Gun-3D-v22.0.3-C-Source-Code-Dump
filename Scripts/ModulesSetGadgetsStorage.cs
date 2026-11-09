using UnityEngine;
internal class ModulesSetGadgetsStorage : ScriptableObject
{
    // Fields
    private static Rilisoft.七丞丞丅东丞专丙丝<ModulesSetGadgetsStorage> _instance;
    private static bool _initialized;
    public UnityEngine.AudioClip defaultSoundOnUseGadget;
    private System.Collections.Generic.List<ModulesSetGadgetsStorage.ModuleGadgetRecord> _listRecords;
    private System.Collections.Generic.List<ModulesSetGadgetsStorage.PropertyLocalization> propertiesLocalizations;
    public string testGadgetID;
    public string testGadgetUp;
    public bool testMode;
    private System.Collections.Generic.Dictionary<string, ModulesSetGadgetsStorage.ModuleGadgetRecord> _moduleGadgets;
    private System.Collections.Generic.Dictionary<ModulesSetGadgetsStorage.GadgetProperty, ModulesSetGadgetsStorage.PropertyLocalization> _propertiesDependencies;
    
    // Properties
    internal static ModulesSetGadgetsStorage Instance { get; }
    internal System.Collections.Generic.Dictionary<string, ModulesSetGadgetsStorage.ModuleGadgetRecord> ModuleGadgets { get; }
    internal System.Collections.Generic.Dictionary<ModulesSetGadgetsStorage.GadgetProperty, ModulesSetGadgetsStorage.PropertyLocalization> PropertiesDependencies { get; }
    
    // Methods
    internal static ModulesSetGadgetsStorage get_Instance()
    {
        null = null;
        if(ModulesSetGadgetsStorage._instance != null)
        {
                return ModulesSetGadgetsStorage._instance.世三丞丅丑丌丈丈一();
        }
        
        return ModulesSetGadgetsStorage._instance.世三丞丅丑丌丈丈一();
    }
    internal System.Collections.Generic.Dictionary<string, ModulesSetGadgetsStorage.ModuleGadgetRecord> get_ModuleGadgets()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if(ModulesSetGadgetsStorage._initialized == true)
        {
                return (System.Collections.Generic.Dictionary<System.String, ModuleGadgetRecord>)this._moduleGadgets;
        }
        
        this.丈丂丝丘与世丌丐业();
        val_2 = null;
        val_2 = null;
        ModulesSetGadgetsStorage._initialized = true;
        return (System.Collections.Generic.Dictionary<System.String, ModuleGadgetRecord>)this._moduleGadgets;
    }
    internal System.Collections.Generic.Dictionary<ModulesSetGadgetsStorage.GadgetProperty, ModulesSetGadgetsStorage.PropertyLocalization> get_PropertiesDependencies()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if(ModulesSetGadgetsStorage._initialized == true)
        {
                return (System.Collections.Generic.Dictionary<GadgetProperty, PropertyLocalization>)this._propertiesDependencies;
        }
        
        this.丈丂丝丘与世丌丐业();
        val_2 = null;
        val_2 = null;
        ModulesSetGadgetsStorage._initialized = true;
        return (System.Collections.Generic.Dictionary<GadgetProperty, PropertyLocalization>)this._propertiesDependencies;
    }
    private void 丈丂丝丘与世丌丐业()
    {
        ModulesSetGadgetsStorage.GadgetProperty val_3;
        string val_9;
        GadgetProperty val_10;
        var val_11 = this;
        this._moduleGadgets.Clear();
        List.Enumerator<T> val_1 = this._listRecords.GetEnumerator();
        label_6:
        if(((-601822176) & 1) == 0)
        {
            goto label_3;
        }
        
        this._moduleGadgets.Add(key:  val_4.m_stringLength, value:  val_3.丐丏七丌丕丗业且上());
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this._propertiesDependencies.Clear();
        List.Enumerator<T> val_5 = this.propertiesLocalizations.GetEnumerator();
        label_16:
        if(((-601822224) & 1) == 0)
        {
            goto label_14;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_7 = val_3.RemoteEndpoint;
        val_3 = val_10;
        this._propertiesDependencies.Add(key:  val_10, value:  new PropertyLocalization() {property = val_3, localizationKey = val_9, iconName = val_9});
        goto label_16;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal ModulesSetGadgetsStorage.ModuleGadgetRecord 丄丝丒与丆丛丙专丅(string 丗丄万丄丌丕丈丈三)
    {
        var val_6;
        if((this.ModuleGadgets.ContainsKey(key:  丗丄万丄丌丕丈丈三)) != false)
        {
                val_6 = this.ModuleGadgets.Item[丗丄万丄丌丕丈丈三];
            return (ModuleGadgetRecord)val_6;
        }
        
        ModulesSetGadgetsStorage.ModuleGadgetRecord val_5 = null;
        val_6 = val_5;
        val_5 = new ModulesSetGadgetsStorage.ModuleGadgetRecord();
        return (ModuleGadgetRecord)val_6;
    }
    internal string 丝七丕丂丅丈丁三丑(ModulesSetGadgetsStorage.GadgetProperty 丄丒丗丟世丘万丙丟)
    {
        var val_5;
        var val_6;
        if((this.PropertiesDependencies.ContainsKey(key:  丄丒丗丟世丘万丙丟)) != false)
        {
                PropertyLocalization val_4 = this.PropertiesDependencies.Item[丄丒丗丟世丘万丙丟];
            val_6 = val_5;
            return (string)val_6;
        }
        
        val_6 = "";
        return (string)val_6;
    }
    internal string 上丘丞丏丗且丑丟丛(ModulesSetGadgetsStorage.GadgetProperty 丄丒丗丟世丘万丙丟)
    {
        var val_5;
        var val_6;
        if((this.PropertiesDependencies.ContainsKey(key:  丄丒丗丟世丘万丙丟)) != false)
        {
                PropertyLocalization val_4 = this.PropertiesDependencies.Item[丄丒丗丟世丘万丙丟];
            val_6 = val_5;
            return (string)val_6;
        }
        
        val_6 = "";
        return (string)val_6;
    }
    internal float 丅业专丏不丒丄丐一(string 丗丄万丄丌丕丈丈三, ModulesSetGadgetsStorage.GadgetProperty 丄丒丗丟世丘万丙丟)
    {
        if(丄丒丗丟世丘万丙丟 > 8)
        {
                return 0f;
        }
        
        var val_6 = 106017180 + (丄丒丗丟世丘万丙丟) << 2;
        val_6 = val_6 + 106017180;
        goto (106017180 + (丄丒丗丟世丘万丙丟) << 2 + 106017180);
    }
    internal string 丅七丑与丆丞丝且丟(ModulesSetGadgetsStorage.GadgetProperty 丄丒丗丟世丘万丙丟)
    {
        if(丄丒丗丟世丘万丙丟 > 8)
        {
                return (string)System.String.alignConst;
        }
        
        var val_1 = 1;
        val_1 = val_1 << 丄丒丗丟世丘万丙丟;
        val_1 = val_1 & 430;
        if(val_1 != 0)
        {
                System.String.alignConst = "%";
            return (string)System.String.alignConst;
        }
        
        if(丄丒丗丟世丘万丙丟 != 0)
        {
                return (string)System.String.alignConst;
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7435");
    }
    internal string 下世三万专丈丂下丝(string 丗丄万丄丌丕丈丈三, ModulesSetGadgetsStorage.GadgetProperty 丄丒丗丟世丘万丙丟)
    {
        float val_1 = this.丅业专丏不丒丄丐一(丗丄万丄丌丕丈丈三:  丗丄万丄丌丕丈丈三, 丄丒丗丟世丘万丙丟:  丄丒丗丟世丘万丙丟);
        return (string)System.String.Format(format:  "{0}{1}", arg0:  val_1, arg1:  val_1.丅七丑与丆丞丝且丟(丄丒丗丟世丘万丙丟:  丄丒丗丟世丘万丙丟));
    }
    internal static bool 下丗上丑丒与七专丆(string 丗丑丐丕丟丝且下丕)
    {
        return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Gadget_Unlocked_" + 丗丑丐丕丟丝且下丕, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
    }
    internal static void 业丘丁丅业七丘丁丆(string 丗丑丐丕丟丝且下丕)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Gadget_Unlocked_" + 丗丑丐丕丟丝且下丕, 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal static 不丘丄丝丗丒丙一丌 丂丟七丝三七丄丈世(string 丐不丙万不世丛丛丐, ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专)
    {
        string val_24;
        var val_25;
        if(三丐三丞丘丕不丒专 != null)
        {
                val_24 = 三丐三丞丘丕不丒专.nameLocalizationKey;
        }
        else
        {
                val_24 = 64;
        }
        
        丕丈丏丝丗下丟丅丂 val_5 = new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  188, 丞丅上丏丂且下丅与:  丐不丙万不世丛丛丐, 业东丘与与业丏丛丈:  val_24, 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  三丐三丞丘丕不丒专.descriptionLocalizationKey, 丞世不丒下上上丝丑:  0, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  ((三丐三丞丘丕不丒专.type == 7) ? 1 : 0) | (((三丐三丞丘丕不丒专.type - 9) < 5) ? 1 : 0), 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65);
        if(三丐三丞丘丕不丒专.type <= 17)
        {
                var val_24 = 106017216 + (三丐三丞丘丕不丒专.type) << 2;
            val_24 = val_24 + 106017216;
        }
        else
        {
                val_25 = 0;
            return (不丘丄丝丗丒丙一丌);
        }
    
    }
    internal static bool 东丒丐三三东丈丒丈(ModulesSetGadgetsStorage.GadgetModuleType 丁丅丈丌丟世丗丗丟)
    {
        if(丁丅丈丌丟世丗丗丟 != 7)
        {
                return (bool)((丁丅丈丌丟世丗丗丟 - 9) < 5) ? 1 : 0;
        }
        
        return true;
    }
    internal static float 下丏丏东丙丒丑丝丁(string 专丏丈丟丐专下丏丒)
    {
        return BalanceController.丙丕丝三下丒且丅万(万专上丞业下丙丗丁:  专丏丈丟丐专下丏丒);
    }
    internal static float 丌丗丐下业七上丞下(string 丙丗丌丈一专丅丏丅)
    {
        return BalanceController.专丕一与业丏专不专(万专上丞业下丙丗丁:  丙丗丌丈一专丅丏丅);
    }
    internal static float 不三业丌丒下丕丌下(string 专丏丈丟丐专下丏丒)
    {
        return BalanceController.丕世丛专万丄丘下丞(万专上丞业下丙丗丁:  专丏丈丟丐专下丏丒);
    }
    internal static float 万三丘丗万七世业丗(string 专丏丈丟丐专下丏丒)
    {
        return BalanceController.丆丆丈丕丐丂丂且丑(万专上丞业下丙丗丁:  专丏丈丟丐专下丏丒);
    }
    internal static float 丐上丆丟丒丟丅丞一(string 专丏丈丟丐专下丏丒)
    {
        return BalanceController.七丂丌丈上丅丙世丞(万专上丞业下丙丗丁:  专丏丈丟丐专下丏丒);
    }
    public ModulesSetGadgetsStorage()
    {
        this._listRecords = new System.Collections.Generic.List<ModuleGadgetRecord>();
        this.propertiesLocalizations = new System.Collections.Generic.List<PropertyLocalization>();
        this.testGadgetID = "";
        this.testGadgetUp = "";
        this._moduleGadgets = new System.Collections.Generic.Dictionary<System.String, ModuleGadgetRecord>();
        this._propertiesDependencies = new System.Collections.Generic.Dictionary<GadgetProperty, PropertyLocalization>();
    }
    private static ModulesSetGadgetsStorage()
    {
        null = null;
        System.Func<ModulesSetGadgetsStorage> val_1 = 1152921538367249104;
        val_1 = new System.Func<ModulesSetGadgetsStorage>(object:  ModulesSetGadgetsStorage.<>c.<>9, method:  ModulesSetGadgetsStorage ModulesSetGadgetsStorage.<>c::专丝万业东丑上世丈());
        ModulesSetGadgetsStorage._instance = new Rilisoft.七丞丞丅东丞专丙丝<ModulesSetGadgetsStorage>(丙丂丌且丌世丒丐三:  val_1);
        ModulesSetGadgetsStorage._initialized = false;
    }

}
