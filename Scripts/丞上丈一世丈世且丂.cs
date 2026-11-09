using UnityEngine;
private sealed class Player_move_c.丞上丈一世丈世且丂 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public Player_move_c 丝且与丝丒丟万丁专;
    private Rocket 三且万三万东丝下三;
    public Rocket 丝丁丑丆丟丌丗丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丞上丈一世丈世且丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_8;
        UnityEngine.GameObject val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_12;
        }
        
        val_8 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 > 0f)
        {
            goto label_2;
        }
        
        val_9 = this.丝且与丝丒丟万丁专.丌下不丐丅丗专丙且;
        if(val_9 == 0)
        {
            goto label_12;
        }
        
        if(this.三且万三万东丝下三 == 0)
        {
            goto label_9;
        }
        
        val_9 = this.丝且与丝丒丟万丁专.丌下不丐丅丗专丙且.GetComponent<Rocket>();
        if((val_9.Equals(other:  this.三且万三万东丝下三)) == false)
        {
            goto label_12;
        }
        
        label_9:
        this.丝且与丝丒丟万丁专.丌下不丐丅丗专丙且 = 0;
        this.丝且与丝丒丟万丁专.fpsPlayerBody.SetActive(value:  false);
        BaseCamera val_5 = val_8.丝丙与东丈不丙三丟();
        val_9 = this.丝且与丝丒丟万丁专.myCameraContainer;
        this.丝且与丝丒丟万丁专.gunCamera.gameObject.SetActive(value:  true);
        val_8 = this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_8, 不东丛三丂丌丑专丆:  9);
        label_12:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        float val_7 = UnityEngine.Time.unscaledDeltaTime;
        val_7 = this.丕丕世且下一与丝与 - val_7;
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丕丕世且下一与丝与 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
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
                Player_move_c.丞上丈一世丈世且丂 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丞上丈一世丈世且丂();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .三且万三万东丝下三 = this.丝丁丑丆丟丌丗丕一;
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
