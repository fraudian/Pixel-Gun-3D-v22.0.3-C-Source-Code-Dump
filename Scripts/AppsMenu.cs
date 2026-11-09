using UnityEngine;
internal sealed class AppsMenu : MonoBehaviour
{
    // Fields
    private static System.Text.StringBuilder 丆不丒丄丌七不丈丌;
    internal static readonly System.Diagnostics.Stopwatch 丁丈丈丞丌丐丆丐丆;
    internal static readonly System.Diagnostics.Stopwatch 一丛丂丐丞丒上丘丄;
    private static long 下丌丌丙专丟七专东;
    private static string 且东丁丄业世丞丁不;
    private static string 丄世专丁丛专丝三丄;
    private const bool 丌丂丘丆丞丅丆东丒 = True;
    private const bool 专丛丁丆丛世万三丁 = False;
    private bool 丛丐专丂丒丌丌丒丛;
    public UnityEngine.Texture androidFon;
    public UnityEngine.Texture commicsFon;
    public UnityEngine.GameObject activityIndikatorPrefab;
    public string intendedSignatureHash;
    private UnityEngine.Texture 丕丘三丅丑上与上丆;
    private const string 丝与丆丁丒与丄丒一 = "android.permission.WRITE_EXTERNAL_STORAGE";
    private static uint 世丞丕丅万与丏丕丂;
    private const string 丐丙丑丛与丑万丒丂 = "Scene";
    private System.IDisposable 丐丆七且丞丏下三丙;
    private int 丆丛丑世下一丐且丕;
    private readonly System.Threading.Tasks.TaskCompletionSource<bool> 世丐一东且丏丄丄世;
    private bool 丏与丐业专丙丑丟三;
    
    // Properties
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    internal static bool 丑世不与丛一业丅丟 { get; }
    private System.Threading.Tasks.Task<bool> 万丒七一丆丐丛丒丒 { get; }
    
