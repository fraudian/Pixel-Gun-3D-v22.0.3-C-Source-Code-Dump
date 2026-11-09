using UnityEngine;
public class ClansInviteGuiController : MonoBehaviour
{
    // Fields
    internal static ClansInviteGuiController 丆丕丝丒不丙且丐丗;
    private ClansInviteGuiController.不丑丙丒专丟丕丘丙 _currentMode;
    private static bool 丄不丆丂三丗七东与;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private System.IDisposable 与丈丘下一七丒东丁;
    private bool 丕丘丐丙丌丆与且不;
    private System.Collections.Generic.List<string> 丛丌丌丒丌丕丅丅万;
    private readonly System.Collections.Generic.List<string> 万下万且不东上丅业;
    private readonly System.Collections.Generic.List<ClansInviteGuiController.丗丐丅丂不不丁三丙> 丙丙丐不丅丟丏丈丗;
    public Rilisoft.ButtonHandler backBtn;
    public int minCellCountForDisableScroll;
    private MyUIInput findFriendInput;
    private System.Collections.Generic.List<ClansInviteGuiController.万丕上东丅与丙丏丕> friendsList;
    private ClansInfoInviteContainer infoItem;
    private UnityEngine.GameObject loading;
    private UIScrollView friendsScroll;
    private UIWrapContent friendsWrap;
    private System.Collections.Generic.List<UIToggle> friendsToggle;
    private UnityEngine.GameObject requestsTabContainer;
    private DynamicWrapGrid requestsWrapGrid;
    private System.Collections.Generic.List<UIToggle> requestsToggle;
    private UILabel requestsCount;
    private UIButton rejectAllButton;
    private UnityEngine.GameObject giftsContainer;
    private DynamicWrapGrid giftsWrapGrid;
    private System.Collections.Generic.List<UIToggle> giftsToggle;
    private UnityEngine.GameObject giftsDescription;
    private UnityEngine.GameObject searchContainer;
    private System.Collections.Generic.List<UIToggle> searchToggle;
    private UnityEngine.GameObject threeTabs;
    private UnityEngine.GameObject fourTabs;
    private bool <丙丑与三专专丁丂丂>k__BackingField;
    private System.Action 丄丑上丕丂丈丘丙七;
    
    // Properties
    public bool 丛丄丘东丌丈丛丌丏 { get; set; }
    
    // Methods
    public void set_IsFindFriendByIdStateActivate(bool 丙业与丙丗丝不丈东)
    {
        this.<丙丑与三专专丁丂丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_IsFindFriendByIdStateActivate()
    {
        return (bool)this.<丙丑与三专专丁丂丂>k__BackingField;
    }
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
    internal static int 丅万万不专上丟丑丙(UnityEngine.GameObject 丈东丘丏与丌东东下, System.Action 丟不丒万丝与丂上丘, ClansInviteGuiController.不丑丙丒专丟丕丘丙 丂丛丑东不丅丈一东)
    {
        UnityEngine.Object val_30;
        var val_31;
        System.Object[] val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_40;
        val_30 = 丈东丘丏与丌东东下;
        if((丟不丒万丝与丂上丘 == null) || (val_30 == 0))
        {
            goto label_4;
        }
        
        val_31 = null;
        val_31 = null;
        if(ClansInviteGuiController.丆丕丝丒不丙且丐丗 != 0)
        {
            goto label_9;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Clan/ClanInviteGui");
        if(val_3 != 0)
        {
            goto label_12;
        }
        
        val_32 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "prefab not found ClanInviteGui", args:  val_32);
        val_33 = 0;
        return (int)val_33;
        label_9:
        val_34 = null;
        val_34 = null;
        UnityEngine.Transform val_6 = ClansInviteGuiController.丆丕丝丒不丙且丐丗.transform;
        val_6.SetParent(p:  val_30.transform.parent);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_6.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_6.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        UnityEngine.GameObject val_11 = ClansInviteGuiController.丆丕丝丒不丙且丐丗.gameObject;
        if(val_30 != null)
        {
            goto label_84;
        }
        
        label_85:
        label_84:
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_11, 不东丛三丂丌丑专丆:  val_30.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
        if((Rilisoft.Singleton<NotificationMessageController>.Instance) != 0)
        {
                Rilisoft.Singleton<NotificationMessageController>.Instance.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  3, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = false, isViewd = false});
        }
        
