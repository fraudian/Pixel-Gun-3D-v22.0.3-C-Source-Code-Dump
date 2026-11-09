using UnityEngine;
private sealed class Player_move_c.丟不丏丛丕与丟丕世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丟不丏丛丕与丟丕世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = true;
        this.丝且与丝丒丟万丁专.丑丂丄丌不业三上丏 = val_3;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        AutoFade.三丒下丝东七且七丈(世三丏丑丙丅丌且下:  0.3f, 业三一丆丒与丘且业:  0.3f, 丅世丗丛万下下专丕:  0.1f, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        this.丝且与丝丒丟万丁专.丕丛专丆丝丛丆丌丐();
        goto label_8;
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_7:
        0.丕丛专丆丝丛丆丌丐();
        label_8:
        val_3 = 0;
        this.丝且与丝丒丟万丁专.丑丂丄丌不业三上丏 = false;
        return (bool)val_3;
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
