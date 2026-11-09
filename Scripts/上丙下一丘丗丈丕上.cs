using UnityEngine;
private sealed class 万丝丘且丁与丅丂丗.上丙下一丘丗丈丕上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Func<bool> 丞三丕世业三丒丅三;
    public System.Action 七丆丘上专丞上丟丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 万丝丘且丁与丅丂丗.上丙下一丘丗丈丕上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_3;
        System.Func<System.Boolean> val_4;
        int val_5;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_5;
        }
        
        val_4 = this.丞三丕世业三丒丅三;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_4 == null)
        {
            goto label_3;
        }
        
        if(this.七丆丘上专丞上丟丗 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_4 = this.丞三丕世业三丒丅三;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_4 == null)
        {
                val_4 = 0;
        }
        
        label_6:
        if(val_4.Invoke() != false)
        {
                val_5 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_5;
            return (bool)val_5;
        }
        
        val_3 = this.七丆丘上专丞上丟丗;
        val_3.Invoke();
        label_5:
        val_5 = 0;
        return (bool)val_5;
        label_3:
        System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "condition");
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
