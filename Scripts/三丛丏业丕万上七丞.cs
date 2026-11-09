using UnityEngine;
private sealed class SubscriptionBankViewItem.三丛丏业丕万上七丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Inapps.SubscriptionBankViewItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SubscriptionBankViewItem.三丛丏业丕万上七丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        var val_9;
        object val_10;
        int val_11;
        if(this.丗丏丅丕丆世丁专丟 > 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        long val_2 = FriendsController.丝丗专上三不丄丑丑();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        this.丝且与丝丒丟万丁专.与三一丁三不丌丛丞 = val_2;
        val_8 = UnityEngine.Time.realtimeSinceStartup;
        goto label_8;
        label_1:
        val_9 = 0;
        return (bool)val_9;
        label_4:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_7:
        mem[360] = val_2;
        val_8 = UnityEngine.Time.realtimeSinceStartup;
        label_8:
        this.丝且与丝丒丟万丁专.业丗世上万东丁丁丈 = val_8;
        label_11:
        if(this.丝且与丝丒丟万丁专.丕丗丛丅丆丏业丕丅 == null)
        {
            goto label_12;
        }
        
        PGCompany.丈万丟丟丗丞专专与 val_5 = PGCompany.丘丒丑万专一业丒专.丗丝丌丄丂丗丅世与(丙业丞丑七丗下丟丌:  this.丝且与丝丒丟万丁专.丕丗丛丅丆丏业丕丅);
        if(val_5 != this.丝且与丝丒丟万丁专.世丘丛万丙与丒业丌)
        {
            goto label_13;
        }
        
        if(val_5 != 4)
        {
            goto label_15;
        }
        
        this.丝且与丝丒丟万丁专.丂丐丂丐丛丈专丛不();
        goto label_15;
        label_12:
        val_10 = 0;
        val_11 = 2;
        goto label_16;
        label_13:
        this.丝且与丝丒丟万丁专.丝一丅丆三东丂丞七();
        label_15:
        this.丝且与丝丒丟万丁专.丕丁专上丐东丐丗丒();
        丕世专丒丁不丁丅丁 val_6 = null;
        val_10 = val_6;
        val_6 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  0.3f);
        val_11 = 1;
        label_16:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = val_10;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_9;
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
