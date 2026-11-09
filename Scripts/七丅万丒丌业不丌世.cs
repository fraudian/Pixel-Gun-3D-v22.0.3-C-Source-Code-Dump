using UnityEngine;
private sealed class 丂丐丏七丅丝业丅专.七丅万丒丌业不丌世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SimpleJSON.丂丐丏七丅丝业丅专 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<SimpleJSON.且丐上一丝业不专上> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丂丐丏七丅丝业丅专.七丅万丒丌业不丌世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_2;
        List.Enumerator<SimpleJSON.且丐上一丝业不专上> val_3;
        List.Enumerator<SimpleJSON.且丐上一丝业不专上> val_6;
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_16;
        }
        
        val_6 = this.与业丕业业业丌丟丐;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        List.Enumerator<T> val_1 = this.丝且与丝丒丟万丁专.丏丕丗丒丒丛一丕丟.GetEnumerator();
        val_6 = this.与业丕业业业丌丟丐;
        mem[1152921541559167768] = val_2;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_3;
        label_3:
        if((val_6 & 1) != 0)
        {
                this.丒上七丌业七丟与丐 = val_6.丐丏七丌丕丗业且上();
            val_7 = 1;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        this.一世丕丕业且且丅丌();
        val_7 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_7;
        label_16:
        val_7 = 0;
        return (bool)val_7;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
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
