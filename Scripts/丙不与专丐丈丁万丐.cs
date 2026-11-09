using UnityEngine;
private sealed class ObjectsActivatorManager.丙不与专丐丈丁万丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ObjectWithDelay 丏不丂丆且三丞丆丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ObjectsActivatorManager.丙不与专丐丈丁万丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_2;
        ObjectWithDelay val_3;
        int val_4;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_3 = val_2;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丏不丂丆且三丞丆丏.delay <= 0f)
        {
            goto label_4;
        }
        
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丏不丂丆且三丞丆丏.delay);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        val_3 = this.丏不丂丆且三丞丆丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_2 = mem[mem[this.丏不丂丆且三丞丆丏] + 16];
        val_2 = mem[this.丏不丂丆且三丞丆丏] + 16;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
