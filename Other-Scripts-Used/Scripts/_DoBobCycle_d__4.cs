using UnityEngine;
private sealed class LerpControlledBob.<DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityStandardAssets.Utility.LerpControlledBob <>4__this;
    private float <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LerpControlledBob.<DoBobCycle>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        int val_15;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        val_9 = this;
        this.<t>5__2 = 0f;
        this.<>1__state = 0;
        val_10 = 0f;
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        goto label_5;
        label_1:
        val_9 = this;
        val_11 = this.<t>5__2;
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_6;
        }
        
        if(val_11 >= 0)
        {
            goto label_7;
        }
        
        val_12 = 1.401298E-45f;
        val_13 = this.<t>5__2;
        val_14 = 1.68059E-38f;
        goto label_8;
        label_2:
        val_9 = this;
        val_10 = this.<t>5__2;
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        label_5:
        label_9:
        if(val_10 < 0)
        {
            goto label_10;
        }
        
        this.<t>5__2 = 0f;
        val_11 = 0f;
        label_6:
        val_14 = this.<>4__this.BobDuration;
        if(val_11 < 0)
        {
            goto label_11;
        }
        
        label_7:
        val_15 = 0;
        this.<>4__this.m_Offset = 0f;
        return (bool)val_15;
        label_3:
        val_15 = 0;
        return (bool)val_15;
        label_10:
        this.<>4__this.m_Offset = UnityEngine.Mathf.Lerp(a:  0f, b:  this.<>4__this.BobAmount, t:  (this.<t>5__2) / (this.<>4__this.BobDuration));
        val_11 = this.<t>5__2;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_11 + val_3;
        this.<t>5__2 = val_3;
        val_15 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_15;
        return (bool)val_15;
        label_11:
        val_12 = this.<>4__this.BobAmount;
        val_13 = this.<t>5__2;
        label_8:
        this.<>4__this.m_Offset = UnityEngine.Mathf.Lerp(a:  val_12, b:  0f, t:  val_13 / val_14);
        val_11 = this.<t>5__2;
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = val_11 + val_7;
        this.<t>5__2 = val_7;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = 2;
        val_15 = 1;
        return (bool)val_15;
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
