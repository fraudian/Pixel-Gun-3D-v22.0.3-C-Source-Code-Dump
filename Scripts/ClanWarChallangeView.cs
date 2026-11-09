using UnityEngine;
internal class ClanWarChallangeView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.世丐下丕专东丘丏且>, 万丟丞不世丛七一专<ClanWarChallangeView>
{
    // Fields
    private Rilisoft.OfferItem <丂下丟专不东三七七>k__BackingField;
    private PGCompany.世丐下丕专东丘丏且 <丅丝丌丝丁丏丙东丞>k__BackingField;
    private PGCompany.ClanWarController 丄丆丙世丂一丈丛业;
    internal bool 一一丐丂不一业丞丝;
    private float 丕丆丏丆丈丙东与丗;
    private UnityEngine.Animator 丌上世不丗丁丐业丕;
    internal bool 专下七丌丙丂丟万丐;
    internal bool 丟丗丘丄丘丝丌上丞;
    internal bool 丆与一东丌不世丘丂;
    private bool 与丈东丁世丅丕丛丗;
    public int totalPoints;
    public int currentPoints;
    public int currentPointsWithoutMyInpact;
    public int existsPoints;
    private System.ValueTuple<int, int, int, bool> 丑上丝万下世丈丛丏;
    private PGCompany.丁下丒丕丆下丂丆丌 丛丌丌丁丌丁丐丈上;
    internal int 丟丘丛不专丟丂丐万;
    internal bool setCurrentProgressColor;
    internal bool setAllProgressColor;
    internal float timeForProgressBarAnimation;
    internal float timeForInpactAnimation;
    internal float timeDelayOnEndAnimation;
    private System.EventHandler 丄不与丒世专三专丕;
    private UILabel _pointsLabel;
    private UILabel _pointsMyLabel;
    private UnityEngine.GameObject _impactBar;
    private UILabel _percentImpact;
    private UIBasicSprite _progressSprite;
    private UIBasicSprite _currentProgressSprite;
    private UILabel _descriptionLabel;
    private System.Action<ClanWarChallangeView> 丅丕丌丛万丂丈七与;
    
