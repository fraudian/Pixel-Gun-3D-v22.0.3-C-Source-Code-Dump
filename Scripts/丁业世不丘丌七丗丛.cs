using UnityEngine;
private sealed class ClanWarUIRewardsAnimator.丁业世不丘丌七丗丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanWarUIRewardsAnimator 丝且与丝丒丟万丁专;
    public System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarUIRewardsAnimator.丁业世不丘丌七丗丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        int val_3;
        val_2 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_2;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            val_3 = 1;
            this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丝三丘上丂丑丞丗丈(上业丟世三与七七三:  this.上业丟世三与七七三, 且丑丞与七丂且万万:  true);
            val_2 = 1;
        }
        else
        {
                val_3 = 0;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_3;
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
