using UnityEngine;
internal sealed class MobAudioComponent : PGBehaviour
{
    // Fields
    private UnityEngine.AudioSource audioSource;
    private UnityEngine.AudioClip idleSound;
    private bool randomPauseInIdleSound;
    private float minTimePause;
    private float maxTimePause;
    private float 丅丗丒三东丅丁世东;
    private float 丕丑与且丙万不丛丆;
    private bool idleSoundIsStepSound;
    private UnityEngine.AudioClip stepSound;
    private UnityEngine.AudioClip attackSound;
    private UnityEngine.AudioClip takeDamageSound;
    private UnityEngine.AudioClip deathSound;
    private UnityEngine.AudioClip voiceSound;
    private bool 丟丈东与丝七丄一丗;
    private float 丄万丏不且丄七丙丝;
    
    // Methods
    private void Start()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.idleSound, y:  0);
        this.丟丈东与丝七丄一丗 = val_1;
        if(val_1 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丆丅丒丂丟丁丄丗丏());
    }
    private System.Collections.IEnumerator 丆丅丒丂丟丁丄丗丏()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MobAudioComponent.且丄丆丅丌万世丆万();
    }
    internal void 业下丄丆上七且且丑()
    {
        if(this.audioSource.clip == this.deathSound)
        {
                if(this.audioSource.isPlaying != false)
        {
                return;
        }
        
        }
        
        this.丁丑一下丆丏丆丛下(丆与丈丏丟七丁东丛:  this.attackSound);
    }
    internal void 丝三丁丏丑丆丙万上()
    {
        UnityEngine.Object val_6 = this.audioSource.clip;
        if(val_6 == this.deathSound)
        {
            goto label_4;
        }
        
        val_6 = this.audioSource.clip;
        if(val_6 != this.attackSound)
        {
            goto label_10;
        }
        
        label_4:
        if(this.audioSource.isPlaying != false)
        {
                return;
        }
        
        label_10:
        this.丁丑一下丆丏丆丛下(丆与丈丏丟七丁东丛:  this.takeDamageSound);
    }
    internal void 下丄丗丂丄丑丂丌丅()
    {
        this.丁丑一下丆丏丆丛下(丆与丈丏丟七丁东丛:  this.deathSound);
    }
    private bool 丆与丄世世丒业丛世()
    {
        UnityEngine.AudioSource val_13;
        var val_14;
        UnityEngine.Object val_15;
        val_13 = this;
        if(this.audioSource.clip != 0)
        {
            goto label_4;
        }
        
        label_22:
        val_14 = 1;
        goto label_10;
        label_4:
        val_15 = this.audioSource.clip;
        if(val_15 != this.deathSound)
        {
            goto label_9;
        }
        
        val_14 = 0;
        goto label_10;
        label_9:
        val_15 = this.audioSource.clip;
        if(val_15 == this.attackSound)
        {
            goto label_18;
        }
        
        val_15 = this.audioSource.clip;
        if(val_15 == this.stepSound)
        {
            goto label_18;
        }
        
        val_15 = this.audioSource.clip;
        if(val_15 != this.takeDamageSound)
        {
            goto label_22;
        }
        
        label_18:
        val_13 = this.audioSource;
        bool val_11 = val_13.isPlaying;
        val_14 = val_11 ^ 1;
        label_10:
        val_11 = val_14;
        return (bool)val_11;
    }
    private void 丙且三业下丄丛专丑()
    {
        if(this.randomPauseInIdleSound == false)
        {
            goto label_0;
        }
        
        float val_2 = this.丅丗丒三东丅丁世东;
        if(val_2 >= this.丕丑与且丙万不丛丆)
        {
            goto label_1;
        }
        
        val_2 = val_2 + this.丄万丏不且丄七丙丝;
        this.丅丗丒三东丅丁世东 = val_2;
        return;
        label_0:
        this.丁专丆东丂三与三与(丆与丈丏丟七丁东丛:  this.idleSound);
        return;
        label_1:
        this.丅丗丒三东丅丁世东 = 0f;
        this.丕丑与且丙万不丛丆 = UnityEngine.Random.Range(min:  this.minTimePause, max:  this.maxTimePause);
        this.丁丑一下丆丏丆丛下(丆与丈丏丟七丁东丛:  this.idleSound);
    }
    private void 丁丑一下丆丏丆丛下(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(丆与丈丏丟七丁东丛 == 0)
        {
                return;
        }
        
        this.audioSource.Stop();
        this.audioSource.loop = false;
        this.audioSource.clip = 丆与丈丏丟七丁东丛;
        this.audioSource.Play();
    }
    private void 丁专丆东丂三与三与(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
    {
        UnityEngine.Object val_5;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(丆与丈丏丟七丁东丛 == 0)
        {
                return;
        }
        
        val_5 = this.audioSource.clip;
        if(val_5 == 丆与丈丏丟七丁东丛)
        {
                return;
        }
        
        this.audioSource.loop = true;
        this.audioSource.clip = 丆与丈丏丟七丁东丛;
        this.audioSource.Play();
    }
    public void PlayVoiceSound()
    {
        this.丁丑一下丆丏丆丛下(丆与丈丏丟七丁东丛:  this.voiceSound);
    }
    public MobAudioComponent()
    {
        this.minTimePause = 1f;
        this.maxTimePause = 0f;
        this.丅丗丒三东丅丁世东 = 0.1f;
        this.丄万丏不且丄七丙丝 = 0.25f;
    }

}
