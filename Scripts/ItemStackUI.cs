using UnityEngine;
internal sealed class ItemStackUI : PGBehaviour
{
    // Fields
    private UILabel itemsCountLabel;
    private PGCompany.InventoryItemView itemView;
    private MiniPoolMonoBehaviour stackPool;
    private WidgetLayout stackLayout;
    internal int maxItemCount;
    internal bool showLast;
    private System.Collections.Generic.List<UIWidget> 一业丙丕上且一万万;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        int val_7;
        var val_8;
        WidgetLayout val_10;
        val_8 = this;
        this.世业丒万丘丆专丘丐();
        if(丈丄不七三万丄丁不 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemsCountLabel, 丕丗丘丑丛与丑业丒:  丈丄不七三万丄丁不.Count);
        if(this.showLast != false)
        {
                PGCompany.三东丏不丗世丅丌丄 val_2 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不);
        }
        
        this.itemView.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不));
        val_7 = 丈丄不七三万丄丁不.Count;
        int val_7 = UnityEngine.Mathf.Min(a:  val_7, b:  this.maxItemCount);
        if(val_7 > 0)
        {
                val_10 = this.stackLayout;
            do
        {
            val_7 = this.stackPool.Get<UIWidget>();
            this.一业丙丕上且一万万.Add(item:  val_7);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  true);
            mem[this.stackLayout].AddElement(世丌丌丙丞丟下东丞:  val_7);
            val_7 = val_7 - 1;
        }
        while(val_7 != 0);
        
        }
        else
        {
                val_10 = this.stackLayout;
        }
        
        val_8 = mem[this.stackLayout];
        val_8.Reposition();
    }
    private void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.stackPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.一业丙丕上且一万万.GetEnumerator();
        label_7:
        if(((-195674168) & 1) == 0)
        {
            goto label_5;
        }
        
        this.stackPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.一业丙丕上且一万万.Clear();
        this.stackLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    public ItemStackUI()
    {
        this.一业丙丕上且一万万 = new System.Collections.Generic.List<UIWidget>();
    }

}
