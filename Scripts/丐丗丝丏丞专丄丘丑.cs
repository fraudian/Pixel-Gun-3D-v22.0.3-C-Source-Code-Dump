using UnityEngine;
private sealed class RewardWindowBase.丐丗丝丏丞专丄丘丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardWindowBase 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardWindowBase.丐丗丝丏丞专丄丘丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.IDictionary<System.String, System.Object> val_4;
        RewardWindowBase val_5;
        var val_6;
        int val_7;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_4;
        label_1:
        int val_4 = this.丙不丅丌丗上丂丕一;
        val_5 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = val_4 + 1;
        this.丙不丅丌丗上丂丕一 = val_4;
        if(val_4 < 2)
        {
            goto label_4;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "Show Event", value:  this.丝且与丝丒丟万丁专.<丝且万丁丐丄丌丕与>k__BackingField);
        if((this.丝且与丝丒丟万丁专.丕丒丁丒丏一丌上东 != true) && (TwitterController.上业丗丛三丕丒丗丙() != false))
        {
                val_6 = null;
            val_6 = null;
            val_5 = this.丝且与丝丒丟万丁专.与丂与丗与丁专丏丄;
            if((TwitterController.丗丘丒丈专丘丕世与.不专下丒丌丒三丂丄(与丈丂一丌三丈丟丅:  val_5)) != false)
        {
                val_1.Add(key:  "Total Twitter", value:  "Shows");
        }
        
        }
        
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Virality", 丛东不丒丏丈丄且丕:  val_1);
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        val_7 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
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
