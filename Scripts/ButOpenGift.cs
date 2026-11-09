using UnityEngine;
public class ButOpenGift : MonoBehaviour
{
    // Fields
    internal static ButOpenGift 丄丘七三上丕世丞业;
    public bool _activeHighLight;
    private bool 丙专丑丈丐万丛上丛;
    public bool _isCanGetGift;
    public bool _isPressBut;
    public UnityEngine.Material[] allHighlightMaterial;
    public UnityEngine.Color animColor;
    public Rilisoft.BindedBillboard Billboard;
    public UnityEngine.Collider colActive;
    public UnityEngine.Collider colNormal;
    public UnityEngine.Color curColorHS;
    public string nameShaderColor;
    public UnityEngine.Color normalColor;
    public UnityEngine.Color pressColor;
    public float speedAnim;
    private static System.Action 下丑丅丗七丁丟丌下;
    private System.Func<bool> 上丂世万丄丗丄丒上;
    
    // Properties
    public bool 丆三万丞世丒丑丕丑 { get; set; }
    public bool 丐丄万丌丈世上丆丞 { get; set; }
    public bool 一下丂世与丌与下东 { get; set; }
    private Rilisoft.GiftLobbyHeader 丅万丒世丗丕上丁业 { get; }
    public bool 世丆丆丛丗下东与丑 { get; }
    private bool 专丏世丆且丗丆丛丝 { get; }
    
    // Methods
    public bool get_ActiveHighLight()
    {
        return (bool)this._activeHighLight;
    }
    public void set_ActiveHighLight(bool 丙业与丙丗丝不丈东)
    {
        var val_5;
        var val_6;
        var val_1 = (this._activeHighLight == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this._activeHighLight = 丙业与丙丗丝不丈东;
        val_5 = null;
        val_5 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 != 0)
        {
                val_6 = null;
            val_6 = null;
            if(GiftBannerWindow.丄丘七三上丕世丞业.IsShow != false)
        {
                this._activeHighLight = false;
        }
        
        }
        
        this.UpdateHUDStateGift();
    }
    public bool get_IsPressBut()
    {
        return (bool)this._isPressBut;
    }
    public void set_IsPressBut(bool 丙业与丙丗丝不丈东)
    {
        this._isPressBut = 丙业与丙丗丝不丈东;
        this.UpdateHUDStateGift();
    }
    public bool get_IsCanGetGift()
    {
        return (bool)this._isCanGetGift;
    }
    public void set_IsCanGetGift(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this._isCanGetGift = val_1;
        this.丝丘一一万下丗丌上(下下丏一丙不丘丌丞:  val_1);
        this.UpdateHUDStateGift();
    }
    private Rilisoft.GiftLobbyHeader 丅世丄业丂丂丕与与()
    {
        AnimationGift val_2;
        Rilisoft.GiftLobbyHeader val_3;
        val_2 = AnimationGift.丄丘七三上丕世丞业;
        val_3 = 0;
        if(val_2 == 0)
        {
                return val_3;
        }
        
        val_2 = AnimationGift.丄丘七三上丕世丞业;
        val_3 = mem[AnimationGift.丄丘七三上丕世丞业 + 40];
        val_3 = AnimationGift.丄丘七三上丕世丞业.LobbyHeader;
        return val_3;
    }
    public bool get_CanShowLabel()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = this;
        if(this.上丂世万丄丗丄丒上 == null)
        {
            goto label_1;
        }
        
        val_3 = this.上丂世万丄丗丄丒上;
        val_4 = 0;
        goto label_2;
        label_7:
        object val_2 = System.Func<TResult>.__il2cppRuntimeField_byval_arg.DynamicInvoke(args:  System.Array.Empty<System.Object>());
        if(null == null)
        {
            goto label_5;
        }
        
        val_4 = 1;
        label_2:
        if(val_4 < null)
        {
            goto label_7;
        }
        
