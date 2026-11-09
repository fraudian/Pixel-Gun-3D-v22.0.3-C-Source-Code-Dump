using UnityEngine;
private sealed class TouchPadInJoystick.万三业七丞丈丞丌丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TouchPadInJoystick 丝且与丝丒丟万丁专;
    private float 丁丈丏丁丁丛下东丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TouchPadInJoystick.万三业七丞丈丞丌丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丁丈丏丁丁丛下东丟 = UnityEngine.Time.realtimeSinceStartup;
        goto label_3;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_2 = val_2 - this.丁丈丏丁丁丛下东丟;
        if(val_2 >= 0)
        {
                val_3 = 0;
            this.丝且与丝丒丟万丁专.丟丈七丏三业丄业丌 = false;
            return (bool)val_3;
        }
        
        label_3:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
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
