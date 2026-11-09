using UnityEngine;
private sealed class Player_move_c.东三丄丏世丁丒丘上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponSounds 世丏且丂丒丗东丙丁;
    public Player_move_c 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.东三丄丏世丁丒丘上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WeaponSounds val_4;
        WeaponSounds val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        val_4 = this;
        val_5 = this.世丏且丂丒丗东丙丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 == 0)
        {
                return false;
        }
        
        if(this.世丏且丂丒丗东丙丁.countInSeriaBazooka == 0)
        {
                this.世丏且丂丒丗东丙丁.countInSeriaBazooka = 1;
        }
        
        val_6 = this;
        val_5 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_9;
        label_1:
        val_6 = this.丙不丅丌丗上丂丕一;
        val_4 = this.世丏且丂丒丗东丙丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_10;
        label_15:
        this.丝且与丝丒丟万丁专.丆丑丐不丝上七上丝(丌丝下丄业一丄不三:  mem[this.世丏且丂丒丗东丙丁]);
        var val_3 = mem[this.世丏且丂丒丗东丙丁] + 328;
        val_3 = val_3 - 1;
        if(val_6 != val_3)
        {
            goto label_13;
        }
        
        label_10:
        val_5 = val_6 + 1;
        mem2[0] = val_5;
        label_9:
        if(val_5 < (mem[this.世丏且丂丒丗东丙丁] + 328))
        {
            goto label_15;
        }
        
        return false;
        label_13:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  mem[this.世丏且丂丒丗东丙丁] + 300);
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
