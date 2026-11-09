using UnityEngine;

namespace PGCompany
{
    internal class MainMenuMainPanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject multiplayerButtonInstantGoToMatch;
        public UnityEngine.GameObject modulesTutorialBlocker;
        public UnityEngine.GameObject emailSubscribeBtn;
        public UnityEngine.GameObject starParticleStarterPackGaemObject;
        public UnityEngine.GameObject completeTraining;
        public UnityEngine.GameObject multiplayerButton;
        public UnityEngine.GameObject shopButton;
        private UnityEngine.GameObject tutorialFirstStep;
        private UnityEngine.GameObject 丕与丟丘业丏万丄丌;
        private UnityEngine.Transform _almanachArmoryHintPrefab;
        private float showFirstStepTime;
        public UnityEngine.GameObject settingsButton;
        public UILabel rewardSubscribeBtn;
        public UILabel premiumTime;
        public UIButton developerConsole;
        public UIButton developerAutoTest;
        public UIButton eventHubBanner;
        public Rilisoft.ButtonHandler tasksBtn;
        private UnityEngine.GameObject _compaignGo;
        private UnityEngine.GameObject _battlePassGo;
        private UniversalMiniBannerListUI _miniBannerListUI;
        private bool 丁丞东上丅专丛与丆;
        private float 七业万丘万且七丂业;
        private UnityEngine.Coroutine 丝丈万业下丗上丟丌;
        
        // Properties
        internal UniversalMiniBannerListUI 丝一丂下丙丙且丝下 { get; }
        private bool 丒世丟东丛丞三丝丙 { get; set; }
        internal static bool 丂丞与丄丛丒丅丑丘 { get; }
        private bool 丘万上丏丞丆万丈丌 { get; }
        
