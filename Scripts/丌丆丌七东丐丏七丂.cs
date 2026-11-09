using UnityEngine;
private sealed class 丂丘丗丗与且丌丁丙.丌丆丌七东丐丏七丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丂丘丗丗与且丌丁丙.丌丆丌七东丐丏七丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            丂丘丗丗与且丌丁丙.专且且丕丌下且丆丈();
            val_2 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
            this.丗丏丅丕丆世丁专丟 = val_2;
            return (bool)val_2;
        }
        
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
