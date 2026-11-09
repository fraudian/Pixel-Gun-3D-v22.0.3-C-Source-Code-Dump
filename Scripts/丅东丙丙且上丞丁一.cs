using UnityEngine;
private sealed class 丑丂丆丘丞丛丟业丅.丅东丙丙且上丞丁一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.丟丟丈丙万丂上与不 丟且丅上丛丁丙丏丈;
    public PGCompany.丑丂丆丘丞丛丟业丅 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丑丂丆丘丞丛丟业丅.丅东丙丙且上丞丁一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丟且丅上丛丁丙丏丈 != null)
        {
                if(this.丟且丅上丛丁丙丏丈.丂丒丌不不丛丞丁一() == false)
        {
            goto label_2;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.万丏丛东下丝下丟丕();
        return false;
        label_2:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
