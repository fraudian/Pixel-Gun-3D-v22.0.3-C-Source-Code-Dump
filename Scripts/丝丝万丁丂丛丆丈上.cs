using UnityEngine;
private sealed class WindowAnimator.丝丝万丁丂丛丆丈上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.WindowAnimator 丝且与丝丒丟万丁专;
    public bool 丅万且万丄丁七专丅;
    private float 丌三丘丙丘丕丐丛丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WindowAnimator.丝丝万丁丂丛丆丈上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_24;
        UnityEngine.AnimationCurve val_25;
        UnityEngine.AnimationCurve val_27;
        float val_28;
        float val_29;
        int val_30;
        var val_31;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.丝且与丝丒丟万丁专._scaleCurve.Evaluate(time:  (this.丅万且万丄丁七专丅 == true) ? 0f : 1f));
        this.丝且与丝丒丟万丁专.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        val_24 = this;
        this.丌三丘丙丘丕丐丛丆 = 0f;
        val_25 = this.丝且与丝丒丟万丁专._scaleCurve;
        goto label_11;
        label_1:
        val_24 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = this.丝且与丝丒丟万丁专._scaleCurve;
        if(this.丌三丘丙丘丕丐丛丆 > 1f)
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_27.Evaluate(time:  (((this.丅万且万丄丁七专丅 == true) ? 1 : 0) != 0) ? 1f : 0f));
            val_28 = val_14.x;
            val_29 = val_14.z;
            this.丝且与丝丒丟万丁专.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_28, y = val_14.y, z = val_29};
            val_30 = 0;
            this.丝且与丝丒丟万丁专.万专上丆丗一丅丟丆 = 0;
            return (bool)val_30;
        }
        
        label_11:
        val_31 = this.丝且与丝丒丟万丁专.gameObject.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  val_25.Evaluate(time:  (((this.丅万且万丄丁七专丅 == true) ? 1 : 0) != 0) ? (this.丌三丘丙丘丕丐丛丆) : (1f - this.丌三丘丙丘丕丐丛丆)));
        val_29 = val_21.z;
        val_31.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_29};
        val_28 = this.丌三丘丙丘丕丐丛丆;
        float val_22 = UnityEngine.Time.deltaTime;
        val_22 = (1f / this.丝且与丝丒丟万丁专._animationTime) * val_22;
        val_30 = 1;
        val_22 = val_28 + val_22;
        this.丌三丘丙丘丕丐丛丆 = val_22;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_30;
        return (bool)val_30;
        label_2:
        val_30 = 0;
        return (bool)val_30;
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
