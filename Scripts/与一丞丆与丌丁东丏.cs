using UnityEngine;
private sealed class ConnectSceneRollBackMigrationBanner.与一丞丆与丌丁东丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丂三丟丂丈丐丆丗丟;
    public System.Action 丟丕丞丂一丙不丅丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectSceneRollBackMigrationBanner.与一丞丆与丌丁东丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丂三丟丂丈丐丆丗丟);
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
        label_1:
        val_2 = this.丟丕丞丂一丙不丅丝;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        val_2.Invoke();
        label_2:
        val_2 = 0;
        return (bool)val_2;
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
