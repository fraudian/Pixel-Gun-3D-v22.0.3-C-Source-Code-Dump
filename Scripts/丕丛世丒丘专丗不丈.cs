using UnityEngine;
private sealed class TransportControllerBase.丕丛世丒丘专丗不丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TransportControllerBase 丝且与丝丒丟万丁专;
    public float 世丙丟上丘上七万万;
    public float 丟丆丆丝东世一丒丐;
    public bool 万丝一万丐且丌业丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransportControllerBase.丕丛世丒丘专丗不丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.三世丕丏万一丘丘丈 != null)
        {
                val_1 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_1;
            return (bool)val_1;
        }
        
            if(this.万丝一万丐且丌业丛 != true)
        {
                if(this.丟丆丆丝东世一丒丐 >= 0)
        {
            goto label_7;
        }
        
        }
        
        }
        
        label_7:
        val_1 = 0;
        return (bool)val_1;
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
