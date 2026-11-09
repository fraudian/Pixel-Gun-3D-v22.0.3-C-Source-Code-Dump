using UnityEngine;
private sealed class Player_move_c.一丌丗下且丝丙丕与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.一丌丗下且丝丙丕与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        var val_7;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_4;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        val_6 = 0;
        this.丝且与丝丒丟万丁专.丆万不丄万丘丛丑丁 = false;
        return (bool)val_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_7 = null;
        val_7 = null;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == false)
        {
            goto label_11;
        }
        
        label_15:
        this.丝且与丝丒丟万丁专.丅丐万丛不七丌三丗(丙业与丙丗丝不丈东:  0);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        goto label_13;
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_10:
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == true)
        {
            goto label_15;
        }
        
        label_11:
        var val_7 = 0;
        val_7 = val_7 + 1;
        UnityEngine.Coroutine val_5 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.一丞上丐丈丘丌丄丈(丕丕世且下一与丝与:  0.5f).GetEnumerator());
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.7f);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
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
