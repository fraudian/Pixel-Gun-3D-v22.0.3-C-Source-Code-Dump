using UnityEngine;
internal sealed class ClanSearchGui : ClanMainSearchGui
{
    // Fields
    private const string 业丄丛且丝三丗丏丅 = "NguiWindows/Clan/ClanSearch";
    private static ClanSearchGui 丄丘七三上丕世丞业;
    private static bool 不丈丑丙且且东丘丘;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private bool 下世七下上丝一七丅;
    private bool 丝世丗丆丄不丝丝丒;
    private UIButton backButton;
    private ClanSearchGui.一丐丛丏东上专丆丐 丅万丐丑丈丁丙丒丘;
    private UnityEngine.GameObject HeaderForClaMemberContainer;
    private System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 与丒下丕不一丒下丌;
    private System.Collections.Generic.List<string> 丐三丒丞上万一丙丟;
    private UILabel invitesInfoMessageLabel;
    private LoadingButton invitesRefreshButton;
    private UnityEngine.GameObject invitesTabContainer;
    private UIToggle invitesToggleButton;
    private DynamicWrapGrid invitesWrapGrid;
    private bool 丗丏丅丑丆三万丛丂;
    private UnityEngine.GameObject joinRequestDialogObj;
    private UIInput joinRequestMessageInput;
    private LoadingButton joinRequestSendButton;
    private System.Collections.Generic.List<ClanSearchGui.丑丏丄且丁且一专三> 七业下专一丕丞丐东;
    private System.Action 三丁丕丈丅丏丅丕丌;
    private UnityEngine.GameObject searchContainerFirst;
    private UILabel searchInfoMessageLabel;
    private UIInput searchInput;
    private UIInput searchInput_First;
    private string 且丞丐丅丝丁丐不丛;
    private System.Collections.Generic.List<ClanSearchGui.丑丏丄且丁且一专三> 丐七丈丐丛丄丙业万;
    private UnityEngine.GameObject searchResultsContainer;
    private UnityEngine.GameObject searchTabContainer;
    private UIToggle searchToggleButton;
    private DynamicWrapGrid searchWrapGrid;
    private ClanSearchWrapGridItem 业与丙一丙丞丝不丐;
    private UnityEngine.GameObject TabButtonsForPlayerContainer;
    private System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丝丈三万丄万一三丄;
    private UILabel topClansInfoMessageLabel;
    private UnityEngine.GameObject topClansTabContainer;
    private UIToggle topClansToggleButton;
    private DynamicWrapGrid topClansWrapGrid;
    private bool 丞与丗丟丞丝业丒丑;
    
    // Properties
    private bool 不丑丌丂丂丕丗丈上 { get; set; }
    private bool 丈丘丑丛且丝专丑七 { get; set; }
    
