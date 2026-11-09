using UnityEngine;
private sealed class BaseDummy.丏上不世业丞下丏丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BaseDummy 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseDummy.丏上不世业丞下丏丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Collider val_6;
        var val_7;
        UnityEngine.AudioSource val_8;
        UnityEngine.AudioClip val_9;
        var val_10;
        val_6 = this;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_6;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        val_7 = this.丝且与丝丒丟万丁专;
        val_8 = this.丝且与丝丒丟万丁专.丞下上且一上丙不丏;
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = 0;
        goto label_10;
        label_14:
        val_6 = this.丝且与丝丒丟万丁专.colliders[0];
        val_6.enabled = true;
        val_9 = 1;
        label_10:
        if(val_9 < this.丝且与丝丒丟万丁专.colliders.Length)
        {
            goto label_14;
        }
        
        label_3:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_16;
        label_6:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_17;
        }
        
        mem[40] = 0;
        mem[41] = 0;
        goto label_18;
        label_7:
        val_7 = 56;
        val_8 = 4194311;
        label_8:
        val_9 = this.丝且与丝丒丟万丁专.upSound;
        val_8.clip = val_9;
        val_7.Play();
        label_17:
        this.丝且与丝丒丟万丁专.丆且上丘世下丅且丞 = false;
        this.丝且与丝丒丟万丁专.丒丒与丆专丂丕丆丑 = false;
        label_18:
        if(this.丝且与丝丒丟万丁专.flyTarget == false)
        {
            goto label_21;
        }
        
        label_16:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_10 = 1;
        return (bool)val_10;
        label_21:
        bool val_2 = this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世.Play(animation:  "Dummy_Up", mode:  4);
        UnityEngine.WaitForSeconds val_5 = null;
        float val_6 = 0.55f;
        val_6 = (this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世.GetClip(name:  "Dummy_Up").length) * val_6;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  val_6);
        this.丒上七丌业七丟与丐 = val_5;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_10;
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
