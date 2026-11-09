using UnityEngine;
private sealed class 丗下丙丅且丐丞丙世.丄专丅一丕丛丂丐丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丟丐丙上丈丙万丂丐;
    public Rilisoft.丗下丙丅且丐丞丙世 丝且与丝丒丟万丁专;
    public float 东丏上东丆丕丂丗不;
    private int 丗丙丝丈丈万丟丝丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丗下丙丅且丐丞丙世.丄专丅一丕丛丂丐丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        OfferModule val_10;
        OfferModule val_11;
        System.Collections.Generic.List<OfferModule> val_12;
        int val_13;
        int val_14;
        var val_15;
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
            goto label_23;
        }
        
        val_10 = this.丟丐丙上丈丙万丂丐;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_10 == 0)
        {
            goto label_23;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_11 = this.丟丐丙上丈丙万丂丐;
        }
        
        val_12 = this.丝且与丝丒丟万丁专;
        val_13 = this.丝且与丝丒丟万丁专.丐丝且丈世与七丐丐.IndexOf(item:  val_11);
        this.丗丙丝丈丈万丟丝丅 = val_13;
        if((val_13 & 2147483648) != 0)
        {
            goto label_23;
        }
        
        if(this.东丏上东丆丕丂丗不 <= 0f)
        {
            goto label_8;
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "OFFERS => update configs start, wait time: \'{0}\'", arg0:  this.东丏上东丆丕丂丗不));
        val_14 = 1;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  this.东丏上东丆丕丂丗不);
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        BalanceController.丙丏丂下丂上七不一();
        goto label_23;
        label_2:
        val_13 = this.丗丙丝丈丈万丟丝丅;
        val_12 = this.丝且与丝丒丟万丁专.丐丝且丈世与七丐丐;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_8:
        val_15 = 0;
        goto label_15;
        label_20:
        OfferModule val_4 = this.丝且与丝丒丟万丁专.丐丝且丈世与七丐丐.SyncRoot.Item[val_13];
        PGCompany.丒丒丛丙不万专三丆 val_5 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        this.丝且与丝丒丟万丁专.丟丈与丕三丐丒丐丑(丗与丟上上丑专世丗:  val_4, 丅业丙丞且丐一丙丆:  val_5.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  val_5.一下丕丒丙丁万丂丆(丕上业丕丘上丘七一:  val_4)));
        val_13 = val_13 + 1;
        val_15 = 1;
        label_15:
        if(val_13 < this.丝且与丝丒丟万丁专.丐丝且丈世与七丐丐.SyncRoot.Count)
        {
            goto label_20;
        }
        
        UnityEngine.Debug.Log(message:  "OFFERS => update configs passed");
        if((val_15 & 1) != 0)
        {
                this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  1f);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_14 = 1;
            return (bool)val_14;
        }
        
        label_23:
        val_14 = 0;
        return (bool)val_14;
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
