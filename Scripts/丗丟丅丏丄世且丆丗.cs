using UnityEngine;
private sealed class 丒且丌丑丆上一丘丆.丗丟丅丏丄世且丆丗<TKey> : IEnumerator<System.Collections.Generic.KeyValuePair<TKey, int>>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private System.Collections.Generic.KeyValuePair<TKey, int> 丒上七丌业七丟与丐;
    public PGCompany.丒且丌丑丆上一丘丆<TKey> 丝且与丝丒丟万丁专;
    private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, Rilisoft.丝丑丂丛万丐丈丘且>> 与业丕业业业丌丟丐;
    
    // Properties
    private System.Collections.Generic.KeyValuePair<TKey, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,System.Int32>>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒且丌丑丆上一丘丆.丗丟丅丏丄世且丆丗<TKey>(int 丗丏丅丕丆世丁专丟)
    {
        mem[1152921555918523872] = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(W8 != 1)
        {
                if(W8 != 3)
        {
                return;
        }
        
        }
    
    }
    private bool MoveNext()
    {
        var val_3;
        bool val_9;
        var val_10;
        var val_13;
        var val_15;
        if(true == 0)
        {
            goto label_1;
        }
        
        if(true != 1)
        {
            goto label_36;
        }
        
        val_10 = this;
        goto label_3;
        label_1:
        mem[1152921555918747888] = 0;
        bool val_8 = static_value_082CF010;
        var val_6 = static_value_082CF010 + 176;
        var val_7 = 0;
        val_6 = val_6 + 8;
        val_7 = val_7 + 1;
        val_6 = val_6 + 16;
        val_9 = static_value_082CF010;
        val_10 = this;
        mem[1152921555918747912] = val_9;
        label_3:
        mem[1152921555918747888] = -3;
        var val_11 = val_9;
        var val_9 = static_value_082CF010 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        val_13 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(val_9.MoveNext() != false)
        {
                var val_14 = mem[1152921555918747912];
            var val_12 = static_value_082CF010 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            val_13 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        }
        else
        {
                val_15 = 0;
            mem[1152921555918747912] = 0;
            return (bool)val_15;
        }
        
        val_9 = val_3.GetHashCode();
        DiscreteVector2 val_5 = new DiscreteVector2(三丟东丕丄丄下下丑:  val_9, 丒丒丄丁且丄丆丂丌:  -227718752);
        val_15 = 1;
        mem[1152921555918747888] = val_15;
        mem[1152921555918747892] = val_5._x;
        return (bool)val_15;
        label_36:
        val_15 = 0;
        return (bool)val_15;
    }
    private void 一世丕丕业且且丅丌()
    {
        var val_2;
        mem[1152921555918859920] = 0;
        if(==0)
        {
                return;
        }
        
        var val_3 = mem[137162752];
        if((mem[137162752] + 286) == 0)
        {
            goto label_5;
        }
        
        var val_1 = mem[137162752] + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((mem[137162752] + 176 + 8) + -8) == null)
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (mem[137162752] + 286))
        {
            goto label_4;
        }
        
        goto label_5;
        label_3:
        val_3 = val_3 + (((mem[137162752] + 176 + 8)) << 4);
        val_2 = val_3 + 296;
        label_5:
        Dispose();
    }
    private System.Collections.Generic.KeyValuePair<TKey, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,System.Int32>>.get_Current()
    {
        return (System.Collections.Generic.KeyValuePair<TKey, System.Int32>)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 294) & 1) != 0)
        {
                return -227261416;
        }
        
        return -227261416;
    }

}
