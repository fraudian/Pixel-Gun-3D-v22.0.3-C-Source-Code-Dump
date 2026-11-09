using UnityEngine;
public class ButtonBannerHUD : MonoBehaviour
{
    // Fields
    private const string 丌丒业丁丂且东不丐 = "keyLastShowIndex";
    private const string 丁丒丕丛不上丆丑丐 = "ButtonBanners";
    private const float 丟且丛丁丂丂东丂三 = 5;
    internal static ButtonBannerHUD 丄丘七三上丕世丞业;
    public MyCenterOnChild centerScript;
    public ButtonBannerBase curShowBanner;
    public System.Collections.Generic.List<ButtonBannerBase> listActiveBanners;
    public System.Collections.Generic.List<ButtonBannerBase> listAllBanners;
    public UnityEngine.Transform objAnchorNoActiveBanners;
    private ButtonBannerBase 丈丁不丟上丝丝丒丛;
    public UIScrollView scrollBanners;
    public UIWrapContent wrapBanners;
    
    // Properties
    public int 丑丟丄丌不专丑不丘 { get; set; }
    
    // Methods
    public int get_IndexShowBanner()
    {
        return Load.丙丄七且丄与丆万世(丒丘丏上丙丟丑丕丈:  "keyLastShowIndex");
    }
    public void set_IndexShowBanner(int 丙业与丙丗丝不丈东)
    {
        int val_3 = 丙业与丙丗丝不丈东;
        val_3 = val_3 & (~(val_3 >> 31));
        Save.丐丏丑丟丐丁上上丑(丒丘丏上丙丟丑丕丈:  "keyLastShowIndex", 三丂丏不三上上丏丝:  (val_3 < this.listActiveBanners.Count) ? (val_3) : 0);
    }
    private void Awake()
    {
        null = null;
        ButtonBannerHUD.丄丘七三上丕世丞业 = this;
        this.丝丛与丘丌丞丟一丒();
    }
    private void Start()
    {
        上丄丂丛专下丟万下 val_7;
        MyCenterOnChild val_1 = this.wrapBanners.GetComponent<MyCenterOnChild>();
        this.centerScript = val_1;
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        val_7 = System.Delegate.Combine(a:  this.centerScript.onFinished, b:  new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void ButtonBannerHUD::OnCenterBanner()));
        if(this.centerScript == null)
        {
            goto label_6;
        }
        
        if(val_7 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_7 == null)
        {
            goto label_10;
        }
        
