using UnityEngine;
private sealed class TrainingEnemy.丕丂丟丂东丟丒丅丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.TrainingEnemy 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TrainingEnemy.丕丂丟丂东丟丒丅丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ZombieCreator val_11;
        int val_12;
        UnityEngine.AudioClip val_13;
        var val_14;
        var val_15;
        var val_16;
        val_11 = this;
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
            goto label_30;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世 != 0)
        {
            goto label_11;
        }
        
        goto label_24;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_11:
        if((this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世.IsPlaying(name:  "Dummy_Damage")) != false)
        {
                val_12 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_12;
            return (bool)val_12;
        }
        
        val_13 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟 != 0)
        {
                if(this.丝且与丝丒丟万丁专.dieAudioClip != 0)
        {
                val_13 = this.丝且与丝丒丟万丁专.dieAudioClip;
            this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟.PlayOneShot(clip:  val_13);
        }
        
        }
        
        bool val_5 = this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世.Play(animation:  "Dead", mode:  0);
        label_10:
        if(this.丝且与丝丒丟万丁专.业与丘丞丂专丘丗世.isPlaying != false)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_12 = 1;
            return (bool)val_12;
        }
        
        label_24:
        val_14 = null;
        val_14 = null;
        val_11 = ZombieCreator.丞丈丟丒丂丞丏不丑;
        if(val_11 != 0)
        {
                val_15 = null;
            val_15 = null;
            val_11 = ZombieCreator.丞丈丟丒丂丞丏不丑;
            if(val_11 != null)
        {
                val_16 = val_11.丌丟且丛丄丒万丈丑();
        }
        else
        {
                val_16 = 0.丌丟且丛丄丒万丈丑();
        }
        
            val_11.丂丟丑丂丁丝下与丒(丙业与丙丗丝不丈东:  val_16 + 1);
        }
        
        label_30:
        val_12 = 0;
        return (bool)val_12;
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
