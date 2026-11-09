using UnityEngine;
public class DailyQuestItem : MonoBehaviour
{
    // Fields
    private Rilisoft.丗丈丒丏丁东一不三 丙丐丏丂丄不七丞丁;
    public UITable awardTable;
    public UILabel coinsCount;
    public UILabel gemsCount;
    public UILabel expCount;
    public UILabel progressLabel;
    public UILabel questDescription;
    public UnityEngine.GameObject coinsObject;
    public UnityEngine.GameObject gemObject;
    public UnityEngine.GameObject expObject;
    public UnityEngine.GameObject getRewardButton;
    public UnityEngine.GameObject toBattleButton;
    public UnityEngine.GameObject completedObject;
    public UnityEngine.GameObject questInProgress;
    public bool itemInLobby;
    public UISprite modeColor;
    public UISprite modeIcon;
    public UnityEngine.GameObject oldQuest;
    public UISprite progressBar;
    public UILabel questsButtonLabel;
    public UnityEngine.GameObject questSkipFrame;
    public TweenScale rewardAnim;
    public UILabel rewardButtonLabel;
    public TweenPosition skipAnimPosition;
    public UIButton skipButton;
    public UILabel viewAllLabel;
    
    // Properties
    private Rilisoft.与不一丝丈万东不丗 且下且丅丗丒且万丝 { get; }
    public bool 且丐丆与丛专丙业丑 { get; }
    
