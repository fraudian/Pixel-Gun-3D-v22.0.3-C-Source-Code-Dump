using UnityEngine;
public sealed class RewardWindowBase : MonoBehaviour
{
    // Fields
    private static System.Action 下东丘丆丗东丑丗七;
    public bool ShowLoginsButton;
    public UnityEngine.GameObject connectToSocialContainer;
    public System.Collections.Generic.List<UILabel> connectToSocial;
    public UIWidget containerWidget;
    public float widgetExpanded;
    public float widgetCollapsed;
    public float widgetNoConnectToSocial;
    public UIButton facebook;
    public UIButton twitter;
    public UIButton continueButton;
    public UIButton hideButton;
    public UIButton facebookNoReward;
    public UIButton twitterNoReward;
    public UIButton continueAndShare;
    public UIButton collect;
    public UIButton collectAndShare;
    public UIGrid innerGrid;
    public ToggleButton share;
    public UnityEngine.GameObject shareContainer;
    public bool shouldHideExpGui;
    public UnityEngine.GameObject soundsController;
    public UnityEngine.Vector3 continue_NotConnected;
    public UnityEngine.Vector3 facebook_NotConnected;
    public UnityEngine.Vector3 twitter_NotConnected;
    public UnityEngine.Vector3 continue_TwiiterConnected;
    public UnityEngine.Vector3 facebook_TwiiterConnected;
    public UnityEngine.Vector3 continue_FacebookConnected;
    public UnityEngine.Vector3 twitter_FacebookConnected;
    public UnityEngine.Vector3 continue_AllConnected;
    public System.Action shareAction;
    public System.Action customHide;
    private System.Func<string> <下丁业丁丄东且与三>k__BackingField;
    private bool <丄业丞丕业且丛三业>k__BackingField;
    private bool 丕丒丁丒丏一丌上东;
    private string <丝且万丁丐丄丌丕与>k__BackingField;
    public UnityEngine.Animator animatorLevel;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private const string 与丈丏不下丘业世上 = "Reward Window";
    private float 专丈丘三丗丛三世丛;
    private FacebookController.上丘丟丂万东丟下丂 世丂丑世丏丐丗下丞;
    private FacebookController.上丘丟丂万东丟下丂 与丂与丗与丁专丏丄;
    
    // Properties
    internal FacebookController.上丘丟丂万东丟下丂 丄七丂下万一丝丂丌 { get; set; }
    internal FacebookController.上丘丟丂万东丟下丂 丄业三上丑丞丁七三 { get; set; }
    internal FacebookController.上丘丟丂万东丟下丂 与丈丂一丌三丈丟丅 { set; }
    public System.Func<string> 一丟丙丂丒丁丟且专 { get; set; }
    public bool 丑丐丐丏不丘丕一三 { get; set; }
    public bool 丟丏一丆万丕丑丝世 { get; set; }
    public string 且七专丗丛丒专丗世 { get; set; }
    private string 丄丕下与丒丐丈丝丟 { get; }
    
