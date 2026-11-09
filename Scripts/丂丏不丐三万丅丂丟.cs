using UnityEngine;
private sealed class SceneLoader.丂丏不丐三万丅丂丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.AsyncOperation 丌万业且丟三丘丝万;
    public Rilisoft.SceneLoader 丝且与丝丒丟万丁专;
    public Rilisoft.且丙业丂丞一丈丙七 东丞丙专下七丞且东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SceneLoader.丂丏不丐三万丅丂丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action<Rilisoft.且丙业丂丞一丈丙七> val_2;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丌万业且丟三丘丝万.isDone == false)
        {
            goto label_3;
        }
        
        val_2 = this.丝且与丝丒丟万丁专.丙与东丏丕丞丕丐东;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        val_2.Invoke(obj:  new Rilisoft.且丙业丂丞一丈丙七() {<且上丁世丞丛上丁不>k__BackingField = this.东丞丙专下七丞且东});
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_3:
        val_2 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
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
