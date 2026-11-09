using UnityEngine;
private sealed class GraffitiManager.丙丈丌不丝万丏丒七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GraffitiManager 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GraffitiManager.丙丈丌不丝万丏丒七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.<且七丌丐丐且丛三丐>k__BackingField = 0f;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_3:
        mem[104] = 0;
        label_4:
        this.丝且与丝丒丟万丁专.下丟业东三丙万不丙 = false;
        val_2 = null;
        val_2 = null;
        GraffitiManager.上丘七丟丑丅丆丕专.Invoke(obj:  false);
        label_6:
        if((this.丝且与丝丒丟万丁专.<且七丌丐丐且丛三丐>k__BackingField) <= 1f)
        {
            goto label_10;
        }
        
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_10:
        float val_1 = UnityEngine.Time.deltaTime;
        val_3 = 1;
        val_1 = val_1 / this.丝且与丝丒丟万丁专.下丏丒万丒丏丕丄丈;
        val_1 = (this.丝且与丝丒丟万丁专.<且七丌丐丐且丛三丐>k__BackingField) + val_1;
        this.丝且与丝丒丟万丁专.<且七丌丐丐且丛三丐>k__BackingField = val_1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
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
