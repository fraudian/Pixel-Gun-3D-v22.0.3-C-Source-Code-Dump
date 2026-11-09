using UnityEngine;
private sealed class GoblinAutoCollectorController.上下丆丄业丒丝不丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丆丐七丅丆丗丛上与;
    public PGCompany.GoblinAutoCollectorController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GoblinAutoCollectorController.上下丆丄业丒丝不丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.GoblinAutoCollectorController val_3;
        int val_4;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  this.丆丐七丅丆丗丛上与);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = this.丝且与丝丒丟万丁专;
        PGCompany.上专丌丂上业丕丌七.专丐下丄丑丒丅下丗();
        System.Collections.IEnumerator val_2 = val_3.丛丕七且世丟一不丌();
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
