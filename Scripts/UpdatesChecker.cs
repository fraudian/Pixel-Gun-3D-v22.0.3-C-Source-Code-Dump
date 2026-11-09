using UnityEngine;
internal sealed class UpdatesChecker : MonoBehaviour
{
    // Fields
    private static UpdatesChecker <不丁丄七丛不丆丁丕>k__BackingField;
    private static bool <丟丝丏专且丙业世丒>k__BackingField;
    private static bool <业下丄丆丝丌丄东丞>k__BackingField;
    private static System.Action 三万下丕丄丒七丛世;
    private static bool 三丑一一世丞万丑丑;
    private static bool 丄丙丙万丅丐三丞丂;
    private string 丏丆丈丌世业专七不;
    private string 丕丁专丛丛丒丂七丌;
    private static string 丑与业不上丆与且丆;
    private static string 丛三三丏丘丛丗一丛;
    private static bool 丑下丑丈上一丒丗与;
    private static bool 丘丈七丒万丅丘丁与;
    private static System.Collections.Generic.List<VersionChange> 丝不丒与万世下一丘;
    private static System.Collections.Generic.List<VersionChange> 丝丅丂丈丟丈丒且丂;
    private const string 且丟丌丛丈下丛三丙 = "new_version_images";
    
    // Properties
    internal static UpdatesChecker 丆丕丝丒不丙且丐丗 { get; set; }
    internal static bool 丅丌一一丕不与丈丂 { get; set; }
    internal static bool 丄且七三丙业七丟上 { get; set; }
    internal static string 与丞专业丄与东世丝 { get; }
    
