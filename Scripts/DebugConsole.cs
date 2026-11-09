using UnityEngine;
internal class DebugConsole : PGBehaviour
{
    // Fields
    private static DebugConsole 丄丘七三上丕世丞业;
    private static PGCompany.DebugLogWindow 丙丂三丆丗下丈七三;
    private static bool 丝三丄专丗丞丄丄丌;
    public static bool DuplicateToConsole;
    
    // Properties
    public static DebugConsole 丆丕丝丒不丙且丐丗 { get; set; }
    internal static PGCompany.DebugLogWindow 丘丈丝丞丂丅丟丏丌 { get; set; }
    public static bool 三不专丗七丄且丝业 { get; set; }
    
    // Methods
    public static DebugConsole get_Instance()
    {
        var val_4;
        DebugConsole val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = DebugConsole.丄丘七三上丕世丞业;
        if(val_5 == 0)
        {
                val_6 = null;
            val_5 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<DebugConsole>(丝三丁东丈丒世丅业:  new UnityEngine.GameObject(name:  "Console"));
            val_6 = null;
            DebugConsole.丄丘七三上丕世丞业 = val_5;
        }
        
        val_7 = null;
        val_7 = null;
        return (DebugConsole)DebugConsole.丄丘七三上丕世丞业;
    }
    public static void set_Instance(DebugConsole 丙业与丙丗丝不丈东)
    {
        null = null;
        DebugConsole.丄丘七三上丕世丞业 = 丙业与丙丗丝不丈东;
    }
    internal static PGCompany.DebugLogWindow 七上七下且三丙丌丆()
    {
        var val_8;
        PGCompany.DebugLogWindow val_9;
        var val_10;
        var val_11;
        val_8 = null;
        val_8 = null;
        val_9 = DebugConsole.丙丂三丆丗下丈七三;
        if(val_9 == 0)
        {
                InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
            val_10 = null;
            val_10 = null;
            DebugConsole.丙丂三丆丗下丈七三 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/DebugWindow/DebugLogWindow"), parent:  val_3.camera.transform.parent).GetComponent<PGCompany.DebugLogWindow>();
            val_9 = DebugConsole.丙丂三丆丗下丈七三;
            val_9.丙丝丄丝丟万丈丘丁();
        }
        
        val_11 = null;
        val_11 = null;
        return (PGCompany.DebugLogWindow)DebugConsole.丙丂三丆丗下丈七三;
    }
    private static void 丙丞下丌丛丘一上丄(PGCompany.DebugLogWindow 丙业与丙丗丝不丈东)
    {
        null = null;
        DebugConsole.丙丂三丆丗下丈七三 = 丙业与丙丗丝不丈东;
    }
    public static bool get_Enabled()
    {
        null = null;
        return (bool)DebugConsole.丝三丄专丗丞丄丄丌;
    }
    public static void set_Enabled(bool 丙业与丙丗丝不丈东)
    {
        var val_5;
        if(丙业与丙丗丝不丈东 != false)
        {
                DebugConsole.七上七下且三丙丌丆().enabled = true;
        }
        else
        {
                UnityEngine.Object.DestroyImmediate(obj:  DebugConsole.七上七下且三丙丌丆().gameObject);
        }
        
        val_5 = null;
        val_5 = null;
        DebugConsole.丝三丄专丗丞丄丄丌 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        DebugConsole.Enabled = System.Convert.ToBoolean(value:  UnityEngine.PlayerPrefs.GetInt(key:  "Dev.DebugConsoleEnabled", defaultValue:  0));
    }
    internal static void 丆丟丟三丗东一丆三(string 万且万且丑丗且丌丆)
    {
        DebugConsole.Instance.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  0, 万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
    }
    internal static void 丆丟丟三丗东一丆三(object 万且万且丑丗且丌丆)
    {
        DebugConsole val_1 = DebugConsole.Instance;
        this.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  0, 万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
    }
    internal static void 万丅丘业丕东丁丕业(string 丆丗丘丕且丈丘丁不, object[] 专丒丌丆下丐丞丟丞)
    {
        DebugConsole val_1 = DebugConsole.Instance;
        this.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  0, 万且万且丑丗且丌丆:  System.String.Format(format:  丆丗丘丕且丈丘丁不, args:  专丒丌丆下丐丞丟丞));
    }
    internal static void 丏丑丝丌东一与专一(string 万且万且丑丗且丌丆)
    {
        DebugConsole.Instance.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  2, 万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
    }
    internal static void 丏丑丝丌东一与专一(object 万且万且丑丗且丌丆)
    {
        DebugConsole val_1 = DebugConsole.Instance;
        this.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  2, 万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
    }
    internal static void 一世丂丐业业与丑丗(string 丆丗丘丕且丈丘丁不, object[] 专丒丌丆下丐丞丟丞)
    {
        DebugConsole val_1 = DebugConsole.Instance;
        this.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  2, 万且万且丑丗且丌丆:  System.String.Format(format:  丆丗丘丕且丈丘丁不, args:  专丒丌丆下丐丞丟丞));
    }
    internal static void 与丐丞一与七七七丂(string 万且万且丑丗且丌丆)
    {
        DebugConsole.Instance.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  1, 万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
    }
    internal static void 与丐丞一与七七七丂(object 万且万且丑丗且丌丆)
    {
        DebugConsole val_1 = DebugConsole.Instance;
        this.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  1, 万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
    }
    internal static void 专丆丝丌专不丌丌世(string 丆丗丘丕且丈丘丁不, object[] 专丒丌丆下丐丞丟丞)
    {
        DebugConsole val_1 = DebugConsole.Instance;
        this.丌丄丁丟丂丂东东业(丁丅丈丌丟世丗丗丟:  1, 万且万且丑丗且丌丆:  System.String.Format(format:  丆丗丘丕且丈丘丁不, args:  专丒丌丆下丐丞丟丞));
    }
    internal void 丌丄丁丟丂丂东东业(万丕丗丅丘丗丗丌世 丁丅丈丌丟世丗丗丟, string 万且万且丑丗且丌丆)
    {
        var val_14;
        string[] val_1 = new string[1];
        val_1[0] = 万且万且丑丗且丌丆;
        丄三丗世三丝下丆丒 val_2 = DebugConsole.三丙万丟丕不专丑丆(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丛专丛丕一与丅丝丁:  val_1);
        if(DebugConsole.DuplicateToConsole == false)
        {
            goto label_31;
        }
        
        if(丁丅丈丌丟世丗丗丟 == 2)
        {
            goto label_8;
        }
        
        if(丁丅丈丌丟世丗丗丟 == 1)
        {
            goto label_9;
        }
        
        if(丁丅丈丌丟世丗丗丟 != 0)
        {
            goto label_31;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        goto label_15;
        label_8:
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_20;
        label_9:
        var val_16 = 0;
        val_16 = val_16 + 1;
        goto label_25;
        label_15:
        UnityEngine.Debug.Log(message:  "[DebugConsole] " + val_2.丏万且专丑下东丞丑());
        goto label_31;
        label_20:
        UnityEngine.Debug.LogError(message:  "[DebugConsole] " + val_2.丏万且专丑下东丞丑());
        goto label_31;
        label_25:
        UnityEngine.Debug.LogWarning(message:  "[DebugConsole] " + val_2.丏万且专丑下东丞丑());
        label_31:
        val_14 = null;
        if(DebugConsole.Enabled == false)
        {
                return;
        }
        
        DebugConsole.七上七下且三丙丌丆().丑丞丝一万业不丑丈(丄丙下丝丛丒七丂丘:  val_2);
    }
    private static 丄三丗世三丝下丆丒 三丙万丟丕不专丑丆(万丕丗丅丘丗丗丌世 丁丅丈丌丟世丗丗丟, string[] 丛专丛丕一与丅丝丁)
    {
        var val_13;
        string val_14;
        System.DateTime val_1 = System.DateTime.Now;
        if(丁丅丈丌丟世丗丗丟 == 1)
        {
                val_13 = "[F0E68C]";
        }
        
        string[] val_4 = new string[7];
        val_4[0] = "[";
        val_4[1] = (丁丅丈丌丟世丗丗丟 == 2) ? "[FF0000]" : "[FFFFFF]";
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_4[2] = 丁丅丈丌丟世丗丗丟.ToString();
        val_4[3] = "[-]] ";
        val_4[4] = ;
        val_4[5] = " ";
        val_4[6] = System.String.Join(separator:  "", value:  丛专丛丕一与丅丝丁);
        string val_6 = +val_4;
        val_14 = val_6;
        if(val_6.Length >= 501)
        {
                val_14 = val_6.Substring(startIndex:  0, length:  244)(val_6.Substring(startIndex:  0, length:  244)) + "...";
        }
        
        丈丐丐丂丑丅丟与丁 val_12 = new 丈丐丐丂丑丅丟与丁();
        if(val_12 != null)
        {
                val_12.丆七与丒专丕下丒不(丙业与丙丗丝不丈东:  null);
            val_12.万丙丞丏一丆丂丞丌(丙业与丙丗丝不丈东:  val_6);
            val_12.丐世下丘丁上业下不(丙业与丙丗丝不丈东:  val_14);
        }
        else
        {
                val_12.丆七与丒专丕下丒不(丙业与丙丗丝不丈东:  null);
            val_12.万丙丞丏一丆丂丞丌(丙业与丙丗丝不丈东:  val_6);
            val_12.丐世下丘丁上业下不(丙业与丙丗丝不丈东:  val_14);
        }
        
        val_12.丁丂丘丘丆不丝丑丏(丙业与丙丗丝不丈东:  "StackTrace:\n"("StackTrace:\n") + System.Environment.StackTrace);
        return (丄三丗世三丝下丆丒)val_12;
    }
    public DebugConsole()
    {
    
    }
    private static DebugConsole()
    {
        DebugConsole.丝三丄专丗丞丄丄丌 = false;
        DebugConsole.DuplicateToConsole = true;
    }

}
