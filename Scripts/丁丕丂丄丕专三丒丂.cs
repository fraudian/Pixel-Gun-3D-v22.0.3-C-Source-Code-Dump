using UnityEngine;
private sealed class GameEventSetsViewChestContent.丁丕丂丄丕专三丒丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventSetsViewChestContent 丝且与丝丒丟万丁专;
    public Rilisoft.GameEventSetItemView 丑丒丞丑丝丒丂丏丛;
    public int 丅专丑丄不东丈七丂;
    public System.Action 丟丘丙丄丅万丏与丗;
    private int 一丌丒丁专丕丁丙丟;
    private int 丅丛上一丛且业丌丟;
    private Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 万世七三丆丐东丒业;
    private Rilisoft.GameEventSetItemView 七业丛丒世丛上丙丛;
    private Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丕丗上丙且丂丕东丕;
    private int 世丙世且丆丑与专下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewChestContent.丁丕丂丄丕专三丒丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_27;
        var val_28;
        且世丈业丘丆不上丄 val_30;
        int val_31;
        int val_32;
        if(this.丗丏丅丕丆世丁专丟 > 4)
        {
            goto label_1;
        }
        
        var val_27 = 106048384 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_27 = val_27 + 106048384;
        goto (106048384 + (this.丗丏丅丕丆世丁专丟) << 2 + 106048384);
        label_1:
        val_28 = 0;
        return (bool)val_28;
        label_36:
        Rilisoft.GameEventSetItemView val_12 = 丂丄丘专丈业三且丛().Item[this.丅丛上一丛且业丌丟];
        this.七业丛丒世丛上丙丛 = val_12;
        if(val_12 == null)
        {
            goto label_31;
        }
        
        val_27 = public System.Int32 System.Collections.Generic.List<Rilisoft.GameEventSetItemView>::get_Count();
        if(this.丅丛上一丛且业丌丟 < (丂丄丘专丈业三且丛().Count - 1))
        {
                val_32 = this.丅丛上一丛且业丌丟 + 1;
        }
        else
        {
                val_32 = 0;
        }
        
        this.丅丛上一丛且业丌丟 = val_32;
        int val_16 = this.一丌丒丁专丕丁丙丟 - 1;
        this.一丌丒丁专丕丁丙丟 = val_16;
        if((val_16 & 2147483648) == 0)
        {
            goto label_36;
        }
        
        this.万世七三丆丐东丒业 = this.丑丒丞丑丝丒丂丏丛;
        this.世丙世且丆丑与专下 = 0;
        val_30 = this.丑丒丞丑丝丒丂丏丛;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_30 = mem[137150648];
            if(val_30 != 0)
        {
                UnityEngine.AudioSource val_19 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  mem[137150648]);
        }
        
        }
        
        GameEventsHalper val_20 = GameEventsHalper.Instance;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  val_20.animation.spinBlink);
        val_31 = 2;
        this.丗丏丅丕丆世丁专丟 = val_31;
        val_28 = 1;
        return (bool)val_28;
        label_31:
        this.丕丗上丙且丂丕东丕 = this.七业丛丒世丛上丙丛;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(mem[137150648] != 0)
        {
                UnityEngine.AudioSource val_24 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  mem[137150648]);
        }
        
        }
        
        GameEventsHalper val_25 = GameEventsHalper.Instance;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  val_25.animation.spinStep);
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_28;
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
