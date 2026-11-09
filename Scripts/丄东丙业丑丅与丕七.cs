using UnityEngine;
private sealed class Player_move_c.丄东丙业丑丅与丕七 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
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
    public Player_move_c.丄东丙业丑丅与丕七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FirstPersonControlSharp val_4;
        int val_5;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_18;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 != true)
        {
                this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.世丟丈丏丕万丝丆万.enabled = true;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = null;
        this.丝且与丝丒丟万丁专.photonViewGroup0.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  47, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        this.丝且与丝丒丟万丁专.东三不一丂丈丕丝上 = 0;
        val_4 = this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl;
        if(val_4.丌丙丁丝七丕丐上丛() != false)
        {
                val_4 = this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl;
            val_4.上且丈丒与专上丝业(丆丝下丒上一丙丄丞:  1);
        }
        
        label_18:
        val_5 = 0;
        return (bool)val_5;
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
        this = new Player_move_c.丄东丙业丑丅与丕七();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
