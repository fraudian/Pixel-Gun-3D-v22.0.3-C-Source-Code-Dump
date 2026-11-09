using UnityEngine;
internal sealed class ItemRewardListView : PGBehaviour
{
    // Fields
    private System.Action 世万万丌丘丛丟丒上;
    private System.Action<PGCompany.丄与丘丑业专丞七丅> 丒丄丒丈丛丈专三丞;
    public float stepDelay;
    internal ItemRewardView itemRewardViewExample;
    private UnityEngine.GameObject countHolder;
    private UILabel countLabel;
    private MiniPoolMonoBehaviour 万上万丛丌丟丗上丂;
    private WidgetLayout 丏专丌万与上丆丈三;
    private UIGrid 丝三不丑丏丘丒丂丗;
    private PositionHolder 丅业上丆丕上丝丄不;
    private UIScrollView 丅七丗丁丏丄丆丁丕;
    private ScrollViewHelper 丑丝丒丛业丌下与七;
    private UIPanel 丛丘下丗业丂一且业;
    private System.Collections.Generic.IEnumerable<PGCompany.丄与丘丑业专丞七丅> 丑丟上一三业万万丏;
    private System.Collections.Generic.List<ItemRewardView> 丁专丈丆丐丙世业丄;
    private bool 丗丞丄丐丈万丕丌一;
    private UnityEngine.Coroutine 三丌丏丟三上丂丑丂;
    private UnityEngine.Coroutine 丌丅下丞丄下丞丛丕;
    
    // Properties
    internal WidgetLayout 三东上丕丂世与丈一 { get; }
    