        val_35 = null;
        val_35 = null;
        val_30 = ClansInviteGuiController.丆丕丝丒不丙且丐丗;
        val_30.add_OnClose(丙业与丙丗丝不丈东:  丟不丒万丝与丂上丘);
        ClansInviteGuiController.丆丕丝丒不丙且丐丗._currentMode = 丂丛丑东不丅丈一东;
        丞丂丘丒丟丞丑下丄 val_17 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_17 != null)
        {
                val_36 = val_17.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        }
        else
        {
                val_36 = 0;
        }
        
        val_37 = null;
        val_37 = null;
        val_36 = val_36 - 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ClansInviteGuiController.丆丕丝丒不丙且丐丗.fourTabs, 丏业丟一东丂东丘丛:  (val_36 < 2) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ClansInviteGuiController.丆丕丝丒不丙且丐丗.threeTabs, 丏业丟一东丂东丘丛:  (val_36 > 1) ? 1 : 0);
        label_4:
        val_38 = null;
        val_38 = null;
        if(ClansInviteGuiController.丆丕丝丒不丙且丐丗._currentMode > 4)
        {
            goto label_50;
        }
        
        var val_30 = mem[4611686020712113800];
        val_30 = val_30 + 106030728;
        goto (mem[4611686020712113800] + 106030728);
        label_50:
        val_40 = null;
        val_40 = null;
        val_32 = ClansInviteGuiController.丆丕丝丒不丙且丐丗;
        val_32.OnRequestClick();
        val_33 = 0;
        return (int)val_33;
        label_12:
        UnityEngine.Transform val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_3).transform;
        val_24.SetParent(p:  val_30.transform.parent.transform);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        val_24.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
        val_24.localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
        if(val_30 != null)
        {
            goto label_84;
        }
        
        goto label_85;
    }
    private void Awake()
    {
        null = null;
        ClansInviteGuiController.丆丕丝丒不丙且丐丗 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.infoItem, 丏业丟一东丂东丘丛:  false);
        this.丑三且专丙丄丕丏丙();
    }
    private void Start()
    {
        if(this.backBtn == 0)
        {
                return;
        }
        
        this.backBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClansInviteGuiController::丂丏丁与丑丌丞专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnEnable()
    {
        System.Action val_16;
        object val_17;
        val_16 = 1152921504615739392;
        FriendsController.业丐丙丅丒丝丈丕丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::七丙三丞丝三且不丘()));
        丌且下丛三丟三业丑.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::七丙三丞丝三且不丘()));
        FriendsController.业丐丙丅丒丝丈丕丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::丞业丝专丌东丙丐且()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丁且且丐丈丒丅世不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::丞业丝专丌东丙丐且()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丂三世万丁丁丂丕丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClansInviteGuiController::丝一丐丛丂丈丅东丟(int 万且万且丑丗且丌丆)));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::且七丐丟丅不丄丙丗()));
        PGCompany.GiftSystem.业三东上与丁丁专三.与丕丅丌东丁丕丄丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::下丟丂东世上三世世()));
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                System.Action val_9 = null;
            val_16 = val_9;
            val_9 = new System.Action(object:  this, method:  public System.Void ClansInviteGuiController::BackBtn());
            this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_9, 与且专丈不万东一万:  "ClanInvite");
        }
        
        this.七丙三丞丝三且不丘();
        丞丂丘丒丟丞丑下丄 val_12 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_12 != null)
        {
                val_16 = val_12.上丟下丌丞业丞专丄();
            int val_14 = val_16.Count;
            val_17 = 0;
        }
        else
        {
                val_17 = 0;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.requestsCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/100", arg0:  val_17));
    }
    private void OnDisable()
    {
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::七丙三丞丝三且不丘()));
        丌且下丛三丟三业丑.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::七丙三丞丝三且不丘()));
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::丞业丝专丌东丙丐且()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丑丂与东丘丄一丗下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::丞业丝专丌东丙丐且()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丗丟不专丞丄丄业丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClansInviteGuiController::丝一丐丛丂丈丅东丟(int 万且万且丑丗且丌丆)));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::且七丐丟丅不丄丙丗()));
        PGCompany.GiftSystem.业三东上与丁丁专三.丑丘与一丑丏业与且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::下丟丂东世上三世世()));
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    private void 丈丑丟丒七三丝丝且()
    {
        var val_9;
        System.Collections.Generic.List<System.String> val_47;
        var val_48;
        var val_50;
        System.Func<丅下丙一东丄丕丛下, System.String> val_52;
        var val_53;
        System.Func<丗丐丅丂不不丁三丙, System.Int32> val_55;
        var val_56;
        System.Func<丗丐丅丂不不丁三丙, System.Int32> val_58;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄()) == null)
        {
                return;
        }
        
        bool val_47 = this.丕丘丐丙丌丆与且不;
        val_47 = val_47 + 3;
        var val_48 = ~val_47;
        val_48 = val_48 & 3;
        if(val_48 != 0)
        {
                return;
        }
        
        this.丕丘丐丙丌丆与且不 = true;
        this.丙丙丐不丅丟丏丈丗.Clear();
        this.万下万且不东上丅业.Clear();
        List.Enumerator<T> val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄().GetEnumerator();
        val_47 = 0;
        goto label_31;
        label_33:
        string val_10 = val_9.丐丏七丌丕丗业且上();
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().三丐丁一且一丏三丞(丄丒且丙三丆丟与丏:  val_10.丒且丟下东丘丆丄丕())) == null)
        {
            goto label_13;
        }
        
        new ClansInviteGuiController.丗丐丅丂不不丁三丙() = new System.Object();
        .<上上丈万丄上丂下丞>k__BackingField = val_10.丒且丟下东丘丆丄丕();
        .<且丗丛一丕一丙专世>k__BackingField = val_10.与丐三丗一下丕七万();
        .<丒丒丏一下业丁丌丗>k__BackingField = 丂与专万与丐丌丏不.丑七不且上丗丁一世().七丙丞且世七丙丐下(丄丒且丙三丆丟与丏:  val_10.丒且丟下东丘丆丄丕());
        .<丗不一专丑万东丐不>k__BackingField = 丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  val_10.丒且丟下东丘丆丄丕());
        .<丁丂丆业丅丁丙丈丟>k__BackingField = 丂与专万与丐丌丏不.丑七不且上丗丁一世().七丛丂丟丐三下丝丏(丄丒且丙三丆丟与丏:  val_10.丒且丟下东丘丆丄丕());
        .<且三丂丏专上丅丑万>k__BackingField = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丛丁丝下丌丝且东世(丄丒且丙三丆丟与丏:  val_10.丒且丟下东丘丆丄丕());
        this.丙丙丐不丅丟丏丈丗.Add(item:  new ClansInviteGuiController.丗丐丅丂不不丁三丙());
        goto label_31;
        label_13:
        if(val_47 == 0)
        {
                val_47 = null;
            val_47 = new System.Collections.Generic.List<System.String>();
            if(val_47 == null)
        {
            goto label_32;
        }
        
        }
        
        label_32:
        if(null.Count <= 199)
        {
                null.Add(item:  val_10.丒且丟下东丘丆丄丕());
        }
        
        this.丕丘丐丙丌丆与且不 = false;
        label_31:
        if((1994545280 & 1) != 0)
        {
            goto label_33;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_48 = null;
        val_48 = null;
        if(ClansInviteGuiController.丄不丆丂三丗七东与 != false)
        {
                ClansInviteGuiController.丄不丆丂三丗七东与 = false;
            if( != 0)
        {
                val_47.Clear();
        }
        else
        {
                System.Collections.Generic.List<System.String> val_32 = null;
            val_47 = val_32;
            val_32 = new System.Collections.Generic.List<System.String>();
        }
        
            val_50 = null;
            val_50 = null;
            val_52 = ClansInviteGuiController.<>c.<>9__44_0;
            if(val_52 == null)
        {
                System.Func<丅下丙一东丄丕丛下, System.String> val_36 = null;
            val_52 = val_36;
            val_36 = new System.Func<丅下丙一东丄丕丛下, System.String>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ClansInviteGuiController.<>c::丄不与一丟丞丁丆丞(丅下丙一东丄丕丛下 三丟东丕丄丄下下丑));
            ClansInviteGuiController.<>c.<>9__44_0 = val_52;
        }
        
            val_32.AddRange(collection:  System.Linq.Enumerable.Take<System.String>(source:  System.Linq.Enumerable.Select<丅下丙一东丄丕丛下, System.String>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄(), selector:  val_36), count:  232));
            this.丕丘丐丙丌丆与且不 = false;
        }
        
        val_53 = null;
        val_53 = null;
        val_55 = ClansInviteGuiController.<>c.<>9__44_1;
        if(val_55 == null)
        {
                System.Func<丗丐丅丂不不丁三丙, System.Int32> val_39 = null;
            val_55 = val_39;
            val_39 = new System.Func<丗丐丅丂不不丁三丙, System.Int32>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClansInviteGuiController.<>c::丟丗丕万丟与世丂丄(ClansInviteGuiController.丗丐丅丂不不丁三丙 三丟东丕丄丄下下丑));
            ClansInviteGuiController.<>c.<>9__44_1 = val_55;
        }
        
        val_56 = null;
        val_56 = null;
        val_58 = ClansInviteGuiController.<>c.<>9__44_2;
        if(val_58 == null)
        {
                System.Func<丗丐丅丂不不丁三丙, System.Int32> val_41 = null;
            val_58 = val_41;
            val_41 = new System.Func<丗丐丅丂不不丁三丙, System.Int32>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClansInviteGuiController.<>c::一丈丄与丕丄上丐下(ClansInviteGuiController.丗丐丅丂不不丁三丙 三丟东丕丄丄下下丑));
            ClansInviteGuiController.<>c.<>9__44_2 = val_58;
        }
        
        this.requestsWrapGrid.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  System.Linq.Enumerable.ThenByDescending<丗丐丅丂不不丁三丙, System.Int32>(source:  System.Linq.Enumerable.OrderByDescending<丗丐丅丂不不丁三丙, System.Int32>(source:  this.丙丙丐不丅丟丏丈丗, keySelector:  val_39), keySelector:  val_41))), 业丛丛世上丈丘丄东:  false);
        if(val_47 == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<System.String>(source:  val_32)) == false)
        {
                return;
        }
        
        丂与专万与丐丌丏不.丑七不且上丗丁一世().上丂不东丝且丆丝丝(世丅丈东丘丐丕丟丐:  val_32);
    }
    public void OpenTab_Requests()
    {
        var val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.requestsTabContainer, 丏业丟一东丂东丘丛:  true);
        val_2 = null;
        val_2 = null;
        if((ClansInviteGuiController.<>c.<>9__45_0) == null)
        {
            goto label_5;
        }
        
        label_10:
        this.requestsToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__45_0);
        this.丞业丝专丌东丙丐且();
        return;
        label_5:
        ClansInviteGuiController.<>c.<>9__45_0 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::丐丆丑丝与丝丛不世(UIToggle 三丟东丕丄丄下下丑));
        if(this.requestsToggle != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    private void 丏丅丌万丌丄东丐丂()
    {
        var val_11;
        var val_12;
        丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_3 != null)
        {
                丌丌丄丂丕丑专万丆 val_5 = val_3.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            val_11 = 0;
        }
        else
        {
                val_11 = 0;
        }
        
        if((val_11.丙东专丂世丈丏丁丂() == 1) && ((1995000760 & 1) != 0))
        {
                val_12 = 1;
        }
        else
        {
                val_12 = ((val_11.丙东专丂世丈丏丁丂() == 2) ? 1 : 0) & 1152921536666618808;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rejectAllButton, 丏业丟一东丂东丘丛:  ((this.requestsWrapGrid.ContentCount > 0) ? 1 : 0) & val_12);
    }
    public void OnClickCancelFindFriendButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.findFriendInput.value = System.String.alignConst;
    }
    private void 丑三且专丙丄丕丏丙()
    {
        var val_16;
        float val_17;
        float val_18;
        string val_19;
        int val_20;
        object val_21;
        this.friendsWrap.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClansInviteGuiController::丝专万丐丐万丒世丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.friendsWrap, 丏业丟一东丂东丘丛:  true);
        int val_3 = UnityEngine.Screen.height;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_16 = null;
            val_16 = null;
            float val_15 = (float)val_3;
            val_15 = IphoneXCameraScaler.且下丒丘丙丒丈丏万 * val_15;
            val_17 = 748f / val_15;
            val_18 = IphoneXCameraScaler.不丅七丘丈不丌丝丏 * (float)UnityEngine.Screen.width;
        }
        else
        {
                val_17 = 748f / (float)val_3;
            val_18 = (float)UnityEngine.Screen.width;
        }
        
        val_17 = val_17 * val_18;
        val_17 = val_17 + (-20f);
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_17);
        UIDragScrollView val_8 = this.infoItem.transform.GetComponent<UIDragScrollView>();
        val_8.scrollView = this.friendsScroll;
        val_19 = this.infoItem.GetComponent<UIWidget>();
        val_20 = val_6;
        val_19.width = val_20;
        val_21 = 0;
        goto label_19;
        label_26:
        val_19 = System.String.Format(format:  "{0} {1}", arg0:  this.infoItem.name, arg1:  val_21);
        val_20 = val_19;
        不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  val_6.gameObject, 丑且不丕与专丄业丙:  this.infoItem.gameObject).name = val_20;
        val_21 = 1;
        label_19:
        if(val_21 < 14)
        {
            goto label_26;
        }
    
    }
    private void 七丙三丞丝三且不丘()
    {
        InfoWindowController.丏三万丏世丛业丒丒();
        if(this.loading != 0)
        {
                this.loading.gameObject.SetActive(value:  false);
        }
        
        this.不丁丙丞丄丂三丗丝();
        this.三丈丐丑丞丌下万丁();
    }
    public void OnClickFindFriendButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this._currentMode = 1;
        if((System.String.IsNullOrEmpty(value:  this.findFriendInput.value)) != false)
        {
                return;
        }
        
        this.<丙丑与三专专丁丂丂>k__BackingField = true;
        this.ShowResultFindPlayer(丂丐丄丁丆与丈丂上:  this.findFriendInput.value);
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0348"));
    }
    public void ShowResultFindPlayer(string 丂丐丄丁丆与丈丂上)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_2.Add(key:  "Search Friends", value:  "Search");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Social", 丛东不丒丏丈丄且丕:  val_2);
        val_6 = null;
        val_6 = null;
        FriendsController.丄丞丁丈与业上丞丟.SearchPlayersByString(丂丐丄丁丆与丈丂上:  丂丐丄丁丆与丈丂上, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::丅东且丘丗上丆世丌()), 七丛丟丕丐丆丆丝七:  new System.Action(object:  this, method:  System.Void ClansInviteGuiController::丙三东丅东丄丅丑上()));
    }
    private void 不丁丙丞丄丂三丗丝()
    {
        var val_11;
        var val_31;
        var val_32;
        var val_33;
        string val_34;
        var val_35;
        System.Collections.Generic.List<System.String> val_36;
        var val_37;
        this.friendsList.Clear();
        if(this._currentMode == 2)
        {
            goto label_2;
        }
        
        if(this._currentMode == 1)
        {
            goto label_3;
        }
        
        if(this._currentMode != 0)
        {
            goto label_49;
        }
        
        val_31 = 1152921516934571616;
        val_32 = 1152921505151574016;
        val_33 = 0;
        goto label_5;
        label_15:
        val_34 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Item[0];
        this.friendsList.Add(item:  new ClansInviteGuiController.万丕上东丅与丙丏丕(丄丏丆丝世丙业下丌:  val_34, 丁丅丈丌丟世丗丗丟:  0));
        val_33 = 1;
        label_5:
        if(val_33 < 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count)
        {
            goto label_15;
        }
        
        goto label_49;
        label_2:
        val_35 = null;
        val_35 = null;
        Dictionary.Enumerator<TKey, TValue> val_8 = 下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.GetEnumerator();
        val_34 = 1152921526106513264;
        val_31 = 1152921526106515312;
        val_32 = 1152921524404748272;
        label_28:
        if((1996064112 & 1) == 0)
        {
            goto label_20;
        }
        
        ConfiguredValueTaskAwaiter val_12 = val_11.GetAwaiter();
        string val_13 = val_12._value._obj.丐丏七丌丕丗业且上();
        if((((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_13)) == false) || ((System.String.op_Inequality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_13)) == false)) || ((Rilisoft.Singleton<ClansController>.Instance.且丁丐一世下丒丞丏(丄丒且丙三丆丟与丏:  val_13)) == true))
        {
            goto label_28;
        }
        
        new ClansInviteGuiController.万丕上东丅与丙丏丕() = new ClansInviteGuiController.万丕上东丅与丙丏丕(丄丏丆丝世丙业下丌:  val_13, 丁丅丈丌丟世丗丗丟:  1);
        this.friendsList.Add(item:  new ClansInviteGuiController.万丕上东丅与丙丏丕());
        goto label_28;
        label_3:
        val_36 = this.丛丌丌丒丌丕丅丅万;
        if(val_36 == null)
        {
            goto label_49;
        }
        
        val_31 = 1152921516223708000;
        val_32 = 1152921505151574016;
        val_37 = 0;
        goto label_30;
        label_37:
        string val_22 = this.丛丌丌丒丌丕丅丅万.Item[0];
        if((System.String.op_Inequality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_22)) != false)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.且丁丐一世下丒丞丏(丄丒且丙三丆丟与丏:  val_22)) != true)
        {
                ClansInviteGuiController.万丕上东丅与丙丏丕 val_27 = null;
            val_34 = val_27;
            val_27 = new ClansInviteGuiController.万丕上东丅与丙丏丕(丄丏丆丝世丙业下丌:  val_22, 丁丅丈丌丟世丗丗丟:  1);
            this.friendsList.Add(item:  val_27);
        }
        
        }
        
        val_36 = this.丛丌丌丒丌丕丅丅万;
        val_37 = 1;
        label_30:
        if(val_37 < val_36.Count)
        {
            goto label_37;
        }
        
        goto label_49;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_49:
        this.friendsWrap.minIndex = -this.friendsList.Count;
    }
    private void 三丈丐丑丞丌下万丁()
    {
        var val_9;
        var val_10;
        int val_1 = this.friendsList.Count;
        UnityEngine.Transform val_2 = this.friendsWrap.transform;
        val_9 = 0;
        val_10 = 0;
        goto label_3;
        label_12:
        ClansInfoInviteContainer val_4 = val_2.GetChild(index:  0).GetComponent<ClansInfoInviteContainer>();
        if(val_1 != 0)
        {
                UIDragScrollView val_5 = val_4.GetComponent<UIDragScrollView>();
            if(val_1 > this.minCellCountForDisableScroll)
        {
                val_5.enabled = true;
        }
        else
        {
                val_5.enabled = false;
            val_10 = 1;
        }
        
        }
        
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  val_4);
        val_9 = 1;
        label_3:
        if(val_9 < val_2.childCount)
        {
            goto label_12;
        }
        
        if((val_10 & 1) != 0)
        {
                this.friendsScroll.ResetPosition();
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丏丂丑丅丁一丂专丛());
    }
    private System.Collections.IEnumerator 丏丂丑丅丁一丂专丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClansInviteGuiController.丗丄丂丄丌丛丟上丈();
    }
    private void 丞丙丞丅丘七丅不世(ClansInfoInviteContainer 七丘丛下丒丅且丕且)
    {
        var val_8;
        var val_9;
        if(this.friendsList.Count > 七丘丛下丒丅且丕且.wrapIndex)
        {
                七丘丛下丒丅且丕且.UpdateView(东丛下丗且东丄业下:  this.friendsList.Item[七丘丛下丒丅且丕且.wrapIndex]);
            七丘丛下丒丅且丕且.gameObject.SetActive(value:  false);
            val_8 = 七丘丛下丒丅且丕且.gameObject;
            val_9 = 1;
        }
        else
        {
                if(七丘丛下丒丅且丕且.gameObject.activeSelf == false)
        {
                return;
        }
        
            val_8 = 七丘丛下丒丅且丕且.gameObject;
            val_9 = 0;
        }
        
        val_8.SetActive(value:  false);
    }
    private void 丝专万丐丐万丒世丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)
    {
        ClansInfoInviteContainer val_1 = 丝三丁东丈丒世丅业.GetComponent<ClansInfoInviteContainer>();
        val_1.wrapIndex = UnityEngine.Mathf.Abs(value:  丞丂业丅丟丙丏七丗);
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<ClansInfoInviteContainer>());
    }
    private void 丑丂丒上东丙丟丕三()
    {
        if(this.与丈丘下一七丒东丁 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.与丈丘下一七丒东丁.Dispose();
        this.与丈丘下一七丒东丁 = 0;
    }
    private void 丂丏丁与丑丌丞专上()
    {
        this.丂丏丁与丑丌丞专上(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 丂丏丁与丑丌丞专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丄丑上丕丂丈丘丙七 != null)
        {
                this.丄丑上丕丂丈丘丙七.Invoke();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public void BackBtn()
    {
        this.丂丏丁与丑丌丞专上(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    public void OnFriendsClick()
    {
        var val_3;
        this.丆与丅丆且丌丒与且();
        this._currentMode = 0;
        val_3 = null;
        val_3 = null;
        if((ClansInviteGuiController.<>c.<>9__61_0) == null)
        {
            goto label_3;
        }
        
        label_10:
        this.friendsToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__61_0);
        this.friendsScroll.gameObject.SetActive(value:  true);
        this.七丙三丞丝三且不丘();
        return;
        label_3:
        ClansInviteGuiController.<>c.<>9__61_0 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::丒丕丄业丆丆专丂不(UIToggle 三丟东丕丄丄下下丑));
        if(this.friendsToggle != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    public void OnSearchClick()
    {
        var val_2;
        this.丆与丅丆且丌丒与且();
        this.findFriendInput.value = System.String.alignConst;
        this._currentMode = 2;
        val_2 = null;
        val_2 = null;
        if((ClansInviteGuiController.<>c.<>9__62_0) == null)
        {
            goto label_4;
        }
        
        label_11:
        this.searchToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__62_0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.friendsScroll, 丏业丟一东丂东丘丛:  true);
        this.七丙三丞丝三且不丘();
        return;
        label_4:
        ClansInviteGuiController.<>c.<>9__62_0 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::丛与丛丒丈丞丟丂丒(UIToggle 三丟东丕丄丄下下丑));
        if(this.searchToggle != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    public void OnRequestClick()
    {
        this.丆与丅丆且丌丒与且();
        this._currentMode = 3;
        this.OpenTab_Requests();
        this.七丙三丞丝三且不丘();
    }
    public void OnGiftsClick()
    {
        var val_2;
        this.丆与丅丆且丌丒与且();
        this._currentMode = 4;
        val_2 = null;
        val_2 = null;
        if((ClansInviteGuiController.<>c.<>9__64_0) == null)
        {
            goto label_3;
        }
        
        label_10:
        this.giftsToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__64_0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftsContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftsDescription, 丏业丟一东丂东丘丛:  true);
        this.下丟丂东世上三世世();
        return;
        label_3:
        ClansInviteGuiController.<>c.<>9__64_0 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::专丂丂丁丛丝丞七专(UIToggle 三丟东丕丄丄下下丑));
        if(this.giftsToggle != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    public void OnClickRefreshButton()
    {
    
    }
    private void 丞业丝专丌东丙丐且()
    {
        var val_19;
        object val_20;
        var val_21;
        System.Func<丅下丙一东丄丕丛下, System.String> val_23;
        System.Collections.Generic.List<System.String> val_24;
        if(this._currentMode != 3)
        {
                return;
        }
        
        val_19 = 1152921524404748272;
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_2 != null)
        {
                int val_4 = val_2.上丟下丌丞业丞专丄().Count;
            val_20 = 0;
        }
        else
        {
                val_20 = 0;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.requestsCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/100", arg0:  val_20));
        val_21 = null;
        val_21 = null;
        val_23 = ClansInviteGuiController.<>c.<>9__66_0;
        if(val_23 == null)
        {
                System.Func<丅下丙一东丄丕丛下, System.String> val_9 = null;
            val_23 = val_9;
            val_9 = new System.Func<丅下丙一东丄丕丛下, System.String>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ClansInviteGuiController.<>c::丌不万丏与丞丑丘丆(丅下丙一东丄丕丛下 三丟东丕丄丄下下丑));
            ClansInviteGuiController.<>c.<>9__66_0 = val_23;
        }
        
        System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丅下丙一东丄丕丛下, System.String>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄(), selector:  val_9));
        val_24 = Rilisoft.Singleton<ClansController>.Instance;
        if((val_24.丞丗丑丈一丅丗丌丟() != null) && (this.万下万且不东上丅业 != null))
        {
                val_19 = 1152921516934571616;
            val_24 = val_11.Count;
            if(val_24 == this.万下万且不东上丅业.Count)
        {
                val_24 = this.万下万且不东上丅业;
            if(val_24.Count >= 1)
        {
                System.Collections.Generic.HashSet<System.String> val_17 = null;
            val_24 = val_17;
            val_17 = new System.Collections.Generic.HashSet<System.String>(collection:  val_11);
            if((val_17.SetEquals(other:  this.万下万且不东上丅业)) == true)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        this.丕丘丐丙丌丆与且不 = false;
        this.丈丑丟丒七三丝丝且();
        this.丏丅丌万丌丄东丐丂();
    }
    public void U_RemoveAllRequests()
    {
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌().丟不丁丑世上东世东();
    }
    private void 下丟丂东世上三世世()
    {
        UnityEngine.Object val_10;
        var val_11;
        System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean> val_13;
        val_10 = this;
        if(this._currentMode != 4)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = ClansInviteGuiController.<>c.<>9__68_0;
        if(val_13 == null)
        {
                System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean> val_3 = null;
            val_13 = val_3;
            val_3 = new System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClansInviteGuiController.<>c::与一与丏丏丏上东丏(PGCompany.GiftSystem.丏下丙丂万且一丑丛 三丟东丕丄丄下下丑));
            ClansInviteGuiController.<>c.<>9__68_0 = val_13;
        }
        
        this.giftsWrapGrid.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  System.Linq.Enumerable.Where<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(source:  Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘(), predicate:  val_3))), 业丛丛世上丈丘丄东:  false);
        val_10 = Rilisoft.Singleton<NotificationMessageController>.Instance;
        if(val_10 == 0)
        {
                return;
        }
        
        Rilisoft.Singleton<NotificationMessageController>.Instance.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  2, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = false, isViewd = false});
    }
    private void 且七丐丟丅不丄丙丗()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        this.万下万且不东上丅业.Clear();
        this.丞业丝专丌东丙丐且();
    }
    private void 丆与丅丆且丌丒与且()
    {
        var val_5;
        var val_7;
        var val_9;
        var val_11;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftsContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftsDescription, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.friendsScroll, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.requestsTabContainer, 丏业丟一东丂东丘丛:  false);
        val_5 = null;
        val_5 = null;
        if((ClansInviteGuiController.<>c.<>9__70_0) == null)
        {
            goto label_5;
        }
        
        label_22:
        this.friendsToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__70_0);
        val_7 = null;
        val_7 = null;
        if((ClansInviteGuiController.<>c.<>9__70_1) == null)
        {
            goto label_9;
        }
        
        label_26:
        this.searchToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__70_1);
        val_9 = null;
        val_9 = null;
        if((ClansInviteGuiController.<>c.<>9__70_2) == null)
        {
            goto label_13;
        }
        
        label_30:
        this.giftsToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__70_2);
        val_11 = null;
        val_11 = null;
        if((ClansInviteGuiController.<>c.<>9__70_3) == null)
        {
            goto label_17;
        }
        
        label_34:
        this.requestsToggle.ForEach(action:  ClansInviteGuiController.<>c.<>9__70_3);
        return;
        label_5:
        ClansInviteGuiController.<>c.<>9__70_0 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::业丆下专丑专丅上丂(UIToggle 三丟东丕丄丄下下丑));
        if(this.friendsToggle != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_9:
        ClansInviteGuiController.<>c.<>9__70_1 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::世丘一丐丟上丄丏丙(UIToggle 三丟东丕丄丄下下丑));
        if(this.searchToggle != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_13:
        ClansInviteGuiController.<>c.<>9__70_2 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::万丝丐丏东丐丁下丁(UIToggle 三丟东丕丄丄下下丑));
        if(this.giftsToggle != null)
        {
            goto label_30;
        }
        
        goto label_30;
        label_17:
        ClansInviteGuiController.<>c.<>9__70_3 = new System.Action<UIToggle>(object:  ClansInviteGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansInviteGuiController.<>c::丄丒丏世业上丗丏且(UIToggle 三丟东丕丄丄下下丑));
        if(this.requestsToggle != null)
        {
            goto label_34;
        }
        
        goto label_34;
    }
    private void 丝一丐丛丂丈丅东丟(int 万且万且丑丗且丌丆)
    {
        this.丞业丝专丌东丙丐且();
    }
    public ClansInviteGuiController()
    {
        this.丕丘丐丙丌丆与且不 = true;
        this.万下万且不东上丅业 = new System.Collections.Generic.List<System.String>();
        this.丙丙丐不丅丟丏丈丗 = new System.Collections.Generic.List<丗丐丅丂不不丁三丙>();
        this.minCellCountForDisableScroll = 8;
        this.friendsList = new System.Collections.Generic.List<万丕上东丅与丙丏丕>();
    }
    private static ClansInviteGuiController()
    {
        ClansInviteGuiController.丄不丆丂三丗七东与 = true;
    }
    private void 丅东且丘丗上丆世丌()
    {
        var val_4;
        if((this.<丙丑与三专专丁丂丂>k__BackingField) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        System.Collections.Generic.List<System.String> val_1 = FriendsController.丄丞丁丈与业上丞丟.SearchPlayersByStringResult;
        this.丛丌丌丒丌丕丅丅万 = val_1;
        if((System.Linq.Enumerable.Any<System.String>(source:  val_1)) != false)
        {
                this.七丙三丞丝三且不丘();
            return;
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1426"));
    }
    private void 丙三东丅东丄丅丑上()
    {
        if((this.<丙丑与三专专丁丂丂>k__BackingField) == false)
        {
                return;
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1426"));
    }

}
