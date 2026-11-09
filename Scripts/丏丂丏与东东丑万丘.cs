using UnityEngine;
private sealed class BatteryWatcher.丏丂丏与东东丑万丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BatteryWatcher 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BatteryWatcher.丏丂丏与东东丑万丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丑丛丘丗三且万丞丌 != null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丑丛丘丗三且万丞丌 = new UnityEngine.WaitForSecondsRealtime(time:  10f);
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.业丘丝业丛丆丄一上 & 1) != 0)
        {
            goto label_6;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        PGCompany.七丙上丛七万且丁丟 val_4 = PGCompany.与一东丘七东丝且丟.丑七不且上丗丁一世().丘丑丗丛下丒丁丙上();
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.世三丞丗丑一丝丏且 = val_4;
            this.丝且与丝丒丟万丁专.三与与丞与丐不丟专();
        }
        else
        {
                mem[32] = val_4;
            0.三与与丞与丐不丟专();
        }
        
        this.丝且与丝丒丟万丁专.不丄万且下与丈丏业();
        label_5:
        if((this.业丘丝业丛丆丄一上 & 1) == 0)
        {
            goto label_14;
        }
        
        label_6:
        val_5 = 0;
        return (bool)val_5;
        label_14:
        val_5 = 1;
        this.丗丏丅丕丆世丁专丟 = val_5;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丑丛丘丗三且万丞丌;
        return (bool)val_5;
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
