using UnityEngine;
internal sealed class ItemRewardListViewScrolled : PGBehaviour
{
    // Fields
    private System.Action 世万万丌丘丛丟丒上;
    private System.Action<PGCompany.丄与丘丑业专丞七丅> 丒丄丒丈丛丈专三丞;
    private float defaultScrollPosition;
    private System.Collections.Generic.List<ItemRewardListViewScrolled.GridPosition> linesScrollValues;
    private System.Collections.Generic.List<ItemRewardListViewScrolled.GridScale> scaleSettings;
    private ScrollViewHelper scrollHelper;
    private UIWidget scrollBarVerical;
    private int linesCountToShowScrollBar;
    public float stepDelay;
    internal ItemRewardView itemRewardViewExample;
    private UnityEngine.GameObject countHolder;
    private UILabel countLabel;
    private MiniPoolMonoBehaviour 万上万丛丌丟丗上丂;
    private UIGrid 丝三不丑丏丘丒丂丗;
    private System.Collections.Generic.IEnumerable<PGCompany.丄与丘丑业专丞七丅> 丑丟上一三业万万丏;
    private System.Collections.Generic.List<ItemRewardView> 丁专丈丆丐丙世业丄;
    private UnityEngine.Coroutine 三丌丏丟三上丂丑丂;
    internal int linesCountToScroll;
    
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
        while(this.世万万丌丘丛丟丒上 != 1152921539244016344);
    
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
        while(this.世万万丌丘丛丟丒上 != 1152921539244152920);
    
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
        while(this.丒丄丒丈丛丈专三丞 != 1152921539244289504);
    
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
        while(this.丒丄丒丈丛丈专三丞 != 1152921539244426080);
    
    }
    private void 丘上丐世丆丑且丞丒()
    {
        if(this.万上万丛丌丟丗上丂 == 0)
        {
                this.万上万丛丌丟丗上丂 = this.GetComponent<MiniPoolMonoBehaviour>();
            this.itemRewardViewExample.gameObject.SetActive(value:  false);
            this.万上万丛丌丟丗上丂.SetupExample(丗丝丘丒丅丄专上丗:  this.itemRewardViewExample);
        }
        
        if(this.丝三不丑丏丘丒丂丗 != 0)
        {
                return;
        }
        
        this.丝三不丑丏丘丒丂丗 = this.GetComponentInChildren<UIGrid>();
    }
    internal void 丄一且丄丑专丙丗世()
    {
        List.Enumerator<T> val_1 = this.丁专丈丆丐丙世业丄.GetEnumerator();
        label_8:
        if((278167256 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_2.transform.SetParent(p:  this.万上万丛丌丟丗上丂.transform);
        this.万上万丛丌丟丗上丂.Return(万且万且丑丗且丌丆:  val_2);
        goto label_8;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丁专丈丆丐丙世业丄.Clear();
        this.一丆丆丗丝丞专丑专(丌丒丝东丌下丕丁丅:  0);
        this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
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
        if(this.三丌丏丟三上丂丑丂 != null)
        {
                this.StopCoroutine(routine:  this.三丌丏丟三上丂丑丂);
        }
        
        this.三丌丏丟三上丂丑丂 = this.StartCoroutine(routine:  this.丗丐丘三丒丐业丈丕());
        this.一丆丆丗丝丞专丑专(丌丒丝东丌下丕丁丅:  System.Linq.Enumerable.Count<PGCompany.丄与丘丑业专丞七丅>(source:  this.丑丟上一三业万万丏));
    }
    private System.Collections.IEnumerator 丗丐丘三丒丐业丈丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ItemRewardListViewScrolled.三丞东丈丟不丄万东();
    }
    private void 一丆丆丗丝丞专丑专(int 丌丒丝东丌下丕丁丅)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countHolder, 丏业丟一东丂东丘丛:  (丌丒丝东丌下丕丁丅 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  丌丒丝东丌下丕丁丅);
    }
    private void SetParent(ItemRewardView 丑丂不下丁丄与万丏)
    {
        if(this.丝三不丑丏丘丒丂丗 == 0)
        {
                return;
        }
        
        丑丂不下丁丄与万丏.transform.SetParent(p:  this.丝三不丑丏丘丒丂丗.transform);
    }
    private void 与丁丞万丏丂业丝丁(int 丐丁上上专七丑丐丗)
    {
        int val_3 = 丐丁上上专七丑丐丗;
        if(this.linesCountToScroll >= val_3)
        {
                return;
        }
        
        val_3 = val_3 - this.linesCountToScroll;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.scrollHelper.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_1.x, y = -(this.丝三不丑丏丘丒丂丗.cellHeight * (float)val_3), z = val_1.z}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  true);
    }
    public ItemRewardListViewScrolled()
    {
        this.defaultScrollPosition = 140f;
        this.linesCountToShowScrollBar = 3;
        this.stepDelay = 1f;
        this.丁专丈丆丐丙世业丄 = new System.Collections.Generic.List<ItemRewardView>();
        this.linesCountToScroll = 2;
    }

}
