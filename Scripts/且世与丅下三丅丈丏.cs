using UnityEngine;
private sealed class 一丟专且三万丞丁丂.且世与丅下三丅丈丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 一丟专且三万丞丁丂.且世与丅下三丅丈丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        System.Func<System.Boolean> val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        val_5 = 一丟专且三万丞丁丂.<>c.<>9__224_0;
        if(val_5 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  一丟专且三万丞丁丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一丟专且三万丞丁丂.<>c::丕丑与丘丝丘且七世());
            一丟专且三万丞丁丂.<>c.<>9__224_0 = val_5;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_1);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        Rilisoft.一丟专且三万丞丁丂.东丗业丘丞专一丟七();
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
