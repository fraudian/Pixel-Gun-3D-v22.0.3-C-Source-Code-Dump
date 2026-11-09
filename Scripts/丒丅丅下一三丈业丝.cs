using UnityEngine;
private sealed class FastList.丒丅丅下一三丈业丝<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private T 丒上七丌业七丟与丐;
    public FastList<T> 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FastList.丒丅丅下一三丈业丝<T>(int 丗丏丅丕丆世丁专丟)
    {
        mem[1152921535374850368] = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        var val_5;
        if(W8 == 1)
        {
            goto label_0;
        }
        
        if(W8 != 0)
        {
            goto label_6;
        }
        
        mem[1152921535375074368] = 0;
        if((X20 + 16) == 0)
        {
            goto label_6;
        }
        
        val_3 = this;
        val_4 = 0;
        mem[1152921535375074392] = 0;
        goto label_5;
        label_0:
        val_3 = this;
        val_4 = W8 + 1;
        mem[1152921535375074368] = 0;
        mem[1152921535375074392] = val_4;
        label_5:
        if(val_4 < (X20 + 24))
        {
                val_3 = mem[1152921535375074392];
            var val_1 = (X20 + 16) + (((W8 + 1)) << 3);
            val_5 = 1;
            mem[1152921535375074368] = val_5;
            mem[1152921535375074376] = (X20 + 16 + ((W8 + 1)) << 3) + 32;
            return (bool)val_5;
        }
        
        label_6:
        val_5 = 0;
        return (bool)val_5;
    }
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        return (object)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
