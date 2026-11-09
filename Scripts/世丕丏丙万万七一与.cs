using UnityEngine;
private sealed class 丘万上丏丞丆万丈丌.世丕丏丙万万七一与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    private PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌.丒丑万一丁丕东一丗 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丘万上丏丞丆万丈丌.世丕丏丙万万七一与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = this.与且专丈不万东一万;
        if(PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌.三丈与丞上丘专丈丆() == true)
        {
            goto label_3;
        }
        
        if(PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌.世丈且业丆丑丏丐一() == false)
        {
            goto label_8;
        }
        
        UnityEngine.Debug.Log(message:  "[LoadingState.WaitTillCompletedCoroutine] IsRewardedVideoAvailable: false. Waiting...");
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌.三丈与丞上丘专丈丆() == false)
        {
            goto label_8;
        }
        
        label_3:
        PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌.丄丅丂不与东丘丂七(: ref  new 丒丑万一丁丕东一丗() {与且专丈不万东一万 = this.丄丌丂东丘丗一万且});
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_8:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
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
