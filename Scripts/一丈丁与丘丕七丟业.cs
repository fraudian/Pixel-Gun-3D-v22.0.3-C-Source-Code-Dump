using UnityEngine;
private sealed class CenterOnChildAutomatic.一丈丁与丘丕七丟业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CenterOnChildAutomatic 丝且与丝丒丟万丁专;
    public float 三丟丆且丁丏丅丛万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CenterOnChildAutomatic.一丈丁与丘丕七丟业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        float val_6;
        float val_7;
        int val_8;
        float val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_5 = this.三丟丆且丁丏丅丛万;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.丝且与丝丒丟万丁专.丞不万丕丅丆不七丈;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        val_6 = this.丝且与丝丒丟万丁专;
        val_7 = this.丝且与丝丒丟万丁专.丞不万丕丅丆不七丈;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_7 - val_1;
        mem2[0] = val_1;
        goto label_6;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_5:
        val_6 = 92;
        float val_2 = UnityEngine.Time.deltaTime;
        val_7 = val_2;
        val_2 = 0f - val_7;
        mem[92] = val_2;
        label_6:
        val_5 = this.丝且与丝丒丟万丁专.scrollView;
        if(val_5 == 0)
        {
            goto label_12;
        }
        
        val_5 = this.丝且与丝丒丟万丁专.scrollView;
        if(val_5.isDragging == false)
        {
            goto label_12;
        }
        
        mem[92] = this.三丟丆且丁丏丅丛万;
        val_9 = this.三丟丆且丁丏丅丛万;
        goto label_13;
        label_12:
        val_9 = mem[92];
        label_13:
        if(val_9 > 0f)
        {
            goto label_14;
        }
        
        this.丝且与丝丒丟万丁专.专丏丞七丝丛下丌丗();
        val_5 = this.三丟丆且丁丏丅丛万;
        label_4:
        mem[92] = val_5;
        label_14:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
