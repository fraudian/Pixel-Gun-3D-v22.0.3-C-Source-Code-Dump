using UnityEngine;
internal sealed class FreeAwardShowHandler : MonoBehaviour
{
    // Fields
    private bool 上丈丛七且与丝丙丌;
    private FreeAwardShowHandler.丆且丄丐专且业丄下 且世丌丄丘丌丅丗丄;
    private UnityEngine.Collider 丕丈丝丐一丒三丕与;
    private int 丙丂三丘丁丂丄且丕;
    private TextMeshBounds _headerTextTimer;
    private FreeAwardShowHandler.丆且丄丐专且业丄下 下丐丝与丈丂下不丘;
    private System.Threading.CancellationTokenSource 丅丐丈下丗丂七业丐;
    public UnityEngine.GameObject chestModelGems;
    public UnityEngine.GameObject freeAwardGuiPrefab;
    public TextMeshBounds HeaderTextGems;
    private UnityEngine.GameObject _chestModelTrygun;
    private TextMeshBounds _headerTextTrygun;
    private static FreeAwardShowHandler <不丁丄七丛不丆丁丕>k__BackingField;
    private UnityEngine.BoxCollider 万丄丏丟丏丞丗丟丐;
    private readonly System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> 三丆丆丕丂丟丕与丐;
    private readonly System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3> 丐三丕丟丈一丗丕一;
    private static UnityEngine.Color 上丙丛丁万不丑下世;
    private static UnityEngine.Color 万丙一七业丄丆丘万;
    
