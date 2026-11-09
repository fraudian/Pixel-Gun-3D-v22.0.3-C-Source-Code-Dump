using UnityEngine;
private sealed class AppsMenu.万不世丆丏丅丞丛业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public long 丝三丒丐七东与丐一;
    public long 丞丄丅上丏上专专丄;
    public string 专万丟三世业丙丈且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AppsMenu.万不世丆丏丅丞丛业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        double val_10;
        int val_11;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_12;
        }
        
        long val_9 = this.丝三丒丐七东与丐一;
        this.丗丏丅丕丆世丁专丟 = 0;
        long val_1 = val_9 - this.丞丄丅上丏上专专丄;
        val_9 = (this.丗丏丅丕丆世丁专丟 < 0) ? (-val_1) : (val_1);
        System.TimeSpan val_2 = System.TimeSpan.FromTicks(value:  val_9);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_9;
        }
        
        double val_4 = val_2._ticks.TotalMinutes;
        val_10 = 3;
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.专万丟三世业丙丈且);
        goto label_12;
        label_9:
        val_10 = 1;
        label_10:
        if(val_2._ticks.TotalDays >= 0)
        {
                val_9 = val_9.GetHashCode();
            System.Random val_7 = new System.Random(Seed:  val_9);
            val_11 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1.152922E+18f);
            this.丗丏丅丕丆世丁专丟 = val_11;
            return (bool)val_11;
        }
        
        label_12:
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
