using UnityEngine;
private sealed class Player_move_c.万丘丂上丛万丗丆七 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private float 丂下丄下丈下七专上;
    public float 丕七丈丆丏丈三业丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.万丘丂上丛万丗丆七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        float val_6;
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.业丒丏丘一丌丄丞丞 = true;
        this.丝且与丝丒丟万丁专.丅东业上一丕丐丂丒 = UnityEngine.Time.realtimeSinceStartup;
        val_5 = this;
        val_6 = this.丂下丄下丈下七专上;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        goto label_6;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_3:
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_5 = this;
        val_6 = this.丂下丄下丈下七专上;
        label_4:
        this.丝且与丝丒丟万丁专.万业七万丐万丁一下 = val_6;
        if(val_6 > 0f)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_6);
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        label_8:
        this.丝且与丝丒丟万丁专.业丒丏丘一丌丄丞丞 = false;
        label_6:
        val_7 = 0;
        this.丝且与丝丒丟万丁专.下上丐丙丁丝不上丆 = 0;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.万丘丂上丛万丗丆七 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.万丘丂上丛万丗丆七();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丂下丄下丈下七专上 = this.丕七丈丆丏丈三业丒;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
