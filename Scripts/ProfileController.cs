using UnityEngine;
internal sealed class ProfileController : MonoBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    internal const string 丑丞上业下丛且世丐 = "keyChooseDefaultName";
    internal static Rilisoft.丝丑丂丛万丐丈丘且 丟丌丏丌丂业丈世丑;
    internal static Rilisoft.丝丑丂丛万丐丈丘且 丄丛与丈丄丟一三丈;
    internal static Rilisoft.丝丑丂丛万丐丈丘且 专且丐丝丏丘且下丈;
    internal static string[] 丘与业丟且世丒丕万;
    private static string 丈且丘七下丒丁丒丆;
    private static ProfileController 丝业丆丁业三丈丟东;
    internal const string 丛丗丂三不与且上专 = "NamePlayer";
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UnityEngine.Camera _camera3D;
    private bool 丟丁丄万丅东丛丛丗;
    private bool 丆丐丕丈业丛丆丐业;
    private float 丕万丏丒万世丛丏下;
    private UnityEngine.Quaternion 丞一专七东丁丙丂丂;
    private bool 丐业世丙业丟一丝与;
    private float 丕丐丅丐丅丗丏丅丌;
    private CategoryButtonsController _statsTabButtonsController;
    private System.Nullable<UnityEngine.Color> 与丕专丛世丛丅丒东;
    private System.Nullable<UnityEngine.Rect> 丕丅丅一丝丅丛丝与;
    public ProfileView profileView;
    private string <丌世丑丌丕丐下世与>k__BackingField;
    private System.EventHandler 世丐与一丛业丆专丝;
    
    // Properties
    public UnityEngine.Camera 丝业丑世专丟三不丗 { get; }
    internal static ProfileController 丆丕丝丒不丙且丐丗 { get; }
    public string 丂与东且丈丟丁下丈 { get; set; }
    internal static int 七万丂丏与丁丛丕丅 { get; }
    public bool 不丁丄丌丒上丅丂丟 { get; set; }
    internal static string 下丁丞七世丝丐万上 { get; }
    
    // Methods
    public UnityEngine.Camera get_Camera3D()
    {
        return (UnityEngine.Camera)this._camera3D;
    }
    internal static ProfileController 丑七不且上丗丁一世()
    {
        null = null;
        return (ProfileController)ProfileController.丝业丆丁业三丈丟东;
    }
    public string get_DesiredWeaponTag()
    {
        return (string)this.<丌世丑丌丕丐下世与>k__BackingField;
    }
    public void set_DesiredWeaponTag(string 丙业与丙丗丝不丈东)
    {
        this.<丌世丑丌丕丐下世与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static int 丕东世上丄万丘丅业()
    {
        var val_4;
        var val_5;
        int val_1 = ExperienceController.丞丞丘业东丙丏七丌();
        val_4 = 0;
        goto label_3;
        label_13:
        if(val_1 >= (ProfileController.世丗与丆丞丏且丟三(丛丌丆丕一且丒世专:  0)))
        {
                if(val_1 <= (ProfileController.丑丘一丘丅丏丟丕七(丛丌丆丕一且丒世专:  0)))
        {
                return 0;
        }
        
        }
        
        val_4 = 1;
        label_3:
        val_5 = null;
        val_5 = null;
        if(val_4 < ExpController.LevelsForTiers.Length)
        {
            goto label_13;
        }
        
        return 0;
    }
    public bool get_InterfaceEnabled()
    {
        if(this.profileView == 0)
        {
                return false;
        }
        
        if(this.profileView.interfaceHolder == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = this.profileView.interfaceHolder.gameObject;
        if(val_3 != null)
        {
                return val_3.activeInHierarchy;
        }
        
        return val_3.activeInHierarchy;
    }
    public void set_InterfaceEnabled(bool 丙业与丙丗丝不丈东)
    {
        ProfileView val_15;
        var val_16;
        var val_17;
        System.IDisposable val_19;
        val_15 = this.profileView;
        if(val_15 == 0)
        {
                return;
        }
        
        val_15 = this.profileView.interfaceHolder;
        if(val_15 == 0)
        {
                return;
        }
        
        this.profileView.interfaceHolder.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_11;
        }
        
        this.业不不且丐且与不与(丏丟丂丅丐专一世丗:  true);
        val_16 = null;
        val_16 = null;
        if(ExperienceController.sharedController != 0)
        {
                if(ExpController.丑七不且上丗丁一世() != 0)
        {
                val_17 = null;
            val_17 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
            ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        if(this.丐丆七且丞丏下三丙 == null)
        {
            goto label_28;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_32;
        label_11:
        val_19 = this.丐丆七且丞丏下三丙;
        this.<丌世丑丌丕丐下世与>k__BackingField = System.String.alignConst;
        if(val_19 == null)
        {
            goto label_42;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        goto label_37;
        label_32:
        this.丐丆七且丞丏下三丙.Dispose();
        label_28:
        val_19 = this.profileView;
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ProfileController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Profile Controller");
        val_19.下东丂下丗上丐且上();
        goto label_42;
        label_37:
        val_19.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
        label_42:
        FreeAwardShowHandler.万上业丄丈丁上东丟(丘丅七丝丒丐丝专七:  丙业与丙丗丝不丈东);
    }
    public void add_NicknameInput(System.EventHandler<ProfileView.上丟丁丏丕上不不丒> 丙业与丙丗丝不丈东)
    {
        if(this.profileView == 0)
        {
                return;
        }
        
        this.profileView.add_NicknameInput(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void remove_NicknameInput(System.EventHandler<ProfileView.上丟丁丏丕上不不丒> 丙业与丙丗丝不丈东)
    {
        if(this.profileView == 0)
        {
                return;
        }
        
        this.profileView.remove_NicknameInput(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void HandleBankButton()
    {
        if(BankController.丑七不且上丗丁一世() == 0)
        {
            goto label_5;
        }
        
        ProfileController.且且丛丌丝三丏丙丛 val_3 = new ProfileController.且且丛丌丝三丏丙丛();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        .丝且与丝丒丟万丁专 = this;
        goto label_7;
        label_5:
        UnityEngine.Debug.LogWarning(message:  "BankController.Instance == null");
        return;
        label_6:
        mem[24] = this;
        label_7:
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_3, method:  System.Void ProfileController.且且丛丌丝三丏丙丛::世丄丟丟丘业世不丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ProfileController.且且丛丌丝三丏丙丛)[1152921538737713008].丑丘丐丂不丐丒丟且);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        this.InterfaceEnabled = false;
    }
    public void HandleAchievementsButton()
    {
        var val_12;
        IntPtr val_13;
        var val_15;
        var val_16;
        System.Action<System.Boolean, System.String> val_18;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Achievements] button pressed");
        }
        
        UnityEngine.RuntimePlatform val_2 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
        if(val_2 == 11)
        {
            goto label_4;
        }
        
        if(val_2 != 8)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        val_12 = UnityEngine.Social.localUser;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_13 = 3;
        goto label_11;
        label_4:
        val_15 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2)
        {
            goto label_14;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
                return;
        }
        
        AGSAchievementsClient.ShowAchievementsOverlay();
        return;
        label_11:
        if(val_12.authenticated == false)
        {
            goto label_20;
        }
        
        label_14:
        UnityEngine.Social.ShowAchievementsUI();
        return;
        label_20:
        val_16 = null;
        val_16 = null;
        val_18 = ProfileController.<>c.<>9__37_0;
        if(val_18 == null)
        {
                System.Action<System.Boolean, System.String> val_10 = null;
            val_18 = val_10;
            val_13 = System.Void ProfileController.<>c::丒万丟丐下下丑丘丝(bool 东且丁丆丛丁丏丘且, string 丂七东不不丈一丐不);
            val_10 = new System.Action<System.Boolean, System.String>(object:  ProfileController.<>c.__il2cppRuntimeField_static_fields, method:  val_13);
            ProfileController.<>c.<>9__37_0 = val_18;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = 1;
        UnityEngine.Social.localUser.Authenticate(callback:  val_10);
    }
    public void HandleLeaderboardsButton()
    {
        var val_12;
        IntPtr val_13;
        var val_15;
        var val_16;
        System.Action<System.Boolean, System.String> val_18;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Leaderboards] button pressed");
        }
        
        UnityEngine.RuntimePlatform val_2 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
        if(val_2 == 11)
        {
            goto label_4;
        }
        
        if(val_2 != 8)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        val_12 = UnityEngine.Social.localUser;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_13 = 3;
        goto label_11;
        label_4:
        val_15 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2)
        {
            goto label_14;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
                return;
        }
        
        AGSLeaderboardsClient.ShowLeaderboardsOverlay();
        return;
        label_11:
        if(val_12.authenticated == false)
        {
            goto label_20;
        }
        
        label_14:
        UnityEngine.Social.ShowLeaderboardUI();
        return;
        label_20:
        val_16 = null;
        val_16 = null;
        val_18 = ProfileController.<>c.<>9__38_0;
        if(val_18 == null)
        {
                System.Action<System.Boolean, System.String> val_10 = null;
            val_18 = val_10;
            val_13 = System.Void ProfileController.<>c::丝世与东丆丁丐丄三(bool 东且丁丆丛丁丏丘且, string 丂七东不不丈一丐不);
            val_10 = new System.Action<System.Boolean, System.String>(object:  ProfileController.<>c.__il2cppRuntimeField_static_fields, method:  val_13);
            ProfileController.<>c.<>9__38_0 = val_18;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = 1;
        UnityEngine.Social.localUser.Authenticate(callback:  val_10);
    }
    internal static int 世丗与丆丞丏且丟三(int 丛丌丆丕一且丒世专)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = 丛丌丆丕一且丒世专;
        if((val_2 & 2147483648) == 0)
        {
                val_3 = null;
            val_3 = null;
            if(ExpController.LevelsForTiers.Length > val_2)
        {
                val_4 = null;
            val_4 = null;
            val_2 = (long)val_2;
            System.Int32[] val_1 = ExpController.LevelsForTiers + (((long)(int)(丛丌丆丕一且丒世专)) << 2);
            val_5 = mem[(ExpController.LevelsForTiers + ((long)(int)(丛丌丆丕一且丒世专)) << 2) + 32];
            val_5 = (ExpController.LevelsForTiers + ((long)(int)(丛丌丆丕一且丒世专)) << 2) + 32;
            return (int)val_5;
        }
        
        }
        
        val_5 = 0;
        return (int)val_5;
    }
    internal static int 丑丘一丘丅丏丟丕七(int 丛丌丆丕一且丒世专)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        if((丛丌丆丕一且丒世专 & 2147483648) != 0)
        {
            goto label_5;
        }
        
        val_3 = null;
        val_3 = null;
        if(ExpController.LevelsForTiers.Length <= 丛丌丆丕一且丒世专)
        {
            goto label_5;
        }
        
        val_4 = null;
        val_4 = null;
        int val_3 = ExpController.LevelsForTiers.Length;
        val_3 = val_3 - 1;
        if(val_3 != 丛丌丆丕一且丒世专)
        {
            goto label_9;
        }
        
        val_5 = 65;
        return (int)val_5;
        label_5:
        val_5 = 0;
        return (int)val_5;
        label_9:
        val_6 = null;
        val_6 = null;
        int val_1 = 丛丌丆丕一且丒世专 + 1;
        System.Int32[] val_2 = ExpController.LevelsForTiers + (((long)(int)((丛丌丆丕一且丒世专 + 1))) << 2);
        return (int)val_5;
    }
    internal static float 丌丘与不丌一丏专丛(int 丅且丘丁上专且世丛, int 丝下三丆丅丕丐丒且)
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        val_7 = 0f;
        if(ExpController.LevelsForTiers.Length <= 丅且丘丁上专且世丛)
        {
                return (float)val_7;
        }
        
        int val_1 = ProfileController.世丗与丆丞丏且丟三(丛丌丆丕一且丒世专:  丅且丘丁上专且世丛);
        int val_3 = 丝下三丆丅丕丐丒且 - val_1;
        if(val_3 < 1)
        {
                return (float)val_7;
        }
        
        val_7 = (float)val_3 / ((float)(ProfileController.丑丘一丘丅丏丟丕七(丛丌丆丕一且丒世专:  丅且丘丁上专且世丛)) - val_1);
        return (float)val_7;
    }
    public void add_BackRequested(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.profileView != 0)
        {
                this.profileView.add_BackButtonPressed(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        
        this.且丁丈丂丟专丆一业(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void remove_BackRequested(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.profileView != 0)
        {
                this.profileView.remove_BackButtonPressed(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        
        this.丙丌万七一丒丂三与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 且丁丈丂丟专丆一业(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.世丐与一丛业丆专丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世丐与一丛业丆专丝 != 1152921538738760824);
    
    }
    private void 丙丌万七一丒丂三与(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.世丐与一丛业丆专丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世丐与一丛业丆专丝 != 1152921538738897400);
    
    }
    public void ShowInterface()
    {
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        业丂丏与世一丏业不.丑七不且上丗丁一世().专丟丁丄上万丂丝万();
        this.InterfaceEnabled = true;
    }
    public void SetStaticticTab(七丛丈丗三丂且丛世 丈丒丅上丗丅丙下丞)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this._statsTabButtonsController.BtnClicked(丟专丛丏丝万丘丄丗:  丈丒丅上丗丅丙下丞.ToString(), 丌丝丌丁下丐丞丆一:  false);
    }
    private void Awake()
    {
        null = null;
        ProfileController.丝业丆丁业三丈丟东 = this;
    }
    private void Start()
    {
        丆上上不丄东万下三 val_23;
        System.Delegate val_24;
        丂一世丝丝丞七下上 val_25;
        UIButton val_26;
        string val_27;
        UIButton val_28;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Profile controller start");
        this.add_BackRequested(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ProfileController::丈丈丟丕业丕丑丅专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this.profileView == 0)
        {
            goto label_5;
        }
        
        this.profileView.nicknameInput.defaultText = ProfileController.丐与丄东丆上丟丑与();
        if(this.profileView.nicknameOffline != 0)
        {
                this.profileView.nicknameOffline.text = ProfileController.丐与丄东丆上丟丑与();
        }
        
        val_23 = System.Delegate.Combine(a:  this.profileView.nicknameInput.onFocus, b:  new UIInputRilisoft.丆上上不丄东万下三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ProfileController::丂与东丅丅东丙与上()));
        if(this.profileView.nicknameInput == null)
        {
            goto label_20;
        }
        
        if(val_23 != null)
        {
            goto label_21;
        }
        
        goto label_24;
        label_20:
        if(val_23 == null)
        {
            goto label_24;
        }
        
        label_21:
        if(null != null)
        {
                val_23 = 0;
        }
        
        label_24:
        this.profileView.nicknameInput.onFocus = val_23;
        UIInputRilisoft.丂一世丝丝丞七下上 val_9 = null;
        val_24 = val_9;
        val_9 = new UIInputRilisoft.丂一世丝丝丞七下上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ProfileController::不专不万丏丒丈下丌());
        val_25 = System.Delegate.Combine(a:  this.profileView.nicknameInput.onFocusLost, b:  val_9);
        if(this.profileView.nicknameInput == null)
        {
            goto label_27;
        }
        
        if(val_25 != null)
        {
            goto label_28;
        }
        
        goto label_31;
        label_27:
        if(val_25 == null)
        {
            goto label_31;
        }
        
        label_28:
        if(null != null)
        {
                val_25 = 0;
        }
        
        label_31:
        this.profileView.nicknameInput.onFocusLost = val_25;
        label_5:
        if(this.profileView == 0)
        {
            goto label_59;
        }
        
        this.profileView.Nickname = ProfileController.丆三丂丂丆上丆丕专();
        System.EventHandler<上丟丁丏丕上不不丒> val_13 = null;
        val_24 = val_13;
        val_13 = new System.EventHandler<上丟丁丏丕上不不丒>(object:  this, method:  System.Void ProfileController::与丁丅上丌丒业三丗(object 不丟丗丏丛丕不丁丌, ProfileView.上丟丁丏丕上不不丒 丗丛不丁丑专专丂且));
        this.profileView.add_NicknameInput(丙业与丙丗丝不丈东:  val_13);
        UnityEngine.Quaternion val_15 = this.profileView.characterView.character.localRotation;
        this.丞一专七东丁丙丂丂 = val_15;
        mem[1152921538739607972] = val_15.y;
        mem[1152921538739607976] = val_15.z;
        mem[1152921538739607980] = val_15.w;
        UnityEngine.RuntimePlatform val_16 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
        if(val_16 == 11)
        {
            goto label_42;
        }
        
        if(val_16 != 8)
        {
            goto label_43;
        }
        
        val_26 = this.profileView.achievementsButton;
        val_27 = "gamecntr";
        goto label_45;
        label_42:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
        {
            goto label_48;
        }
        
        val_26 = this.profileView.achievementsButton;
        val_27 = "google";
        label_45:
        this.与丈上丕三丅丁东与(丟丒丞丐丐丘丒丄东:  val_26, 万丑丞一丝丌丐丒丘:  val_27);
        val_24 = this.profileView;
        this.与丈上丕三丅丁东与(丟丒丞丐丐丘丒丄东:  this.profileView.leaderboardsButton, 万丑丞一丝丌丐丒丘:  "google");
        goto label_59;
        label_43:
        val_28 = this.profileView.achievementsButton;
        goto label_57;
        label_48:
        val_24 = 与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三();
        val_28 = this.profileView.achievementsButton;
        if(val_24 != 1)
        {
            goto label_57;
        }
        
        val_24 = "amazon";
        this.与丈上丕三丅丁东与(丟丒丞丐丐丘丒丄东:  val_28, 万丑丞一丝丌丐丒丘:  "amazon");
        this.与丈上丕三丅丁东与(丟丒丞丐丐丘丒丄东:  this.profileView.leaderboardsButton, 万丑丞一丝丌丐丒丘:  "amazon");
        goto label_59;
        label_57:
        val_28.gameObject.SetActive(value:  false);
        label_59:
        业丂丏与世一丏业不.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileController::丞丅世丕丒丑万丈丐()));
        Progress.丌丆丈丛丁不丁万丒.与丐丕上丌丑丁丌上(丙业与丙丗丝不丈东:  new System.Action<System.Int32, PGCompany.丙丕丑丑丆丂丗丗丟>(object:  this, method:  System.Void ProfileController::万丗丄丝丈万业丌七(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不)));
        Progress.丌丆丈丛丁不丁万丒.丒专七与丏丌丌业七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ProfileController::丒丙上丕上世丟一专(int 丛丆东与丑丞丅丝专)));
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Profile controller end start");
    }
    private void 万丗丄丝丈万业丌七(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不)
    {
        this.丞丅世丕丒丑万丈丐();
    }
    private void 丒丙上丕上世丟一专(int 丛丆东与丑丞丅丝专)
    {
        this.丞丅世丕丒丑万丈丐();
    }
    private void 丞丅世丕丒丑万丈丐()
    {
        if(this.InterfaceEnabled == false)
        {
                return;
        }
        
        this.业不不且丐且与不与(丏丟丂丅丐专一世丗:  false);
    }
    private void 与丈上丕三丅丁东与(UIButton 丟丒丞丐丐丘丒丄东, string 万丑丞一丝丌丐丒丘)
    {
        if(丟丒丞丐丐丘丒丄东 == 0)
        {
                return;
        }
        
        丟丒丞丐丐丘丒丄东.normalSprite = 万丑丞一丝丌丐丒丘;
        string val_2 = 万丑丞一丝丌丐丒丘 + "_n";
        if(丟丒丞丐丐丘丒丄东 != null)
        {
                丟丒丞丐丐丘丒丄东.hoverSprite = 万丑丞一丝丌丐丒丘;
            丟丒丞丐丐丘丒丄东.pressedSprite = val_2;
        }
        else
        {
                mem[144] = val_2;
            mem[136] = 万丑丞一丝丌丐丒丘;
        }
        
        丟丒丞丐丐丘丒丄东.disabledSprite = 万丑丞一丝丌丐丒丘;
    }
    private void OnDestroy()
    {
        object val_11;
        丆上上不丄东万下三 val_12;
        val_11 = this;
        业丂丏与世一丏业不.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileController::丞丅世丕丒丑万丈丐()));
        Progress.丌丆丈丛丁不丁万丒.丂专丑东丂丏与与丒(丙业与丙丗丝不丈东:  new System.Action<System.Int32, PGCompany.丙丕丑丑丆丂丗丗丟>(object:  this, method:  System.Void ProfileController::万丗丄丝丈万业丌七(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不)));
        Progress.丌丆丈丛丁不丁万丒.丘丑且下丁丈专丝三(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ProfileController::丒丙上丕上世丟一专(int 丛丆东与丑丞丅丝专)));
        if(this.profileView == 0)
        {
                return;
        }
        
        this.profileView.remove_NicknameInput(丙业与丙丗丝不丈东:  new System.EventHandler<上丟丁丏丕上不不丒>(object:  this, method:  System.Void ProfileController::与丁丅上丌丒业三丗(object 不丟丗丏丛丕不丁丌, ProfileView.上丟丁丏丕上不不丒 丗丛不丁丑专专丂且)));
        val_12 = System.Delegate.Remove(source:  this.profileView.nicknameInput.onFocus, value:  new UIInputRilisoft.丆上上不丄东万下三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ProfileController::丂与东丅丅东丙与上()));
        if(this.profileView.nicknameInput == null)
        {
            goto label_11;
        }
        
        if(val_12 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_12 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(null != null)
        {
                val_12 = 0;
        }
        
        label_15:
        this.profileView.nicknameInput.onFocus = val_12;
        val_11 = System.Delegate.Remove(source:  this.profileView.nicknameInput.onFocusLost, value:  new UIInputRilisoft.丂一世丝丝丞七下上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ProfileController::不专不万丏丒丈下丌()));
        if(this.profileView.nicknameInput == null)
        {
            goto label_18;
        }
        
        if(val_11 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_11 == null)
        {
            goto label_22;
        }
        
        label_19:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_22:
        this.profileView.nicknameInput.onFocusLost = val_11;
    }
    private void 业不不且丐且与不与(bool 丏丟丂丅丐专一世丗 = True)
    {
        bool val_141;
        ProfileView val_142;
        ProfileView val_143;
        var val_144;
        var val_145;
        var val_146;
        var val_147;
        var val_148;
        bool val_149;
        var val_150;
        float val_151;
        var val_152;
        var val_153;
        var val_154;
        ProfileView val_155;
        string val_156;
        string val_157;
        int val_158;
        string val_159;
        val_141 = 丏丟丂丅丐专一世丗;
        val_142 = this;
        val_143 = this.profileView;
        if(val_143 == 0)
        {
                return;
        }
        
        this.profileView.Nickname = ProfileController.丆三丂丂丆上丆丕专();
        if((业丂丏与世一丏业不.丑七不且上丗丁一世().万一世丂丘与丏万专().ContainsKey(key:  "wincount")) != false)
        {
                object val_8 = 业丂丏与世一丏业不.丑七不且上丗丁一世().万一世丂丘与丏万专().Item["wincount"];
        }
        
        object val_54 = 0;
        this.profileView.CheckBtnCopy();
        this.profileView.丞丁丞丘丛不丑与万();
        val_144 = null;
        val_144 = null;
        this.profileView.DeathmatchWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.世与丟丐丅丑不丐丞, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.TeamBattleWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丙丈三丑上丁丁丈且, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.DeadlyGamesWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丌丙与与三丐上专万, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.BattleRoyaleWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.业丌丗丟丕一丄专丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        int val_17 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.下丗三专下丆下世丅, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        int val_18 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.业丆丐且丙世丑丘丄, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        int val_19 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丞下丐且万且丕丏丝, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        this.profileView.dungeonsEasyWinCount.text = System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7320"), arg0:  val_17);
        this.profileView.dungeonsMediumWinCount.text = System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7321"), arg0:  val_18);
        this.profileView.dungeonsHardWinCount.text = System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7322"), arg0:  val_19);
        this.profileView.DungeonWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  (val_18 + val_17) + val_19);
        this.profileView.FlagCaptureWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丁丂万万丅丒万丙世, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.CapturePointWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丅世丞丌丘丘世丅专, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.DuelWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丒七与丙丏下丄丕丁, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.TeamDuelWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丅专与丘丙丟丕丆丘, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        this.profileView.FreePlayWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.万丑专万丅丛且万丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        int val_47 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.万丑专万丅丛且万丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        int val_48 = (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丙丈三丑上丁丁丈且, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.世与丟丐丅丑不丐丞, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_48 = val_48 + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丌丙与与三丐上专万, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_48 = val_48 + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丁丂万万丅丒万丙世, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_48 = val_48 + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丅世丞丌丘丘世丅专, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_48 = val_48 + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丒七与丙丏下丄丕丁, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_48 = val_48 + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丅专与丘丙丟丕丆丘, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_48 = val_48 + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.业丌丗丟丕一丄专丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_47 = val_48 + val_47;
        this.profileView.TotalWinCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_47);
        if(this.profileView.TotalLikeCount != null)
        {
                val_145 = null;
            val_145 = null;
            this.profileView.TotalLikeCount = PlayerLikeController.丄丘七三上丕世丞业.丏东丟丅丒丄丑丆与().ToString();
        }
        
        this.profileView.PixelgunFriendsID = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(0 != 0)
        {
                bool val_55 = 0.TryGetValue(key:  "weekly", value: out  val_54);
        }
        
        if(val_54 != 0)
        {
                long val_56 = System.Convert.ToInt64(value:  val_54);
        }
        else
        {
                val_146 = 0;
        }
        
        this.profileView.TotalWeeklyWinCount = val_146.ToString();
        this.profileView.CoopTimeSurvivalPointCount = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丈业丝丌丛上上丏且(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        KillRateObject val_62 = Rilisoft.Singleton<KillrateController>.Instance.万上丗丂丅丕丙且丆();
        this.profileView.GameTotalKills = UnityEngine.Mathf.RoundToInt(f:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_62.kills, hi = val_62.kills})).ToString();
        decimal val_68 = Rilisoft.Singleton<KillrateController>.Instance.万上丗丂丅丕丙且丆().CalculateKillRate;
        this.profileView.GameKillrate = val_68.flags.ToString();
        decimal val_73 = Rilisoft.Singleton<KillrateController>.Instance.世丏丒世不丏上丐丑().CalculateKillRate;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.profileView.battleRoyaleKillRate, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8932"), arg0:  val_73));
        decimal val_77 = Rilisoft.Singleton<KillrateController>.Instance.丙丝与丝万丞七丌与(一丑丗三一丛一丄业:  7);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.profileView.sevenMatchesKillRate, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8933"), arg0:  val_77));
        decimal val_81 = Rilisoft.Singleton<KillrateController>.Instance.丙丝与丝万丞七丌与(一丑丗三一丛一丄业:  30);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.profileView.thirtyMatchesKillRate, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8934"), arg0:  val_81));
        val_147 = null;
        val_148 = 1152921504848912384;
        val_149 = val_141;
        if(ProfileController.丄丛与丈丄丟一三丈 != 0)
        {
                val_150 = null;
            val_150 = null;
            val_151 = (4.611686E+18f) / (1.152922E+18f);
        }
        else
        {
                val_151 = val_151;
        }
        
        this.profileView.GameAccuracy = (float)System.Math.Round(value:  (double)val_151, digits:  2).ToString();
        val_152 = null;
        val_152 = null;
        this.profileView.GameLikes = 1152921505248542752.ToString();
        this.profileView.WaveCountLabel = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  与丂丏丛丞丞丒丟丄.丐三丂丅不丆业丕丅());
        this.profileView.KilledCountLabel = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.一丌丝丏丒丞丁丞丟(), defaultValue:  0));
        Rilisoft.丝丑丂丛万丐丈丘且 val_92 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丐丐三七丆丂丄三丘();
        this.profileView.SurvivalScoreLabel = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  -225339952);
        this.profileView.Box1StarsLabel = this.profileView.丞丑业丟下丝丑丒丈(不丘丂东丛专东七东:  0);
        this.profileView.Box2StarsLabel = this.profileView.丞丑业丟下丝丑丒丈(不丘丂东丛专东七东:  1);
        this.profileView.Box3StarsLabel = this.profileView.丞丑业丟下丝丑丒丈(不丘丂东丛专东七东:  2);
        this.profileView.Box4StarsLabel = this.profileView.丞丑业丟下丝丑丒丈(不丘丂东丛专东七东:  3);
        this.profileView.SecretCoinsLabel = this.profileView.不三丐丟不丑丛与丞(丆丙丅丝七丒丐丙万:  1);
        this.profileView.SecretGemsLabel = this.profileView.不三丐丟不丑丛与丞(丆丙丅丝七丒丐丙万:  2);
        if( == false)
        {
            goto label_118;
        }
        
        val_153 = null;
        val_153 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_118;
        }
        
        val_154 = null;
        val_154 = null;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_101 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        if(val_101.Count < 1)
        {
            goto label_123;
        }
        
        .丑三丗丕世不三一丘 = 0;
        if((System.String.IsNullOrEmpty(value:  this.<丌世丑丌丕丐下世与>k__BackingField)) != true)
        {
                三丅丁丗丗丝丂万且 val_105 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<丌世丑丌丕丐下世与>k__BackingField);
            if(val_105 != null)
        {
                .丑三丗丕世不三一丘 = val_105.三与丛丑且丐丈业丌();
        }
        
        }
        
        if(((System.String.IsNullOrEmpty(value:  (ProfileController.丏丑丅丙世东丈丑丆)[1152921538741743184].丑三丗丕世不三一丘)) == true) || ((System.Linq.Enumerable.Any<三丈丟与丏丘丈丐万>(source:  val_101, predicate:  new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new ProfileController.丏丑丅丙世东丈丑丆(), method:  System.Boolean ProfileController.丏丑丅丙世东丈丑丆::丑不丁丝下上丝世丐(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)))) == false))
        {
            goto label_130;
        }
        
        val_155 = this.profileView;
        val_156 = this.<丌世丑丌丕丐下世与>k__BackingField;
        if(val_155 != null)
        {
            goto label_139;
        }
        
        goto label_132;
        label_130:
        System.Random val_112 = new System.Random(Seed:  UnityEngine.Time.frameCount);
        int val_113 = val_101.Count;
        三丈丟与丏丘丈丐万 val_114 = val_101.Item[-224805296];
        val_155 = this.profileView;
        val_156 = val_114.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        if(val_155 != null)
        {
            goto label_139;
        }
        
        label_132:
        label_139:
        val_157 = val_156;
        goto label_140;
        label_123:
        val_157 = "Knife";
        label_140:
        this.profileView.SetWeaponAndSkin(丒东业不丐丑丕丄丆:  val_157);
        label_118:
        string val_116 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
        val_141 = 1152921504624312320;
        bool val_117 = System.String.op_Inequality(a:  val_116, b:  System.String.alignConst);
        if(this.profileView == null)
        {
            goto label_142;
        }
        
        if(val_117 == false)
        {
            goto label_143;
        }
        
        label_145:
        this.profileView.UpdateHat(上丈专丌万丕丙万丘:  val_116);
        goto label_144;
        label_142:
        if(val_117 == true)
        {
            goto label_145;
        }
        
        label_143:
        this.profileView.RemoveHat();
        label_144:
        if((System.String.op_Inequality(a:  七丌丞万七万丁丐丙.上三丐丛东丐丏丗丝(), b:  "MaskNoneEquipped")) != false)
        {
                this.profileView.UpdateMask(丟世丟丐且丐丟七上:  七丌丞万七万丁丐丙.上三丐丛东丐丏丗丝());
        }
        else
        {
                this.profileView.RemoveMask();
        }
        
        if((System.String.op_Inequality(a:  七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐(), b:  与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟())) != false)
        {
                this.profileView.UpdateBoots(上世丘丐东万丐丆不:  七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐());
        }
        else
        {
                this.profileView.RemoveBoots();
        }
        
        if((System.String.op_Inequality(a:  七丌丞万七万丁丐丙.东与丑丌丄万业丘丄(), b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) != false)
        {
                this.profileView.UpdateArmor(与丙丕丛一丌丛丆丈:  七丌丞万七万丁丐丙.东与丑丌丄万业丘丄());
        }
        else
        {
                this.profileView.RemoveArmor();
        }
        
        if((System.String.op_Inequality(a:  七丌丞万七万丁丐丙.一万丌东丄世上丕丟(), b:  与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业())) != false)
        {
                this.profileView.UpdateCape(丈丐丕业下丟业丛一:  七丌丞万七万丁丐丙.一万丌东丄世上丕丟());
        }
        else
        {
                this.profileView.RemoveCape();
        }
        
        val_143 = 1152921524404748272;
        if(((Rilisoft.Singleton<ClansController>.Instance) != 0) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null))
        {
                val_142 = this.profileView;
            val_158 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丝丈三专丟丌丄丝();
            if(val_158 == null)
        {
                val_158 = System.String.alignConst;
        }
        
            val_159 = val_158;
        }
        else
        {
                val_142 = System.String.alignConst;
            val_159 = val_142;
        }
        
        this.profileView.SetClanLogo(一丘上丟丝丆丕丐丁:  val_159);
    }
    private void OnEnable()
    {
        this.业不不且丐且与不与(丏丟丂丅丐专一世丗:  true);
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 + 1000000f;
        this.丕万丏丒万世丛丏下 = val_1;
    }
    private void Update()
    {
        var val_3;
        var val_4;
        if((this.世丐与一丛业丆专丝 != null) && (this.丆丐丕丈业丛丆丐业 != false))
        {
                val_3 = null;
            val_3 = null;
            this.世丐与一丛业丆专丝.Invoke(sender:  this, e:  System.EventArgs.Empty);
            this.丆丐丕丈业丛丆丐业 = false;
        }
        
        val_4 = null;
        val_4 = null;
        if((UnityEngine.Time.realtimeSinceStartup - this.丕万丏丒万世丛丏下) <= ShopNGUIController.上丈丂丁三丂业丛丝)
        {
                return;
        }
        
        this.丟丞丝三丒世世丒丈();
    }
    private void LateUpdate()
    {
        if(this.profileView == 0)
        {
                return;
        }
        
        if(this.InterfaceEnabled == false)
        {
                return;
        }
        
        if((Holoville.HOTween.HOTween.IsTweening(p_target:  this.profileView.characterView.character)) == true)
        {
                return;
        }
        
        if(this.丕丅丅一丝丅丛丝与.HasValue != true)
        {
                float val_15 = 0.5f;
            val_15 = (float)UnityEngine.Screen.width * val_15;
            float val_10 = (float)UnityEngine.Screen.height * 0.1f;
            float val_11 = (float)UnityEngine.Screen.height * 0.8f;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        
        RilisoftRotator.丒丌丄丛丟丏丒世丄(世丟丈丏丕万丝丆万:  this.profileView.characterView.character, 丄七丛丝丏丈丒丝业:  RilisoftRotator.丙丂专一丄丞丛业上(), 丕丏丘七丗丘万丟丛:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 丑丗丘丞丗丌三丈丆: ref  this.丕万丏丒万世丛丏下, 三丕丂且一丝丈三一: ref  this.丕丐丅丐丅丗丏丅丌, 丝丛业丑专业一丁上:  0);
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(InfoWindowController.丈丐丞丐上丑且丕万() != false)
        {
                InfoWindowController.一丘丕上丈一丂丐丌();
            return;
        }
        
        this.丆丐丕丈业丛丆丐业 = true;
    }
    private void 丟丞丝三丒世世丒丈()
    {
        if(this.profileView == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "profileView == null");
            return;
        }
        
        int val_3 = Holoville.HOTween.HOTween.Kill(p_target:  this.profileView.characterView.character);
        if(val_3 >= 1)
        {
                if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Tweens killed: "("Tweens killed: ") + val_3);
        }
        
        }
        
        float val_15 = this.丕万丏丒万世丛丏下;
        val_15 = val_15 + 1000000f;
        this.丕万丏丒万世丛丏下 = val_15;
        Holoville.HOTween.Tweener val_14 = Holoville.HOTween.HOTween.To(p_target:  this.profileView.characterView.character, p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Quaternion() {x = this.丞一专七东丁丙丂丂, y = V9.16B, z = V10.16B, w = V11.16B})).UpdateType(p_updateType:  3).Ease(p_easeType:  0).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void ProfileController::世东丏且世丛丄丐一())));
    }
    private string 丞丑业丟下丝丑丒丈(int 不丘丂东丛专东七东)
    {
        object val_12;
        var val_13;
        var val_14;
        System.Collections.Generic.List<丞丏丙一丘丌与业丌> val_15;
        var val_16;
        var val_17;
        int val_18;
        val_12 = 1152921505226227712;
        val_13 = null;
        val_13 = null;
        if(下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count <= 不丘丂东丛专东七东)
        {
            goto label_4;
        }
        
        val_14 = null;
        val_14 = null;
        下与业丆下三丅丅丝 val_2 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[不丘丂东丛专东七东];
        val_15 = val_2.下上不丏专丄丆业世;
        val_16 = 0;
        val_17 = 0;
        goto label_9;
        label_17:
        丐丘丛三丙专业丕丄 val_6 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  val_2.丒丘丏上丙丟丑丕丈, 丂一丏丙下丝丘丆丗:  val_15.Item[0].一七与丅上丁丙丂不());
        val_16 = 1;
        label_9:
        if(val_16 != val_15.Count)
        {
            goto label_17;
        }
        
        val_12 = 47;
        int val_8 = val_15.Count;
        string val_10 = val_6.丌丐丛丝丒上丟丏下.七丄不丐丗三丝丑一 + 47 + val_8 + (val_8 << 1)(val_8 + (val_8 << 1));
        return (string)val_18;
        label_4:
        val_15 = "Box index is out of range:    "("Box index is out of range:    ") + 不丘丂东丛专东七东;
        UnityEngine.Debug.LogWarning(message:  val_15);
        val_18 = System.String.alignConst;
        return (string)val_18;
    }
    private string 不三丐丟不丑丛与丞(Rilisoft.丝一丌上丟且三一丏 丆丙丅丝七丒丐丙万)
    {
        return (string)System.Math.Min(val1:  26, val2:  CoinBonus.丟丐业东丑丘丐丘东(丆丙丅丝七丒丐丙万:  丆丙丅丝七丒丐丙万).Count)(System.Math.Min(val1:  26, val2:  CoinBonus.丟丐业东丑丘丐丘东(丆丙丅丝七丒丐丙万:  丆丙丅丝七丒丐丙万).Count)) + 47 + 26;
    }
    private void 与丁丅上丌丒业三丗(object 不丟丗丏丛丕不丁丌, ProfileView.上丟丁丏丕上不不丒 丗丛不丁丑专专丂且)
    {
        this.SaveNamePlayer(丏丕丁三万丛丑丝下:  丗丛不丁丑专专丂且.丙三丂丒丂专丌丟东());
    }
    public void SaveNamePlayer(string 丏丕丁三万丛丑丝下)
    {
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        string val_1 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  丏丕丁三万丛丑丝下);
        val_13 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                if((System.String.op_Equality(a:  val_13.Trim(), b:  System.String.alignConst)) == false)
        {
            goto label_5;
        }
        
        }
        
        val_13 = ProfileController.丐与丄东丆上丟丑与();
        this.profileView.nicknameInput.text = val_13;
        label_5:
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Saving new name:    "("Saving new name:    ") + val_13);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丐万丑丏上专世专(丑与丕丐七丆三丟一:  val_13);
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_15 = null;
            val_15 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_16 = null;
            val_16 = null;
            NetworkStartTable val_11 = GetComponent<NetworkStartTable>();
            if(val_11 != 0)
        {
                val_11.丞丄世丗不丑丙上丂();
        }
        
        }
        
        }
        
        this.丟丁丄万丅东丛丛丗 = true;
        this.丐业世丙业丟一丝与 = true;
    }
    internal static void 丕丑丟丂丝丕丝东丒(string 丏丕丁三万丛丑丝下)
    {
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        string val_1 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  丏丕丁三万丛丑丝下);
        val_17 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                if((System.String.op_Equality(a:  val_17.Trim(), b:  System.String.alignConst)) == false)
        {
            goto label_27;
        }
        
        }
        
        val_17 = ProfileController.丐与丄东丆上丟丑与();
        if(ProfileController.丝业丆丁业三丈丟东 != 0)
        {
                val_18 = null;
            val_18 = null;
            if(ProfileController.丝业丆丁业三丈丟东.profileView != 0)
        {
                val_19 = null;
            val_19 = null;
            public System.Int32 UnityEngine.Object::GetHashCode().__il2cppRuntimeField_18.text = val_17;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        if(PlayerPanel.丄丘七三上丕世丞业 != 0)
        {
                val_21 = null;
            val_21 = null;
            PlayerPanel.丄丘七三上丕世丞业.UpdateNickPlayer();
        }
        
        label_27:
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Saving new name:    "("Saving new name:    ") + val_17);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丐万丑丏上专世专(丑与丕丐七丆三丟一:  val_17);
        val_22 = null;
        val_22 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_23 = null;
            val_23 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_24 = null;
            val_24 = null;
            NetworkStartTable val_14 = GetComponent<NetworkStartTable>();
            if(val_14 != 0)
        {
                val_14.丞丄世丗不丑丙上丂();
        }
        
        }
        
        }
        
        业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
    }
    private void 丈丈丟丕业丕丑丅专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.profileView.NewsOpened != false)
        {
                this.profileView.CloseNews();
            return;
        }
        
        if(this.丟丁丄万丅东丛丛丗 != false)
        {
                业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
            this.丟丁丄万丅东丛丛丗 = false;
        }
        
        this.与丆且丆世丟丛丏丟();
    }
    private void 与丆且丆世丟丛丏丟()
    {
        this.InterfaceEnabled = false;
        UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 丂与东丅丅东丙与上()
    {
        this.丐业世丙业丟一丝与 = false;
    }
    private void 不专不万丏丒丈下丌()
    {
        ProfileView val_5;
        if(this.丐业世丙业丟一丝与 == true)
        {
                return;
        }
        
        if(this.profileView == 0)
        {
                return;
        }
        
        this.profileView.nicknameInput.value = ProfileController.丆三丂丂丆上丆丕专();
        if(this.profileView.nicknameOffline == 0)
        {
                return;
        }
        
        val_5 = this.profileView;
        if(this.profileView != null)
        {
            goto label_13;
        }
        
        val_5 = this.profileView;
        if(val_5 == null)
        {
            goto label_14;
        }
        
        label_13:
        this.profileView.nicknameOffline.text = this.profileView.nicknameInput.value;
        return;
        label_14:
    }
    internal static void 丆丟七丅丒七且下丟()
    {
        null = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameShoot", 下下丏一丙不丘丌丞:  641695744, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameHit", 下下丏一丙不丘丌丞:  641695760, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyCountLikes", 下下丏一丙不丘丌丞:  641695776, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal static void 丁一世且丄下业东一()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "keyGameTotalKills")) != true)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameTotalKills", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "keyGameDeath")) != true)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameDeath", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "keyGameShoot")) != true)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameShoot", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "keyGameHit")) != true)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "keyGameHit", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        int val_5 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "keyGameShoot", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        int val_6 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "keyGameHit", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        int val_7 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "keyCountLikes", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    internal static void 下丂且七丕业世一与()
    {
        null = null;
    }
    internal static void 丈丅业下丑丘下业下()
    {
        null = null;
    }
    internal static void 七丄七七丘丆丁丑丕()
    {
        null = null;
    }
    internal static string 丐与丄东丆上丟丑与()
    {
        string val_4;
        var val_5;
        val_4 = "keyChooseDefaultName";
        if((UnityEngine.PlayerPrefs.HasKey(key:  "keyChooseDefaultName")) != true)
        {
                ProfileController.丈且丘七下丒丁丒丆 = ProfileController.专不业业下东丆不世();
            UnityEngine.PlayerPrefs.SetString(key:  "keyChooseDefaultName", value:  ProfileController.丈且丘七下丒丁丒丆);
        }
        
        val_5 = null;
        val_5 = null;
        if(ProfileController.丈且丘七下丒丁丒丆 == null)
        {
                val_5 = null;
            val_4 = UnityEngine.PlayerPrefs.GetString(key:  "keyChooseDefaultName");
            val_5 = null;
            ProfileController.丈且丘七下丒丁丒丆 = val_4;
        }
        
        val_5 = null;
        return (string)ProfileController.丈且丘七下丒丁丒丆;
    }
    internal static string 专不业业下东丆不世()
    {
        var val_3;
        System.String[] val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ProfileController.丘与业丟且世丒丕万;
        if(val_4 == null)
        {
                return "Player";
        }
        
        val_4 = ProfileController.丘与业丟且世丒丕万;
        if(val_4 != null)
        {
                if(ProfileController.丘与业丟且世丒丕万.Length == 0)
        {
                return "Player";
        }
        
            val_5 = null;
            val_5 = null;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  ProfileController.丘与业丟且世丒丕万.Length);
            System.String[] val_2 = ProfileController.丘与业丟且世丒丕万 + (((long)(int)(val_1)) << 3);
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (ProfileController.丘与业丟且世丒丕万 + ((long)(int)(val_1)) << 3) + 32);
        }
    
    }
    internal static string 丆三丂丂丆上丆丕专()
    {
        if((System.String.IsNullOrEmpty(value:  Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三())) != false)
        {
                if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return ProfileController.丁七丞丙世三业专丂();
        }
        
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丐万丑丏上专世专(丑与丕丐七丆三丟一:  ProfileController.丁七丞丙世三业专丂());
        }
        
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                if((NickNameValidator.instance.ValidateNickName(丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三())) != true)
        {
                NickNameValidationBanner.ShowNickNameValidation(万丕万丑三丕丌丏丆:  (~(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220))) & 1);
        }
        
        }
        
        Progress.上丁丆七丁丗万丘丐 val_14 = Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下();
        if(val_14 != null)
        {
                return val_14.与与丌万丟丄丌丘三();
        }
        
        return val_14.与与丌万丟丄丌丘三();
    }
    internal static string 丁七丞丙世三业专丂()
    {
        string val_32;
        var val_39;
        var val_41;
        var val_42;
        if((System.String.IsNullOrEmpty(value:  Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三())) == false)
        {
            goto label_4;
        }
        
        val_32 = UnityEngine.PlayerPrefs.GetString(key:  "SocialName", defaultValue:  System.String.alignConst);
        if(UnityEngine.Social.localUser == null)
        {
            goto label_14;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        goto label_10;
        label_4:
        Progress.上丁丆七丁丗万丘丐 val_7 = Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下();
        if(val_7 != null)
        {
                return val_7.与与丌万丟丄丌丘三();
        }
        
        return val_7.与与丌万丟丄丌丘三();
        label_10:
        if(UnityEngine.Social.localUser.authenticated == false)
        {
            goto label_14;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        if((System.String.IsNullOrEmpty(value:  UnityEngine.Social.localUser.userName)) == false)
        {
            goto label_20;
        }
        
        label_14:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_37;
        }
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        goto label_31;
        label_20:
        var val_42 = 0;
        val_42 = val_42 + 1;
        goto label_36;
        label_31:
        if(GameCircleSocial.Instance.localUser.authenticated == false)
        {
            goto label_37;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        if((System.String.IsNullOrEmpty(value:  GameCircleSocial.Instance.localUser.userName)) == false)
        {
            goto label_46;
        }
        
        label_37:
        if((System.String.IsNullOrEmpty(value:  val_32)) == false)
        {
                return val_32;
        }
        
        return ProfileController.丐与丄东丆上丟丑与();
        label_46:
        var val_44 = 0;
        val_44 = val_44 + 1;
        goto label_57;
        label_36:
        if((val_32.Equals(value:  UnityEngine.Social.localUser.userName)) == true)
        {
                return val_32;
        }
        
        val_39 = UnityEngine.Social.localUser;
        val_41 = null;
        var val_45 = 0;
        val_42 = 1152921504882016264;
        val_45 = val_45 + 1;
        goto label_74;
        label_57:
        if((val_32.Equals(value:  GameCircleSocial.Instance.localUser.userName)) == true)
        {
                return val_32;
        }
        
        val_39 = GameCircleSocial.Instance.localUser;
        val_41 = null;
        var val_46 = 0;
        val_42 = 1152921504882016264;
        val_46 = val_46 + 1;
        label_74:
        val_32 = val_39.userName;
        UnityEngine.PlayerPrefs.SetString(key:  "SocialName", value:  val_32);
        return val_32;
    }
    public void TurnOn()
    {
        this.profileView.interfaceHolder.gameObject.SetActive(value:  true);
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ProfileController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Profile Controller");
    }
    public void TurnOff()
    {
        this.profileView.interfaceHolder.gameObject.SetActive(value:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public ProfileController()
    {
    
    }
    private static ProfileController()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = new Rilisoft.丝丑丂丛万丐丈丘且(丑三不丌丌丆丞丆丐:  623401554);
        ProfileController.丛丗丂三不与且上专 = val_1.七丄不丐丗三丝丑一;
        ProfileController.丛丗丂三不与且上专.__il2cppRuntimeField_8 = val_1.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = new Rilisoft.丝丑丂丛万丐丈丘且(丑三不丌丌丆丞丆丐:  606624338);
        Rilisoft.丝丑丂丛万丐丈丘且 val_3;
        ProfileController.丄丛与丈丄丟一三丈 = val_2.七丄不丐丗三丝丑一;
        ProfileController.丛丗丂三不与且上专.__il2cppRuntimeField_18 = val_2.上万三丆专丏丒丗业;
        val_3 = new Rilisoft.丝丑丂丛万丐丈丘且(丑三不丌丌丆丞丆丐:  606624338);
        ProfileController.专且丐丝丏丘且下丈 = val_3.七丄不丐丗三丝丑一;
        ProfileController.丛丗丂三不与且上专.__il2cppRuntimeField_28 = val_3.上万三丆专丏丒丗业;
        string[] val_4 = new string[19];
        val_4[0] = "Key_2020";
        val_4[1] = "Key_2021";
        val_4[2] = "Key_2022";
        val_4[3] = "Key_2023";
        val_4[4] = "Key_2024";
        val_4[5] = "Key_2025";
        val_4[6] = "Key_2026";
        val_4[7] = "Key_2027";
        val_4[8] = "Key_2028";
        val_4[9] = "Key_2029";
        val_4[10] = "Key_2030";
        val_4[11] = "Key_2031";
        val_4[12] = "Key_2032";
        val_4[13] = "Key_2033";
        val_4[14] = "Key_2034";
        val_4[15] = "Key_2035";
        val_4[16] = "Key_2036";
        val_4[17] = "Key_2037";
        val_4[18] = "Key_2038";
        ProfileController.丘与业丟且世丒丕万 = val_4;
        ProfileController.丈且丘七下丒丁丒丆 = 0;
    }
    private void 世东丏且世丛丄丐一()
    {
        float val_1 = this.丕万丏丒万世丛丏下;
        val_1 = val_1 + 1000000f;
        this.丕万丏丒万世丛丏下 = val_1;
    }

}
