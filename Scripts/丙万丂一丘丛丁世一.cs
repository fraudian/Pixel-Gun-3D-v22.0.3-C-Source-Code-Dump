using UnityEngine;
private sealed class AllSecretsHolder.丙万丂一丘丛丁世一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AllSecretsHolder 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AllSecretsHolder.丙万丂一丘丛丁世一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_7;
        int val_8;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        val_7 = this.丝且与丝丒丟万丁专.GetComponent<UnityEngine.AudioSource>();
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.丝且与丝丒丟万丁专.gameObject;
        val_6.SetActive(value:  false);
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_5:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_6:
        val_7 = 0.GetComponent<UnityEngine.AudioSource>();
        label_7:
        val_7.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.allSecretsSfx);
        label_12:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.waitTime);
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
