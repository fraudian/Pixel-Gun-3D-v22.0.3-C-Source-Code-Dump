using UnityEngine;
private sealed class 丁丕下丗丝业丕丙丅.且下上丞丈万丞丛丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SimpleJSON.丁丕下丗丝业丕丙丅 丝且与丝丒丟万丁专;
    private System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON.且丐上一丝业不专上> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丁丕下丗丝业丕丙丅.且下上丞丈万丞丛丆(int 丗丏丅丕丆世丁专丟)
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
        var val_3;
        Dictionary.Enumerator<System.String, SimpleJSON.且丐上一丝业不专上> val_4;
        Dictionary.Enumerator<System.String, SimpleJSON.且丐上一丝业不专上> val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_17;
        }
        
        val_7 = this.与业丕业业业丌丟丐;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丝且与丝丒丟万丁专.下专丐业丑丞丈丛丙.GetEnumerator();
        val_7 = this.与业丕业业业丌丟丐;
        mem[1152921541563528712] = val_2;
        mem[1152921541563528696] = val_3;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_4;
        label_3:
        if((val_7 & 1) != 0)
        {
                ConfiguredValueTaskAwaiter val_5 = val_7.GetAwaiter();
            val_4 = val_5._value._obj;
            this.丒上七丌业七丟与丐 = val_4;
            val_8 = 1;
            this.丗丏丅丕丆世丁专丟 = val_8;
            return (bool)val_8;
        }
        
        this.一世丕丕业且且丅丌();
        val_8 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_8;
        label_17:
        val_8 = 0;
        return (bool)val_8;
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
