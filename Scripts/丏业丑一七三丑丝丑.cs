using UnityEngine;
private sealed class TurretController_HologramProjector.丏业丑一七三丑丝丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretController_HologramProjector 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController_HologramProjector.丏业丑一七三丑丝丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        object val_4;
        int val_5;
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
        
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.世不丆不丅专丁丅万(丝世丏丑专丄丒业丏:  false);
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.世不丆不丅专丁丅万(丝世丏丑专丄丒业丏:  true);
        goto label_7;
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_4:
        0.世不丆不丅专丁丅万(丝世丏丑专丄丒业丏:  false);
        label_5:
        UnityEngine.WaitForSeconds val_1 = null;
        val_4 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.nonGlossTime);
        val_5 = 1;
        goto label_9;
        label_6:
        0.世不丆不丅专丁丅万(丝世丏丑专丄丒业丏:  true);
        label_7:
        UnityEngine.WaitForSeconds val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.glossTime);
        val_5 = 2;
        label_9:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = val_4;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_3;
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
