using UnityEngine;
private sealed class 万丘业丅丅丏丆东丈.上一丛丁三丗丟三丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.万丘业丅丅丏丆东丈 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 万丘业丅丅丏丆东丈.上一丛丁三丗丟三丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.IDictionary<System.String, System.Object> val_46;
        int val_48;
        val_46 = this;
        TValue val_31 = 0;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_51 = 106040432 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_51 = val_51 + 106040432;
        }
        else
        {
                val_48 = 0;
            return (bool)val_48;
        }
    
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
