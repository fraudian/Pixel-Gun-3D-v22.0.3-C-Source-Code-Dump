using UnityEngine;
private sealed class 丞东丑专丛丆丄丝世.东丈丙三丆业丙上一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.GameObject 丝三丁东丈丒世丅业;
    public UnityEngine.Vector3 丈丗与丞一上且上上;
    public UnityEngine.Vector3 专丂丕丗丗东世丞下;
    public float 丆丐七丅丆丗丛上与;
    public System.Action 丘丌七与丗东丘丈丗;
    private float 丌丂专丕东丈丙且丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丞东丑专丛丆丄丝世.东丈丙三丆业丙上一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_7;
        UnityEngine.Vector3 val_8;
        float val_9;
        System.Action val_10;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝三丁东丈丒世丅业.transform.position = new UnityEngine.Vector3() {x = this.丈丗与丞一上且上上, y = V9.16B, z = V10.16B};
        this.丌丂专丕东丈丙且丐 = 0f;
        val_7 = 0f;
        goto label_5;
        label_1:
        val_7 = this.丌丂专丕东丈丙且丐;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        UnityEngine.Transform val_2 = this.丝三丁东丈丒世丅业.transform;
        if(val_7 < 0)
        {
            goto label_7;
        }
        
        val_8 = this.专丂丕丗丗东世丞下;
        val_2.position = new UnityEngine.Vector3() {x = val_8, y = this.丆丐七丅丆丗丛上与, z = V10.16B};
        val_10 = this.丘丌七与丗东丘丈丗;
        if(val_10 == null)
        {
                return (bool)val_10;
        }
        
        val_10.Invoke();
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_7:
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丈丗与丞一上且上上, y = this.丆丐七丅丆丗丛上与, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.专丂丕丗丗东世丞下, y = V13.16B, z = V12.16B}, t:  this.丌丂专丕东丈丙且丐 / this.丆丐七丅丆丗丛上与);
        val_9 = val_4.z;
        val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_9};
        val_8 = this.丌丂专丕东丈丙且丐;
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_8 + val_5;
        this.丌丂专丕东丈丙且丐 = val_5;
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
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
