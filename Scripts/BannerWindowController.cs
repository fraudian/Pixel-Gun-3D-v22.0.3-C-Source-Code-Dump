using UnityEngine;
internal sealed class BannerWindowController : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<BannerWindow> bannerWindows;
    private static BannerWindowController <丟丒丁上丑丂万与且>k__BackingField;
    public Rilisoft.AdvertisementController advertiseController;
    private readonly int 丙下丕与上与与丙丟;
    private const float 丛丁世东丘丝丞丙丛 = 3;
    private float 上不丅丝丗一七丈丞;
    private System.Collections.Generic.Queue<BannerWindow> 丆丌专丟万丄东丟丂;
    private BannerWindow 东一丏七业丙万丞丅;
    private bool[] 丑世不丝万七丁业丌;
    private bool[] 不丁丝丞一丄丄万丂;
    private float 且三业丙世丁丑丘七;
    private float 丆丌万万业丁不丕业;
    private bool 世世丞三丌丂丅七不;
    public int viewedBannersCountInConnectScene;
    private System.Threading.CancellationTokenSource 丑丝丕一丈业七下丏;
    private bool 世三不丙丁世丕上东;
    private System.Threading.CancellationTokenSource 丁丕且万专丈一一且;
    private static long 丞七丅丒丑万一七专;
    private Rilisoft.丆专丐丂丆丐丕丝丒 丝不丘万丙不丏七丅;
    
    // Properties
    internal static BannerWindowController 丟万业丝丟丆丑丞丈 { get; set; }
    public BannerWindow 东丄专丑一专丙三丒 { get; set; }
    private bool 与七上丑丟丆万丛丘 { get; }
    internal static long 丐东业丙丅专世上丒 { get; set; }
    internal bool 丂丆丁丛万丄且丏丕 { get; }
    internal bool 一丈丂万专上丐业丁 { get; }
    
    // Methods
    private static void 丗丅丒丁丏丗丕丙丑(BannerWindowController 丙业与丙丗丝不丈东)
    {
        null = null;
        BannerWindowController.丛丁世东丘丝丞丙丛 = 丙业与丙丗丝不丈东;
    }
    internal static BannerWindowController 与丅与丒丅专丙丐丗()
    {
        null = null;
        return (BannerWindowController)BannerWindowController.丛丁世东丘丝丞丙丛;
    }
    public BannerWindow get_CurrentBanner()
    {
        return (BannerWindow)this.东一丏七业丙万丞丅;
    }
    private void 专丅丗东丆下三丐丛(BannerWindow 丙业与丙丗丝不丈东)
    {
        this.东一丏七业丙万丞丅 = 丙业与丙丗丝不丈东;
    }
    private bool 丅业丙业万七丒丑一()
    {
        return UnityEngine.Object.op_Inequality(x:  this.东一丏七业丙万丞丅, y:  0);
    }
    private BannerWindowController()
    {
        System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        this.丙下丕与上与与丙丟 = val_2.Length;
        this.上不丅丝丗一七丈丞 = 12f;
        this.丝不丘万丙不丏七丅 = new Rilisoft.丆专丐丂丆丐丕丝丒(丟东丟丑丕丄丂丟丙:  "skip-first-offer-show");
        this.丑世不丝万七丁业丌 = new bool[0];
        this.不丁丝丞一丄丄万丂 = new bool[0];
    }
    private void Awake()
    {
        BannerWindowController.丗丅丒丁丏丗丕丙丑(丙业与丙丗丝不丈东:  this);
        this.Reset();
    }
    internal void Reset()
    {
        var val_14;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.东一丏七业丙万丞丅, y:  0);
        this.丑世不丝万七丁业丌 = new bool[0];
        this.不丁丝丞一丄丄万丂 = new bool[0];
        goto label_7;
        label_10:
        this.bannerWindows.Add(item:  0);
        label_7:
        if(this.bannerWindows.Count < (丞东丑专丛丆丄丝世.丆丛丝丕丄七丏丒丅<BannerWindowType>()))
        {
            goto label_10;
        }
        
        val_14 = 0;
        goto label_11;
        label_14:
        this.bannerWindows.set_Item(index:  0, value:  0);
        val_14 = 1;
        label_11:
        if(val_14 < this.bannerWindows.Count)
        {
            goto label_14;
        }
        
        T[] val_8 = this.transform.GetComponentsInChildren<BannerWindow>(includeInactive:  true);
        if((val_8 != null) && (val_8.Length >= 1))
        {
                do
        {
            T val_15 = val_8[0];
            if(val_15 != 0)
        {
                System.Nullable<T> val_11 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<BannerWindowType>(下业七不丑丂丏丟东:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_15), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
            if((1629951640 & 1) != 0)
        {
                this.bannerWindows.set_Item(index:  1629951640, value:  val_15);
        }
        
        }
        
        }
        while((0 + 1) < val_8.Length);
        
        }
        
        PGCompany.TransitionController.东世丏上丐丕上一与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void BannerWindowController::下丒一丈丘丅丈且丒(PGCompany.丑且丆万丏丝丘丙丟 丁丄且丝七一丗丕专)));
        PGCompany.TransitionController.丛丟世丌丞与丒上丄(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void BannerWindowController::下丒一丈丘丅丈且丒(PGCompany.丑且丆万丏丝丘丙丟 丁丄且丝七一丗丕专)));
    }
    private void 下丒一丈丘丅丈且丒(PGCompany.丑且丆万丏丝丘丙丟 丁丄且丝七一丗丕专)
    {
        if(丁丄且丝七一丗丕专 == null)
        {
                return;
        }
        
        if(this.东一丏七业丙万丞丅 != 0)
        {
                return;
        }
        
        this.东一丏七业丙万丞丅 = (((PGCompany.丑且丆万丏丝丘丙丟.__il2cppRuntimeField_typeHierarchy + (BannerWindow.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丁丄且丝七一丗丕专 : 0;
    }
    private void Start()
    {
        this.东一丏七业丙万丞丅 = 0;
        System.Collections.Generic.Queue<BannerWindow> val_1 = new System.Collections.Generic.Queue<BannerWindow>();
        this.丆丌专丟万丄东丟丂 = val_1;
        bool val_3 = ~val_1.丞丂世世丒丞世丂三();
        val_3 = val_3 & 1;
        this.世世丞三丌丂丅七不 = val_3;
    }
    public void ResetScene()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 + 3f;
        this.丆丌万万业丁不丕业 = val_1;
        this.东一丏七业丙万丞丅 = 0;
    }
    public void AddBannersTimeout(float 丆丐七丅丆丗丛上与)
    {
        if(NovicePromotionSelectorBanner.CanShowAutomaticaly() == true)
        {
                return;
        }
        
        if(TierBundleBanner.CanShowAutomaticaly() == true)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.realtimeSinceStartup;
        val_3 = val_3 + 丆丐七丅丆丗丛上与;
        this.且三业丙世丁丑丘七 = val_3;
    }
    private void OnDestroy()
    {
        BannerWindowController.丗丅丒丁丏丗丕丙丑(丙业与丙丗丝不丈东:  0);
        this.丆丌专丟万丄东丟丂 = 0;
        this.advertiseController = 0;
        PGCompany.TransitionController.东世丏上丐丕上一与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void BannerWindowController::下丒一丈丘丅丈且丒(PGCompany.丑且丆万丏丝丘丙丟 丁丄且丝七一丗丕专)));
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        BannerWindowController.丒丆丛万下世丒丙东 val_1 = new BannerWindowController.丒丆丛万下世丒丙东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丁与丟万丄丒丗专丌 = 丁与丟万丄丒丗专丌;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丁丅丝丒丂上丘丏丑(BannerWindowType 丌丅丕一丛丛丄一万, bool 丛万下上万丙下世丂, string 丈世且丞专丑丂丐世, System.Action 丟丘丙丄丅万丏与丗, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
    {
        BannerWindowController.且下七业七业一上丈 val_1 = new BannerWindowController.且下七业七业一上丈();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
        if(this.丑丝丕一丈业七下丏 != null)
        {
                this.丑丝丕一丈业七下丏.Cancel();
        }
        
        this.丑丝丕一丈业七下丏 = new System.Threading.CancellationTokenSource();
        if(this.世三不丙丁世丕上东 != false)
        {
                if((BannerWindowController.且下七业七业一上丈)[1152921536302760608].丟丘丙丄丅万丏与丗 == null)
        {
                return;
        }
        
            (BannerWindowController.且下七业七业一上丈)[1152921536302760608].丟丘丙丄丅万丏与丗.Invoke();
            return;
        }
        
        this.世三不丙丁世丕上东 = true;
        System.Threading.CancellationToken val_4 = this.丑丝丕一丈业七下丏.Token;
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丆丏七一丞世丞世七(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_4.m_source}, 丛万下上万丙下世丂:  丛万下上万丙下世丂, 丟丘丙丄丅万丏与丗:  new System.Action(object:  val_1, method:  System.Void BannerWindowController.且下七业七业一上丈::三丕东业丏丑丒东专()), 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆不七一丐且不七三 = ???, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}}));
    }
    private void OnDisable()
    {
        if(this.世三不丙丁世丕上东 == false)
        {
                return;
        }
        
        if(this.丑丝丕一丈业七下丏 != null)
        {
                this.丑丝丕一丈业七下丏.Cancel();
            this.丑丝丕一丈业七下丏 = 0;
        }
        
        this.世三不丙丁世丕上东 = false;
    }
    private System.Collections.IEnumerator 丆丏七一丞世丞世七(BannerWindowType 丌丅丕一丛丛丄一万, System.Threading.CancellationToken 不丒三业下丑不丞业, bool 丛万下上万丙下世丂, System.Action 丟丘丙丄丅万丏与丗, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
    {
        var val_4;
        BannerWindowController.丐世丆丛丝丒丙丂丒 val_1 = new BannerWindowController.丐世丆丛丝丒丙丂丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丌丅丕一丛丛丄一万 = 丌丅丕一丛丛丄一万;
            .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
            .丝且与丝丒丟万丁专 = this;
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            .丛万下上万丙下世丂 = 丛万下上万丙下世丂;
            val_4;
            return (System.Collections.IEnumerator)val_1;
        }
        
        mem[40] = this;
        mem[32] = 丌丅丕一丛丛丄一万;
        mem[64] = 不丒三业下丑不丞业.m_source;
        mem[56] = 丛万下上万丙下世丂;
        mem[48] = 丟丘丙丄丅万丏与丗;
        val_4;
        return (System.Collections.IEnumerator)val_1;
    }
    public void HideBannerWindowNoShowNext()
    {
        UnityEngine.Object val_2 = 0;
        if(this.东一丏七业丙万丞丅 == val_2)
        {
                return;
        }
        
        if((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) >= this.丑世不丝万七丁业丌.Length)
        {
                val_2 = 0;
        }
        
        if((this.丑世不丝万七丁业丌[this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField]) != false)
        {
                if((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) >= this.丑世不丝万七丁业丌.Length)
        {
                val_2 = 0;
        }
        
            this.丑世不丝万七丁业丌[this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField] = false;
            if((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) >= this.不丁丝丞一丄丄万丂.Length)
        {
                val_2 = 0;
        }
        
            this.不丁丝丞一丄丄万丂[this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField] = false;
        }
        
        this.东一丏七业丙万丞丅 = 0;
    }
    public void ClearBannerStates()
    {
        this.丑世不丝万七丁业丌 = new bool[0];
        this.不丁丝丞一丄丄万丂 = new bool[0];
    }
    public void HideBannerWindow()
    {
        if(this.东一丏七业丙万丞丅 != 0)
        {
                if((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) == 5)
        {
                return;
        }
        
        }
        
        this.HideBannerWindowNoShowNext();
        if(this.丆丌专丟万丄东丟丂.Count < 1)
        {
                return;
        }
        
        this.东一丏七业丙万丞丅 = this.丆丌专丟万丄东丟丂.Dequeue();
        this = ???;
        goto typeof(BannerWindow).__il2cppRuntimeField_1C8;
    }
    private void 且丆丂七丞万三丗与()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(AdmobPerelivWindow.世丝一且丏三丄丞丙 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if((System.String.IsNullOrEmpty(value:  AdmobPerelivWindow.一一三丘丒且与丄万)) == true)
        {
                return;
        }
        
        this.丁丅丝丒丂上丘丏丑(丌丅丕一丛丛丄一万:  7, 丛万下上万丙下世丂:  true, 丈世且丞专丑丂丐世:  null, 丟丘丙丄丅万丏与丗:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆不七一丐且不七三 = ???, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void 丏东与万丒丕丒丗丑(Rilisoft.AdvertisementController 东不丙业丒与万世七)
    {
        if(this.丁丕且万专丈一一且 != null)
        {
                this.丁丕且万专丈一一且.Cancel();
        }
        
        System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
        this.丁丕且万专丈一一且 = val_1;
        System.Threading.CancellationToken val_2 = val_1.Token;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丏东与万丒丕丒丗丑(东不丙业丒与万世七:  东不丙业丒与万世七, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_2.m_source}));
    }
    private System.Collections.IEnumerator 丏东与万丒丕丒丗丑(Rilisoft.AdvertisementController 东不丙业丒与万世七, System.Threading.CancellationToken 不丒三业下丑不丞业)
    {
        BannerWindowController.专且万丞丂丂丙上丏 val_1 = new BannerWindowController.专且万丞丂丂丙上丏();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .东不丙业丒与万世七 = 东不丙业丒与万世七;
            .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
            mem[32] = 东不丙业丒与万世七;
        }
        
        .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
        return (System.Collections.IEnumerator)val_1;
    }
    public void AdvertBannerExitClick()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.advertiseController.Close();
        this.advertiseController.下与业丌丙专七东一();
        this.HideBannerWindow();
    }
    public void AdvertBannerApplyClick()
    {
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_2 = 0;
        string val_4 = 0;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.advertiseController.Close();
        this.advertiseController.下与业丌丙专七东一();
        if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_2)) != false)
        {
                if((PGCompany.DataObjects.三丛丂丟与不专丛丏.七三丟三丛上东丒且(上世丏丁世丟世丆业:  val_2, 七丆丒与丗丌丄且丂: out  val_4)) != false)
        {
                UnityEngine.Application.OpenURL(url:  Rilisoft.且且丌与专丐一东一.丑七不且上丗丁一世().专万丗丁丗下不丂丈(七丆丒与丗丌丄且丂:  val_4).七三丅且三东万不业());
        }
        
        }
        
        this.HideBannerWindow();
    }
    public void SorryBannerExitButtonClick()
    {
        null = null;
        SetActive(value:  false);
        this.HideBannerWindow();
    }
    internal static long 上丞业不不丐业丏丟()
    {
        string val_11;
        var val_12;
        var val_13;
        val_12 = null;
        val_12 = null;
        if(BannerWindowController.丞七丅丒丑万一七专 <= 0)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  与丂丏丛丞丞丒丟丄.七丝七丄上丅丑丌丘())) != false)
        {
                val_13 = null;
            val_11 = UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.七丝七丄上丅丑丌丘());
            val_13 = null;
            bool val_6 = System.Int64.TryParse(s:  val_11, result: out  1152921505133846536);
            val_12 = null;
        }
        else
        {
                UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.七丝七丄上丅丑丌丘(), value:  专七专下且专三一且.上且一丈丐三丄一丆().ToString());
            val_12 = null;
            val_11 = 专七专下且专三一且.上且一丈丐三丄一丆();
            val_12 = null;
            BannerWindowController.丞七丅丒丑万一七专 = val_11;
        }
        
        }
        
        val_12 = null;
        return (long)BannerWindowController.丞七丅丒丑万一七专;
    }
    internal static void 下丑上丞丅上丏丟一(long 丙业与丙丗丝不丈东)
    {
        var val_3;
        UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.七丝七丄上丅丑丌丘(), value:  丙业与丙丗丝不丈东.ToString());
        val_3 = null;
        val_3 = null;
        BannerWindowController.丞七丅丒丑万一七专 = 丙业与丙丗丝不丈东;
    }
    private void 下与业丌丙专七东一()
    {
        string val_16;
        string val_4 = 0;
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_2 = 0;
        val_16 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
        if((val_16.不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_2)) == false)
        {
                return;
        }
        
        if((PGCompany.DataObjects.三丛丂丟与不专丛丏.七三丟三丛上东丒且(上世丏丁世丟世丆业:  val_2, 七丆丒与丗丌丄且丂: out  val_4)) == false)
        {
                return;
        }
        
        val_16 = Rilisoft.且且丌与专丐一东一.丑七不且上丗丁一世().专万丗丁丗下不丂丈(七丆丒与丗丌丄且丂:  val_4);
        if(val_16.丘上丁丅丛三三丕不() == true)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丞业丆丈丌世丕丙丙(), value:  (UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丞业丆丈丌世丕丙丙(), defaultValue:  3)) - 1);
        val_16 = 与丂丏丛丞丞丒丟丄.下丘世丅丘丁丗三下();
        UnityEngine.PlayerPrefs.SetString(key:  val_16, value:  专七专下且专三一且.上且一丈丐三丄一丆().ToString());
        UnityEngine.PlayerPrefs.Save();
    }
    private bool 丞丂世世丒丞世丂三()
    {
        string val_8;
        var val_9;
        var val_10;
        var val_11;
        val_9 = null;
        val_9 = null;
        if((System.String.IsNullOrEmpty(value:  与丂丏丛丞丞丒丟丄.上不七丘三专丐丁专)) != true)
        {
                val_10 = null;
            val_10 = null;
            val_8 = 与丂丏丛丞丞丒丟丄.上不七丘三专丐丁专;
            if((System.DateTime.TryParse(s:  val_8, result: out  new System.DateTime())) != false)
        {
                System.DateTime val_3 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime());
            if(val_4._ticks.TotalMinutes < 1440)
        {
                var val_7 = (与丂丏丛丞丞丒丟丄.不丟丘丝丒专丅东丏() > 3) ? 1 : 0;
            return (bool)val_11;
        }
        
        }
        
        }
        
        val_11 = 1;
        return (bool)val_11;
    }
    private void Update()
    {
        BannerWindowType val_225;
        var val_226;
        BannerWindowType val_227;
        var val_228;
        var val_229;
        var val_230;
        var val_231;
        var val_232;
        var val_233;
        var val_234;
        var val_235;
        var val_236;
        var val_237;
        var val_238;
        var val_239;
        var val_240;
        var val_241;
        var val_242;
        var val_243;
        var val_244;
        var val_245;
        var val_246;
        var val_247;
        var val_248;
        var val_249;
        var val_250;
        var val_251;
        var val_252;
        var val_253;
        var val_268;
        var val_269;
        var val_293;
        var val_294;
        Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_9 = 0;
        if(this.东一丏七业丙万丞丅 != 0)
        {
                if(this.东一丏七业丙万丞丅.gameObject.activeSelf != true)
        {
                if((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) == 31)
        {
                return;
        }
        
            val_225 = this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField;
            BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  val_225);
            BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        }
        
        }
        
        val_226 = null;
        val_226 = null;
        if(ReviewHUDWindow.丆丄丗七丂丐世丂七 == true)
        {
                return;
        }
        
        if(UnityEngine.Time.realtimeSinceStartup < 0)
        {
                return;
        }
        
        if(this.世三不丙丁世丕上东 == true)
        {
                return;
        }
        
        float val_7 = UnityEngine.Time.realtimeSinceStartup;
        val_7 = val_7 - this.且三业丙世丁丑丘七;
        if(val_7 < 1f)
        {
                return;
        }
        
        if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丅丙一业丂丐丐丟不(丅丟丛丙下丙丄丒丁: out  val_9)) != false)
        {
                if(val_9.CurrentState == null)
        {
                return;
        }
        
            if(null != null)
        {
                return;
        }
        
        }
        
        this.七三专丙下业一世上();
        val_227 = 0;
        goto label_138;
        label_682:
        if((PGCompany.Banners.丗丘丆一世丁丙丝且.世丌丕丏丒丌一丒丄(世丁丌万丏丟丗世三:  val_227)) == false)
        {
            goto label_680;
        }
        
        if(val_227 != 7)
        {
                if(this.丅业丙业万七丒丑一() == true)
        {
            goto label_680;
        }
        
        }
        
        val_225 = this.不丁丝丞一丄丄万丂;
        if((val_225[0] == false) || (ActivityIndicator.丙专三丙丌丝丏丌丅() == true))
        {
            goto label_680;
        }
        
        if(MainMenuController.专上三丛专万丂下万() == true)
        {
            goto label_691;
        }
        
        val_228 = null;
        val_228 = null;
        val_225 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_225 == 0)
        {
            goto label_46;
        }
        
        val_229 = null;
        val_229 = null;
        val_225 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_225.一丑丟世丛丌丁下不() == true)
        {
            goto label_691;
        }
        
        label_46:
        if(((UniversalRewardBanner.丈丐丞丐上丑且丕万() == true) || (LootBoxBanner.丈丐丞丐上丑且丕万() == true)) || (Rilisoft.GameEventOpenChestBase.丈丐丞丐上丑且丕万() == true))
        {
            goto label_691;
        }
        
        if(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丆丂丄丌丝丅上业丒() != false)
        {
                if(PGCompany.TutorialHintUI.丈丐丞丐上丑且丕万() == true)
        {
            goto label_680;
        }
        
        }
        
        val_225 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_225.丟丂下七且七东丛丞(不七丆万丁一丞七下:  176)) == false)
        {
            goto label_691;
        }
        
        if(val_227 == 14)
        {
            goto label_61;
        }
        
        val_230 = null;
        val_230 = null;
        if(GiftBannerWindow.丘丆且七丑丘且专丟 == true)
        {
            goto label_691;
        }
        
        label_61:
        if(BankController.丑七不且上丗丁一世() == 0)
        {
            goto label_69;
        }
        
        val_225 = BankController.丑七不且上丗丁一世();
        if(val_225.上丙丆不丂丂丄一丂() == true)
        {
            goto label_691;
        }
        
        label_69:
        val_225 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_225 != 0)
        {
            goto label_691;
        }
        
        val_225 = Rilisoft.Nest.丑七不且上丗丁一世();
        if(val_225 == 0)
        {
            goto label_81;
        }
        
        val_225 = Rilisoft.Nest.丑七不且上丗丁一世();
        if(val_225.BannerIsVisible == true)
        {
            goto label_691;
        }
        
        label_81:
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
        {
            goto label_691;
        }
        
        val_231 = null;
        val_231 = null;
        val_225 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_225 == 0)
        {
            goto label_91;
        }
        
        val_232 = null;
        val_232 = null;
        val_225 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 496];
        val_225 = MainMenuController.丄丞丁丈与业上丞丟.丗上丏丟丆专与丗丆;
        if(activeSelf == true)
        {
            goto label_691;
        }
        
        label_91:
        if((NurseryGuiController.丛世丛与丌不丈丐丐() == true) || (ShopNGUIController.丛世丛与丌不丈丐丐() == true))
        {
            goto label_691;
        }
        
        val_233 = static_value_081DACA8;
        val_233 = static_value_081DACA8;
        val_225 = mem[static_value_081DACA8 + 184 + 16];
        val_225 = static_value_081DACA8 + 184 + 16;
        if(val_225 == 0)
        {
            goto label_107;
        }
        
        val_234 = static_value_081DACA8;
        val_234 = static_value_081DACA8;
        val_225 = static_value_081DACA8 + 184 + 16 + 72.gameObject;
        if(val_225.activeSelf == true)
        {
            goto label_691;
        }
        
        label_107:
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世() == null)
        {
            goto label_114;
        }
        
        val_225 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_225.丌丗丑业丁上丆万七() == true)
        {
            goto label_691;
        }
        
        label_114:
        if((FreeAwardController.丁丈丐万万一丕丞丄() == false) || (MainMenuController.丝丂丒且与丆丛丝丒() == true))
        {
            goto label_691;
        }
        
        val_225 = ExpController.丑七不且上丗丁一世();
        if(val_225 == 0)
        {
            goto label_125;
        }
        
        val_225 = ExpController.丑七不且上丗丁一世();
        if(val_225.下不上丌丘七世丘丙() == true)
        {
            goto label_691;
        }
        
        val_225 = ExpController.丑七不且上丗丁一世();
        if(val_225.丆丝丅丗世丞丟下且() == true)
        {
            goto label_691;
        }
        
        label_125:
        val_235 = null;
        val_235 = null;
        if(SeasonEndView.世丑丗上丘丟丐丂丕 == true)
        {
            goto label_691;
        }
        
        if(UniversalRewardView.丅业东万丌丕上丌丄 == false)
        {
            goto label_137;
        }
        
        label_680:
        val_227 = 1;
        goto label_138;
        label_137:
        if(val_227 > 32)
        {
            goto label_139;
        }
        
        if((-5) > 7)
        {
            goto label_202;
        }
        
        if(NickNameValidationBanner.丂东下不丆专丌丈丆() == false)
        {
            goto label_680;
        }
        
        goto label_144;
        label_139:
        if(val_227 > 100)
        {
            goto label_145;
        }
        
        if(val_227 == 33)
        {
            goto label_146;
        }
        
        if(val_227 != 69)
        {
            goto label_202;
        }
        
        if(PGCompany.UpdateBanner.UpdateBannerController.丂东下不丆专丌丈丆() == false)
        {
            goto label_680;
        }
        
        label_144:
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == true)
        {
            goto label_680;
        }
        
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == false)
        {
            goto label_202;
        }
        
        goto label_680;
        label_145:
        if(val_227 == 101)
        {
            goto label_156;
        }
        
        if(val_227 != 105)
        {
            goto label_202;
        }
        
        if(this.与丝东专上丕丂不丕() == false)
        {
            goto label_680;
        }
        
        if(NewLobbyBanner.丕世一与业丅万专丑() == true)
        {
            goto label_202;
        }
        
        goto label_680;
        label_171:
        if(丆下丝丟丛不三丟丟() == true)
        {
            goto label_202;
        }
        
        goto label_680;
        label_146:
        if((ConnectScene.丈丘丂丙不丛业丟三() == true) || (FriendsController.丝丗专上三不丄丑丑() < 1))
        {
            goto label_680;
        }
        
        val_236 = null;
        val_236 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_680;
        }
        
        val_237 = null;
        val_237 = null;
        if(activeInHierarchy == false)
        {
            goto label_680;
        }
        
        val_238 = null;
        val_238 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.丂丙丈与世专上丒上() == true)
        {
            goto label_680;
        }
        
        val_239 = null;
        val_239 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) == true)
        {
            goto label_680;
        }
        
        val_240 = null;
        val_240 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends == false)
        {
            goto label_202;
        }
        
        goto label_680;
        label_156:
        if((this.与丝东专上丕丂不丕() == false) || (PGCompany.Banners.NewCompetitionBanner.丁七下丌丏丄丟上三() == false))
        {
            goto label_680;
        }
        
        label_202:
        if((PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().世丗一下丈万专且专() == false) || (val_227 != PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().丁丆丝丁不丌丌丂丅()))
        {
            goto label_213;
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() == true)
        {
            goto label_680;
        }
        
        val_241 = null;
        val_241 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_680;
        }
        
        val_242 = null;
        val_242 = null;
        if(activeInHierarchy == false)
        {
            goto label_680;
        }
        
        val_243 = null;
        val_243 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.丂丙丈与世专上丒上() == true)
        {
            goto label_680;
        }
        
        val_244 = null;
        val_244 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) == true)
        {
            goto label_680;
        }
        
        val_245 = null;
        val_245 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends == true)
        {
            goto label_680;
        }
        
        label_213:
        if(val_227 <= 40)
        {
            goto label_240;
        }
        
        if((-59) > 44)
        {
            goto label_241;
        }
        
        if(((((Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐() == false) || (Rilisoft.ClansLobbyGui.丑丂丂丈丐丌丏七丐() == true)) || (Rilisoft.ClansLobbyGui.丛丞丒丌丑三丝丑丈() == true)) || (LeaderboardsGui.丑丙丗世丏丞万世丒() == true)) || (LeaderboardsClans.丑丙丗世丏丞万世丒() == true))
        {
            goto label_680;
        }
        
        goto label_720;
        label_240:
        if(val_227 > 12)
        {
            goto label_250;
        }
        
        if((-1) > 8)
        {
            goto label_334;
        }
        
        goto label_171;
        label_250:
        if(val_227 > 18)
        {
            goto label_256;
        }
        
        if(val_227 == 13)
        {
            goto label_257;
        }
        
        if(val_227 != 18)
        {
            goto label_334;
        }
        
        if(Rilisoft.丐丌丝七下丈丒丅丗.丁丟丗与万丆丝丈丞() == true)
        {
            goto label_680;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_93 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  10);
        if(val_93 == null)
        {
            goto label_680;
        }
        
        Rilisoft.七丈业与与不七丈丟 val_94 = val_93.丁专丗万三上丟三丆();
        if(val_94.丁丑丅丐丌不世丁下.且丟业丒与丛丑丟不 == true)
        {
            goto label_268;
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() == true) || (Rilisoft.OfferPackWindow.丁丂丒七丌下上且丏() == false))
        {
            goto label_680;
        }
        
        goto label_720;
        label_256:
        if(val_227 == 19)
        {
            goto label_276;
        }
        
        if(val_227 == 34)
        {
            goto label_279;
        }
        
        goto label_334;
        label_241:
        if(val_227 == 41)
        {
            goto label_279;
        }
        
        if(val_227 != 54)
        {
            goto label_334;
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() == true)
        {
            goto label_283;
        }
        
        val_246 = null;
        val_246 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_680;
        }
        
        val_247 = null;
        val_247 = null;
        if(activeInHierarchy == false)
        {
            goto label_680;
        }
        
        label_283:
        if(ClanWarRegistrationNotification.业丗丝万专万丞丟上() == true)
        {
            goto label_720;
        }
        
        this.丑世不丝万七丁业丌[6] = false;
        this.不丁丝丞一丄丄万丂[6] = false;
        goto label_680;
        label_279:
        if(((ConnectScene.丈丘丂丙不丛业丟三() == true) || (LeaderboardsGui.丑丙丗世丏丞万世丒() == true)) || (LeaderboardsClans.丑丙丗世丏丞万世丒() == true))
        {
            goto label_680;
        }
        
        val_248 = null;
        val_248 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_311;
        }
        
        val_249 = null;
        val_249 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
        {
            goto label_680;
        }
        
        label_311:
        val_250 = null;
        val_250 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_680;
        }
        
        val_251 = null;
        val_251 = null;
        if(activeInHierarchy == false)
        {
            goto label_680;
        }
        
        val_252 = null;
        val_252 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.丂丙丈与世专上丒上() == true)
        {
            goto label_680;
        }
        
        val_253 = null;
        val_253 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends == true)
        {
            goto label_680;
        }
        
        goto label_334;
        label_257:
        if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_422;
        }
        
        label_679:
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
            goto label_680;
        }
        
        val_268 = null;
        val_268 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_430;
        }
        
        val_269 = null;
        val_269 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
        {
            goto label_680;
        }
        
        label_430:
        if(((ShopNGUIController.丛世丛与丌不丈丐丐() == true) || (LeaderboardsGui.丑丙丗世丏丞万世丒() == true)) || (LeaderboardsClans.丑丙丗世丏丞万世丒() == true))
        {
            goto label_680;
        }
        
        goto label_720;
        label_276:
        if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_680;
        }
        
        goto label_720;
        label_422:
        val_293 = null;
        val_293 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_680;
        }
        
        val_294 = null;
        val_294 = null;
        if(activeInHierarchy == true)
        {
            goto label_679;
        }
        
        goto label_680;
        label_138:
        val_225 = this.不丁丝丞一丄丄万丂;
        if(val_227 < this.不丁丝丞一丄丄万丂.Length)
        {
            goto label_682;
        }
        
        label_691:
        this.且三业丙世丁丑丘七 = UnityEngine.Time.realtimeSinceStartup;
        return;
        label_334:
        label_720:
        this.不丁丝丞一丄丄万丂[0] = false;
        if(val_227 == 8)
        {
            goto label_685;
        }
        
        if(val_227 != 7)
        {
            goto label_686;
        }
        
        this.且丆丂七丞万三丗与();
        goto label_691;
        label_685:
        this.丏东与万丒丕丒丗丑(东不丙业丒与万世七:  this.advertiseController);
        goto label_691;
        label_686:
        if(0 == 0)
        {
            goto label_689;
        }
        
        PGCompany.VeteranChest.丒专丛丒丄业丛业丁.东不丙三与丟丈东丘(七万上丐一丈丏丏专:  0, 七丘丑丂且万丄丒丟:  false);
        goto label_691;
        label_689:
        this.丁丅丝丒丂上丘丏丑(丌丅丕一丛丛丄一万:  val_227, 丛万下上万丙下世丂:  true, 丈世且丞专丑丂丐世:  null, 丟丘丙丄丅万丏与丗:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆不七一丐且不七三 = val_9, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = ???}});
        goto label_691;
        label_268:
        this.丝不丘万丙不丏七丅.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  true);
        goto label_720;
    }
    private void 丛世下丙丞丑丑与丏()
    {
        Rilisoft.AdvertisementController val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        val_25 = this;
        val_26 = 1152921505061052416;
        string val_5 = 0;
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_3 = 0;
        val_27 = null;
        val_27 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_3)) == false)
        {
                return;
        }
        
        if((PGCompany.DataObjects.三丛丂丟与不专丛丏.七三丟三丛上东丒且(上世丏丁世丟世丆业:  val_3, 七丆丒与丗丌丄且丂: out  val_5)) == false)
        {
                return;
        }
        
        Rilisoft.丆丆丕丟不一丝丕世 val_8 = Rilisoft.且且丌与专丐一东一.丑七不且上丗丁一世().专万丗丁丗下不丂丈(七丆丒与丗丌丄且丂:  val_5);
        int val_9 = ExperienceController.丞丞丘业东丙丏七丌();
        if(val_8.丗世丁丒丅丈丕丕丟() == 1)
        {
            goto label_17;
        }
        
        if(val_8 != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        if(val_8.丄且东且丕丛与丆丒() == 1)
        {
            goto label_20;
        }
        
        if(val_8 != null)
        {
            goto label_39;
        }
        
        label_40:
        label_39:
        if(val_8.丘上丁丅丛三三丕不() == false)
        {
            goto label_23;
        }
        
        val_28 = 1;
        if(val_8 != null)
        {
            goto label_28;
        }
        
        goto label_25;
        label_23:
        if(val_8 != null)
        {
            goto label_28;
        }
        
        label_25:
        label_28:
        if((val_8.世丑三丆丒七丘丕丑() != false) && (this.advertiseController != 0))
        {
                var val_23 = (this.advertiseController.CurrentState == 0) ? 1 : 0;
        }
        else
        {
                val_29 = 0;
        }
        
        var val_24 = ((val_9 <= val_8.丄且东且丕丛与丆丒()) ? 1 : 0) & ((val_9 >= val_8.丗世丁丒丅丈丕丕丟()) ? 1 : 0);
        val_24 = val_24 & (((UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丞业丆丈丌世丕丙丙(), defaultValue:  3)) > 0) ? 1 : 0);
        val_29 = val_24 & val_29;
        if(val_29 == 0)
        {
                return;
        }
        
        val_25 = this.advertiseController;
        val_25.Run();
        return;
        label_17:
        if(val_8 != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_20:
        if(val_8 != null)
        {
            goto label_39;
        }
        
        goto label_40;
    }
    private bool 丒业且上业丄丘世业()
    {
        Rilisoft.AdvertisementController val_5;
        var val_6;
        val_5 = this;
        if(this.advertiseController != 0)
        {
                val_5 = this.advertiseController;
            丙丟与丐三丐万万丆 val_2 = val_5.CurrentState;
            if(val_2 != 0)
        {
                var val_4 = ((val_2 & 4294967294) != 4) ? 1 : 0;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    public bool CanShowAnyBanner()
    {
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        if(ActivityIndicator.丙专三丙丌丝丏丌丅() == true)
        {
                return (bool)0 & 1;
        }
        
        val_39 = null;
        val_39 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return (bool)0 & 1;
        }
        
        val_40 = null;
        val_40 = null;
        if(activeInHierarchy != false)
        {
                if(this.世三不丙丁世丕上东 == false)
        {
            goto label_14;
        }
        
        }
        
        return (bool)0 & 1;
        label_14:
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return (bool)0 & 1;
        }
        
            if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        val_41 = null;
        val_41 = null;
        if(SeasonEndView.世丑丗上丘丟丐丂丕 == true)
        {
                return (bool)0 & 1;
        }
        
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() == null)
        {
                return (bool)0 & 1;
        }
        
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return (bool)0 & 1;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if(GiftBannerWindow.丛世丛与丌不丈丐丐() == true)
        {
                return (bool)0 & 1;
        }
        
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
        {
                return (bool)0 & 1;
        }
        
        if(Rilisoft.Nest.丑七不且上丗丁一世() != 0)
        {
                if(Rilisoft.Nest.丑七不且上丗丁一世().BannerIsVisible == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
        {
                return (bool)0 & 1;
        }
        
        val_42 = null;
        val_42 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_43 = null;
            val_43 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        val_44 = null;
        val_44 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_45 = null;
            val_45 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if(UnityEngine.SceneManagement.SceneManager.sceneCount != 1)
        {
                return (bool)0 & 1;
        }
        
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世() != null)
        {
                if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        val_46 = null;
        val_46 = null;
        if(ClansController.丑丏丛不丂丄上且丈 == true)
        {
                return (bool)0 & 1;
        }
        
        UnityEngine.SceneManagement.Scene val_34 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
        if(val_34.m_Handle.isLoaded == false)
        {
                return (bool)0 & 1;
        }
        
        bool val_39 = (System.String.op_Inequality(a:  val_34.m_Handle.name, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) ^ 1;
        return (bool)0 & 1;
    }
    public bool AddBannerToShowQueue(BannerWindowType 世丁丌万丏丟丗世三)
    {
        if(this.CanShowAnyBanner() == false)
        {
                return false;
        }
        
        if(this.丑世不丝万七丁业丌[(long)世丁丌万丏丟丗世三] != false)
        {
                return false;
        }
        
        this.丑世不丝万七丁业丌[(long)世丁丌万丏丟丗世三] = true;
        this.不丁丝丞一丄丄万丂[(long)世丁丌万丏丟丗世三] = true;
        return false;
    }
    private void 七三专丙下业一世上()
    {
        var val_219;
        bool val_220;
        bool val_221;
        var val_222;
        var val_223;
        var val_224;
        var val_225;
        var val_226;
        var val_227;
        var val_228;
        var val_229;
        var val_230;
        string val_153 = 0;
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_151 = 0;
        if(this.世三不丙丁世丕上东 != false)
        {
                return;
        }
        
        if(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丆丂丄丌丝丅上业丒() != false)
        {
                if(PGCompany.TutorialHintUI.丈丐丞丐上丑且丕万() == true)
        {
                return;
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  176)) == false)
        {
                return;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
            if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
        {
                return;
        }
        
        }
        
        UnityEngine.SceneManagement.Scene val_12 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_12.m_Handle.name, b:  "FortFieldBuild")) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_12.m_Handle.name, b:  "ClanTankBuild")) == true)
        {
                return;
        }
        
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == true)
        {
                return;
        }
        
        }
        
        if(SeasonEndView.世丑丗上丘丟丐丂丕 == true)
        {
                return;
        }
        
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() == null)
        {
                return;
        }
        
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(GiftBannerWindow.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
        {
                return;
        }
        
        if(Rilisoft.Nest.丑七不且上丗丁一世() != 0)
        {
                if(Rilisoft.Nest.丑七不且上丗丁一世().BannerIsVisible == true)
        {
                return;
        }
        
        }
        
        if(ClansController.丑丏丛不丂丄上且丈 == true)
        {
                return;
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (一丅三东丑丗丅丗丝.业业业业东丛丁世丏() != false))
        {
                if(this.丑世不丝万七丁业丌[7] != true)
        {
                this.丑世不丝万七丁业丌[7] = true;
            this.不丁丝丞一丄丄万丂[7] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().东丈丏丕且一与世丕() != false))
        {
                if(this.丑世不丝万七丁业丌[7] != true)
        {
                this.丑世不丝万七丁业丌[7] = true;
            this.不丁丝丞一丄丄万丂[7] = true;
        }
        
        }
        
        if(ClanWarUI.丈丐丞丐上丑且丕万() == true)
        {
                return;
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
            
        }
        else
        {
                bool val_41 = PGCompany.ClanPromotionBanner.丕世一与业丅万专丑();
        }
        
        this.丑世不丝万七丁业丌[8] = val_41;
        this.不丁丝丞一丄丄万丂[8] = val_41;
        if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
            
        }
        else
        {
                bool val_44 = PGCompany.ClanAutoReceiptOfGiftBanner.丕世一与业丅万专丑();
        }
        
        this.丑世不丝万七丁业丌[7] = val_44;
        this.不丁丝丞一丄丄万丂[7] = val_44;
        bool val_46 = ClanChangeRegionBannerController.丂丙上且不丟业丛丒();
        this.丑世不丝万七丁业丌[7] = val_46;
        this.不丁丝丞一丄丄万丂[7] = val_46;
        bool val_48 = ClanSetMinimumRankBannerController.丂丙上且不丟业丛丒();
        this.丑世不丝万七丁业丌[8] = val_48;
        this.不丁丝丞一丄丄万丂[8] = val_48;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
        {
                return;
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() != true)
        {
                if(Rilisoft.GameEventOpenChestBase.丈丐丞丐上丑且丕万() != false)
        {
            
        }
        else
        {
                bool val_54 = UniversalRewardController.业丗丝万专万丞丟上();
        }
        
        }
        
        this.丑世不丝万七丁业丌[10] = val_54;
        this.不丁丝丞一丄丄万丂[10] = val_54;
        if((与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != false) && (PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世().三专丆上丞万上丒丑() != false))
        {
                if(this.丑世不丝万七丁业丌[0] != true)
        {
                PGCompany.丅丗且下丈业丌与丞.丝东三丂丗一专与丗 = true;
            this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        }
        
        if((AdmobPerelivWindow.世丝一且丏三丄丞丙 == 0) || ((System.String.IsNullOrEmpty(value:  AdmobPerelivWindow.一一三丘丒且与丄万)) == true))
        {
            goto label_183;
        }
        
        if((Rilisoft.Nest.丑七不且上丗丁一世() == 0) || (Rilisoft.Nest.丑七不且上丗丁一世().BannerIsVisible == false))
        {
            goto label_176;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_183;
        }
        
        UnityEngine.Debug.Log(message:  "Skipping fake interstitial while Nest Banner is active.");
        goto label_183;
        label_176:
        if(this.丑世不丝万七丁业丌[0] != true)
        {
                this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        label_183:
        if((((((PGCompany.ConnectSceneRollBackMigrationBanner.丌七丘七丗下丐七丞() != false) && (this.丑世不丝万七丁业丌[0] != true)) && (MainMenuController.丄丞丁丈与业上丞丟 != 0)) && (activeInHierarchy != false)) && (MainMenuController.丄丞丁丈与业上丞丟.丂丙丈与世专上丒上() != true)) && ((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) != true))
        {
                if(MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends != true)
        {
                this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        }
        
        this.丛世下丙丞丑丑与丏();
        if(this.丒业且上业丄丘世业() == false)
        {
            goto label_219;
        }
        
        label_818:
        if((UnityEngine.PlayerPrefs.GetInt(key:  "leave_from_duel_penalty")) != 0)
        {
                if(Rilisoft.Nest.丑七不且上丗丁一世() != 0)
        {
                if(Rilisoft.Nest.丑七不且上丗丁一世().BannerIsVisible == true)
        {
            goto label_235;
        }
        
        }
        
            if(CompetitionConnectWindow.三丛丂丂专丕上丅世() != true)
        {
                if(this.丑世不丝万七丁业丌[1] != true)
        {
                this.丑世不丝万七丁业丌[1] = true;
            this.不丁丝丞一丄丄万丂[1] = true;
        }
        
        }
        
        }
        
        label_235:
        if(Rilisoft.Nest.丑七不且上丗丁一世() == 0)
        {
            goto label_244;
        }
        
        val_219 = Rilisoft.Nest.丑七不且上丗丁一世();
        if(val_219.BannerIsVisible == true)
        {
            goto label_671;
        }
        
        label_244:
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (MailBoxRewardController.丁丆丟东上且上丕丑() != false))
        {
                if(this.丑世不丝万七丁业丌[6] != true)
        {
                this.丑世不丝万七丁业丌[6] = true;
            this.不丁丝丞一丄丄万丂[6] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (Rilisoft.RollbackEggsAndTournamentBannerWindow.丂丙上且不丟业丛丒() != false))
        {
                if(this.丑世不丝万七丁业丌[3] != true)
        {
                this.丑世不丝万七丁业丌[3] = true;
            this.不丁丝丞一丄丄万丂[3] = true;
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() != true)
        {
                if(Rilisoft.PrivacyBannerWindow.丂丙上且不丟业丛丒() != false)
        {
                if(this.丑世不丝万七丁业丌[0] == false)
        {
            goto label_282;
        }
        
        }
        
        }
        
        label_795:
        this.丑世不丝万七丁业丌[0] = false;
        this.不丁丝丞一丄丄万丂[0] = false;
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (PGCompany.UpdateBanner.UpdateBannerController.丁七下丌丏丄丟上三() != false))
        {
                if(this.丑世不丝万七丁业丌[8] != true)
        {
                this.丑世不丝万七丁业丌[8] = true;
            this.不丁丝丞一丄丄万丂[8] = true;
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() != true)
        {
                if(NickNameValidationBanner.丁七下丌丏丄丟上三() != false)
        {
                if(this.丑世不丝万七丁业丌[0] == false)
        {
            goto label_308;
        }
        
        }
        
        }
        
        label_797:
        this.丑世不丝万七丁业丌[0] = false;
        this.不丁丝丞一丄丄万丂[0] = false;
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.EventHub.EventHubBanner.丁七下丌丏丄丟上三() != false))
        {
                if(this.丑世不丝万七丁业丌[1] != true)
        {
                this.丑世不丝万七丁业丌[1] = true;
            this.不丁丝丞一丄丄万丂[1] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.Banners.NewCompetitionBanner.丁七下丌丏丄丟上三() != false))
        {
                if(this.丑世不丝万七丁业丌[12] != true)
        {
                this.丑世不丝万七丁业丌[12] = true;
            this.不丁丝丞一丄丄万丂[12] = true;
        }
        
        }
        
        if(this.与丝东专上丕丂不丕() != false)
        {
                if(PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世().丆下丝丟丛不三丟丟() != false)
        {
                this.丑世不丝万七丁业丌[1] = true;
            this.不丁丝丞一丄丄万丂[1] = true;
        }
        
        }
        
        if(this.与丝东专上丕丂不丕() != false)
        {
                if(NewLobbyBanner.丕世一与业丅万专丑() != false)
        {
                this.丑世不丝万七丁业丌[13] = true;
            this.不丁丝丞一丄丄万丂[13] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (Rilisoft.GameEventOpenChest.丁七下丌丏丄丟上三() != false))
        {
                if(this.丑世不丝万七丁业丌[9] != true)
        {
                this.丑世不丝万七丁业丌[9] = true;
            this.不丁丝丞一丄丄万丂[9] = true;
        }
        
        }
        
        if((this.丑丙上丙与丟三丕专() != true) && (PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().世东丑丁上业专丏丙() != false))
        {
                if(this.丑世不丝万七丁业丌[0] != true)
        {
                this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().世丗一下丈万专且专() != false))
        {
                if(this.丑世不丝万七丁业丌[(long)PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().丁丆丝丁不丌丌丂丅()] != true)
        {
                this.丑世不丝万七丁业丌[(long)PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().丁丆丝丁不丌丌丂丅()] = true;
            this.不丁丝丞一丄丄万丂[(long)PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().丁丆丝丁不丌丌丂丅()] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丞不丗丄丞丘丛丙东() != false))
        {
                if(this.丑世不丝万七丁业丌[10] != true)
        {
                this.丑世不丝万七丁业丌[10] = true;
            this.不丁丝丞一丄丄万丂[10] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丛丝与七一丏不七一() != false))
        {
                if(this.丑世不丝万七丁业丌[11] != true)
        {
                this.丑世不丝万七丁业丌[11] = true;
            this.不丁丝丞一丄丄万丂[11] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丞不丗丄丞丘丛丙东() != false))
        {
                if(this.丑世不丝万七丁业丌[11] != true)
        {
                this.丑世不丝万七丁业丌[11] = true;
            this.不丁丝丞一丄丄万丂[11] = true;
        }
        
        }
        
        if(PGCompany.Banners.FreePlayModeInfo.丞丈上丙丟七丄丗东() != false)
        {
                if(this.丑世不丝万七丁业丌[10] != true)
        {
                this.丑世不丝万七丁业丌[10] = true;
            this.不丁丝丞一丄丄万丂[10] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (this.丑世不丝万七丁业丌[10] != true))
        {
                if((NotificationWindowController.丂东下不丆专丌丈丆() != false) && ((1152921505102430256 & 1) != 0))
        {
                this.丑世不丝万七丁业丌[10] = true;
            this.不丁丝丞一丄丄万丂[10] = true;
        }
        
        }
        
        if(Rilisoft.SubscriptionEmailWindow.丂丙上且不丟业丛丒() != false)
        {
                if(this.丑世不丝万七丁业丌[0] != true)
        {
                this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        }
        
        if(Rilisoft.SubscriptionEmailErrorWindow.丂丙上且不丟业丛丒() != false)
        {
                if(this.丑世不丝万七丁业丌[0] != true)
        {
                this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (Rilisoft.AutofireWelcomeWindow.丂丙上且不丟业丛丒() != false))
        {
                if(this.丑世不丝万七丁业丌[4] != true)
        {
                this.丑世不丝万七丁业丌[4] = true;
            this.不丁丝丞一丄丄万丂[4] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (Rilisoft.AutofireDisabledWindow.丂丙上且不丟业丛丒() != false))
        {
                if(this.丑世不丝万七丁业丌[5] != true)
        {
                this.丑世不丝万七丁业丌[5] = true;
            this.不丁丝丞一丄丄万丂[5] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (PGCompany.GadgetLevelsMigrationFeb2020.丂丙上且不丟业丛丒() != false))
        {
                if(this.丑世不丝万七丁业丌[6] != true)
        {
                this.丑世不丝万七丁业丌[6] = true;
            this.不丁丝丞一丄丄万丂[6] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (LobbySeasonBanner.丂丙上且不丟业丛丒() != false))
        {
                if(this.丑世不丝万七丁业丌[9] != true)
        {
                this.丑世不丝万七丁业丌[9] = true;
            this.不丁丝丞一丄丄万丂[9] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().丞不丗丄丞丘丛丙东() != false))
        {
                if(this.丑世不丝万七丁业丌[10] != true)
        {
                this.丑世不丝万七丁业丌[10] = true;
            this.不丁丝丞一丄丄万丂[10] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().丞不丗丄丞丘丛丙东() != false))
        {
                if(this.丑世不丝万七丁业丌[9] != true)
        {
                this.丑世不丝万七丁业丌[9] = true;
            this.不丁丝丞一丄丄万丂[9] = true;
        }
        
        }
        
        if(PGCompany.UnequipClanArmorBanner.丂丙上且不丟业丛丒() != false)
        {
                if(this.丑世不丝万七丁业丌[7] != true)
        {
                this.丑世不丝万七丁业丌[7] = true;
            this.不丁丝丞一丄丄万丂[7] = true;
        }
        
        }
        
        if((((ConnectScene.丈丘丂丙不丛业丟三() != true) && (PGCompany.MobileOperatorBillingWindow.丂丙上且不丟业丛丒() != false)) && (this.丑世不丝万七丁业丌[5] != true)) && (LeaderboardsGui.丑丙丗世丏丞万世丒() != true))
        {
                if(LeaderboardsClans.丑丙丗世丏丞万世丒() != true)
        {
                this.丑世不丝万七丁业丌[5] = true;
            this.不丁丝丞一丄丄万丂[5] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (EventStoreBannerWindow.CanShow != false))
        {
                if(this.丑世不丝万七丁业丌[4] != true)
        {
                this.丑世不丝万七丁业丌[4] = true;
            this.不丁丝丞一丄丄万丂[4] = true;
        }
        
        }
        
        if(PGCompany.ConnectSceneRollBackMigrationBanner.丌七丘七丗下丐七丞() != false)
        {
                if(this.丑世不丝万七丁业丌[0] != true)
        {
                this.丑世不丝万七丁业丌[0] = true;
            this.不丁丝丞一丄丄万丂[0] = true;
        }
        
        }
        
        if((ConnectScene.丈丘丂丙不丛业丟三() != true) && (ClanWarRegistrationNotification.业丗丝万专万丞丟上() != false))
        {
                if(this.丑世不丝万七丁业丌[6] != true)
        {
                this.丑世不丝万七丁业丌[6] = true;
            this.不丁丝丞一丄丄万丂[6] = true;
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_585;
        }
        
        val_220 = 0;
        goto label_586;
        label_219:
        if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_151)) == false)
        {
                return;
        }
        
        if((PGCompany.DataObjects.三丛丂丟与不专丛丏.七三丟三丛上东丒且(上世丏丁世丟世丆业:  val_151, 七丆丒与丗丌丄且丂: out  val_153)) == false)
        {
                return;
        }
        
        if((((Rilisoft.且且丌与专丐一东一.丑七不且上丗丁一世().专万丗丁丗下不丂丈(七丆丒与丗丌丄且丂:  val_153).世丑三丆丒七丘丕丑()) == false) || (this.advertiseController == 0)) || (this.advertiseController.CurrentState != 5))
        {
            goto label_818;
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_604;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_818;
        }
        
        label_810:
        UnityEngine.Debug.Log(message:  "Skipping pereliv in Connect Scene.");
        goto label_818;
        label_585:
        val_220 = PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丏万一丕三下丒丗三();
        label_586:
        this.丑世不丝万七丁业丌[4] = val_220;
        this.不丁丝丞一丄丄万丂[4] = val_220;
        if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
                val_221 = 0;
        }
        else
        {
                val_221 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丙丝丞一下上丅下与();
        }
        
        this.丑世不丝万七丁业丌[5] = val_221;
        this.不丁丝丞一丄丄万丂[5] = val_221;
        if((((this.丒业且上业丄丘世业() != true) && (ConnectScene.丈丘丂丙不丛业丟三() != true)) && (this.丄丄丁丗且丐丘丟丅() != true)) && (this.万丌丙丆丅上万丙丛() != true))
        {
                if(this.丑世不丝万七丁业丌[2] != true)
        {
                val_222 = static_value_081DACA8;
            val_222 = static_value_081DACA8;
            bool val_171 = Rilisoft.丛下丟丌上下丞丗丐.丑七不且上丗丁一世().丛丏丈东与丂东丝丐();
        }
        
        }
        
        val_223 = static_value_081DACA8;
        val_223 = static_value_081DACA8;
        if(((this.丒业且上业丄丘世业() != true) && (ConnectScene.丈丘丂丙不丛业丟三() != true)) && (EventRewardBannerWindow.丌七丘七丗下丐七丞() != false))
        {
                if(this.丑世不丝万七丁业丌[2] != true)
        {
                this.丑世不丝万七丁业丌[2] = true;
            this.不丁丝丞一丄丄万丂[2] = true;
        }
        
        }
        
        val_219 = static_value_081DACA8;
        val_219 = static_value_081DACA8;
        val_219 = 0;
        if(ConnectScene.丈丘丂丙不丛业丟三() != true)
        {
                val_219 = 0;
            if(RemoveGadgetCategoryBannerWindow.丌七丘七丗下丐七丞() != false)
        {
                if(this.丑世不丝万七丁业丌 == null)
        {
                val_219 = 0;
        }
        
            if(this.丑世不丝万七丁业丌[4] != true)
        {
                if(this.丑世不丝万七丁业丌 == null)
        {
                val_219 = 0;
        }
        
            this.丑世不丝万七丁业丌[4] = true;
            if(this.不丁丝丞一丄丄万丂 == null)
        {
                val_219 = 0;
        }
        
            this.不丁丝丞一丄丄万丂[4] = true;
        }
        
        }
        
        }
        
        if(this.丑世不丝万七丁业丌 == null)
        {
                val_219 = 0;
        }
        
        if(this.丑世不丝万七丁业丌[6] != true)
        {
                val_219 = 0;
            if(PGCompany.UI.GiftSystem.与丕丒三万丞丝丄丑.丂丙上且不丟业丛丒() != false)
        {
                if(this.丑世不丝万七丁业丌 == null)
        {
                val_219 = 0;
        }
        
            this.丑世不丝万七丁业丌[6] = true;
            if(this.不丁丝丞一丄丄万丂 == null)
        {
                val_219 = 0;
        }
        
            this.不丁丝丞一丄丄万丂[6] = true;
        }
        
        }
        
        label_671:
        if(this.丑丙上丙与丟三丕专() != true)
        {
                val_219 = PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世();
            if(val_219.世东丑丁上业专丏丙() != false)
        {
                if(this.丑世不丝万七丁业丌 == null)
        {
                val_219 = 0;
        }
        
            if(this.丑世不丝万七丁业丌[10] != true)
        {
                if(this.丑世不丝万七丁业丌 == null)
        {
                val_219 = 0;
        }
        
            this.丑世不丝万七丁业丌[10] = true;
            if(this.不丁丝丞一丄丄万丂 == null)
        {
                val_219 = 0;
        }
        
            this.不丁丝丞一丄丄万丂[10] = true;
        }
        
        }
        
        }
        
        if((this.丑丙上丙与丟三丕专() != true) && (NovicePromotionSelectorBanner.CanShowAutomaticaly() != false))
        {
                if(this.丑世不丝万七丁业丌[8] != true)
        {
                this.丑世不丝万七丁业丌[8] = true;
            this.不丁丝丞一丄丄万丂[8] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.DoubleOfferBanner.丆下丝丟丛不三丟丟() != false))
        {
                if(this.丑世不丝万七丁业丌[11] != true)
        {
                this.丑世不丝万七丁业丌[11] = true;
            this.不丁丝丞一丄丄万丂[11] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.NoviceDoubleOfferBanner.丆下丝丟丛不三丟丟() != false))
        {
                if(this.丑世不丝万七丁业丌[12] != true)
        {
                this.丑世不丝万七丁业丌[12] = true;
            this.不丁丝丞一丄丄万丂[12] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (Subscription20.万丞且丐世丙丄丄丌.丆下丝丟丛不三丟丟() != false))
        {
                if(this.丑世不丝万七丁业丌[12] != true)
        {
                this.丑世不丝万七丁业丌[12] = true;
            this.不丁丝丞一丄丄万丂[12] = true;
        }
        
        }
        
        if((this.与丝东专上丕丂不丕() != false) && (PGCompany.丕一业万丂丟丄丘丙.丆下丝丟丛不三丟丟() != false))
        {
                if(this.丑世不丝万七丁业丌[12] != true)
        {
                this.丑世不丝万七丁业丌[12] = true;
            this.不丁丝丞一丄丄万丂[12] = true;
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() != true)
        {
                val_224 = static_value_081DACA8;
            val_224 = static_value_081DACA8;
            if(TierBundleBanner.CanShowAutomaticaly() != false)
        {
                val_225 = null;
            val_225 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_226 = null;
            val_226 = null;
            if(activeInHierarchy != false)
        {
                val_227 = null;
            val_227 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.丂丙丈与世专上丒上() != true)
        {
                val_228 = null;
            val_228 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) != true)
        {
                val_229 = null;
            val_229 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends != true)
        {
                this.丑世不丝万七丁业丌[8] = true;
            this.不丁丝丞一丄丄万丂[8] = true;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        if(this.世世丞三丌丂丅七不 == true)
        {
                return;
        }
        
        val_230 = static_value_081DACA8;
        val_230 = static_value_081DACA8;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        System.TimeSpan val_202 = System.TimeSpan.FromHours(value:  (double)this.上不丅丝丗一七丈丞);
        if((专七专下且专三一且.上且一丈丐三丄一丆() - BannerWindowController.上丞业不不丐业丏丟()) <= (long)val_202._ticks.TotalSeconds)
        {
                if(((专七专下且专三一且.上且一丈丐三丄一丆() - BannerWindowController.上丞业不不丐业丏丟()) & 9223372036854775808) == 0)
        {
                return;
        }
        
        }
        
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() == true)
        {
                return;
        }
        
        if(this.丑世不丝万七丁业丌[1] == true)
        {
                return;
        }
        
        this.丑世不丝万七丁业丌[1] = true;
        this.不丁丝丞一丄丄万丂[1] = true;
        return;
        label_282:
        PGCompany.丗三万丁三丗上专丟 val_263 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        val_263 = val_263.丟丂下七且七东丛丞(不七丆万丁一丞七下:  20);
        goto label_795;
        label_308:
        PGCompany.丗三万丁三丗上专丟 val_264 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        val_264 = val_264.丟丂下七且七东丛丞(不七丆万丁一丞七下:  20);
        goto label_797;
        label_604:
        if((Rilisoft.Nest.丑七不且上丗丁一世() == 0) || (Rilisoft.Nest.丑七不且上丗丁一世().BannerIsVisible == false))
        {
            goto label_806;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_818;
        }
        
        goto label_810;
        label_806:
        if(this.丑世不丝万七丁业丌[1] == true)
        {
            goto label_818;
        }
        
        this.丑世不丝万七丁业丌[1] = true;
        this.不丁丝丞一丄丄万丂[1] = true;
        goto label_818;
    }
    private bool 丑丙上丙与丟三丕专()
    {
        var val_39;
        ProfileView val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_39 = 1152921505248804864;
        val_40 = ProfileView.丄丞丁丈与业上丞丟;
        if(val_40 != 0)
        {
                val_40 = mem[ProfileView.丄丞丁丈与业上丞丟 + 48];
            val_40 = ProfileView.丄丞丁丈与业上丞丟.interfaceHolder;
            if(activeSelf == true)
        {
                return true;
        }
        
        }
        
        if(ChooseProgressWindow.七三丂丕丕世丙上不() == true)
        {
                return true;
        }
        
        if(UniversalRewardBanner.丈丐丞丐上丑且丕万() == true)
        {
                return true;
        }
        
        if(Rilisoft.GameEventOpenChestBase.丈丐丞丐上丑且丕万() == true)
        {
                return true;
        }
        
        if(LootBoxBanner.丈丐丞丐上丑且丕万() == true)
        {
                return true;
        }
        
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
                return true;
        }
        
        if(ClanWarUI.丈丐丞丐上丑且丕万() == true)
        {
                return true;
        }
        
        if(MainStoreView.丈丐丞丐上丑且丕万() == true)
        {
                return true;
        }
        
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == true)
        {
                return true;
        }
        
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == true)
        {
                return true;
        }
        
        if(Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐() == true)
        {
                return true;
        }
        
        if(Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐() == true)
        {
                return true;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return true;
        }
        
        val_40 = Rilisoft.Singleton<ClansVisitController>.Instance;
        if(val_15.丕丁不丅丒丑丁丁世 == true)
        {
                return true;
        }
        
        val_39 = 1152921505080860672;
        val_41 = null;
        val_41 = null;
        if(MainMenuController.与丝与丄三丅下丒七 != 9990000)
        {
                return true;
        }
        
        val_42 = null;
        val_42 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_43 = null;
            val_43 = null;
            val_40 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_40.InterfaceEnabled == true)
        {
                return true;
        }
        
        }
        
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 != 0)
        {
                val_40 = ClansWindowInfoViewController.丄丘七三上丕世丞业;
            if(val_40.isActiveAndEnabled == true)
        {
                return true;
        }
        
        }
        
        val_44 = null;
        val_44 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
                val_45 = null;
            val_45 = null;
            val_40 = FriendProfileView.丐丕丝上丅丈丐丞专;
            if(val_40.isActiveAndEnabled == true)
        {
                return true;
        }
        
        }
        
        val_46 = null;
        val_46 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业 != 0)
        {
                val_47 = null;
            val_47 = null;
            val_40 = SquadPanelGUI.丄丘七三上丕世丞业;
            if(SquadPanelGUI.丄丘七三上丕世丞业.isActive == true)
        {
                return true;
        }
        
        }
        
        if(SquadInviteGUI.丄丘七三上丕世丞业 != 0)
        {
                val_40 = SquadInviteGUI.丄丘七三上丕世丞业;
            if(SquadInviteGUI.丄丘七三上丕世丞业.isActive == true)
        {
                return true;
        }
        
        }
        
        val_48 = null;
        val_48 = null;
        val_40 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_40 != 0)
        {
                val_49 = null;
            val_49 = null;
            val_40 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_40.与丙七丞丞不丒丙丘() == true)
        {
                return true;
        }
        
        }
        
        if(PGCompany.Banners.NewCompetitionBanner.七三丂丕丕世丙上不() == true)
        {
                return true;
        }
        
        if(FriendsWindowController.丈丐丞丐上丑且丕万() == true)
        {
                return true;
        }
        
        InfoWindowController val_28 = InfoWindowController.丑七不且上丗丁一世();
        val_40 = val_28.competitionConnectWindow;
        if(val_40.丙东丞丛丝丅世七三() == true)
        {
                return true;
        }
        
        val_50 = null;
        val_50 = null;
        val_40 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_40 == 0)
        {
                return true;
        }
        
        val_51 = null;
        val_51 = null;
        val_40 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_40.丂丙丈与世专上丒上() == true)
        {
                return true;
        }
        
        val_52 = null;
        val_52 = null;
        val_40 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
        val_40 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
        if(val_40.activeInHierarchy == true)
        {
                return true;
        }
        
        val_53 = null;
        val_53 = null;
        val_40 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_40.丄丅世丒一业丝专丕() == true)
        {
                return true;
        }
        
        val_54 = null;
        val_54 = null;
        val_40 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_40.IsOpeningFriends == true)
        {
                return true;
        }
        
        val_55 = null;
        val_55 = null;
        val_40 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_40.丏丆丈专丈丈丈丘丘() == true)
        {
                return true;
        }
        
        val_39 = 1152921505052479488;
        if(ConnectScene.东世三丆东世丈丟不() == true)
        {
                return true;
        }
        
        if(ConnectScene.一下丗不丒丙与七丛() != true)
        {
                val_56 = static_value_081DACA8;
            val_56 = static_value_081DACA8;
            val_57 = mem[static_value_081DACA8 + 184];
            val_57 = static_value_081DACA8 + 184;
        }
        
        return true;
    }
    private bool 丑丘丈丁万下丌世丐()
    {
        return ConnectScene.丈丘丂丙不丛业丟三();
    }
    internal bool 与丝东专上丕丂不丕()
    {
        var val_4;
        bool val_1 = this.丑丙上丙与丟三丕专();
        if(val_1 != false)
        {
                val_4 = 0;
        }
        else
        {
                bool val_2 = val_1.丑丘丈丁万下丌世丐();
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    private bool 丙业丛丆丟丑世丆丂()
    {
        bool val_1 = this.丑丙上丙与丟三丕专();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public void ResetStateBannerShowed(BannerWindowType 丌丅丕一丛丛丄一万)
    {
        var val_4;
        System.Collections.Generic.List<BannerWindow> val_5;
        val_4 = 丌丅丕一丛丛丄一万;
        val_5 = this.bannerWindows;
        if((val_5.Count & 2147483648) != 0)
        {
                return;
        }
        
        val_5 = this.bannerWindows;
        if((val_5.Count - 1) < val_4)
        {
                return;
        }
        
        val_4 = (long)val_4;
        this.丑世不丝万七丁业丌[val_4] = false;
    }
    public bool IsBannerShow(BannerWindowType 世丁丌万丏丟丗世三)
    {
        var val_3;
        if(this.东一丏七业丙万丞丅 != 0)
        {
                return (bool)((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) == 世丁丌万丏丟丗世三) ? 1 : 0;
        }
        
        val_3 = 0;
        return (bool)((this.东一丏七业丙万丞丅.<丟七丒三丙丝丅不不>k__BackingField) == 世丁丌万丏丟丗世三) ? 1 : 0;
    }
    public void ForceShowBanner(BannerWindowType 丌丅丕一丛丛丄一万, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
    {
        this.ForceShowBanner(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丙下丙丈上三丁丅丒:  192, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆不七一丐且不七三 = ???, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = ???}});
    }
    public void ForceShowBanner(BannerWindowType 丌丅丕一丛丛丄一万, string 丙下丙丈上三丁丅丒, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
    {
        if(this.东一丏七业丙万丞丅 != 0)
        {
                this.HideBannerWindowNoShowNext();
        }
        
        if(this.不丁丝丞一丄丄万丂[(long)丌丅丕一丛丛丄一万] != false)
        {
                this.不丁丝丞一丄丄万丂[(long)丌丅丕一丛丛丄一万] = false;
        }
        
        if(this.丑世不丝万七丁业丌[(long)丌丅丕一丛丛丄一万] != false)
        {
                this.丑世不丝万七丁业丌[(long)丌丅丕一丛丛丄一万] = false;
        }
        
        this.丁丅丝丒丂上丘丏丑(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丛万下上万丙下世丂:  false, 丈世且丞专丑丂丐世:  丌专丟丘一不七丅东.丟与丞丗丌丂万丕丝, 丟丘丙丄丅万丏与丗:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆不七一丐且不七三 = ???, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    internal void 专业丗一上专丏七业()
    {
        if(this.东一丏七业丙万丞丅 == 0)
        {
                return;
        }
        
        if(this.东一丏七业丙万丞丅 == null)
        {
            
        }
    
    }
    internal bool 丄丄丁丗且丐丘丟丅()
    {
        if(this.东一丏七业丙万丞丅 == 0)
        {
                return this.万丌丙丆丅上万丙丛();
        }
        
        return true;
    }
    internal bool 不且丝丆丈三与世东(bool 丈丈不丒丗与丝不丗)
    {
        if((this.丄丄丁丗且丐丘丟丅() != false) && (丈丈不丒丗与丝不丗 != false))
        {
                if(this.东一丏七业丙万丞丅 == 0)
        {
                this = 1;
        }
        else
        {
                var val_3 = (this.东一丏七业丙万丞丅 == 0) ? 1 : 0;
        }
        
        }
        
        val_3 = val_3 & 1;
        return (bool)val_3;
    }
    internal bool 万丌丙丆丅上万丙丛()
    {
        var val_2;
        if(this.丑丝丕一丈业七下丏 != null)
        {
                System.Threading.CancellationToken val_1 = this.丑丝丕一丈业七下丏.Token;
            return (bool)val_2 & 1;
        }
        
        val_2 = 0;
        return (bool)val_2 & 1;
    }
    private void 一业丌世三丁丄丑丒()
    {
        东不丞丄三世丟一丂.丞丝丙业东丐万丟丕 val_2 = new 东不丞丄三世丟一丂.丞丝丙业东丐万丟丕();
        if(val_2 != null)
        {
                .不上丛丁三与上专与 = 144002;
            .与不丁丂丙七丏丌七 = 145002;
            .丒丙下丂丕丞万万丕 = 2;
        }
        else
        {
                mem[16] = 144002;
            .与不丁丂丙七丏丌七 = 144002 + 1000;
            mem[24] = 2;
        }
        
        .专专丐丏万丄上丆丌 = 1;
        东不丞丄三世丟一丂.丑七不且上丗丁一世().不东丒丆丆一丛丛丙(丙业与丙丗丝不丈东:  val_2);
    }
    private static BannerWindowController()
    {
        BannerWindowController.丞七丅丒丑万一七专 = 0;
    }

}
