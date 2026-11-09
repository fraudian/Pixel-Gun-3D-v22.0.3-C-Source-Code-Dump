using UnityEngine;
private sealed class 丛丁七东专三丈丕丘.业世丏丗与丆且丘且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丛丁七东专三丈丕丘 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丛丁七东专三丈丕丘.业世丏丗与丆且丘且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 val_2;
        var val_3;
        int val_4;
        var val_5;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_14;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        val_4 = 1;
        this.丗丏丅丕丆世丁专丟 = val_4;
        this.丒上七丌业七丟与丐 = PGCompany.Ads.AdvertisingChestWindowMachinery.丛丁七东专三丈丕丘.丒丑丑下丟丒丒丏丄;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(0 == 0)
        {
            goto label_7;
        }
        
        label_15:
        val_5 = null;
        if(PGCompany.Ads.AdvertisingChestWindowMachinery.丛丁七东专三丈丕丘.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[WatchingState.DelayedPostSkippedEventCoroutine] Posting Skipped event...");
        }
        
        val_2 = this.与且专丈不万东一万;
        val_2.专丌丅不丑丛丘丑丝(丙不不丒丁丄丄与丛:  7);
        goto label_14;
        label_7:
        if(this.丝且与丝丒丟万丁专.丝丝丌丝七上不丁丗 == false)
        {
            goto label_15;
        }
        
        label_14:
        val_4 = 0;
        return (bool)val_4;
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
