using UnityEngine;
private sealed class SabotageImposterModeController.丟丒丝丗丏丒东丂丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丂三丟丂丈丐丆丗丟;
    public EventDelegate 东丛三丌丂三且丝丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SabotageImposterModeController.丟丒丝丗丏丒东丂丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丂三丟丂丈丐丆丗丟);
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        val_3 = this.东丛三丌丂三且丝丂;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 == null)
        {
                return (bool)val_3;
        }
        
        bool val_2 = val_3.丞丙东丌一三专丏不();
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
