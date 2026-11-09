using UnityEngine;
private sealed class CoroutineRunner.丛丘万丟丅丐丝万专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丏丏下丛丆丐丈三丏;
    public System.Action 七丐丅专且专七三丆;
    public float 七且丆丞丌丘下世丑;
    private float 万丟丆东一下丑丆丐;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoroutineRunner.丛丘万丟丅丐丝万专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.万丟丆东一下丑丆丐 = UnityEngine.Time.realtimeSinceStartup;
        this.丈丌丝且业丏丈丂丁 = 0;
        goto label_5;
        label_0:
        int val_4 = this.丈丌丝且业丏丈丂丁;
        int val_5 = this.丏丏下丛丆丐丈三丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = val_4 + 1;
        val_5 = val_4 - ((val_4 / val_5) * val_5);
        this.丈丌丝且业丏丈丂丁 = val_4;
        if((val_5 == 0) && (this.七丐丅专且专七三丆 != null))
        {
                this.七丐丅专且专七三丆.Invoke();
        }
        
        float val_3 = UnityEngine.Time.realtimeSinceStartup;
        val_3 = val_3 - this.万丟丆东一下丑丆丐;
        if(val_3 < 0)
        {
            goto label_5;
        }
        
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_5:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
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
