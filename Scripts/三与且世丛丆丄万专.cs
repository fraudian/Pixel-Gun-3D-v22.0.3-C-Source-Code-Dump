using UnityEngine;
private sealed class ClanWarUIRewardsAnimator.三与且世丛丆丄万专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanWarUIRewardsAnimator 丝且与丝丒丟万丁专;
    public System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三;
    public System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 丕丂丗丟专东丌不丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarUIRewardsAnimator.三与且世丛丆丄万专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_5;
        val_3 = 0;
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
                return (bool)val_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Collections.IEnumerator val_1 = this.丝且与丝丒丟万丁专.丝三丘上丂丑丞丗丈(上业丟世三与七七三:  this.上业丟世三与七七三, 且丑丞与七丂且万万:  false);
        val_5 = 1;
        goto label_5;
        label_1:
        val_5 = 0;
        goto label_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PGCompany.ClanWarUIRewardsAnimator.丛三丞丏一丈丁丝三 != null)
        {
                PGCompany.ClanWarUIRewardsAnimator.丛三丞丏一丈丁丝三.Invoke(obj:  1);
        }
        
        val_5 = 2;
        label_5:
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丝三丘上丂丑丞丗丈(上业丟世三与七七三:  this.丕丂丗丟专东丌不丞, 且丑丞与七丂且万万:  true);
        val_3 = 1;
        label_6:
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
