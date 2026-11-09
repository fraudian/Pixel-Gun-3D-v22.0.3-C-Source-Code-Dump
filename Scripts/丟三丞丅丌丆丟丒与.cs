using UnityEngine;
private sealed class ExpController.丟三丞丅丌丆丟丒与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.GameObject 世丞丑上丅与世丁世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ExpController.丟三丞丅丌丆丟丒与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_6;
        var val_7;
        FilterMaps val_8;
        var val_9;
        var val_10;
        int val_11;
        var val_12;
        val_6 = this;
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
        val_7 = null;
        val_7 = null;
        val_8 = 1152921504848912384;
        if((ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0) || (业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == true))
        {
            goto label_10;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_10 = null;
            val_10 = null;
            val_8 = ExpController.丕丟丛丈丄丆世丑与();
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  true, 专丆丌丛东一不丑丙:  val_8);
        }
        
        val_11 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.世丞丑上丅与世丁世;
        ExpController.丏丂丛一与丄世上丒(世丞丑上丅与世丁世:  val_6);
        label_10:
        val_11 = 0;
        return (bool)val_11;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = null;
        val_12 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = 0;
        val_11 = 1;
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_11;
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