    // Methods
    public void add_onFillList(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.世万万丌丘丛丟丒上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世万万丌丘丛丟丒上 != 1152921539239393480);
    
    }
    public void remove_onFillList(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.世万万丌丘丛丟丒上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世万万丌丘丛丟丒上 != 1152921539239530056);
    
    }
    public void add_onAddReward(System.Action<PGCompany.丄与丘丑业专丞七丅> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒丄丒丈丛丈专三丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丄丒丈丛丈专三丞 != 1152921539239666640);
    
    }
    public void remove_onAddReward(System.Action<PGCompany.丄与丘丑业专丞七丅> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒丄丒丈丛丈专三丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丄丒丈丛丈专三丞 != 1152921539239803216);
    
    }
    internal WidgetLayout 三丂一业万七丟丈一()
    {
        return (WidgetLayout)this.丏专丌万与上丆丈三;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        UIScrollView val_16;
        if(this.万上万丛丌丟丗上丂 == 0)
        {
                this.万上万丛丌丟丗上丂 = this.GetComponent<MiniPoolMonoBehaviour>();
            this.itemRewardViewExample.gameObject.SetActive(value:  false);
            this.万上万丛丌丟丗上丂.SetupExample(丗丝丘丒丅丄专上丗:  this.itemRewardViewExample);
        }
        
        if(this.丏专丌万与上丆丈三 == 0)
        {
                this.丏专丌万与上丆丈三 = this.GetComponentInChildren<WidgetLayout>();
        }
        
        if(this.丝三不丑丏丘丒丂丗 == 0)
        {
                this.丝三不丑丏丘丒丂丗 = this.GetComponentInChildren<UIGrid>();
        }
        
        if(this.丅业上丆丕上丝丄不 == 0)
        {
                this.丅业上丆丕上丝丄不 = this.GetComponentInChildren<PositionHolder>(includeInactive:  true);
        }
        
        if(this.丅七丗丁丏丄丆丁丕 == 0)
        {
                this.丅七丗丁丏丄丆丁丕 = this.GetComponentInParent<UIScrollView>();
        }
        
        if(this.丑丝丒丛业丌下与七 == 0)
        {
                val_16 = this.丅七丗丁丏丄丆丁丕;
            this.丑丝丒丛业丌下与七 = val_16.GetComponent<ScrollViewHelper>();
        }
        
        if(this.丛丘下丗业丂一且业 != 0)
        {
                return;
        }
        
        this.丛丘下丗业丂一且业 = this.GetComponentInParent<UIPanel>();
    }
    internal void 丄一且丄丑专丙丗世()
    {
        List.Enumerator<T> val_1 = this.丁专丈丆丐丙世业丄.GetEnumerator();
        label_7:
        if((273754696 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_2.transform.SetParent(p:  this.万上万丛丌丟丗上丂.transform);
        this.万上万丛丌丟丗上丂.Return(万且万且丑丗且丌丆:  val_2);
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        this.丁专丈丆丐丙世业丄.Clear();
        this.一丆丆丗丝丞专丑专(丌丒丝东丌下丕丁丅:  0);
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丄与丘丑业专丞七丅 下丅丙一丂丗丅丝七)
    {
        PGCompany.丄与丘丑业专丞七丅[] val_1 = new PGCompany.丄与丘丑业专丞七丅[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(下丅丙一丂丗丅丝七 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 下丅丙一丂丗丅丝七;
        this.丈且东丑丂且万丒丅(丑丟上一三业万万丏:  val_1);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.IEnumerable<PGCompany.丄与丘丑业专丞七丅> 丑丟上一三业万万丏)
    {
        this.丑丟上一三业万万丏 = 丑丟上一三业万万丏;
        this.丗丞丄丐丈万丕丌一 = false;
        this.丝丗下且下专丗与下();
        this.一丆丆丗丝丞专丑专(丌丒丝东丌下丕丁丅:  System.Linq.Enumerable.Count<PGCompany.丄与丘丑业专丞七丅>(source:  this.丑丟上一三业万万丏));
        this.丑丂丌丂上丕下丐丄(丌丒丝东丌下丕丁丅:  System.Linq.Enumerable.Count<PGCompany.丄与丘丑业专丞七丅>(source:  this.丑丟上一三业万万丏));
    }
    private void OnEnable()
    {
        this.丝丗下且下专丗与下();
    }
    private void 丝丗下且下专丗与下()
    {
        if(this.三丌丏丟三上丂丑丂 != null)
        {
                this.StopCoroutine(routine:  this.三丌丏丟三上丂丑丂);
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.丗丞丄丐丈万丕丌一 == true)
        {
                return;
        }
        
        this.三丌丏丟三上丂丑丂 = this.StartCoroutine(routine:  this.丗丐丘三丒丐业丈丕());
    }
    private System.Collections.IEnumerator 丗丐丘三丒丐业丈丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ItemRewardListView.丌丂业上万丘不丒丗();
    }
    private void 一丆丆丗丝丞专丑专(int 丌丒丝东丌下丕丁丅)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countHolder, 丏业丟一东丂东丘丛:  (丌丒丝东丌下丕丁丅 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  丌丒丝东丌下丕丁丅);
    }
    private void 丑丂丌丂上丕下丐丄(int 丌丒丝东丌下丕丁丅)
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.丌丅下丞丄下丞丛丕 != null)
        {
                this.StopCoroutine(routine:  this.丌丅下丞丄下丞丛丕);
        }
        
        this.丌丅下丞丄下丞丛丕 = this.StartCoroutine(routine:  this.丄丘上且七丕丏与丗(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅));
    }
    private void SetParent(ItemRewardView 丑丂不下丁丄与万丏)
    {
        WidgetLayout val_6;
        WidgetLayout val_8;
        val_6 = this.丏专丌万与上丆丈三;
        if(val_6 != 0)
        {
                UnityEngine.Transform val_2 = 丑丂不下丁丄与万丏.transform;
            val_8 = this.丏专丌万与上丆丈三;
        }
        else
        {
                val_6 = this.丝三不丑丏丘丒丂丗;
            if(val_6 == 0)
        {
                return;
        }
        
            val_8 = this.丝三不丑丏丘丒丂丗;
        }
        
        丑丂不下丁丄与万丏.transform.SetParent(p:  val_8.transform);
    }
    private System.Collections.IEnumerator 丄丘上且七丕丏与丗(int 丌丒丝东丌下丕丁丅)
    {
        ItemRewardListView.丒丕丐下丕七丐丈丙 val_1 = new ItemRewardListView.丒丕丐下丕七丐丈丙();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丌丒丝东丌下丕丁丅 = 丌丒丝东丌下丕丁丅;
        return (System.Collections.IEnumerator)val_1;
    }
    public ItemRewardListView()
    {
        this.stepDelay = 1f;
        this.丁专丈丆丐丙世业丄 = new System.Collections.Generic.List<ItemRewardView>();
    }

}
