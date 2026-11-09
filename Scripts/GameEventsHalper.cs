using UnityEngine;
internal class GameEventsHalper : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<EventGuiSettings.ResouceElement> gmhCategorySettings;
    public int lootBoxAllItemsCount;
    public int lootBoxRewardItemsCount;
    public int count;
    private static GameEventsHalper _instance;
    private static System.Collections.Generic.List<EventGuiSettings> _geGuiSettingsList;
    private static System.Collections.Generic.Dictionary<string, EventGuiSettings> _geGuiSettingsDict;
    internal const string SharedResourcesPath = "GameEvents/EventGUI_SharedResources/";
    internal const string DefaultResourcesPath = "default";
    internal GameEventsHalper.AnimationSettings animation;
    
    // Properties
    internal static GameEventsHalper Instance { get; }
    private static System.Collections.Generic.List<EventGuiSettings> geGuiSettingsList { get; }
    private static System.Collections.Generic.Dictionary<string, EventGuiSettings> geGuiSettingsDict { get; }
    
    // Methods
    internal static GameEventsHalper get_Instance()
    {
        if(GameEventsHalper.DefaultResourcesPath != 0)
        {
                return (GameEventsHalper)GameEventsHalper.DefaultResourcesPath;
        }
        
        GameEventsHalper.DefaultResourcesPath = UnityEngine.Resources.Load<GameEventsHalper>(path:  "GameEvents/GEHelper");
        return (GameEventsHalper)GameEventsHalper.DefaultResourcesPath;
    }
    private static System.Collections.Generic.List<EventGuiSettings> get_geGuiSettingsList()
    {
        var val_4;
        if(GameEventsHalper._geGuiSettingsList != null)
        {
                if(GameEventsHalper._geGuiSettingsList.Count != 0)
        {
                val_4 = null;
            return (System.Collections.Generic.List<EventGuiSettings>)GameEventsHalper._geGuiSettingsList;
        }
        
        }
        
        val_4 = null;
        GameEventsHalper._geGuiSettingsList = System.Linq.Enumerable.ToList<EventGuiSettings>(source:  UnityEngine.Resources.LoadAll<EventGuiSettings>(path:  "GameEvents/EventGUI_Settings"));
        return (System.Collections.Generic.List<EventGuiSettings>)GameEventsHalper._geGuiSettingsList;
    }
    private static System.Collections.Generic.Dictionary<string, EventGuiSettings> get_geGuiSettingsDict()
    {
        var val_11;
        if(GameEventsHalper._geGuiSettingsDict != null)
        {
                if(GameEventsHalper._geGuiSettingsDict.Count != 0)
        {
                return (System.Collections.Generic.Dictionary<System.String, EventGuiSettings>)GameEventsHalper._geGuiSettingsDict;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, EventGuiSettings> val_4 = new System.Collections.Generic.Dictionary<System.String, EventGuiSettings>(capacity:  GameEventsHalper.geGuiSettingsList.Count);
        GameEventsHalper._geGuiSettingsDict = val_4;
        val_11 = GameEventsHalper.geGuiSettingsList;
        List.Enumerator<T> val_6 = val_11.GetEnumerator();
        label_11:
        if(((-1546028392) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_7 = 0.丐丏七丌丕丗业且上();
        if((val_4.ContainsKey(key:  val_7.name)) == true)
        {
            goto label_11;
        }
        
        val_4.Add(key:  val_7.name, value:  val_7);
        goto label_11;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.Dictionary<System.String, EventGuiSettings>)GameEventsHalper._geGuiSettingsDict;
    }
    public static EventGuiSettings 三丝世业业一丛丌丑(string 丟丟丄专上丟丁丐丝)
    {
        var val_5;
        if((GameEventsHalper.geGuiSettingsDict.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                EventGuiSettings val_4 = GameEventsHalper.geGuiSettingsDict.Item[丟丟丄专上丟丁丐丝];
            return (EventGuiSettings)val_5;
        }
        
        val_5 = 0;
        return (EventGuiSettings)val_5;
    }
    public static void 丞丄七丙丙丂七丈丅()
    {
    
    }
    private static string 专不与丛业一丁丏丁(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
    {
        return (string)(丅东专与不三丂丁丝.不业丙丒丂丞下丆丙() == 100) ? "default_chests" : "default_roulettes";
    }
    internal static void 丗丁丝丛丄丌丐丛丂(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        GameEventsHalper.三丝世业业一丛丌丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝).丒丗丙丙丙丟专丅万(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
    }
    internal static void 东丌丅丟与专下三专(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈, string 万丑丞一丝丌丐丒丘)
    {
        GameEventsHalper.三丝世业业一丛丌丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝).与专丟业下且丕不丈(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈, 万丑丞一丝丌丐丒丘:  万丑丞一丝丌丐丒丘);
    }
    internal static void 丑丂与丅一丐一世丕(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈, string 下丕不世丕丄丐丑万)
    {
        GameEventsHalper.三丝世业业一丛丌丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝).丟不丏世丝丕与世丘(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈, 下丕不世丕丄丐丑万:  下丕不世丕丄丐丑万);
    }
    internal static void 下丕上丌一七丁上丁(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈, string 丟东丕丗丑丏丐丟丅)
    {
        GameEventsHalper.三丝世业业一丛丌丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝).专丏专上丅与丄丙丅(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈, 丟东丕丗丑丏丐丟丅:  丟东丕丗丑丏丐丟丅);
    }
    internal static T 业一丁丙丏专下丟丗<T>(string 丛丘丁丁上丅业丐丙, string 丒丘丏上丙丟丑丕丈, UnityEngine.Transform 丈东丘丏与丌东东下, bool 丛下丅丏丄且丁一业)
    {
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  丛丘丁丁上丅业丐丙);
        丛下丅丏丄且丁一业 = 丛下丅丏丄且丁一业;
        goto __RuntimeMethodHiddenParam + 48;
    }
    internal static T 业一丁丙丏专下丟丗<T>(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, string 丒丘丏上丙丟丑丕丈, UnityEngine.Transform 丈东丘丏与丌东东下, bool 丛下丅丏丄且丁一业)
    {
        UnityEngine.GameObject val_13;
        string val_14;
        UnityEngine.Object val_15;
        val_13 = 丛下丅丏丄且丁一业;
        string val_4 = "GameEvents/EventGUI"("GameEvents/EventGUI") + (丅东专与不三丂丁丝.不业丙丒丂丞下丆丙() == 100) ? "/Chests/chests_" : "/Roulettes/roulette_"((丅东专与不三丂丁丝.不业丙丒丂丞下丆丙() == 100) ? "/Chests/chests_" : "/Roulettes/roulette_")("GameEvents/EventGUI"("GameEvents/EventGUI") + (丅东专与不三丂丁丝.不业丙丒丂丞下丆丙() == 100) ? "/Chests/chests_" : "/Roulettes/roulette_"((丅东专与不三丂丁丝.不业丙丒丂丞下丆丙() == 100) ? "/Chests/chests_" : "/Roulettes/roulette_")) + 丒丘丏上丙丟丑丕丈;
        val_14 = val_4;
        val_15 = val_4;
        if(val_15 != 0)
        {
                val_15.gameObject.SetActive(value:  false);
            val_15 = val_15;
            val_14 = 1152921505284374528;
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_15.transform);
            if(val_13 == false)
        {
                return (Rilisoft.AbstractGameEventGui)val_15;
        }
        
            if(丈东丘丏与丌东东下 == 0)
        {
                return (Rilisoft.AbstractGameEventGui)val_15;
        }
        
            val_13 = val_15.gameObject;
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_13, 不东丛三丂丌丑专丆:  丈东丘丏与丌东东下.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            return (Rilisoft.AbstractGameEventGui)val_15;
        }
        
        UnityEngine.Debug.LogError(message:  "No event ui prefab at path: "("No event ui prefab at path: ") + val_14);
        return (Rilisoft.AbstractGameEventGui)val_15;
    }
    internal static T 丙丌丘丅丑与与丂万<T>(string 丞丕丟丁且丛三丕不, string 丒丘丏上丙丟丑丕丈, bool 下上丕丌业丁丙上丐 = False)
    {
        var val_15;
        string val_16;
        var val_17;
        UnityEngine.Object val_18;
        val_15 = __RuntimeMethodHiddenParam;
        val_16 = 丒丘丏上丙丟丑丕丈;
        val_17 = 1152921504848912384;
        val_18 = System.String.Format(format:  "GameEvents/EventGUI_Resource/{0}/{1}", arg0:  丞丕丟丁且丛三丕不, arg1:  GameEventsHalper.丏丟世丄七三丒丟上(丞丕丟丁且丛三丕不:  丞丕丟丁且丛三丕不, 丒丘丏上丙丟丑丕丈:  val_16));
        if((val_18 == 0) && (下上丕丌业丁丙上丐 != false))
        {
                val_18 = System.String.Format(format:  "GameEvents/EventGUI_Resource/{0}/{1}", arg0:  "default", arg1:  GameEventsHalper.丞与丐丂丟丕且丂丒(丒丘丏上丙丟丑丕丈:  val_16));
        }
        
        if(val_18 == 0)
        {
                return (object)val_18;
        }
        
        if(val_18 == null)
        {
                return (object)val_18;
        }
        
        val_18 = ???;
        val_15 = ???;
        val_16 = ???;
        val_17 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 16;
    }
    internal static string 丏丟世丄七三丒丟上(string 丞丕丟丁且丛三丕不, string 丒丘丏上丙丟丑丕丈)
    {
        return System.String.Format(format:  "{0}_{1}", arg0:  丞丕丟丁且丛三丕不, arg1:  丒丘丏上丙丟丑丕丈);
    }
    internal static string 丞与丐丂丟丕且丂丒(string 丒丘丏上丙丟丑丕丈)
    {
        return System.String.Format(format:  "{0}_{1}", arg0:  "default", arg1:  丒丘丏上丙丟丑丕丈);
    }
    internal static UnityEngine.Color 丈三丆丟丝七与丛丌(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, string 丒丘丏上丙丟丑丕丈)
    {
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        UnityEngine.Color val_2 = GameEventsHalper.丈三丆丟丝七与丛丌(丟丟丄专上丟丁丐丝:  丅东专与不三丂丁丝.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        val_7 = val_2.r;
        val_8 = val_2.g;
        val_9 = val_2.b;
        val_10 = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.magenta;
        if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_7, g = val_8, b = val_9, a = val_10}, rhs:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a})) == false)
        {
                return new UnityEngine.Color() {r = val_7, g = val_8, b = val_9, a = val_10};
        }
        
        UnityEngine.Color val_6 = GameEventsHalper.丈三丆丟丝七与丛丌(丟丟丄专上丟丁丐丝:  GameEventsHalper.专不与丛业一丁丏丁(丅东专与不三丂丁丝:  丅东专与不三丂丁丝), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        val_7 = val_6.r;
        val_8 = val_6.g;
        val_9 = val_6.b;
        val_10 = val_6.a;
        return new UnityEngine.Color() {r = val_7, g = val_8, b = val_9, a = val_10};
    }
    internal static UnityEngine.Color 丈三丆丟丝七与丛丌(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈)
    {
        string val_8;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        val_8 = 丒丘丏上丙丟丑丕丈;
        UnityEngine.Color val_1 = UnityEngine.Color.magenta;
        val_13 = val_1.r;
        val_14 = val_1.g;
        val_15 = val_1.b;
        val_16 = val_1.a;
        if((GameEventsHalper.geGuiSettingsDict.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                UnityEngine.Color val_6 = GameEventsHalper.geGuiSettingsDict.Item[丟丟丄专上丟丁丐丝].丝一丙丝上丛三丄丈(丒丘丏上丙丟丑丕丈:  val_8);
            val_13 = val_6.r;
            val_14 = val_6.g;
            val_15 = val_6.b;
            val_16 = val_6.a;
            return new UnityEngine.Color() {r = val_13, g = val_14, b = val_15, a = val_16};
        }
        
        val_8 = "No GE GUI Settings for event: "("No GE GUI Settings for event: ") + 丟丟丄专上丟丁丐丝;
        UnityEngine.Debug.LogError(message:  val_8);
        return new UnityEngine.Color() {r = val_13, g = val_14, b = val_15, a = val_16};
    }
    internal static string 专与丆与丅下丅且丆(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, string 丒丘丏上丙丟丑丕丈)
    {
        string val_2 = GameEventsHalper.专与丆与丅下丅且丆(丟丟丄专上丟丁丐丝:  丅东专与不三丂丁丝.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == false)
        {
                return val_2;
        }
        
        return GameEventsHalper.专与丆与丅下丅且丆(丟丟丄专上丟丁丐丝:  GameEventsHalper.专不与丛业一丁丏丁(丅东专与不三丂丁丝:  丅东专与不三丂丁丝), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
    }
    internal static string 专与丆与丅下丅且丆(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈)
    {
        if((GameEventsHalper.geGuiSettingsDict.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                EventGuiSettings val_4 = GameEventsHalper.geGuiSettingsDict.Item[丟丟丄专上丟丁丐丝];
            if(val_4 != null)
        {
                return val_4.丟丛丙不丗万丙一上(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        }
        
            return val_4.丟丛丙不丗万丙一上(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        }
        
        UnityEngine.Debug.LogError(message:  "No GE GUI Settings for event: "("No GE GUI Settings for event: ") + 丟丟丄专上丟丁丐丝);
        return "";
    }
    internal static UnityEngine.Texture 下丁丞上上且世丂丅(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Texture val_2 = GameEventsHalper.下丁丞上上且世丂丅(丟丟丄专上丟丁丐丝:  丅东专与不三丂丁丝.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        if(val_2 != 0)
        {
                return val_2;
        }
        
        return GameEventsHalper.下丁丞上上且世丂丅(丟丟丄专上丟丁丐丝:  GameEventsHalper.专不与丛业一丁丏丁(丅东专与不三丂丁丝:  丅东专与不三丂丁丝), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
    }
    internal static UnityEngine.Texture 下丁丞上上且世丂丅(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈)
    {
        string val_9;
        var val_10;
        if((GameEventsHalper.geGuiSettingsDict.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                val_9 = GameEventsHalper.geGuiSettingsDict.Item[丟丟丄专上丟丁丐丝].丑东丐下专丞丕丘世(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
            val_10 = 0;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_9)) == false)
        {
                return (UnityEngine.Texture)val_10;
        }
        
            UnityEngine.Texture val_7 = GameEventsHalper.世与丘与下丝丝与丂<UnityEngine.Texture>(丒丘丏上丙丟丑丕丈:  val_9);
            return (UnityEngine.Texture)val_10;
        }
        
        val_9 = "No GE GUI Settings for event: "("No GE GUI Settings for event: ") + 丟丟丄专上丟丁丐丝;
        UnityEngine.Debug.LogError(message:  val_9);
        val_10 = 0;
        return (UnityEngine.Texture)val_10;
    }
    internal static UnityEngine.Material 丄丑与一丁丝丌丁东(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Material val_2 = GameEventsHalper.丄丑与一丁丝丌丁东(丟丟丄专上丟丁丐丝:  丅东专与不三丂丁丝.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        if(val_2 != 0)
        {
                return val_2;
        }
        
        return GameEventsHalper.丄丑与一丁丝丌丁东(丟丟丄专上丟丁丐丝:  GameEventsHalper.专不与丛业一丁丏丁(丅东专与不三丂丁丝:  丅东专与不三丂丁丝), 丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
    }
    internal static UnityEngine.Material 丄丑与一丁丝丌丁东(string 丟丟丄专上丟丁丐丝, string 丒丘丏上丙丟丑丕丈)
    {
        string val_9;
        var val_10;
        if((GameEventsHalper.geGuiSettingsDict.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                val_9 = GameEventsHalper.geGuiSettingsDict.Item[丟丟丄专上丟丁丐丝].丑丟七一丙丈丞丑东(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
            val_10 = 0;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_9)) == false)
        {
                return (UnityEngine.Material)val_10;
        }
        
            UnityEngine.Material val_7 = GameEventsHalper.世与丘与下丝丝与丂<UnityEngine.Material>(丒丘丏上丙丟丑丕丈:  val_9);
            return (UnityEngine.Material)val_10;
        }
        
        val_9 = "No GE GUI Settings for event: "("No GE GUI Settings for event: ") + 丟丟丄专上丟丁丐丝;
        UnityEngine.Debug.LogError(message:  val_9);
        val_10 = 0;
        return (UnityEngine.Material)val_10;
    }
    internal static T 世与丘与下丝丝与丂<T>(string 丒丘丏上丙丟丑丕丈)
    {
        string val_1 = "GameEvents/EventGUI_SharedResources/"("GameEvents/EventGUI_SharedResources/") + 丒丘丏上丙丟丑丕丈;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public GameEventsHalper()
    {
        this.lootBoxAllItemsCount = 64424509455;
        this.lootBoxRewardItemsCount = 15;
        this.count = 15;
    }

}
