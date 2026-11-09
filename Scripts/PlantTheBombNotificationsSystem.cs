using UnityEngine;
internal sealed class PlantTheBombNotificationsSystem : PGBehaviour
{
    // Fields
    private string keyTitle_LoseInRound;
    private string keyTitle_WinInRound;
    private string keyTitle_Draw;
    private string Key_TheBombHasBeenPlanted;
    private string Key_DefendThePoint;
    private string Key_DefuseIt;
    private string Key_PlantingABomb;
    private string Key_PlantABomb;
    private string Key_OnOneOfThePointsBeforeRoundEnds;
    private string Key_OrStopTheEnemy;
    private string Key_PreventOpponents;
    private string Key_FromPlantingABombBeforeTheRoundEnds;
    private string Key_Ally;
    private string Key_Enemy;
    private string Key_EnemiesAreDefusingTheBomb;
    private string Key_DontLetThem;
    private string Key_AlliesDefuseTheBomb;
    private string Key_ProtectThem;
    private string Key_PlantedTheBomb;
    private string Key_DefusedTheBomb;
    private string Key_ThaBombHasBeenDefused;
    private string Key_OpposingTeamHasBeenEliminated;
    private string Key_YourTeamHasBeenEliminated;
    private string keyDescription_EnemyTeamDefeated;
    private string keyDescription_YourTeamDefeated;
    private string keyDescription_TimeIsUpBombDontPlaced;
    private string keyDescription_BombDefused;
    private string keyDescription_BombExploded;
    private UnityEngine.Color colBlue;
    private UnityEngine.Color colRed;
    private UnityEngine.Color colOrange;
    private UnityEngine.Color colWhite;
    private UnityEngine.GameObject startingState;
    private UnityEngine.GameObject startingStateIconBomb;
    private UnityEngine.GameObject startingStateIconCutters;
    private UILabel startingStateLabel;
    private UILabel startingStateSublabel;
    private UISprite[] startingStateBgSprites;
    private UnityEngine.GameObject bombProcessState;
    private UnityEngine.GameObject bombProcessStateIconBomb;
    private UnityEngine.GameObject bombProcessStateIconCutters;
    private UILabel bombProcessStateLabel;
    private UILabel bombProcessStateSublabel;
    private UISprite[] bombProcessStateBgSprites;
    private UnityEngine.GameObject bombCompletedState;
    private UnityEngine.GameObject bombCompletedStateIconBomb;
    private UnityEngine.GameObject bombCompletedStateIconCutters;
    private UILabel bombCompletedStateLabel;
    private UILabel bombCompletedStateSublabel;
    private UISprite[] bombCompletedStateBgSprites;
    private UnityEngine.GameObject taskCompletedWithSubHeaderState;
    private UnityEngine.GameObject taskCompletedWithSubHeaderStateIconBomb;
    private UnityEngine.GameObject taskCompletedWithSubHeaderStateIconCutters;
    private UILabel taskCompletedWithSubHeaderStateNickLabel;
    private UITexture taskCompletedWithSubHeaderStateClanTexture;
    private UILabel taskCompletedWithSubHeaderStateLabel;
    private UILabel taskCompletedWithSubHeaderStateSublabel;
    private UISprite[] taskCompletedWithSubHeaderStateBgSprites;
    private WidgetLayout taskCompletedWithSubHeaderStateWidgetLayout;
    private UnityEngine.GameObject taskCompletedState;
    private UnityEngine.GameObject taskCompletedStateIconBomb;
    private UnityEngine.GameObject taskCompletedStateIconCutters;
    private UILabel taskCompletedStateNickLabel;
    private UITexture taskCompletedStateClanTexture;
    private UILabel taskCompletedStateLabel;
    private UISprite[] taskCompletedStateBgSprites;
    private WidgetLayout taskCompletedStateWidgetLayout;
    private UnityEngine.GameObject taskCompletedWithoutNameState;
    private UnityEngine.GameObject taskCompletedWithoutNameStateIconBomb;
    private UnityEngine.GameObject taskCompletedWithoutNameStateIconCutters;
    private UILabel taskCompletedWithoutNameStateLabel;
    private UISprite[] taskCompletedWithoutNameStateBgSprites;
    private UnityEngine.GameObject allEliminatedState;
    private UnityEngine.GameObject allEliminatedStateIconBomb;
    private UnityEngine.GameObject allEliminatedStateIconCutters;
    private UILabel allEliminatedStateLabel;
    private UISprite[] allEliminatedStateBgSprites;
    private UnityEngine.GameObject endingState;
    private UILabel endingStateHeadLabel;
    private UILabel endingStateDescriptionLabel;
    private UISprite[] endingStateBgSprites;
    private float 东丐丄丁丞丟东上丂;
    
