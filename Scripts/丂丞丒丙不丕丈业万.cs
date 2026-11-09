using UnityEngine;
private sealed class ItemExpiryController.丂丞丒丙不丕丈业万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ItemExpiryController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ItemExpiryController.丂丞丒丙不丕丈业万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.ItemExpiryController val_5;
        System.Action val_6;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this.丝且与丝丒丟万丁专;
        if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.丐丅三丒丅上一丅专.Clear();
        if(this.丝且与丝丒丟万丁专.丙丗专万丒世一与下 != null)
        {
                val_5.StopCoroutine(routine:  this.丝且与丝丒丟万丁专.丙丗专万丒世一与下);
        }
        
        this.丝且与丝丒丟万丁专.丙丗专万丒世一与下 = 0;
        val_5.丘丒丘一丝丁丌丐上(丁丏丒丁下丌丗丐丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂<PGCompany.丌丐下丌丘下丝丞业>(丁丅丈丌丟世丗丗丟:  40, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}));
        val_6 = PGCompany.ItemExpiryController.丆丙丈丒丗下一丟世;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        val_6.Invoke();
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_4:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
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
