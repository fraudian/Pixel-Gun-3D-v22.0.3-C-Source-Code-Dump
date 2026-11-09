using UnityEngine;
private sealed class 丅丆万丟丐丏丏下丄.丄丑不七与丅丌丛丟<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private T 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private System.Collections.Generic.IEnumerable<UnityEngine.GameObject> 丑东与丅丐丅丂丞业;
    public System.Collections.Generic.IEnumerable<UnityEngine.GameObject> 丆丙丌丝丝丌下不丐;
    private System.Collections.Generic.IEnumerator<UnityEngine.GameObject> 与业丕业业业丌丟丐;
    
    // Properties
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丆万丟丐丏丏下丄.丄丑不七与丅丌丛丟<T>(int 丗丏丅丕丆世丁专丟)
    {
        mem[1152921541537159648] = 丗丏丅丕丆世丁专丟;
        mem[1152921541537159664] = System.Environment.CurrentManagedThreadId;
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
        System.Collections.Generic.IEnumerator<T> val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(true == 0)
        {
            goto label_1;
        }
        
        if(true != 1)
        {
            goto label_34;
        }
        
        val_6 = 1152921541537383736;
        goto label_3;
        label_1:
        mem[1152921541537383696] = 0;
        var val_7 = mem[137175040];
        if((mem[137175040] + 286) == 0)
        {
            goto label_8;
        }
        
        var val_5 = mem[137175040] + 176;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_7:
        if(((mem[137175040] + 176 + 8) + -8) == null)
        {
            goto label_6;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (mem[137175040] + 286))
        {
            goto label_7;
        }
        
        goto label_8;
        label_6:
        val_7 = val_7 + (((mem[137175040] + 176 + 8)) << 4);
        val_7 = val_7 + 296;
        label_8:
        val_6 = this;
        mem[1152921541537383736] = GetEnumerator();
        label_3:
        mem[1152921541537383696] = -3;
        label_23:
        val_5 = mem[1152921541537383736];
        var val_10 = val_5;
        if((val_1 + 286) == 0)
        {
            goto label_13;
        }
        
        var val_8 = val_1 + 176;
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_12:
        if(((val_1 + 176 + 8) + -8) == null)
        {
            goto label_11;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (val_1 + 286))
        {
            goto label_12;
        }
        
        goto label_13;
        label_11:
        val_10 = val_10 + (((val_1 + 176 + 8)) << 4);
        val_8 = val_10 + 296;
        label_13:
        if(val_5.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_13 = mem[1152921541537383736];
        if((val_1 + 286) == 0)
        {
            goto label_19;
        }
        
        var val_11 = val_1 + 176;
        var val_12 = 0;
        val_11 = val_11 + 8;
        label_18:
        if(((val_1 + 176 + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_12 = val_12 + 1;
        val_11 = val_11 + 16;
        if(val_12 < (val_1 + 286))
        {
            goto label_18;
        }
        
        goto label_19;
        label_17:
        val_13 = val_13 + (((val_1 + 176 + 8)) << 4);
        val_9 = val_13 + 296;
        label_19:
        val_5 = mem[1152921541537383736].Current;
        if(val_5 == 0)
        {
            goto label_23;
        }
        
        val_10 = 1;
        mem[1152921541537383704] = val_5;
        mem[1152921541537383696] = val_10;
        return (bool)val_10;
        label_14:
        val_10 = 0;
        mem[1152921541537383736] = 0;
        return (bool)val_10;
        label_34:
        val_10 = 0;
        return (bool)val_10;
    }
    private void 一世丕丕业且且丅丌()
    {
        var val_2;
        mem[1152921541537499856] = 0;
        if(==0)
        {
                return;
        }
        
        var val_3 = mem[137175040];
        if((mem[137175040] + 286) == 0)
        {
            goto label_5;
        }
        
        var val_1 = mem[137175040] + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((mem[137175040] + 176 + 8) + -8) == null)
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (mem[137175040] + 286))
        {
            goto label_4;
        }
        
        goto label_5;
        label_3:
        val_3 = val_3 + (((mem[137175040] + 176 + 8)) << 4);
        val_2 = val_3 + 296;
        label_5:
        Dispose();
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
    private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
    {
        var val_2;
        if((W8 != 2) || (W21 != System.Environment.CurrentManagedThreadId))
        {
            goto label_1;
        }
        
        mem[1152921541537957088] = 0;
        val_2 = this;
        goto label_2;
        label_1:
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        if(val_2 == 0)
        {
            goto label_4;
        }
        
        label_2:
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        return (System.Collections.Generic.IEnumerator<T>)val_2;
        label_4:
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        if(this == null)
        {
            
        }
    
    }

}
