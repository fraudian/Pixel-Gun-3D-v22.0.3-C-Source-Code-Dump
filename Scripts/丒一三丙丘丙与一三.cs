using UnityEngine;
private sealed class BotHealth.丒一三丙丘丙与一三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 七且丆丞丌丘下世丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BotHealth.丒一三丙丘丙与一三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        bool val_4;
        var val_5;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        val_4 = true;
        BotHealth.专丛丁下丝下与万不 = val_4;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.七且丆丞丌丘下世丑);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = 1152921505140178944;
        val_5 = null;
        val_5 = null;
        val_4 = 0;
        BotHealth.专丛丁下丝下与万不 = false;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
