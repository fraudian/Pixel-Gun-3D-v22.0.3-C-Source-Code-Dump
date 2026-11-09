using UnityEngine;
public abstract class CurrencyUpdater : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UILabel> labels;
    public UISprite blinkObj;
    public bool ignoreX3;
    protected bool 七一丗丁下东丒丐丟;
    public UnityEngine.AudioClip clipTicketsAdded;
    public bool useSelectedColors;
    public UnityEngine.Color normalColorX3;
    public UnityEngine.Color normalColor;
    private System.Nullable<UnityEngine.Color> 三一丑丘丛丆丘丟专;
    private float 丌丗丟一丐丞丈世上;
    
    // Properties
    protected virtual UnityEngine.Color 丝三东三丆不业丞业 { get; }
    protected abstract string 世丟丑丘丘业七丑不 { get; }
    
    // Methods
    private void Start()
    {
        Holoville.HOTween.HOTween.Init(p_permanentInstance:  true, p_renameInstanceToCountTweens:  true, p_allowOverwriteManager:  true);
        Holoville.HOTween.HOTween.EnableOverwriteManager(logWarnings:  true);
        this.丏七且万丒东丏丛丅();
        UnityEngine.Color val_1 = this.且不业七丄丂世且一();
        this.blinkObj.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丌丗丟一丐丞丈世上;
        if(val_1 < 1f)
        {
                return;
        }
        
        this.丏七且万丒东丏丛丅();
    }
    protected virtual void OnEnable()
    {
        this.七一丗丁下东丒丐丟 = false;
        BankController.丁下丂丒万一下七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CurrencyUpdater::丏七且万丒东丏丛丅()));
    }
    private void 丅下丄丟丆丗不丒七()
    {
        this.下丛世丆不丏七东丑();
        UnityEngine.Color val_1 = this.且不业七丄丂世且一();
        this.blinkObj.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    protected void 上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)
    {
        Holoville.HOTween.TweenParms val_20;
        if(丌丒丝东丌下丕丁丅 == 0)
        {
                return;
        }
        
        this.下丛世丆不丏七东丑();
        UnityEngine.Color val_5 = this.且不业七丄丂世且一();
        val_20 = new Holoville.HOTween.TweenParms().Prop(p_propName:  "color", p_endVal:  val_5).Ease(p_easeType:  0);
        Holoville.HOTween.Sequence val_12 = new Holoville.HOTween.Sequence(p_parms:  new Holoville.HOTween.SequenceParms().Id(p_id:  this).Loops(p_loops:  15).UpdateType(p_updateType:  3));
        float val_14 = val_12.Append(p_twMember:  Holoville.HOTween.HOTween.To(p_target:  this.blinkObj, p_duration:  0.1f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "color", p_endVal:  ???).Ease(p_easeType:  0)));
        Holoville.HOTween.Tweener val_15 = Holoville.HOTween.HOTween.To(p_target:  this.blinkObj, p_duration:  0.1f, p_parms:  val_20);
        if(val_12 != null)
        {
                float val_16 = val_12.Append(p_twMember:  val_15);
        }
        else
        {
                float val_17 = val_12.Append(p_twMember:  val_15);
        }
        
        val_12.Play();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_19 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.clipTicketsAdded);
        }
        
        this.丌丗丟一丐丞丈世上 = 0f;
    }
    private void 下丛世丆不丏七东丑()
    {
        int val_1 = Holoville.HOTween.HOTween.Kill(p_id:  this);
        UnityEngine.Color val_2 = this.且不业七丄丂世且一();
        this.blinkObj.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    protected virtual void OnDisable()
    {
        BankController.与丄丅丘且丟世丗丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CurrencyUpdater::丏七且万丒东丏丛丅()));
        this.下丛世丆不丏七东丑();
    }
    private void OnDestroy()
    {
        this.下丛世丆不丏七东丑();
    }
    protected void 丏七且万丒东丏丛丅()
    {
        this.丌丗丟一丐丞丈世上 = UnityEngine.Time.realtimeSinceStartup;
        if(this.七一丗丁下东丒丐丟 != false)
        {
                return;
        }
        
        .丕丗丘丑丛与丑业丒 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  -220867104);
        if(this.labels == null)
        {
                return;
        }
        
        this.labels.ForEach(action:  new System.Action<UILabel>(object:  new CurrencyUpdater.丞丆丌万丛不且七丐(), method:  System.Void CurrencyUpdater.丞丆丌万丛不且七丐::丗且且丑丏东丕七丒(UILabel 丐三丞七丝丅不万丛)));
    }
    protected abstract int 丞下丂下东东丅一七(); // 0
    protected virtual UnityEngine.Color 丐业丅丒丅丁丞且丝()
    {
        if(this.三一丑丘丛丆丘丟专.HasValue == true)
        {
                return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private UnityEngine.Color 且不业七丄丂世且一()
    {
        var val_4 = this;
        if(this.ignoreX3 == false)
        {
            goto label_1;
        }
        
        label_10:
        if(this.useSelectedColors == false)
        {
            goto label_2;
        }
        
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        label_1:
        if((丅且东丙业丏丛东丛.丑七不且上丗丁一世() == null) || (丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌() == false))
        {
            goto label_10;
        }
        
        if(this.useSelectedColors == false)
        {
            goto label_11;
        }
        
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        label_2:
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        label_11:
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    protected abstract string 丌东世丁丁丌丐丕丟(); // 0
    protected CurrencyUpdater()
    {
        this.normalColorX3 = 0;
        mem[1152921525861185184] = 0;
        mem[1152921525861185192] = 0;
        this.normalColor = 0;
        mem[1152921525861185200] = 0;
        mem[1152921525861185208] = 0;
        this.丌丗丟一丐丞丈世上 = -3.402823E+38f;
    }

}
