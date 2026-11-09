using UnityEngine;
private sealed class StoreKitEventListener.丞丁丞丒丙丟且丑丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StoreKitEventListener.丞丁丞丒丙丟且丑丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.String[] val_10;
        int val_11;
        var val_12;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Waiting {0}s before requering inventory...", arg0:  10f));
        val_11 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  10f);
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Trying to repeat query inventory...", args:  System.Array.Empty<System.Object>()));
        val_12 = null;
        val_12 = null;
        val_10 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  StoreKitEventListener.丘世与丄一丐丝下丛, second:  StoreKitEventListener.业万专三一丟且丘业), second:  StoreKitEventListener.业丝丐三上丈丛丂专), second:  StoreKitEventListener.丒丕丗丑丕且丌丁丂), second:  StoreKitEventListener.丗丛丟丘下丙丞业丑));
        Prime31.GoogleIAB.queryInventory(skus:  val_10);
        label_2:
        val_11 = 0;
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
