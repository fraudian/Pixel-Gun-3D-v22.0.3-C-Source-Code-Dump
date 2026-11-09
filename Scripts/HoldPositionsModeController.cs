using UnityEngine;
internal sealed class HoldPositionsModeController : OnlineModeController
{
    // Fields
    private static PGCompany.DataObjects.丒丆丂丂丞丝丐下丄 丆一世丙丄丁丞丄丝;
    private 丌丈不下下丘丏丌一 丐下不专与丞丘且丌;
    private System.Collections.Generic.List<TeamScorePointConditionEndRound> 丂三丒专丁丑丒丂丂;
    
    // Properties
    internal int 丐丐丁业三世丁丁不 { get; }
    
    // Methods
    internal int 世七业丌业丝丟丁丆()
    {
        var val_2;
        HoldPositionsController val_3;
        var val_4;
        int val_5;
        val_2 = null;
        val_2 = null;
        val_3 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_3 != 0)
        {
                val_4 = null;
            val_4 = null;
            val_3 = HoldPositionsController.丆丕丝丒不丙且丐丗;
            val_5 = mem[HoldPositionsController.丆丕丝丒不丙且丐丗 + 140];
            val_5 = HoldPositionsController.丆丕丝丒不丙且丐丗.matchTime;
            return 100;
        }
        
