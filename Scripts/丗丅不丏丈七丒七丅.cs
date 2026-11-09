using UnityEngine;
private sealed class Player_move_c.丗丅不丏丈七丒七丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丗丅不丏丈七丒七丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        var val_18;
        float val_19;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆 == true)
        {
                return false;
        }
        
        if(this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟() != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        label_6:
        val_18 = 0;
        goto label_8;
        label_7:
        val_18 = 1;
        label_8:
        val_19 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟().丘丁世业丒丙上丈丗();
        float val_4 = Player_move_c.且丒丗丑万丐丗丅三();
        if(val_19 >= 0)
        {
                val_17 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
            val_19 = Player_move_c.且丒丗丑万丐丗丅三();
            if(val_17 != null)
        {
                return false;
        }
        
            return false;
        }
        
        bool val_17 = this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆;
        val_17 = val_17 + 7;
        var val_18 = ~val_17;
        val_18 = val_18 & 7;
        if(val_18 != 0)
        {
                return false;
        }
        
        BaseCamera val_7 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        float val_14 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟().丘丁世业丒丙上丈丗();
        val_14 = Player_move_c.且丒丗丑万丐丗丅三() - val_14;
        val_14 = val_14 * 10f;
        val_14 = val_14 + 10f;
        float val_16 = UnityEngine.Mathf.MoveTowards(current:  this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟().丘丁世业丒丙上丈丗(), target:  Player_move_c.且丒丗丑万丐丗丅三(), maxDelta:  UnityEngine.Time.deltaTime * val_14);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
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
