using UnityEngine;
private sealed class Player_move_c.丛丈三下丟不丆三丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public bool 万东丏丌不七东丘万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丛丈三下丟不丆三丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_7 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丄且丈业上丕七丂丛 == true)
        {
                return false;
        }
        
        if(this.万东丏丌不七东丘万 == false)
        {
            goto label_5;
        }
        
        UnityEngine.Texture2D val_1 = SkinsController.丈三且与上丄丗丙专();
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_7 != null)
        {
                val_7.丅七世丅丑不丏一丈(万丝丑丗不世丕专丁:  0);
        }
        else
        {
                0.丅七世丅丑不丏一丈(万丝丑丗不世丕专丁:  0);
        }
        
        if(this.丝且与丝丒丟万丁专.东丗丒丝丐且丞丄丏 == false)
        {
                return false;
        }
        
        if(this.丝且与丝丒丟万丁专.丑丝丂丗丝丛与不七 == 0)
        {
                return false;
        }
        
        val_7 = this.丝且与丝丒丟万丁专.丑丝丂丗丝丛与不七;
        val_7.世下三上丟七丙丛丛(丁丂丝不丟丛丟一丂:  false, 万东丏丌不七东丘万:  false);
        return false;
        label_5:
        label_8:
        val_7.丅七世丅丑不丏一丈(万丝丑丗不世丕专丁:  SkinsController.丝丕且丐上丁丛三丝());
        if(this.丝且与丝丒丟万丁专.东丗丒丝丐且丞丄丏 != false)
        {
                if(this.丝且与丝丒丟万丁专.丑丝丂丗丝丛与不七 != 0)
        {
                this.丝且与丝丒丟万丁专.丑丝丂丗丝丛与不七.世下三上丟七丙丛丛(丁丂丝不丟丛丟一丂:  true, 万东丏丌不七东丘万:  (this.万东丏丌不七东丘万 == true) ? 1 : 0);
        }
        
        }
        
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.125f);
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
