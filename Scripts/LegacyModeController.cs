using UnityEngine;
public class LegacyModeController : OnlineModeController
{
    // Fields
    internal ModeStartCondition startCondition;
    internal System.Collections.Generic.List<Player_move_c> 丗世丕世一与下丗丅;
    internal System.Collections.Generic.List<Player_move_c> 丄东丛丟丐丄丈丆丒;
    internal FlagController 丐万与丞上丒丛丁丕;
    internal FlagController 不丄万丑丟万世专世;
    internal string 丅丌一丌丑七业东丁;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    private bool 丗不专世丌丗三丑丝;
    
    // Methods
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
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == true)
        {
                return;
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                return;
        }
        
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LegacyModeController::下丙丒丘七丛且不丗()));
    }
    private void 下丙丒丘七丛且不丗()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_2.丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        }
        
        val_2.丒丆且丑业世丅三上();
        mem[1152921537512862792] = 1;
    }
    internal void 丈丌一丂丟丕丄不且()
    {
        if(137105408 == 0)
        {
                return;
        }
        
        this.丟丞丗上丂世丄与丞();
    }
    internal override void 东丞丒丗专业且专丒()
    {
        this.东丞丒丗专业且专丒();
        this.丈丌一丂丟丕丄不且();
    }
    public override void AfterInitialization()
    {
        var val_19;
        string val_20;
        string val_21;
        this.AfterInitialization();
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        if(((Rilisoft.Singleton<ClansController>.Instance) != 0) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null))
        {
                val_20 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
            val_21 = "-1";
        }
        else
        {
                val_21 = "-1";
            val_20 = val_21;
        }
        
        if((System.String.op_Inequality(a:  val_20, b:  val_21)) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丁丝丕上下丗丕丞东], b:  val_20)) != true)
        {
                if((System.String.op_Equality(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟不下业世与丈下三], b:  val_20)) == false)
        {
                return;
        }
        
        }
        
        this.丅丌一丌丑七业东丁 = val_20;
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        var val_28;
        var val_29;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        val_28 = 1152921505066536960;
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if((TeamDuelController.丅丌丛丏丞上万丛丕 + 24) != 2)
        {
                if((TeamDuelController.丅丌丛丏丞上万丛丕 + 24) != 4)
        {
            goto label_7;
        }
        
        }
        
            TeamDuelController.丅丌丛丏丞上万丛丕.丐丛丕且东下上丐业();
            TeamDuelController.丅丌丛丏丞上万丛丕.丆丄上丛丝东丅专东();
            TeamDuelController.丅丌丛丏丞上万丛丕.丒丝下丐万三丒三不();
            this.专七丙丂一一丂丂丌(丒丟七三丝丝丐丂丛:  true);
            return;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != true)
        {
                if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_18;
        }
        
        }
        
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                val_28 = 1152921505084108800;
            MiniGamesController val_5 = MiniGamesController.丑七不且上丗丁一世();
            if(val_5.playerDead != true)
        {
                if(val_6.isEnd == false)
        {
            goto label_29;
        }
        
        }
        
            MiniGamesController.丑七不且上丗丁一世().七丘丈丛世与丘万丝(丛与丙丒丒下丌丟且:  true);
            MiniGamesController val_7 = MiniGamesController.丑七不且上丗丁一世();
            val_29 = 1152921537513478832;
            val_7.playerDead.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  0);
        }
        else
        {
                label_29:
            丂丘下万丈丘丅一丄.ShowStartInterface();
            val_29 = 1152921537513478832;
        }
        
        if(null != null)
        {
            goto label_96;
        }
        
        label_97:
        label_96:
        1152921505190604800.丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  true);
        return;
        label_7:
        if((TeamDuelController.丅丌丛丏丞上万丛丕 + 24) != 3)
        {
            goto label_40;
        }
        
        TeamDuelController.丅丌丛丏丞上万丛丕.丐丛丕且东下上丐业();
        var val_29 = 0;
        val_29 = val_29 + 1;
        goto label_47;
        label_18:
        丂丘下万丈丘丅一丄.丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  ((X22 + 32) == 0) ? 1 : 0);
        mem2[0] = X22 + 32 + 76;
        if(丂丘下万丈丘丅一丄.丟业上丝七丐丈丅丁() == true)
        {
            goto label_83;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_64;
        }
        
        BattleRoyaleController val_12 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_12.isEnd == true)
        {
            goto label_83;
        }
        
        BattleRoyaleController val_13 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_13.isRunPlayer != false)
        {
                val_31 = null;
            val_31 = null;
        }
        
        label_64:
        if(GameConnect.不专专丂万丝上东丐() == false)
        {
            goto label_72;
        }
        
        MiniGamesController val_15 = MiniGamesController.丑七不且上丗丁一世();
        if(val_15.isEnd == true)
        {
            goto label_83;
        }
        
        label_72:
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_79;
        }
        
        val_32 = null;
        val_32 = null;
        if(DuelController.丄丘七三上丕世丞业.roomStatus == 0)
        {
            goto label_83;
        }
        
        label_79:
        DuelController.丄丘七三上丕世丞业.丒丆且丑业世丅三上();
        this.上不丒丄世丞丈丙三();
        return;
        label_83:
        if((丂丘下万丈丘丅一丄 + 118) == 0)
        {
            goto label_86;
        }
        
        label_120:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_135;
        }
        
        if((丂丘下万丈丘丅一丄 + 118) == 0)
        {
            goto label_91;
        }
        
        label_134:
        丂丘下万丈丘丅一丄.丂丛丆万丐丝下东丑();
        label_135:
        丂丘下万丈丘丅一丄.七丘丈丛世与丘万丝(丛与丙丒丒下丌丟且:  true);
        this.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  0);
        return;
        label_40:
        TeamDuelController.丅丌丛丏丞上万丛丕.ShowStartInterface();
        if(this != null)
        {
            goto label_96;
        }
        
        goto label_97;
        label_86:
        if(GameConnect.不专专丂万丝上东丐() == false)
        {
            goto label_100;
        }
        
        MiniGamesController val_20 = MiniGamesController.丑七不且上丗丁一世();
        if(val_20.isEnd == true)
        {
            goto label_120;
        }
        
        label_100:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_115;
        }
        
        BattleRoyaleController val_22 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_22.isEnd == true)
        {
            goto label_120;
        }
        
        BattleRoyaleController val_23 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_23.isRunPlayer != false)
        {
                val_33 = null;
            val_33 = null;
        }
        
        label_115:
        this.ShowStartInterface();
        return;
        label_47:
        UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  TeamDuelController.丅丌丛丏丞上万丛丕.丗上丙上丏三世且丁(丕丕世且下一与丝与:  0.1f).GetEnumerator());
        return;
        label_91:
        BattleRoyaleController val_27 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_27.isRunPlayer == false)
        {
            goto label_135;
        }
        
        val_34 = null;
        val_34 = null;
        BattleRoyaleController val_28 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_28.playerDead == true)
        {
            goto label_134;
        }
        
        goto label_135;
    }
    internal override bool 丄一下丒七丝与与万()
    {
        string val_30;
        var val_31;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        val_31 = null;
        val_31 = null;
        val_32 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_32 == null)
        {
            goto label_3;
        }
        
        val_32 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_32 == null)
        {
                val_32 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_32.丌不丅不丞东万专专();
        val_30 = val_1.HasValue.丙东专丂世丈丏丁丂();
        if((val_30 != 4) || (((-1452867640) & 1) == 0))
        {
            goto label_8;
        }
        
        val_30 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_62;
        }
        
        val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_33 = val_30.业丆丛丁丈丌丘丛丅() ^ 1;
        return (bool)val_33 & 1;
        label_8:
        val_31 = null;
        label_3:
        if(GameConnect.业丛丛丂一丆丕丗丟() != false)
        {
                val_34 = null;
            val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_34 = null;
            object val_9 = val_30.Item[GameConnect.丟丞丏丝与丙丁丛与];
            if(null == 1)
        {
                return (bool)val_33 & 1;
        }
        
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_28;
        }
        
        val_35 = null;
        val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_35 = null;
        object val_13 = val_30.Item[GameConnect.丟丞丏丝与丙丁丛与];
        if(null == 5)
        {
            goto label_59;
        }
        
        label_28:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_38;
        }
        
        val_36 = null;
        val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_36 = null;
        object val_17 = val_30.Item[GameConnect.丟丞丏丝与丙丁丛与];
        if(null == 7)
        {
            goto label_59;
        }
        
        label_38:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_55;
        }
        
        BattleRoyaleController val_19 = BattleRoyaleController.丑七不且上丗丁一世();
        val_30 = val_19.roomConnectedName;
        if((System.String.op_Equality(a:  val_30, b:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘())) == false)
        {
            goto label_55;
        }
        
        val_30 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_23.isRunPlayer == false)
        {
            goto label_59;
        }
        
        label_55:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_62;
        }
        
        val_37 = null;
        val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_37 = null;
        object val_27 = val_30.Item[GameConnect.丟丞丏丝与丙丁丛与];
        var val_28 = (null == 4) ? 1 : 0;
        return (bool)val_33 & 1;
        label_59:
        val_33 = 1;
        return (bool)val_33 & 1;
        label_62:
        val_33 = 0;
        return (bool)val_33 & 1;
    }
    internal override void 丁三丅东三丅丄丘丙()
    {
        DuelController val_3;
        var val_4;
        var val_5;
        val_3 = this;
        this.丁三丅东三丅丄丘丙();
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = DuelController.丄丘七三上丕世丞业;
        if(val_3 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        DuelController.丄丘七三上丕世丞业.SendGameLeft();
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        var val_19;
        double val_20;
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                return false;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
            goto label_12;
        }
        
        }
        
        }
        
        label_48:
        if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() != true)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
                return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        }
        
        }
        
        }
        
        if(丏业丟一东丂东丘丛 != null)
        {
                丏业丟一东丂东丘丛.isDead = true;
        }
        else
        {
                mem[76] = 1;
        }
        
        丏业丟一东丂东丘丛.playerHealth = 0f;
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        label_12:
        val_19 = null;
        val_19 = null;
        double val_11 = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丝下世丄业丕丑七]);
        if(GameConnect.丕上丐丄三上丝专万() != false)
        {
                val_20 = 60;
            if((System.Math.Abs(丏业丟一东丂东丘丛.timeEndMatch - val_11)) >= val_20)
        {
                return false;
        }
        
        }
        else
        {
                val_20 = val_11;
            if((丏业丟一东丂东丘丛.timeEndMatch & 1) == 0)
        {
                return false;
        }
        
        }
        
        double val_14 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_11 < 0)
        {
                return false;
        }
        
        int val_17 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        if((NetworkStartTable.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  丏业丟一东丂东丘丛.myTeam, 丆丘万七一丐上且丅:  true, 丗不下丆丈丌三丛与:  false)) >= (((val_17 < 0) ? (val_17 + 1) : (val_17)) >> 1))
        {
                return false;
        }
        
        goto label_48;
    }
    protected override void 丟不东丌丕不丐专业()
    {
        var val_4;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_5;
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
        
        if(((-1452392360) & 1) == 0)
        {
                return;
        }
        
        this.丘丁上且不丟丟三世();
    }
    internal override void 丕且丅丞世三不七万()
    {
        int val_6 = this;
        this.丕且丅丞世三不七万();
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                val_6 = MiniGamesController.丑七不且上丗丁一世();
            val_6.OnPlayerRespawn();
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_6 = TeamDuelController.丅丌丛丏丞上万丛丕;
            val_6.丕且丅丞世三不七万();
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        BattleRoyaleController.丑七不且上丗丁一世().OnPlayerRespawn();
    }
    internal override bool 世丕丘不丁东与世丞()
    {
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_12;
        }
        
        }
        
        return (bool)0 & 1;
        label_12:
        bool val_7 = GameConnect.万不丒丌丙万丗东不() ^ 1;
        return (bool)0 & 1;
    }
    internal override bool 专丝上丟丆丝丙丄丈()
    {
        if(GameConnect.丆丁上丟丛业丄丅丝() != false)
        {
                if(丘丑丅三丆丑丌且丝() <= 0)
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() == false)
        {
                return true;
        }
        
        }
        
        }
        
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                if(this != null)
        {
                return this.丘万丈丒下丕且东丁();
        }
        
            return this.丘万丈丒下丕且东丁();
        }
        
        return true;
    }
    internal override void 丝丐不东一一丁丌七()
    {
        var val_14;
        var val_15;
        this.丝丐不东一一丁丌七();
        if(((((GameConnect.不专专丂万丝上东丐() != true) && (GameConnect.业丛丛丂一丆丕丗丟() != true)) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.与丂丝丟丟三丑丝万() != true)) && (GameConnect.万不丒丌丙万丗东不() != true))
        {
                if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        }
        
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_14 = null;
            val_14 = null;
            object val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟下丗丙丕丁丞丞丛];
            Rilisoft.一丟专且三万丞丁丂.东下专丟专丏业七业(东且丒丘下万丐世下:  21884928, 不且东三三丐世下丝:  true);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_15 = null;
            val_15 = null;
            if(null != 0)
        {
                BattleRoyaleController val_12 = BattleRoyaleController.丑七不且上丗丁一世();
            val_12.fadeMusic = true;
        }
        
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() != false)
        {
                return;
        }
        
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_9;
        var val_10;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_11;
        val_10 = null;
        val_10 = null;
        val_11 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_11 != null)
        {
                val_11 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_11 == null)
        {
                val_11 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_11.丌不丅不丞东万专专();
            val_9 = val_1.HasValue.丙东专丂世丈丏丁丂();
            if((val_9 == 4) && (((-1451762744) & 1) != 0))
        {
                val_9 = 1152921505107111936;
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_9.七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        }
        
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                val_9 = MiniGamesController.丑七不且上丗丁一世();
            val_6.isEnd = true;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_9 = BattleRoyaleController.丑七不且上丗丁一世();
            val_8.isEnd = true;
        }
        
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    internal override void 业专丏七丆丏丛七东(丁丁丒丆不丒下丟三 丑丝丑丟丏下丂万丝)
    {
        mem[1152921537514967224] = 丑丝丑丟丏下丂万丝;
        if(static_value_082C10A8 == 0)
        {
                return;
        }
        
        int val_2 = static_value_082C10A8.丘丑丅三丆丑丌且丝();
        int val_3 = static_value_082C10A8.丘丑丅三丆丑丌且丝();
        this.业专丏七丆丏丛七东(丑丝丑丟丏下丂万丝:  丑丝丑丟丏下丂万丝);
    }
    internal void 七丁丕一一丒丂七丑()
    {
        丁丁丒丆不丒下丟三 val_4;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_4 = 1152921537487063744;
        label_5:
        if(((-1451510088) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((val_2 == null) || (null != null))
        {
            goto label_5;
        }
        
        val_2.丛万丙丏丝丗丛丄丐();
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if((this.丗不专世丌丗三丑丝 != false) && (0 != 0))
        {
                0.下万丆七丙下与丂丞(丞丙下万丗丝丄七丝:  val_4, 丒丝下丙万丟丂世丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
        }
        
        this.丗不专世丌丗三丑丝 = true;
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_36;
        bool val_37;
        float val_38;
        int val_39;
        var val_41;
        var val_42;
        float val_43;
        var val_44;
        int val_45;
        System.TimeSpan val_1 = Elapsed;
        double val_2 = val_1._ticks.TotalMinutes;
        System.TimeSpan val_3 = Elapsed;
        double val_4 = val_3._ticks.TotalSeconds;
        if(GameConnect.丘丐丅丌上与丒丞万() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_11;
        }
        
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_14;
        }
        
        label_11:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_17;
        }
        
        val_36 = null;
        val_36 = null;
        val_37 = SiegeController.三三万丆下一丗万丛.丒一丘丘不丕七一不();
        val_38 = SiegeController.三三万丆下一丗万丛.丅一丛丑丒丘丅三下();
        val_39 = TramController.丄丘七三上丕世丞业.丑丛丆三丆丄七丐万();
        丁丁丒丆不丒下丟三 val_22 = 丆丒丑丑丒丘丆丅一.丞丘丑上三丛丛丅下(丂丌丙丝且东丗丙万:  val_39, 丒丒丏丗丁丛丅七丙:  SiegeController.三三万丆下一丗万丛.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_2, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  SiegeController.三三万丆下一丗万丛 + 188), 丘丁七丁不丙不丟上:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  SiegeController.三三万丆下一丗万丛 + 200), 丒丅与丒丑七且丞丛:  val_37, 世丄七东丒丘世丈下:  SiegeController.三三万丆下一丗万丛.丈业且上三且丄丅丄(), 丂丈不丗丝丙丈与不:  val_38, 丟东业专下丄丐丟丁:  SiegeController.三三万丆下一丗万丛.业不丁与业专与丝丂(), 丌丑丁上丂丙与丈丞:  val_4);
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  val_29.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_2, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  val_37 = UnityEngine.Mathf.Max(a:  0, b:  val_45 = GameController.onlineMode + 152), 东丙丂丌丒丏丅丄丕:  val_43 = 0f, 丘丁七丁不丙不丟上:  val_38 = 0f, 丌丑丁上丂丙与丈丞:  val_4);
        label_14:
        val_41 = null;
        val_41 = null;
        if(GameController.onlineMode == 0)
        {
            goto label_37;
        }
        
        val_42 = null;
        val_42 = null;
        val_43 = 0f;
        if(GameController.onlineMode.teamController == 0)
        {
            goto label_50;
        }
        
        val_44 = null;
        val_44 = null;
        val_43 = (float)typeof(TeamController).__il2cppRuntimeField_38;
        val_38 = (float)typeof(TeamController).__il2cppRuntimeField_3C;
        goto label_50;
        label_17:
        val_37 = 丑丛丆三丆丄七丐万();
        丁丁丒丆不丒下丟三 val_28 = 丆丒丑丑丒丘丆丅一.丈东丄丌丅丝不丂丘(丂丌丙丝且东丗丙万:  val_37, 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_2, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  X23 + 118, 丌丑丁上丂丙与丈丞:  val_4);
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  val_29.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_2, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  val_37, 东丙丂丌丒丏丅丄丕:  val_43, 丘丁七丁不丙不丟上:  val_38, 丌丑丁上丂丙与丈丞:  val_4);
        label_37:
        label_50:
        int val_29 = GameController.onlineMode.丘丑丅三丆丑丌且丝();
        if(val_29 >= 1)
        {
                val_45 = GameController.onlineMode.丘丑丅三丆丑丌且丝();
        }
        else
        {
                val_45 = mem[GameController.onlineMode + 152];
        }
        
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  val_29.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_2, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  val_37, 东丙丂丌丒丏丅丄丕:  val_43, 丘丁七丁不丙不丟上:  val_38, 丌丑丁上丂丙与丈丞:  val_4);
    }
    internal override bool 世七丌丟丞且丛七且()
    {
        TimeGameController val_4;
        var val_5;
        var val_6;
        val_4 = TimeGameController.丄丞丁丈与业上丞丟;
        if(val_4 != 0)
        {
                val_4 = TimeGameController.丄丞丁丈与业上丞丟;
            if(TimeGameController.丄丞丁丈与业上丞丟.丒丂世丌东万三下丗 > 0f)
        {
                val_4 = TimeGameController.丄丞丁丈与业上丞丟;
            if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 > 0f)
        {
                val_5 = null;
            val_5 = null;
            val_4 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
            var val_3 = (val_4.Count > 0) ? 1 : 0;
            return (bool)val_6;
        }
        
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    public LegacyModeController()
    {
        this.丗世丕世一与下丗丅 = new System.Collections.Generic.List<Player_move_c>();
        this.丄东丛丟丐丄丈丆丒 = new System.Collections.Generic.List<Player_move_c>();
        this.丅丌一丌丑七业东丁 = "-1";
    }

}
