using UnityEngine;
internal sealed class FriendsWindowController : MonoBehaviour
{
    // Fields
    internal static System.Action 丞世丑丁且丌丙丛专;
    internal static FriendsWindowController 丆丕丝丒不丙且丐丗;
    private bool 万不丟丁丝丁业丑一;
    private bool 丘业丙下丌七世丑丂;
    private bool 丛丑丙一丗丂丐丅丗;
    private FriendPreviewItem 三丝上丙一丈丕万丟;
    public UnityEngine.GameObject friendsContainer;
    public UnityEngine.GameObject findContainer;
    public UnityEngine.GameObject inviteContainer;
    public UnityEngine.GameObject chatContainer;
    public UIToggle chatTab;
    private ConnectionControl 丙不丅丝丙专丕世丐;
    private UnityEngine.GameObject 丗上丏丟丆专与丗丆;
    private FriendsWindowController.不丑丙丒专丟丕丘丙 丗丒七丁丙丝丘世丅;
    public UnityEngine.GameObject emptyStateLocalPlayersTabLabel;
    public UILabel emptyStateTabLabel;
    private string[] 下丈丅与丄丏七上丗;
    public UIWrapContent findFriendsWrap;
    public UnityEngine.GameObject friendPreviewPrefab;
    public UIWrapContent friendsListWrap;
    public UIScrollView friendsListScrollView;
    public UIToggle friendsTab;
    public UIButton goInBattleButton;
    private string[] 丒下下世丁丟三业世;
    public UIWrapContent inviteFriendsWrap;
    public UnityEngine.GameObject joinToFriendRoomPhoton;
    private string[] 万七丐专丆丁丈丟丑;
    private string[] 业丌世丕不丆世丐不;
    private string 下世三丛一丗下丂下;
    public FriendsWindowStatusBar statusBar;
    private bool 丏丕丅丂丑业一世丂;
    private bool <丗丆东丄丁丘与且丐>k__BackingField;
    
    // Properties
    internal bool 丂世丛万丐且丘丐丏 { get; set; }
    internal static bool 丅业东万丌丕上丌丄 { get; }
    
