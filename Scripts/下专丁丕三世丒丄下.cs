using UnityEngine;
private sealed class EventWinterButton.下专丁丕三世丒丄下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public EventWinterButton 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EventWinterButton.下专丁丕三世丒丄下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_9;
        int val_10;
        var val_11;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if((this.丝且与丝丒丟万丁专._badges == null) || ((this.丝且与丝丒丟万丁专.<与世丁丌丕丅丕丙业>k__BackingField) == null))
        {
            goto label_8;
        }
        
        EventWinterButton.丒丂万丒丂一上丞一 val_1 = new EventWinterButton.丒丂万丒丂一上丞一();
        if((this.丝且与丝丒丟万丁专.<与世丁丌丕丅丕丙业>k__BackingField.丄丌万丘与专丝业丗()) != false)
        {
                if((this.丝且与丝丒丟万丁专.<与世丁丌丕丅丕丙业>k__BackingField.七丝丝丈七三丝丘一()) != true)
        {
                if((this.丝且与丝丒丟万丁专.<与世丁丌丕丅丕丙业>k__BackingField.丒世业三丘丝不下丕()) == false)
        {
            goto label_14;
        }
        
        }
        
        }
        
        if(val_1 != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        .万丑丘丁丙不七丕丑 = false;
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  this.丝且与丝丒丟万丁专._badges, 七丐丅专且专七三丆:  new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void EventWinterButton.丒丂万丒丂一上丞一::世丞丅业丞万丌丄丂(UnityEngine.GameObject 丌丗丏丏丛东专丁且)));
        val_9 = this.三丛与七下专丅丕东;
        if(val_9 == null)
        {
                UnityEngine.WaitForSeconds val_6 = null;
            val_9 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.三丛与七下专丅丕东 = val_9;
        }
        
        val_10 = 1;
        goto label_19;
        label_8:
        val_9 = 0;
        val_10 = 2;
        label_19:
        val_11 = 1;
        this.丒上七丌业七丟与丐 = val_9;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_11;
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_14:
        var val_8 = ((this.丝且与丝丒丟万丁专.<与世丁丌丕丅丕丙业>k__BackingField.丟丂丞不专丆万丒世()) < 1) ? 1 : 0;
        if(val_1 != null)
        {
            goto label_23;
        }
        
        goto label_24;
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
