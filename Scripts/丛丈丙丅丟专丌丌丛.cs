using UnityEngine;
private sealed class GadgetAudioComponent.丛丈丙丅丟专丌丌丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GadgetAudioComponent 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GadgetAudioComponent.丛丈丙丅丟专丌丌丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioClip val_5;
        int val_6;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.soundActivate == 0)
        {
            goto label_7;
        }
        
        this.丝且与丝丒丟万丁专.audioSource.clip = this.丝且与丝丒丟万丁专.soundActivate;
        this.丝且与丝丒丟万丁专.audioSource.loop = false;
        this.丝且与丝丒丟万丁专.audioSource.Play();
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.soundActivate.length);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this.丝且与丝丒丟万丁专.soundOn;
        if(val_5 != 0)
        {
                this.丝且与丝丒丟万丁专.audioSource.Stop();
            this.丝且与丝丒丟万丁专.audioSource.clip = this.丝且与丝丒丟万丁专.soundOn;
            this.丝且与丝丒丟万丁专.audioSource.loop = true;
            val_5 = this.丝且与丝丒丟万丁专.audioSource;
            val_5.Play();
        }
        
        label_16:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
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
