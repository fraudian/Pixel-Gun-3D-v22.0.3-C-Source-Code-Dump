using UnityEngine;
public sealed class ImposterModeController : OnlineModeController
{
    // Fields
    internal ImposterModeController.一且丐丗丅丈丏丄丅 丗世丞七丗丝世上丄;
    internal UnityEngine.AudioClip playerDeadSound;
    private bool 丗与丒丒且万丄万万;
    public ModeStartCondition startCondition;
    public ImposterVoteController voteController;
    public ImposterVoteChatController voteChatController;
    public SabotageDoorsNetworkController sabotageDoorsNetwork;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    internal int 丏丙丗丐丞丕丅丁丗;
    internal double 丆东与丏下丑与丂丘;
    private bool 丑丆丏下丛世上丄丛;
    internal static readonly System.Collections.Generic.List<System.ValueTuple<string, UnityEngine.Color32>> 丟丟丄且丄丞与丑丘;
    private bool 丝丟丟丏七三丛且丅;
    internal int 丗丑世丒东丑丛上万;
    internal NetworkStartTable 丙丗东丞丕业万丟业;
    internal System.Collections.Generic.Dictionary<string, 丈万且丗丂丝丙一东> 上丄丈丙丐丘丙丁与;
    
    // Properties
    internal ImposterModeController.一且丐丗丅丈丏丄丅 丟丆世且世丂丙丟丈 { get; set; }
    internal int 七丑东丒不上丛丛丂 { get; }
    internal int 丂丟丝七丑东丂下上 { get; }
    internal string 丗丝丂丟丄丄上下东 { get; }
    internal bool 丐上丄丅丗丝万与丝 { get; }
    internal bool 世下东万丞丞丗与丆 { get; }
    
    // Methods
    internal ImposterModeController.一且丐丗丅丈丏丄丅 三丘三丈上丕丆丂一()
    {
        var val_5;
        var val_7;
        val_5 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (一且丐丗丅丈丏丄丅)null;
        }
        
