using UnityEngine;
internal sealed class MonsterHunterModeController : OnlineModeController
{
    // Fields
    internal static string 七丁丈丐丐丁丁上下;
    internal static string 业丘与且丟丄上丒丐;
    internal static string 丅丗丙东上丅丘东丕;
    internal static string 丏下丒丒丄不丌专上;
    internal static int 且丕世丑万丙且下丐;
    internal static float 丞万丌丙丟丘丁七丗;
    internal static int 丕上丁业丙东丐业丙;
    internal static MonsterHunterModeController 丆丕丝丒不丙且丐丗;
    internal ModeStartCondition startCondition;
    private WorldPosIndicationItem_Distanced 东丄与丛丂丘丝三丝;
    private float 丅三丂一丟且上专丆;
    private Player_move_c 万七丗万丁丝下下丘;
    private bool 丟一丙丟不专三丕且;
    private bool 丟与丗丁丅一东东且;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    
    // Properties
    internal bool 丅业七丅上且不且万 { get; set; }
    internal static bool 与丝丈丏丕丐一专丑 { get; }
    internal static bool 丗丆丛丞丝不三丝专 { get; }
    
    // Methods
    internal bool 下丏丐丛丝丝丄万丒()
    {
        return (bool)this.丟与丗丁丅一东东且;
    }
    private void 丁丕丂丘丂丈丈丅世(bool 丙业与丙丗丝不丈东)
    {
        this.丟与丗丁丅一东东且 = 丙业与丙丗丝不丈东;
    }
    internal static bool 丝不且丛不丟丞丆与()
    {
        null = null;
        bool val_1 = System.String.IsNullOrEmpty(value:  MonsterHunterModeController.丅丗丙东上丅丘东丕);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal static bool 且业丞且丘丌丄丞丑()
    {
        null = null;
        bool val_1 = System.String.IsNullOrEmpty(value:  MonsterHunterModeController.丏下丒丒丄不丌专上);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public override void Initialize()
    {
        this.Initialize();
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MonsterHunterModeController::下丙丒丘七丛且不丗()));
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
    }
    private void 下丙丒丘七丛且不丗()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_2.丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        }
        
        val_2.丒丆且丑业世丅三上();
        mem[1152921537634502040] = 1;
        this.丟一丙丟不专三丕且 = false;
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_7;
        System.Collections.Generic.List<Player_move_c> val_8;
        var val_9;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        List.Enumerator<T> val_3 = val_8.GetEnumerator();
        label_17:
        if(((-1331967288) & 1) == 0)
        {
            goto label_10;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        var val_6 = (this.丟一丙丟不专三丕且 == true) ? 1 : 0;
        val_6 = val_4.丄丝丝下丟丘丄丒丈() ^ val_6;
        if(val_6 == false)
        {
            goto label_17;
        }
        
        val_9 = null;
        val_9 = null;
        val_4.万丑东上万丙业丁丑(丆丞丌东丐一丕一丄:  MonsterHunterModeController.丕上丁业丙东丐业丙);
        goto label_17;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    private void Awake()
    {
        var val_6;
        var val_7;
        System.Action<与丅丕丈丘东丝世丟> val_8;
        val_6 = null;
        val_6 = null;
        MonsterHunterModeController.丆丕丝丒不丙且丐丗 = this;
        this.丟与丗丁丅一东东且 = true;
        val_7 = null;
        val_7 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void MonsterHunterModeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_8 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_8;
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丙专丙一上丐世丐丁());
    }
    internal override void 丝丐不东一一丁丌七()
    {
        this.丝丐不东一一丁丌七();
        TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if((X8 != 0) && ((X8 + 32) != 0))
        {
                X20.丒丆且丑业世丅三上();
            this.上不丒丄世丞丈丙三();
            return;
        }
        
        X20.ShowStartInterface();
        this.丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  true);
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        this.下世丁丟丏丆丛丅丛();
        this.三丗丞丐丄与专丂丆();
        this.丘丁上且不丟丟三世();
    }
    private System.Collections.IEnumerator 丙专丙一上丐世丐丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MonsterHunterModeController.三万丑下丌丌与丂专();
    }
    private void 丘丁上且不丟丟三世()
    {
        ModeStartCondition val_15;
        var val_16;
        string val_17;
        val_15 = this.startCondition;
        if(val_15 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_15 = 0;
        val_16 = 1;
        goto label_3;
        label_2:
        val_16 = 0;
        label_3:
        if(val_15.丟丛万丅业丛且不丂() == false)
        {
            goto label_4;
        }
        
        float val_3 = UnityEngine.Mathf.Max(a:  0f, b:  val_15.丝丒不万丑丙丏丆上());
        if((val_3 >= 0) || (val_15.丈丁丆丆丁一丅丝丒() == false))
        {
            goto label_10;
        }
        
        val_17 = this.丗丏与丂世丝丐丁且;
        goto label_12;
        label_4:
        val_17 = this.专丁丈丛丂上丟上一;
        goto label_12;
        label_10:
        object[] val_5 = new object[4];
        val_5[0] = this.丌业下与丗东丈丌丑;
        float val_6 = val_3 / 60f;
        val_5[1] = UnityEngine.Mathf.FloorToInt(f:  val_6);
        var val_15 = 60;
        val_15 = (UnityEngine.Mathf.FloorToInt(f:  val_6)) * val_15;
        float val_16 = (float)val_15;
        val_16 = val_3 - val_16;
        val_5[2] = ((UnityEngine.Mathf.FloorToInt(f:  val_16)) < 10) ? "0" : "";
        var val_17 = 60;
        val_17 = (UnityEngine.Mathf.FloorToInt(f:  val_6)) * val_17;
        float val_18 = (float)val_17;
        val_18 = val_3 - val_18;
        val_5[3] = UnityEngine.Mathf.FloorToInt(f:  val_18);
        val_17 = System.String.Format(format:  "{0} {1}:{2}{3}", args:  val_5);
        label_12:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        text = val_17;
    }
    internal void 三业业七不东丌丁专(Player_move_c 专丞上七七且丝七丗)
    {
        Player_move_c val_4;
        if(this.万七丗万丁丝下下丘 == 专丞上七七且丝七丗)
        {
                return;
        }
        
        val_4 = this.万七丗万丁丝下下丘;
        if(val_4 != 0)
        {
                val_4 = this.万七丗万丁丝下下丘;
            if(val_4.丄丝丝下丟丘丄丒丈() != false)
        {
                val_4 = this.万七丗万丁丝下下丘;
            val_4.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  "", 三丛丄一东丑丁且业:  27, 丘万丟丕与专丁三丘:  0f, 丆丅丅丂下丏丏丞丂:  0);
        }
        
        }
        
        this.万七丗万丁丝下下丘 = 专丞上七七且丝七丗;
        专丞上七七且丝七丗.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  "", 三丛丄一东丑丁且业:  25, 丘万丟丕与专丁三丘:  0f, 丆丅丅丂下丏丏丞丂:  0);
    }
    private void 丙丟丌七丏丞且丐丈()
    {
        var val_12;
        var val_13;
        var val_14;
        System.Collections.Generic.List<Player_move_c> val_15;
        var val_16;
        var val_17;
        var val_18;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(this.万七丗万丁丝下下丘 != 0)
        {
            goto label_17;
        }
        
        val_12 = 0;
        goto label_7;
        label_16:
        val_13 = null;
        val_13 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丄丝丝下丟丘丄丒丈() == true)
        {
            goto label_12;
        }
        
        val_12 = 1;
        label_7:
        val_14 = null;
        val_14 = null;
        val_15 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_12 < val_15.Count)
        {
            goto label_16;
        }
        
        goto label_17;
        label_12:
        val_16 = null;
        val_16 = null;
        val_15 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        this.万七丗万丁丝下下丘 = val_15.Item[0];
        label_17:
        if(this.万七丗万丁丝下下丘 != 0)
        {
                return;
        }
        
        val_15 = 1152921505189965824;
        val_17 = null;
        val_17 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count < 1)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        this.三业业七不东丌丁专(专丞上七七且丝七丗:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[UnityEngine.Random.Range(min:  0, max:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)]);
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        var val_6 = null;
        double val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if((System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丝下世丄业丕丑七])) >= 0)
        {
                return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        }
        
        return false;
    }
    internal override void 下丕丂业业丐丗与丁(丕丁丕上与丅不丙丄 与丆丌丂丟丛丘丑且)
    {
        this.下丕丂业业丐丗与丁(与丆丌丂丟丛丘丑且:  与丆丌丂丟丛丘丑且);
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        System.TimeSpan val_1 = X21.Elapsed;
        System.TimeSpan val_3 = X21.Elapsed;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丈东丄丌丅丝不丂丘(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  X23 + 118, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.万七丗万丁丝下下丘 == 0)
        {
                return;
        }
        
        this.万七丗万丁丝下下丘.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  专丞上七七且丝七丗, 丂丛丆万丁丆下三丘:  "", 三丛丄一东丑丁且业:  25, 丘万丟丕与专丁三丘:  0f, 丆丅丅丂下丏丏丞丂:  0);
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        this.万七丗万丁丝下下丘.七丘下业丑丝上万丗(三丈一丑丕世万丁丙:  专丞上七七且丝七丗);
    }
    protected override void Destroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        this.Destroy();
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void MonsterHunterModeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    private void 下世丁丟丏丆丛丅丛()
    {
        string val_9;
        InGameGUI val_10;
        float val_11;
        val_9 = 1152921504848912384;
        val_10 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_10 == 0)
        {
                return;
        }
        
        val_11 = 0f;
        if(this.万七丗万丁丝下下丘 != 0)
        {
                val_11 = this.万七丗万丁丝下下丘.业下与上与不丞且丒() / this.万七丗万丁丝下下丘.丐一丕不丙东丄万万;
        }
        
        float val_9 = 100f;
        val_9 = val_11 * val_9;
        val_10 = System.String.Format(format:  "{0}{1}", arg0:  (int)val_9, arg1:  "%");
        val_9 = "Key_11086";
        if(this.万七丗万丁丝下下丘 != 0)
        {
                if(this.万七丗万丁丝下下丘.丟丌下三七丁与丟丑() == false)
        {
            goto label_13;
        }
        
        }
        
        InGameGUIPart_MonsterHunter.__il2cppRuntimeField_byval_arg.且丞丆与万世万丌丟();
        return;
        label_13:
        UnityEngine.Color val_8 = UnityEngine.Color.red;
        InGameGUIPart_MonsterHunter.__il2cppRuntimeField_byval_arg.丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  val_11, 上丕丈丞丌丘丅不与:  val_10, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a}, 丘丏丑丁专上世丄不:  true, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9), 三世丏且丑下专丟丟:  "");
        InGameGUIPart_MonsterHunter.__il2cppRuntimeField_byval_arg.丙上丟丏且丐丌不丒(丗与丘不且万丟丙丑:  val_11, 上丕丈丞丌丘丅不与:  val_10);
    }
    internal void 业丘丘丏丄丏不丂上(Player_move_c 专丞上七七且丝七丗)
    {
        this.万七丗万丁丝下下丘 = 专丞上七七且丝七丗;
        this.丟与丗丁丅一东东且 = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丗丏丄丛丄七丏丌东());
    }
    private System.Collections.IEnumerator 丗丏丄丛丄七丏丌东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MonsterHunterModeController.业丒丒业下且丟业丗();
    }
    internal void 专东丗三丛丅丘世世()
    {
        if(this.东丄与丛丂丘丝三丝 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.东丄与丛丂丘丝三丝.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 三丗丞丐丄与专丂丆()
    {
        var val_3;
        if(this.东丄与丛丂丘丝三丝 == 0)
        {
                return;
        }
        
        if(this.东丄与丛丂丘丝三丝 != null)
        {
            
        }
        else
        {
                val_3 = 80;
        }
        
        this.东丄与丛丂丘丝三丝.上丄丐丅三丄三丈丘(丛与丙丒丒下丌丟且:  (val_3 != 0) ? 1 : 0);
    }
    internal bool 丞一三业与丄丅丈丁()
    {
        if(this.万七丗万丁丝下下丘 == 0)
        {
                return false;
        }
        
        if(this.万七丗万丁丝下下丘 != null)
        {
                return this.万七丗万丁丝下下丘.丟丌下三七丁与丟丑();
        }
        
        return this.万七丗万丁丝下下丘.丟丌下三七丁与丟丑();
    }
    private bool 丁七丝丌且丈丗上上()
    {
        return (bool)this.丟一丙丟不专三丕且;
    }
    private bool 丅丕万业丄丏不丄丂()
    {
        if(this.丟与丗丁丅一东东且 == false)
        {
                return UnityEngine.Object.op_Equality(x:  this.万七丗万丁丝下下丘, y:  0);
        }
        
        return false;
    }
    protected override void 丛丒丒七丈丈下七丌(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        this.丛丒丒七丈丈下七丌(东且丁丆丛丁丏丘且:  东且丁丆丛丁丏丘且);
    }
    internal void 丑一丟丝不万丂丈丛()
    {
        this.丟一丙丟不专三丕且 = true;
        this.万七丗万丁丝下下丘 = 0;
    }
    internal override bool 丄一下丒七丝与与万()
    {
        var val_5;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().业丆丛丁丈丌丘丛丅() ^ 1;
            return (bool)val_5 & 1;
        }
        
        val_5 = 0;
        return (bool)val_5 & 1;
    }
    internal bool 丅三丘丞丈丑丄丌丘()
    {
        var val_6 = null;
        bool val_3 = 丄丝丝下丟丘丄丒丈();
        bool val_5 = ((this.丟一丙丟不专三丕且 == true) ? 1 : 0) ^ val_3;
        val_5 = val_5 | (this.丅丕万业丄丏不丄丂() & (~val_3));
        val_3 = val_5;
        return (bool)val_3;
    }
    internal bool 丒丈三三东丟丒丕下()
    {
        if(this.丟一丙丟不专三丕且 == false)
        {
                return this.丅丕万业丄丏不丄丂();
        }
        
        return true;
    }
    public MonsterHunterModeController()
    {
        this.丅三丂一丟且上专丆 = 1.5f;
    }
    private static MonsterHunterModeController()
    {
        MonsterHunterModeController.七丁丈丐丐丁丁上下 = "gadget_mh_mech1";
        MonsterHunterModeController.业丘与且丟丄上丒丐 = "MonsterHunterMechBody";
        MonsterHunterModeController.丅丗丙东上丅丘东丕 = "";
        MonsterHunterModeController.丏下丒丒丄不丌专上 = "";
        MonsterHunterModeController.且丕世丑万丙且下丐 = 29;
        MonsterHunterModeController.丞万丌丙丟丘丁七丗 = 0.28f;
        MonsterHunterModeController.丕上丁业丙东丐业丙 = 50;
    }

}
