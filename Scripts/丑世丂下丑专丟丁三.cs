using UnityEngine;
private sealed class 丏丟专丒丏且丆丂万.丑世丂下丑专丟丁三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丄丒且丙三丆丟与丏;
    public 丏丟专丒丏且丆丂万 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, object>> 一丑丂丟丟丞丙一万;
    private System.Collections.Generic.Dictionary<string, object> 丗丟业丐丁东丅丅丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丏丟专丒丏且丆丂万.丑世丂下丑专丟丁三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_16;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object> val_17;
        int val_18;
        var val_19;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_21;
        var val_23;
        val_16 = this;
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
            goto label_25;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.一丑丂丟丟丞丙一万 = 丕丑万丒世万上丆丅.丛丐不丐丘丘万丒丂(丄丒且丙三丆丟与丏:  this.丄丒且丙三丆丟与丏);
        val_17 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_17.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.一丑丂丟丟丞丙一万);
        val_18 = 1;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.一丑丂丟丟丞丙一万.IsCanceled == true)
        {
            goto label_25;
        }
        
        val_19 = null;
        val_19 = null;
        val_21 = 丏丟专丒丏且丆丂万.<>c.<>9__3_0;
        if(val_21 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_7 = null;
            val_21 = val_7;
            val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  丏丟专丒丏且丆丂万.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丏丟专丒丏且丆丂万.<>c::下丆万丟丂专丝丛不(System.Collections.Generic.KeyValuePair<string, object> 三丟东丕丄丄下下丑));
            val_19 = null;
            丏丟专丒丏且丆丂万.<>c.<>9__3_0 = val_21;
        }
        
        val_19 = null;
        val_17 = 丏丟专丒丏且丆丂万.<>c.<>9__3_1;
        if(val_17 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object> val_8 = null;
            val_17 = val_8;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object>(object:  丏丟专丒丏且丆丂万.<>c.__il2cppRuntimeField_static_fields, method:  System.Object 丏丟专丒丏且丆丂万.<>c::丏丑丄丕丞丒专一万(System.Collections.Generic.KeyValuePair<string, object> 丒丒丄丁且丄丆丂丌));
            丏丟专丒丏且丆丂万.<>c.<>9__3_1 = val_17;
        }
        
        val_16 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Object>(source:  System.Linq.Enumerable.Union<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(first:  this.一丑丂丟丟丞丙一万.Result, second:  this.丗丟业丐丁东丅丅丂), keySelector:  val_7, elementSelector:  val_8);
        bool val_10 = this.丝且与丝丒丟万丁专.丛世丛丞丅丏丌与丌.TrySetResult(result:  val_16);
        goto label_25;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.一丑丂丟丟丞丙一万.IsCanceled == false)
        {
            goto label_27;
        }
        
        label_25:
        val_18 = 0;
        return (bool)val_18;
        label_27:
        this.丗丟业丐丁东丅丅丂 = this.一丑丂丟丟丞丙一万.Result;
        val_23 = null;
        val_23 = null;
        this.一丑丂丟丟丞丙一万 = 万与下丝东下丕万丈.丄且丙丂丆不一万七(丄丒且丙三丆丟与丏:  this.丄丒且丙三丆丟与丏, 丒丆丛上东丝三丟世:  Progress.不丗丕万上万丟与专.万丅丙丙丕丐丂不东);
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.一丑丂丟丟丞丙一万);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_18;
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
