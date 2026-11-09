using UnityEngine;
private sealed class 丛丁七东专三丈丕丘.一一丆丝丁丝专与一 : IEnumerator<object>, IEnumerator, IDisposable
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
    public 丛丁七东专三丈丕丘.一一丆丝丁丝专与一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        业世丒下丁东丂丏七 val_2;
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        业世丒下丁东丂丏七 val_1 = null;
        val_2 = val_1;
        val_1 = new 业世丒下丁东丂丏七(三七一丁上且丐丝丌:  "DefaultRewardedVideo", 丏七丙不丁丁丒丒丗:  "N/A", 丒专丘丗专丝三丛丘:  0);
        this.丝且与丝丒丟万丁专.三丛专丕丒三丙丅丅(与且专丈不万东一万:  this.与且专丈不万东一万, 且丕丏丗三专七丟丑:  val_1);
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        val_2 = this.与且专丈不万东一万;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丛丆与且丗丅下一一(与且专丈不万东一万:  val_2);
        label_2:
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
