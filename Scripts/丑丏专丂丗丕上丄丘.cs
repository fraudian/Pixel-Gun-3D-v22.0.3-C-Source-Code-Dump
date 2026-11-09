using UnityEngine;
private sealed class 丄丄一丐东丐丝丗七.丑丏专丂丗丕上丄丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丄丄一丐东丐丝丗七.丑丏专丂丗丕上丄丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this = this.丙不不丒丁丄丄与丛;
        bool val_1 = this.丝且与丝丒丟万丁专.专丁丞万丂一丙三丗.TryProcessEvent(ev:  this);
        return false;
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
