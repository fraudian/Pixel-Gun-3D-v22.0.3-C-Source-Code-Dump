using UnityEngine;
private sealed class ParticleSystemDestroyer.<Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityStandardAssets.Utility.ParticleSystemDestroyer <>4__this;
    private UnityEngine.ParticleSystem[] <systems>5__2;
    private float <stopTime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ParticleSystemDestroyer.<Start>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_11;
        var val_12;
        float val_13;
        int val_14;
        float val_15;
        var val_16;
        val_11 = this;
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
        
        this.<>1__state = 0;
        T[] val_1 = this.<>4__this.GetComponentsInChildren<UnityEngine.ParticleSystem>();
        this.<systems>5__2 = val_1;
        val_12 = 0;
        goto label_5;
        label_12:
        val_12 = 1;
        this.<>4__this.m_MaxLifetime = UnityEngine.Mathf.Max(a:  val_1[0].startLifetime, b:  this.<>4__this.m_MaxLifetime);
        label_5:
        if(val_12 < val_1.Length)
        {
            goto label_12;
        }
        
        if((this.<>4__this) == null)
        {
            goto label_13;
        }
        
        val_13 = this.<>4__this.minDuration;
        goto label_14;
        label_1:
        this.<>1__state = 0;
        val_11 = this.<>4__this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_11);
        label_3:
        val_14 = 0;
        return (bool)val_14;
        label_2:
        val_15 = this.<stopTime>5__3;
        this.<>1__state = 0;
        goto label_19;
        label_13:
        val_13 = 6.606506E-38f;
        label_14:
        float val_6 = UnityEngine.Random.Range(min:  val_13, max:  this.<>4__this.maxDuration);
        val_6 = UnityEngine.Time.time + val_6;
        val_15 = val_11;
        this.<stopTime>5__3 = val_6;
        label_19:
        if(UnityEngine.Time.time >= 0)
        {
                if((this.<>4__this.m_EarlyStop) == false)
        {
            goto label_22;
        }
        
        }
        
        val_14 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_22:
        UnityEngine.Debug.Log(message:  "stopping " + this.<>4__this.name(this.<>4__this.name));
        val_16 = 0;
        goto label_25;
        label_29:
        this.<systems>5__2[0].enableEmission = false;
        val_16 = 1;
        label_25:
        if(val_16 < (this.<systems>5__2.Length))
        {
            goto label_29;
        }
        
        if((this.<>4__this) != null)
        {
                this.<>4__this.BroadcastMessage(methodName:  "Extinguish", options:  1);
        }
        else
        {
                0.BroadcastMessage(methodName:  "Extinguish", options:  1);
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.m_MaxLifetime);
        this.<>1__state = 2;
        return (bool)val_14;
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
