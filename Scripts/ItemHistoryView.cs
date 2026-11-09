using UnityEngine;
internal sealed class ItemHistoryView : SimpleBunner
{
    // Fields
    protected bool revers;
    protected ItemListUI itemListUI;
    private string 丅专丂专丌世丒丙丈;
    private 丅七下丏与丙不丐下 丅世丘丗丅丙丗东丄;
    
    // Methods
    internal void 下与丞三丅丛丄七丕(丅七下丏与丙不丐下 丁丗与丁丟丕与世丝)
    {
        this.丅世丘丗丅丙丗东丄 = 丁丗与丁丟丕与世丝;
        goto typeof(ItemHistoryView).__il2cppRuntimeField_188;
    }
    public override void Show()
    {
        this.Show();
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.itemListUI.丄一且丄丑专丙丗世();
        if(this.丅世丘丗丅丙丗东丄 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  this.丅世丘丗丅丙丗东丄.丝上三丌丙七三七丏());
        if(this.revers != false)
        {
                val_2.Reverse();
        }
        
        this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_2);
    }
    public ItemHistoryView()
    {
    
    }

}
