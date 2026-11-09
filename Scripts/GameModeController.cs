using UnityEngine;
public class GameModeController : MonoBehaviour
{
    // Fields
    private static readonly System.Collections.Generic.HashSet<string> 丟七业丐丁七东丛丄;
    private static System.Action 与丙丆不丞与且丆上;
    private System.Action 丒丕丌一丌丘专三丛;
    private System.Action 丒且丒不丈丝丘丝丐;
    private System.Action 三丗丝丕业丞丆丅下;
    internal GameController 丁丕不丛丆丈世万丙;
    internal 丒且丑丙专丟丗丏业 专丞上七七且丝七丗;
    protected System.Collections.Generic.List<BaseConditionEndRound> _listConditionEndRoudn;
    protected System.Collections.Generic.List<BaseConditionEndRound> _listConditionGlobalEndRoudn;
    internal 丁丁丒丆不丒下丟三 丝丆丒一下上下一丞;
    internal 丁丁丒丆不丒下丟三 东丈丆下丂丛丒丟专;
    internal 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 丐丄东丙丙丂丐业丙;
    internal 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 丅丁丈丟业上下丘东;
    private bool 东丗丄与丒丂下且丆;
    protected System.Diagnostics.Stopwatch 丅三业世丐且丑丐丅;
    protected System.Diagnostics.Stopwatch 丏专丝丞不丐东丟业;
    protected bool 不与世丆丟丞不丅丘;
    protected int 下丒丕丟丅丘丈丞丑;
    internal bool 丘下丗丁丕丛丟丅丕;
    public bool IsThirdPersonView;
    public bool IsThirdPersonMode;
    public bool IsControllerBattleRoyalType;
    public bool IsUsePets;
    public bool IsGadgetsPanelEnabled;
    internal System.Collections.Generic.List<Rilisoft.专与丏丞三与不不丆> killBonuses;
    private Rilisoft.丝丑丂丛万丐丈丘且 专七丈丅丝丙丆丙丑;
    private Rilisoft.丝丑丂丛万丐丈丘且 且业一丟丟世与三丑;
    private Rilisoft.丝丑丂丛万丐丈丘且 丏丒世业丆丒丈丞丟;
    private static System.Action 丂丕东丌七丟业且且;
    private static System.Action<bool> 世丘三丁丁业丌丐不;
    private static System.Action 七丂丏丗上丝世丗丌;
    protected 丑业世且丕丟丞丙万 东世东丞业万丙不丞;
    private static System.Action 一丘业丘丁专丗丂且;
    
    // Properties
    internal double 丄丞专丆三丌三不丂 { get; }
    internal double 丘丅七三下丝丝业丗 { get; }
    internal int 丄东丞丘丞下下下丙 { get; set; }
    internal int 专丈丛丛丄东不丂丕 { get; set; }
    internal int 丟与丄丟丂丅专丅专 { get; set; }
    
    // Methods
    internal static void 专丁东七丑丕一不丁()
    {
        null = null;
        GameModeController.丟七业丐丁七东丛丄.Clear();
    }
    private static void 丝丘丟丑三不世丄丆()
    {
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_17;
        var val_18;
        System.Collections.Generic.HashSet<System.String> val_19;
        var val_20;
        var val_21;
        var val_22;
        val_17 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_18 = null;
            val_18 = null;
            val_19 = GameModeController.丟七业丐丁七东丛丄;
            if((val_19.Contains(item:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘())) == true)
        {
                return;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        val_19 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_19 == 0)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_21 = null;
            val_21 = null;
            bool val_9 = GameModeController.丟七业丐丁七东丛丄.Add(item:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘());
        }
        
