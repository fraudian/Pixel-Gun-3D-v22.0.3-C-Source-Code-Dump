using UnityEngine;
private sealed class LevelCompleteScript.专且万丂丁丅丄丟三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LevelCompleteScript 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCompleteScript.专且万丂丁丅丄丟三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioClip val_7;
        var val_8;
        var val_9;
        float val_10;
        int val_11;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_19;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = null;
        val_8 = null;
        if(ExperienceController.sharedController == 0)
        {
            goto label_7;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = length;
        if(val_10 > 0f)
        {
            goto label_12;
        }
        
        label_24:
        val_7 = this.丝且与丝丒丟万丁专.awardClip;
        if(val_7 != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_7 = this.丝且与丝丒丟万丁专.awardClip;
            UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_7);
        }
        
        }
        
        label_19:
        val_11 = 0;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_7:
        val_10 = 0.5f;
        label_12:
        val_11 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_10);
        this.丗丏丅丕丆世丁专丟 = val_11;
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
