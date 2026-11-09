using UnityEngine;
internal sealed class ClanStartGui_v2 : ClanMainSearchGui
{
    // Fields
    private static ClanStartGui_v2 <不丁丄七丛不丆丁丕>k__BackingField;
    internal static bool 业世不丌不丌不东业;
    private bool 不丈丑丙且且东丘丘;
    private System.Collections.Generic.List<ClanSearchGui.丑丏丄且丁且一专三> 丐七丈丐丛丄丙业万;
    private System.Collections.Generic.List<ClanSearchGui.丑丏丄且丁且一专三> 七业下专一丕丞丐东;
    private ClanSearchWrapGridItem 业与丙一丙丞丝不丐;
    private string 且丞丐丅丝丁丐不丛;
    private System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 与丒下丕不一丒下丌;
    private System.Collections.Generic.List<string> 丐三丒丞上万一丙丟;
    private bool 丝世丗丆丄不丝丝丒;
    private bool 丗丏丅丑丆三万丛丂;
    private System.Action 三丁丕丈丅丏丅丕丌;
    private bool 丈丅三丛丈丗丏丟万;
    private UnityEngine.Coroutine 与丄与丁丟三与丕丆;
    private long 丌丗丌业丆丄下丅世;
    private UILabel searchInfoMessageLabel;
    private UILabel ClanCreateButtonText;
    private UILabel DescriptionLabel;
    private PGCompany.PopupList chooseRegionPopup;
    private UnityEngine.GameObject searchForRegionIsEmptyGameObject;
    private UIButton searchWorldwideButton;
    private UnityEngine.GameObject searchTabContainer;
    private UIInput searchInput;
    private UIToggle searchToggleButton;
    private DynamicWrapGrid searchWrapGrid;
    private UnityEngine.GameObject joinRequestDialogObj;
    private UIInput joinRequestMessageInput;
    private LoadingButton joinRequestSendButton;
    private UILabel invitesInfoMessageLabel;
    private UnityEngine.GameObject invitesNotif;
    private UnityEngine.GameObject invitesTab;
    private DynamicWrapGrid invitesWrapGrid;
    private System.Collections.Generic.List<UnityEngine.GameObject> disabledUnHardUI;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    internal static ClanStartGui_v2 丆丕丝丒不丙且丐丗 { get; set; }
    private bool 不丑丌丂丂丕丗丈上 { get; set; }
    
