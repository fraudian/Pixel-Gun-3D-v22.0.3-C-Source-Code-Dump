using UnityEngine;
private sealed class 上丅丙丟不业不丆东.三上上万丒丗丑丘万 : IEnumerator<System.Collections.Generic.KeyValuePair<int, int>>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private System.Collections.Generic.KeyValuePair<int, int> 丒上七丌业七丟与丐;
    public PGCompany.上丅丙丟不业不丆东 丝且与丝丒丟万丁专;
    private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, Rilisoft.丝丑丂丛万丐丈丘且>> 与业丕业业业丌丟丐;
    
    // Properties
    private System.Collections.Generic.KeyValuePair<int, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 上丅丙丟不业不丆东.三上上万丒丗丑丘万(int 丗丏丅丕丆世丁专丟)
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
        var val_6;
        var val_10;
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, Rilisoft.丝丑丂丛万丐丈丘且>> val_11;
        var val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_35;
        }
        
        val_10 = this;
        val_11 = this.与业丕业业业丌丟丐;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = this.丝且与丝丒丟万丁专.万丒丌丞业丐丆丂三.GetEnumerator();
        val_10 = this;
        this.与业丕业业业丌丟丐 = val_11;
        label_3:
        this.丗丏丅丕丆世丁专丟 = -3;
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_11.MoveNext() == false)
        {
            goto label_15;
        }
        
        var val_15 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_20;
        }
        
        var val_13 = mem[val_2] + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_19:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_18;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (mem[val_2] + 286))
        {
            goto label_19;
        }
        
        goto label_20;
        label_15:
        this.一世丕丕业且且丅丌();
        val_15 = 0;
        this.与业丕业业业丌丟丐 = 0;
        return (bool)val_15;
        label_18:
        val_15 = val_15 + (((mem[val_2] + 176 + 8)) << 4);
        val_14 = val_15 + 296;
        label_20:
        T val_5 = this.与业丕业业业丌丟丐.Current;
        ConfiguredValueTaskAwaiter val_8 = val_6.GetAwaiter();
        ConfiguredValueTaskAwaiter val_9 = val_6.GetAwaiter();
        DiscreteVector2 val_10 = new DiscreteVector2(三丟东丕丄丄下下丑:  -232205184, 丒丒丄丁且丄丆丂丌:  -232205184);
        val_15 = 1;
        this.丗丏丅丕丆世丁专丟 = val_15;
        this.丒上七丌业七丟与丐 = val_10._x;
        return (bool)val_15;
        label_35:
        val_15 = 0;
        return (bool)val_15;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.与业丕业业业丌丟丐 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.与业丕业业业丌丟丐.Dispose();
    }
    private System.Collections.Generic.KeyValuePair<int, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>.get_Current()
    {
        return (System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>)this.丒上七丌业七丟与丐;
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
