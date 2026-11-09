using UnityEngine;
public class ClansWindowInfoViewController : MonoBehaviour
{
    // Fields
    private static UnityEngine.GameObject 丗东与丝丞丕丘丁丌;
    internal static ClansWindowInfoViewController 丄丘七三上丕世丞业;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private bool 丂丘丟丘一七上万丞;
    private UnityEngine.GameObject 丅丕且丌丏丆丏丛丌;
    private UnityEngine.GameObject _loadingCircule;
    private UnityEngine.GameObject _membersGrid;
    private UnityEngine.GameObject _membersScroll;
    private Rilisoft.BankShopViewGuiElement BankShopGUI;
    private UnityEngine.GameObject buttonsClanLider;
    private UnityEngine.GameObject buttonsSearch;
    private UIButton clanAddMoreUsers;
    private UIButton clanBack;
    private UILabel clanCapactyLabel;
    private UILabel clanCups;
    private UIButton clanDelete;
    private UIButton clanEdit;
    private UIButton clanEditToClanName;
    private UILabel clanId;
    private UIButton clanIdCopy;
    private UIButton clanInvite;
    private UIButton clanJoin;
    private UIButton clanJoinRequest;
    private UIButton clanLeave;
    private UILabel clanLiderName;
    private System.Collections.Generic.List<UITexture> clanLogos;
    private UILabel clanMedals;
    private System.Collections.Generic.List<UILabel> clanName;
    private UIButton clanRequestSended;
    private UILabel clanSiedges;
    private UILabel clanSlogan;
    private UILabel clanType;
    private UILabel clanUserCount;
    private UIButton clanVisitFort;
    private UnityEngine.GameObject clanVisitFortLoadingCircle;
    private UnityEngine.GameObject joinConditionInfoGameObject;
    private UnityEngine.GameObject promoteClanButton;
    private UnityEngine.GameObject clanPromoting;
    private UILabel promotionTimerLabel;
    private UILabel joinConditionInfoLabel;
    private UISprite joinConditionInfoSprite;
    private 丞丂丘丒丟丞丑下丄 专丁丕丞丑丕丕丟下;
    private DialogWindowController deleteClan;
    private DialogWindowController 丐东上丈上一东丏与;
    private DialogWindowController ExtendClan;
    public UnityEngine.GameObject FindButton;
    public UnityEngine.AudioClip findButtonSound;
    private bool 下世丕丂上与上上丌;
    private bool 丝丘丕丅丙下丑业丙;
    private bool 三世丑丒七与万丌丗;
    private UILabel levelRequiredLable;
    private ClansInfoMemberView lobbyMemberViewPrefab;
    private int membersItemsWrapCount;
    private UILabel officersCountLabel;
    private DialogWindowController quitFromClan;
    private MyUIInput requestMessageInput;
    private DialogWindowController requestToJoinClan;
    private UIButton showRolesInfoButton;
    private UILabel[] divisionTitleLabel;
    private UISprite[] divisionShields;
    private UILabel valorPointsCountLabel;
    private UILabel fortPowerLabel;
    private UILabel tankPowerLabel;
    private UILabel zoneCapturedCountLabel;
    private UILabel continentLabel;
    private System.Collections.Generic.HashSet<string> 东丛三下世且丗丘业;
    private const string 丂丛丟丂丏丆丆丗且 = "{0} Division";
    private System.Action 丄丑上丕丂丈丘丙七;
    private System.Collections.Generic.List<UIButton> 丑丏三丛丝与丟三丌;
    
