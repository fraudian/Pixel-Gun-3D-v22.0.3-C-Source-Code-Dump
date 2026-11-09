using UnityEngine;
public class SquadInviteGUI : MonoBehaviour
{
    // Fields
    public Rilisoft.ButtonHandler backBtn;
    internal static SquadInviteGUI 丄丘七三上丕世丞业;
    private SquadInviteGUI.三丒丝上丐丈业丗丏 东万丆丐丞专三丂丁;
    public UILabel canPlayWithLvl;
    public FriendInviteInfoContainer infoItem;
    public UIToggle friendsTab;
    public UIToggle clanTab;
    public UIToggle clanTabSingle;
    public UnityEngine.GameObject twoTabsGO;
    public UnityEngine.GameObject oneTabGOClan;
    public UIWrapContent friendsWrap;
    public UIScrollView friendsScroll;
    private System.IDisposable 与丈丘下一七丒东丁;
    public bool isActive;
    private System.Collections.Generic.List<SquadInviteGUI.丒世七丈丈丘丄丞丕> 万丄不丅业丌三丟丘;
    
    // Methods
    private void Awake()
    {
        SquadInviteGUI.丄丘七三上丕世丞业 = this;
        this.infoItem.gameObject.SetActive(value:  false);
        this.丑三且专丙丄丕丏丙();
    }
    private void OnEnable()
    {
        var val_7;
        System.Func<丒世七丈丈丘丄丞丕, System.String> val_9;
        FriendsController.业丐丙丅丒丝丈丕丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::七丙三丞丝三且不丘()));
        丌且下丛三丟三业丑.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::七丙三丞丝三且不丘()));
        丐丌不丏东丟丕七丟.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::业丌丒丂业三丒丂万()));
        this.不丁丙丞丄丂三丗丝();
        val_7 = null;
        val_7 = null;
        val_9 = SquadInviteGUI.<>c.<>9__18_0;
        if(val_9 == null)
        {
                System.Func<丒世七丈丈丘丄丞丕, System.String> val_5 = null;
            val_9 = val_5;
            val_5 = new System.Func<丒世七丈丈丘丄丞丕, System.String>(object:  SquadInviteGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.String SquadInviteGUI.<>c::与丞丄丈丙下丗丕不(SquadInviteGUI.丒世七丈丈丘丄丞丕 东丝丄丝丙专丘三丏));
            SquadInviteGUI.<>c.<>9__18_0 = val_9;
        }
        
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  System.Linq.Enumerable.Select<丒世七丈丈丘丄丞丕, System.String>(source:  this.万丄不丅业丌三丟丘, selector:  val_5));
        this.不丁丙丞丄丂三丗丝();
        this.三丈丐丑丞丌下万丁();
    }
    private void 业丌丒丂业三丒丂万()
    {
        this.不丁丙丞丄丂三丗丝();
        this.三丈丐丑丞丌下万丁();
    }
    private void OnDisable()
    {
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::七丙三丞丝三且不丘()));
        丌且下丛三丟三业丑.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::七丙三丞丝三且不丘()));
        丐丌不丏东丟丕七丟.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::业丌丒丂业三丒丂万()));
    }
    private void 丑三且专丙丄丕丏丙()
    {
        string val_8;
        UIScrollView val_9;
        object val_10;
        this.friendsWrap.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadInviteGUI::丝专万丐丐万丒世丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗));
        val_8 = public UIDragScrollView UnityEngine.Component::GetComponent<UIDragScrollView>();
        val_9 = this.friendsScroll;
        val_3.scrollView = val_9;
        val_10 = 0;
        goto label_5;
        label_11:
        val_9 = "FriendPreviewItem_" + val_10;
        val_8 = val_9;
        不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.infoItem.transform.GetComponent<UIDragScrollView>().gameObject, 丑且不丕与专丄业丙:  this.infoItem.gameObject).name = val_8;
        val_10 = 1;
        label_5:
        if(val_10 < 7)
        {
            goto label_11;
        }
    
    }
    private void 七丙三丞丝三且不丘()
    {
        this.不丁丙丞丄丂三丗丝();
        this.三丈丐丑丞丌下万丁();
    }
    private void 不丁丙丞丄丂三丗丝()
    {
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        this.万丄不丅业丌三丟丘.Clear();
        if(this.东万丆丐丞专三丂丁 == 0)
        {
            goto label_2;
        }
        
        val_39 = 1152921524404748272;
        if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
        {
            goto label_21;
        }
        
        val_40 = 1152921536523277200;
        val_41 = 1152921540376511440;
        val_42 = 0;
        goto label_8;
        label_20:
        string val_9 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不().Item[0].业丐丐三丕一丗丛丁();
        int val_11 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().七丙丞且世七丙丐下(丄丒且丙三丆丟与丏:  val_9);
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.squad")) != false)
        {
                if((System.String.op_Inequality(a:  val_9, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                this.万丄不丅业丌三丟丘.Add(item:  new 丒世七丈丈丘丄丞丕() {东丝世世丗专丟丏丘 = ???});
        }
        
        }
        
        val_42 = 1;
        label_8:
        if(val_42 < (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不().Count))
        {
            goto label_20;
        }
        
        goto label_21;
        label_2:
        val_39 = 1152921505234001920;
        val_40 = 1152921516223708000;
        val_43 = 0;
        goto label_42;
        label_48:
        string val_21 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Item[0];
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().ContainsKey(key:  val_21)) != false)
        {
                object val_28 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().Item[val_21].Item["player"];
            val_41 = 1;
            if((0.ContainsKey(key:  "rank")) != false)
        {
                int val_31 = System.Convert.ToInt32(value:  0.Item["rank"]);
        }
        
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.squad")) != false)
        {
                this.万丄不丅业丌三丟丘.Add(item:  new 丒世七丈丈丘丄丞丕() {东丝世世丗专丟丏丘 = ???});
        }
        
        }
        
        val_43 = 1;
        label_42:
        if(val_43 < 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count)
        {
            goto label_48;
        }
        
        label_21:
        this.万丄不丅业丌三丟丘.Sort(comparison:  new System.Comparison<丒世七丈丈丘丄丞丕>(object:  this, method:  System.Int32 SquadInviteGUI::丗世东丁东丈业丝丐(SquadInviteGUI.丒世七丈丈丘丄丞丕 丞丘不丙万丈丕万且, SquadInviteGUI.丒世七丈丈丘丄丞丕 七万业丅丌丌丂丝且)));
        this.friendsWrap.minIndex = -this.万丄不丅业丌三丟丘.Count;
    }
    private void 三丈丐丑丞丌下万丁()
    {
        var val_33;
        System.Func<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一> val_35;
        var val_36;
        var val_37;
        val_33 = null;
        val_33 = null;
        val_35 = SquadInviteGUI.<>c.<>9__24_0;
        if(val_35 == null)
        {
                System.Func<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一> val_1 = null;
            val_35 = val_1;
            val_1 = new System.Func<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一>(object:  SquadInviteGUI.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.七下上丝三丛三上一 SquadInviteGUI.<>c::丄下丑丟丌三万丗丕(SquadInviteGUI.丒世七丈丈丘丄丞丕 与丘东下丈东丛丂万));
            SquadInviteGUI.<>c.<>9__24_0 = val_35;
        }
        
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<丒世七丈丈丘丄丞丕>(source:  System.Linq.Enumerable.OrderBy<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一>(source:  this.万丄不丅业丌三丟丘, keySelector:  val_1));
        int val_4 = val_3.Count;
        val_36 = 0;
        val_37 = 0;
        goto label_7;
        label_18:
        FriendInviteInfoContainer val_7 = this.friendsWrap.transform.GetChild(index:  0).GetComponent<FriendInviteInfoContainer>();
        if(val_4 != 0)
        {
                UIDragScrollView val_8 = val_7.GetComponent<UIDragScrollView>();
            if(val_4 < 5)
        {
                val_8.enabled = false;
            val_37 = 1;
        }
        else
        {
                val_8.enabled = true;
        }
        
        }
        
        val_8.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  val_7, 上丆专七丙三丕丄三:  val_3);
        val_36 = 1;
        label_7:
        if(val_36 < this.friendsWrap.transform.childCount)
        {
            goto label_18;
        }
        
        if((val_37 & 1) != 0)
        {
                this.friendsScroll.ResetPosition();
        }
        
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丏丂丑丅丁一丂专丛());
    }
    private System.Collections.IEnumerator 丏丂丑丅丁一丂专丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SquadInviteGUI.丑东专丁丛丆丌丞丁();
    }
    private void 丞丙丞丅丘七丅不世(FriendInviteInfoContainer 七丘丛下丒丅且丕且, System.Collections.Generic.List<SquadInviteGUI.丒世七丈丈丘丄丞丕> 上丆专七丙三丕丄三)
    {
        string val_3;
        string val_4;
        SquadInviteGUI.三丒丝上丐丈业丗丏 val_5;
        string val_6;
        var val_13;
        int val_14;
        val_13 = 七丘丛下丒丅且丕且;
        int val_1 = 上丆专七丙三丕丄三.Count;
        if(val_13 == null)
        {
            goto label_2;
        }
        
        val_14 = 七丘丛下丒丅且丕且.myWrapIndex;
        if(val_1 > val_14)
        {
            goto label_3;
        }
        
        goto label_5;
        label_2:
        val_14 = 28563616;
        if(val_1 <= 28563616)
        {
            goto label_5;
        }
        
        val_14 = 28563616;
        label_3:
        丒世七丈丈丘丄丞丕 val_2 = 上丆专七丙三丕丄三.Item[28563616];
        if(val_13 == null)
        {
            goto label_7;
        }
        
        val_13.SetUpPlayerInfo(东一丁世丑丞业丄丐:  new 丒世七丈丈丘丄丞丕() {丄丏丆丝世丙业下丌 = val_6, 丞丞下东且丗丄丒丏 = val_6, 专下不丘丘丝丅七三 = val_4, 且专东下上上丙丌丈 = val_4, 丁丅丈丌丟世丗丗丟 = val_5, 专世专丟丝丌与丘上 = val_5, 丂丒丘丅专丗丂世丛 = val_3, 东丝世世丗专丟丏丘 = val_6});
        goto label_8;
        label_5:
        if(val_13.gameObject.activeSelf == false)
        {
                return;
        }
        
        val_13.gameObject.SetActive(value:  false);
        return;
        label_7:
        0.SetUpPlayerInfo(东一丁世丑丞业丄丐:  new 丒世七丈丈丘丄丞丕() {丄丏丆丝世丙业下丌 = val_6, 丞丞下东且丗丄丒丏 = val_6, 专下不丘丘丝丅七三 = val_4, 且专东下上上丙丌丈 = val_4, 丁丅丈丌丟世丗丗丟 = val_5, 专世专丟丝丌与丘上 = val_5, 丂丒丘丅专丗丂世丛 = val_3, 东丝世世丗专丟丏丘 = val_6});
        label_8:
        val_13.gameObject.SetActive(value:  false);
        val_13 = val_13.gameObject;
        val_13.SetActive(value:  true);
    }
    private int 丗世东丁东丈业丝丐(SquadInviteGUI.丒世七丈丈丘丄丞丕 丞丘不丙万丈丕万且, SquadInviteGUI.丒世七丈丈丘丄丞丕 七万业丅丌丌丂丝且)
    {
        var val_9;
        int val_3 = ExpController.万上一丝丆且七丅丅();
        int val_4 = val_3 - (ExpController.丐丈丒丈上业与丅丆(丝下三丆丅丕丐丒且:  268435464));
        int val_5 = val_3 - (ExpController.丐丈丒丈上业与丅丆(丝下三丆丅丕丐丒且:  268435464));
        var val_6 = (val_4 < 0) ? (-val_4) : (val_4);
        var val_7 = (val_5 < 0) ? (-val_5) : (val_5);
        if(val_6 >= val_7)
        {
                return (int)(val_6 > val_7) ? 1 : 0;
        }
        
        val_9 = 0;
        return (int)(val_6 > val_7) ? 1 : 0;
    }
    private void 丝专万丐丐万丒世丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)
    {
        var val_7;
        System.Func<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一> val_9;
        FriendInviteInfoContainer val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendInviteInfoContainer>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  丞丂业丅丟丙丏七丗);
        val_7 = null;
        val_7 = null;
        val_9 = SquadInviteGUI.<>c.<>9__28_0;
        if(val_9 == null)
        {
                System.Func<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一> val_3 = null;
            val_9 = val_3;
            val_3 = new System.Func<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一>(object:  SquadInviteGUI.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.七下上丝三丛三上一 SquadInviteGUI.<>c::丝一东专丂三丏上丌(SquadInviteGUI.丒世七丈丈丘丄丞丕 与丘东下丈东丛丂万));
            SquadInviteGUI.<>c.<>9__28_0 = val_9;
        }
        
        FriendInviteInfoContainer val_6 = 丝三丁东丈丒世丅业.GetComponent<FriendInviteInfoContainer>();
        val_6.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  val_6, 上丆专七丙三丕丄三:  System.Linq.Enumerable.ToList<丒世七丈丈丘丄丞丕>(source:  System.Linq.Enumerable.OrderBy<丒世七丈丈丘丄丞丕, Rilisoft.七下上丝三丛三上一>(source:  this.万丄不丅业丌三丟丘, keySelector:  val_3)));
    }
    private void Start()
    {
        if(this.backBtn == 0)
        {
                return;
        }
        
        this.backBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SquadInviteGUI::丂丏丁与丑丌丞专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
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
    public void ActivatePanel()
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_9;
        }
        
        val_8 = null;
        val_8 = null;
        if(SquadController.丄丘七三上丕世丞业.IsClanSquad == false)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.twoTabsGO, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.oneTabGOClan, 丏业丟一东丂东丘丛:  true);
        this.clanTabSingle.Set(丏业丟一东丂东丘丛:  true);
        this.东万丆丐丞专三丂丁 = 2;
        goto label_13;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.twoTabsGO, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.oneTabGOClan, 丏业丟一东丂东丘丛:  false);
        this.friendsTab.Set(丏业丟一东丂东丘丛:  true);
        label_13:
        this.gameObject.SetActive(value:  true);
        this.isActive = true;
        this.与丈丘下一七丒东丁 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SquadInviteGUI::丂丏丁与丑丌丞专上()), 与且专丈不万东一万:  "Squad invite panel");
    }
    public void DectivatePanel()
    {
        this.丑丂丒上东丙丟丕三();
        this.gameObject.SetActive(value:  false);
        this.isActive = false;
    }
    private void 丂丏丁与丑丌丞专上()
    {
        this.丂丏丁与丑丌丞专上(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 丂丏丁与丑丌丞专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.BackFromInvitePanel();
    }
    private void 业世丂一丂东丑丛丑()
    {
    
    }
    public void OnClansClick()
    {
        this.东万丆丐丞专三丂丁 = 2;
        this.不丁丙丞丄丂三丗丝();
        this.三丈丐丑丞丌下万丁();
    }
    public void OnFriendsClick()
    {
        this.东万丆丐丞专三丂丁 = 0;
        this.不丁丙丞丄丂三丗丝();
        this.三丈丐丑丞丌下万丁();
    }
    public SquadInviteGUI()
    {
        this.万丄不丅业丌三丟丘 = new System.Collections.Generic.List<丒世七丈丈丘丄丞丕>();
    }

}
