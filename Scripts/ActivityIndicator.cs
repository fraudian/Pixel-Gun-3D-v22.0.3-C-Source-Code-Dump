using UnityEngine;
public sealed class ActivityIndicator : MonoBehaviour
{
    // Fields
    internal static ActivityIndicator 丄丘七三上丕世丞业;
    public float rotSpeed;
    private UnityEngine.Vector3 丂丕下丞丆专丂丛业;
    public string text;
    public UnityEngine.Camera needCam;
    public UnityEngine.GameObject panelWindowLoading;
    public UnityEngine.GameObject panelIndicator;
    public UnityEngine.GameObject objIndicator;
    public UnityEngine.GameObject panelProgress;
    public UnityEngine.Transform panelProgressBotPosition;
    public UnityEngine.Transform panelProgressMidPosition;
    public UILabel lbLoading;
    public UILabel lbPercentLoading;
    public UILabel legendLabel;
    public UITexture[] txFon;
    public UITexture txProgressBar;
    public UIFont bitmapFont;
    private static float 与丛丙丞世东与丅丟;
    public UILabel idLabel;
    private bool 专丘东且东上丘七不;
    internal const string 不丌世万丌丘丘丒上 = "Please reboot your device if frozen.";
    private static LoadingTipsView 丝丕丝丐丑丙下丞下;
    private static bool 丂丕丛丛丌丌丘上丟;
    
    // Properties
    internal static float 丙与与丂上世丄万且 { get; set; }
    internal static bool 丂丕丏且三一东丝丂 { set; }
    internal static bool 丄丑丕丄丛丕东丐丕 { get; set; }
    
