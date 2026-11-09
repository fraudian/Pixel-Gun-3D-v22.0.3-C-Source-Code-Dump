using UnityEngine;
private sealed class TimerUI.丝丘丑一丁丂丕丐世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TimerUI 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TimerUI.丝丘丑一丁丂丕丐世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        System.Action val_7;
        UILabel val_8;
        Rilisoft.丝丑丂丛万丐丈丘且 val_9;
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
            goto label_22;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.世丆不下一专专丟丆;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = this.丝且与丝丒丟万丁专.上七与丂丟丄丂丙丈;
        if(val_7 == null)
        {
                return (bool)val_7;
        }
        
        val_7.Invoke();
        goto label_22;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = this.丝且与丝丒丟万丁专.世丆不下一专专丟丆 - 1;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        val_8 = this.丝且与丝丒丟万丁专._timerLabel;
        goto label_11;
        label_4:
        val_6 = 128;
        label_5:
        this.丝且与丝丒丟万丁专.上丛业丙丙七丒丝丁(丆丐七丅丆丗丛上与:  128);
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_12;
        }
        
        label_19:
        val_9 = this.丝且与丝丒丟万丁专.世丆不下一专专丟丆;
        if((val_9 & 2147483648) != 0)
        {
            goto label_20;
        }
        
        val_9 = val_9;
        goto label_14;
        label_10:
        val_8 = 0;
        label_11:
        System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)this.丝且与丝丒丟万丁专.世丆不下一专专丟丆);
        专七专下且专三一且.丏上丟万丆七东上丒(七丐丞丑丑丕世丙七:  val_8, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_3._ticks}, 丟丛丝丑专丏丐且不:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_19;
        }
        
        label_12:
        val_9 = this.丝且与丝丒丟万丁专.世丆不下一专专丟丆;
        if((val_9 & 2147483648) != 0)
        {
            goto label_20;
        }
        
        val_9 = val_9;
        label_14:
        this.丝且与丝丒丟万丁专.上丛业丙丙七丒丝丁(丆丐七丅丆丗丛上与:  val_9);
        val_7 = 1;
        this.丗丏丅丕丆世丁专丟 = val_7;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_7;
        label_20:
        if(this.丝且与丝丒丟万丁专.上七与丂丟丄丂丙丈 != null)
        {
                this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.丄下丛上丈丟丈专三);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_7 = 1;
            return (bool)val_7;
        }
        
        label_22:
        val_7 = 0;
        return (bool)val_7;
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