    // Methods
    public void add_OnClose(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != this.丄丑上丕丂丈丘丙七);
    
    }
    public void remove_OnClose(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != this.丄丑上丕丂丈丘丙七);
    
    }
    private void OnEnable()
    {
        var val_13;
        var val_14;
        var val_15;
        this.东丛三下世且丗丘业.Clear();
        if(this.丐东上丈上一东丏与 != 0)
        {
                this.丐东上丈上一东丏与.CloseWindow();
        }
        
        this.BankShopGUI.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丛丛丄下业丙东三业()));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClansWindowInfoViewController::UpdateMembersScroll()));
        this.quitFromClan.CloseWindow();
        this.deleteClan.CloseWindow();
        this.requestToJoinClan.CloseWindow();
        if(this.clanJoin != 0)
        {
                this._loadingCircule.SetActive(value:  false);
        }
        
        val_13 = null;
        val_13 = null;
        bool val_7 = ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject.activeInHierarchy;
        UnityEngine.GameObject val_8 = this.clanEdit.gameObject;
        if(val_8 == null)
        {
            goto label_22;
        }
        
        if(val_7 == false)
        {
            goto label_23;
        }
        
        label_25:
        val_14 = 1;
        goto label_24;
        label_22:
        if(val_7 == true)
        {
            goto label_25;
        }
        
        label_23:
        val_14 = 0;
        label_24:
        val_8.SetActive(value:  false);
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClansWindowInfoViewController::CloseWindow()), 与且专丈不万东一万:  "ClanInfo");
        }
        
        this.丞东丙丄丟专丆丑且();
        this.下世丕丂上与上上丌 = false;
        val_15 = null;
        val_15 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一与专不下丝丌丈东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClansWindowInfoViewController::万丘丟且与一丝且丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 万丘丟且与一丝且丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                return;
        }
        
        Rilisoft.Singleton<ClansController>.Instance.丘世丛东丈丒丕丝丁(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗, 与与丂丅业丕丂丞丕:  false);
    }
    private void 丞东丙丄丟专丆丑且()
    {
        if(this.专丁丕丞丑丕丕丟下 == null)
        {
                return;
        }
        
        if(this.专丁丕丞丑丕丕丟下.丟业丅世丟丗丄丞万() < 2)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UIButton>(不丗上三丛丒上东丑:  this.丑丏三丛丝与丟三丌, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        var val_13;
        this.BankShopGUI.丆世丅三下丗丆丝丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丛丛丄下业丙东三业()));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClansWindowInfoViewController::UpdateMembersScroll()));
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丂七下丂丂七丈万不()));
        ClansController.东丏丘丞上丅丟丙不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::世下丏丝丁丕丛丛丆()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丂不丟丒下东丁丌不()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丛上上丙且丏丞丙丛()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::东下与丑丞丞丐三丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClansWindowInfoViewController::丙万丁丒东丅丌丙丄(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
            this.且丂七丑丈丞丈三丑 = 0;
        }
        
        val_13 = null;
        val_13 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一与专不下丝丌丈东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClansWindowInfoViewController::万丘丟且与一丝且丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    internal static int 与且丂丐万丝丘三下(UnityEngine.GameObject 丕专上丁丅丅丏万丌, 丞丂丘丒丟丞丑下丄 丞丌丐丞丞丘丏专下, System.Action 丘丗不丁丘丒丅丌不, bool 世丟七丕且丝丅不上 = True, bool 不丆丁且丕丅不丕七 = False)
    {
        System.Action val_35;
        System.Object[] val_36;
        ClansWindowInfoViewController val_37;
        var val_38;
        System.Action val_39;
        var val_40;
        var val_41;
        ClansWindowInfoViewController val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        val_35 = 世丟七丕且丝丅不上;
        val_36 = 丘丗不丁丘丒丅丌不;
        val_37 = 丕专上丁丅丅丏万丌;
        val_38 = 1152921504848912384;
        val_39 = 0;
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 != 0)
        {
                val_39 = mem[ClansWindowInfoViewController.丄丘七三上丕世丞业 + 520];
            val_39 = ClansWindowInfoViewController.丄丘七三上丕世丞业.丄丑上丕丂丈丘丙七;
        }
        
        if(丞丌丐丞丞丘丏专下 == null)
        {
            goto label_5;
        }
        
        label_61:
        if(ClansWindowInfoViewController.丂丛丟丂丏丆丆丗且 != 0)
        {
            goto label_11;
        }
        
        ClansWindowInfoViewController.丂丛丟丂丏丆丆丗且 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Clan/ClansWindowInfo");
        if(ClansWindowInfoViewController.丂丛丟丂丏丆丆丗且 != 0)
        {
            goto label_11;
        }
        
        val_36 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "prefab not found ClansWindowInfo", args:  val_36);
        goto label_14;
        label_11:
        val_40 = null;
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 != 0)
        {
                UnityEngine.Object.Destroy(obj:  ClansWindowInfoViewController.丄丘七三上丕世丞业.gameObject);
            val_40 = null;
            ClansWindowInfoViewController.丄丘七三上丕世丞业 = 0;
        }
        
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  ClansWindowInfoViewController.丂丛丟丂丏丆丆丗且);
        val_8.transform.SetParent(p:  val_37.transform);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        val_8.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        val_38 = val_8.transform;
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.identity;
        val_38.localRotation = new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w};
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_8, 不东丛三丂丌丑专丆:  val_37.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        val_41 = null;
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 == null)
        {
                val_41 = null;
        }
        
        mem[385] = 0;
        val_37 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        mem[386] = 不丆丁且丕丅不丕七;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_46;
        }
        
        val_37 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if((System.String.op_Equality(a:  丞丌丐丞丞丘丏专下.业丐丐三丕一丗丛丁(), b:  val_37.业丐丐三丕一丗丛丁())) == false)
        {
            goto label_46;
        }
        
        val_37 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        mem[336] = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        val_42 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        if(val_42 == null)
        {
            goto label_52;
        }
        
        val_43 = 1;
        goto label_50;
        label_46:
        val_44 = null;
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 == null)
        {
                val_44 = null;
        }
        
        mem[336] = 丞丌丐丞丞丘丏专下;
        val_42 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        if(val_42 == null)
        {
            goto label_52;
        }
        
        val_43 = 0;
        label_50:
        mem[385] = val_43;
        if(val_35 == false)
        {
            goto label_53;
        }
        
        System.Collections.Generic.List<System.String> val_31 = new System.Collections.Generic.List<System.String>();
        if(val_31 == null)
        {
            goto label_56;
        }
        
        val_31.Add(item:  "cr");
        goto label_57;
        label_5:
        if((val_36 != null) || (val_37 != 0))
        {
            goto label_61;
        }
        
        label_14:
        val_45 = 0;
        return (int)val_45;
        label_56:
        val_31.Add(item:  "cr");
        label_57:
        val_31.Add(item:  "mb");
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑().丛丐不丐丘丘万丒丂(丄丒下业一不丈丝丘:  丞丌丐丞丞丘丏专下.业丐丐三丕一丗丛丁(), 丟丐丟丂下专丅业丒:  val_31);
        System.Action val_33 = null;
        val_35 = val_33;
        val_33 = new System.Action(object:  ClansWindowInfoViewController.丄丘七三上丕世丞业, method:  System.Void ClansWindowInfoViewController::丂不丟丒下东丁丌不());
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.丏一与丏丛丘丆丅丟(丙业与丙丗丝不丈东:  val_33);
        label_53:
        val_46 = null;
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 == null)
        {
                val_46 = null;
        }
        
        mem[520] = (val_36 == 0) ? (val_39) : (val_36);
        this.丛丛丄下业丙东三业();
        val_36 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        this.UpdateMembersScroll();
        val_45 = 0;
        return (int)val_45;
        label_52:
    }
    private void 丂不丟丒下东丁丌不()
    {
        ClansWindowInfoViewController val_7 = this;
        丞丂丘丒丟丞丑下丄 val_4 = 0;
        if(this.专丁丕丞丑丕丕丟下 == null)
        {
                return;
        }
        
        PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_2 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
        if((val_2.丂丕万一丄一丂丗丒.TryGetValue(key:  this.专丁丕丞丑丕丕丟下.业丐丐三丕一丗丛丁(), value: out  val_4)) != false)
        {
                this.专丁丕丞丑丕丕丟下 = val_4;
        }
        else
        {
                UnityEngine.Debug.Log(message:  "Cant\'t Get Clan ");
        }
        
        val_7 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
        val_7.丛丛丄下业丙东三业();
    }
    private void 丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        if(BankController.丑七不且上丗丁一世() == 0)
        {
            goto label_6;
        }
        
        ClansWindowInfoViewController.丞丅丂丝丂丌丐东与 val_3 = new ClansWindowInfoViewController.丞丅丂丝丂丌丐东与();
        if(val_3 == null)
        {
            goto label_7;
        }
        
        .丝且与丝丒丟万丁专 = this;
        goto label_8;
        label_6:
        UnityEngine.Debug.LogWarning(message:  "BankController.Instance == null");
        return;
        label_7:
        mem[24] = this;
        label_8:
        .丛丟丌丝丈丞上丕丈 = 0;
        .丛丟丌丝丈丞上丕丈 = new System.EventHandler(object:  val_3, method:  System.Void ClansWindowInfoViewController.丞丅丂丝丂丌丐东与::世且丝丄不且下丙专(object 丟业丏且丟七丞一丆, System.EventArgs 业丝丑丆上丆丌丙业));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ClansWindowInfoViewController.丞丅丂丝丂丌丐东与)[1152921536697629648].丛丟丌丝丈丞上丕丈);
        this.gameObject.SetActive(value:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    private void Start()
    {
        if(this.BankShopGUI.gameObject == 0)
        {
                return;
        }
        
        this.BankShopGUI.且不丄丂上专丗三七(丙业与丙丗丝不丈东:  1);
        this.BankShopGUI.ShowTickets = false;
        this.BankShopGUI.丝一丅丆三东丂丞七();
    }
    private void Awake()
    {
        UIButton val_53;
        UnityEngine.Object val_54;
        var val_55;
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 == 0)
        {
                ClansWindowInfoViewController.丄丘七三上丕世丞业 = this;
        }
        
        System.Collections.Generic.List<UIButton> val_2 = new System.Collections.Generic.List<UIButton>();
        val_2.Add(item:  this.clanAddMoreUsers);
        val_2.Add(item:  this.clanDelete);
        val_2.Add(item:  this.clanEdit);
        val_2.Add(item:  this.clanEditToClanName);
        val_2.Add(item:  this.clanInvite);
        val_2.Add(item:  this.clanJoin);
        val_2.Add(item:  this.clanJoinRequest);
        val_2.Add(item:  this.clanLeave);
        val_2.Add(item:  this.clanRequestSended);
        val_53 = this.clanVisitFort;
        val_2.Add(item:  val_53);
        this.丑丏三丛丝与丟三丌 = val_2;
        if(this.clanDelete != 0)
        {
                val_54 = this.clanDelete.GetComponent<Rilisoft.ButtonHandler>();
            if(val_54 != 0)
        {
                val_55 = null;
        }
        else
        {
                val_54 = this.clanDelete.gameObject.AddComponent<Rilisoft.ButtonHandler>();
            val_55 = null;
        }
        
            System.EventHandler val_8 = null;
            val_53 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丙丗丐世世丑与丙丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_54.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        if(this.clanJoin != 0)
        {
                Rilisoft.ButtonHandler val_10 = this.clanJoin.GetComponent<Rilisoft.ButtonHandler>();
            if(val_10 != 0)
        {
                System.EventHandler val_12 = null;
            val_53 = val_12;
            val_12 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::业丈丝下丌丂下丝丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_10.add_Clicked(丙业与丙丗丝不丈东:  val_12);
        }
        
        }
        
        if(this.clanLeave != 0)
        {
                Rilisoft.ButtonHandler val_14 = this.clanLeave.GetComponent<Rilisoft.ButtonHandler>();
            if(val_14 != 0)
        {
                System.EventHandler val_16 = null;
            val_53 = val_16;
            val_16 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::一丌丌丄丆丏业丛丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_14.add_Clicked(丙业与丙丗丝不丈东:  val_16);
        }
        
        }
        
        if(this.clanIdCopy != 0)
        {
                Rilisoft.ButtonHandler val_18 = this.clanIdCopy.GetComponent<Rilisoft.ButtonHandler>();
            if(val_18 != 0)
        {
                System.EventHandler val_20 = null;
            val_53 = val_20;
            val_20 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::三丆东丁丁丒丝丌丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_18.add_Clicked(丙业与丙丗丝不丈东:  val_20);
        }
        
        }
        
        if(this.clanBack != 0)
        {
                Rilisoft.ButtonHandler val_22 = this.clanBack.GetComponent<Rilisoft.ButtonHandler>();
            if(val_22 != 0)
        {
                System.EventHandler val_24 = null;
            val_53 = val_24;
            val_24 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丛与丒上且丘丆且丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_22.add_Clicked(丙业与丙丗丝不丈东:  val_24);
        }
        
        }
        
        if(this.clanEdit != 0)
        {
                Rilisoft.ButtonHandler val_26 = this.clanEdit.GetComponent<Rilisoft.ButtonHandler>();
            if(val_26 != 0)
        {
                System.EventHandler val_28 = null;
            val_53 = val_28;
            val_28 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::不东丙不丟一上丝丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_26.add_Clicked(丙业与丙丗丝不丈东:  val_28);
        }
        
        }
        
        if(this.clanEditToClanName != 0)
        {
                Rilisoft.ButtonHandler val_30 = this.clanEditToClanName.GetComponent<Rilisoft.ButtonHandler>();
            if(val_30 != 0)
        {
                System.EventHandler val_32 = null;
            val_53 = val_32;
            val_32 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::不东丙不丟一上丝丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_30.add_Clicked(丙业与丙丗丝不丈东:  val_32);
        }
        
        }
        
        if(this.clanJoinRequest != 0)
        {
                Rilisoft.ButtonHandler val_34 = this.clanJoinRequest.GetComponent<Rilisoft.ButtonHandler>();
            if(val_34 != 0)
        {
                System.EventHandler val_36 = null;
            val_53 = val_36;
            val_36 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丌七丝三一七与丗不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_34.add_Clicked(丙业与丙丗丝不丈东:  val_36);
        }
        
        }
        
        if(this.clanInvite != 0)
        {
                Rilisoft.ButtonHandler val_38 = this.clanInvite.GetComponent<Rilisoft.ButtonHandler>();
            if(val_38 != 0)
        {
                System.EventHandler val_40 = null;
            val_53 = val_40;
            val_40 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丐七世不三丄丁与一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_38.add_Clicked(丙业与丙丗丝不丈东:  val_40);
        }
        
        }
        
        if(this.clanAddMoreUsers != 0)
        {
                Rilisoft.ButtonHandler val_42 = this.clanAddMoreUsers.GetComponent<Rilisoft.ButtonHandler>();
            if(val_42 != 0)
        {
                System.EventHandler val_44 = null;
            val_53 = val_44;
            val_44 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::与七丑三三丛丝丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_42.add_Clicked(丙业与丙丗丝不丈东:  val_44);
        }
        
        }
        
        if(this.clanVisitFort != 0)
        {
                Rilisoft.ButtonHandler val_46 = this.clanVisitFort.GetComponent<Rilisoft.ButtonHandler>();
            if(val_46 != 0)
        {
                System.EventHandler val_48 = null;
            val_53 = val_48;
            val_48 = new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::丐东丑万万丗丝一丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_46.add_Clicked(丙业与丙丗丝不丈东:  val_48);
        }
        
        }
        
        if(this.levelRequiredLable == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_50 = this.levelRequiredLable.GetComponent<Rilisoft.ButtonHandler>();
        if(val_50 == 0)
        {
                return;
        }
        
        val_50.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClansWindowInfoViewController::一东丟丟不丑丆丕三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丛丛丄下业丙东三业()
    {
        int val_98;
        var val_99;
        丞丂丘丒丟丞丑下丄 val_100;
        var val_101;
        bool val_102;
        var val_103;
        var val_104;
        UIButton val_105;
        int val_106;
        var val_107;
        UILabel val_108;
        int val_113;
        string val_114;
        val_98 = 1152921524404748272;
        if((Rilisoft.Singleton<ClansController>.Instance) == 0)
        {
                return;
        }
        
        val_99 = null;
        val_99 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(this.丝丘丕丅丙下丑业丙 == false)
        {
            goto label_9;
        }
        
        丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        val_100 = this.专丁丕丞丑丕丕丟下;
        this.专丁丕丞丑丕丕丟下 = val_5;
        if(val_5 != null)
        {
            goto label_11;
        }
        
        return;
        label_9:
        val_100 = this.专丁丕丞丑丕丕丟下;
        if(this.专丁丕丞丑丕丕丟下 == null)
        {
                return;
        }
        
        label_11:
        if(this.丝丘丕丅丙下丑业丙 == false)
        {
            goto label_14;
        }
        
        val_101 = null;
        val_101 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
            goto label_19;
        }
        
        val_102 = 1;
        goto label_21;
        label_14:
        val_102 = 0;
        goto label_21;
        label_19:
        val_103 = null;
        val_103 = null;
        val_102 = UnityEngine.Object.op_Inequality(x:  this.transform.parent, y:  transform);
        label_21:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.FindButton, 丏业丟一东丂东丘丛:  val_102);
        if(this.三世丑丒七与万丌丗 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.FindButton, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.joinConditionInfoGameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.joinConditionInfoLabel, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  this.专丁丕丞丑丕丕丟下.丘丗丏丁丂丑一丌丙()));
        this.joinConditionInfoSprite.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  this.专丁丕丞丑丕丕丟下.丘丗丏丁丂丑一丌丙());
        if((System.String.op_Equality(a:  mem[this.专丁丕丞丑丕丕丟下].丁丏丌丟丂丌一七与(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_42;
        }
        
        if(this.BankShopGUI != 0)
        {
                if(this.BankShopGUI.gameObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.BankShopGUI, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanAddMoreUsers, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsClanLider, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsSearch, 丏业丟一东丂东丘丛:  false);
        goto label_93;
        label_42:
        if(this.BankShopGUI != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.BankShopGUI, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsClanLider, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsSearch, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanJoin, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanLeave, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRequestSended, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanJoinRequest, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.levelRequiredLable, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_63;
        }
        
        if((System.String.op_Equality(a:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁(), b:  mem[this.专丁丕丞丑丕丕丟下].业丐丐三丕一丗丛丁())) == false)
        {
            goto label_93;
        }
        
        val_104 = null;
        val_105 = this.clanLeave;
        goto label_95;
        label_63:
        if(mem[this.专丁丕丞丑丕丕丟下].不业丙丒丂丞下丆丙() == 2)
        {
                if(mem[this.专丁丕丞丑丕丕丟下].丘丗丏丁丂丑一丌丙() <= 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与())
        {
            goto label_75;
        }
        
        }
        
        if((mem[this.专丁丕丞丑丕丕丟下].不业丙丒丂丞下丆丙() == 1) && (mem[this.专丁丕丞丑丕丕丟下].丘丗丏丁丂丑一丌丙() > 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()))
        {
                label_75:
            PGCompany.Clans.Network.不不业三丒与一万丄 val_36 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌();
            string val_95 = mem[this.专丁丕丞丑丕丕丟下].业丐丐三丕一丗丛丁();
            bool val_38 = val_36.业丑三丐丈世丄丛七.Contains(item:  val_95);
            val_95 = (~val_38) & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanJoinRequest, 丏业丟一东丂东丘丛:  val_95);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRequestSended, 丏业丟一东丂东丘丛:  val_38);
        }
        
        if((mem[this.专丁丕丞丑丕丕丟下].不业丙丒丂丞下丆丙() != 1) || (mem[this.专丁丕丞丑丕丕丟下].丘丗丏丁丂丑一丌丙() > 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()))
        {
            goto label_93;
        }
        
        val_104 = null;
        val_105 = this.clanJoin;
        label_95:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_105, 丏业丟一东丂东丘丛:  true);
        label_93:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanCapactyLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  this.专丁丕丞丑丕丕丟下.丁丈丕丆下丙丏业世(), arg1:  mem[this.专丁丕丞丑丕丕丟下] + 340));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.officersCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  this.专丁丕丞丑丕丕丟下.一一上丄一专世丕丈(), arg1:  mem[this.专丁丕丞丑丕丕丟下] + 344));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.clanName, 丕丗丘丑丛与丑业丒:  this.专丁丕丞丑丕丕丟下.东丙上东业丆不丟丘());
        this.丅丟丕丟一丄业丘丛();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanId, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4427")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4427")) + " " + mem[this.专丁丕丞丑丕丕丟下].业丐丐三丕一丗丛丁());
        int val_51 = this.专丁丕丞丑丕丕丟下.丛且丅丂不丟丆万丁();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanSiedges, 丕丗丘丑丛与丑业丒:  val_51.ToString());
        if((System.String.op_Inequality(a:  mem[this.专丁丕丞丑丕丕丟下].丆不与丕世丏三丅一(), b:  System.String.alignConst)) != false)
        {
                val_106 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4127")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4127")) + "[03CDFF]" + mem[this.专丁丕丞丑丕丕丟下].丆不与丕世丏三丅一() + "[-]"("[-]");
            val_107 = null;
        }
        else
        {
                val_107 = null;
            val_106 = System.String.alignConst;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanSlogan, 丕丗丘丑丛与丑业丒:  val_106);
        int val_58 = this.专丁丕丞丑丕丕丟下.丁丈丕丆下丙丏业世();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanUserCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_58, arg1:  mem[this.专丁丕丞丑丕丕丟下] + 340));
        if(mem[this.专丁丕丞丑丕丕丟下].不业丙丒丂丞下丆丙() == 2)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanType, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4117"));
            val_108 = this.clanType;
            UnityEngine.Color val_62 = UnityEngine.Color.red;
        }
        else
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanType, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4116"));
            val_108 = this.clanType;
            UnityEngine.Color val_64 = UnityEngine.Color.green;
        }
        
        val_108.color = new UnityEngine.Color() {r = val_64.r, g = val_64.g, b = val_64.b, a = val_64.a};
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanLiderName, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4126")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4126")) + "[fff32e]" + mem[this.专丁丕丞丑丕丕丟下].丐丒且世丑丘丒上丒() + "[-]"("[-]"));
        List.Enumerator<T> val_68 = this.clanLogos.GetEnumerator();
        label_142:
        if((2027460192 & 1) == 0)
        {
            goto label_139;
        }
        
        UnityEngine.Texture2D val_71 = mem[this.专丁丕丞丑丕丕丟下].世丐专丂世丄世丂丌();
        if(val_58.丐丏七丌丕丗业且上() != null)
        {
            goto label_142;
        }
        
        goto label_142;
        label_139:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        一一万丒与专丙丁丛 val_72 = mem[this.专丁丕丞丑丕丕丟下].世丝丌一且丝专丑丛();
        一一万丒与专丙丁丛 val_75 = val_72 >> 31;
        val_113 = 0;
        goto label_150;
        label_158:
        UILabel val_96 = this.divisionTitleLabel[val_51];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_96, 丏业丟一东丂东丘丛:  val_75 ^ 1);
        if((val_72 & 2147483648) == 0)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_96, 丕丗丘丑丛与丑业丒:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  mem[this.专丁丕丞丑丕丕丟下].世丝丌一且丝专丑丛()));
        }
        
        val_113 = val_51 + 1;
        label_150:
        if(val_113 < this.divisionTitleLabel.Length)
        {
            goto label_158;
        }
        
        int val_78 = mem[this.专丁丕丞丑丕丕丟下].三丑与丏丈丕七丙丂() + 1;
        val_98 = 0;
        goto label_160;
        label_168:
        UISprite val_97 = this.divisionShields[val_78];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_97, 丏业丟一东丂东丘丛:  val_75 ^ 1);
        if((val_72 & 2147483648) == 0)
        {
                丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  val_97, 万丑丞一丝丌丐丒丘:  System.String.Format(format:  "cup{0}_small", arg0:  val_78.ToString()));
        }
        
        val_98 = val_78 + 1;
        label_160:
        if(val_98 < this.divisionShields.Length)
        {
            goto label_168;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.valorPointsCountLabel, 丕丗丘丑丛与丑业丒:  this.专丁丕丞丑丕丕丟下.业不且丟丆下丏丌丒().ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.fortPowerLabel, 丕丗丘丑丛与丑业丒:  this.专丁丕丞丑丕丕丟下.上上三七丟丝与丆与());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.tankPowerLabel, 丕丗丘丑丛与丑业丒:  this.专丁丕丞丑丕丕丟下.三丒三丕不七丁丅丈());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.zoneCapturedCountLabel, 丕丗丘丑丛与丑业丒:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丙丏丌不丒一一丒上(丄丒下业一不丈丝丘:  this.专丁丕丞丑丕丕丟下.业丐丐三丕一丗丛丁()).Count.ToString());
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.专丁丕丞丑丕丕丟下.且丞东丑丟业丑丌万())) != false)
        {
                val_114 = PGCompany.不东丏三丞丞东丕丙.丘专下丄丂丑丞三东(上丏万丕丆七不与万:  mem[this.专丁丕丞丑丕丕丟下].且丞东丑丟业丑丌万());
        }
        else
        {
                val_114 = "–";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.continentLabel, 丕丗丘丑丛与丑业丒:  val_114);
        this.丁丟丙不丆三丐七一();
        this.UpdateMembersScroll();
        this.丞东丙丄丟专丆丑且();
    }
    private void 丁丟丙不丆三丐七一()
    {
        var val_14;
        if((this.丝丘丕丅丙下丑业丙 == false) || ((this.专丁丕丞丑丕丕丟下.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == 0))
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanPromoting, 丏业丟一东丂东丘丛:  this.专丁丕丞丑丕丕丟下.丗丅与三不万一丟丐());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.promoteClanButton, 丏业丟一东丂东丘丛:  (~this.专丁丕丞丑丕丕丟下.丗丅与三不万一丟丐()) & 1);
        if(this.promotionTimerLabel.cachedGameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
            goto label_13;
        }
        
        val_14 = this.专丁丕丞丑丕丕丟下.丑丟丛丂丂东不不上() - PixelTime.丝丗专上三不丄丑丑();
        goto label_17;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanPromoting, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.promoteClanButton, 丏业丟一东丂东丘丛:  false);
        return;
        label_13:
        val_14 = 0;
        label_17:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.promotionTimerLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  System.Math.Max(val1:  1, val2:  0), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
    }
    private void 丅丟丕丟一丄业丘丛()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanVisitFortLoadingCircle, 丏业丟一东丂东丘丛:  false);
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) == false)
        {
            goto label_3;
        }
        
        if(this.专丁丕丞丑丕丕丟下 == null)
        {
            goto typeof(UIButton).__il2cppRuntimeField_178;
        }
        
        goto typeof(UIButton).__il2cppRuntimeField_178;
        label_3:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelRequiredLable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.clans")));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.levelRequiredLable, 丏业丟一东丂东丘丛:  true);
        if(this.clanVisitFort != null)
        {
                return;
        }
    
    }
    private void 业丈丝下丌丂下丝丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        this.下世丕丂上与上上丌 = true;
        this._loadingCircule.SetActive(value:  true);
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丄专丑丝专万丌丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丐且丈丙丑丌三丈丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丁七七丙丒丌丛丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClansWindowInfoViewController::专世丌一丌丑万东与(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丄丆丑丝不不丒丘与().丞丌丝世丆业一东七(丄丒下业一不丈丝丘:  this.专丁丕丞丑丕丕丟下.业丐丐三丕一丗丛丁());
    }
    private void 丐且丈丙丑丌三丈丘()
    {
        var val_13;
        var val_14;
        var val_15;
        this.下世丕丂上与上上丌 = false;
        this._loadingCircule.SetActive(value:  false);
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丐且丈丙丑丌三丈丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClansWindowInfoViewController::专世丌一丌丑万东与(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        this.丛丛丄下业丙东三业();
        val_13 = null;
        val_13 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject.activeInHierarchy != true)
        {
                InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1440"), 世丙丁丗业丝世丕丈:  0, 不且丁丐不丌丟上丌:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌(), 不上丏上丝丆一丛丑:  0);
        }
        
        val_14 = null;
        val_14 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(LoadingNGUIController.丈丗丑丛下东丂丝丟() != false)
        {
                return;
        }
        
        this.CloseWindow();
    }
    private void 专世丌一丌丑万东与(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)
    {
        string val_9;
        var val_10;
        string val_11;
        val_9 = 一丐丗丁丞丆丅丟丄;
        this._loadingCircule.SetActive(value:  false);
        this.下世丕丂上与上上丌 = false;
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丐且丈丙丑丌三丈丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClansWindowInfoViewController::专世丌一丌丑万东与(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        val_10 = null;
        val_10 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if(丞丐丟三丌与丞上一 == 1710)
        {
            goto label_8;
        }
        
        if(丞丐丟三丌与丞上一 != 1702)
        {
            goto label_9;
        }
        
        val_11 = "Key_4361";
        goto label_12;
        label_8:
        val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5938");
        InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  val_9, 丂三丟丂丈丐丆丗丟:  ((System.Int32.TryParse(s:  val_9, result: out  0)) != true) ? 0f : 1200f);
        return;
        label_9:
        val_11 = "Key_1528";
        label_12:
        val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  val_9);
    }
    private void 一东丟丟不丑丆丕三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4348"));
    }
    private void 一丌丌丄丆丏业丛丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        ClansWindowInfoViewController.丝丞与丞不丝一丁丒 val_1 = new ClansWindowInfoViewController.丝丞与丞不丝一丁丒();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .一万丕丐丗丙丈丂丈 = 0;
        System.Action val_2 = new System.Action(object:  val_1, method:  System.Void ClansWindowInfoViewController.丝丞与丞不丝一丁丒::三丄丆专丘万丒丄丅());
        if(val_1 == null)
        {
            goto label_4;
        }
        
        .一万丕丐丗丙丈丂丈 = val_2;
        if(this.quitFromClan != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        this.quitFromClan.add_OnOkAction(丙业与丙丗丝不丈东:  val_2);
        UnityEngine.Debug.Log(message:  "LeaveClan");
        return;
        label_4:
        .一万丕丐丗丙丈丂丈 = val_2;
        if(this.quitFromClan != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    private void 三下丆且丟丛下丁东()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        LobbySeasonController val_31;
        var val_32;
        if(this.quitFromClan != 0)
        {
                if(this.quitFromClan.gameObject.activeInHierarchy != false)
        {
                this.quitFromClan.CloseWindow();
        }
        
        }
        
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.丄与三丕丁丏万万丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::且丏丟丕丐世丈丝丞()));
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.丐丂不一丁与丐与且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::三下丆且丟丛下丁东()));
        val_23 = null;
        val_23 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 == 0)
        {
            goto label_12;
        }
        
        val_24 = null;
        val_24 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy == true)
        {
            goto label_17;
        }
        
        label_12:
        val_25 = null;
        val_25 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_37;
        }
        
        val_26 = null;
        val_26 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.gameObject.activeInHierarchy == false)
        {
            goto label_37;
        }
        
        label_17:
        this.CloseWindow();
        val_27 = null;
        val_27 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
                val_28 = null;
            val_28 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy != false)
        {
                val_29 = null;
            val_29 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.OnBackButtonClick();
        }
        
        }
        
        label_37:
        val_30 = null;
        val_30 = null;
        val_31 = LobbySeasonController.instance;
        if(val_31 == 0)
        {
                return;
        }
        
        val_31 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_31 == 0)
        {
                return;
        }
        
        val_31 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_31.下丟丈不一上万不业() == false)
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业());
    }
    private void 且丏丟丕丐世丈丝丞()
    {
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.丄与三丕丁丏万万丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::且丏丟丕丐世丈丝丞()));
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.丐丂不一丁与丐与且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::三下丆且丟丛下丁东()));
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"));
        this.quitFromClan.CloseWindow();
    }
    private void 丐七世不三丄丁与一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        UnityEngine.GameObject val_7;
        ClansWindowInfoViewController.与且世丛丗丞三丞且 val_1 = new ClansWindowInfoViewController.与且世丛丗丞三丞且();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .丞丒业万东专上丒丛 = 0;
        System.Action val_2 = new System.Action(object:  val_1, method:  System.Void ClansWindowInfoViewController.与且世丛丗丞三丞且::丈丐丁专业不万丟丁());
        if(val_1 != null)
        {
                .丞丒业万东专上丒丛 = val_2;
            val_7 = this.gameObject;
        }
        else
        {
                .丞丒业万东专上丒丛 = val_2;
            val_7 = this.gameObject;
        }
        
        int val_5 = ClansInviteGuiController.丅万万不专上丟丑丙(丈东丘丏与丌东东下:  val_7, 丟不丒万丝与丂上丘:  (ClansWindowInfoViewController.与且世丛丗丞三丞且)[1152921536701477536].丞丒业万东专上丒丛, 丂丛丑东不丅丈一东:  3);
        this.gameObject.SetActive(value:  false);
    }
    private void 丌七丝三一七与丗不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        .丝且与丝丒丟万丁专 = this;
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        .丞七丗业三三一丒丄 = 0;
        System.Action val_2 = new System.Action(object:  new ClansWindowInfoViewController.丟丐丟丝丝不丈下丒(), method:  System.Void ClansWindowInfoViewController.丟丐丟丝丝不丈下丒::丟丟业三丈丞丕东丆());
        .丞七丗业三三一丒丄 = val_2;
        this.requestToJoinClan.add_OnOkAction(丙业与丙丗丝不丈东:  val_2);
    }
    private void 东下与丑丞丞丐三丁()
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::东下与丑丞丞丐三丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClansWindowInfoViewController::丙万丁丒东丅丌丙丄(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        this.requestToJoinClan.CloseWindow();
    }
    private void 丙万丁丒东丅丌丙丄(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::东下与丑丞丞丐三丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClansWindowInfoViewController::丙万丁丒东丅丌丙丄(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        this.requestToJoinClan.CloseWindow();
        if(丂七东不不丈一丐不 != 1740)
        {
                if(丂七东不不丈一丐不 != 1710)
        {
                return;
        }
        
            InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5938"), 丂三丟丂丈丐丆丗丟:  (float)丂三丟丂丈丐丆丗丟);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanJoinRequest, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRequestSended, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11139"));
    }
    private void 三丆东丁丁丒丝丌丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        if(this.专丁丕丞丑丕丕丟下 == null)
        {
                return;
        }
        
        丗丏丑世丌丝丝上下.丒下一丟丝丕丈不一(丕丗丘丑丛与丑业丒:  this.专丁丕丞丑丕丕丟下.业丐丐三丕一丗丛丁());
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1618"));
    }
    private void 丛与丒上且丘丆且丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.CloseWindow();
    }
    private void 丙丗丐世世丑与丙丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        this.deleteClan.add_OnOkAction(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丈丌丗一丑丂三丏丄()));
    }
    public void OnEditClicked()
    {
        this.不东丙不丟一上丝丛(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 不东丙不丟一上丝丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        UnityEngine.Debug.Log(message:  "Edit Clan");
        if((System.String.op_Equality(a:  this.专丁丕丞丑丕丕丟下.丁丏丌丟丂丌一七与(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        ClanCreateGui.丌万丗与七丄丕不丁(丂丛丑东不丅丈一东:  1, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丑不丟丕下丁丘丆丑()), 不丘丘丝丅丁且丞丝:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丑丙丄东丈三一万丅()));
    }
    private void 与七丑三三丛丝丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        this.ExtendClan.add_OnOkAction(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::不丂丐丑丐丂丙与世()));
        UnityEngine.Debug.Log(message:  "ClanADDUSERS");
    }
    public void HandleRolesInfobuttonClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.下世丕丂上与上上丌 != false)
        {
                return;
        }
        
        Rilisoft.ClanRolesAddedWindow.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this.transform);
    }
    private void 丐东丑万万丗丝一丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        string val_15;
        IntPtr val_16;
        if(this.下世丕丂上与上上丌 != false)
        {
                InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"));
            val_11 = null;
            val_11 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.fortOpen = false;
            return;
        }
        
        val_12 = static_value_081DACA8;
        val_12 = static_value_081DACA8;
        mem2[0] = 0;
        val_13 = null;
        val_13 = null;
        MainMenuController.丆不丑丆下丞丙不丞 = false;
        if(this.丝丘丕丅丙下丑业丙 != false)
        {
                val_14 = null;
            val_14 = null;
            Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一与专不下丝丌丈东);
            val_15 = 1152921504615739392;
            ClansController.东丏丘丞上丅丟丙不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::世下丏丝丁丕丛丛丆()));
            System.Action val_4 = null;
            val_16 = System.Void ClansWindowInfoViewController::世下丏丝丁丕丛丛丆();
            val_4 = new System.Action(object:  this, method:  val_16);
            ClansController.丕丅丟丘丝不下丑丆(丙业与丙丗丝不丈东:  val_4);
        }
        else
        {
                PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丛上上丙且丏丞丙丛()));
            PGCompany.Clans.Network.丞丝世上丏与丂丒上.丏一与丏丛丘丆丅丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丛上上丙且丏丞丙丛()));
            val_15 = this.专丁丕丞丑丕丕丟下.业丐丐三丕一丗丛丁();
            System.Collections.Generic.List<System.String> val_10 = new System.Collections.Generic.List<System.String>();
            if(val_10 != null)
        {
                val_10.Add(item:  "fl");
        }
        else
        {
                val_10.Add(item:  "fl");
        }
        
            val_10.Add(item:  "fd");
            val_10.Add(item:  "tn");
            val_16 = val_10;
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑().丛丐不丐丘丘万丒丂(丄丒下业一不丈丝丘:  val_15, 丟丐丟丂下专丅业丒:  val_10);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanVisitFortLoadingCircle, 丏业丟一东丂东丘丛:  true);
    }
    private void 丏丅上丘丌丐丞丄丑()
    {
        var val_11;
        var val_12;
        var val_13;
        ClansWindowGUI val_14;
        var val_15;
        var val_16;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanVisitFortLoadingCircle, 丏业丟一东丂东丘丛:  false);
        this.下世丕丂上与上上丌 = true;
        val_11 = 1152921505152585728;
        val_12 = null;
        val_12 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.fortOpen = true;
        if(this.专丁丕丞丑丕丕丟下.丟与且丙七丙丞下丏() != null)
        {
                if(this.专丁丕丞丑丕丕丟下.丟与且丙七丙丞下丏().Count >= 1)
        {
                ClansVisitController val_4 = Rilisoft.Singleton<ClansVisitController>.Instance;
            val_11 = 1152921505152532480;
            ClansVisitController.不丁丕七业万七丏丈 = true;
            ClansVisitController val_5 = Rilisoft.Singleton<ClansVisitController>.Instance;
            ClansVisitController.丐丗丕丞丅且丁与业 = this.专丁丕丞丑丕丕丟下;
            Rilisoft.Singleton<ClansVisitController>.Instance.UpdateClanData();
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "FortFieldBuild");
            val_13 = null;
            val_13 = null;
            val_14 = MainMenuController.丄丞丁丈与业上丞丟.gameObject;
            if(val_14.activeSelf == true)
        {
                return;
        }
        
            val_15 = null;
            val_15 = null;
            MainMenuController.丄丞丁丈与业上丞丟.gameObject.SetActive(value:  true);
            return;
        }
        
        }
        
        this.下世丕丂上与上上丌 = false;
        val_16 = null;
        val_16 = null;
        val_14 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.fortOpen = false;
    }
    private void 世下丏丝丁丕丛丛丆()
    {
        ClansController.东丏丘丞上丅丟丙不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::世下丏丝丁丕丛丛丆()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanVisitFortLoadingCircle, 丏业丟一东丂东丘丛:  false);
        this.丏丅上丘丌丐丞丄丑();
    }
    private void 丛上上丙且丏丞丙丛()
    {
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丛上上丙且丏丞丙丛()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanVisitFortLoadingCircle, 丏业丟一东丂东丘丛:  false);
        this.丏丅上丘丌丐丞丄丑();
    }
    public void CloseWindow()
    {
        if(this.下世丕丂上与上上丌 == true)
        {
                return;
        }
        
        if(this.丄丑上丕丂丈丘丙七 != null)
        {
                this.丄丑上丕丂丈丘丙七.Invoke();
        }
        
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    internal static UnityEngine.Texture2D 不上丏丑丅上三丟丟(string 丁且专丑万万丘丟七)
    {
        string val_5;
        UnityEngine.Texture2D val_6;
        var val_7;
        val_5 = 丁且专丑万万丘丟七;
        val_6 = 0;
        if((System.String.IsNullOrEmpty(value:  val_5)) == true)
        {
                return val_6;
        }
        
        val_5 = System.Convert.FromBase64String(s:  val_5);
        val_7 = null;
        val_7 = null;
        val_6 = new UnityEngine.Texture2D();
        val_6 = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不, textureFormat:  5, mipChain:  false);
        new UnityEngine.Texture2D().filterMode = 0;
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  val_5, markNonReadable:  true);
        return val_6;
    }
    private void 下一丈与丕丘丞丙丒()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        LobbySeasonController val_20;
        var val_21;
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.丐丆丄业丒不丆且丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::下一丈与丕丘丞丙丒()));
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.丏与一东丈世一七东(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClansWindowInfoViewController::丐上专丆且且不上专(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)));
        this.CloseWindow();
        val_14 = null;
        val_14 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
                val_15 = null;
            val_15 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy != false)
        {
                val_16 = null;
            val_16 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.isSeeLobbyEnable != false)
        {
                val_17 = null;
            val_17 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.HandleBackSeeLobby();
        }
        
            val_18 = null;
            val_18 = null;
            FriendProfileView.丐丕丝上丅丈丐丞专.OnBackButtonClick();
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = LobbySeasonController.instance;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_20.下丟丈不一上万不业() == false)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业());
    }
    private void 丐上专丆且且不上专(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)
    {
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"));
        this.deleteClan.CloseWindow();
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.丐丆丄业丒不丆且丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::下一丈与丕丘丞丙丒()));
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.丏与一东丈世一七东(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClansWindowInfoViewController::丐上专丆且且不上专(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)));
    }
    private void 不丂丐丑丐丂丙与世()
    {
        this.丛丛丄下业丙东三业();
        this.ExtendClan.remove_OnOkAction(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::不丂丐丑丐丂丙与世()));
        if(this.专丁丕丞丑丕丕丟下 != null)
        {
                UnityEngine.Texture2D val_2 = this.专丁丕丞丑丕丕丟下.世丐专丂世丄世丂丌();
        }
        
        InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4257"), 世丙丁丗业丝世丕丈:  0, 不且丁丐不丌丟上丌:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌(), 不上丏上丝丆一丛丑:  0);
    }
    private void 丂七下丂丂七丈万不()
    {
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::丂七下丂丂七丈万不()));
        this.丄丑上丕丂丈丘丙七 = 0;
        this.CloseWindow();
    }
    public void U_Search()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.findButtonSound);
        }
        
        .丟不丒万丝与丂上丘 = this.丄丑上丕丂丈丘丙七;
        .丈东丘丏与丌东东下 = this.transform.parent.gameObject;
        .且丟丅丄丒丑丂丁世 = this.专丁丕丞丑丕丕丟下;
        ClanSearchGui.丌万丗与七丄丕不丁(丐丅丒专丛丏上与业:  0, 丛丝与丂世丌丌丝丂:  new System.Action(object:  new ClansWindowInfoViewController.丗丟且丘丙三丏且专(), method:  System.Void ClansWindowInfoViewController.丗丟且丘丙三丏且专::世且不丕业丅丕专丛()));
        this.gameObject.SetActive(value:  false);
    }
    private void 丘上丐世丆丑且丞丒()
    {
        UIScrollView val_10;
        UIWrapContent val_1 = this._membersGrid.GetComponent<UIWrapContent>();
        val_1.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClansWindowInfoViewController::丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        UIDragScrollView val_3 = this.lobbyMemberViewPrefab.GetComponent<UIDragScrollView>();
        val_10 = this._membersScroll.GetComponent<UIScrollView>();
        val_3.scrollView = val_10;
        if(this.membersItemsWrapCount >= 1)
        {
                object val_10 = 0;
            do
        {
            val_10 = "MemberView_" + val_10;
            不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this._membersGrid.gameObject, 丑且不丕与专丄业丙:  this.lobbyMemberViewPrefab.gameObject).name = val_10;
            val_10 = val_10 + 1;
        }
        while(val_10 < this.membersItemsWrapCount);
        
        }
        
        UIScrollView val_9 = this._membersScroll.GetComponent<UIScrollView>();
        val_9.disableDragIfFits = true;
        this.丂丘丟丘一七上万丞 = true;
    }
    private void 丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        ClansInfoMemberView val_1 = 丝三丁东丈丒世丅业.GetComponent<ClansInfoMemberView>();
        val_1.wrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        this.UpdateItemInfo(下丅丙一丂丗丅丝七:  丝三丁东丈丒世丅业.GetComponent<ClansInfoMemberView>());
    }
    public void UpdateItemInfo(ClansInfoMemberView 下丅丙一丂丗丅丝七)
    {
        丞丂丘丒丟丞丑下丄 val_36;
        bool val_37;
        val_36 = this.专丁丕丞丑丕丕丟下;
        if(val_36 == null)
        {
                return;
        }
        
        if((下丅丙一丂丗丅丝七.wrapIndex & 2147483648) != 0)
        {
            goto label_5;
        }
        
        val_36 = val_36.丐丂丄丏下七与一丌();
        if(下丅丙一丂丗丅丝七.wrapIndex >= val_36.Count)
        {
            goto label_5;
        }
        
        .丞丅上丏丂且下丅与 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].业丐丐三丕一丗丛丁();
        .丄丒下业一不丈丝丘 = this.专丁丕丞丑丕丕丟下.业丐丐三丕一丗丛丁();
        .不业丑丂丝业丞专丈 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].三七丆丑丙丆丘丛丆();
        .专世专丟丝丌与丘上 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].丙东专丂世丈丏丁丂();
        .丁七万丟丆丟不万丗 = System.String.op_Equality(a:  this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].业丐丐三丕一丗丛丁(), b:  this.专丁丕丞丑丕丕丟下.丁丏丌丟丂丌一七与());
        .丒丘丏上丙丟丑丕丈 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].东丙上东业丆不丟丘();
        if((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  (与丛丕丝丑丁与丐丝)[1152921536705489168].丞丅上丏丂且下丅与)) == false)
        {
            goto label_24;
        }
        
        val_37 = 1;
        goto label_25;
        label_5:
        下丅丙一丂丗丅丝七.UpdateView(丕丝丄三丂三与丑世:  0);
        下丅丙一丂丗丅丝七.gameObject.SetActive(value:  false);
        return;
        label_24:
        val_37 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().ContainsKey(key:  (与丛丕丝丑丁与丐丝)[1152921536705489168].丞丅上丏丂且下丅与);
        label_25:
        .丘三三东且丈丅丈丛 = val_37;
        .丕万丐东与一丈万与 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].丙丐丅丕丗丁丅丁丐();
        .丅丄与专下丅丄丝东 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Item[下丅丙一丂丗丅丝七.wrapIndex].与丘且丟不丅丏万丆();
        下丅丙一丂丗丅丝七.UpdateView(丕丝丄三丂三与丑世:  new 与丛丕丝丑丁与丐丝());
    }
    public void UpdateMembersScroll()
    {
        var val_7;
        var val_15;
        var val_16;
        if(this.专丁丕丞丑丕丕丟下 == null)
        {
                return;
        }
        
        if(this.丂丘丟丘一七上万丞 != true)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        int val_3 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().Count;
        if((this._membersGrid.GetComponent<UIWrapContent>()) != null)
        {
                int val_14 = 1;
            val_14 = val_14 - val_3;
            val_1.minIndex = val_14;
        }
        else
        {
                int val_15 = 1;
            val_15 = val_15 - val_3;
            mem[32] = val_15;
        }
        
        List.Enumerator<T> val_5 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌().GetEnumerator();
        val_15 = 1152921536540174048;
        label_12:
        if((2034165328 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  this.专丁丕丞丑丕丕丟下.丁丏丌丟丂丌一七与(), b:  val_8.业丐丐三丕一丗丛丁())) == false)
        {
            goto label_12;
        }
        
        val_8.丝丟丝三丛专丕世丗(丙业与丙丗丝不丈东:  true);
        goto label_12;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<七丈丗不丞丈丝丙七> val_12 = this.专丁丕丞丑丕丕丟下.丐丂丄丏下七与一丌();
        val_12.丙丟丙丆丐东丙专丑(丝丘丑业丛万丞丌丝:  val_12);
        val_16 = 0;
        goto label_21;
        label_24:
        val_15 = 0;
        this.UpdateItemInfo(下丅丙一丂丗丅丝七:  this._membersGrid.GetComponentsInChildren<ClansInfoMemberView>(includeInactive:  true)[val_15]);
        val_16 = 1;
        label_21:
        if(val_16 < val_13.Length)
        {
            goto label_24;
        }
        
        this.丞丅丝专上东丗万丆(且丟丅丄丒丑丂丁世:  this.专丁丕丞丑丕丕丟下);
    }
    private void 丞丅丝专上东丗万丆(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
    {
        var val_8;
        System.Func<七丈丗不丞丈丝丙七, System.String> val_10;
        var val_11;
        val_8 = null;
        val_8 = null;
        val_10 = ClansWindowInfoViewController.<>c.<>9__116_0;
        if(val_10 == null)
        {
                System.Func<七丈丗不丞丈丝丙七, System.String> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<七丈丗不丞丈丝丙七, System.String>(object:  ClansWindowInfoViewController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ClansWindowInfoViewController.<>c::七专丆丁不丁世丁业(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
            ClansWindowInfoViewController.<>c.<>9__116_0 = val_10;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<七丈丗不丞丈丝丙七, System.String>(source:  且丟丅丄丒丑丂丁世.丐丂丄丏下七与一丌(), selector:  val_2);
        System.Collections.Generic.HashSet<System.String> val_4 = null;
        val_11 = val_4;
        val_4 = new System.Collections.Generic.HashSet<System.String>(collection:  val_3);
        if(val_11 != null)
        {
                val_4.SymmetricExceptWith(other:  this.东丛三下世且丗丘业);
        }
        else
        {
                val_4.SymmetricExceptWith(other:  this.东丛三下世且丗丘业);
        }
        
        if(val_4.Count >= 1)
        {
                UIWrapContent val_6 = this._membersGrid.GetComponent<UIWrapContent>();
            val_11 = this._membersScroll.GetComponent<UIScrollView>();
            val_11.ResetPosition();
        }
        
        this.东丛三下世且丗丘业.UnionWith(other:  val_3);
    }
    private void 丙丟丙丆丐东丙专丑(System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丝丘丑业丛万丞丌丝)
    {
        var val_13;
        var val_14;
        var val_15;
        七丈丗不丞丈丝丙七 val_16;
        var val_17;
        七丈丗不丞丈丝丙七 val_18;
        System.Func<七丈丗不丞丈丝丙七, System.Int32> val_20;
        七丈丗不丞丈丝丙七 val_21;
        val_13 = 1152921536523276176;
        val_14 = 0;
        goto label_1;
        label_16:
        val_15 = 1;
        goto label_2;
        label_14:
        if(丝丘丑业丛万丞丌丝 != null)
        {
                val_16 = 丝丘丑业丛万丞丌丝.Item[W21];
        }
        else
        {
                val_16 = 丝丘丑业丛万丞丌丝.Item[W21];
        }
        
        val_17 = null;
        val_18 = 丝丘丑业丛万丞丌丝.Item[1];
        val_17 = null;
        val_20 = ClansWindowInfoViewController.<>c.<>9__117_0;
        if(val_20 == null)
        {
                System.Func<七丈丗不丞丈丝丙七, System.Int32> val_4 = null;
            val_20 = val_4;
            val_4 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClansWindowInfoViewController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClansWindowInfoViewController.<>c::丙丆世专下丒三上丑(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
            ClansWindowInfoViewController.<>c.<>9__117_0 = val_20;
            val_13 = 1152921536523276176;
        }
        
        if((Rilisoft.ClansLobbyGui.下丄丆下丁丝丘丏丒(丈丂丕下丏丈丞丗业:  val_16, 丂丌丌丛丆丆丙丌丈:  val_18, 丂与万东一三丆下业:  val_4)) > 0)
        {
                if(丝丘丑业丛万丞丌丝 != null)
        {
                val_21 = 丝丘丑业丛万丞丌丝.Item[1];
            丝丘丑业丛万丞丌丝.set_Item(index:  1, value:  丝丘丑业丛万丞丌丝.Item[W21]);
        }
        else
        {
                val_21 = 丝丘丑业丛万丞丌丝.Item[1];
            val_18 = 丝丘丑业丛万丞丌丝.Item[W21];
            丝丘丑业丛万丞丌丝.set_Item(index:  1, value:  val_18);
        }
        
            丝丘丑业丛万丞丌丝.set_Item(index:  W21, value:  val_21);
        }
        
        val_15 = 2;
        label_2:
        if((val_15 - 1) < (丝丘丑业丛万丞丌丝.Count - 1))
        {
            goto label_14;
        }
        
        val_14 = 1;
        label_1:
        if(val_14 < 丝丘丑业丛万丞丌丝.Count)
        {
            goto label_16;
        }
    
    }
    public void U_Promote()
    {
        if(this.丝丘丕丅丙下丑业丙 != false)
        {
                if(this.专丁丕丞丑丕丕丟下.丗丅与三不万一丟丐() != false)
        {
                this.丁丟丙不丆三丐七一();
            return;
        }
        
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  88, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void Update()
    {
        this.丁丟丙不丆三丐七一();
    }
    public void U_PromotingClick()
    {
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  89, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public ClansWindowInfoViewController()
    {
        this.membersItemsWrapCount = 8;
        this.东丛三下世且丗丘业 = new System.Collections.Generic.HashSet<System.String>();
    }
    private void 丈丌丗一丑丂三丏丄()
    {
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.与丈丏不丘专丙丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansWindowInfoViewController::下一丈与丕丘丞丙丒()));
        PGCompany.Clans.Network.丘且丂世丆东丂不丘.丝丗丞万且丐丟丘丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClansWindowInfoViewController::丐上专丆且且不上专(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)));
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丗丞丘丛丒丟不丙丟().丈三丅丐丆与业丄丞(丄丒下业一不丈丝丘:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
    }
    private void 丑不丟丕下丁丘丆丑()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    private void 丑丙丄东丈三一万丅()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丛丛丄下业丙东三业();
    }

}
