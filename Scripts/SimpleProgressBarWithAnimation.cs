using UnityEngine;
internal sealed class SimpleProgressBarWithAnimation : PGBehaviour
{
    // Fields
    public bool showMaxValue;
    public float animationSpeed;
    public int initialValue;
    internal UIWidget mainWidget;
    private System.Collections.Generic.List<UISprite> startFill;
    private System.Collections.Generic.List<UISprite> endFill;
    private System.Collections.Generic.List<UISprite> animatedFill;
    private string progressLocalizationKey;
    private bool readableProgressNumber;
    private System.Collections.Generic.List<UILabel> countLabel;
    private System.Collections.Generic.List<WidgetLayout> widgetLayouts;
    private UnityEngine.AudioSource fillSound;
    private UnityEngine.AudioClip fullSound;
    private float minPitch;
    private float maxPitch;
    internal BarFillPoint barFillPoint;
    private UnityEngine.GameObject fullBarAnimation;
    public System.Collections.Generic.List<UIRect> rectsToUpdate;
    public bool selectOnClick;
    private int 丛七专下上丒丝丗丟;
    private int 业三丞丟丆世丄丗丒;
    private int 丏丗丟丂丟丒与丒丑;
    private bool 丈世万丙丟东与丕丞;
    internal System.Action 万万丗丛丏丐七丘丏;
    internal System.Action 世丅丙世不三丈世丅;
    private float 丞万丞丆丕丆专万丒;
    private bool 万丝专丌丌三丟丆丄;
    private float 下三不丗万丆三丞万;
    private float 丘世世丟丙七丟丞丄;
    
    // Properties
    public float 三丑丌上丐七三丝丄 { get; }
    
    // Methods
    public void UpdateRects()
    {
        List.Enumerator<T> val_1 = this.rectsToUpdate.GetEnumerator();
        label_7:
        if((313789256 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.ResetAndUpdateAnchors();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public float get_AnimatedFillValue()
    {
        return (float)this.下三不丗万丆三丞万;
    }
    internal void 三一丞丗七专丑丐且()
    {
        this.万丝专丌丌三丟丆丄 = false;
    }
    internal void 丈且东丑丂且万丒丅(int 丄且一丄丏丆丐丗与, int 丑丒丒丅七丞东丟丕, int 七丝东丛东丝且丆不, bool 丈世万丙丟东与丕丞 = True)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fullBarAnimation, 丏业丟一东丂东丘丛:  false);
        this.万丝专丌丌三丟丆丄 = false;
        if(this.fillSound != 0)
        {
                this.fillSound.Stop();
        }
        
        this.丛七专下上丒丝丗丟 = 丄且一丄丏丆丐丗与;
        this.业三丞丟丆世丄丗丒 = 丑丒丒丅七丞东丟丕;
        this.丏丗丟丂丟丒与丒丑 = 七丝东丛东丝且丆不;
        this.世与丕与丗专丒且丘();
        float val_6 = (float)this.丛七专下上丒丝丗丟;
        val_6 = val_6 / (float)this.丏丗丟丂丟丒与丒丑;
        float val_2 = UnityEngine.Mathf.Min(a:  val_6, b:  (float)this.丏丗丟丂丟丒与丒丑);
        this.丞万丞丆丕丆专万丒 = val_2;
        this.下三不丗万丆三丞万 = val_2;
        float val_7 = (float)this.业三丞丟丆世丄丗丒;
        val_7 = val_7 / (float)this.丏丗丟丂丟丒与丒丑;
        this.丘世世丟丙七丟丞丄 = UnityEngine.Mathf.Min(a:  val_7, b:  1f);
        if(((丈世万丙丟东与丕丞 != false) && (this.丛七专下上丒丝丗丟 < this.丏丗丟丂丟丒与丒丑)) && (this.丛七专下上丒丝丗丟 < this.业三丞丟丆世丄丗丒))
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.fillSound != 0)
        {
                this.fillSound.loop = true;
            this.fillSound.Play();
        }
        
        }
        