    // Properties
    public Rilisoft.OfferItem 丛丌丞三丕丞上丘万 { get; set; }
    public PGCompany.世丐下丕专东丘丏且 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    public Rilisoft.OfferItem get_LastClickedReward()
    {
        return (Rilisoft.OfferItem)this.<丂下丟专不东三七七>k__BackingField;
    }
    private void 丝一七丁丁丗丒丆丝(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<丂下丟专不东三七七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public PGCompany.世丐下丕专东丘丏且 get_Context()
    {
        return (PGCompany.世丐下丕专东丘丏且)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    public void set_Context(PGCompany.世丐下丕专东丘丏且 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(PGCompany.世丐下丕专东丘丏且 与且专丈不万东一万)
    {
        System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_8;
        var val_9;
        this.<丂下丟专不东三七七>k__BackingField = 0;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
        {
                PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void ClanWarChallangeView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_2 = null;
            val_8 = val_2;
            val_2 = new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void ClanWarChallangeView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙世丙且不万万与下));
            PGCompany.世丐下丕专东丘丏且.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  val_2);
        }
        
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
        UnityEngine.Animator val_3 = this.GetComponent<UnityEngine.Animator>();
        this.丌上世不丗丁丐业丕 = val_3;
        val_3.ResetTrigger(name:  "Inpact");
        this.丆与一东丌不世丘丂 = false;
        if(this.丄不与丒世专三专丕 != null)
        {
                val_8 = 1152921504619573248;
            val_9 = null;
            val_9 = null;
            this.丄不与丒世专三专丕.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
        {
                PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void ClanWarChallangeView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            PGCompany.世丐下丕专东丘丏且.一丞世专与丙与丟上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void ClanWarChallangeView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            val_8 = 1152921504615792640;
            PGCompany.世丐下丕专东丘丏且.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void ClanWarChallangeView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙世丙且不万万与下)));
            PGCompany.世丐下丕专东丘丏且.丁七丙丈丑万丕丆与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void ClanWarChallangeView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙世丙且不万万与下)));
        }
        
        this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  0, 丙世丙且不万万与下:  false);
    }
    public void add_ContextChanged(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄不与丒世专三专丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄不与丒世专三专丕 != 1152921536715410584);
    
    }
    public void remove_ContextChanged(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄不与丒世专三专丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄不与丒世专三专丕 != 1152921536715547160);
    
    }
    private void 丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  万不且且丛丆东丒业, 丙世丙且不万万与下:  false);
    }
    internal void 丝一丅丆三东丂丞七()
    {
        this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丙世丙且不万万与下:  false);
    }
    private void 丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙世丙且不万万与下 = False)
    {
        PGCompany.世丐下丕专东丘丏且 val_28;
        string val_29;
        float val_31;
        float val_32;
        int val_33;
        string val_35;
        val_29 = this;
        if(this.与丈东丁世丅丕丛丗 == false)
        {
            goto label_1;
        }
        
        this.与丈东丁世丅丕丛丗 = false;
        label_49:
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        if(万不且且丛丆东丒业 != null)
        {
                val_28 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            if((System.String.op_Equality(a:  万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒(), b:  val_28.丅丙丛丑丌丆丌丕丒())) == true)
        {
                return;
        }
        
        }
        
        if(this.setAllProgressColor != false)
        {
                UnityEngine.Color val_4 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  1);
            val_31 = val_4.r;
            val_32 = val_4.b;
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._progressSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_31, g = val_4.g, b = val_32, a = val_4.a});
        }
        
        if(this.setCurrentProgressColor != false)
        {
                UnityEngine.Color val_5 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  2);
            val_31 = val_5.r;
            val_32 = val_5.b;
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._currentProgressSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_31, g = val_5.g, b = val_32, a = val_5.a});
        }
        
        PGCompany.ClanWarController val_6 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        this.丄丆丙世丂一丈丛业 = val_6;
        this.丛丌丌丁丌丁丐丈上 = val_6.丝且丗丌丟丈世上万();
        System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean> val_8 = this.丄丆丙世丂一丈丛业.GetTaskInfo();
        this.丑上丝万下世丈丛丏 = val_8;
        mem[1152921536716051148] = 0;
        mem[1152921536716051168] = (this.丟丗丘丄丘丝丌上丞 == true) ? 1152921536716051144 : 2044433092;
        this.totalPoints = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁丝丞与丟与丟丌三();
        val_33 = 1152921536716051124;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丞专丅丁丁三丄上专()) != true)
        {
                val_33 = this.丄丆丙世丂一丈丛业.丆丗丏丑上业专世不;
        }
        
        val_28 = mem[this.丄丆丙世丂一丈丛业.丆丗丏丑上业专世不];
        val_28 = val_33;
        this.currentPoints = val_28;
        this.currentPointsWithoutMyInpact = UnityEngine.Mathf.Clamp(value:  val_28 - this.丟丘丛不专丟丂丐万, min:  0, max:  this.totalPoints);
        this.existsPoints = UnityEngine.Mathf.Clamp(value:  this.currentPoints, min:  0, max:  this.totalPoints);
        if(this._pointsLabel != 0)
        {
                val_35 = System.String.Format(format:  "{0}/{1}", arg0:  this.currentPointsWithoutMyInpact, arg1:  this.totalPoints);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丞专丅丁丁三丄上专()) != false)
        {
                val_35 = System.String.Format(format:  "{0}/{1}", arg0:  this.totalPoints, arg1:  this.totalPoints);
        }
        
            val_28 = this._pointsLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_28, 丕丗丘丑丛与丑业丒:  val_35);
        }
        
        if(this._progressSprite != 0)
        {
                float val_20 = (float)this.currentPointsWithoutMyInpact / (float)this.totalPoints;
            this._progressSprite.fillAmount = val_20;
            float val_27 = (float)this.丟丘丛不专丟丂丐万;
            val_27 = val_27 / (float)this.totalPoints;
            val_31 = val_20 + val_27;
            this._currentProgressSprite.fillAmount = val_31;
            val_28 = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8427"), arg1:  UnityEngine.Mathf.RoundToInt(f:  (float)this.丟丘丛不专丟丂丐万));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._pointsMyLabel, 丕丗丘丑丛与丑业丒:  val_28);
        }
        
        if(this.丟丗丘丄丘丝丌上丞 == false)
        {
            goto label_42;
        }
        
        val_28 = true;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._impactBar, 丏业丟一东丂东丘丛:  true);
        float val_28 = (float)(float)this.丟丘丛不专丟丂丐万;
        val_28 = val_28 - (float)this.丟丘丛不专丟丂丐万;
        val_28 = val_28 / (float)this.totalPoints;
        val_31 = val_28 * 100f;
        this.丕丆丏丆丈丙东与丗 = val_31;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._percentImpact, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_31)));
        this.一一丐丂不一业丞丝 = val_28;
        goto label_47;
        label_1:
        if(this.一一丐丂不一业丞丝 == true)
        {
                return;
        }
        
        goto label_49;
        label_42:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._impactBar, 丏业丟一东丂东丘丛:  false);
        label_47:
        if(this._descriptionLabel == 0)
        {
                return;
        }
        
        val_29 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        this._descriptionLabel.text = val_29;
    }
    public void StartAnimation()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.且丌三丒不丑一丘且());
    }
    private System.Collections.IEnumerator 且丌三丒不丑一丘且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanWarChallangeView.丐不丂与七世丐下丛();
    }
    private System.Collections.IEnumerator 上万一万一丒业东世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanWarChallangeView.上丄丌与丄丄下丂丌();
    }
    internal void 丆丝且下专下业丑丝()
    {
        int val_11;
        PGCompany.ClanWarController val_1 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        this.丄丆丙世丂一丈丛业 = val_1;
        this.丛丌丌丁丌丁丐丈上 = val_1.丝且丗丌丟丈世上万();
        System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean> val_3 = this.丄丆丙世丂一丈丛业.GetTaskInfo();
        this.丑上丝万下世丈丛丏 = val_3;
        mem[1152921536716699852] = 0;
        mem[1152921536716699872] = (this.丟丗丘丄丘丝丌上丞 == true) ? 1152921536716699848 : 2045081796;
        val_11 = this;
        this.totalPoints = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁丝丞与丟与丟丌三();
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丞专丅丁丁三丄上专()) != true)
        {
                val_11 = this.丄丆丙世丂一丈丛业.丆丗丏丑上业专世不;
        }
        
        this.currentPoints = val_11;
        this.currentPointsWithoutMyInpact = UnityEngine.Mathf.Clamp(value:  val_11 - this.丟丘丛不专丟丂丐万, min:  0, max:  this.totalPoints);
        this.existsPoints = UnityEngine.Mathf.Clamp(value:  this.currentPoints, min:  0, max:  this.totalPoints);
        this.与丈东丁世丅丕丛丗 = true;
        this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  this.丛丌丌丁丌丁丐丈上.下三下东业丘且丟业(), 丙世丙且不万万与下:  false);
    }
    public void UpdateImpactProgress()
    {
        System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean> val_1 = this.丄丆丙世丂一丈丛业.GetTaskInfo();
        this.丑上丝万下世丈丛丏 = val_1;
        mem[1152921536716865100] = 0;
        mem[1152921536716865120] = (this.丟丗丘丄丘丝丌上丞 == true) ? 1152921536716865096 : 2045247044;
        this.totalPoints = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁丝丞与丟与丟丌三();
        if(this.丟丗丘丄丘丝丌上丞 != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._impactBar, 丏业丟一东丂东丘丛:  true);
            float val_7 = (float)S0;
            val_7 = val_7 - (float)this.丟丘丛不专丟丂丐万;
            val_7 = val_7 / (float)this.totalPoints;
            float val_4 = val_7 * 100f;
            this.丕丆丏丆丈丙东与丗 = val_4;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._percentImpact, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_4)));
            this.一一丐丂不一业丞丝 = true;
            return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._impactBar, 丏业丟一东丂东丘丛:  false);
    }
    public void ImpactAnimationPopEnd()
    {
        this.丆与一东丌不世丘丂 = false;
    }
    public void U_Click()
    {
    
    }
    public void U_GoToBattle()
    {
    
    }
    public void U_Claim()
    {
    
    }
    public void add_Clicked(System.Action<ClanWarChallangeView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921536717462072);
    
    }
    public void remove_Clicked(System.Action<ClanWarChallangeView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921536717598648);
    
    }
    public ClanWarChallangeView()
    {
        this.setAllProgressColor = true;
        this.timeForProgressBarAnimation = 1f;
        this.timeForInpactAnimation = 1f;
        this.timeDelayOnEndAnimation = 1f;
    }

}