        val_5 = 100;
        return 100;
    }
    private void Awake()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = this;
        this.丂三丒专丁丑丒丂丂.Clear();
        List.Enumerator<T> val_1 = this.丂三丒专丁丑丒丂丂.GetEnumerator();
        label_7:
        if(((-1409575768) & 1) == 0)
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
    public void SetLimitForTeamPoints(float 七丏丄丅丌业与且丙)
    {
        float val_3;
        var val_8;
        var val_9;
        var val_10;
        List.Enumerator<T> val_1 = this.GetEnumerator();
        label_11:
        if(((-1409439200) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((val_4 == null) || (null != null))
        {
            goto label_11;
        }
        
        val_3 = 七丏丄丅丌业与且丙;
        if((val_3 != 0) && (val_3 == 0))
        {
                val_8 = 0;
        }
        
        if(val_5.Length == 0)
        {
                val_8 = 0;
        }
        
        new object[1][0] = val_3;
        val_9 = null;
        if(null != val_9)
        {
                val_10 = null;
        }
        else
        {
                val_10 = val_9;
        }
        
        var val_6 = (val_9 == val_10) ? (val_4) : 0;
        goto label_11;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal override void 丝丐不东一一丁丌七()
    {
        var val_1;
        this.丝丐不东一一丁丌七();
        TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        val_1 = null;
        val_1 = null;
        HoldPositionsController.丆丕丝丒不丙且丐丗.丘上丐世丆丑且丞丒();
        HoldPositionsController.丆丕丝丒不丙且丐丗.丐丛丕且东下上丐业();
        this.丐下不专与丞丘且丌 = 0;
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
    internal override void 东丞丒丗专业且专丒()
    {
        var val_3;
        var val_4;
        HoldPositionsController val_5;
        this.东丞丒丗专业且专丒();
        val_3 = null;
        val_3 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_5;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_5 != null)
        {
            goto label_12;
        }
        
        goto label_9;
        label_5:
        val_5 = UnityEngine.Object.FindObjectOfType<HoldPositionsController>();
        if(val_5 != null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        val_5.丛业丑丁七下专丌上();
        if(val_5 == null)
        {
                return;
        }
        
        val_5.丟丞丗上丂世丄与丞();
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_3;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        val_3 = null;
        val_3 = null;
        HoldPositionsController.丆丕丝丒不丙且丐丗.且丌丆丝下且七丟丆();
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    protected override void 丟不东丌丕不丐专业()
    {
        int val_11;
        var val_12;
        var val_13;
        HoldPositionsController val_14;
        int val_15;
        HoldPositionsController val_16;
        var val_17;
        var val_18;
        if(((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丛丏不与丆丅业东丗() == false))
        {
            goto label_35;
        }
        
        val_11 = 1152921504848912384;
        if((TimeGameController.丄丞丁丈与业上丞丟 != 0) && (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 > 2))
        {
                if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 < 0)
        {
            goto label_33;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_35;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_14 == null)
        {
            goto label_25;
        }
        
        val_15 = mem[HoldPositionsController.丆丕丝丒不丙且丐丗 + 132];
        val_15 = HoldPositionsController.丆丕丝丒不丙且丐丗.丘丒丑丅东丄丐丗丈;
        val_16 = val_14;
        goto label_28;
        label_25:
        val_15 = mem[HoldPositionsController.丆丕丝丒不丙且丐丗 + 132];
        val_15 = HoldPositionsController.丆丕丝丒不丙且丐丗.丘丒丑丅东丄丐丗丈;
        val_16 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_16 == null)
        {
            goto label_27;
        }
        
        val_14 = val_16;
        goto label_28;
        label_27:
        val_14 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_14 == null)
        {
            goto label_29;
        }
        
        label_28:
        val_11 = mem[HoldPositionsController.丆丕丝丒不丙且丐丗 + 132];
        val_11 = HoldPositionsController.丆丕丝丒不丙且丐丗.丘丒丑丅东丄丐丗丈;
        if((HoldPositionsController.丆丕丝丒不丙且丐丗.丘丒丑丅东丄丐丗丈 + 64) <= ((float)UnityEngine.Mathf.Max(a:  val_15, b:  HoldPositionsController.丆丕丝丒不丙且丐丗.winPointsLimit - (val_11 << 3))))
        {
                if((HoldPositionsController.丆丕丝丒不丙且丐丗.丘丒丑丅东丄丐丗丈 + 68) <= ((float)UnityEngine.Mathf.Max(a:  val_15, b:  HoldPositionsController.丆丕丝丒不丙且丐丗.winPointsLimit - (val_11 << 3))))
        {
            goto label_35;
        }
        
        }
        
        label_33:
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        label_35:
        val_17 = null;
        val_17 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.configGetted == false)
        {
                return;
        }
        
        this.丒东专丒一一专丛丛();
        this.丟不东丌丕不丐专业();
        return;
        label_29:
    }
    private void 丒东专丒一一专丛丛()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_17;
        var val_18;
        var val_19;
        HoldPositionsController val_20;
        var val_21;
        HoldPositionsController val_22;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.configGetted == false)
        {
                return;
        }
        
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 == 0)
        {
                val_11 = null;
            val_11 = null;
            this.丂三丒专丁丑丒丂丂.Item[0].专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  TeamController.__il2cppRuntimeField_element_class);
            this.丂三丒专丁丑丒丂丂.Item[1].专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  typeof(TeamController).__il2cppRuntimeField_44);
            return;
        }
        
        val_12 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.丘丑丅三丆丑丌且丝() == 1)
        {
                val_13 = null;
            val_14 = null;
            val_14 = null;
            if(null != 0)
        {
            goto label_33;
        }
        
        }
        else
        {
                val_17 = null;
            val_18 = null;
            val_18 = null;
        }
        
        label_33:
        this.丂三丒专丁丑丒丂丂.Item[0].专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  typeof(TeamController).__il2cppRuntimeField_44);
        this.丂三丒专丁丑丒丂丂.Item[1].专三七丞丂三丏丄东(丕世丏下丒丂丏丟东:  GameController.onlineMode.teamController.丙丞丏丅丒丝丅不丒);
        val_19 = null;
        val_19 = null;
        val_20 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        val_21 = null;
        val_21 = null;
        val_22 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(GameController.onlineMode.teamController.丙丞丏丅丒丝丅不丒 <= (float)HoldPositionsController.丆丕丝丒不丙且丐丗.winPointsLimit)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "Match need to end");
    }
    internal void 丝丙七与丒丄七丝下()
    {
        HoldPositionsModeController val_1;
        var val_3;
        if(this.丐下不专与丞丘且丌 == 0)
        {
                return;
        }
        
        val_1 = this;
        mem[1152921537558074584] = val_1;
        if(this == null)
        {
            goto label_1;
        }
        
        val_3 = val_1;
        goto label_4;
        label_1:
        if(X22 == 0)
        {
            goto label_3;
        }
        
        val_1 = X22;
        goto label_4;
        label_3:
        if(this == null)
        {
            goto label_5;
        }
        
        label_4:
        X19.与丏东上丅丕上万上(下上丐丂丈东丆丝东:  (int)S8, 专且一上丒丟上丄丗:  (int)X22 + 96, 丁丞丗业丆丒上丈丞:  -1408510848);
        return;
        label_5:
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_11;
        float val_12;
        float val_13;
        var val_14;
        var val_15;
        HoldPositionsController val_16;
        this.丐下不专与丞丘且丌 = 东且丁丆丛丁丏丘且;
        System.TimeSpan val_1 = Elapsed;
        System.TimeSpan val_3 = Elapsed;
        int val_5 = 丘丑丅三丆丑丌且丝();
        val_11 = null;
        val_11 = null;
        val_14 = null;
        val_14 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.下丁业丑万丄丟丝下 == false)
        {
                return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  HoldPositionsController.丆丕丝丒不丙且丐丗.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  X23.丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  val_12 = HoldPositionsController.丆丕丝丒不丙且丐丗.<丌丅丟丈丗专丏专下>k__BackingField, 丘丁七丁不丙不丟上:  val_13 = HoldPositionsController.丆丕丝丒不丙且丐丗.<丆且丂丗丈三且专七>k__BackingField, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 != null)
        {
            goto label_16;
        }
        
        val_16 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_16 == null)
        {
            goto label_17;
        }
        
        label_16:
        val_12 = mem[HoldPositionsController.丆丕丝丒不丙且丐丗 + 180];
        val_13 = mem[HoldPositionsController.丆丕丝丒不丙且丐丗 + 184];
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  HoldPositionsController.丆丕丝丒不丙且丐丗.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  X23.丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  val_12, 丘丁七丁不丙不丟上:  val_13, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
        label_17:
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
    public HoldPositionsModeController()
    {
        this.丂三丒专丁丑丒丂丂 = new System.Collections.Generic.List<TeamScorePointConditionEndRound>();
    }

}