    // Methods
    internal bool 专丅丅世业不丕丂上()
    {
        return (bool)this.<丗丆东丄丁丘与且丐>k__BackingField;
    }
    internal void 丏丌一丌丅丄丏业丐(bool 丙业与丙丗丝不丈东)
    {
        this.<丗丆东丄丁丘与且丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        if(FriendsWindowController.丆丕丝丒不丙且丐丗 == null)
        {
                return (bool)FriendsWindowController.丆丕丝丒不丙且丐丗;
        }
        
        UnityEngine.GameObject val_1 = FriendsWindowController.丆丕丝丒不丙且丐丗.gameObject;
        if(val_1 != null)
        {
                return val_1.activeInHierarchy;
        }
        
        return val_1.activeInHierarchy;
    }
    public void OnClickGoInBattleButton()
    {
        var val_1;
        ButtonClickSound.丁业上丏不丕三丗不();
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  2);
        val_1 = null;
        val_1 = null;
        MainMenuController.丆不丑丆下丞丙不丞 = true;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    private void Awake()
    {
        UnityEngine.GameObject val_10;
        FriendsWindowController.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "ConnectPanel");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_10);
        this.丗上丏丟丆专与丗丆 = val_3;
        val_3.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
        this.丗上丏丟丆专与丗丆.SetActive(value:  false);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丗上丏丟丆专与丗丆, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        this.丙不丅丝丙专丕世丐 = this.丗上丏丟丆专与丗丆.AddComponent<ConnectionControl>();
        val_8.dontResetGameMode = true;
        this.丙不丅丝丙专丕世丐.SetConnectPanel(丛丘下丗业丂一且业:  this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>());
    }
    internal void 且丅丙丑下东丂丅丅(string 丝丕与丝东与丗丁世)
    {
        FriendsWindowController.且不丘丝丕业下万一 val_1 = new FriendsWindowController.且不丘丝丕业下万一();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丝丕与丝东与丗丁世 = 丝丕与丝东与丗丁世;
        InfoWindowController.一丘丕上丈一丂丐丌();
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void FriendsWindowController.且不丘丝丕业下万一::三丅一东七丐且不丕()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 丛丒万丟专且世且丟(string 丝丕与丝东与丗丁世)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        System.Action val_7;
        val_2 = null;
        val_2 = null;
        FriendsWindowGUI.丆丕丝丒不丙且丐丗.丒丐一下丐丝丁丟世();
        val_3 = null;
        val_3 = null;
        SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        val_7 = FriendsWindowController.<>c.<>9__40_0;
        if(val_7 == null)
        {
                System.Action val_1 = null;
            val_7 = val_1;
            val_1 = new System.Action(object:  FriendsWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FriendsWindowController.<>c::与与不丅丄上不下丁());
            FriendsWindowController.<>c.<>9__40_0 = val_7;
        }
        
        SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  val_1, 上且丗一丏丏万丅丌:  2, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  0, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  丝丕与丝东与丗丁世, 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
    }
    internal void 丆丙丄上七与一东丒(string 丒丘丏上丙丟丑丕丈)
    {
        this.下世三丛一丗下丂下 = 丒丘丏上丙丟丑丕丈;
        InfoWindowController.一丘丕上丈一丂丐丌();
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void FriendsWindowController::与丁丆丙丁丂丙丅与()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 与丁丆丙丁丂丙丅与()
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        System.Action val_7;
        val_2 = null;
        val_2 = null;
        FriendsWindowGUI.丆丕丝丒不丙且丐丗.丒丐一下丐丝丁丟世();
        val_3 = null;
        val_3 = null;
        SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        val_7 = FriendsWindowController.<>c.<>9__42_0;
        if(val_7 == null)
        {
                System.Action val_1 = null;
            val_7 = val_1;
            val_1 = new System.Action(object:  FriendsWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FriendsWindowController.<>c::丆丝丗万七丒专下丞());
            FriendsWindowController.<>c.<>9__42_0 = val_7;
        }
        
        SquadController.丄丘七三上丕世丞业.JoinSquad(丛丝与丂世丌丌丝丂:  val_1, 丐一三丞丝丌不丏丑:  this.下世三丛一丗下丂下);
    }
    public void EnterClanSiegeMode()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        FriendsWindowGUI.丆丕丝丒不丙且丐丗.丒丐一下丐丝丁丟世();
        val_2 = null;
        val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.EnterClanSiege();
    }
    private void Start()
    {
        this.丗丒七丁丙丝丘世丅 = 0;
    }
    private void OnEnable()
    {
        System.Action val_11;
        var val_12;
        var val_13;
        System.Action val_14;
        var val_15;
        FriendsController.业丐丙丅丒丝丈丕丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        丌且下丛三丟三业丑.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        val_12 = null;
        val_13 = null;
        if(((System.Delegate.Combine(a:  FriendsController.且与丟丗且与业丈丗, b:  new System.Action(object:  this, method:  System.Void FriendsWindowController::三丝不丞且丗与上丞()))) != null) && (null != val_13))
        {
                val_12 = null;
            val_13 = null;
            val_11 = 0;
        }
        
        FriendsController.且与丟丗且与业丈丗 = val_11;
        val_15 = null;
        if(((System.Delegate.Combine(a:  FriendsController.下与世万丏丏丅一丏, b:  new System.Action(object:  this, method:  public System.Void FriendsWindowController::HideInfoBox()))) != null) && (null != val_15))
        {
                val_15 = null;
            val_14 = 0;
        }
        
        FriendsController.下与世万丏丏丅一丏 = val_14;
        丐丌不丏东丟丕七丟.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::世不丅丛三丄丗丆丑()));
        东丐丁丐与丟下丄丈.丗丛丘下三丒丝丝丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        丌丟丄专丂丒丁丛三.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
    }
    internal void 三丝不丞且丗与上丞()
    {
        InfoWindowController.东丆丄丒丅丗丌丏下();
    }
    public void HideInfoBox()
    {
        InfoWindowController.丏三万丏世丛业丒丒();
    }
    private void 丐丘丒东丟一丑丝丗(string 丕丗丘丑丛与丑业丒)
    {
        this.emptyStateTabLabel.gameObject.SetActive(value:  true);
        this.emptyStateTabLabel.text = 丕丗丘丑丛与丑业丒;
    }
    private void 不不丛丐丈丗丏丙丂()
    {
        this.emptyStateTabLabel.gameObject.SetActive(value:  false);
    }
    private void 与丒丙且丂丝丏丗丆(bool 下丘丞万三一丈与一, bool 丛万不丞丝丌上万不)
    {
        string val_3;
        if(下丘丞万三一丈与一 != false)
        {
                if(this.丗丒七丁丙丝丘世丅 == 2)
        {
                this.chatContainer.SetActive(value:  true);
        }
        
            this.不不丛丐丈丗丏丙丂();
            return;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 2)
        {
                this.丐丘丒东丟一丑丝丗(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1557"));
            this.chatContainer.SetActive(value:  false);
            return;
        }
        
        if(丛万不丞丝丌上万不 != false)
        {
                val_3 = "Key_1424";
        }
        else
        {
                if(this.丗丒七丁丙丝丘世丅 == 3)
        {
                val_3 = "Key_1425";
        }
        else
        {
                if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                val_3 = "Key_1423";
        }
        else
        {
                val_3 = "Key_0223";
        }
        
        }
        
        }
        
        this.丐丘丒东丟一丑丝丗(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3));
    }
    private void 丘一丘丒丝丕丂三丑()
    {
        var val_11;
        bool val_12;
        var val_13;
        bool val_14;
        bool val_15;
        if(this.业丌世丕不丆世丐不 != null)
        {
                this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  this.friendsListWrap, 丏三丅世世一业专与:  1);
        }
        
        val_11 = null;
        this.万不丟丁丝丁业丑一 = FriendsController.丈世丝丐丝丂丙丌丘();
        val_12 = FriendsController.丁丘万不丌丏丗丗且();
        this.丘业丙下丌七世丑丂 = val_12;
        if(this.丗丒七丁丙丝丘世丅 == 2)
        {
                val_13 = null;
            val_12 = this.丘业丙下丌七世丑丂;
            val_14 = FriendsController.上丄七丙东三上业丕();
        }
        else
        {
                val_14 = this.万不丟丁丝丁业丑一;
        }
        
        this.与丒丙且丂丝丏丗丆(下丘丞万三一丈与一:  val_14, 丛万不丞丝丌上万不:  val_12);
        if(this.万不丟丁丝丁业丑一 != false)
        {
                val_15 = 0;
        }
        else
        {
                val_15 = UpdatesChecker.丈下丐丕丟丂丒丗丞();
        }
        
        this.goInBattleButton.gameObject.SetActive(value:  val_15);
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return;
        }
        
        this.statusBar.与下丛丐世丕丁丝不(丛万不丞丝丌上万不:  (this.丘业丙下丌七世丑丂 == true) ? 1 : 0);
    }
    private void 丄专丛业丞丞丌丝丈()
    {
        this.丗丒七丁丙丝丘世丅 = 0;
        this.丘一丘丒丝丕丂三丑();
        if((this.<丗丆东丄丁丘与且丐>k__BackingField) != false)
        {
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丏三丝丟下丟丙丑一());
        }
        
        this.丛丑丙一丗丂丐丅丗 = false;
    }
    private string 下业丂且与丞丐丙东(int 丞世不丒下上上丝丑)
    {
        var val_3;
        string val_4;
        val_3 = 丞世不丒下上上丝丑;
        if(this.丗丒七丁丙丝丘世丅 <= 3)
        {
                var val_2 = 106017500 + (this.丗丒七丁丙丝丘世丅) << 2;
            val_2 = val_2 + 106017500;
        }
        else
        {
                val_4 = 0;
            return (string);
        }
    
    }
    private string 丁丞不丄且一专一丑(int 丞世不丒下上上丝丑)
    {
        var val_1;
        var val_2;
        val_1 = 丞世不丒下上上丝丑;
        if(this.万七丐专丆丁丈丟丑.Length > val_1)
        {
                val_1 = (long)val_1;
            return (string)val_2;
        }
        
        val_2 = "";
        return (string)val_2;
    }
    private int 专专丟丁丗且世七上()
    {
        int val_2;
        System.String[] val_3;
        if(this.丗丒七丁丙丝丘世丅 == 3)
        {
            goto label_0;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return 0;
        }
        
        if(this.万七丐专丆丁丈丟丑 == null)
        {
            goto label_3;
        }
        
        val_2 = this.万七丐专丆丁丈丟丑.Length;
        return (int)val_2 + this.业丌世丕不丆世丐不.Length;
        label_0:
        val_3 = this.丒下下世丁丟三业世;
        if(val_3 != null)
        {
                return (int)this.下丈丅与丄丏七上丗.Length;
        }
        
        return 0;
        label_1:
        val_3 = this.下丈丅与丄丏七上丗;
        if(val_3 == null)
        {
                return 0;
        }
        
        return (int)this.下丈丅与丄丏七上丗.Length;
        label_3:
        val_2 = 0;
        return (int)val_2 + this.业丌世丕不丆世丐不.Length;
    }
    private 丝丟万七上东丅丄丄 与丆东不丞丒万丏且()
    {
        if(this.丗丒七丁丙丝丘世丅 > 3)
        {
                return 0;
        }
        
        return (丝丟万七上东丅丄丄)106017516 + (this.丗丒七丁丙丝丘世丅) << 2;
    }
    private UIWrapContent 东三世万丌下丘丈丝()
    {
        UIWrapContent val_1;
        if(this.丗丒七丁丙丝丘世丅 == 3)
        {
            goto label_0;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return 0;
        }
        
        val_1 = this.friendsListWrap;
        return (UIWrapContent)mem[this.findFriendsWrap];
        label_0:
        val_1 = this.inviteFriendsWrap;
        return (UIWrapContent)mem[this.findFriendsWrap];
        label_1:
        val_1 = this.findFriendsWrap;
        return (UIWrapContent)mem[this.findFriendsWrap];
    }
    internal void 下不世丞丞丝丟不丒()
    {
        UIWrapContent val_20;
        UnityEngine.Object val_21;
        丝丟万七上东丅丄丄 val_22;
        var val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        this.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  this.丗丒七丁丙丝丘世丅, 上丗与不丑丄丞丆业:  false);
        if(this.丗丒七丁丙丝丘世丅 == 3)
        {
            goto label_1;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
            goto label_3;
        }
        
        val_20 = this.friendsListWrap;
        goto label_5;
        label_1:
        val_20 = this.inviteFriendsWrap;
        goto label_5;
        label_2:
        val_20 = this.findFriendsWrap;
        label_5:
        val_21 = mem[this.findFriendsWrap];
        goto label_6;
        label_3:
        val_21 = 0;
        label_6:
        if(val_21 == 0)
        {
                return;
        }
        
        if(this.丗丒七丁丙丝丘世丅 <= 3)
        {
                val_22 = mem[106017516 + (this.丗丒七丁丙丝丘世丅) << 2];
            val_22 = 106017516 + (this.丗丒七丁丙丝丘世丅) << 2;
        }
        else
        {
                val_22 = 0;
        }
        
        this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  val_21, 丏三丅世世一业专与:  val_22);
        val_23 = val_21.transform.parent.GetComponent<UIScrollView>();
        int val_5 = this.专专丟丁丗且世七上();
        if(val_5 < 5)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = val_23.transform.localPosition;
        val_24 = val_7.y;
        if(val_21 != 0)
        {
                val_25 = val_21;
            val_26 = 28563616;
            val_27 = val_26;
        }
        else
        {
                val_25 = val_21;
            val_27 = 28563616;
            val_26 = 28563616;
        }
        
        val_26 = val_26 * val_5;
        float val_20 = 1.142545E+08f;
        val_20 = val_24 + val_20;
        if(val_20 <= (float)val_26)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  2.856362E+07f);
        val_21 = ???;
        val_23 = ???;
        val_24 = ???;
        goto typeof(UIScrollView).__il2cppRuntimeField_1F8;
    }
    private void 丅丛东万丕丆丟丕丆(UIWrapContent 丄丕丝下丒东上丞丁)
    {
        if(丄丕丝下丒东上丞丁 != null)
        {
                丄丕丝下丒东上丞丁.transform.parent.GetComponent<UIScrollView>().ResetPosition();
            return;
        }
    
    }
    private void 不丁丙丞丄丂三丗丝(FriendsWindowController.不丑丙丒专丟丕丘丙 丏业丟一东丂东丘丛, bool 上丗与不丑丄丞丆业 = False)
    {
        var val_54;
        UIWrapContent val_70;
        bool val_71;
        T[] val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        bool val_82;
        var val_83;
        int val_84;
        val_71 = 上丗与不丑丄丞丆业;
        val_72 = 丏业丟一东丂东丘丛;
        if(val_72 == 3)
        {
            goto label_1;
        }
        
        if(val_72 == 1)
        {
            goto label_2;
        }
        
        if(val_72 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_1 = null;
        val_72 = val_1;
        val_1 = new System.Collections.Generic.List<System.String>();
        val_73 = 1152921516223708000;
        val_71 = 1152921516107659296;
        val_74 = 0;
        goto label_4;
        label_17:
        string val_4 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Item[0];
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().ContainsKey(key:  val_4)) != false)
        {
                val_1.Add(item:  val_4);
        }
        
        val_74 = 1;
        label_4:
        if(val_74 < 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count)
        {
            goto label_17;
        }
        
        System.Comparison<System.String> val_11 = new System.Comparison<System.String>(object:  this, method:  System.Int32 FriendsWindowController::下世丙上丏丏丘下专(string 丞丘不丙万丈丕万且, string 七万业丅丌丌丂丝且));
        if(val_72 == null)
        {
            goto label_18;
        }
        
        val_1.Sort(comparison:  val_11);
        goto label_19;
        label_1:
        System.Collections.Generic.List<System.String> val_12 = new System.Collections.Generic.List<System.String>();
        val_73 = 1152921516934571616;
        val_71 = 1152921516107659296;
        val_75 = 0;
        goto label_20;
        label_34:
        string val_15 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Item[0];
        val_77 = null;
        val_77 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == null)
        {
                val_76 = 0;
        }
        
        if((val_76.HaveSquadInviteFromPlayer(丞丅上丏丂且下丅与:  val_15)) != false)
        {
                val_12.Add(item:  val_15);
        }
        
        val_75 = 1;
        label_20:
        if(val_75 < 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count)
        {
            goto label_34;
        }
        
        if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
        {
            goto label_39;
        }
        
        val_78 = 0;
        goto label_40;
        label_60:
        string val_28 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不().Item[0].业丐丐三丕一丗丛丁();
        if((val_12.Contains(item:  val_28)) != true)
        {
                val_79 = null;
            val_79 = null;
            if(FriendsController.丄丞丁丈与业上丞丟 == null)
        {
                val_79 = 0;
        }
        
            if((val_79.HaveSquadInviteFromPlayer(丞丅上丏丂且下丅与:  val_28)) != false)
        {
                val_12.Add(item:  val_28);
        }
        
            val_80 = null;
            val_80 = null;
            if(FriendsController.丄丞丁丈与业上丞丟 == null)
        {
                val_80 = 0;
        }
        
            if((val_80.HaveClanSiegeInviteFromPlayer(丞丅上丏丂且下丅与:  val_28)) != false)
        {
                val_12.Add(item:  val_28);
        }
        
        }
        
        val_78 = 1;
        label_40:
        if(val_78 < (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不().Count))
        {
            goto label_60;
        }
        
        label_39:
        val_81 = 0;
        goto label_61;
        label_70:
        string val_38 = 且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万().Item[0];
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_38)) != false)
        {
                val_12.Add(item:  val_38);
        }
        
        val_81 = 1;
        label_61:
        val_82 = 且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万();
        if(val_81 < val_82.Count)
        {
            goto label_70;
        }
        
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  val_12);
        val_70 = mem[1152921537341152536];
        val_72 = val_12.ToArray();
        mem[1152921537341152528] = val_72;
        if(val_72 == null)
        {
            goto label_73;
        }
        
        label_96:
        mem2[0] = -val_46.Length;
        if(val_71 == false)
        {
                return;
        }
        
        if(mem[1152921537341152536] != 0)
        {
            goto label_121;
        }
        
        label_122:
        label_121:
        val_70 = mem[1152921537341152536].transform.parent.GetComponent<UIScrollView>();
        val_70.ResetPosition();
        return;
        label_2:
        System.Collections.Generic.List<System.String> val_50 = new System.Collections.Generic.List<System.String>();
        val_83 = null;
        val_83 = null;
        Dictionary.Enumerator<TKey, TValue> val_51 = 下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.GetEnumerator();
        val_73 = 1152921524493730496;
        label_89:
        if(((-1625445136) & 1) == 0)
        {
            goto label_84;
        }
        
        ConfiguredValueTaskAwaiter val_55 = val_54.GetAwaiter();
        string val_56 = val_55._value._obj.丐丏七丌丕丗业且上();
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_56)) == false)
        {
            goto label_89;
        }
        
        val_50.Add(item:  val_56);
        goto label_89;
        label_18:
        val_1.Sort(comparison:  val_11);
        label_19:
        val_82 = val_71;
        T[] val_60 = val_1.ToArray();
        this.业丌世丕不丆世丐不 = val_60;
        if(val_60 == null)
        {
            goto label_90;
        }
        
        if(this.万七丐专丆丁丈丟丑 == null)
        {
            goto label_91;
        }
        
        label_97:
        val_84 = this.万七丐专丆丁丈丟丑.Length + val_60.Length;
        goto label_94;
        label_73:
        if(val_70 != 0)
        {
            goto label_96;
        }
        
        goto label_96;
        label_90:
        if(this.万七丐专丆丁丈丟丑 != null)
        {
            goto label_97;
        }
        
        label_91:
        val_84 = val_60.Length;
        label_94:
        this.friendsListWrap.minIndex = -val_84;
        if(val_82 != false)
        {
                this.friendsListWrap.transform.parent.GetComponent<UIScrollView>().ResetPosition();
        }
        
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  val_1);
        丄三万丑丑东且丁丙.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  val_1);
        val_70 = 丂与专万与丐丌丏不.丑七不且上丗丁一世();
        val_70.丒三丐丄万且上上丑(丅下丏丙丞东丒丕丁:  val_1);
        return;
        label_84:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_72 = val_50.ToArray();
        this.下丈丅与丄丏七上丗 = val_72;
        System.Array.Sort<System.String>(array:  val_72, comparison:  new System.Comparison<System.String>(object:  this, method:  System.Int32 FriendsWindowController::与专丑三丞丞丈丆丁(string 丅丝丕丒丒丑东上一, string 丕丄丟丝业丗丕七与)));
        val_70 = this.findFriendsWrap;
        if(this.下丈丅与丄丏七上丗 == null)
        {
            goto label_118;
        }
        
        label_124:
        this.findFriendsWrap.minIndex = -this.下丈丅与丄丏七上丗.Length;
        if(val_71 == false)
        {
                return;
        }
        
        if(this.findFriendsWrap != null)
        {
            goto label_121;
        }
        
        goto label_122;
        label_118:
        if(val_70 != null)
        {
            goto label_124;
        }
        
        goto label_124;
    }
    private void 上世丞丟丑业丌世丂(bool 上丗与不丑丄丞丆业)
    {
        var val_5;
        var val_14;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_14 = null;
        val_14 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = 下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.GetEnumerator();
        label_10:
        if(((-1624755600) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if(((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_6._value._obj.丐丏七丌丕丗业且上())) == false) || ((-1624755616) != 1))
        {
            goto label_10;
        }
        
        val_1.Add(item:  val_6._value._obj.丐丏七丌丕丗业且上());
        goto label_10;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丂与专万与丐丌丏不.丑七不且上丗丁一世().丒三丐丄万且上上丑(丅下丏丙丞东丒丕丁:  val_1);
        T[] val_13 = val_1.ToArray();
        this.万七丐专丆丁丈丟丑 = val_13;
        if(this.业丌世丕不丆世丐不 == null)
        {
            goto label_22;
        }
        
        if(val_13 == null)
        {
            goto label_23;
        }
        
        label_25:
        label_27:
        int val_14 = this.业丌世丕不丆世丐不.Length;
        val_14 = val_14 + val_13.Length;
        this.friendsListWrap.minIndex = -val_14;
        return;
        label_22:
        if(this.万七丐专丆丁丈丟丑 != null)
        {
            goto label_25;
        }
        
        label_23:
        if(this.friendsListWrap != null)
        {
            goto label_27;
        }
        
        goto label_27;
    }
    private System.Collections.IEnumerator 丏三丝丟下丟丙丑一()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FriendsWindowController.东不丂丞丘万丘丛专(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丟丙丟丕丗且七且上(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        FriendPreviewItem val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        if(this.丗丒七丁丙丝丘世丅 != 3)
        {
                return;
        }
        
        this.上世丘丛业丕上丏且(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>(), 丏三丅世世一业专与:  3);
    }
    private void 丝专万丐丐万丒世丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        FriendPreviewItem val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return;
        }
        
        this.上世丘丛业丕上丏且(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>(), 丏三丅世世一业专与:  1);
    }
    private void 丐丛丞丞丞丐丕丅七(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        FriendPreviewItem val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        if(this.丗丒七丁丙丝丘世丅 != 1)
        {
                return;
        }
        
        this.上世丘丛业丕上丏且(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>(), 丏三丅世世一业专与:  2);
    }
    private void 不丙丛丞丕丄丙专丌(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        FriendPreviewItem val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return;
        }
        
        this.上世丘丛业丕上丏且(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<FriendPreviewItem>(), 丏三丅世世一业专与:  2);
    }
    private void 上世丘丛业丕上丏且(FriendPreviewItem 七丘丛下丒丅且丕且, 丝丟万七上东丅丄丄 丏三丅世世一业专与)
    {
        var val_8;
        var val_9;
        string val_1 = this.下业丂且与丞丐丙东(丞世不丒下上上丝丑:  七丘丛下丒丅且丕且.myWrapIndex);
        if((System.String.IsNullOrEmpty(value:  val_1)) == false)
        {
            goto label_1;
        }
        
        if(七丘丛下丒丅且丕且.gameObject.activeSelf == false)
        {
                return;
        }
        
        val_8 = 七丘丛下丒丅且丕且.gameObject;
        val_9 = 0;
        goto label_5;
        label_1:
        if((丏三丅世世一业专与 == 1) && (七丘丛下丒丅且丕且.myWrapIndex < this.万七丐专丆丁丈丟丑.Length))
        {
                if(this.丗丒七丁丙丝丘世丅 != 3)
        {
            goto label_12;
        }
        
        }
        
        label_12:
        七丘丛下丒丅且丕且.FillData(丄丒且丙三丆丟与丏:  val_1, 世丟万一丘丐丙丝与:  丏三丅世世一业专与);
        七丘丛下丒丅且丕且.gameObject.SetActive(value:  false);
        val_8 = 七丘丛下丒丅且丕且.gameObject;
        val_9 = 1;
        label_5:
        val_8.SetActive(value:  true);
    }
    private int 世一万丝丝七丗三丅()
    {
        return 4;
    }
    private void 丕万丆丁丅丁丄世丏(UIWrapContent 上丈世丁丐丒业上世, 丝丟万七上东丅丄丄 丏三丅世世一业专与)
    {
        丝丟万七上东丅丄丄 val_6;
        var val_7;
        var val_8;
        val_6 = 丏三丅世世一业专与;
        if(上丈世丁丐丒业上世 == 0)
        {
                return;
        }
        
        T[] val_2 = 上丈世丁丐丒业上世.GetComponentsInChildren<FriendPreviewItem>(includeInactive:  true);
        int val_3 = this.专专丟丁丗且世七上();
        val_7 = 0;
        val_8 = 0;
        goto label_5;
        label_14:
        if(val_3 != 0)
        {
                UIDragScrollView val_4 = val_2[0].GetComponent<UIDragScrollView>();
            if(val_3 < 5)
        {
                val_4.enabled = false;
            val_8 = 1;
        }
        else
        {
                val_4.enabled = true;
        }
        
        }
        
        this.上世丘丛业丕上丏且(七丘丛下丒丅且丕且:  val_2[0], 丏三丅世世一业专与:  val_6);
        val_7 = 1;
        label_5:
        if(val_7 < val_2.Length)
        {
            goto label_14;
        }
        
        val_6 = this.friendsListWrap;
        if(上丈世丁丐丒业上世 == val_6)
        {
                this.friendsListScrollView.ResetPosition();
        }
        
        if((val_8 & 1) == 0)
        {
                return;
        }
        
        this.friendsListScrollView.丅丛东万丕丆丟丕丆(丄丕丝下丒东上丞丁:  上丈世丁丐丒业上世);
    }
    private void 七丙三丞丝三且不丘()
    {
        this.丘一丘丒丝丕丂三丑();
        this.<丗丆东丄丁丘与且丐>k__BackingField = true;
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丒七丁丙丝丘世丅 != 3)
        {
            goto label_8;
        }
        
        this.<丗丆东丄丁丘与且丐>k__BackingField = true;
        this.万丅丕世丛丌丗丄三();
        goto label_4;
        label_0:
        this.<丗丆东丄丁丘与且丐>k__BackingField = true;
        if(this.statusBar.丆世丁东丏丞不世三() != true)
        {
                this.丂丅万丑下东丏丈东();
        }
        
        label_4:
        if((this.<丗丆东丄丁丘与且丐>k__BackingField) == false)
        {
                return;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
                if(this.statusBar.丆世丁东丏丞不世三() != false)
        {
                return;
        }
        
        }
        
        label_8:
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丏三丝丟下丟丙丑一());
    }
    public void OnClickFriendListTab(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗.value != false)
        {
                ButtonClickSound.丁业上丏不丕三丗不();
        }
        
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        this.三业上丙丆丌丕上业();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.friendsContainer, 丏业丟一东丂东丘丛:  true);
        this.friendsContainer.HideInfoBox();
        this.<丗丆东丄丁丘与且丐>k__BackingField = true;
        this.丄专丛业丞丞丌丝丈();
    }
    private void 丂丅万丑下东丏丈东()
    {
        var val_8;
        bool val_9;
        bool val_10;
        var val_11;
        val_8 = null;
        this.丘业丙下丌七世丑丂 = FriendsController.丁丘万不丌丏丗丗且();
        if(this.statusBar.丆世丁东丏丞不世三() != false)
        {
                val_9 = this.丘业丙下丌七世丑丂;
            var val_4 = (val_9 == false) ? 1 : 0;
        }
        else
        {
                val_11 = null;
            if(FriendsController.丈与且丄一丗东丅丒() != false)
        {
                var val_6 = (this.丘业丙下丌七世丑丂 != true) ? 1 : 0;
        }
        else
        {
                val_10 = false;
        }
        
            val_9 = this.丘业丙下丌七世丑丂;
        }
        
        this.万不丟丁丝丁业丑一 = val_10;
        this.statusBar.丂丅万丑下东丏丈东(丛万不丞丝丌上万不:  (val_9 == true) ? 1 : 0);
        this.与丒丙且丂丝丏丗丆(下丘丞万三一丈与一:  this.万不丟丁丝丁业丑一, 丛万不丞丝丌上万不:  this.丘业丙下丌七世丑丂);
        this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  this.findFriendsWrap, 丏三丅世世一业专与:  2);
    }
    private void 丘下不丛丘不丏丑丛()
    {
        this.丗丒七丁丙丝丘世丅 = 1;
        this.丂丅万丑下东丏丈东();
    }
    public void OnClickFindFriendsTab(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗.value != false)
        {
                ButtonClickSound.丁业上丏不丕三丗不();
        }
        
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        this.三业上丙丆丌丕上业();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.findContainer, 丏业丟一东丂东丘丛:  true);
        this.findContainer.HideInfoBox();
        this.<丗丆东丄丁丘与且丐>k__BackingField = true;
        if(this.statusBar.丆世丁东丏丞不世三() != false)
        {
                this.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  1, 上丗与不丑丄丞丆业:  false);
            this.丅丛东万丕丆丟丕丆(丄丕丝下丒东上丞丁:  this.findFriendsWrap);
        }
        
        this.丗丒七丁丙丝丘世丅 = 1;
        this.丂丅万丑下东丏丈东();
        this.statusBar.findFriendInput.value = System.String.alignConst;
    }
    private void 下丝丄丑丟下丄上丁()
    {
        var val_3;
        this.丗丒七丁丙丝丘世丅 = 2;
        val_3 = null;
        bool val_2 = FriendsController.上丄七丙东三上业丕();
        this.与丒丙且丂丝丏丗丆(下丘丞万三一丈与一:  val_2, 丛万不丞丝丌上万不:  false);
        this.chatContainer.SetActive(value:  val_2);
        this.statusBar.OnClickChatTab();
    }
    public void OnClickFriendsChatTab(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗.value != false)
        {
                ButtonClickSound.丁业上丏不丕三丗不();
        }
        
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        this.三业上丙丆丌丕上业();
        this.HideInfoBox();
        this.下丝丄丑丟下丄上丁();
    }
    private void 万丅丕世丛丌丗丄三()
    {
        var val_6;
        this.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  3, 上丗与不丑丄丞丆业:  false);
        this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  this.inviteFriendsWrap, 丏三丅世世一业专与:  3);
        val_6 = null;
        this.万不丟丁丝丁业丑一 = FriendsController.丄丌万世东丕丈丆万();
        bool val_4 = FriendsController.丁丘万不丌丏丗丗且();
        this.丘业丙下丌七世丑丂 = val_4;
        this.statusBar.OnClickInboxFriendsTab(丘丘丁丐上且上丞业:  (this.万不丟丁丝丁业丑一 == true) ? 1 : 0, 丛万不丞丝丌上万不:  val_4);
        this.与丒丙且丂丝丏丗丆(下丘丞万三一丈与一:  this.万不丟丁丝丁业丑一, 丛万不丞丝丌上万不:  false);
    }
    private void 丌丛丄丒不万且丌丐()
    {
        this.丗丒七丁丙丝丘世丅 = 3;
        this.万丅丕世丛丌丗丄三();
    }
    public void OnClickInboxFriendsTab(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗.value != false)
        {
                ButtonClickSound.丁业上丏不丕三丗不();
        }
        
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        this.三业上丙丆丌丕上业();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inviteContainer, 丏业丟一东丂东丘丛:  true);
        this.inviteContainer.HideInfoBox();
        this.丗丒七丁丙丝丘世丅 = 3;
        this.万丅丕世丛丌丗丄三();
    }
    internal void 与不丘丌且世上丟业()
    {
        if(this.丗丒七丁丙丝丘世丅 == 3)
        {
            goto label_0;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return;
        }
        
        this.丄专丛业丞丞丌丝丈();
        return;
        label_0:
        this.丗丒七丁丙丝丘世丅 = this.丗丒七丁丙丝丘世丅;
        this.万丅丕世丛丌丗丄三();
        return;
        label_1:
        this.丗丒七丁丙丝丘世丅 = this.丗丒七丁丙丝丘世丅;
        this.丂丅万丑下东丏丈东();
    }
    internal static int 丏丕专一丞不丟丑丗(System.Collections.Generic.Dictionary<string, string> 丄且丆丘丆丏丄且东)
    {
        var val_4;
        int val_2 = System.Convert.ToInt32(value:  丄且丆丘丆丏丄且东.Item["game_mode"]);
        if(val_2 != 6)
        {
                if(val_2 != 7)
        {
                return (int)(val_2 != 18) ? 0 : 7;
        }
        
            val_4 = 3;
            return (int)(val_2 != 18) ? 0 : 7;
        }
        
        val_4 = 2;
        return (int)(val_2 != 18) ? 0 : 7;
    }
    private int 下世丙上丏丏丘下专(string 丞丘不丙万丈丕万且, string 七万业丅丌丌丂丝且)
    {
        string val_27;
        FriendsController val_28;
        var val_29;
        var val_30;
        var val_31;
        ulong val_32;
        val_27 = 七万业丅丌丌丂丝且;
        if((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().ContainsKey(key:  丞丘不丙万丈丕万且)) == false)
        {
            goto label_6;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_6 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().Item[丞丘不丙万丈丕万且];
        if(val_6 == null)
        {
            goto label_6;
        }
        
        val_28 = FriendsWindowController.丏丕专一丞不丟丑丗(丄且丆丘丆丏丄且东:  val_6);
        goto label_7;
        label_6:
        val_28 = 4;
        label_7:
        if((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().ContainsKey(key:  val_27)) == false)
        {
            goto label_13;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_13 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().Item[val_27];
        if(val_13 == null)
        {
            goto label_13;
        }
        
        val_29 = FriendsWindowController.丏丕专一丞不丟丑丗(丄且丆丘丆丏丄且东:  val_13);
        goto label_14;
        label_13:
        val_29 = 4;
        label_14:
        System.Collections.Generic.IEnumerable<System.String> val_16 = Rilisoft.丈丑丟丏丏与丟丙且.丑七不且上丗丁一世().业丆丙丆东上丛三丅();
        if(val_28 >= val_29)
        {
            goto label_21;
        }
        
        label_39:
        val_30 = 0;
        return (int)val_30;
        label_21:
        if(val_28 > val_29)
        {
                val_30 = 1;
            return (int)val_30;
        }
        
        val_31 = null;
        val_31 = null;
        val_28 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_28 == 0)
        {
                val_30 = 0;
            return (int)val_30;
        }
        
        if(val_28 != null)
        {
                System.DateTime val_21 = val_28.GetDateLastClickJoinFriend(丑三丅丒丕丗三丏丁:  丞丘不丙万丈丕万且);
            val_32 = val_21.dateData;
        }
        else
        {
                System.DateTime val_22 = 0.GetDateLastClickJoinFriend(丑三丅丒丕丗三丏丁:  丞丘不丙万丈丕万且);
            val_32 = val_22.dateData;
        }
        
        System.DateTime val_23 = val_28.GetDateLastClickJoinFriend(丑三丅丒丕丗三丏丁:  val_27);
        val_28 = 1152921504618614784;
        val_27 = val_23.dateData;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_32}, t2:  new System.DateTime() {dateData = val_27})) == true)
        {
            goto label_39;
        }
        
        val_30 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_32}, t2:  new System.DateTime() {dateData = val_27});
        return (int)val_30;
    }
    private int 与专丑三丞丞丈丆丁(string 丅丝丕丒丒丑东上一, string 丕丄丟丝业丗丕七与)
    {
        var val_4;
        三丁丏一丄下三东一 val_1 = FriendsController.东丁丘下丛丑上丝且(丄丒且丙三丆丟与丏:  丅丝丕丒丒丑东上一);
        三丁丏一丄下三东一 val_2 = FriendsController.东丁丘下丛丑上丝且(丄丒且丙三丆丟与丏:  丕丄丟丝业丗丕七与);
        if(val_1 >= val_2)
        {
                return (int)(val_1 > val_2) ? 1 : 0;
        }
        
        val_4 = 0;
        return (int)(val_1 > val_2) ? 1 : 0;
    }
    private void 世不丅丛三丄丗丆丑()
    {
        if(this.丗丒七丁丙丝丘世丅 != 3)
        {
                if(this.丗丒七丁丙丝丘世丅 != 0)
        {
                return;
        }
        
        }
        
        this.三丄丙下与七丟下丘(丛丗丛丁七丆万丟丅:  false);
    }
    private void 三丄丙下与七丟下丘(bool 丛丗丛丁七丆万丟丅)
    {
        不丑丙丒专丟丕丘丙 val_1;
        UIWrapContent val_2;
        UIWrapContent val_3;
        丝丟万七上东丅丄丄 val_4;
        if(FriendsWindowController.丞世丑丁且丌丙丛专 != null)
        {
                FriendsWindowController.丞世丑丁且丌丙丛专.Invoke();
        }
        
        val_1 = this.丗丒七丁丙丝丘世丅;
        if(val_1 != 0)
        {
            goto label_2;
        }
        
        this.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  0, 上丗与不丑丄丞丆业:  false);
        if(this.丗丒七丁丙丝丘世丅 == 3)
        {
            goto label_3;
        }
        
        if(this.丗丒七丁丙丝丘世丅 == 1)
        {
            goto label_4;
        }
        
        if(this.丗丒七丁丙丝丘世丅 != 0)
        {
            goto label_5;
        }
        
        val_2 = this.friendsListWrap;
        goto label_7;
        label_3:
        val_2 = this.inviteFriendsWrap;
        goto label_7;
        label_4:
        val_2 = this.findFriendsWrap;
        label_7:
        val_3 = mem[this.findFriendsWrap];
        goto label_8;
        label_5:
        val_3 = 0;
        label_8:
        if((long)this.丗丒七丁丙丝丘世丅 <= 3)
        {
                val_4 = mem[106017516 + ((long)(int)(this.丗丒七丁丙丝丘世丅)) << 2];
            val_4 = 106017516 + ((long)(int)(this.丗丒七丁丙丝丘世丅)) << 2;
        }
        else
        {
                val_4 = 0;
        }
        
        this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  val_3, 丏三丅世世一业专与:  val_4);
        val_1 = this.丗丒七丁丙丝丘世丅;
        label_2:
        if(val_1 != 3)
        {
                return;
        }
        
        this.万丅丕世丛丌丗丄三();
    }
    private void OnDisable()
    {
        System.Action val_12;
        var val_13;
        var val_14;
        System.Action val_15;
        var val_16;
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        丌且下丛三丟三业丑.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        val_13 = null;
        val_14 = null;
        if(((System.Delegate.Remove(source:  FriendsController.且与丟丗且与业丈丗, value:  new System.Action(object:  this, method:  System.Void FriendsWindowController::三丝不丞且丗与上丞()))) != null) && (null != val_14))
        {
                val_13 = null;
            val_14 = null;
            val_12 = 0;
        }
        
        FriendsController.且与丟丗且与业丈丗 = val_12;
        val_16 = null;
        if(((System.Delegate.Remove(source:  FriendsController.下与世万丏丏丅一丏, value:  new System.Action(object:  this, method:  public System.Void FriendsWindowController::HideInfoBox()))) != null) && (null != val_16))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        FriendsController.下与世万丏丏丅一丏 = val_15;
        丐丌不丏东丟丕七丟.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::世不丅丛三丄丗丆丑()));
        东丐丁丐与丟下丄丈.丄丏丏丛丑丏东且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        丌丟丄专丂丒丁丛三.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsWindowController::七丙三丞丝三且不丘()));
        InfoWindowController.一丘丕上丈一丂丐丌();
        Rilisoft.丈丑丟丏丏与丟丙且.丑七不且上丗丁一世().三上丕丌万丑丝丟与();
    }
    private void OnDestroy()
    {
        FriendsController.丌业丗丈业丑一丙与();
        FriendsWindowController.丆丕丝丒不丙且丐丗 = 0;
    }
    public void Hide()
    {
        this.gameObject.SetActive(value:  false);
    }
    public void Show()
    {
        this.gameObject.SetActive(value:  true);
    }
    private void 丂不上东丒万丙丒不(bool 丕丁丗丘丟丆一丟丆)
    {
        if(丕丁丗丘丟丆一丟丆 != false)
        {
                this.<丗丆东丄丁丘与且丐>k__BackingField = true;
        }
        
        this.gameObject.SetActive(value:  true);
        this.joinToFriendRoomPhoton.SetActive(value:  true);
        if(this.三丝上丙一丈丕万丟 != 0)
        {
                this.三丝上丙一丈丕万丟.不下丌丆东丑丈丕丝();
        }
        
        this.与不丘丌且世上丟业();
    }
    internal void 世专丌业丘丒丛丅上(string 丑三丅丒丕丗三丏丁, FriendPreviewItem 丁丑丞不丗专丑业万)
    {
        this.三丝上丙一丈丕万丟 = 丁丑丞不丗专丑业万;
        this.gameObject.SetActive(value:  false);
        this.joinToFriendRoomPhoton.SetActive(value:  false);
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  丑三丅丒丕丗三丏丁, 丁丅丈丌丟世丗丗丟:  0, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void FriendsWindowController::丂不上东丒万丙丒不(bool 丕丁丗丘丟丆一丟丆)));
    }
    internal void 丌丆丁且丐丄丕丑丞(string 丞丅上丏丂且下丅与)
    {
        PrivateChatController val_2 = PrivateChatController.丄丞丁丈与业上丞丟;
        if(val_2 != 0)
        {
                val_2 = PrivateChatController.丄丞丁丈与业上丞丟;
            PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerID = 丞丅上丏丂且下丅与;
        }
        
        this.chatTab.Set(丏业丟一东丂东丘丛:  true);
        this.下丝丄丑丟下丄上丁();
    }
    internal void 下丕丗丕丁丟丁丛一(string 丂丐丄丁丆与丈丂上)
    {
        var val_6;
        this.不不丛丐丈丗丏丙丂();
        string[] val_1 = new string[1];
        val_1[0] = "";
        this.下丈丅与丄丏七上丗 = val_1;
        this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  this.findFriendsWrap, 丏三丅世世一业专与:  2);
        val_6 = null;
        val_6 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_3.Add(key:  "Search Friends", value:  "Search");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Social", 丛东不丒丏丈丄且丕:  val_3);
        FriendsController.丄丞丁丈与业上丞丟.SearchPlayersByString(丂丐丄丁丆与丈丂上:  丂丐丄丁丆与丈丂上, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void FriendsWindowController::丞丆丝丑丗业丗丄丞()), 七丛丟丕丐丆丆丝七:  new System.Action(object:  this, method:  System.Void FriendsWindowController::丆丛万丘丏丞丆丂一()));
    }
    public void OnClickClearAllInboxButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        东丐丁丐与丟下丄丈.丑七不且上丗丁一世().一丈下丂丂不专丁丄();
    }
    internal void 三丐丂不丐丄丑不七()
    {
        UnityEngine.Coroutine val_2 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.万下下丛东丕丏世丐());
    }
    internal void 专丒丆丌丝丙上丙丐()
    {
        this.friendsTab.Set(丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.IEnumerator 万下下丛东丕丏世丐()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FriendsWindowController.七丂且丒丙丑东不丙(丗丏丅丕丆世丁专丟:  0);
    }
    private void 三业上丙丆丌丕上业()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.friendsContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.findContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inviteContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chatContainer, 丏业丟一东丂东丘丛:  false);
    }
    public FriendsWindowController()
    {
    
    }
    private void 丞丆丝丑丗业丗丄丞()
    {
        var val_9;
        string val_10;
        if(this.statusBar.丆世丁东丏丞不世三() == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if((System.Linq.Enumerable.Any<System.String>(source:  FriendsController.丄丞丁丈与业上丞丟.<专丈丌丟不东丂三丅>k__BackingField)) == false)
        {
            goto label_6;
        }
        
        T[] val_3 = ToArray();
        this.下丈丅与丄丏七上丗 = val_3;
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_22:
        this.findFriendsWrap.minIndex = -val_3.Length;
        this.findFriendsWrap.transform.parent.GetComponent<UIScrollView>().ResetPosition();
        this.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  this.findFriendsWrap, 丏三丅世世一业专与:  2);
        return;
        label_6:
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
            goto label_17;
        }
        
        val_10 = "Key_1426";
        goto label_20;
        label_8:
        if(this.findFriendsWrap != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_17:
        val_10 = "Key_1528";
        label_20:
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_10));
        this.与丒丙且丂丝丏丗丆(下丘丞万三一丈与一:  false, 丛万不丞丝丌上万不:  false);
    }
    private void 丆丛万丘丏丞丆丂一()
    {
        string val_4;
        if(this.statusBar.丆世丁东丏丞不世三() == false)
        {
                return;
        }
        
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
                val_4 = "Key_1426";
        }
        else
        {
                val_4 = "Key_1528";
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4));
        this.与丒丙且丂丝丏丗丆(下丘丞万三一丈与一:  false, 丛万不丞丝丌上万不:  false);
    }

}