        label_1:
        val_5 = 1;
        return (bool)val_5;
        label_5:
        val_5 = 0;
        return (bool)val_5;
    }
    private bool 丆丈一丌丒丅丌丌丝()
    {
        GiftController val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        if(MainMenuController.丝丂丒且与丆丛丝丒() == true)
        {
            goto label_71;
        }
        
        val_23 = null;
        val_23 = null;
        val_22 = GiftController.丆丕丝丒不丙且丐丗;
        if(val_22.ActiveGift == false)
        {
            goto label_71;
        }
        
        val_22 = mem[AnimationGift.丄丘七三上丕世丞业 + 48];
        val_22 = AnimationGift.丄丘七三上丕世丞业.objGift;
        if(activeSelf == false)
        {
            goto label_71;
        }
        
        val_24 = null;
        val_24 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_15;
        }
        
        val_25 = null;
        val_25 = null;
        val_22 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_22.丂丙丈与世专上丒上() == true)
        {
            goto label_71;
        }
        
        label_15:
        val_26 = null;
        val_26 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_24;
        }
        
        val_27 = null;
        val_27 = null;
        val_22 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_22.上丙丆不丂丂丄一丂() == true)
        {
            goto label_71;
        }
        
        label_24:
        val_28 = null;
        val_28 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_33;
        }
        
        val_29 = null;
        val_29 = null;
        val_22 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 320];
        val_22 = MainMenuController.丄丞丁丈与业上丞丟.rotateCamera;
        if(丘丈丙专上上三上丒() == true)
        {
            goto label_71;
        }
        
        label_33:
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_41;
        }
        
        val_22 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_22.上丙丆不丂丂丄一丂() == true)
        {
            goto label_71;
        }
        
        label_41:
        val_30 = null;
        val_30 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_48;
        }
        
        val_31 = null;
        val_31 = null;
        val_22 = SquadController.丄丘七三上丕世丞业;
        if(val_22.inSquad == true)
        {
            goto label_71;
        }
        
        label_48:
        val_22 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_22 == 0)
        {
                val_32 = 1;
            return (bool)val_32 & 1;
        }
        
        val_22 = BannerWindowController.与丅与丒丅专丙丐丗();
        if((val_22.不且丝丆丈三与世东(丈丈不丒丗与丝不丗:  true)) == false)
        {
            goto label_62;
        }
        
        label_71:
        val_32 = 0;
        return (bool)val_32 & 1;
        label_62:
        val_33 = null;
        val_33 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_67;
        }
        
        val_34 = null;
        val_34 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == true)
        {
            goto label_71;
        }
        
        label_67:
        bool val_22 = MainStoreView.丈丐丞丐上丑且丕万() ^ 1;
        return (bool)val_32 & 1;
    }
    internal static void 东上一丒丂丆丂丒丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ButOpenGift.下丑丅丗七丁丟丌下, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ButOpenGift.下丑丅丗七丁丟丌下 != 1152921505204240392);
    
    }
    internal static void 且一丟上丞世丗丆丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ButOpenGift.下丑丅丗七丁丟丌下, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ButOpenGift.下丑丅丗七丁丟丌下 != 1152921505204240392);
    
    }
    public void add_CanShowNickLabel(System.Func<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上丂世万丄丗丄丒上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丂世万丄丗丄丒上 != 1152921537771654960);
    
    }
    public void remove_CanShowNickLabel(System.Func<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上丂世万丄丗丄丒上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丂世万丄丗丄丒上 != 1152921537771791536);
    
    }
    public void AddCanShowNickLabelChecker(System.Func<bool> 丑上丈丞丗丄丒丈丕)
    {
        this.remove_CanShowNickLabel(丙业与丙丗丝不丈东:  丑上丈丞丗丄丒丈丕);
        this.add_CanShowNickLabel(丙业与丙丗丝不丈东:  丑上丈丞丗丄丒丈丕);
        this.UpdateHUDStateGift();
    }
    public void RemoveCanShowNickLabelChecker(System.Func<bool> 丑上丈丞丗丄丒丈丕)
    {
        this.remove_CanShowNickLabel(丙业与丙丗丝不丈东:  丑上丈丞丗丄丒丈丕);
        this.UpdateHUDStateGift();
    }
    public void Click()
    {
        this.OpenWithSelectedGift(丆万一不丌且东丐丐:  System.String.alignConst);
    }
    public void OpenWithSelectedGift(string 丆万一不丌且东丐丐)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Action val_11;
        var val_12;
        var val_13;
        var val_14;
        bool val_2 = MainMenuHeroCamera.丑七不且上丗丁一世().一丈下丕丕一丛且丝();
        if(val_2 == true)
        {
                return;
        }
        
        if(val_2.丆丈一丌丒丅丌丌丝() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        GiftController.丆丕丝丒不丙且丐丗.七丁万丈丛丈丝丁丐(丞丅上丏丂且下丅与:  丆万一不丌且东丐丐);
        val_7 = null;
        val_7 = null;
        GiftScroll.丌一丆丛世业专三丑 = true;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_8 = null;
        val_8 = null;
        MainMenuController.丞且丙丛丞不世专七 = false;
        val_9 = null;
        val_9 = null;
        GiftBannerWindow.与丌东下丙丕业三且 = false;
        GiftBannerWindow.丘丆且七丑丘且专丟 = true;
        val_10 = null;
        val_10 = null;
        val_11 = ButOpenGift.下丑丅丗七丁丟丌下;
        if(val_11 != null)
        {
                val_11 = ButOpenGift.下丑丅丗七丁丟丌下;
            if(val_11 == null)
        {
                val_11 = 0;
        }
        
            val_11.Invoke();
        }
        
        val_12 = null;
        val_12 = null;
        MainMenuController.丄丞丁丈与业上丞丟.SaveShowPanelAndClose();
        MainMenuController.丄丞丁丈与业上丞丟.OnShowBannerGift();
        val_13 = null;
        val_13 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 != 0)
        {
                val_14 = null;
            val_14 = null;
            GiftBannerWindow.丄丘七三上丕世丞业.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
        }
        
        this.ActiveHighLight = false;
        this.UpdateHUDStateGift();
        MainMenuHeroCamera.丑七不且上丗丁一世().PlayShowGift();
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        if(this.丆丈一丌丒丅丌丌丝() == false)
        {
                return;
        }
        
        this._isPressBut = 丆且上丘世下丅且丞;
        this.UpdateHUDStateGift();
        this.UpdateHUDStateGift();
    }
    private void 世丆丕丌丒下丆万上()
    {
        this.OnPress(丆且上丘世下丅且丞:  false);
    }
    private void Awake()
    {
        null = null;
        ButOpenGift.丄丘七三上丕世丞业 = this;
        Holoville.HOTween.HOTween.Init();
        this._activeHighLight = false;
        this._isCanGetGift = false;
        this._isPressBut = false;
        Rilisoft.LobbyCraftController.丈丈东三丙且丟丗下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ButOpenGift::UpdateHUDStateGift()));
        this.AddCanShowNickLabelChecker(丑上丈丞丗丄丒丈丕:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean ButOpenGift::丄丂丆丙丌上七丐丁()));
    }
    private void OnEnable()
    {
        var val_3;
        if(this.Billboard == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if((ButOpenGift.<>c.<>9__43_0) == null)
        {
            goto label_6;
        }
        
        label_11:
        this.Billboard.BindTo(丅专与丒丈丗丒丘丌:  ButOpenGift.<>c.<>9__43_0);
        return;
        label_6:
        ButOpenGift.<>c.<>9__43_0 = new System.Func<UnityEngine.Transform>(object:  ButOpenGift.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Transform ButOpenGift.<>c::丅丅丁与丑丐且丌丒());
        if(this.Billboard != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    private void Start()
    {
        null = null;
        GiftController.丆丕丝丒不丙且丐丗.TryGetData();
        this.UpdateHUDStateGift();
    }
    private void OnDestroy()
    {
        null = null;
        ButOpenGift.丄丘七三上丕世丞业 = 0;
        Rilisoft.LobbyCraftController.东三世丟世业不丏上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ButOpenGift::UpdateHUDStateGift()));
        this.remove_CanShowNickLabel(丙业与丙丗丝不丈东:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean ButOpenGift::丄丂丆丙丌上七丐丁()));
        this.UpdateHUDStateGift();
    }
    private bool 丄丂丆丙丌上七丐丁()
    {
        Rilisoft.LobbyCraftController val_4;
        var val_5;
        val_4 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_4 == 0)
        {
                val_5 = 1;
        }
        else
        {
                val_4 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            bool val_2 = val_4.上丙丆不丂丂丄一丂();
            val_5 = val_2 ^ 1;
        }
        
        val_2 = val_5;
        return (bool)val_2;
    }
    public void UpdateHUDStateGift()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_9;
        }
        
        val_5 = null;
        val_5 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift == false)
        {
            goto label_9;
        }
        
        if(this._activeHighLight == false)
        {
            goto label_10;
        }
        
        if(this._isPressBut == false)
        {
            goto label_11;
        }
        
        label_16:
        this.万丐一丐上一丙业世(下下丏一丙不丘丌丞:  true);
        goto label_12;
        label_9:
        this.下上万丌三且三丁三(下下丏一丙不丘丌丞:  false);
        this.HideLabelTap();
        this._isCanGetGift = false;
        this._isPressBut = false;
        this._activeHighLight = false;
        return;
        label_10:
        this.下上万丌三且三丁三(下下丏一丙不丘丌丞:  false);
        goto label_15;
        label_11:
        if(this._isCanGetGift == false)
        {
            goto label_16;
        }
        
        this.世丛三业丙丕业丆一();
        label_12:
        bool val_3 = this.CanShowLabel;
        if(val_3 != false)
        {
                val_3.丟一丅丂世丐丛丌丏();
            return;
        }
        
        label_15:
        this.HideLabelTap();
    }
    public void OpenGift()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        GiftBannerWindow.丄丘七三上丕世丞业.SetVisibleBanner(下下丏一丙不丘丌丞:  true);
    }
    public void CloseGift()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 != 0)
        {
                val_3 = null;
            val_3 = null;
            GiftBannerWindow.丄丘七三上丕世丞业.CloseBannerEndAnimtion();
        }
        
        this.ActiveHighLight = true;
        val_4 = null;
        val_4 = null;
        MainMenuController.丞且丙丛丞不世专七 = true;
    }
    private void 万丐一丐上一丙业世(bool 下下丏一丙不丘丌丞)
    {
        this.不万丒且且丟业丞丛();
        if(下下丏一丙不丘丌丞 != false)
        {
            
        }
        
        this.丒丗丙丙丙丟专丅万(丒专一与一丗七不丌:  new UnityEngine.Color() {r = this.normalColor});
    }
    private void 世世丟丏丞丅上专三()
    {
        this.世丛三业丙丕业丆一();
    }
    private void 下上万丌三且三丁三(bool 下下丏一丙不丘丌丞)
    {
        if(下下丏一丙不丘丌丞 == true)
        {
                return;
        }
        
        this.不万丒且且丟业丞丛();
        this.丒丗丙丙丙丟专丅万(丒专一与一丗七不丌:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
    }
    private void 不万丒且且丟业丞丛()
    {
        int val_1 = Holoville.HOTween.HOTween.Kill(p_target:  this);
    }
    private void 世丛三业丙丕业丆一()
    {
        int val_1 = Holoville.HOTween.HOTween.Kill(p_target:  this);
        Holoville.HOTween.Tweener val_8 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  this.speedAnim, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "curColorHS", p_endVal:  this.animColor).OnUpdate(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void ButOpenGift::丙丂丂丌不万丕下丞())).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void ButOpenGift::丞丟丝业丈丙丕丁丘())));
    }
    private void 丞丟丝业丈丙丕丁丘()
    {
        int val_1 = Holoville.HOTween.HOTween.Kill(p_target:  this);
        Holoville.HOTween.Tweener val_8 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  this.speedAnim, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "curColorHS", p_endVal:  this.normalColor).OnUpdate(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void ButOpenGift::丑丐一丁七丘丏一丄())).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void ButOpenGift::世丛三业丙丕业丆一())));
    }
    private void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丒专一与一丗七不丌)
    {
        UnityEngine.Material[] val_1;
        var val_2;
        val_1 = this.allHighlightMaterial;
        this.curColorHS = 丒专一与一丗七不丌;
        mem[1152921537774511188] = 丒专一与一丗七不丌.g;
        mem[1152921537774511192] = 丒专一与一丗七不丌.b;
        mem[1152921537774511196] = 丒专一与一丗七不丌.a;
        if(val_1 == null)
        {
                return;
        }
        
        val_2 = 0;
        goto label_1;
        label_6:
        this.allHighlightMaterial[0].SetColor(name:  this.nameShaderColor, value:  new UnityEngine.Color() {r = 丒专一与一丗七不丌.r, g = 丒专一与一丗七不丌.g, b = 丒专一与一丗七不丌.b, a = 丒专一与一丗七不丌.a});
        val_1 = this.allHighlightMaterial;
        val_2 = 1;
        label_1:
        if(val_2 < this.allHighlightMaterial.Length)
        {
            goto label_6;
        }
    
    }
    private void 丟一丅丂世丐丛丌丏()
    {
        this.丅世丄业丂丂丕与与().gameObject.SetActive(value:  false);
    }
    public void HideLabelTap()
    {
        bool val_2 = UnityEngine.Object.op_Equality(x:  this.丅世丄业丂丂丕与与(), y:  0);
        if(val_2 == true)
        {
                return;
        }
        
        bool val_5 = val_2.丅世丄业丂丂丕与与().gameObject.activeSelf;
        if(val_5 == false)
        {
                return;
        }
        
        val_5.丅世丄业丂丂丕与与().gameObject.SetActive(value:  false);
    }
    private void 丝丘一一万下丗丌上(bool 下下丏一丙不丘丌丞)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.colActive)) != false)
        {
                this.colActive.enabled = 下下丏一丙不丘丌丞;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.colNormal)) == false)
        {
                return;
        }
        
        this.colNormal.enabled = (~下下丏一丙不丘丌丞) & 1;
    }
    public ButOpenGift()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.animColor = val_1;
        mem[1152921537775168044] = val_1.g;
        mem[1152921537775168048] = val_1.b;
        mem[1152921537775168052] = val_1.a;
        this.nameShaderColor = "_Color";
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.normalColor = val_2;
        mem[1152921537775168108] = val_2.g;
        mem[1152921537775168112] = val_2.b;
        mem[1152921537775168116] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.pressColor = val_3;
        mem[1152921537775168124] = val_3.g;
        mem[1152921537775168128] = val_3.b;
        mem[1152921537775168132] = val_3.a;
        this.speedAnim = 1f;
    }
    private static ButOpenGift()
    {
    
    }
    private void 丙丂丂丌不万丕下丞()
    {
        this.丒丗丙丙丙丟专丅万(丒专一与一丗七不丌:  new UnityEngine.Color() {r = this.curColorHS});
    }
    private void 丑丐一丁七丘丏一丄()
    {
        this.丒丗丙丙丙丟专丅万(丒专一与一丗七不丌:  new UnityEngine.Color() {r = this.curColorHS});
    }

}
