using UnityEngine;
private sealed class BaseBot.丛丏东丁丆丕专丙丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.BaseBot 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 丏丛东丙丝丅丏丟万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseBot.丛丏东丁丆丕专丙丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丏丛东丙丝丅丏丟万 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_16:
        UnityEngine.WaitForSeconds val_1 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        mem[1152921540965785752] = val_1;
        label_15:
        val_5 = 1;
        this.丒上七丌业七丟与丐 = val_1;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != 0)
        {
                if(this.丝且与丝丒丟万丁专.photonView != 0)
        {
            goto label_10;
        }
        
        }
        
        val_5 = 0;
        this.丝且与丝丒丟万丁专.丒丕丟丁丐不丕丑业 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
        label_10:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.<丄上丐丝东丘丅丙丈>k__BackingField = true;
            this.丝且与丝丒丟万丁专.health = 0f;
        }
        else
        {
                mem[424] = 1;
            mem[280] = 0;
        }
        
        this.丝且与丝丒丟万丁专.DestroyByNetworkType();
        if(this.丏丛东丙丝丅丏丟万 != null)
        {
            goto label_15;
        }
        
        goto label_16;
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
