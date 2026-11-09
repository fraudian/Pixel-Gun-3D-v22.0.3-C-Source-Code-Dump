using UnityEngine;
private sealed class PersistentCacheManager.七不一丞丙三七东丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task<string> 专一与丘且上丟上且;
    private Rilisoft.PersistentCacheManager.丈业丗丞丁七下一不 丄丌丂东丘丗一万且;
    public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 世丅丒丆三下专丘丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PersistentCacheManager.七不一丞丙三七东丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
    }
    private bool MoveNext()
    {
        var val_16;
        UnityEngine.WaitUntil val_22;
        int val_23;
        string val_24;
        var val_25;
        var val_26;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_67;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        if(this.丄丌丂东丘丗一万且.专一与丘且上丟上且.IsCanceled == false)
        {
            goto label_5;
        }
        
        bool val_2 = this.世丅丒丆三下专丘丆.TrySetCanceled();
        goto label_61;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        new PersistentCacheManager.丈业丗丞丁七下一不() = new System.Object();
        this.丄丌丂东丘丗一万且 = new PersistentCacheManager.丈业丗丞丁七下一不();
        .专一与丘且上丟上且 = this.专一与丘且上丟上且;
        this.丗丏丅丕丆世丁专丟 = -3;
        System.Func<System.Boolean> val_4 = new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean PersistentCacheManager.丈业丗丞丁七下一不::丕上丏三且三业万下());
        val_22 = new UnityEngine.WaitUntil();
        val_22 = new UnityEngine.WaitUntil(predicate:  null);
        val_23 = 1;
        this.丒上七丌业七丟与丐 = val_22;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_5:
        if(this.丄丌丂东丘丗一万且.专一与丘且上丟上且.IsFaulted != false)
        {
                val_22 = this.丄丌丂东丘丗一万且.专一与丘且上丟上且.Exception;
            bool val_8 = this.世丅丒丆三下专丘丆.TrySetException(exception:  val_22);
        }
        else
        {
                System.Collections.Generic.Dictionary<System.String, System.String> val_9 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            object val_11 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  this.丄丌丂东丘丗一万且.专一与丘且上丟上且.Result);
            val_22 = this.世丅丒丆三下专丘丆;
            bool val_12 = val_22.TrySetResult(result:  null);
        }
        
        label_61:
        val_23 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_23;
        label_29:
        if((52842768 & 1) == 0)
        {
            goto label_24;
        }
        
        ConfiguredValueTaskAwaiter val_17 = val_16.GetAwaiter();
        if(val_17._value._obj != 0)
        {
                var val_18 = (val_17._value._obj == null) ? 52842752 : 0;
        }
        else
        {
                val_24 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_24)) == true)
        {
            goto label_29;
        }
        
        null.set_Item(key:  val_17._value._obj.丐丏七丌丕丗业且上(), value:  val_24);
        goto label_29;
        label_24:
        val_25 = 0;
        val_26 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_55;
        }
        
        if( == 0)
        {
            goto label_59;
        }
        
        if(339 != 339)
        {
            goto label_57;
        }
        
        goto label_59;
        label_55:
        if( == 0)
        {
            goto label_59;
        }
        
        label_57:
        label_59:
        bool val_21 = this.世丅丒丆三下专丘丆.TrySetResult(result:  null);
        goto label_61;
        label_67:
        val_23 = 0;
        return (bool)val_23;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
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