        label_7:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_10:
        this.centerScript.onFinished = val_7;
        label_4:
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void ButtonBannerHUD::LocalizeBanner()));
        this.丙丏丝业东丁丏一丑();
        this.ResetTimerNextBanner();
    }
    private void OnDestroy()
    {
        上丄丂丛专下丟万下 val_6;
        var val_7;
        if(this.centerScript == 0)
        {
            goto label_3;
        }
        
        val_6 = System.Delegate.Remove(source:  this.centerScript.onFinished, value:  new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void ButtonBannerHUD::OnCenterBanner()));
        if(this.centerScript == null)
        {
            goto label_5;
        }
        
        if(val_6 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_6 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_9:
        this.centerScript.onFinished = val_6;
        label_3:
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void ButtonBannerHUD::LocalizeBanner()));
        val_7 = null;
        val_7 = null;
        ButtonBannerHUD.丄丘七三上丕世丞业 = 0;
    }
    private void 丝丛与丘丌丞丟一丒()
    {
        var val_8;
        UnityEngine.Object val_9;
        var val_10;
        var val_11;
        this.listAllBanners.Clear();
        val_8 = 0;
        goto label_2;
        label_20:
        val_9 = UnityEngine.Resources.LoadAll(path:  "ButtonBanners")[0];
        if(val_9 == 0)
        {
            goto label_17;
        }
        
        val_10 = UnityEngine.Object.Instantiate(original:  val_9);
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_10 = 0;
        val_11 = 1;
        goto label_11;
        label_10:
        val_11 = 0;
        label_11:
        UnityEngine.Transform val_4 = val_10.transform;
        val_4.parent = this.objAnchorNoActiveBanners;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        ButtonBannerBase val_6 = val_10.GetComponent<ButtonBannerBase>();
        val_9 = val_6;
        if(val_6 != 0)
        {
                this.listAllBanners.Add(item:  val_9);
        }
        
        label_17:
        val_8 = 1;
        label_2:
        if(val_8 < val_1.Length)
        {
            goto label_20;
        }
    
    }
    internal static void 丐不上专且上专三丏()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ButtonBannerHUD.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ButtonBannerHUD.丄丘七三上丕世丞业.丙丏丝业东丁丏一丑();
    }
    private void 丙丏丝业东丁丏一丑()
    {
        this.专丂丅一丗丒东丛丘();
        this.与丒丑丌丏丛且世丕();
        this.且与丘且丐业丑丑专();
    }
    private void 专丂丅一丗丒东丛丘()
    {
        var val_6;
        var val_12;
        System.Collections.Generic.List<ButtonBannerBase> val_13;
        val_12 = this;
        if((this.curShowBanner != 0) && ((this.curShowBanner & 1) == 0))
        {
                this.curShowBanner = this.与七东上世一丙一丌();
        }
        
        System.Collections.Generic.List<ButtonBannerBase> val_3 = new System.Collections.Generic.List<ButtonBannerBase>();
        val_13 = this.listActiveBanners;
        List.Enumerator<T> val_4 = val_13.GetEnumerator();
        label_11:
        if((1791633008 & 1) == 0)
        {
            goto label_7;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if((val_7 & 1) != 0)
        {
            goto label_11;
        }
        
        val_3.Add(item:  val_7);
        goto label_11;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_8 = val_3.GetEnumerator();
        label_23:
        if((1791633008 & 1) == 0)
        {
            goto label_19;
        }
        
        string val_9 = val_6.丐丏七丌丕丗业且上();
        val_9.transform.parent = this.objAnchorNoActiveBanners;
        bool val_11 = this.listActiveBanners.Remove(item:  val_9);
        goto label_23;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private bool 不不上丏丛与丙丕丙(ButtonBannerBase 丐丙且与丆丄丟丘丒)
    {
        if(this.listActiveBanners != null)
        {
                return this.listActiveBanners.Contains(item:  丐丙且与丆丄丟丘丒);
        }
        
        return this.listActiveBanners.Contains(item:  丐丙且与丆丄丟丘丒);
    }
    private void 与丒丑丌丏丛且世丕()
    {
        List.Enumerator<T> val_2 = this.listAllBanners.GetEnumerator();
        label_9:
        if((1791939960 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if(((this.不不上丏丛与丙丕丙(丐丙且与丆丄丟丘丒:  val_3)) == true) || ((val_3 & 1) == 0))
        {
            goto label_9;
        }
        
        val_3.transform.parent = this.wrapBanners.transform;
        this.listActiveBanners.Add(item:  val_3);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 且与丘且丐业丑丑专()
    {
        var val_8;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        val_8 = null;
        val_8 = null;
        if((ButtonBannerHUD.<>c.<>9__24_0) == null)
        {
            goto label_3;
        }
        
        label_19:
        this.listActiveBanners.Sort(comparison:  ButtonBannerHUD.<>c.<>9__24_0);
        val_10 = 0;
        goto label_5;
        label_13:
        val_11 = 0;
        val_12 = 0.ToString();
        if(val_11 <= 9)
        {
                val_11 = 0;
            val_12 = "0" + val_12;
        }
        
        this.listActiveBanners.Item[0].gameObject.name = val_12;
        val_13 = 0;
        if(this.listActiveBanners.Item[0] == null)
        {
                val_13 = 0;
        }
        
        val_5.indexBut = 0;
        val_10 = val_13 + 1;
        label_5:
        if(val_10 < this.listActiveBanners.Count)
        {
            goto label_13;
        }
        
        this.ShowBanner(下丙丞东丐丄丅世一:  this.curShowBanner);
        return;
        label_3:
        ButtonBannerHUD.<>c.<>9__24_0 = new System.Comparison<ButtonBannerBase>(object:  ButtonBannerHUD.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ButtonBannerHUD.<>c::上丐丝世丑丆上世丗(ButtonBannerBase 丈丂丕下丏丈丞丗业, ButtonBannerBase 丂丌丌丛丆丆丙丌丈));
        if(this.listActiveBanners != null)
        {
            goto label_19;
        }
        
        goto label_19;
    }
    public void OnClickShowBanner()
    {
        if(this.curShowBanner == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(ButtonBannerBase).__il2cppRuntimeField_198;
    }
    private ButtonBannerBase 与七东上世一丙一丌()
    {
        var val_7;
        int val_1 = this.listActiveBanners.Count;
        if(val_1 >= 1)
        {
                int val_2 = val_1 + 1;
            do
        {
            this.IndexShowBanner = val_1.IndexShowBanner + 1;
            val_7 = this.listActiveBanners.Item[this.IndexShowBanner];
            if((val_7 & 1) != 0)
        {
                return (ButtonBannerBase)val_7;
        }
        
            val_2 = val_2 - 1;
        }
        while(val_2 > 1);
        
            UnityEngine.Debug.LogWarning(message:  "No next banner for show");
            return (ButtonBannerBase)val_7;
        }
        
        val_7 = 0;
        return (ButtonBannerBase)val_7;
    }
    public void ShowNextBanner()
    {
        this.ShowBanner(下丙丞东丐丄丅世一:  this.与七东上世一丙一丌());
    }
    public void ShowBanner(ButtonBannerBase 下丙丞东丐丄丅世一)
    {
        if(下丙丞东丐丄丅世一 == 0)
        {
                return;
        }
        
        if((下丙丞东丐丄丅世一 & 1) == 0)
        {
                return;
        }
        
        if(下丙丞东丐丄丅世一 == 0)
        {
                return;
        }
        
        this.丕丟丁丑丗与丗丑丄(下丙丞东丐丄丅世一:  下丙丞东丐丄丅世一, 丙丟丂丄丟丙丘丛不:  true);
        this.centerScript.CenterOn(丞下万上三丘上与专:  下丙丞东丐丄丅世一.transform);
    }
    public void OnCenterBanner()
    {
        ButtonBannerBase val_6;
        if(this.centerScript == 0)
        {
                return;
        }
        
        ButtonBannerBase val_3 = this.centerScript.centeredObject.GetComponent<ButtonBannerBase>();
        val_6 = this.丈丁不丟上丝丝丒丛;
        if(val_6 != 0)
        {
                val_6 = this.丈丁不丟上丝丝丒丛;
        }
        
        this.丕丟丁丑丗与丗丑丄(下丙丞东丐丄丅世一:  val_3, 丙丟丂丄丟丙丘丛不:  false);
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        this.ResetTimerNextBanner();
    }
    private void 丕丟丁丑丗与丗丑丄(ButtonBannerBase 下丙丞东丐丄丅世一, bool 丙丟丂丄丟丙丘丛不 = False)
    {
        var val_10;
        UnityEngine.Object val_11;
        val_10 = 丙丟丂丄丟丙丘丛不;
        val_11 = 下丙丞东丐丄丅世一;
        if(this.curShowBanner == val_11)
        {
                return;
        }
        
        this.curShowBanner = val_11;
        this.丈丁不丟上丝丝丒丛 = this.curShowBanner;
        if(val_11 == 0)
        {
                return;
        }
        
        this.IndexShowBanner = this.curShowBanner.indexBut;
        val_11 = this.curShowBanner;
        if(val_10 == false)
        {
                return;
        }
        
        val_10 = ???;
        val_11 = ???;
        goto typeof(ButtonBannerBase).__il2cppRuntimeField_1B8;
    }
    public void StopTimerNextBanner()
    {
        this.CancelInvoke(methodName:  "ShowNextBanner");
    }
    public void ResetTimerNextBanner()
    {
        this.StopTimerNextBanner();
        this.InvokeRepeating(methodName:  "ShowNextBanner", time:  5f, repeatRate:  5f);
    }
    public void LocalizeBanner()
    {
        if(this.curShowBanner == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(ButtonBannerBase).__il2cppRuntimeField_1A8;
    }
    public ButtonBannerHUD()
    {
        this.listActiveBanners = new System.Collections.Generic.List<ButtonBannerBase>();
        this.listAllBanners = new System.Collections.Generic.List<ButtonBannerBase>();
    }
    private static ButtonBannerHUD()
    {
    
    }

}