    // Properties
    internal static FreeAwardShowHandler 丆丕丝丒不丙且丐丗 { get; set; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    private TextMeshBounds 丝丈丌丄丗丑丕与丂 { get; }
    public bool 丟丟丂丑下下且丟丗 { get; set; }
    private UnityEngine.Collider 丁东丁丙丅且丆且下 { get; }
    
    // Methods
    private FreeAwardShowHandler()
    {
        this.丙丂三丘丁丂丄且丕 = 0;
        this.丅丐丈下丗丂七业丐 = new System.Threading.CancellationTokenSource();
        mem[1152921537261442280] = 0;
        this.三丆丆丕丂丟丕与丐 = 0;
        mem[1152921537261442304] = 0;
        this.丐三丕丟丈一丗丕一 = 0;
    }
    internal static FreeAwardShowHandler 丑七不且上丗丁一世()
    {
        null = null;
        return (FreeAwardShowHandler)FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(FreeAwardShowHandler 丙业与丙丗丝不丈东)
    {
        null = null;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private TextMeshBounds 丕七不东丝丟丑丑丕()
    {
        return (TextMeshBounds)this._headerTextTimer;
    }
    public bool get_IsInteractable()
    {
        if(this.丕丈丝丐一丒三丕与 == 0)
        {
                return false;
        }
        
        if(this.丕丈丝丐一丒三丕与 != null)
        {
                return this.丕丈丝丐一丒三丕与.enabled;
        }
        
        return this.丕丈丝丐一丒三丕与.enabled;
    }
    public void set_IsInteractable(bool 丙业与丙丗丝不丈东)
    {
        if(this.丕丈丝丐一丒三丕与 == 0)
        {
                return;
        }
        
        this.丕丈丝丐一丒三丕与.enabled = 丙业与丙丗丝不丈东;
    }
    private UnityEngine.Collider 丈丙丙丑万丁丌丙丑()
    {
        return (UnityEngine.Collider)this.丕丈丝丐一丒三丕与;
    }
    private void 丞万专丒丁丒丅丙丆()
    {
        if(this.HeaderTextGems == 0)
        {
                return;
        }
        
        if(this.HeaderTextGems.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.专丛丌下丌不丘丄下();
    }
    private void Awake()
    {
        FreeAwardShowHandler.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        if(FreeAwardController.世丒丞七专三与万丕 == 0)
        {
                if(this.freeAwardGuiPrefab != 0)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.freeAwardGuiPrefab, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
        }
        
        }
        
        this.万丄丏丟丏丞丗丟丐 = this.GetComponent<UnityEngine.BoxCollider>();
        I2.Loc.丗丈下丕丟丟丙七丞.三世丅丁丝丟丛丄丝(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FreeAwardShowHandler::丞万专丒丁丒丅丙丆()));
        FreeAwardChestWeaponController.丆丏丝丐世丗丘三丛(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FreeAwardShowHandler::丒与丝丄丑业不丐业(bool 丏业丟一东丂东丘丛)));
    }
    private void Start()
    {
        this.专丛丌下丌不丘丄下();
        if(this._headerTextTrygun == 0)
        {
                return;
        }
        
        this._headerTextTrygun.LocalizationKey = "Key_6919";
        this._headerTextTrygun.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6919");
    }
    private void 丒与丝丄丑业不丐业(bool 丏业丟一东丂东丘丛 = False)
    {
        if(丏业丟一东丂东丘丛 == false)
        {
            goto label_0;
        }
        
        this.万丄丏丟丏丞丗丟丐.center = new UnityEngine.Vector3() {x = this.丐三丕丟丈一丗丕一, y = V9.16B, z = V10.16B};
        if(this.万丄丏丟丏丞丗丟丐 != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.万丄丏丟丏丞丗丟丐.size = new UnityEngine.Vector3() {x = this.丐三丕丟丈一丗丕一, y = V9.16B, z = V10.16B};
        return;
        label_0:
        this.万丄丏丟丏丞丗丟丐.center = new UnityEngine.Vector3() {x = this.三丆丆丕丂丟丕与丐, y = V9.16B, z = V10.16B};
        if(this.万丄丏丟丏丞丗丟丐 != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    private void 专丛丌下丌不丘丄下()
    {
        var val_6;
        string val_7;
        UnityEngine.Color val_8;
        var val_10;
        var val_13;
        if(this.HeaderTextGems == 0)
        {
                return;
        }
        
        val_6 = null;
        val_7 = "Key_3994";
        val_6 = null;
        val_8 = FreeAwardShowHandler.上丙丛丁万不丑下世;
        val_10 = null;
        if(FreeAwardChestWeaponController.丑丞七一七丈丄七与() != false)
        {
                val_13 = null;
            val_7 = "Key_11849";
            val_13 = null;
            val_8 = FreeAwardShowHandler.万丙一七业丄丆丘万;
        }
        
        if((System.String.op_Inequality(a:  this.HeaderTextGems.LocalizationKey, b:  val_7)) == false)
        {
                return;
        }
        
        this.HeaderTextGems.LocalizationKey = val_7;
        this.HeaderTextGems.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7);
        this.HeaderTextGems.Color = new UnityEngine.Color() {r = val_8, g = FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_1C, b = FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_20, a = FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_24};
    }
    private void OnEnable()
    {
        var val_9;
        this.上丈丛七且与丝丙丌 = true;
        val_9 = null;
        this.丈丑丈三且且且下丌(丌且丁丐丁丅上丏丅:  FreeAwardShowHandler.世丈且业丆丑丏丐一());
        this.上丈丛七且与丝丙丌 = false;
        PGCompany.Ads.丒三丕三上丟与丈丆.丑七不且上丗丁一世().业丟丈下且东业不不(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void FreeAwardShowHandler::丝丘丟丂丒东下丈丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void FreeAwardShowHandler::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丗丙丞丁丙丘丒丗东());
    }
    private void OnDisable()
    {
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void FreeAwardShowHandler::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        PGCompany.Ads.丒三丕三上丟与丈丆.丑七不且上丗丁一世().专东丙丗七丁丄丛丂(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void FreeAwardShowHandler::丝丘丟丂丒东下丈丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丝丘丟丂丒东下丈丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.上丈丛七且与丝丙丌 = true;
    }
    private void 丌且且一丌一且丗丌(bool 丌且丁丐丁丅上丏丅)
    {
        this.丈丑丈三且且且下丌(丌且丁丐丁丅上丏丅:  丌且丁丐丁丅上丏丅);
        this.上丈丛七且与丝丙丌 = false;
    }
    private void 丈丑丈三且且且下丌(bool 丌且丁丐丁丅上丏丅)
    {
        var val_15;
        object val_16;
        string val_6 = 0;
        if(this.丕丈丝丐一丒三丕与 == 0)
        {
                this.丕丈丝丐一丒三丕与 = this.gameObject.GetComponent<UnityEngine.Collider>();
        }
        
        if(Rilisoft.与丄丁丄丙丞下下丙.丒丐丆丘丈丟丂下专() != false)
        {
                if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
            goto label_6;
        }
        
        }
        
        if((FreeAwardShowHandler.丒丒丟丄业丆丆三丐(丁丂丕与丁丒丕丟丞: out  val_6)) == false)
        {
            goto label_9;
        }
        
        if(丌且丁丐丁丅上丏丅 == false)
        {
            goto label_32;
        }
        
        label_33:
        val_15 = "[Free…dler.RefreshCore] SetInterfaceActive: None, TryGetReasonToOmitChest: "("[Free…dler.RefreshCore] SetInterfaceActive: None, TryGetReasonToOmitChest: ") + val_6;
        goto label_13;
        label_9:
        if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
        {
            goto label_14;
        }
        
        if(PGCompany.七丟世上与且丈丂丅.丑七不且上丗丁一世().专丕丑丂丝一七业丒() == false)
        {
            goto label_16;
        }
        
        if(丌且丁丐丁丅上丏丅 == false)
        {
            goto label_38;
        }
        
        UnityEngine.Debug.Log(message:  "[Free…dler.RefreshCore] SetInterfaceActive: Trygun");
        goto label_38;
        label_6:
        if(丌且丁丐丁丅上丏丅 == false)
        {
            goto label_32;
        }
        
        val_16 = "[Free…dler.RefreshCore] SetInterfaceActive: None, IsWsa";
        goto label_24;
        label_14:
        if(丌且丁丐丁丅上丏丅 == false)
        {
            goto label_32;
        }
        
        val_16 = "[Free…dler.RefreshCore] SetInterfaceActive: None, TryGetServerUniversalTime";
        label_24:
        label_13:
        UnityEngine.Debug.Log(message:  val_16);
        label_32:
        label_38:
        this.三丒丌与七丄世丐下(上丈丒丁丂七丆上丑:  0, 业丅与与丝丄专丞七:  new System.Nullable<System.DateTime>() {HasValue = false});
        return;
        label_16:
        if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丒丒丟丄业丆丆三丐(丁丂丕与丁丒丕丟丞: out  val_6)) == false)
        {
            goto label_31;
        }
        
        if(丌且丁丐丁丅上丏丅 == false)
        {
            goto label_32;
        }
        
        goto label_33;
        label_31:
        bool val_14 = this.chestModelGems.activeInHierarchy;
        if(丌且丁丐丁丅上丏丅 == false)
        {
            goto label_38;
        }
        
        UnityEngine.Debug.Log(message:  "[Free…dler.RefreshCore] SetInterfaceActive: Gems");
        goto label_38;
    }
    private void Update()
    {
        var val_5;
        if(this.上丈丛七且与丝丙丌 == false)
        {
            goto label_1;
        }
        
        val_5 = null;
        label_6:
        this.丈丑丈三且且且下丌(丌且丁丐丁丅上丏丅:  FreeAwardShowHandler.世丈且业丆丑丏丐一());
        this.上丈丛七且与丝丙丌 = false;
        return;
        label_1:
        if((UnityEngine.Time.frameCount & 63) == 0)
        {
            goto label_6;
        }
    
    }
    private void OnDestroy()
    {
        I2.Loc.丗丈下丕丟丟丙七丞.丑丘丆丘世丕丌专七(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FreeAwardShowHandler::丞万专丒丁丒丅丙丆()));
        FreeAwardChestWeaponController.东丘丞丏丐丅丞专一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FreeAwardShowHandler::丒与丝丄丑业不丐业(bool 丏业丟一东丂东丘丛)));
        FreeAwardShowHandler.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
    }
    private void 上丛业丙丙七丒丝丁(bool 丛丅丘一丏丙且丌上, string 丕丗丘丑丛与丑业丒)
    {
        string val_8;
        var val_9;
        val_8 = 丕丗丘丑丛与丑业丒;
        if(丛丅丘一丏丙且丌上 != true)
        {
                val_9 = null;
            if(FreeAwardShowHandler.世丈且业丆丑丏丐一() != false)
        {
                System.Threading.CancellationToken val_2 = this.丅丐丈下丗丂七业丐.Token;
            if(((-1702450696) & 1) == 0)
        {
                UnityEngine.Debug.Log(message:  "[FreeAwardShowHandler.SetTimer] Stopping timer coroutine.");
        }
        
        }
        
            this.丅丐丈下丗丂七业丐.Cancel();
        }
        
        if(this._headerTextTimer == 0)
        {
                return;
        }
        
        if(val_8 == null)
        {
            goto label_13;
        }
        
        label_22:
        this._headerTextTimer.Text = val_8;
        val_8 = this._headerTextTimer.gameObject;
        if(val_8 == 0)
        {
                return;
        }
        
        this._headerTextTimer.gameObject.SetActive(value:  丛丅丘一丏丙且丌上);
        return;
        label_13:
        if(this._headerTextTimer != null)
        {
            goto label_22;
        }
        
        goto label_22;
    }
    private void 下丒丝丕丟丐专下上(FreeAwardShowHandler.丆且丄丐专且业丄下 上丈丒丁丂七丆上丑, System.DateTime 业丅与与丝丄专丞七, float 世下丗丝丝丄一丗七)
    {
        var val_9 = null;
        if(FreeAwardShowHandler.世丈且业丆丑丏丐一() != false)
        {
                System.Threading.CancellationToken val_2 = this.丅丐丈下丗丂七业丐.Token;
            if(((-1702272936) & 1) == 0)
        {
                UnityEngine.Debug.Log(message:  "[FreeAwardShowHandler.StartRefreshingTimer] Stopping timer coroutine.");
        }
        
        }
        
        this.丅丐丈下丗丂七业丐.Cancel();
        System.Threading.CancellationTokenSource val_3 = new System.Threading.CancellationTokenSource();
        this.丅丐丈下丗丂七业丐 = val_3;
        if(上丈丒丁丂七丆上丑 != 2)
        {
                if(上丈丒丁丂七丆上丑 != 1)
        {
                return;
        }
        
            System.Threading.CancellationToken val_4 = val_3.Token;
            System.Collections.IEnumerator val_5 = this.丁丝丞三不丈丞丝丟(业丅与与丝丄专丞七:  new System.DateTime() {dateData = val_4.m_source}, 丏丘东世丞丌丄万丄:  世下丗丝丝丄一丗七, 业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_4.m_source});
        }
        else
        {
                System.Threading.CancellationToken val_6 = val_3.Token;
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丈丘世世三丟丑丟一(业丅与与丝丄专丞七:  new System.DateTime() {dateData = val_6.m_source}, 丏丘东世丞丌丄万丄:  世下丗丝丝丄一丗七, 业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_6.m_source}));
    }
    private System.Collections.IEnumerator 丈丘世世三丟丑丟一(System.DateTime 业丅与与丝丄专丞七, float 丏丘东世丞丌丄万丄, System.Threading.CancellationToken 业丘丝业丛丆丄一上)
    {
        FreeAwardShowHandler.丗丘丞七丙丕丘东万 val_1 = new FreeAwardShowHandler.丗丘丞七丙丕丘东万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丁丝丞三不丈丞丝丟(System.DateTime 业丅与与丝丄专丞七, float 丏丘东世丞丌丄万丄, System.Threading.CancellationToken 业丘丝业丛丆丄一上)
    {
        FreeAwardShowHandler.不七业丄丞丒一丒丑 val_1 = new FreeAwardShowHandler.不七业丄丞丒一丒丑();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 三丒丌与七丄世丐下(FreeAwardShowHandler.丆且丄丐专且业丄下 上丈丒丁丂七丆上丑, System.Nullable<System.DateTime> 业丅与与丝丄专丞七)
    {
        UnityEngine.Collider val_19;
        var val_20;
        ulong val_21;
        丆且丄丐专且业丄下 val_23;
        var val_24;
        val_19 = this.丕丈丝丐一丒三丕与;
        if(val_19 == 0)
        {
            goto label_3;
        }
        
        if(上丈丒丁丂七丆上丑 == 0)
        {
            goto label_4;
        }
        
        val_19 = FreeAwardController.世丒丞七专三与万丕;
        if(val_19 != 0)
        {
            goto label_8;
        }
        
        label_4:
        this.丕丈丝丐一丒三丕与.enabled = false;
        label_3:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.chestModelGems, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._chestModelTrygun, 丏业丟一东丂东丘丛:  false);
        this.丛丂丈上丒丑丒丛七(上丈丒丁丂七丆上丑:  0);
        this.下丐丝与丈丂下不丘 = 0;
        this.上丛业丙丙七丒丝丁(丛丅丘一丏丙且丌上:  false, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        return;
        label_8:
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != false)
        {
                this.丕丈丝丐一丒三丕与.enabled = false;
            this.丛丂丈上丒丑丒丛七(上丈丒丁丂七丆上丑:  0);
            this.下丐丝与丈丂下不丘 = 0;
            this.上丛业丙丙七丒丝丁(丛丅丘一丏丙且丌上:  false, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.chestModelGems, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._chestModelTrygun, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        }
        
        this.丕丈丝丐一丒三丕与.enabled = true;
        this.下丐丝与丈丂下不丘 = 上丈丒丁丂七丆上丑;
        if(this.下丐丝与丈丂下不丘 != 上丈丒丁丂七丆上丑)
        {
            goto label_24;
        }
        
        if(this.上丈丛七且与丝丙丌 == true)
        {
            goto label_33;
        }
        
        goto label_39;
        label_24:
        if(this._chestModelTrygun != 0)
        {
                val_20 = this._chestModelTrygun.activeInHierarchy;
        }
        else
        {
                val_20 = 0;
        }
        
        if((上丈丒丁丂七丆上丑 != 2) || (val_20 != 0))
        {
            goto label_33;
        }
        
        PGCompany.七丟世上与且丈丂丅.丑七不且上丗丁一世().丌丑丗丟专丒丄丟丄();
        goto label_36;
        label_33:
        if(上丈丒丁丂七丆上丑 != 1)
        {
            goto label_36;
        }
        
        System.DateTime val_10 = PGCompany.且世万丐七丆丛丄丌.丒丌丟业丂丌丈丕丒();
        val_21 = val_10.dateData;
        this.上丛业丙丙七丒丝丁(丛丅丘一丏丙且丌上:  true, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        float val_11 = PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业();
        val_23 = 1;
        goto label_37;
        label_36:
        if(( & 1) == 0)
        {
            goto label_38;
        }
        
        this.上丛业丙丙七丒丝丁(丛丅丘一丏丙且丌上:  true, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        val_21 = ;
        val_23 = 上丈丒丁丂七丆上丑;
        label_37:
        this.下丒丝丕丟丐专下上(上丈丒丁丂七丆上丑:  val_23, 业丅与与丝丄专丞七:  new System.DateTime() {dateData = val_21}, 世下丗丝丝丄一丗七:  PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业());
        goto label_39;
        label_38:
        val_24 = null;
        if(FreeAwardShowHandler.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[FreeAwardShowHandler.SetInterfaceActive] serverTimeUtc: null");
        }
        
        this.上丛业丙丙七丒丝丁(丛丅丘一丏丙且丌上:  false, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        label_39:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.chestModelGems, 丏业丟一东丂东丘丛:  (上丈丒丁丂七丆上丑 == 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._chestModelTrygun, 丏业丟一东丂东丘丛:  (上丈丒丁丂七丆上丑 == 2) ? 1 : 0);
        if((Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().与丈下不丏丁丛丒丐() <= 0) && (Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().与丈下不丏丁丛丒丐() >= 1))
        {
                Rilisoft.一丟专且三万丞丁丂.丂业丝且丁丒丆丌丈();
        }
        
        this.丛丂丈上丒丑丒丛七(上丈丒丁丂七丆上丑:  上丈丒丁丂七丆上丑);
    }
    private void 丛丂丈上丒丑丒丛七(FreeAwardShowHandler.丆且丄丐专且业丄下 上丈丒丁丂七丆上丑)
    {
        if(this.HeaderTextGems != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.HeaderTextGems.gameObject, 丏业丟一东丂东丘丛:  (上丈丒丁丂七丆上丑 == 1) ? 1 : 0);
            if(this.HeaderTextGems.gameObject.activeSelf != false)
        {
                this.专丛丌下丌不丘丄下();
        }
        
        }
        
        if(this._headerTextTrygun == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._headerTextTrygun.gameObject, 丏业丟一东丂东丘丛:  (上丈丒丁丂七丆上丑 == 2) ? 1 : 0);
    }
    private bool 丌七丅丐万丗丞世东()
    {
        return (bool)(this.下丐丝与丈丂下不丘 != 0) ? 1 : 0;
    }
    public void OnClick()
    {
        this.丘业上三丝七丒丏丟();
    }
    private void 七世七丈丗七丟丞丟(bool 一与不业与不与且丟, UnityEngine.GameObject 丕丝丏专丙七世下三)
    {
        bool val_4 = 一与不业与不与且丟;
        UIPlayTween val_1 = 丕丝丏专丙七世下三.GetComponent<UIPlayTween>();
        if(val_1 != null)
        {
                val_1.resetOnPlay = true;
            val_1.tweenGroup = val_4;
        }
        else
        {
                val_1.resetOnPlay = true;
            val_4 = val_4;
            mem[32] = val_4;
        }
        
        val_1.Play(且丒且丐丌东专三丁:  true);
    }
    private void 业一丒丕与丏三丞丞(bool 丝三丞丙丟丏与世世)
    {
        var val_10;
        var val_11;
        UnityEngine.Animation val_1 = this.chestModelGems.GetComponent<UnityEngine.Animation>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_10 = val_1.Item["Animate"];
        if(val_10 == null)
        {
            goto label_6;
        }
        
        if(丝三丞丙丟丏与世世 == false)
        {
            goto label_7;
        }
        
        label_10:
        val_10.speed = -1f;
        if(val_1 == null)
        {
            goto label_8;
        }
        
        val_11 = val_1.Item["Animate"];
        goto label_9;
        label_6:
        if(丝三丞丙丟丏与世世 == true)
        {
            goto label_10;
        }
        
        label_7:
        val_10.speed = 1f;
        if(val_1.Item["Animate"] != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_8:
        val_11 = val_1.Item["Animate"];
        label_9:
        val_10 = val_1.Item["Animate"];
        label_13:
        val_11.time = val_10.length;
        bool val_9 = val_1.Play();
    }
    internal static void 万上业丄丈丁上东丟(bool 丘丅七丝丒丐丝专七)
    {
        UnityEngine.Object val_8;
        var val_9;
        val_8 = 丘丅七丝丒丐丝专七;
        if(val_8 == false)
        {
                return;
        }
        
        val_8 = FreeAwardShowHandler.丑七不且上丗丁一世();
        if(val_8 == 0)
        {
                return;
        }
        
        FreeAwardShowHandler val_3 = FreeAwardShowHandler.丑七不且上丗丁一世();
        val_8 = val_3.丕丈丝丐一丒三丕与;
        if(val_8 == 0)
        {
                return;
        }
        
        if(val_8.enabled == false)
        {
                return;
        }
        
        val_9 = null;
        if(FreeAwardShowHandler.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[FreeAwardShowHandler.CheckShowChest] SetInterfaceActive: None, interfaceEnabled: true");
        }
        
        FreeAwardShowHandler.丑七不且上丗丁一世().三丒丌与七丄世丐下(上丈丒丁丂七丆上丑:  0, 业丅与与丝丄专丞七:  new System.Nullable<System.DateTime>() {HasValue = false});
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 1)
        {
                return;
        }
        
        this.上丈丛七且与丝丙丌 = true;
    }
    internal static bool 丒丒丟丄业丆丆三丐(out string 丁丂丕与丁丒丕丟丞)
    {
        UnityEngine.GameObject val_48;
        var val_49;
        var val_50;
        string val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_60;
        var val_61;
        var val_63;
        var val_64;
        var val_65;
        val_48 = 1152921505066164224;
        val_49 = null;
        val_49 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_9;
        }
        
        val_50 = null;
        val_50 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == false)
        {
            goto label_9;
        }
        
        val_51 = "FriendsWindowGUI";
        goto label_181;
        label_9:
        val_48 = 1152921505210572800;
        if((BankController.丑七不且上丗丁一世() == 0) || (BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == false))
        {
            goto label_21;
        }
        
        val_51 = "BankController";
        goto label_181;
        label_21:
        val_48 = 1152921505261211648;
        val_52 = null;
        val_52 = null;
        if((ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0) || (ShopNGUIController.丛世丛与丌不丈丐丐() == false))
        {
            goto label_32;
        }
        
        val_51 = "ShopNGUIController";
        goto label_181;
        label_32:
        if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丅丙一业丂丐丐丟不(丅丟丛丙下丙丄丒丁: out  0)) == false)
        {
            goto label_42;
        }
        
        val_48 = 1152921536305318176;
        if(val_10.CurrentState != null)
        {
                if(null == null)
        {
            goto label_42;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_45;
        }
        
        val_53 = val_10.CurrentState.GetType();
        goto label_51;
        label_42:
        val_48 = 1152921505133842432;
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() != false)
        {
                if(GiftBannerWindow.丛世丛与丌不丈丐丐() == false)
        {
            goto label_63;
        }
        
        }
        
        }
        
        val_54 = null;
        val_54 = null;
        if(GiftBannerWindow.丘丆且七丑丘且专丟 == false)
        {
            goto label_66;
        }
        
        val_51 = "isActiveBanner";
        goto label_181;
        label_66:
        val_48 = 1152921505229049856;
        val_55 = null;
        val_55 = null;
        if(AskNameManager.丄丘七三上丕世丞业 != 0)
        {
                val_56 = null;
            val_56 = null;
            if(AskNameManager.东丏丂丙丑丁丞丞万 != true)
        {
                if(ExperienceController.丞丞丘业东丙丏七丌() <= 1)
        {
            goto label_80;
        }
        
        }
        
        }
        
        val_57 = null;
        val_57 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == null)
        {
            goto label_118;
        }
        
        val_48 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 304];
        val_48 = MainMenuController.丄丞丁丈与业上丞丟.stubLoading;
        if(activeInHierarchy == false)
        {
            goto label_85;
        }
        
        val_51 = "stubLoading";
        goto label_181;
        label_45:
        val_51 = "IdleState: false";
        goto label_181;
        label_63:
        val_51 = "IsAnyBannerShown";
        goto label_181;
        label_85:
        if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == false)
        {
            goto label_95;
        }
        
        val_51 = "UserCharactersWindowEnabled";
        goto label_181;
        label_95:
        val_48 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 40];
        val_48 = MainMenuController.丄丞丁丈与业上丞丟 + 40;
        if(val_48.activeInHierarchy == true)
        {
            goto label_100;
        }
        
        val_48 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
        val_48 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
        if(val_48.activeInHierarchy == false)
        {
            goto label_102;
        }
        
        label_100:
        val_51 = "SettingsJoysticksPanel";
        goto label_181;
        label_80:
        val_51 = "AskNameManager";
        goto label_181;
        label_102:
        if(MainMenuController.丄丞丁丈与业上丞丟.一丑丟世丛丌丁下不() == false)
        {
            goto label_109;
        }
        
        val_51 = "InMiniGamesScreen";
        goto label_181;
        label_109:
        val_58 = null;
        val_58 = null;
        val_48 = FreeAwardShowHandler.<>c.<>9__56_0;
        if(val_48 == null)
        {
                System.Func<UnityEngine.Transform, System.Boolean> val_28 = null;
            val_48 = val_28;
            val_28 = new System.Func<UnityEngine.Transform, System.Boolean>(object:  FreeAwardShowHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreeAwardShowHandler.<>c::丆丌丅丗丒丘丑丞丅(UnityEngine.Transform 东七上世万下丗丄丛));
            FreeAwardShowHandler.<>c.<>9__56_0 = val_48;
        }
        
        if((Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<UnityEngine.Transform, System.Boolean>(丄三丅七丆丛与与上:  MainMenuController.丄丞丁丈与业上丞丟.RentExpiredPoint, 东丑丈丅丌万东丅且:  val_28)) == false)
        {
            goto label_118;
        }
        
        val_51 = "RentExpiredPoint";
        goto label_181;
        label_118:
        if((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == null) || (Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == false))
        {
            goto label_123;
        }
        
        val_51 = "LobbyCraftController";
        goto label_181;
        label_123:
        if((FeedbackMenuController.丑七不且上丗丁一世() == 0) || (FeedbackMenuController.丑七不且上丗丁一世().gameObject.activeInHierarchy == false))
        {
            goto label_132;
        }
        
        val_51 = "FeedbackMenuController";
        goto label_181;
        label_132:
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == false)
        {
            goto label_138;
        }
        
        val_51 = "LeaderboardsGui";
        goto label_181;
        label_138:
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == false)
        {
            goto label_142;
        }
        
        val_51 = "LeaderboardsClans";
        goto label_181;
        label_142:
        val_60 = null;
        val_60 = null;
        val_61 = null;
        val_61 = null;
        val_48 = FreeAwardShowHandler.<>c.<>9__56_1;
        if(val_48 == null)
        {
                System.Func<FriendsController, System.Boolean> val_38 = null;
            val_48 = val_38;
            val_38 = new System.Func<FriendsController, System.Boolean>(object:  FreeAwardShowHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreeAwardShowHandler.<>c::业万下丟丑丌且丂丝(FriendsController 丁丂专业丁丅丅丈丙));
            FreeAwardShowHandler.<>c.<>9__56_1 = val_48;
        }
        
        if((Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<FriendsController, System.Boolean>(丄三丅七丆丛与与上:  FriendsController.丄丞丁丈与业上丞丟, 东丑丈丅丌万东丅且:  val_38)) == false)
        {
            goto label_153;
        }
        
        val_51 = "ProfileInterfaceActive";
        goto label_181;
        label_153:
        val_48 = 1152921505566695424;
        val_63 = null;
        val_63 = null;
        if(PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_166;
        }
        
        val_64 = null;
        val_64 = null;
        if(PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false)
        {
            goto label_166;
        }
        
        val_51 = "NewsLobbyController";
        goto label_181;
        label_166:
        val_48 = 1152921505175109632;
        if((ExpController.丑七不且上丗丁一世() == 0) || (ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == false))
        {
            goto label_178;
        }
        
        val_51 = "IsLevelUpShown";
        goto label_181;
        label_178:
        if(PGCompany.丁东丌世与丕东丆上.丛不丆丕且丗丏丑丒() == false)
        {
            goto label_184;
        }
        
        val_53 = 0;
        val_65 = 0;
        goto label_185;
        label_184:
        val_51 = "IsCompleteAllTutors";
        label_181:
        label_51:
        val_65 = 1;
        label_185:
        丁丂丕与丁丒丕丟丞 = val_51;
        return (bool)val_65;
    }
    private void 丘业上三丝七丒丏丟()
    {
        var val_10;
        string val_11;
        string val_12;
        string val_2 = 0;
        string val_6 = 0;
        val_10 = null;
        if(FreeAwardShowHandler.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[Free…dler.OnClickNew]");
        }
        
        if((FreeAwardShowHandler.丒丒丟丄业丆丆三丐(丁丂丕与丁丒丕丟丞: out  val_2)) != false)
        {
                val_11 = val_2;
            val_12 = "[Free…dler.OnClickNew] TryGetReasonToOmitChest: ";
        }
        else
        {
                if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丙丒三丂东丒一丑上(丅丟丛丙下丙丄丒丁: out  0, 丏丞专丏业丗丝七丝: out  val_6)) != false)
        {
                bool val_8 = val_5.TryProcessEvent(ev:  2);
            return;
        }
        
            val_11 = val_6;
            val_12 = "[Free…dler.OnClickNew] TryResolveLobbyStateMachine: ";
        }
        
        UnityEngine.Debug.LogWarning(message:  val_12 + val_11);
    }
    private static FreeAwardShowHandler()
    {
        UnityEngine.Color val_1 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "00D5FF");
        FreeAwardShowHandler.上丙丛丁万不丑下世 = val_1.r;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_C = val_1.g;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_10 = val_1.b;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_14 = val_1.a;
        UnityEngine.Color val_2 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "FFCF40");
        FreeAwardShowHandler.万丙一七业丄丆丘万 = val_2.r;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_1C = val_2.g;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_20 = val_2.b;
        FreeAwardShowHandler.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_24 = val_2.a;
    }
    private System.Collections.IEnumerator 丗丙丞丁丙丘丒丗东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FreeAwardShowHandler.七丑下丈万业不丆丆();
    }
    internal static bool 丛丈丟专一丂三东丂(string 东丒丝不上丛丒丌丄, out string 丄丙下丝丛丒七丂丘)
    {
        丄丙下丝丛丒七丂丘 = 东丒丝不上丛丒丌丄;
        return true;
    }

}