            this.万丝专丌丌三丟丆丄 = true;
            return;
        }
        
        this.世丛丐丂不业七丝三();
    }
    private void 世与丕与丗专丒且丘()
    {
        this.丑不丕三丙丑丕东丄(上丞丕专丈业丁世专:  this.丛七专下上丒丝丗丟 + this.initialValue, 七丝东丛东丝且丆不:  this.丏丗丟丂丟丒与丒丑);
        float val_2 = (float)this.丛七专下上丒丝丗丟;
        val_2 = val_2 / (float)this.丏丗丟丂丟丒与丒丑;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.startFill, 丙业与丙丗丝不丈东:  val_2);
        float val_3 = (float)this.丛七专下上丒丝丗丟;
        val_3 = val_3 / (float)this.丏丗丟丂丟丒与丒丑;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.animatedFill, 丙业与丙丗丝不丈东:  val_3);
        float val_4 = (float)this.业三丞丟丆世丄丗丒;
        val_4 = val_4 / (float)this.丏丗丟丂丟丒与丒丑;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.endFill, 丙业与丙丗丝不丈东:  val_4);
    }
    private void 丌丅丐丘丐丁下丟上()
    {
        this.丑不丕三丙丑丕东丄(上丞丕专丈业丁世专:  this.业三丞丟丆世丄丗丒 + this.initialValue, 七丝东丛东丝且丆不:  this.丏丗丟丂丟丒与丒丑);
        float val_2 = (float)this.丛七专下上丒丝丗丟;
        val_2 = val_2 / (float)this.丏丗丟丂丟丒与丒丑;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.startFill, 丙业与丙丗丝不丈东:  val_2);
        float val_3 = (float)this.业三丞丟丆世丄丗丒;
        val_3 = val_3 / (float)this.丏丗丟丂丟丒与丒丑;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.animatedFill, 丙业与丙丗丝不丈东:  val_3);
        float val_4 = (float)this.业三丞丟丆世丄丗丒;
        val_4 = val_4 / (float)this.丏丗丟丂丟丒与丒丑;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.endFill, 丙业与丙丗丝不丈东:  val_4);
    }
    private void 七丘丁丁与丄下丁一(string 丕丗丘丑丛与丑业丒)
    {
        object val_5;
        string val_6;
        val_5 = 丕丗丘丑丛与丑业丒;
        val_6 = this.progressLocalizationKey;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != true)
        {
                val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.progressLocalizationKey);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != true)
        {
                val_5 = System.String.Format(format:  val_6, arg0:  val_5);
        }
        
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_5);
    }
    internal void 世丛丐丂不业七丝三()
    {
        if(this.业三丞丟丆世丄丗丒 >= this.丏丗丟丂丟丒与丒丑)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.fullSound);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fullBarAnimation, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        if(this.fillSound != 0)
        {
                this.fillSound.Stop();
        }
        
        this.万丝专丌丌三丟丆丄 = false;
        this.丌丅丐丘丐丁下丟上();
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.widgetLayouts);
        if(this.万万丗丛丏丐七丘丏 != null)
        {
                this.万万丗丛丏丐七丘丏.Invoke();
        }
        
        if(this.万丝专丌丌三丟丆丄 == false)
        {
                return;
        }
        
        if(this.世丅丙世不三丈世丅 == null)
        {
                return;
        }
        
        this.世丅丙世不三丈世丅.Invoke();
    }
    private void 丐丄丝东丆丆万丐专()
    {
        float val_9;
        if(this.万丝专丌丌三丟丆丄 == false)
        {
                return;
        }
        
        val_9 = UnityEngine.Time.deltaTime;
        float val_3 = UnityEngine.Mathf.MoveTowards(current:  this.下三不丗万丆三丞万, target:  this.丘世世丟丙七丟丞丄, maxDelta:  val_9 * this.animationSpeed);
        this.下三不丗万丆三丞万 = val_3;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.animatedFill, 丙业与丙丗丝不丈东:  val_3);
        if(this.fillSound != 0)
        {
                val_9 = this.minPitch;
            this.fillSound.pitch = UnityEngine.Mathf.Lerp(a:  val_9, b:  this.maxPitch, t:  UnityEngine.Mathf.InverseLerp(a:  this.丞万丞丆丕丆专万丒, b:  this.丘世世丟丙七丟丞丄, value:  this.下三不丗万丆三丞万));
        }
        
        float val_9 = (float)this.丏丗丟丂丟丒与丒丑;
        float val_10 = (float)this.initialValue;
        val_9 = this.下三不丗万丆三丞万 * val_9;
        val_10 = val_9 + val_10;
        this.丑不丕三丙丑丕东丄(上丞丕专丈业丁世专:  UnityEngine.Mathf.FloorToInt(f:  val_10), 七丝东丛东丝且丆不:  this.丏丗丟丂丟丒与丒丑);
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.widgetLayouts);
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  this.下三不丗万丆三丞万, 丒丈丙丐丏丕丆万丗:  this.丘世世丟丙七丟丞丄, 丌丕丗七丒丛万丒东:  0.001f)) == false)
        {
                return;
        }
        
        this.世丛丐丂不业七丝三();
    }
    private void 丑不丕三丙丑丕东丄(int 上丞丕专丈业丁世专, int 七丝东丛东丝且丆不)
    {
        string val_7;
        var val_9;
        if(this.readableProgressNumber != false)
        {
                val_7 = 专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)上丞丕专丈业丁世专);
            string val_2 = 专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)七丝东丛东丝且丆不);
        }
        else
        {
                val_7 = 上丞丕专丈业丁世专.ToString();
        }
        
        if(this.showMaxValue != false)
        {
                val_9 = val_7 + "/"("/") + 七丝东丛东丝且丆不.ToString();
        }
        
        this.七丘丁丁与丄下丁一(丕丗丘丑丛与丑业丒:  (val_7 == null) ? "" : (val_7));
    }
    private void Update()
    {
        this.丐丄丝东丆丆万丐专();
    }
    public SimpleProgressBarWithAnimation()
    {
        this.showMaxValue = true;
        this.animationSpeed = 0.25f;
        this.minPitch = 1.701412E+38f;
        this.maxPitch = 2f;
        this.selectOnClick = true;
    }

}
