using UnityEngine;
internal sealed class ReplaceAdmobPerelivController : MonoBehaviour
{
    // Fields
    private static int 丆上丟丂丐丛丂世三;
    private static int 下丐丈上业丘丆万丞;
    internal bool 丌东专且丑世专丐不;
    private string 丂丟下丌东万专下丝;
    private UnityEngine.Texture2D 丟且一万丆下丁东且;
    private System.Collections.Generic.IReadOnlyList<string> 丝丌丐丅丄丗丟下且;
    private long 丗上世丑与万丂世丟;
    private static ReplaceAdmobPerelivController <丗专丁丞丞丄东七丘>k__BackingField;
    private bool <丑丌专丐业且丑且丛>k__BackingField;
    private bool <丛业三丞专丟业下东>k__BackingField;
    
    // Properties
    internal static ReplaceAdmobPerelivController 丄丞丁丈与业上丞丟 { get; set; }
    internal UnityEngine.Texture2D 下且三丌丌丕丟丂且 { get; }
    internal string 丒一与丝丅丟丙丞丝 { get; }
    private System.Collections.Generic.IReadOnlyList<string> 丗不丝丝业丑丌专丄 { get; }
    internal bool 专丐万不丒东丙丅业 { get; }
    internal bool 丑丘丕与东东一不丛 { get; set; }
    internal bool 业丈且丝丕专丌丅丝 { get; set; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    
    // Methods
    internal static ReplaceAdmobPerelivController 丂丞丛丙东丗丈业丑()
    {
        null = null;
        return (ReplaceAdmobPerelivController)ReplaceAdmobPerelivController.<丗专丁丞丞丄东七丘>k__BackingField;
    }
    private static void 丕丆上三世丘不丂丂(ReplaceAdmobPerelivController 丙业与丙丗丝不丈东)
    {
        null = null;
        ReplaceAdmobPerelivController.<丗专丁丞丞丄东七丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Texture2D 一东三丟丁丘丏万丏()
    {
        return (UnityEngine.Texture2D)this.丟且一万丆下丁东且;
    }
    internal string 丞三东丟丄丐且东丌()
    {
        return (string)this.丂丟下丌东万专下丝;
    }
    private System.Collections.Generic.IReadOnlyList<string> 丈丟丝上丟丌万丒丂()
    {
        return (System.Collections.Generic.IReadOnlyList<System.String>)this.丝丌丐丅丄丗丟下且;
    }
    internal bool 丗丅丗丐丐丈丞丝丞()
    {
        var val_3;
        if((this.丟且一万丆下丁东且 == 0) || (this.丂丟下丌东万专下丝 == null))
        {
                return (bool)(this.丝丌丐丅丄丗丟下且 != 0) ? 1 : 0;
        }
        
        val_3 = 1;
        return (bool)(this.丝丌丐丅丄丗丟下且 != 0) ? 1 : 0;
    }
    internal bool 丝世丆与丏一丘丌专()
    {
        return (bool)this.<丑丌专丐业且丑且丛>k__BackingField;
    }
    internal void 世丌东丗丛丞丙丘丘(bool 丙业与丙丗丝不丈东)
    {
        this.<丑丌专丐业且丑且丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丏世与丛丛丝丈万东()
    {
        return (bool)this.<丛业三丞专丟业下东>k__BackingField;
    }
    internal void 下业七丙丈丂丏丛万(bool 丙业与丙丗丝不丈东)
    {
        this.<丛业三丞专丟业下东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    internal static void 下与丞丁下七丌且丒()
    {
        null = null;
        int val_1 = ReplaceAdmobPerelivController.丆上丟丂丐丛丂世三;
        val_1 = val_1 + 1;
        ReplaceAdmobPerelivController.丆上丟丂丐丛丂世三 = val_1;
    }
    internal static void 丝丘丑丒丌丈丒世丌(string 与且专丈不万东一万)
    {
        object val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
        {
            goto label_1;
        }
        
        if(ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑() != 0)
        {
            goto label_6;
        }
        
        val_21 = "[ReplaceAdmobPerelivController.TryShowPereliv] sharedController: null";
        goto label_9;
        label_1:
        val_21 = "[ReplaceAdmobPerelivController.TryShowPereliv] TryGetServerUniversalTime: false";
        label_9:
        UnityEngine.Debug.LogWarning(message:  val_21);
        return;
        label_6:
        ReplaceAdmobPerelivController val_4 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        val_22 = null;
        if(val_4.丝丌丐丅丄丗丟下且 == null)
        {
            goto label_15;
        }
        
        if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ReplaceAdmobPerelivController.TryShowPereliv] ShowBanner");
        }
        
        ModalBannerHolder val_6 = ModalBannerHolder.丑七不且上丗丁一世();
        val_6.mainStoreHolder.ShowBanner(丌丅丕一丛丛丄一万:  106, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        label_58:
        UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.丌下万丅丌东丑丑丌(), value:  0);
        int val_9 = 上七丄丆一与东丅丝.丑七不且上丗丁一世().世一丒与万丐丄万丑(丅丏丅丂丝一丆丙丅:  new System.DateTime());
        val_23 = null;
        val_23 = null;
        int val_21 = ReplaceAdmobPerelivController.下丐丈上业丘丆万丞;
        val_21 = val_21 + 1;
        ReplaceAdmobPerelivController.下丐丈上业丘丆万丞 = val_21;
        Rilisoft.且丞丘丁丁丝世丙丄.丑七不且上丗丁一世().与不丕丟丄丈丆丁丅();
        return;
        label_15:
        ReplaceAdmobPerelivController val_11 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        if(val_11.丟且一万丆下丁东且 == 0)
        {
            goto label_43;
        }
        
        ReplaceAdmobPerelivController val_13 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        if(val_13.丂丟下丌东万专下丝 == null)
        {
            goto label_43;
        }
        
        val_24 = null;
        if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() != false)
        {
                ReplaceAdmobPerelivController val_15 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
            UnityEngine.Debug.Log(message:  "[ReplaceAdmobPerelivController.TryShowPereliv] AdUrl: "("[ReplaceAdmobPerelivController.TryShowPereliv] AdUrl: ") + val_15.丂丟下丌东万专下丝);
        }
        
        ReplaceAdmobPerelivController val_17 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        val_25 = null;
        val_25 = null;
        AdmobPerelivWindow.世丝一且丏三丄丞丙 = val_17.丟且一万丆下丁东且;
        ReplaceAdmobPerelivController val_18 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        AdmobPerelivWindow.一一三丘丒且与丄万 = val_18.丂丟下丌东万专下丝;
        AdmobPerelivWindow.不丕丌与业丕下东丂(丙业与丙丗丝不丈东:  与且专丈不万东一万);
        goto label_58;
        label_43:
        val_26 = null;
        if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[ReplaceAdmobPerelivController.TryShowPereliv] context: "("[ReplaceAdmobPerelivController.TryShowPereliv] context: ") + 与且专丈不万东一万);
    }
    internal void 丝下三丗业丁业丛丟()
    {
        if(this.丟且一万丆下丁东且 == 0)
        {
                return;
        }
        
        this.丟且一万丆下丁东且 = 0;
    }
    internal PGCompany.DataObjects.万丞丘丏丆丆丝与与.丂丅丑丘丘与业丌丞 丛丅不丈七丄丅上丒()
    {
        object val_15;
        var val_16;
        var val_17;
        string val_19;
        string val_20;
        var val_21;
        var val_22;
        val_15 = this;
        string val_4 = 0;
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_2 = 0;
        丂丅丑丘丘与业丌丞 val_6 = 0;
        if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_2)) == false)
        {
            goto label_4;
        }
        
        if((PGCompany.DataObjects.三丛丂丟与不专丛丏.七三丟三丛上东丒且(上世丏丁世丟世丆业:  val_2, 七丆丒与丗丌丄且丂: out  val_4)) == false)
        {
            goto label_5;
        }
        
        if((PGCompany.DataObjects.三丛丂丟与不专丛丏.丘丂丅丞丗东专丒丘(上世丏丁世丟世丆业:  val_2, 七丆丒与丗丌丄且丂:  val_4, 丟丐丗万丅下丗丝万: out  val_6)) == false)
        {
            goto label_6;
        }
        
        val_16 = val_6;
        return (丂丅丑丘丘与业丌丞)val_16;
        label_4:
        val_17 = null;
        if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() == false)
        {
            goto label_18;
        }
        
        string val_9 = this.tag;
        val_19 = "[";
        val_20 = "] TryGetLastLoadedConfig: false";
        goto label_15;
        label_5:
        val_21 = null;
        if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() == false)
        {
            goto label_18;
        }
        
        string val_11 = this.tag;
        val_19 = "[";
        val_20 = "] TryGetPlayerCategory: false";
        goto label_15;
        label_6:
        val_22 = null;
        if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() == false)
        {
            goto label_18;
        }
        
        val_19 = "[";
        val_20 = "] TryGetEffectiveFakeInterstitialSettings: false";
        label_15:
        val_15 = val_19 + this.tag + val_20;
        UnityEngine.Debug.LogWarning(message:  val_15);
        label_18:
        val_16 = 0;
        return (丂丅丑丘丘与业丌丞)val_16;
    }
    internal void 三丕世不与不丌丙丄()
    {
        UnityEngine.Texture2D val_10;
        var val_13;
        if((this.<丑丌专丐业且丑且丛>k__BackingField) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "ReplaceAdmobPerelivController: data is already loading. returning...");
            return;
        }
        
        val_10 = this.丟且一万丆下丁东且;
        if(val_10 != 0)
        {
                val_10 = this.丟且一万丆下丁东且;
            UnityEngine.Object.Destroy(obj:  val_10);
        }
        
        this.丟且一万丆下丁东且 = 0;
        this.丝丌丐丅丄丗丟下且 = 0;
        this.丂丟下丌东万专下丝 = 0;
        if(this.丛丅不丈七丄丅上丒() == null)
        {
                return;
        }
        
        if(val_2.videoPaths != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_2.videoPaths.Count > 0)
        {
                this.丝丌丐丅丄丗丟下且 = val_2.videoPaths;
            return;
        }
        
            UnityEngine.Debug.LogWarning(message:  "LoadVideo: fakeInterstitialConfig.videoPaths.Count == 0");
        }
        
        if(val_2.imageUrls != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
        }
        else
        {
                val_13 = null;
            if(ReplaceAdmobPerelivController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
            UnityEngine.Debug.LogWarning(message:  "[ReplaceAdmobPerelivController.LoadPerelivData] imageUrls: null");
            return;
        }
        
        int val_7 = val_2.imageUrls.Count;
        if(val_7 > 0)
        {
                if(this == 0)
        {
                return;
        }
        
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.丌万丈丘世丅丘丌万(丞上不丈专丛丞丐与:  val_2.imageUrls, 丘丅丂三丏世专丑丟:  val_2.redirectUrls, 丞世不丒下上上丝丑:  UnityEngine.Random.Range(min:  0, max:  val_7)));
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "LoadPerelivData(): fakeInterstitialConfig.ImageUrls.Count == 0");
    }
    private string 丑东世丒丞东万丗丏(string 上丝专丂丒一丄业东)
    {
        int val_7;
        if(上丝专丂丒一丄业东 != null)
        {
                val_7 = 上丝专丂丒一丄业东.LastIndexOf(value:  ".", comparisonType:  4);
            return 上丝专丂丒一丄业东.Insert(startIndex:  val_7 = 0.LastIndexOf(value:  ".", comparisonType:  4), value:  (UnityEngine.Screen.height < 900) ? ((UnityEngine.Screen.height < 500) ? System.String.alignConst : "-Medium") : "-Hi");
        }
        
        return 上丝专丂丒一丄业东.Insert(startIndex:  val_7, value:  (UnityEngine.Screen.height < 900) ? ((UnityEngine.Screen.height < 500) ? System.String.alignConst : "-Medium") : "-Hi");
    }
    private System.Collections.IEnumerator 丌万丈丘世丅丘丌万(System.Collections.Generic.IReadOnlyList<string> 丞上不丈专丛丞丐与, System.Collections.Generic.IReadOnlyList<string> 丘丅丂三丏世专丑丟, int 丞世不丒下上上丝丑)
    {
        ReplaceAdmobPerelivController.丝且丂丙下丘不世丞 val_1 = new ReplaceAdmobPerelivController.丝且丂丙下丘不世丞();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丞上不丈专丛丞丐与 = 丞上不丈专丛丞丐与;
            .丘丅丂三丏世专丑丟 = 丘丅丂三丏世专丑丟;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丞上不丈专丛丞丐与;
            mem[56] = 丘丅丂三丏世专丑丟;
        }
        
        .丞世不丒下上上丝丑 = 丞世不丒下上上丝丑;
        return (System.Collections.IEnumerator)val_1;
    }
    private void Awake()
    {
        ReplaceAdmobPerelivController.丕丆上三世丘不丂丂(丙业与丙丗丝不丈东:  this);
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnApplicationPause(bool 丄七丙不丟丛与丏丐)
    {
        var val_4;
        if(丄七丙不丟丛与丏丐 != false)
        {
                this.丗上世丑与万丂世丟 = 专七专下且专三一且.上且一丈丐三丄一丆();
            return;
        }
        
        long val_4 = this.丗上世丑与万丂世丟;
        val_4 = 专七专下且专三一且.上且一丈丐三丄一丆() - val_4;
        if(val_4 < 3601)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        ReplaceAdmobPerelivController.下丐丈上业丘丆万丞 = 0;
        Rilisoft.且丞丘丁丁丝世丙丄.丑七不且上丗丁一世().且七丙丄丘一丄上不();
    }
    public ReplaceAdmobPerelivController()
    {
    
    }
    private static ReplaceAdmobPerelivController()
    {
        ReplaceAdmobPerelivController.丆上丟丂丐丛丂世三 = 0;
        ReplaceAdmobPerelivController.下丐丈上业丘丆万丞 = 0;
    }

}
