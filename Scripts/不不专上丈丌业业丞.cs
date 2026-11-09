using UnityEngine;
private sealed class FirstPersonControlSharp.不不专上丈丌业业丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FirstPersonControlSharp 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FirstPersonControlSharp.不不专上丈丌业业丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SkinName val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_7;
        }
        
        label_15:
        if(this.丝且与丝丒丟万丁专.cableCarMoving == false)
        {
            goto label_7;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业;
        if(this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业 != null)
        {
            goto label_10;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业;
        if(val_4 == null)
        {
            goto label_11;
        }
        
        label_10:
        this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.cableCarSlidingAudio);
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.cableCarSlidingAudio.length);
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_7:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_11:
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
