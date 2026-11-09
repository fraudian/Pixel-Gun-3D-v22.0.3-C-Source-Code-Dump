using UnityEngine;
private sealed class 丘万上丏丞丆万丈丌.三专丆丁丞丗丈丌丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丘万上丏丞丆万丈丌.三专丆丁丞丗丈丌丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  V8.16B);
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(0 != 0)
        {
                val_2 = this.与且专丈不万东一万;
            val_2.专丌丅不丑丛丘丑丝(丙不不丒丁丄丄与丛:  4);
        }
        
        label_7:
        val_3 = 0;
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
