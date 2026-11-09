using UnityEngine;
private sealed class Portal.且与丗专丗业丛万万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Portal 丝且与丝丒丟万丁专;
    public bool 丌丏一一业丗丐丑不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Portal.且与丗专丗业丛万万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
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
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        this.丝且与丝丒丟万丁专.七丈与丌下世丒丅专 = this.丌丏一一业丗丐丑不;
        goto label_3;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_5;
        label_2:
        mem[184] = this.丌丏一一业丗丐丑不;
        label_3:
        this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 = 0f;
        label_5:
        if(this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 <= 1f)
        {
            goto label_6;
        }
        
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_6:
        float val_1 = UnityEngine.Time.deltaTime;
        val_2 = 1;
        val_1 = val_1 / this.丝且与丝丒丟万丁专.deactivationTimer;
        val_1 = this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 + val_1;
        this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 = val_1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_2;
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
