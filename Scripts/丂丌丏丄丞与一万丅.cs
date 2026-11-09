using UnityEngine;
private sealed class 丑下且丙上丁丌上且.丂丌丏丄丞与一万丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Progress.丑下且丙上丁丌上且 丝且与丝丒丟万丁专;
    private bool 七上不业上丅丛业丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丑下且丙上丁丌上且.丂丌丏丄丞与一万丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_4;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.七上不业上丅丛业丂 != true)
        {
                if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                this.丝且与丝丒丟万丁专.丛下丈不丅丙丙业丏();
        }
        
        }
        
        label_4:
        val_4 = 1;
        this.七上不业上丅丛业丂 = AuthSceneController.一不丆丏与丐丏丈丄();
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
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