    // Methods
    private Rilisoft.与不一丝丈万东不丗 丙丂丘丁丒丕丙万业()
    {
        var val_2;
        System.Func<Rilisoft.丗丈丒丏丁东一不三, Rilisoft.与不一丝丈万东不丗> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = DailyQuestItem.<>c.<>9__27_0;
        if(val_4 != null)
        {
                return Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<Rilisoft.丗丈丒丏丁东一不三, Rilisoft.与不一丝丈万东不丗>(丄三丅七丆丛与与上:  this.丙丐丏丂丄不七丞丁, 东丑丈丅丌万东丅且:  System.Func<Rilisoft.丗丈丒丏丁东一不三, Rilisoft.与不一丝丈万东不丗> val_1 = null);
        }
        
        val_4 = val_1;
        val_1 = new System.Func<Rilisoft.丗丈丒丏丁东一不三, Rilisoft.与不一丝丈万东不丗>(object:  DailyQuestItem.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.与不一丝丈万东不丗 DailyQuestItem.<>c::丌丛丈三东丅丟丆丞(Rilisoft.丗丈丒丏丁东一不三 丄下丞丄丂丞丝万万));
        DailyQuestItem.<>c.<>9__27_0 = val_4;
        return Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<Rilisoft.丗丈丒丏丁东一不三, Rilisoft.与不一丝丈万东不丗>(丄三丅七丆丛与与上:  this.丙丐丏丂丄不七丞丁, 东丑丈丅丌万东丅且:  val_1);
    }
    public bool get_CanSkip()
    {
        if(this.丙丐丏丂丄不七丞丁 == null)
        {
                return (bool)this.丙丐丏丂丄不七丞丁;
        }
        
        return this.丙丐丏丂丄不七丞丁.丕专且不且丌丟丌丒();
    }
    public void Refresh()
    {
        if(this.itemInLobby != false)
        {
                return;
        }
        
        if(this.丙丐丏丂丄不七丞丁 == null)
        {
                return;
        }
        
        if(this.丙丐丏丂丄不七丞丁.丙丂丘丁丒丕丙万业() == null)
        {
                return;
        }
        
        int val_3 = this.丙丂丘丁丒丕丙万业().丘专上世与丟丝丟丛();
    }
    private void OnEnable()
    {
        if(this.questSkipFrame != 0)
        {
                this.questSkipFrame.SetActive(value:  false);
        }
        
        if(this.rewardAnim != 0)
        {
                this.rewardAnim.enabled = false;
        }
        
        if(this.skipAnimPosition == 0)
        {
                return;
        }
        
        this.skipAnimPosition.enabled = false;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.skipAnimPosition.from, y = val_5.y, z = val_5.z};
    }
    private int 专东丐东丙与丒丒丘(Rilisoft.与不一丝丈万东不丗 丗一下三丐上丏上一)
    {
        if(丗一下三丐上丏上一 == null)
        {
                return 0;
        }
        
        var val_1 = (null == null) ? (丗一下三丐上丏上一) : 0;
        if(null != null)
        {
                return 0;
        }
        
        if(val_1 != 0)
        {
                return val_1.丘丛丆丕且丂业世丌();
        }
        
        return val_1.丘丛丆丕且丂业世丌();
    }
    private string 丙上丙丏一丌一丙丏(Rilisoft.与不一丝丈万东不丗 丗一下三丐上丏上一)
    {
        if(丗一下三丐上丏上一 == null)
        {
                return (string)System.String.alignConst;
        }
        
        if(null == null)
        {
                return 丗一下三丐上丏上一.丕丆丞丂业东与上丅();
        }
        
        return (string)System.String.alignConst;
    }
    public void FillData(int 与丄不丌一世东丁丙)
    {
    
    }
    public void OnGetRewardButtonClick()
    {
    
    }
    public void OnSkipInMainMenuClick()
    {
        this.专丕万丑且丘万业丙();
    }
    public void OnSkipInGameClick()
    {
        this.专丕万丑且丘万业丙();
    }
    private void 专丕万丑且丘万业丙()
    {
        TweenPosition val_17;
        object val_18;
        var val_19;
        System.Action<DailyQuestsBannerController> val_21;
        val_17 = this;
        if(this.丙丐丏丂丄不七丞丁 == null)
        {
            goto label_1;
        }
        
        if(this.丙丐丏丂丄不七丞丁.丕专且不且丌丟丌丒() == false)
        {
            goto label_2;
        }
        
        this.丙丐丏丂丄不七丞丁.丐丆丙丕丂三丄专业();
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_2.Add(key:  "Total", value:  "Skipped");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Daily Quests", 丛东不丒丏丈丄且丕:  val_2);
        Rilisoft.丝且一上一万与丘丈 val_3 = this.丙丐丏丂丄不七丞丁.丙丂丘丁丒丕丙万业();
        if(val_3 == null)
        {
            goto label_10;
        }
        
        val_18 = val_3.业上丙丞丐丄丆丅七();
        goto label_11;
        label_1:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "QuestInfo is null.");
        return;
        label_2:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_37;
        }
        
        UnityEngine.Debug.LogError(message:  "Cannot skip!");
        goto label_37;
        label_10:
        val_18 = 0.业上丙丞丐丄丆丅七();
        label_11:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_12.Add(key:  "Skip", value:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0} / {1}", arg0:  val_18, arg1:  Rilisoft.世丗丙专东一丘丑万.丌丕丟丝丄三丏丑一(丒万丟丅丌丝丟下下:  val_3.丟七丐丂东与丈一一())));
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Daily Quests", 丛东不丒丏丈丄且丕:  val_12);
        val_19 = null;
        val_19 = null;
        val_21 = DailyQuestItem.<>c.<>9__38_0;
        if(val_21 == null)
        {
                System.Action<DailyQuestsBannerController> val_13 = null;
            val_21 = val_13;
            val_13 = new System.Action<DailyQuestsBannerController>(object:  DailyQuestItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DailyQuestItem.<>c::世世丙业丌丙一七丞(DailyQuestsBannerController 丁丂专业丁丅丅丈丙));
            DailyQuestItem.<>c.<>9__38_0 = val_21;
        }
        
        DailyQuestsBannerController val_14 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<DailyQuestsBannerController>(丄三丅七丆丛与与上:  DailyQuestsBannerController.丆丕丝丒不丙且丐丗, 七丐丅专且专七三丆:  val_13);
        if(this.questSkipFrame != 0)
        {
                this.questSkipFrame.SetActive(value:  true);
        }
        
        if(this.skipAnimPosition != 0)
        {
                val_17 = this.skipAnimPosition;
            val_17.enabled = true;
        }
        
        label_37:
        MainMenuQuestSystemListener.业不不且丐且与不与();
    }
    public void OnViewAllButtonClick()
    {
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void 与丛丄世丁丛专一丕(int 丂丛丑东不丅丈一东)
    {
        var val_1;
        ConnectScene.RegimMulty = 丂丛丑东不丅丈一东;
        val_1 = null;
        val_1 = null;
        MainMenuController.丄丞丁丈与业上丞丟.OnClickMultiplyerButton();
    }
    public void OnToBattleButtonClick()
    {
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        string val_21;
        string val_22;
        var val_23;
        var val_24;
        if(this.丙丂丘丁丒丕丙万业() == null)
        {
            goto label_1;
        }
        
        string val_3 = this.丙丂丘丁丒丕丙万业().业上丙丞丐丄丆丅七();
        uint val_4 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_3);
        if(val_4 > 1531656510)
        {
            goto label_3;
        }
        
        if(val_4 > 450784453)
        {
            goto label_4;
        }
        
        if(val_4 == 184512644)
        {
            goto label_5;
        }
        
        if(val_4 == 313133353)
        {
            goto label_6;
        }
        
        if(val_4 != 450784453)
        {
                return;
        }
        
        val_17 = "killWithGrenade";
        goto label_51;
        label_1:
        UnityEngine.Debug.LogError(message:  "Quest is null.");
        return;
        label_3:
        if(val_4 > (-2031621270))
        {
            goto label_11;
        }
        
        if(val_4 > 1989230928)
        {
            goto label_12;
        }
        
        if(val_4 == 1835874072)
        {
            goto label_13;
        }
        
        if(val_4 != 1989230928)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3, b:  "killNpcWithWeapon")) == false)
        {
                return;
        }
        
        val_18 = 1;
        goto label_48;
        label_4:
        if(val_4 > 1077466521)
        {
            goto label_17;
        }
        
        if(val_4 == 831460513)
        {
            goto label_18;
        }
        
        if(val_4 != 1077466521)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3, b:  "surviveWavesInArena")) == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        MainMenuController.丄丞丁丈与业上丞丟.StartSurvivalButton();
        return;
        label_11:
        if(val_4 > (-1876727114))
        {
            goto label_24;
        }
        
        if(val_4 == (-1888189755))
        {
            goto label_25;
        }
        
        if(val_4 != (-1876727114))
        {
                return;
        }
        
        val_17 = "makeSeries";
        goto label_51;
        label_12:
        if(val_4 == (-2031621270))
        {
            goto label_28;
        }
        
        if(val_4 != 2119240360)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3, b:  "killInCampaign")) == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        MainMenuController.丄丞丁丈与业上丞丟.StartCampaingButton();
        return;
        label_17:
        if(val_4 == 1131198989)
        {
            goto label_34;
        }
        
        if(val_4 != 1531656510)
        {
                return;
        }
        
        val_21 = "killFlagCarriers";
        goto label_36;
        label_24:
        if(val_4 == (-1019643275))
        {
            goto label_37;
        }
        
        if(val_4 != (-224143007))
        {
                return;
        }
        
        val_22 = "winInMode";
        goto label_39;
        label_5:
        if((System.String.op_Equality(a:  val_3, b:  "winInMap")) == false)
        {
                return;
        }
        
        Rilisoft.与不一丝丈万东不丗 val_9 = this.丙丂丘丁丒丕丙万业();
        val_23 = static_value_081DACA8;
        val_23 = static_value_081DACA8;
        mem2[0] = val_9.丙上丙丏一丌一丙丏(丗一下三丐上丏上一:  val_9);
        goto label_43;
        label_6:
        val_17 = "killWithWeapon";
        goto label_51;
        label_13:
        val_21 = "captureFlags";
        label_36:
        if((System.String.op_Equality(a:  val_3, b:  val_21)) == false)
        {
                return;
        }
        
        val_18 = 4;
        goto label_48;
        label_18:
        val_22 = "killInMode";
        label_39:
        if((System.String.op_Equality(a:  val_3, b:  val_22)) == false)
        {
                return;
        }
        
        Rilisoft.与不一丝丈万东不丗 val_13 = this.丙丂丘丁丒丕丙万业();
        val_18 = val_13.专东丐东丙与丒丒丘(丗一下三丐上丏上一:  val_13);
        goto label_48;
        label_25:
        val_17 = "breakSeries";
        goto label_51;
        label_28:
        bool val_15 = System.String.op_Equality(a:  val_3, b:  "capturePoints");
        if(val_15 == false)
        {
                return;
        }
        
        val_18 = 5;
        label_48:
        val_15.与丛丄世丁丛专一丕(丂丛丑东不丅丈一东:  5);
        return;
        label_34:
        val_17 = "killViaHeadshot";
        goto label_51;
        label_37:
        val_17 = "revenge";
        label_51:
        if((System.String.op_Equality(a:  val_3, b:  val_17)) == false)
        {
                return;
        }
        
        label_43:
        val_24 = null;
        val_24 = null;
        MainMenuController.丄丞丁丈与业上丞丟.OnClickMultiplyerButton();
    }
    public DailyQuestItem()
    {
    
    }

}
