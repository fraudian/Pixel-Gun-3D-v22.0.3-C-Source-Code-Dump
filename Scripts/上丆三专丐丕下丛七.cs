using UnityEngine;
private sealed class 七专万下丄世丞丂且.上丆三专丐丕下丛七<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task<T> 万不且且丛丆东丒业;
    public 七专万下丄世丞丂且 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 七专万下丄世丞丂且.上丆三专丐丕下丛七<T>(int 丗丏丅丕丆世丁专丟)
    {
        mem[1152921536268763888] = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_15;
        }
        
        mem[1152921536269000176] = 0;
        mem[1152921536269000184] = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  137175040);
        val_8 = 1;
        mem[1152921536269000176] = val_8;
        return (bool)val_8;
        label_1:
        mem[1152921536269000176] = 0;
        if(X21.IsCanceled != true)
        {
                上丌一东丈丟与丘丒 val_4 = this.Result;
            if(val_4.东丙丑世万丐七丝丘() != false)
        {
                三下丝丛丗世丐丅丟();
        }
        else
        {
                if(val_4.丙且丗丛一一专丂丕() != false)
        {
                丟丙丛丄上丂丘丆业();
        }
        
        }
        
        }
        
        label_15:
        val_8 = 0;
        return (bool)val_8;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
