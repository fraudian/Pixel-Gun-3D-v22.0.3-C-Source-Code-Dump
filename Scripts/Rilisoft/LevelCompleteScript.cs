using UnityEngine;

namespace Rilisoft
{
    internal sealed class LevelCompleteScript : MonoBehaviour
    {
        // Fields
        private const string 丙七一丘与丏东丄万 = "AllStarsForBoxRewardWindowIsShown_";
        private const string 丑丂业丑丟专万丁与 = "AllSecretsForBoxRewardWindowIsShown_";
        internal static Rilisoft.LevelCompleteScript 丗丐丙且丒丙万一丂;
        private static Rilisoft.LevelCompleteScript 丝业丆丁业三丈丟东;
        private static System.Collections.Generic.Dictionary<string, string> 丗专丛且丒丑丆丆且;
        private UnityEngine.AudioSource 万世丌丟丛丈丆一丏;
        private bool 七丙下三丝丘世丁丐;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private ExperienceController 丐东丈丗丅丛丝丙万;
        private bool 丏丒专丏丙丁丐东丁;
        private bool 上丅丐丁丂丈万丄三;
        private bool 丆丑丗丆丒丄丘丛七;
        private string 上丏丏丞丂丘不丟丗;
        private int 下不世丙丌丐丄丞丛;
        private int 丆丞丘丂一丑丈丗丆;
        private ShopNGUIController 三三丒丅丂丝七下丁;
        private bool 丆世世专丄丑丂丂且;
        private bool 丑丛丆丙丟与下三下;
        private bool 丏业一丙且丑丝丙丅;
        private bool 丞丑丞丘丐丛三丄下;
        private bool 丐丂三丑世与丘丆丑;
        private bool 万丙丙丆上一丂丈丝;
        private int 丘丑世与丁丌业丛丑;
        public UnityEngine.GameObject award1coinSprite;
        public UnityEngine.AudioClip awardClip;
        public UnityEngine.GameObject backgroundSurvivalTexture;
        public UnityEngine.GameObject backgroundTexture;
        public UnityEngine.GameObject brightStarPrototypeSprite;
        public UnityEngine.GameObject checkboxSpritePrototype;
        private bool 不丕丑丘丌丗专丈丑;
        public UnityEngine.GameObject darkStarPrototypeSprite;
        public UnityEngine.GameObject facebookButton;
        public UnityEngine.GameObject twitterButton;
        public UnityEngine.GameObject gameOverSprite;
        public UnityEngine.GameObject loadingPanel;
        public UnityEngine.GameObject mainInterface;
        public UnityEngine.GameObject mainPanel;
        public UnityEngine.GameObject menuButton;
        public UILabel[] miniGameMatchPriceLabel;
        public UnityEngine.GameObject miniGamePriceContainer;
        public UnityEngine.GameObject miniGamesRetryButton;
        public UnityEngine.GameObject nextButton;
        public UnityEngine.GameObject quitButton;
        public UnityEngine.Transform RentWindowPoint;
        public UnityEngine.GameObject retryButton;
        public CampaignLevelCompleteRewardSettings rewardSettings;
        public RewardWindowBase rewardWindow;
        public RewardWindowBase rewardWindowSurvival;
        public UnityEngine.AudioClip shopButtonSound;
        public Rilisoft.BankShopViewGuiElement shopView;
        public UILabel speedrunCurrentScore;
        public UILabel speedrunBestScore;
        public UnityEngine.GameObject speedrunNewRecordLabel;
        public UnityEngine.GameObject speedrunResultWindow;
        public UnityEngine.AudioClip[] starClips;
        public UnityEngine.GameObject[] statisticLabels;
        public UnityEngine.GameObject survivalResults;
        public ArenaRewardWindowSettings survivalRewardWindowSettings;
        public UILabel[] label1Stars;
        public UILabel[] label2Stars;
        public UILabel[] label3Stars;
        public UnityEngine.GameObject classicArenaResults;
        public UICamera uiCamera;
        private bool <丞下丅与丙丒丝丅丗>k__BackingField;
        private bool <下上丑丝与丅七专且>k__BackingField;
        private static Rilisoft.丈东丒丟丂丑丐丟丟 <与世丙一丏且丐且下>k__BackingField;
        
        // Properties
        internal static bool 丘丕丕一丂丞丑上世 { get; }
        public bool 丕丈与丕丘丈丑东丙 { get; set; }
        public bool 下丟专世丗丛七万且 { get; set; }
        internal static Rilisoft.丈东丒丟丂丑丐丟丟 丑一下丕丟丆丐丁且 { get; set; }
        internal static bool 三丞丛东一丂丆丆与 { get; }
        
