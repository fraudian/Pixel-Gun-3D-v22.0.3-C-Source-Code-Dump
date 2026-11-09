using UnityEngine;
private sealed class GameEventSetsViewChestContentField.丝与丄丗一丆丆丝丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 专丌丏世丐丛丗丝丂;
    public int 丗丏丑丁万东丆丝丝;
    public Rilisoft.GameEventSetsViewChestContentField 丝且与丝丒丟万丁专;
    public bool 丅与丅丝丈世丑丐丗;
    private int 一丌丒丁专丕丁丙丟;
    private int 丅丛上一丛且业丌丟;
    private Rilisoft.GameEventSetItemView 丗一业丕万且丛丟专;
    private Rilisoft.GameEventSetItemView 七业丛丒世丛上丙丛;
    private Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丕丗上丙且丂丕东丕;
    private bool 丁与丛丒三丟下丄丄;
    private UnityEngine.WaitForSecondsRealtime 丝丒丌丙丏世丂丅丄;
    private int 丐且丈丂丁丏三一丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewChestContentField.丝与丄丗一丆丆丝丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_24;
        int val_26;
        且世丈业丘丆不上丄 val_29;
        UnityEngine.WaitForSecondsRealtime val_30;
        int val_31;
        int val_32;
        val_24 = 0;
        if(this.丗丏丅丕丆世丁专丟 > 4)
        {
                return (bool)val_24;
        }
        
        var val_21 = 106048460;
        val_21 = (106048460 + (this.丗丏丅丕丆世丁专丟) << 2) + val_21;
        goto (106048460 + (this.丗丏丅丕丆世丁专丟) << 2 + 106048460);
        label_22:
        Rilisoft.GameEventSetItemView val_5 = Item[0];
        this.七业丛丒世丛上丙丛 = val_5;
        if(val_5 == null)
        {
            goto label_16;
        }
        
        if( < (this.丝且与丝丒丟万丁专.丂丄丘专丈业三且丛().Count - 1))
        {
                val_32 = 1;
        }
        else
        {
                val_32 = 0;
        }
        
        this.丅丛上一丛且业丌丟 = val_32;
        val_26 =  - 1;
        this.一丌丒丁专丕丁丙丟 = val_26;
        if((val_26 & 2147483648) == 0)
        {
            goto label_22;
        }
        
        val_29 = this.丝且与丝丒丟万丁专.丂丄丘专丈业三且丛().Item[this.专丌丏世丐丛丗丝丂];
        this.丗一业丕万且丛丟专 = val_29;
        if(this.丅与丅丝丈世丑丐丗 == false)
        {
            goto label_25;
        }
        
        this.丕丗上丙且丂丕东丕 = this.丗一业丕万且丛丟专;
        this.丝丒丌丙丏世丂丅丄 = new UnityEngine.WaitForSecondsRealtime(time:  0.07f);
        this.丐且丈丂丁丏三一丟 = 0;
        val_29 = this.丗一业丕万且丛丟专;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_29 = this.丝且与丝丒丟万丁专._spinClip;
            if(val_29 != 0)
        {
                UnityEngine.AudioSource val_14 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专._spinClip);
        }
        
        }
        
        val_30 = this.丝丒丌丙丏世丂丅丄;
        val_31 = 2;
        goto label_53;
        label_16:
        this.丕丗上丙且丂丕东丕 = this.七业丛丒世丛上丙丛;
        this.丁与丛丒三丟下丄丄 = this.七业丛丒世丛上丙丛 & 1;
        val_29 = this.七业丛丒世丛上丙丛;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_29 = this.丝且与丝丒丟万丁专._spinClip;
            if(val_29 != 0)
        {
                UnityEngine.AudioSource val_18 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专._spinClip);
        }
        
        }
        
        GameEventsHalper val_19 = GameEventsHalper.Instance;
        丕世专丒丁不丁丅丁 val_20 = null;
        val_30 = val_20;
        val_20 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  val_19.animation.diceStep);
        val_31 = 1;
        goto label_53;
        label_25:
        val_30 = 0;
        val_31 = 4;
        label_53:
        val_24 = 1;
        this.丒上七丌业七丟与丐 = val_30;
        this.丗丏丅丕丆世丁专丟 = val_31;
        return (bool)val_24;
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
