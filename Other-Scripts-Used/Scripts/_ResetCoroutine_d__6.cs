using UnityEngine;
private sealed class ObjectResetter.<ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public UnityStandardAssets.Utility.ObjectResetter <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ObjectResetter.<ResetCoroutine>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityStandardAssets.Utility.ObjectResetter val_9;
        float val_10;
        int val_11;
        var val_12;
        var val_13;
        float val_14;
        val_9 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_10 = this.delay;
        this.<>1__state = 0;
        if(val_10 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  val_10);
        val_11 = 1;
        this.<>2__current = val_9;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        label_3:
        val_12 = 0;
        goto label_6;
        label_13:
        T val_9 = val_9.GetComponentsInChildren<UnityEngine.Transform>()[0];
        if((this.<>4__this.originalStructure.Contains(item:  val_9)) != true)
        {
                val_9.parent = 0;
        }
        
        val_12 = 1;
        label_6:
        if(val_12 < val_2.Length)
        {
            goto label_13;
        }
        
        if(val_9 != null)
        {
                val_13 = val_9.transform;
        }
        else
        {
                val_13 = val_9.transform;
        }
        
        val_13.position = new UnityEngine.Vector3() {x = this.<>4__this.originalPosition, y = V9.16B, z = V10.16B};
        val_10 = this.<>4__this.originalRotation;
        val_13.rotation = new UnityEngine.Quaternion() {x = val_10, y = V9.16B, z = V10.16B, w = V11.16B};
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.Rigidbody)) != false)
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.<>4__this.Rigidbody.velocity = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_10 = val_8.x;
            val_14 = val_8.z;
            this.<>4__this.Rigidbody.angularVelocity = new UnityEngine.Vector3() {x = val_10, y = val_8.y, z = val_14};
        }
        
        val_9.SendMessage(methodName:  "Reset");
        label_2:
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
