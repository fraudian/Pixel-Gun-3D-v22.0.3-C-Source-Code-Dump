using UnityEngine;
private sealed class ComponentToggler.丆丌东丐丈丘世丙丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ComponentToggler 丝且与丝丒丟万丁专;
    private int 丌丗世上丙业丟丙业;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ComponentToggler.丆丌东丐丈丘世丙丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_1 = this.丝且与丝丒丟万丁专.delyInFrames;
        this.丌丗世上丙业丟丙业 = val_1;
        goto label_3;
        label_0:
        val_1 = this.丌丗世上丙业丟丙业;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(val_1 > 0)
        {
                val_1 = val_1 - 1;
            val_2 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丌丗世上丙业丟丙业 = val_1;
            this.丗丏丅丕丆世丁专丟 = val_2;
            return (bool)val_2;
        }
        
        this.丝且与丝丒丟万丁专.Toggle();
        label_1:
        val_2 = 0;
        return (bool)val_2;
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
