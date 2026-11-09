using UnityEngine;
private sealed class BPChallengesController.丆东丏七丅上业丅丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BPChallengesController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPChallengesController.丆东丏七丅上业丅丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        UnityEngine.WaitForSecondsRealtime val_3;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        this.丝且与丝丒丟万丁专.丌丙下丅七万丑丝丞(丐丕丙丛丐下丘不丙:  false);
        goto label_3;
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        0.丌丙下丅七万丑丝丞(丐丕丙丛丐下丘不丙:  false);
        label_3:
        val_3 = this.丝且与丝丒丟万丁专.世上三丘丒不上丆丝;
        if(val_3 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  30f);
            this.丝且与丝丒丟万丁专.世上三丘丒不上丆丝 = val_3;
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
