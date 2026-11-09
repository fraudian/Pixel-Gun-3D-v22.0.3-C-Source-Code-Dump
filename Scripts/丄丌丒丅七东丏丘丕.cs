using UnityEngine;
private sealed class AbstractGameEventView.丄丌丒丅七东丏丘丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.AbstractGameEventView 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AbstractGameEventView.丄丌丒丅七东丏丘丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.丛且世丐丆上七业丁 val_6;
        int val_7;
        var val_8;
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
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if((this.丝且与丝丒丟万丁专.<世丐丈丑不且丌丙下>k__BackingField) != null)
        {
            goto label_7;
        }
        
        goto label_9;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        val_6 = this.丝且与丝丒丟万丁专.<世丐丈丑不且丌丙下>k__BackingField;
        if(val_6 == null)
        {
            goto label_10;
        }
        
        label_7:
        if(this.丝且与丝丒丟万丁专._endTimerLabel != 0)
        {
                System.Nullable<System.TimeSpan> val_3 = this.丝且与丝丒丟万丁专.<世丐丈丑不且丌丙下>k__BackingField.丙世丑丅丒丑业与不();
            if(( & 1) != 0)
        {
                System.Nullable<System.TimeSpan> val_4 = this.丝且与丝丒丟万丁专.<世丐丈丑不且丌丙下>k__BackingField.丙世丑丅丒丑业与不();
            this.丝且与丝丒丟万丁专._endTimerLabel.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        }
        
        }
        
        val_6 = this.三丛与七下专丅丕东;
        val_7 = 2;
        goto label_20;
        label_3:
        val_8 = 0;
        return (bool)val_8;
        label_10:
        val_7 = 1;
        label_20:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_7;
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
