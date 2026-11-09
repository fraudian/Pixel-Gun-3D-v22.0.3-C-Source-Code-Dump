using UnityEngine;
private sealed class TryGuns_2_0_Controller.专三与丆一三丅不丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.TryGuns_2_0_Controller 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TryGuns_2_0_Controller.专三与丆一三丅不丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_5;
        int val_6;
        var val_7;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.不下丌丆东丑丈丕丝(丝七下丗丝丗丑三且:  false);
        UnityEngine.WaitForSecondsRealtime val_2 = null;
        val_5 = val_2;
        val_2 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
        val_6 = 2;
        goto label_3;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_4;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丝且与丝丒丟万丁专.且丁三一丘业丅不下(丝七下丗丝丗丑三且:  true));
        val_6 = 1;
        label_3:
        val_7 = 1;
        this.丒上七丌业七丟与丐 = val_5;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_7;
        label_4:
        val_7 = 0;
        return (bool)val_7;
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
