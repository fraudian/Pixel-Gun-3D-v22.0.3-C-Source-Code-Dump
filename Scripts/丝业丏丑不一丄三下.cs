using UnityEngine;
private sealed class 业丕丐万下丏丘下丕.丝业丏丑不一丄三下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.业丕丐万下丏丘下丕 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 业丕丐万下丏丘下丕.丝业丏丑不一丄三下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_0;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专 & 1) == 0)
        {
            goto label_2;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
                return (bool)val_1;
        }
        
        this.丝且与丝丒丟万丁专.Invoke();
        label_0:
        val_1 = 0;
        return (bool)val_1;
        label_2:
        val_1 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_1;
        return (bool)val_1;
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
