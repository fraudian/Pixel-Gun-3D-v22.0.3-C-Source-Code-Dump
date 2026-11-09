using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丈丟丈不丗丈丅丞丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丈丟丈不丗丈丅丞丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        val_5 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_5;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            .业丌一下丄三上下丄 = UnityEngine.Time.frameCount;
            val_6 = 1;
            val_5 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  new 丐丌丝七下丈丒丅丗.丞丘世丐丏丟业丕丒(), method:  System.Boolean 丐丌丝七下丈丒丅丗.丞丘世丐丏丟业丕丒::专丘丆丞一丑丘丝世()));
        }
        else
        {
                val_6 = 0;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_5;
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
