using UnityEngine;
private sealed class TerrainController.丘下丑业丝丒丌丗业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TerrainController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TerrainController.丘下丑业丝丒丌丗业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_14;
        var val_15;
        var val_16;
        int val_20;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Collections.IEnumerator val_2 = this.丝且与丝丒丟万丁专.GetComponentInChildren<UnityEngine.Transform>().GetEnumerator();
        label_19:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = val_2.Current;
        val_14 = 0;
        if((System.String.op_Equality(a:  val_14.gameObject.name, b:  "TerrainPlayerPosition")) == false)
        {
            goto label_19;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_20;
        }
        
        this.丝且与丝丒丟万丁专.terrainPlayerTransform = val_14;
        goto label_21;
        label_9:
        val_15 = 0;
        val_16 = 0;
        goto label_23;
        label_20:
        mem[24] = val_14;
        label_21:
        val_15 = 0;
        val_16 = 0;
        this.丝且与丝丒丟万丁专.丙与丏丑丐世丒七三 = true;
        label_23:
        if(val_2 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_2.Dispose();
        }
        
        if( == 1)
        {
            goto label_39;
        }
        
        if(( == 0) || (128 == 128))
        {
            goto label_48;
        }
        
        label_47:
        label_48:
        if(this.丝且与丝丒丟万丁专.terrainPlayerTransform == 0)
        {
            goto label_45;
        }
        
        label_1:
        val_20 = 0;
        return (bool)val_20;
        label_45:
        val_20 = 1;
        this.丗丏丅丕丆世丁专丟 = val_20;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.万丆丄丝丞世丑一业;
        return (bool)val_20;
        label_39:
        if( != 0)
        {
            goto label_47;
        }
        
        goto label_48;
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
