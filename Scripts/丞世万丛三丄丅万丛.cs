using UnityEngine;
private sealed class InGameTerrain.丞世万丛三丄丅万丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.丞世万丛三丄丅万丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        var val_2;
        int val_3;
        val_1 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_1;
        }
        
        val_2 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_2;
        label_9:
        val_2 = 1;
        this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东[0] = this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[0];
        label_2:
        if(val_2 < this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上.Length)
        {
            goto label_9;
        }
        
        val_3 = 1;
        val_1 = 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丕丄不与丒上丟下三;
        goto label_10;
        label_0:
        val_3 = 0;
        label_10:
        this.丗丏丅丕丆世丁专丟 = val_3;
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
