using UnityEngine;
private sealed class PersistentCacheManager.七丛丆丏七三丘业丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.PersistentCacheManager 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 世丅丒丆三下专丘丆;
    public int 与且专丈不万东一万;
    private string[] 丂七丈七三东下且丄;
    private System.Threading.Tasks.TaskCompletionSource<string> 丘丅与丌丙与丏世丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PersistentCacheManager.七丛丆丏七三丘业丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.PersistentCacheManager val_34;
        System.Threading.CancellationToken val_35;
        System.Collections.IEnumerator val_36;
        int val_37;
        var val_38;
        val_34 = this.丝且与丝丒丟万丁专;
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
            goto label_84;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        string[] val_1 = new string[1];
        val_1[0] = 丄丛丏丄不一丆丐丑.七不丐丈三丅且丕丙();
        this.丂七丈七三东下且丄 = val_1;
        System.Threading.Tasks.TaskCompletionSource<System.String> val_3 = new System.Threading.Tasks.TaskCompletionSource<System.String>();
        this.丘丅与丌丙与丏世丌 = val_3;
        val_35 = this.业丘丝业丛丆丄一上;
        val_36 = Rilisoft.PersistentCacheManager.丗下丈下丘七丆丐丘(丅万丛丄丅七一丟丘:  this.丂七丈七三东下且丄, 业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_35}, 世丅丒丆三下专丘丆:  val_3);
        this.丒上七丌业七丟与丐 = val_34.StartCoroutine(routine:  val_36);
        val_37 = 1;
        this.丗丏丅丕丆世丁专丟 = val_37;
        return (bool)val_37;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_35 = 1152921543308594160;
        val_36 = this.世丅丒丆三下专丘丆.Task;
        if(val_36.IsCanceled == false)
        {
            goto label_16;
        }
        
        object[] val_8 = new object[1];
        val_34 = val_8;
        val_34[0] = this.与且专丈不万东一万;
        UnityEngine.Debug.LogWarningFormat(format:  "DownloadSignaturesOnceCoroutine({0}) cancelled.", args:  val_8);
        goto label_84;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_36 = Rilisoft.PersistentCacheManager.万上丕丆丛一丅万丆(专一与丘且上丟上且:  this.丘丅与丌丙与丏世丌.Task, 世丅丒丆三下专丘丆:  this.世丅丒丆三下专丘丆);
        this.丒上七丌业七丟与丐 = val_34.StartCoroutine(routine:  val_36);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_37 = 1;
        return (bool)val_37;
        label_16:
        if(this.世丅丒丆三下专丘丆.Task.IsFaulted == false)
        {
            goto label_31;
        }
        
        object[] val_14 = new object[2];
        val_36 = val_14;
        val_36[0] = this.与且专丈不万东一万;
        val_36[1] = this.世丅丒丆三下专丘丆.Task.Exception.InnerException;
        UnityEngine.Debug.LogWarningFormat(format:  "DownloadSignaturesOnceCoroutine({0}) failed: {1}", args:  val_14);
        val_38 = 1152921505478782976;
        val_35 = 0;
        goto label_44;
        label_54:
        string val_19 = Rilisoft.PersistentCacheManager.丄丑丈丏上丝丆丂丐(东与专丗且丏不与丐:  Rilisoft.PersistentCacheManager.丗东丅不丛七下丄丌(七丙不丅丛丘丗万与:  this.丂七丈七三东下且丄[0]));
        val_36 = val_34.丌丁丐丒业丅丙丝丁();
        if((val_36.丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  val_19)) != false)
        {
                val_36 = System.String.alignConst;
            val_34.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  val_19, 丙业与丙丗丝不丈东:  val_36);
        }
        
        val_35 = 1;
        label_44:
        if(val_35 < this.丂七丈七三东下且丄.Length)
        {
            goto label_54;
        }
        
        val_34 = this.丝且与丝丒丟万丁专.不丙与丂丒丑丒与万;
        val_34.Clear();
        goto label_84;
        label_31:
        val_36 = this.世丅丒丆三下专丘丆.Task.Result;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(UnityEngine.Application.isEditor != true)
        {
                object[] val_29 = new object[2];
            val_29[0] = this.与且专丈不万东一万;
            val_29[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_36);
            UnityEngine.Debug.LogFormat(format:  (UnityEngine.Application.isEditor != true) ? "DownloadSignaturesOnceCoroutine({0}) succeeded: <color=magenta>{1}</color>" : "DownloadSignaturesOnceCoroutine({0}) succeeded: {1}", args:  val_29);
        }
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_31 = val_36.GetEnumerator();
        val_35 = 1152921516597555328;
        val_38 = 1152921516597556352;
        label_77:
        if((51595480 & 1) == 0)
        {
            goto label_74;
        }
        
        ConfiguredValueTaskAwaiter val_32 = 0.GetAwaiter();
        this.丝且与丝丒丟万丁专.不丙与丂丒丑丒与万.set_Item(key:  val_32._value._obj.丐丏七丌丕丗业且上(), value:  val_32._value._obj);
        goto label_77;
        label_74:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_84:
        val_37 = 0;
        return (bool)val_37;
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
