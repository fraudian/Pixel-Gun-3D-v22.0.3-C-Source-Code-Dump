using UnityEngine;
private sealed class Player_move_c.丗丈丗丐丏丏丄与丐 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丟丙丏三丞不丅专丆;
    public float 丛一东业专且丛丝丂;
    private UnityEngine.Vector3 一丄丘丑丝丗丁业丅;
    public UnityEngine.Vector3 丘东上与万丝丛三丐;
    private UnityEngine.Vector3 世丁丈东世不丕专丄;
    public UnityEngine.Vector3 丄七丗一七丆丆丁世;
    private string 丑丌丞东业丝丑下丈;
    public string 丈丘丂丆丅丅丟万与;
    private float 丏丂丕上丙丁丕丄丏;
    public float 上丂丒万业业世不丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丗丈丗丐丏丏丄与丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = this.丟丙丏三丞不丅专丆;
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_3);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        val_3 = this.一丄丘丑丝丗丁业丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.GameObject val_2 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_3, y = V9.16B, z = V10.16B}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = this.世丁丈东世不丕专丄, y = V13.16B, z = V12.16B}, 丛丄万三丂东丙丑东:  this.丑丌丞东业丝丑下丈, 不丅丛专丘丅专丘丕:  this.丏丂丕上丙丁丕丄丏);
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
        string val_5;
        float val_6;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.丗丈丗丐丏丏丄与丐 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丗丈丗丐丏丏丄与丐();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        }
        
        .一丄丘丑丝丗丁业丅 = this.丘东上与万丝丛三丐;
        mem[1152921535876237616] = ???;
        mem[1152921535876237620] = ???;
        .世丁丈东世不丕专丄 = this.丄七丗一七丆丆丁世;
        mem[1152921535876237640] = ???;
        mem[1152921535876237644] = ???;
        val_5 = this.丈丘丂丆丅丅丟万与;
        if(val_4 != null)
        {
                .丑丌丞东业丝丑下丈 = val_5;
            .丏丂丕上丙丁丕丄丏 = this.上丂丒万业业世不丞;
            val_6 = this.丛一东业专且丛丝丂;
        }
        else
        {
                mem[96] = val_5;
            val_5 = this.上丂丒万业业世不丞;
            mem[112] = val_5;
            val_6 = this.丛一东业专且丛丝丂;
        }
        
        .丟丙丏三丞不丅专丆 = val_6;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
