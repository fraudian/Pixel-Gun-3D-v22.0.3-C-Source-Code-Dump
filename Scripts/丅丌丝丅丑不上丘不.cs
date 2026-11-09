using UnityEngine;
private sealed class AuthSceneController.丅丌丝丅丑不上丘不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<System.Collections.Generic.HashSet<string>> 一世七丐丏丐丙丐丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.丅丌丝丅丑不上丘不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_20;
        var val_21;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_22;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_20 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_20;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        if(this.丝且与丝丒丟万丁专.丙丅丛一专丘东上丄 == null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丙丅丛一专丘东上丄 = 0;
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_24;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.一世七丐丏丐丙丐丘 = 0;
        label_6:
        System.Collections.Generic.HashSet<System.Int32> val_3 = new System.Collections.Generic.HashSet<System.Int32>();
        val_21 = 0;
        goto label_11;
        label_20:
        int val_20 = 丞东丑专丛丆丄丝世.丞丏丞丗不丐与一丌<Progress.专丘七丑一世不专丕>()[0];
        if(val_20 >= 25)
        {
                if((this.一世七丐丏丐丙丐丘.Result.Contains(item:  val_20.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture))) != true)
        {
                bool val_8 = val_3.Add(item:  val_20);
        }
        
        }
        
        val_21 = 1;
        label_11:
        if(val_21 < val_4.Length)
        {
            goto label_20;
        }
        
        val_22 = Progress.七七世万专丕丁上业.丙丌丁丒丘丕业万业(丛丙与一与且万一三:  val_3);
        if(val_22.Count >= 1)
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  12);
            ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.88f));
            val_22 = CoroutineRunner.Instance;
            this.丒上七丌业七丟与丐 = val_22.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  Progress.丝下与上丙丞万业丐.专专丞丁丁下丈专专(万丈与万丑丛与一且:  val_22));
            this.丗丏丅丕丆世丁专丟 = 2;
            val_20 = 1;
            return (bool)val_20;
        }
        
        label_24:
        this.丝且与丝丒丟万丁专.七丅丑与丒业丛下丂();
        val_20 = 0;
        return (bool)val_20;
        label_5:
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  11);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.85f));
        this.一世七丐丏丐丙丐丘 = 万与下丝东下丕万丈.且丌三业丌世丑且且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.一世七丐丏丐丙丐丘);
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_20;
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