    // Methods
    internal static void 丝丘丝丏丏东丅专丂(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  RewardWindowBase.与丈丏不下丘业世上, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丑丁世一世丝丈丒丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  RewardWindowBase.与丈丏不下丘业世上, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal FacebookController.上丘丟丂万东丟下丂 丝丝三丗丟丑丅丝丝()
    {
        return (上丘丟丂万东丟下丂)this.世丂丑世丏丐丗下丞;
    }
    internal void 丝丈丆丏丒丛且丗业(FacebookController.上丘丟丂万东丟下丂 丙业与丙丗丝不丈东)
    {
        this.世丂丑世丏丐丗下丞 = 丙业与丙丗丝不丈东;
    }
    internal FacebookController.上丘丟丂万东丟下丂 丛丒专丗丒世丛丙丒()
    {
        return (上丘丟丂万东丟下丂)this.与丂与丗与丁专丏丄;
    }
    internal void 七三丆丅下上丙丕丐(FacebookController.上丘丟丂万东丟下丂 丙业与丙丗丝不丈东)
    {
        this.与丂与丗与丁专丏丄 = 丙业与丙丗丝不丈东;
    }
    internal void 丟丁丑丆丅一丙丂丂(FacebookController.上丘丟丂万东丟下丂 丙业与丙丗丝不丈东)
    {
        this.世丂丑世丏丐丗下丞 = 丙业与丙丗丝不丈东;
        this.与丂与丗与丁专丏丄 = 丙业与丙丗丝不丈东;
    }
    public System.Func<string> get_twitterStatus()
    {
        return (System.Func<System.String>)this.<下丁业丁丄东且与三>k__BackingField;
    }
    public void set_twitterStatus(System.Func<string> 丙业与丙丗丝不丈东)
    {
        this.<下丁业丁丄东且与三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_HasReward()
    {
        return (bool)this.<丄业丞丕业且丛三业>k__BackingField;
    }
    public void set_HasReward(bool 丙业与丙丗丝不丈东)
    {
        this.<丄业丞丕业且丛三业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_CollectOnlyNoShare()
    {
        return (bool)this.丕丒丁丒丏一丌上东;
    }
    public void set_CollectOnlyNoShare(bool 丙业与丙丗丝不丈东)
    {
        this.丕丒丁丒丏一丌上东 = 丙业与丙丗丝不丈东;
    }
    public string get_EventTitle()
    {
        return (string)this.<丝且万丁丐丄丌丕与>k__BackingField;
    }
    public void set_EventTitle(string 丙业与丙丗丝不丈东)
    {
        this.<丝且万丁丐丄丌丕与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        if(this.share != 0)
        {
                this.share.IsChecked = true;
        }
        
        this.animatorLevel = this.GetComponent<UnityEngine.Animator>();
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void RewardWindowBase::丞丛一丙丂世丈丅丗()));
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void RewardWindowBase::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.丒丏丐丕丄丘业七下();
    }
    private void OnEnable()
    {
        System.Action val_14;
        string val_15;
        this.丒丏丐丕丄丘业七下();
        if((UnityEngine.Object.op_Implicit(exists:  this.soundsController)) != false)
        {
                this.soundsController.SetActive(value:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗());
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Cursor.lockState = 0;
            UnityEngine.Cursor.visible = true;
        }
        
        if(RewardWindowBase.与丈丏不下丘业世上 != null)
        {
                RewardWindowBase.与丈丏不下丘业世上.Invoke();
        }
        
        if(this.shouldHideExpGui != false)
        {
                RentScreenController.丞丈丄上丘丁丛且七(丙上丌丈丑丈七丝专:  0);
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丂丁丁丁一专七三丌());
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        System.Action val_9 = null;
        val_14 = val_9;
        val_9 = new System.Action(object:  this, method:  System.Void RewardWindowBase::三丝丐专丛丈丙丒与());
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_9, 与且专丈不万东一万:  "Reward Window");
        if(this.animatorLevel != 0)
        {
                val_14 = ExperienceController.丞丞丘业东丙丏七丌();
            if(val_14 == 2)
        {
                val_15 = "Weapons";
        }
        else
        {
                val_15 = "is2items";
        }
        
            this.animatorLevel.SetTrigger(name:  val_15);
            this.animatorLevel.SetBool(name:  "IsRatingSystem", value:  true);
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
    }
    private void OnDisable()
    {
        if(this.shouldHideExpGui != false)
        {
                RentScreenController.丞丈丄上丘丁丛且七(丙上丌丈丑丈七丝专:  99);
        }
        
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
    }
    private System.Collections.IEnumerator 丂丁丁丁一专七三丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardWindowBase.丐丗丝丏丞专丄丘丑();
    }
    private bool 丌万世下上与丂丞丛()
    {
        return false;
    }
    private bool 丗不丅不丞丁丑丝丁()
    {
        var val_5;
        if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
                return false;
        }
        
        if(TwitterController.丒丆世一与丁丛丐下() == true)
        {
                return false;
        }
        
        if(TwitterController.丌丛且丑丈丈丅丗七() == true)
        {
                return false;
        }
        
        if(this.丕丒丁丒丏一丌上东 != false)
        {
                return false;
        }
        
