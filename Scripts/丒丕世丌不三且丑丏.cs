using UnityEngine;
private sealed class LoaderFX.丒丕世丌不三且丑丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LoaderFX 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅世丌与不丗万业丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoaderFX.丒丕世丌不三且丑丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_14;
        UnityEngine.ResourceRequest val_15;
        var val_16;
        int val_17;
        var val_18;
        val_14 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_14;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = UnityEngine.Resources.LoadAsync(path:  "LoadGameObjectFX/"("LoadGameObjectFX/") + this.丝且与丝丒丟万丁专.namePrefab);
        val_16 = val_14;
        this.丅世丌与不丗万业丅 = val_15;
        if(val_15 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_16 = val_14;
        val_15 = this.丅世丌与不丗万业丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_15 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if(val_15.isDone == false)
        {
            goto label_7;
        }
        
        UnityEngine.ResourceRequest val_14 = this.丅世丌与不丗万业丅;
        UnityEngine.Object val_4 = val_14.asset;
        if(val_4 == null)
        {
            goto label_9;
        }
        
        val_14 = (null == null) ? (val_4) : 0;
        goto label_10;
        label_7:
        val_17 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_17;
        label_9:
        val_14 = 0;
        label_10:
        if(val_14 == 0)
        {
            goto label_14;
        }
        
        val_18 = 0;
        goto label_15;
        label_34:
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_14);
        val_6.transform.parent = this.丝且与丝丒丟万丁专.parents[0];
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_16 = val_6.transform;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_16.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        val_6.transform.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
        val_18 = 1;
        label_15:
        if(val_18 < this.丝且与丝丒丟万丁专.parents.Length)
        {
            goto label_34;
        }
        
        label_14:
        val_17 = 0;
        return (bool)val_17;
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
