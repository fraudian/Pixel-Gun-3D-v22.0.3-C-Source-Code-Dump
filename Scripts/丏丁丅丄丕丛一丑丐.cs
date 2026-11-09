using UnityEngine;
private sealed class ControlSizeController.丏丁丅丄丕丛一丑丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ControlSizeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ControlSizeController.丏丁丅丄丕丛一丑丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        var val_4;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = 0;
        goto label_6;
        label_14:
        ButtonJoystickAdjust val_1 = this.丝且与丝丒丟万丁专.丞丅业丕业专丒丈丛[0].GetComponent<ButtonJoystickAdjust>();
        if(val_1 != 0)
        {
                val_1.CheckForCollisionWithMap();
        }
        
        val_4 = 1;
        label_6:
        if(val_4 < this.丝且与丝丒丟万丁专.丞丅业丕业专丒丈丛.Length)
        {
            goto label_14;
        }
        
        val_3 = 0;
        this.丝且与丝丒丟万丁专.专业上下丘丟东上丁 = 0;
        return (bool)val_3;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.东丂丂丆下业丟丄丟();
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_3 = 1;
        return (bool)val_3;
        label_3:
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
