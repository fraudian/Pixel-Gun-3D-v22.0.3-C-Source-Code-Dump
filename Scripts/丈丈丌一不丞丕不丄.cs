using UnityEngine;
private sealed class TerrainObjectsPull.丈丈丌一不丞丕不丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TerrainObjectsPull 丝且与丝丒丟万丁专;
    public float 丕丄丝丄丞不丘丅丏;
    public int 业丈丐丐与丕丕业下;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TerrainObjectsPull.丈丈丌一不丞丕不丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_1;
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丙不丅丌丗上丂丕一 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_1 = 0f;
        goto label_2;
        label_0:
        int val_1 = this.丙不丅丌丗上丂丕一;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_1 = val_1 + 1;
        val_1 = (float)val_1;
        this.丙不丅丌丗上丂丕一 = val_1;
        label_2:
        if(this.丕丄丝丄丞不丘丅丏 > val_1)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.丙丌丄万丛三丗丞丁(业丈丐丐与丕丕业下:  this.业丈丐丐与丕丕业下);
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_3:
        val_2 = 1;
        this.丗丏丅丕丆世丁专丟 = val_2;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丕丄不与丒上丟下三;
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
