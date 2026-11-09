using UnityEngine;
private sealed class CaseAnimationWrapper.业且与丒三与万东丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CaseAnimationWrapper 丝且与丝丒丟万丁专;
    public CaseAnimationWrapper.专丘万丙丝丌丗丞丛 丁丅丈丌丟世丗丗丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CaseAnimationWrapper.业且与丒三与万东丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.ParticleAccept.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.ParticleRise.SetActive(value:  false);
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丁丅丈丌丟世丗丗丟 == 0)
        {
            goto label_7;
        }
        
        if(this.丁丅丈丌丟世丗丗丟 != 2)
        {
            goto label_8;
        }
        
        val_2 = this.丝且与丝丒丟万丁专.ParticleRise;
        if(val_2 != null)
        {
            goto label_13;
        }
        
        goto label_11;
        label_7:
        val_2 = this.丝且与丝丒丟万丁专.ParticleAccept;
        if(val_2 != null)
        {
            goto label_13;
        }
        
        label_11:
        label_13:
        val_2.SetActive(value:  true);
        label_8:
        val_3 = 0;
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