    // Methods
    public void Awake()
    {
        null = null;
        ActivityIndicator.不丌世万丌丘丘丒上 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        this.丂丕下丞丆专丂丛业 = 0;
        mem[1152921524289168740] = 0;
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ActivityIndicator::丞丛一丙丂世丈丅丗()));
        UnityEngine.Vector3 val_4 = this.panelProgressBotPosition.localPosition;
        this.panelProgress.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ActivityIndicator::丄专万丞丌三丂丛业()));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ActivityIndicator::专丂丕丌不丏丝专一()));
    }
    private void Start()
    {
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "StartActivityIndicator");
        this.丞丛一丙丂世丈丅丗();
        this.lbLoading.GetComponent<I2.Loc.Localize>().enabled = true;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  " end StartActivityIndicator");
        this.丈七丙丄且丅丏且东();
    }
    private void Update()
    {
        if(this.objIndicator == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丂丕下丞丆专丂丛业, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.unscaledDeltaTime);
        this.objIndicator.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private void OnDestroy()
    {
        null = null;
        ActivityIndicator.不丌世万丌丘丘丒上 = 0;
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ActivityIndicator::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        if(this.lbLoading == 0)
        {
                return;
        }
        
        string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0853");
        string val_4 = ((System.String.op_Equality(a:  "Key_0853", b:  val_2)) != true) ? "Please reboot your device if frozen." : (val_2);
        this.text = val_4;
        this.lbLoading.text = val_4;
    }
    private void OnEnable()
    {
        this.丞丛一丙丂世丈丅丗();
    }
    internal static float 七业业丝丛丈丁丕丞()
    {
        null = null;
        return (float)ActivityIndicator.与丛丙丞世东与丅丟;
    }
    internal static void 万万丅丌丑丗丅世一(float 丙业与丙丗丝不丈东)
    {
        var val_7;
        string val_8;
        var val_9;
        var val_10;
        var val_13;
        var val_15;
        var val_16;
        val_7 = null;
        val_7 = null;
        val_8 = ActivityIndicator.不丌世万丌丘丘丒上;
        if(val_8 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        ActivityIndicator.与丛丙丞世东与丅丟 = 丙业与丙丗丝不丈东;
        val_10 = null;
        ActivityIndicator.与丛丙丞世东与丅丟 = UnityEngine.Mathf.Clamp01(value:  ActivityIndicator.与丛丙丞世东与丅丟);
        if(ActivityIndicator.与丛丙丞世东与丅丟 < 0)
        {
                val_10 = null;
            ActivityIndicator.与丛丙丞世东与丅丟 = 0f;
        }
        
        val_10 = null;
        if(ActivityIndicator.与丛丙丞世东与丅丟 > 1f)
        {
                val_10 = null;
            ActivityIndicator.与丛丙丞世东与丅丟 = 1f;
        }
        
        val_10 = null;
        if((ActivityIndicator.不丌世万丌丘丘丒上 + 136) != 0)
        {
                val_13 = null;
            val_13 = null;
            ActivityIndicator.不丌世万丌丘丘丒上 + 136.fillAmount = ActivityIndicator.与丛丙丞世东与丅丟;
        }
        
        val_15 = null;
        val_15 = null;
        val_8 = mem[ActivityIndicator.不丌世万丌丘丘丒上 + 112];
        val_8 = ActivityIndicator.不丌世万丌丘丘丒上 + 112;
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_8 = mem[ActivityIndicator.不丌世万丌丘丘丒上 + 112];
        val_8 = ActivityIndicator.不丌世万丌丘丘丒上 + 112;
        float val_7 = 100f;
        val_7 = ActivityIndicator.与丛丙丞世东与丅丟 * val_7;
        val_8.text = System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_7));
    }
    internal void 丆丆丁丂世丆且丈丐()
    {
        UnityEngine.Transform val_12;
        var val_13;
        UnityEngine.Transform val_14;
        var val_15;
        var val_16;
        val_12 = this;
        val_13 = null;
        val_13 = null;
        if(ActivityIndicator.丝丕丝丐丑丙下丞下 != 0)
        {
                return;
        }
        
        LoadingTipsView val_2 = UnityEngine.Resources.Load<LoadingTipsView>(path:  "LoadingTips");
        if(val_2 == 0)
        {
                UnityEngine.Debug.LogError(message:  "[A_ctivityIndicator] P_repareTip => ltv: null");
            return;
        }
        
        val_14 = this.panelWindowLoading.transform;
        val_15 = null;
        val_15 = null;
        ActivityIndicator.丝丕丝丐丑丙下丞下 = UnityEngine.Object.Instantiate<LoadingTipsView>(original:  val_2, parent:  val_14, worldPositionStays:  false);
        if(ActivityIndicator.丝丕丝丐丑丙下丞下 == 0)
        {
                UnityEngine.Debug.LogError(message:  "[A_ctivityIndicator] P_repareTip => s_ltv: null");
            return;
        }
        
        val_16 = null;
        val_16 = null;
        val_14 = this.gameObject.layer;
        ActivityIndicator.丝丕丝丐丑丙下丞下.gameObject.layer = val_14;
        ActivityIndicator.丂丕丛丛丌丌丘上丟 = true;
        val_12 = this.panelProgressMidPosition;
        UnityEngine.Vector3 val_11 = val_12.localPosition;
        this.panelProgress.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    internal static void 丞丂一丝三丄专丆一(UnityEngine.Texture 丝丘专世丏三丝下丐)
    {
        LoadingTipsView val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = 丝丘专世丏三丝下丐;
        val_6 = null;
        val_6 = null;
        if(ActivityIndicator.不丌世万丌丘丘丒上 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if((ActivityIndicator.不丌世万丌丘丘丒上 + 128 + 32) == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_5 = ActivityIndicator.丝丕丝丐丑丙下丞下;
        if(val_5 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(ActivityIndicator.丂丕丛丛丌丌丘上丟 == false)
        {
                return;
        }
        
        val_10 = null;
        val_5 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
        val_10 = null;
        val_5.ShowTip(丞万一业万丕丏且丄:  ActivityIndicator.丝丕丝丐丑丙下丞下, 七丆丒与丗丌丄且丂:  2, 丛业丑丝丘丟七与丑:  false);
        ActivityIndicator.丂丕丛丛丌丌丘上丟 = false;
    }
    public System.Collections.Generic.IEnumerable<float> ReplaceLoadingFon(UnityEngine.Texture 丝丘专世丏三丝下丐, float 与丈业丛丝丒丙一丏)
    {
        ActivityIndicator.丘丘不东上万万丒丕 val_1 = new ActivityIndicator.丘丘不东上万万丒丕(丗丏丅丕丆世丁专丟:  -2);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丝丕上丞丐上上七专 = 丝丘专世丏三丝下丐;
        }
        else
        {
                mem[32] = this;
            mem[48] = 丝丘专世丏三丝下丐;
        }
        
        .丅七丆三丐且丙下丗 = 与丈业丛丝丒丙一丏;
        return (System.Collections.Generic.IEnumerable<System.Single>)val_1;
    }
    internal static void 与丛上丆丐丞丗东七(bool 丙业与丙丗丝不丈东)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_7 = null;
        val_7 = null;
        if(ActivityIndicator.不丌世万丌丘丘丒上 == 0)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 != true)
        {
                val_8 = null;
            val_8 = null;
            if((ActivityIndicator.不丌世万丌丘丘丒上 + 128) != 0)
        {
                val_9 = null;
            val_9 = null;
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        if((ActivityIndicator.不丌世万丌丘丘丒上 + 56) != 0)
        {
                val_11 = null;
            val_11 = null;
            ActivityIndicator.不丌世万丌丘丘丒上 + 56.SetActive(value:  丙业与丙丗丝不丈东);
        }
        
        val_12 = null;
        val_12 = null;
        ActivityIndicator.不丌世万丌丘丘丒上.上不上丛丕专且丆下();
        if((ActivityIndicator.不丌世万丌丘丘丒上 + 48) == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        ActivityIndicator.不丌世万丌丘丘丒上 + 48.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
    }
    internal static bool 丙专三丙丌丝丏丌丅()
    {
        var val_3;
        string val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = ActivityIndicator.不丌世万丌丘丘丒上;
        if(val_4 == 0)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[ActivityIndicator.不丌世万丌丘丘丒上 + 64];
        val_4 = ActivityIndicator.不丌世万丌丘丘丒上 + 64;
        if(val_4 == 0)
        {
                return false;
        }
        
        val_6 = null;
        val_6 = null;
        if((ActivityIndicator.不丌世万丌丘丘丒上 + 64) != 0)
        {
                return ActivityIndicator.不丌世万丌丘丘丒上 + 64.activeSelf;
        }
        
        return ActivityIndicator.不丌世万丌丘丘丒上 + 64.activeSelf;
    }
    internal static void 不丒丑丅业丞丘丐三(bool 丙业与丙丗丝不丈东)
    {
        bool val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_11 = 丙业与丙丗丝不丈东;
        val_12 = null;
        val_12 = null;
        if(ActivityIndicator.不丌世万丌丘丘丒上 == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        bool val_4 = (ActivityIndicator.不丌世万丌丘丘丒上 + 64.activeSelf) ^ val_11;
        if((val_4 != false) && ((ActivityIndicator.不丌世万丌丘丘丒上 + 64) != 0))
        {
                val_14 = null;
            val_14 = null;
            ActivityIndicator.不丌世万丌丘丘丒上 + 64.SetActive(value:  val_11);
        }
        
        if(val_4 != false)
        {
                val_15 = null;
            val_15 = null;
            if((ActivityIndicator.不丌世万丌丘丘丒上 + 48) != 0)
        {
                val_16 = null;
            val_16 = null;
            ActivityIndicator.不丌世万丌丘丘丒上 + 48.gameObject.SetActive(value:  val_11);
            ActivityIndicator.不丌世万丌丘丘丒上 + 48.Render();
        }
        
        }
        
        if(val_11 == true)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        ActivityIndicator.不丌世万丌丘丘丒上.丞丛一丙丂世丈丅丗();
        val_11 = ActivityIndicator.丝丕丝丐丑丙下丞下;
        if(val_11 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        UnityEngine.Object.Destroy(obj:  ActivityIndicator.丝丕丝丐丑丙下丞下.gameObject);
    }
    internal static void 丁与丏东且与万丝下()
    {
        var val_5;
        string val_6;
        var val_7;
        var val_8;
        System.Collections.IEnumerator val_9;
        val_5 = null;
        val_5 = null;
        val_6 = ActivityIndicator.不丌世万丌丘丘丒上;
        if(val_6 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_6 = ActivityIndicator.不丌世万丌丘丘丒上;
        if((ActivityIndicator.不丌世万丌丘丘丒上 + 160) == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(ActivityIndicator.不丌世万丌丘丘丒上 != null)
        {
                val_9 = ActivityIndicator.不丌世万丌丘丘丒上.丒业三世丟上丆丑下();
        }
        else
        {
                val_9 = this.丒业三世丟上丆丑下();
        }
        
        UnityEngine.Coroutine val_4 = ActivityIndicator.不丌世万丌丘丘丒上.StartCoroutine(routine:  val_9);
    }
    private System.Collections.IEnumerator 丒业三世丟上丆丑下()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ActivityIndicator.丂丕丆七丞丌丆业丙(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丈七丙丄且丅丏且东()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.idLabel, 丕丗丘丑丛与丑业丒:  "ID: "("ID: ") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    private void 上不上丛丕专且丆下()
    {
        UnityEngine.MonoBehaviour val_3;
        var val_4;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_3 = this.legendLabel;
            val_4 = 0;
        }
        else
        {
                val_4 = 1;
            val_3 = this.legendLabel;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  true);
    }
    private void 丄专万丞丌三丂丛业()
    {
        this.丈七丙丄且丅丏且东();
    }
    private void 专丂丕丌不丏丝专一()
    {
        this.丈七丙丄且丅丏且东();
    }
    public ActivityIndicator()
    {
        this.rotSpeed = 180f;
        this.专丘东且东上丘七不 = true;
    }
    private static ActivityIndicator()
    {
    
    }

}
