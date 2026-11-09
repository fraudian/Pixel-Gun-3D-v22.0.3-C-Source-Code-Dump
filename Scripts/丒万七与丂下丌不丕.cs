using UnityEngine;
private sealed class PiggyOffersLobby.丒万七与丂下丌不丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Piggy.PiggyOffersLobby 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PiggyOffersLobby.丒万七与丂下丌不丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
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
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._headerTime != 0)
        {
            goto label_7;
        }
        
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        long val_2 = PGCompany.Piggy.业世且丐丕专丛专丐.<不丁丄七丛不丆丁丕>k__BackingField.七三不业三丕丈丅丈();
        if(this.丝且与丝丒丟万丁专._headerTime != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        this.丝且与丝丒丟万丁专._headerTime.丈且东丑丂且万丒丅(丂三丟丂丈丐丆丗丟:  val_2);
        if(val_2 <= 0)
        {
            goto label_14;
        }
        
        label_18:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  1f);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_14:
        if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
            goto label_18;
        }
        
        this.丝且与丝丒丟万丁专.丟丁东丘丝丙丑上万 = 0;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
        label_7:
        long val_5 = PGCompany.Piggy.业世且丐丕专丛专丐.<不丁丄七丛不丆丁丕>k__BackingField.七三不业三丕丈丅丈();
        if(this.丝且与丝丒丟万丁专._headerTime != null)
        {
            goto label_21;
        }
        
        goto label_22;
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
