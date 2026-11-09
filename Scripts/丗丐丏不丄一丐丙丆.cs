using UnityEngine;
private sealed class PersistentCacheManager.丗丐丏不丄一丐丙丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 世丅丒丆三下专丘丆;
    public Rilisoft.PersistentCacheManager 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    private Rilisoft.PersistentCacheManager.业丂七丏丟丕丌丂世 丄丌丂东丘丗一万且;
    public float 且丛丄丌下丑丁七与;
    public float 丘三丅丒三世丄下且;
    private int 丙不丅丌丗上丂丕一;
    private System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> 丂丆丞丕世三丗与丝;
    private float 丅丈丏丂七万丗丏丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PersistentCacheManager.丗丐丏不丄一丐丙丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PersistentCacheManager.业丂七丏丟丕丌丂世 val_16;
        System.Collections.IEnumerator val_17;
        int val_18;
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
        PersistentCacheManager.业丂七丏丟丕丌丂世 val_1 = null;
        val_16 = val_1;
        val_1 = new PersistentCacheManager.业丂七丏丟丕丌丂世();
        this.丄丌丂东丘丗一万且 = val_16;
        .世丅丒丆三下专丘丆 = this.世丅丒丆三下专丘丆;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_18;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_7;
        label_22:
        System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<System.String, System.String>> val_2 = new System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<System.String, System.String>>();
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_17 = this.丝且与丝丒丟万丁专.丑一不丘丟不三丑丟(业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = this.业丘丝业丛丆丄一上}, 世丅丒丆三下专丘丆:  val_2, 与且专丈不万东一万:  this.丙不丅丌丗上丂丕一);
        }
        else
        {
                val_17 = 0.丑一不丘丟不三丑丟(业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = this.业丘丝业丛丆丄一上}, 世丅丒丆三下专丘丆:  val_2, 与且专丈不万东一万:  this.丙不丅丌丗上丂丕一);
        }
        
        UnityEngine.Coroutine val_5 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_17);
        System.Threading.Tasks.Task<TResult> val_6 = val_2.Task;
        this.丂丆丞丕世三丗与丝 = val_6;
        if(this.丄丌丂东丘丗一万且.上丌丘丑一且丆且丏 == null)
        {
            goto label_12;
        }
        
        if(val_6 != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        System.Threading.Tasks.Task val_7 = val_6.ContinueWith(continuationAction:  this.丄丌丂东丘丗一万且.上丌丘丑一且丆且丏);
        float val_8 = UnityEngine.Time.realtimeSinceStartup;
        val_8 = val_8 + this.且丛丄丌下丑丁七与;
        this.丅丈丏丂七万丗丏丛 = val_8;
        label_7:
        if(UnityEngine.Time.realtimeSinceStartup >= 0)
        {
            goto label_14;
        }
        
        val_16 = this.丂丆丞丕世三丗与丝;
        if(val_16.IsFaulted == false)
        {
            goto label_16;
        }
        
        label_14:
        val_16 = this.丂丆丞丕世三丗与丝;
        if(val_16.IsFaulted != false)
        {
                float val_12 = UnityEngine.Time.realtimeSinceStartup;
            val_12 = this.丅丈丏丂七万丗丏丛 - val_12;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Mathf.Clamp(value:  val_12, min:  0f, max:  this.丘三丅丒三世丄下且));
            this.丗丏丅丕丆世丁专丟 = 2;
            val_18 = 1;
            return (bool)val_18;
        }
        
        label_18:
        int val_16 = this.丙不丅丌丗上丂丕一;
        this.丂丆丞丕世三丗与丝 = 0;
        val_16 = val_16 + 1;
        this.丙不丅丌丗上丂丕一 = val_16;
        label_5:
        if((this.业丘丝业丛丆丄一上 & 1) == 0)
        {
            goto label_22;
        }
        
        label_3:
        val_18 = 0;
        return (bool)val_18;
        label_16:
        val_18 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_12:
        this.丄丌丂东丘丗一万且.上丌丘丑一且丆且丏 = new System.Action<System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.String>>>(object:  this.丄丌丂东丘丗一万且, method:  System.Void PersistentCacheManager.业丂七丏丟丕丌丂世::与丟丌丐上丗丆丙且(System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> 丙丒七丄上与丏丙丙));
        if(val_6 != null)
        {
            goto label_25;
        }
        
        goto label_26;
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
