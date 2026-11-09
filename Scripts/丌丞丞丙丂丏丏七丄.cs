using UnityEngine;
private sealed class ExpController.丌丞丞丙丂丏丏七丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丕丁下丌不万丅丞丛;
    public CategoryNames 七丆丒与丗丌丄且丂;
    public UnityEngine.GameObject 世丞丑上丅与世丁世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ExpController.丌丞丞丙丂丏丏七丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ShopNGUIController val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = null;
        val_12 = null;
        if((ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0) || (业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == true))
        {
            goto label_10;
        }
        
        val_13 = null;
        val_13 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丟丆世三七丏丐下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丕丁下丌不万丅丞丛, 七丆丒与丗丌丄且丂:  this.七丆丒与丗丌丄且丂));
        ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose = this.七丆丒与丗丌丄且丂;
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_19;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = null;
        val_16 = null;
        if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  UnityEngine.Application.loadedLevelName)) == false)
        {
            goto label_25;
        }
        
        val_17 = null;
        val_17 = null;
        FilterMaps val_9 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[UnityEngine.Application.loadedLevelName];
        goto label_29;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        ExpController.丏丂丛一与丄世上丒(世丞丑上丅与世丁世:  this.世丞丑上丅与世丁世);
        val_19 = null;
        val_19 = null;
        val_11 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_11.AdjustCategoryGridCells();
        label_10:
        val_20 = 0;
        return (bool)val_20;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_21 = null;
        val_21 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = 0;
        val_20 = 1;
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_20;
        label_25:
        val_22 = null;
        val_22 = null;
        label_29:
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  true, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
        label_19:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_20;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
