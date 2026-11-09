using UnityEngine;
internal sealed class ComicsCampaign : MonoBehaviour
{
    // Fields
    private UnityEngine.Coroutine 丒丄丅丅丝丏丗且万;
    private int 东丘且丂下丟一七丕;
    private bool 丌七丘丞丐丘且丄七;
    private bool 七丛丙丏丗丏丁东丌;
    private System.Action 丒丕丞丒业三丝三下;
    private string[] 丄专世一丘丑不丈东;
    public UIButton backButton;
    public UnityEngine.UI.RawImage background;
    public UnityEngine.UI.RawImage[] comicFrames;
    public UIButton skipButton;
    public UnityEngine.UI.Text subtitlesText;
    private int 丄丄万丞不丝且丄丛;
    
    // Methods
    public void HandleSkipPressed()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        UnityEngine.Debug.Log(message:  "[Skip] pressed.");
        if(this.丒丕丞丒业三丝三下 == null)
        {
                return;
        }
        
        this.丒丕丞丒业三丝三下.Invoke();
    }
    public void HandleBackPressed()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "ChooseLevel");
    }
    private bool 七业不上丟丛下丈一()
    {
        var val_6;
        var val_7;
        var val_8;
        Rilisoft.丝丑丂丛万丐丈丘且 val_9;
        var val_10;
        var val_11;
        val_6 = null;
        val_6 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 == false)
        {
            goto label_3;
        }
        
        val_7 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
        val_8 = null;
        val_8 = null;
        if((val_7.与丏丌七丙万专丈东(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与)) == null)
        {
            goto label_16;
        }
        
        val_9 = val_2.丁丑丕且世丛丁东万;
        goto label_10;
        label_3:
        val_7 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
        val_10 = null;
        val_10 = null;
        if((val_7.七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) == null)
        {
            goto label_16;
        }
        
        val_9 = val_4.丁丑丕且世丛丁东万;
        label_10:
        var val_5 = (val_9 == 0) ? 1 : 0;
        return (bool)val_11;
        label_16:
        val_11 = 1;
        return (bool)val_11;
    }
    private void Awake()
    {
        if(this.subtitlesText != 0)
        {
                string val_10 = "English";
            val_10 = System.String.op_Inequality(a:  丟丏下丂七三下丗丕.丗七丏三万丛丙丟业(), b:  val_10);
            this.subtitlesText.transform.parent.gameObject.SetActive(value:  val_10);
        }
        
        int val_7 = System.Math.Min(val1:  4, val2:  this.comicFrames.Length);
        this.东丘且丂下丟一七丕 = val_7;
        this.七丛丙丏丗丏丁东丌 = val_7.七业不上丟丛下丈一();
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ComicsCampaign.丑丆七世上万下丟丙();
    }
    private void 专丑丏丌丆丆一不丒()
    {
        System.Action val_17;
        System.String[] val_18;
        System.String[] val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        int val_24;
        string val_25;
        var val_26;
        int val_27;
        if(this.七丛丙丏丗丏丁东丌 != false)
        {
                val_17 = 0;
        }
        else
        {
                System.Action val_1 = new System.Action(object:  this, method:  System.Void ComicsCampaign::丂业丟丕丆丆东丌世());
            val_17 = val_1;
        }
        
        this.业东丞丑丟丞丏丐丙(丞丂丛七与丟丈专丙:  val_1);
        int val_18 = this.丄丄万丞不丝且丄丛;
        val_18 = val_18 + 1;
        this.丄丄万丞不丝且丄丛 = val_18;
        if(this.丒丄丅丅丝丏丗且万 != null)
        {
                this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
        }
        
        val_18 = 0;
        goto label_4;
        label_23:
        if(this.comicFrames[0] == 0)
        {
            goto label_9;
        }
        
        this.comicFrames[0].texture = 0;
        this.comicFrames[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_19 = this.丄专世一丘丑不丈东;
        if(val_19 == null)
        {
            goto label_16;
        }
        
        if(System.String.alignConst != 0)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(System.String.alignConst == 0)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_19[0] = System.String.alignConst;
        label_9:
        val_18 = 1;
        label_4:
        if(val_18 != this.comicFrames.Length)
        {
            goto label_23;
        }
        
        UnityEngine.AsyncOperation val_3 = UnityEngine.Resources.UnloadUnusedAssets();
        if(this.东丘且丂下丟一七丕 == 0)
        {
            goto label_29;
        }
        
        val_19 = 1152921505078251520;
        label_60:
        val_20 = null;
        val_20 = null;
        UnityEngine.Texture val_7 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  ComicsCampaign.东丂丌丑丁七与丝一(丙丐一丕丗万丁下一:  (this.东丘且丂下丟一七丕 + 0) + 1, 丗业丞丐丙三丆丘丟:  LevelArt.丗业丞丐丙三丆丘丟));
        if(val_7 == 0)
        {
            goto label_29;
        }
        
        this.comicFrames[0].rectTransform.SetSizeWithCurrentAnchors(axis:  0, size:  (float)val_7);
        this.comicFrames[0].rectTransform.SetSizeWithCurrentAnchors(axis:  1, size:  (float)val_7);
        this.comicFrames[0].texture = val_7;
        val_21 = null;
        val_21 = null;
        val_22 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                val_23 = null;
            val_24 = this.东丘且丂下丟一七丕;
            val_25 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        }
        else
        {
                val_26 = null;
            val_24 = this.东丘且丂下丟一七丕;
            val_25 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万;
        }
        
        val_18 = this.丄专世一丘丑不丈东;
        val_27 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "{0}_{1}", arg0:  val_25, arg1:  0 + val_24));
        if(val_27 == null)
        {
            goto label_52;
        }
        
        if(val_18 == null)
        {
            goto label_53;
        }
        
        label_56:
        if(val_27 != null)
        {
            goto label_54;
        }
        
        goto label_58;
        label_52:
        val_27 = System.String.alignConst;
        if(val_18 != null)
        {
            goto label_56;
        }
        
        label_53:
        if(val_27 == 0)
        {
            goto label_58;
        }
        
        label_54:
        label_58:
        val_18[0] = val_27;
        if((0 + 1) != this.东丘且丂下丟一七丕)
        {
            goto label_60;
        }
        
        label_29:
        this.丒丄丅丅丝丏丗且万 = this.StartCoroutine(routine:  this.丕丁丒与世不丕丁三(丞丂丛七与丟丈专丙:  new System.Action(object:  this, method:  System.Void ComicsCampaign::丂业丟丕丆丆东丌世())));
    }
    private void 丂业丟丕丆丆东丌世()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(this.丒丄丅丅丝丏丗且万 != null)
        {
                this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
        }
        
        val_4 = null;
        val_4 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_6 = null;
            val_6 = null;
            val_5.一东丄丞与丂且丑丅(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与);
        }
        else
        {
                val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_7 = null;
            val_7 = null;
            val_5.一东丄丞与丂且丑丅(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万);
        }
        
        val_8 = null;
        val_8 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "ChooseLevel");
            return;
        }
        
        MainMenuController.丅与丁丌丝丒七不与();
    }
    private void 业东丞丑丟丞丏丐丙(System.Action 丞丂丛七与丟丈专丙)
    {
        this.丒丕丞丒业三丝三下 = 丞丂丛七与丟丈专丙;
        if(this.skipButton == 0)
        {
                return;
        }
        
        this.skipButton.gameObject.SetActive(value:  (丞丂丛七与丟丈专丙 != 0) ? 1 : 0);
    }
    private System.Collections.IEnumerator 丕丁丒与世不丕丁三(System.Action 丞丂丛七与丟丈专丙)
    {
        ComicsCampaign.下与丘丐业专一丒东 val_1 = new ComicsCampaign.下与丘丐业专一丒东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丞丂丛七与丟丈专丙 = 丞丂丛七与丟丈专丙;
        return (System.Collections.IEnumerator)val_1;
    }
    private static string 东丂丌丑丁七与丝一(int 丙丐一丕丗万丁下一, bool 丗业丞丐丙三丆丘丟)
    {
        var val_4;
        var val_5;
        string val_6;
        var val_7;
        val_4 = null;
        if(丗业丞丐丙三丆丘丟 != false)
        {
                val_5 = null;
            return (string)丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Arts", 丌丗丏丏丛东专丁且:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  val_6 = 1152921505169682440, 丌丗丏丏丛东专丁且:  丙丐一丕丗万丁下一.ToString()));
        }
        
        val_7 = null;
        return (string)丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Arts", 丌丗丏丏丛东专丁且:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  val_6, 丌丗丏丏丛东专丁且:  丙丐一丕丗万丁下一.ToString()));
    }
    public ComicsCampaign()
    {
        this.七丛丙丏丗丏丁东丌 = true;
        string[] val_1 = new string[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(System.String.alignConst != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(System.String.alignConst == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = System.String.alignConst;
        val_1[1] = System.String.alignConst;
        val_1[2] = System.String.alignConst;
        val_1[3] = System.String.alignConst;
        this.丄专世一丘丑不丈东 = val_1;
        this.comicFrames = new UnityEngine.UI.RawImage[4];
    }

}
