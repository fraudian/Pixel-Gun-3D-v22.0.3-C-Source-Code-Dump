using UnityEngine;
private sealed class TrainingEnemy.上三丙业三且丝丈丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丘丁三丅丆与丆业业;
    public Rilisoft.TrainingEnemy 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TrainingEnemy.上三丙业三且丝丈丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.TrainingEnemy val_10;
        int val_11;
        UnityEngine.Animation val_12;
        val_10 = this.丝且与丝丒丟万丁专;
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
        if(this.丘丁三丅丆与丆业业 <= 0f)
        {
            goto label_4;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_10 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丘丁三丅丆与丆业业);
        val_11 = 1;
        this.丒上七丌业七丟与丐 = val_10;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_10 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_12 = this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世;
        if(val_12 == 0)
        {
            goto label_25;
        }
        
        if(this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟 != 0)
        {
                if(this.丝且与丝丒丟万丁专.wakeUpAudioClip != 0)
        {
                this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.wakeUpAudioClip);
        }
        
        }
        
        bool val_5 = this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世.Play(animation:  "Dummy_Up", mode:  0);
        label_7:
        val_12 = this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世;
        if(val_12.isPlaying != false)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_11 = 1;
            return (bool)val_11;
        }
        
        if(this.丝且与丝丒丟万丁专.DamageZone != 0)
        {
                this.丝且与丝丒丟万丁专.DamageZone.SetActive(value:  true);
        }
        
        label_25:
        this.丝且与丝丒丟万丁专.丗下丘世三七一专丕 = 1;
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  val_10.gameObject, 专丐丛丆与专世丆丂:  5);
        丘丛丞且一丅丁丏丐.丙丅丅丆丂一上业丐(不丂丅丁且丆东东丂:  val_10.丌丟丄业且三丛丕丄(), 丞下万上三丘上与专:  val_10);
        label_3:
        val_11 = 0;
        return (bool)val_11;
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
