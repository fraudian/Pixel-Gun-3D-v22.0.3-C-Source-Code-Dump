using UnityEngine;
private sealed class PlayerBotsManager.不丕丐三丝且世丕业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBotsManager 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerBotsManager.不丕丐三丝且世丕业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        object val_16;
        int val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        float val_23;
        var val_24;
        int val_25;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_38:
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                val_16 = 0;
            val_17 = 1;
        }
        else
        {
                UnityEngine.WaitForSeconds val_2 = null;
            val_16 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.不丐丞专丆东丘东东);
            val_17 = 2;
        }
        
        val_18 = 1;
        this.丒上七丌业七丟与丐 = val_16;
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = null;
        val_19 = null;
        int val_3 = 丘丑丅三丆丑丌且丝();
        val_20 = null;
        val_20 = null;
        val_21 = 0;
        val_22 = 0f;
        val_23 = 0f;
        goto label_20;
        label_26:
        int val_5 = Item[0].丘丑丅三丆丑丌且丝();
        float val_15 = (float)Item[0].丑丛丆三丆丄七丐万();
        val_15 = val_23 + val_15;
        val_22 = (val_5 == val_3) ? (val_22) : (val_22 + val_15);
        val_23 = (val_5 == val_3) ? (val_15) : (val_23);
        val_21 = 1;
        label_20:
        if(val_21 < Count)
        {
            goto label_26;
        }
        
        val_15 = val_22 + val_23;
        if(val_15 < 0)
        {
            goto label_38;
        }
        
        val_22 = val_23 / val_22;
        if(this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Count < 1)
        {
            goto label_38;
        }
        
        val_24 = 0;
        val_25 = 0;
        goto label_33;
        label_37:
        float val_16 = this.丝且与丝丒丟万丁专.丘专下与三丗丝丝丁[0];
        val_24 = 1;
        val_25 = val_25 + (((UnityEngine.Mathf.Min(a:  val_22, b:  val_22 / val_23)) < 0) ? 1 : 0);
        label_33:
        if(val_24 < this.丝且与丝丒丟万丁专.丘专下与三丗丝丝丁.Length)
        {
            goto label_37;
        }
        
        this.丝且与丝丒丟万丁专.丘不专丘不专丙万世(万丙丆不下一丐且丆:  val_25, 丗东世不丙丁丞世丛:  (val_22 < 0) ? 1 : 0, 丁丞丗业丆丒上丈丞:  val_3);
        goto label_38;
        label_3:
        val_18 = 0;
        return (bool)val_18;
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
