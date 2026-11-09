using UnityEngine;
private sealed class SynchNetworkAnimation.丕丈专丗丆丝一丛丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SynchNetworkAnimation 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SynchNetworkAnimation.丕丈专丗丆丝一丛丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  10f);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        float val_4 = this.丝且与丝丒丟万丁专.丐丐七专三且世三七.clip.length;
        float val_7 = (float)丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_7 = val_7 / this.丝且与丝丒丟万丁专.丐丐七专三且世三七.clip.length;
        this.丝且与丝丒丟万丁专.上万丗丕丝丂丒下三.normalizedTime = val_7;
        val_7 = 1;
        this.丗丏丅丕丆世丁专丟 = val_7;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
