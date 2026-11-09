using UnityEngine;
private sealed class PersistentCacheManager.三丂丙上世丙丌丒丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string[] 丅万丛丄丅七一丟丘;
    public System.Threading.Tasks.TaskCompletionSource<string> 世丅丒丆三下专丘丆;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    private UnityEngine.WWW 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PersistentCacheManager.三丂丙上世丙丌丒丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<System.String> val_18;
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.WWW val_22;
        var val_23;
        val_18 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅万丛丄丅七一丟丘.Length == 0)
        {
            goto label_4;
        }
        
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_19 = 0;
        goto label_5;
        label_12:
        val_1.Add(item:  Rilisoft.PersistentCacheManager.丗东丅不丛七下丄丌(七丙不丅丛丘丗万与:  this.丅万丛丄丅七一丟丘[0]));
        val_19 = 1;
        label_5:
        if(val_19 < this.丅万丛丄丅七一丟丘.Length)
        {
            goto label_12;
        }
        
        UnityEngine.WWWForm val_4 = new UnityEngine.WWWForm();
        val_20 = null;
        val_20 = null;
        string val_6 = System.String.Format(format:  "{0}:{1}", arg0:  ProtocolListGetter.丅三专丐丗丅与丆丑(), arg1:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        if(val_4 == null)
        {
            goto label_15;
        }
        
        val_4.AddField(fieldName:  "app_version", value:  val_6);
        goto label_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.业丘丝业丛丆丄一上 & 1) != 0)
        {
            goto label_22;
        }
        
        val_21 = val_18;
        val_22 = this.丅丒丑丄丞丑下丈丕;
        if(val_22 != null)
        {
            goto label_19;
        }
        
        val_22 = 0;
        goto label_19;
        label_4:
        val_18 = this.世丅丒丆三下专丘丆;
        bool val_7 = val_18.TrySetResult(result:  "{}");
        return false;
        label_15:
        val_4.AddField(fieldName:  "app_version", value:  val_6);
        label_16:
        val_4.AddField(fieldName:  "names", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
        UnityEngine.WWW val_8 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  "https://secure.pixelgunserver.com/get_files_info.php", 丛丁且丏丁丄上上丄:  val_4, 丐丆丐七一上专三丑:  "DownloadSignaturesCoroutine()", 一丞不一不一与世丙:  0);
        val_21 = val_18;
        this.丅丒丑丄丞丑下丈丕 = val_8;
        if(val_8 == null)
        {
            goto label_22;
        }
        
        label_19:
        if(val_8.isDone == false)
        {
            goto label_23;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丅丒丑丄丞丑下丈丕.error)) == false)
        {
            goto label_25;
        }
        
        bool val_13 = this.世丅丒丆三下专丘丆.TrySetResult(result:  丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.丅丒丑丄丞丑下丈丕));
        val_23 = 368;
        goto label_29;
        label_22:
        val_18 = this.世丅丒丆三下专丘丆;
        bool val_14 = val_18.TrySetCanceled();
        return false;
        label_23:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
        label_25:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  this.丅丒丑丄丞丑下丈丕.error);
        bool val_17 = this.世丅丒丆三下专丘丆.TrySetException(exception:  new System.InvalidOperationException());
        val_23 = 377;
        label_29:
        this.丅丒丑丄丞丑下丈丕.Dispose();
        if(0 == 1)
        {
            goto label_35;
        }
        
        if(377 == 377)
        {
                return false;
        }
        
        if(0 == 0)
        {
            goto label_40;
        }
        
        if(377 != 368)
        {
            goto label_38;
        }
        
        goto label_40;
        label_35:
        if(0 == 0)
        {
            goto label_40;
        }
        
        label_38:
        label_40:
        this.丅丒丑丄丞丑下丈丕 = 0;
        return false;
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
