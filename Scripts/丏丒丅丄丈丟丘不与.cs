using UnityEngine;
private sealed class 丒三丕三上丟与丈丆.丏丒丅丄丈丟丘不与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.丒三丕三上丟与丈丆 丝且与丝丒丟万丁专;
    public object 不丟丗丏丛丕不丁丌;
    public System.EventArgs 丗丛不丁丑专专丂且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒三丕三上丟与丈丆.丏丒丅丄丈丟丘不与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丂丝丟丅丄七丅丛丟 == null)
        {
                return false;
        }
        
        this.丝且与丝丒丟万丁专.丂丝丟丅丄七丅丛丟.Invoke(sender:  this.不丟丗丏丛丕不丁丌, e:  this.丗丛不丁丑专专丂且);
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
