using UnityEngine;
private sealed class EventHubView.东不东丏上业丐丟不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.EventHub.EventHubView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EventHubView.东不东丏上业丐丟不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        var val_2;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_1 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_1;
        return (bool)val_1;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_2 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.业丁七三丛上丕东丈(丄上丏丝丒丅丆且丄:  this.丝且与丝丒丟万丁专.业业丏丞丞丄东丒下);
        goto label_5;
        label_1:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_1 = 1;
        return (bool)val_1;
        label_2:
        val_1 = 0;
        return (bool)val_1;
        label_4:
        val_2 = 104;
        0.业丁七三丛上丕东丈(丄上丏丝丒丅丆且丄:  123372880);
        label_5:
        mem[104] = 0;
        val_1 = 0;
        return (bool)val_1;
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