        UnityEngine.SceneManagement.Scene val_10 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_19 = val_10.m_Handle.name;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_22 = null;
        val_22 = null;
        val_17 = System.Linq.Enumerable.ToList<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与());
        PGCompany.Analytics.一业丗丆世世上丁且.丞不世丒丛丂万丒丘(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞丁丑丏丄丏七丂不:  val_19, 丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业().ToString(), 专万丏丝丟丈丝丄丕:  val_17);
    }
    internal static void 丂丂且丂丂与丟丁丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GameModeController.与丙丆不丞与且丆上, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.与丙丆不丞与且丆上 != 1152921505189756936);
    
    }
    internal static void 上丝世一丆丙丙丙三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GameModeController.与丙丆不丞与且丆上, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.与丙丆不丞与且丆上 != 1152921505189756936);
    
    }
    internal void 一下不东丆三丆丏丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒丕丌一丌丘专三丛, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丕丌一丌丘专三丛 != 1152921537484550040);
    
    }
    internal void 丐丌丈丈丘丗丛丆丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒丕丌一丌丘专三丛, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丕丌一丌丘专三丛 != 1152921537484686616);
    
    }
    internal void 业丄七丝丆丗三丆东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒且丒不丈丝丘丝丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒且丒不丈丝丘丝丐 != 1152921537484823200);
    
    }
    internal void 丑丁丗七业丘与丟丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒且丒不丈丝丘丝丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒且丒不丈丝丘丝丐 != 1152921537484959776);
    
    }
    internal void 丛世丝一万丒世丁七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三丗丝丕业丞丆丅下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三丗丝丕业丞丆丅下 != 1152921537485096360);
    
    }
    internal void 与专万三丒丄专且丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三丗丝丕业丞丆丅下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三丗丝丕业丞丆丅下 != 1152921537485232936);
    
    }
    internal double 不东业丒丛丙丗上丝()
    {
        if(this.丏专丝丞不丐东丟业 == null)
        {
                return 0;
        }
        
        System.TimeSpan val_1 = this.丏专丝丞不丐东丟业.Elapsed;
        double val_2 = val_1._ticks.TotalSeconds;
        return 0;
    }
    internal double 丞丈丝上丕丗三万三()
    {
        if(this.丅三业世丐且丑丐丅 == null)
        {
                return 0;
        }
        
        System.TimeSpan val_1 = this.丅三业世丐且丑丐丅.Elapsed;
        double val_2 = val_1._ticks.TotalSeconds;
        return 0;
    }
    internal int 丞丏丕丑丞丑丏丏丄()
    {
    
    }
    internal void 一丟丌万东专丐丂丆(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.专七丈丅丝丙丆丙丑 = 0;
        mem[1152921537485709864] = 0;
    }
    internal int 七丒丘丏业丟丌丄七()
    {
    
    }
    internal void 与丄下丑丈丗三丂丘(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.且业一丟丟世与三丑 = 0;
        mem[1152921537485933880] = 0;
    }
    internal int 丘不丄一丒丆丒丅万()
    {
    
    }
    internal void 丈丕丅且丄七丄丙下(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丏丒世业丆丒丈丞丟 = 0;
        mem[1152921537486157896] = 0;
    }
    private void 万丟丙丌丛且丐不丘()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        UnityEngine.Object val_25;
        var val_26;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_20 = null;
        val_20 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_3 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  14);
        if((val_3 == null) || ((val_3.丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom")) != 2))
        {
            goto label_7;
        }
        
        val_21 = "BackgroundMusic/BackgroundMusic_BrawlCyber";
        goto label_42;
        label_7:
        val_22 = null;
        val_22 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_1.m_Handle.name)) != 0)
        {
                丟丌丁且且世丈丈丟.丞丄丗丟丂丆万上七(丙业与丙丗丝不丈东:  val_5.indexMap);
        }
        
        int val_7 = 丟丌丁且且世丈丈丟.丙东东丅丁业丝万一();
        val_23 = 1152921504622075904;
        goto label_20;
        label_3:
        if(丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一() == 0)
        {
            goto label_23;
        }
        
        val_23 = 1152921504622075904;
        val_24;
        label_20:
        label_42:
        UnityEngine.Object val_11 = UnityEngine.Resources.Load(path:  "BackgroundMusic/BackgroundMusic_Level"("BackgroundMusic/BackgroundMusic_Level") + 丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一());
        if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_25 = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_25)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_25);
        return;
        label_23:
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_38;
        }
        
        }
        
        val_26 = "BackgroundMusic_Level0";
        goto label_39;
        label_38:
        label_39:
        string val_19 = "BackgroundMusic/"("BackgroundMusic/") + (GameConnect.丛专丌且丕不专丈下() != true) ? "BackgroundMusic_Speedrun" : "Background_Training"((GameConnect.丛专丌且丕不专丈下() != true) ? "BackgroundMusic_Speedrun" : "Background_Training");
        goto label_42;
    }
    public virtual void Initialize()
    {
        GameController val_1 = GameController.丑七不且上丗丁一世();
        this.丁丕不丛丆丈世万丙 = val_1;
        val_1.万丟丙丌丛且丐不丘();
        this.丏专丝丞不丐东丟业.Start();
        this.丘下丗丁丕丛丟丅丕 = true;
        if(this.killBonuses != null)
        {
                if(this.killBonuses.Count != 0)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.List<Rilisoft.专与丏丞三与不不丆> val_3 = new System.Collections.Generic.List<Rilisoft.专与丏丞三与不不丆>();
        if(val_3 != null)
        {
                val_3.Add(item:  16);
            val_3.Add(item:  13);
            val_3.Add(item:  16);
            val_3.Add(item:  13);
        }
        else
        {
                val_3.Add(item:  16);
            val_3.Add(item:  13);
            val_3.Add(item:  16);
            val_3.Add(item:  13);
        }
        
        val_3.Add(item:  0);
        this.killBonuses = val_3;
    }
    internal virtual void 东丞丒丗专业且专丒()
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.专七丈丅丝丙丆丙丑 = 0;
        mem[1152921537486601128] = 0;
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.且业一丟丟世与三丑 = 0;
        mem[1152921537486601144] = 0;
        int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丏丒世业丆丒丈丞丟 = 0;
        mem[1152921537486601160] = 0;
    }
    public static void add_OnStartMode(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GameModeController.丂丕东丌七丟业且且, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.丂丕东丌七丟业且且 != 1152921505189756944);
    
    }
    public static void remove_OnStartMode(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GameModeController.丂丕东丌七丟业且且, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.丂丕东丌七丟业且且 != 1152921505189756944);
    
    }
    public virtual void AfterInitialization()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = GameModeController.丂丕东丌七丟业且且;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = GameModeController.丂丕东丌七丟业且且;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal virtual void 三丟丏东且与丗世专(bool 丂丘下万丈丘丅一丄 = False)
    {
        var val_4;
        if(GameConnect.丞丂丑一丕丑丙三丐() == false)
        {
                return;
        }
        
        this.业丁丂丆丕丝三丐丆();
        List.Enumerator<T> val_2 = this._listConditionEndRoudn.GetEnumerator();
        label_10:
        if(((-1479479008) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == 0)
        {
            goto label_10;
        }
        
        System.Action<BaseConditionEndRound> val_7 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1C0);
        val_5.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  null);
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_8 = this._listConditionGlobalEndRoudn.GetEnumerator();
        label_23:
        if(((-1479479008) & 1) == 0)
        {
            goto label_18;
        }
        
        string val_9 = val_4.丐丏七丌丕丗业且上();
        if(val_9 == 0)
        {
            goto label_23;
        }
        
        System.Action<BaseConditionEndRound> val_11 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1D0);
        val_9.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  null);
        goto label_23;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.三丐丝丙与丘世不下());
    }
    private System.Collections.IEnumerator 三丐丝丙与丘世不下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GameModeController.丗七一丗丙七丐且丁();
    }
    public static void add_OnConnectionMode(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GameModeController.世丘三丁丁业丌丐不, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.世丘三丁丁业丌丐不 != 1152921505189756952);
    
    }
    public static void remove_OnConnectionMode(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GameModeController.世丘三丁丁业丌丐不, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.世丘三丁丁业丌丐不 != 1152921505189756952);
    
    }
    protected virtual void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄 = False)
    {
        var val_1;
        System.Action<System.Boolean> val_2;
        val_1 = null;
        val_1 = null;
        val_2 = GameModeController.世丘三丁丁业丌丐不;
        if(val_2 != null)
        {
                val_2 = GameModeController.世丘三丁丁业丌丐不;
            if(val_2 == null)
        {
                val_2 = 0;
        }
        
            丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
            val_2.Invoke(obj:  丂丘下万丈丘丅一丄);
        }
        
        this.业丁丂丆丕丝三丐丆();
    }
    public static void add_OnEndLocalRound(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GameModeController.七丂丏丗上丝世丗丌, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.七丂丏丗上丝世丗丌 != 1152921505189756960);
    
    }
    public static void remove_OnEndLocalRound(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GameModeController.七丂丏丗上丝世丗丌, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.七丂丏丗上丝世丗丌 != 1152921505189756960);
    
    }
    public virtual void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_4;
        var val_21;
        var val_22;
        System.Action val_23;
        丌丈不下下丘丏丌一 val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  54);
        List.Enumerator<T> val_2 = this._listConditionEndRoudn.GetEnumerator();
        val_21 = 1152921537487063744;
        label_7:
        if(((-1478510688) & 1) == 0)
        {
            goto label_5;
        }
        
        System.Action<BaseConditionEndRound> val_6 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1C0);
        val_4.丐丏七丌丕丗业且上().丏丘丗丝丂丛丟丐丝(丙业与丙丗丝不丈东:  null);
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_22 = null;
        val_22 = null;
        val_23 = GameModeController.七丂丏丗上丝世丗丌;
        if(val_23 != null)
        {
                val_23 = GameModeController.七丂丏丗上丝世丗丌;
            if(val_23 == null)
        {
                val_23 = 0;
        }
        
            val_23.Invoke();
        }
        
        this.丅三业世丐且丑丐丅.Stop();
        if(丅丈丌丅专丐丈丞东 != 0)
        {
                val_25 = 丅丈丌丅专丐丈丞东;
        }
        else
        {
                val_25 = this.东丈丆下丂丛丒丟专.与丟丙丛东丒丞万丆;
        }
        
        this.下丕世且不丄丂且丏();
        this.东丗丄与丒丂下且丆 = false;
        if(PlayerBotsManager.与一丅丝不丈业与丙() != 0)
        {
                PlayerBotsManager.与一丅丝不丈业与丙().丙丏专丞丗东丗世丞();
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() != true)
        {
                if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
            goto label_39;
        }
        
        }
        
        val_21 = 1152921505286238208;
        val_26 = null;
        val_26 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_27 = null;
            val_27 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                label_39:
            丑业世且丕丟丞丙万 val_15 = new 丑业世且丕丟丞丙万();
            val_15.下万丆七丙下与丂丞(丞丙下万丗丝丄七丝:  this.东丈丆下丂丛丒丟专, 丒丝下丙万丟丂世丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
            if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                this.东世东丞业万丙不丞 = val_15;
        }
        
            if(GameConnect.丑丌丛丈丅丅与不业() == 29)
        {
                val_28 = null;
            val_28 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_61;
        }
        
        }
        
        }
        
        }
        
        }
        
        label_80:
        丑七丕丛丐丌七丙丄.下万丆七丙下与丂丞(丞丙下万丗丝丄七丝:  this.东丈丆下丂丛丒丟专, 三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
        上业丕丘丈与丟丝丝.丛丆专七丛且丈丈万(丞丙下万丗丝丄七丝:  this.东丈丆下丂丛丒丟专, 三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_61:
        bool val_19 = GameController.onlineMode.丞一三业与丄丅丈丁();
        if(丅丈丌丅专丐丈丞东 != null)
        {
                var val_20 = (null != null) ? 1 : 0;
        }
        else
        {
                val_29 = 1;
        }
        
        if((val_29 & 1) == 0)
        {
            goto label_71;
        }
        
        this.东丈丆下丂丛丒丟专.丄上丐丞上一专丑丛 = false;
        goto label_80;
        label_71:
        this.东丈丆下丂丛丒丟专.丄上丐丞上一专丑丛 = true;
        goto label_80;
    }
    public static void add_OnEndRound(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GameModeController.一丘业丘丁专丗丂且, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.一丘业丘丁专丗丂且 != 1152921505189756968);
    
    }
    public static void remove_OnEndRound(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GameModeController.一丘业丘丁专丗丂且, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameModeController.一丘业丘丁专丗丂且 != 1152921505189756968);
    
    }
    public virtual void GlobalEndMod(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        object val_4 = this;
        List.Enumerator<T> val_1 = this._listConditionGlobalEndRoudn.GetEnumerator();
        label_4:
        if(((-1478047688) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<BaseConditionEndRound> val_3 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1D0);
        0.丐丏七丌丕丗业且上().丏丘丗丝丂丛丟丐丝(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 世丗丅丆丈丟丒丁世()
    {
        var val_3;
        object val_9 = this;
        this.业丁丂丆丕丝三丐丆();
        List.Enumerator<T> val_1 = this._listConditionEndRoudn.GetEnumerator();
        label_4:
        if(((-1477894736) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<BaseConditionEndRound> val_5 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1C0);
        val_3.丐丏七丌丕丗业且上().丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_6 = this._listConditionGlobalEndRoudn.GetEnumerator();
        label_13:
        if(((-1477894736) & 1) == 0)
        {
            goto label_11;
        }
        
        System.Action<BaseConditionEndRound> val_8 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1D0);
        val_3.丐丏七丌丕丗业且上().丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  null);
        goto label_13;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal virtual void 丝丐不东一一丁丌七()
    {
        System.Diagnostics.Stopwatch val_3;
        this.世丗丅丆丈丟丒丁世();
        if((GameConnect.丑丌丛丈丅丅与不业() != 30) || (this.丘下丗丁丕丛丟丅丕 == false))
        {
            goto label_4;
        }
        
        val_3 = this.丅三业世丐且丑丐丅;
        this.丘下丗丁丕丛丟丅丕 = false;
        if(val_3 != null)
        {
            goto label_10;
        }
        
        goto label_6;
        label_4:
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
            goto label_9;
        }
        
        val_3 = this.丅三业世丐且丑丐丅;
        if(val_3 != null)
        {
            goto label_10;
        }
        
        label_6:
        label_10:
        val_3.Reset();
        this.丅三业世丐且丑丐丅.Start();
        label_9:
        GameModeController.丝丘丟丑三不世丄丆();
        if(this.三丗丝丕业丞丆丅下 == null)
        {
                return;
        }
        
        this.三丗丝丕业丞丆丅下.Invoke();
    }
    internal virtual void 且丗且丏丟丙丅三丏()
    {
        if(this.丒且丒不丈丝丘丝丐 == null)
        {
                return;
        }
        
        this.丒且丒不丈丝丘丝丐.Invoke();
    }
    internal virtual void 丕且丅丞世三不七万()
    {
        if(this.丒丕丌一丌丘专三丛 == null)
        {
                return;
        }
        
        this.丒丕丌一丌丘专三丛.Invoke();
    }
    internal virtual bool 世丕丘不丁东与世丞()
    {
        return true;
    }
    internal virtual bool 专丝上丟丆丝丙丄丈()
    {
        return true;
    }
    internal void 丟丛专七不七丆三万()
    {
        if((this & 1) == 0)
        {
                return;
        }
        
        goto typeof(GameModeController).__il2cppRuntimeField_258;
    }
    protected void 上不丒丄世丞丈丙三()
    {
        this.不与世丆丟丞不丅丘 = true;
        this.下丒丕丟丅丘丈丞丑 = UnityEngine.Time.frameCount;
    }
    public virtual void OnDisconnect()
    {
        this.业丁丂丆丕丝三丐丆();
    }
    protected virtual void Destroy()
    {
        this.业丁丂丆丕丝三丐丆();
    }
    protected void 业丁丂丆丕丝三丐丆()
    {
        var val_3;
        List.Enumerator<T> val_1 = this._listConditionEndRoudn.GetEnumerator();
        label_7:
        if(((-1476660064) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_7;
        }
        
        System.Action<BaseConditionEndRound> val_6 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1C0);
        val_4.丏丘丗丝丂丛丟丐丝(丙业与丙丗丝不丈东:  null);
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_7 = this._listConditionGlobalEndRoudn.GetEnumerator();
        label_21:
        if(((-1476660064) & 1) == 0)
        {
            goto label_16;
        }
        
        string val_8 = val_3.丐丏七丌丕丗业且上();
        if(val_8 == 0)
        {
            goto label_21;
        }
        
        System.Action<BaseConditionEndRound> val_10 = new System.Action<BaseConditionEndRound>(object:  this, method:  typeof(GameModeController).__il2cppRuntimeField_1D0);
        val_8.丏丘丗丝丂丛丟丐丝(丙业与丙丗丝不丈东:  null);
        goto label_21;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal virtual void 丁三丅东三丅丄丘丙()
    {
    
    }
    protected virtual void 丕丗东且一且且丘丂()
    {
    
    }
    private void OnDestroy()
    {
        goto typeof(GameModeController).__il2cppRuntimeField_238;
    }
    private void Update()
    {
        var val_6;
        var val_7;
        if(this.不与世丆丟丞不丅丘 == false)
        {
                return;
        }
        
        if(this.下丒丕丟丅丘丈丞丑 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                if(GameConnect.丆丁上丟丛业丄丅丝() != false)
        {
                val_7 = null;
            val_7 = null;
            var val_4 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + OnlineModeController.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_7) ? (this) : 0;
            if(((GameModeController.__il2cppRuntimeField_typeHierarchy + OnlineModeController.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_7 ? this : 0 + 352.丘丑丅三丆丑丌且丝()) < 1)
        {
                return;
        }
        
        }
        
        }
        
        this.不与世丆丟丞不丅丘 = false;
        this.丟丛专七不七丆三万();
    }
    protected virtual void 丟不东丌丕不丐专业()
    {
    
    }
    private void LateUpdate()
    {
        goto typeof(GameModeController).__il2cppRuntimeField_278;
    }
    protected virtual void 丅丙与东丏丂丑丄丆()
    {
    
    }
    internal void 丑与世丙与丗丛且丆()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丑与世丙与丗丛且丆(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    protected System.Collections.IEnumerable 丑与世丙与丗丛且丆(float 丕丕世且下一与丝与)
    {
        GameModeController.与丙三丁丑东丛不丕 val_1 = new GameModeController.与丙三丁丑东丛不丕();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    protected void 下丕世且不丄丂且丏()
    {
        var val_22;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_23;
        丁丁丒丆不丒下丟三 val_24;
        丁丁丒丆不丒下丟三 val_25;
        int val_26;
        int val_27;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_28;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_29;
        var val_30;
        var val_31;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        bool val_37;
        bool val_38;
        bool val_5 = false;
        if(this.东丈丆下丂丛丒丟专.丟不世三丘与丆丘丂 != false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_23 != null)
        {
                val_23 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_23 == null)
        {
                val_23 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_23.丌不丅不丞东万专专();
            val_24 = val_1.HasValue.丙东专丂世丈丏丁丂();
            if((val_24 == 4) && (((-1475396552) & 1) != 0))
        {
                this.世七丈丑丘丞丝不丘();
            return;
        }
        
            val_22 = null;
        }
        
        val_25 = this.东丈丆下丂丛丒丟专;
        if(val_25 == null)
        {
            goto label_15;
        }
        
        val_26 = this.东丈丆下丂丛丒丟专.且七丙丁与丌丗与上;
        goto label_16;
        label_15:
        val_26 = this.东丈丆下丂丛丒丟专.且七丙丁与丌丗与上;
        if(this.东丈丆下丂丛丒丟专 == null)
        {
            goto label_17;
        }
        
        val_25 = this.东丈丆下丂丛丒丟专;
        label_16:
        val_27 = this.东丈丆下丂丛丒丟专.万且丒下丕丝专丟上;
        label_62:
        label_63:
        上丑丝丌七不丙丗丅 val_6 = 专上丈丌丒丁丒丆三.丁三丈丏丐业丘丏业(丒七世丈丌丑丏丄丏:  GameConnect.丑丌丛丈丅丅与不业(), 且丒丛与丞世丙丕丌:  val_26, 万且丒下丕丝专丟上:  val_27, 丂丌丙丝且东丗丙万:  this.东丈丆下丂丛丒丟专.丂丌丙丝且东丗丙万, 业东丞丏丒业万丏丘:  (this.东丈丆下丂丛丒丟专.丄上丐丞上一专丑丛 == true) ? 1 : 0, 丌丁业丅丕丁丈丌丅: out  val_5);
        val_28 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_28 == null)
        {
            goto label_20;
        }
        
        val_28 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_28 == null)
        {
                val_28 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_7 = val_28.丌不丅不丞东万专专();
        if(val_7.HasValue.丙东专丂世丈丏丁丂() != 3)
        {
            goto label_24;
        }
        
        val_29 = 0;
        if(((-1475396552) & 1) != 0)
        {
            goto label_28;
        }
        
        label_24:
        val_30 = null;
        val_30 = null;
        val_29 = GameConnect.丈丝丂丐丟万丙丑丕;
        goto label_28;
        label_20:
        val_29 = 0;
        label_28:
        val_31 = null;
        val_31 = null;
        val_32 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_32 == null)
        {
            goto label_31;
        }
        
        val_32 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_32 == null)
        {
                val_32 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_10 = val_32.丌不丅不丞东万专专();
        if((val_10.HasValue.丙东专丂世丈丏丁丂() != 3) || (((-1475396552) & 1) == 0))
        {
            goto label_36;
        }
        
        label_31:
        val_33 = 0;
        goto label_37;
        label_36:
        val_34 = null;
        val_34 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕.丘一丒丕丟万丏一丟() != false)
        {
                val_35 = null;
            val_35 = null;
            val_27 = GameConnect.丈丝丂丐丟万丙丑丕.三业丂丞丕东下七丒();
        }
        else
        {
                val_27 = 0;
        }
        
        val_36 = null;
        val_36 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕.丘一丒丕丟万丏一丟() != false)
        {
                val_37 = 0;
        }
        else
        {
                val_37 = this.东丈丆下丂丛丒丟专.丄上丐丞上一专丑丛;
        }
        
        val_37 = val_37 | val_27;
        bool val_15 = (val_37 == true) ? 1 : 0;
        label_37:
        if(val_5 != 0)
        {
            
        }
        else
        {
                上丑丝丌七不丙丗丅 val_16 = new PGCompany.GameModeEvents.下与丛丒丙一世丟专(与不下三丈专丘丂世:  val_29).东丁上丈东与下丅丅(三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false}, 丟且丄专丌丁丆丅丛:  false, 丑丆世丟万丁丆上丛:  val_15);
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_56;
        }
        
        val_24 = this.东丈丆下丂丛丒丟专;
        mem[1152921537491201068] = 0;
        var val_19 = (val_15 > 0) ? 1 : 0;
        goto label_58;
        label_56:
        val_24 = this.东丈丆下丂丛丒丟专;
        mem[1152921537491201068] = 0;
        if(val_24 == null)
        {
            goto label_59;
        }
        
        val_38 = false;
        label_58:
        this.东丈丆下丂丛丒丟专.不丁丛丈丙世丈万丟 = val_38;
        if(this.丅丁丈丟业上下丘东 > 0)
        {
                return;
        }
        
        if(this.丅丁丈丟业上下丘东.丆丒丘丐下丞丛上丈() > 0)
        {
                return;
        }
        
        return;
        label_17:
        if(this.东丈丆下丂丛丒丟专 != null)
        {
            goto label_62;
        }
        
        if(this.东丈丆下丂丛丒丟专 != null)
        {
            goto label_63;
        }
        
        label_59:
    }
    private void 世七丈丑丘丞丝不丘()
    {
        丁丁丒丆不丒下丟三 val_9;
        int val_10;
        int val_11;
        var val_12;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_13;
        var val_14;
        bool val_3 = false;
        val_9 = this.东丈丆下丂丛丒丟专;
        if(val_9 == null)
        {
            goto label_3;
        }
        
        val_10 = this.东丈丆下丂丛丒丟专.且七丙丁与丌丗与上;
        goto label_4;
        label_3:
        val_10 = this.东丈丆下丂丛丒丟专.且七丙丁与丌丗与上;
        if(this.东丈丆下丂丛丒丟专 == null)
        {
            goto label_5;
        }
        
        val_9 = this.东丈丆下丂丛丒丟专;
        label_4:
        label_20:
        label_21:
        val_11 = this.东丈丆下丂丛丒丟专.丂丌丙丝且东丗丙万;
        上丑丝丌七不丙丗丅 val_4 = 专上丈丌丒丁丒丆三.丁三丈丏丐业丘丏业(丒七世丈丌丑丏丄丏:  GameConnect.丑丌丛丈丅丅与不业(), 且丒丛与丞世丙丕丌:  val_10, 万且丒下丕丝专丟上:  this.东丈丆下丂丛丒丟专.万且丒下丕丝专丟上, 丂丌丙丝且东丗丙万:  val_11, 业东丞丏丒业万丏丘:  (this.东丈丆下丂丛丒丟专.丄上丐丞上一专丑丛 == true) ? 1 : 0, 丌丁业丅丕丁丈丌丅: out  val_3);
        if(val_3 != 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_13 == null)
        {
            goto label_11;
        }
        
        val_13 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_13 == null)
        {
                val_13 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_5 = val_13.丌不丅不丞东万专专();
        if(val_5.HasValue.丙东专丂世丈丏丁丂() != 3)
        {
            goto label_15;
        }
        
        val_10 = 0;
        if(((-1475128848) & 1) != 0)
        {
            goto label_19;
        }
        
        label_15:
        val_14 = null;
        val_14 = null;
        val_10 = GameConnect.丈丝丂丐丟万丙丑丕;
        goto label_19;
        label_5:
        val_11 = this.东丈丆下丂丛丒丟专;
        if(val_11 != null)
        {
            goto label_20;
        }
        
        if(this.东丈丆下丂丛丒丟专 != null)
        {
            goto label_21;
        }
        
        label_11:
        val_10 = 0;
        label_19:
        上丑丝丌七不丙丗丅 val_8 = new PGCompany.GameModeEvents.下与丛丒丙一世丟专(与不下三丈专丘丂世:  val_10).东丁上丈东与下丅丅(三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false}, 丟且丄专丌丁丆丅丛:  false, 丑丆世丟万丁丆上丛:  false);
    }
    protected virtual void 丛丒丒七丈丈下七丌(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        this.丝丆丒一下上下一丞 = this.东丈丆下丂丛丒丟专;
        if(this.东丗丄与丒丂下且丆 != false)
        {
                return;
        }
        
        this.东丈丆下丂丛丒丟专 = this;
        this.与丂丞丂丝丑丗丌丐();
        this.东丈丆下丂丛丒丟专.丑丒丂丗不丞丞不丄();
        this.东丈丆下丂丛丒丟专.丛一上丈世一丙丗世();
    }
    protected virtual 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        return (丁丁丒丆不丒下丟三)new 丁丁丒丆不丒下丟三();
    }
    internal virtual void 业专丏七丆丏丛七东(丁丁丒丆不丒下丟三 丑丝丑丟丏下丂万丝)
    {
        this.东丈丆下丂丛丒丟专 = 丑丝丑丟丏下丂万丝;
        this.东丗丄与丒丂下且丆 = true;
        goto typeof(GameModeController).__il2cppRuntimeField_1B8;
    }
    public GameModeController()
    {
        this.专丞上七七且丝七丗 = new 丒且丑丙专丟丗丏业();
        this._listConditionEndRoudn = new System.Collections.Generic.List<BaseConditionEndRound>();
        this._listConditionGlobalEndRoudn = new System.Collections.Generic.List<BaseConditionEndRound>();
        this.丅三业世丐且丑丐丅 = new System.Diagnostics.Stopwatch();
        this.丏专丝丞不丐东丟业 = new System.Diagnostics.Stopwatch();
        this.丘下丗丁丕丛丟丅丕 = true;
        this.IsUsePets = true;
        this.IsGadgetsPanelEnabled = true;
    }
    private static GameModeController()
    {
        GameModeController.丟七业丐丁七东丛丄 = new System.Collections.Generic.HashSet<System.String>();
    }

}