    // Methods
    internal static ClanStartGui_v2 丑七不且上丗丁一世()
    {
        null = null;
        return (ClanStartGui_v2)ClanStartGui_v2.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(ClanStartGui_v2 丙业与丙丗丝不丈东)
    {
        null = null;
        ClanStartGui_v2.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private bool 丝丌业丐与三上七东()
    {
        return (bool)this.丗丏丅丑丆三万丛丂;
    }
    private void 业丗万丛丁丑丗丅丆(bool 丙业与丙丗丝不丈东)
    {
        this.丗丏丅丑丆三万丛丂 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        var val_1;
        ClanStartGui_v2.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        this.不丈丑丙且且东丘丘 = true;
        val_1 = null;
        val_1 = null;
        ClansWindowGUI.三丞丆丝东且丒丆万 = true;
    }
    private void OnEnable()
    {
        var val_10;
        var val_11;
        this.丄七丛丅专丑业丛业();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchForRegionIsEmptyGameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.joinRequestDialogObj, 丏业丟一东丂东丘丛:  false);
        this.joinRequestSendButton.Pressed = false;
        val_10 = null;
        val_10 = null;
        if(ClansWindowGUI.三丞丆丝东且丒丆万 != false)
        {
                this.丌丈丐东丙专丕丙丑();
            this.与丅丞丘丂专且世下();
            this.searchInput.value = System.String.alignConst;
            this.OnSearchInputSubmit();
            val_11 = null;
            val_11 = null;
            ClansWindowGUI.三丞丆丝东且丒丆万 = false;
        }
        else
        {
                if(this.七业下专一丕丞丐东.Count == 0)
        {
                this.丞东丒丟丂丗世七上(上丆丘东丅世业一丁:  true);
        }
        
        }
        
        this.丞不上上世丒万丐丛();
        this.专三下丑丐三世丑一();
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丐丁上世丒万万且丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丌世不下丑丏丙丛三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丏丕丘丟七丏世丌丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().丞丝三丑丘专丝丙丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丞一丒一万且丛上丏()));
        Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丂东上且丂下丛不丐(丙业与丙丗丝不丈东:  new System.Action<丙丏丈上丞上专丅与>(object:  this, method:  System.Void ClanStartGui_v2::丄丘七丈丞丘不丛世(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 丈丂丒丄丘丕丌上与)));
        this.chooseRegionPopup.下丅东丏不丒丐上东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丂丈丘三丒丈不专丘>(object:  this, method:  System.Void ClanStartGui_v2::丛丑丌与丟丂丑丙万(PGCompany.丂丈丘三丒丈不专丘 万且万且丑丗且丌丆)));
        ClanChangeRegionBannerController.三丂东丑上丅丞东丞(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丈下与丂丘丅丐与东(string 万且万且丑丗且丌丆)));
        this.丒不与丆七丄万丌丛();
    }
    private void 丈下与丂丘丅丐与东(string 万且万且丑丗且丌丆)
    {
        PGCompany.不东丏三丞丞东丕丙.丙七丅丏专丐丒丂七(上丏万丕丆七不与万:  万且万且丑丗且丌丆);
        this.chooseRegionPopup.SelectItemWithValue(丙业与丙丗丝不丈东:  万且万且丑丗且丌丆);
        this.不丈丑丙且且东丘丘 = true;
        this.丞东丒丟丂丗世七上(上丆丘东丅世业一丁:  true);
    }
    private void 丛丑丌与丟丂丑丙万(PGCompany.丂丈丘三丒丈不专丘 万且万且丑丗且丌丆)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        PGCompany.不东丏三丞丞东丕丙.丙七丅丏专丐丒丂七(上丏万丕丆七不与万:  万且万且丑丗且丌丆.GetStringValue());
        this.不丈丑丙且且东丘丘 = true;
        this.丞东丒丟丂丗世七上(上丆丘东丅世业一丁:  true);
    }
    private void OnDisable()
    {
        if(this.与丄与丁丟三与丕丆 != null)
        {
                this.StopCoroutine(routine:  this.与丄与丁丟三与丕丆);
            this.与丄与丁丟三与丕丆 = 0;
        }
        
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丞与丄不不丛业东丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丁丙丑世世丆丙上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丐业丑不一且丟且东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丞一丒一万且丛上丏()));
        Rilisoft.WebSocket.丛丗丟万丛一丝丅下.三丈丈世丌东世万专(丙业与丙丗丝不丈东:  new System.Action<丙丏丈上丞上专丅与>(object:  this, method:  System.Void ClanStartGui_v2::丄丘七丈丞丘不丛世(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 丈丂丒丄丘丕丌上与)));
        this.chooseRegionPopup.上丟丘不丘丝丅丞业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丂丈丘三丒丈不专丘>(object:  this, method:  System.Void ClanStartGui_v2::丛丑丌与丟丂丑丙万(PGCompany.丂丈丘三丒丈不专丘 万且万且丑丗且丌丆)));
        ClanChangeRegionBannerController.丁丟且丅丁世世丄丏(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丈下与丂丘丅丐与东(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanStartGui_v2::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
    }
    private void OnDestroy()
    {
        if(this.与丄与丁丟三与丕丆 != null)
        {
                this.StopCoroutine(routine:  this.与丄与丁丟三与丕丆);
            this.与丄与丁丟三与丕丆 = 0;
        }
        
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丞与丄不不丛业东丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丁丙丑世世丆丙上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丐业丑不一且丟且东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒不与丆七丄万丌丛()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丞一丒一万且丛上丏()));
        Rilisoft.WebSocket.丛丗丟万丛一丝丅下.三丈丈世丌东世万专(丙业与丙丗丝不丈东:  new System.Action<丙丏丈上丞上专丅与>(object:  this, method:  System.Void ClanStartGui_v2::丄丘七丈丞丘不丛世(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 丈丂丒丄丘丕丌上与)));
    }
    private void 丞一丒一万且丛上丏()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if((ClanStartGui_v2.<>c.<>9__46_0) == null)
        {
            goto label_6;
        }
        
        label_11:
        this.disabledUnHardUI.ForEach(action:  ClanStartGui_v2.<>c.<>9__46_0);
        return;
        label_6:
        ClanStartGui_v2.<>c.<>9__46_0 = new System.Action<UnityEngine.GameObject>(object:  ClanStartGui_v2.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStartGui_v2.<>c::万丏东丑丈丗丑七丞(UnityEngine.GameObject 七丞丙丒三丕且丌丟));
        if(this.disabledUnHardUI != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    private void 专三下丑丐三世丑一()
    {
        var val_4 = null;
        if((ClanStartGui_v2.<>c.<>9__47_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        this.disabledUnHardUI.ForEach(action:  ClanStartGui_v2.<>c.<>9__47_0);
        string val_1 = I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_1488");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.ClanCreateButtonText, 丕丗丘丑丛与丑业丒:  (val_1 == null) ? "" : (val_1));
        return;
        label_3:
        ClanStartGui_v2.<>c.<>9__47_0 = new System.Action<UnityEngine.GameObject>(object:  ClanStartGui_v2.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStartGui_v2.<>c::且上丅丗不东且丘丑(UnityEngine.GameObject 七丞丙丒三丕且丌丟));
        if(this.disabledUnHardUI != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private void 丙且世丈丏丏与七丒()
    {
        var val_3;
        if(this.与丄与丁丟三与丕丆 != null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 == false)
        {
                return;
        }
        
        this.与丄与丁丟三与丕丆 = this.StartCoroutine(routine:  this.下丘丅丌丙丅丅丘一());
    }
    private void 丌且七丙丑不丁丗下()
    {
        if(this.与丄与丁丟三与丕丆 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.与丄与丁丟三与丕丆);
        this.与丄与丁丟三与丕丆 = 0;
    }
    private System.Collections.IEnumerator 下丘丅丌丙丅丅丘一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanStartGui_v2.丄下一丞丌专丘万世();
    }
    private void 丒不与丆七丄万丌丛()
    {
        this.丁丐世丗丈丆丆万丟(专丘丘丕丅丙万不业:  this.丅丟丒丝万丕三专三());
        if(this.invitesTab.activeSelf == false)
        {
                return;
        }
        
        this.丑丁丗丗下与三丞丑();
    }
    private void 丄丘七丈丞丘不丛世(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 丈丂丒丄丘丕丌上与)
    {
        null = null;
        if((丈丂丒丄丘丕丌上与.专丕与丒丗丁丘专丟.Equals(value:  Rilisoft.WebSocket.业丛世业世不丄丐三.丁业上丟丈东丙下丟)) == false)
        {
                return;
        }
        
        if(this.七业下专一丕丞丐东.Count != 0)
        {
                return;
        }
        
        this.丞东丒丟丂丗世七上(上丆丘东丅世业一丁:  true);
    }
    private void 与丅丞丘丂专且世下()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchTabContainer, 丏业丟一东丂东丘丛:  true);
        this.丏一丒丌七丏东丑专();
        if(this.七业下专一丕丞丐东.Count != 0)
        {
                return;
        }
        
        System.DateTime val_2 = System.DateTime.Now;
        if((this.丌丗丌业丆丄下丅世 + 15) >= (丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_2.dateData})))
        {
                return;
        }
        
        this.丞东丒丟丂丗世七上(上丆丘东丅世业一丁:  true);
    }
    private void 丏丞丗丕上上世丑丙()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DescriptionLabel, 丕丗丘丑丛与丑业丒:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8885"));
    }
    private void 丏一丒丌七丏东丑专()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DescriptionLabel, 丕丗丘丑丛与丑业丒:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8803"));
    }
    private void 丌丈丐东丙专丕丙丑()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.invitesTab, 丏业丟一东丂东丘丛:  false);
    }
    public void BackToSearchTab()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = 0;
        this.丌丈丐东丙专丕丙丑();
        this.与丅丞丘丂专且世下();
    }
    private bool 丅丟丒丝万丕三专三()
    {
        System.Collections.Generic.HashSet<System.String> val_3 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().上丞东丌丐世与业丕();
        if(val_3 == null)
        {
                return (bool)(val_3.Count > 0) ? 1 : 0;
        }
        
        return (bool)(val_3.Count > 0) ? 1 : 0;
    }
    private void 丁丐世丗丈丆丆万丟(bool 专丘丘丕丅丙万不业)
    {
        专丘丘丕丅丙万不业 = 专丘丘丕丅丙万不业;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.invitesNotif, 丏业丟一东丂东丘丛:  专丘丘丕丅丙万不业);
    }
    internal void 丞不上上世丒万丐丛()
    {
        if(ClansTutorialController.上且世丘丝三丄丈丗() != false)
        {
                return;
        }
        
        ClansTutorialController.Instance.下丐丁丑丁下丘七不(业丝丛且丛专丝业丁:  5, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄());
    }
    public void ForceShowTutorial()
    {
        ClansTutorialController.Instance.下丐丁丑丁下丘七不(业丝丛且丛专丝业丁:  5, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄());
    }
    private void 东东丒七丞丘专业丗(UILabel 七丐丞丑丑丕世丙七, string 丕丗丘丑丛与丑业丒)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  七丐丞丑丑丕世丙七, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  七丐丞丑丑丕世丙七, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchForRegionIsEmptyGameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丞丘下丛东丙专且世(UILabel 七丐丞丑丑丕世丙七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  七丐丞丑丑丕世丙七, 丏业丟一东丂东丘丛:  false);
    }
    public void U_CreateClick()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = ClanStartGui_v2.<>c.<>9__64_1;
        if(val_6 == null)
        {
                System.Action val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action(object:  ClanStartGui_v2.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStartGui_v2.<>c::且丝丙丝丐下丈丂丏());
            ClanStartGui_v2.<>c.<>9__64_1 = val_6;
        }
        
        this.gameObject.SetActive(value:  false);
        ClanCreateGui.丌万丗与七丄丕不丁(丂丛丑东不丅丈一东:  0, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丈东专丕丂丈丆丂丕()), 不丘丘丝丅丁且丞丝:  val_2);
    }
    public void U_BackRequest()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ClansWindowGUI.三丞丆丝东且丒丆万 = true;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.丝东丐丝东三丈世丝();
    }
    internal void 丞东丒丟丂丗世七上(bool 上丆丘东丅世业一丁)
    {
        string val_16;
        System.DateTime val_1 = System.DateTime.Now;
        this.丌丗丌业丆丄下丅世 = 丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_1.dateData});
        this.丙且世丈丏丏与七丒();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchTabContainer, 丏业丟一东丂东丘丛:  true);
        if(this.searchToggleButton != 0)
        {
                this.searchToggleButton.value = true;
        }
        
        this.searchInput.value = System.String.alignConst;
        this.且丞丐丅丝丁丐不丛 = System.String.alignConst;
        this.searchInput.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.searchWrapGrid, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<ClansController>.Instance) != 0)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_16;
        }
        
        }
        
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        return;
        label_16:
        if(this.不丈丑丙且且东丘丘 == false)
        {
            goto label_17;
        }
        
        if(上丆丘东丅世业一丁 == false)
        {
            goto label_20;
        }
        
        PGCompany.丂丈丘三丒丈不专丘 val_12 = this.chooseRegionPopup.丕丟丐丈丐丄丌三丐();
        if(val_12 == null)
        {
            goto label_20;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        goto label_24;
        label_20:
        val_16 = 0;
        goto label_25;
        label_17:
        this.三丛丗一且丐丕三丅();
        return;
        label_24:
        val_16 = val_12.GetStringValue();
        label_25:
        this.专丕丗丆东丈万七业(万丅丝丈上丅丘丈丘:  val_16);
        this.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0348"));
    }
    public void U_SearchClansWithAnyRegion()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchForRegionIsEmptyGameObject, 丏业丟一东丂东丘丛:  false);
        this.不丈丑丙且且东丘丘 = true;
        this.丞东丒丟丂丗世七上(上丆丘东丅世业一丁:  false);
    }
    private void 专丕丗丆东丈万七业(string 万丅丝丈上丅丘丈丘)
    {
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.业下与三三丕丑丞丂(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丝丟丈丟三丞丗与三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().业丙丗丟丞丁丌丗不().丝一丏丞丌七丕世丕(万丅丝丈上丅丘丈丘:  万丅丝丈上丅丘丈丘);
    }
    private void 三丛丗一且丐丕三丅()
    {
        var val_3;
        DynamicWrapGrid val_13;
        DynamicWrapGrid val_14;
        val_13 = this;
        this.丏一丒丌七丏东丑专();
        if(this.丈丅三丛丈丗丏丟万 == false)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = this.七业下专一丕丞丐东.GetEnumerator();
        goto label_3;
        label_5:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        mem2[0] = 0;
        label_3:
        if(((-340014624) & 1) != 0)
        {
            goto label_5;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丈丅三丛丈丗丏丟万 = false;
        label_1:
        val_14 = 1152921504848912384;
        if(this.searchWrapGrid == 0)
        {
                return;
        }
        
        if(this.searchWrapGrid.gameObject == 0)
        {
                return;
        }
        
        int val_8 = this.七业下专一丕丞丐东.Count;
        if(val_8 >= 1)
        {
                val_14 = this.searchWrapGrid;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_14, 丏业丟一东丂东丘丛:  true);
            val_13 = this.searchWrapGrid;
            val_13.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_8.丄丆丗一丏丘业与丂(丗丏丟世万万丄与丁:  this.七业下专一丕丞丐东))), 业丛丛世上丈丘丄东:  false);
            return;
        }
        
        val_13 = this.searchWrapGrid;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_13, 丏业丟一东丂东丘丛:  false);
    }
    private void 丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)
    {
        var val_6;
        System.Collections.Generic.List<丑丏丄且丁且一专三> val_18;
        UILabel val_19;
        string val_20;
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        System.Collections.Generic.List<丑丏丄且丁且一专三> val_3 = null;
        val_18 = val_3;
        val_3 = new System.Collections.Generic.List<丑丏丄且丁且一专三>();
        this.丐七丈丐丛丄丙业万 = val_18;
        List.Enumerator<T> val_4 = 丑丞七丈且丟丈丞且.GetEnumerator();
        label_4:
        if(((-339744768) & 1) == 0)
        {
            goto label_2;
        }
        
        new ClanSearchGui.丑丏丄且丁且一专三() = new System.Object();
        .且丟丅丄丒丑丂丁世 = val_6.丐丏七丌丕丗业且上();
        this.丐七丈丐丛丄丙业万.Add(item:  new ClanSearchGui.丑丏丄且丁且一专三());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
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
        val_18 = System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_11.丄丆丗一丏丘业与丂(丗丏丟世万万丄与丁:  this.丐七丈丐丛丄丙业万)));
        this.searchWrapGrid.SetContent(三丏丑不业丏不丂丈:  val_18, 业丛丛世上丈丘丄东:  false);
        goto label_17;
        label_10:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchWrapGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        val_19 = this.searchInfoMessageLabel;
        val_20 = "Key_1528";
        goto label_23;
        label_11:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchWrapGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        val_19 = this.searchInfoMessageLabel;
        val_20 = "Key_1493";
        label_23:
        this.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  val_19, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_20));
        label_17:
        this.丈丅三丛丈丗丏丟万 = true;
    }
    private void 丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)
    {
        var val_4;
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        val_4 = null;
        val_4 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
        ClansWindowGUI.丆丕丝丒不丙且丐丗.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel);
    }
    private void 丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)
    {
        object val_8;
        System.Collections.Generic.List<丑丏丄且丁且一专三> val_9;
        val_8 = this;
        this.丈丅三丛丈丗丏丟万 = true;
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        System.Collections.Generic.List<丑丏丄且丁且一专三> val_3 = null;
        val_9 = val_3;
        val_3 = new System.Collections.Generic.List<丑丏丄且丁且一专三>();
        this.七业下专一丕丞丐东 = val_9;
        List.Enumerator<T> val_4 = 丑丞七丈且丟丈丞且.GetEnumerator();
        label_4:
        if(((-339339528) & 1) == 0)
        {
            goto label_2;
        }
        
        new ClanSearchGui.丑丏丄且丁且一专三() = new System.Object();
        .且丟丅丄丒丑丂丁世 = 0.丐丏七丌丕丗业且上();
        this.七业下专一丕丞丐东.Add(item:  new ClanSearchGui.丑丏丄且丁且一专三());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel);
        if(this.与丄与丁丟三与丕丆 != null)
        {
                this.StopCoroutine(routine:  this.与丄与丁丟三与丕丆);
            this.与丄与丁丟三与丕丆 = 0;
        }
        
        this.三丛丗一且丐丕三丅();
        if((System.Linq.Enumerable.Any<丞丂丘丒丟丞丑下丄>(source:  丑丞七丈且丟丈丞且)) == true)
        {
                return;
        }
        
        val_8 = this.searchForRegionIsEmptyGameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
    }
    private void 丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)
    {
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
    }
    public override void ShowJoinRequestDialogFromSearch(ClanSearchWrapGridItem 丞东下丙万丈不丘三)
    {
        this.业与丙一丙丞丝不丐 = 丞东下丙万丈不丘三;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.joinRequestDialogObj, 丏业丟一东丂东丘丛:  true);
    }
    public override void JoinClanFromSearch(string 丈丈丆丞丘东专万东)
    {
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丄专丑丝专万丌丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丁七七丙丒丌丛丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丄丆丑丝不不丒丘与().丞丌丝世丆业一东七(丄丒下业一不丈丝丘:  丈丈丆丞丘东专万东);
    }
    private void 丕专丛丟东丁丂上丘()
    {
        this.丈丅三丛丈丗丏丟万 = true;
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
    }
    private void 丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)
    {
        ClansWindowGUI val_9;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        val_9 = 一丐丗丁丞丆丅丟丄;
        this.丈丅三丛丈丗丏丟万 = true;
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丕专丛丟东丁丂上丘()));
        PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅世丂丁上专下丈丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丟丗丘丛丕丑七丈(int 丞丐丟三丌与丞上一, string 一丐丗丁丞丆丅丟丄)));
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
    public void U_ClearSearchInput()
    {
        this.searchInput.value = System.String.alignConst;
        this.OnSearchInputSubmit();
    }
    public void OnSearchInputSubmit()
    {
        if((System.String.op_Equality(a:  this.searchInput.value, b:  System.String.alignConst)) != false)
        {
                this.三丛丗一且丐丕三丅();
            this.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel);
            return;
        }
        
        this.丏丞丗丕上上世丑丙();
        this.且丞丐丅丝丁丐不丛 = this.searchInput.value;
        this.丞上丌丝丛上丐丝丆(丛丐一业业丐丕东七:  this.searchInput.value);
    }
    private void 丞上丌丝丛上丐丝丆(string 丛丐一业业丐丕东七)
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.searchWrapGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        this.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  this.searchInfoMessageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0348"));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丈丅不丝丙与丆丐三(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.丈一不丌丙七下丆丅.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丂丗业丘丌丗丞东且(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丒丕三东丅且下丆且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丌丕丕专丑下丅丞丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.业下与三三丕丑丞丂(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>>(object:  this, method:  System.Void ClanStartGui_v2::丄丐丆丟一三且丅丛(System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丑丞七丈且丟丈丞且)));
        PGCompany.Clans.Network.业三东丑丌丘七丞业.丝丟丈丟三丞丗与三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::丛一且丒丗业丐丝与(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().世丈丝七业丞丕业且().丝一丏丞丌七丕世丕(丕丛业且专专丆丆丆:  丛丐一业业丐丕东七);
    }
    public void OpenInvitesTab()
    {
        this.丐三丒丞上万一丙丟 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.searchTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.invitesTab, 丏业丟一东丂东丘丛:  true);
        this.丑丁丗丗下与三丞丑();
        this.业丕业专世丟丏业一();
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanStartGui_v2::BackToSearchTab()), 与且专丈不万东一万:  "Clans-CloseTabInvites");
    }
    private void 丑丁丗丗下与三丞丑()
    {
        var val_17;
        System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_23;
        System.Collections.Generic.HashSet<System.String> val_3 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().上丞东丌丐世与业丕();
        if(val_3 == null)
        {
                return;
        }
        
        if(this.丐三丒丞上万一丙丟 != null)
        {
                if(val_3.Count == this.丐三丒丞上万一丙丟.Count)
        {
                System.Collections.Generic.HashSet<System.String> val_6 = null;
            val_23 = val_6;
            val_6 = new System.Collections.Generic.HashSet<System.String>(collection:  val_3);
            if((val_6.SetEquals(other:  this.丐三丒丞上万一丙丟)) == true)
        {
                return;
        }
        
        }
        
        }
        
        this.丐三丒丞上万一丙丟 = new System.Collections.Generic.List<System.String>(collection:  val_3);
        this.丝世丗丆丄不丝丝丒 = false;
        System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_9 = null;
        val_23 = val_9;
        val_9 = new System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>();
        this.与丒下丕不一丒下丌 = val_23;
        if(this.丐三丒丞上万一丙丟.Count < 1)
        {
            goto label_26;
        }
        
        val_23 = 1152921504615739392;
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::业丕业专世丟丏业一()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.丏一与丏丛丘丆丅丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::业丕业专世丟丏业一()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丝丐丄丂丙丘丗丝(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
        List.Enumerator<T> val_15 = this.丐三丒丞上万一丙丟.GetEnumerator();
        label_17:
        if(((-337730592) & 1) == 0)
        {
            goto label_12;
        }
        
        System.Collections.Generic.List<System.String> val_21 = new System.Collections.Generic.List<System.String>();
        null.Add(item:  "cr");
        null.Add(item:  "mb");
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑().丛丐不丐丘丘万丒丂(丄丒下业一不丈丝丘:  val_17.丐丏七丌丕丗业且上(), 丟丐丟丂下专丅业丒:  null);
        goto label_17;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_26:
        this.业丕业专世丟丏业一();
    }
    private void 业丕业专世丟丏业一()
    {
        var val_3;
        丞丂丘丒丟丞丑下丄 val_7 = 0;
        if((this.丐三丒丞上万一丙丟 == null) || (this.丝世丗丆丄不丝丝丒 == true))
        {
            goto label_2;
        }
        
        this.丝世丗丆丄不丝丝丒 = true;
        List.Enumerator<T> val_1 = this.丐三丒丞上万一丙丟.GetEnumerator();
        goto label_11;
        label_12:
        PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_6 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
        if((val_6.丂丕万一丄一丂丗丒.TryGetValue(key:  val_3.丐丏七丌丕丗业且上(), value: out  val_7)) == false)
        {
            goto label_7;
        }
        
        if((this.与丒下丕不一丒下丌.Contains(item:  val_7)) == true)
        {
            goto label_11;
        }
        
        this.与丒下丕不一丒下丌.Add(item:  val_7);
        goto label_11;
        label_7:
        this.丝世丗丆丄不丝丝丒 = false;
        label_11:
        if(((-337475120) & 1) != 0)
        {
            goto label_12;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丝世丗丆丄不丝丝丒 != false)
        {
                PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::业丕业专世丟丏业一()));
            PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
            this.丗丏丅丑丆三万丛丂 = false;
        }
        
        UnityEngine.GameObject val_13 = this.invitesWrapGrid.gameObject;
        if(this.与丒下丕不一丒下丌.Count == 0)
        {
            goto label_25;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        val_13.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.invitesInfoMessageLabel);
        label_2:
        this.丄丗不丕丙丑东丑丆();
        return;
        label_25:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
        this.东东丒七丞丘专业丗(七丐丞丑丑丕世丙七:  this.invitesInfoMessageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1494"));
    }
    private void 业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)
    {
        var val_4;
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上丗三丈与万万丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::业丕业专世丟丏业一()));
        PGCompany.Clans.Network.丞丝世上丏与丂丒上.上不丑且世丅丕丛专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanStartGui_v2::业丟丞丒东一丄丗下(string 万且万且丑丗且丌丆)));
        if(this.丗丏丅丑丆三万丛丂 != false)
        {
                this.丗丏丅丑丆三万丛丂 = false;
            val_4 = null;
            val_4 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1528"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
            ClansWindowGUI.丆丕丝丒不丙且丐丗.丞丘下丛东丙专且世(七丐丞丑丑丕世丙七:  this.invitesInfoMessageLabel);
            this.业丕业专世丟丏业一();
            return;
        }
        
        this.丝世丗丆丄不丝丝丒 = true;
    }
    private void 丄丗不丕丙丑东丑丆()
    {
        this.invitesWrapGrid.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  new System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>(collection:  this.与丒下丕不一丒下丌))), 业丛丛世上丈丘丄东:  false);
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
    public void U_BackRequest_RequestWindow()
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
    private void 业下上丐丐丛丅世且()
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丒丁不丟丕丕丞丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.丟上三丕业丏三三丟(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanStartGui_v2::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌().丂且且丐不丕一丗丐(丄丒下业一不丈丝丘:  this.业与丙一丙丞丝不丐.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁(), 丄丙下丝丛丒七丂丘:  this.joinRequestMessageInput.value);
    }
    private void 丒上一丌专丛三丁丁()
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanStartGui_v2::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
        this.joinRequestSendButton.Pressed = false;
        this.joinRequestDialogObj.SetActive(value:  false);
    }
    private void 东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)
    {
        PGCompany.Clans.Network.不不业三丒与一万丄.丟丕专丛丏丕丗丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanStartGui_v2::丒上一丌专丛三丁丁()));
        PGCompany.Clans.Network.不不业三丒与一万丄.世丞丂一专丈业不丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Int32>(object:  this, method:  System.Void ClanStartGui_v2::东丐丒丙万丁上上三(int 丂七东不不丈一丐不, int 丂三丟丂丈丐丆丗丟)));
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
    private void 丄七丛丅专丑业丛业()
    {
        var val_3;
        PGCompany.PopupList val_9;
        var val_10;
        string val_11;
        val_9 = this;
        this.chooseRegionPopup.Clear();
        val_10 = null;
        val_10 = null;
        List.Enumerator<T> val_1 = PGCompany.不东丏三丞丞东丕丙.丞一丌丙不丄丝且丐.GetEnumerator();
        label_7:
        if(((-336060480) & 1) == 0)
        {
            goto label_5;
        }
        
        this.chooseRegionPopup.AddItemWithValue(丙业与丙丗丝不丈东:  val_3.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_11 = PGCompany.不东丏三丞丞东丕丙.不东丏丅不丌丄丝丝();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) != false)
        {
                val_11 = PGCompany.不东丏三丞丞东丕丙.丟与丄丒丝丗万丟丁();
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_11)) == false)
        {
                return;
        }
        
        val_9 = this.chooseRegionPopup;
        val_9.SelectItemWithValue(丙业与丙丗丝不丈东:  val_11);
    }
    public ClanStartGui_v2()
    {
        this.七业下专一丕丞丐东 = new System.Collections.Generic.List<丑丏丄且丁且一专三>();
        this.丝世丗丆丄不丝丝丒 = true;
        this.disabledUnHardUI = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this = new PGBehaviour();
    }
    private static ClanStartGui_v2()
    {
    
    }
    private void 丈东专丕丂丈丆丂丕()
    {
        this.gameObject.SetActive(value:  true);
    }

}
