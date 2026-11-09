using UnityEngine;
[Serializable]
public class FastList<T>
{
    // Fields
    public T[] buffer;
    public int size;
    
    // Properties
    public T Item { get; set; }
    
    // Methods
    public System.Collections.Generic.IEnumerator<T> 世且一丄且上丄不一()
    {
        mem2[0] = this;
        return (System.Collections.Generic.IEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192;
    }
    public T get_Item(int 七丞丙丒三丕且丌丟)
    {
        var val_1 = X20 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
        return (object)(X20 + ((long)(int)(七丞丙丒三丕且丌丟)) << 3) + 32;
    }
    public void set_Item(int 七丞丙丒三丕且丌丟, T 丙业与丙丗丝不丈东)
    {
        var val_1 = X21 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
        mem2[0] = 丙业与丙丗丝不丈东;
    }
    private void 东丐与不丙专丁丗丗()
    {
        var val_2;
        if(X8 != 0)
        {
                val_2 = (X8 + 24) << 1;
        }
        
        var val_1 = (val_2 > 32) ? (val_2) : 32;
        if((val_2 != 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 16 + 294) >= 1))
        {
                val_2.CopyTo(array:  __RuntimeMethodHiddenParam + 24 + 192 + 16, index:  0);
        }
        
        mem[1152921535373332928] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
    }
    private void 丝丙丆三丑东丈且丙()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        if(W21 < 1)
        {
            goto label_0;
        }
        
