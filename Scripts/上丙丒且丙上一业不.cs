using UnityEngine;
private sealed class Player_move_c.上丙丒且丙上一业不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.上丙丒且丙上一业不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_4 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  1f);
        val_5 = 1;
        this.丒上七丌业七丟与丐 = val_4;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        val_4 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4.万丙丘丗丆业丐万世(丆与丈丏丟七丁东丛:  val_4.丙不丅丕三丂业东丕().丆丛专丑丘专丌不且(), 丛丝丗不丞丛丕七丏:  true, 与丁万东丌丑下丏丕:  1f, 七丗专上丄丙丝上丁:  true);
        label_2:
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

}
