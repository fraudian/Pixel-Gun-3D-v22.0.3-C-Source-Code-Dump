using UnityEngine;
internal sealed class UniversalMiniBannerListUI : PGBehaviour
{
    // Fields
    private System.Action 丏上丟东丟下上丄且;
    private float showTime;
    private bool smooth;
    private WidgetLayout layout;
    private ScrollViewHelper scrollHelper;
    public MiniPoolGroup poolGroup;
    private System.Collections.Generic.List<MiniBannerEntry> 丑丌丟东丙万丞且丘;
    private MiniBannerEntry 上丞丐丒丕丆丆丞专;
    private UnityEngine.Coroutine 丌丞丅丝世丟丈专上;
    private float 丈东丈且不东丞专丒;
    private UnityEngine.Coroutine 丕且丁丄丆丟世丅丁;
    
    // Methods
    internal void 东丄专丁上丝万下丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏上丟东丟下上丄且, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏上丟东丟下上丄且 != 1152921539451104024);
    
    }
    internal void 七世丁业与丈丄万丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏上丟东丟下上丄且, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏上丟东丟下上丄且 != 1152921539451240600);
    
    }
    private bool 不丌丈丌丁丁且万丌(MiniBannerEntry 三且丑东与丝丛丐丏)
    {
        MiniBannerEntry val_6;
        var val_7;
        val_6 = 三且丑东与丝丛丐丏;
        if((this.丑丌丟东丙万丞且丘.Contains(item:  val_6)) != false)
        {
                val_7 = 0;
            return (bool)val_7;
        }
        
        this.丑丌丟东丙万丞且丘.Add(item:  val_6);
        三且丑东与丝丛丐丏.view.transform.SetParent(p:  this.layout.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  三且丑东与丝丛丐丏.view.transform);
        val_6 = 三且丑东与丝丛丐丏.data;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Add Banner: "("Add Banner: ") + 三且丑东与丝丛丐丏.data.丞丅上丏丂且下丅与);
        val_7 = 1;
        return (bool)val_7;
    }
    internal bool 丂丒七丌与上万丆丁(MiniBannerEntry 三且丑东与丝丛丐丏)
    {
        MiniBannerEntry val_5;
        var val_6;
        val_5 = 三且丑东与丝丛丐丏;
        if(三且丑东与丝丛丐丏.data == null)
        {
            goto label_6;
        }
        
        if(三且丑东与丝丛丐丏.data.丏不万且丑丗丄一丕 >= 1)
        {
                if(PixelTime.丙三丝下丛丈丌丟下() >= 三且丑东与丝丛丐丏.data.丏不万且丑丗丄一丕)
        {
            goto label_6;
        }
        
        }
        
        if((this.不丌丈丌丁丁且万丌(三且丑东与丝丛丐丏:  val_5)) == false)
        {
            goto label_11;
        }
        
        this.丘且不丛业丂丐三丘();
        val_6 = 1;
        return (bool)val_6;
        label_6:
        if(三且丑东与丝丛丐丏.view != 0)
        {
                val_5 = 三且丑东与丝丛丐丏.view.gameObject;
            UnityEngine.Object.Destroy(obj:  val_5);
        }
        
        label_11:
        val_6 = 0;
        return (bool)val_6;
    }
    private bool 不且丞不丗丏丒丆不(MiniBannerEntry 三且丑东与丝丛丐丏)
    {
        MiniBannerEntry val_5;
        System.Collections.Generic.List<MiniBannerEntry> val_6;
        var val_7;
        val_5 = 三且丑东与丝丛丐丏;
        val_6 = this.丑丌丟东丙万丞且丘;
        if((val_6.Contains(item:  val_5)) != false)
        {
                if(this.上丞丐丒丕丆丆丞专 == val_5)
        {
                this.上丞丐丒丕丆丆丞专 = 0;
        }
        
            val_6 = this.poolGroup;
            val_6.Return(丛丄业丕且丗下一万:  三且丑东与丝丛丐丏.view.name, 万且万且丑丗且丌丆:  三且丑东与丝丛丐丏.view);
            bool val_3 = this.丑丌丟东丙万丞且丘.Remove(item:  val_5);
            val_5 = 三且丑东与丝丛丐丏.data;
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Remove Banner: "("Remove Banner: ") + 三且丑东与丝丛丐丏.data.丞丅上丏丂且下丅与);
            val_7 = 1;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    internal void 丕东丅丒丏丐丘丌丙(MiniBannerEntry 三且丑东与丝丛丐丏)
    {
        if((this.不且丞不丗丏丒丆不(三且丑东与丝丛丐丏:  三且丑东与丝丛丐丏)) == false)
        {
                return;
        }
        
        this.丘且不丛业丂丐三丘();
    }
    internal void 丕东丅丒丏丐丘丌丙(string 丞丅上丏丂且下丅与)
    {
        MiniBannerEntry val_5;
        List.Enumerator<T> val_1 = this.丑丌丟东丙万丞且丘.GetEnumerator();
        label_5:
        if((485467496 & 1) == 0)
        {
            goto label_2;
        }
        
        val_5 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength + 16, b:  丞丅上丏丂且下丅与)) == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_2:
        val_5 = 0;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((this.不且丞不丗丏丒丆不(三且丑东与丝丛丐丏:  null)) == false)
        {
                return;
        }
        
        this.丘且不丛业丂丐三丘();
    }
    internal UniversalMiniBannerView 丙丈丞万丂丞丙丅丆(string 丞丅上丏丂且下丅与)
    {
        var val_4;
        List.Enumerator<T> val_1 = this.丑丌丟东丙万丞且丘.GetEnumerator();
        label_5:
        if((485604072 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength + 16, b:  丞丅上丏丂且下丅与)) == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_2:
        val_4 = 0;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (UniversalMiniBannerView)val_4;
    }
    private void 丘且不丛业丂丐三丘()
    {
        this.layout.CollectWidgets();
        this.layout.Reposition();
        if(this.丏上丟东丟下上丄且 == null)
        {
                return;
        }
        
        this.丏上丟东丟下上丄且.Invoke();
    }
    private void 丏丈上丏丝下且丁七()
    {
        var val_7 = (this.丑丌丟东丙万丞且丘.IndexOf(item:  this.上丞丐丒丕丆丆丞专)) + 1;
        if((val_7 & 2147483648) == 0)
        {
                if(val_7 < this.丑丌丟东丙万丞且丘.Count)
        {
            goto label_4;
        }
        
        }
        
        val_7 = 0;
        label_4:
        if(this.丑丌丟东丙万丞且丘.Count <= 0)
        {
            goto label_6;
        }
        
        MiniBannerEntry val_4 = this.丑丌丟东丙万丞且丘.Item[0];
        this.上丞丐丒丕丆丆丞专 = val_4;
        if(val_4 == null)
        {
                return;
        }
        
        label_11:
        this.丈东丈且不东丞专丒 = this.showTime;
        this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  val_4.view.transform, 丌与丟丁万丝丞丄丏:  (this.smooth == true) ? 1 : 0);
        return;
        label_6:
        if(this.上丞丐丒丕丆丆丞专 != null)
        {
            goto label_11;
        }
    
    }
    private void 丁丙上丅丂丅丌下专()
    {
        var val_4;
        var val_10;
        System.Collections.Generic.List<MiniBannerEntry> val_11;
        val_10 = this;
        System.Collections.Generic.List<MiniBannerEntry> val_1 = new System.Collections.Generic.List<MiniBannerEntry>();
        val_11 = this.丑丌丟东丙万丞且丘;
        List.Enumerator<T> val_2 = val_11.GetEnumerator();
        label_11:
        if((486078272 & 1) == 0)
        {
            goto label_2;
        }
        
        if(((val_5.m_stringLength + 24) < 1) || (PixelTime.丙三丝下丛丈丌丟下() < (val_5.m_stringLength + 24)))
        {
            goto label_11;
        }
        
        val_1.Add(item:  val_4.丐丏七丌丕丗业且上());
        goto label_11;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_7 = val_1.GetEnumerator();
        label_23:
        if((486078272 & 1) == 0)
        {
            goto label_21;
        }
        
        if((this.不且丞不丗丏丒丆不(三且丑东与丝丛丐丏:  val_4.丐丏七丌丕丗业且上())) == false)
        {
            goto label_23;
        }
        
        this.丘且不丛业丂丐三丘();
        goto label_23;
        label_21:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void OnEnable()
    {
        if(this.丕且丁丄丆丟世丅丁 != null)
        {
                this.StopCoroutine(routine:  this.丕且丁丄丆丟世丅丁);
        }
        
        this.丕且丁丄丆丟世丅丁 = this.StartCoroutine(routine:  this.上业丌丄丛万丛世丐());
        if(this.丌丞丅丝世丟丈专上 != null)
        {
                this.StopCoroutine(routine:  this.丌丞丅丝世丟丈专上);
        }
        
        this.丌丞丅丝世丟丈专上 = this.StartCoroutine(routine:  this.专万万一丁业丘下丕());
    }
    private System.Collections.IEnumerator 专万万一丁业丘下丕()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UniversalMiniBannerListUI.丄丅三丛丘业一丏上(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 上业丌丄丛万丛世丐()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UniversalMiniBannerListUI.万专丐丗丘丆且丗东(丗丏丅丕丆世丁专丟:  0);
    }
    public UniversalMiniBannerListUI()
    {
        this.showTime = 5f;
        this.smooth = true;
        this.丑丌丟东丙万丞且丘 = new System.Collections.Generic.List<MiniBannerEntry>();
        this.丈东丈且不东丞专丒 = -1f;
    }

}
