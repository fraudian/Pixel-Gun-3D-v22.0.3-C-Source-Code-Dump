using UnityEngine;
private sealed class BalanceController.不上丏上不世丕上丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BalanceController.不上丏上不世丕上丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_6;
        var val_7;
        int val_8;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((AuthSceneController.一不丆丏与丐丏丈丄() == false) || (StoreKitEventListener.三丘丈不丝丕丞东丌() == true))
        {
            goto label_10;
        }
        
        val_6 = null;
        val_6 = null;
        if((StoreKitEventListener.丌丗丆丟丈丆丝丝丄 == true) || (PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世().丄丙丙丑丝专世上丌() == false))
        {
            goto label_10;
        }
        
        val_5 = 1152921505037303808;
        BalanceController.专一丞丌一丝丑丅丂();
        val_7 = null;
        val_7 = null;
        val_8 = 0;
        BalanceController.丂下丝丝丘业不七下 = 0;
        return (bool)val_8;
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_10:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
