using UnityEngine;
private sealed class 丁丕下世丁丌万三丆.丁丁丏丆丆下丝丙丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丆丐七丅丆丗丛上与;
    public PGCompany.BM.丁丕下世丁丌万三丆 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丁丕下世丁丌万三丆.丁丁丏丆丆下丝丙丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSecondsRealtime val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForSecondsRealtime(time:  this.丆丐七丅丆丗丛上与);
        val_6 = 1;
        this.丒上七丌业七丟与丐 = val_5;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        val_5 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5.丛不丄与丅丘丙丁与(丌下业东与下丅丞七:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  0.丞丂万丝丌丝丝丆万()));
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