    // Methods
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    internal static void 与不丅丑下专丟丈丟()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        AppsMenu.一丛丂丐丞丒上丘丄.Reset();
        AppsMenu.一丛丂丐丞丒上丘丄.Start();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        AppsMenu.丐丙丑丛与丑万丒丂.Length = 0;
        AppsMenu.丁丈丈丞丌丐丆丐丆.Reset();
        AppsMenu.丁丈丈丞丌丐丆丐丆.Start();
    }
    internal static void 丁七丙丌丗丝丒丟且()
    {
        var val_8;
        System.Diagnostics.Stopwatch val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        val_9 = AppsMenu.一丛丂丐丞丒上丘丄;
        val_9.Stop();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        AppsMenu.丁丈丈丞丌丐丆丐丆.Stop();
        AppsMenu.丐丙丑丛与丑万丒丂 = AppsMenu.丐丙丑丛与丑万丒丂.Replace(oldValue:  ".", newValue:  ",");
        System.DateTime val_5 = System.DateTime.Now;
        AppsMenu.丐丙丑丛与丑万丒丂 = AppsMenu.丐丙丑丛与丑万丒丂.Insert(index:  0, value:  System.String.Format(format:  "{0}\t{1}\n", arg0:  UnityEngine.SystemInfo.deviceModel, arg1:  val_5));
        val_9 = AppsMenu.丐丙丑丛与丑万丒丂;
        丗丏丑世丌丝丝上下.丒下一丟丝丕丈不一(丕丗丘丑丛与丑业丒:  val_9);
    }
    internal static void 且丝专丙且丒丝下丑(string 下业七不丑丂丏丟东)
    {
        System.Diagnostics.Stopwatch val_11;
        string val_12;
        var val_13;
        var val_14;
        long val_15;
        var val_16;
        val_12 = 下业七不丑丂丏丟东;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = null;
        if((System.String.op_Equality(a:  AppsMenu.且东丁丄业世丞丁不, b:  val_12)) != false)
        {
                val_14 = null;
            val_15 = AppsMenu.丁丈丈丞丌丐丆丐丆.ElapsedMilliseconds + AppsMenu.下丌丌丙专丟七专东;
        }
        else
        {
                val_15 = 0;
        }
        
        val_16 = null;
        AppsMenu.下丌丌丙专丟七专东 = val_15;
        val_16 = null;
        AppsMenu.且东丁丄业世丞丁不 = val_12;
        object[] val_5 = new object[4];
        val_5[0] = val_12;
        float val_10 = (float)AppsMenu.丁丈丈丞丌丐丆丐丆.ElapsedMilliseconds;
        val_10 = val_10 / 1000f;
        val_5[1] = val_10;
        val_5[2] = AppsMenu.下丌丌丙专丟七专东;
        float val_11 = (float)AppsMenu.一丛丂丐丞丒上丘丄.ElapsedMilliseconds;
        val_11 = val_11 / 1000f;
        val_12 = val_11;
        val_5[3] = val_12;
        AppsMenu.丐丙丑丛与丑万丒丂 = AppsMenu.丐丙丑丛与丑万丒丂.Append(value:  System.String.Format(format:  "{0}\t{1}\t{2}\t{3}\n", args:  val_5));
        AppsMenu.丁丈丈丞丌丐丆丐丆.Reset();
        val_11 = AppsMenu.丁丈丈丞丌丐丆丐丆;
        val_11.Start();
    }
    private void GetDeepLinkArgsFromiOS(string message)
    {
        var val_3;
        var val_4;
        val_3 = null;
        if(AppsMenu.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[AppsMenu.GetDeepLinkArgsFromiOS] message: "("[AppsMenu.GetDeepLinkArgsFromiOS] message: ") + message);
        }
        
        val_4 = null;
        val_4 = null;
        丅与专与丘丛万丘与.下丄丛业丟东丑上东 = message;
    }
    private static System.Collections.IEnumerator 丕业丑丑东东丈丂与(string 专万丟三世业丙丈且, long 丞丄丅上丏上专专丄, long 丝三丒丐七东与丐一)
    {
        AppsMenu.万不世丆丏丅丞丛业 val_1 = new AppsMenu.万不世丆丏丅丞丛业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丞丄丅上丏上专专丄 = 丞丄丅上丏上专专丄;
            .专万丟三世业丙丈且 = 专万丟三世业丙丈且;
        }
        else
        {
                mem[48] = 专万丟三世业丙丈且;
            mem[40] = 丞丄丅上丏上专专丄;
        }
        
        .丝三丒丐七东与丐一 = 丝三丒丐七东与丐一;
        return (System.Collections.IEnumerator)val_1;
    }
    private static string 万丏下丙专丙丒丘丏(uint 丝业丌丑丌丘世下丒)
    {
        var val_4 = null;
        AppsMenu.世丞丕丅万与丏丕丂 = AppsMenu.世丞丕丅万与丏丕丂 + 1;
        return (string)丝业丌丑丌丘世下丒 ^ 2546556124.ToString(format:  "x");
    }
    private static string 一丘丒丛丁东与丅丅(uint 丝业丌丑丌丘世下丒)
    {
        var val_4 = null;
        AppsMenu.世丞丕丅万与丏丕丂 = AppsMenu.世丞丕丅万与丏丕丂 + 1;
        return (string)丝业丌丑丌丘世下丒 ^ 3852684321.ToString(format:  "x");
    }
    private static string 丟丌丂丝丆丆专七丑(uint 丁丁万丟丙丕一丘下)
    {
        if("Closing4de1Scene" != null)
        {
                return (string)Replace(oldValue:  丁丁万丟丙丕一丘下.ToString(format:  "x"), newValue:  System.String.alignConst);
        }
        
        "Closing4de1Scene" = "Closing4de1Scene";
        return (string)Replace(oldValue:  丁丁万丟丙丕一丘下.ToString(format:  "x"), newValue:  System.String.alignConst);
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    internal static bool 丕且一下下七丘上丐()
    {
        return true;
    }
    private static void 丛丌三万丝一丅丝下()
    {
    
    }
    private void Awake()
    {
        object val_4;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        FpsManager.丞丝下丄丆且丌丈丐();
        val_45 = null;
        val_45 = null;
        Dictionary.Enumerator<TKey, TValue> val_1 = Progress.七七世万专丕丁上业.丛丘丝丕丌不世丟丐.GetEnumerator();
        label_26:
        if(((-1706284576) & 1) == 0)
        {
            goto label_6;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        三丅丁丗丗丝丂万且 val_7 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_5._value._obj.丐丏七丌丕丗业且上());
        val_46 = null;
        val_46 = null;
        string val_45 = val_7.与不丞丑七丘丁丂丛();
        val_45 = WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_45);
        val_5._value._obj.丝丈东七与丑专丘一(丙业与丙丗丝不丈东:  val_45);
        string val_46 = val_7.与不丞丑七丘丁丂丛();
        val_46 = WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_46);
        val_5._value._obj.不东丅丟世丁七与丅(丙业与丙丗丝不丈东:  val_46);
        string val_47 = val_7.与不丞丑七丘丁丂丛();
        val_47 = WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  val_47);
        val_5._value._obj.丌三丟七丌业丗下丗(丙业与丙丗丝不丈东:  val_47);
        string val_48 = val_7.三与丛丑且丐丈业丌();
        val_48 = WeaponManager.丞上一丘丆三下丐丑().Contains(item:  val_48);
        val_5._value._obj.且丁不不不丙丛丛专(丙业与丙丗丝不丈东:  val_48);
        string val_49 = val_7.与不丞丑七丘丁丂丛();
        val_49 = WeaponManager.丐上业丐丏丐万世丑().Contains(item:  val_49);
        val_5._value._obj.丞丁丘专丂专丙丕丕(丙业与丙丗丝不丈东:  val_49);
        goto label_26;
        label_6:
        val_47 = 0;
        val_48 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_51;
        }
        
        if(( == 0) || (210 != 210))
        {
            goto label_56;
        }
        
        goto label_56;
        label_51:
        label_56:
        业丌下丛丟万专丌丏 val_21 = 业丌下丛丟万专丌丏.丑七不且上丗丁一世();
        东不丞丄三世丟一丂 val_22 = 东不丞丄三世丟一丂.丑七不且上丗丁一世();
        PGCompany.丆丅三丁七世一丑丝 val_23 = PGCompany.丆丅三丁七世一丑丝.丑七不且上丗丁一世();
        System.Globalization.CultureInfo val_24 = System.Globalization.CultureInfo.InvariantCulture;
        System.Globalization.CultureInfo.DefaultThreadCurrentCulture = val_24;
        System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = val_24;
        System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> val_25 = PGCompany.GameplayLoop.丕与七丐丞丕丑业世.丂一丟丐专业丂丕丘();
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "reset_supress_time_android_15_10")) == true)
        {
            goto label_68;
        }
        
        丈丆丅丄与万丌世丂.一丝丏丆丞三丒丆丙();
        Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丙世丝一一丈三与丈(丙业与丙丗丝不丈东:  false);
        label_136:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "reset_supress_time_android_15_10", 下下丏一丙不丘丌丞:  "");
        label_68:
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  1);
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != true)
        {
                if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != true)
        {
                上丞丑上丙丈丄丗丐.丛丗上丝业下不丈丟();
        }
        
        }
        
        CloudHashMigrationValidator val_30 = CloudHashMigrationValidator.丑七不且上丗丁一世();
        TmpPrefsFilesCleaner val_31 = TmpPrefsFilesCleaner.丑七不且上丗丁一世();
        Rilisoft.丝丄三业丙专丛与不 val_32 = Rilisoft.丝丄三业丙专丛与不.丑七不且上丗丁一世();
        Rilisoft.TryGuns_2_0_Controller val_33 = Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世();
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "CurrentProductCurrency_12_5")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "CurrentProductCurrency_12_5", 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        AppsMenu.与不丅丑下专丟丈丟();
        Rilisoft.BackSystem.上丛丌丆丑上七世三();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake AppsMenu start synch");
        System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> val_36 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().专业丛丂丅与世上丙(与且专丏丅世丐丐丑:  true, 丙丈丄丟业丗上丒丛:  false);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake AppsMenu End synch");
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "BalanceController.SHOWN_ACTION_IDS_KEY")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "BalanceController.SHOWN_ACTION_IDS_KEY", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  new System.Collections.Generic.List<System.String>()));
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake AppsMenu start LogsManager");
        Rilisoft.丅专丞丛丞丐丛世三.上丛丌丆丑上七世三();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake AppsMenu end LogsManager");
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake AppsMenu end FirstTagForOurTier");
        val_50 = null;
        val_50 = null;
        if(ActivityIndicator.不丌世万丌丘丘丒上 == 0)
        {
                if(mem[1152921524375411072] != 0)
        {
                UnityEngine.Object.DontDestroyOnLoad(target:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  mem[1152921524375411072]));
        }
        
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start SetCurrentFon");
        this.丁丒丂丘丌丛丕丕丟();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "End SetCurrentFon");
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake AppsMenu");
        return;
        label_149:
        val_49 = 8;
        do
        {
        
        }
        while(123444064 != 1);
        
        if((null & 1) == 0)
        {
            goto label_129;
        }
        
        object[] val_43 = new object[1];
        val_43[0] = ;
        UnityEngine.Debug.LogErrorFormat(format:  "Exception in reset_supress_time_android_15_10: {0}", args:  val_43);
        goto label_136;
        label_129:
        mem[8] = ;
        goto label_149;
    }
    private void 丏东丅一丏东丆丌且()
    {
        string[] val_1 = new string[3];
        string val_2 = UnityEngine.Application.persistentDataPath;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = "Cache";
        val_1[2] = "bundles";
        string val_3 = 丞东丑专丛丆丄丝世.丏丅丅丘丝丑与丟丁(三丈一丈丂丆下七丞:  val_1);
        if((System.IO.Directory.Exists(path:  val_3)) == false)
        {
                return;
        }
        
        System.IO.Directory.Delete(path:  val_3, recursive:  true);
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AppsMenu.丐丘丝丕丙丟专丝丑();
    }
    private System.Collections.IEnumerator 七上丒丐丌三丅丑丏()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new AppsMenu.丑丕丄且丙丛丝东丅();
    }
    public static void OpenSettings()
    {
        var val_20;
        var val_21;
        var val_23;
        var val_24;
        var val_26;
        var val_28;
        new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri");
        object[] val_6 = new object[3];
        val_6[0] = "package";
        val_6[1] = val_2.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
        UnityEngine.AndroidJavaObject val_7 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fromParts", args:  val_6);
        object[] val_8 = new object[2];
        val_8[0] = "android.settings.APPLICATION_DETAILS_SETTINGS";
        val_8[1] = val_7;
        new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  val_8);
        object[] val_10 = new object[1];
        val_10[0] = "android.intent.category.DEFAULT";
        UnityEngine.AndroidJavaObject val_11 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "addCategory", args:  val_10);
        object[] val_12 = new object[1];
        val_12[0] = 268435456;
        UnityEngine.AndroidJavaObject val_13 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "setFlags", args:  val_12);
        object[] val_14 = new object[1];
        val_14[0] = new UnityEngine.AndroidJavaObject();
        val_2.Call(methodName:  "startActivity", args:  val_14);
        val_20 = 0;
        val_21 = 0;
        if(new UnityEngine.AndroidJavaObject() != null)
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
        }
        
        if((val_20 != 1) && (208 == 208))
        {
                val_20 = 0;
        }
        else
        {
                if(val_21 != 0)
        {
                val_21 = 0;
        }
        
        }
        
        val_23 = 0 + 1;
        mem2[0] = 222;
        val_24 = val_21;
        if(val_7 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_7.Dispose();
        }
        
        if((val_23 != 1) && ((1152921524376093984 + ((0 + 1)) << 2) == 222))
        {
                var val_22 = 0;
            val_22 = val_22 ^ (val_23 >> 31);
            val_23 = val_23 + val_22;
        }
        else
        {
                if(val_24 != 0)
        {
                val_21 = 0;
            val_24 = 0;
        }
        else
        {
                val_21 = 0;
        }
        
        }
        
        val_26 = val_23 + 1;
        mem2[0] = 234;
        if(new UnityEngine.AndroidJavaClass() != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
        }
        
        if((val_26 != 1) && ((1152921524376093984 + (((0 + 1) + 1)) << 2) == 234))
        {
                var val_24 = 0;
            val_24 = val_24 ^ (val_26 >> 31);
            val_26 = val_26 + val_24;
        }
        else
        {
                if(val_24 != 0)
        {
                val_21 = 0;
            val_24 = 0;
        }
        else
        {
                val_21 = 0;
        }
        
        }
        
        val_28 = val_26 + 1;
        mem2[0] = 246;
        if(val_2 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_2.Dispose();
        }
        
        if((val_28 != 1) && ((1152921524376093984 + ((((0 + 1) + 1) + 1)) << 2) == 246))
        {
                var val_26 = 0;
            val_26 = val_26 ^ (val_28 >> 31);
            val_28 = val_28 + val_26;
        }
        else
        {
                if(val_24 != 0)
        {
                val_21 = 0;
            val_24 = 0;
        }
        else
        {
                val_21 = 0;
        }
        
        }
        
        val_28 = val_28 + 1;
        mem2[0] = 258;
        if(new UnityEngine.AndroidJavaClass() != null)
        {
                var val_27 = 0;
            val_27 = val_27 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
        }
        
        if(val_28 != 1)
        {
                if(val_24 == 0)
        {
                return;
        }
        
            if((1152921524376093984 + (((((0 + 1) + 1) + 1) + 1)) << 2) != 258)
        {
                return;
        }
        
            return;
        }
        
        if(val_24 == 0)
        {
                return;
        }
    
    }
    private void 下业丒丛下丌丟一业(string 丑丞东万丁丂丏万丙 = "")
    {
        object val_24;
        string val_26;
        string val_27;
        string val_28;
        System.Text.StringBuilder val_1 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  240);
        val_24 = 且丞丑下丈丞丘一丌.丏丞且与丒丕丗不丄();
        if(val_24 == null)
        {
            goto label_3;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        goto label_7;
        label_3:
        UnityEngine.Debug.Log(message:  "[A_ppsM_enu.LogExpansionFileInfo] downloader: null");
        goto label_14;
        label_7:
        string val_4 = val_24.丏上丙丂丐丒丟丅丌();
        if((System.String.IsNullOrWhiteSpace(value:  val_4)) != false)
        {
                val_24 = "[A_ppsM_enu.LogExpansionFileInfo] mainObbFileName: "("[A_ppsM_enu.LogExpansionFileInfo] mainObbFileName: ") + val_4;
            UnityEngine.Debug.Log(message:  val_24);
        }
        else
        {
                new System.IO.FileInfo() = new System.IO.FileInfo(fileName:  val_4);
            System.Text.StringBuilder val_9 = val_1.Append(value:  "[A_ppsM_enu.LogExpansionFileInfo] " + 丑丞东万丁丂丏万丙);
            System.Text.StringBuilder val_11 = val_1.Append(value:  System.String.Format(format:  ". {0}: {1}", arg0:  "mainObbPath", arg1:  new System.IO.FileInfo()));
            val_26 = val_4;
            if((System.String.Equals(a:  new System.IO.FileInfo(), b:  val_26, comparisonType:  4)) != true)
        {
                val_26 = ", FullName: "(", FullName: ") + new System.IO.FileInfo();
            System.Text.StringBuilder val_14 = val_1.Append(value:  val_26);
        }
        
            System.Text.StringBuilder val_18 = val_1.Append(value:  ", mainObbExists: "(", mainObbExists: ") + 0.ToString(provider:  AppsMenu.丙专丝世不业下丂丈())(0.ToString(provider:  AppsMenu.丙专丝世不业下丂丈())));
            if((new System.IO.FileInfo() & 1) == 0)
        {
                System.IO.DirectoryInfo val_19 = new System.IO.FileInfo().Directory;
            if(val_19 != null)
        {
                System.IO.DirectoryInfo val_26 = val_19;
            val_26 = val_26 & 1;
            val_28 = val_26.ToString(provider:  AppsMenu.丙专丝世不业下丂丈());
        }
        else
        {
                val_28 = 0;
        }
        
            val_27 = ", mainObbDir.Exists: "(", mainObbDir.Exists: ") + val_28;
            System.Text.StringBuilder val_23 = val_1.Append(value:  val_27);
        }
        
            val_24 = val_1;
            UnityEngine.Debug.Log(message:  val_24);
            System.Text.StringBuilder val_24 = val_1.Clear();
        }
        
        label_14:
        PGCompany.丐丝丕一丒丐丄七与.七世丗且丑丝丐专丛(东世丞七丏下不丘丞:  val_1);
    }
    private System.Collections.IEnumerator 丒丅丂三丞丒丕七丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AppsMenu.丗丘丗丐丄丈丐丙丕();
    }
    private static string 丆丏丒丙世三丘丛下()
    {
        var val_6 = 0;
        val_6 = val_6 + 1;
        string val_3 = 且丞丑下丈丞丘一丌.丏丞且与丒丕丗不丄().丏上丙丂丐丒丟丅丌();
        return (string)((System.IO.File.Exists(path:  val_3)) != true) ? (val_3) : 0;
    }
    private static int 丏丞丆丞一丝丟丙下()
    {
        return (int)Rilisoft.丅丒三丐不丏业丛万.丞三丅丈上丘丕且丈();
    }
    private System.Threading.Tasks.Task<bool> 一七丝丛丟丞业丑下()
    {
        if(this.世丐一东且丏丄丄世 != null)
        {
                return this.世丐一东且丏丄丄世.Task;
        }
        
        return this.世丐一东且丏丄丄世.Task;
    }
    private void 丘东丗丁丛丒丗丙且(bool 业上丘下丗丂丝不上)
    {
        var val_5;
        bool val_1 = 业上丘下丗丂丝不上;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_1;
        UnityEngine.Debug.LogFormat(format:  "[A_ppsM_enu] H_andleS_torageP_ermissionD_ialog => permissionGranted: {0}", args:  val_2);
        bool val_4 = this.世丐一东且丏丄丄世.TrySetResult(result:  业上丘下丗丂丝不上);
        val_5 = null;
        val_5 = null;
        NoodlePermissionGranter.专且万丏一与丌东丅 = 0;
    }
    private static void 世一七七下丐万一丅()
    {
        string val_15;
        string val_17;
        val_15 = 与丂丏丛丞丞丒丟丄.丌专丞丈不一且东丐();
        if((丌丝世丞世丛丆丅丟.丐丘丐且业三丑丅丈(世丐与丞丕三丂专与:  val_15)) == true)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.丏七丂万不东丘丄丂(世丐与丞丕三丂专与:  与丂丏丛丞丞丒丟丄.丌专丞丈不一且东丐());
        string val_5 = UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业(), defaultValue:  System.String.alignConst);
        val_15 = val_5;
        if((System.String.IsNullOrEmpty(value:  val_5)) != false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_15, b:  "Français")) != false)
        {
                string val_8 = 与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业();
            val_17 = "French";
        }
        else
        {
                if((System.String.op_Equality(a:  val_15, b:  "Deutsch")) != false)
        {
                string val_10 = 与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业();
            val_17 = "German";
        }
        else
        {
                if((System.String.op_Equality(a:  val_15, b:  "日本人")) != false)
        {
                string val_12 = 与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业();
            val_17 = "Japanese";
        }
        else
        {
                if((System.String.op_Equality(a:  val_15, b:  "Español")) == false)
        {
                return;
        }
        
            val_17 = "Spanish";
        }
        
        }
        
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业(), value:  val_17);
        UnityEngine.PlayerPrefs.Save();
    }
    internal static void 丈丏丆丂万丏与丒万()
    {
        AppsMenu.世一七七下丐万一丅();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业());
        if((System.String.IsNullOrEmpty(value:  val_2)) != false)
        {
                string val_4 = 丟丏下丂七三下丗丕.丗七丏三万丛丙丟业();
            return;
        }
        
        丟丏下丂七三下丗丕.下且丘丒丗丑不丕丌(丙业与丙丗丝不丈东:  val_2);
    }
    private static void 丌丌丟三世丕丆丘一(string 丄丙下丝丛丒七丂丘, System.Collections.Generic.Dictionary<string, object> 丞万丕丏东与丑下丕, bool 东丅丞丁丗万且丁丗)
    {
        object[] val_1 = new object[2];
        val_1[0] = 丄丙下丝丛丒七丂丘;
        val_1[1] = 东丅丞丁丗万且丁丗;
        UnityEngine.Debug.LogFormat(format:  "GameThrive HandleNotification(\'{0}\', ..., {1})", args:  val_1);
    }
    private void 七丞不一丏丅且丑丟(UnityEngine.Color 一七专业丞丛世且丌, float 丗且丑丗且不三万一)
    {
    
    }
    private System.Collections.IEnumerator 丂丄丈且丑丒丑一与(float 世三丏丑丙丅丌且下, float 丅世丗丛万下下专丕)
    {
        AppsMenu.且东丘丙东丂丘丁东 val_1 = new AppsMenu.且东丘丙东丂丘丁东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丅世丗丛万下下专丕 = 丅世丗丛万下下专丕;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 上丛丅丙一专三东丛()
    {
        var val_8;
        var val_9;
        string val_10;
        var val_11;
        string val_12;
        var val_13;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(ActivityIndicator.不丌世万丌丘丘丒上 == 0)
        {
            goto label_7;
        }
        
        val_9 = null;
        val_9 = null;
        ActivityIndicator.不丌世万丌丘丘丒上 + 120.gameObject.SetActive(value:  true);
        val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1925");
        if((System.String.op_Equality(a:  "Key_1925", b:  val_10)) == false)
        {
            goto label_15;
        }
        
        val_11 = null;
        val_10 = ToUpperInvariant();
        val_11 = null;
        val_12 = ActivityIndicator.不丌世万丌丘丘丒上;
        if(ActivityIndicator.不丌世万丌丘丘丒上 != null)
        {
            goto label_19;
        }
        
        val_12 = ActivityIndicator.不丌世万丌丘丘丒上;
        if(val_12 == null)
        {
            goto label_20;
        }
        
        label_19:
        ActivityIndicator.不丌世万丌丘丘丒上 + 120.ambigiousFont = ActivityIndicator.不丌世万丌丘丘丒上 + 144;
        ActivityIndicator.不丌世万丌丘丘丒上 + 120.ProcessText();
        label_15:
        val_13 = null;
        val_13 = null;
        ActivityIndicator.不丌世万丌丘丘丒上 + 120.text = val_10;
        return;
        label_7:
        UnityEngine.Debug.LogWarning(message:  "ActivityIndicator.instance is null.");
        return;
        label_20:
    }
    private void 丁丒丂丘丌丛丕丕丟()
    {
        UnityEngine.Texture val_6;
        UnityEngine.Texture val_7;
        var val_8;
        val_6 = this;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_2;
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "StartLoadBackgroudTexture");
        if((UnityEngine.Object.op_Implicit(exists:  Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂())) == false)
        {
            goto label_9;
        }
        
        val_7 = Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂();
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_2:
        this.丕丘三丅丑上与上丆 = this.commicsFon;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        val_8 = null;
        val_8 = null;
        val_6 = this.丕丘三丅丑上与上丆;
        Switcher.丌不丙丞丙丌丗七上.Start();
        goto label_19;
        label_9:
        val_7 = this.androidFon;
        label_13:
        this.丕丘三丅丑上与上丆 = val_7;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "EndLoadBackgroudTexture");
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.不丌世万丌丘丘丒上.丆丆丁丂世丆且丈丐();
        label_19:
        ActivityIndicator.丞丂一丝三丄专丆一(丝丘专世丏三丝下丐:  this.丕丘三丅丑上与上丆);
    }
    internal static UnityEngine.Rect 七丄丞万业丒世下上()
    {
        int val_4 = UnityEngine.Screen.height;
        float val_5 = (float)UnityEngine.Screen.width;
        float val_6 = 0.5f;
        val_5 = val_5 * val_6;
        val_6 = ((float)UnityEngine.Screen.height * 1.776623f) * val_6;
        val_5 = val_5 - val_6;
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    private System.Collections.IEnumerator 丌丝丁专世业丄世丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new AppsMenu.丏下丂丆丝万丒上丁();
    }
    public AppsMenu()
    {
        this.丆丛丑世下一丐且丕 = 9001;
        this.世丐一东且丏丄丄世 = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
    }
    private static AppsMenu()
    {
        AppsMenu.丐丙丑丛与丑万丒丂 = new System.Text.StringBuilder(capacity:  160);
        AppsMenu.丁丈丈丞丌丐丆丐丆 = new System.Diagnostics.Stopwatch();
        AppsMenu.一丛丂丐丞丒上丘丄 = new System.Diagnostics.Stopwatch();
        AppsMenu.下丌丌丙专丟七专东 = 0;
        AppsMenu.且东丁丄业世丞丁不 = System.String.alignConst;
        AppsMenu.丄世专丁丛专丝三丄 = System.String.alignConst;
        AppsMenu.世丞丕丅万与丏丕丂 = -729383235;
    }

}
