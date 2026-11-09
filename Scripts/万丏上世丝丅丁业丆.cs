using UnityEngine;
private sealed class HelicopterController.万丏上世丝丅丁业丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public HelicopterController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HelicopterController.万丏上世丝丅丁业丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioSource val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_0;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.engineAudioSource.isPlaying == false)
        {
            goto label_3;
        }
        
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_0:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        this.丝且与丝丒丟万丁专.engineAudioSource.Stop();
        this.丝且与丝丒丟万丁专.engineAudioSource.clip = this.丝且与丝丒丟万丁专.engineOn;
        this.丝且与丝丒丟万丁专.engineAudioSource.loop = true;
        val_2 = this.丝且与丝丒丟万丁专.engineAudioSource;
        val_2.Play();
        val_3 = 0;
        this.丝且与丝丒丟万丁专.世七丁与丘下丏丗丘 = 0;
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
