using UnityEngine;
private sealed class Player_move_c.丅丘与丒丐东丁丐上 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private UnityEngine.GameObject 下且丆万丝丂丏丛丌;
    public UnityEngine.GameObject 丐世丝丂上丄专专一;
    private float 万上丆世东万丕丒丌;
    public float 丘丘专世业三丒不丟;
    private float 丁上不丘丅丈七且丏;
    public float 丏不丒一东丌丅丗丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丅丘与丒丐东丁丐上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_6;
        UnityEngine.GameObject val_7;
        int val_8;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_19;
        }
        
        val_7 = val_6;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.下且丆万丝丂丏丛丌 == 0)
        {
            goto label_19;
        }
        
        if(this.万上丆世东万丕丒丌 <= 0f)
        {
            goto label_7;
        }
        
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.万上丆世东万丕丒丌);
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        val_7 = this.下且丆万丝丂丏丛丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_15;
        label_2:
        val_7 = this.下且丆万丝丂丏丛丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        if(mem[this.下且丆万丝丂丏丛丌] == 0)
        {
            goto label_19;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[this.下且丆万丝丂丏丛丌], 丏业丟一东丂东丘丛:  true);
        if(this.丁上不丘丅丈七且丏 > 0f)
        {
                this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丁上不丘丅丈七且丏);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_8 = 1;
            return (bool)val_8;
        }
        
        label_15:
        val_6 = mem[this.下且丆万丝丂丏丛丌];
        if(val_6 != 0)
        {
                val_6 = mem[this.下且丆万丝丂丏丛丌];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
        }
        
        label_19:
        val_8 = 0;
        return (bool)val_8;
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
        UnityEngine.GameObject val_4;
        var val_5;
        if((this.丗丏丅丕丆世丁专丟 != 2) || (this.丈世三丐万且丅上丈 != System.Environment.CurrentManagedThreadId))
        {
            goto label_2;
        }
        
        val_4 = this.丐世丝丂上丄专专一;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this;
        goto label_3;
        label_2:
        Player_move_c.丅丘与丒丐东丁丐上 val_2 = null;
        val_5 = val_2;
        val_2 = new Player_move_c.丅丘与丒丐东丁丐上();
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        val_4 = this.丐世丝丂上丄专专一;
        if(val_5 == null)
        {
            goto label_4;
        }
        
        label_3:
        .下且丆万丝丂丏丛丌 = val_4;
        .万上丆世东万丕丒丌 = this.丘丘专世业三丒不丟;
        .丁上不丘丅丈七且丏 = this.丏不丒一东丌丅丗丁;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_5;
        label_4:
        mem[40] = val_4;
        mem[56] = this.丘丘专世业三丒不丟;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
