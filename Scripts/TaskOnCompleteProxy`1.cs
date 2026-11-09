using UnityEngine;
private class AndroidTaskUtils.TaskOnCompleteProxy<T> : AndroidJavaProxy
{
    // Fields
    private System.Action<T> mCallback;
    
    // Methods
    public AndroidTaskUtils.TaskOnCompleteProxy<T>(System.Action<T> callback)
    {
        mem[1152921541822007504] = callback;
    }
    public void onComplete(T result)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = this;
        if(result == null)
        {
            goto label_1;
        }
        
        if(result == null)
        {
            goto label_2;
        }
        
        val_4 = result;
        if(val_4 != null)
        {
            goto label_3;
        }
        
        label_2:
        val_4 = 0;
        label_3:
        if(val_4 == 0)
        {
            goto label_17;
        }
        
        var val_4 = 1179403647;
        if(mem[282584257676957] == 0)
        {
            goto label_9;
        }
        
        var val_2 = mem[282584257676847];
        var val_3 = 0;
        val_2 = val_2 + 8;
        label_8:
        if(((mem[282584257676847] + 8) + -8) == null)
        {
            goto label_7;
        }
        
        val_3 = val_3 + 1;
        val_2 = val_2 + 16;
        if(val_3 < mem[282584257676957])
        {
            goto label_8;
        }
        
        goto label_9;
        label_1:
        val_6 = 1152921541822127712;
        return;
        label_7:
        val_4 = val_4 + (((mem[282584257676847] + 8)) << 4);
        val_5 = val_4 + 296;
        label_9:
        val_4.Dispose();
        label_17:
        if(0 != 1)
        {
                return;
        }
    
    }

}
