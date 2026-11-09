using UnityEngine;
private sealed class InGameTerrain.七上七丗上一世七丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.七上七丗上一世七丂(int 丗丏丅丕丆世丁专丟)
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
        var val_3;
        丝与丐与丌丞丕丗丁[] val_4;
        var val_5;
        int val_6;
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
        label_11:
        if(this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[0] == 0)
        {
                this.丝且与丝丒丟万丁专.lowMeshes[0].enabled = true;
        }
        
        val_2 = 1;
        label_2:
        if(val_2 < this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上.Length)
        {
            goto label_11;
        }
        
        val_3 = 0;
        goto label_12;
        label_19:
        val_4 = this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上;
        if(val_4[20] == 0)
        {
                64.enabled = false;
        }
        
        val_3 = 1;
        label_12:
        if(val_3 < this.丝且与丝丒丟万丁专.midMeshes.Length)
        {
            goto label_19;
        }
        
        val_5 = 0;
        goto label_20;
        label_27:
        val_4 = this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上;
        if(val_4[20] == 0)
        {
                64.enabled = false;
        }
        
        val_5 = 1;
        label_20:
        if(val_5 < this.丝且与丝丒丟万丁专.hiMeshes.Length)
        {
            goto label_27;
        }
        
        val_6 = 1;
        val_1 = 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丕丄不与丒上丟下三;
        goto label_28;
        label_0:
        val_6 = 0;
        label_28:
        this.丗丏丅丕丆世丁专丟 = val_6;
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
