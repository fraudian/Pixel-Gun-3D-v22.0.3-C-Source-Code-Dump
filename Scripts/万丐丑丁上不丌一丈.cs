using UnityEngine;
private sealed class InGameTerrain.万丐丑丁上不丌一丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    public UnityEngine.Vector2 丞丟丆一丄七与丝丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.万丐丑丁上不丌一丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        int val_8;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = 1;
        this.丗丏丅丕丆世丁专丟 = val_8;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丕丄不与丒上丟下三;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_7 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_7 = this.丞丟丆一丄七与丝丒 * val_7;
        val_7 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_7), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        float val_8 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_8 = this.丞丟丆一丄七与丝丒 * val_8;
        this.丝且与丝丒丟万丁专.recalculateHiMeshEvent.Invoke(arg0:  val_7, arg1:  UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_8), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1));
        val_8 = 0;
        this.丝且与丝丒丟万丁专.丈丈丆丆专丟丘一丌 = 0;
        return (bool)val_8;
        label_2:
        val_8 = 0;
        return (bool)val_8;
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
