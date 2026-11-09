using UnityEngine;
private sealed class 丒三丕三上丟与丈丆.不丛丞且一丏业世丟 : IEnumerator<object>, IEnumerator, IDisposable
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
    public 丒三丕三上丟与丈丆.不丛丞且一丏业世丟(int 丗丏丅丕丆世丁专丟)
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
        if(this.丝且与丝丒丟万丁专.丅三丂世专丟万丑上 == null)
        {
                return false;
        }
        
        this.丝且与丝丒丟万丁专.丅三丂世专丟万丑上.Invoke(sender:  this.不丟丗丏丛丕不丁丌, e:  this.丗丛不丁丑专专丂且);
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
