using UnityEngine;
internal sealed class MMTeamFightController : OnlineModeController
{
    // Fields
    public TimeGameController timeController;
    public SiegeTeamsController teamsCamera;
    internal MMTeamFightController.一且丐丗丅丈丏丄丅 丗世丞七丗丝世上丄;
    private bool 丝专丌丄丐世丌丄东;
    private float 丙与丗丅丙丟上丂丅;
    
    // Properties
    internal MMTeamFightController.一且丐丗丅丈丏丄丅 丟丆世且世丂丙丟丈 { get; set; }
    internal bool 世不业不业与七丝丐 { get; }
    
    // Methods
    internal MMTeamFightController.一且丐丗丅丈丏丄丅 三丘三丈上丕丆丂一()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_7 = null;
            val_7 = null;
            val_6 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丞丏丝与丙丁丛与]);
            return (一且丐丗丅丈丏丄丅)val_8;
        }
        
        val_8 = 0;
        return (一且丐丗丅丈丏丄丅)val_8;
    }
    internal void 万下丐丅上丏丅专专(MMTeamFightController.一且丐丗丅丈丏丄丅 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal bool 万东七丁世万丟专且()
    {
        var val_3;
        if(this.三丘三丈上丕丆丂一() != 0)
        {
                var val_2 = (this.丗世丞七丗丝世上丄 == 0) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    public override void Initialize()
    {
        UnityEngine.GameObject val_8;
        this.Initialize();
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "NguiWindows/Matchmaking/MatchmakingCamera");
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1000f);
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        if(val_1 != null)
        {
                var val_5 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_8 = 0;
        }
        
        this.teamsCamera = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_8, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}).GetComponent<SiegeTeamsController>();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        this.丝专丌丄丐世丌丄东 = true;
        if(this.三丘三丈上丕丆丂一() == 0)
        {
            goto label_0;
        }
        
        if(this.timeController != null)
        {
            goto label_2;
        }
        
        label_3:
        label_2:
        this.timeController.enabled = (this.丗世丞七丗丝世上丄 != 0) ? 1 : 0;
        this.东一丟丌丏且一丞丌();
        return;
        label_0:
        if(this.timeController != null)
        {
            goto label_2;
        }
        
        goto label_3;
    }
    private void 东一丟丌丏且一丞丌()
    {
        if(this.丝专丌丄丐世丌丄东 == false)
        {
                return;
        }
        
        一且丐丗丅丈丏丄丅 val_1 = this.三丘三丈上丕丆丂一();
        this.丗世丞七丗丝世上丄 = val_1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_4 = "Status updated " + val_1.三丘三丈上丕丆丂一().ToString();
        UnityEngine.Debug.LogError(message:  val_4);
        一且丐丗丅丈丏丄丅 val_5 = val_4.三丘三丈上丕丆丂一();
        if(val_5 == 2)
        {
            goto label_6;
        }
        
        if(val_5 == 1)
        {
            goto label_7;
        }
        
        if(val_5 != 0)
        {
                return;
        }
        
        val_4.丐丛丕且东下上丐业();
        goto label_16;
        label_6:
        val_4.丐丛丕且东下上丐业();
        PlayerBotsManager val_6 = PlayerBotsManager.与一丅丝不丈业与丙();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  val_6.丒丅丙丁丌丏丝丘东());
        val_6.丒丆且丑业世丅三上();
        this.上不丒丄世丞丈丙三();
        return;
        label_16:
        val_4.丒丆且丑业世丅三上();
        mem[1152921537632011160] = 1;
        return;
        label_7:
        val_4.SetActive(value:  true);
        this.teamsCamera.丘东东丐万丁丆万丈();
        this.teamsCamera.ShowStartInterface();
        this.丙与丗丅丙丟上丂丅 = 5f;
    }
    protected override void 丟不东丌丕不丐专业()
    {
        一且丐丗丅丈丏丄丅 val_3;
        一且丐丗丅丈丏丄丅 val_4;
        this.丟不东丌丕不丐专业();
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 != null)
        {
                val_3 = this.丗世丞七丗丝世上丄;
            val_4 = this.丗世丞七丗丝世上丄;
        }
        else
        {
                val_4 = this.丗世丞七丗丝世上丄;
            val_3 = 0;
            this.丝专丌丄丐世丌丄东 = false;
            this.丗世丞七丗丝世上丄 = val_3;
        }
        
        if(val_3 != val_1.三丘三丈上丕丆丂一())
        {
                this.东一丟丌丏且一丞丌();
        }
        
        if(val_4 != 1)
        {
                return;
        }
        
        this.丘丟丙丅七丛丕与不();
    }
    private void 丝且丞丞世丏丂丙丅()
    {
    
    }
    private void 丘丟丙丅七丛丕与不()
    {
        string val_5;
        var val_6;
        if(this.丙与丗丅丙丟上丂丅 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丙与丗丅丙丟上丂丅 - val_1;
        this.丙与丗丅丙丟上丂丅 = val_1;
        val_5 = 1152921505086132224;
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.matchMakingUI == 0)
        {
            goto label_5;
        }
        
        SiegeUI.__il2cppRuntimeField_generic_class.SetActive(value:  true);
        val_6 = 0;
        goto label_11;
        label_17:
        val_5 = UnityEngine.Mathf.RoundToInt(f:  this.丙与丗丅丙丟上丂丅).ToString();
        64.text = val_5;
        val_6 = 1;
        label_11:
        if(val_6 < 28563616)
        {
            goto label_17;
        }
        
        label_5:
        if(this.丙与丗丅丙丟上丂丅 > 0f)
        {
                return;
        }
        
        this.万下丐丅上丏丅专专(丙业与丙丗丝不丈东:  2);
    }
    private void 与丛上万丘且不七丕()
    {
    
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        var val_6 = null;
        if((丏业丟一东丂东丘丛.timeEndMatch & 1) == 0)
        {
                return false;
        }
        
        double val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if((System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丝下世丄业丕丑七])) < 0)
        {
                return false;
        }
        
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    internal override void 下丕丂业业丐丗与丁(丕丁丕上与丅不丙丄 与丆丌丂丟丛丘丑且)
    {
        this.下丕丂业业丐丗与丁(与丆丌丂丟丛丘丑且:  与丆丌丂丟丛丘丑且);
    }
    internal override bool 专丝上丟丆丝丙丄丈()
    {
        if(this.丘丑丅三丆丑丌且丝() <= 0)
        {
                return NetworkStartTable.与一专丒东丏丘专丕();
        }
        
        return true;
    }
    internal override void 丝丐不东一一丁丌七()
    {
        this.丝丐不东一一丁丌七();
        if((this.三丘三丈上丕丆丂一() != 0) && (this.丗世丞七丗丝世上丄 != 0))
        {
                TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        }
        
        this.丐丛丕且东下上丐业();
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_12;
        float val_13;
        var val_14;
        float val_15;
        var val_16;
        System.TimeSpan val_1 = Elapsed;
        System.TimeSpan val_3 = Elapsed;
        val_12 = null;
        val_12 = null;
        val_13 = 0f;
        if(GameController.onlineMode != 0)
        {
                val_14 = null;
            val_14 = null;
            val_15 = 0f;
            if(GameController.onlineMode.teamController == 0)
        {
                return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  GameController.onlineMode.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  val_15 = 0f, 丘丁七丁不丙不丟上:  val_13, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
        }
        
            val_16 = null;
            val_16 = null;
            val_15 = (float)typeof(TeamController).__il2cppRuntimeField_38;
            val_13 = (float)typeof(TeamController).__il2cppRuntimeField_3C;
            return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  GameController.onlineMode.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  val_15, 丘丁七丁不丙不丟上:  val_13, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
        }
        
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  GameController.onlineMode.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  val_15, 丘丁七丁不丙不丟上:  val_13, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    internal override bool 世七丌丟丞且丛七且()
    {
        TimeGameController val_5;
        var val_6;
        var val_7;
        val_5 = this;
        if((this.三丘三丈上丕丆丂一() == 0) || (this.丗世丞七丗丝世上丄 == 0))
        {
            goto label_2;
        }
        
        val_5 = TimeGameController.丄丞丁丈与业上丞丟;
        if(val_5 == 0)
        {
            goto label_9;
        }
        
        val_5 = TimeGameController.丄丞丁丈与业上丞丟;
        if(TimeGameController.丄丞丁丈与业上丞丟.丒丂世丌东万三下丗 <= 0f)
        {
            goto label_9;
        }
        
        val_5 = TimeGameController.丄丞丁丈与业上丞丟;
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= 0f)
        {
            goto label_9;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        var val_4 = (val_5.Count > 0) ? 1 : 0;
        return (bool)val_7;
        label_2:
        val_7 = 1;
        return (bool)val_7;
        label_9:
        val_7 = 0;
        return (bool)val_7;
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
    internal void 专丏丒丘东丟一丅丆()
    {
        if(137142272 == 0)
        {
                return;
        }
        
        this.丐丅丑丞丆丝上丈丝();
    }
    public MMTeamFightController()
    {
        this.丗世丞七丗丝世上丄 = 0;
    }

}
