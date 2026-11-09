using UnityEngine;
internal sealed class CapturePointsModeController : OnlineModeController
{
    // Fields
    internal ModeStartCondition startCondition;
    private int 丐下下下与一七丑上;
    private System.Collections.Generic.List<TeamScorePointConditionEndRound> 丂三丒专丁丑丒丂丂;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    
    // Methods
    private void Awake()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = this;
        this.丂三丒专丁丑丒丂丂.Clear();
        List.Enumerator<T> val_1 = this.丂三丒专丁丑丒丂丂.GetEnumerator();
        label_7:
        if(((-1447254504) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == null)
        {
            goto label_7;
        }
        
        val_5 = null;
        if(null != val_5)
        {
            goto label_7;
        }
        
        val_6 = val_5;
        if(this.丂三丒专丁丑丒丂丂 == null)
        {
                val_6 = null;
        }
        
        this.丂三丒专丁丑丒丂丂.Add(item:  (null == val_6) ? (val_2) : 0);
        goto label_7;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
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
    public override void Initialize()
    {
        this.Initialize();
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
        if(GameConnect.丕上丐丄三上丝专万() == false)
        {
                return;
        }
        
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CapturePointsModeController::下丙丒丘七丛且不丗()));
    }
    private void 下丙丒丘七丛且不丗()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_2.丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        }
        
        val_2.丒丆且丑业世丅三上();
        mem[1152921537519762152] = 1;
    }
    internal override void 丝丐不东一一丁丌七()
    {
        this.丝丐不东一一丁丌七();
        TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        CapturePointsController.丄丘七三上丕世丞业.丘上丐世丆丑且丞丒(丛万丅上丂丝丂丙丒:  X21);
        this.丐丛丕且东下上丐业();
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
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_6;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_7;
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
        if(this.startCondition != 0)
        {
                val_6 = null;
            val_6 = null;
            val_7 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_7 != null)
        {
                val_7 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_7 == null)
        {
                val_7 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_7.丌不丅不丞东万专专();
            if((val_2.HasValue.丙东专丂世丈丏丁丂() == 4) && (((-1446483112) & 1) != 0))
        {
                if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        }
        
        }
        
        CapturePointsController.丄丘七三上丕世丞业.丛业丑丁七下专丌上();
    }
    internal override void 下丕丂业业丐丗与丁(丕丁丕上与丅不丙丄 与丆丌丂丟丛丘丑且)
    {
        this.下丕丂业业丐丗与丁(与丆丌丂丟丛丘丑且:  与丆丌丂丟丛丘丑且);
    }
    protected override void 丟不东丌丕不丐专业()
    {
        var val_4;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_5;
        this.丒东专丒一一专丛丛();
        this.丟不东丌丕不丐专业();
        if(this.startCondition == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_5.丌不丅不丞东万专专();
        if(val_2.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if(((-1446234536) & 1) == 0)
        {
                return;
        }
        
        this.丘丁上且不丟丟三世();
    }
    private void 丒东专丒一一专丛丛()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_11;
        var val_12;
        var val_13;
        var val_15;
        var val_16;
        if(static_value_082C0000 != 0)
        {
            goto label_3;
        }
        
        val_7 = 1152921537520459040;
        val_8 = null;
        val_8 = null;
        this.丂三丒专丁丑丒丂丂.Item[0].专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  TeamController.__il2cppRuntimeField_element_class);
        val_9 = this.丂三丒专丁丑丒丂丂.Item[1];
        if(val_9 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_3:
        val_11 = null;
        if(丘丑丅三丆丑丌且丝() == 1)
        {
                val_12 = null;
            val_13 = null;
            val_13 = null;
            if(null != 0)
        {
            goto label_25;
        }
        
        }
        else
        {
                val_15 = null;
            val_16 = null;
            val_16 = null;
        }
        
        label_25:
        val_7 = 1152921537520459040;
        this.丂三丒专丁丑丒丂丂.Item[0].专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  typeof(TeamController).__il2cppRuntimeField_44);
        val_9 = this.丂三丒专丁丑丒丂丂.Item[1];
        label_14:
        val_9.专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  GameController.onlineMode.teamController.丙丞丏丅丒丝丅不丒);
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_11;
        System.TimeSpan val_1 = Elapsed;
        System.TimeSpan val_3 = Elapsed;
        int val_5 = 丘丑丅三丆丑丌且丝();
        val_11 = null;
        val_11 = null;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  GameController.onlineMode.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  X23.丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  TeamController.__il2cppRuntimeField_element_class, 丘丁七丁不丙不丟上:  typeof(TeamController).__il2cppRuntimeField_44, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    internal override void 东丞丒丗专业且专丒()
    {
        var val_1;
        this.东丞丒丗专业且专丒();
        CapturePointsController.丄丘七三上丕世丞业.丛业丑丁七下专丌上();
        val_1 = null;
        val_1 = null;
        typeof(TeamController).__il2cppRuntimeField_38 = 0;
        typeof(TeamController).__il2cppRuntimeField_3C = 0;
        typeof(TeamController).__il2cppRuntimeField_40 = 0;
        typeof(TeamController).__il2cppRuntimeField_44 = 0;
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        int val_3 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        if((NetworkStartTable.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  丏业丟一东丂东丘丛.myTeam, 丆丘万七一丐上且丅:  true, 丗不下丆丈丌三丛与:  false)) >= (((val_3 < 0) ? (val_3 + 1) : (val_3)) >> 1))
        {
                return false;
        }
        
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    internal override bool 专丝上丟丆丝丙丄丈()
    {
        if(this.丘丑丅三丆丑丌且丝() <= 0)
        {
                return NetworkStartTable.与一专丒东丏丘专丕();
        }
        
        return true;
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
    public CapturePointsModeController()
    {
        this.丐下下下与一七丑上 = 2;
        this.丂三丒专丁丑丒丂丂 = new System.Collections.Generic.List<TeamScorePointConditionEndRound>();
    }

}
