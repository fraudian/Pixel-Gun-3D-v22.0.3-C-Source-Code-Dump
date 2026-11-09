using UnityEngine;
internal sealed class ItemListFromInventoryUI : PGBehaviour
{
    // Fields
    private ItemListUI itemListUI;
    private System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> defautlItemIds;
    private bool resersList;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丞丈与且世七丐丞;
    
    // Methods
    private void OnEnable()
    {
        if((this.丕丞丈与且世七丐丞 == null) && (this.defautlItemIds != null))
        {
                if(this.defautlItemIds.Count >= 1)
        {
                this.丈且东丑丂且万丒丅(丞丂世丌世丅丗丁丂:  this.defautlItemIds);
        }
        
        }
        
        this.丝一丅丆三东丂丞七();
        Progress.丑丅专一业丙丝丄丁.丆丄世东东丝丝一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ItemListFromInventoryUI::且丄不丄不丕业三丘(string 丞丅上丏丂且下丅与)));
    }
    private void OnDisable()
    {
        Progress.丑丅专一业丙丝丄丁.丒一世与三东世不丒(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ItemListFromInventoryUI::且丄不丄不丕业三丘(string 丞丅上丏丂且下丅与)));
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> 丞丂世丌世丅丗丁丂)
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_2 = 丞丂世丌世丅丗丁丂.GetEnumerator();
        label_4:
        if((245993960 & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  0.丙东专丂世丈丏丁丂()));
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_1);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.IReadOnlyList<int> 丞丂世丌世丅丗丁丂)
    {
        var val_10;
        var val_11;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        var val_10 = 0;
        val_10 = val_10 + 1;
        System.Collections.Generic.IEnumerator<T> val_3 = 丞丂世丌世丅丗丁丂.GetEnumerator();
        label_18:
        var val_11 = 0;
        val_11 = val_11 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_1.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_3.Current));
        goto label_18;
        label_11:
        val_10 = 0;
        val_11 = 0;
        if(val_3 == null)
        {
            
        }
        else
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_3.Dispose();
        }
        
        this.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_1);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        this.丕丞丈与且世七丐丞 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不);
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_2;
        var val_3;
        ItemListUI val_11;
        System.Collections.Generic.IEnumerable<PGCompany.丗丅三丈丙丝上丞七> val_12;
        if(this.丕丞丈与且世七丐丞 == null)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = this.丕丞丈与且世七丐丞.GetEnumerator();
        label_5:
        if((246432480 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == null)
        {
            goto label_5;
        }
        
        val_2 = 0;
        val_3 = 0;
        PGCompany.三东丏不丗世丅丌丄 val_8 = val_4.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丞世不丒下上上丝丑:  val_4.业东丅东丌上丗丑不(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}));
        goto label_5;
        label_1:
        val_11 = this.itemListUI;
        val_11.丄一且丄丑专丙丗世();
        return;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.resersList != false)
        {
                System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  this.丕丞丈与且世七丐丞);
            val_9.Reverse();
            val_11 = this.itemListUI;
            val_12 = val_9;
        }
        else
        {
                val_11 = this.丕丞丈与且世七丐丞;
            val_12 = val_11;
        }
        
        this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_12);
    }
    private void 且丄不丄不丕业三丘(string 丞丅上丏丂且下丅与)
    {
        .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        this.丝一丅丆三东丂丞七();
        if((System.Linq.Enumerable.FirstOrDefault<PGCompany.InventoryItemView>(source:  this.itemListUI.丟丟且丄丑丝丑丒丅, predicate:  new System.Func<PGCompany.InventoryItemView, System.Boolean>(object:  new ItemListFromInventoryUI.下丌丛三下专丘丐丕(), method:  System.Boolean ItemListFromInventoryUI.下丌丛三下专丘丐丕::丆丙不丄丐丞丕丒丅(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)))) == null)
        {
                return;
        }
        
        if(val_3.simpleTweenePlayer == null)
        {
                return;
        }
        
        val_3.simpleTweenePlayer.Play();
    }
    public ItemListFromInventoryUI()
    {
        this.defautlItemIds = new System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈>();
    }

}
