using UnityEngine;
internal class ItemListUI : PGBehaviour
{
    // Fields
    internal PGCompany.InventoryItemView itemViewExample;
    private MiniPoolMonoBehaviour 万上万丛丌丟丗上丂;
    private WidgetLayout 丏专丌万与上丆丈三;
    private UIGrid 丝三不丑丏丘丒丂丗;
    private PositionHolder 丅业上丆丕上丝丄不;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> 丟丟且丄丑丝丑丒丅;
    
    // Properties
    internal System.Collections.Generic.List<PGCompany.InventoryItemView> 丈与丞丑丂丑丏下世 { get; }
    internal WidgetLayout 三东上丕丂世与丈一 { get; }
    
    // Methods
    internal System.Collections.Generic.List<PGCompany.InventoryItemView> 丆业丈丐丞丄丙业丂()
    {
        return (System.Collections.Generic.List<PGCompany.InventoryItemView>)this.丟丟且丄丑丝丑丒丅;
    }
    internal WidgetLayout 三丂一业万七丟丈一()
    {
        return (WidgetLayout)this.丏专丌万与上丆丈三;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        if(this.万上万丛丌丟丗上丂 == 0)
        {
                this.万上万丛丌丟丗上丂 = this.GetComponent<MiniPoolMonoBehaviour>();
            this.itemViewExample.gameObject.SetActive(value:  false);
            this.万上万丛丌丟丗上丂.SetupExample(丗丝丘丒丅丄专上丗:  this.itemViewExample);
        }
        
        if(this.丏专丌万与上丆丈三 == 0)
        {
                this.丏专丌万与上丆丈三 = this.GetComponent<WidgetLayout>();
        }
        
        if(this.丝三不丑丏丘丒丂丗 == 0)
        {
                this.丝三不丑丏丘丒丂丗 = this.GetComponent<UIGrid>();
        }
        
        if(this.丅业上丆丕上丝丄不 != 0)
        {
                return;
        }
        
        this.丅业上丆丕上丝丄不 = this.GetComponentInChildren<PositionHolder>(includeInactive:  true);
    }
    internal void 丄一且丄丑专丙丗世()
    {
        List.Enumerator<T> val_1 = this.丟丟且丄丑丝丑丒丅.GetEnumerator();
        label_7:
        if((2122508872 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        this.万上万丛丌丟丗上丂.Return(万且万且丑丗且丌丆:  val_2);
        val_2.transform.SetParent(p:  this.万上万丛丌丟丗上丂.transform);
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        this.丟丟且丄丑丝丑丒丅.Clear();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丗丅三丈丙丝上丞七 下丅丙一丂丗丅丝七)
    {
        PGCompany.丗丅三丈丙丝上丞七[] val_1 = new PGCompany.丗丅三丈丙丝上丞七[1];
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
        this.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_1);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.IEnumerable<PGCompany.丗丅三丈丙丝上丞七> 丝丛丟世丁与一万丞)
    {
        var val_4;
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_19;
        var val_20;
        var val_21;
        var val_22;
        this.丘上丐世丆丑且丞丒();
        this.丄一且丄丑专丙丗世();
        if(丝丛丟世丁与一万丞 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = PGCompany.万丞丘与丕丞下万丌.丄丆丛丙且丅丘七与(丝丛丟世丁与一万丞:  丝丛丟世丁与一万丞).GetEnumerator();
        val_20 = 1152921536474029712;
        val_21 = 1152921536794400480;
        label_12:
        if((2122972496 & 1) == 0)
        {
            goto label_5;
        }
        
        PGCompany.InventoryItemView val_6 = this.万上万丛丌丟丗上丂.Get<PGCompany.InventoryItemView>();
        this.丟丟且丄丑丝丑丒丅.Add(item:  val_6);
        val_6.Setup(与且专丈不万东一万:  val_4.丐丏七丌丕丗业且上());
        val_6.gameObject.SetActive(value:  true);
        if(this.丏专丌万与上丆丈三 == null)
        {
            goto label_12;
        }
        
        this.丏专丌万与上丆丈三.AddElement(丅丆东丏丙丝丅丆丟:  val_6);
        goto label_12;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.Reposition();
        }
        
        val_19 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  this.丝三不丑丏丘丒丂丗)) != false)
        {
                this.丝三不丑丏丘丒丂丗.repositionNow = true;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丅业上丆丕上丝丄不)) == false)
        {
                return;
        }
        
        val_20 = 1152921536558789920;
        this.丅业上丆丕上丝丄不.state = this.丟丟且丄丑丝丑丒丅.Count - 1;
        this.丅业上丆丕上丝丄不.CorrectLoadState();
        val_21 = 1152921505284374528;
        val_22 = 0;
        goto label_34;
        label_53:
        PGCompany.InventoryItemView val_12 = this.丟丟且丄丑丝丑丒丅.Item[0];
        if(val_22 < this.丅业上丆丕上丝丄不.obj.Length)
        {
                val_12.transform.SetParent(p:  this.丅业上丆丕上丝丄不.obj[0].transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丟丟且丄丑丝丑丒丅.Item[0].transform);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_12, 丏业丟一东丂东丘丛:  false);
        }
        
        val_22 = 1;
        label_34:
        val_19 = this.丟丟且丄丑丝丑丒丅;
        if(val_22 < val_19.Count)
        {
            goto label_53;
        }
    
    }
    internal void 业丏丗丐丂业东丂丗(PGCompany.丗丅三丈丙丝上丞七 下丅丙一丂丗丅丝七)
    {
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_13;
        var val_14;
        this.丘上丐世丆丑且丞丒();
        PGCompany.InventoryItemView val_1 = this.万上万丛丌丟丗上丂.Get<PGCompany.InventoryItemView>();
        this.丟丟且丄丑丝丑丒丅.Add(item:  val_1);
        if(val_1 != null)
        {
                val_1.Setup(与且专丈不万东一万:  下丅丙一丂丗丅丝七);
        }
        else
        {
                val_1.Setup(与且专丈不万东一万:  下丅丙一丂丗丅丝七);
        }
        
        val_1.gameObject.SetActive(value:  true);
        if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.AddElement(丅丆东丏丙丝丅丆丟:  val_1);
            if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.Reposition();
        }
        
        }
        
        val_13 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  this.丝三不丑丏丘丒丂丗)) != false)
        {
                this.丝三不丑丏丘丒丂丗.repositionNow = true;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丅业上丆丕上丝丄不)) == false)
        {
                return;
        }
        
        this.丅业上丆丕上丝丄不.state = this.丟丟且丄丑丝丑丒丅.Count - 1;
        this.丅业上丆丕上丝丄不.LoadState();
        val_14 = 0;
        goto label_19;
        label_32:
        this.丟丟且丄丑丝丑丒丅.Item[0].transform.SetParent(p:  this.丅业上丆丕上丝丄不.obj[0].transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丟丟且丄丑丝丑丒丅.Item[0].transform);
        val_14 = 1;
        label_19:
        val_13 = this.丟丟且丄丑丝丑丒丅;
        if(val_14 < val_13.Count)
        {
            goto label_32;
        }
    
    }
    internal System.Collections.Generic.List<PGCompany.InventoryItemView> 七三且丕丞丘丈七丑(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_1 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
        if(丈丄不七三万丄丁不 == null)
        {
                return val_1;
        }
        
        this = this.丟丟且丄丑丝丑丒丅;
        List.Enumerator<T> val_2 = this.GetEnumerator();
        label_10:
        if((2123676760 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if((val_3.ItemParams == null) || (val_3.ItemParams.业东丅东丌上丗丑不() != 丈丄不七三万丄丁不.业东丅东丌上丗丑不()))
        {
            goto label_10;
        }
        
        val_1.Add(item:  val_3);
        goto label_10;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal PGCompany.InventoryItemView 丐丞丂三丝丝上丌丈(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_4;
        var val_5;
        val_4 = this;
        ItemListUI.丞丆丌万丛不且七丐 val_1 = new ItemListUI.丞丆丌万丛不且七丐();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .丈丄不七三万丄丁不 = 丈丄不七三万丄丁不;
        if(丈丄不七三万丄丁不 == null)
        {
            goto label_2;
        }
        
        label_4:
        val_4 = this.丟丟且丄丑丝丑丒丅;
        PGCompany.InventoryItemView val_3 = System.Linq.Enumerable.FirstOrDefault<PGCompany.InventoryItemView>(source:  val_4, predicate:  new System.Func<PGCompany.InventoryItemView, System.Boolean>(object:  val_1, method:  System.Boolean ItemListUI.丞丆丌万丛不且七丐::专丘丅专且丐丈丟一(PGCompany.InventoryItemView 丁世丛业丟下丕三丟)));
        return (PGCompany.InventoryItemView)val_5;
        label_1:
        mem[16] = 丈丄不七三万丄丁不;
        if(mem[16] != 0)
        {
            goto label_4;
        }
        
        label_2:
        val_5 = 0;
        return (PGCompany.InventoryItemView)val_5;
    }
    internal float 丂丗丏丝丈丟丗丕万()
    {
        if(this.丏专丌万与上丆丈三 == 0)
        {
                return 0f;
        }
        
        if(this.丏专丌万与上丆丈三 != null)
        {
                return this.丏专丌万与上丆丈三.GetSize();
        }
        
        return this.丏专丌万与上丆丈三.GetSize();
    }
    public ItemListUI()
    {
        this.丟丟且丄丑丝丑丒丅 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
    }

}
