using UnityEngine;
public sealed class ClansWindowGUI : PGBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    private bool 丘丐丞丕与丏不丟丅;
    private UnityEngine.Coroutine 万下丈且丂丅不东丛;
    private UILabel blockMessageLabel;
    private UnityEngine.GameObject blockMessagePanel;
    private const string 丈世七丄丁三世下丒 = "Clan";
    private const string 丛丗丆丅丅专丕下一 = "ClanStart";
    private const string 专丐丁且丅丁丝丛丕 = "ClanStart_v2";
    internal static ClansWindowGUI 丆丕丝丒不丙且丐丗;
    internal static bool 世丙丑丙丕七丗下丑;
    internal static bool 丆丂丐丈丈三丛丂世;
    internal static bool 三丞丆丝东且丒丆万;
    private System.IDisposable 丐丆七且丞丏下三丙;
    public UnityEngine.GameObject clanLobbtPrefab;
    public ConnectionControl clanLobbyConnectionControl;
    public bool fortOpen;
    private bool 丒丑业与丌万丏下丒;
    private bool 一丛东丆七一下丈丑;
    private 丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 丂万丝丟丏丅丒业丛;
    private static System.Action 丅丒丕丟丘世丘丐丐;
    
    // Properties
    public bool 不丁丄丌丒上丅丂丟 { get; set; }
    
    // Methods
    private System.Collections.IEnumerator 上丒三世且丙下丑丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClansWindowGUI.上丙丏丗三丆丌丒下();
    }
    public void ShowBlockMessage(string 丞丗专丌丝东丄万丁, bool 丝世业丘上业三且丄 = True, bool 丘下专下丅下业与与 = True)
    {
        this.丘丐丞丕与丏不丟丅 = 丘下专下丅下业与与;
        if(this.万下丈且丂丅不东丛 != null)
        {
                this.StopCoroutine(routine:  this.万下丈且丂丅不东丛);
        }
        
        this.blockMessagePanel.SetActive(value:  true);
        this.blockMessageLabel.text = 丞丗专丌丝东丄万丁;
        if(丝世业丘上业三且丄 == false)
        {
                return;
        }
        
        this.万下丈且丂丅不东丛 = this.StartCoroutine(routine:  this.上丒三世且丙下丑丝());
    }
    public void HideBlockMessage()
    {
        if(this.万下丈且丂丅不东丛 != null)
        {
                this.StopCoroutine(routine:  this.万下丈且丂丅不东丛);
        }
        
        this.blockMessagePanel.SetActive(value:  false);
    }
    public void U_BlockMessageClick()
    {
        if(this.丘丐丞丕与丏不丟丅 == false)
        {
                return;
        }
        
        this.HideBlockMessage();
    }
    public bool get_InterfaceEnabled()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    private void 丟丁专丁丈丕丁一丙(bool 丙业与丙丗丝不丈东)
    {
        var val_23;
        var val_24;
        object val_31;
        UnityEngine.Object val_32;
        var val_34;
        var val_35;
        var val_36;
        var val_38;
        var val_39;
        val_31 = this;
        val_32 = this.gameObject;
        if(val_32 == 0)
        {
                return;
        }
        
        val_32 = this.gameObject;
        val_32.SetActive(value:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_5;
        }
        
        if(this.丐丆七且丞丏下三丙 == null)
        {
            goto label_6;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        goto label_10;
        label_5:
        if(this.丌丟丄业且三丛丕丄().childCount < 1)
        {
            goto label_12;
        }
        
        val_34 = 0;
        goto label_13;
        label_19:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丌丟丄业且三丛丕丄().GetChild(index:  0).gameObject, 丏业丟一东丂东丘丛:  false);
        val_34 = 1;
        label_13:
        val_32 = this.丌丟丄业且三丛丕丄();
        if(val_34 < val_32.childCount)
        {
            goto label_19;
        }
        
        val_35 = 0;
        goto label_21;
        label_29:
        val_32 = this.gameObject.GetComponentsInChildren<Rilisoft.丁丝与丅丏且丂丙下>(includeInactive:  true)[0];
        var val_33 = val_32;
        if((val_13[0x0][0] + 286) == 0)
        {
            goto label_27;
        }
        
        var val_30 = val_13[0x0][0] + 176;
        var val_31 = 0;
        val_30 = val_30 + 8;
        label_26:
        if(((val_13[0x0][0] + 176 + 8) + -8) == null)
        {
            goto label_25;
        }
        
        val_31 = val_31 + 1;
        val_30 = val_30 + 16;
        if(val_31 < (val_13[0x0][0] + 286))
        {
            goto label_26;
        }
        
        goto label_27;
        label_25:
        var val_32 = val_30;
        val_32 = val_32 + 1;
        val_33 = val_33 + val_32;
        val_36 = val_33 + 296;
        label_27:
        val_32.HideWindow();
        val_35 = 1;
        label_21:
        if(val_35 < val_13.Length)
        {
            goto label_29;
        }
        
        label_12:
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        goto label_34;
        label_10:
        this.丐丆七且丞丏下三丙.Dispose();
        label_6:
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Clans");
        val_38 = null;
        val_38 = null;
        this.丘丆与与且专与与丅(丅丆业丄丙下一与丗:  ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == 0) ? ((ClansController.万且丄丂丆丄一世七 == true) ? "ClanStart_v2" : "ClanStart") : "Clan");
        val_39 = null;
        val_39 = null;
        List.Enumerator<T> val_22 = ChatController.丑丈万一下丗丘丄丘.GetEnumerator();
        goto label_46;
        label_47:
        string val_25 = val_24.丐丏七丌丕丗业且上();
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        label_46:
        if((2018407712 & 1) != 0)
        {
            goto label_47;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_52;
        label_34:
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
        return;
        label_52:
        List.Enumerator<T> val_27 = 0x1000000000E2C000.__il2cppRuntimeField_70.GetEnumerator();
        val_32 = 1152921525655684976;
        goto label_58;
        label_59:
        val_31 = 0.丐丏七丌丕丗业且上();
        if(0 == 0)
        {
                mem2[0] = 1;
        }
        
        label_58:
        if((2018407688 & 1) != 0)
        {
            goto label_59;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        ChatController.下七丆丈且丝丝丈一();
        丙万三丈丆丄丑东且.不下丑丆丐且丆下与();
    }
    internal static void 上丘丛与丑丏丄一丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ClansWindowGUI.丅丒丕丟丘世丘丐丐, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ClansWindowGUI.丅丒丕丟丘世丘丐丐 != 1152921505152589840);
    
    }
    internal static void 丅丑一丏下丑丕一东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ClansWindowGUI.丅丒丕丟丘世丘丐丐, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ClansWindowGUI.丅丒丕丟丘世丘丐丐 != 1152921505152589840);
    
    }
    private void Awake()
    {
        null = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗 = this;
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
        PGCompany.Clans.Network.丂丏万丙丟世与丄丟.丛丗三业下丑丑丈与(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, System.String>(object:  this, method:  System.Void ClansWindowGUI::丄丏业业万七世世且(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)));
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.与丈丏不丘专丙丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丞下丛一丂丕丄丆三()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().丞丝三丑丘专丝丙丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::与丞丛丂丅丏丅业业()));
    }
    private void 不业丛丑丝丘东丘丅()
    {
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.丟业丅世丟丗丄丞万() < 2)
        {
                return;
        }
        
        this.丝东丐丝东三丈世丝();
    }
    private void Start()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClansWindowGUI.世丙丑丙丕七丗下丑 == false)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                this.EnterSiegeMode();
        }
        
        val_4 = null;
        val_4 = null;
        ClansWindowGUI.世丙丑丙丕七丗下丑 = false;
    }
    private void OnDestroy()
    {
        null = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗 = 0;
        PGCompany.Clans.Network.丂丏万丙丟世与丄丟.不专丑丛丌丕一丘丏(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, System.String>(object:  this, method:  System.Void ClansWindowGUI::丄丏业业万七世世且(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)));
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.丐丆丄业丒不丆且丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丞下丛一丂丕丄丆三()));
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClansWindowGUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丄丕丂丁丘丌丕丗一()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::与丞丛丂丅丏丅业业()));
    }
    private void OnEnable()
    {
        this.fortOpen = false;
        ClansController.丒世丒业丙丟丌世上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丂七下丂丂七丈万不()));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::不业丛丑丝丘东丘丅()));
        丌丅且丗七丘丅丛丑.丌业三专丞丆万丏丁(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClansWindowGUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
    }
    private void 丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)
    {
        if(PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        PGCompany.Banners.ClanRankPromoteWindow.与丏不丂专丕丁世丐(与上丟丏业专业与专:  new 上丑下丆丄下丝东世() {丒丗丝七丛丟专丄丂 = 万且万且丑丗且丌丆.丒丗丝七丛丟专丄丂, 且丅七丏业丛丙丟下 = 万且万且丑丗且丌丆.且丅七丏业丛丙丟下, 世丛丘丙世丝丟一丂 = 万且万且丑丗且丌丆.世丛丘丙世丝丟一丂, 丟专丙丐专世丁与一 = 万且万且丑丗且丌丆.丟专丙丐专世丁与一});
        if(万且万且丑丗且丌丆.世丛丘丙世丝丟一丂 <= 万且万且丑丗且丌丆.丒丗丝七丛丟专丄丂)
        {
                return;
        }
        
        this.一丛东丆七一下丈丑 = true;
    }
    private void Update()
    {
        var val_1;
        if(this.一丛东丆七一下丈丑 == false)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        if(PGCompany.ClanLootBoxRewardUI.七丂丑七丑世丂不丒 != false)
        {
                return;
        }
        
        this.一丛东丆七一下丈丑 = false;
        丌丅且丗七丘丅丛丑.丏丂专丄七且不丌丛();
    }
    private void 与丞丛丂丅丏丅业业()
    {
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        与丂丅三丂且不不与.丑七不且上丗丁一世().三丐七丕丘与丂丑丈();
    }
    private void OnDisable()
    {
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丂七下丂丂七丈万不()));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::不业丛丑丝丘东丘丅()));
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClansWindowGUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
        this.一丛东丆七一下丈丑 = false;
    }
    private void 丄丏业业万七世世且(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)
    {
        UnityEngine.GameObject val_1 = this.丙不万世丟万丝一上(丅丆业丄丙下一与丗:  "ClanStart");
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.activeSelf == false)
        {
                return;
        }
        
        val_1.SetActive(value:  false);
        this.丘丆与与且专与与丅(丅丆业丄丙下一与丗:  "Clan");
    }
    private void 丞下丛一丂丕丄丆三()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丝东丐丝东三丈世丝();
    }
    public void ShowInterface(System.Action 丄丐丙丏业丐世丐丛)
    {
        Rilisoft.FortCraftController val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_17 = Rilisoft.Singleton<ClansController>.Instance;
        丞丂丘丒丟丞丑下丄 val_2 = val_17.丞丗丑丈一丅丗丌丟();
        if(val_2 != null)
        {
                if(val_2.丟业丅世丟丗丄丞万() > 1)
        {
                return;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 != true)
        {
                val_19 = null;
            val_19 = null;
            bool val_17 = ~ClansTutorialController.上且世丘丝三丄丈丗();
            val_17 = val_17 & 1;
            ClansWindowGUI.丆丂丐丈丈三丛丂世 = val_17;
        }
        
        if(LoadingNGUIController.丈丗丑丛下东丂丝丟() != true)
        {
                PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            InfoWindowController.一丘丕上丈一丂丐丌();
            val_20 = null;
            val_20 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_21 = null;
            val_21 = null;
            val_17 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            if(val_17.上丙丆不丂丂丄一丂() != false)
        {
                return;
        }
        
        }
        
            val_22 = null;
            val_22 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
                val_23 = null;
            val_23 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy != false)
        {
                val_24 = null;
            val_24 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.isSeeLobbyEnable != false)
        {
                val_25 = null;
            val_25 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.HandleBackSeeLobby();
        }
        
            val_26 = null;
            val_26 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.OnBackButtonClick();
        }
        
        }
        
        }
        
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 != 0)
        {
                if(ClansWindowInfoViewController.丄丘七三上丕世丞业.isActiveAndEnabled != false)
        {
                ClansWindowInfoViewController.丄丘七三上丕世丞业.CloseWindow();
        }
        
        }
        
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        ClansWindowGUI.丅丑一丏下丑丕一东(丙业与丙丗丝不丈东:  丄丐丙丏业丐世丐丛);
        ClansWindowGUI.上丘丛与丑丏丄一丌(丙业与丙丗丝不丈东:  丄丐丙丏业丐世丐丛);
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丄丕丂丁丘丌丕丗一()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丄丕丂丁丘丌丕丗一()));
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().下丛丕丑丌丕丁专丆();
    }
    private void 丂七下丂丂七丈万不()
    {
        var val_6;
        var val_7;
        var val_8;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(LoadingNGUIController.丈丗丑丛下东丂丝丟() != false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_7 = null;
            val_7 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != false)
        {
                val_8 = null;
            val_8 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.U_BackButtonAction();
        }
        
        }
        
        this.ShowInterface(丄丐丙丏业丐世丐丛:  0);
    }
    private void 丄丕丂丁丘丌丕丗一()
    {
        this.丒丑业与丌万丏下丒 = true;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false)
        {
                BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::世上丛丈丁业丗丑下()));
            return;
        }
        
        }
        
        this.丑下丄世一下下丁三();
    }
    private void 丛丂丕不专丗不上丁()
    {
        this.ShowInterface(丄丐丙丏业丐世丐丛:  0);
    }
    private void 东丕一业丟丟与专丟(string 丅一丞万丑专丅丅与)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        this.HideInterface();
        val_3 = null;
        val_3 = null;
        SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_5 = null;
            val_5 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        val_6 = null;
        val_6 = null;
        SquadController.丄丘七三上丕世丞业.JoinSquad(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丛丂丕不专丗不上丁()), 丐一三丞丝丌不丏丑:  丅一丞万丑专丅丅与);
    }
    public void JoinToSquadPoint(ConnectionControl 丙不丅丝丙专丕世丐, string 丅一丞万丑专丅丅与)
    {
        ClansWindowGUI val_5 = this;
        ClansWindowGUI.丅三丈世丝丑专丂世 val_1 = new ClansWindowGUI.丅三丈世丝丑专丂世();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = val_5;
        }
        else
        {
                mem[16] = val_5;
        }
        
        .丅一丞万丑专丅丅与 = 丅一丞万丑专丅丅与;
        if(丙不丅丝丙专丕世丐 == 0)
        {
                return;
        }
        
        if(this.clanLobbyConnectionControl != 0)
        {
                this.clanLobbyConnectionControl.enabled = false;
        }
        
        System.Action val_4 = null;
        val_5 = val_4;
        val_4 = new System.Action(object:  val_1, method:  System.Void ClansWindowGUI.丅三丈世丝丑专丂世::丆且丂丗丐三丟且丛());
        丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  val_4, 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    public void EnterSiegeMode()
    {
        this.ShowInterface(丄丐丙丏业丐世丐丛:  0);
        Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().HandleOnSiegeClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
    }
    public void EnterClanWarMode()
    {
        this.ShowInterface(丄丐丙丏业丐世丐丛:  0);
        Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().HandleOnClanWarClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
    }
    public void EnterClanWarTestMode()
    {
        this.ShowInterface(丄丐丙丏业丐世丐丛:  0);
        Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().HandleOnClanWarTestModeClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
    }
    private void 世上丛丈丁业丗丑下()
    {
        if(this.丒丑业与丌万丏下丒 != false)
        {
                this.丑下丄世一下下丁三();
        }
        
        BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::世上丛丈丁业丗丑下()));
    }
    private void 丑下丄世一下下丁三()
    {
        var val_16;
        var val_17;
        var val_18;
        UnityEngine.Object val_19;
        this.丒丑业与丌万丏下丒 = false;
        this.丝东丐丝东三丈世丝();
        val_16 = 1152921505049497600;
        val_17 = null;
        val_17 = null;
        if(ClanChatController.丄丞丁丈与业上丞丟 != 0)
        {
                val_18 = null;
            val_18 = null;
            ClanChatController.丄丞丁丈与业上丞丟.丆世与丑丆丅丐万且();
        }
        
        val_19 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
        if(val_19 != 0)
        {
                val_19 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
            val_19.不万三丗丗不丌世丘();
        }
        
        if(UnityEngine.SceneManagement.SceneManager.sceneCount < 1)
        {
                return;
        }
        
        val_19 = 0;
        label_18:
        UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
        val_16 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if((((System.String.op_Equality(a:  val_6.m_Handle.name, b:  val_16.丈一丝万丈世丛万一())) == true) || ((System.String.op_Equality(a:  val_6.m_Handle.name, b:  "FortFieldBuild")) == true)) || ((System.String.op_Equality(a:  val_6.m_Handle.name, b:  "ClanTankBuild")) == true))
        {
            goto label_17;
        }
        
        val_19 = val_19 + 1;
        if(val_19 < UnityEngine.SceneManagement.SceneManager.sceneCount)
        {
            goto label_18;
        }
        
        return;
        label_17:
        丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
    }
    private void 丘丆与与且专与与丅(string 丅丆业丄丙下一与丗)
    {
        UnityEngine.GameObject val_19;
        var val_20;
        UnityEngine.Object val_21;
        UnityEngine.GameObject val_22;
        val_19 = this;
        val_20 = this.丌丟丄业且三丛丕丄();
        if(val_20.childCount < 1)
        {
            goto label_2;
        }
        
        val_20 = 0;
        val_21 = 0;
        goto label_3;
        label_27:
        UnityEngine.Transform val_4 = this.丌丟丄业且三丛丕丄().GetChild(index:  0);
        Rilisoft.丁丝与丅丏且丂丙下 val_5 = val_4.GetComponent<Rilisoft.丁丝与丅丏且丂丙下>();
        val_22 = val_4.gameObject;
        if((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_4), b:  丅丆业丄丙下一与丗)) == false)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4.gameObject, 丏业丟一东丂东丘丛:  true);
        if(val_5 == null)
        {
            goto label_25;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        goto label_17;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_22, 丏业丟一东丂东丘丛:  false);
        if(val_5 == null)
        {
            goto label_20;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        goto label_24;
        label_17:
        val_5.ShowWindow();
        goto label_25;
        label_24:
        val_5.HideWindow();
        label_20:
        val_22 = val_21;
        label_25:
        val_20 = 1;
        val_21 = val_22;
        label_3:
        if(val_20 < this.丌丟丄业且三丛丕丄().childCount)
        {
            goto label_27;
        }
        
        goto label_28;
        label_2:
        val_21 = 0;
        label_28:
        if(val_21 != 0)
        {
                return;
        }
        
        val_19 = this.gameObject;
        int val_17 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        UnityEngine.GameObject val_18 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  System.String.Format(format:  "NguiWindows/Clan/{0}", arg0:  丅丆业丄丙下一与丗), 七万上丐一丈丏丏专:  val_19, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    private UnityEngine.GameObject 丙不万世丟万丝一上(string 丅丆业丄丙下一与丗)
    {
        var val_7 = 0;
        do
        {
            if(val_7 >= this.丌丟丄业且三丛丕丄().childCount)
        {
                return 0;
        }
        
            UnityEngine.Transform val_4 = this.丌丟丄业且三丛丕丄().GetChild(index:  0);
            val_7 = val_7 + 1;
        }
        while((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_4), b:  丅丆业丄丙下一与丗)) == false);
        
        if(val_4 != null)
        {
                return val_4.gameObject;
        }
        
        return val_4.gameObject;
    }
    public void HideInterface()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Action val_19;
        val_10 = null;
        val_10 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 != false)
        {
                val_11 = null;
            val_11 = null;
            if(ClanStartGui_v2.业世不丌不丌不东业 == true)
        {
                return;
        }
        
            val_10 = null;
        }
        
        val_10 = null;
        ClansWindowGUI.三丞丆丝东且丒丆万 = true;
        if(LoadingNGUIController.丈丗丑丛下东丂丝丟() != false)
        {
                return;
        }
        
        InfoWindowController.一丘丕上丈一丂丐丌();
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 != 0)
        {
                if(ClansWindowInfoViewController.丄丘七三上丕世丞业.gameObject.activeInHierarchy != false)
        {
                ClansWindowInfoViewController.丄丘七三上丕世丞业.CloseWindow();
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        if(ClansWindowGUI.丅丒丕丟丘世丘丐丐 != null)
        {
                val_13 = null;
            val_13 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
                val_14 = null;
            val_14 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy != false)
        {
                val_15 = null;
            val_15 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.isSeeLobbyEnable != false)
        {
                val_16 = null;
            val_16 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.HandleBackSeeLobby();
        }
        
            val_17 = null;
            val_17 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.OnBackButtonClick();
        }
        
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        val_19 = ClansWindowGUI.丅丒丕丟丘世丘丐丐;
        if(val_19 != null)
        {
                val_19 = ClansWindowGUI.丅丒丕丟丘世丘丐丐;
            if(val_19 == null)
        {
                val_19 = 0;
        }
        
            val_19.Invoke();
        }
        
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowGUI::丄丕丂丁丘丌丕丗一()));
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().下丛丕丑丌丕丁专丆();
    }
    internal void 丝东丐丝东三丈世丝()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 != false)
        {
                val_3 = null;
            val_3 = null;
            if(ClanStartGui_v2.业世不丌不丌不东业 != false)
        {
                return;
        }
        
        }
        
        this.HideInterface();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 != false)
        {
                val_2 = null;
            val_2 = null;
            if(ClanStartGui_v2.业世不丌不丌不东业 == true)
        {
                return;
        }
        
        }
        
        if(this.fortOpen != false)
        {
                return;
        }
        
        this.丝东丐丝东三丈世丝();
    }
    public void TurnOn()
    {
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
    }
    public void TurnOff()
    {
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
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
    public ClansWindowGUI()
    {
    
    }
    private static ClansWindowGUI()
    {
    
    }

}