        val_4 = this;
        if(W21 >= (X23 + 24))
        {
                return;
        }
        
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 16 + 294) < 1)
        {
            goto label_10;
        }
        
        do
        {
            val_5 = 0;
            var val_1 = X24 + 0;
            mem2[0] = (X24 + 0) + 32;
            val_3 = 0 + 1;
        }
        while(val_3 < (val_6 + 0));
        
        goto label_10;
        label_0:
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        val_4 = 1152921535373457216;
        label_10:
        mem[1152921535373457216] = val_6;
    }
    public void 世业丒万丘丆专丘丐()
    {
        mem[1152921535373577416] = 0;
    }
    public void 七世丗且丑丝丐专丛()
    {
        mem[1152921535373689416] = 0;
        mem[1152921535373689408] = 0;
    }
    public void 业丏丗丐丂业东丂丗(T 下丅丙一丂丗丅丝七)
    {
        if(X21 != 0)
        {
                if(W22 != (X21 + 24))
        {
            goto label_1;
        }
        
        }
        
        mem[1152921535373805512] = W22 + 1;
        if(X21 != 0)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        mem[1152921535373805512] = W22 + 1;
        label_3:
        var val_3 = X21 + (((long)(int)(W22)) << 3);
        mem2[0] = 下丅丙一丂丗丅丝七;
    }
    public void 丁丌丒七丐丂且下丞(int 丞世不丒下上上丝丑, T 下丅丙一丂丗丅丝七)
    {
        var val_6;
        var val_8;
        if(X8 == 0)
        {
            goto label_0;
        }
        
        val_6 = this;
        if(W25 != (X8 + 24))
        {
            goto label_1;
        }
        
        label_0:
        val_6 = this;
        label_1:
        if(W25 > 丞世不丒下上上丝丑)
        {
                var val_6 = (long)(long)(int)(W25);
            var val_1 = (X24 == 0) ? 1 : 0;
            do
        {
            val_8 = mem[X24 + 24];
            val_8 = X24 + 24;
            if((W25 - 1) >= val_8)
        {
                val_8 = mem[X24 + 24];
            val_8 = X24 + 24;
        }
        
            var val_3 = X24 + (((long)(int)(W25)) << 3);
            val_6 = val_6 - 1;
            mem2[0] = (X24 + ((long)(int)(W25)) << 3) + 24;
            var val_4 = (val_3 == 0) ? 1 : 0;
        }
        while(val_6 > (long)丞世不丒下上上丝丑);
        
            var val_5 = val_3 + (((long)(int)(丞世不丒下上上丝丑)) << 3);
            mem2[0] = 下丅丙一丂丗丅丝七;
            val_5 = val_5 + 1;
            mem[1152921535373925704] = val_5;
        }
    
    }
    public bool 丟不下下且业丛丄丏(T 下丅丙一丂丗丅丝七)
    {
        var val_3;
        var val_4;
        var val_5;
        if((X22 == 0) || (W8 < 1))
        {
            goto label_3;
        }
        
        val_3 = 0;
        goto label_2;
        label_8:
        val_3 = 1;
        if(val_3 >= W8)
        {
            goto label_3;
        }
        
        label_2:
        if(val_3 >= (X22 + 24))
        {
                val_4 = 0;
        }
        
        var val_1 = X22 + 8;
        if(val_3 >= (X22 + 24))
        {
                val_4 = 0;
        }
        
        if((((X22 + 8) + 32) & 1) == 0)
        {
            goto label_8;
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_3:
        val_5 = 0;
        return (bool)val_5;
    }
    public bool Remove(T 下丅丙一丂丗丅丝七)
    {
        if((X8 == 0) || ((__RuntimeMethodHiddenParam + 24 + 192 + 48) < 1))
        {
                return false;
        }
        
        var val_4 = 0;
        label_6:
        var val_1 = X22 + 0;
        var val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 48;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 48) & 1) != 0)
        {
            goto label_5;
        }
        
        val_4 = val_4 + 1;
        if(val_4 < val_5)
        {
            goto label_6;
        }
        
        return false;
        label_5:
        val_5 = val_5 - 1;
        mem[1152921535374166088] = val_5;
        typeof(System.Object).__il2cppRuntimeField_20 = 0;
        if(val_4 >= null)
        {
                return false;
        }
        
        do
        {
            var val_2 = val_4 + 1;
            object val_3 = 下丅丙一丂丗丅丝七 + (((long)(int)((0 + 1))) << 3);
            typeof(System.Object).__il2cppRuntimeField_20 = (long)val_2;
        }
        while(val_2 < null);
        
        return false;
    }
    public void 丄不丆丑丑丂丈丐丈(int 丞世不丒下上上丝丑)
    {
        var val_7;
        if(X21 == 0)
        {
                return;
        }
        
        if(W8 <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        mem[1152921535374282184] = W8 - 1;
        mem2[0] = 0;
        if((X21 + (((long)(int)(丞世不丒下上上丝丑)) << 3)) <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        do
        {
            val_7 = mem[X21 + 24];
            val_7 = X21 + 24;
            int val_3 = 丞世不丒下上上丝丑 + 1;
            if(val_3 >= val_7)
        {
                val_7 = mem[X21 + 24];
            val_7 = X21 + 24;
        }
        
            var val_4 = X21 + (((long)(int)((丞世不丒下上上丝丑 + 1))) << 3);
            mem2[0] = (X21 + ((long)(int)((丞世不丒下上上丝丑 + 1))) << 3) + 32;
        }
        while(val_3 < (X21 + (((long)(int)(丞世不丒下上上丝丑)) << 3)));
    
    }
    public T 丁丆丞丛上世专丟丕()
    {
        var val_5;
        var val_6;
        var val_7;
        if((X20 == 0) || (W8 == 0))
        {
            goto label_1;
        }
        
        val_6 = W8 - 1;
        mem[1152921535374394184] = val_6;
        if(val_6 >= (X20 + 24))
        {
            goto label_2;
        }
        
        var val_1 = X20 + (((long)(int)((W8 - 1))) << 3);
        val_7 = mem[(X20 + ((long)(int)((W8 - 1))) << 3) + 32];
        val_7 = (X20 + ((long)(int)((W8 - 1))) << 3) + 32;
        goto label_6;
        label_1:
        val_7 = 0;
        return (object)val_7;
        label_2:
        var val_2 = X20 + (((long)(int)((W8 - 1))) << 3);
        val_7 = mem[(X20 + ((long)(int)((W8 - 1))) << 3) + 32];
        val_7 = (X20 + ((long)(int)((W8 - 1))) << 3) + 32;
        if((X20 + 24) != 0)
        {
                val_5 = X20 + 24;
        }
        else
        {
                val_5 = 0;
        }
        
        label_6:
        var val_3 = val_5 + (((long)(int)((W8 - 1))) << 3);
        mem2[0] = 0;
        return (object)val_7;
    }
    public T[] 东与上丗与丏下丂丘()
    {
        if(this != null)
        {
                return (T[])this;
        }
        
        return (T[])this;
    }
    public void 万万丘丙丗丈丘丙丁(System.Comparison<T> 业丌丆丝东不丑上丗)
    {
        var val_7;
        var val_8;
        var val_8 = 1;
        label_15:
        val_7 = 0;
        if(val_8 >= W9)
        {
            goto label_0;
        }
        
        var val_2 = X22 + (((long)(int)((1 - 1))) << 3);
        var val_3 = X23 + 8;
        if(业丌丆丝东不丑上丗 >= 1)
        {
                var val_4 = ((X22 + ((long)(int)((1 - 1))) << 3) + 32) + 8;
            val_8 = mem[(X23 + 8) + 32 + 24];
            val_8 = (X23 + 8) + 32 + 24;
            if(((long)val_8 - 1) >= val_8)
        {
                val_8 = mem[(X23 + 8) + 32 + 24];
            val_8 = (X23 + 8) + 32 + 24;
        }
        
            var val_5 = ((X23 + 8) + 32) + (((long)(int)((1 - 1))) << 3);
            var val_6 = ((X23 + 8) + 32) + 8;
            mem2[0] = ((X23 + 8) + 32 + ((long)(int)((1 - 1))) << 3) + 32;
            var val_7 = ((X23 + 8) + 32) + (((long)(int)((1 - 1))) << 3);
            val_7 = 1;
            mem2[0] = ((X22 + ((long)(int)((1 - 1))) << 3) + 32 + 8) + 32;
        }
        
        val_8 = val_8 + 1;
        goto label_15;
        label_0:
        if((val_7 & 1) != 0)
        {
            goto label_15;
        }
    
    }
    public FastList<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }

}