        if(this.ShowLoginsButton == false)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        var val_4 = (东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false) ? 1 : 0;
        return false;
    }
    private void 丒丏丐丕丄丘业七下()
    {
        object val_4;
        this.专丈丘三丗丛三世丛 = UnityEngine.Time.realtimeSinceStartup;
        List.Enumerator<T> val_2 = this.connectToSocial.GetEnumerator();
        label_9:
        if((1418609200 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == 0)
        {
            goto label_9;
        }
        
        val_4 = 10;
        val_5.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1460"), arg0:  val_4);
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Start()
    {
        this.丅丞不七万三丌下万();
    }
    private void 丅丞不七万三丌下万()
    {
        var val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_93;
        bool val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        bool val_104;
        var val_105;
        var val_106;
        if(this.ShowLoginsButton == false)
        {
                return;
        }
        
        if((this.connectToSocialContainer != 0) && (this.connectToSocialContainer.activeSelf != false))
        {
                this.connectToSocialContainer.SetActive(value:  false);
            val_89 = 1;
        }
        else
        {
                val_89 = 0;
        }
        
        if((this.facebook != 0) && (this.facebook.gameObject.activeSelf != false))
        {
                this.facebook.gameObject.SetActive(value:  false);
            val_90 = 1;
        }
        else
        {
                val_90 = 0;
        }
        
        if(FacebookController.且丈丄一丁丞丒丑东() != false)
        {
                if(Facebook.Unity.FB.IsLoggedIn == false)
        {
            goto label_25;
        }
        
        }
        
        val_91 = 0;
        goto label_26;
        label_25:
        bool val_83 = this.丕丒丁丒丏一丌上东;
        val_83 = val_83 ^ 1;
        val_91 = val_83 & 255;
        label_26:
        bool val_10 = PGCompany.丁东丌世与丕东丆上.丛不丆丕且丗丏丑丒();
        val_91 = val_91 & val_10;
        if((val_91 != false) && (this.ShowLoginsButton != false))
        {
                val_92 = null;
            val_92 = null;
            bool val_84 = 东丗上丁下业一丂丂.丆丒一专且业七丟丈;
            val_84 = val_84 ^ 1;
            val_93 = val_84 & 255;
        }
        else
        {
                val_93 = 0;
        }
        
        if(this.facebookNoReward != 0)
        {
                if(val_93 != this.facebookNoReward.gameObject.activeSelf)
        {
                this.facebookNoReward.gameObject.SetActive(value:  (val_93 != 0) ? 1 : 0);
            val_90 = 1;
        }
        
        }
        
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                val_94 = this.丗不丅不丞丁丑丝丁();
        }
        else
        {
                val_94 = false;
        }
        
        val_94 = val_94 & val_10;
        if(this.twitter != 0)
        {
                if(val_94 != this.twitter.gameObject.activeSelf)
        {
                this.twitter.gameObject.SetActive(value:  val_94);
            val_90 = 1;
        }
        
        }
        
        if(((TwitterController.上业丗丛三丕丒丗丙() != false) && (TwitterController.丒丆世一与丁丛丐下() != true)) && (TwitterController.丌丛且丑丈丈丅丗七() != false))
        {
                bool val_85 = this.丕丒丁丒丏一丌上东;
            val_85 = val_85 ^ 1;
            val_95 = val_85 & 255;
        }
        else
        {
                val_95 = 0;
        }
        
        val_95 = val_95 & val_10;
        if((val_95 != false) && (this.ShowLoginsButton != false))
        {
                val_96 = null;
            val_96 = null;
            bool val_86 = 东丗上丁下业一丂丂.丆丒一专且业七丟丈;
            val_86 = val_86 ^ 1;
            val_97 = val_86 & 255;
        }
        else
        {
                val_97 = 0;
        }
        
        if(this.twitterNoReward != 0)
        {
                if(val_97 != this.twitterNoReward.gameObject.activeSelf)
        {
                this.twitterNoReward.gameObject.SetActive(value:  (val_97 != 0) ? 1 : 0);
            val_90 = 1;
        }
        
        }
        
        if((val_93 != 0) && (FacebookController.且丈丄一丁丞丒丑东() != false))
        {
                val_98 = 1;
        }
        else
        {
                var val_36 = (TwitterController.上业丗丛三丕丒丗丙() != true) ? (val_97 | val_94) : 0;
        }
        
        if((this.innerGrid != 0) && ((((val_36 != 0) ? 1 : 0) ^ this.innerGrid.gameObject.activeSelf) != false))
        {
                this.innerGrid.gameObject.SetActive(value:  (val_36 != 0) ? 1 : 0);
            val_99 = 1;
        }
        else
        {
                val_99 = 0;
        }
        
        bool val_46 = ((val_36 != 0) ? 1 : 0) & (UnityEngine.Object.op_Inequality(x:  this.innerGrid, y:  0));
        val_46 = val_90 & val_46;
        if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
            goto label_106;
        }
        
        val_100 = null;
        val_100 = null;
        if(TwitterController.丗丘丒丈专丘丕世与 == 0)
        {
            goto label_106;
        }
        
        val_101 = null;
        val_101 = null;
        if((TwitterController.丗丘丒丈专丘丕世与.不专下丒丌丒三丂丄(与丈丂一丌三丈丟丅:  this.与丂与丗与丁专丏丄)) == false)
        {
            goto label_106;
        }
        
        val_102 = TwitterController.丒丆世一与丁丛丐下();
        goto label_109;
        label_106:
        val_102 = 0;
        label_109:
        val_103 = 0;
        if((val_102 == 0) && ((this.<丄业丞丕业且丛三业>k__BackingField) != true))
        {
                bool val_87 = this.丕丒丁丒丏一丌上东;
            val_87 = val_87 ^ 1;
            val_103 = val_87 & 255;
        }
        
        if(this.continueButton != 0)
        {
                if(val_103 != this.continueButton.gameObject.activeSelf)
        {
                this.continueButton.gameObject.SetActive(value:  (val_103 == true) ? 1 : 0);
        }
        
        }
        
        if((val_102 == 0) && ((this.<丄业丞丕业且丛三业>k__BackingField) != false))
        {
                val_104 = 1;
        }
        else
        {
                val_104 = this.丕丒丁丒丏一丌上东;
        }
        
        if(this.collect != 0)
        {
                if(val_104 != this.collect.gameObject.activeSelf)
        {
                this.collect.gameObject.SetActive(value:  (val_104 == true) ? 1 : 0);
        }
        
        }
        
        bool val_88 = this.<丄业丞丕业且丛三业>k__BackingField;
        val_88 = val_88 ^ 1;
        val_88 = val_102 & val_88;
        if(val_88 != false)
        {
                bool val_89 = this.丕丒丁丒丏一丌上东;
            val_89 = val_89 ^ 1;
            val_105 = val_89 & 255;
        }
        else
        {
                val_105 = 0;
        }
        
        if(this.continueAndShare != 0)
        {
                if(val_105 != this.continueAndShare.gameObject.activeSelf)
        {
                this.continueAndShare.gameObject.SetActive(value:  (val_105 != 0) ? 1 : 0);
        }
        
        }
        
        bool val_90 = this.<丄业丞丕业且丛三业>k__BackingField;
        val_90 = val_102 & val_90;
        if(val_90 != false)
        {
                bool val_91 = this.丕丒丁丒丏一丌上东;
            val_91 = val_91 ^ 1;
            val_106 = val_91 & 255;
        }
        else
        {
                val_106 = 0;
        }
        
        if(this.collectAndShare != 0)
        {
                if(val_106 != this.collectAndShare.gameObject.activeSelf)
        {
                this.collectAndShare.gameObject.SetActive(value:  (val_106 != 0) ? 1 : 0);
        }
        
        }
        
        if((val_89 & (UnityEngine.Object.op_Inequality(x:  this.containerWidget, y:  0))) == false)
        {
            goto label_153;
        }
        
        if(val_36 == 0)
        {
            goto label_154;
        }
        
        if(this.containerWidget != null)
        {
            goto label_166;
        }
        
        label_167:
        label_166:
        this.containerWidget.height = (int)this.widgetNoConnectToSocial;
        label_153:
        if((val_99 & (UnityEngine.Object.op_Inequality(x:  this.containerWidget, y:  0))) == false)
        {
            goto label_158;
        }
        
        if(val_36 == 0)
        {
            goto label_159;
        }
        
        if(this.containerWidget != null)
        {
            goto label_168;
        }
        
        label_169:
        label_168:
        this.containerWidget.height = (int)this.widgetNoConnectToSocial;
        label_158:
        if(this.hideButton == 0)
        {
                return;
        }
        
        this.hideButton.gameObject.SetActive(value:  ((val_106 | val_105) != 0) ? 1 : 0);
        return;
        label_154:
        if(this.containerWidget != null)
        {
            goto label_166;
        }
        
        goto label_167;
        label_159:
        if(this.containerWidget != null)
        {
            goto label_168;
        }
        
        goto label_169;
    }
    public void ShowAuthorizationSucceded()
    {
        this.且丟丅丟丒丛七丅丐(丐万丗丒下七丟丁三:  true);
    }
    public void ShowAuthorizationFailed()
    {
        this.且丟丅丟丒丛七丅丐(丐万丗丒下七丟丁三:  false);
    }
    private void 且丟丅丟丒丛七丅丐(bool 丐万丗丒下七丟丁三)
    {
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/"("NguiWindows/") + (丐万丗丒下七丟丁三 != true) ? "PanelAuthSucces" : "PanelAuthFailed"((丐万丗丒下七丟丁三 != true) ? "PanelAuthSucces" : "PanelAuthFailed")));
        val_4.transform.parent = this.transform;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_4.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        val_4.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private string 丄丄丛丗专业丛丁丅()
    {
        if((System.String.IsNullOrEmpty(value:  this.<丝且万丁丐丄丌丕与>k__BackingField)) == false)
        {
                return System.String.Format(format:  "{0}: {1}", arg0:  "Reward Window", arg1:  this.<丝且万丁丐丄丌丕与>k__BackingField);
        }
        
        return "Reward Window";
    }
    public void HandleFacebookButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void RewardWindowBase::万丅丁东丗下丞丈三()), 丆丒丅丁不且丛一业:  new System.Action(object:  this, method:  System.Void RewardWindowBase::万丈与丆丈丝丞万丆()));
    }
    public void HandleTwitterButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void RewardWindowBase::丗世丂一丏丘七丏世()), 丆丒丅丁不且丛一业:  new System.Action(object:  this, method:  System.Void RewardWindowBase::世丒丟丞且七一丝三()));
    }
    public void HandleShareToggle(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    private void Update()
    {
        this.丅丞不七万三丌下万();
    }
    public void HandleContinueButtonNoHide()
    {
        var val_6;
        var val_7;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
                return;
        }
        
        if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((TwitterController.丗丘丒丈专丘丕世与.不专下丒丌丒三丂丄(与丈丂一丌三丈丟丅:  this.与丂与丗与丁专丏丄)) == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        TwitterController.丗丘丒丈专丘丕世与.丑与东丒七丁丝三丁(丝丝不丝上丂三丌世:  this.<下丁业丁丄东且与三>k__BackingField.Invoke(), 与丈丂一丌三丈丟丅:  this.与丂与丗与丁专丏丄);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_5 != null)
        {
                val_5.Add(key:  "Post Twitter", value:  this.<丝且万丁丐丄丌丕与>k__BackingField);
        }
        else
        {
                val_5.Add(key:  "Post Twitter", value:  this.<丝且万丁丐丄丌丕与>k__BackingField);
        }
        
        val_5.Add(key:  "Total Twitter", value:  "Posts");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Virality", 丛东不丒丏丈丄且丕:  val_5);
    }
    public void HandleContinueButton()
    {
        this.HandleContinueButtonNoHide();
        this.Hide();
    }
    public void Hide()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.customHide != null)
        {
                this.customHide.Invoke();
            this.customHide = 0;
        }
        
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void StartGemsStarterAnimation()
    {
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.transform.parent.GetComponent<LevelUpWithOffers>().GemsStarterAnimation());
    }
    public void StartCoinsStarterAnimation()
    {
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.transform.parent.GetComponent<LevelUpWithOffers>().CoinsStarterAnimation());
    }
    public RewardWindowBase()
    {
        this.ShowLoginsButton = true;
        this.shouldHideExpGui = true;
    }
    private void 三丝丐专丛丈丙丒与()
    {
        if(this.hideButton == 0)
        {
                return;
        }
        
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.hideButton.onClick);
    }
    private void 万丅丁东丗下丞丈三()
    {
        FacebookController.丟不丆丂且三丅世专(七丒上且丝业业下七:  new System.Action(object:  this, method:  public System.Void RewardWindowBase::ShowAuthorizationSucceded()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  this, method:  public System.Void RewardWindowBase::ShowAuthorizationFailed()), 与且专丈不万东一万:  this.丄丄丛丗专业丛丁丅());
    }
    private void 万丈与丆丈丝丞万丆()
    {
        FacebookController.丟不丆丂且三丅世专(七丒上且丝业业下七:  0, 丝丏丗丄丗与丐丌三:  0, 与且专丈不万东一万:  this.丄丄丛丗专业丛丁丅());
    }
    private void 丗世丂一丏丘七丏世()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(TwitterController.丗丘丒丈专丘丕世与 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        TwitterController.丗丘丒丈专丘丕世与.丟不丆丂且三丅世专(七丒上且丝业业下七:  new System.Action(object:  this, method:  public System.Void RewardWindowBase::ShowAuthorizationSucceded()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  this, method:  public System.Void RewardWindowBase::ShowAuthorizationFailed()), 与且专丈不万东一万:  this.丄丄丛丗专业丛丁丅());
    }
    private void 世丒丟丞且七一丝三()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(TwitterController.丗丘丒丈专丘丕世与 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        TwitterController.丗丘丒丈专丘丕世与.丟不丆丂且三丅世专(七丒上且丝业业下七:  0, 丝丏丗丄丗与丐丌三:  0, 与且专丈不万东一万:  this.丄丄丛丗专业丛丁丅());
    }

}
