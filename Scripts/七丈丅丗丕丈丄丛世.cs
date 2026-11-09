using UnityEngine;
private sealed class AuthSceneController.七丈丅丗丕丈丄丛世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<System.Collections.Generic.HashSet<string>> 下丁丁世丐丅丌丂丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.七丈丅丗丕丈丄丛世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        System.Collections.Generic.HashSet<System.Int32> val_24;
        AuthSceneController val_25;
        System.Collections.Generic.HashSet<System.String> val_26;
        int val_27;
        System.Collections.IEnumerator val_28;
        val_24 = this;
        val_25 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_40;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 9)
        {
            goto label_40;
        }
        
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        val_26 = this.丝且与丝丒丟万丁专.丒丌丕丟业与一丏业;
        if(val_26 == null)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.丒丌丕丟业与一丏业 = 0;
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_26 = this.下丁丁世丐丅丌丂丞.Result;
        this.下丁丁世丐丅丌丂丞 = 0;
        label_7:
        System.Collections.Generic.HashSet<System.Int32> val_4 = null;
        val_24 = val_4;
        val_4 = new System.Collections.Generic.HashSet<System.Int32>(collection:  System.Linq.Enumerable.Range(start:  1, count:  24));
        HashSet.Enumerator<T> val_5 = val_26.GetEnumerator();
        label_16:
        if((1574150448 & 1) == 0)
        {
            goto label_10;
        }
        
        int val_9 = System.Convert.ToInt32(value:  val_7.丐丏七丌丕丗业且上());
        if((val_4.Contains(item:  val_9)) == false)
        {
            goto label_16;
        }
        
        bool val_11 = val_4.Remove(item:  val_9);
        goto label_16;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_24 != null)
        {
            goto label_35;
        }
        
        goto label_18;
        label_6:
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  11);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.85f));
        this.下丁丁世丐丅丌丂丞 = 万与下丝东下丕万丈.且丌三业丌世丑且且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        CoroutineRunner val_15 = CoroutineRunner.Instance;
        val_25 = this.下丁丁世丐丅丌丂丞;
        this.丒上七丌业七丟与丐 = val_15.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  val_25);
        val_27 = 1;
        this.丗丏丅丕丆世丁专丟 = val_27;
        return (bool)val_27;
        label_18:
        label_35:
        if(this.Count >= 1)
        {
                val_24 = Progress.七七世万专丕丁上业.专丛丁业世上丙世世(丛丙与一与且万一三:  this);
            val_25.丕丌丈丂丝丝七业下(上丕丈丞丌丘丅不与:  val_24, 丗丙且世且丞丆丙下:  false, 三专一丝丝三丆丑上:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 一万东三丏丘丄丗丈:  val_15);
        }
        else
        {
                if(val_25 != null)
        {
                mem2[0] = val_15;
            val_28 = val_25.专专丞丁丁下丈专专();
        }
        else
        {
                mem[64] = val_15;
            val_28 = 0.专专丞丁丁下丈专专();
        }
        
            UnityEngine.Coroutine val_22 = val_25.StartCoroutine(routine:  val_28);
        }
        
        label_40:
        val_27 = 0;
        return (bool)val_27;
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
