using UnityEngine;
private sealed class InGameTerrain.丗丁且世东上下与万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.丗丁且世东上下与万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丈下业专七丞专丟丂.上上丈东丈七丘丏三() != true)
        {
                this.丝且与丝丒丟万丁专.丈下业专七丞专丟丂.丙世丑东丕丙丙丛丝();
        }
        
        this.丝且与丝丒丟万丁专.业丏丅丛丞一丞东丟(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丝且与丝丒丟万丁专.丏丝丏业丁万丛上上});
        this.丝且与丝丒丟万丁专.丑丙上丐专丗丑丌丌(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丝且与丝丒丟万丁专.丏丝丏业丁万丛上上});
        this.丝且与丝丒丟万丁专.丘业丗丄专专一一与(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丝且与丝丒丟万丁专.丏丝丏业丁万丛上上});
        this.丝且与丝丒丟万丁专.丁丛丂一丙三上丕与();
        val_2 = 1;
        this.丗丏丅丕丆世丁专丟 = val_2;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丕丄不与丒上丟下三;
        return (bool)val_2;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = 0;
        this.丝且与丝丒丟万丁专.东丞专丌丞丈丅丂业 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 0;
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
