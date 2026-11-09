using UnityEngine;
private sealed class ConnectionControl.专丒丙丂上丌丙与专 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public ConnectionControl 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectionControl.专丒丙丂上丌丙与专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_12;
        int val_13;
        var val_14;
        var val_15;
        val_12 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_17;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        val_13 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        this.丝且与丝丒丟万丁专.下丟丈业丂丘丌与万 = false;
        if(this.丝且与丝丒丟万丁专.世丁丒丞丁丕一丟万 != false)
        {
                val_12 = this.丝且与丝丒丟万丁专.丐丝丛丂与专下丝丙;
            bool val_4 = GameConnect.丛三七七丆丄丂丕丈(丐丝丛丂与专下丝丙:  (val_12 == true) ? 1 : 0, 丛丈丑丏与上丄丝丌:  (this.丝且与丝丒丟万丁专.丅万丁丌一世下丐丑 == false) ? 1 : 0);
        }
        else
        {
                val_14 = null;
            val_14 = null;
            if(GameConnect.丛丑世丕丌上丑丂丈 != false)
        {
                bool val_5 = GameConnect.七丑三不丙丄丄东丞(业万上丆丐丞且丒七:  0);
        }
        else
        {
                val_12 = this.丝且与丝丒丟万丁专.丛且丞与丕业下丏丞;
            if(this.丝且与丝丒丟万丁专.丝丞丌丌不业丕七七 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_6 = this.丝且与丝丒丟万丁专.丝丞丌丌不业丕七七.丌不丅不丞东万专专();
            val_14 = null;
            val_15 = ((val_6.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) & ;
        }
        else
        {
                val_15 = 0;
        }
        
            bool val_11 = GameConnect.丆下丅丟下丂一不丙(业万上丆丐丞且丒七:  GameConnect.三东丄丞丛丒丄与万(丞丁丑丏丄丏七丂不:  val_12, 一丅丆丂七与丆丈丂:  false), 丛丈丑丏与上丄丝丌:  true, 丐且丘丑与万丞丑丅:  (this.丝且与丝丒丟万丁专.丝丞丌丌不业丕七七 != 0) ? 1 : 0);
        }
        
        }
        
        label_17:
        val_13 = 0;
        return (bool)val_13;
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
                ConnectionControl.专丒丙丂上丌丙与专 val_2 = null;
            val_4 = val_2;
            val_2 = new ConnectionControl.专丒丙丂上丌丙与专();
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
