using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丟丛不丗万丂与丈丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丟丛不丗万丂与丈丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ArmoryInfoScreenController val_14;
        var val_15;
        var val_16;
        FilterMaps val_17;
        var val_18;
        var val_19;
        val_14 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return false;
        }
        
        val_16 = null;
        val_16 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
            goto label_12;
        }
        
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐();
        goto label_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        WeaponManager.丒不丄丐丏丑世丟东();
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return false;
        }
        
        val_14 = ShopNGUIController.丛丐丛专丟丞万三七();
        val_18 = null;
        val_18 = null;
        if(val_14 == WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐())
        {
                return false;
        }
        
        val_19 = null;
        val_19 = null;
        WeaponManager.丟丗丄业丘丗业丗七.下东与丌丁丝丁丘专(专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        val_14 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_14 == 0)
        {
                return false;
        }
        
        val_14 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_14.丞丏世丆丄上丆一七();
        return false;
        label_12:
        val_17 = 0.丟三上丁丗一丅丝丐();
        label_13:
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  WeaponManager.丟丗丄业丘丗业丗七.业丂下丒丙且世不丝(万业丒丙丂丝丗不丈:  true, 专丆丌丛东一不丑丙:  val_17));
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
