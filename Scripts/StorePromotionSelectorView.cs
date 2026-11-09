using UnityEngine;
internal class StorePromotionSelectorView : SelectableButtonController
{
    // Fields
    private System.Action 丗不世丙丏丅丄丂下;
    private PGCompany.东丑丆丗丏丐丟下丄 丘丑专丘丐丗丘东不;
    private System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 七丄丆丘丒与丐丘丅;
    private PGCompany.StorePromotionView selectedStorePromotionView;
    private MiniPoolMonoBehaviour selectorButtonsPool;
    private System.Collections.Generic.List<StorePromotionSelectorButton> 丈一一丌丗丕丗一丛;
    
    // Properties
    internal PGCompany.东丑丆丗丏丐丟下丄 一与丂七七世且下三 { get; }
    
    // Methods
    public void add_onSelect(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗不世丙丏丅丄丂下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921539307772728);
    
    }
    public void remove_onSelect(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗不世丙丏丅丄丂下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921539307909304);
    
    }
    internal PGCompany.东丑丆丗丏丐丟下丄 丌丂专七丞丑丁丐丆()
    {
        return (PGCompany.东丑丆丗丏丐丟下丄)this.丘丑专丘丐丗丘东不;
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 七丄丆丘丒与丐丘丅, PGCompany.东丑丆丗丏丐丟下丄 丛丗七丅下丞丗且丐)
    {
        var val_4;
        System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_12;
        System.Collections.Generic.IEnumerable<TSource> val_13;
        val_12 = 七丄丆丘丒与丐丘丅;
        val_13 = this;
        mem[1152921539308179384] = 0;
        this.丘丑专丘丐丗丘东不 = 0;
        this.七丄丆丘丒与丐丘丅 = val_12;
        this.丝一丅丆三东丂丞七();
        if(this == null)
        {
                return;
        }
        
        val_12 = System.Linq.Enumerable.FirstOrDefault<SelectableButton>(source:  this);
        if(丛丗七丅下丞丗且丐 == null)
        {
            goto label_19;
        }
        
        List.Enumerator<T> val_2 = this.GetEnumerator();
        label_13:
        if((341581840 & 1) == 0)
        {
            goto label_4;
        }
        
        val_13 = val_4.丐丏七丌丕丗业且上();
        if(val_13 != null)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        label_6:
        var val_6 = (null == null) ? (val_13) : 0;
        PGCompany.专丟专世丅丂丁且专 val_7 = typeof(System.String) == null ? val_5 : 0 + 88.七丈丒丒下下且万与();
        if(val_7 == null)
        {
            goto label_13;
        }
        
        PGCompany.专丟专世丅丂丁且专 val_8 = 丛丗七丅下丞丗且丐.七丈丒丒下下且万与();
        var val_12 = 0;
        val_12 = val_12 + 1;
        if((val_7.Equals(other:  null)) == false)
        {
            goto label_13;
        }
        
        val_12 = val_13;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_19:
        if(val_12 == 0)
        {
                return;
        }
    
    }
    internal void 丝一丅丆三东丂丞七()
    {
        this.业丞丗丈东专丂不丛();
        this.上丝上上世丅丙丈东();
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_2 == null)
        {
                return;
        }
        
        val_2.丛丗业丞上丂丏东丑();
    }
    private void 业丞丗丈东专丂不丛()
    {
        var val_3;
        var val_7 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectorButtonsPool.example, 丏业丟一东丂东丘丛:  false);
        this.丞七丐三丑东且丈下();
        if(this.七丄丆丘丒与丐丘丅 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.七丄丆丘丒与丐丘丅.GetEnumerator();
        label_11:
        if((341881648 & 1) == 0)
        {
            goto label_5;
        }
        
        StorePromotionSelectorButton val_5 = this.selectorButtonsPool.Get<StorePromotionSelectorButton>();
        val_5.Reset();
        val_5.丂丅七与丘丞丟万丕 = val_3.丐丏七丌丕丗业且上();
        val_5.丝一丅丆三东丂丞七();
        this.AddNewButton(丟丂丄丕下业丗丛丂:  val_5);
        this.丈一一丌丗丕丗一丛.Add(item:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        goto label_11;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.Reposition();
    }
    private void 丞七丐三丑东且丈下()
    {
        List.Enumerator<T> val_1 = this.丈一一丌丗丕丗一丛.GetEnumerator();
        label_4:
        if((342043848 & 1) == 0)
        {
            goto label_2;
        }
        
        this.selectorButtonsPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丈一一丌丗丕丗一丛.Clear();
        this.丈一一丌丗丕丗一丛.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.Clear();
    }
    private void 上丝上上世丅丙丈东()
    {
        var val_3;
        var val_4;
        PGCompany.东丑丆丗丏丐丟下丄 val_5;
        this.丘丑专丘丐丗丘东不 = 0;
        if(137121792 == 0)
        {
            goto label_3;
        }
        
        if(==0)
        {
            goto label_4;
        }
        
        val_3 = null;
        if(mem[137121792] == val_3)
        {
            goto label_5;
        }
        
        label_4:
        val_4 = null;
        val_3 = mem[137121792];
        goto label_6;
        label_3:
        val_5 = this.丘丑专丘丐丗丘东不;
        goto label_7;
        label_5:
        val_4 = val_3;
        label_6:
        var val_2 = (val_3 == val_4) ? 137121792 : 0;
        val_5 = mem[val_3 == val_4 ? 137121792 : 0 + 88];
        val_5 = val_3 == val_4 ? 137121792 : 0 + 88;
        this.丘丑专丘丐丗丘东不 = val_5;
        label_7:
        if(this.丗不世丙丏丅丄丂下 == null)
        {
                return;
        }
        
        this.丗不世丙丏丅丄丂下.Invoke();
    }
    public override bool SelectButton(SelectableButton 丕丐不丑三上万丝东)
    {
        this.上丝上上世丅丙丈东();
        return (bool)this.SelectButton(丕丐不丑三上万丝东:  丕丐不丑三上万丝东);
    }
    public StorePromotionSelectorView()
    {
        this.丈一一丌丗丕丗一丛 = new System.Collections.Generic.List<StorePromotionSelectorButton>();
    }

}
