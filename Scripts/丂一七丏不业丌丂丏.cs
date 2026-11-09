using UnityEngine;
private sealed class Player_move_c.丂一七丏不业丌丂丏 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丂一七丏不业丌丂丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_17;
        int val_18;
        var val_19;
        float val_20;
        var val_22;
        val_17 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_17 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_18 = 1;
        this.丒上七丌业七丟与丐 = val_17;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(val_17 == null)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_6;
        }
        
        label_17:
        if(this.丝且与丝丒丟万丁专.丝丙七丒且丂丝与丏 == false)
        {
            goto label_16;
        }
        
        object[] val_2 = new object[2];
        val_2[0] = null;
        val_2[1] = 0;
        this.丝且与丝丒丟万丁专.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  21, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        goto label_16;
        label_5:
        if(0 != 0)
        {
            goto label_17;
        }
        
        label_6:
        val_17.丏丞丝上丝丗丁业丅(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0);
        label_16:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_20;
        }
        
        下专世丏丈丞三丗不.丒专丕七丈上业与业(丞丅上丏丂且下丅与:  "LikeID", 丑上丏丙不丆丐丗丌:  1);
        if(val_17 != null)
        {
            goto label_27;
        }
        
        goto label_24;
        label_20:
        if(val_17 != null)
        {
                val_19 = val_17.丐丑专与与丗丗丟丂();
        }
        else
        {
                val_19 = 0.丐丑专与与丗丗丟丂();
        }
        
        val_17.丏与丝三一丕三一下(丙业与丙丗丝不丈东:  val_19 - 1);
        if(val_17 != null)
        {
            goto label_27;
        }
        
        label_24:
        label_27:
        if(val_17.丙不丅丕三丂业东丕() == 0)
        {
            goto label_30;
        }
        
        WeaponSounds val_9 = val_17.丙不丅丕三丂业东丕();
        val_20 = val_9.grenadeThrowTime;
        if(val_17 != null)
        {
            goto label_35;
        }
        
        goto label_34;
        label_30:
        val_20 = 0.2667f;
        if(val_17 != null)
        {
            goto label_35;
        }
        
        label_34:
        label_35:
        var val_19 = 0;
        val_19 = val_19 + 1;
        System.Collections.IEnumerator val_12 = val_17.万丏世丆丁万丏丞丟(丕丕世且下一与丝与:  val_20).GetEnumerator();
        if(val_17 != null)
        {
                UnityEngine.Coroutine val_13 = val_17.StartCoroutine(routine:  val_12);
            val_22 = val_17;
        }
        else
        {
                UnityEngine.Coroutine val_14 = 0.StartCoroutine(routine:  val_12);
            val_22 = 0;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        UnityEngine.Coroutine val_18 = val_22.StartCoroutine(routine:  val_17.丟丑且丗丗东一丘上(丕丕世且下一与丝与:  1f).GetEnumerator());
        label_2:
        val_18 = 0;
        return (bool)val_18;
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
                Player_move_c.丂一七丏不业丌丂丏 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丂一七丏不业丌丂丏();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