        // Methods
        private void Awake()
        {
            PGCompany.TransitionController.丒专丈丁丗丄世丅不(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void PGCompany.MainMenuMainPanel::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
            PGCompany.TransitionController.丛东且丙一丆不丞丁(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void PGCompany.MainMenuMainPanel::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
            PGCompany.TransitionController.丕丐丘丆且丌丒丌不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainMenuMainPanel::丗丁丏一专丁七丝丞()));
        }
        private void OnDestroy()
        {
            PGCompany.TransitionController.丕丆专不丐东不丌丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void PGCompany.MainMenuMainPanel::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
            PGCompany.TransitionController.上世丆丈七丒万丐丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void PGCompany.MainMenuMainPanel::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
            PGCompany.TransitionController.与丄丟上丛且上万丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainMenuMainPanel::丗丁丏一专丁七丝丞()));
        }
        internal UniversalMiniBannerListUI 丂东下与丐丕丌且丏()
        {
            return (UniversalMiniBannerListUI)this._miniBannerListUI;
        }
        public void HandleMultiplayerButtonInstantGoToMatch(object 且丆丏丛东下上丄丟, System.EventArgs 丏丂丅丟上丁东丞丂)
        {
        
        }
        private bool 丑万丗丒丆丈丏丛丄()
        {
            return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  71)) > 0) ? 1 : 0;
        }
        private void 丛丄丂一丞丕专三丝(bool 丙业与丙丗丝不丈东)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  71, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        internal static bool 丞丅与上上丁丛丟丆()
        {
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                    return false;
            }
            
            if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false)
            {
                    return false;
            }
            
            if(AlmanachTutorialManager.TutorialFinished == true)
            {
                    return false;
            }
            
            if(PGCompany.BattlePass.BattlePassLobbyButton.下丛丞丈业东七丟丙() == true)
            {
                    return false;
            }
            
            if(AccountsInAppLobbyButton.HintIsShowing() != false)
            {
                    return false;
            }
            
            if(丅丛丟上丁丆上丛专.不七不丙丏上与三一() == null)
            {
                    return false;
            }
            
            var val_10 = (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count < 2) ? 1 : 0;
            return false;
        }
        private void OnEnable()
        {
            UnityEngine.GameObject val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Func<System.Boolean> val_12;
            System.Action val_14;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._compaignGo, 丏业丟一东丂东丘丛:  true);
                val_7 = this._battlePassGo;
                val_8 = 0;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._compaignGo, 丏业丟一东丂东丘丛:  false);
                val_7 = this._battlePassGo;
                val_8 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
            if(PGCompany.Banners.NewCompetitionBanner.丁七下丌丏丄丟上三() != false)
            {
                    val_9 = static_value_081DACA8;
                val_9 = static_value_081DACA8;
                val_10 = null;
                val_10 = null;
                val_12 = MainMenuMainPanel.<>c.<>9__33_0;
                if(val_12 == null)
            {
                    System.Func<System.Boolean> val_3 = null;
                val_12 = val_3;
                val_3 = new System.Func<System.Boolean>(object:  MainMenuMainPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuMainPanel.<>c::丏三不丐丛丏丘丑丑());
                val_10 = null;
                MainMenuMainPanel.<>c.<>9__33_0 = val_12;
            }
            
                val_10 = null;
                val_14 = MainMenuMainPanel.<>c.<>9__33_1;
                if(val_14 == null)
            {
                    System.Action val_4 = null;
                val_14 = val_4;
                val_4 = new System.Action(object:  MainMenuMainPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuMainPanel.<>c::丕且丙不丁丄丗业丑());
                MainMenuMainPanel.<>c.<>9__33_1 = val_14;
            }
            
                UnityEngine.Coroutine val_5 = CoroutineRunner.丆万七与丏丁丞丂专(且丐丈丕三丟丕丙丒:  val_3, 一丏丘业丅丈东东丄:  val_4);
            }
            
            PGCompany.LobbyEventStoreDelegate.UpdateState();
            丄一世专一丞丙丌丏.不下丑丆丐且丆下与();
            丕丆上下业与丄不与.不下丑丆丐且丆下与();
            PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世().不下丑丆丐且丆下与();
        }
        private void OnDisable()
        {
            PGCompany.LobbyEventStoreDelegate.UpdateState();
            PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世().丒专与三丈一丒丕丑();
        }
        private void 丗丁丏一专丁七丝丞()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        private bool 丐上丒世丘专一丗丄()
        {
            var val_14;
            MainMenuController val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_14 = null;
            val_14 = null;
            val_15 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_15 != null)
            {
                    if(null != 0)
            {
                    bool val_2 = activeInHierarchy;
                val_15 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            }
            
            if(((-1869835796) & 1) != 0)
            {
                    val_16 = val_15.GetValueOrDefault();
            }
            else
            {
                    val_16 = 0;
            }
            
            val_17 = null;
            val_17 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == null)
            {
                goto label_12;
            }
            
            ConnectPanel val_5 = MainMenuController.丄丞丁丈与业上丞丟.丆丂三一丌一丏丁丞();
            if(val_5 == null)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_6 = val_5.gameObject;
            if(val_6 == null)
            {
                goto label_12;
            }
            
            bool val_8 = val_6.activeInHierarchy;
            val_18 = 0;
            val_16 = (MainMenuController.丄丞丁丈与业上丞丟 == 0) ? 0 : (val_16);
            goto label_13;
            label_12:
            val_18 = 0;
            label_13:
            if(((-1869835796) & 1) != 0)
            {
                    val_19 = val_18.GetValueOrDefault() ^ 1;
                return (bool)((val_16 == 0) ? 1 : 0) & val_19;
            }
            
            val_19 = 1;
            return (bool)((val_16 == 0) ? 1 : 0) & val_19;
        }
        private void Start()
        {
            UnityEngine.Transform val_1 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this._almanachArmoryHintPrefab);
            val_1.parent = this.tutorialFirstStep.transform;
            val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            val_1.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            if(val_1 != null)
            {
                    val_1.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            }
            else
            {
                    val_1.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            }
            
            UnityEngine.GameObject val_5 = val_1.gameObject;
            this.丕与丟丘业丏万丄丌 = val_5;
            Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_5, 不东丛三丂丌丑专丆:  this.tutorialFirstStep.layer);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丕与丟丘业丏万丄丌, 丏业丟一东丂东丘丛:  false);
            if(this.丕与丟丘业丏万丄丌.丐上丒世丘专一丗丄() == false)
            {
                    return;
            }
            
            if(this.丁丞东上丅专丛与丆 == true)
            {
                    return;
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  164)) == false)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                    return;
            }
            
            this.丁丞东上丅专丛与丆 = true;
            this.七业万丘万且七丂业 = this.showFirstStepTime;
        }
        private void Update()
        {
            var val_8 = 52781;
            bool val_1 = this.丑万丗丒丆丈丏丛丄();
            if(val_1 != false)
            {
                    return;
            }
            
            if(val_1.丐上丒世丘专一丗丄() == false)
            {
                goto label_5;
            }
            
            if(this.丁丞东上丅专丛与丆 == true)
            {
                goto label_20;
            }
            
            val_8 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_8.丟丂下七且七东丛丞(不七丆万丁一丞七下:  164)) == false)
            {
                goto label_5;
            }
            
            val_8 = 0;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_8;
            }
            
            label_5:
            if(this.丁丞东上丅专丛与丆 == false)
            {
                    return;
            }
            
            label_20:
            if(PGCompany.MainMenuMainPanel.丞丅与上上丁丛丟丆() == false)
            {
                goto label_10;
            }
            
            if(this.七业万丘万且七丂业 <= 0f)
            {
                goto label_11;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丕与丟丘业丏万丄丌, 丏业丟一东丂东丘丛:  true);
            float val_7 = UnityEngine.Time.unscaledDeltaTime;
            val_7 = this.七业万丘万且七丂业 - val_7;
            this.七业万丘万且七丂业 = val_7;
            return;
            label_10:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丕与丟丘业丏万丄丌, 丏业丟一东丂东丘丛:  false);
            return;
            label_11:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丕与丟丘业丏万丄丌, 丏业丟一东丂东丘丛:  false);
            this.丕与丟丘业丏万丄丌.丛丄丂一丞丕专三丝(丙业与丙丗丝不丈东:  true);
            this.丁丞东上丅专丛与丆 = false;
            return;
            label_8:
            this.丁丞东上丅专丛与丆 = true;
            this.七业万丘万且七丂业 = this.showFirstStepTime;
            goto label_20;
        }
        private void 下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)
        {
            var val_13;
            var val_14;
            UnityEngine.MonoBehaviour val_15;
            PGCompany.丑且丆万丏丝丘丙丟 val_2 = PGCompany.TransitionController.丑七不且上丗丁一世().丘丁丒东丒丏上丛丝();
            if(val_2 == null)
            {
                goto label_2;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_6;
            label_2:
            val_13 = 1;
            goto label_7;
            label_6:
            val_13 = val_2.IsVisibleLobbyMenu();
            label_7:
            if(this.丝丈万业下丗上丟丌 != null)
            {
                    CoroutineRunner.Instance.StopCoroutine(routine:  this.丝丈万业下丗上丟丌);
            }
            
            if((val_13 | (~this.isActiveAndEnabled)) != false)
            {
                    val_14 = val_13;
                val_15 = this;
            }
            else
            {
                    if(不丌不世且丄不三丝 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                float val_9 = 不丌不世且丄不三丝.GetDelayTurnOff();
                if(val_9 > 0f)
            {
                    this.丝丈万业下丗上丟丌 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丌丄不七三丘丏丆与(丕丕世且下一与丝与:  val_9));
                return;
            }
            
            }
            
                val_15 = this;
                val_14 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        private System.Collections.IEnumerator 丌丄不七三丘丏丆与(float 丕丕世且下一与丝与)
        {
            MainMenuMainPanel.丕丁丛丛丂业上东七 val_1 = new MainMenuMainPanel.丕丁丛丛丂业上东七();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        public MainMenuMainPanel()
        {
            this.showFirstStepTime = 60f;
        }
    
    }

}
