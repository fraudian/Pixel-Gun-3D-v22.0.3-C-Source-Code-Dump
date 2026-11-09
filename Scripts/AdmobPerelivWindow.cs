using UnityEngine;
public sealed class AdmobPerelivWindow : MonoBehaviour
{
    // Fields
    private System.Nullable<bool> 三丝上丁丆丒丌与且;
    private static string <丅丝丌丝丁丏丙东丞>k__BackingField;
    public AdmobPerelivWindow.三丞东七下丙丝丟业 state;
    private float 上丕丈且业丒丛万丝;
    internal static UnityEngine.Texture 世丝一且丏三丄丞丙;
    internal static string 一一三丘丒且与丄万;
    public UITexture adTexture;
    public UnityEngine.GameObject closeAnchor;
    public UISprite closeSprite;
    public UITexture lightTexture;
    public UISprite closeSpriteAndr;
    private UnityEngine.Transform 上丛丂三上与丂丕丑;
    
    // Properties
    internal static string 丄丄一丐东丐丝丗七 { get; set; }
    private UnityEngine.Transform 万东万丆专丌丕丐丗 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    private bool 七丐三丒专不丐一丕 { get; }
    
    // Methods
    internal static string 丄丌一七丈万万丌丐()
    {
        null = null;
        return (string)AdmobPerelivWindow.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    internal static void 不丕丌与业丕下东丂(string 丙业与丙丗丝不丈东)
    {
        null = null;
        AdmobPerelivWindow.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private UnityEngine.Transform 丏丞丐丂且不万下丘()
    {
        UnityEngine.Transform val_3;
        if(this.上丛丂三上与丂丕丑 == 0)
        {
                this.上丛丂三上与丂丕丑 = this.transform;
            return val_3;
        }
        
        val_3 = this.上丛丂三上与丂丕丑;
        return val_3;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private void Awake()
    {
        this.上丛丂三上与丂丕丑 = this.transform;
        this.closeSprite.gameObject.SetActive(value:  (Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8) ? 1 : 0);
        this.closeSpriteAndr.gameObject.SetActive(value:  (Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8) ? 1 : 0);
    }
    private void Start()
    {
        if(this.closeAnchor == 0)
        {
                return;
        }
        
        this = this.closeAnchor.transform;
        int val_3 = UnityEngine.Screen.width;
        var val_6 = 1;
        val_6 = val_6 - val_3;
        float val_7 = 768f;
        var val_5 = ((-val_3) < 0) ? (val_6) : (-val_3);
        val_5 = val_5 >> 1;
        val_7 = (float)val_5 * val_7;
        val_7 = val_7 / (float)UnityEngine.Screen.height;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        var val_16;
        三丞东七下丙丝丟业 val_17;
        float val_18;
        var val_19;
        var val_20;
        var val_21;
        val_16 = this;
        val_17 = this.state;
        if(val_17 == 1)
        {
                UnityEngine.Vector3 val_2 = this.丏丞丐丂且不万下丘().localPosition;
            if(val_2.y < 0)
        {
                UnityEngine.Vector3 val_4 = this.丏丞丐丂且不万下丘().localPosition;
            float val_5 = UnityEngine.Time.deltaTime;
            float val_16 = 770f;
            val_16 = val_16 / this.上丕丈且业丒丛万丝;
            val_5 = val_16 * val_5;
            val_18 = val_4.y + val_5;
            if(val_18 > 0f)
        {
                val_18 = 0f;
            this.state = 2;
        }
        
            this.丏丞丐丂且不万下丘().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
            val_17 = this.state;
        }
        
        if(val_17 != 3)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = this.丏丞丐丂且不万下丘().localPosition;
        if(val_8.y <= (-770f))
        {
                return;
        }
        
        UnityEngine.Vector3 val_10 = this.丏丞丐丂且不万下丘().localPosition;
        float val_11 = UnityEngine.Time.deltaTime;
        val_11 = ((-770f) / this.上丕丈且业丒丛万丝) * val_11;
        val_18 = val_10.y + val_11;
        if(val_18 < 0)
        {
                this.state = 0;
            this.gameObject.SetActive(value:  false);
            val_19 = null;
            val_19 = null;
            if(AdmobPerelivWindow.世丝一且丏三丄丞丙 != 0)
        {
                val_20 = null;
            val_20 = null;
            UnityEngine.Object.Destroy(obj:  AdmobPerelivWindow.世丝一且丏三丄丞丙);
        }
        
            val_21 = null;
            val_21 = null;
            val_18 = -770f;
            AdmobPerelivWindow.世丝一且丏三丄丞丙 = 0;
            AdmobPerelivWindow.一一三丘丒且与丄万 = System.String.alignConst;
        }
        
        val_16 = this.丏丞丐丂且不万下丘();
        val_16.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void Show()
    {
        System.Object[] val_27;
        var val_28;
        var val_29;
        int val_30;
        var val_31;
        UnityEngine.Object val_32;
        var val_33;
        var val_34;
        float val_35;
        float val_36;
        var val_37;
        var val_38;
        bool val_39;
        var val_40;
        val_27 = this;
        val_28 = null;
        if(AdmobPerelivWindow.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[AdmobPerelivWindow.Show]");
        }
        
        if(this.state != 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = 1152921504848912384;
        if(AdmobPerelivWindow.世丝一且丏三丄丞丙 == 0)
        {
                val_27 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogWarningFormat(format:  "AdmobTexture is null.", args:  val_27);
            return;
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = 0;
        if(ExperienceController.sharedController != val_32)
        {
                val_33 = null;
            val_33 = null;
            bool val_6 = ExperienceController.sharedController.下一丝丗丁上世丐上();
            this.三丝上丁丆丒丌与且 = 0;
            val_32 = 0;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        val_34 = null;
        val_34 = null;
        float val_24 = (float)UnityEngine.Screen.height;
        val_24 = val_24 / (float)UnityEngine.Screen.width;
        if(((float)AdmobPerelivWindow.世丝一且丏三丄丞丙 / (float)AdmobPerelivWindow.世丝一且丏三丄丞丙) < val_24)
        {
                float val_26 = (float)UnityEngine.Screen.width;
            float val_25 = (float)UnityEngine.Screen.height;
            val_25 = (float)AdmobPerelivWindow.世丝一且丏三丄丞丙 * val_25;
            val_26 = val_26 * 768f;
            val_26 = val_26 * (float)AdmobPerelivWindow.世丝一且丏三丄丞丙;
            val_35 = val_26 / val_25;
            float val_27 = (float)UnityEngine.Screen.width;
            val_27 = val_27 * 768f;
            val_36 = val_27 / (float)UnityEngine.Screen.height;
        }
        else
        {
                val_35 = 768f;
            val_36 = ((float)AdmobPerelivWindow.世丝一且丏三丄丞丙 * val_35) / (float)AdmobPerelivWindow.世丝一且丏三丄丞丙;
        }
        
        if(this.adTexture != 0)
        {
                mem2[0] = 0;
            val_37 = null;
            val_37 = null;
            this.adTexture.width = UnityEngine.Mathf.RoundToInt(f:  val_36);
            val_30 = UnityEngine.Mathf.RoundToInt(f:  val_35);
            this.adTexture.height = val_30;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "AdTexture is null.");
        }
        
        val_38 = null;
        val_38 = null;
        val_39 = PGCompany.Ads.万丆且丐丁丙丐丛不.丅上丌丒丐三一丙丁(七丙不丅丛丘丗万与:  AdmobPerelivWindow.一一三丘丒且与丄万);
        if(AdmobPerelivWindow.世丈且业丆丑丏丐一() != false)
        {
                val_40 = null;
            val_40 = null;
            UnityEngine.Debug.Log(message:  "[AdmobPerelivWindow.Show] shouldAttributeCrossPromoImpression: "("[AdmobPerelivWindow.Show] shouldAttributeCrossPromoImpression: ") + val_39.ToString() + ", admobUrl: "(", admobUrl: ") + AdmobPerelivWindow.一一三丘丒且与丄万);
            val_39 = val_39;
        }
        
        if(val_39 != false)
        {
                Rilisoft.丄上且丘丙丙丝丙丅.丈丙三不世丗东丅丝(丗万丟万七专丗下丕:  PGCompany.Ads.万丆且丐丁丙丐丛不.七丂丈丌世丐三万七(), 不三世丒丟一丘专丛:  "PG_crosspromo", 丗丟上上丒丐丗丞丙:  0);
        }
        
        this.丏丞丐丂且不万下丘().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.state = 2;
    }
    public void Hide()
    {
        System.Nullable<System.Boolean> val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_5 = this;
        if(this.state != 2)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = 1152921504848912384;
        if(AdmobPerelivWindow.世丝一且丏三丄丞丙 != 0)
        {
                val_8 = null;
            val_8 = null;
            UnityEngine.Object.Destroy(obj:  AdmobPerelivWindow.世丝一且丏三丄丞丙);
        }
        
        val_9 = null;
        val_9 = null;
        AdmobPerelivWindow.世丝一且丏三丄丞丙 = 0;
        AdmobPerelivWindow.一一三丘丒且与丄万 = System.String.alignConst;
        this.state = 0;
        this.gameObject.SetActive(value:  false);
        val_5 = this.三丝上丁丆丒丌与且;
        if((val_5 & 1) == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_11 = null;
            val_11 = null;
            val_7 = val_5;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  val_7 & 1);
        }
        
        mem2[0] = 0;
    }
    private bool 丟丈丈万丕且不业丂()
    {
        return false;
    }
    public void AdmobBannerExitClick()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  7);
    }
    public void AdmobBannerApplyClick()
    {
        var val_8;
        bool val_9;
        var val_10;
        bool val_11;
        string val_12;
        var val_13;
        val_8 = null;
        val_8 = null;
        val_9 = PGCompany.Ads.万丆且丐丁丙丐丛不.丅上丌丒丐三一丙丁(七丙不丅丛丘丗万与:  AdmobPerelivWindow.一一三丘丒且与丄万);
        if(AdmobPerelivWindow.世丈且业丆丑丏丐一() != false)
        {
                val_10 = null;
            val_10 = null;
            UnityEngine.Debug.Log(message:  "[AdmobPerelivWindow.AdmobBannerApplyClick] shouldAttributeCrossPromoClick: "("[AdmobPerelivWindow.AdmobBannerApplyClick] shouldAttributeCrossPromoClick: ") + val_9.ToString() + ", admobUrl: "(", admobUrl: ") + AdmobPerelivWindow.一一三丘丒且与丄万);
            val_11 = val_9;
        }
        
        if(val_11 != false)
        {
                val_12 = PGCompany.Ads.万丆且丐丁丙丐丛不.七丂丈丌世丐三万七();
            Rilisoft.丄上且丘丙丙丝丙丅.丘与丂丐业三专且丂(丗万丟万七专丗下丕:  val_12, 不三世丒丟一丘专丛:  "PG_crosspromo", 丗丟上上丒丐丗丞丙:  0, 业丏丈世世世丞丒世:  PGCompany.AppsFlyerTrackerCallbacks.丑七不且上丗丁一世());
            return;
        }
        
        val_13 = null;
        val_13 = null;
        UnityEngine.Application.OpenURL(url:  AdmobPerelivWindow.一一三丘丒且与丄万);
    }
    public AdmobPerelivWindow()
    {
        this.上丕丈且业丒丛万丝 = 0.2f;
    }
    private static AdmobPerelivWindow()
    {
        AdmobPerelivWindow.世丝一且丏三丄丞丙 = 0;
        AdmobPerelivWindow.一一三丘丒且与丄万 = System.String.alignConst;
    }

}
