using UnityEngine;
public class ClanWarUI : MonoBehaviour
{
    // Fields
    private static ClanWarUI <不丁丄七丛不丆丁丕>k__BackingField;
    internal static bool 丂丄万丑不丙丆七一;
    internal static bool 七丈且七七丘丛东上;
    private ClanWarMap clanWarMap;
    private UnityEngine.Camera mapCamera;
    private UnityEngine.Camera rootCamera;
    private ClanWarUIBottomButtons bottomButtons;
    private ClanWarCellInfoBigView bigCellInfo;
    private FortAssaultInfoUI smallFortAssaultInfoUI;
    private FortAssaultInfoUI bigFortAssaultInfoUI;
    private ClanWarCellInfoListView cellInfoListView;
    private UnityEngine.GameObject devPanel;
    private UnityEngine.GameObject devButton;
    private UILabel clanSilverCount;
    private UILabel clanShieldsCount;
    private UnityEngine.BoxCollider _tributeContBoxCollider;
    private UnityEngine.GameObject tributeTimerState;
    private UnityEngine.GameObject underSiegeState;
    private UnityEngine.GameObject collectTributeState;
    private UnityEngine.GameObject noTributeState;
    private UnityEngine.GameObject goblinUnderSiegeState;
    private UnityEngine.GameObject goblinNoUnderSiegeState;
    private UnityEngine.GameObject goblinNoIncomeState;
    private PGCompany.TimerUI _goblinTimerUnderSiege;
    private PGCompany.TimerUI _goblinTimerNoUnderSiege;
    private PGCompany.TimerUI _goblinTimerNoIncome;
    private PGCompany.TimerUI clanTributeTimer;
    private UILabel silverTributeReward;
    private UILabel silverTributeRewardBuff;
    private UnityEngine.GameObject silverTributeRewardBuffHolder;
    private UILabel shildsTributeReward;
    private PGCompany.TimerUI endWarTimer;
    private UnityEngine.Transform _bindedItemsHolder;
    private ClanWarRatingListUI clanWarRatingListUI;
    private System.Collections.Generic.List<ClanWarCameraSettings> cameraSettingsList;
    private ScrollViewHelper _scrollViewHelper;
    private PGCompany.ClanWarUIRewardsAnimator _rewardsAnimator;
    private UnityEngine.GameObject _touchBlocker;
    private PGCompany.ClanWarLogView _warLogView;
    private UITexture clanDivision;
    public ClanWarMapUI clanWarMapUI;
    internal static bool 东东丄丅丅丅丙七一;
    private static bool 丂丛丆专东丘丗丏不;
    internal static bool 上与丛三不世丄一上;
    private bool 一丛东丆七一下丈丑;
    private 丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 丂万丝丟丏丅丒业丛;
    private float 丕专专丝丞东专丗丌;
    private System.IDisposable 东三世丝丒三一丈丛;
    private System.IDisposable 万且下世业丑专七业;
    private 不上丌世万丁丝丏丆 不丂丁丏三东万上万;
    private readonly System.Collections.Generic.List<PGCompany.UI.BindedUI> 下不且不下丝上丄丅;
    private UnityEngine.GameObject 丗上丏丟丆专与丗丆;
    private ConnectionControl 丟丘世东丐丌丕丂丝;
    public float applayCameraSettingsSpeed;
    
    // Properties
    internal static ClanWarUI 丆丕丝丒不丙且丐丗 { get; set; }
    internal 不上丌世万丁丝丏丆 丗丕丒下丐丁丞丛七 { get; }
    internal UnityEngine.Camera 丙丏与丙七丝不丁丒 { get; }
    internal ClanWarRatingListUI 世丒世丙丗丟丅丌丌 { get; }
    internal ClanWarCellInfoBigView 丘丛丆丛丐丛且不不 { get; }
    internal static bool 丗丗七专专丕丈东丁 { get; set; }
    internal static bool 丅业东万丌丕上丌丄 { get; }
    private ConnectionControl 丙不丅丝丙专丕世丐 { get; }
    internal bool 东丟丞世丐丕丝万丄 { get; }
    
