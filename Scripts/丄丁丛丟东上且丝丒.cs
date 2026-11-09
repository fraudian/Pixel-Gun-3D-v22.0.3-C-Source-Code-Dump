using UnityEngine;
private sealed class Player_move_c.丄丁丛丟东上且丝丒 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private string 丝三丛且丘不丌丙下;
    public string 上丌丘丈专丈丏丘丗;
    private int[] 丛下不丛与万丏丒丕;
    public int[] 丌丆丕丙且专七丝丌;
    private float[] 三丈丑丗丘丂丆丐七;
    public float[] 丕丐专丕丑与丒专且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丄丁丛丟东上且丝丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_7;
        UnityEngine.Object val_8;
        int val_9;
        string val_10;
        SkinName val_11;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_9;
        }
        
        val_7 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丆上丛世丌丕丙一丗 != null)
        {
            goto label_3;
        }
        
        val_8 = val_7.丙不丅丕三丂业东丕();
        if(val_8 != 0)
        {
            goto label_6;
        }
        
        label_3:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_6:
        val_8 = val_7.丙不丅丕三丂业东丕();
        if((System.String.op_Inequality(a:  val_8.三与丛丑且丐丈业丌(), b:  this.丝三丛且丘不丌丙下)) == true)
        {
            goto label_9;
        }
        
        WeaponSounds val_6 = val_7.丙不丅丕三丂业东丕();
        万世专丘且万世七丒.专丞丈万丂万丘专一(与上丌丅七丒丗丑丅:  val_6.三世丗丆丕万丐且三, 丛下不丛与万丏丒丕:  this.丛下不丛与万丏丒丕, 丅丝丕丌丘丆丁丂业:  this.三丈丑丗丘丂丆丐七);
        val_8 = this.丝且与丝丒丟万丁专.mySkinName;
        if(val_8 == null)
        {
            goto label_13;
        }
        
        val_10 = this.丝且与丝丒丟万丁专.mySkinName.丌专专万丟业与丂东;
        val_11 = val_8;
        goto label_16;
        label_13:
        val_11 = this.丝且与丝丒丟万丁专.mySkinName;
        val_10 = this.丝且与丝丒丟万丁专.mySkinName.丌专专万丟业与丂东;
        if(val_11 == null)
        {
            goto label_15;
        }
        
        val_8 = val_11;
        goto label_16;
        label_15:
        val_8 = this.丝且与丝丒丟万丁专.mySkinName;
        if(val_8 == null)
        {
            goto label_17;
        }
        
        label_16:
        val_7.丒丝丛丗丁三丅一与(丌专专万丟业与丂东:  val_10, 与丁丝七丕业业丄且:  this.丝且与丝丒丟万丁专.mySkinName.与丁丝七丕业业丄且, 丁丅上丟丑三且且丆:  this.丝且与丝丒丟万丁专.mySkinName.丁丅上丟丑三且且丆);
        val_7.丛丒丙下丕丘丑丂三();
        label_9:
        val_9 = 0;
        return (bool)val_9;
        label_17:
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
                Player_move_c.丄丁丛丟东上且丝丒 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丄丁丛丟东上且丝丒();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丝三丛且丘不丌丙下 = this.上丌丘丈专丈丏丘丗;
        .丛下不丛与万丏丒丕 = this.丌丆丕丙且专七丝丌;
        .三丈丑丗丘丂丆丐七 = this.丕丐专丕丑与丒专且;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