    // Methods
    private bool 丝丌业丐与三上七东()
    {
        return (bool)this.丗丏丅丑丆三万丛丂;
    }
    private void 业丗万丛丁丑丗丅丆(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this.丗丏丅丑丆三万丛丂 = val_1;
        this.invitesRefreshButton.Pressed = val_1;
    }
    private bool 上上东下丞丌丝丌世()
    {
        return (bool)this.下世七下上丝一七丅;
    }
    private void 丛丞七丝丛下丝丙三(bool 丙业与丙丗丝不丈东)
    {
        var val_13;
        this.下世七下上丝一七丅 = 丙业与丙丗丝不丈东;
        bool val_2 = 丙业与丙丗丝不丈东 ^ 1;
        丙业与丙丗丝不丈东 = val_2;
        UIButton val_3 = this.searchToggleButton.GetComponent<UIButton>();
        bool val_4 = val_2;
        UIButton val_5 = this.topClansToggleButton.GetComponent<UIButton>();
        bool val_6 = val_2;
        UIButton val_7 = this.invitesToggleButton.GetComponent<UIButton>();
        bool val_8 = val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchInput.gameObject, 丏业丟一东丂东丘丛:  val_2);
        val_13 = 0;
        goto label_12;
        label_16:
        this.searchWrapGrid.GetComponentsInChildren<ClanSearchWrapGridItem>(includeInactive:  true)[0].isEnabled = val_2;
        val_13 = 1;
        label_12:
        if(val_13 < val_11.Length)
        {
            goto label_16;
        }
    
    }
    internal static void 丌万丗与七丄丕不丁(ClanSearchGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业, System.Action 丛丝与丂世丌丌丝丂)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = null;
        val_7 = null;
        ClanSearchGui.不丈丑丙且且东丘丘 = true;
        val_8 = null;
        val_8 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 丏业丟一东丂东丘丛:  true);
        if(ClanSearchGui.丄丘七三上丕世丞业 == 0)
        {
                val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            ClanSearchGui.丄丘七三上丕世丞业 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  "NguiWindows/Clan/ClanSearch", 七万上丐一丈丏丏专:  ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<ClanSearchGui>();
        }
        else
        {
                val_11 = null;
            val_11 = null;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  ClanSearchGui.丄丘七三上丕世丞业.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        val_12 = null;
        val_12 = null;
        if(ClanSearchGui.丄丘七三上丕世丞业 == null)
        {
                val_12 = null;
        }
        
        三丁丕丈丅丏丅丕丌 = 丛丝与丂世丌丌丝丂;
        ClanSearchGui.丄丘七三上丕世丞业.万七丄东丞丅丆三东(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
        ClanSearchGui.不丈丑丙且且东丘丘 = false;
    }
    private void 万七丄东丞丅丆三东(ClanSearchGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业)
    {
        this.业丗万丛丁丑丗丅丆(丙业与丙丗丝不丈东:  false);
        this.丛丞七丝丛下丝丙三(丙业与丙丗丝不丈东:  false);
        this.joinRequestDialogObj.SetActive(value:  false);
        this.joinRequestMessageInput.value = System.String.alignConst;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
    }
    private void 丛丅专丁上一丞丄丈(ClanSearchGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业)
    {
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        this.丅万丐丑丈丁丙丒丘 = (val_2 != 0) ? 0 : 丐丅丒专丛丏上与业;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.TabButtonsForPlayerContainer, 丏业丟一东丂东丘丛:  (val_2 == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.HeaderForClaMemberContainer, 丏业丟一东丂东丘丛:  (val_2 != 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.invitesTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.topClansTabContainer, 丏业丟一东丂东丘丛:  false);
        if(this.丅万丐丑丈丁丙丒丘 == 2)
        {
            goto label_4;
        }
        
        if(this.丅万丐丑丈丁丙丒丘 == 1)
        {
            goto label_5;
        }
        
        if(this.丅万丐丑丈丁丙丒丘 != 0)
        {
                return;
        }
        
        this.丒丌丘丐丏且一不丂();
        return;
        label_4:
        this.丗业业不上丅万丄专();
        return;
        label_5:
        this.世丟丂丈丑上万丏一();
    }
    private void 丒丌丘丐丏且一不丂()
    {
        var val_10;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchTabContainer, 丏业丟一东丂东丘丛:  true);
        this.searchToggleButton.value = true;
        this.searchInput.value = System.String.alignConst;
        this.且丞丐丅丝丁丐不丛 = System.String.alignConst;
        this.searchInput.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel);
        this.searchWrapGrid.gameObject.SetActive(value:  false);
        if((Rilisoft.Singleton<ClansController>.Instance) != 0)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_11;
        }
        
        }
        
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        return;
        label_11:
        this.三丛丗一且丐丕三丅();
        val_10 = null;
        val_10 = null;
        if(ClanSearchGui.不丈丑丙且且东丘丘 == false)
        {
                return;
        }
        
        this.专丕丗丆东丈万七业();
    }
    private void 世丟丂丈丑上万丏一()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.invitesTabContainer, 丏业丟一东丂东丘丛:  true);
        this.invitesToggleButton.value = true;
        this.丐三丒丞上万一丙丟 = 0;
        this.丑丁丗丗下与三丞丑();
        this.业丕业专世丟丏业一();
    }
    private void 丗业业不上丅万丄专()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.topClansTabContainer, 丏业丟一东丂东丘丛:  true);
        this.topClansToggleButton.value = true;
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::且一丙丕万万专丒丌()));
        LeaderboardsController.万丅丙七丛丘丙丝与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::且一丙丕万万专丒丌()));
        this.七东一丅丘不丐三丗();
    }
    private void 东东丒七丞丘专业丗(UILabel 七丐丞丑丑丕世丙七, string 丕丗丘丑丛与丑业丒)
    {
        if(七丐丞丑丑丕世丙七 == 0)
        {
                return;
        }
        
        七丐丞丑丑丕世丙七.gameObject.SetActive(value:  true);
        七丐丞丑丑丕世丙七.text = 丕丗丘丑丛与丑业丒;
    }
    private void 丞丘下丛东丙专且世(UILabel 七丐丞丑丑丕世丙七)
    {
        if(七丐丞丑丑丕世丙七 == 0)
        {
                return;
        }
        
        七丐丞丑丑丕世丙七.gameObject.SetActive(value:  false);
    }
    private void 丞上丌丝丛上丐丝丆(string 丛丐一业业丐丕东七)
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchWrapGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0348");
        val_2.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel, 丕丗丘丑丛与丑业丒:  val_2);
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.业下与三三丕丑丞丂(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丝丟丈丟三丞丗与三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().世丈丝七业丞丕业且().丝一丏丞丌七丕世丕(丕丛业且专专丆丆丆:  丛丐一业业丐丕东七);
    }
    private void 丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)
    {
        var val_6;
        DynamicWrapGrid val_18;
        string val_19;
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        this.丐七丈丐丛丄丙业万 = new System.Collections.Generic.List<丑丏丄且丁且一专三>();
        List.Enumerator<T> val_4 = 丑丞七丈且丟丈丞且.GetEnumerator();
        label_4:
        if((1983066048 & 1) == 0)
        {
            goto label_2;
        }
        
        new ClanSearchGui.丑丏丄且丁且一专三() = new System.Object();
        .且丟丅丄丒丑丂丁世 = val_6.丐丏七丌丕丗业且上();
        this.丐七丈丐丛丄丙业万.Add(item:  new ClanSearchGui.丑丏丄且丁且一专三());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丐七丈丐丛丄丙业万 == null)
        {
            goto label_10;
        }
        
        if(this.丐七丈丐丛丄丙业万.Count == 0)
        {
            goto label_11;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchInfoMessageLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        UnityEngine.GameObject val_11 = this.searchWrapGrid.gameObject;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
        val_18 = this.searchWrapGrid;
        val_18.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_11.丄丆丗一丏丘业与丂(丗丏丟世万万丄与丁:  this.丐七丈丐丛丄丙业万))), 业丛丛世上丈丘丄东:  false);
        return;
        label_10:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchWrapGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        val_18 = this.searchInfoMessageLabel;
        val_19 = "Key_1528";
        goto label_23;
        label_11:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchWrapGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        val_18 = this.searchInfoMessageLabel;
        val_19 = "Key_1493";
        label_23:
        string val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_19);
        val_17.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  val_17);
    }
    private void 丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)
    {
        var val_4;
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        val_4 = null;
        val_4 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
        ClansWindowGUI.丆丕丝丒不丙且丐丗.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel);
    }
    private void 专丕丗丆东丈万七业()
    {
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.业下与三三丕丑丞丂(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丝丟丈丟三丞丗与三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().业丙丗丟丞丁丌丗不().丝一丏丞丌七丕世丕(万丅丝丈上丅丘丈丘:  0);
    }
    private void 丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)
    {
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        this.七业下专一丕丞丐东 = new System.Collections.Generic.List<丞丘丒一上与丕丒且>();
        List.Enumerator<T> val_4 = 丑丞七丈且丟丈丞且.GetEnumerator();
        label_4:
        if((1983635528 & 1) == 0)
        {
            goto label_2;
        }
        
        new ClanSearchGui.丑丏丄且丁且一专三() = new System.Object();
        .且丟丅丄丒丑丂丁世 = 0.丐丏七丌丕丗业且上();
        this.七业下专一丕丞丐东.Add(item:  new ClanSearchGui.丑丏丄且丁且一专三());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.三丛丗一且丐丕三丅();
    }
    private void 丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)
    {
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
    }
    private void 三丛丗一且丐丕三丅()
    {
        if(this.七业下专一丕丞丐东 != null)
        {
                if(this.七业下专一丕丞丐东.Count >= 1)
        {
                this.searchWrapGrid.gameObject.SetActive(value:  true);
            this.searchWrapGrid.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  this.七业下专一丕丞丐东)), 业丛丛世上丈丘丄东:  false);
            return;
        }
        
        }
        
        this.searchWrapGrid.gameObject.SetActive(value:  false);
    }
    public override void JoinClanFromSearch(string 丈丈丆丞丘东专万东)
    {
        this.丛丞七丝丛下丝丙三(丙业与丙丗丝不丈东:  true);
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丄专丑丝专万丌丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丁七七丙丒丌丛丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanSearchGui::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丄丆丑丝不不丒丘与().丞丌丝世丆业一东七(丄丒下业一不丈丝丘:  丈丈丆丞丘东专万东);
    }
    private void 丕专丛丟东丁丂上丘()
    {
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanSearchGui::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        this.丛丞七丝丛下丝丙三(丙业与丙丗丝不丈东:  false);
    }
    private void 丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)
    {
        ClansWindowGUI val_9;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        val_9 = 一丐丗丁丞丆丅丟丄;
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanSearchGui::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        this.丛丞七丝丛下丝丙三(丙业与丙丗丝不丈东:  false);
        val_10 = null;
        val_10 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if(丞丐丟三丌与丞上一 == 1710)
        {
            goto label_6;
        }
        
        if(丞丐丟三丌与丞上一 != 1702)
        {
            goto label_7;
        }
        
        val_11 = null;
        val_11 = null;
        val_9 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        val_12 = "Key_4361";
        goto label_12;
        label_6:
        val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5938");
        InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  val_9, 丂三丟丂丈丐丆丗丟:  ((System.Int32.TryParse(s:  val_9, result: out  0)) != true) ? 0f : 1200f);
        return;
        label_7:
        val_13 = null;
        val_13 = null;
        val_9 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        val_12 = "Key_1528";
        label_12:
        val_9.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_12), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
    }
    public override void ShowJoinRequestDialogFromSearch(ClanSearchWrapGridItem 丞东下丙万丈不丘三)
    {
        this.业与丙一丙丞丝不丐 = 丞东下丙万丈不丘三;
        this.joinRequestDialogObj.SetActive(value:  true);
    }
    private void 业下上丐丐丛丅世且()
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丒丁不丟丕丕丞丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟上三丕业丏三三丟(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanSearchGui::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌().丂且且丐不丕一丗丐(丄丒下业一不丈丝丘:  this.业与丙一丙丞丝不丐.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁(), 丄丙下丝丛丒七丂丘:  this.joinRequestMessageInput.value);
    }
    private void 丒上一丌专丛三丁丁()
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanSearchGui::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        this.joinRequestSendButton.Pressed = false;
        this.joinRequestDialogObj.SetActive(value:  false);
    }
    private void 东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanSearchGui::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丒上一丌专丛三丁丁()));
        this.joinRequestSendButton.Pressed = false;
        this.joinRequestDialogObj.SetActive(value:  false);
        if(丂七东不不丈一丐不 != 1740)
        {
                if(丂七东不不丈一丐不 != 1710)
        {
                return;
        }
        
            InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5938"), 丂三丟丂丈丐丆丗丟:  (float)丂三丟丂丈丐丆丗丟);
            return;
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11139"));
    }
    private void 一丏三七丂丕丑丟专()
    {
        null = null;
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  false);
    }
    private void 丑丁丗丗下与三丞丑()
    {
        System.Collections.Generic.HashSet<System.String> val_3 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().上丞东丌丐世与业丕();
        if(val_3 == null)
        {
                return;
        }
        
        if((this.丐三丒丞上万一丙丟 != null) && (val_3.Count == this.丐三丒丞上万一丙丟.Count))
        {
                if((new System.Collections.Generic.HashSet<System.String>(collection:  val_3).SetEquals(other:  this.丐三丒丞上万一丙丟)) != false)
        {
                return;
        }
        
        }
        
        this.丐三丒丞上万一丙丟 = new System.Collections.Generic.List<System.String>(collection:  val_3);
        this.丝世丗丆丄不丝丝丒 = false;
        this.与丒下丕不一丒下丌 = new System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>();
        if(this.丐三丒丞上万一丙丟.Count >= 1)
        {
                PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::业丕业专世丟丏业一()));
            PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
            PGCompany.Clans.Network.丞丝世上丏与丂丒上.丏一与丏丛丘丆丅丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::业丕业专世丟丏业一()));
            PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丝丐丄丂丙丘丗丝(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑().丛丐不丐丘丘万丒丂(丄丁上一与丟丌丒丘:  this.丐三丒丞上万一丙丟);
            return;
        }
        
        this.业丕业专世丟丏业一();
    }
    private void 丛与丄丆丐业丝丁万()
    {
        if(this.丅万丐丑丈丁丙丒丘 != 1)
        {
                if(this.丗丏丅丑丆三万丛丂 == false)
        {
                return;
        }
        
        }
        
        this.业丗万丛丁丑丗丅丆(丙业与丙丗丝不丈东:  false);
        this.丑丁丗丗下与三丞丑();
    }
    private void 七丅丙丂丝与丅世上()
    {
        var val_2;
        if(this.丗丏丅丑丆三万丛丂 == false)
        {
                return;
        }
        
        this.业丗万丛丁丑丗丅丆(丙业与丙丗丝不丈东:  false);
        val_2 = null;
        val_2 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
        this.业丕业专世丟丏业一();
    }
    private void 丙丘丌业丕丛丐丞丁()
    {
        this.丑丁丗丗下与三丞丑();
    }
    private void 业丕业专世丟丏业一()
    {
        var val_3;
        object val_21;
        System.Collections.IEnumerable val_22;
        val_21 = this;
        if(this.丐三丒丞上万一丙丟 == null)
        {
                return;
        }
        
        bool val_20 = this.丝世丗丆丄不丝丝丒;
        val_20 = val_20 + 3;
        var val_21 = ~val_20;
        val_21 = val_21 & 3;
        if(val_21 != 0)
        {
                return;
        }
        
        this.丝世丗丆丄不丝丝丒 = true;
        List.Enumerator<T> val_1 = this.丐三丒丞上万一丙丟.GetEnumerator();
        goto label_14;
        label_15:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_6 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
        if((val_6.丂丕万一丄一丂丗丒.ContainsKey(key:  val_4)) == false)
        {
            goto label_7;
        }
        
        PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_9 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
        丞丂丘丒丟丞丑下丄 val_10 = val_9.丂丕万一丄一丂丗丒.Item[val_4];
        if((this.与丒下丕不一丒下丌.Contains(item:  val_10)) == true)
        {
            goto label_14;
        }
        
        this.与丒下丕不一丒下丌.Add(item:  val_10);
        goto label_14;
        label_7:
        this.丝世丗丆丄不丝丝丒 = false;
        label_14:
        if((1985999536 & 1) != 0)
        {
            goto label_15;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丝世丗丆丄不丝丝丒 != false)
        {
                PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::业丕业专世丟丏业一()));
            PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
            this.业丗万丛丁丑丗丅丆(丙业与丙丗丝不丈东:  false);
        }
        
        val_22 = this.与丒下丕不一丒下丌.Count;
        UnityEngine.GameObject val_15 = this.invitesWrapGrid.gameObject;
        if(val_22 != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  true);
            val_15.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.invitesInfoMessageLabel);
            System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_16 = null;
            val_22 = val_16;
            val_16 = new System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>(collection:  this.与丒下丕不一丒下丌);
            val_21 = this.invitesWrapGrid;
            val_21.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_16)), 业丛丛世上丈丘丄东:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  false);
        val_21 = this.invitesInfoMessageLabel;
        string val_19 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1494");
        val_19.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  val_21, 丕丗丘丑丛与丑业丒:  val_19);
    }
    private void 业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)
    {
        var val_4;
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::业丕业专世丟丏业一()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
        if(this.丗丏丅丑丆三万丛丂 != false)
        {
                this.业丗万丛丁丑丗丅丆(丙业与丙丗丝不丈东:  false);
            val_4 = null;
            val_4 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
            ClansWindowGUI.丆丕丝丒不丙且丐丗.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.invitesInfoMessageLabel);
            this.业丕业专世丟丏业一();
            return;
        }
        
        this.丝世丗丆丄不丝丝丒 = true;
    }
    private void 七东一丅丘不丐三丗()
    {
        System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_2 = Rilisoft.Singleton<LeaderboardsController>.Instance.丂丂丛与丟世丁且丒();
        this.丝丈三万丄万一三丄 = val_2;
        UnityEngine.GameObject val_4 = this.topClansWrapGrid.gameObject;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<丞丂丘丒丟丞丑下丄>(丑东与丅丐丅丂丞业:  val_2)) != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        this.topClansWrapGrid.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  this.丝丈三万丄万一三丄)), 业丛丛世上丈丘丄东:  false);
    }
    private void 且一丙丕万万专丒丌()
    {
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::且一丙丕万万专丒丌()));
        this.七东一丅丘不丐三丗();
    }
    public void U_SearchToggleButtonClick()
    {
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  0);
    }
    public void U_InvitesToggleButtonClick()
    {
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  1);
    }
    public void U_TopClansToggleButtonClick()
    {
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  2);
    }
    public void U_SearchButtonClick()
    {
        if(this.searchContainerFirst.activeSelf == false)
        {
            goto label_1;
        }
        
        if(this.searchInput_First != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        string val_2 = this.searchInput_First.value;
        return;
        label_1:
        if(this.searchInput != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    public void U_RefreshInvitesButtonClick()
    {
        this.业丗万丛丁丑丗丅丆(丙业与丙丗丝不丈东:  true);
        this.一丏三七丂丕丑丟专();
    }
    public void U_SendJoinRequestButtonClick()
    {
        this.业下上丐丐丛丅世且();
    }
    public void U_CloseJoinRequstDialogClick()
    {
        if(this.joinRequestSendButton.Pressed != false)
        {
                return;
        }
        
        this.joinRequestDialogObj.SetActive(value:  false);
    }
    public void U_BackRequest()
    {
        UnityEngine.GameObject val_4;
        if(this.joinRequestDialogObj.activeSelf == false)
        {
            goto label_1;
        }
        
        if(this.joinRequestSendButton.Pressed == false)
        {
            goto label_3;
        }
        
        return;
        label_1:
        if(this.三丁丕丈丅丏丅丕丌 != null)
        {
                this.三丁丕丈丅丏丅丕丌.Invoke();
        }
        
        val_4 = this.gameObject;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_3:
        val_4 = this.joinRequestDialogObj;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        val_4.SetActive(value:  false);
    }
    public void OnSearchInputSubmit()
    {
        if((System.String.op_Equality(a:  this.searchInput.value, b:  System.String.alignConst)) != false)
        {
                this.searchInput.value = this.且丞丐丅丝丁丐不丛;
            return;
        }
        
        this.且丞丐丅丝丁丐不丛 = this.searchInput.value;
        this.丞上丌丝丛上丐丝丆(丛丐一业业丐丕东七:  this.searchInput.value);
    }
    private void Awake()
    {
        null = null;
        ClanSearchGui.丄丘七三上丕世丞业 = this;
    }
    private void OnEnable()
    {
        this.丞与丗丟丞丝业丒丑 = true;
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丐丁上世丒万万且丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丛与丄丆丐业丝丁万()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丏丕丘丟七丏世丌丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丙丘丌业丕丛丐丞丁()));
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                return;
        }
        
        this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanSearchGui::U_BackRequest()), 与且专丈不万东一万:  "ClanSearch");
    }
    private void OnDisable()
    {
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丞与丄不不丛业东丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丛与丄丆丐业丝丁万()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丐业丑不一且丟且东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丙丘丌业丕丛丐丞丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanSearchGui::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丒上一丌专丛三丁丁()));
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    private void OnDestroy()
    {
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::且一丙丕万万专丒丌()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::业丕业专世丟丏业一()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanSearchGui::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanSearchGui::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanSearchGui::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanSearchGui::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanSearchGui::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
    }
    private void LateUpdate()
    {
        if(this.丞与丗丟丞丝业丒丑 == false)
        {
                return;
        }
        
        this.丞与丗丟丞丝业丒丑 = false;
        if((System.String.op_Inequality(a:  this.且丞丐丅丝丁丐不丛, b:  System.String.alignConst)) == false)
        {
                return;
        }
        
        this.searchInput.label.text = this.且丞丐丅丝丁丐不丛;
    }
    public ClanSearchGui()
    {
        this.丝世丗丆丄不丝丝丒 = true;
        val_1 = new PGBehaviour();
    }
    private static ClanSearchGui()
    {
        ClanSearchGui.不丈丑丙且且东丘丘 = true;
    }

}
