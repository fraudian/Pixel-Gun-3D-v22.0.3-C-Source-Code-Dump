using UnityEngine;
private sealed class FlyingPetEngine.<CheckIsMoving>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Rilisoft.FlyingPetEngine <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FlyingPetEngine.<CheckIsMoving>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        float val_8;
        float val_9;
        float val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this._unwaikableElapsedTime = 0f;
        var val_1 = ((this.<>4__this) == 0) ? 1 : 0;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_5;
        }
        
        val_6 = 0;
        label_4:
        if((this.<>4__this.丅业东丘丟丞世丙丘()) == false)
        {
            goto label_6;
        }
        
        label_10:
        this.<>4__this._unwaikableElapsedTime = 0f;
        goto label_14;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_6:
        val_8 = this.<>4__this._unwaikableElapsedTime;
        val_9 = this.<>4__this._unwaikableElapsedTime;
        val_10 = val_8 + UnityEngine.Time.deltaTime;
        this.<>4__this._unwaikableElapsedTime = val_10;
        goto label_9;
        label_5:
        if(0.丅业东丘丟丞世丙丘() == true)
        {
            goto label_10;
        }
        
        val_9 = 536;
        float val_5 = UnityEngine.Time.deltaTime;
        val_8 = val_5;
        val_5 = (4.386064E-43f) + val_8;
        mem[536] = val_5;
        val_10 = mem[536];
        val_6 = 1;
        label_9:
        if(val_10 >= 1f)
        {
                if((val_6 & 1) != 0)
        {
                mem[536] = 0;
            0.To(丘丏世丈业丛丞丘丒:  7);
        }
        else
        {
                mem[536] = 0;
            this.<>4__this.To(丘丏世丈业丛丞丘丒:  7);
        }
        
            if((this.<>4__this._checkIsMoving) != null)
        {
                this.<>4__this.StopCoroutine(routine:  this.<>4__this._checkIsMoving);
            this.<>4__this._checkIsMoving = 0;
        }
        
        }
        
        label_14:
        val_7 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_7;
        return (bool)val_7;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