    // Methods
    private void Update()
    {
        if(this.东丐丄丁丞丟东上丂 <= 0f)
        {
                return;
        }
        
        if(UnityEngine.Time.time <= this.东丐丄丁丞丟东上丂)
        {
                return;
        }
        
        this.七丂东世业世与不万();
        this.东丐丄丁丞丟东上丂 = 0f;
    }
    private void 上丙七丌丗丏丁丟丈(PlantTheBombNotificationsSystem.世丛世丁上丘丝丑丈 丙丒七丄上与丏丙丙, string 下上丐丆丝丟丝丒不, string 万世丛与丙丞丞三丝, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        UnityEngine.GameObject val_11;
        UILabel val_12;
        var val_13;
        var val_18;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.startingState.SetActive(value:  true);
        this.startingStateIconBomb.SetActive(value:  false);
        this.startingStateIconCutters.SetActive(value:  false);
        if(丙丒七丄上与丏丙丙 == 1)
        {
            goto label_4;
        }
        
        if(丙丒七丄上与丏丙丙 != 0)
        {
            goto label_5;
        }
        
        val_11 = this.startingStateIconBomb;
        if(val_11 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_11 = this.startingStateIconCutters;
        if(val_11 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_11.SetActive(value:  true);
        label_5:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.startingStateLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_12 = this.startingStateSublabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  万世丛与丙丞丞三丝));
        val_13 = 0;
        goto label_13;
        label_25:
        UISprite val_11 = this.startingStateBgSprites[0];
        val_12 = val_11.gameObject.name;
        if((val_12.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_8 = val_11.color;
            val_18 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_9 = val_11.color;
            val_18 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_11, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_13 = 1;
        label_13:
        if(val_13 < this.startingStateBgSprites.Length)
        {
            goto label_25;
        }
        
        float val_12 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_12 = UnityEngine.Time.time + val_12;
        this.东丐丄丁丞丟东上丂 = val_12;
    }
    private void 丂丛三七丕丑上下业(PlantTheBombNotificationsSystem.世丛世丁上丘丝丑丈 丙丒七丄上与丏丙丙, string 下上丐丆丝丟丝丒不, string 万世丛与丙丞丞三丝, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        UnityEngine.GameObject val_11;
        UILabel val_12;
        var val_13;
        var val_18;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.bombProcessState.SetActive(value:  true);
        this.bombProcessStateIconBomb.SetActive(value:  false);
        this.bombProcessStateIconCutters.SetActive(value:  false);
        if(丙丒七丄上与丏丙丙 == 1)
        {
            goto label_4;
        }
        
        if(丙丒七丄上与丏丙丙 != 0)
        {
            goto label_5;
        }
        
        val_11 = this.bombProcessStateIconBomb;
        if(val_11 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_11 = this.bombProcessStateIconCutters;
        if(val_11 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_11.SetActive(value:  true);
        label_5:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.bombProcessStateLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_12 = this.bombProcessStateSublabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  万世丛与丙丞丞三丝));
        val_13 = 0;
        goto label_13;
        label_25:
        UISprite val_11 = this.bombProcessStateBgSprites[0];
        val_12 = val_11.gameObject.name;
        if((val_12.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_8 = val_11.color;
            val_18 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_9 = val_11.color;
            val_18 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_11, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_13 = 1;
        label_13:
        if(val_13 < this.bombProcessStateBgSprites.Length)
        {
            goto label_25;
        }
        
        float val_12 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_12 = UnityEngine.Time.time + val_12;
        this.东丐丄丁丞丟东上丂 = val_12;
    }
    private void 世丌与丆且且丕上丄(PlantTheBombNotificationsSystem.世丛世丁上丘丝丑丈 丙丒七丄上与丏丙丙, string 下上丐丆丝丟丝丒不, string 万世丛与丙丞丞三丝, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        string val_21;
        string val_22;
        var val_23;
        var val_24;
        UnityEngine.GameObject val_25;
        UILabel val_26;
        var val_27;
        var val_32;
        val_21 = 专丘丝丄万丒丞七世;
        val_22 = 七不丁与丐一丈三世;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_23 = null;
            val_23 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟丈丑丒丑专丄下丅)) != false)
        {
                val_24 = null;
            val_24 = null;
            if((System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅])) == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())
        {
                val_22 = "PlantTheBomb/bg_green";
            val_21 = "PlantTheBomb/border_green";
        }
        
        }
        
        }
        
        UnityEngine.Color val_11 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_22);
        UnityEngine.Color val_12 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_21);
        this.七丂东世业世与不万();
        this.bombCompletedState.SetActive(value:  true);
        this.bombCompletedStateIconBomb.SetActive(value:  false);
        this.bombCompletedStateIconCutters.SetActive(value:  false);
        if(丙丒七丄上与丏丙丙 == 1)
        {
            goto label_23;
        }
        
        if(丙丒七丄上与丏丙丙 != 0)
        {
            goto label_24;
        }
        
        val_25 = this.bombCompletedStateIconBomb;
        if(val_25 != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_23:
        val_25 = this.bombCompletedStateIconCutters;
        if(val_25 != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        val_25.SetActive(value:  true);
        label_24:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.bombCompletedStateLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_26 = this.bombCompletedStateSublabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_26, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  万世丛与丙丞丞三丝));
        val_27 = 0;
        goto label_32;
        label_44:
        UISprite val_21 = this.bombCompletedStateBgSprites[0];
        val_26 = val_21.gameObject.name;
        if((val_26.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_18 = val_21.color;
            val_32 = val_12.g;
        }
        else
        {
                UnityEngine.Color val_19 = val_21.color;
            val_32 = val_11.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_21, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_27 = 1;
        label_32:
        if(val_27 < this.bombCompletedStateBgSprites.Length)
        {
            goto label_44;
        }
        
        float val_22 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_22 = UnityEngine.Time.time + val_22;
        this.东丐丄丁丞丟东上丂 = val_22;
    }
    private void 丘丝上丂丟丝丟且丐(string 东且丟丏世丛不丝丙, string 下一不一丁丟丄丑丒, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        UILabel val_11;
        var val_12;
        var val_17;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.endingState.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.endingStateHeadLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  东且丟丏世丛不丝丙));
        val_11 = this.endingStateDescriptionLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_11, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下一不一丁丟丄丑丒));
        val_12 = 0;
        goto label_6;
        label_18:
        UISprite val_11 = this.endingStateBgSprites[0];
        val_11 = val_11.gameObject.name;
        if((val_11.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_8 = val_11.color;
            val_17 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_9 = val_11.color;
            val_17 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_11, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_12 = 1;
        label_6:
        if(val_12 < this.endingStateBgSprites.Length)
        {
            goto label_18;
        }
        
        float val_12 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_12 = UnityEngine.Time.time + val_12;
        this.东丐丄丁丞丟东上丂 = val_12;
    }
    private void 丒丑万丝丏业一丐丘(PlantTheBombNotificationsSystem.世丛世丁上丘丝丑丈 丙丒七丄上与丏丙丙, string 下上丐丆丝丟丝丒不, string 万世丛与丙丞丞三丝, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        UnityEngine.GameObject val_26;
        var val_27;
        var val_28;
        UILabel val_29;
        var val_30;
        var val_35;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.taskCompletedWithSubHeaderState.SetActive(value:  true);
        this.taskCompletedWithSubHeaderStateIconBomb.SetActive(value:  false);
        this.taskCompletedWithSubHeaderStateIconCutters.SetActive(value:  false);
        if(丙丒七丄上与丏丙丙 == 1)
        {
            goto label_4;
        }
        
        if(丙丒七丄上与丏丙丙 != 0)
        {
            goto label_5;
        }
        
        val_26 = this.taskCompletedWithSubHeaderStateIconBomb;
        if(val_26 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_26 = this.taskCompletedWithSubHeaderStateIconCutters;
        if(val_26 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_26.SetActive(value:  true);
        label_5:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_27 = null;
            val_27 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟丈丑丒丑专丄下丅)) != false)
        {
                val_28 = null;
            val_28 = null;
            Player_move_c val_11 = 丘丛丞且一丅丁丏丐.丅丞万万三丛且专丁(丞丅上丏丂且下丅与:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅]));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskCompletedWithSubHeaderStateNickLabel, 丕丗丘丑丛与丑业丒:  val_11.mySkinName.不与丏上丐七丄专且);
            Player_move_c val_16 = 丘丛丞且一丅丁丏丐.丅丞万万三丛且专丁(丞丅上丏丂且下丅与:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅]));
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.taskCompletedWithSubHeaderStateClanTexture, 与万丆丛丒万丝丙丑:  val_16.丟三丏丅世一丟丟上.丏丅业丞丁丌丈与丆);
            if(this.taskCompletedWithSubHeaderStateWidgetLayout != 0)
        {
                this.taskCompletedWithSubHeaderStateWidgetLayout.Reposition();
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskCompletedWithSubHeaderStateLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_29 = this.taskCompletedWithSubHeaderStateSublabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_29, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  万世丛与丙丞丞三丝));
        val_30 = 0;
        goto label_45;
        label_57:
        UISprite val_26 = this.taskCompletedWithSubHeaderStateBgSprites[0];
        val_29 = val_26.gameObject.name;
        if((val_29.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_23 = val_26.color;
            val_35 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_24 = val_26.color;
            val_35 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_26, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_30 = 1;
        label_45:
        if(val_30 < this.taskCompletedWithSubHeaderStateBgSprites.Length)
        {
            goto label_57;
        }
        
        float val_27 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_27 = UnityEngine.Time.time + val_27;
        this.东丐丄丁丞丟东上丂 = val_27;
    }
    private void 七世专下丝丁丑一且(PlantTheBombNotificationsSystem.世丛世丁上丘丝丑丈 丙丒七丄上与丏丙丙, string 下上丐丆丝丟丝丒不, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        var val_25;
        var val_26;
        UnityEngine.GameObject val_27;
        UILabel val_28;
        var val_29;
        var val_34;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.taskCompletedState.SetActive(value:  true);
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_25 = null;
            val_25 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟丈丑丒丑专丄下丅)) != false)
        {
                val_26 = null;
            val_26 = null;
            Player_move_c val_11 = 丘丛丞且一丅丁丏丐.丅丞万万三丛且专丁(丞丅上丏丂且下丅与:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅]));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskCompletedStateNickLabel, 丕丗丘丑丛与丑业丒:  val_11.mySkinName.不与丏上丐七丄专且);
            Player_move_c val_16 = 丘丛丞且一丅丁丏丐.丅丞万万三丛且专丁(丞丅上丏丂且下丅与:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅]));
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.taskCompletedStateClanTexture, 与万丆丛丒万丝丙丑:  val_16.丟三丏丅世一丟丟上.丏丅业丞丁丌丈与丆);
            if(this.taskCompletedStateWidgetLayout != 0)
        {
                this.taskCompletedStateWidgetLayout.Reposition();
        }
        
        }
        
        }
        
        this.taskCompletedStateIconBomb.SetActive(value:  false);
        this.taskCompletedStateIconCutters.SetActive(value:  false);
        if(丙丒七丄上与丏丙丙 == 1)
        {
            goto label_36;
        }
        
        if(丙丒七丄上与丏丙丙 != 0)
        {
            goto label_37;
        }
        
        val_27 = this.taskCompletedStateIconBomb;
        if(val_27 != null)
        {
            goto label_40;
        }
        
        goto label_39;
        label_36:
        val_27 = this.taskCompletedStateIconCutters;
        if(val_27 != null)
        {
            goto label_40;
        }
        
        label_39:
        label_40:
        val_27.SetActive(value:  true);
        label_37:
        val_28 = this.taskCompletedStateLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_28, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_29 = 0;
        goto label_45;
        label_57:
        UISprite val_25 = this.taskCompletedStateBgSprites[0];
        val_28 = val_25.gameObject.name;
        if((val_28.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_22 = val_25.color;
            val_34 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_23 = val_25.color;
            val_34 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_25, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_29 = 1;
        label_45:
        if(val_29 < this.taskCompletedStateBgSprites.Length)
        {
            goto label_57;
        }
        
        float val_26 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_26 = UnityEngine.Time.time + val_26;
        this.东丐丄丁丞丟东上丂 = val_26;
    }
    private void 一丘东世丕丕丙七丁(PlantTheBombNotificationsSystem.世丛世丁上丘丝丑丈 丙丒七丄上与丏丙丙, string 下上丐丆丝丟丝丒不, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        UnityEngine.GameObject val_10;
        UILabel val_11;
        var val_12;
        var val_17;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.taskCompletedWithoutNameState.SetActive(value:  true);
        this.taskCompletedWithoutNameStateIconBomb.SetActive(value:  false);
        this.taskCompletedWithoutNameStateIconCutters.SetActive(value:  false);
        if(丙丒七丄上与丏丙丙 == 1)
        {
            goto label_4;
        }
        
        if(丙丒七丄上与丏丙丙 != 0)
        {
            goto label_5;
        }
        
        val_10 = this.taskCompletedWithoutNameStateIconBomb;
        if(val_10 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_10 = this.taskCompletedWithoutNameStateIconCutters;
        if(val_10 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_10.SetActive(value:  true);
        label_5:
        val_11 = this.taskCompletedWithoutNameStateLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_11, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_12 = 0;
        goto label_13;
        label_25:
        UISprite val_10 = this.taskCompletedWithoutNameStateBgSprites[0];
        val_11 = val_10.gameObject.name;
        if((val_11.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_7 = val_10.color;
            val_17 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_8 = val_10.color;
            val_17 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_10, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_12 = 1;
        label_13:
        if(val_12 < this.taskCompletedWithoutNameStateBgSprites.Length)
        {
            goto label_25;
        }
        
        float val_11 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_11 = UnityEngine.Time.time + val_11;
        this.东丐丄丁丞丟东上丂 = val_11;
    }
    private void 丘一丗与丛丏丑丞不(string 下上丐丆丝丟丝丒不, string 七不丁与丐一丈三世, string 专丘丝丄万丒丞七世)
    {
        UILabel val_10;
        var val_11;
        var val_16;
        UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  七不丁与丐一丈三世);
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  专丘丝丄万丒丞七世);
        this.七丂东世业世与不万();
        this.allEliminatedState.SetActive(value:  true);
        val_10 = this.allEliminatedStateLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_10, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  下上丐丆丝丟丝丒不));
        val_11 = 0;
        goto label_6;
        label_18:
        UISprite val_10 = this.allEliminatedStateBgSprites[0];
        val_10 = val_10.gameObject.name;
        if((val_10.Contains(value:  "Border")) != false)
        {
                UnityEngine.Color val_7 = val_10.color;
            val_16 = val_2.g;
        }
        else
        {
                UnityEngine.Color val_8 = val_10.color;
            val_16 = val_1.g;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_10, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_11 = 1;
        label_6:
        if(val_11 < this.allEliminatedStateBgSprites.Length)
        {
            goto label_18;
        }
        
        float val_11 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_11 = UnityEngine.Time.time + val_11;
        this.东丐丄丁丞丟东上丂 = val_11;
    }
    private void 七丂东世业世与不万()
    {
        this.startingState.SetActive(value:  false);
        this.bombProcessState.SetActive(value:  false);
        this.bombCompletedState.SetActive(value:  false);
        this.endingState.SetActive(value:  false);
        this.taskCompletedWithSubHeaderState.SetActive(value:  false);
        this.taskCompletedWithoutNameState.SetActive(value:  false);
        this.taskCompletedState.SetActive(value:  false);
        this.allEliminatedState.SetActive(value:  false);
    }
    public void ShowSetBombOnOneOfPoints()
    {
        this.上丙七丌丗丏丁丟丈(丙丒七丄上与丏丙丙:  0, 下上丐丆丝丟丝丒不:  this.Key_PlantABomb, 万世丛与丙丞丞三丝:  this.Key_OnOneOfThePointsBeforeRoundEnds, 七不丁与丐一丈三世:  "PlantTheBomb/bg_yellow", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_yellow");
    }
    public void ShowDontLetEnemiesSetBomb()
    {
        this.上丙七丌丗丏丁丟丈(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.Key_PreventOpponents, 万世丛与丙丞丞三丝:  this.Key_FromPlantingABombBeforeTheRoundEnds, 七不丁与丐一丈三世:  "PlantTheBomb/bg_yellow", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_yellow");
    }
    public void ShowSetBombOrDontLetEnemiesDo()
    {
        this.上丙七丌丗丏丁丟丈(丙丒七丄上与丏丙丙:  0, 下上丐丆丝丟丝丒不:  this.Key_PlantABomb, 万世丛与丙丞丞三丝:  this.Key_OrStopTheEnemy, 七不丁与丐一丈三世:  "PlantTheBomb/bg_yellow", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_yellow");
    }
    public void ShowAlliesSettingBomb()
    {
        this.丂丛三七丕丑上下业(丙丒七丄上与丏丙丙:  0, 下上丐丆丝丟丝丒不:  this.Key_Ally, 万世丛与丙丞丞三丝:  this.Key_PlantingABomb, 七不丁与丐一丈三世:  "PlantTheBomb/bg_blue", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_blue");
    }
    public void ShowAllyDefuseBomb()
    {
        var val_11;
        var val_12;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟丈丑丒丑专丄下丅)) == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅])) == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())
        {
                this.一丘东世丕丕丙七丁(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.Key_DefusedTheBomb, 七不丁与丐一丈三世:  "PlantTheBomb/bg_green", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_green");
            return;
        }
        
        this.七世专下丝丁丑一且(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.Key_ThaBombHasBeenDefused, 七不丁与丐一丈三世:  "PlantTheBomb/bg_blue", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_blue");
    }
    public void ShowEnemyDefuseBomb()
    {
        this.一丘东世丕丕丙七丁(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.keyDescription_BombDefused, 七不丁与丐一丈三世:  "PlantTheBomb/bg_red", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_red");
    }
    public void ShowBombIsPlacedProtectIt()
    {
        var val_11;
        var val_12;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟丈丑丒丑专丄下丅)) == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅])) == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())
        {
                this.世丌与丆且且丕上丄(丙丒七丄上与丏丙丙:  0, 下上丐丆丝丟丝丒不:  this.Key_TheBombHasBeenPlanted, 万世丛与丙丞丞三丝:  this.Key_DefendThePoint, 七不丁与丐一丈三世:  "PlantTheBomb/bg_green", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_green");
            return;
        }
        
        this.丒丑万丝丏业一丐丘(丙丒七丄上与丏丙丙:  0, 下上丐丆丝丟丝丒不:  this.Key_PlantedTheBomb, 万世丛与丙丞丞三丝:  this.Key_DefendThePoint, 七不丁与丐一丈三世:  "PlantTheBomb/bg_blue", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_blue");
    }
    public void ShowAlliesDefusingBomb()
    {
        this.丂丛三七丕丑上下业(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.Key_AlliesDefuseTheBomb, 万世丛与丙丞丞三丝:  this.Key_ProtectThem, 七不丁与丐一丈三世:  "PlantTheBomb/bg_blue", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_blue");
    }
    public void ShowEnemiesSettingBomb()
    {
        this.丂丛三七丕丑上下业(丙丒七丄上与丏丙丙:  0, 下上丐丆丝丟丝丒不:  this.Key_Enemy, 万世丛与丙丞丞三丝:  this.Key_PlantingABomb, 七不丁与丐一丈三世:  "PlantTheBomb/bg_red", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_red");
    }
    public void ShowBombIsPlacedDefuseIt()
    {
        this.世丌与丆且且丕上丄(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.Key_TheBombHasBeenPlanted, 万世丛与丙丞丞三丝:  this.Key_DefuseIt, 七不丁与丐一丈三世:  "PlantTheBomb/bg_red", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_red");
    }
    public void ShowEnemiesDefusingBombDontLetThem()
    {
        this.丂丛三七丕丑上下业(丙丒七丄上与丏丙丙:  1, 下上丐丆丝丟丝丒不:  this.Key_EnemiesAreDefusingTheBomb, 万世丛与丙丞丞三丝:  this.Key_DontLetThem, 七不丁与丐一丈三世:  "PlantTheBomb/bg_red", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_red");
    }
    public void ShowEnemiesKilled()
    {
        this.丘一丗与丛丏丑丞不(下上丐丆丝丟丝丒不:  this.Key_OpposingTeamHasBeenEliminated, 七不丁与丐一丈三世:  "PlantTheBomb/bg_blue", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_blue");
    }
    public void ShowMyTeamKilled()
    {
        this.丘一丗与丛丏丑丞不(下上丐丆丝丟丝丒不:  this.Key_YourTeamHasBeenEliminated, 七不丁与丐一丈三世:  "PlantTheBomb/bg_red", 专丘丝丄万丒丞七世:  "PlantTheBomb/border_red");
    }
    internal void 与丑七丗丂丅一不丁(bool 上丈丗丏丞丏世一上 = False)
    {
        float val_3 = 1f;
        val_3 = ((上丈丗丏丞丏世一上 != true) ? -1f : (val_3)) + UnityEngine.Time.time;
        this.东丐丄丁丞丟东上丂 = val_3;
    }
    public void ShowResults(PlantTheBombController.世丑丗三丙丒丈丒丏 且丅丕三不丛专一丘, int 丕丗丞丞丑丘丛丂且)
    {
        var val_7;
        string val_10;
        string val_11;
        this.七丂东世业世与不万();
        val_7 = null;
        val_7 = null;
        int val_1 = 丘丑丅三丆丑丌且丝();
        if((且丅丕三不丛专一丘 - 1) <= 4)
        {
                var val_7 = 106039864 + ((且丅丕三不丛专一丘 - 1)) << 2;
            val_7 = val_7 + 106039864;
        }
        else
        {
                val_10 = "";
            val_11 = val_10;
            this.丘丝上丂丟丝丟且丐(东且丟丏世丛不丝丙:  null, 下一不一丁丟丄丑丒:  null, 七不丁与丐一丈三世:  (丕丗丞丞丑丘丛丂且 == 0) ? "PlantTheBomb/bg_yellow" : ((val_1 == 丕丗丞丞丑丘丛丂且) ? "PlantTheBomb/bg_blue" : "PlantTheBomb/bg_red"), 专丘丝丄万丒丞七世:  (丕丗丞丞丑丘丛丂且 == 0) ? "PlantTheBomb/border_yellow" : ((val_1 == 丕丗丞丞丑丘丛丂且) ? "PlantTheBomb/border_blue" : "PlantTheBomb/border_red"));
        }
    
    }
    private void Awake()
    {
        this.七丂东世业世与不万();
        if(PlantTheBombController.丞丞丙丌丙丞与专丒() != false)
        {
                return;
        }
        
        this.ShowStartMessage();
    }
    public void ShowStartMessage()
    {
        this.七丂东世业世与不万();
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.七业丕且万丝丛丝与 != false)
        {
                this.ShowSetBombOrDontLetEnemiesDo();
            return;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamBomberRole != false)
        {
                this.ShowSetBombOnOneOfPoints();
            return;
        }
        
        this.ShowDontLetEnemiesSetBomb();
    }
    public PlantTheBombNotificationsSystem()
    {
    
    }

}