        val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_7 = null;
        val_7 = null;
        object val_4 = val_5.Item[GameConnect.丐世丞业丁丄与丐上];
        return (一且丐丗丅丈丏丄丅)null;
    }
    internal void 万下丐丅上丏丅专专(ImposterModeController.一且丐丗丅丈丏丄丅 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal int 丕丆丄丗与丟丞丅专()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (int)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丂丐丝三与专与且丈)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.丂丐丝三与专与且丈];
            return (int)val_9;
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    internal int 东丂丙七丌世业上丅()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_9 = null;
            val_9 = null;
            if((val_8.ContainsKey(key:  GameConnect.丙世丁丆丆丗一丞丈)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.丙世丁丆丆丗一丞丈];
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    internal string 丒丐丕专专世丟丘丛()
    {
        var val_9;
        var val_10;
        var val_11;
        int val_12;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            val_10 = null;
            if((val_9.ContainsKey(key:  GameConnect.业丙丞丏丘不一与与)) != false)
        {
                val_11 = null;
            val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            if(val_9.Item[GameConnect.业丙丞丏丘不一与与] == null)
        {
                return (string)val_12;
        }
        
            if(null == null)
        {
                return (string)val_12;
        }
        
            val_12 = 0;
            return (string)val_12;
        }
        
        }
        
        val_12 = System.String.alignConst;
        return (string)val_12;
    }
    internal bool 丞丕丟丘万丁上丌一()
    {
        一且丐丗丅丈丏丄丅 val_1 = this.三丘三丈上丕丆丂一();
        if(val_1 == 0)
        {
                return (bool)(val_1.三丘三丈上丕丆丂一() != 1) ? 1 : 0;
        }
        
        return (bool)(val_1.三丘三丈上丕丆丂一() != 1) ? 1 : 0;
    }
    internal bool 丗丛一丑丂丏丘上下()
    {
        return (bool)this.丝丟丟丏七三丛且丅;
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        0.丒世东专丝业丒丙专();
        0.丒丄上丁且丑丈丄世();
        0.下丆丐三专丂丕丝三();
        this.丝丟丟丏七三丛且丅 = true;
        bool val_1 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_1 != false)
        {
                val_1.万下丐丅上丏丅专专(丙业与丙丗丝不丈东:  5);
        }
        
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    internal override void 丝丐不东一一丁丌七()
    {
        this.丝丐不东一一丁丌七();
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    public override void Initialize()
    {
        var val_12;
        System.Action<与丅丕丈丘东丝世丟> val_13;
        var val_14;
        var val_15;
        System.Action<与丅丕丈丘东丝世丟> val_16;
        this.Initialize();
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ImposterModeController::丐丟下不下丏丂一业()));
        val_12 = null;
        val_12 = null;
        val_14 = null;
        val_15 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void ImposterModeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != val_15))
        {
                val_14 = null;
            val_15 = null;
            val_13 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_13;
        if(((System.Delegate.Combine(a:  GameConnect.丅三业三丙专丏丟丐, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void ImposterModeController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_16 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_16;
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
        this.丗丑世丒东丑丛上万 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丟丏丄丞与不世丐丙();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        bool val_1 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  val_1);
        this.丑丆丏下丛世上丄丛 = val_1;
        this.专三丗丌一七丏丒丅();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丘丅丟万不与丐一丘());
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        this.东一丟丌丏且一丞丌();
        一且丐丗丅丈丏丄丅 val_1 = this.三丘三丈上丕丆丂一();
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.三丘三丈上丕丆丂一() == 1)
        {
                return;
        }
        
        this.三上且丙且丂下丅丝();
    }
    internal void 三上且丙且丂下丅丝()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 0;
        goto label_1;
        label_10:
        val_4 = null;
        val_4 = null;
        this.业丒丈丏一万不丏世(不且上一上丐三万丛:  Item[0]);
        val_3 = 1;
        label_1:
        val_5 = null;
        val_5 = null;
        if(val_3 < Count)
        {
            goto label_10;
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
    private void 丐丟下不下丏丂一业()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        this.丟一丂丙丑丙丄且且();
        this.万下丐丅上丏丅专专(丙业与丙丗丝不丈东:  2);
    }
    private void 专三丗丌一七丏丒丅()
    {
        一且丐丗丅丈丏丄丅 val_1 = this.三丘三丈上丕丆丂一();
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 == this.丗世丞七丗丝世上丄)
        {
                return;
        }
        
        if((val_1 - 1) <= 4)
        {
                var val_6 = 106020304 + ((val_1 - 1)) << 2;
            val_6 = val_6 + 106020304;
        }
        else
        {
                this.丗世丞七丗丝世上丄 = val_1;
        }
    
    }
    private void 东一丟丌丏且一丞丌()
    {
        if(this.丗世丞七丗丝世上丄 == 4)
        {
            goto label_0;
        }
        
        if(this.丗世丞七丗丝世上丄 == 3)
        {
            goto label_1;
        }
        
        if(this.丗世丞七丗丝世上丄 != 1)
        {
                return;
        }
        
        this.万不不丂丅且丗与丑();
        return;
        label_0:
        this.七不世丏一丛世丕丘();
        return;
        label_1:
        this.上世丘丂丛丈且三丅();
    }
    private void 不丟丈业丅丅万丁丏()
    {
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ShowStartInterface();
        }
        
        this.丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  true);
    }
    private void 丗丘丒丈丝业上丝丟()
    {
        var val_9;
        var val_10;
        if(this.丗世丞七丗丝世上丄 <= 1)
        {
                与丅丕丈丘东丝世丟[] val_1 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
            this.丏丙丗丐丞丕丅丁丗 = val_1.Length;
        }
        
        this.丆东与丏下丑与丂丘 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        0.丒丄上丁且丑丈丄世();
        PlayerDeadStackController.丄丞丁丈与业上丞丟.下丌与世丅万丞业丌();
        PlayerDeadStackController.丄丞丁丈与业上丞丟.丒丆且丑业世丅三上();
        if(PlayerDeadStackController.丄丞丁丈与业上丞丟 != null)
        {
                this.上不丒丄世丞丈丙三();
        }
        else
        {
                mem[1152921537563023240] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if((丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丒东下丈且丕丌丞七)) == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        object val_8 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[GameConnect.丒东下丈且丕丌丞七];
    }
    private void 且专丆一业丄丛丕丌()
    {
        var val_4;
        var val_5;
        mem[1152921537563204872] = 0;
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_5 = null;
            val_5 = null;
            bool val_2 = 丞丁丛丐不丞丗丒三();
            bool val_3 = 丞丁丛丐不丞丗丒三();
            丏专七丁七丙下丆丁(丟丆丞丏业七世东丒:  true);
        }
        
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.丞丛丑丁丂丒丄下与();
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.丟丙不上丝丂丄丗三();
        PlayerDeadStackController.丄丞丁丈与业上丞丟.下丌与世丅万丞业丌();
        this.voteController.丆专丅上丙丞丁丅东();
    }
    private void 丅丌专丑业丛丒下专()
    {
        this.voteController.丗丈万丈东且三丅丄();
    }
    private void 万不不丂丅且丗与丑()
    {
        ModeStartCondition val_8;
        var val_9;
        val_8 = this;
        this.丘丁上且不丟丟三世();
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().业丆丛丁丈丌丘丛丅() == false)
        {
                return;
        }
        
        val_8 = this.startCondition;
        if(val_8 != null)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_8 = 0;
        val_9 = 1;
        goto label_10;
        label_9:
        val_9 = 0;
        label_10:
        if(val_8.丟丛万丅业丛且不丂() == false)
        {
                return;
        }
        
        if(val_8.丝丒不万丑丙丏丆上() >= 0)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    private void 上世丘丂丛丈且三丅()
    {
        this.voteController.且丞丙丟下丘业丘丒();
    }
    private void 七不世丏一丛世丕丘()
    {
        this.voteController.且丞丙丟下丘业丘丒();
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
    private void 丐下下丝万丗丄下丛()
    {
        this.丟一丂丙丑丙丄且且();
    }
    private 与丅丕丈丘东丝世丟 业丈丟一丕丒与丅与(System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丝不丝丗丂丙万与业)
    {
        var val_3;
        var val_20;
        string val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        List.Enumerator<T> val_1 = 丝不丝丗丂丙万与业.GetEnumerator();
        val_20 = 0;
        goto label_2;
        label_13:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        val_21 = val_4.丑丗三丛丛丆丟丌丆();
        val_22 = null;
        val_22 = null;
        if((val_21.ContainsKey(key:  GameConnect.丘业丆丕一丆丌丕不)) != false)
        {
                val_23 = null;
            val_23 = null;
            val_21 = GameConnect.丘业丆丕一丆丌丕不;
            object val_8 = val_4.丑丗三丛丛丆丟丌丆().Item[val_21];
        }
        else
        {
                val_24 = 0;
        }
        
        label_2:
        if(((-1402432672) & 1) != 0)
        {
            goto label_13;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_10 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        List.Enumerator<T> val_11 = 丝不丝丗丂丙万与业.GetEnumerator();
        label_38:
        if(((-1402432672) & 1) == 0)
        {
            goto label_25;
        }
        
        string val_12 = val_3.丐丏七丌丕丗业且上();
        val_25 = null;
        val_25 = null;
        if((val_12.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丘业丆丕一丆丌丕不)) != false)
        {
                val_26 = null;
            val_26 = null;
            object val_16 = val_12.丑丗三丛丛丆丟丌丆().Item[GameConnect.丘业丆丕一丆丌丕不];
        }
        else
        {
                val_27 = 0;
        }
        
        if(val_27 != ((val_24 > val_20) ? (val_24) : (val_20)))
        {
            goto label_38;
        }
        
        val_10.Add(item:  val_12);
        goto label_38;
        label_25:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_10 != null)
        {
                return (与丅丕丈丘东丝世丟)val_10.Item[UnityEngine.Random.Range(min:  0, max:  val_10.Count)];
        }
        
        return (与丅丕丈丘东丝世丟)val_10.Item[UnityEngine.Random.Range(min:  0, max:  val_10.Count)];
    }
    private void 丟一丂丙丑丙丄且且()
    {
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_22;
        object val_23;
        int val_24;
        与丅丕丈丘东丝世丟 val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        object val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_1 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_3 = null;
        val_22 = val_3;
        val_3 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>(collection:  丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁());
        与丅丕丈丘东丝世丟[] val_4 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        int val_5 = UnityEngine.Mathf.Min(a:  val_4.Length, b:  this.丗丑世丒东丑丛上万);
        var val_22 = val_5;
        if(val_22 >= 1)
        {
                val_23 = 1152921525961926672;
            do
        {
            与丅丕丈丘东丝世丟 val_6 = val_5.业丈丟一丕丒与丅与(丝不丝丗丂丙万与业:  val_3);
            if(val_22 != null)
        {
                val_24 = val_3.IndexOf(item:  val_6);
            val_25 = val_3.Item[val_24];
        }
        else
        {
                val_24 = val_3.IndexOf(item:  val_6);
            val_25 = val_3.Item[val_24];
        }
        
            val_3.RemoveAt(index:  val_24);
            val_1.Add(item:  val_25);
            val_22 = val_22 - 1;
        }
        while(val_22 != 0);
        
        }
        
        val_26 = null;
        val_26 = null;
        System.Collections.Generic.List<System.ValueTuple<System.String, UnityEngine.Color32>> val_11 = new System.Collections.Generic.List<System.ValueTuple<System.String, UnityEngine.Color32>>(collection:  ImposterModeController.丟丟丄且丄丞与丑丘);
        val_27 = 1152921518385779168;
        val_28 = 0;
        goto label_13;
        label_31:
        ExitGames.Client.Photon.Hashtable val_12 = null;
        val_25 = val_12;
        val_12 = new ExitGames.Client.Photon.Hashtable();
        val_29 = null;
        val_30 = 1;
        val_29 = null;
        val_30 = 1;
        val_12.Add(key:  GameConnect.丒东下丈且丕丌丞七, value:  val_30);
        val_12.Add(key:  GameConnect.丂丏丈上东丕丒三丈, value:  1);
        val_27 = 1152921518385779168;
        val_12.Add(key:  GameConnect.丑上丐且丟丂东丐丅, value:  0);
        val_23 = 0;
        val_12.Add(key:  GameConnect.上丛万丏丄不丗下丐, value:  0);
        val_22 = val_22;
        int val_13 = 丞东丑专丛丆丄丝世.丕七丆不丈丒丏丟专(丑东与丅丐丅丂丞业:  val_11);
        if(val_13 != 1)
        {
                val_31 = null;
            val_31 = null;
            val_23 = GameConnect.丕一业丌丄下丈丂专;
            System.ValueTuple<System.String, UnityEngine.Color32> val_14 = val_11.Item[val_13];
            val_12.Add(key:  val_23, value:  val_14.Item2.r);
            val_11.RemoveAt(index:  val_13);
        }
        
        val_1.Item[0].丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_12, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_28 = 1;
        label_13:
        if(val_28 < val_1.Count)
        {
            goto label_31;
        }
        
        val_32 = 0;
        goto label_32;
        label_50:
        ExitGames.Client.Photon.Hashtable val_17 = new ExitGames.Client.Photon.Hashtable();
        val_33 = null;
        val_33 = null;
        val_23 = 1152921504622075904;
        val_17.Add(key:  GameConnect.丒东下丈且丕丌丞七, value:  0);
        val_17.Add(key:  GameConnect.丂丏丈上东丕丒三丈, value:  1);
        val_17.Add(key:  GameConnect.丑上丐且丟丂东丐丅, value:  0);
        val_17.Add(key:  GameConnect.上丛万丏丄不丗下丐, value:  0);
        int val_18 = 丞东丑专丛丆丄丝世.丕七丆不丈丒丏丟专(丑东与丅丐丅丂丞业:  val_11);
        if(val_18 != 1)
        {
                val_34 = null;
            val_34 = null;
            System.ValueTuple<System.String, UnityEngine.Color32> val_19 = val_11.Item[val_18];
            val_23 = val_19.Item2.r;
            val_17.Add(key:  GameConnect.丕一业丌丄下丈丂专, value:  val_23);
            val_11.RemoveAt(index:  val_18);
        }
        
        val_25 = val_3.Item[0];
        val_25.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_17, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_32 = 1;
        label_32:
        if(val_32 < val_3.Count)
        {
            goto label_50;
        }
    
    }
    private void 丛丝丌丄上丝丝丏业()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘丅丟万不与丐一丘());
    }
    private System.Collections.IEnumerator 丘丅丟万不与丐一丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ImposterModeController.丆三上上丂一且东丅();
    }
    internal void 世丘且与一丄丟丗丐(与丅丕丈丘东丝世丟 丛丌专丒一丞丐丞丐, bool 丄丐丆丞与丟上上下, string 与丟丅七丞且且丛丕)
    {
        ExitGames.Client.Photon.Hashtable val_10;
        int val_11;
        bool val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = 与丟丅七丞且且丛丕;
        val_12 = 丄丐丆丞与丟上上下;
        if(this.三丘三丈上丕丆丂一() != 2)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_10 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_13 = null;
        val_13 = null;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  3);
        val_2.set_Item(key:  GameConnect.丙世丁丆丆丗一丞丈, value:  丛丌专丒一丞丐丞丐.业丐丐三丕一丗丛丁());
        val_2.set_Item(key:  GameConnect.丂丐丝三与专与且丈, value:  val_12);
        val_14 = null;
        val_14 = null;
        if(val_12 != true)
        {
                val_11 = System.String.alignConst;
        }
        
        val_2.set_Item(key:  GameConnect.业丙丞丏丘不一与与, value:  val_11);
        val_15 = null;
        val_15 = null;
        double val_10 = (double)ImposterVoteController.丒七不丕丞专七丕丘();
        val_10 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_10;
        val_10 = val_10 + (double)ImposterVoteController.业丛丒丞一丂丌丅与();
        double val_11 = (double)ImposterVoteController.丗丏丁丟丝丟不东丄();
        val_11 = val_10 + val_11;
        val_12 = val_11;
        val_2.set_Item(key:  GameConnect.丞专上丗丄一东丐丛, value:  val_11);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 不丙丈丁三下七丄万(int 东且丁丆丛丁丏丘且)
    {
        ExitGames.Client.Photon.Hashtable val_6;
        var val_7;
        if(this.三丘三丈上丕丆丂一() != 3)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_6 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  4);
        double val_6 = (double)ImposterVoteController.丏三丑世丆丄丞丛与();
        val_6 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_6;
        val_2.set_Item(key:  GameConnect.丞专上丗丄一东丐丛, value:  val_6);
        val_2.set_Item(key:  GameConnect.丒丑丘丟丌丝世专丘, value:  东且丁丆丛丁丏丘且);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 丟丑丑丁七丝上丏丕()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = null;
        val_11 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丒丑丘丟丌丝世专丘)) != false)
        {
                val_12 = null;
            val_12 = null;
            object val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丒丑丘丟丌丝世专丘];
            if(null != 1)
        {
                val_13 = null;
            val_13 = null;
            if(null != ImposterVoteController.专丟七上丁世丕且丟)
        {
                与丅丕丈丘东丝世丟 val_7 = 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  21884928);
            if(val_7 != null)
        {
                ExitGames.Client.Photon.Hashtable val_8 = new ExitGames.Client.Photon.Hashtable();
            val_14 = null;
            val_14 = null;
            val_8.Add(key:  GameConnect.丂丏丈上东丕丒三丈, value:  0);
            val_7.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_8, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        }
        
        }
        
        }
        
        ExitGames.Client.Photon.Hashtable val_9 = new ExitGames.Client.Photon.Hashtable();
        val_15 = null;
        val_15 = null;
        val_9.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  2);
        val_9.set_Item(key:  GameConnect.丒丑丘丟丌丝世专丘, value:  0);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    protected override void 世丄丄与丌业丑丕丈(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        this.世丄丄与丌业丑丕丈(业上上东丑东丞丗不:  业上上东丑东丞丗不);
        if(this.丗世丞七丗丝世上丄 == this.三丘三丈上丕丆丂一())
        {
                return;
        }
        
        this.专三丗丌一七丏丒丅();
    }
    internal override bool 丄一下丒七丝与与万()
    {
        一且丐丗丅丈丏丄丅 val_1 = this.三丘三丈上丕丆丂一();
        if(val_1 == 0)
        {
                return (bool)(val_1.三丘三丈上丕丆丂一() != 1) ? 1 : 0;
        }
        
        return (bool)(val_1.三丘三丈上丕丆丂一() != 1) ? 1 : 0;
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_16 = null;
        val_16 = null;
        val_17 = null;
        val_17 = null;
        bool val_2 = PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丐丟一东丅丘一丒下();
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_19 = null;
        System.Predicate<NetworkStartTable> val_16 = ImposterModeController.<>c.<>9__60_0;
        if(val_16 == null)
        {
            goto label_13;
        }
        
        label_20:
        bool val_3 = Exists(match:  val_16);
        val_16 = val_3 ^ 1;
        System.TimeSpan val_8 = Elapsed;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.世丙丐丏丅丌丑一七(丏丏业东上七丐万东:  val_8._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  ((((丟东丘丏上世且上丕() != true) ? (val_3 & (~val_2)) : (val_2 | val_16)) & 1) != 0) ? (1 + 1) : 1, 丅且丅且丙丘丗万丞:  val_2, 七与上丝上与丏丞丂:  val_16, 丗与丒丒且万丄万万:  this.丗与丒丒且万丄万万, 万丏且七丟丕丄丈上:  SabotageImposterModeController.丆丕丝丒不丙且丐丗.东与丈丗与丘丟丘丟());
        label_13:
        ImposterModeController.<>c.<>9__60_0 = new System.Predicate<NetworkStartTable>(object:  ImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ImposterModeController.<>c::世丆世专丒丙不丆丟(NetworkStartTable 三丟东丕丄丄下下丑));
        if(null != 0)
        {
            goto label_20;
        }
        
        goto label_20;
    }
    protected override void 丛丒丒七丈丈下七丌(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_8;
        var val_9;
        this.丛丒丒七丈丈下七丌(东且丁丆丛丁丏丘且:  东且丁丆丛丁丏丘且);
        if(true != 0)
        {
                val_8 = 0;
            val_9 = 0;
        }
        else
        {
                if(true != 0)
        {
                val_9 = 3;
            val_8 = 1;
        }
        else
        {
                if(true != 0)
        {
                val_8 = 0;
            val_9 = 2;
        }
        else
        {
                bool val_1 = (true == 0) ? 1 : 0;
        }
        
        }
        
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丑丘业丐丟世丗下且().上东与丛丞下丈专丈(丛丄东丅世且丆丝上:  (true == 0) ? 4 : (0 + 1), 三三丅丐丐不业丅丟:  val_1, 业东丞丏丒业万丏丘:  ((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 49) != 0) ? 1 : 0, 三世丈丆丆丄丗一业:  (val_1 != 0) ? (X22 + 176) : (X22 + 184));
    }
    internal void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        bool val_1 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_1 == false)
        {
                return;
        }
        
        一且丐丗丅丈丏丄丅 val_2 = val_1.三丘三丈上丕丆丂一();
        if(val_2 == 0)
        {
                return;
        }
        
        if(val_2.三丘三丈上丕丆丂一() == 1)
        {
                return;
        }
        
        bool val_4 = 丅丒丗丑丒丙丛不丆.丑丌七丗丐丌丆丏万(与丐丞丒上丈业丐丄:  专丞上七七且丝七丗);
    }
    internal void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_4;
        var val_5;
        if(this.丞丕丟丘万丁上丌一() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        if((ImposterModeController.<>c.<>9__63_0) == null)
        {
            goto label_7;
        }
        
        label_13:
        bool val_4 = ~(Exists(match:  ImposterModeController.<>c.<>9__63_0));
        val_4 = val_4 & 1;
        this.丗与丒丒且万丄万万 = val_4;
        return;
        label_7:
        ImposterModeController.<>c.<>9__63_0 = new System.Predicate<NetworkStartTable>(object:  ImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ImposterModeController.<>c::丟丒丐专丘丈一丘东(NetworkStartTable 三丟东丕丄丄下下丑));
        if(null != 0)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    internal void 丞丝下丄丆且丌丈丐()
    {
        var val_2;
        var val_3;
        if(this.startCondition == null)
        {
            goto label_1;
        }
        
        val_2 = null;
        if(null == val_2)
        {
            goto label_2;
        }
        
        label_1:
        val_3 = null;
        goto label_3;
        label_2:
        val_3 = val_2;
        label_3:
        var val_1 = (val_2 == val_3) ? this.startCondition : 0;
        mem2[0] = 1;
    }
    protected override void Destroy()
    {
        var val_6;
        System.Action<与丅丕丈丘东丝世丟> val_7;
        var val_8;
        var val_9;
        System.Action<与丅丕丈丘东丝世丟> val_10;
        this.Destroy();
        val_6 = null;
        val_6 = null;
        val_8 = null;
        val_9 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void ImposterModeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != val_9))
        {
                val_8 = null;
            val_9 = null;
            val_7 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_7;
        if(((System.Delegate.Remove(source:  GameConnect.丅三业三丙专丏丟丐, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void ImposterModeController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_10 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_10;
    }
    public ImposterModeController()
    {
        this.丏丙丗丐丞丕丅丁丗 = 10;
        this.上丄丈丙丐丘丙丁与 = new System.Collections.Generic.Dictionary<System.String, 丈万且丗丂丝丙一东>(capacity:  10);
    }
    private static ImposterModeController()
    {
        System.Collections.Generic.List<System.ValueTuple<System.String, UnityEngine.Color32>> val_1 = new System.Collections.Generic.List<System.ValueTuple<System.String, UnityEngine.Color32>>();
        UnityEngine.Color val_2 = UnityEngine.Color.black;
        UnityEngine.Color32 val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        byte val_4 = val_3.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        UnityEngine.Color val_5 = UnityEngine.Color.blue;
        UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        byte val_7 = val_6.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        UnityEngine.Color val_8 = UnityEngine.Color.cyan;
        UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
        byte val_10 = val_9.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        UnityEngine.Color val_11 = UnityEngine.Color.green;
        UnityEngine.Color32 val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
        byte val_13 = val_12.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        UnityEngine.Color val_14 = UnityEngine.Color.red;
        UnityEngine.Color32 val_15 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a});
        byte val_16 = val_15.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        UnityEngine.Color val_17 = UnityEngine.Color.white;
        UnityEngine.Color32 val_18 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a});
        byte val_19 = val_18.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        UnityEngine.Color val_20 = UnityEngine.Color.yellow;
        UnityEngine.Color32 val_21 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a});
        byte val_22 = val_21.r & 4294967295;
        val_1.Add(item:  new System.ValueTuple<System.String, UnityEngine.Color32>() {Item2 = new UnityEngine.Color32()});
        ImposterModeController.丟丟丄且丄丞与丑丘 = val_1;
    }

}
