using UnityEngine;
private sealed class OneChestGameEventView.丟丄三丐丝且丁丄上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝;
    public Rilisoft.OneChestGameEventView 丝且与丝丒丟万丁专;
    public bool 东丆丛东七七丘丐丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OneChestGameEventView.丟丄三丐丝且丁丄上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.OneChestGameEventView val_10;
        Rilisoft.丛且世丐丆上七业丁 val_11;
        int val_12;
        var val_13;
        Rilisoft.丛且世丐丆上七业丁 val_14;
        Rilisoft.丛且世丐丆上七业丁 val_15;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        val_10 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_11 = this.丅东专与不三丂丁丝;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_11.不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  val_11.丄三丐丟丗丄丟上丞().Item[0]);
        if(val_10 != null)
        {
            goto label_10;
        }
        
        goto label_8;
        label_1:
        val_12 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_10 != null)
        {
            goto label_10;
        }
        
        label_8:
        label_10:
        if((val_10 & 1) != 0)
        {
                val_12 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_12;
            return (bool)val_12;
        }
        
        if(this.东丆丛东七七丘丐丘 == false)
        {
            goto label_13;
        }
        
        if(val_10.上丕丌丕丂丘丁丙万() == null)
        {
            goto label_14;
        }
        
        val_13 = this;
        val_14 = val_10.上丕丌丕丂丘丁丙万();
        if(val_14 != this.丅东专与不三丂丁丝)
        {
            goto label_15;
        }
        
        goto label_17;
        label_13:
        val_14 = this.丅东专与不三丂丁丝;
        goto label_17;
        label_14:
        val_15 = this.丅东专与不三丂丁丝;
        label_15:
        val_11 = mem[this.丅东专与不三丂丁丝];
        if(val_10.上丕丌丕丂丘丁丙万() != null)
        {
                this.丝且与丝丒丟万丁专.丝业世丈世不丈丈丞 = val_11;
            this.丒上七丌业七丟与丐 = val_10.StartCoroutine(routine:  val_10.丞三丝丒丂专不丁专(丈丄丂丈丆丑丞专丌:  val_11.下一三万丝丟丐丒丆()));
            this.丗丏丅丕丆世丁专丟 = 2;
            val_12 = 1;
            return (bool)val_12;
        }
        
        val_14 = val_11;
        label_17:
        val_10.东丟万下不七丙且东(丙业与丙丗丝不丈东:  val_14);
        val_10.下与丞三丅丛丄七丕();
        val_10.UpdateSpinButtonsAndChests();
        label_3:
        val_12 = 0;
        return (bool)val_12;
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
