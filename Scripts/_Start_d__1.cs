using UnityEngine;
private sealed class InAppInstancer.<Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InAppInstancer <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InAppInstancer.<Start>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        int val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_21;
        }
        
        this.<>1__state = 0;
        val_10 = null;
        val_10 = null;
        if(StoreKitEventListener.丆丕丝丒不丙且丐丗 != 0)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.inAppGameObjectPrefab, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        val_11 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        label_7:
        if((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11) || (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1))
        {
            goto label_19;
        }
        
        if((this.<>4__this._amazonGamecircleManagerInitialized) == true)
        {
            goto label_21;
        }
        
        UnityEngine.Coroutine val_8 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.InitializeAmazonGamecircleManager());
        val_11 = 0;
        this.<>4__this._amazonGamecircleManagerInitialized = true;
        return (bool)val_11;
        label_19:
        UnityEngine.RuntimePlatform val_9 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
        label_21:
        val_11 = 0;
        return (bool)val_11;
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
