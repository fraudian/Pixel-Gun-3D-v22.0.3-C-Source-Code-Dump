using UnityEngine;
private sealed class VeteranChestBanner.丑不丟丅丕业且上丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VeteranChestBanner 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VeteranChestBanner.丑不丟丅丕业且上丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        VeteranChestBanner val_3;
        int val_4;
        val_3 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 == null)
        {
            goto label_3;
        }
        
        val_3.丗丄且丌下世上丈与(与丆丌丂丟丛丘丑且:  5);
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 != null)
        {
            goto label_9;
        }
        
        mem[456] = 0;
        goto label_6;
        label_3:
        0.丗丄且丌下世上丈与(与丆丌丂丟丛丘丑且:  5);
        label_4:
        if(this.丝且与丝丒丟万丁专._chestOpenTweener != 0)
        {
                val_4 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._chestOpenTweener, 丏业丟一东丂东丘丛:  true);
            UnityEngine.WaitForSeconds val_2 = null;
            val_3 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专._startSpinDelay);
            this.丒上七丌业七丟与丐 = val_3;
            this.丗丏丅丕丆世丁专丟 = val_4;
            return (bool)val_4;
        }
        
        label_9:
        this.丝且与丝丒丟万丁专.且丛丐与丞上丌不丒 = 0;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._progressBarObject, 丏业丟一东丂东丘丛:  false);
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