    // Methods
    internal static UpdatesChecker 丑七不且上丗丁一世()
    {
        null = null;
        return (UpdatesChecker)UpdatesChecker.且丟丌丛丈下丛三丙;
    }
    private static void 丒且丒丗丗丟下丗丝(UpdatesChecker 丙业与丙丗丝不丈东)
    {
        null = null;
        UpdatesChecker.且丟丌丛丈下丛三丙 = 丙业与丙丗丝不丈东;
    }
    internal static bool 丈下丐丕丟丂丒丗丞()
    {
        null = null;
        return (bool)UpdatesChecker.<丟丝丏专且丙业世丒>k__BackingField;
    }
    private static void 一丝万万丏世丁丑丂(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        UpdatesChecker.<丟丝丏专且丙业世丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 且丕丑万丂丘且丄丂()
    {
        null = null;
        return (bool)UpdatesChecker.<业下丄丆丝丌丄东丞>k__BackingField;
    }
    private static void 丄丕七丛丘丕丙丑与(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        UpdatesChecker.<业下丄丆丝丌丄东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 与下丅三万东丏丗且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  UpdatesChecker.三万下丕丄丒七丛世, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(UpdatesChecker.三万下丕丄丒七丛世 != 1152921505336029200);
    
    }
    internal static void 丗三上丈丄东丅丆一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  UpdatesChecker.三万下丕丄丒七丛世, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(UpdatesChecker.三万下丕丄丒七丛世 != 1152921505336029200);
    
    }
    internal static string 丝业丙丈东丐七丂丒()
    {
        var val_1;
        var val_5;
        val_1 = null;
        val_1 = null;
        if(UpdatesChecker.丄丙丙万丅丐三丞丂 != false)
        {
                val_5 = 1152921505336029216;
            return (string)val_5;
        }
        
        val_5 = 1152921505336029224;
        return (string)val_5;
    }
    internal static System.Collections.Generic.List<VersionChange> 丞世丁丕丌东丈丗丆()
    {
        var val_1;
        var val_5;
        val_1 = null;
        val_1 = null;
        if(UpdatesChecker.丄丙丙万丅丐三丞丂 != false)
        {
                val_5 = 1152921505336029240;
            return (System.Collections.Generic.List<VersionChange>)val_5;
        }
        
        val_5 = 1152921505336029248;
        return (System.Collections.Generic.List<VersionChange>)val_5;
    }
    private void Awake()
    {
        var val_4;
        UpdatesChecker.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        UpdatesChecker.一丝万万丏世丁丑丂(丙业与丙丗丝不丈东:  true);
        val_4 = null;
        val_4 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.世业丅下丏丆丗与三, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UpdatesChecker::丞且丄业丁丌丂丞与(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UpdatesChecker::丐丛丝丞丗丂上丄不()));
    }
    private void Start()
    {
        System.Version val_14;
        var val_15;
        var val_16;
        val_14 = this;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                UpdatesChecker.一丝万万丏世丁丑丂(丙业与丙丗丝不丈东:  true);
            return;
        }
        
        val_15 = 1152921504624312320;
        this.丕丁专丛丛丒丂七丌 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.CachedVersionInfo", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.AppVersionForCachedVersionInfo", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if(((System.String.op_Inequality(a:  this.丕丁专丛丛丒丂七丌, b:  System.String.alignConst)) != false) && ((System.String.op_Inequality(a:  val_3, b:  System.String.alignConst)) != false))
        {
                val_16 = null;
            val_16 = null;
            bool val_10 = this.丑丗丒丞丘丟丟不专(丄丕丛与不且业与专:  this.丕丁专丛丛丒丂七丌, 丌丈不丄丝七丕万专: out  1152921505336029224, 下丟专丙丘丆丌丆丗: out  false, 专丒丌丕丂丟与丘丏: out  false, 与东丛丙丆丁东不丑: out  1152921505336029248);
            val_15 = 1152921504626122752;
            val_14 = new System.Version();
            val_14 = new System.Version(version:  val_3);
            bool val_13 = System.Version.op_Inequality(v1:  new System.Version(), v2:  丟丌丁且且世丈丈丟.丕不七与丘东丞丕业());
            if(val_13 != false)
        {
                val_13.丗丝丗丒七上丘上丘();
        }
        
        }
        
        val_13.丝丆丆业丒丝丕业丝();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                return;
        }
        
        this.丝丆丆业丒丝丕业丝();
    }
    private void 丞且丄业丁丌丂丞与(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((this.专丟业万上丁丞丅丕(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗)) < 1)
        {
                return;
        }
        
        this.丏专丕丒下业七丝且(丆丐七丅丆丗丛上与:  20f);
    }
    private int 专丟业万上丁丞丅丕(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
    {
        bool val_1 = 一丐丗丁丞丆丅丟丄.ContainsKey(key:  "err_code");
        if(一丐丗丁丞丆丅丟丄 == null)
        {
            goto label_2;
        }
        
        if(val_1 == false)
        {
            goto label_3;
        }
        
        return System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["err_code"]);
        label_2:
        if(val_1 == true)
        {
                return System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["err_code"]);
        }
        
        label_3:
        string val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄.Item["info"]);
        this.丏丆丈丌世业专七不 = val_4;
        this.丛七世丙丟丞与一丆(丄丕丛与不且业与专:  val_4);
        return 0;
    }
    private void 丝丆丆业丒丝丕业丝()
    {
        var val_6;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                UpdatesChecker.一丝万万丏世丁丑丂(丙业与丙丗丝不丈东:  true);
            return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_2.set_Item(key:  "app_version", value:  FriendsController.上上丗且丗不丂下丞());
        val_6 = null;
        val_6 = null;
        int val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.世业丅下丏丆丗与三, 一丐丗丁丞丆丅丟丄:  val_2);
    }
    private void 丏专丕丒下业七丝且(float 丆丐七丅丆丗丛上与)
    {
        if(丆丐七丅丆丗丛上与 <= 0f)
        {
                this.丝丆丆业丒丝丕业丝();
        }
        
        UnityEngine.Coroutine val_2 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  丆丐七丅丆丗丛上与, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void UpdatesChecker::丝丆丆业丒丝丕业丝()));
    }
    private void 丐丛丝丞丗丂上丄不()
    {
        this.丝丆丆业丒丝丕业丝();
    }
    private void 丛七世丙丟丞与一丆(string 丄丕丛与不且业与专)
    {
        var val_10;
        var val_20;
        string val_21;
        var val_22;
        var val_23;
        System.Collections.Generic.List<VersionChange> val_24;
        var val_25;
        val_20 = null;
        val_20 = null;
        bool val_5 = this.丑丗丒丞丘丟丟不专(丄丕丛与不且业与专:  丄丕丛与不且业与专, 丌丈不丄丝七丕万专: out  1152921505336029216, 下丟专丙丘丆丌丆丗: out  1152921505336029232, 专丒丌丕丂丟与丘丏: out  1152921505336029233, 与东丛丙丆丁东不丑: out  1152921505336029240);
        UpdatesChecker.一丝万万丏世丁丑丂(丙业与丙丗丝不丈东:  UpdatesChecker.丑下丑丈上一丒丗与);
        UpdatesChecker.丄丕七丛丘丕丙丑与(丙业与丙丗丝不丈东:  (UpdatesChecker.丘丈七丒万丅丘丁与 == false) ? 1 : 0);
        bool val_7 = System.String.op_Inequality(a:  this.丕丁专丛丛丒丂七丌, b:  丄丕丛与不且业与专);
        if(val_7 != false)
        {
                val_7.丗丝丗丒七上丘上丘();
            val_21 = 1;
        }
        else
        {
                val_21 = 0;
        }
        
        val_22 = null;
        val_22 = null;
        UpdatesChecker.三丑一一世丞万丑丑 = true;
        UpdatesChecker.三万下丕丄丒七丛世.Invoke();
        if(val_21 == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = UpdatesChecker.丝不丒与万世下一丘;
        if(val_24 == null)
        {
                return;
        }
        
        val_24 = UpdatesChecker.丝不丒与万世下一丘;
        if(val_24 == null)
        {
                val_24 = 0;
        }
        
        List.Enumerator<T> val_8 = val_24.GetEnumerator();
        label_23:
        label_22:
        if((1689039648 & 1) == 0)
        {
            goto label_15;
        }
        
        string val_11 = val_10.丐丏七丌丕丗业且上();
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_21)) == true) || ((UpdatesChecker.专三丄丙丘世丁丘世(丝丅丏丙丞丟丕丘上:  val_21)) == true))
        {
            goto label_22;
        }
        
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.丛丂丝丙丐专丞且丕(丝丅丏丙丞丟丕丘上:  0));
        goto label_23;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_25 = null;
        val_25 = null;
        UpdatesChecker.丄丙丙万丅丐三丞丂 = true;
        if(UpdatesChecker.丄丙丙万丅丐三丞丂 != false)
        {
                this.万丂丌丘丈丏丟丟一();
            return;
        }
        
        this.StopCoroutine(routine:  this.丑三丄丝丒丏丈丝丞());
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.丑三丄丝丒丏丈丝丞());
    }
    private System.Collections.IEnumerator 丑三丄丝丒丏丈丝丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UpdatesChecker.业丌三丘丈丅丝丟下();
    }
    private void 万丂丌丘丈丏丟丟一()
    {
        var val_1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.CachedVersionInfo", 下下丏一丙不丘丌丞:  this.丏丆丈丌世业专七不);
        val_1 = null;
        val_1 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.AppVersionForCachedVersionInfo", 下下丏一丙不丘丌丞:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
    }
    private bool 丑丗丒丞丘丟丟不专(string 丄丕丛与不且业与专, out string 丌丈不丄丝七丕万专, out bool 下丟专丙丘丆丌丆丗, out bool 专丒丌丕丂丟与丘丏, out System.Collections.Generic.List<VersionChange> 与东丛丙丆丁东不丑)
    {
        var val_26;
        丌丈不丄丝七丕万专 = System.String.alignConst;
        下丟专丙丘丆丌丆丗 = true;
        专丒丌丕丂丟与丘丏 = true;
        与东丛丙丆丁东不丑 = new System.Collections.Generic.List<VersionChange>();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丕丛与不且业与专)) != false)
        {
                UnityEngine.Debug.LogError(message:  "parse client version info fail: string is null or empty");
            return false;
        }
        
        object[] val_4 = new object[1];
        1152921540656190624 = val_4;
        1152921540656190624[0] = 丄丕丛与不且业与专;
        UnityEngine.Debug.LogErrorFormat(format:  "parse client version info fail: unknown data format : \'{0}\'", args:  val_4);
        return false;
        label_99:
        if((1689544912 & 1) == 0)
        {
            goto label_54;
        }
        
        object[] val_28 = new object[1];
        val_28[0] = val_26.丐丏七丌丕丗业且上();
        UnityEngine.Debug.LogErrorFormat(format:  "parse client version info fail: unknown change format : \'{0}\'", args:  val_28);
        goto label_99;
        label_54:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return false;
    }
    private System.Collections.Generic.List<VersionChangeText> 东丂世丄丗且丏丁丐(object 万且万且丑丗且丌丆, string 丒丐丞丙万丂丁丐下)
    {
        var val_5;
        System.Collections.Generic.List<VersionChangeText> val_1 = new System.Collections.Generic.List<VersionChangeText>();
        if(万且万且丑丗且丌丆 == null)
        {
            goto label_33;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = 万且万且丑丗且丌丆.GetEnumerator();
        label_23:
        if((1689806960 & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        string val_7 = val_6._value._obj.丐丏七丌丕丗业且上();
        if(val_7 == null)
        {
            goto label_5;
        }
        
        if(val_6._value._obj != 0)
        {
                if(val_6._value._obj == null)
        {
            goto label_7;
        }
        
        }
        
        object[] val_8 = new object[1];
        val_8[0] = 万且万且丑丗且丌丆;
        UnityEngine.Debug.LogErrorFormat(format:  "parse client version info fail: text is not a string : \'{0}\'", args:  val_8);
        goto label_23;
        label_5:
        object[] val_9 = new object[1];
        val_9[0] = 万且万且丑丗且丌丆;
        UnityEngine.Debug.LogErrorFormat(format:  "parse client version info fail: locale is not a string : \'{0}\'", args:  val_9);
        goto label_23;
        label_7:
        new VersionChangeText() = new VersionChangeText();
        if(new VersionChangeText() != null)
        {
                .Locale = val_7;
        }
        else
        {
                mem[16] = val_7;
        }
        
        .Text = ;
        val_1.Add(item:  new VersionChangeText());
        goto label_23;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
        label_33:
        object[] val_11 = new object[2];
        val_11[0] = 丒丐丞丙万丂丁丐下;
        val_11[1] = 万且万且丑丗且丌丆;
        UnityEngine.Debug.LogErrorFormat(format:  "parse client version info fail: unknown {0} format : \'{1}\'", args:  val_11);
        return val_1;
    }
    internal static bool 专三丄丙丘世丁丘世(string 丝丅丏丙丞丟丕丘上)
    {
        return System.IO.File.Exists(path:  Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  丝丅丏丙丞丟丕丘上));
    }
    internal static UnityEngine.Texture2D 东丂丒七专丏丌丛丞(string 丝丅丏丙丞丟丕丘上)
    {
        UnityEngine.Texture2D val_7;
        if((UpdatesChecker.专三丄丙丘世丁丘世(丝丅丏丙丞丟丕丘上:  丝丅丏丙丞丟丕丘上)) != false)
        {
                val_7 = new UnityEngine.Texture2D();
            val_7 = new UnityEngine.Texture2D(width:  2, height:  2, textureFormat:  4, mipChain:  false);
            bool val_6 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.IO.File.ReadAllBytes(path:  Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  丝丅丏丙丞丟丕丘上)), markNonReadable:  true);
            new UnityEngine.Texture2D().filterMode = 0;
            return (UnityEngine.Texture2D)val_7;
        }
        
        val_7 = 0;
        return (UnityEngine.Texture2D)val_7;
    }
    private System.Collections.IEnumerator 丛丂丝丙丐专丞且丕(string 丝丅丏丙丞丟丕丘上)
    {
        UpdatesChecker.丆丆丂丝世丞下丑下 val_1 = new UpdatesChecker.丆丆丂丝世丞下丑下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丝丅丏丙丞丟丕丘上 = 丝丅丏丙丞丟丕丘上;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 一丘丏丗丈一万丛不(string 丝丅丏丙丞丟丕丘上)
    {
        var val_10;
        var val_11;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "new_version_images", defaultValue:  "[]"));
        val_10 = 0;
        System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.Object> val_5 = null;
        val_10 = val_5;
        val_5 = new System.Collections.Generic.List<System.Object>();
        val_11 = 0;
        goto label_5;
        label_10:
        val_4.Add(item:  val_5.Item[0]);
        val_11 = 1;
        label_5:
        if(val_11 < val_5.Count)
        {
            goto label_10;
        }
        
        if((val_4.Contains(item:  丝丅丏丙丞丟丕丘上)) != true)
        {
                val_4.Add(item:  丝丅丏丙丞丟丕丘上);
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "new_version_images", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
    }
    private void 丗丝丗丒七上丘上丘()
    {
        var val_11;
        var val_21;
        string val_22;
        string val_24;
        object val_25;
        var val_26;
        var val_27;
        var val_28;
        string val_30;
        var val_31;
        val_21 = null;
        val_21 = null;
        UpdatesChecker.丝丅丂丈丟丈丒且丂 = 0;
        UpdatesChecker.丛三三丏丘丛丗一丛 = System.String.alignConst;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.CachedVersionInfo", 下下丏一丙不丘丌丞:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.AppVersionForCachedVersionInfo", 下下丏一丙不丘丌丞:  System.String.alignConst);
        val_22 = UnityEngine.PlayerPrefs.GetString(key:  "new_version_images", defaultValue:  "[]");
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) == true)
        {
                return;
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_22);
        val_22 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<System.Object>(丑东与丅丐丅丂丞业:  null)) == false)
        {
            goto label_13;
        }
        
        System.Collections.Generic.List<System.String> val_5 = null;
        val_22 = val_5;
        val_5 = new System.Collections.Generic.List<System.String>();
        string val_6 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_5);
        val_24 = "new_version_images";
        goto label_14;
        label_13:
        int val_8 = Count - 1;
        if((val_8 & 2147483648) != 0)
        {
            goto label_16;
        }
        
        val_25 = 0;
        goto label_54;
        label_49:
        val_26 = null;
        val_26 = null;
        List.Enumerator<T> val_9 = UpdatesChecker.丝不丒与万世下一丘.GetEnumerator();
        label_23:
        if((1690646688 & 1) == 0)
        {
            goto label_21;
        }
        
        string val_12 = val_11.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  0, b:  X22)) == false)
        {
            goto label_23;
        }
        
        val_27 = 1;
        val_28 = 1;
        goto label_25;
        label_21:
        val_28 = 0;
        val_27 = 1;
        label_25:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_27 == 1) || (218 != 218))
        {
            goto label_34;
        }
        
        var val_20 = 0;
        val_20 = val_20 ^ 0;
        val_27 = val_27 + val_20;
        if( != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_34:
        if( == 0)
        {
            goto label_37;
        }
        
        val_25 = 0;
        if( != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_37:
        val_25 = 0;
        if( != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_54:
        object val_14 = Item[val_8];
        if(val_14 != null)
        {
                var val_15 = (null == null) ? (val_14) : 0;
        }
        else
        {
                val_30 = 0;
        }
        
        val_31 = null;
        val_31 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<VersionChange>(丑东与丅丐丅丂丞业:  UpdatesChecker.丝不丒与万世下一丘)) == false)
        {
            goto label_49;
        }
        
        label_41:
        val_28 = Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世();
        System.IO.File.Delete(path:  val_28.三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  val_30));
        RemoveAt(index:  val_8);
        label_40:
        val_8 = val_8 - 1;
        if((val_8 & 2147483648) == 0)
        {
            goto label_54;
        }
        
        label_16:
        val_24 = "new_version_images";
        label_14:
        UnityEngine.PlayerPrefs.SetString(key:  val_24, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  null));
        return;
        label_56:
        mem[8] = ;
        goto label_56;
    }
    public UpdatesChecker()
    {
    
    }
    private static UpdatesChecker()
    {
        null = null;
        UpdatesChecker.三万下丕丄丒七丛世 = new System.Action(object:  UpdatesChecker.<>c.<>9, method:  System.Void UpdatesChecker.<>c::不丅丞丗丏丘下且三());
        UpdatesChecker.三丑一一世丞万丑丑 = false;
    }

}
