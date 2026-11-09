using UnityEngine;
private sealed class TaskUIImposterModeTransgerData.丁一一丅丟业丂与丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TaskUIImposterModeTransgerData 丝且与丝丒丟万丁专;
    private int 丒丆且下丂东丑丝丙;
    private int 丅丌丁下且不七上世;
    private int 专世世丘丈万丂丌丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TaskUIImposterModeTransgerData.丁一一丅丟业丂与丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TaskUIImposterModeTransgerData val_13;
        float val_15;
        float val_17;
        UnityEngine.AudioSource val_18;
        int val_19;
        float val_20;
        double val_21;
        UISprite val_22;
        float val_23;
        val_13 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Random val_2 = new System.Random(Seed:  X21.丐丕不丅三专万丕丗());
        this.丒丆且下丂东丑丝丙 = val_2;
        if(val_2 == null)
        {
            goto label_6;
        }
        
        this.丅丌丁下且不七上世 = val_2;
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_13 != null)
        {
            goto label_12;
        }
        
        val_15 = 1.651491E-34f;
        if(val_15 >= 0)
        {
            goto label_9;
        }
        
        float val_3 = UnityEngine.Time.unscaledDeltaTime;
        val_3 = (1.651491E-34f) + val_3;
        mem[144] = val_3;
        val_15 = mem[144] / 0f;
        val_17 = 0f - mem[144];
        goto label_10;
        label_6:
        this.丅丌丁下且不七上世 = val_2;
        label_7:
        this.专世世丘丈万丂丌丈 = val_2;
        val_18 = this.丝且与丝丒丟万丁专.audioSource;
        if(val_18.isPlaying != true)
        {
                this.丝且与丝丒丟万丁专.audioSource.loop = true;
            this.丝且与丝丒丟万丁专.audioSource.clip = this.丝且与丝丒丟万丁专.fillingClip;
            val_18 = this.丝且与丝丒丟万丁专.audioSource;
            val_18.Play();
        }
        
        label_12:
        val_15 = this.丝且与丝丒丟万丁专.丄不丅东丑丝三丌丞;
        if(val_15 < 0)
        {
            goto label_16;
        }
        
        label_9:
        if(this.丝且与丝丒丟万丁专.audioSource.isPlaying != false)
        {
                this.丝且与丝丒丟万丁专.audioSource.loop = false;
            this.丝且与丝丒丟万丁专.audioSource.clip = 0;
            this.丝且与丝丒丟万丁专.audioSource.Stop();
        }
        
        mem2[0] = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.completeMessage, 丏业丟一东丂东丘丛:  true);
        val_13.万丏丛东下丝下丟丕();
        label_2:
        val_19 = 0;
        return (bool)val_19;
        label_16:
        float val_6 = UnityEngine.Time.unscaledDeltaTime;
        val_6 = val_15 + val_6;
        this.丝且与丝丒丟万丁专.丄不丅东丑丝三丌丞 = val_6;
        val_15 = val_6 / this.丝且与丝丒丟万丁专.barTime;
        val_17 = this.丝且与丝丒丟万丁专.barTime - val_6;
        label_10:
        val_20 = val_17 + 1f;
        this.丝且与丝丒丟万丁专.progressBar.fillAmount = val_15;
        val_21 = (double)val_15;
        if(val_21 >= 0)
        {
            goto label_26;
        }
        
        val_22 = this.丝且与丝丒丟万丁专.progressBar;
        val_20 = val_20 + (float)this.丒丆且下丂东丑丝丙;
        val_23 = 0.25f;
        goto label_32;
        label_26:
        if((val_21 < 0.15) || (val_21 >= 0))
        {
            goto label_30;
        }
        
        val_22 = this.丝且与丝丒丟万丁专.progressBar;
        val_20 = val_20 + (float)this.丅丌丁下且不七上世;
        val_23 = 0.5f;
        goto label_32;
        label_30:
        if((val_21 < 0.3) || (val_21 >= 0))
        {
            goto label_34;
        }
        
        val_22 = this.丝且与丝丒丟万丁专.progressBar;
        val_20 = val_20 + (float)this.专世世丘丈万丂丌丈;
        val_23 = 0.75f;
        label_32:
        val_21 = val_15 * val_23;
        val_22.fillAmount = val_21;
        label_34:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.timerLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10116")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10116")) + 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)val_20, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)val_20, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
        val_18 = this.丝且与丝丒丟万丁专.progressBar;
        val_13 = this.丝且与丝丒丟万丁专.percentLabel;
        float val_10 = val_18.fillAmount;
        val_10 = val_10 * 100f;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_13, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  (int)val_10));
        val_19 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
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
