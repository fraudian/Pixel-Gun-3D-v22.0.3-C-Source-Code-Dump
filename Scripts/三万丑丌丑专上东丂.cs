using UnityEngine;
private sealed class InfoWindowController.三万丑丌丑专上东丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InfoWindowController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InfoWindowController.三万丑丌丑专上东丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_7;
        int val_8;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_15;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  this.丝且与丝丒丟万丁专.丄上与丈一丐不丘丌);
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = InfoWindowController.丑七不且上丗丁一世();
        if(val_7 != 0)
        {
                InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
            val_7 = val_4._noStoreLogin;
            if(val_7 != 0)
        {
                InfoWindowController val_6 = InfoWindowController.丑七不且上丗丁一世();
            val_7 = val_6._noStoreLogin;
            val_7.SetActive(value:  false);
        }
        
        }
        
        label_15:
        val_8 = 0;
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