        // Methods
        internal static bool 业七三丕下丅丗业丟()
        {
            var val_4;
            Rilisoft.LevelCompleteScript val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = null;
            val_4 = null;
            val_5 = Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂;
            if(val_5 == 0)
            {
                    val_6 = 0;
                return (bool)val_6;
            }
            
            val_7 = null;
            if(Rilisoft.LevelCompleteScript.丄丄一丂丆丟东与下() == true)
            {
                goto label_9;
            }
            
            val_8 = null;
            val_8 = null;
            val_5 = Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂;
            if((Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂.<丞下丅与丙丒丝丅丗>k__BackingField) == false)
            {
                goto label_13;
            }
            
            label_9:
            val_6 = 1;
            return (bool)val_6;
            label_13:
            val_9 = null;
            val_9 = null;
            var val_3 = ((Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂.<下上丑丝与丅七专且>k__BackingField) == true) ? 1 : 0;
            return (bool)val_6;
        }
        public bool get_DisplayLevelResultIsRunning()
        {
            return (bool)this.<丞下丅与丙丒丝丅丗>k__BackingField;
        }
        public void set_DisplayLevelResultIsRunning(bool 丙业与丙丗丝不丈东)
        {
            this.<丞下丅与丙丒丝丅丗>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_DisplaySurvivalResultIsRunning()
        {
            return (bool)this.<下上丑丝与丅七专且>k__BackingField;
        }
        public void set_DisplaySurvivalResultIsRunning(bool 丙业与丙丗丝不丈东)
        {
            this.<下上丑丝与丅七专且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static Rilisoft.丈东丒丟丂丑丐丟丟 丌与三丆丕丈万丙丅()
        {
            null = null;
            return (Rilisoft.丈东丒丟丂丑丐丟丟)Rilisoft.LevelCompleteScript.<与世丙一丏且丐且下>k__BackingField;
        }
        internal static void 一世丕丝丞丌七且丌(Rilisoft.丈东丒丟丂丑丐丟丟 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.LevelCompleteScript.<与世丙一丏且丐且下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丗专丝丐丂丒丌且万()
        {
            null = null;
            return UnityEngine.Object.op_Inequality(x:  Rilisoft.LevelCompleteScript.丝业丆丁业三丈丟东, y:  0);
        }
        private bool 丙不丕丏业专三丟丁(string 丐下丆丌丈世三丈与)
        {
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "AllStarsForBoxRewardWindowIsShown_" + 丐下丆丌丈世三丈与, defaultValue:  0)) == 1) ? 1 : 0;
        }
        private bool 与一与东丑不丛专丒(string 丐下丆丌丈世三丈与)
        {
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "AllSecretsForBoxRewardWindowIsShown_" + 丐下丆丌丈世三丈与, defaultValue:  0)) == 1) ? 1 : 0;
        }
        private void Awake()
        {
            var val_14;
            var val_15;
            var val_17;
            ShopNGUIController.万丟丂与业丟丘一一();
            RewardWindowBase.丝丘丝丏丏东丅专丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丞丑万且业七丐丌丐()));
            val_14 = null;
            val_14 = null;
            Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂 = this;
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindow.hideButton.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindow"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindow.continueButton.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindow"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindow.collect.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindow"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindow.collectAndShare.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindow"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindow.continueAndShare.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindow"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindowSurvival.hideButton.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindowSurvival"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindowSurvival.continueButton.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindowSurvival"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindowSurvival.collect.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindowSurvival"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindowSurvival.continueAndShare.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindowSurvival"));
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.rewardWindowSurvival.collectAndShare.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HideRewardWindowSurvival"));
            this.rewardWindowSurvival.丟丁丑丆丅一丙丂丂(丙业与丙丗丝不丈东:  1);
            this.rewardWindowSurvival.七三丆丅下上丙丕丐(丙业与丙丗丝不丈东:  3);
            val_15 = null;
            val_15 = null;
            if((LevelCompleteScript.<>c.<>9__81_0) == null)
            {
                goto label_31;
            }
            
            label_42:
            this.rewardWindowSurvival.shareAction = LevelCompleteScript.<>c.<>9__81_0;
            this.rewardWindowSurvival.HasReward = false;
            val_17 = null;
            val_17 = null;
            if((LevelCompleteScript.<>c.<>9__81_1) == null)
            {
                goto label_36;
            }
            
            label_46:
            this.rewardWindowSurvival.twitterStatus = LevelCompleteScript.<>c.<>9__81_1;
            this.rewardWindowSurvival.EventTitle = "Arena Survival";
            return;
            label_31:
            LevelCompleteScript.<>c.<>9__81_0 = new System.Action(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelCompleteScript.<>c::丗丘且丂丞一丌与丞());
            if(this.rewardWindowSurvival != null)
            {
                goto label_42;
            }
            
            goto label_42;
            label_36:
            LevelCompleteScript.<>c.<>9__81_1 = new System.Func<System.String>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelCompleteScript.<>c::三丘丟世丏丁丏七丈());
            if(this.rewardWindowSurvival != null)
            {
                goto label_46;
            }
            
            goto label_46;
        }
        private void 丞丑万且业七丐丌丐()
        {
            int val_1 = this.下不世丙丌丐丄丞丛;
            val_1 = val_1 + 1;
            this.下不世丙丌丐丄丞丛 = val_1;
        }
        internal static bool 上丄丑下与丄丞专一()
        {
            null = null;
            if(丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 != null)
            {
                    return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.Equals(value:  "School");
            }
            
            return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.Equals(value:  "School");
        }
        internal static bool 东丆丝七与丁与世丘()
        {
            null = null;
            if(丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 != null)
            {
                    return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.StartsWith(value:  "Gluk");
            }
            
            return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.StartsWith(value:  "Gluk");
        }
        internal static bool 丒丐丆世世不世丌丆()
        {
            null = null;
            if(丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 != null)
            {
                    return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.StartsWith(value:  "Code_campaign3");
            }
            
            return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.StartsWith(value:  "Code_campaign3");
        }
        internal static bool 东丂丑丆丌七丕丈丑()
        {
            null = null;
            if(丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 != null)
            {
                    return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.StartsWith(value:  "cubic_arena_campaign4");
            }
            
            return 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万.StartsWith(value:  "cubic_arena_campaign4");
        }
        private static void 丝丏丞丆丐七不丒七()
        {
            var val_13;
            string val_14;
            string val_15;
            var val_16;
            .丏丈丕世丝丆东丆丑 = System.String.alignConst;
            val_13 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() == false)
            {
                goto label_4;
            }
            
            var val_7 = (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1) ? "Block_Survivor_id" : ((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8) ? "block_world_id" : "CgkIr8rGkPIJEAIQCA");
            val_15 = "Block World Survivor";
            goto label_7;
            label_4:
            if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() == false)
            {
                goto label_8;
            }
            
            val_14 = "CgkIr8rGkPIJEAIQCQ";
            val_15 = "Dragon Slayer";
            label_7:
            .丏丈丕世丝丆东丆丑 = val_15;
            label_8:
            if((System.String.IsNullOrEmpty(value:  val_14)) != false)
            {
                    val_16 = null;
                val_16 = null;
                UnityEngine.Debug.LogWarning(message:  "Achievement Box Completed: id is null. Scene: "("Achievement Box Completed: id is null. Scene: ") + 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万);
                return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    AGSAchievementsClient.UpdateAchievementProgress(achievementId:  val_14, progress:  100f, userData:  0);
                object[] val_11 = new object[1];
                val_11[0] = (LevelCompleteScript.丝丞与丞不丝一丁丒)[1152921543032047168].丏丈丕世丝丆东丆丑;
                UnityEngine.Debug.LogFormat(format:  "Achievement {0} completed.", args:  val_11);
                return;
            }
            
            UnityEngine.Social.ReportProgress(achievementID:  val_14, progress:  100, callback:  new System.Action<System.Boolean>(object:  new LevelCompleteScript.丝丞与丞不丝一丁丒(), method:  System.Void LevelCompleteScript.丝丞与丞不丝一丁丒::下丅东丆丐万丈丐七(bool 丐万丗丒下七丟丁三)));
        }
        private System.Collections.IEnumerator 万丏业丌与七业丅丝()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LevelCompleteScript.专且万丂丁丅丄丟三(丗丏丅丕丆世丁专丟:  0);
        }
        private static string 丛丌丌东丄专不不丑(out 丞丏丙一丘丌与业丌 三七丄七丒丁丂丘东)
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            三七丄七丒丁丂丘东 = 下与业丆下三丅丅丝.与丘不丌丂三丆丂丈(专万丟三世业丙丈且:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万);
            val_7 = null;
            if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() != false)
            {
                    val_8 = "???";
                return (string)val_8;
            }
            
            if(三七丄七丒丁丂丘东 != null)
            {
                    if(三七丄七丒丁丂丘东.丒丝丛丁世业与专与() != null)
            {
                    string val_6 = 三七丄七丒丁丂丘东.丒丝丛丁世业与专与();
                string val_5 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_6);
                val_6 = (val_5 == null) ? "FARM" : (val_5);
                if(val_6 != 0)
            {
                    return val_6.Replace(oldValue:  "\n", newValue:  " ");
            }
            
                return val_6.Replace(oldValue:  "\n", newValue:  " ");
            }
            
            }
            
            val_8 = "FARM";
            return (string)val_8;
        }
        private void 丕三丟与丁业丟上丁()
        {
            var val_28;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            string val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            var val_101;
            var val_102;
            var val_103;
            var val_104;
            var val_105;
            var val_106;
            var val_107;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  12);
            if(this.七丙下三丝丘世丁丐 != true)
            {
                    if(this.上丅丐丁丂丈万丄三 == false)
            {
                goto label_5;
            }
            
            }
            
            if(this.丘丑世与丁丌业丛丑 != 3)
            {
                goto label_6;
            }
            
            int val_3 = BalanceController.丗丈丅丟丑丕业世七();
            val_81 = val_3;
            if(this.七丙下三丝丘世丁丐 == false)
            {
                goto label_9;
            }
            
            label_13:
            val_81 = val_3.丒一丄丌丂丝下东东().丈业丂专下丝丅上丑() + val_81;
            Rilisoft.LevelCompleteScript.丝丏丞丆丐七不丒七();
            val_82 = 1;
            goto label_12;
            label_6:
            val_81 = 0;
            if(this.七丙下三丝丘世丁丐 == true)
            {
                goto label_13;
            }
            
            label_9:
            val_82 = 0;
            label_12:
            if(val_81 >= 1)
            {
                    BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  0, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  44, 丟世且丕丂丁万丒万:  0);
            }
            
            if(0 < 1)
            {
                goto label_20;
            }
            
            BankController.丐丙东东不丛丂上丛(丌丒丝东丌下丕丁丅:  0, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  44, 丟世且丕丂丁万丒万:  0);
            goto label_20;
            label_5:
            val_82 = 0;
            val_81 = 0;
            label_20:
            val_83 = null;
            val_83 = null;
            if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) != null)
            {
                    var val_8 = (val_7.丒一丅与丞下且丏丐 != 1) ? 1 : 0;
            }
            else
            {
                    val_84 = 1;
            }
            
            val_85 = null;
            val_85 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丘丕且丒丟丄上七丄(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, 丌丐丛丝丒上丟丏下:  System.Math.Max(val1:  this.丆丞丘丂一丑丈丗丆, val2:  this.丘丑世与丁丌业丛丑), 丆丒业专与丘丞业专:  true, 丈丌丗业丆丌丙丂丛:  false);
            if(0 <= 0)
            {
                    if(val_81 < 1)
            {
                goto label_38;
            }
            
            }
            
            UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.万丏业丌与七业丅丝());
            if(0 >= 1)
            {
                    this.丑丛丆丙丟与下三下 = true;
            }
            
            if(val_81 >= 1)
            {
                    this.丆世世专丄丑丂丂且 = true;
            }
            
            label_38:
            if(this.七丙下三丝丘世丁丐 == false)
            {
                goto label_39;
            }
            
            val_86 = null;
            bool val_14 = Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆();
            if(this.七丙下三丝丘世丁丐 == false)
            {
                goto label_42;
            }
            
            val_87 = null;
            bool val_16 = Rilisoft.LevelCompleteScript.东丂丑丆丌七丕丈丑();
            goto label_45;
            label_39:
            label_42:
            label_45:
            .一丟丙丂丒丁丟且专 = System.String.Format(format:  "All enemies {0} {1} are defeated in @PixelGun3D! Join my adventures now! #pixelgun3d #pixelgun #pg3d http://goo.gl/8fzL9u", arg0:  val_17.丄世七丒丏丌丂上丑(), arg1:  Rilisoft.LevelCompleteScript.丛丌丌东丄专不不丑(三七丄七丒丁丂丘东: out  0));
            val_88 = "Level Complete";
            if(this.丆丑丗丆丒丄丘丛七 == false)
            {
                goto label_61;
            }
            
            val_89 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() == false)
            {
                goto label_53;
            }
            
            .一丟丙丂丒丁丟且专 = "I’ve defeated the RIDER in @PixelGun3D! Join my adventures now! #pixelgun3d #pixelgun #3d #pg3d #mobile #fps http://goo.gl/8fzL9u";
            val_90 = "Box 1 Complete";
            goto label_58;
            label_53:
            val_91 = null;
            if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() == false)
            {
                goto label_57;
            }
            
            .一丟丙丂丒丁丟且专 = "I’ve defeated the DRAGON in @PixelGun3D! Join my adventures now! #pixelgun3d #pixelgun #3d #pg3d #mobile #fps http://goo.gl/8fzL9u";
            val_90 = "Box 2 Complete";
            goto label_58;
            label_57:
            val_92 = null;
            if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() == false)
            {
                goto label_61;
            }
            
            .一丟丙丂丒丁丟且专 = "I’ve defeated the EVIL BUG in @PixelGun3D! Join my adventures now! #pixelgun3d #pixelgun #3d #pg3d #mobile #fps http://goo.gl/8fzL9u";
            val_90 = "Box 3 Complete";
            label_58:
            label_61:
            bool val_82 = this.丆丑丗丆丒丄丘丛七;
            val_82 = val_82 ^ 1;
            this.rewardWindow.丟丁丑丆丅一丙丂丂(丙业与丙丗丝不丈东:  val_82 & 255);
            this.rewardWindow.twitterStatus = new System.Func<System.String>(object:  new LevelCompleteScript.与且世丛丗丞三丞且(), method:  System.String LevelCompleteScript.与且世丛丗丞三丞且::丆一丘丒东丗下丕世());
            this.rewardWindow.EventTitle = val_90;
            this.rewardWindow.HasReward = true;
            val_93 = null;
            val_93 = null;
            if((LevelCompleteScript.<>c.<>9__90_1) == null)
            {
                goto label_68;
            }
            
            label_107:
            this.rewardWindow.shareAction = LevelCompleteScript.<>c.<>9__90_1;
            List.Enumerator<T> val_26 = this.rewardSettings.bossDefeatedHeader.GetEnumerator();
            label_103:
            if(((-228762608) & 1) == 0)
            {
                goto label_72;
            }
            
            string val_29 = val_28.丐丏七丌丕丗业且上();
            val_29.gameObject.SetActive(value:  (this.七丙下三丝丘世丁丐 == true) ? 1 : 0);
            if(this.七丙下三丝丘世丁丐 == false)
            {
                goto label_103;
            }
            
            val_95 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() == false)
            {
                goto label_78;
            }
            
            val_29.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1546");
            goto label_103;
            label_78:
            val_96 = null;
            if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() == false)
            {
                goto label_85;
            }
            
            val_29.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1547");
            goto label_103;
            label_85:
            val_97 = null;
            if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() == false)
            {
                goto label_92;
            }
            
            val_29.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1548");
            goto label_103;
            label_92:
            val_98 = null;
            if(Rilisoft.LevelCompleteScript.东丂丑丆丌七丕丈丑() == false)
            {
                goto label_103;
            }
            
            val_29.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6976");
            goto label_103;
            label_68:
            LevelCompleteScript.<>c.<>9__90_1 = new System.Action(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelCompleteScript.<>c::七丟丄丛丄一丝与丌());
            if(this.rewardWindow != null)
            {
                goto label_107;
            }
            
            goto label_107;
            label_72:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_41 = this.rewardSettings.boxCompletedLabels.GetEnumerator();
            label_154:
            if(((-228762608) & 1) == 0)
            {
                goto label_123;
            }
            
            string val_42 = val_28.丐丏七丌丕丗业且上();
            val_42.gameObject.SetActive(value:  (this.七丙下三丝丘世丁丐 == true) ? 1 : 0);
            if(this.七丙下三丝丘世丁丐 == false)
            {
                goto label_154;
            }
            
            val_99 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() == false)
            {
                goto label_129;
            }
            
            val_42.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1549");
            goto label_154;
            label_129:
            val_100 = null;
            if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() == false)
            {
                goto label_136;
            }
            
            val_42.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1550");
            goto label_154;
            label_136:
            val_101 = null;
            if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() == false)
            {
                goto label_143;
            }
            
            val_42.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1551");
            goto label_154;
            label_143:
            val_102 = null;
            if(Rilisoft.LevelCompleteScript.东丂丑丆丌七丕丈丑() == false)
            {
                goto label_154;
            }
            
            val_42.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6977");
            goto label_154;
            label_123:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_53 = this.rewardSettings.missionHeader.GetEnumerator();
            label_173:
            if(((-228762608) & 1) == 0)
            {
                goto label_170;
            }
            
            val_28.丐丏七丌丕丗业且上().gameObject.SetActive(value:  (this.七丙下三丝丘世丁丐 == false) ? 1 : 0);
            goto label_173;
            label_170:
            val_103 = 0;
            val_104 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (991 == 991))
            {
                    val_103 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_104 = 0;
            }
            
            }
            
            var val_57 = (0 == 0) ? 1f : 0.8f;
            this.rewardSettings.coinsReward.gameObject.SetActive(value:  (val_81 > 0) ? 1 : 0);
            this.rewardSettings.coinsReward.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            List.Enumerator<T> val_60 = this.rewardSettings.coinsRewardLabels.GetEnumerator();
            label_195:
            if(((-228762608) & 1) == 0)
            {
                goto label_189;
            }
            
            val_28.丐丏七丌丕丗业且上().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  0)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  0)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0275")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0275"));
            goto label_195;
            label_189:
            val_105 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_105 != 1) && (1147 == 1147))
            {
                    var val_83 = 0;
                val_83 = val_83 ^ 0;
                val_105 = val_105 + val_83;
            }
            else
            {
                    if( != 0)
            {
                    val_104 = 0;
            }
            
            }
            
            this.rewardSettings.coinsMultiplierContainer.SetActive(value:  false);
            this.rewardSettings.gemsReward.gameObject.SetActive(value:  (0 > 0) ? 1 : 0);
            this.rewardSettings.gemsReward.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            List.Enumerator<T> val_67 = this.rewardSettings.gemsRewrdLabels.GetEnumerator();
            label_221:
            if(((-228762608) & 1) == 0)
            {
                goto label_215;
            }
            
            val_28.丐丏七丌丕丗业且上().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  0)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  0)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0951")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0951"));
            goto label_221;
            label_215:
            val_106 = val_105 + 1;
            mem2[0] = 1299;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_106 != 1) && ((-228762720 + ((val_105 + 1)) << 2) == 1299))
            {
                    var val_84 = 0;
                val_84 = val_84 ^ (val_106 >> 31);
                val_106 = val_106 + val_84;
            }
            else
            {
                    if( != 0)
            {
                    val_104 = 0;
            }
            
            }
            
            this.rewardSettings.gemsMultyplierContainer.SetActive(value:  false);
            this.rewardSettings.experienceReward.gameObject.SetActive(value:  false);
            this.rewardSettings.experienceReward.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            List.Enumerator<T> val_73 = this.rewardSettings.experienceRewardLabels.GetEnumerator();
            label_247:
            if(((-228762608) & 1) == 0)
            {
                goto label_241;
            }
            
            val_28.丐丏七丌丕丗业且上().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  0)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  0)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0204")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0204"));
            goto label_247;
            label_241:
            val_106 = val_106 + 1;
            mem2[0] = 1453;
            val_107 = 1152921505359773696;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_106 == 1)
            {
                goto label_254;
            }
            
            if(( == 0) || ((-228762720 + (((val_105 + 1) + 1)) << 2) == 1453))
            {
                goto label_275;
            }
            
            label_274:
            label_275:
            this.rewardSettings.expMultiplier.SetActive(value:  false);
            this.rewardSettings.badcode.gameObject.SetActive(value:  0 & 1);
            val_28 = 0;
            this.rewardSettings.badcode.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.rewardSettings.cubeHead.gameObject.SetActive(value:  false);
            this.rewardSettings.cubeHead.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_254:
            if( != 0)
            {
                goto label_274;
            }
            
            goto label_275;
        }
        private void Start()
        {
            var val_199;
            System.EventHandler val_200;
            var val_201;
            var val_202;
            var val_203;
            var val_204;
            var val_205;
            var val_206;
            var val_207;
            var val_210;
            var val_211;
            var val_212;
            var val_213;
            var val_214;
            string val_215;
            var val_216;
            var val_217;
            var val_218;
            var val_219;
            var val_220;
            System.Func<三丈丟与丏丘丈丐万, System.String> val_222;
            System.Func<三丈丟与丏丘丈丐万, 丑丝丝丟与丌丝不丞<System.Int32, System.Int32>> val_224;
            var val_225;
            var val_226;
            var val_227;
            System.Predicate<下与业丆下三丅丅丝> val_229;
            var val_230;
            System.Func<丞丏丙一丘丌与业丌, System.String> val_232;
            bool val_233;
            int val_234;
            var val_235;
            var val_236;
            var val_237;
            var val_238;
            var val_239;
            var val_240;
            var val_241;
            var val_242;
            var val_243;
            var val_244;
            var val_245;
            var val_247;
            var val_248;
            var val_250;
            var val_251;
            var val_252;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  24);
            if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.Cursor.lockState = 0;
                UnityEngine.Cursor.visible = true;
            }
            
            if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if(GameConnect.万七丄丛丈丟专一丑() == false)
            {
                goto label_10;
            }
            
            }
            
            this.backgroundSurvivalTexture.SetActive(value:  true);
            label_98:
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
            if(Rilisoft.LevelCompleteScript.丌与三丆丕丈万丙丅() == 2)
            {
                    this.丏丒专丏丙丁丐东丁 = true;
                Rilisoft.LevelCompleteScript.一世丕丝丞丌七且丌(丙业与丙丗丝不丈东:  0);
            }
            
            if(this.丏丒专丏丙丁丐东丁 == false)
            {
                goto label_19;
            }
            
            label_60:
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_22;
            }
            
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "Level Failed");
            System.Collections.Generic.IDictionary<System.String, System.String> val_9 = StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世();
            string val_10 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 + " Level Failed";
            goto label_124;
            label_19:
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_36;
            }
            
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "Level Completed");
            System.Collections.Generic.IDictionary<System.String, System.String> val_14 = StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世();
            string val_15 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 + " Level Completed";
            goto label_124;
            label_22:
            if(this.丏丒专丏丙丁丐东丁 == true)
            {
                goto label_48;
            }
            
            goto label_49;
            label_10:
            this.backgroundTexture.SetActive(value:  true);
            if(GameConnect.丛专丌且丕不专丈下() == false)
            {
                goto label_98;
            }
            
            if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() == false)
            {
                goto label_58;
            }
            
            goto label_59;
            label_36:
            if(this.丏丒专丏丙丁丐东丁 == true)
            {
                goto label_60;
            }
            
            label_49:
            if(GameConnect.丌专丌万一下丕专上() == false)
            {
                goto label_63;
            }
            
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "Player quit");
            System.Collections.Generic.IDictionary<System.String, System.String> val_21 = StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世();
            val_199 = "Waves";
            goto label_73;
            label_63:
            if(this.丏丒专丏丙丁丐东丁 == false)
            {
                goto label_77;
            }
            
            label_48:
            if(GameConnect.丌专丌万一下丕专上() == false)
            {
                goto label_77;
            }
            
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "Game over");
            System.Collections.Generic.IDictionary<System.String, System.String> val_27 = StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世();
            val_199 = "Waves";
            goto label_87;
            label_58:
            label_59:
            if(((this.backgroundTexture == 0) || ((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.专专丐业丗丆丕专丆 + System.String.alignConst, 丌丗丏丏丛东专丁且:  "Loading_Speedrun"))) == 0)) || ((this.backgroundTexture.GetComponent<UITexture>()) != null))
            {
                goto label_98;
            }
            
            goto label_98;
            label_87:
            string val_42 = StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Substring(startIndex:  0, length:  StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().IndexOf(value:  " In game"))(StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Substring(startIndex:  0, length:  StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().IndexOf(value:  " In game"))) + " Game over";
            goto label_124;
            label_73:
            string val_49 = StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Substring(startIndex:  0, length:  StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().IndexOf(value:  " In game"))(StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Substring(startIndex:  0, length:  StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().IndexOf(value:  " In game"))) + " Player quit";
            label_124:
            label_77:
            this.丐丂三丑世与丘丆丑 = FacebookController.且丈丄一丁丞丒丑东();
            this.万丙丙丆上一丂丈丝 = TwitterController.上业丗丛三丕丒丗丙();
            this.丐东丈丗丅丛丝丙万 = Rilisoft.LevelCompleteScript.三七三不业丄七丒丏();
            System.EventHandler val_56 = 102751096;
            val_56 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丙不丅丕三丂丐一丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            Rilisoft.LevelCompleteScript.丕丁且七丄东丟丄万(丟丒丞丐丐丘丒丄东:  this.menuButton, 丕丒上丄丒业丕丕丐:  val_56);
            System.EventHandler val_57 = 102751096;
            val_57 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丝丁下丏且丈丑丐丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            Rilisoft.LevelCompleteScript.丕丁且七丄东丟丄万(丟丒丞丐丐丘丒丄东:  this.retryButton, 丕丒上丄丒业丕丕丐:  val_57);
            System.EventHandler val_58 = 102751096;
            val_58 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丈三丈与丒丐丂丑下(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            Rilisoft.LevelCompleteScript.丕丁且七丄东丟丄万(丟丒丞丐丐丘丒丄东:  this.nextButton, 丕丒上丄丒业丕丕丐:  val_58);
            System.EventHandler val_59 = 102751096;
            val_59 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::上丐专与不丟丁丗丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            Rilisoft.LevelCompleteScript.丕丁且七丄东丟丄万(丟丒丞丐丐丘丒丄东:  this.quitButton, 丕丒上丄丒业丕丕丐:  val_59);
            System.EventHandler val_60 = 102751096;
            val_60 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丟丞万丟丄丏三丈丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            Rilisoft.LevelCompleteScript.丕丁且七丄东丟丄万(丟丒丞丐丐丘丒丄东:  this.facebookButton, 丕丒上丄丒业丕丕丐:  val_60);
            System.EventHandler val_61 = 102751096;
            val_200 = val_61;
            val_61 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::专下与三丟丈上丁丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            Rilisoft.LevelCompleteScript.丕丁且七丄东丟丄万(丟丒丞丐丐丘丒丄东:  this.twitterButton, 丕丒上丄丒业丕丕丐:  val_200);
            if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == false)
            {
                goto label_133;
            }
            
            this.shopView.HideButtons = true;
            this.shopView.丝一丅丆三东丂丞七();
            goto label_136;
            label_133:
            if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if(GameConnect.丛专丌且丕不专丈下() != true)
            {
                    if(GameConnect.万七丄丛丈丟专一丑() == false)
            {
                goto label_190;
            }
            
            }
            
            }
            
            this.shopView.且不丄丂上专丗三七(丙业与丙丗丝不丈东:  1);
            this.shopView.ShowTickets = false;
            this.shopView.ShowCoins = true;
            this.shopView.丝一丅丆三东丂丞七();
            System.EventHandler val_66 = 102751096;
            label_190:
            val_200 = val_66;
            val_66 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丘丅专下上上丅三东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.shopView.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  val_200);
            label_136:
            if(GameConnect.上丏丈七丘丁与丅丏() != false)
            {
                    val_201 = null;
                val_201 = null;
                val_200 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                PGCompany.Analytics.一业丗丆世世上丁且.丘丒丑业一丗丞丁丛(丆丛丑世下一丐且丕:  val_200, 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业().ToString(), 丏丈丗世丙万丆丐丅:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, 丌三丒丌丆东万丆一:  (this.丏丒专丏丙丁丐东丁 == false) ? 1 : 0, 专世专丟丝丌与丘上:  1, 与丈业丛丝丒丙一丏:  0, 丝丐丐丟丙丆一丄丗:  0, 下丝丘丁专丐丅丛丝:  0, 丞丗丄七专丈丕丕业:  0, 丕丈一丐丛世丆上万:  new RatingSystem.丁上且上一丆丘与业(), 万三丟世三一不专丛:  4);
                PGCompany.Analytics.一业丗丆世世上丁且.丆丛业上丛丒三丆丗(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false}, 下丝丘丁专丐丅丛丝:  0, 丞丗丄七专丈丕丕业:  0);
            }
            
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_166;
            }
            
            val_202 = null;
            val_202 = null;
            List.Enumerator<T> val_74 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.GetEnumerator();
            label_175:
            if(((-227379872) & 1) == 0)
            {
                goto label_170;
            }
            
            val_203 = 0.丐丏七丌丕丗业且上();
            val_204 = null;
            val_204 = null;
            if((val_200.Equals(value:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与)) == false)
            {
                goto label_175;
            }
            
            val_199 = 1152921525705971664;
            val_205 = 0;
            goto label_176;
            label_184:
            val_206 = null;
            val_206 = null;
            if((val_75.m_stringLength.Item[0].一七与丅上丁丙丂不().Equals(value:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) == true)
            {
                goto label_182;
            }
            
            val_205 = 1;
            label_176:
            if(val_205 != val_75.m_stringLength.Count)
            {
                goto label_184;
            }
            
            goto label_185;
            label_170:
            val_203 = 0;
            label_185:
            val_207 = 0;
            label_182:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_203 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "Current box not found in the list of boxes!");
                this.丆丑丗丆丒丄丘丛七 = true;
                UnityEngine.SceneManagement.Scene val_81 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                string val_82 = val_81.m_Handle.name;
            }
            else
            {
                    int val_84 = 11993091.Count - 1;
                this.丆丑丗丆丒丄丘丛七 = ( >= val_84) ? 1 : 0;
            }
            
            this.上丏丏丞丂丘不丟丗 = 11993091.Item[( < val_84) ? ( + 1) : ()].一七与丅上丁丙丂不();
            this.丆丞丘丂一丑丈丗丆 = 0;
            val_210 = null;
            this.丘丑世与丁丌业丛丑 = Rilisoft.LevelCompleteScript.上下三丆万下上丌丞();
            if(this.丏丒专丏丙丁丐东丁 == true)
            {
                goto label_207;
            }
            
            LevelCompleteScript.丟丐丟丝丝不丈下丒 val_90 = null;
            val_200 = val_90;
            val_90 = new LevelCompleteScript.丟丐丟丝丝不丈下丒();
            val_211 = null;
            val_211 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
            {
                    val_212 = null;
                val_212 = null;
                WeaponManager.丟丗丄业丘丗业丗七.丈东下丄专三业丛万();
            }
            
            val_213 = null;
            val_213 = null;
            不丛专丁世三专三丒 val_93 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与);
            丐丘丛三丙专业丕丄 val_95 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万);
            if((val_95 == null) || (val_95.丌丐丛丝丒上丟丏下 == 0))
            {
                goto label_229;
            }
            
            if((this.丆丑丗丆丒丄丘丛七 != false) && (val_93.丒一丅与丞下且丏丐 == 0))
            {
                    if(Progress.丅丕东丑下世丏丑与.丑万丅丏丞一丟丌丝() == false)
            {
                goto label_229;
            }
            
            }
            
            this.丆丞丘丂一丑丈丗丆 = val_95.丌丐丛丝丒上丟丏下;
            丕七丌下与丙丅丆丅.丗丛丅丕丘且丅丈丟();
            goto label_561;
            label_229:
            this.不丕丑丘丌丗专丈丑 = true;
            if(this.丆丑丗丆丒丄丘丛七 == false)
            {
                goto label_233;
            }
            
            val_214 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() == false)
            {
                goto label_236;
            }
            
            val_215 = "Box 1";
            goto label_246;
            label_233:
            val_216 = 0;
            goto label_238;
            label_236:
            val_217 = null;
            if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() != false)
            {
                    val_215 = "Box 2";
            }
            else
            {
                    val_218 = null;
                if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() != false)
            {
                    val_215 = "Box 3";
            }
            else
            {
                    val_215 = "Box 4";
            }
            
            }
            
            label_246:
            label_238:
            string val_101 = Rilisoft.LevelCompleteScript.丛丌丌东丄专不不丑(三七丄七丒丁丂丘东: out  0);
            Rilisoft.一丟专且三万丞丁丂.丞丏与与东万丄一丕(丞丁丑丏丄丏七丂不:  val_101, 丛一丝丛丏专一业且:  val_215);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_102 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "level", value:  val_101);
            null.Add(key:  "box_level", value:  System.String.Format(format:  "{0}: {1}", arg0:  val_215, arg1:  val_101));
            Rilisoft.丝丄三业丙专丛与不.东三丆丁三下七丑上(丝丏业丅丈东业丝丒:  "campaign_level_reached", 丗丟上上丒丐丗丞丙:  null);
            label_561:
            丕七丌下与丙丅丆丅.东丒丒业丛东与丝业();
            val_219 = null;
            val_219 = null;
            val_199 = 1152921505226227712;
            val_220 = null;
            val_220 = null;
            val_222 = LevelCompleteScript.<>c.<>9__91_0;
            if(val_222 == null)
            {
                    System.Func<三丈丟与丏丘丈丐万, System.String> val_105 = null;
                val_222 = val_105;
                val_105 = new System.Func<三丈丟与丏丘丈丐万, System.String>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelCompleteScript.<>c::一业丑丝丘丆丅丁丄(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
                val_220 = null;
                LevelCompleteScript.<>c.<>9__91_0 = val_222;
            }
            
            val_220 = null;
            val_224 = LevelCompleteScript.<>c.<>9__91_1;
            if(val_224 == null)
            {
                    System.Func<三丈丟与丏丘丈丐万, 丑丝丝丟与丌丝不丞<System.Int32, System.Int32>> val_106 = null;
                val_224 = val_106;
                val_106 = new System.Func<三丈丟与丏丘丈丐万, 丑丝丝丟与丌丝不丞<System.Int32, System.Int32>>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  丑丝丝丟与丌丝不丞<System.Int32, System.Int32> LevelCompleteScript.<>c::丐丘丝业下一专上丈(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
                LevelCompleteScript.<>c.<>9__91_1 = val_224;
                val_199 = 1152921505226227712;
            }
            
            .一上三丟上丒七七丑 = System.Linq.Enumerable.ToDictionary<三丈丟与丏丘丈丐万, System.String, 丑丝丝丟与丌丝不丞<System.Int32, System.Int32>>(source:  WeaponManager.丟丗丄业丘丗业丗七.丅下三且万丟东不下(), keySelector:  val_105, elementSelector:  val_106);
            if(UnityEngine.Application.platform == 8)
            {
                    new System.Action(object:  val_90, method:  System.Void LevelCompleteScript.丟丐丟丝丝不丈下丒::丈丁丐与丈下世与丘()).Invoke();
            }
            
            val_225 = null;
            val_225 = null;
            if((丙不丕丏业专三丟丁(丐下丆丌丈世三丈与:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与).与一与东丑不丛专丒(丐下丆丌丈世三丈与:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与)) != true)
            {
                    val_200 = new LevelCompleteScript.丟不不丈丒下丞丕丆();
                val_200 = new LevelCompleteScript.丟不不丈丒下丞丕丆();
                val_226 = null;
                val_227 = null;
                val_227 = null;
                val_229 = LevelCompleteScript.<>c.<>9__91_4;
                if(val_229 == null)
            {
                    val_229 = null;
                val_229 = new System.Predicate<下与业丆下三丅丅丝>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LevelCompleteScript.<>c::一且丏丈丈丆丏一专(下与业丆下三丅丅丝 丑丝丙业丐与丛世丘));
                LevelCompleteScript.<>c.<>9__91_4 = val_229;
            }
            
                下与业丆下三丅丅丝 val_114 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Find(match:  null);
                val_230 = null;
                val_230 = null;
                val_232 = LevelCompleteScript.<>c.<>9__91_5;
                if(val_232 == null)
            {
                    val_232 = null;
                val_232 = new System.Func<丞丏丙一丘丌与业丌, System.String>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelCompleteScript.<>c::丞丌三丗丞丈且丒三(丞丏丙一丘丌与业丌 丈丘丝一丗下丈丐不));
                LevelCompleteScript.<>c.<>9__91_5 = val_232;
            }
            
                val_199 = 1152921523757905360;
                System.Collections.Generic.HashSet<System.String> val_119 = new System.Collections.Generic.HashSet<System.String>(collection:  CoinBonus.丟丐业东丑丘丐丘东(丆丙丅丝七丒丐丙万:  1));
                .且丘下万一丏专一丛 = null;
                System.Collections.Generic.HashSet<System.String> val_121 = new System.Collections.Generic.HashSet<System.String>(collection:  CoinBonus.丟丐业东丑丘丐丘东(丆丙丅丝七丒丐丙万:  2));
                .业世丆上万丑丈丘下 = null;
                System.Func<System.String, System.Boolean> val_122 = new System.Func<System.String, System.Boolean>(object:  new LevelCompleteScript.丟不不丈丒下丞丕丆(), method:  System.Boolean LevelCompleteScript.丟不不丈丒下丞丕丆::丌丘与一万丝且丗与(string 丐三丞七丝丅不万丛));
                this.丏业一丙且丑丝丙丅 = System.Linq.Enumerable.All<System.String>(source:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丞丏丙一丘丌与业丌, System.String>(source:  val_114.下上不丏专丄丆业世, selector:  null)), predicate:  null);
            }
            
            if(this.丘丑世与丁丌业丛丑 == 3)
            {
                    if((val_95 + 80) == 0)
            {
                goto label_293;
            }
            
            }
            
            label_532:
            this.上丅丐丁丂丈万丄三 = false;
            label_207:
            val_233 = this.丆丑丗丆丒丄丘丛七;
            if(val_233 != false)
            {
                    val_233 = this.不丕丑丘丌丗专丈丑;
                if(val_233 != false)
            {
                    val_233 = (~Progress.丅丕东丑下世丏丑与.丑万丅丏丞一丟丌丝()) & 1;
            }
            
            }
            
            this.七丙下三丝丘世丁丐 = val_233;
            label_166:
            this.survivalResults.SetActive(value:  false);
            this.quitButton.SetActive(value:  false);
            if(this.丏丒专丏丙丁丐东丁 == false)
            {
                goto label_300;
            }
            
            this.award1coinSprite.SetActive(value:  false);
            this.nextButton.SetActive(value:  false);
            this.checkboxSpritePrototype.SetActive(value:  false);
            if(GameConnect.上丏丈七丘丁与丅丏() != false)
            {
                    if(this.gameOverSprite != 0)
            {
                    this.gameOverSprite.SetActive(value:  true);
            }
            
            }
            
            val_234 = 0;
            goto label_311;
            label_317:
            this.statisticLabels[0].SetActive(value:  GameConnect.丌专丌万一下丕专上());
            val_234 = 1;
            label_311:
            if(val_234 < this.statisticLabels.Length)
            {
                goto label_317;
            }
            
            if(GameConnect.上丏丈七丘丁与丅丏() != false)
            {
                    UnityEngine.Vector3 val_133 = this.retryButton.transform.position;
                UnityEngine.Vector3 val_135 = this.menuButton.transform.position;
                val_135.x = val_133.x - val_135.x;
                val_135.x = val_135.x * 0.5f;
                UnityEngine.Vector3 val_138 = this.retryButton.transform.position;
                UnityEngine.Vector3 val_139 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_138.x, y = val_138.y, z = val_138.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.menuButton.transform.position = new UnityEngine.Vector3() {x = val_139.x, y = val_139.y, z = val_139.z};
                UnityEngine.Transform val_140 = this.retryButton.transform;
                UnityEngine.Vector3 val_141 = val_140.position;
                UnityEngine.Vector3 val_142 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_141.x, y = val_141.y, z = val_141.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_140.position = new UnityEngine.Vector3() {x = val_142.x, y = val_142.y, z = val_142.z};
            }
            
            val_200 = GameConnect.上丏丈七丘丁与丅丏();
            this.menuButton.SetActive(value:  val_200);
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_338;
            }
            
            UnityEngine.Coroutine val_147 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner());
            goto label_338;
            label_300:
            if(GameConnect.上丏丈七丘丁与丅丏() != false)
            {
                    this.award1coinSprite.SetActive(value:  true);
            }
            
            val_234 = 0;
            goto label_343;
            label_349:
            val_200 = GameConnect.丌专丌万一下丕专上();
            this.statisticLabels[0].SetActive(value:  val_200);
            val_234 = 1;
            label_343:
            if(val_234 < this.statisticLabels.Length)
            {
                goto label_349;
            }
            
            label_338:
            if(GameConnect.丌专丌万一下丕专上() != false)
            {
                    val_200 = 1152921505286238208;
                val_235 = null;
                val_235 = null;
                if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
            {
                    val_236 = null;
                val_236 = null;
                WeaponManager.丟丗丄业丘丗业丗七.丈东下丄专三业丛万();
            }
            
                val_237 = null;
                val_237 = null;
                WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
            }
            
            val_238 = null;
            val_238 = null;
            Rilisoft.LevelCompleteScript.丝业丆丁业三丈丟东 = this;
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_370;
            }
            
            if(this.七丙下三丝丘世丁丐 != true)
            {
                    if(this.上丅丐丁丂丈万丄三 == false)
            {
                goto label_370;
            }
            
            }
            
            label_388:
            this.mainInterface.SetActive(value:  false);
            this.rewardWindow.gameObject.SetActive(value:  true);
            this.丕三丟与丁业丟上丁();
            goto label_498;
            label_370:
            if(((this.丘丑世与丁丌业丛丑 == 3) && (this.丆丞丘丂一丑丈丗丆 <= 2)) && ((Progress.丅丕东丑下世丏丑与.丑万丅丏丞一丟丌丝() != true) && (this.丏丒专丏丙丁丐东丁 != true)))
            {
                    val_200 = 1152921505061052416;
                val_239 = null;
                val_239 = null;
                if(ExperienceController.sharedController != 0)
            {
                    if(ExperienceController.丞丞丘业东丙丏七丌() <= 64)
            {
                goto label_388;
            }
            
            }
            
            }
            
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_391;
            }
            
            if(this.丏丒专丏丙丁丐东丁 != true)
            {
                    val_240 = null;
                val_240 = null;
                val_200 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万;
                val_234 = System.Math.Max(val1:  this.丆丞丘丂一丑丈丗丆, val2:  this.丘丑世与丁丌业丛丑);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丘丕且丒丟丄上七丄(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  val_200, 丌丐丛丝丒上丟丏下:  val_234, 丆丒业专与丘丞业专:  false, 丈丌丗业丆丌丙丂丛:  false);
            }
            
            this.mainInterface.SetActive(value:  true);
            this.rewardWindow.gameObject.SetActive(value:  false);
            if(this.丏丒专丏丙丁丐东丁 != true)
            {
                    val_200 = 1152921504848912384;
                if(this.brightStarPrototypeSprite != 0)
            {
                    if(this.darkStarPrototypeSprite != 0)
            {
                    UnityEngine.Coroutine val_165 = this.StartCoroutine(routine:  this.下世丌丗丒万业与丞());
            }
            
            }
            
            }
            
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_498;
            }
            
            val_241 = null;
            val_241 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == false)
            {
                goto label_498;
            }
            
            val_242 = 0;
            goto label_416;
            label_422:
            val_200 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6895");
            this.label1Stars[0].text = val_200;
            val_242 = 1;
            label_416:
            if(val_242 < this.label1Stars.Length)
            {
                goto label_422;
            }
            
            val_243 = 0;
            goto label_423;
            label_429:
            val_200 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6896");
            this.label2Stars[0].text = val_200;
            val_243 = 1;
            label_423:
            if(val_243 < this.label2Stars.Length)
            {
                goto label_429;
            }
            
            val_199 = "Key_6897";
            val_234 = 0;
            goto label_430;
            label_436:
            val_200 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6897");
            this.label3Stars[0].text = val_200;
            val_234 = 1;
            label_430:
            if(val_234 < this.label3Stars.Length)
            {
                goto label_436;
            }
            
            goto label_498;
            label_391:
            if(GameConnect.丌专丌万一下丕专上() != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  146);
                val_200 = 1152921505474576384;
                if((Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  12)) < 丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业())
            {
                    Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().专三七丞丂三丏丄东(上且丗一丏丏万丅丌:  12, 万且丒下丕丝专丟上:  丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业());
                val_244 = null;
                val_244 = null;
                val_200 = 丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业();
                FriendsController.丄丞丁丈与业上丞丟.SendScoreInMiniGames(丂丛丑东不丅丈一东:  12, 业丌七业业七丞与丄:  val_200);
            }
            
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                val_245 = null;
                val_245 = null;
                if(丟丌丁且且世丈丈丟.丒且业丝丟下丅丛丛 != false)
            {
                    丟丌丁且且世丈丈丟.丒且业丝丟下丅丛丛 = false;
            }
            
                this.专丐丛丈丏世丁丒与();
            }
            else
            {
                    if(GameConnect.万七丄丛丈丟专一丑() != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  147);
                val_200 = 1152921505474576384;
                if((Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  25)) < 丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业())
            {
                    Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().专三七丞丂三丏丄东(上且丗一丏丏万丅丌:  25, 万且丒下丕丝专丟上:  丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业());
                val_247 = null;
                val_247 = null;
                val_200 = 丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业();
                FriendsController.丄丞丁丈与业上丞丟.SendScoreInMiniGames(丂丛丑东不丅丈一东:  25, 业丌七业业七丞与丄:  val_200);
            }
            
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                val_248 = null;
                val_248 = null;
                if(丟丌丁且且世丈丈丟.丒且业丝丟下丅丛丛 != false)
            {
                    丟丌丁且且世丈丈丟.丒且业丝丟下丅丛丛 = false;
            }
            
                this.丆业万七七不丕丑丄();
            }
            else
            {
                    if(GameConnect.丛专丌且丕不专丈下() != false)
            {
                    this.丆东丐三丞丝不东东();
            }
            
            }
            
            }
            
            label_498:
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                goto label_504;
            }
            
            val_250 = null;
            val_250 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == false)
            {
                goto label_504;
            }
            
            val_251 = 0;
            goto label_505;
            label_511:
            this.label1Stars[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6895");
            val_251 = 1;
            label_505:
            if(val_251 < this.label1Stars.Length)
            {
                goto label_511;
            }
            
            val_199 = "Key_6896";
            val_252 = 0;
            goto label_512;
            label_518:
            this.label2Stars[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6896");
            val_252 = 1;
            label_512:
            if(val_252 < this.label2Stars.Length)
            {
                goto label_518;
            }
            
            val_234 = this.label3Stars;
            val_200 = 0;
            goto label_519;
            label_525:
            val_234[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6897");
            val_200 = 1;
            label_519:
            if(val_200 < this.label3Stars.Length)
            {
                goto label_525;
            }
            
            label_504:
            GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_293:
            var val_206 = ~Progress.丅丕东丑下世丏丑与.丑万丅丏丞一丟丌丝();
            val_206 = val_206 & 1;
            goto label_532;
        }
        private void 丘丅专下上上丅三东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.ShowBankWindow();
        }
        public void HideRewardWindow()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.mainInterface.SetActive(value:  true);
            this.rewardWindow.gameObject.SetActive(value:  false);
            if(GameConnect.上丏丈七丘丁与丅丏() == false)
            {
                    return;
            }
            
            if(this.brightStarPrototypeSprite == 0)
            {
                    return;
            }
            
            if(this.darkStarPrototypeSprite == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.下世丌丗丒万业与丞());
        }
        public void HideRewardWindowSurvival()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.mainInterface.SetActive(value:  true);
            this.rewardWindowSurvival.gameObject.SetActive(value:  false);
            this.专丐丛丈丏世丁丒与();
        }
        private void OnDestroy()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            Rilisoft.LevelCompleteScript.丝业丆丁业三丈丟东 = 0;
            if(this.丐东丈丗丅丛丝丙万 != 0)
            {
                    this.丐东丈丗丅丛丝丙万.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
            }
            
            UnityEngine.PlayerPrefs.Save();
            RewardWindowBase.丑丁世一世丝丈丒丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丞丑万且业七丐丌丐()));
            val_4 = null;
            val_4 = null;
            Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂 = 0;
        }
        public void ShowBankWindow()
        {
            object val_12;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                goto label_3;
            }
            
            val_12 = "ShowBankWindow ShopNGUIController.GuiActive != null";
            goto label_14;
            label_3:
            if(BankController.丑七不且上丗丁一世() != 0)
            {
                goto label_11;
            }
            
            val_12 = "ShowBankWindow bankController == null";
            goto label_14;
            label_11:
            if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() == false)
            {
                goto label_18;
            }
            
            val_12 = "ShowBankWindow InterfaceEnabledCoroutineLocked";
            label_14:
            UnityEngine.Debug.LogWarning(message:  val_12);
            return;
            label_18:
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
            {
                    UnityEngine.Debug.LogError(message:  "Mini game -> GoToMainStore");
                PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  0, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
                return;
            }
            
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainInterface, 丏业丟一东丂东丘丛:  false);
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        }
        private void 丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            object val_9;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                goto label_3;
            }
            
            val_9 = "HandleBackFromBankClicked ShopNGUIController.GuiActive  != null";
            goto label_14;
            label_3:
            if(BankController.丑七不且上丗丁一世() != 0)
            {
                goto label_11;
            }
            
            val_9 = "HandleBackFromBankClicked bankController == null";
            goto label_14;
            label_11:
            if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() == false)
            {
                goto label_18;
            }
            
            val_9 = "HandleBackFromBankClicked InterfaceEnabledCoroutineLocked";
            label_14:
            UnityEngine.Debug.LogWarning(message:  val_9);
            return;
            label_18:
            BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainInterface, 丏业丟一东丂东丘丛:  true);
        }
        internal static bool 丄丄一丂丆丟东与下()
        {
            var val_15;
            Rilisoft.LevelCompleteScript val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_15 = null;
            val_15 = null;
            val_16 = Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂;
            if(val_16 == 0)
            {
                    val_17 = 0;
                return (bool)(val_25 != 0) ? 1 : 0;
            }
            
            val_18 = null;
            val_18 = null;
            if(Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂.rewardWindowSurvival == 0)
            {
                goto label_19;
            }
            
            val_19 = null;
            val_19 = null;
            if(gameObject == 0)
            {
                goto label_19;
            }
            
            val_20 = null;
            val_20 = null;
            val_21 = gameObject.activeInHierarchy;
            goto label_25;
            label_19:
            val_21 = 0;
            label_25:
            val_22 = null;
            val_22 = null;
            val_16 = mem[Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂 + 288];
            val_16 = Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂.rewardWindow;
            if(val_16 == 0)
            {
                goto label_38;
            }
            
            val_23 = null;
            val_23 = null;
            val_16 = gameObject;
            if(val_16 == 0)
            {
                goto label_38;
            }
            
            val_24 = null;
            val_24 = null;
            val_16 = gameObject;
            val_25 = val_16.activeInHierarchy;
            goto label_44;
            label_38:
            val_25 = 0;
            label_44:
            val_25 = val_25 | val_21;
            return (bool)(val_25 != 0) ? 1 : 0;
        }
        private void Update()
        {
            var val_19;
            bool val_20;
            var val_21;
            var val_22;
            if((((this.丐东丈丗丅丛丝丙万 == 0) || (BankController.丑七不且上丗丁一世() == 0)) || (BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)) || (ShopNGUIController.丛世丛与丌不丈丐丐() == true))
            {
                goto label_15;
            }
            
            if(this.RentWindowPoint.childCount == 0)
            {
                    if(this.loadingPanel.activeSelf == false)
            {
                goto label_19;
            }
            
            }
            
            if(this.丐东丈丗丅丛丝丙万 != null)
            {
                goto label_53;
            }
            
            label_54:
            label_53:
            this.丐东丈丗丅丛丝丙万.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
            label_15:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.facebookButton, 丏业丟一东丂东丘丛:  false);
            if(((TwitterController.上业丗丛三丕丒丗丙() == false) || (this.万丙丙丆上一丂丈丝 == false)) || (TwitterController.丂丌与下丛丑丂丐丘() == false))
            {
                goto label_29;
            }
            
            val_19 = TwitterController.丒丆世一与丁丛丐下();
            if(this.twitterButton != null)
            {
                goto label_34;
            }
            
            goto label_33;
            label_29:
            val_19 = 0;
            if(this.twitterButton != null)
            {
                goto label_34;
            }
            
            label_33:
            label_34:
            this.twitterButton.SetActive(value:  false);
            if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() != false)
            {
                    val_20 = (~业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七()) & 1;
            }
            else
            {
                    val_20 = false;
            }
            
            if(val_20 == this.shopView.InteractionEnabled)
            {
                    return;
            }
            
            this.shopView.InteractionEnabled = val_20;
            this.shopView.丝一丅丆三东丂丞七();
            return;
            label_19:
            val_21 = null;
            val_21 = null;
            if(Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂 == 0)
            {
                goto label_48;
            }
            
            val_22 = null;
            var val_17 = (~Rilisoft.LevelCompleteScript.丄丄一丂丆丟东与下()) & 1;
            if(this.丐东丈丗丅丛丝丙万 != null)
            {
                goto label_53;
            }
            
            goto label_54;
            label_48:
            if(this.丐东丈丗丅丛丝丙万 != null)
            {
                goto label_53;
            }
            
            goto label_54;
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丂与丝业丌丈丏上丟()), 与且专丈不万东一万:  "Level Complete");
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        private static void 丕丁且七丄东丟丄万(UnityEngine.GameObject 丟丒丞丐丐丘丒丄东, System.EventHandler 丕丒上丄丒业丕丕丐)
        {
            if(丟丒丞丐丐丘丒丄东 == 0)
            {
                    return;
            }
            
            Rilisoft.ButtonHandler val_2 = 丟丒丞丐丐丘丒丄东.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.add_Clicked(丙业与丙丗丝不丈东:  丕丒上丄丒业丕丕丐);
        }
        private void 丆东丐三丞丝不东东()
        {
            int val_17;
            var val_18;
            var val_19;
            int val_20;
            UnityEngine.GameObject val_21;
            this.<下上丑丝与丅七专且>k__BackingField = true;
            this.menuButton.SetActive(value:  false);
            this.retryButton.SetActive(value:  false);
            this.nextButton.SetActive(value:  false);
            this.shopView.专丌丅下万丐三丗丗();
            this.quitButton.SetActive(value:  false);
            this.speedrunResultWindow.SetActive(value:  true);
            this.speedrunCurrentScore.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业());
            val_17 = Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  13);
            if(val_17 < 丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业())
            {
                    Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().专三七丞丂三丏丄东(上且丗一丏丏万丅丌:  13, 万且丒下丕丝专丟上:  丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业());
                val_18 = null;
                val_18 = null;
                FriendsController.丄丞丁丈与业上丞丟.SendScoreInMiniGames(丂丛丑东不丅丈一东:  13, 业丌七业业七丞与丄:  丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业());
                val_17 = 丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业();
                val_19 = 1;
            }
            else
            {
                    val_19 = 0;
            }
            
            this.speedrunBestScore.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_17);
            this.speedrunNewRecordLabel.SetActive(value:  false);
            new LevelCompleteScript.万丐丘不丝一丏丐世() = new LevelCompleteScript.万丐丘不丝一丏丐世();
            this.miniGamesRetryButton.SetActive(value:  true);
            丌丑丕丏丝丆上东丄 val_12 = BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  13);
            val_20 = val_12.丏上专丐三丛丁丗丆;
            if(new LevelCompleteScript.万丐丘不丝一丏丐世() != null)
            {
                    .专业丛丛丄丟不丛与 = val_20;
                val_21 = this.miniGamePriceContainer;
            }
            else
            {
                    mem[16] = val_20;
                val_21 = this.miniGamePriceContainer;
                val_20 = mem[16];
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  (val_20 > 0) ? 1 : 0);
            System.Action<UILabel> val_14 = new System.Action<UILabel>(object:  new LevelCompleteScript.万丐丘不丝一丏丐世(), method:  System.Void LevelCompleteScript.万丐丘不丝一丏丐世::东丑丁下丂丗一且丝(UILabel 七丐丞丑丑丕世丙七));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.miniGameMatchPriceLabel, 七丐丅专且专七三丆:  null);
            this.shopView.业下丛七业丆丛万丂();
            this.quitButton.SetActive(value:  true);
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner());
            this.<下上丑丝与丅七专且>k__BackingField = false;
        }
        private void 专丐丛丈丏世丁丒与()
        {
            int val_7;
            UnityEngine.GameObject val_8;
            this.<下上丑丝与丅七专且>k__BackingField = true;
            this.menuButton.SetActive(value:  false);
            this.retryButton.SetActive(value:  false);
            this.nextButton.SetActive(value:  false);
            this.shopView.专丌丅下万丐三丗丗();
            this.quitButton.SetActive(value:  false);
            this.survivalResults.SetActive(value:  true);
            new LevelCompleteScript.丟丗东丛丘丂丌七丑() = new LevelCompleteScript.丟丗东丛丘丂丌七丑();
            this.miniGamesRetryButton.SetActive(value:  true);
            丌丑丕丏丝丆上东丄 val_2 = BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  12);
            val_7 = val_2.丏上专丐三丛丁丗丆;
            if(new LevelCompleteScript.丟丗东丛丘丂丌七丑() != null)
            {
                    .专业丛丛丄丟不丛与 = val_7;
                val_8 = this.miniGamePriceContainer;
            }
            else
            {
                    mem[16] = val_7;
                val_8 = this.miniGamePriceContainer;
                val_7 = mem[16];
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  (val_7 > 0) ? 1 : 0);
            System.Action<UILabel> val_4 = new System.Action<UILabel>(object:  new LevelCompleteScript.丟丗东丛丘丂丌七丑(), method:  System.Void LevelCompleteScript.丟丗东丛丘丂丌七丑::丗丁丌丐丁丝丘丂丂(UILabel 七丐丞丑丑丕世丙七));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.miniGameMatchPriceLabel, 七丐丅专且专七三丆:  null);
            this.shopView.业下丛七业丆丛万丂();
            this.quitButton.SetActive(value:  true);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner());
            this.<下上丑丝与丅七专且>k__BackingField = false;
        }
        private void 丆业万七七不丕丑丄()
        {
            int val_7;
            UnityEngine.GameObject val_8;
            this.<下上丑丝与丅七专且>k__BackingField = true;
            this.menuButton.SetActive(value:  false);
            this.retryButton.SetActive(value:  false);
            this.nextButton.SetActive(value:  false);
            this.shopView.专丌丅下万丐三丗丗();
            this.quitButton.SetActive(value:  false);
            this.classicArenaResults.SetActive(value:  true);
            new LevelCompleteScript.丙丁业世一丆下一七() = new LevelCompleteScript.丙丁业世一丆下一七();
            this.miniGamesRetryButton.SetActive(value:  true);
            丌丑丕丏丝丆上东丄 val_2 = BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  25);
            val_7 = val_2.丏上专丐三丛丁丗丆;
            if(new LevelCompleteScript.丙丁业世一丆下一七() != null)
            {
                    .专业丛丛丄丟不丛与 = val_7;
                val_8 = this.miniGamePriceContainer;
            }
            else
            {
                    mem[16] = val_7;
                val_8 = this.miniGamePriceContainer;
                val_7 = mem[16];
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  (val_7 > 0) ? 1 : 0);
            System.Action<UILabel> val_4 = new System.Action<UILabel>(object:  new LevelCompleteScript.丙丁业世一丆下一七(), method:  System.Void LevelCompleteScript.丙丁业世一丆下一七::七与丝丟不万丂且下(UILabel 七丐丞丑丑丕世丙七));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.miniGameMatchPriceLabel, 七丐丅专且专七三丆:  null);
            this.shopView.业下丛七业丆丛万丂();
            this.quitButton.SetActive(value:  true);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner());
            this.<下上丑丝与丅七专且>k__BackingField = false;
        }
        private int 丒一丄丌丂丝下东东()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.List<下与业丆下三丅丅丝> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_6 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_8 = 0;
                val_9 = public 下与业丆下三丅丅丝 System.Collections.Generic.List<下与业丆下三丅丅丝>::get_Item(int index);
            }
            else
            {
                    val_10 = null;
                if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() != false)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
                val_13 = 1152921525697588720;
                val_8 = 1;
            }
            else
            {
                    val_14 = null;
                if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() != false)
            {
                    val_15 = null;
                val_15 = null;
                val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
                val_13 = 1152921525697588720;
                val_8 = 2;
            }
            else
            {
                    val_16 = null;
                if(Rilisoft.LevelCompleteScript.东丂丑丆丌七丕丈丑() == false)
            {
                    return 0;
            }
            
                val_17 = null;
                val_17 = null;
                val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
                val_13 = 1152921525697588720;
                val_8 = 3;
            }
            
            }
            
            }
            
            下与业丆下三丅丅丝 val_5 = val_12.Item[3];
            if(val_5 != null)
            {
                    return val_5.丄丙丌丟丞万丗丝七();
            }
            
            return val_5.丄丙丌丟丞万丗丝七();
        }
        private int 丈业丂专下丝丅上丑()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.List<下与业丆下三丅丅丝> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_6 = null;
            if(Rilisoft.LevelCompleteScript.上丄丑下与丄丞专一() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_8 = 0;
                val_9 = public 下与业丆下三丅丅丝 System.Collections.Generic.List<下与业丆下三丅丅丝>::get_Item(int index);
            }
            else
            {
                    val_10 = null;
                if(Rilisoft.LevelCompleteScript.东丆丝七与丁与世丘() != false)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
                val_13 = 1152921525697588720;
                val_8 = 1;
            }
            else
            {
                    val_14 = null;
                if(Rilisoft.LevelCompleteScript.丒丐丆世世不世丌丆() != false)
            {
                    val_15 = null;
                val_15 = null;
                val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
                val_13 = 1152921525697588720;
                val_8 = 2;
            }
            else
            {
                    val_16 = null;
                if(Rilisoft.LevelCompleteScript.东丂丑丆丌七丕丈丑() == false)
            {
                    return 0;
            }
            
                val_17 = null;
                val_17 = null;
                val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
                val_13 = 1152921525697588720;
                val_8 = 3;
            }
            
            }
            
            }
            
            下与业丆下三丅丅丝 val_5 = val_12.Item[3];
            if(val_5 != null)
            {
                    return val_5.丘专专世上丕丛丆丆();
            }
            
            return val_5.丘专专世上丕丛丆丆();
        }
        private System.Collections.IEnumerator 下世丌丗丒万业与丞()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LevelCompleteScript.世丕丌丗业与丂丕丙(丗丏丅丕丆世丁专丟:  0);
        }
        private static string 三丅与丛丘丂丝丙与()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            if(Rilisoft.LevelCompleteScript.丗专丛且丒丑丆丆且 != null)
            {
                    return Rilisoft.LevelCompleteScript.丗专丛且丒丑丆丆且.Item[丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与];
            }
            
            return Rilisoft.LevelCompleteScript.丗专丛且丒丑丆丆且.Item[丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与];
        }
        private System.Collections.IEnumerator TryToShowExpiredBanner()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LevelCompleteScript.丄丒业丝丁上丌业业(丗丏丅丕丆世丁专丟:  0);
        }
        internal void 丙不丅丕三丂丐一丄(bool 丄丂与东专不丄丞丘)
        {
            ShopNGUIController val_11;
            string val_12;
            val_11 = this;
            if(ExpController.丑七不且上丗丁一世() != 0)
            {
                    if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
            {
                    return;
            }
            
                if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
            {
                    return;
            }
            
            }
            
            val_11 = this.三三丒丅丂丝七下丁;
            if(val_11 != 0)
            {
                    return;
            }
            
            if(GameConnect.上丏丈七丘丁与丅丏() != false)
            {
                    val_12 = "ChooseLevel";
            }
            else
            {
                    val_12 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
            }
            
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  val_12);
        }
        private void 丙不丅丕三丂丐一丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            this.丙不丅丕三丂丐一丄(丄丂与东专不丄丞丘:  false);
        }
        internal void 上丐专与不丟丁丗丞(bool 丄丂与东专不丄丞丘)
        {
            var val_5;
            if(ExpController.丑七不且上丗丁一世() != 0)
            {
                    if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() != false)
            {
                    return;
            }
            
            }
            
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
            this.loadingPanel.SetActive(value:  true);
            this.mainPanel.SetActive(value:  false);
            val_5 = null;
            val_5 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
            this.Invoke(methodName:  "QuitLevel", time:  0.1f);
        }
        private void 上丐专与不丟丁丗丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            this.上丐专与不丟丁丗丞(丄丂与东专不丄丞丘:  false);
        }
        private void QuitLevel()
        {
            UnityEngine.AsyncOperation val_3 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐(), 丂丛丑东不丅丈一东:  0);
        }
        private static void 丆丝丁与七下三丌且()
        {
            var val_4;
            var val_25;
            var val_26;
            val_25 = null;
            val_25 = null;
            val_26 = WeaponManager.丟丗丄业丘丗业丗七.丅下三且万丟东不下();
            List.Enumerator<T> val_2 = val_26.GetEnumerator();
            label_20:
            if(((-222387056) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            int val_6 = val_5.下世万丆丛专丒丑丙();
            int val_7 = val_5.东东丄丅丐一丙一业();
            if((val_7 + val_6) >= (X23.下世下丂丂丌丑丝世() + X22.丟七下专丈丏丕丈上()))
            {
                goto label_11;
            }
            
            val_5.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_6.下世下丂丂丌丑丝世());
            val_5.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_6.丟七下专丈丏丕丈上());
            goto label_20;
            label_11:
            int val_14 = val_5.下世万丆丛专丒丑丙();
            if(val_14 >= val_7.下世下丂丂丌丑丝世())
            {
                goto label_20;
            }
            
            int val_20 = UnityEngine.Mathf.Min(a:  val_14.下世下丂丂丌丑丝世() - val_5.下世万丆丛专丒丑丙(), b:  val_5.东东丄丅丐一丙一业());
            val_5.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_5.下世万丆丛专丒丑丙() + val_20);
            val_5.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_5.东东丄丅丐一丙一业() - val_20);
            goto label_20;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void HandleMiniGamesRetry()
        {
            UnityEngine.GameObject val_13;
            int val_14;
            var val_15;
            System.Action val_17;
            val_13 = this;
            val_14 = 1152921504848912384;
            if(ExpController.丑七不且上丗丁一世() != 0)
            {
                    if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
            {
                    return;
            }
            
            }
            
            if(this.三三丒丅丂丝七下丁 != 0)
            {
                    return;
            }
            
            if(GameConnect.万七丄丛丈丟专一丑() != true)
            {
                    if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if(GameConnect.丛专丌且丕不专丈下() == false)
            {
                    return;
            }
            
            }
            
            }
            
            丌丑丕丏丝丆上东丄 val_10 = BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  GameConnect.丑丌丛丈丅丅与不业());
            val_14 = val_10.丏上专丐三丛丁丗丆;
            val_15 = null;
            val_15 = null;
            val_17 = LevelCompleteScript.<>c.<>9__117_0;
            if(val_17 == null)
            {
                    System.Action val_12 = null;
                val_17 = val_12;
                val_12 = new System.Action(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelCompleteScript.<>c::丘丞万丂不下七且丅());
                LevelCompleteScript.<>c.<>9__117_0 = val_17;
            }
            
            if(val_14 >= 1)
            {
                    val_13 = this.mainInterface;
                上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_13, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_14, 丏丂不专上丘丂不丅:  "TicketsCurrency"), 七丒上且丝业业下七:  val_12, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  102);
                return;
            }
            
            val_12.Invoke();
        }
        private void 丝丁下丏且丈丑丐丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            if(ExpController.丑七不且上丗丁一世() != 0)
            {
                    if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
            {
                    return;
            }
            
                if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
            {
                    return;
            }
            
            }
            
            this = this.三三丒丅丂丝七下丁;
            if(this != 0)
            {
                    return;
            }
            
            Rilisoft.LevelCompleteScript.丆丝丁与七下三丌且();
            丟丌丁且且世丈丈丟.丅下丅丞与下丂丝且(丙业与丙丗丝不丈东:  0);
            MainMenuController.丅与丁丌丝丒七不与();
        }
        private void 丟丞万丟丄丏三丈丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            if(this.三三丒丅丂丝七下丁 != 0)
            {
                    return;
            }
            
            FacebookController.七丒万丒丘东世丌上();
        }
        private void 专下与三丟丈上丁丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            var val_7;
            var val_8;
            if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.Debug.Log(message:  "Send Twitter: "("Send Twitter: ") + this.丒丕世丟东下丗丘东());
                return;
            }
            
            if(this.三三丒丅丂丝七下丁 != 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            if(TwitterController.丗丘丒丈专丘丕世与 == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            TwitterController.丗丘丒丈专丘丕世与.丑与东丒七丁丝三丁(丝丝不丝上丂三丌世:  this.丒丕世丟东下丗丘东(), 丟不丌丁一丆业且丝:  0);
        }
        private void 丈三丈与丒丐丂丑下(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            var val_11;
            var val_12;
            string val_13;
            var val_14;
            var val_15;
            if(ExpController.丑七不且上丗丁一世() != 0)
            {
                    if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
            {
                    return;
            }
            
                if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
            {
                    return;
            }
            
            }
            
            if(this.三三丒丅丂丝七下丁 != 0)
            {
                    return;
            }
            
            if(this.丆丑丗丆丒丄丘丛七 == false)
            {
                goto label_17;
            }
            
            val_11 = null;
            val_11 = null;
            LevelArt.丗业丞丐丙三丆丘丟 = true;
            Rilisoft.SceneLoader val_8 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
            val_12 = mem[LevelArt.三丂丂丘下丕丌下三 == true ? "LevelArt" : "ChooseLevel"];
            val_12 = (LevelArt.三丂丂丘下丕丌下三 == true) ? "LevelArt" : "ChooseLevel";
            val_13 = val_12;
            goto label_21;
            label_17:
            val_14 = null;
            val_14 = null;
            丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 = this.上丏丏丞丂丘不丟丗;
            Rilisoft.LevelCompleteScript.丆丝丁与七下三丌且();
            val_15 = null;
            val_15 = null;
            LevelArt.丗业丞丐丙三丆丘丟 = false;
            if(LevelArt.三丂丂丘下丕丌下三 == false)
            {
                goto label_28;
            }
            
            val_12 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
            val_13 = "LevelArt";
            label_21:
            val_12.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  val_13);
            return;
            label_28:
            MainMenuController.丅与丁丌丝丒七不与();
        }
        private void GoToChooseLevel()
        {
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "ChooseLevel");
        }
        private void 丆一丛丕丏一丞丟丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
        {
            ShopNGUIController val_10;
            var val_11;
            if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
            {
                    return;
            }
            
            val_10 = 1152921504848912384;
            if(this.三三丒丅丂丝七下丁 != 0)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            this.三三丒丅丂丝七下丁 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
            {
                goto label_11;
            }
            
            this.三三丒丅丂丝七下丁.丝丞与丄丆业丛丏专(丗丛不丁丑专专丂且:  false);
            ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
            if(this.shopButtonSound != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.shopButtonSound);
            }
            
            }
            
            if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if(GameConnect.万七丄丛丈丟专一丑() == false)
            {
                goto label_28;
            }
            
            }
            
            if(this.backgroundSurvivalTexture != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            this.backgroundSurvivalTexture.SetActive(value:  false);
            val_10 = this.三三丒丅丂丝七下丁;
            this.三三丒丅丂丝七下丁.丏丐世且丑丅丘丅丟 = new System.Action(object:  this, method:  System.Void Rilisoft.LevelCompleteScript::丞丈丏丈世丛丒丛丞());
            label_11:
            this.quitButton.SetActive(value:  false);
            return;
            label_28:
            if(this.backgroundTexture != null)
            {
                goto label_32;
            }
            
            goto label_33;
        }
        private void 丞丈丏丈世丛丒丛丞()
        {
            var val_10;
            var val_12;
            var val_13;
            bool val_14;
            if(this.三三丒丅丂丝七下丁 == 0)
            {
                    return;
            }
            
            ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
            val_10 = null;
            val_10 = null;
            if((LevelCompleteScript.<>c.<>9__124_0) == null)
            {
                goto label_8;
            }
            
            label_40:
            this.三三丒丅丂丝七下丁.丏丐世且丑丅丘丅丟 = LevelCompleteScript.<>c.<>9__124_0;
            this.三三丒丅丂丝七下丁 = 0;
            val_12 = null;
            val_12 = null;
            if(coinsPlashka.专丆专上丗万世丒七 != 0)
            {
                    val_13 = null;
                val_13 = null;
                coinsPlashka.专丆专上丗万世丒七.enabled = false;
            }
            
            if(GameConnect.丌专丌万一下丕专上() == false)
            {
                goto label_20;
            }
            
            val_14 = 1;
            if(this.quitButton != null)
            {
                goto label_25;
            }
            
            goto label_22;
            label_20:
            val_14 = GameConnect.万七丄丛丈丟专一丑();
            if(this.quitButton != null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            this.quitButton.SetActive(value:  val_14);
            if(this.丐东丈丗丅丛丝丙万 != 0)
            {
                    this.丐东丈丗丅丛丝丙万.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
            }
            
            if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if(GameConnect.万七丄丛丈丟专一丑() == false)
            {
                goto label_35;
            }
            
            }
            
            if(this.backgroundSurvivalTexture != null)
            {
                goto label_41;
            }
            
            label_42:
            label_41:
            this.backgroundSurvivalTexture.SetActive(value:  true);
            return;
            label_8:
            LevelCompleteScript.<>c.<>9__124_0 = new System.Action(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelCompleteScript.<>c::丒丅丂丗丈丄与七丒());
            if(this.三三丒丅丂丝七下丁 != null)
            {
                goto label_40;
            }
            
            goto label_40;
            label_35:
            if(this.backgroundTexture != null)
            {
                goto label_41;
            }
            
            goto label_42;
        }
        private static ExperienceController 三七三不业丄七丒丏()
        {
            var val_9;
            ExperienceController val_10;
            var val_11;
            var val_13;
            val_9 = null;
            val_9 = null;
            val_10 = ExperienceController.sharedController;
            if(val_10 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "Cannot find experience controller.");
            }
            else
            {
                    val_11 = null;
                val_11 = null;
                float val_9 = 21f;
                val_9 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_9;
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_9, y:  val_9);
                ExperienceController.sharedController.posRanks = val_5.x;
                ExperienceController.sharedController.__unknownFiledOffset_38 = val_5.y;
                ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
                val_10 = ExpController.丑七不且上丗丁一世();
                if(val_10 != 0)
            {
                    val_10 = ExpController.丑七不且上丗丁一世();
                val_10.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
            }
            
            }
            
            val_13 = null;
            val_13 = null;
            return (ExperienceController)ExperienceController.sharedController;
        }
        private static int 上下三丆万下上丌丞()
        {
            var val_3 = null;
            return (int)((丅丌丝丘丐不丒丄专.三与且上丘丞上丕下 == true) ? (1 + 1) : 1) + 丅丌丝丘丐不丒丄专.上丏丗丑丏丕且世上;
        }
        private bool 丟丘丒丈东一业世丄()
        {
            if(this.丆丑丗丆丒丄丘丛七 == false)
            {
                    return false;
            }
            
            return (bool)(this.不丕丑丘丌丗专丈丑 == true) ? 1 : 0;
        }
        private string 丒丕世丟东下丗丘东()
        {
            object val_17;
            var val_19;
            var val_20;
            object val_21;
            if(GameConnect.丌专丌万一下丕专上() == false)
            {
                goto label_3;
            }
            
            int val_4 = WavesSurvivedStat.万且下不丟丌丄世丂();
            val_17 = val_4;
            string val_8 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_1382"), arg0:  val_4, arg1:  UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丑丗不东丏丑专丒丕(), defaultValue:  0), arg2:  丟丌丁且且世丈丈丟.丑三三丆丘丒丁丁业());
            goto label_25;
            label_3:
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            val_17 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万;
            SceneInfo val_9 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_17);
            if(val_9 == 0)
            {
                goto label_20;
            }
            
            if(this.丏丒专丏丙丁丐东丁 == false)
            {
                goto label_21;
            }
            
            string val_13 = System.String.Format(format:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_1380"), arg0:  val_9.上丘丙丒一丈丕丈世());
            goto label_25;
            label_20:
            val_21 = "error map";
            return (string)val_21;
            label_21:
            val_17 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_1382");
            label_25:
            val_21 = System.String.Format(format:  val_17, arg0:  val_9.上丘丙丒一丈丕丈世(), arg1:  this.丘丑世与丁丌业丛丑);
            UnityEngine.Debug.Log(message:  val_21);
            return (string)val_21;
        }
        internal static void 丕七一丒丆不与丏丑(bool 丝三丄专丗丞丄丄丌)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Rilisoft.LevelCompleteScript.丝业丆丁业三丈丟东 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            enabled = 丝三丄专丗丞丄丄丌;
        }
        public LevelCompleteScript()
        {
            this.上丏丏丞丂丘不丟丗 = System.String.alignConst;
        }
        private static LevelCompleteScript()
        {
            Rilisoft.LevelCompleteScript.丝业丆丁业三丈丟东 = 0;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "Real", value:  "PIXELATED WORLD");
            }
            else
            {
                    val_1.Add(key:  "Real", value:  "PIXELATED WORLD");
            }
            
            val_1.Add(key:  "minecraft", value:  "BLOCK WORLD");
            val_1.Add(key:  "Crossed", value:  "CROSSED WORLDS");
            Rilisoft.LevelCompleteScript.丗专丛且丒丑丆丆且 = val_1;
        }
        private void 丂与丝业丌丈丏上丟()
        {
            this.丙不丅丕三丂丐一丄(丄丂与东专不丄丞丘:  false);
        }
    
    }

}
