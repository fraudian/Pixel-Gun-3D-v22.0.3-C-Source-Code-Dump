using UnityEngine;
private sealed class RewardParticlesSource.丝丞丕与上丐丟丐东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardParticlesSource 丝且与丝丒丟万丁专;
    private float 专丅专东丛丕丂上万;
    private int 丝丏业丘丟丙专丘丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardParticlesSource.丝丞丕与上丐丟丐东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        int val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.丂丌丄不丆丒丝丅万();
        this.专丅专东丛丕丂上万 = 0f;
        this.丝丏业丘丟丙专丘丞 = 0;
        goto label_4;
        label_1:
        val_5 = this;
        val_6 = this.丝丏业丘丟丙专丘丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_3:
        0.丂丌丄不丆丒丝丅万();
        this.专丅专东丛丕丂上万 = 0f;
        this.丝丏业丘丟丙专丘丞 = 0;
        label_4:
        this.丝且与丝丒丟万丁专.丏丌不丌与丘丆上业 = UnityEngine.Mathf.Min(a:  this.丝且与丝丒丟万丁专.丕丟丈丙丟丅丟丑七.丂丁丏一丙丛业且丌(), b:  this.丝且与丝丒丟万丁专.丒丄丅丟丞丅丄七丕.maxPacticlesCount);
        this.丝且与丝丒丟万丁专.世丁东业丆丙丌丝丆 = 0;
        if(RewardParticlesSource.丞下与业东东丏丒丆 != null)
        {
                RewardParticlesSource.丞下与业东东丏丒丆.Invoke(obj:  this.丝且与丝丒丟万丁专);
        }
        
        val_5 = this;
        val_6 = this.丝丏业丘丟丙专丘丞;
        label_6:
        if(val_6 < this.丝且与丝丒丟万丁专.丏丌不丌与丘丆上业)
        {
            goto label_12;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.下丟丏丘不丄丅丒七;
        if(val_6.Count <= 0)
        {
            goto label_14;
        }
        
        label_12:
        float val_4 = UnityEngine.Time.unscaledDeltaTime;
        val_4 = this.专丅专东丛丕丂上万 - val_4;
        this.专丅专东丛丕丂上万 = val_4;
        if(val_4 <= 0f)
        {
                val_7 = this.丝丏业丘丟丙专丘丞;
            if(val_7 < this.丝且与丝丒丟万丁专.丏丌不丌与丘丆上业)
        {
                val_6 = this.丝且与丝丒丟万丁专.丒丄丅丟丞丅丄七丕;
            if(val_6 == null)
        {
                val_7 = this.丝丏业丘丟丙专丘丞;
        }
        
            val_7 = val_7 + 1;
            this.专丅专东丛丕丂上万 = this.丝且与丝丒丟万丁专.丒丄丅丟丞丅丄七丕.emmitDelay;
            this.丝丏业丘丟丙专丘丞 = val_7;
            this.丝且与丝丒丟万丁专.丐丛上三丛丌七丐东();
        }
        
        }
        
        this.丝且与丝丒丟万丁专.上丕丄丞丅丝三丗丏();
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_14:
        val_8 = RewardParticlesSource.丌业不万业下丕丟七;
        if(val_8 == null)
        {
                return (bool)val_8;
        }
        
        val_8.Invoke(obj:  this.丝且与丝丒丟万丁专);
        label_2:
        val_8 = 0;
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
