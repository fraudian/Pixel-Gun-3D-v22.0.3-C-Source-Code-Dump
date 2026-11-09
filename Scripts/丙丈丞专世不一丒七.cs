using UnityEngine;
private sealed class 丅丂丌丗丈七业七丕.丙丈丞专世不一丒七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丌丈不丄丝七丕万专;
    private 丅丂丌丗丈七业七丕.业东下丕世丗丏万丏 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丂丌丗丈七业七丕.丙丈丞专世不一丒七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_20;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_16 = 106025212 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_16 = val_16 + 106025212;
        }
        else
        {
                val_20 = 0;
            return (bool);
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
