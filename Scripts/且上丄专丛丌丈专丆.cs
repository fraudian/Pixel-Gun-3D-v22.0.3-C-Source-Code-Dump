using UnityEngine;
private sealed class InGameTerrain.且上丄专丛丌丈专丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    private int 丌丑与且丑东丞丕丗;
    private UnityEngine.Transform[] 业东东下丘丒丝业专;
    private int 丒与不丕东七丂上不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.且上丄专丛丌丈专丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        int val_10;
        UnityEngine.Transform[] val_11;
        UnityEngine.Transform[] val_12;
        int val_13;
        var val_14;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        val_10 = this.丌丑与且丑东丞丕丗;
        val_11 = this.业东东下丘丒丝业专;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丌丑与且丑东丞丕丗 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.showPreview = false;
        goto label_7;
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_6:
        mem[32] = 0;
        label_7:
        val_12 = this.丝且与丝丒丟万丁专.GetComponentsInChildren<UnityEngine.Transform>();
        val_11 = this;
        this.业东东下丘丒丝业专 = val_12;
        val_13 = 0;
        this.丒与不丕东七丂上不 = 0;
        if(val_12 != null)
        {
            goto label_23;
        }
        
        goto label_10;
        label_24:
        if((val_2.Length + 32.gameObject.name.Contains(value:  "Preview_")) != false)
        {
                UnityEngine.Object.Destroy(obj:  val_2.Length + 32.gameObject);
        }
        
        val_14 = this;
        int val_9 = this.丝且与丝丒丟万丁专.terrainData.grid;
        val_9 = this.丌丑与且丑东丞丕丗 - ((this.丌丑与且丑东丞丕丗 / val_9) * val_9);
        if(val_9 == 0)
        {
            goto label_22;
        }
        
        label_5:
        int val_10 = this.丌丑与且丑东丞丕丗;
        val_10 = val_10 + 1;
        this.丌丑与且丑东丞丕丗 = val_10;
        val_13 = 1;
        this.丒与不丕东七丂上不 = val_13;
        val_12 = this.业东东下丘丒丝业专;
        if(val_12 != null)
        {
            goto label_23;
        }
        
        label_10:
        label_23:
        if(val_13 < val_2.Length)
        {
            goto label_24;
        }
        
        val_9 = 0;
        this.业东东下丘丒丝业专 = 0;
        return (bool)val_9;
        label_22:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
        return (bool)val_9;
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
