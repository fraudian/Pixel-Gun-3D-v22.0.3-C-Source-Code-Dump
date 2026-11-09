using UnityEngine;
private sealed class AuthSceneController.丙丟与七丁三丞丈丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<System.Collections.Generic.HashSet<string>> 一丑丂丟丟丞丙一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.丙丟与七丁三丞丈丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.Task<System.Collections.Generic.HashSet<System.String>> val_9;
        System.Threading.Tasks.Task<System.Collections.Generic.HashSet<System.String>> val_10;
        int val_11;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  9);
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  11);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.85f));
        this.一丑丂丟丟丞丙一万 = 万与下丝东下丕万丈.且丌三业丌世丑且且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        val_10 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_10.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.一丑丂丟丟丞丙一万);
        val_11 = 1;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.86f));
        val_10 = this.一丑丂丟丟丞丙一万;
        Progress.丑丗丄业丒三上上丁.丒丁丈丗丈丛万丕丛(丞万丒丝与不丙丏不:  val_10.Result);
        val_9 = this.一丑丂丟丟丞丙一万;
        val_11 = 0;
        this.丝且与丝丒丟万丁专.丒丌丕丟业与一丏业 = val_9.Result;
        return (bool)val_11;
        label_2:
        val_11 = 0;
        return (bool)val_11;
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
