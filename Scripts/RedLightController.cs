using UnityEngine;
internal sealed class RedLightController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    public static RedLightController Instance;
    public UnityEngine.Transform startPoint;
    public UnityEngine.Transform finishPoint;
    public RedLightDoll doll;
    public RedLightSoundSystem soundSystem;
    public double matchTime;
    public double maxRunningTime;
    public double minRunningTime;
    public double maxStoppingTime;
    public double minStoppingTime;
    public double stoppingDamageDelay;
    public double damageAmount;
    public double damageFrequency;
    public int minTrapsPercent;
    public int maxTrapsPercent;
    public float jumpCoef;
    public float speedCoef;
    public double stopSafeTime;
    public double inertionCoef;
    private bool 丄丗丆丆且且万一上;
    private bool 丟下七丐与丟丒丐丞;
    private int 丈丏与丅丏丘丟七万;
    private float 一万丐丘不下丟丕丙;
    internal double 七丙丟万丏与丆丆丂;
    private string[] 丒丈丗丟丌丆三丑丟;
    private string[] 七丒丛东丌丄万万丝;
    private bool 丛丝丕与丕专东且丂;
    private float 丒丕丂上世下一丝与;
    private float 丑丛丒丐丂丒不万丁;
    private double 丗丞丁丟丄丆上丒下;
    private System.Collections.Generic.List<double> 丒万丟与一万万下丒;
    public System.Collections.Generic.List<TrapsSector> trapsSectors;
    private float 丅一万丝丕丂三且下;
    private float 丌下丘丁丌丄业丈丑;
    private bool 丛且丏丘丂专丙丙下;
    private bool 上丈与与丛丘丗丝丒;
    private int 丄七丆丗东不丅丆丌;
    private float 丄丒世丝丘世丌丗丁;
    internal float 丂丝丈丙丞丝三丂一;
    private int 业丒丂丈丘专一东丏;
    private RedLightController.万与专世三世丝业丏 且丆丝世上丐上不万;
    private bool 丅丕丞丂丑丞丅丑不;
    private float 丝上七万上丄专丟丘;
    private RedLightController.与丂万三七丗丗丒丒 丙丆丂丏丕专丅业丝;
    internal System.Collections.Generic.Dictionary<string, 丈万且丗丂丝丙一东> 上丄丈丙丐丘丙丁与;
    
    // Properties
    internal float 丌与丁不下丅丆丘丞 { get; }
    private double 丟且七丌丄专丅丁丌 { get; }
    private int 且三丗丘一丈丌丌且 { get; }
    private double 专丘丄世与丟丆一世 { get; }
    public bool 下丝不一丕世且丐下 { get; }
    internal static int 丆丕丌业丗专七世丒 { get; }
    public bool 上丗丂与丝丂万丆丞 { get; }
    public double 丏丟世丑丆世丆丌专 { get; }
    internal bool 丌丄与丈丑丌上专丝 { get; }
    internal static bool 丝丁丄丂丛下业不下 { get; }
    internal bool 丌丏专丈丐丟丕丞专 { get; }
    private double 业下丄丟丞丙一一一 { get; }
    internal RedLightController.万与专世三世丝业丏 丟丄一不丕一东世东 { get; }
    internal bool 万丕丘丙丆下丈丘丏 { get; }
    internal bool 丌丟业丙万上丈丒且 { get; }
    internal string 丝不上丞上丝一丈万 { get; }
    internal bool 丕丝专丗业上丁丆丗 { get; }
    internal bool 万丗上丄丞专上丅丝 { get; }
    internal RedLightController.与丂万三七丗丗丒丒 丏东丛丑丝世丙下丅 { get; }
    
    // Methods
    internal float 丙世丑丅丒丑业与不()
    {
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = this.且不丘丆与上东丆丐() - val_2;
        return (float)(float)val_2;
    }
    private double 业丙万业上且且世丙()
    {
        if(this.且不丘丆与上东丆丐() <= 0f)
        {
                return -1;
        }
        
        double val_3 = this.且不丘丆与上东丆丐();
        val_3 = val_3 - this.matchTime;
        val_3 = val_3 - this.丗丞丁丟丄丆上丒下;
        val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - val_3;
        return -1;
    }
    private int 与丕不与丆丑丄丈丆()
    {
        var val_5;
        System.Collections.Generic.List<System.Double> val_6;
        double val_2 = this.业丙万业上且且世丙() - this.丗丞丁丟丄丆上丒下;
        if(val_2 <= 0f)
        {
                return 0;
        }
        
        val_5 = 0;
        double val_5 = 0;
        goto label_2;
        label_6:
        val_6 = this.丒万丟与一万万下丒;
        val_5 = val_5 + val_6.Item[0];
        if(val_2 <= val_5)
        {
                return 0;
        }
        
        val_5 = 1;
        label_2:
        val_6 = this.丒万丟与一万万下丒;
        if(val_5 < val_6.Count)
        {
            goto label_6;
        }
        
        return 0;
    }
    private double 丑丝丌丘世与丞上下()
    {
        double val_7;
        System.Collections.Generic.List<System.Double> val_8;
        val_7 = -1;
        double val_2 = this.业丙万业上且且世丙() - this.丗丞丁丟丄丆上丒下;
        if(val_2 <= 0f)
        {
                return (double)val_7;
        }
        
        var val_6 = 0;
        double val_5 = 0;
        do
        {
            val_8 = this.丒万丟与一万万下丒;
            if(val_6 >= val_8.Count)
        {
                return (double)val_7;
        }
        
            val_8 = this.丒万丟与一万万下丒;
            val_5 = val_5 + val_8.Item[0];
            val_6 = val_6 + 1;
        }
        while(val_2 > val_5);
        
        val_7 = val_5 - val_2;
        return (double)val_7;
    }
    internal void 丅丕丛丑三世丅世东()
    {
        this.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  this.世业丗丄丁丝丒一丁());
    }
    private void 丑丛七七丒万丆丑丘(bool 下丁丞丝丛一丘丐丒)
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                下丁丞丝丛一丘丐丒 = 下丁丞丝丛一丘丐丒;
            typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.SetStatusMessageContainer(下丁丞丝丛一丘丐丒:  下丁丞丝丛一丘丐丒);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        SetStatusMessageContainer(下丁丞丝丛一丘丐丒:  下丁丞丝丛一丘丐丒);
    }
    private void 七不丏东丐且业丄丞()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.ShowMessagePreStart();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessagePreStart();
    }
    private void 丒丐丂丂三且丕丈丛()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.ShowMessageStop();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageStop();
    }
    private void 丏上不专万丌丗丄下()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.HideMessageStop();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        HideMessageStop();
    }
    private void 丗丗一丕下丑丂丆丘()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.ShowMessageRun();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageRun();
    }
    private void 丐丝世丅丑丞东与丆()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.HideMessageRun();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        HideMessageRun();
    }
    private void 世丟东丝丂丒与丈下(RedLightController.万与专世三世丝业丏 且丆丝世上丐上不万)
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.ShowMessageNowYouDied(且丆丝世上丐上不万:  且丆丝世上丐上不万);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageNowYouDied(且丆丝世上丐上不万:  且丆丝世上丐上不万);
    }
    private void 丂丕丐一东七七丏丂(int 且七丙丁与丌丗与上)
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.ShowMessageYouScored(且七丙丁与丌丗与上:  且七丙丁与丌丗与上);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageYouScored(且七丙丁与丌丗与上:  且七丙丁与丌丗与上);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    private void Awake()
    {
        var val_7;
        System.Action<ExitGames.Client.Photon.Hashtable> val_8;
        RedLightController.Instance = this;
        this.丛丝丕与丕专东且丂 = false;
        if(GameConnect.一业上七丟业且业丙() != false)
        {
                this.丑丛丒丐丂丒不万丁 = UnityEngine.Random.Range(min:  0.2f, max:  0.65f);
            this.FillAllValues();
            this.丙丏万不下丑万业下();
            this.且上丟上丁丛丏上丏();
            this.一专丅丗丐丒东丂丈();
            RedLightController.Instance = this;
            val_7 = null;
            val_7 = null;
            if(((System.Delegate.Combine(a:  GameConnect.世丄丄与丌业丑丕丈, b:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void RedLightController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_8 = 0;
        }
        
            GameConnect.世丄丄与丌业丑丕丈 = val_8;
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void 一专丅丗丐丒东丂丈()
    {
        var val_5;
        System.String[] val_6;
        var val_7;
        val_5 = 0;
        this.七丒丛东丌丄万万丝 = new string[0];
        goto label_2;
        label_12:
        val_6 = this.七丒丛东丌丄万万丝;
        string val_5 = this.丒丈丗丟丌丆三丑丟[0];
        if(val_6 == null)
        {
            goto label_5;
        }
        
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_5 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_5 = 1;
        val_6[0] = val_5;
        label_2:
        if(val_5 < this.丒丈丗丟丌丆三丑丟.Length)
        {
            goto label_12;
        }
        
        val_7 = 0;
        goto label_13;
        label_32:
        string val_6 = this.七丒丛东丌丄万万丝[0];
        if(this.七丒丛东丌丄万万丝 == null)
        {
            goto label_16;
        }
        
        label_27:
        int val_4 = this.七丒丛东丌丄万万丝.Length - 1;
        this.七丒丛东丌丄万万丝[0] = this.七丒丛东丌丄万万丝[-145977872];
        val_6 = this.七丒丛东丌丄万万丝;
        if(val_6 == null)
        {
            goto label_23;
        }
        
        if(val_6 != null)
        {
            goto label_24;
        }
        
        goto label_29;
        label_16:
        if((new System.Random(Seed:  RedLightController.一一丕丏丈世丞世丟())) != null)
        {
            goto label_27;
        }
        
        goto label_27;
        label_23:
        if(val_6 == null)
        {
            goto label_29;
        }
        
        label_24:
        label_29:
        val_7 = 1;
        val_6[-145977872] = val_6;
        label_13:
        if(val_7 < this.七丒丛东丌丄万万丝.Length)
        {
            goto label_32;
        }
    
    }
    public void FillAllValues()
    {
        var val_17;
        var val_18;
        object val_19;
        var val_20;
        val_17 = null;
        val_17 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丂丆丏丄丝丆丂丕三)) != false)
        {
                val_18 = null;
            val_18 = null;
            val_19 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丂丆丏丄丝丆丂丕三];
        }
        else
        {
                val_19 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  143);
            ExitGames.Client.Photon.Hashtable val_9 = new ExitGames.Client.Photon.Hashtable();
            val_20 = null;
            val_20 = null;
            val_9.set_Item(key:  GameConnect.丂丆丏丄丝丆丂丕三, value:  val_19);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        this.丟下七丐与丟丒丐丞 = true;
        if(DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝() != null)
        {
                this.matchTime = 1;
            this.maxRunningTime = true;
            this.minRunningTime = true;
            this.maxStoppingTime = true;
            this.minStoppingTime = true;
            this.stoppingDamageDelay = true;
            this.damageAmount = true;
            this.damageFrequency = true;
            this.minTrapsPercent = true;
            this.maxTrapsPercent = true;
        }
        else
        {
                this.matchTime = 11993091;
            this.maxRunningTime = 1.41123013866014E-316;
            this.minRunningTime = 3.16202013338398E-322;
            this.maxStoppingTime = 6.71781809630125E-316;
            this.minStoppingTime = 1.33509863819657E-307;
            this.stoppingDamageDelay = 3.75487155418531E-308;
            this.damageAmount = 1.06099789553204E-313;
            this.damageFrequency = 0;
            this.minTrapsPercent = 0;
            this.maxTrapsPercent = 0;
        }
        
        this.jumpCoef = (11993091 > 0f) ? (val_11 + 92) : this.jumpCoef;
        this.speedCoef = (11993091 > 0f) ? (val_11 + 88) : this.speedCoef;
        this.stopSafeTime = (11993091 > 0f) ? (val_11 + 96) : this.stopSafeTime;
        this.inertionCoef = (11993091 > 0f) ? (val_11 + 104) : this.inertionCoef;
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<ExitGames.Client.Photon.Hashtable> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.世丄丄与丌业丑丕丈, value:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void RedLightController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_5;
        DestroyDamageableObjectConditionEndRound.__error = 0;
    }
    private void 丗丁丝下不七且丌不()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.HideAllMessages();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        HideAllMessages();
    }
    private void 丁丂下丙丐东丄三丞()
    {
        InGameGUI val_9;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丄丗丆丆且且万一上 == false)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丙丈丌下丒专丝丄七(且且与丛七丗上丛三:  false);
        this.丄丗丆丆且且万一上 = false;
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_25;
        }
        
        if(null == 0)
        {
            goto label_23;
        }
        
        InGameGUIPart_RedLight.__il2cppRuntimeField_byval_arg.gameObject.SetActive(value:  true);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_25;
        }
        
        label_23:
        gameObject.SetActive(value:  true);
        return;
        label_25:
    }
    private void 东一丟丌丏且一丞丌(RedLightController.与丂万三七丗丗丒丒 丝丝不丝上丂三丌世)
    {
        NetworkStartTable val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if(this.丙丆丂丏丕专丅业丝 == 丝丝不丝上丂三丌世)
        {
                return;
        }
        
        与丂万三七丗丗丒丒 val_1 = 丝丝不丝上丂三丌世 & 255;
        if(val_1 == 2)
        {
            goto label_2;
        }
        
        if(val_1 == 1)
        {
            goto label_3;
        }
        
        if(val_1 != 0)
        {
            goto label_41;
        }
        
        this.丈丏与丅丏丘丟七万 = 0;
        goto label_41;
        label_2:
        this.丄丗丆丆且且万一上 = false;
        if(this.丙丆丂丏丕专丅业丝 != 0)
        {
            goto label_8;
        }
        
        this.丗丁丝下不七且丌不();
        if((this.丈丏与丅丏丘丟七万 & 1) != 0)
        {
            goto label_7;
        }
        
        this.丗丗一丕下丑丂丆丘();
        goto label_8;
        label_3:
        val_3 = null;
        val_3 = null;
        ShowStartInterface();
        val_2 = mem[GameController.onlineMode + 352];
        val_2 = GameController.onlineMode.丟三丏丅世一丟丟上;
        丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  true);
        goto label_41;
        label_7:
        this.丒丐丂丂三且丕丈丛();
        label_8:
        if(this.丙丆丂丏丕专丅业丝 == 0)
        {
            goto label_16;
        }
        
        label_51:
        if(this.丙丆丂丏丕专丅业丝 > 1)
        {
            goto label_41;
        }
        
        this.丙丗三不丟丛万三且();
        goto label_41;
        label_16:
        if(this.丛且丏丘丂专丙丙下 != true)
        {
                if(this.上丈与与丛丘丗丝丒 == false)
        {
            goto label_20;
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        七丘丈丛世与丘万丝(丛与丙丒丒下丌丟且:  true);
        丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  0);
        if(this.上丈与与丛丘丗丝丒 == false)
        {
            goto label_27;
        }
        
        val_5 = null;
        val_5 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        丌丒世不与专丙一丈();
        label_41:
        this.丙丆丂丏丕专丅业丝 = 丝丝不丝上丂三丌世;
        return;
        label_27:
        val_6 = null;
        val_6 = null;
        if(null == 0)
        {
            goto label_41;
        }
        
        val_7 = null;
        val_7 = null;
        if(null != 0)
        {
            goto label_41;
        }
        
        goto label_41;
        label_20:
        val_8 = null;
        val_8 = null;
        if(null == 0)
        {
            goto label_51;
        }
        
        val_9 = null;
        val_9 = null;
        goto label_51;
    }
    private void 万一三丝丑丂不丗专()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_RedLight).__il2cppRuntimeField_28.HideMessagePreStart();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        HideMessagePreStart();
    }
    public bool get_isCurrentDelayStopper()
    {
        return (bool)this.丈丏与丅丏丘丟七万 & 1;
    }
    private void 丌丅丞且丝丁丏丘与(int 丏业七丆丁丟丅丄且)
    {
    
    }
    internal static int 一一丕丏丈世丞世丟()
    {
        var val_8;
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.七丝丕东丘丐丗不世)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丝丕东丘丐丗不世]);
    }
    public bool get_disableAnyMoving()
    {
        var val_4;
        if(RedLightController.丑不专七丗丛丅与丟() != false)
        {
                if(this.丑丛丒丐丂丒不万丁 < 0)
        {
            goto label_1;
        }
        
        }
        
        var val_3 = (this.goTimer > 0f) ? 1 : 0;
        return (bool)val_4;
        label_1:
        val_4 = 1;
        return (bool)val_4;
    }
    public double get_goTimer()
    {
        double val_2 = this.且不丘丆与上东丆丐();
        val_2 = (丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + this.matchTime) - val_2;
        val_2 = 0 - val_2;
        return (double)val_2;
    }
    internal bool 丗丒丕专丛丆丈万一()
    {
        return (bool)(this.goTimer <= 0f) ? 1 : 0;
    }
    internal static bool 丑不专七丗丛丅与丟()
    {
        RedLightController val_5;
        var val_6;
        if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_6;
        }
        
        val_5 = RedLightController.Instance;
        if(val_5 == 0)
        {
            goto label_6;
        }
        
        if(RedLightController.Instance.goTimer <= 0f)
        {
            goto label_10;
        }
        
        val_5 = RedLightController.Instance;
        if(RedLightController.Instance.丙丆丂丏丕专丅业丝 != 2)
        {
            goto label_10;
        }
        
        val_6 = 1;
        return (bool)val_6;
        label_6:
        val_6 = 0;
        return (bool)val_6;
        label_10:
        var val_4 = (RedLightController.Instance.丛丝丕与丕专东且丂 == true) ? 1 : 0;
        return (bool)val_6;
    }
    internal bool 七丌丌丐丘下丟丐丌()
    {
        var val_5;
        double val_2 = this.且不丘丆与上东丆丐();
        val_2 = val_2 + 1.5;
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + this.matchTime) < 0)
        {
                var val_4 = (this.丙丆丂丏丕专丅业丝 == 2) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private double 且不丘丆与上东丆丐()
    {
        string val_10;
        var val_11;
        var val_12;
        val_10 = this;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_11 = null;
            val_11 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.不丈与七丗丘下丌丅)) != false)
        {
                val_12 = null;
            val_12 = null;
            val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.不丈与七丗丘下丌丅];
            float val_8 = System.Single.Parse(s:  val_10);
            return (double)val_9;
        }
        
        }
        
        double val_9 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_9 = val_9 + this.matchTime;
        val_9 = val_9 + this.丗丞丁丟丄丆上丒下;
        return (double)val_9;
    }
    internal void 丕丞丁丐丌世世丞丈()
    {
        ExitGames.Client.Photon.Hashtable val_5;
        object val_6;
        var val_7;
        val_6 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_5 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_3 = val_3 + this.matchTime;
        val_3 = val_3 + this.丗丞丁丟丄丆上丒下;
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  val_3);
        val_6 = 2;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  2);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丙丏万不下丑万业下()
    {
        var val_8;
        double val_9;
        double val_10;
        System.Random val_2 = new System.Random(Seed:  RedLightController.一一丕丏丈世丞世丟());
        this.丒万丟与一万万下丒 = new System.Collections.Generic.List<System.Double>();
        val_8 = 0;
        double val_8 = 0;
        goto label_2;
        label_11:
        val_8 = 1;
        if(val_8 < 998)
        {
            goto label_2;
        }
        
        return;
        label_6:
        val_10 = this.maxStoppingTime;
        val_9 = this.minStoppingTime;
        if(val_2 != null)
        {
            goto label_7;
        }
        
        goto label_5;
        label_2:
        if((val_8 & 1) != 0)
        {
            goto label_6;
        }
        
        val_10 = this.maxRunningTime;
        val_9 = this.minRunningTime;
        if(val_2 != null)
        {
            goto label_7;
        }
        
        label_5:
        label_7:
        double val_4 = val_9 * 100;
        double val_5 = val_10 * 100;
        double val_7 = System.Math.Round(value:  (1.15292150460685E+18) * 0.01, digits:  2);
        val_8 = val_8 + val_7;
        this.丒万丟与一万万下丒.Add(item:  val_7);
        if(val_8 < this.matchTime)
        {
            goto label_11;
        }
    
    }
    private void 且上丟上丁丛丏上丏()
    {
        var val_26;
        var val_27;
        object val_28;
        int val_29;
        var val_30;
        object val_31;
        var val_32;
        object val_33;
        val_26 = this;
        if(this.trapsSectors == null)
        {
                return;
        }
        
        if(this.trapsSectors.Count == 0)
        {
                return;
        }
        
        val_27 = 1152921519068975536;
        val_28 = 0;
        goto label_3;
        label_59:
        TrapsSector val_4 = this.trapsSectors.Item[0];
        float val_26 = (float)val_4.traps.Length;
        val_26 = ((1.152922E+18f) * 0.01f) * val_26;
        TrapsSector val_6 = this.trapsSectors.Item[0];
        val_29 = (int)val_26;
        if(val_29 > val_6.traps.Length)
        {
                TrapsSector val_7 = this.trapsSectors.Item[0];
            val_29 = val_7.traps.Length;
        }
        
        System.Collections.Generic.List<UnityEngine.GameObject> val_8 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        val_30 = 0;
        goto label_15;
        label_24:
        TrapsSector val_9 = this.trapsSectors.Item[0];
        val_31 = 0;
        val_8.Add(item:  val_9.traps[val_31]);
        val_30 = 1;
        label_15:
        TrapsSector val_10 = this.trapsSectors.Item[0];
        if(val_30 < val_10.traps.Length)
        {
            goto label_24;
        }
        
        val_32 = 0;
        goto label_25;
        label_32:
        if(val_8 != null)
        {
                UnityEngine.GameObject val_11 = val_8.Item[0];
        }
        
        int val_14 = val_8.Count - 1;
        val_31 = new System.Random(Seed:  RedLightController.一一丕丏丈世丞世丟());
        if(val_8 != null)
        {
                val_8.set_Item(index:  0, value:  val_8.Item[-142963200]);
        }
        else
        {
                val_27 = val_27;
            val_26 = val_26;
            val_8.set_Item(index:  0, value:  val_8.Item[-142963200]);
        }
        
        val_8.set_Item(index:  -142963200, value:  val_8.Item[0]);
        val_32 = 1;
        label_25:
        if(val_32 < val_8.Count)
        {
            goto label_32;
        }
        
        val_33 = 0;
        goto label_33;
        label_57:
        if(val_8.Item[0] != 0)
        {
                val_8.Item[0].SetActive(value:  (val_33 < val_29) ? 1 : 0);
        }
        else
        {
                object[] val_22 = new object[4];
            val_22[0] = "Error - empty trap (traps sector ";
            val_22[1] = val_28;
            val_22[2] = ", index ";
            val_31 = val_33;
            val_22[3] = val_31;
            UnityEngine.Debug.LogError(message:  +val_22);
        }
        
        val_33 = 1;
        label_33:
        if(val_33 < val_8.Count)
        {
            goto label_57;
        }
        
        val_28 = val_28 + 1;
        label_3:
        if(val_28 < this.trapsSectors.Count)
        {
            goto label_59;
        }
    
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  22)) != false)
        {
                UnityEngine.Debug.LogError(message:  "GetModeAvatar = "("GetModeAvatar = ") + this.丞七丕且丈丙上万下());
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  24)) != false)
        {
                this.doll.PlayAttack();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  25)) == false)
        {
                return;
        }
        
        this.doll.PlayPeace();
    }
    private bool 丙三不三一丙东东丈(int 丕丕世且下一与丝与)
    {
        return (bool)((丕丕世且下一与丝与 & 1) != 0) ? 1 : 0;
    }
    private bool 一丟世丘丛丒东丐丟(int 丕丕世且下一与丝与)
    {
        return (bool)丕丕世且下一与丝与 & 1;
    }
    internal RedLightController.万与专世三世丝业丏 一且三万专东丏不丞()
    {
        return (万与专世三世丝业丏)this.且丆丝世上丐上不万;
    }
    internal bool 丙上七丗丁万丙丘不()
    {
        return (bool)this.丛且丏丘丂专丙丙下;
    }
    internal bool 一与丞丌丏一专丐丞()
    {
        return (bool)this.上丈与与丛丘丗丝丒;
    }
    private void 丙丏丞七丅丄且七上()
    {
        var val_12;
        float val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丙丆丂丏丕专丅业丝 != 2)
        {
            goto label_52;
        }
        
        double val_2 = this.goTimer;
        if(val_2 >= 0)
        {
            goto label_52;
        }
        
        val_12 = mem[null + 408 + 8];
        if(val_2 != 0f)
        {
                val_13 = 0f;
            val_12 = mem[null + 424 + 8];
        }
        
        double val_3 = this.goTimer;
        if((val_3 < 0) && (val_3 < 0))
        {
                val_13 = 1f;
        }
        
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_27;
        }
        
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_27;
        }
        
        val_16 = null;
        val_16 = null;
        var val_7 = (丘七业丒丐世丂丅丒() <= 0f) ? 1 : 0;
        goto label_32;
        label_27:
        val_17 = 0;
        label_32:
        if(this.goTimer > 0f)
        {
            goto label_52;
        }
        
        if(this.丛且丏丘丂专丙丙下 != true)
        {
                var val_9 = (this.上丈与与丛丘丗丝丒 == true) ? 1 : 0;
            val_9 = val_17 | val_9;
            if((val_9 & 1) == 0)
        {
                if(this.丂丝丈丙丞丝三丂一 <= 0f)
        {
            goto label_36;
        }
        
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_52;
        }
        
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_52;
        }
        
        val_20 = null;
        val_20 = null;
        label_36:
        this.丁丂下丙丐东丄三丞();
        return;
        label_52:
        this.丁一万丆与丝丑丞业();
    }
    private void Update()
    {
        int val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_40;
        var val_41;
        float val_42;
        var val_43;
        float val_44;
        UnityEngine.Transform val_45;
        float val_47;
        var val_48;
        float val_49;
        double val_50;
        var val_51;
        var val_52;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(this.丙丆丂丏丕专丅业丝 != 2)
        {
            goto label_9;
        }
        
        val_35 = 1152921505286238208;
        val_36 = null;
        val_36 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_9;
        }
        
        val_37 = null;
        val_37 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_38 = null;
            val_38 = null;
            if(丘七业丒丐世丂丅丒() > 0f)
        {
                if(RedLightController.丑不专七丗丛丅与丟() == false)
        {
            goto label_75;
        }
        
        }
        
        }
        
        val_40 = null;
        val_40 = null;
        if(null != 0)
        {
            goto label_75;
        }
        
        goto label_75;
        label_9:
        val_41 = 0;
        goto label_75;
        label_3:
        val_41 = 0;
        this.丙丆丂丏丕专丅业丝 = 0;
        label_75:
        val_1.丑丛七七丒万丆丑丘(下丁丞丝丛一丘丐丒:  (val_41 != 0) ? 1 : 0);
        this.丙丏丞七丅丄且七上();
        if(this.丙丆丂丏丕专丅业丝 != 2)
        {
                return;
        }
        
        this.UpdatePlayerScores();
        if(this.丛丝丕与丕专东且丂 != false)
        {
                val_42 = this.丒丕丂上世下一丝与;
            float val_7 = UnityEngine.Time.deltaTime;
            val_7 = val_42 + val_7;
            this.丒丕丂上世下一丝与 = val_7;
        }
        
        val_43 = null;
        val_43 = null;
        val_35 = this.丈丏与丅丏丘丟七万;
        if((val_35 & 1) == 0)
        {
                val_44 = 0f;
        }
        else
        {
                val_42 = this.一万丐丘不下丟丕丙;
            val_35 = this.丈丏与丅丏丘丟七万;
            val_44 = val_42 + UnityEngine.Time.deltaTime;
        }
        
        this.一万丐丘不下丟丕丙 = val_44;
        if(val_35 != this.与丕不与丆丑丄丈丆())
        {
            goto label_35;
        }
        
        if((this.丈丏与丅丏丘丟七万 & 1) == 0)
        {
            goto label_36;
        }
        
        goto label_45;
        label_35:
        val_35 = this.soundSystem;
        if((this.与丕不与丆丑丄丈丆() & 1) == 0)
        {
                val_42 = this.丑丝丌丘世与丞上下();
            val_44 = (float)val_42;
            val_35.PlayRunForTime(丂三丟丂丈丐丆丗丟:  val_44);
            val_35.丗丗一丕下丑丂丆丘();
        }
        else
        {
                val_35.PlayStop();
            val_35.丒丐丂丂三且丕丈丛();
        }
        
        int val_12 = this.与丕不与丆丑丄丈丆();
        this.丈丏与丅丏丘丟七万 = val_12;
        if((val_12 & 1) != 0)
        {
            goto label_45;
        }
        
        label_36:
        val_35 = this.doll;
        val_42 = this.丑丝丌丘世与丞上下();
        val_44 = 2;
        if(val_42 < 0)
        {
                val_35.PlayAttack();
        }
        else
        {
                val_35.PlayPeace();
        }
        
        label_45:
        if((this.丈丏与丅丏丘丟七万 & 1) != 0)
        {
                if(this.丙丆丂丏丕专丅业丝 == 2)
        {
            goto label_47;
        }
        
        }
        
        this.业丒丂丈丘专一东丏 = 0;
        label_47:
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_15 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        float val_35 = val_15.x;
        UnityEngine.Vector3 val_16 = this.startPoint.position;
        val_35 = val_35 - val_16.x;
        UnityEngine.Vector3 val_17 = this.finishPoint.position;
        val_45 = this.startPoint;
        float val_36 = val_17.x;
        UnityEngine.Vector3 val_18 = val_45.position;
        val_36 = val_36 - val_18.x;
        if((val_35 <= 0f) || (val_35 >= 0))
        {
            goto label_81;
        }
        
        val_44 = this.丅一万丝丕丂三且下;
        if(val_44 <= 0f)
        {
            goto label_58;
        }
        
        if((this.丈丏与丅丏丘丟七万 & 1) == 0)
        {
            goto label_59;
        }
        
        val_47 = this.丅一万丝丕丂三且下;
        if(UnityEngine.Time.time < val_47)
        {
            goto label_74;
        }
        
        this.丅一万丝丕丂三且下 = -1f;
        val_48 = typeof(Player_move_c).__il2cppRuntimeField_600;
        UnityEngine.Vector3 val_21 = this.transform.position;
        val_49 = val_21.z;
        val_44 = (float)RedLightController.Instance.damageAmount;
        val_47 = val_21.x;
        typeof(Player_move_c).__il2cppRuntimeField_600.ApplyDamage(丞丈专下丈专业三丞:  val_44, 丛世一丟丞丁业丘丒:  typeof(Player_move_c).__il2cppRuntimeField_600, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_47, y = val_21.y, z = val_49}, 丐丟丘世丁三丕专专:  22, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        ActivateRedLightExplosion();
        if(丘七业丒丐世丂丅丒() > 0f)
        {
            goto label_74;
        }
        
        this.且丆丝世上丐上不万 = 0;
        goto label_74;
        label_58:
        if(((this.丈丏与丅丏丘丟七万 & 1) == 0) || ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456.下三业三丌世丆丂丏()) == false))
        {
            goto label_74;
        }
        
        val_47 = this.stopSafeTime;
        val_44 = (double)this.一万丐丘不下丟丕丙;
        if(val_47 >= 0)
        {
            goto label_74;
        }
        
        if(this.业丒丂丈丘专一东丏 == 0)
        {
            goto label_71;
        }
        
        RedLightController.Instance.damageFrequency
        goto label_73;
        label_59:
        this.丅一万丝丕丂三且下 = -1f;
        goto label_74;
        label_71:
        val_50 = this.stoppingDamageDelay;
        label_73:
        int val_37 = this.业丒丂丈丘专一东丏;
        val_37 = val_37 + 1;
        val_44 = UnityEngine.Time.time + (float)val_50;
        this.丅一万丝丕丂三且下 = val_44;
        this.业丒丂丈丘专一东丏 = val_37;
        label_74:
        val_51 = null;
        val_51 = null;
        val_45 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_45 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(this.丄七丆丗东不丅丆丌 < 丝丈丅一丆丗丝丝丘())
        {
                float val_26 = UnityEngine.Time.time;
            if(this.丄丒世丝丘世丌丗丁 < 0)
        {
                val_47 = 1f;
            val_44 = UnityEngine.Time.time + val_47;
            this.丄丒世丝丘世丌丗丁 = val_44;
            val_52 = null;
            val_52 = null;
            this.丄七丆丗东不丅丆丌 = 丝丈丅一丆丗丝丝丘();
            val_45 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_45 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            丆丂东丏与不与不丟();
        }
        
        }
        
        label_81:
        if((val_35 < 0) && (this.丙世丑丅丒丑业与不() <= 0f))
        {
                if(丘七业丒丐世丂丅丒() > 0f)
        {
                val_45 = this.transform;
            UnityEngine.Vector3 val_32 = val_45.position;
            val_49 = val_32.z;
            val_44 = 100f;
            typeof(Player_move_c).__il2cppRuntimeField_600.ApplyDamage(丞丈专下丈专业三丞:  val_44, 丛世一丟丞丁业丘丒:  typeof(Player_move_c).__il2cppRuntimeField_600, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_49}, 丐丟丘世丁三丕专专:  22, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        }
        
        }
        
        if(this.丌下丘丁丌丄业丈丑 != 0f)
        {
            goto label_93;
        }
        
        if(val_35 < val_36)
        {
            goto label_96;
        }
        
        this.且丟丅且丛丑丁一丅();
        goto label_96;
        label_93:
        float val_33 = UnityEngine.Time.time;
        if(this.丌下丘丁丌丄业丈丑 < 0)
        {
                this.丛且丏丘丂专丙丙下 = true;
        }
        
        label_96:
        this.丐世万专丈丁世丏丈(丌七丒世丄上丞丞丁:  UnityEngine.Mathf.Min(a:  val_35, b:  val_36));
    }
    private void 且丟丅且丛丑丁一丅()
    {
        var val_8;
        var val_9;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + 4f;
        this.丌下丘丁丌丄业丈丑 = val_1;
        double val_8 = (double)this.丙世丑丅丒丑业与不();
        val_8 = this.matchTime - val_8;
        this.丂丝丈丙丞丝三丂一 = (float)val_8;
        val_8 = null;
        val_8 = null;
        float val_9 = 100f;
        val_9 = this.丂丝丈丙丞丝三丂一 * val_9;
        丆专世丒七丒东丕世(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  (int)val_9, b:  0));
        专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        val_9 = null;
        val_9 = null;
        GameController.mode.与丄下丑丈丗三丂丘(丙业与丙丗丝不丈东:  丑丛丆三丆丄七丐万());
        UnityEngine.Vector3 val_6 = this.finishPoint.position;
        UnityEngine.Vector3 val_7 = this.startPoint.position;
        val_7.x = val_6.x - val_7.x;
        this.丐世万专丈丁世丏丈(丌七丒世丄上丞丞丁:  val_7.x);
        this.UpdatePlayerScores();
        丐丗丅丈丒丈丂七丒();
        丂丕丐一东七七丏丂(且七丙丁与丌丗与上:  业七业丅丅丝万丕丝());
        this.丛丝丕与丕专东且丂 = true;
    }
    internal void 丞丂丝七丟丕丂且三()
    {
        this.丛且丏丘丂专丙丙下 = true;
    }
    internal void 丞下且丐丑业专且丛()
    {
        this.上丈与与丛丘丗丝丒 = true;
    }
    internal void 且丗且丏丟丙丅三丏()
    {
        万与专世三世丝业丏 val_3;
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() < this.且不丘丆与上东丆丐())
        {
                val_3 = this.且丆丝世上丐上不万;
        }
        else
        {
                val_3 = 1;
            this.且丆丝世上丐上不万 = val_3;
        }
        
        this.世丟东丝丂丒与丈下(且丆丝世上丐上不万:  val_3);
    }
    private void LateUpdate()
    {
        if(this.丅丕丞丂丑丞丅丑不 == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  InGameGUI.丙丞专丌丁丞与不丐.丁丝丆万丈世丄丒丅, y:  0);
        if(val_2 == false)
        {
                return;
        }
        
        val_2.七不丏东丐且业丄丞();
        this.丅丕丞丂丑丞丅丑不 = false;
    }
    private void 丐世万专丈丁世丏丈(float 丌七丒世丄上丞丞丁)
    {
        var val_5;
        var val_6;
        WeaponManager val_7;
        this.丝上七万上丄专丟丘 = UnityEngine.Mathf.Max(a:  丌七丒世丄上丞丞丁, b:  this.丝上七万上丄专丟丘);
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_11;
        }
        
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 == null)
        {
            goto label_12;
        }
        
        label_11:
        东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  丝丈丅一丆丗丝丝丘(), b:  (int)this.丝上七万上丄专丟丘));
        return;
        label_12:
    }
    private void 丙丗三不丟丛万三且()
    {
        null = null;
        丒丆且丑业世丅三上();
        if(GameController.onlineMode != null)
        {
                var val_1 = (null == null) ? GameController.onlineMode : 0;
        }
        
        0.丌不丂且丁丙丝万丄();
        if(this.goTimer <= 0f)
        {
                return;
        }
        
        this.丅丕丞丂丑丞丅丑不 = true;
    }
    private void 丁一万丆与丝丑丞业()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丄丗丆丆且且万一上 != false)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丙丈丌下丒专丝丄七(且且与丛七丗上丛三:  true);
        this.丄丗丆丆且且万一上 = true;
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        InGameGUIPart_RedLight.__il2cppRuntimeField_byval_arg.gameObject.SetActive(value:  false);
    }
    private void 丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        null = null;
        bool val_1 = 业上上东丑东丞丗不.ContainsKey(key:  GameConnect.丐世丞业丁丄与丐上);
        if(val_1 == false)
        {
                return;
        }
        
        与丂万三七丗丗丒丒 val_2 = val_1.世业丗丄丁丝丒一丁();
        if((val_2 & 255) == this.丙丆丂丏丕专丅业丝)
        {
                return;
        }
        
        if(this.丙丆丂丏丕专丅业丝 == 0)
        {
                return;
        }
        
        this.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  val_2);
    }
    internal string 丞七丕且丈丙上万下()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        val_9 = 0;
        val_10 = 0;
        goto label_7;
        label_16:
        与丅丕丈丘东丝世丟 val_8 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        if(val_8 != null)
        {
                var val_5 = (val_8.业丐丐三丕一丗丛丁() < typeof(Player_move_c).__il2cppRuntimeField_3B8.owner.业丐丐三丕一丗丛丁()) ? (val_10 + 1) : (val_10);
        }
        
        val_9 = 1;
        label_7:
        与丅丕丈丘东丝世丟[] val_6 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_9 < val_6.Length)
        {
            goto label_16;
        }
        
        int val_7 = val_5 / this.七丒丛东丌丄万万丝.Length;
        val_7 = val_5 - (val_7 * this.七丒丛东丌丄万万丝.Length);
        return (string)this.七丒丛东丌丄万万丝[(long)val_7];
    }
    internal void 且丒世万东丒丕丗万()
    {
        ExitGames.Client.Photon.Hashtable val_5;
        object val_6;
        var val_7;
        val_6 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_5 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_3 = val_3 + this.matchTime;
        val_3 = val_3 + this.丗丞丁丟丄丆上丒下;
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  val_3);
        val_6 = 2;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  2);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal RedLightController.与丂万三七丗丗丒丒 世业丗丄丁丝丒一丁()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            val_10 = null;
            if((val_9.ContainsKey(key:  GameConnect.丐世丞业丁丄与丐上)) != false)
        {
                val_11 = null;
            val_11 = null;
            val_9 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丐世丞业丁丄与丐上]);
            return (与丂万三七丗丗丒丒)val_12;
        }
        
        }
        
        val_12 = 1;
        return (与丂万三七丗丗丒丒)val_12;
    }
    internal bool 丁丁丏且三丗不且丘()
    {
        if(this.丛且丏丘丂专丙丙下 == false)
        {
                return (bool)this.上丈与与丛丘丗丝丒;
        }
        
        return true;
    }
    internal bool 下丐万丞业且丈不丞()
    {
        return (bool)(this.丙丆丂丏丕专丅业丝 == 2) ? 1 : 0;
    }
    internal RedLightController.与丂万三七丗丗丒丒 世东上与东丂万业丑()
    {
        return (与丂万三七丗丗丒丒)this.丙丆丂丏丕专丅业丝;
    }
    public void UpdatePlayerScores()
    {
        var val_4;
        var val_5;
        var val_6;
        GameController val_1 = GameController.丑七不且上丗丁一世();
        if(val_1.万丕丘七丟丞丏不专 == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_5;
        label_14:
        val_5 = null;
        val_5 = null;
        this.业丒丈丏一万不丏世(不且上一上丐三万丛:  Item[0]);
        val_4 = 1;
        label_5:
        val_6 = null;
        val_6 = null;
        if(val_4 < Count)
        {
            goto label_14;
        }
    
    }
    internal void 业丒丈丏一万不丏世(NetworkStartTable 不且上一上丐三万丛)
    {
        string val_7;
        NetworkStartTable val_8 = 不且上一上丐三万丛;
        if((System.String.IsNullOrEmpty(value:  不且上一上丐三万丛.丈三世丞丕万丄七丂)) == true)
        {
                return;
        }
        
        val_7 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        if((val_7.Equals(value:  "-1")) == true)
        {
                return;
        }
        
        val_7 = System.String.Format(format:  "{0}-{1}", arg0:  不且上一上丐三万丛.丈三世丞丕万丄七丂, arg1:  不且上一上丐三万丛.业丏三七专东丁丕丂);
        if((this.上丄丈丙丐丘丙丁与.ContainsKey(key:  val_7)) != false)
        {
                this.上丄丈丙丐丘丙丁与.Item[val_7].丑七下业与丕丛丅丕(不且上一上丐三万丛:  val_8 = 不且上一上丐三万丛);
            return;
        }
        
        val_8 = this.上丄丈丙丐丘丙丁与;
        val_8.Add(key:  val_7, value:  new 丈万且丗丂丝丙一东(不且上一上丐三万丛:  val_8));
    }
    public RedLightController()
    {
        this.stopSafeTime = 0.5;
        this.matchTime = ;
        this.maxRunningTime = 10;
        this.minRunningTime = ;
        this.maxStoppingTime = 8;
        this.minTrapsPercent = 5;
        this.maxTrapsPercent = 100;
        this.jumpCoef = 1f;
        this.speedCoef = 1f;
        this.丈丏与丅丏丘丟七万 = 0;
        this.minStoppingTime = ;
        this.stoppingDamageDelay = 0.5;
        this.七丙丟万丏与丆丆丂 = 5;
        this.damageAmount = ;
        this.damageFrequency = 0.5;
        string[] val_1 = new string[5];
        val_1[0] = "avatar_squid_001";
        val_1[1] = "avatar_squid_002";
        val_1[2] = "avatar_squid_003";
        val_1[3] = "avatar_squid_004";
        val_1[4] = "avatar_squid_005";
        this.丒丈丗丟丌丆三丑丟 = val_1;
        this.丑丛丒丐丂丒不万丁 = 0.2f;
        this.丗丞丁丟丄丆上丒下 = 6;
        this.丒万丟与一万万下丒 = new System.Collections.Generic.List<System.Double>();
        this.丅一万丝丕丂三且下 = -1f;
        this.且丆丝世上丐上不万 = 2;
        this.上丄丈丙丐丘丙丁与 = new System.Collections.Generic.Dictionary<System.String, 丈万且丗丂丝丙一东>(capacity:  30);
    }

}
