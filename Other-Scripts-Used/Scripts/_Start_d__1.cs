using UnityEngine;
private sealed class SkidTrail.<Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityStandardAssets.Vehicles.Car.SkidTrail <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkidTrail.<Start>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_7;
        int val_8;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        val_7 = this.<>4__this.transform.parent.parent;
        if(val_7 != 0)
        {
            goto label_9;
        }
        
        if((this.<>4__this) == null)
        {
            goto label_10;
        }
        
        val_7 = this.<>4__this.gameObject;
        goto label_11;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_10:
        val_7 = this.<>4__this.gameObject;
        label_11:
        UnityEngine.Object.Destroy(obj:  val_7, t:  this.<>4__this.m_PersistTime);
        label_9:
        val_8 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_8;
        return (bool)val_8;
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
