using UnityEngine;
private sealed class Player_move_c.丕且丆丒七七丟丛丗 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丕且丆丒七七丟丛丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        var val_10;
        int val_11;
        var val_12;
        float val_13;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_14;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_7;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        val_9 = this.丝且与丝丒丟万丁专.丙丙丟世丌且丑丅丘();
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.与丙丕丛一丌丛丆丈.Destroy();
        this.丝且与丝丒丟万丁专.上上丘一丁下丕上与(丙业与丙丗丝不丈东:  0f);
        this.丝且与丝丒丟万丁专.丑世丗丙丞世丙世丙(丝丟业一丞丈丂丟丐:  true);
        val_8 = 1152921505171275776;
        val_10 = null;
        val_10 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                this.丝且与丝丒丟万丁专.丏丞丅丑丁丅上丗不(丐丟丘世丁三丕专专:  1);
        }
        
        label_14:
        val_11 = 0;
        return (bool)val_11;
        label_8:
        val_9 = 0.丙丙丟世丌且丑丅丘();
        label_9:
        val_9.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.fallPlayerSound);
        label_7:
        val_12 = null;
        val_12 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                label_25:
            val_13 = 0.3f;
        }
        else
        {
                val_13 = 1f;
            if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                if(SpeedrunTrackController.丛专与丅下丌丆世丒.canRespawn == true)
        {
            goto label_25;
        }
        
        }
        
        }
        
        val_11 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_13);
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Player_move_c.丕且丆丒七七丟丛丗();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
