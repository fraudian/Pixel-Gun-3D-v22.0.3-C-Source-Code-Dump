using UnityEngine;
private sealed class LobbyEventStoreDelegate.不东丟业上丄且丄世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.LobbyEventStoreDelegate 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyEventStoreDelegate.不东丟业上丄且丄世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        UnityEngine.WaitForSeconds val_3;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        this.丝且与丝丒丟万丁专.丘丁丟业丁三丐丗丑();
        this.丝且与丝丒丟万丁专.丏丌不下丘丞丆七丞();
        goto label_3;
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        0.丘丁丟业丁三丐丗丑();
        0.丏丌不下丘丞丆七丞();
        label_3:
        val_3 = this.丝且与丝丒丟万丁专.专七丛丟丟丄丝上丛;
        if(val_3 == null)
        {
                UnityEngine.WaitForSeconds val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            this.丝且与丝丒丟万丁专.专七丛丟丟丄丝上丛 = val_3;
        }
        
        val_2 = 1;
        this.丒上七丌业七丟与丐 = val_3;
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