    // Methods
    internal static ClanWarUI 丑七不且上丗丁一世()
    {
        null = null;
        return (ClanWarUI)ClanWarUI.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    internal static void 丒且丒丗丗丟下丗丝(ClanWarUI 丙业与丙丗丝不丈东)
    {
        null = null;
        ClanWarUI.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 不上丌世万丁丝丏丆 丆丆丘且丑丅丝丟丙()
    {
        if(this.clanWarMap == null)
        {
                return (不上丌世万丁丝丏丆)this.clanWarMap;
        }
        
        return this.clanWarMap.丆丆丘且丑丅丝丟丙();
    }
    internal UnityEngine.Camera 世丅丟专丛丐丑丂与()
    {
        return (UnityEngine.Camera)this.mapCamera;
    }
    internal ClanWarRatingListUI 世丙世丄丗七下下世()
    {
        return (ClanWarRatingListUI)this.clanWarRatingListUI;
    }
    internal ClanWarCellInfoBigView 丅丌丅丝业七三三丑()
    {
        return (ClanWarCellInfoBigView)this.bigCellInfo;
    }
    internal static void 丙与丒丘且丈专丆丝(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        ClanWarUI.丂丛丆专东丘丗丏不 = 丙业与丙丗丝不丈东;
    }
    internal static bool 丘七上丏业丟专专丈()
    {
        return false;
    }
    private void Awake()
    {
        ClanWarUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        与丂丅三丂且不不与.丑七不且上丗丁一世().丞丝三丑丘专丝丙丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::上且丆丛业且丞丟业()));
        ClansTutorialController.Instance.丐业一三专世丁丏世(业丝丛且丛专丝业丁:  3, 丈东丘丏与丌东东下:  this.transform);
    }
    private void OnDestroy()
    {
        ClanWarUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
        this.clanWarMap.丒专一与丌丝丑世丞(丙业与丙丗丝不丈东:  new System.Action<不上丌世万丁丝丏丆>(object:  this, method:  System.Void ClanWarUI::下下丂丗丌上七东丕(不上丌世万丁丝丏丆 丞丘丈丝丑丟七丞不)));
        PGCompany.ClanWarController.世世丙万且丁东一丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarController.不丁丐丈一且丅与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarDevSelectClanButton.丐世且丂丘且丄丁东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丛一丄与万丒丌丌丁()));
        PGCompany.ClanWarProgressController.与丄世上丏与且业东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丌丝丞丟丟丕不丙丆()));
        System.Action val_6 = new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::一丑且上丑丙丁丄丟());
        PGCompany.ClanWarProgressController.业万不丁丞丆一丏丆(丙业与丙丗丝不丈东:  val_6);
        val_6 = new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void ClanWarUI::且下丆丆丙专下丑丅(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞));
        PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  val_6);
        PGCompany.ClanWarController.东丝丞丘一丂丆丘七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::专丈不丘丛丅七万丙()));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::专七丗一且一丞世专()));
    }
    private void Start()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devButton, 丏业丟一东丂东丘丛:  false);
        this.丕专专丝丞东专丗丌 = this._scrollViewHelper.scrollDelta;
        this.下与丞三丅丛丄七丕();
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        if(ClanWarUI.丑七不且上丗丁一世() == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_4 = ClanWarUI.丑七不且上丗丁一世().gameObject;
        if(val_4 != null)
        {
                return val_4.activeInHierarchy;
        }
        
        return val_4.activeInHierarchy;
    }
    internal void 下与丞三丅丛丄七丕()
    {
        System.Collections.Generic.IEnumerable<TSource> val_25;
        var val_26;
        System.Func<七丈丗不丞丈丝丙七, System.String> val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_34;
        var val_35;
        this.rootCamera.gameObject.SetActive(value:  true);
        this.mapCamera.gameObject.SetActive(value:  true);
        if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世() != 0)
        {
                Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().丆世与丑丆丅丐万且();
        }
        
        丞丂丘丒丟丞丑下丄 val_8 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_8 == null)
        {
            goto label_10;
        }
        
        val_25 = val_8.丐丂丄丏下七与一丌();
        if(val_25 != null)
        {
            goto label_11;
        }
        
        label_10:
        System.Collections.Generic.List<七丈丗不丞丈丝丙七> val_10 = null;
        val_25 = val_10;
        val_10 = new System.Collections.Generic.List<七丈丗不丞丈丝丙七>();
        label_11:
        val_26 = null;
        val_26 = null;
        val_28 = ClanWarUI.<>c.<>9__66_0;
        if(val_28 == null)
        {
                System.Func<七丈丗不丞丈丝丙七, System.String> val_11 = null;
            val_28 = val_11;
            val_11 = new System.Func<七丈丗不丞丈丝丙七, System.String>(object:  ClanWarUI.<>c.__il2cppRuntimeField_static_fields, method:  System.String ClanWarUI.<>c::世丑专丙丕丙丙上丕(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
            ClanWarUI.<>c.<>9__66_0 = val_28;
        }
        
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  System.Linq.Enumerable.Select<七丈丗不丞丈丝丙七, System.String>(source:  val_10, selector:  val_11));
        val_29 = null;
        val_29 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_30 = null;
            val_30 = null;
            SetActive(value:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  MainMenuHeroCamera.丑七不且上丗丁一世(), 丏业丟一东丂东丘丛:  false);
        }
        
        if((Rilisoft.Singleton<NotificationMessageController>.Instance) != 0)
        {
                Rilisoft.Singleton<NotificationMessageController>.Instance.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  7, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = false, isViewd = false});
        }
        
        this.gameObject.SetActive(value:  true);
        this.clanWarMap.transform.parent.gameObject.SetActive(value:  true);
        this.bigCellInfo.丆世与丑丆丅丐万且(与丑丑丑丂丛一丝一:  false);
        this.cellInfoListView.ResetScroll();
        this.万下丑丑万一丕丝丟();
        this.ApplayCameraSettings();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devPanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devButton, 丏业丟一东丂东丘丛:  false);
        val_31 = null;
        val_31 = null;
        if(ClanWarUI.丂丄万丑不丙丆七一 != true)
        {
                val_31 = null;
            if(ClanWarUI.七丈且七七丘丛东上 != true)
        {
                System.ValueTuple<PGCompany.丟与丞丗丌丂万丕丝, System.Boolean> val_22 = ClanWarEventBanner.丐专丟丏丑且与东下();
            val_31 = null;
        }
        
        }
        
        val_31 = null;
        if(ClanWarUI.丂丄万丑不丙丆七一 != false)
        {
                val_34 = null;
            ClanWarUI.丂丄万丑不丙丆七一 = false;
            ClanWarUI.七丈且七七丘丛东上 = false;
            this.U_GoToFortAttack();
            val_35 = null;
        }
        
        val_35 = null;
        if(ClanWarUI.七丈且七七丘丛东上 != false)
        {
                val_35 = null;
            ClanWarUI.丂丄万丑不丙丆七一 = false;
            ClanWarUI.七丈且七七丘丛东上 = false;
            this.U_GoToFortDefence();
        }
        
        Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丛丞丈丐丏七丗上东();
        丌丅且丗七丘丅丛丑.丌业三专丞丆万丏丁(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClanWarUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
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
    public void U_ShowTutorialInfo()
    {
        ClansTutorialController.Instance.下丐丁丑丁下丘七不(业丝丛且丛专丝业丁:  3, 丈东丘丏与丌东东下:  this.transform);
    }
    internal void 万万丄丌与丐丘东三()
    {
        this.rootCamera.gameObject.SetActive(value:  false);
        this.mapCamera.gameObject.SetActive(value:  false);
        this.gameObject.SetActive(value:  false);
        this.clanWarMap.transform.parent.gameObject.SetActive(value:  false);
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClanWarUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
    }
    internal void 丆世与丑丆丅丐万且()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        this.rootCamera.gameObject.SetActive(value:  false);
        this.mapCamera.gameObject.SetActive(value:  false);
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丝丑丛万丟丝三上世();
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void ClanWarUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
        val_13 = null;
        val_13 = null;
        val_14 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_15 = null;
            SetActive(value:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  MainMenuHeroCamera.丑七不且上丗丁一世(), 丏业丟一东丂东丘丛:  true);
            this.gameObject.SetActive(value:  false);
            this.clanWarMap.transform.parent.gameObject.SetActive(value:  false);
            MainMenuController.丄丞丁丈与业上丞丟.丐丐世三丆东丆丌丛();
            return;
        }
        
        val_16 = null;
        MainMenuController.下且丄丝丘丝丈上丒 = true;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
    }
    internal void 丛一丄与万丒丌丌丁()
    {
        this.万下丑丑万一丕丝丟();
        this.ApplayCameraSettings();
    }
    internal void 万下丑丑万一丕丝丟()
    {
        this.clanWarMap.Init();
        this.且丒丏万三丟且丞丝();
        this.丌丝丞丟丟丕不丙丆();
        this.丗业丗丁且七丐三丛();
        this.与东丘丆丘七丒丝不();
        this.丌丄丘且丑丏专丄业();
    }
    internal void 丌世七万丘万世丐不()
    {
        this.cellInfoListView.丅丘丝丗丂丑丈丂丐();
    }
    internal void 丄不丕丛丌丞三东丁()
    {
        this.clanWarMap.Init();
        this.且丒丏万三丟且丞丝();
        this.丌丝丞丟丟丕不丙丆();
        this.丗业丗丁且七丐三丛();
        this.与东丘丆丘七丒丝不();
        this.丌丄丘且丑丏专丄业();
    }
    private void 专丈不丘丛丅七万丙()
    {
        var val_2 = null;
        if(ClanWarUI.丈丐丞丐上丑且丕万() == false)
        {
                return;
        }
        
        this.丆世与丑丆丅丐万且();
    }
    private void 丌丄丘且丑丏专丄业()
    {
        object val_7;
        ClansController val_1 = Rilisoft.Singleton<ClansController>.Instance;
        丞丂丘丒丟丞丑下丄 val_2 = val_1.丞丗丑丈一丅丗丌丟();
        if(val_2 != null)
        {
                val_7 = val_2.世丝丌一且丝专丑丛().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_7 = 0;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.clanDivision, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  val_1, arg0:  val_7)));
    }
    private void 与东丘丆丘七丒丝不()
    {
        ScrollViewHelper val_5;
        float val_6;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.一丏不三且丆专东东>(且下丕七丙丗丄不七:  2)) == null)
        {
            goto label_2;
        }
        
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.smallFortAssaultInfoUI, 丏业丟一东丂东丘丛:  false);
        val_5 = this._scrollViewHelper;
        if(val_5 == null)
        {
            goto label_12;
        }
        
        val_6 = 0f;
        goto label_6;
        label_2:
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  2)) < 1)
        {
            goto label_8;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.smallFortAssaultInfoUI, 丏业丟一东丂东丘丛:  true);
        this.smallFortAssaultInfoUI.Setup();
        val_5 = this._scrollViewHelper;
        if(val_5 == null)
        {
            goto label_12;
        }
        
        val_6 = this.丕专专丝丞东专丗丌;
        label_6:
        this._scrollViewHelper.scrollDelta = val_6;
        return;
        label_12:
    }
    private void 丌丝丞丟丟丕不丙丆()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanSilverCount, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "ClanSilver"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanShieldsCount, 丕丗丘丑丛与丑业丒:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().下上东丟丟世世且丄(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()));
    }
    private void 三七世丛丘丂专丘三()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.endWarTimer)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance)) == false)
        {
                return;
        }
        
        this.endWarTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    private void 且万一下丝七与万七()
    {
        System.Action val_2 = new System.Action(object:  this, method:  System.Void ClanWarUI::丗业丗丁且七丐三丛());
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  val_2.丗世与专丝丄下丝丟(丒丏下万世七丆上不:  val_2));
    }
    private System.Collections.IEnumerator 丗世与专丝丄下丝丟(System.Action 丒丏下万世七丆上不)
    {
        .丒丏下万世七丆上不 = 丒丏下万世七丆上不;
        return (System.Collections.IEnumerator)new ClanWarUI.七丕丌丝且下不上三(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丗业丗丁且七丐三丛()
    {
        var val_19;
        object val_46;
        PGCompany.TimerUI val_47;
        var val_50;
        val_46 = this;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.collectTributeState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.underSiegeState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tributeTimerState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noTributeState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goblinUnderSiegeState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goblinNoUnderSiegeState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goblinNoIncomeState, 丏业丟一东丂东丘丛:  false);
        if(this._tributeContBoxCollider != 0)
        {
                this._tributeContBoxCollider.enabled = false;
        }
        
        val_47 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐不业一业丁丞世丏();
        int val_4 = 一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与();
        if(val_4 < 1)
        {
            goto label_10;
        }
        
        if(val_47 == 1)
        {
            goto label_11;
        }
        
        if(val_47 != 2)
        {
            goto label_12;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goblinNoIncomeState, 丏业丟一东丂东丘丛:  true);
        val_47 = this._goblinTimerNoIncome;
        if(val_47 == 0)
        {
                return;
        }
        
        val_47 = this._goblinTimerNoIncome;
        goto label_60;
        label_10:
        if(this._tributeContBoxCollider != 0)
        {
                this._tributeContBoxCollider.enabled = true;
        }
        
        PGCompany.ClanWarController val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        丞丂丘丒丟丞丑下丄 val_9 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_9 == null)
        {
            goto label_24;
        }
        
        if(val_7 != null)
        {
            goto label_71;
        }
        
        label_72:
        label_71:
        if((val_7.丙丏丌不丒一一丒上(丄丒下业一不丈丝丘:  val_9.业丐丐三丕一丗丛丁()).Count) == 0)
        {
            goto label_31;
        }
        
        if(val_47 > 4)
        {
                return;
        }
        
        var val_46 = 106032504 + (val_3) << 2;
        val_46 = val_46 + 106032504;
        goto (106032504 + (val_3) << 2 + 106032504);
        label_54:
        if(((-2143146032) & 1) == 0)
        {
            goto label_35;
        }
        
        ConfiguredValueTaskAwaiter val_20 = val_19.GetAwaiter();
        List.Enumerator<T> val_21 = val_20._value._obj.GetEnumerator();
        goto label_42;
        label_44:
        string val_22 = val_19.丐丏七丌丕丗业且上();
        Rilisoft.OfferItemType val_23 = val_22.Type;
        if(val_23 == 1200)
        {
            goto label_39;
        }
        
        if(val_23 != 1220)
        {
            goto label_42;
        }
        
        int val_47 = 0;
        val_47 = val_22.Count + val_47;
        goto label_42;
        label_39:
         = val_22.Count + ;
        label_42:
        if(((-2143146080) & 1) != 0)
        {
            goto label_44;
        }
        
         =  + 1;
        mem2[0] = 589;
        val_50 = ;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || ((1152921536823439184 + ((0 + 1)) << 2) != 589))
        {
            goto label_51;
        }
        
        var val_50 = 0;
        val_50 = val_50 ^ ( >> 31);
         =  + val_50;
        goto label_54;
        label_51:
        if( == 0)
        {
            goto label_54;
        }
        
        goto label_54;
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goblinUnderSiegeState, 丏业丟一东丂东丘丛:  true);
        val_47 = this._goblinTimerUnderSiege;
        if(val_47 == 0)
        {
                return;
        }
        
        val_47 = this._goblinTimerUnderSiege;
        goto label_60;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goblinNoUnderSiegeState, 丏业丟一东丂东丘丛:  true);
        val_47 = this._goblinTimerNoUnderSiege;
        if(val_47 == 0)
        {
                return;
        }
        
        val_47 = this._goblinTimerNoUnderSiege;
        label_60:
        val_47.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_4, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ClanWarUI::丗业丗丁且七丐三丛()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        return;
        label_31:
        val_46 = this.noTributeState;
        goto label_70;
        label_24:
        if(val_7 != null)
        {
            goto label_71;
        }
        
        goto label_72;
        label_70:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  null, 丏业丟一东丂东丘丛:  true);
        return;
        label_35:
         =  + 1;
        mem2[0] = 614;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_95;
        }
        
        if(( == 0) || ((1152921536823439184 + ((0 + 1)) << 2) == 614))
        {
            goto label_104;
        }
        
        label_103:
        label_104:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.silverTributeReward, 丕丗丘丑丛与丑业丒:  null);
        int val_44 = (PGCompany.万丞丘与丕丞下万丌.丐丝不七与丑且丟丝(丙业与丙丗丝不丈东:  null, 三丅丘上丞一丙丑业:  1)) - ;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.silverTributeRewardBuffHolder, 丏业丟一东丂东丘丛:  (val_44 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.silverTributeRewardBuff, 丕丗丘丑丛与丑业丒:  val_44);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.shildsTributeReward, 丕丗丘丑丛与丑业丒:  val_47);
        return;
        label_95:
        if( != 0)
        {
            goto label_103;
        }
        
        goto label_104;
    }
    private void OnEnable()
    {
        var val_19;
        var val_20;
        var val_21;
        this.clanWarMap.丐丕世万七丌丄丄丟(丙业与丙丗丝不丈东:  new System.Action<不上丌世万丁丝丏丆>(object:  this, method:  System.Void ClanWarUI::下下丂丗丌上七东丕(不上丌世万丁丝丏丆 丞丘丈丝丑丟七丞不)));
        PGCompany.ClanWarController.业万万且专丂丙上丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarController.丒丛三且丏七丙丄丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarDevSelectClanButton.下丒东丏专丏丌丙业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丛一丄与万丒丌丌丁()));
        PGCompany.ClanWarProgressController.丈丕丝东丝丟丐世万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丌丝丞丟丟丕不丙丆()));
        PGCompany.ClanWarProgressController.丐三且丝丒丄丑丙丟(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::一丑且上丑丙丁丄丟()));
        PGCompany.ClanWarController.丙业丛丝世丅丏丈丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::专丈不丘丛丅七万丙()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::专七丗一且一丞世专()));
        PGCompany.ItemExpiryController.丐丐丞丒下丙丟丂万(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void ClanWarUI::且下丆丆丙专下丑丅(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)));
        一丅三东丑丗丅丗丝.世丝丄丂万丐丑丁下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::且万一下丝七与万七()));
        val_19 = null;
        val_19 = null;
        if(ClanWarUI.上与丛三不世丄一上 != false)
        {
                UnityEngine.Coroutine val_12 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  2, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  public System.Void ClanWarUI::U_GiveTributeRewards()));
            val_20 = null;
            val_20 = null;
            ClanWarUI.上与丛三不世丄一上 = false;
        }
        
        this.三七世丛丘丂专丘三();
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanWarUI::U_GoToLobby()), 与且专丈不万东一万:  System.String.Format(format:  "ClanWarUi_{0}", arg0:  this.gameObject.name));
        val_21 = null;
        val_21 = null;
        if(ClanWarUI.东东丄丅丅丅丙七一 == false)
        {
                return;
        }
        
        ClanWarUI.东东丄丅丅丅丙七一 = false;
        PGCompany.丂丘丞丂丏七丁丄不.一丑且上丑丙丁丄丟();
    }
    private void OnDisable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._touchBlocker, 丏业丟一东丂东丘丛:  false);
        this.clanWarMap.丒专一与丌丝丑世丞(丙业与丙丗丝不丈东:  new System.Action<不上丌世万丁丝丏丆>(object:  this, method:  System.Void ClanWarUI::下下丂丗丌上七东丕(不上丌世万丁丝丏丆 丞丘丈丝丑丟七丞不)));
        PGCompany.ClanWarController.七不丆不与世世丈与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarController.世世丙万且丁东一丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarController.不丁丐丈一且丅与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丄不丕丛丌丞三东丁()));
        PGCompany.ClanWarDevSelectClanButton.丐世且丂丘且丄丁东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丛一丄与万丒丌丌丁()));
        PGCompany.ClanWarProgressController.与丄世上丏与且业东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::丌丝丞丟丟丕不丙丆()));
        PGCompany.ClanWarProgressController.业万不丁丞丆一丏丆(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::一丑且上丑丙丁丄丟()));
        一丅三东丑丗丅丗丝.丄丌丗丙三世丞丕三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::且万一下丝七与万七()));
        PGCompany.ClanWarController.东丝丞丘一丂丆丘七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::专丈不丘丛丅七万丙()));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUI::专七丗一且一丞世专()));
        var val_13 = 0;
        val_13 = val_13 + 1;
        this.东三世丝丒三一丈丛.Dispose();
        if(this.万且下世业丑专七业 == null)
        {
                return;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        this.万且下世业丑专七业.Dispose();
    }
    private void Update()
    {
        var val_4;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟()) <= 0)
        {
                if(FriendsController.丝丗专上三不丄丑丑() >= 1)
        {
                this.专丈不丘丛丅七万丙();
        }
        
        }
        
        if(this.一丛东丆七一下丈丑 == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(PGCompany.ClanLootBoxRewardUI.七丂丑七丑世丂不丒 != false)
        {
                return;
        }
        
        this.一丛东丆七一下丈丑 = false;
        丌丅且丗七丘丅丛丑.丏丂专丄七且不丌丛();
    }
    public void U_GoToLobby()
    {
        null = null;
        Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 = true;
        this.丆世与丑丆丅丐万且();
    }
    public void U_OpenDevPanel()
    {
    
    }
    public void U_CloseDevPanel()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devPanel, 丏业丟一东丂东丘丛:  false);
    }
    public void TrySelectCell(UnityEngine.Vector3 一东且与下丞专丙上)
    {
        float val_7;
        float val_8;
        float val_9;
        ClanWarMap val_10;
        var val_14;
        val_7 = 一东且与下丞专丙上.z;
        val_8 = 一东且与下丞专丙上.y;
        val_9 = 一东且与下丞专丙上.x;
        val_10 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
        {
                val_14 = 1152921504850403328;
        }
        else
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            val_14 = 1152921504850403328;
            val_9 = val_3.x;
            val_8 = val_3.y;
            val_7 = val_3.z;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7});
        System.Nullable<DiscreteVector2> val_5 = this.一上世下业丐业丟东(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        if(((-2141891728) & 1) == 0)
        {
                return;
        }
        
        val_10 = this.clanWarMap;
        bool val_6 = val_10.七丞万丅一丄丛丛丝(业丄世世一世三与丝:  new System.Nullable<DiscreteVector2>() {HasValue = false});
    }
    public void TryPressCell(UnityEngine.Vector3 一东且与下丞专丙上)
    {
        float val_7;
        float val_8;
        float val_9;
        ClanWarMap val_10;
        var val_14;
        val_7 = 一东且与下丞专丙上.z;
        val_8 = 一东且与下丞专丙上.y;
        val_9 = 一东且与下丞专丙上.x;
        val_10 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
        {
                val_14 = 1152921504850403328;
        }
        else
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            val_14 = 1152921504850403328;
            val_9 = val_3.x;
            val_8 = val_3.y;
            val_7 = val_3.z;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7});
        System.Nullable<DiscreteVector2> val_5 = this.一上世下业丐业丟东(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        if(((-2141771536) & 1) == 0)
        {
                return;
        }
        
        val_10 = this.clanWarMap;
        bool val_6 = val_10.万丅上世丌不丞丙三(业丄世世一世三与丝:  new System.Nullable<DiscreteVector2>() {HasValue = false});
    }
    public void UnpressCell()
    {
        bool val_1 = this.clanWarMap.万丅上世丌不丞丙三(业丄世世一世三与丝:  new System.Nullable<DiscreteVector2>() {HasValue = false});
    }
    internal System.Nullable<DiscreteVector2> 一上世下业丐业丟东(UnityEngine.Vector2 专世丐丆丗丙万七下)
    {
        float val_3;
        float val_4;
        var val_16;
        System.Func<UnityEngine.RaycastHit, System.Boolean> val_18;
        var val_20;
        System.Func<UnityEngine.RaycastHit, System.Single> val_22;
        UnityEngine.Object val_23;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专世丐丆丗丙万七下.x, y = 专世丐丆丗丙万七下.y});
        UnityEngine.Ray val_2 = this.mapCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_16 = null;
        val_16 = null;
        val_18 = ClanWarUI.<>c.<>9__94_0;
        if(val_18 == null)
        {
                System.Func<UnityEngine.RaycastHit, System.Boolean> val_6 = null;
            val_18 = val_6;
            val_6 = new System.Func<UnityEngine.RaycastHit, System.Boolean>(object:  ClanWarUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarUI.<>c::万丛丅丏万专上丆丑(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂));
            ClanWarUI.<>c.<>9__94_0 = val_18;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = ClanWarUI.<>c.<>9__94_1;
        if(val_22 == null)
        {
                System.Func<UnityEngine.RaycastHit, System.Single> val_8 = null;
            val_22 = val_8;
            val_8 = new System.Func<UnityEngine.RaycastHit, System.Single>(object:  ClanWarUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Single ClanWarUI.<>c::丆丄世且丝业丄不丞(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂));
            ClanWarUI.<>c.<>9__94_1 = val_22;
        }
        
        UnityEngine.RaycastHit val_10 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.RaycastHit>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.RaycastHit, System.Single>(source:  System.Linq.Enumerable.Where<UnityEngine.RaycastHit>(source:  UnityEngine.Physics.RaycastAll(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, m_Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, maxDistance:  1000f), predicate:  val_6), keySelector:  val_8));
        val_23;
        if(val_4 == 0)
        {
                return 0;
        }
        
        val_23 = val_4.GetComponent<PGCompany.HexagonFieldTile>();
        if(val_23 == 0)
        {
                return 0;
        }
        
        DiscreteVector2 val_15 = val_23.Position;
        return 0;
    }
    private void 且下丆丆丙专下丑丅(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)
    {
        List.Enumerator<T> val_1 = 丑七不与丛丆一丂丞.GetEnumerator();
        label_5:
        if(((-2141267672) & 1) == 0)
        {
            goto label_2;
        }
        
        if((0.丐丏七丌丕丗业且上().业上丙丞丐丄丆丅七().Equals(value:  "cw_tribute_auto")) == false)
        {
            goto label_5;
        }
        
        this.丗业丗丁且七丐三丛();
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 下下丂丗丌上七东丕(不上丌世万丁丝丏丆 丞丘丈丝丑丟七丞不)
    {
        var val_5;
        var val_6;
        this.cellInfoListView.丘一丒丞上万上且丈(世丕丅丄丕专丑丑丆:  丞丘丈丝丑丟七丞不);
        if((this.cellInfoListView.与丁且丝丆丝与万上(世丕丅丄丕专丑丑丆:  丞丘丈丝丑丟七丞不)) == false)
        {
            goto label_8;
        }
        
        if(this.不丂丁丏三东万上万 == 丞丘丈丝丑丟七丞不)
        {
            goto label_5;
        }
        
        if(this.bigCellInfo.丟丛丕世三丙东丈丐 == true)
        {
            goto label_8;
        }
        
        goto label_9;
        label_5:
        if(this.bigCellInfo.丟丛丕世三丙东丈丐 == false)
        {
            goto label_8;
        }
        
        this.丂丘一丐七且丕世丅();
        goto label_9;
        label_8:
        DiscreteVector2 val_2 = 丞丘丈丝丑丟七丞不.丞丑丟下丘三下专不();
        if(( & 1) == 0)
        {
            goto label_12;
        }
        
        if(((-2141106512) & 1) == 0)
        {
            goto label_13;
        }
        
        val_5 = 0;
        bool val_4 = DiscreteVector2.丌且丕丐丛上丅且丁(万且丂丘丌业七与丞:  new DiscreteVector2() {_x = this.clanWarMap.<丗世世一丄东丆丘业>k__BackingField.丐丏七丌丕丗业且上(), _y = this.clanWarMap.<丗世世一丄东丆丘业>k__BackingField.丐丏七丌丕丗业且上()}, 丅专丌丅业与丏丞下:  new DiscreteVector2() {_x = val_2._x, _y = val_2._y});
        goto label_15;
        label_12:
        val_6 = 0;
        val_5 = 1;
        goto label_15;
        label_13:
        val_5 = 1;
        val_6 = 1;
        label_15:
        var val_5 = val_6 & 1;
        this.bigCellInfo.下与丞三丅丛丄七丕(丞丘丈丝丑丟七丞不:  丞丘丈丝丑丟七丞不, 与丑丑丑丂丛一丝一:  true, 丞丈丌且东丆丅丗万:  new System.Nullable<System.Boolean>() {HasValue = false});
        label_9:
        this.bottomButtons.丈且东丑丂且万丒丅(丌丝万上丅丒一丈丘:  丞丘丈丝丑丟七丞不);
        this.不丂丁丏三东万上万 = 丞丘丈丝丑丟七丞不;
    }
    private void 且丒丏万三丟且丞丝()
    {
        this.cellInfoListView.丈且东丑丂且万丒丅(丆丘业上下丙丏万与:  this.clanWarMap.丒与丂业丆三丞上下);
    }
    internal T 丞且丞丄丗专业丘丁<T>(UnityEngine.GameObject 丑且不丕与专丄业丙)
    {
        var val_12;
        System.Collections.Generic.List<PGCompany.UI.BindedUI> val_13;
        UnityEngine.Object val_14;
        val_12 = __RuntimeMethodHiddenParam;
        val_13 = this;
        val_14 = 0;
        if(丑且不丕与专丄业丙 == 0)
        {
                return (PGCompany.ClanWarCellHeader)val_14;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        val_14 = 0;
        if(val_2 == 0)
        {
                return (PGCompany.ClanWarCellHeader)val_14;
        }
        
        val_14 = val_2;
        if(val_14 == 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_2);
            val_14 = 0;
            return (PGCompany.ClanWarCellHeader)val_14;
        }
        
        val_14.丌丟丄业且三丛丕丄().SetParent(p:  this._bindedItemsHolder);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        val_14.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_14.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_12 = val_14.丌丟丄业且三丛丕丄();
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_12.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        val_13 = this.下不且不下丝上丄丅;
        val_13.Add(item:  val_14);
        return (PGCompany.ClanWarCellHeader)val_14;
    }
    internal void 丁丛不与七东下一丛<T>(T 下丛丘专丌丟且与丒)
    {
        if(下丛丘专丌丟且与丒 == 0)
        {
                return;
        }
        
        if((this.下不且不下丝上丄丅.Contains(item:  下丛丘专丌丟且与丒)) == false)
        {
                return;
        }
        
        bool val_3 = this.下不且不下丝上丄丅.Remove(item:  下丛丘专丌丟且与丒);
        丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  下丛丘专丌丟且与丒.gameObject);
    }
    private void 丆不七世丞专专且下(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        PGCompany.丆一一丂世七丏且丝 val_1 = 万不且且丛丆东丒业.不业丙丒丂丞下丆丙();
    }
    public void U_GatherSquad()
    {
        this.CreateClanSquad();
    }
    public void U_GoSolo()
    {
        this.ConnectToMapSolo();
    }
    private ConnectionControl 丁丒丗丞丂丏业业丗()
    {
        UnityEngine.GameObject val_10;
        if(this.丟丘世东丐丌丕丂丝 != 0)
        {
                return (ConnectionControl)this.丟丘世东丐丌丕丂丝;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "ConnectPanel");
        if(val_2 != null)
        {
                val_2 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_10);
        this.丗上丏丟丆专与丗丆 = val_3;
        val_3.transform.SetParent(parent:  this.transform.parent, worldPositionStays:  false);
        this.丗上丏丟丆专与丗丆.SetActive(value:  false);
        ConnectionControl val_8 = this.gameObject.AddComponent<ConnectionControl>();
        this.丟丘世东丐丌丕丂丝 = val_8;
        val_8.SetConnectPanel(丛丘下丗业丂一且业:  this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>());
        return (ConnectionControl)this.丟丘世东丐丌丕丂丝;
    }
    public void ConnectToMapSolo()
    {
        ClanWarMap val_33;
        var val_34;
        .丝且与丝丒丟万丁专 = this;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
        {
                val_33 = this;
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  this.clanWarMap.丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘());
        }
        else
        {
                val_33 = this.clanWarMap;
        }
        
        PGCompany.GameTaskActionSettings val_11 = mem[this.clanWarMap].丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘().下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_11.GameMode == 27)
        {
                string val_14 = mem[this.clanWarMap].丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘().下丁丙一丄丈不不丁();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_14)) != false)
        {
                PGCompany.一丝丐丕丒丛专七丄.丗丑丅下丘世丆三丄(丟丙丈丄丈丈丙丆三:  val_14);
        }
        
        }
        
        PGCompany.丁下丒丕丆下丂丆丌 val_17 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万();
        PGCompany.GameTaskActionSettings val_20 = val_17.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  val_20.GameMode);
        .专丗万丟与东丟且专 = 0;
        PGCompany.GameTaskActionSettings val_23 = val_17.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if((System.String.IsNullOrEmpty(value:  val_23.Map)) != true)
        {
                val_34 = null;
            val_34 = null;
            PGCompany.GameTaskActionSettings val_27 = val_17.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            .专丗万丟与东丟且专 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_27.Map);
        }
        
        if((PGCompany.GameModeLowDeviceWarningBanner.七丑丆丏东业专丒万(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 东下丌丝且七丛丘丒:  (ClanWarUI.丟一丛丑丘上丗下东)[1152921536826841824].专丗万丟与东丟且专, 万丟丗丏专丆丌上三:  false, 丏丒且丄三世丆丕上:  new System.Action(object:  new ClanWarUI.丟一丛丑丘上丗下东(), method:  System.Void ClanWarUI.丟一丛丑丘上丗下东::丛万一世业上丘丟丑()))) != false)
        {
                return;
        }
        
        this.丆下丅丟下丂一不丙(专丗万丟与东丟且专:  (ClanWarUI.丟一丛丑丘上丗下东)[1152921536826841824].专丗万丟与东丟且专, 业丄世丆世丁丝丌七:  new System.Action(object:  this, method:  System.Void ClanWarUI::丗丒丄丂上丕七丏丌()));
    }
    private void 丆下丅丟下丂一不丙(SceneInfo 专丗万丟与东丟且专, System.Action 业丄世丆世丁丝丌七)
    {
        int val_4;
        this.丁丒丗丞丂丏业业丗().enabled = true;
        ConnectionControl val_2 = this.丁丒丗丞丂丏业业丗();
        if(专丗万丟与东丟且专 == 0)
        {
            goto label_4;
        }
        
        val_4 = 专丗万丟与东丟且专.indexMap;
        if(val_2 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_4 = 0;
        if(val_2 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_2.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  业丄世丆世丁丝丌七, 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 丗丒丄丂上丕七丏丌()
    {
        SceneInfo val_18;
        var val_19;
        var val_20;
        PGCompany.丁下丒丕丆下丂丆丌 val_2 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万();
        PGCompany.GameTaskActionSettings val_5 = val_2.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_18 = 0;
        if((System.String.IsNullOrEmpty(value:  val_5.Map)) != true)
        {
                PGCompany.GameTaskActionSettings val_9 = val_2.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            if(val_9.GameMode == 22)
        {
                val_19 = null;
            val_19 = null;
            GameConnect.与丝丒万且丘丂丟三 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丙丆不上丂万丝丕();
        }
        
            val_20 = null;
            val_20 = null;
            PGCompany.GameTaskActionSettings val_14 = val_2.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            val_18 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_14.Map);
        }
        
        this.丁丒丗丞丂丏业业丗().一丙丅丛丁东丅丅世(上业丈东万下世丝丁:  new System.Action(object:  this, method:  System.Void ClanWarUI::丂丛不丑丅且丟丌世()), 丏丈丗世丙万丆丐丅:  val_18, 丐且丘丑与万丞丑丅:  0);
    }
    public void CreateClanSquad()
    {
        SceneInfo val_17;
        var val_18;
        PGCompany.丁下丒丕丆下丂丆丌 val_2 = this.clanWarMap.丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘();
        PGCompany.GameTaskActionSettings val_5 = val_2.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_17 = 0;
        if((System.String.IsNullOrEmpty(value:  val_5.Map)) != true)
        {
                val_18 = null;
            val_18 = null;
            PGCompany.GameTaskActionSettings val_9 = val_2.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            val_17 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_9.Map);
        }
        
        PGCompany.GameTaskActionSettings val_13 = val_2.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if((PGCompany.GameModeLowDeviceWarningBanner.七丑丆丏东业专丒万(上且丗一丏丏万丅丌:  val_13.GameMode, 东下丌丝且七丛丘丒:  val_17, 万丟丗丏专丆丌上三:  true, 丏丒且丄三世丆丕上:  new System.Action(object:  this, method:  System.Void ClanWarUI::丟一丁丕丈丟上丁不()))) != false)
        {
                return;
        }
        
        this.丛三七七丆丄丂丕丈(业丄世丆世丁丝丌七:  new System.Action(object:  this, method:  System.Void ClanWarUI::丅丌丄上一不丗丅上()));
    }
    private void 丛三七七丆丄丂丕丈(System.Action 业丄世丆世丁丝丌七)
    {
        this.丁丒丗丞丂丏业业丗().enabled = true;
        this.丁丒丗丞丂丏业业丗().丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  业丄世丆世丁丝丌七, 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  true, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 丅丌丄上一不丗丅上()
    {
        var val_10;
        var val_11;
        this.gameObject.SetActive(value:  false);
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
        {
                Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  this.clanWarMap.丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘());
        }
        
        val_10 = null;
        val_10 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 2;
        val_11 = null;
        val_11 = null;
        SquadController.丄丘七三上丕世丞业.七丙一丘丛丒丟丝丗(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void ClanWarUI::BackFromSquad()), 丌丝万上丅丒一丈丘:  this.clanWarMap.丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘(), 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "");
    }
    public void CreateClanSquadReturn()
    {
        UnityEngine.Debug.LogError(message:  "Clan War CreateClanSquadReturn");
        this.丛三七七丆丄丂丕丈(业丄世丆世丁丝丌七:  new System.Action(object:  this, method:  System.Void ClanWarUI::丟丌丝丕不丅专丄丛()));
    }
    private void 丟丌丝丕不丅专丄丛()
    {
        var val_10;
        var val_11;
        this.gameObject.SetActive(value:  false);
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
        {
                Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  this.clanWarMap.丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘());
        }
        
        val_10 = null;
        val_10 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 2;
        val_11 = null;
        val_11 = null;
        SquadController.丄丘七三上丕世丞业.七丙一丘丛丒丟丝丗(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void ClanWarUI::BackFromSquad()), 丌丝万上丅丒一丈丘:  this.clanWarMap.丆丆丘且丑丅丝丟丙().丑丂丅丐业丘下东丘(), 丟与丏丈丁东丅下丕:  true, 丗不下业上下丆丑丑:  "");
    }
    public void BackFromSquad()
    {
        this.gameObject.SetActive(value:  true);
    }
    internal bool 七丏丆丁不丐三丁丄()
    {
        if(this.bigCellInfo != null)
        {
                return (bool)this.bigCellInfo.丟丛丕世三丙东丈丐;
        }
        
        return (bool)this.bigCellInfo.丟丛丕世三丙东丈丐;
    }
    internal void 丂丘一丐七且丕世丅()
    {
        this.bigCellInfo.丆世与丑丆丅丐万且(与丑丑丑丂丛一丝一:  true);
        this.cellInfoListView.ChekSelection();
    }
    public void U_HideBigCellInfo()
    {
        this.丂丘一丐七且丕世丅();
    }
    public void ShowBigFortAssaultInfoUI()
    {
        this.bigFortAssaultInfoUI.gameObject.SetActive(value:  true);
        this.bigFortAssaultInfoUI.Setup();
    }
    public void U_GoToFortAttack()
    {
        this.丛三七七丆丄丂丕丈(业丄世丆世丁丝丌七:  new System.Action(object:  this, method:  System.Void ClanWarUI::丘丘专世丝丛丅丄丐()));
    }
    public void U_GoToFortDefence()
    {
        this.丛三七七丆丄丂丕丈(业丄世丆世丁丝丌七:  new System.Action(object:  this, method:  System.Void ClanWarUI::丑与不丘东丂世不业()));
    }
    public void U_GoToAppStore()
    {
        UnityEngine.Application.OpenURL(url:  丄丛丏丄不一丆丐丑.丅丙业上丄不丘丝三());
    }
    private void 丘丘专世丝丛丅丄丐()
    {
        var val_5;
        this.gameObject.SetActive(value:  false);
        val_5 = null;
        val_5 = null;
        SquadController.丄丘七三上丕世丞业.不丂七上丁丙丗业丁(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void ClanWarUI::BackFromSquad()), 且世上丙与丐一丛业:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万(且下丕七丙丗丄不七:  2), 上且丗一丏丏万丅丌:  27, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "");
    }
    private void 丑与不丘东丂世不业()
    {
        var val_5;
        this.gameObject.SetActive(value:  false);
        val_5 = null;
        val_5 = null;
        SquadController.丄丘七三上丕世丞业.不丂七上丁丙丗业丁(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void ClanWarUI::BackFromSquad()), 且世上丙与丐一丛业:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万(且下丕七丙丗丄不七:  1), 上且丗一丏丏万丅丌:  26, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "");
    }
    public void HideBigFortAssaultInfoUI()
    {
        this.bigFortAssaultInfoUI.gameObject.SetActive(value:  false);
    }
    public void ApplayCameraSettings()
    {
        var val_6;
        var val_16;
        float val_20;
        float val_21;
        float val_22;
        val_16 = this;
        int val_1 = PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_20 = val_2.x;
        val_21 = val_2.y;
        val_22 = val_2.z;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = this.clanWarMap.丒与丂业丆三丞上下.Values.GetEnumerator();
        label_12:
        if(((-2136764544) & 1) == 0)
        {
            goto label_14;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if((val_7.丗丐东丑丕丞丅丞东() != 2) || (val_7.丛丆东上上丗丗业丕() != val_1))
        {
            goto label_12;
        }
        
        if(val_7.丂丕丘丌专丗丞丘丘() != null)
        {
                UnityEngine.Vector3 val_12 = val_7.丂丕丘丌专丗丞丘丘().丌丆业专三万丁丒丒();
            val_20 = val_12.x;
            val_21 = val_12.y;
            val_22 = val_12.z;
        }
        
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((public System.Void Dictionary.ValueCollection.Enumerator<DiscreteVector2, 不上丌世万丁丝丏丆>::Dispose()) < 1)
        {
                return;
        }
        
        if(this.cameraSettingsList == null)
        {
                return;
        }
        
        if(val_1 > this.cameraSettingsList.Count)
        {
                return;
        }
        
        val_16 = this.cameraSettingsList.Item[val_1 - 1];
        val_16.三业丒丑丂三丕上丛(丟丞一专丕三东丗一:  this.applayCameraSettingsSpeed, 三专万丗三丈丈丄丏:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22});
    }
    public ClanWarCameraSettings GetCameraSettings(int 丄丝丏上丄丛丘丟丆)
    {
        System.Collections.Generic.List<ClanWarCameraSettings> val_4;
        var val_5;
        val_4 = 丄丝丏上丄丛丘丟丆;
        val_5 = 0;
        if()
        {
                return (ClanWarCameraSettings)val_4.Item[val_4 - 1];
        }
        
        if(this.cameraSettingsList == null)
        {
                return (ClanWarCameraSettings)val_4.Item[val_4 - 1];
        }
        
        if(this.cameraSettingsList.Count < val_4)
        {
                val_5 = 0;
            return (ClanWarCameraSettings)val_4.Item[val_4 - 1];
        }
        
        val_4 = this.cameraSettingsList;
        return (ClanWarCameraSettings)val_4.Item[val_4 - 1];
    }
    public void U_GiveTributeRewards()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丈丝丒丌丛丙丐丐世(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  1)) != false)
        {
                InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9102"), arg0:  丑丁世丒丅丄丈丑丙.七与丑下丅万丗不丞(丅专与丒丈丗丒丘丌:  1)), 丂三丟丂丈丐丆丗丟:  (float)Rilisoft.Singleton<ClansController>.Instance.丈丄一丈丆且丕丞丌(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  1), 丛丒丟一万上丒丁七:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9101"));
            return;
        }
        
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丘丙东丞丒上丛丙丙());
    }
    private System.Collections.IEnumerator 丘丙东丞丒上丛丙丙()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanWarUI.丞丙丟丈一丁万丙丕(丗丏丅丕丆世丁专丟:  0);
    }
    private void 上且丆丛业且丞丟业()
    {
        与丂丅三丂且不不与.丑七不且上丗丁一世().三丐七丕丘与丂丑丈();
    }
    private void 专七丗一且一丞世专()
    {
        丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
    }
    public ClanWarUI()
    {
        this.下不且不下丝上丄丅 = new System.Collections.Generic.List<PGCompany.UI.BindedUI>();
        this.applayCameraSettingsSpeed = 2.5f;
    }
    private static ClanWarUI()
    {
    
    }
    private void 丂丛不丑丅且丟丌世()
    {
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  MainMenuController.丝业丗上上丘丐与丗(丛丑丂丛丙一上专丆:  false, 世不丛业丟丝与丆丙:  false, 丑丐丗三丒世丏东丅:  "", 丒不丙万万不丕丞与:  false, 丌与一丌且一不七丆:  false, 丝丅与业且一丛丒一:  true, 丁丟丑丆三丆业一丅:  2, 丅与丏与丙东世丌世:  100));
        this.gameObject.SetActive(value:  false);
    }
    private void 丟一丁丕丈丟上丁不()
    {
        this.丛三七七丆丄丂丕丈(业丄世丆世丁丝丌七:  new System.Action(object:  this, method:  System.Void ClanWarUI::丅丌丄上一不丗丅上()));
        PGCompany.GameModeLowDeviceWarningBanner.丕丂万与与丛丈丆丈 = true;
    }

}
