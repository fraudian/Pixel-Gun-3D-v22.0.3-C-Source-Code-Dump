using UnityEngine;
private sealed class RankIndicatorGuiElement.业丕丈七丘丘东专上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.RankIndicatorGuiElement 丝且与丝丒丟万丁专;
    public bool 万不东上丄丞丕七万;
    public UnityEngine.AudioClip 东世丑世丛丞不专丕;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RankIndicatorGuiElement.业丕丈七丘丘东专上(int 丗丏丅丕丆世丁专丟)
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
            goto label_19;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.丈丌丝且业丏丈丂丁 = 0;
        goto label_5;
        label_1:
        int val_5 = this.丈丌丝且业丏丈丂丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = val_5 + 1;
        this.丈丌丝且业丏丈丂丁 = val_5;
        if(val_5 != 4)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        if(this.万不东上丄丞丕七万 == false)
        {
            goto label_7;
        }
        
        label_15:
        this.丝且与丝丒丟万丁专.东丝丕与丝丙下丙丏(丗丝丌丌业丗业丅丗:  false);
        goto label_8;
        label_5:
        this.丝且与丝丒丟万丁专._currentProgress.enabled = false;
        val_6 = 1;
        this.丗丏丅丕丆世丁专丟 = val_6;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = 1;
        this.丝且与丝丒丟万丁专._currentProgress.enabled = true;
        this.丗丏丅丕丆世丁专丟 = 2;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_6;
        label_6:
        if(this.万不东上丄丞丕七万 == true)
        {
            goto label_15;
        }
        
        label_7:
        this.丝且与丝丒丟万丁专.丂丄丏丐丗丕丞上丒(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丂丂下丑且下丌丝东());
        label_8:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_5 = this.东世丑世丛丞不专丕;
            UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_5);
        }
        
        label_19:
        val_6 = 0;
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
