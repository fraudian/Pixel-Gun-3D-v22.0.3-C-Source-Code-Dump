using UnityEngine;
public abstract class 丟东丈下且丅丒丂专<K, V> : ISerializationCallbackReceiver
{
    // Fields
    private K[] keys;
    private V[] values;
    public System.Collections.Generic.Dictionary<K, V> 万丝且丘不丑丝下丑;
    
    // Methods
    public static T 丁三丘与丙丆丅下与<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        val_2 = __RuntimeMethodHiddenParam + 24;
        if((val_1 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192;
        return (object)__RuntimeMethodHiddenParam + 48;
    }
    public void OnAfterDeserialize()
    {
        var val_5;
        var val_6;
        val_5 = __RuntimeMethodHiddenParam + 24 + 192;
        mem[1152921526377225328] = val_5;
        if((X22 + 24) <= 0)
        {
            goto label_2;
        }
        
        val_6 = 0;
        goto label_3;
        label_9:
        val_6 = 1;
        label_3:
        var val_3 = (X22 + 24) + 8;
        var val_4 = X23 + 4;
        if((((X22 + 24) & 4294967295) - 1) != val_6)
        {
            goto label_9;
        }
        
        label_2:
        mem[1152921526377225312] = 0;
        mem[1152921526377225320] = 0;
    }
    public void OnBeforeSerialize()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_10;
        var val_11;
        var val_12;
        mem[1152921528572215792] = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        mem[1152921528572215800] = __RuntimeMethodHiddenParam + 24 + 192 + 48;
        if(!=0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_10:
        ConfiguredValueTaskAwaiter val_4 = val_3.GetAwaiter();
        var val_6 = X24 + 0;
        mem2[0] = val_4._value._obj.丐丏七丌丕丗业且上();
        var val_7 = X24 + 0;
        mem2[0] = ;
        label_5:
        if(((-1804447088) & 1) != 0)
        {
            goto label_10;
        }
        
        val_10 = 0;
        val_11 = 0;
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
        val_1 = val_2;
        val_2 = val_3;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_20:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8) + -8) == null)
        {
            goto label_19;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_19:
        val_12 = ((__RuntimeMethodHiddenParam + 24 + 192 + 96) + (((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8)) << 4)) + 296;
        label_21:
        val_3.Dispose();
        if( != 1)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    protected 丟东丈下且丅丒丂专<K, V>()
    {
        mem[1152921530767206288] = __RuntimeMethodHiddenParam + 24 + 192;
        if(this != null)
        {
                return;
        }
    
    }

}
