using UnityEngine;
private sealed class TerrainController.东丛丂上专丏专丒不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TerrainController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TerrainController.东丛丂上专丏专丒不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_26 = 0;
        if(this.丗丏丅丕丆世丁专丟 > 5)
        {
                return (bool);
        }
        
        var val_26 = 106023152;
        val_26 = (106023152 + (this.丗丏丅丕丆世丁专丟) << 2) + val_26;
        goto (106023152 + (this.丗丏丅丕丆世丁专丟) << 2 + 106023152);
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
