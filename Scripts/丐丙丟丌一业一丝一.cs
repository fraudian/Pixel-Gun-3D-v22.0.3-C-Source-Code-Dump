using UnityEngine;
private sealed class GameEventDiceView.丐丙丟丌一业一丝一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventDiceView 丝且与丝丒丟万丁专;
    public System.Action 世丅丙世不三丈世丅;
    private float 丘丌丕一上丛下丙上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventDiceView.丐丙丟丌一业一丝一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        System.Action val_6;
        UnityEngine.Animator val_7;
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
        this.丝且与丝丒丟万丁专._animator.SetInteger(name:  "Value", value:  0);
        this.丝且与丝丒丟万丁专._animator.SetTrigger(name:  "Drop");
        GameEventsHalper val_1 = GameEventsHalper.Instance;
        this.丘丌丕一上丛下丙上 = val_1.animation.diceDelay_1;
        val_5 = val_1.animation.diceDelay_1;
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丁专专丞丘丘丙丟三 = 0;
        val_6 = this.世丅丙世不三丈世丅;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        val_6.Invoke();
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_5 = this.丘丌丕一上丛下丙上;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        if(val_5 > 0f)
        {
            goto label_13;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_14;
        }
        
        val_7 = this.丝且与丝丒丟万丁专._animator;
        goto label_15;
        label_13:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_5 - val_2;
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丘丌丕一上丛下丙上 = val_2;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_14:
        val_7 = 135970152;
        label_15:
        val_7.SetInteger(name:  "Value", value:  this.丝且与丝丒丟万丁专.<丅丝丌丝丁丏丙东丞>k__BackingField);
        GameEventsHalper val_3 = GameEventsHalper.Instance;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_3.animation.diceDelay_2);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
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
