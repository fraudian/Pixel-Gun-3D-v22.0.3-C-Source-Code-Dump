using UnityEngine;
private sealed class AuthSceneController.世且丘丘丂丑丘东丁<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task<T> 万不且且丛丆东丒业;
    public System.Action 丁万丂专丞世丈三丅;
    public System.Action 丑丈丈丝丘万七一上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.世且丘丘丂丑丘东丁<T>(int 丗丏丅丕丆世丁专丟)
    {
        mem[1152921536254098512] = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_7;
        }
        
        mem[1152921536254338896] = 0;
        mem[1152921536254338904] = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  137162752);
        val_7 = 1;
        mem[1152921536254338896] = val_7;
        return (bool)val_7;
        label_1:
        mem[1152921536254338896] = 0;
        if(AuthSceneController.丄丙丂丝丄丌丗丂丅() != 6)
        {
            goto label_7;
        }
        
        bool val_4 = IsCanceled;
        if((val_4 == true) || (val_4 == false))
        {
            goto label_10;
        }
        
        bool val_6 = val_4.Result.东丙丑世万丐七丝丘();
        if(val_6 == false)
        {
            goto label_12;
        }
        
        label_10:
        if(val_6 == false)
        {
                return (bool)val_7;
        }
        
        label_14:
        val_6.Invoke();
        label_7:
        val_7 = 0;
        return (bool)val_7;
        label_12:
        if(val_6 == true)
        {
            goto label_14;
        }
        
        return (bool)val_7;
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
