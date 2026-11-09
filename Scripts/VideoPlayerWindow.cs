using UnityEngine;
internal sealed class VideoPlayerWindow : BannerWindow
{
    // Fields
    internal static VideoPlayerWindow 丆丕丝丒不丙且丐丗;
    private UnityEngine.GameObject redirectPanel;
    private UnityEngine.GameObject skipButton;
    private int 丁丘丌丟丘七丁丑丟;
    private int 丆丁丁丘丘业七专七;
    private string 丈丞下下丒丘与丈丛;
    private UnityEngine.Video.VideoPlayer 丂上丛东专丁不万丒;
    private bool 丐上丄丒与丝丁业丝;
    private bool 丄丏下一丙三丂丘下;
    private System.Collections.Generic.List<UnityEngine.GameObject> 且丂丏一三丟且丂丟;
    
    // Properties
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    
    // Methods
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    protected override void Awake()
    {
        this.Awake();
        if(VideoPlayerWindow.丆丕丝丒不丙且丐丗 == 0)
        {
                VideoPlayerWindow.丆丕丝丒不丙且丐丗 = this;
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        this.丂上丛东专丁不万丒 = this.GetComponent<UnityEngine.Video.VideoPlayer>();
    }
    public override void Show()
    {
        this.StopCoroutine(methodName:  "ShowVideoCoroutine");
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "ShowVideoCoroutine");
    }
    private System.Collections.IEnumerator ShowVideoCoroutine()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VideoPlayerWindow.丌世丂上丆丂丅丕丁();
    }
    private System.Collections.IEnumerator 七丒丐丁丌丑丐七丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VideoPlayerWindow.丙丛且丞世丛丂丅丘();
    }
    public void CloseWindow()
    {
        this.三丛下业丄万丈丄丐(丂上丛东专丁不万丒:  this.丂上丛东专丁不万丒);
    }
    private void 三丛下业丄万丈丄丐(UnityEngine.Video.VideoPlayer 丂上丛东专丁不万丒)
    {
        var val_4;
        System.Collections.Generic.List<UnityEngine.GameObject> val_8;
        var val_9;
        var val_10;
        var val_11;
        this.StopCoroutine(routine:  this.七丒丐丁丌丑丐七丅());
        val_8 = this.且丂丏一三丟且丂丟;
        List.Enumerator<T> val_2 = val_8.GetEnumerator();
        val_9 = 1152921519068955088;
        label_5:
        if((1690062864 & 1) == 0)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  true);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丐上丄丒与丝丁业丝 != false)
        {
                val_9 = 1152921505083416576;
            val_10 = null;
            val_10 = null;
            val_8 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
            if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
        {
                val_11 = null;
            val_11 = null;
            val_8 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
            val_8.三且世三丂七丐一丟();
        }
        
            this.丐上丄丒与丝丁业丝 = false;
        }
        
        if(this.丄丏下一丙三丂丘下 != false)
        {
                与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  true);
            this.丄丏下一丙三丂丘下 = false;
        }
        
        if(丂上丛东专丁不万丒.isPlaying != false)
        {
                丂上丛东专丁不万丒.Stop();
        }
        
        this.HideSelf();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.skipButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.redirectPanel, 丏业丟一东丂东丘丛:  false);
    }
    public void OnClickVideo()
    {
        string val_9;
        bool val_10;
        val_9 = this;
        if((System.String.IsNullOrWhiteSpace(value:  this.丈丞下下丒丘与丈丛)) == true)
        {
                return;
        }
        
        val_10 = PGCompany.Ads.万丆且丐丁丙丐丛不.丅上丌丒丐三一丙丁(七丙不丅丛丘丗万与:  this.丈丞下下丒丘与丈丛);
        if(VideoPlayerWindow.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[VideoPlayerWindow.OnClickVideo] shouldAttributeCrossPromoClick: "("[VideoPlayerWindow.OnClickVideo] shouldAttributeCrossPromoClick: ") + val_10.ToString() + ", redirectUrl: "(", redirectUrl: ") + this.丈丞下下丒丘与丈丛);
            val_10 = val_10;
        }
        
        if(val_10 != false)
        {
                val_9 = PGCompany.Ads.万丆且丐丁丙丐丛不.七丂丈丌世丐三万七();
            Rilisoft.丄上且丘丙丙丝丙丅.丘与丂丐业三专且丂(丗万丟万七专丗下丕:  val_9, 不三世丒丟一丘专丛:  "PG_crosspromo", 丗丟上上丒丐丗丞丙:  0, 业丏丈世世世丞丒世:  PGCompany.AppsFlyerTrackerCallbacks.丑七不且上丗丁一世());
            return;
        }
        
        UnityEngine.Application.OpenURL(url:  this.丈丞下下丒丘与丈丛);
    }
    public VideoPlayerWindow()
    {
        this.丁丘丌丟丘七丁丑丟 = 0;
        this.丆丁丁丘丘业七专七 = 0;
        this.丈丞下下丒丘与丈丛 = "";
        this.且丂丏一三丟且丂丟 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }
    private void 丑丌丁东丈丈丅丂三(UnityEngine.Video.VideoPlayer 丑东与丅丐丅丂丞业)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.skipButton, 丏业丟一东丂东丘丛:  true);
    }
    private void 专三丟丆专万丈上上()
    {
        this.Show();
    }

}
